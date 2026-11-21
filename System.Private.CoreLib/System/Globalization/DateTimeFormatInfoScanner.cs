using System;
using System.Collections.Generic;
using System.Text;

namespace System.Globalization
{
	// Token: 0x020002E2 RID: 738
	internal sealed class DateTimeFormatInfoScanner
	{
		// Token: 0x06003688 RID: 13960 RVA: 0x000B245C File Offset: 0x000B065C
		internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex)
		{
			while (currentIndex < pattern.Length)
			{
				char c = pattern[currentIndex];
				if (c == '\\')
				{
					currentIndex++;
					if (currentIndex >= pattern.Length)
					{
						break;
					}
					c = pattern[currentIndex];
					if (c == '\'')
					{
						continue;
					}
				}
				if (char.IsLetter(c) || c == '\'' || c == '.')
				{
					break;
				}
				currentIndex++;
			}
			return currentIndex;
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x000B24B4 File Offset: 0x000B06B4
		internal void AddDateWordOrPostfix(string formatPostfix, string str)
		{
			if (str.Length == 0)
			{
				return;
			}
			if (str.Length == 1)
			{
				char c = str[0];
				if (c <= '月')
				{
					if (c <= '年')
					{
						switch (c)
						{
						case '-':
						case '/':
							return;
						case '.':
							this.AddIgnorableSymbols(".");
							return;
						default:
							if (c != '分' && c != '年')
							{
								goto IL_E5;
							}
							break;
						}
					}
					else if (c <= '时')
					{
						if (c != '日' && c != '时')
						{
							goto IL_E5;
						}
					}
					else if (c != '時' && c != '月')
					{
						goto IL_E5;
					}
				}
				else if (c <= '분')
				{
					if (c != '秒' && c != '년' && c != '분')
					{
						goto IL_E5;
					}
				}
				else if (c <= '월')
				{
					if (c != '시' && c != '월')
					{
						goto IL_E5;
					}
				}
				else if (c != '일' && c != '초')
				{
					goto IL_E5;
				}
				return;
			}
			IL_E5:
			if (this.m_dateWords == null)
			{
				this.m_dateWords = new List<string>();
			}
			if (formatPostfix == "MMMM")
			{
				string item = "" + str;
				if (!this.m_dateWords.Contains(item))
				{
					this.m_dateWords.Add(item);
					return;
				}
			}
			else
			{
				if (!this.m_dateWords.Contains(str))
				{
					this.m_dateWords.Add(str);
				}
				if (str.EndsWith('.'))
				{
					string item2 = str.Substring(0, str.Length - 1);
					if (!this.m_dateWords.Contains(item2))
					{
						this.m_dateWords.Add(item2);
					}
				}
			}
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x000B2640 File Offset: 0x000B0840
		internal int AddDateWords(string pattern, int index, string formatPostfix)
		{
			int num = DateTimeFormatInfoScanner.SkipWhiteSpacesAndNonLetter(pattern, index);
			if (num != index && formatPostfix != null)
			{
				formatPostfix = null;
			}
			index = num;
			StringBuilder stringBuilder = new StringBuilder();
			while (index < pattern.Length)
			{
				char c = pattern[index];
				if (c == '\'')
				{
					this.AddDateWordOrPostfix(formatPostfix, stringBuilder.ToString());
					index++;
					break;
				}
				if (c == '\\')
				{
					index++;
					if (index < pattern.Length)
					{
						stringBuilder.Append(pattern[index]);
						index++;
					}
				}
				else if (char.IsWhiteSpace(c))
				{
					this.AddDateWordOrPostfix(formatPostfix, stringBuilder.ToString());
					if (formatPostfix != null)
					{
						formatPostfix = null;
					}
					stringBuilder.Length = 0;
					index++;
				}
				else
				{
					stringBuilder.Append(c);
					index++;
				}
			}
			return index;
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x000B26F4 File Offset: 0x000B08F4
		internal static int ScanRepeatChar(string pattern, char ch, int index, out int count)
		{
			count = 1;
			while (++index < pattern.Length && pattern[index] == ch)
			{
				count++;
			}
			return index;
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x000B271C File Offset: 0x000B091C
		internal void AddIgnorableSymbols(string text)
		{
			if (this.m_dateWords == null)
			{
				this.m_dateWords = new List<string>();
			}
			string item = "" + text;
			if (!this.m_dateWords.Contains(item))
			{
				this.m_dateWords.Add(item);
			}
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x000B2764 File Offset: 0x000B0964
		internal void ScanDateWord(string pattern)
		{
			this._ymdFlags = DateTimeFormatInfoScanner.FoundDatePattern.None;
			for (int i = 0; i < pattern.Length; i++)
			{
				char c = pattern[i];
				if (c <= 'M')
				{
					if (c == '\'')
					{
						i = this.AddDateWords(pattern, i + 1, null);
						continue;
					}
					if (c == '.')
					{
						if (this._ymdFlags == DateTimeFormatInfoScanner.FoundDatePattern.FoundYMDPatternFlag)
						{
							this.AddIgnorableSymbols(".");
							this._ymdFlags = DateTimeFormatInfoScanner.FoundDatePattern.None;
						}
						i++;
						continue;
					}
					if (c == 'M')
					{
						int num;
						i = DateTimeFormatInfoScanner.ScanRepeatChar(pattern, 'M', i, out num);
						if (num >= 4 && i < pattern.Length && pattern[i] == '\'')
						{
							i = this.AddDateWords(pattern, i + 1, "MMMM");
						}
						this._ymdFlags |= DateTimeFormatInfoScanner.FoundDatePattern.FoundMonthPatternFlag;
						continue;
					}
				}
				else
				{
					if (c == '\\')
					{
						i += 2;
						continue;
					}
					if (c != 'd')
					{
						if (c == 'y')
						{
							int num2;
							i = DateTimeFormatInfoScanner.ScanRepeatChar(pattern, 'y', i, out num2);
							this._ymdFlags |= DateTimeFormatInfoScanner.FoundDatePattern.FoundYearPatternFlag;
							continue;
						}
					}
					else
					{
						int num;
						i = DateTimeFormatInfoScanner.ScanRepeatChar(pattern, 'd', i, out num);
						if (num <= 2)
						{
							this._ymdFlags |= DateTimeFormatInfoScanner.FoundDatePattern.FoundDayPatternFlag;
							continue;
						}
						continue;
					}
				}
				if (this._ymdFlags == DateTimeFormatInfoScanner.FoundDatePattern.FoundYMDPatternFlag && !char.IsWhiteSpace(c))
				{
					this._ymdFlags = DateTimeFormatInfoScanner.FoundDatePattern.None;
				}
			}
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x000B289C File Offset: 0x000B0A9C
		internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi)
		{
			string[] allDateTimePatterns = dtfi.GetAllDateTimePatterns('D');
			for (int i = 0; i < allDateTimePatterns.Length; i++)
			{
				this.ScanDateWord(allDateTimePatterns[i]);
			}
			allDateTimePatterns = dtfi.GetAllDateTimePatterns('d');
			for (int i = 0; i < allDateTimePatterns.Length; i++)
			{
				this.ScanDateWord(allDateTimePatterns[i]);
			}
			allDateTimePatterns = dtfi.GetAllDateTimePatterns('y');
			for (int i = 0; i < allDateTimePatterns.Length; i++)
			{
				this.ScanDateWord(allDateTimePatterns[i]);
			}
			this.ScanDateWord(dtfi.MonthDayPattern);
			allDateTimePatterns = dtfi.GetAllDateTimePatterns('T');
			for (int i = 0; i < allDateTimePatterns.Length; i++)
			{
				this.ScanDateWord(allDateTimePatterns[i]);
			}
			allDateTimePatterns = dtfi.GetAllDateTimePatterns('t');
			for (int i = 0; i < allDateTimePatterns.Length; i++)
			{
				this.ScanDateWord(allDateTimePatterns[i]);
			}
			string[] array = null;
			if (this.m_dateWords != null && this.m_dateWords.Count > 0)
			{
				array = new string[this.m_dateWords.Count];
				for (int i = 0; i < this.m_dateWords.Count; i++)
				{
					array[i] = this.m_dateWords[i];
				}
			}
			return array;
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x000B29A4 File Offset: 0x000B0BA4
		internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitiveMonthNames, string[] abbrevMonthNames, string[] genitiveAbbrevMonthNames)
		{
			if (monthNames.AsSpan<string>().SequenceEqual(genitiveMonthNames) && abbrevMonthNames.AsSpan<string>().SequenceEqual(genitiveAbbrevMonthNames))
			{
				return FORMATFLAGS.None;
			}
			return FORMATFLAGS.UseGenitiveMonth;
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x000B29D0 File Offset: 0x000B0BD0
		internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames)
		{
			return FORMATFLAGS.None | ((DateTimeFormatInfoScanner.ArrayElementsBeginWithDigit(monthNames) || DateTimeFormatInfoScanner.ArrayElementsBeginWithDigit(genitveMonthNames) || DateTimeFormatInfoScanner.ArrayElementsBeginWithDigit(abbrevMonthNames) || DateTimeFormatInfoScanner.ArrayElementsBeginWithDigit(genetiveAbbrevMonthNames)) ? FORMATFLAGS.UseDigitPrefixInTokens : FORMATFLAGS.None) | ((DateTimeFormatInfoScanner.ArrayElementsHaveSpace(monthNames) || DateTimeFormatInfoScanner.ArrayElementsHaveSpace(genitveMonthNames) || DateTimeFormatInfoScanner.ArrayElementsHaveSpace(abbrevMonthNames) || DateTimeFormatInfoScanner.ArrayElementsHaveSpace(genetiveAbbrevMonthNames)) ? FORMATFLAGS.UseSpacesInMonthNames : FORMATFLAGS.None);
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x000B2A29 File Offset: 0x000B0C29
		internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames)
		{
			if (!DateTimeFormatInfoScanner.ArrayElementsHaveSpace(dayNames) && !DateTimeFormatInfoScanner.ArrayElementsHaveSpace(abbrevDayNames))
			{
				return FORMATFLAGS.None;
			}
			return FORMATFLAGS.UseSpacesInDayNames;
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x000B2A3F File Offset: 0x000B0C3F
		internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID)
		{
			if (calID != 8)
			{
				return FORMATFLAGS.None;
			}
			return (FORMATFLAGS)10;
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x000B2A4C File Offset: 0x000B0C4C
		private static bool ArrayElementsHaveSpace(string[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				for (int j = 0; j < array[i].Length; j++)
				{
					if (char.IsWhiteSpace(array[i][j]))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x000B2A90 File Offset: 0x000B0C90
		private static bool ArrayElementsBeginWithDigit(string[] array)
		{
			int i = 0;
			while (i < array.Length)
			{
				string text = array[i];
				if (text.Length != 0 && char.IsAsciiDigit(text[0]))
				{
					int num = 1;
					while (num < text.Length && char.IsAsciiDigit(text[num]))
					{
						num++;
					}
					if (num == text.Length)
					{
						return false;
					}
					if (num == text.Length - 1)
					{
						char c = text[num];
						if (c == '月' || c == '월')
						{
							return false;
						}
					}
					return num != text.Length - 4 || text[num] != '\'' || text[num + 1] != ' ' || text[num + 2] != '月' || text[num + 3] != '\'';
				}
				else
				{
					i++;
				}
			}
			return false;
		}

		// Token: 0x04000A6E RID: 2670
		internal List<string> m_dateWords = new List<string>();

		// Token: 0x04000A6F RID: 2671
		private DateTimeFormatInfoScanner.FoundDatePattern _ymdFlags;

		// Token: 0x020002E3 RID: 739
		private enum FoundDatePattern
		{
			// Token: 0x04000A71 RID: 2673
			None,
			// Token: 0x04000A72 RID: 2674
			FoundYearPatternFlag,
			// Token: 0x04000A73 RID: 2675
			FoundMonthPatternFlag,
			// Token: 0x04000A74 RID: 2676
			FoundDayPatternFlag = 4,
			// Token: 0x04000A75 RID: 2677
			FoundYMDPatternFlag = 7
		}
	}
}
