using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yasi = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Python";
            kurs1.KursEgitmeni = "Engin Demirog";
            kurs1.IzlenmeOrani = 86;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.KursEgitmeni = "Mustafa Murat Çoşkun";
            kurs2.IzlenmeOrani = 76;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.KursEgitmeni);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursEgitmeni);
            }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
