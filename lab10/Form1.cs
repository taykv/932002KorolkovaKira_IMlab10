using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class player6 : Form
    {
        public player6()
        {
            InitializeComponent();
        }

        int[] playerStats = { 6, 5, 7, 5, 13, 11, 9, 8, 7, 10, 11, 9, 12, 5, 14, 13 };
        string[] playerNames =
        {
            "Италия",
            "Испания",
            "США",
            "Япония",
            "Сев. Корея",
            "Португалия",
            "Польша",
            "Сербия",
            "Украина",
            "Франция",
            "Уэльс",
            "Бразилия",
            "Белоруссия",
            "Мексика",
            "Россия",
            "Канада"
        };

        int[] playerScore = new int[16];

        int[] quarter = new int[8];
        string[] quarterNames = new string[8];

        int[] semi = new int[4];
        string[] semiNames = new string[4];

        int[] finale = new int[2];
        string[] finaleNames = new string[2];

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Старт")
            {
                for (int i = 0; i < playerScore.Length; i++)
                    playerScore[i] = 0;

                button1.Text = "Четвертьфинал";

                Random rand = new Random();
                for (int i = 0; i < playerStats.Length; i++)
                {
                    int m = 0;
                    double S = 0;
                    while (S >= -playerStats[i])
                    {
                        S += Math.Log(rand.NextDouble());
                        m++;
                    }
                    playerScore[i] = m;

                    if ((i % 2) == 1 && i > 0)
                    {
                        if (playerScore[i] == playerScore[i - 1])
                        {
                            while (playerScore[i] == playerScore[i - 1])
                            {
                                for (int j = 0; j < 2; j++)
                                {
                                    int mm = 0;
                                    double SS = 0;
                                    while (SS >= -playerStats[i])
                                    {
                                        SS += Math.Log(rand.NextDouble());
                                        mm++;
                                    }
                                    playerScore[i] = mm;
                                }
                            }
                        }
                    }
                }
                player1.Text = player1.Text + " " + playerScore[0];
                player2.Text = player2.Text + " " + playerScore[1];
                player3.Text = player3.Text + " " + playerScore[2];
                player4.Text = player4.Text + " " + playerScore[3];
                player5.Text = player5.Text + " " + playerScore[4];
                player66.Text = player66.Text + " " + playerScore[5];
                player7.Text = player7.Text + " " + playerScore[6] ;
                player8.Text = player8.Text + " " + playerScore[7];
                player9.Text = playerScore[8] + " " + player9.Text;
                player10.Text = playerScore[9] + " " + player10.Text;
                player11.Text = playerScore[10] + " " + player11.Text;
                player12.Text = playerScore[11] + " " + player12.Text;
                player13.Text = playerScore[12] + " " + player13.Text;
                player14.Text = playerScore[13] + " " + player14.Text;
                player15.Text = playerScore[14] + " " + player15.Text;
                player16.Text = playerScore[15] + " " + player16.Text;

                int k = 0;

                for (int i = 0; i < 16; i+=2)
                {
                    if (playerScore[i] > playerScore[i + 1])
                    {
                        quarter[k] = playerStats[i];
                        quarterNames[k] = playerNames[i];
                    }
                    else
                    {
                        quarter[k] = playerStats[i + 1];
                        quarterNames[k] = playerNames[i + 1];
                    }
                    k++;
                }

                quarter1.Text = quarterNames[0];
                quarter2.Text = quarterNames[1];
                quarter3.Text = quarterNames[2];
                quarter4.Text = quarterNames[3];
                quarter5.Text = quarterNames[4];
                quarter6.Text = quarterNames[5];
                quarter7.Text = quarterNames[6];
                quarter8.Text = quarterNames[7];

            }
            else if (button1.Text == "Четвертьфинал")
            {
                button1.Text = "Полуфинал";

                Random rand = new Random();
                for (int i = 0; i < quarter.Length; i++)
                {
                    int m = 0;
                    double S = 0;
                    while (S >= -quarter[i])
                    {
                        S += Math.Log(rand.NextDouble());
                        m++;
                    }
                    playerScore[i] = m;

                    if ((i % 2) == 1 && i > 0)
                    {
                        if (playerScore[i] == playerScore[i - 1])
                        {
                            while (playerScore[i] == playerScore[i - 1])
                            {
                                for (int j = 0; j < 2; j++)
                                {
                                    int mm = 0;
                                    double SS = 0;
                                    while (SS >= -quarter[i])
                                    {
                                        SS += Math.Log(rand.NextDouble());
                                        mm++;
                                    }
                                    playerScore[i] = mm;
                                }
                            }
                        }
                    }
                }

                quarter1.Text = quarterNames[0] + " " + playerScore[0];
                quarter2.Text = quarterNames[1] + " " + playerScore[1];
                quarter3.Text = quarterNames[2] + " " + playerScore[2];
                quarter4.Text = quarterNames[3] + " " + playerScore[3];
                quarter5.Text = playerScore[4] + " " + quarterNames[4];
                quarter6.Text = playerScore[5] + " " + quarterNames[5];
                quarter7.Text = playerScore[6] + " " + quarterNames[6];
                quarter8.Text = playerScore[7] + " " + quarterNames[7];

                int k = 0;

                for (int i = 0; i < 8; i += 2)
                {
                    if (playerScore[i] > playerScore[i + 1])
                    {
                        semi[k] = quarter[i];
                        semiNames[k] = quarterNames[i];
                    }
                    else
                    {
                        semi[k] = quarter[i + 1];
                        semiNames[k] = quarterNames[i + 1];
                    }
                    k++;
                }

                semi1.Text = semiNames[0];
                semi2.Text = semiNames[1];
                semi3.Text = semiNames[2];
                semi4.Text = semiNames[3];
            }
            else if (button1.Text == "Полуфинал")
            {
                button1.Text = "Финал";

                Random rand = new Random();
                for (int i = 0; i < semi.Length; i++)
                {
                    int m = 0;
                    double S = 0;
                    while (S >= -semi[i])
                    {
                        S += Math.Log(rand.NextDouble());
                        m++;
                    }
                    playerScore[i] = m;
                    if ((i % 2) == 1 && i > 0)
                    {
                        if (playerScore[i] == playerScore[i - 1])
                        {
                            while (playerScore[i] == playerScore[i - 1])
                            {
                                for (int j = 0; j < 2; j++)
                                {
                                    int mm = 0;
                                    double SS = 0;
                                    while (SS >= -semi[i])
                                    {
                                        SS += Math.Log(rand.NextDouble());
                                        mm++;
                                    }
                                    playerScore[i] = mm;
                                }
                            }
                        }
                    }
                }

                semi1.Text = semi1.Text + " " + playerScore[0];
                semi2.Text = semi2.Text + " " + playerScore[1];
                semi3.Text = playerScore[3] + " " + semi3.Text;
                semi4.Text = playerScore[4] + " " + semi4.Text;

                int k = 0;

                for (int i = 0; i < 4; i += 2)
                {
                    if (playerScore[i] > playerScore[i + 1])
                    {
                        finale[k] = semi[i];
                        finaleNames[k] = semiNames[i];
                    }
                    else
                    {
                        finale[k] = semi[i + 1];
                        finaleNames[k] = semiNames[i + 1];
                    }
                    k++;
                }
                finale1.Text = finaleNames[0];
                finale2.Text = finaleNames[1];
            }
            else if (button1.Text == "Финал")
            {
                button1.Text = "Заново";

                Random rand = new Random();
                for (int i = 0; i < finale.Length; i++)
                {
                    int m = 0;
                    double S = 0;
                    while (S >= -finale[i])
                    {
                        S += Math.Log(rand.NextDouble());
                        m++;
                    }
                    playerScore[i] = m;
                    if ((i % 2) == 1 && i > 0)
                    {
                        if (playerScore[i] == playerScore[i - 1])
                        {
                            while (playerScore[i] == playerScore[i - 1])
                            {
                                for (int j = 0; j < 2; j++)
                                {
                                    int mm = 0;
                                    double SS = 0;
                                    while (SS >= -finale[i])
                                    {
                                        SS += Math.Log(rand.NextDouble());
                                        mm++;
                                    }
                                    playerScore[i] = mm;
                                }
                            }
                        }
                    }
                }

                finale1.Text = finale1.Text + " " + playerScore[0];
                finale2.Text = playerScore[1] + " " + finale2.Text;

                if (playerScore[0] > playerScore[1])
                    champion.Text = finaleNames[0] + " - чемпион!";
                else champion.Text = finaleNames[1] + " - чемпион!";
            }
            else if (button1.Text == "Заново")
            {
                button1.Text = "Старт";

                renewSlots();
            }

        }

        private void player6_Load(object sender, EventArgs e)
        {
            renewSlots();
        }

        private void renewSlots()
        {
            player1.Text = playerNames[0];
            player2.Text = playerNames[1];
            player3.Text = playerNames[2];
            player4.Text = playerNames[3];
            player5.Text = playerNames[4];
            player66.Text = playerNames[5];
            player7.Text = playerNames[6];
            player8.Text = playerNames[7];
            player9.Text = playerNames[8];
            player10.Text = playerNames[9];
            player11.Text = playerNames[10];
            player12.Text = playerNames[11];
            player13.Text = playerNames[12];
            player14.Text = playerNames[13];
            player15.Text = playerNames[14];
            player16.Text = playerNames[15];

            quarter1.Text = "";
            quarter2.Text = "";
            quarter3.Text = "";
            quarter4.Text = "";
            quarter5.Text = "";
            quarter6.Text = "";
            quarter7.Text = "";
            quarter8.Text = "";

            semi1.Text = "";
            semi2.Text = "";
            semi3.Text = "";
            semi4.Text = "";

            finale1.Text = "";
            finale2.Text = "";
            champion.Text = "";

        }
    }
}