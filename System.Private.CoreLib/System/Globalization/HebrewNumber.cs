using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x020002F4 RID: 756
	internal static class HebrewNumber
	{
		// Token: 0x06003743 RID: 14147 RVA: 0x000B5240 File Offset: 0x000B3440
		internal unsafe static void Append<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> outputBuffer, int Number) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int length = outputBuffer.Length;
			char c = '\0';
			if (Number > 5000)
			{
				Number -= 5000;
			}
			int num = Number / 100;
			if (num > 0)
			{
				Number -= num * 100;
				for (int i = 0; i < num / 4; i++)
				{
					DateTimeFormat.AppendChar<TChar>(ref outputBuffer, 'ת');
				}
				int num2 = num % 4;
				if (num2 > 0)
				{
					DateTimeFormat.AppendChar<TChar>(ref outputBuffer, (char)(1510 + num2));
				}
			}
			int num3 = Number / 10;
			Number %= 10;
			switch (num3)
			{
			case 0:
				c = '\0';
				break;
			case 1:
				c = 'י';
				break;
			case 2:
				c = 'כ';
				break;
			case 3:
				c = 'ל';
				break;
			case 4:
				c = 'מ';
				break;
			case 5:
				c = 'נ';
				break;
			case 6:
				c = 'ס';
				break;
			case 7:
				c = 'ע';
				break;
			case 8:
				c = 'פ';
				break;
			case 9:
				c = 'צ';
				break;
			}
			char c2 = (char)((Number > 0) ? (1488 + Number - 1) : 0);
			if (c2 == 'ה' && c == 'י')
			{
				c2 = 'ו';
				c = 'ט';
			}
			if (c2 == 'ו' && c == 'י')
			{
				c2 = 'ז';
				c = 'ט';
			}
			if (c != '\0')
			{
				DateTimeFormat.AppendChar<TChar>(ref outputBuffer, c);
			}
			if (c2 != '\0')
			{
				DateTimeFormat.AppendChar<TChar>(ref outputBuffer, c2);
			}
			if (outputBuffer.Length - length <= 1)
			{
				DateTimeFormat.AppendChar<TChar>(ref outputBuffer, '\'');
				return;
			}
			if (typeof(TChar) == typeof(char))
			{
				TChar item = *outputBuffer[outputBuffer.Length - 1];
				int length2 = outputBuffer.Length;
				outputBuffer.Length = length2 - 1;
				outputBuffer.Append(IUtfChar<TChar>.CastFrom('"'));
				outputBuffer.Append(item);
				return;
			}
			Rune rune;
			int num4;
			Rune.DecodeLastFromUtf8(MemoryMarshal.AsBytes<TChar>(outputBuffer.AsSpan()), out rune, out num4);
			outputBuffer.Length -= num4;
			outputBuffer.Append(IUtfChar<TChar>.CastFrom('"'));
			DateTimeFormat.AppendChar<TChar>(ref outputBuffer, (char)rune.Value);
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x000B5450 File Offset: 0x000B3650
		internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context)
		{
			HebrewNumber.HebrewToken hebrewToken;
			if (ch == '\'')
			{
				hebrewToken = HebrewNumber.HebrewToken.SingleQuote;
			}
			else if (ch == '"')
			{
				hebrewToken = HebrewNumber.HebrewToken.DoubleQuote;
			}
			else
			{
				int num = (int)(ch - 'א');
				if (num < 0 || num >= HebrewNumber.s_hebrewValues.Length)
				{
					return HebrewNumberParsingState.NotHebrewDigit;
				}
				hebrewToken = HebrewNumber.s_hebrewValues[num].token;
				if (hebrewToken == HebrewNumber.HebrewToken.Invalid)
				{
					return HebrewNumberParsingState.NotHebrewDigit;
				}
				context.result += (int)HebrewNumber.s_hebrewValues[num].value;
			}
			context.state = HebrewNumber.s_numberPassingState[(int)(context.state * HebrewNumber.HS.X00 + (sbyte)hebrewToken)];
			if (context.state == HebrewNumber.HS._err)
			{
				return HebrewNumberParsingState.InvalidHebrewNumber;
			}
			if (context.state == HebrewNumber.HS.END)
			{
				return HebrewNumberParsingState.FoundEndOfHebrewNumber;
			}
			return HebrewNumberParsingState.ContinueParsing;
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x000B54EA File Offset: 0x000B36EA
		internal static bool IsDigit(char ch)
		{
			if (ch >= 'א' && ch <= HebrewNumber.s_maxHebrewNumberCh)
			{
				return HebrewNumber.s_hebrewValues[(int)(ch - 'א')].value >= 0;
			}
			return ch == '\'' || ch == '"';
		}

		// Token: 0x04000AB1 RID: 2737
		private static readonly HebrewNumber.HebrewValue[] s_hebrewValues = new HebrewNumber.HebrewValue[]
		{
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 2),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 3),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 4),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 5),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit6_7, 6),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit6_7, 7),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit1, 8),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit9, 9),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 10),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Invalid, -1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 20),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 30),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Invalid, -1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 40),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Invalid, -1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 50),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 60),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 70),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Invalid, -1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 80),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Invalid, -1),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit10, 90),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit100, 100),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit200_300, 200),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit200_300, 300),
			new HebrewNumber.HebrewValue(HebrewNumber.HebrewToken.Digit400, 400)
		};

		// Token: 0x04000AB2 RID: 2738
		private static readonly char s_maxHebrewNumberCh = (char)(1488 + HebrewNumber.s_hebrewValues.Length - 1);

		// Token: 0x04000AB3 RID: 2739
		private static readonly HebrewNumber.HS[] s_numberPassingState = new HebrewNumber.HS[]
		{
			HebrewNumber.HS.S400,
			HebrewNumber.HS.X00,
			HebrewNumber.HS.X00,
			HebrewNumber.HS.X0,
			HebrewNumber.HS.X,
			HebrewNumber.HS.X,
			HebrewNumber.HS.X,
			HebrewNumber.HS.S9,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_400,
			HebrewNumber.HS.S400_X00,
			HebrewNumber.HS.S400_X00,
			HebrewNumber.HS.S400_X0,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_S9,
			HebrewNumber.HS.END,
			HebrewNumber.HS.S400_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_400_100,
			HebrewNumber.HS.S400_X0,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_S9,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_400_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_X00_X0,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_S9,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X0_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X0_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.X0_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_X0,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_S9,
			HebrewNumber.HS.END,
			HebrewNumber.HS.X00_DQ,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S400_X00_X0,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_S9,
			HebrewNumber.HS._err,
			HebrewNumber.HS.X00_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.S9_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.S9_DQ,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS.END,
			HebrewNumber.HS.END,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err,
			HebrewNumber.HS._err
		};

		// Token: 0x020002F5 RID: 757
		private enum HebrewToken : short
		{
			// Token: 0x04000AB5 RID: 2741
			Invalid = -1,
			// Token: 0x04000AB6 RID: 2742
			Digit400,
			// Token: 0x04000AB7 RID: 2743
			Digit200_300,
			// Token: 0x04000AB8 RID: 2744
			Digit100,
			// Token: 0x04000AB9 RID: 2745
			Digit10,
			// Token: 0x04000ABA RID: 2746
			Digit1,
			// Token: 0x04000ABB RID: 2747
			Digit6_7,
			// Token: 0x04000ABC RID: 2748
			Digit7,
			// Token: 0x04000ABD RID: 2749
			Digit9,
			// Token: 0x04000ABE RID: 2750
			SingleQuote,
			// Token: 0x04000ABF RID: 2751
			DoubleQuote
		}

		// Token: 0x020002F6 RID: 758
		private readonly struct HebrewValue
		{
			// Token: 0x06003747 RID: 14151 RVA: 0x000B5713 File Offset: 0x000B3913
			internal HebrewValue(HebrewNumber.HebrewToken token, short value)
			{
				this.token = token;
				this.value = value;
			}

			// Token: 0x04000AC0 RID: 2752
			internal readonly HebrewNumber.HebrewToken token;

			// Token: 0x04000AC1 RID: 2753
			internal readonly short value;
		}

		// Token: 0x020002F7 RID: 759
		internal enum HS : sbyte
		{
			// Token: 0x04000AC3 RID: 2755
			_err = -1,
			// Token: 0x04000AC4 RID: 2756
			Start,
			// Token: 0x04000AC5 RID: 2757
			S400,
			// Token: 0x04000AC6 RID: 2758
			S400_400,
			// Token: 0x04000AC7 RID: 2759
			S400_X00,
			// Token: 0x04000AC8 RID: 2760
			S400_X0,
			// Token: 0x04000AC9 RID: 2761
			X00_DQ,
			// Token: 0x04000ACA RID: 2762
			S400_X00_X0,
			// Token: 0x04000ACB RID: 2763
			X0_DQ,
			// Token: 0x04000ACC RID: 2764
			X,
			// Token: 0x04000ACD RID: 2765
			X0,
			// Token: 0x04000ACE RID: 2766
			X00,
			// Token: 0x04000ACF RID: 2767
			S400_DQ,
			// Token: 0x04000AD0 RID: 2768
			S400_400_DQ,
			// Token: 0x04000AD1 RID: 2769
			S400_400_100,
			// Token: 0x04000AD2 RID: 2770
			S9,
			// Token: 0x04000AD3 RID: 2771
			X00_S9,
			// Token: 0x04000AD4 RID: 2772
			S9_DQ,
			// Token: 0x04000AD5 RID: 2773
			END = 100
		}
	}
}
