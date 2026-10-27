using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CFA RID: 23802
	[NullableContext(1)]
	[Nullable(0)]
	public class Converter
	{
		// Token: 0x0603C4AC RID: 246956 RVA: 0x00E6FD28 File Offset: 0x00E6DF28
		public static string Convert(string inputStr, int baseNum, int to)
		{
			if (baseNum == to)
			{
				return inputStr;
			}
			if (to < 2 || to > 62 || baseNum < 2 || baseNum > 62)
			{
				return "";
			}
			double num = Converter.ConvertToDecimal(inputStr, baseNum);
			string text = "";
			while (num > 0.0)
			{
				char c = Converter.CodeTable[(int)num % to];
				text = new ReadOnlySpan<char>(ref c) + text;
				num = Math.Floor(num / (double)to);
			}
			return text;
		}

		// Token: 0x0603C4AD RID: 246957 RVA: 0x00E6FD9C File Offset: 0x00E6DF9C
		private static double ConvertToDecimal(string inputStr, int baseNum)
		{
			double num = 0.0;
			for (int i = 0; i < inputStr.Length; i++)
			{
				num += (double)Converter.CodeTable.IndexOf(inputStr[i]) * Math.Pow((double)baseNum, (double)(inputStr.Length - i - 1));
			}
			return num;
		}

		// Token: 0x0401F696 RID: 128662
		private static readonly string CodeTable = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
	}
}
