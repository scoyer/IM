﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class setting : Form
    {
        
        private LinkWithServer lws;
        
        public setting()
        {
            InitializeComponent();
        }
        
        public setting(LinkWithServer LWS)
        {
            this.lws = LWS;
            InitializeComponent();
            textBox1.Text = lws.hostname;
            textBox2.Text = lws.port.ToString();
        }
        /*
        private delegate void ChangeTextBox1Delegate(string str);
        public void ChangeTextBox1(string msg)
        {
            if (textBox1.InvokeRequired)
            {
                ChangeTextBox1Delegate add = ChangeTextBox1;
                textBox1.Invoke(add, msg);
            }
            else
            {
                textBox1.Text = msg;
            }
        }

        private delegate void ChangeTextBox2Delegate(string str);
        public void ChangeTextBox2(string msg)
        {
            if (textBox2.InvokeRequired)
            {
                ChangeTextBox2Delegate add = ChangeTextBox2;
                textBox2.Invoke(add, msg);
            }
            else
            {
                textBox2.Text = msg;
            }
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            lws.hostname = textBox1.Text;
            lws.port = int.Parse(textBox2.Text);
            this.Close();
        }
         
    }
}
