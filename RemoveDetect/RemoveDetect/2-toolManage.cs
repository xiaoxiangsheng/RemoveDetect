﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RemoveDetect
{
    public partial class _2_toolManage : Form
    {
        public _2_toolManage()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(showform);
            thread.IsBackground = false;
            thread.Start();
        }
        void showform()
        {
            Application.Run(new _1_menuList());
        }

        private void exit_Click(object sender, EventArgs e)
        {
            _1_menuLogout exit = new _1_menuLogout();
            exit.ShowDialog(this);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(showform1);
            thread.IsBackground = false;
            thread.Start();
        }
        void showform1()
        {
            Application.Run(new _2_toolAdd());
        }
    }
}
