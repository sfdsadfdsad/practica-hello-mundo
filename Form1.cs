using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_hello_mundo
{
    public partial class Helo_Mundo : Form
    {
        public Helo_Mundo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Hello, " + textBox1.Text + "!";
        }
    }
}
