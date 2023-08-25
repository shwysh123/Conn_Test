using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _01BASIC
{
    public partial class winform : Form
    {   
        private SerialPort serialPort = new SerialPort();
        public winform()
        {
            InitializeComponent();
        }
        private void PortNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void SerialPort_DataRecv(object sender, SerialDataReceivedEventArgs e)
        {
            String recvData = this.serialPort.ReadExisting();
            Console.WriteLine(recvData);
        }

       


        private void conn_btn_Click(object sender, EventArgs e)
        {
            string selectedPortName = this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString();
            Console.WriteLine(selectedPortName + " CONN");
            label2.Text = selectedPortName + " CONN";
            try
            {
                this.serialPort.PortName = selectedPortName;
                this.serialPort.BaudRate = 9600;
                this.serialPort.DataBits = 8;
                this.serialPort.StopBits = System.IO.Ports.StopBits.One;
                this.serialPort.Parity = System.IO.Ports.Parity.None;
                this.serialPort.Open();
                this.serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataRecv);
            }
            catch
            {
                this.serialPort.Close();
            }

        } 
        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine(button1.Text + " CLICKED");
            label2.Text = button1.Text+" SUCCESS";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(button2.Text + " CLICKED");
            label2.Text = button2.Text + " SUCCESS";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(button3.Text + " CLICKED");
            label2.Text = button3.Text + " SUCCESS";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine(button4.Text + " CLICKED");
            label2.Text = button4.Text + " SUCCESS";
        }
    }
}
