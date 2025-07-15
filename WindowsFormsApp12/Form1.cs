using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Maas"].Points.Add(1000);
            chart1.Series["Maas"].Points[0].Color = Color.Orange;
            chart1.Series["Maas"].Points[0].LegendText = "Ali";
            chart1.Series["Maas"].Points[0].Label = "1000";


            chart1.Series["Maas"].Points.Add(3000);
            chart1.Series["Maas"].Points[1].Color = Color.Gray;
            chart1.Series["Maas"].Points[1].LegendText = "Ayşe";
            chart1.Series["Maas"].Points[1].Label = "5000";



            chart1.Series["Maas"].Points.Add(1000);
            chart1.Series["Maas"].Points[2].Color = Color.Purple;
            chart1.Series["Maas"].Points[2].LegendText = "Ahmet";
            chart1.Series["Maas"].Points[2].Label = "1500";


            chart1.Series["Maas"].Points.Add(2000);
            chart1.Series["Maas"].Points[3].Color = Color.Pink;
            chart1.Series["Maas"].Points[3].LegendText = "Mehmet";
            chart1.Series["Maas"].Points[3].Label = "2000";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1, sayi2, sonuc;

                sayi1 = Convert.ToInt16(textBox1.Text);
                sayi2 = Convert.ToInt16(textBox2.Text);

                sonuc = sayi1 + sayi2;
                textBox3.Text = sonuc.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lutfen sayisal deger giriniz !!!", "UYARİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Lutfen daha kucuk deger giriniz !!!", "UYARİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            finally
            {
                MessageBox.Show("Finally blok yapısına ait kod çalıştı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
