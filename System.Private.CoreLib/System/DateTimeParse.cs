using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x02000125 RID: 293
	internal static class DateTimeParse
	{
		// Token: 0x060011D7 RID: 4567 RVA: 0x000334A0 File Offset: 0x000316A0
		internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (DateTimeParse.TryParseExact(s, format, dtfi, style, ref dateTimeResult))
			{
				return dateTimeResult.parsedDate;
			}
			throw DateTimeParse.GetDateTimeParseException(ref dateTimeResult);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x000334D8 File Offset: 0x000316D8
		internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			dateTimeResult.flags |= ParseFlags.CaptureOffset;
			if (DateTimeParse.TryParseExact(s, format, dtfi, style, ref dateTimeResult))
			{
				offset = dateTimeResult.timeZoneOffset;
				return dateTimeResult.parsedDate;
			}
			throw DateTimeParse.GetDateTimeParseException(ref dateTimeResult);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00033530 File Offset: 0x00031730
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (DateTimeParse.TryParseExact(s, format, dtfi, style, ref dateTimeResult))
			{
				result = dateTimeResult.parsedDate;
				return true;
			}
			result = DateTime.MinValue;
			return false;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00033578 File Offset: 0x00031778
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			dateTimeResult.flags |= ParseFlags.CaptureOffset;
			if (DateTimeParse.TryParseExact(s, format, dtfi, style, ref dateTimeResult))
			{
				result = dateTimeResult.parsedDate;
				offset = dateTimeResult.timeZoneOffset;
				return true;
			}
			result = DateTime.MinValue;
			offset = TimeSpan.Zero;
			return false;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x000335E7 File Offset: 0x000317E7
		internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, [ScopedRef] ref DateTimeResult result)
		{
			if (s.Length == 0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (format.Length == 0)
			{
				result.SetBadFormatSpecifierFailure();
				return false;
			}
			return DateTimeParse.DoStrictParse(s, format, style, dtfi, ref result);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00033618 File Offset: 0x00031818
		internal static DateTime ParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (DateTimeParse.TryParseExactMultiple(s, formats, dtfi, style, ref dateTimeResult))
			{
				return dateTimeResult.parsedDate;
			}
			throw DateTimeParse.GetDateTimeParseException(ref dateTimeResult);
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00033650 File Offset: 0x00031850
		internal static DateTime ParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			dateTimeResult.flags |= ParseFlags.CaptureOffset;
			if (DateTimeParse.TryParseExactMultiple(s, formats, dtfi, style, ref dateTimeResult))
			{
				offset = dateTimeResult.timeZoneOffset;
				return dateTimeResult.parsedDate;
			}
			throw DateTimeParse.GetDateTimeParseException(ref dateTimeResult);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x000336A8 File Offset: 0x000318A8
		internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			dateTimeResult.flags |= ParseFlags.CaptureOffset;
			if (DateTimeParse.TryParseExactMultiple(s, formats, dtfi, style, ref dateTimeResult))
			{
				result = dateTimeResult.parsedDate;
				offset = dateTimeResult.timeZoneOffset;
				return true;
			}
			result = DateTime.MinValue;
			offset = TimeSpan.Zero;
			return false;
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00033718 File Offset: 0x00031918
		internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (DateTimeParse.TryParseExactMultiple(s, formats, dtfi, style, ref dateTimeResult))
			{
				result = dateTimeResult.parsedDate;
				return true;
			}
			result = DateTime.MinValue;
			return false;
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00033760 File Offset: 0x00031960
		internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, [ScopedRef] ref DateTimeResult result)
		{
			if (formats == null)
			{
				result.SetFailure(ParseFailureKind.ArgumentNull_String);
				return false;
			}
			if (s.Length == 0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (formats.Length == 0)
			{
				result.SetFailure(ParseFailureKind.Format_NoFormatSpecifier);
				return false;
			}
			foreach (string value in formats)
			{
				if (string.IsNullOrEmpty(value))
				{
					result.SetBadFormatSpecifierFailure();
					return false;
				}
				DateTimeResult dateTimeResult = default(DateTimeResult);
				dateTimeResult.Init(s);
				dateTimeResult.flags = result.flags;
				if (DateTimeParse.TryParseExact(s, value, dtfi, style, ref dateTimeResult))
				{
					result.parsedDate = dateTimeResult.parsedDate;
					result.timeZoneOffset = dateTimeResult.timeZoneOffset;
					return true;
				}
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00033814 File Offset: 0x00031A14
		private unsafe static bool MatchWord(ref __DTString str, string target)
		{
			if (target.Length > str.Value.Length - str.Index)
			{
				return false;
			}
			if (str.CompareInfo.Compare(str.Value.Slice(str.Index, target.Length), target, CompareOptions.IgnoreCase) != 0)
			{
				return false;
			}
			int num = str.Index + target.Length;
			if (num < str.Value.Length && char.IsLetter((char)(*str.Value[num])))
			{
				return false;
			}
			str.Index = num;
			if (str.Index < str.Length)
			{
				str.m_current = (char)(*str.Value[str.Index]);
			}
			return true;
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x000338CA File Offset: 0x00031ACA
		private static bool GetTimeZoneName(ref __DTString str)
		{
			return DateTimeParse.MatchWord(ref str, "GMT") || DateTimeParse.MatchWord(ref str, "Z");
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000338EC File Offset: 0x00031AEC
		private static bool ParseFraction(ref __DTString str, out double result)
		{
			result = 0.0;
			double num = 0.1;
			int num2 = 0;
			char current;
			while (str.GetNext() && char.IsAsciiDigit(current = str.m_current))
			{
				result += (double)(current - '0') * num;
				num *= 0.1;
				num2++;
			}
			return num2 > 0;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0003394C File Offset: 0x00031B4C
		private static bool ParseTimeZone(ref __DTString str, [ScopedRef] ref TimeSpan result)
		{
			int num = 0;
			DTSubString subString = str.GetSubString();
			if (subString.length != 1)
			{
				return false;
			}
			char c = subString[0];
			if (c != '+' && c != '-')
			{
				return false;
			}
			str.ConsumeSubString(subString);
			subString = str.GetSubString();
			if (subString.type != DTSubStringType.Number)
			{
				return false;
			}
			int value = subString.value;
			int length = subString.length;
			int hours;
			if (length == 1 || length == 2)
			{
				hours = value;
				str.ConsumeSubString(subString);
				subString = str.GetSubString();
				if (subString.length == 1 && subString[0] == ':')
				{
					str.ConsumeSubString(subString);
					subString = str.GetSubString();
					if (subString.type != DTSubStringType.Number || subString.length < 1 || subString.length > 2)
					{
						return false;
					}
					num = subString.value;
					str.ConsumeSubString(subString);
				}
			}
			else
			{
				if (length != 3 && length != 4)
				{
					return false;
				}
				hours = value / 100;
				num = value % 100;
				str.ConsumeSubString(subString);
			}
			if (num < 0 || num >= 60)
			{
				return false;
			}
			result = new TimeSpan(hours, num, 0);
			if (c == '-')
			{
				result = result.Negate();
			}
			return true;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00033A64 File Offset: 0x00031C64
		private unsafe static bool HandleTimeZone(ref __DTString str, [ScopedRef] ref DateTimeResult result)
		{
			if (str.Index < str.Length - 1)
			{
				char c = (char)(*str.Value[str.Index]);
				int num = 0;
				while (char.IsWhiteSpace(c) && str.Index + num < str.Length - 1)
				{
					num++;
					c = (char)(*str.Value[str.Index + num]);
				}
				if (c == '+' || c == '-')
				{
					str.Index += num;
					if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0)
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					result.flags |= ParseFlags.TimeZoneUsed;
					if (!DateTimeParse.ParseTimeZone(ref str, ref result.timeZoneOffset))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00033B20 File Offset: 0x00031D20
		private unsafe static bool Lex(DateTimeParse.DS dps, ref __DTString str, [ScopedRef] ref DateTimeToken dtok, [ScopedRef] ref DateTimeRawInfo raw, [ScopedRef] ref DateTimeResult result, [ScopedRef] ref DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			dtok.dtt = DateTimeParse.DTT.Unk;
			TokenType tokenType;
			int num;
			str.GetRegularToken(out tokenType, out num, dtfi);
			switch (tokenType)
			{
			case TokenType.NumberToken:
			case TokenType.YearNumberToken:
				if (raw.numCount == 3 || num == -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				if (dps == DateTimeParse.DS.T_NNt && str.Index < str.Length - 1)
				{
					char c = (char)(*str.Value[str.Index]);
					if (c == '.' || c == ',')
					{
						DateTimeParse.ParseFraction(ref str, out raw.fraction);
					}
				}
				if ((dps == DateTimeParse.DS.T_NNt || dps == DateTimeParse.DS.T_Nt) && str.Index < str.Length - 1 && !DateTimeParse.HandleTimeZone(ref str, ref result))
				{
					return false;
				}
				dtok.num = num;
				if (tokenType != TokenType.YearNumberToken)
				{
					int index;
					char current;
					TokenType separatorToken;
					TokenType tokenType2 = separatorToken = str.GetSeparatorToken(dtfi, out index, out current);
					if (separatorToken > TokenType.SEP_YearSuff)
					{
						if (separatorToken <= TokenType.SEP_HourSuff)
						{
							if (separatorToken == TokenType.SEP_MonthSuff || separatorToken == TokenType.SEP_DaySuff)
							{
								dtok.dtt = DateTimeParse.DTT.NumDatesuff;
								dtok.suffix = tokenType2;
								break;
							}
							if (separatorToken != TokenType.SEP_HourSuff)
							{
								goto IL_5A3;
							}
						}
						else if (separatorToken <= TokenType.SEP_SecondSuff)
						{
							if (separatorToken != TokenType.SEP_MinuteSuff && separatorToken != TokenType.SEP_SecondSuff)
							{
								goto IL_5A3;
							}
						}
						else
						{
							if (separatorToken == TokenType.SEP_LocalTimeMark)
							{
								dtok.dtt = DateTimeParse.DTT.NumLocalTimeMark;
								raw.AddNumber(dtok.num);
								break;
							}
							if (separatorToken != TokenType.SEP_DateOrOffset)
							{
								goto IL_5A3;
							}
							if (DateTimeParse.s_dateParsingStates[(int)dps][4] == DateTimeParse.DS.ERROR && DateTimeParse.s_dateParsingStates[(int)dps][3] > DateTimeParse.DS.ERROR)
							{
								str.Index = index;
								str.m_current = current;
								dtok.dtt = DateTimeParse.DTT.NumSpace;
							}
							else
							{
								dtok.dtt = DateTimeParse.DTT.NumDatesep;
							}
							raw.AddNumber(dtok.num);
							break;
						}
						dtok.dtt = DateTimeParse.DTT.NumTimesuff;
						dtok.suffix = tokenType2;
						break;
					}
					if (separatorToken <= TokenType.SEP_Am)
					{
						if (separatorToken == TokenType.SEP_End)
						{
							dtok.dtt = DateTimeParse.DTT.NumEnd;
							raw.AddNumber(dtok.num);
							break;
						}
						if (separatorToken == TokenType.SEP_Space)
						{
							dtok.dtt = DateTimeParse.DTT.NumSpace;
							raw.AddNumber(dtok.num);
							break;
						}
						if (separatorToken != TokenType.SEP_Am)
						{
							goto IL_5A3;
						}
					}
					else if (separatorToken <= TokenType.SEP_Date)
					{
						if (separatorToken != TokenType.SEP_Pm)
						{
							if (separatorToken != TokenType.SEP_Date)
							{
								goto IL_5A3;
							}
							dtok.dtt = DateTimeParse.DTT.NumDatesep;
							raw.AddNumber(dtok.num);
							break;
						}
					}
					else if (separatorToken != TokenType.SEP_Time)
					{
						if (separatorToken != TokenType.SEP_YearSuff)
						{
							goto IL_5A3;
						}
						try
						{
							dtok.num = dtfi.Calendar.ToFourDigitYear(num);
						}
						catch (ArgumentOutOfRangeException)
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						dtok.dtt = DateTimeParse.DTT.NumDatesuff;
						dtok.suffix = tokenType2;
						break;
					}
					else
					{
						if (raw.hasSameDateAndTimeSeparators && (dps == DateTimeParse.DS.D_Y || dps == DateTimeParse.DS.D_YN || dps == DateTimeParse.DS.D_YNd || dps == DateTimeParse.DS.D_YM || dps == DateTimeParse.DS.D_YMd))
						{
							dtok.dtt = DateTimeParse.DTT.NumDatesep;
							raw.AddNumber(dtok.num);
							break;
						}
						dtok.dtt = DateTimeParse.DTT.NumTimesep;
						raw.AddNumber(dtok.num);
						break;
					}
					if (raw.timeMark != DateTimeParse.TM.NotSet)
					{
						result.SetBadDateTimeFailure();
						break;
					}
					raw.timeMark = ((tokenType2 == TokenType.SEP_Am) ? DateTimeParse.TM.AM : DateTimeParse.TM.PM);
					dtok.dtt = DateTimeParse.DTT.NumAmpm;
					if (dps == DateTimeParse.DS.D_NN && !DateTimeParse.ProcessTerminalState(DateTimeParse.DS.DX_NN, ref result, ref styles, ref raw, dtfi))
					{
						return false;
					}
					raw.AddNumber(dtok.num);
					if ((dps == DateTimeParse.DS.T_NNt || dps == DateTimeParse.DS.T_Nt) && !DateTimeParse.HandleTimeZone(ref str, ref result))
					{
						return false;
					}
					break;
					IL_5A3:
					result.SetBadDateTimeFailure();
					return false;
				}
				if (raw.year == -1)
				{
					raw.year = num;
					int index;
					char current;
					TokenType separatorToken;
					TokenType tokenType2 = separatorToken = str.GetSeparatorToken(dtfi, out index, out current);
					if (separatorToken <= TokenType.SEP_Time)
					{
						if (separatorToken <= TokenType.SEP_Am)
						{
							if (separatorToken == TokenType.SEP_End)
							{
								dtok.dtt = DateTimeParse.DTT.YearEnd;
								return true;
							}
							if (separatorToken == TokenType.SEP_Space)
							{
								dtok.dtt = DateTimeParse.DTT.YearSpace;
								return true;
							}
							if (separatorToken != TokenType.SEP_Am)
							{
								goto IL_2BD;
							}
						}
						else if (separatorToken != TokenType.SEP_Pm)
						{
							if (separatorToken == TokenType.SEP_Date)
							{
								dtok.dtt = DateTimeParse.DTT.YearDateSep;
								return true;
							}
							if (separatorToken != TokenType.SEP_Time)
							{
								goto IL_2BD;
							}
							if (!raw.hasSameDateAndTimeSeparators)
							{
								result.SetBadDateTimeFailure();
								return false;
							}
							dtok.dtt = DateTimeParse.DTT.YearDateSep;
							return true;
						}
						if (raw.timeMark == DateTimeParse.TM.NotSet)
						{
							raw.timeMark = ((tokenType2 == TokenType.SEP_Am) ? DateTimeParse.TM.AM : DateTimeParse.TM.PM);
							dtok.dtt = DateTimeParse.DTT.YearSpace;
							return true;
						}
						result.SetBadDateTimeFailure();
						return true;
					}
					else
					{
						if (separatorToken > TokenType.SEP_DaySuff)
						{
							if (separatorToken <= TokenType.SEP_MinuteSuff)
							{
								if (separatorToken != TokenType.SEP_HourSuff && separatorToken != TokenType.SEP_MinuteSuff)
								{
									goto IL_2BD;
								}
							}
							else if (separatorToken != TokenType.SEP_SecondSuff)
							{
								if (separatorToken != TokenType.SEP_DateOrOffset)
								{
									goto IL_2BD;
								}
								if (DateTimeParse.s_dateParsingStates[(int)dps][13] == DateTimeParse.DS.ERROR && DateTimeParse.s_dateParsingStates[(int)dps][12] > DateTimeParse.DS.ERROR)
								{
									str.Index = index;
									str.m_current = current;
									dtok.dtt = DateTimeParse.DTT.YearSpace;
									return true;
								}
								dtok.dtt = DateTimeParse.DTT.YearDateSep;
								return true;
							}
							dtok.dtt = DateTimeParse.DTT.NumTimesuff;
							dtok.suffix = tokenType2;
							return true;
						}
						if (separatorToken == TokenType.SEP_YearSuff || separatorToken == TokenType.SEP_MonthSuff || separatorToken == TokenType.SEP_DaySuff)
						{
							dtok.dtt = DateTimeParse.DTT.NumDatesuff;
							dtok.suffix = tokenType2;
							return true;
						}
					}
					IL_2BD:
					result.SetBadDateTimeFailure();
					return false;
				}
				result.SetBadDateTimeFailure();
				return false;
			case TokenType.Am:
			case TokenType.Pm:
				if (raw.timeMark != DateTimeParse.TM.NotSet)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				raw.timeMark = (DateTimeParse.TM)num;
				break;
			case TokenType.MonthToken:
			{
				if (raw.month != -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				int index;
				char current;
				TokenType separatorToken;
				TokenType tokenType2 = separatorToken = str.GetSeparatorToken(dtfi, out index, out current);
				if (separatorToken <= TokenType.SEP_Space)
				{
					if (separatorToken == TokenType.SEP_End)
					{
						dtok.dtt = DateTimeParse.DTT.MonthEnd;
						goto IL_7FC;
					}
					if (separatorToken == TokenType.SEP_Space)
					{
						dtok.dtt = DateTimeParse.DTT.MonthSpace;
						goto IL_7FC;
					}
				}
				else
				{
					if (separatorToken == TokenType.SEP_Date)
					{
						dtok.dtt = DateTimeParse.DTT.MonthDatesep;
						goto IL_7FC;
					}
					if (separatorToken != TokenType.SEP_Time)
					{
						if (separatorToken == TokenType.SEP_DateOrOffset)
						{
							if (DateTimeParse.s_dateParsingStates[(int)dps][8] == DateTimeParse.DS.ERROR && DateTimeParse.s_dateParsingStates[(int)dps][7] > DateTimeParse.DS.ERROR)
							{
								str.Index = index;
								str.m_current = current;
								dtok.dtt = DateTimeParse.DTT.MonthSpace;
								goto IL_7FC;
							}
							dtok.dtt = DateTimeParse.DTT.MonthDatesep;
							goto IL_7FC;
						}
					}
					else
					{
						if (!raw.hasSameDateAndTimeSeparators)
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						dtok.dtt = DateTimeParse.DTT.MonthDatesep;
						goto IL_7FC;
					}
				}
				result.SetBadDateTimeFailure();
				return false;
				IL_7FC:
				raw.month = num;
				break;
			}
			case TokenType.EndOfString:
				dtok.dtt = DateTimeParse.DTT.End;
				break;
			case TokenType.DayOfWeekToken:
				if (raw.dayOfWeek != -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				raw.dayOfWeek = num;
				dtok.dtt = DateTimeParse.DTT.DayOfWeek;
				break;
			case TokenType.TimeZoneToken:
				if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				dtok.dtt = DateTimeParse.DTT.TimeZone;
				result.flags |= ParseFlags.TimeZoneUsed;
				result.timeZoneOffset = new TimeSpan(0L);
				result.flags |= ParseFlags.TimeZoneUtc;
				break;
			case TokenType.EraToken:
				if (result.era == -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				result.era = num;
				dtok.dtt = DateTimeParse.DTT.Era;
				break;
			case TokenType.UnknownToken:
				if (char.IsLetter(str.m_current))
				{
					result.SetFailure(ParseFailureKind.Format_UnknownDateTimeWord, str.Index);
					return false;
				}
				if ((str.m_current == '-' || str.m_current == '+') && (result.flags & ParseFlags.TimeZoneUsed) == (ParseFlags)0)
				{
					int index2 = str.Index;
					if (DateTimeParse.ParseTimeZone(ref str, ref result.timeZoneOffset))
					{
						result.flags |= ParseFlags.TimeZoneUsed;
						return true;
					}
					str.Index = index2;
				}
				if (DateTimeParse.VerifyValidPunctuation(ref str))
				{
					return true;
				}
				result.SetBadDateTimeFailure();
				return false;
			case TokenType.HebrewNumber:
			{
				int index;
				char current;
				TokenType separatorToken;
				TokenType tokenType2;
				if (num < 100)
				{
					dtok.num = num;
					raw.AddNumber(dtok.num);
					tokenType2 = (separatorToken = str.GetSeparatorToken(dtfi, out index, out current));
					if (separatorToken <= TokenType.SEP_Space)
					{
						if (separatorToken == TokenType.SEP_End)
						{
							dtok.dtt = DateTimeParse.DTT.NumEnd;
							break;
						}
						if (separatorToken != TokenType.SEP_Space)
						{
							goto IL_6FA;
						}
					}
					else if (separatorToken != TokenType.SEP_Date)
					{
						if (separatorToken != TokenType.SEP_DateOrOffset)
						{
							goto IL_6FA;
						}
						if (DateTimeParse.s_dateParsingStates[(int)dps][4] == DateTimeParse.DS.ERROR && DateTimeParse.s_dateParsingStates[(int)dps][3] > DateTimeParse.DS.ERROR)
						{
							str.Index = index;
							str.m_current = current;
							dtok.dtt = DateTimeParse.DTT.NumSpace;
							break;
						}
						dtok.dtt = DateTimeParse.DTT.NumDatesep;
						break;
					}
					dtok.dtt = DateTimeParse.DTT.NumDatesep;
					break;
					IL_6FA:
					result.SetBadDateTimeFailure();
					return false;
				}
				if (raw.year != -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				raw.year = num;
				tokenType2 = (separatorToken = str.GetSeparatorToken(dtfi, out index, out current));
				if (separatorToken != TokenType.SEP_End)
				{
					if (separatorToken != TokenType.SEP_Space)
					{
						if (separatorToken == TokenType.SEP_DateOrOffset)
						{
							if (DateTimeParse.s_dateParsingStates[(int)dps][12] > DateTimeParse.DS.ERROR)
							{
								str.Index = index;
								str.m_current = current;
								dtok.dtt = DateTimeParse.DTT.YearSpace;
								break;
							}
						}
						result.SetBadDateTimeFailure();
						return false;
					}
					dtok.dtt = DateTimeParse.DTT.YearSpace;
				}
				else
				{
					dtok.dtt = DateTimeParse.DTT.YearEnd;
				}
				break;
			}
			case TokenType.JapaneseEraToken:
				if (GlobalizationMode.Invariant)
				{
					return false;
				}
				result.calendar = JapaneseCalendar.GetDefaultInstance();
				dtfi = DateTimeFormatInfo.GetJapaneseCalendarDTFI();
				if (result.era == -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				result.era = num;
				dtok.dtt = DateTimeParse.DTT.Era;
				break;
			case TokenType.TEraToken:
				if (GlobalizationMode.Invariant)
				{
					return false;
				}
				result.calendar = TaiwanCalendar.GetDefaultInstance();
				dtfi = DateTimeFormatInfo.GetTaiwanCalendarDTFI();
				if (result.era == -1)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				result.era = num;
				dtok.dtt = DateTimeParse.DTT.Era;
				break;
			}
			return true;
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0003450C File Offset: 0x0003270C
		private unsafe static bool VerifyValidPunctuation(ref __DTString str)
		{
			char c = (char)(*str.Value[str.Index]);
			if (c == '#')
			{
				bool flag = false;
				bool flag2 = false;
				for (int i = 0; i < str.Length; i++)
				{
					c = (char)(*str.Value[i]);
					if (c == '#')
					{
						if (flag)
						{
							if (flag2)
							{
								return false;
							}
							flag2 = true;
						}
						else
						{
							flag = true;
						}
					}
					else if (c == '\0')
					{
						if (!flag2)
						{
							return false;
						}
					}
					else if (!char.IsWhiteSpace(c) && (!flag || flag2))
					{
						return false;
					}
				}
				if (!flag2)
				{
					return false;
				}
				str.GetNext();
				return true;
			}
			else
			{
				if (c != '\0')
				{
					return false;
				}
				if (str.Value.Slice(str.Index + 1).ContainsAnyExcept('\0'))
				{
					return false;
				}
				str.Index = str.Length;
				return true;
			}
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000345C0 File Offset: 0x000327C0
		private static bool GetYearMonthDayOrder(string datePattern, out int order)
		{
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			int num4 = 0;
			bool flag = false;
			int num5 = 0;
			while (num5 < datePattern.Length && num4 < 3)
			{
				char c = datePattern[num5];
				if (c == '\\' || c == '%')
				{
					num5++;
				}
				else
				{
					if (c == '\'' || c == '"')
					{
						flag = !flag;
					}
					if (!flag)
					{
						if (c == 'y')
						{
							num = num4++;
							while (num5 + 1 < datePattern.Length)
							{
								if (datePattern[num5 + 1] != 'y')
								{
									break;
								}
								num5++;
							}
						}
						else if (c == 'M')
						{
							num2 = num4++;
							while (num5 + 1 < datePattern.Length)
							{
								if (datePattern[num5 + 1] != 'M')
								{
									break;
								}
								num5++;
							}
						}
						else if (c == 'd')
						{
							int num6 = 1;
							while (num5 + 1 < datePattern.Length && datePattern[num5 + 1] == 'd')
							{
								num6++;
								num5++;
							}
							if (num6 <= 2)
							{
								num3 = num4++;
							}
						}
					}
				}
				num5++;
			}
			if (num == 0 && num2 == 1 && num3 == 2)
			{
				order = 0;
				return true;
			}
			if (num2 == 0 && num3 == 1 && num == 2)
			{
				order = 1;
				return true;
			}
			if (num3 == 0 && num2 == 1 && num == 2)
			{
				order = 2;
				return true;
			}
			if (num == 0 && num3 == 1 && num2 == 2)
			{
				order = 3;
				return true;
			}
			order = -1;
			return false;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00034714 File Offset: 0x00032914
		private static bool GetYearMonthOrder(string pattern, out int order)
		{
			int num = -1;
			int num2 = -1;
			int num3 = 0;
			bool flag = false;
			int num4 = 0;
			while (num4 < pattern.Length && num3 < 2)
			{
				char c = pattern[num4];
				if (c == '\\' || c == '%')
				{
					num4++;
				}
				else
				{
					if (c == '\'' || c == '"')
					{
						flag = !flag;
					}
					if (!flag)
					{
						if (c == 'y')
						{
							num = num3++;
							while (num4 + 1 < pattern.Length)
							{
								if (pattern[num4 + 1] != 'y')
								{
									break;
								}
								num4++;
							}
						}
						else if (c == 'M')
						{
							num2 = num3++;
							while (num4 + 1 < pattern.Length && pattern[num4 + 1] == 'M')
							{
								num4++;
							}
						}
					}
				}
				num4++;
			}
			if (num == 0 && num2 == 1)
			{
				order = 4;
				return true;
			}
			if (num2 == 0 && num == 1)
			{
				order = 5;
				return true;
			}
			order = -1;
			return false;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000347F4 File Offset: 0x000329F4
		private static bool GetMonthDayOrder(string pattern, out int order)
		{
			int num = -1;
			int num2 = -1;
			int num3 = 0;
			bool flag = false;
			int num4 = 0;
			while (num4 < pattern.Length && num3 < 2)
			{
				char c = pattern[num4];
				if (c == '\\' || c == '%')
				{
					num4++;
				}
				else
				{
					if (c == '\'' || c == '"')
					{
						flag = !flag;
					}
					if (!flag)
					{
						if (c == 'd')
						{
							int num5 = 1;
							while (num4 + 1 < pattern.Length && pattern[num4 + 1] == 'd')
							{
								num5++;
								num4++;
							}
							if (num5 <= 2)
							{
								num2 = num3++;
							}
						}
						else if (c == 'M')
						{
							num = num3++;
							while (num4 + 1 < pattern.Length && pattern[num4 + 1] == 'M')
							{
								num4++;
							}
						}
					}
				}
				num4++;
			}
			if (num == 0 && num2 == 1)
			{
				order = 6;
				return true;
			}
			if (num2 == 0 && num == 1)
			{
				order = 7;
				return true;
			}
			order = -1;
			return false;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000348E8 File Offset: 0x00032AE8
		private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear)
		{
			if (year < 100)
			{
				try
				{
					year = result.calendar.ToFourDigitYear(year);
				}
				catch (ArgumentOutOfRangeException)
				{
					adjustedYear = -1;
					return false;
				}
			}
			adjustedYear = year;
			return true;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00034928 File Offset: 0x00032B28
		private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day)
		{
			if (result.calendar.IsValidDay(year, month, day, result.era))
			{
				result.SetDate(year, month, day);
				return true;
			}
			return false;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0003494C File Offset: 0x00032B4C
		private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year)
		{
			return DateTimeParse.SetDateYMD(ref result, year, month, day);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00034957 File Offset: 0x00032B57
		private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year)
		{
			return DateTimeParse.SetDateYMD(ref result, year, month, day);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00034962 File Offset: 0x00032B62
		private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month)
		{
			return DateTimeParse.SetDateYMD(ref result, year, month, day);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0003496D File Offset: 0x00032B6D
		private static void GetDefaultYear(ref DateTimeResult result, [ScopedRef] ref DateTimeStyles styles)
		{
			result.Year = result.calendar.GetYear(DateTimeParse.GetDateTimeNow(ref result, ref styles));
			result.flags |= ParseFlags.YearDefault;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00034998 File Offset: 0x00032B98
		private static bool GetDayOfNN(ref DateTimeResult result, [ScopedRef] ref DateTimeStyles styles, [ScopedRef] ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int number = raw.GetNumber(0);
			int number2 = raw.GetNumber(1);
			DateTimeParse.GetDefaultYear(ref result, ref styles);
			int num;
			if (!DateTimeParse.GetMonthDayOrder(dtfi.MonthDayPattern, out num))
			{
				result.SetFailure(ParseFailureKind.Format_BadDatePattern, dtfi.MonthDayPattern);
				return false;
			}
			if (num == 6)
			{
				if (DateTimeParse.SetDateYMD(ref result, result.Year, number, number2))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (DateTimeParse.SetDateYMD(ref result, result.Year, number2, number))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00034A40 File Offset: 0x00032C40
		private static bool GetDayOfNNN(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int number = raw.GetNumber(0);
			int number2 = raw.GetNumber(1);
			int number3 = raw.GetNumber(2);
			int num;
			if (!DateTimeParse.GetYearMonthDayOrder(dtfi.ShortDatePattern, out num))
			{
				result.SetFailure(ParseFailureKind.Format_BadDatePattern, dtfi.ShortDatePattern);
				return false;
			}
			int year;
			if (num == 0)
			{
				if (DateTimeParse.TryAdjustYear(ref result, number, out year) && DateTimeParse.SetDateYMD(ref result, year, number2, number3))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (num == 1)
			{
				if (DateTimeParse.TryAdjustYear(ref result, number3, out year) && DateTimeParse.SetDateMDY(ref result, number, number2, year))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (num == 2)
			{
				if (DateTimeParse.TryAdjustYear(ref result, number3, out year) && DateTimeParse.SetDateDMY(ref result, number, number2, year))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (num == 3 && DateTimeParse.TryAdjustYear(ref result, number, out year) && DateTimeParse.SetDateYDM(ref result, year, number2, number3))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00034B58 File Offset: 0x00032D58
		private static bool GetDayOfMN(ref DateTimeResult result, [ScopedRef] ref DateTimeStyles styles, [ScopedRef] ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int num;
			if (!DateTimeParse.GetMonthDayOrder(dtfi.MonthDayPattern, out num))
			{
				result.SetFailure(ParseFailureKind.Format_BadDatePattern, dtfi.MonthDayPattern);
				return false;
			}
			if (num == 7)
			{
				int num2;
				if (!DateTimeParse.GetYearMonthOrder(dtfi.YearMonthPattern, out num2))
				{
					result.SetFailure(ParseFailureKind.Format_BadDatePattern, dtfi.YearMonthPattern);
					return false;
				}
				if (num2 == 5)
				{
					int year;
					if (!DateTimeParse.TryAdjustYear(ref result, raw.GetNumber(0), out year) || !DateTimeParse.SetDateYMD(ref result, year, raw.month, 1))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					return true;
				}
			}
			DateTimeParse.GetDefaultYear(ref result, ref styles);
			if (!DateTimeParse.SetDateYMD(ref result, result.Year, raw.month, raw.GetNumber(0)))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			return true;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00034C18 File Offset: 0x00032E18
		private static bool GetHebrewDayOfNM(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			int num;
			if (!DateTimeParse.GetMonthDayOrder(dtfi.MonthDayPattern, out num))
			{
				result.SetFailure(ParseFailureKind.Format_BadDatePattern, dtfi.MonthDayPattern);
				return false;
			}
			result.Month = raw.month;
			if ((num == 7 || num == 6) && result.calendar.IsValidDay(result.Year, result.Month, raw.GetNumber(0), result.era))
			{
				result.Day = raw.GetNumber(0);
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00034C94 File Offset: 0x00032E94
		private static bool GetDayOfNM(ref DateTimeResult result, [ScopedRef] ref DateTimeStyles styles, [ScopedRef] ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int num;
			if (!DateTimeParse.GetMonthDayOrder(dtfi.MonthDayPattern, out num))
			{
				result.SetFailure(ParseFailureKind.Format_BadDatePattern, dtfi.MonthDayPattern);
				return false;
			}
			if (num == 6)
			{
				int num2;
				if (!DateTimeParse.GetYearMonthOrder(dtfi.YearMonthPattern, out num2))
				{
					result.SetFailure(ParseFailureKind.Format_BadDatePattern, dtfi.YearMonthPattern);
					return false;
				}
				if (num2 == 4)
				{
					int year;
					if (!DateTimeParse.TryAdjustYear(ref result, raw.GetNumber(0), out year) || !DateTimeParse.SetDateYMD(ref result, year, raw.month, 1))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					return true;
				}
			}
			DateTimeParse.GetDefaultYear(ref result, ref styles);
			if (!DateTimeParse.SetDateYMD(ref result, result.Year, raw.month, raw.GetNumber(0)))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			return true;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00034D54 File Offset: 0x00032F54
		private static bool GetDayOfMNN(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int number = raw.GetNumber(0);
			int number2 = raw.GetNumber(1);
			int num;
			if (!DateTimeParse.GetYearMonthDayOrder(dtfi.ShortDatePattern, out num))
			{
				result.SetFailure(ParseFailureKind.Format_BadDatePattern, dtfi.ShortDatePattern);
				return false;
			}
			if (num == 1)
			{
				int year;
				if (DateTimeParse.TryAdjustYear(ref result, number2, out year) && result.calendar.IsValidDay(year, raw.month, number, result.era))
				{
					result.SetDate(year, raw.month, number);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
				if (DateTimeParse.TryAdjustYear(ref result, number, out year) && result.calendar.IsValidDay(year, raw.month, number2, result.era))
				{
					result.SetDate(year, raw.month, number2);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (num == 0)
			{
				int year;
				if (DateTimeParse.TryAdjustYear(ref result, number, out year) && result.calendar.IsValidDay(year, raw.month, number2, result.era))
				{
					result.SetDate(year, raw.month, number2);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
				if (DateTimeParse.TryAdjustYear(ref result, number2, out year) && result.calendar.IsValidDay(year, raw.month, number, result.era))
				{
					result.SetDate(year, raw.month, number);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (num == 2)
			{
				int year;
				if (DateTimeParse.TryAdjustYear(ref result, number2, out year) && result.calendar.IsValidDay(year, raw.month, number, result.era))
				{
					result.SetDate(year, raw.month, number);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
				if (DateTimeParse.TryAdjustYear(ref result, number, out year) && result.calendar.IsValidDay(year, raw.month, number2, result.era))
				{
					result.SetDate(year, raw.month, number2);
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00034F6C File Offset: 0x0003316C
		private static bool GetDayOfYNN(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int number = raw.GetNumber(0);
			int number2 = raw.GetNumber(1);
			int num;
			if (DateTimeParse.GetYearMonthDayOrder(dtfi.ShortDatePattern, out num) && num == 3)
			{
				if (DateTimeParse.SetDateYMD(ref result, raw.year, number2, number))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (DateTimeParse.SetDateYMD(ref result, raw.year, number, number2))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00034FFC File Offset: 0x000331FC
		private static bool GetDayOfNNY(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int number = raw.GetNumber(0);
			int number2 = raw.GetNumber(1);
			int num;
			if (!DateTimeParse.GetYearMonthDayOrder(dtfi.ShortDatePattern, out num))
			{
				result.SetFailure(ParseFailureKind.Format_BadDatePattern, dtfi.ShortDatePattern);
				return false;
			}
			if (num == 1 || num == 0)
			{
				if (DateTimeParse.SetDateYMD(ref result, raw.year, number, number2))
				{
					result.flags |= ParseFlags.HaveDate;
					return true;
				}
			}
			else if (DateTimeParse.SetDateYDM(ref result, raw.year, number, number2))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x000350A0 File Offset: 0x000332A0
		private static bool GetDayOfYMN(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (DateTimeParse.SetDateYMD(ref result, raw.year, raw.month, raw.GetNumber(0)))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x000350F8 File Offset: 0x000332F8
		private static bool GetDayOfYN(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (DateTimeParse.SetDateYMD(ref result, raw.year, raw.GetNumber(0), 1))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0003514C File Offset: 0x0003334C
		private static bool GetDayOfYM(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveDate) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (DateTimeParse.SetDateYMD(ref result, raw.year, raw.month, 1))
			{
				result.flags |= ParseFlags.HaveDate;
				return true;
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0003519C File Offset: 0x0003339C
		private static void AdjustTimeMark(DateTimeFormatInfo dtfi, [ScopedRef] ref DateTimeRawInfo raw)
		{
			if (raw.timeMark == DateTimeParse.TM.NotSet && dtfi.AMDesignator != null && dtfi.PMDesignator != null)
			{
				if (dtfi.AMDesignator.Length == 0 && dtfi.PMDesignator.Length != 0)
				{
					raw.timeMark = DateTimeParse.TM.AM;
				}
				if (dtfi.PMDesignator.Length == 0 && dtfi.AMDesignator.Length != 0)
				{
					raw.timeMark = DateTimeParse.TM.PM;
				}
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00035204 File Offset: 0x00033404
		private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark)
		{
			if (timeMark != DateTimeParse.TM.NotSet)
			{
				if (timeMark == DateTimeParse.TM.AM)
				{
					if (hour < 0 || hour > 12)
					{
						return false;
					}
					hour = ((hour == 12) ? 0 : hour);
				}
				else
				{
					if (hour < 0 || hour > 23)
					{
						return false;
					}
					if (hour < 12)
					{
						hour += 12;
					}
				}
			}
			return true;
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00035244 File Offset: 0x00033444
		private static bool GetTimeOfN(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveTime) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (raw.timeMark == DateTimeParse.TM.NotSet)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			result.Hour = raw.GetNumber(0);
			result.flags |= ParseFlags.HaveTime;
			return true;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00035284 File Offset: 0x00033484
		private static bool GetTimeOfNN(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveTime) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			result.Hour = raw.GetNumber(0);
			result.Minute = raw.GetNumber(1);
			result.flags |= ParseFlags.HaveTime;
			return true;
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x000352C0 File Offset: 0x000334C0
		private static bool GetTimeOfNNN(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw)
		{
			if ((result.flags & ParseFlags.HaveTime) != (ParseFlags)0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			result.Hour = raw.GetNumber(0);
			result.Minute = raw.GetNumber(1);
			result.Second = raw.GetNumber(2);
			result.flags |= ParseFlags.HaveTime;
			return true;
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00035314 File Offset: 0x00033514
		private static bool GetDateOfDSN(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw)
		{
			if (raw.numCount != 1 || result.Day != -1)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			result.Day = raw.GetNumber(0);
			return true;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x00035340 File Offset: 0x00033540
		private static bool GetDateOfNDS(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw)
		{
			if (result.Month == -1)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (result.Year != -1)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (!DateTimeParse.TryAdjustYear(ref result, raw.GetNumber(0), out result.Year))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			result.Day = 1;
			return true;
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00035394 File Offset: 0x00033594
		private static bool GetDateOfNNDS(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			if ((result.flags & ParseFlags.HaveYear) != (ParseFlags)0)
			{
				if ((result.flags & ParseFlags.HaveMonth) == (ParseFlags)0 && (result.flags & ParseFlags.HaveDay) == (ParseFlags)0 && DateTimeParse.TryAdjustYear(ref result, raw.year, out result.Year) && DateTimeParse.SetDateYMD(ref result, result.Year, raw.GetNumber(0), raw.GetNumber(1)))
				{
					return true;
				}
			}
			else if ((result.flags & ParseFlags.HaveMonth) != (ParseFlags)0 && (result.flags & ParseFlags.HaveYear) == (ParseFlags)0 && (result.flags & ParseFlags.HaveDay) == (ParseFlags)0)
			{
				int num;
				if (!DateTimeParse.GetYearMonthDayOrder(dtfi.ShortDatePattern, out num))
				{
					result.SetFailure(ParseFailureKind.Format_BadDatePattern, dtfi.ShortDatePattern);
					return false;
				}
				int year;
				if (num == 0)
				{
					if (DateTimeParse.TryAdjustYear(ref result, raw.GetNumber(0), out year) && DateTimeParse.SetDateYMD(ref result, year, result.Month, raw.GetNumber(1)))
					{
						return true;
					}
				}
				else if (DateTimeParse.TryAdjustYear(ref result, raw.GetNumber(1), out year) && DateTimeParse.SetDateYMD(ref result, year, result.Month, raw.GetNumber(0)))
				{
					return true;
				}
			}
			result.SetBadDateTimeFailure();
			return false;
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00035498 File Offset: 0x00033698
		private static bool ProcessDateTimeSuffix(ref DateTimeResult result, [ScopedRef] ref DateTimeRawInfo raw, [ScopedRef] ref DateTimeToken dtok)
		{
			TokenType suffix = dtok.suffix;
			if (suffix <= TokenType.SEP_DaySuff)
			{
				if (suffix != TokenType.SEP_YearSuff)
				{
					if (suffix != TokenType.SEP_MonthSuff)
					{
						if (suffix == TokenType.SEP_DaySuff)
						{
							if ((result.flags & ParseFlags.HaveDay) != (ParseFlags)0)
							{
								return false;
							}
							result.flags |= ParseFlags.HaveDay;
							result.Day = dtok.num;
						}
					}
					else
					{
						if ((result.flags & ParseFlags.HaveMonth) != (ParseFlags)0)
						{
							return false;
						}
						result.flags |= ParseFlags.HaveMonth;
						result.Month = (raw.month = dtok.num);
					}
				}
				else
				{
					if ((result.flags & ParseFlags.HaveYear) != (ParseFlags)0)
					{
						return false;
					}
					result.flags |= ParseFlags.HaveYear;
					result.Year = (raw.year = dtok.num);
				}
			}
			else if (suffix != TokenType.SEP_HourSuff)
			{
				if (suffix != TokenType.SEP_MinuteSuff)
				{
					if (suffix == TokenType.SEP_SecondSuff)
					{
						if ((result.flags & ParseFlags.HaveSecond) != (ParseFlags)0)
						{
							return false;
						}
						result.flags |= ParseFlags.HaveSecond;
						result.Second = dtok.num;
					}
				}
				else
				{
					if ((result.flags & ParseFlags.HaveMinute) != (ParseFlags)0)
					{
						return false;
					}
					result.flags |= ParseFlags.HaveMinute;
					result.Minute = dtok.num;
				}
			}
			else
			{
				if ((result.flags & ParseFlags.HaveHour) != (ParseFlags)0)
				{
					return false;
				}
				result.flags |= ParseFlags.HaveHour;
				result.Hour = dtok.num;
			}
			return true;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x000355F4 File Offset: 0x000337F4
		internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, [ScopedRef] ref DateTimeResult result, [ScopedRef] ref DateTimeStyles styles, [ScopedRef] ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			switch (dps)
			{
			case DateTimeParse.DS.DX_MN:
			case DateTimeParse.DS.DX_NM:
				DateTimeParse.GetDefaultYear(ref result, ref styles);
				if (!dtfi.YearMonthAdjustment(ref result.Year, ref raw.month, true))
				{
					result.SetFailure(ParseFailureKind.Format_BadDateTimeCalendar);
					return false;
				}
				if (!DateTimeParse.GetHebrewDayOfNM(ref result, ref raw, dtfi))
				{
					return false;
				}
				goto IL_188;
			case DateTimeParse.DS.DX_MNN:
				raw.year = raw.GetNumber(1);
				if (!dtfi.YearMonthAdjustment(ref raw.year, ref raw.month, true))
				{
					result.SetFailure(ParseFailureKind.Format_BadDateTimeCalendar);
					return false;
				}
				if (!DateTimeParse.GetDayOfMNN(ref result, ref raw, dtfi))
				{
					return false;
				}
				goto IL_188;
			case DateTimeParse.DS.DX_YMN:
				if (!dtfi.YearMonthAdjustment(ref raw.year, ref raw.month, true))
				{
					result.SetFailure(ParseFailureKind.Format_BadDateTimeCalendar);
					return false;
				}
				if (!DateTimeParse.GetDayOfYMN(ref result, ref raw))
				{
					return false;
				}
				goto IL_188;
			case DateTimeParse.DS.DX_YM:
				if (!dtfi.YearMonthAdjustment(ref raw.year, ref raw.month, true))
				{
					result.SetFailure(ParseFailureKind.Format_BadDateTimeCalendar);
					return false;
				}
				if (!DateTimeParse.GetDayOfYM(ref result, ref raw))
				{
					return false;
				}
				goto IL_188;
			case DateTimeParse.DS.TX_N:
				if (!DateTimeParse.GetTimeOfN(ref result, ref raw))
				{
					return false;
				}
				goto IL_188;
			case DateTimeParse.DS.TX_NN:
				if (!DateTimeParse.GetTimeOfNN(ref result, ref raw))
				{
					return false;
				}
				goto IL_188;
			case DateTimeParse.DS.TX_NNN:
				if (!DateTimeParse.GetTimeOfNNN(ref result, ref raw))
				{
					return false;
				}
				goto IL_188;
			case DateTimeParse.DS.DX_NNY:
				if (raw.year < 1000)
				{
					raw.year += 5000;
				}
				if (!DateTimeParse.GetDayOfNNY(ref result, ref raw, dtfi))
				{
					return false;
				}
				if (!dtfi.YearMonthAdjustment(ref result.Year, ref raw.month, true))
				{
					result.SetFailure(ParseFailureKind.Format_BadDateTimeCalendar);
					return false;
				}
				goto IL_188;
			}
			result.SetBadDateTimeFailure();
			return false;
			IL_188:
			if (dps > DateTimeParse.DS.ERROR)
			{
				raw.numCount = 0;
			}
			return true;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00035798 File Offset: 0x00033998
		internal static bool ProcessTerminalState(DateTimeParse.DS dps, [ScopedRef] ref DateTimeResult result, [ScopedRef] ref DateTimeStyles styles, [ScopedRef] ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
		{
			bool flag = true;
			switch (dps)
			{
			case DateTimeParse.DS.DX_NN:
				flag = DateTimeParse.GetDayOfNN(ref result, ref styles, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_NNN:
				flag = DateTimeParse.GetDayOfNNN(ref result, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_MN:
				flag = DateTimeParse.GetDayOfMN(ref result, ref styles, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_NM:
				flag = DateTimeParse.GetDayOfNM(ref result, ref styles, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_MNN:
				flag = DateTimeParse.GetDayOfMNN(ref result, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_DS:
				flag = true;
				break;
			case DateTimeParse.DS.DX_DSN:
				flag = DateTimeParse.GetDateOfDSN(ref result, ref raw);
				break;
			case DateTimeParse.DS.DX_NDS:
				flag = DateTimeParse.GetDateOfNDS(ref result, ref raw);
				break;
			case DateTimeParse.DS.DX_NNDS:
				flag = DateTimeParse.GetDateOfNNDS(ref result, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_YNN:
				flag = DateTimeParse.GetDayOfYNN(ref result, ref raw, dtfi);
				break;
			case DateTimeParse.DS.DX_YMN:
				flag = DateTimeParse.GetDayOfYMN(ref result, ref raw);
				break;
			case DateTimeParse.DS.DX_YN:
				flag = DateTimeParse.GetDayOfYN(ref result, ref raw);
				break;
			case DateTimeParse.DS.DX_YM:
				flag = DateTimeParse.GetDayOfYM(ref result, ref raw);
				break;
			case DateTimeParse.DS.TX_N:
				flag = DateTimeParse.GetTimeOfN(ref result, ref raw);
				break;
			case DateTimeParse.DS.TX_NN:
				flag = DateTimeParse.GetTimeOfNN(ref result, ref raw);
				break;
			case DateTimeParse.DS.TX_NNN:
				flag = DateTimeParse.GetTimeOfNNN(ref result, ref raw);
				break;
			case DateTimeParse.DS.TX_TS:
				flag = true;
				break;
			case DateTimeParse.DS.DX_NNY:
				flag = DateTimeParse.GetDayOfNNY(ref result, ref raw, dtfi);
				break;
			}
			if (!flag)
			{
				return false;
			}
			if (dps > DateTimeParse.DS.ERROR)
			{
				raw.numCount = 0;
			}
			return true;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x000358D4 File Offset: 0x00033AD4
		internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (DateTimeParse.TryParse(s, dtfi, styles, ref dateTimeResult))
			{
				return dateTimeResult.parsedDate;
			}
			throw DateTimeParse.GetDateTimeParseException(ref dateTimeResult);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0003590C File Offset: 0x00033B0C
		internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			dateTimeResult.flags |= ParseFlags.CaptureOffset;
			if (DateTimeParse.TryParse(s, dtfi, styles, ref dateTimeResult))
			{
				offset = dateTimeResult.timeZoneOffset;
				return dateTimeResult.parsedDate;
			}
			throw DateTimeParse.GetDateTimeParseException(ref dateTimeResult);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00035960 File Offset: 0x00033B60
		internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (DateTimeParse.TryParse(s, dtfi, styles, ref dateTimeResult))
			{
				result = dateTimeResult.parsedDate;
				return true;
			}
			result = DateTime.MinValue;
			return false;
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x000359A4 File Offset: 0x00033BA4
		internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset)
		{
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			dateTimeResult.flags |= ParseFlags.CaptureOffset;
			if (DateTimeParse.TryParse(s, dtfi, styles, ref dateTimeResult))
			{
				result = dateTimeResult.parsedDate;
				offset = dateTimeResult.timeZoneOffset;
				return true;
			}
			result = DateTime.MinValue;
			offset = TimeSpan.Zero;
			return false;
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00035A10 File Offset: 0x00033C10
		internal unsafe static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, [ScopedRef] ref DateTimeResult result)
		{
			if (s.Length == 0)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			DateTimeParse.DS ds = DateTimeParse.DS.BEGIN;
			bool flag = false;
			DateTimeToken dateTimeToken = default(DateTimeToken);
			dateTimeToken.suffix = TokenType.SEP_Unk;
			DateTimeRawInfo dateTimeRawInfo = default(DateTimeRawInfo);
			int* numberBuffer = stackalloc int[(UIntPtr)12];
			dateTimeRawInfo.Init(numberBuffer);
			dateTimeRawInfo.hasSameDateAndTimeSeparators = dtfi.DateSeparator.Equals(dtfi.TimeSeparator, StringComparison.Ordinal);
			result.calendar = dtfi.Calendar;
			result.era = 0;
			__DTString _DTString = new __DTString(s, dtfi);
			_DTString.GetNext();
			while (DateTimeParse.Lex(ds, ref _DTString, ref dateTimeToken, ref dateTimeRawInfo, ref result, ref dtfi, styles))
			{
				if (dateTimeToken.dtt != DateTimeParse.DTT.Unk)
				{
					if (dateTimeToken.suffix != TokenType.SEP_Unk)
					{
						if (!DateTimeParse.ProcessDateTimeSuffix(ref result, ref dateTimeRawInfo, ref dateTimeToken))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						dateTimeToken.suffix = TokenType.SEP_Unk;
					}
					if (dateTimeToken.dtt == DateTimeParse.DTT.NumLocalTimeMark)
					{
						if (ds == DateTimeParse.DS.D_YNd || ds == DateTimeParse.DS.D_YN)
						{
							return DateTimeParse.ParseISO8601(ref dateTimeRawInfo, ref _DTString, styles, ref result);
						}
						result.SetBadDateTimeFailure();
						return false;
					}
					else
					{
						if (dateTimeRawInfo.hasSameDateAndTimeSeparators)
						{
							if (dateTimeToken.dtt == DateTimeParse.DTT.YearEnd || dateTimeToken.dtt == DateTimeParse.DTT.YearSpace || dateTimeToken.dtt == DateTimeParse.DTT.YearDateSep)
							{
								if (ds == DateTimeParse.DS.T_Nt)
								{
									ds = DateTimeParse.DS.D_Nd;
								}
								if (ds == DateTimeParse.DS.T_NNt)
								{
									ds = DateTimeParse.DS.D_NNd;
								}
							}
							bool flag2 = _DTString.AtEnd();
							if (DateTimeParse.s_dateParsingStates[(int)ds][(int)dateTimeToken.dtt] == DateTimeParse.DS.ERROR || flag2)
							{
								DateTimeParse.DTT dtt = dateTimeToken.dtt;
								switch (dtt)
								{
								case DateTimeParse.DTT.NumDatesep:
									dateTimeToken.dtt = (flag2 ? DateTimeParse.DTT.NumEnd : DateTimeParse.DTT.NumSpace);
									break;
								case DateTimeParse.DTT.NumTimesep:
									dateTimeToken.dtt = (flag2 ? DateTimeParse.DTT.NumEnd : DateTimeParse.DTT.NumSpace);
									break;
								case DateTimeParse.DTT.MonthEnd:
								case DateTimeParse.DTT.MonthSpace:
									break;
								case DateTimeParse.DTT.MonthDatesep:
									dateTimeToken.dtt = (flag2 ? DateTimeParse.DTT.MonthEnd : DateTimeParse.DTT.MonthSpace);
									break;
								default:
									if (dtt == DateTimeParse.DTT.YearDateSep)
									{
										dateTimeToken.dtt = (flag2 ? DateTimeParse.DTT.YearEnd : DateTimeParse.DTT.YearSpace);
									}
									break;
								}
							}
						}
						ds = DateTimeParse.s_dateParsingStates[(int)ds][(int)dateTimeToken.dtt];
						if (ds == DateTimeParse.DS.ERROR)
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						if (ds > DateTimeParse.DS.ERROR)
						{
							if ((dtfi.FormatFlags & DateTimeFormatFlags.UseHebrewRule) != DateTimeFormatFlags.None)
							{
								if (!DateTimeParse.ProcessHebrewTerminalState(ds, ref result, ref styles, ref dateTimeRawInfo, dtfi))
								{
									return false;
								}
							}
							else if (!DateTimeParse.ProcessTerminalState(ds, ref result, ref styles, ref dateTimeRawInfo, dtfi))
							{
								return false;
							}
							flag = true;
							ds = DateTimeParse.DS.BEGIN;
						}
					}
				}
				if (dateTimeToken.dtt == DateTimeParse.DTT.End || dateTimeToken.dtt == DateTimeParse.DTT.NumEnd || dateTimeToken.dtt == DateTimeParse.DTT.MonthEnd)
				{
					if (!flag)
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					DateTimeParse.AdjustTimeMark(dtfi, ref dateTimeRawInfo);
					if (!DateTimeParse.AdjustHour(ref result.Hour, dateTimeRawInfo.timeMark))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					bool bTimeOnly = result.Year == -1 && result.Month == -1 && result.Day == -1;
					if (!DateTimeParse.CheckDefaultDateTime(ref result, ref result.calendar, styles))
					{
						return false;
					}
					DateTime dateTime;
					if (!result.calendar.TryToDateTime(result.Year, result.Month, result.Day, result.Hour, result.Minute, result.Second, 0, result.era, out dateTime))
					{
						result.SetFailure(ParseFailureKind.Format_BadDateTimeCalendar);
						return false;
					}
					if (dateTimeRawInfo.fraction > 0.0 && !dateTime.TryAddTicks((long)Math.Round(dateTimeRawInfo.fraction * 10000000.0), out dateTime))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					if (dateTimeRawInfo.dayOfWeek != -1 && dateTimeRawInfo.dayOfWeek != (int)result.calendar.GetDayOfWeek(dateTime))
					{
						result.SetFailure(ParseFailureKind.Format_BadDayOfWeek);
						return false;
					}
					result.parsedDate = dateTime;
					return DateTimeParse.DetermineTimeZoneAdjustments(ref result, styles, bTimeOnly);
				}
			}
			return false;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00035D5C File Offset: 0x00033F5C
		private static bool DetermineTimeZoneAdjustments(ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly)
		{
			if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0)
			{
				return DateTimeParse.DateTimeOffsetTimeZonePostProcessing(ref result, styles);
			}
			long ticks = result.timeZoneOffset.Ticks;
			if (ticks < -504000000000L || ticks > 504000000000L)
			{
				result.SetFailure(ParseFailureKind.Format_OffsetOutOfRange);
				return false;
			}
			if ((result.flags & ParseFlags.TimeZoneUsed) == (ParseFlags)0)
			{
				if ((styles & DateTimeStyles.AssumeLocal) != DateTimeStyles.None)
				{
					if ((styles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.None)
					{
						result.parsedDate = DateTime.SpecifyKind(result.parsedDate, DateTimeKind.Local);
						return true;
					}
					result.flags |= ParseFlags.TimeZoneUsed;
					result.timeZoneOffset = TimeZoneInfo.GetLocalUtcOffset(result.parsedDate, TimeZoneInfoOptions.NoThrowOnInvalidTime);
				}
				else
				{
					if ((styles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.None)
					{
						return true;
					}
					if ((styles & DateTimeStyles.AdjustToUniversal) != DateTimeStyles.None)
					{
						result.parsedDate = DateTime.SpecifyKind(result.parsedDate, DateTimeKind.Utc);
						return true;
					}
					result.flags |= ParseFlags.TimeZoneUsed;
					result.timeZoneOffset = TimeSpan.Zero;
				}
			}
			if ((styles & DateTimeStyles.RoundtripKind) != DateTimeStyles.None && (result.flags & ParseFlags.TimeZoneUtc) != (ParseFlags)0)
			{
				result.parsedDate = DateTime.SpecifyKind(result.parsedDate, DateTimeKind.Utc);
				return true;
			}
			if ((styles & DateTimeStyles.AdjustToUniversal) != DateTimeStyles.None)
			{
				return DateTimeParse.AdjustTimeZoneToUniversal(ref result);
			}
			return DateTimeParse.AdjustTimeZoneToLocal(ref result, bTimeOnly);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00035E80 File Offset: 0x00034080
		private static bool DateTimeOffsetTimeZonePostProcessing(ref DateTimeResult result, DateTimeStyles styles)
		{
			if ((result.flags & ParseFlags.TimeZoneUsed) == (ParseFlags)0)
			{
				if ((styles & DateTimeStyles.AssumeUniversal) != DateTimeStyles.None)
				{
					result.timeZoneOffset = TimeSpan.Zero;
				}
				else
				{
					result.timeZoneOffset = TimeZoneInfo.GetLocalUtcOffset(result.parsedDate, TimeZoneInfoOptions.NoThrowOnInvalidTime);
				}
			}
			long ticks = result.timeZoneOffset.Ticks;
			long num = result.parsedDate.Ticks - ticks;
			if (num < 0L || num > 3155378975999999999L)
			{
				result.SetFailure(ParseFailureKind.Format_UTCOutOfRange);
				return false;
			}
			if (ticks < -504000000000L || ticks > 504000000000L)
			{
				result.SetFailure(ParseFailureKind.Format_OffsetOutOfRange);
				return false;
			}
			if ((styles & DateTimeStyles.AdjustToUniversal) != DateTimeStyles.None)
			{
				if ((result.flags & ParseFlags.TimeZoneUsed) == (ParseFlags)0 && (styles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.None)
				{
					bool result2 = DateTimeParse.AdjustTimeZoneToUniversal(ref result);
					result.timeZoneOffset = TimeSpan.Zero;
					return result2;
				}
				result.parsedDate = new DateTime(num, DateTimeKind.Utc);
				result.timeZoneOffset = TimeSpan.Zero;
			}
			return true;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00035F5C File Offset: 0x0003415C
		private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result)
		{
			long num = result.parsedDate.Ticks;
			num -= result.timeZoneOffset.Ticks;
			if (num < 0L)
			{
				num += 864000000000L;
			}
			if (num < 0L || num > 3155378975999999999L)
			{
				result.SetFailure(ParseFailureKind.Format_DateOutOfRange);
				return false;
			}
			result.parsedDate = new DateTime(num, DateTimeKind.Utc);
			return true;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00035FBC File Offset: 0x000341BC
		private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly)
		{
			long num = result.parsedDate.Ticks;
			TimeZoneInfo local = TimeZoneInfo.Local;
			bool isAmbiguousDst = false;
			if (num < 864000000000L)
			{
				num -= result.timeZoneOffset.Ticks;
				num += local.GetUtcOffset(bTimeOnly ? DateTime.Now : result.parsedDate, TimeZoneInfoOptions.NoThrowOnInvalidTime).Ticks;
				if (num < 0L)
				{
					num += 864000000000L;
				}
			}
			else
			{
				num -= result.timeZoneOffset.Ticks;
				if (num < 0L || num > 3155378975999999999L)
				{
					num += local.GetUtcOffset(result.parsedDate, TimeZoneInfoOptions.NoThrowOnInvalidTime).Ticks;
				}
				else
				{
					DateTime time = new DateTime(num, DateTimeKind.Utc);
					bool flag;
					num += TimeZoneInfo.GetUtcOffsetFromUtc(time, TimeZoneInfo.Local, out flag, out isAmbiguousDst).Ticks;
				}
			}
			if (num < 0L || num > 3155378975999999999L)
			{
				result.parsedDate = DateTime.MinValue;
				result.SetFailure(ParseFailureKind.Format_DateOutOfRange);
				return false;
			}
			result.parsedDate = new DateTime(num, DateTimeKind.Local, isAmbiguousDst);
			return true;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x000360C0 File Offset: 0x000342C0
		private static bool ParseISO8601([ScopedRef] ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, [ScopedRef] ref DateTimeResult result)
		{
			str.Index--;
			int second = 0;
			double num = 0.0;
			str.SkipWhiteSpaces();
			int hour;
			if (!DateTimeParse.ParseDigits(ref str, 2, out hour))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			str.SkipWhiteSpaces();
			if (!str.Match(':'))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			str.SkipWhiteSpaces();
			int minute;
			if (!DateTimeParse.ParseDigits(ref str, 2, out minute))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			str.SkipWhiteSpaces();
			if (str.Match(':'))
			{
				str.SkipWhiteSpaces();
				if (!DateTimeParse.ParseDigits(ref str, 2, out second))
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				if (str.Match('.') || str.Match(','))
				{
					if (!DateTimeParse.ParseFraction(ref str, out num))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					str.Index--;
				}
				str.SkipWhiteSpaces();
			}
			if (str.GetNext())
			{
				char @char = str.GetChar();
				if (@char == '+' || @char == '-')
				{
					result.flags |= ParseFlags.TimeZoneUsed;
					if (!DateTimeParse.ParseTimeZone(ref str, ref result.timeZoneOffset))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					str.Index--;
				}
				else if (@char == 'Z' || @char == 'z')
				{
					result.flags |= ParseFlags.TimeZoneUsed;
					result.timeZoneOffset = TimeSpan.Zero;
					result.flags |= ParseFlags.TimeZoneUtc;
				}
				else
				{
					str.Index--;
				}
				str.SkipWhiteSpaces();
				if (str.Match('#'))
				{
					if (!DateTimeParse.VerifyValidPunctuation(ref str))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					str.SkipWhiteSpaces();
				}
				if (str.Match('\0') && !DateTimeParse.VerifyValidPunctuation(ref str))
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				if (str.GetNext())
				{
					result.SetBadDateTimeFailure();
					return false;
				}
			}
			DateTime parsedDate;
			if (!GregorianCalendar.GetDefaultInstance().TryToDateTime(raw.year, raw.GetNumber(0), raw.GetNumber(1), hour, minute, second, 0, result.era, out parsedDate))
			{
				result.SetFailure(ParseFailureKind.Format_BadDateTimeCalendar);
				return false;
			}
			if (!parsedDate.TryAddTicks((long)Math.Round(num * 10000000.0), out parsedDate))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			result.parsedDate = parsedDate;
			return DateTimeParse.DetermineTimeZoneAdjustments(ref result, styles, false);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000362DC File Offset: 0x000344DC
		internal static bool MatchHebrewDigits(ref __DTString str, out int number)
		{
			number = 0;
			HebrewNumberParsingContext hebrewNumberParsingContext = new HebrewNumberParsingContext(0);
			HebrewNumberParsingState hebrewNumberParsingState = HebrewNumberParsingState.ContinueParsing;
			while (hebrewNumberParsingState == HebrewNumberParsingState.ContinueParsing && str.GetNext())
			{
				hebrewNumberParsingState = HebrewNumber.ParseByChar(str.GetChar(), ref hebrewNumberParsingContext);
			}
			if (hebrewNumberParsingState == HebrewNumberParsingState.FoundEndOfHebrewNumber)
			{
				number = hebrewNumberParsingContext.result;
				return true;
			}
			return false;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00036321 File Offset: 0x00034521
		internal static bool ParseDigits(ref __DTString str, int digitLen, out int result)
		{
			if (digitLen == 1)
			{
				return DateTimeParse.ParseDigits(ref str, 1, 2, out result);
			}
			return DateTimeParse.ParseDigits(ref str, digitLen, digitLen, out result);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0003633C File Offset: 0x0003453C
		internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result)
		{
			int num = 0;
			int index = str.Index;
			int i;
			for (i = 0; i < maxDigitLen; i++)
			{
				if (!str.GetNextDigit())
				{
					str.Index--;
					break;
				}
				num = num * 10 + str.GetDigit();
			}
			result = num;
			if (i < minDigitLen)
			{
				str.Index = index;
				return false;
			}
			return true;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00036390 File Offset: 0x00034590
		private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, [ScopedRef] ref double result)
		{
			if (!str.GetNextDigit())
			{
				str.Index--;
				return false;
			}
			result = (double)str.GetDigit();
			int i;
			for (i = 1; i < maxDigitLen; i++)
			{
				if (!str.GetNextDigit())
				{
					str.Index--;
					break;
				}
				result = result * 10.0 + (double)str.GetDigit();
			}
			result /= (double)TimeSpanParse.Pow10UpToMaxFractionDigits(i);
			return i == maxDigitLen;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00036404 File Offset: 0x00034604
		private static bool ParseSign(ref __DTString str, [ScopedRef] ref bool result)
		{
			if (!str.GetNext())
			{
				return false;
			}
			char @char = str.GetChar();
			if (@char == '+')
			{
				result = true;
				return true;
			}
			if (@char == '-')
			{
				result = false;
				return true;
			}
			return false;
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00036438 File Offset: 0x00034638
		private static bool ParseTimeZoneOffset(ref __DTString str, int len, [ScopedRef] ref TimeSpan result)
		{
			bool flag = true;
			int num = 0;
			int hours;
			if (len - 1 <= 1)
			{
				if (!DateTimeParse.ParseSign(ref str, ref flag))
				{
					return false;
				}
				if (!DateTimeParse.ParseDigits(ref str, len, out hours))
				{
					return false;
				}
			}
			else
			{
				if (!DateTimeParse.ParseSign(ref str, ref flag))
				{
					return false;
				}
				if (!DateTimeParse.ParseDigits(ref str, 1, out hours))
				{
					return false;
				}
				if (str.Match(":"))
				{
					if (!DateTimeParse.ParseDigits(ref str, 2, out num))
					{
						return false;
					}
				}
				else
				{
					str.Index--;
					if (!DateTimeParse.ParseDigits(ref str, 2, out num))
					{
						return false;
					}
				}
			}
			if (num < 0 || num >= 60)
			{
				return false;
			}
			result = new TimeSpan(hours, num, 0);
			if (!flag)
			{
				result = result.Negate();
			}
			return true;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x000364DC File Offset: 0x000346DC
		private unsafe static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, [ScopedRef] ref int result)
		{
			int num = 0;
			result = -1;
			if (str.GetNext())
			{
				if (dtfi == DateTimeFormat.InvariantFormatInfo)
				{
					ReadOnlySpan<char> readOnlySpan = str.Value.Slice(str.Index);
					if (readOnlySpan.Length >= 3)
					{
						uint num2 = (uint)(*readOnlySpan[0]);
						uint num3 = (uint)(*readOnlySpan[1]);
						uint num4 = (uint)(*readOnlySpan[2]);
						if ((num2 | num3 | num4) <= 127U)
						{
							num = 3;
							uint num5 = num2 << 16 | num3 << 8 | num4 | 2105376U;
							if (num5 <= 6976876U)
							{
								if (num5 <= 6579555U)
								{
									if (num5 == 6385778U)
									{
										result = 4;
										goto IL_1DB;
									}
									if (num5 == 6387047U)
									{
										result = 8;
										goto IL_1DB;
									}
									if (num5 == 6579555U)
									{
										result = 12;
										goto IL_1DB;
									}
								}
								else
								{
									if (num5 == 6710626U)
									{
										result = 2;
										goto IL_1DB;
									}
									if (num5 == 6971758U)
									{
										result = 1;
										goto IL_1DB;
									}
									if (num5 == 6976876U)
									{
										result = 7;
										goto IL_1DB;
									}
								}
							}
							else if (num5 <= 7168377U)
							{
								if (num5 == 6976878U)
								{
									result = 6;
									goto IL_1DB;
								}
								if (num5 == 7168370U)
								{
									result = 3;
									goto IL_1DB;
								}
								if (num5 == 7168377U)
								{
									result = 5;
									goto IL_1DB;
								}
							}
							else
							{
								if (num5 == 7237494U)
								{
									result = 11;
									goto IL_1DB;
								}
								if (num5 == 7299956U)
								{
									result = 10;
									goto IL_1DB;
								}
								if (num5 == 7562608U)
								{
									result = 9;
									goto IL_1DB;
								}
							}
							num = 0;
						}
					}
				}
				else
				{
					int num6 = (dtfi.GetAbbreviatedMonthName(13).Length == 0) ? 12 : 13;
					for (int i = 1; i <= num6; i++)
					{
						string abbreviatedMonthName = dtfi.GetAbbreviatedMonthName(i);
						int length = abbreviatedMonthName.Length;
						if ((dtfi.HasSpacesInMonthNames ? str.MatchSpecifiedWords(abbreviatedMonthName, false, ref length) : str.MatchSpecifiedWord(abbreviatedMonthName)) && length > num)
						{
							num = length;
							result = i;
						}
					}
				}
				IL_1DB:
				if ((dtfi.FormatFlags & DateTimeFormatFlags.UseGenitiveMonth) != DateTimeFormatFlags.None)
				{
					int num7 = str.MatchLongestWords(dtfi.InternalGetGenitiveMonthNames(true), ref num);
					if (num7 >= 0)
					{
						result = num7 + 1;
					}
				}
				if ((dtfi.FormatFlags & DateTimeFormatFlags.UseLeapYearMonth) != DateTimeFormatFlags.None)
				{
					int num8 = str.MatchLongestWords(dtfi.InternalGetLeapYearMonthNames(), ref num);
					if (num8 >= 0)
					{
						result = num8 + 1;
					}
				}
			}
			if (result > 0)
			{
				str.Index += num - 1;
				return true;
			}
			return false;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00036724 File Offset: 0x00034924
		private unsafe static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, [ScopedRef] ref int result)
		{
			int num = 0;
			result = -1;
			if (str.GetNext())
			{
				if (dtfi == DateTimeFormat.InvariantFormatInfo)
				{
					ReadOnlySpan<char> span = str.Value.Slice(str.Index);
					if (span.Length >= 3)
					{
						uint num2 = (uint)(*span[0]);
						uint num3 = (uint)(*span[1]);
						uint num4 = (uint)(*span[2]);
						if ((num2 | num3 | num4) <= 127U)
						{
							uint num5 = num2 << 16 | num3 << 8 | num4 | 2105376U;
							if (num5 <= 6976876U)
							{
								if (num5 <= 6579555U)
								{
									if (num5 != 6385778U)
									{
										if (num5 != 6387047U)
										{
											if (num5 == 6579555U)
											{
												DateTimeParse.SetIfStartsWith(span, "December", 12, ref result, ref num);
											}
										}
										else
										{
											DateTimeParse.SetIfStartsWith(span, "August", 8, ref result, ref num);
										}
									}
									else
									{
										DateTimeParse.SetIfStartsWith(span, "April", 4, ref result, ref num);
									}
								}
								else if (num5 != 6710626U)
								{
									if (num5 != 6971758U)
									{
										if (num5 == 6976876U)
										{
											DateTimeParse.SetIfStartsWith(span, "July", 7, ref result, ref num);
										}
									}
									else
									{
										DateTimeParse.SetIfStartsWith(span, "January", 1, ref result, ref num);
									}
								}
								else
								{
									DateTimeParse.SetIfStartsWith(span, "February", 2, ref result, ref num);
								}
							}
							else if (num5 <= 7168377U)
							{
								if (num5 != 6976878U)
								{
									if (num5 != 7168370U)
									{
										if (num5 == 7168377U)
										{
											DateTimeParse.SetIfStartsWith(span, "May", 5, ref result, ref num);
										}
									}
									else
									{
										DateTimeParse.SetIfStartsWith(span, "March", 3, ref result, ref num);
									}
								}
								else
								{
									DateTimeParse.SetIfStartsWith(span, "June", 6, ref result, ref num);
								}
							}
							else if (num5 != 7237494U)
							{
								if (num5 != 7299956U)
								{
									if (num5 == 7562608U)
									{
										DateTimeParse.SetIfStartsWith(span, "September", 9, ref result, ref num);
									}
								}
								else
								{
									DateTimeParse.SetIfStartsWith(span, "October", 10, ref result, ref num);
								}
							}
							else
							{
								DateTimeParse.SetIfStartsWith(span, "November", 11, ref result, ref num);
							}
						}
					}
				}
				else
				{
					int num6 = (dtfi.GetMonthName(13).Length == 0) ? 12 : 13;
					for (int i = 1; i <= num6; i++)
					{
						string monthName = dtfi.GetMonthName(i);
						int length = monthName.Length;
						if ((dtfi.HasSpacesInMonthNames ? str.MatchSpecifiedWords(monthName, false, ref length) : str.MatchSpecifiedWord(monthName)) && length > num)
						{
							num = length;
							result = i;
						}
					}
				}
				if ((dtfi.FormatFlags & DateTimeFormatFlags.UseGenitiveMonth) != DateTimeFormatFlags.None)
				{
					int num7 = str.MatchLongestWords(dtfi.InternalGetGenitiveMonthNames(false), ref num);
					if (num7 >= 0)
					{
						result = num7 + 1;
					}
				}
				if ((dtfi.FormatFlags & DateTimeFormatFlags.UseLeapYearMonth) != DateTimeFormatFlags.None)
				{
					int num8 = str.MatchLongestWords(dtfi.InternalGetLeapYearMonthNames(), ref num);
					if (num8 >= 0)
					{
						result = num8 + 1;
					}
				}
			}
			if (result > 0)
			{
				str.Index += num - 1;
				return true;
			}
			return false;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00036A14 File Offset: 0x00034C14
		private unsafe static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, [ScopedRef] ref int result)
		{
			int num = 0;
			result = -1;
			if (str.GetNext())
			{
				if (dtfi == DateTimeFormat.InvariantFormatInfo)
				{
					ReadOnlySpan<char> readOnlySpan = str.Value.Slice(str.Index);
					if (readOnlySpan.Length >= 3)
					{
						uint num2 = (uint)(*readOnlySpan[0]);
						uint num3 = (uint)(*readOnlySpan[1]);
						uint num4 = (uint)(*readOnlySpan[2]);
						if ((num2 | num3 | num4) <= 127U)
						{
							num = 3;
							uint num5 = num2 << 16 | num3 << 8 | num4 | 2105376U;
							if (num5 <= 7561588U)
							{
								if (num5 == 6713961U)
								{
									result = 5;
									goto IL_147;
								}
								if (num5 == 7171950U)
								{
									result = 1;
									goto IL_147;
								}
								if (num5 == 7561588U)
								{
									result = 6;
									goto IL_147;
								}
							}
							else if (num5 <= 7628917U)
							{
								if (num5 == 7566702U)
								{
									result = 0;
									goto IL_147;
								}
								if (num5 == 7628917U)
								{
									result = 4;
									goto IL_147;
								}
							}
							else
							{
								if (num5 == 7632229U)
								{
									result = 2;
									goto IL_147;
								}
								if (num5 == 7824740U)
								{
									result = 3;
									goto IL_147;
								}
							}
							num = 0;
						}
					}
				}
				else
				{
					for (DayOfWeek dayOfWeek = DayOfWeek.Sunday; dayOfWeek <= DayOfWeek.Saturday; dayOfWeek++)
					{
						string abbreviatedDayName = dtfi.GetAbbreviatedDayName(dayOfWeek);
						int length = abbreviatedDayName.Length;
						if ((dtfi.HasSpacesInDayNames ? str.MatchSpecifiedWords(abbreviatedDayName, false, ref length) : str.MatchSpecifiedWord(abbreviatedDayName)) && length > num)
						{
							num = length;
							result = (int)dayOfWeek;
						}
					}
				}
			}
			IL_147:
			if (result >= 0)
			{
				str.Index += num - 1;
				return true;
			}
			return false;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00036B80 File Offset: 0x00034D80
		private unsafe static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, [ScopedRef] ref int result)
		{
			int num = 0;
			result = -1;
			if (str.GetNext())
			{
				if (dtfi == DateTimeFormat.InvariantFormatInfo)
				{
					ReadOnlySpan<char> span = str.Value.Slice(str.Index);
					if (span.Length >= 3)
					{
						uint num2 = (uint)(*span[0]);
						uint num3 = (uint)(*span[1]);
						uint num4 = (uint)(*span[2]);
						if ((num2 | num3 | num4) <= 127U)
						{
							uint num5 = num2 << 16 | num3 << 8 | num4 | 2105376U;
							if (num5 <= 7561588U)
							{
								if (num5 != 6713961U)
								{
									if (num5 != 7171950U)
									{
										if (num5 == 7561588U)
										{
											DateTimeParse.SetIfStartsWith(span, "Saturday", 6, ref result, ref num);
										}
									}
									else
									{
										DateTimeParse.SetIfStartsWith(span, "Monday", 1, ref result, ref num);
									}
								}
								else
								{
									DateTimeParse.SetIfStartsWith(span, "Friday", 5, ref result, ref num);
								}
							}
							else if (num5 <= 7628917U)
							{
								if (num5 != 7566702U)
								{
									if (num5 == 7628917U)
									{
										DateTimeParse.SetIfStartsWith(span, "Thursday", 4, ref result, ref num);
									}
								}
								else
								{
									DateTimeParse.SetIfStartsWith(span, "Sunday", 0, ref result, ref num);
								}
							}
							else if (num5 != 7632229U)
							{
								if (num5 == 7824740U)
								{
									DateTimeParse.SetIfStartsWith(span, "Wednesday", 3, ref result, ref num);
								}
							}
							else
							{
								DateTimeParse.SetIfStartsWith(span, "Tuesday", 2, ref result, ref num);
							}
						}
					}
				}
				else
				{
					for (DayOfWeek dayOfWeek = DayOfWeek.Sunday; dayOfWeek <= DayOfWeek.Saturday; dayOfWeek++)
					{
						string dayName = dtfi.GetDayName(dayOfWeek);
						int length = dayName.Length;
						if ((dtfi.HasSpacesInDayNames ? str.MatchSpecifiedWords(dayName, false, ref length) : str.MatchSpecifiedWord(dayName)) && length > num)
						{
							num = length;
							result = (int)dayOfWeek;
						}
					}
				}
			}
			if (result >= 0)
			{
				str.Index += num - 1;
				return true;
			}
			return false;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00036D52 File Offset: 0x00034F52
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void SetIfStartsWith(ReadOnlySpan<char> span, [ConstantExpected] string match, int matchResult, [ScopedRef] ref int result, ref int maxMatchStrLen)
		{
			if (span.StartsWith(match, StringComparison.OrdinalIgnoreCase))
			{
				result = matchResult;
				maxMatchStrLen = match.Length;
			}
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00036D70 File Offset: 0x00034F70
		private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, [ScopedRef] ref int result)
		{
			if (str.GetNext())
			{
				int[] eras = dtfi.Calendar.Eras;
				if (eras != null)
				{
					for (int i = 0; i < eras.Length; i++)
					{
						string text = dtfi.GetEraName(eras[i]);
						if (str.MatchSpecifiedWord(text))
						{
							str.Index += text.Length - 1;
							result = eras[i];
							return true;
						}
						text = dtfi.GetAbbreviatedEraName(eras[i]);
						if (str.MatchSpecifiedWord(text))
						{
							str.Index += text.Length - 1;
							result = eras[i];
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00036DFC File Offset: 0x00034FFC
		private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, [ScopedRef] ref DateTimeParse.TM result)
		{
			result = DateTimeParse.TM.NotSet;
			if (dtfi.AMDesignator.Length == 0)
			{
				result = DateTimeParse.TM.AM;
			}
			if (dtfi.PMDesignator.Length == 0)
			{
				result = DateTimeParse.TM.PM;
			}
			if (str.GetNext())
			{
				string text = dtfi.AMDesignator;
				if (text.Length > 0 && str.MatchSpecifiedWord(text))
				{
					str.Index += text.Length - 1;
					result = DateTimeParse.TM.AM;
					return true;
				}
				text = dtfi.PMDesignator;
				if (text.Length > 0 && str.MatchSpecifiedWord(text))
				{
					str.Index += text.Length - 1;
					result = DateTimeParse.TM.PM;
					return true;
				}
				str.Index--;
			}
			return result != DateTimeParse.TM.NotSet;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00036EA8 File Offset: 0x000350A8
		private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, [ScopedRef] ref DateTimeParse.TM result)
		{
			if (str.GetNext())
			{
				string amdesignator = dtfi.AMDesignator;
				if (amdesignator.Length > 0 && str.GetChar() == amdesignator[0])
				{
					result = DateTimeParse.TM.AM;
					return true;
				}
				string pmdesignator = dtfi.PMDesignator;
				if (pmdesignator.Length > 0 && str.GetChar() == pmdesignator[0])
				{
					result = DateTimeParse.TM.PM;
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00036F06 File Offset: 0x00035106
		private static bool CheckNewValue([ScopedRef] ref int currentValue, int newValue, char patternChar, [ScopedRef] ref DateTimeResult result)
		{
			if (currentValue == -1)
			{
				currentValue = newValue;
				return true;
			}
			if (newValue != currentValue)
			{
				result.SetFailure(ParseFailureKind.Format_RepeatDateTimePattern, (int)patternChar);
				return false;
			}
			return true;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x00036F24 File Offset: 0x00035124
		private static DateTime GetDateTimeNow([ScopedRef] ref DateTimeResult result, [ScopedRef] ref DateTimeStyles styles)
		{
			if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0)
			{
				if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0)
				{
					return new DateTime(DateTime.UtcNow.Ticks + result.timeZoneOffset.Ticks, DateTimeKind.Unspecified);
				}
				if ((styles & DateTimeStyles.AssumeUniversal) != DateTimeStyles.None)
				{
					return DateTime.UtcNow;
				}
			}
			return DateTime.Now;
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00036F80 File Offset: 0x00035180
		private static bool CheckDefaultDateTime([ScopedRef] ref DateTimeResult result, [ScopedRef] ref Calendar cal, DateTimeStyles styles)
		{
			if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0 && (result.Month != -1 || result.Day != -1) && (result.Year == -1 || (result.flags & ParseFlags.YearDefault) != (ParseFlags)0) && (result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0)
			{
				result.SetFailure(ParseFailureKind.Format_MissingIncompleteDate);
				return false;
			}
			if (result.Year == -1 || result.Month == -1 || result.Day == -1)
			{
				DateTime dateTimeNow = DateTimeParse.GetDateTimeNow(ref result, ref styles);
				if (result.Month == -1 && result.Day == -1)
				{
					if (result.Year == -1)
					{
						if ((styles & DateTimeStyles.NoCurrentDateDefault) != DateTimeStyles.None)
						{
							cal = GregorianCalendar.GetDefaultInstance();
							result.Year = (result.Month = (result.Day = 1));
						}
						else
						{
							result.Year = cal.GetYear(dateTimeNow);
							result.Month = cal.GetMonth(dateTimeNow);
							result.Day = cal.GetDayOfMonth(dateTimeNow);
						}
					}
					else
					{
						result.Month = 1;
						result.Day = 1;
					}
				}
				else
				{
					if (result.Year == -1)
					{
						result.Year = cal.GetYear(dateTimeNow);
					}
					if (result.Month == -1)
					{
						result.Month = 1;
					}
					if (result.Day == -1)
					{
						result.Day = 1;
					}
				}
			}
			if (result.Hour == -1)
			{
				result.Hour = 0;
			}
			if (result.Minute == -1)
			{
				result.Minute = 0;
			}
			if (result.Second == -1)
			{
				result.Second = 0;
			}
			if (result.era == -1)
			{
				result.era = 0;
			}
			return true;
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x000370FC File Offset: 0x000352FC
		private static string ExpandPredefinedFormat(char format, [ScopedRef] ref DateTimeFormatInfo dtfi, [ScopedRef] ref ParsingInfo parseInfo, [ScopedRef] ref DateTimeResult result)
		{
			if (format <= 'R')
			{
				if (format != 'O')
				{
					if (format != 'R')
					{
						goto IL_132;
					}
					goto IL_5D;
				}
			}
			else if (format != 'U')
			{
				switch (format)
				{
				case 'o':
				case 's':
					break;
				case 'p':
				case 'q':
				case 't':
					goto IL_132;
				case 'r':
					goto IL_5D;
				case 'u':
					parseInfo.calendar = GregorianCalendar.GetDefaultInstance();
					dtfi = DateTimeFormatInfo.InvariantInfo;
					if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0)
					{
						result.flags |= ParseFlags.UtcSortPattern;
						goto IL_132;
					}
					goto IL_132;
				default:
					goto IL_132;
				}
			}
			else
			{
				parseInfo.calendar = GregorianCalendar.GetDefaultInstance();
				result.flags |= ParseFlags.TimeZoneUsed;
				result.timeZoneOffset = new TimeSpan(0L);
				result.flags |= ParseFlags.TimeZoneUtc;
				if (dtfi.Calendar.GetType() != typeof(GregorianCalendar))
				{
					dtfi = (DateTimeFormatInfo)dtfi.Clone();
					dtfi.Calendar = GregorianCalendar.GetDefaultInstance();
					goto IL_132;
				}
				goto IL_132;
			}
			parseInfo.calendar = GregorianCalendar.GetDefaultInstance();
			dtfi = DateTimeFormatInfo.InvariantInfo;
			goto IL_132;
			IL_5D:
			parseInfo.calendar = GregorianCalendar.GetDefaultInstance();
			dtfi = DateTimeFormatInfo.InvariantInfo;
			if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0)
			{
				result.flags |= ParseFlags.Rfc1123Pattern;
			}
			IL_132:
			return DateTimeFormat.ExpandStandardFormatToCustomPattern(format, dtfi);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00037244 File Offset: 0x00035444
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ParseJapaneseEraStart(ref __DTString str, DateTimeFormatInfo dtfi)
		{
			if (LocalAppContextSwitches.EnforceLegacyJapaneseDateParsing || dtfi.Calendar.ID != CalendarId.JAPAN || !str.GetNext())
			{
				return false;
			}
			if (str.m_current != "元"[0])
			{
				str.Index--;
				return false;
			}
			return true;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00037294 File Offset: 0x00035494
		private unsafe static bool ParseByFormat(ref __DTString str, ref __DTString format, [ScopedRef] ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, [ScopedRef] ref DateTimeResult result)
		{
			int newValue = 0;
			int newValue2 = 0;
			int newValue3 = 0;
			int newValue4 = 0;
			int newValue5 = 0;
			int newValue6 = 0;
			int newValue7 = 0;
			double num = 0.0;
			DateTimeParse.TM tm = DateTimeParse.TM.AM;
			char @char = format.GetChar();
			int repeatCount;
			if (@char <= 'K')
			{
				if (@char <= '.')
				{
					if (@char <= '%')
					{
						if (@char != '"')
						{
							if (@char != '%')
							{
								goto IL_8EB;
							}
							if (format.Index >= format.Value.Length - 1 || *format.Value[format.Index + 1] == 37)
							{
								result.SetBadFormatSpecifierFailure(format.Value);
								return false;
							}
							return true;
						}
					}
					else if (@char != '\'')
					{
						if (@char != '.')
						{
							goto IL_8EB;
						}
						if (str.Match(@char))
						{
							return true;
						}
						if (format.GetNext() && format.Match('F'))
						{
							format.GetRepeatCount();
							return true;
						}
						result.SetBadDateTimeFailure();
						return false;
					}
					Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
					ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
					if (!DateTimeParse.TryParseQuoteString(format.Value, format.Index, ref valueStringBuilder, out repeatCount))
					{
						result.SetFailure(ParseFailureKind.Format_BadQuote, (int)@char);
						valueStringBuilder.Dispose();
						return false;
					}
					format.Index += repeatCount - 1;
					ReadOnlySpan<char> span = valueStringBuilder.AsSpan();
					for (int i = 0; i < span.Length; i++)
					{
						if (parseInfo.fAllowInnerWhite && char.IsWhiteSpace((char)(*span[i])))
						{
							str.SkipWhiteSpaces();
						}
						else if (!str.Match((char)(*span[i])))
						{
							result.SetBadDateTimeFailure();
							valueStringBuilder.Dispose();
							return false;
						}
					}
					if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0 && (((result.flags & ParseFlags.Rfc1123Pattern) != (ParseFlags)0 && span.SequenceEqual("GMT")) || ((result.flags & ParseFlags.UtcSortPattern) != (ParseFlags)0 && span.SequenceEqual("Z"))))
					{
						result.flags |= ParseFlags.TimeZoneUsed;
						result.timeZoneOffset = TimeSpan.Zero;
					}
					valueStringBuilder.Dispose();
					return true;
				}
				else if (@char <= ':')
				{
					if (@char != '/')
					{
						if (@char != ':')
						{
							goto IL_8EB;
						}
						if (((dtfi.TimeSeparator.Length > 1 && dtfi.TimeSeparator[0] == ':') || !str.Match(':')) && !str.Match(dtfi.TimeSeparator))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						return true;
					}
					else
					{
						if (((dtfi.DateSeparator.Length > 1 && dtfi.DateSeparator[0] == '/') || !str.Match('/')) && !str.Match(dtfi.DateSeparator))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						return true;
					}
				}
				else if (@char != 'F')
				{
					if (@char != 'H')
					{
						if (@char != 'K')
						{
							goto IL_8EB;
						}
						if (str.Match('Z'))
						{
							if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0 && result.timeZoneOffset != TimeSpan.Zero)
							{
								result.SetFailure(ParseFailureKind.Format_RepeatDateTimePattern, 75);
								return false;
							}
							result.flags |= ParseFlags.TimeZoneUsed;
							result.timeZoneOffset = new TimeSpan(0L);
							result.flags |= ParseFlags.TimeZoneUtc;
							return true;
						}
						else
						{
							if (!str.Match('+') && !str.Match('-'))
							{
								return true;
							}
							str.Index--;
							TimeSpan timeSpan = new TimeSpan(0L);
							if (!DateTimeParse.ParseTimeZoneOffset(ref str, 3, ref timeSpan))
							{
								result.SetBadDateTimeFailure();
								return false;
							}
							if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0 && timeSpan != result.timeZoneOffset)
							{
								result.SetFailure(ParseFailureKind.Format_RepeatDateTimePattern, 75);
								return false;
							}
							result.timeZoneOffset = timeSpan;
							result.flags |= ParseFlags.TimeZoneUsed;
							return true;
						}
					}
					else
					{
						repeatCount = format.GetRepeatCount();
						if (!DateTimeParse.ParseDigits(ref str, (repeatCount < 2) ? 1 : 2, out newValue5))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						if (!DateTimeParse.CheckNewValue(ref result.Hour, newValue5, @char, ref result))
						{
							return false;
						}
						return true;
					}
				}
			}
			else if (@char <= 'h')
			{
				if (@char <= 'Z')
				{
					if (@char != 'M')
					{
						if (@char != 'Z')
						{
							goto IL_8EB;
						}
						if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0 && result.timeZoneOffset != TimeSpan.Zero)
						{
							result.SetFailure(ParseFailureKind.Format_RepeatDateTimePattern, 90);
							return false;
						}
						result.flags |= ParseFlags.TimeZoneUsed;
						result.timeZoneOffset = new TimeSpan(0L);
						result.flags |= ParseFlags.TimeZoneUtc;
						str.Index++;
						if (!DateTimeParse.GetTimeZoneName(ref str))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						str.Index--;
						return true;
					}
					else
					{
						repeatCount = format.GetRepeatCount();
						if (repeatCount <= 2)
						{
							if (!DateTimeParse.ParseDigits(ref str, repeatCount, out newValue2) && (!parseInfo.fUseHebrewNumberParser || !DateTimeParse.MatchHebrewDigits(ref str, out newValue2)))
							{
								result.SetBadDateTimeFailure();
								return false;
							}
						}
						else
						{
							if (repeatCount == 3)
							{
								if (!DateTimeParse.MatchAbbreviatedMonthName(ref str, dtfi, ref newValue2))
								{
									result.SetBadDateTimeFailure();
									return false;
								}
							}
							else if (!DateTimeParse.MatchMonthName(ref str, dtfi, ref newValue2))
							{
								result.SetBadDateTimeFailure();
								return false;
							}
							result.flags |= ParseFlags.ParsedMonthName;
						}
						if (!DateTimeParse.CheckNewValue(ref result.Month, newValue2, @char, ref result))
						{
							return false;
						}
						return true;
					}
				}
				else if (@char != '\\')
				{
					switch (@char)
					{
					case 'd':
						repeatCount = format.GetRepeatCount();
						if (repeatCount <= 2)
						{
							if (!DateTimeParse.ParseDigits(ref str, repeatCount, out newValue3) && (!parseInfo.fUseHebrewNumberParser || !DateTimeParse.MatchHebrewDigits(ref str, out newValue3)))
							{
								result.SetBadDateTimeFailure();
								return false;
							}
							if (!DateTimeParse.CheckNewValue(ref result.Day, newValue3, @char, ref result))
							{
								return false;
							}
							return true;
						}
						else
						{
							if (repeatCount == 3)
							{
								if (!DateTimeParse.MatchAbbreviatedDayName(ref str, dtfi, ref newValue4))
								{
									result.SetBadDateTimeFailure();
									return false;
								}
							}
							else if (!DateTimeParse.MatchDayName(ref str, dtfi, ref newValue4))
							{
								result.SetBadDateTimeFailure();
								return false;
							}
							if (!DateTimeParse.CheckNewValue(ref parseInfo.dayOfWeek, newValue4, @char, ref result))
							{
								return false;
							}
							return true;
						}
						break;
					case 'e':
						goto IL_8EB;
					case 'f':
						break;
					case 'g':
						format.GetRepeatCount();
						if (!DateTimeParse.MatchEraName(ref str, dtfi, ref result.era))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						return true;
					case 'h':
						parseInfo.fUseHour12 = true;
						repeatCount = format.GetRepeatCount();
						if (!DateTimeParse.ParseDigits(ref str, (repeatCount < 2) ? 1 : 2, out newValue5))
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						if (!DateTimeParse.CheckNewValue(ref result.Hour, newValue5, @char, ref result))
						{
							return false;
						}
						return true;
					default:
						goto IL_8EB;
					}
				}
				else
				{
					if (!format.GetNext())
					{
						result.SetBadFormatSpecifierFailure(format.Value);
						return false;
					}
					if (!str.Match(format.GetChar()))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					return true;
				}
			}
			else if (@char <= 's')
			{
				if (@char != 'm')
				{
					if (@char != 's')
					{
						goto IL_8EB;
					}
					repeatCount = format.GetRepeatCount();
					if (!DateTimeParse.ParseDigits(ref str, (repeatCount < 2) ? 1 : 2, out newValue7))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					if (!DateTimeParse.CheckNewValue(ref result.Second, newValue7, @char, ref result))
					{
						return false;
					}
					return true;
				}
				else
				{
					repeatCount = format.GetRepeatCount();
					if (!DateTimeParse.ParseDigits(ref str, (repeatCount < 2) ? 1 : 2, out newValue6))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					if (!DateTimeParse.CheckNewValue(ref result.Minute, newValue6, @char, ref result))
					{
						return false;
					}
					return true;
				}
			}
			else if (@char != 't')
			{
				if (@char != 'y')
				{
					if (@char != 'z')
					{
						goto IL_8EB;
					}
					repeatCount = format.GetRepeatCount();
					TimeSpan timeSpan2 = new TimeSpan(0L);
					if (!DateTimeParse.ParseTimeZoneOffset(ref str, repeatCount, ref timeSpan2))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					if ((result.flags & ParseFlags.TimeZoneUsed) != (ParseFlags)0 && timeSpan2 != result.timeZoneOffset)
					{
						result.SetFailure(ParseFailureKind.Format_RepeatDateTimePattern, 122);
						return false;
					}
					result.timeZoneOffset = timeSpan2;
					result.flags |= ParseFlags.TimeZoneUsed;
					return true;
				}
				else
				{
					repeatCount = format.GetRepeatCount();
					bool flag;
					if (DateTimeParse.ParseJapaneseEraStart(ref str, dtfi))
					{
						newValue = 1;
						flag = true;
					}
					else if (dtfi.HasForceTwoDigitYears)
					{
						flag = DateTimeParse.ParseDigits(ref str, 1, 4, out newValue);
					}
					else
					{
						if (repeatCount <= 2)
						{
							parseInfo.fUseTwoDigitYear = true;
						}
						flag = DateTimeParse.ParseDigits(ref str, repeatCount, out newValue);
					}
					if (!flag && parseInfo.fUseHebrewNumberParser)
					{
						flag = DateTimeParse.MatchHebrewDigits(ref str, out newValue);
					}
					if (!flag)
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					if (!DateTimeParse.CheckNewValue(ref result.Year, newValue, @char, ref result))
					{
						return false;
					}
					return true;
				}
			}
			else
			{
				repeatCount = format.GetRepeatCount();
				if (repeatCount == 1)
				{
					if (!DateTimeParse.MatchAbbreviatedTimeMark(ref str, dtfi, ref tm))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
				}
				else if (!DateTimeParse.MatchTimeMark(ref str, dtfi, ref tm))
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				if (parseInfo.timeMark == DateTimeParse.TM.NotSet)
				{
					parseInfo.timeMark = tm;
					return true;
				}
				if (parseInfo.timeMark != tm)
				{
					result.SetFailure(ParseFailureKind.Format_RepeatDateTimePattern, (int)@char);
					return false;
				}
				return true;
			}
			repeatCount = format.GetRepeatCount();
			if (repeatCount > 7)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (!DateTimeParse.ParseFractionExact(ref str, repeatCount, ref num) && @char == 'f')
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (result.fraction < 0.0)
			{
				result.fraction = num;
				return true;
			}
			if (num != result.fraction)
			{
				result.SetFailure(ParseFailureKind.Format_RepeatDateTimePattern, (int)@char);
				return false;
			}
			return true;
			IL_8EB:
			if (!parseInfo.fAllowInnerWhite || !char.IsWhiteSpace(@char))
			{
				if (format.MatchSpecifiedWord("GMT"))
				{
					format.Index += "GMT".Length - 1;
					result.flags |= ParseFlags.TimeZoneUsed;
					result.timeZoneOffset = TimeSpan.Zero;
					if (!str.Match("GMT"))
					{
						result.SetBadDateTimeFailure();
						return false;
					}
				}
				else if (!str.Match(@char))
				{
					if (parseInfo.fAllowTrailingWhite && char.IsWhiteSpace(@char) && format.GetNext() && DateTimeParse.ParseByFormat(ref str, ref format, ref parseInfo, dtfi, ref result))
					{
						return true;
					}
					result.SetBadDateTimeFailure();
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00037C34 File Offset: 0x00035E34
		internal unsafe static bool TryParseQuoteString(ReadOnlySpan<char> format, int pos, ref ValueStringBuilder result, out int returnValue)
		{
			int num = pos;
			char c = (char)(*format[pos++]);
			bool flag = false;
			while (pos < format.Length)
			{
				char c2 = (char)(*format[pos++]);
				if (c2 == c)
				{
					flag = true;
					break;
				}
				if (c2 == '\\')
				{
					if (pos >= format.Length)
					{
						returnValue = 0;
						return false;
					}
					result.Append((char)(*format[pos++]));
				}
				else
				{
					result.Append(c2);
				}
			}
			if (!flag)
			{
				returnValue = 0;
				return false;
			}
			returnValue = pos - num;
			return true;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00037CB8 File Offset: 0x00035EB8
		private unsafe static bool DoStrictParse(ReadOnlySpan<char> s, ReadOnlySpan<char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, [ScopedRef] ref DateTimeResult result)
		{
			ParsingInfo parsingInfo = new ParsingInfo(dtfi.Calendar);
			parsingInfo.fAllowInnerWhite = ((styles & DateTimeStyles.AllowInnerWhite) > DateTimeStyles.None);
			parsingInfo.fAllowTrailingWhite = ((styles & DateTimeStyles.AllowTrailingWhite) > DateTimeStyles.None);
			if (formatParam.Length == 1)
			{
				char c = (char)(*formatParam[0]);
				if (styles == DateTimeStyles.None)
				{
					int num = (int)(c | ' ');
					if (num == 111)
					{
						return DateTimeParse.TryParseFormatO(s, ref result);
					}
					if (num == 114)
					{
						return DateTimeParse.TryParseFormatR(s, ref result);
					}
				}
				if ((result.flags & ParseFlags.CaptureOffset) != (ParseFlags)0 && c == 'U')
				{
					result.SetBadFormatSpecifierFailure(formatParam);
					return false;
				}
				formatParam = DateTimeParse.ExpandPredefinedFormat(c, ref dtfi, ref parsingInfo, ref result);
			}
			result.calendar = parsingInfo.calendar;
			parsingInfo.fUseHebrewNumberParser = (parsingInfo.calendar.ID == CalendarId.HEBREW);
			result.Hour = (result.Minute = (result.Second = -1));
			__DTString _DTString = new __DTString(formatParam, dtfi, false);
			__DTString _DTString2 = new __DTString(s, dtfi, false);
			if (parsingInfo.fAllowTrailingWhite)
			{
				_DTString.TrimTail();
				_DTString.RemoveTrailingInQuoteSpaces();
				_DTString2.TrimTail();
			}
			if ((styles & DateTimeStyles.AllowLeadingWhite) != DateTimeStyles.None)
			{
				_DTString.SkipWhiteSpaces();
				_DTString.RemoveLeadingInQuoteSpaces();
				_DTString2.SkipWhiteSpaces();
			}
			while (_DTString.GetNext())
			{
				if (parsingInfo.fAllowInnerWhite)
				{
					_DTString2.SkipWhiteSpaces();
				}
				if (!DateTimeParse.ParseByFormat(ref _DTString2, ref _DTString, ref parsingInfo, dtfi, ref result))
				{
					return false;
				}
			}
			if (_DTString2.Index < _DTString2.Value.Length - 1)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (parsingInfo.fUseTwoDigitYear && (dtfi.FormatFlags & DateTimeFormatFlags.UseHebrewRule) == DateTimeFormatFlags.None)
			{
				if (result.Year >= 100)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				try
				{
					result.Year = parsingInfo.calendar.ToFourDigitYear(result.Year);
				}
				catch (ArgumentOutOfRangeException)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
			}
			if (parsingInfo.fUseHour12)
			{
				if (parsingInfo.timeMark == DateTimeParse.TM.NotSet)
				{
					parsingInfo.timeMark = DateTimeParse.TM.AM;
				}
				if (result.Hour > 12)
				{
					result.SetBadDateTimeFailure();
					return false;
				}
				if (parsingInfo.timeMark == DateTimeParse.TM.AM)
				{
					if (result.Hour == 12)
					{
						result.Hour = 0;
					}
				}
				else
				{
					result.Hour = ((result.Hour == 12) ? 12 : (result.Hour + 12));
				}
			}
			else if ((parsingInfo.timeMark == DateTimeParse.TM.AM && result.Hour >= 12) || (parsingInfo.timeMark == DateTimeParse.TM.PM && result.Hour < 12))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			bool flag = result.Year == -1 && result.Month == -1 && result.Day == -1;
			if (!DateTimeParse.CheckDefaultDateTime(ref result, ref parsingInfo.calendar, styles))
			{
				return false;
			}
			if (!flag && dtfi.HasYearMonthAdjustment && !dtfi.YearMonthAdjustment(ref result.Year, ref result.Month, (result.flags & ParseFlags.ParsedMonthName) > (ParseFlags)0))
			{
				result.SetFailure(ParseFailureKind.Format_BadDateTimeCalendar);
				return false;
			}
			if (!parsingInfo.calendar.TryToDateTime(result.Year, result.Month, result.Day, result.Hour, result.Minute, result.Second, 0, result.era, out result.parsedDate))
			{
				result.SetFailure(ParseFailureKind.Format_BadDateTimeCalendar);
				return false;
			}
			if (result.fraction > 0.0 && !result.parsedDate.TryAddTicks((long)Math.Round(result.fraction * 10000000.0), out result.parsedDate))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (parsingInfo.dayOfWeek != -1 && parsingInfo.dayOfWeek != (int)parsingInfo.calendar.GetDayOfWeek(result.parsedDate))
			{
				result.SetFailure(ParseFailureKind.Format_BadDayOfWeek);
				return false;
			}
			return DateTimeParse.DetermineTimeZoneAdjustments(ref result, styles, flag);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00038074 File Offset: 0x00036274
		private unsafe static bool TryParseFormatR(ReadOnlySpan<char> source, [ScopedRef] ref DateTimeResult result)
		{
			if (source.Length != 29)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			uint num = (uint)(*source[0]);
			uint num2 = (uint)(*source[1]);
			uint num3 = (uint)(*source[2]);
			uint num4 = (uint)(*source[3]);
			if ((num | num2 | num3 | num4) > 127U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			uint num5 = num << 24 | num2 << 16 | num3 << 8 | num4 | 538976256U;
			DayOfWeek dayOfWeek;
			if (num5 <= 1935766572U)
			{
				if (num5 == 1718774060U)
				{
					dayOfWeek = DayOfWeek.Friday;
					goto IL_EC;
				}
				if (num5 == 1836019244U)
				{
					dayOfWeek = DayOfWeek.Monday;
					goto IL_EC;
				}
				if (num5 == 1935766572U)
				{
					dayOfWeek = DayOfWeek.Saturday;
					goto IL_EC;
				}
			}
			else if (num5 <= 1953002796U)
			{
				if (num5 == 1937075756U)
				{
					dayOfWeek = DayOfWeek.Sunday;
					goto IL_EC;
				}
				if (num5 == 1953002796U)
				{
					dayOfWeek = DayOfWeek.Thursday;
					goto IL_EC;
				}
			}
			else
			{
				if (num5 == 1953850668U)
				{
					dayOfWeek = DayOfWeek.Tuesday;
					goto IL_EC;
				}
				if (num5 == 2003133484U)
				{
					dayOfWeek = DayOfWeek.Wednesday;
					goto IL_EC;
				}
			}
			result.SetBadDateTimeFailure();
			return false;
			IL_EC:
			if (*source[4] != 32)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			uint num6 = (uint)(*source[5] - 48);
			uint num7 = (uint)(*source[6] - 48);
			if (num6 > 9U || num7 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int day = (int)(num6 * 10U + num7);
			if (*source[7] != 32)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			uint num8 = (uint)(*source[8]);
			uint num9 = (uint)(*source[9]);
			uint num10 = (uint)(*source[10]);
			uint num11 = (uint)(*source[11]);
			if ((num8 | num9 | num10 | num11) > 127U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			uint num12 = num8 << 24 | num9 << 16 | num10 << 8 | num11 | 538976256U;
			int month;
			if (num12 <= 1786080288U)
			{
				if (num12 <= 1684366112U)
				{
					if (num12 == 1634759200U)
					{
						month = 4;
						goto IL_287;
					}
					if (num12 == 1635084064U)
					{
						month = 8;
						goto IL_287;
					}
					if (num12 == 1684366112U)
					{
						month = 12;
						goto IL_287;
					}
				}
				else
				{
					if (num12 == 1717920288U)
					{
						month = 2;
						goto IL_287;
					}
					if (num12 == 1784770080U)
					{
						month = 1;
						goto IL_287;
					}
					if (num12 == 1786080288U)
					{
						month = 7;
						goto IL_287;
					}
				}
			}
			else if (num12 <= 1835104544U)
			{
				if (num12 == 1786080800U)
				{
					month = 6;
					goto IL_287;
				}
				if (num12 == 1835102752U)
				{
					month = 3;
					goto IL_287;
				}
				if (num12 == 1835104544U)
				{
					month = 5;
					goto IL_287;
				}
			}
			else
			{
				if (num12 == 1852798496U)
				{
					month = 11;
					goto IL_287;
				}
				if (num12 == 1868788768U)
				{
					month = 10;
					goto IL_287;
				}
				if (num12 == 1936027680U)
				{
					month = 9;
					goto IL_287;
				}
			}
			result.SetBadDateTimeFailure();
			return false;
			IL_287:
			uint num13 = (uint)(*source[12] - 48);
			uint num14 = (uint)(*source[13] - 48);
			uint num15 = (uint)(*source[14] - 48);
			uint num16 = (uint)(*source[15] - 48);
			if (num13 > 9U || num14 > 9U || num15 > 9U || num16 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int year = (int)(num13 * 1000U + num14 * 100U + num15 * 10U + num16);
			if (*source[16] != 32)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			uint num17 = (uint)(*source[17] - 48);
			uint num18 = (uint)(*source[18] - 48);
			if (num17 > 9U || num18 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int hour = (int)(num17 * 10U + num18);
			if (*source[19] != 58)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			uint num19 = (uint)(*source[20] - 48);
			uint num20 = (uint)(*source[21] - 48);
			if (num19 > 9U || num20 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int minute = (int)(num19 * 10U + num20);
			if (*source[22] != 58)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			uint num21 = (uint)(*source[23] - 48);
			uint num22 = (uint)(*source[24] - 48);
			if (num21 > 9U || num22 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int second = (int)(num21 * 10U + num22);
			if (*source[25] != 32 || *source[26] != 71 || *source[27] != 77 || *source[28] != 84)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (!DateTime.TryCreate(year, month, day, hour, minute, second, 0, out result.parsedDate))
			{
				result.SetFailure(ParseFailureKind.Format_BadDateTimeCalendar);
				return false;
			}
			if (dayOfWeek != result.parsedDate.DayOfWeek)
			{
				result.SetFailure(ParseFailureKind.Format_BadDayOfWeek);
				return false;
			}
			return true;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x000384EC File Offset: 0x000366EC
		private unsafe static bool TryParseFormatO(ReadOnlySpan<char> source, [ScopedRef] ref DateTimeResult result)
		{
			if (source.Length < 27 || *source[4] != 45 || *source[7] != 45 || *source[10] != 84 || *source[13] != 58 || *source[16] != 58 || *source[19] != 46)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			uint num = (uint)(*source[0] - 48);
			uint num2 = (uint)(*source[1] - 48);
			uint num3 = (uint)(*source[2] - 48);
			uint num4 = (uint)(*source[3] - 48);
			if (num > 9U || num2 > 9U || num3 > 9U || num4 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int year = (int)(num * 1000U + num2 * 100U + num3 * 10U + num4);
			uint num5 = (uint)(*source[5] - 48);
			uint num6 = (uint)(*source[6] - 48);
			if (num5 > 9U || num6 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int month = (int)(num5 * 10U + num6);
			uint num7 = (uint)(*source[8] - 48);
			uint num8 = (uint)(*source[9] - 48);
			if (num7 > 9U || num8 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int day = (int)(num7 * 10U + num8);
			uint num9 = (uint)(*source[11] - 48);
			uint num10 = (uint)(*source[12] - 48);
			if (num9 > 9U || num10 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int hour = (int)(num9 * 10U + num10);
			uint num11 = (uint)(*source[14] - 48);
			uint num12 = (uint)(*source[15] - 48);
			if (num11 > 9U || num12 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int minute = (int)(num11 * 10U + num12);
			uint num13 = (uint)(*source[17] - 48);
			uint num14 = (uint)(*source[18] - 48);
			if (num13 > 9U || num14 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			int second = (int)(num13 * 10U + num14);
			uint num15 = (uint)(*source[20] - 48);
			uint num16 = (uint)(*source[21] - 48);
			uint num17 = (uint)(*source[22] - 48);
			uint num18 = (uint)(*source[23] - 48);
			uint num19 = (uint)(*source[24] - 48);
			uint num20 = (uint)(*source[25] - 48);
			uint num21 = (uint)(*source[26] - 48);
			if (num15 > 9U || num16 > 9U || num17 > 9U || num18 > 9U || num19 > 9U || num20 > 9U || num21 > 9U)
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			double num22 = (num15 * 1000000U + num16 * 100000U + num17 * 10000U + num18 * 1000U + num19 * 100U + num20 * 10U + num21) / 10000000.0;
			DateTime dateTime;
			if (!DateTime.TryCreate(year, month, day, hour, minute, second, 0, out dateTime))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (!dateTime.TryAddTicks((long)Math.Round(num22 * 10000000.0), out result.parsedDate))
			{
				result.SetBadDateTimeFailure();
				return false;
			}
			if (source.Length > 27)
			{
				char c = (char)(*source[27]);
				if (c != '+' && c != '-')
				{
					if (c != 'Z')
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					if (source.Length != 28)
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					result.flags |= (ParseFlags.TimeZoneUsed | ParseFlags.TimeZoneUtc);
				}
				else
				{
					int num25;
					int num26;
					if (source.Length == 33)
					{
						uint num23 = (uint)(*source[28] - 48);
						uint num24 = (uint)(*source[29] - 48);
						if (num23 > 9U || num24 > 9U)
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						num25 = (int)(num23 * 10U + num24);
						num26 = 30;
					}
					else
					{
						if (source.Length != 32)
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						num25 = (int)(*source[28] - 48);
						if (num25 > 9)
						{
							result.SetBadDateTimeFailure();
							return false;
						}
						num26 = 29;
					}
					if (*source[num26] != 58)
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					uint num27 = (uint)(*source[num26 + 1] - 48);
					uint num28 = (uint)(*source[num26 + 2] - 48);
					if (num27 > 9U || num28 > 9U)
					{
						result.SetBadDateTimeFailure();
						return false;
					}
					int minutes = (int)(num27 * 10U + num28);
					result.flags |= ParseFlags.TimeZoneUsed;
					result.timeZoneOffset = new TimeSpan(num25, minutes, 0);
					if (c == '-')
					{
						result.timeZoneOffset = result.timeZoneOffset.Negate();
					}
				}
			}
			return DateTimeParse.DetermineTimeZoneAdjustments(ref result, DateTimeStyles.None, false);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0003898C File Offset: 0x00036B8C
		private static Exception GetDateTimeParseException([ScopedRef] ref DateTimeResult result)
		{
			switch (result.failure)
			{
			case ParseFailureKind.ArgumentNull_String:
				return new ArgumentNullException("formats", SR.ArgumentNull_String);
			case ParseFailureKind.Format_BadDatePattern:
				return new FormatException(SR.Format(SR.Format_BadDatePattern, new string(result.failureSpanArgument)));
			case ParseFailureKind.Format_BadDateTime:
				return new FormatException(SR.Format(SR.Format_BadDateTime, new string(result.failureSpanArgument)));
			case ParseFailureKind.Format_BadDateTimeCalendar:
				return new FormatException(SR.Format(SR.Format_BadDateTimeCalendar, new string(result.failureSpanArgument), result.calendar));
			case ParseFailureKind.Format_BadDayOfWeek:
				return new FormatException(SR.Format(SR.Format_BadDayOfWeek, new string(result.failureSpanArgument)));
			case ParseFailureKind.Format_BadFormatSpecifier:
				return new FormatException(SR.Format(SR.Format_BadFormatSpecifier, new string(result.failureSpanArgument)));
			case ParseFailureKind.Format_BadQuote:
				return new FormatException(SR.Format(SR.Format_BadQuote, (char)result.failureIntArgument));
			case ParseFailureKind.Format_DateOutOfRange:
				return new FormatException(SR.Format(SR.Format_DateOutOfRange, new string(result.failureSpanArgument)));
			case ParseFailureKind.Format_MissingIncompleteDate:
				return new FormatException(SR.Format(SR.Format_MissingIncompleteDate, new string(result.failureSpanArgument)));
			case ParseFailureKind.Format_NoFormatSpecifier:
				return new FormatException(SR.Format_NoFormatSpecifier);
			case ParseFailureKind.Format_OffsetOutOfRange:
				return new FormatException(SR.Format(SR.Format_OffsetOutOfRange, new string(result.failureSpanArgument)));
			case ParseFailureKind.Format_RepeatDateTimePattern:
				return new FormatException(SR.Format(SR.Format_RepeatDateTimePattern, (char)result.failureIntArgument));
			case ParseFailureKind.Format_UnknownDateTimeWord:
				return new FormatException(SR.Format(SR.Format_UnknownDateTimeWord, new string(result.failureSpanArgument), result.failureIntArgument));
			case ParseFailureKind.Format_UTCOutOfRange:
				return new FormatException(SR.Format(SR.Format_UTCOutOfRange, new string(result.failureSpanArgument)));
			default:
				return null;
			}
		}

		// Token: 0x040003CB RID: 971
		private static readonly DateTimeParse.DS[][] s_dateParsingStates = new DateTimeParse.DS[][]
		{
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.BEGIN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.TX_N,
				DateTimeParse.DS.N,
				DateTimeParse.DS.D_Nd,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_M,
				DateTimeParse.DS.D_M,
				DateTimeParse.DS.D_S,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.BEGIN,
				DateTimeParse.DS.D_Y,
				DateTimeParse.DS.D_Y,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.BEGIN,
				DateTimeParse.DS.BEGIN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NN,
				DateTimeParse.DS.TX_NN,
				DateTimeParse.DS.NN,
				DateTimeParse.DS.D_NNd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NM,
				DateTimeParse.DS.D_NM,
				DateTimeParse.DS.D_MNd,
				DateTimeParse.DS.D_NDS,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.N,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.D_YNd,
				DateTimeParse.DS.DX_YN,
				DateTimeParse.DS.N,
				DateTimeParse.DS.N,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_NN,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.TX_NNN,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.NN,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.NN,
				DateTimeParse.DS.NN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NN,
				DateTimeParse.DS.D_NNd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NM,
				DateTimeParse.DS.D_MN,
				DateTimeParse.DS.D_MNd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_Nd,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.D_YNd,
				DateTimeParse.DS.DX_YN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_Nd,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_NN,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.TX_N,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_DS,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.D_NN,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.DX_NNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_DS,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NNd,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_NNY,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NNd,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_MN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_MN,
				DateTimeParse.DS.D_MNd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_M,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.D_YMd,
				DateTimeParse.DS.DX_YM,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_M,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_MN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_DS,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.D_MN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_MN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_NM,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_DS,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.D_NM,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NM,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_MNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_MNd,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_MNd,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_NDS,
				DateTimeParse.DS.DX_NNDS,
				DateTimeParse.DS.DX_NNDS,
				DateTimeParse.DS.DX_NNDS,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NDS,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.D_NDS,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_NDS,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.D_YNd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YM,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.D_YMd,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_Y,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_Y,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_YN,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.DX_YNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YN,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_YM,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.DX_YMN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_YM,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.DX_DS,
				DateTimeParse.DS.DX_DSN,
				DateTimeParse.DS.TX_N,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_S,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.D_S,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_S,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.TX_TS,
				DateTimeParse.DS.TX_TS,
				DateTimeParse.DS.TX_TS,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.D_Nd,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.D_S,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.ERROR
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.TX_NN,
				DateTimeParse.DS.TX_NN,
				DateTimeParse.DS.TX_NN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_NNt,
				DateTimeParse.DS.DX_NM,
				DateTimeParse.DS.D_NM,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.T_Nt,
				DateTimeParse.DS.TX_NN
			},
			new DateTimeParse.DS[]
			{
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.TX_NNN,
				DateTimeParse.DS.TX_NNN,
				DateTimeParse.DS.TX_NNN,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_S,
				DateTimeParse.DS.T_NNt,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.ERROR,
				DateTimeParse.DS.T_NNt,
				DateTimeParse.DS.T_NNt,
				DateTimeParse.DS.TX_NNN
			}
		};

		// Token: 0x02000126 RID: 294
		internal enum DTT
		{
			// Token: 0x040003CD RID: 973
			End,
			// Token: 0x040003CE RID: 974
			NumEnd,
			// Token: 0x040003CF RID: 975
			NumAmpm,
			// Token: 0x040003D0 RID: 976
			NumSpace,
			// Token: 0x040003D1 RID: 977
			NumDatesep,
			// Token: 0x040003D2 RID: 978
			NumTimesep,
			// Token: 0x040003D3 RID: 979
			MonthEnd,
			// Token: 0x040003D4 RID: 980
			MonthSpace,
			// Token: 0x040003D5 RID: 981
			MonthDatesep,
			// Token: 0x040003D6 RID: 982
			NumDatesuff,
			// Token: 0x040003D7 RID: 983
			NumTimesuff,
			// Token: 0x040003D8 RID: 984
			DayOfWeek,
			// Token: 0x040003D9 RID: 985
			YearSpace,
			// Token: 0x040003DA RID: 986
			YearDateSep,
			// Token: 0x040003DB RID: 987
			YearEnd,
			// Token: 0x040003DC RID: 988
			TimeZone,
			// Token: 0x040003DD RID: 989
			Era,
			// Token: 0x040003DE RID: 990
			NumUTCTimeMark,
			// Token: 0x040003DF RID: 991
			Unk,
			// Token: 0x040003E0 RID: 992
			NumLocalTimeMark,
			// Token: 0x040003E1 RID: 993
			Max
		}

		// Token: 0x02000127 RID: 295
		internal enum TM
		{
			// Token: 0x040003E3 RID: 995
			NotSet = -1,
			// Token: 0x040003E4 RID: 996
			AM,
			// Token: 0x040003E5 RID: 997
			PM
		}

		// Token: 0x02000128 RID: 296
		internal enum DS
		{
			// Token: 0x040003E7 RID: 999
			BEGIN,
			// Token: 0x040003E8 RID: 1000
			N,
			// Token: 0x040003E9 RID: 1001
			NN,
			// Token: 0x040003EA RID: 1002
			D_Nd,
			// Token: 0x040003EB RID: 1003
			D_NN,
			// Token: 0x040003EC RID: 1004
			D_NNd,
			// Token: 0x040003ED RID: 1005
			D_M,
			// Token: 0x040003EE RID: 1006
			D_MN,
			// Token: 0x040003EF RID: 1007
			D_NM,
			// Token: 0x040003F0 RID: 1008
			D_MNd,
			// Token: 0x040003F1 RID: 1009
			D_NDS,
			// Token: 0x040003F2 RID: 1010
			D_Y,
			// Token: 0x040003F3 RID: 1011
			D_YN,
			// Token: 0x040003F4 RID: 1012
			D_YNd,
			// Token: 0x040003F5 RID: 1013
			D_YM,
			// Token: 0x040003F6 RID: 1014
			D_YMd,
			// Token: 0x040003F7 RID: 1015
			D_S,
			// Token: 0x040003F8 RID: 1016
			T_S,
			// Token: 0x040003F9 RID: 1017
			T_Nt,
			// Token: 0x040003FA RID: 1018
			T_NNt,
			// Token: 0x040003FB RID: 1019
			ERROR,
			// Token: 0x040003FC RID: 1020
			DX_NN,
			// Token: 0x040003FD RID: 1021
			DX_NNN,
			// Token: 0x040003FE RID: 1022
			DX_MN,
			// Token: 0x040003FF RID: 1023
			DX_NM,
			// Token: 0x04000400 RID: 1024
			DX_MNN,
			// Token: 0x04000401 RID: 1025
			DX_DS,
			// Token: 0x04000402 RID: 1026
			DX_DSN,
			// Token: 0x04000403 RID: 1027
			DX_NDS,
			// Token: 0x04000404 RID: 1028
			DX_NNDS,
			// Token: 0x04000405 RID: 1029
			DX_YNN,
			// Token: 0x04000406 RID: 1030
			DX_YMN,
			// Token: 0x04000407 RID: 1031
			DX_YN,
			// Token: 0x04000408 RID: 1032
			DX_YM,
			// Token: 0x04000409 RID: 1033
			TX_N,
			// Token: 0x0400040A RID: 1034
			TX_NN,
			// Token: 0x0400040B RID: 1035
			TX_NNN,
			// Token: 0x0400040C RID: 1036
			TX_TS,
			// Token: 0x0400040D RID: 1037
			DX_NNY
		}
	}
}
