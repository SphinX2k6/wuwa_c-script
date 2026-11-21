using System;
using System.Buffers.Text;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Globalization
{
	// Token: 0x0200031B RID: 795
	internal static class TimeSpanParse
	{
		// Token: 0x060039A6 RID: 14758 RVA: 0x000BE9D0 File Offset: 0x000BCBD0
		internal unsafe static int Pow10UpToMaxFractionDigits(int pow)
		{
			return *RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.C69994AC61B52FBCEA582D6CCCD595C12E00BDB18F0C6F593FB6B393CAEDB08C4).FieldHandle)[pow];
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x000BE9F4 File Offset: 0x000BCBF4
		private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result)
		{
			if (days._num > 10675199 || hours._num > 23 || minutes._num > 59 || seconds._num > 59 || !fraction.NormalizeAndValidateFraction())
			{
				result = 0L;
				return false;
			}
			long num = ((long)days._num * 3600L * 24L + (long)hours._num * 3600L + (long)minutes._num * 60L + (long)seconds._num) * 1000L;
			if (num > 922337203685477L || num < -922337203685477L)
			{
				result = 0L;
				return false;
			}
			result = num * 10000L + (long)fraction._num;
			if (positive && result < 0L)
			{
				result = 0L;
				return false;
			}
			return true;
		}

		// Token: 0x060039A8 RID: 14760 RVA: 0x000BEAC0 File Offset: 0x000BCCC0
		internal static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider)
		{
			TimeSpanParse.TimeSpanResult timeSpanResult = new TimeSpanParse.TimeSpanResult(true, input);
			TimeSpanParse.TryParseTimeSpan(input, TimeSpanParse.TimeSpanStandardStyles.Any, formatProvider, ref timeSpanResult);
			return timeSpanResult.parsedTimeSpan;
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x000BEAE8 File Offset: 0x000BCCE8
		internal static bool TryParse(ReadOnlySpan<char> input, IFormatProvider formatProvider, out TimeSpan result)
		{
			TimeSpanParse.TimeSpanResult timeSpanResult = new TimeSpanParse.TimeSpanResult(false, input);
			if (TimeSpanParse.TryParseTimeSpan(input, TimeSpanParse.TimeSpanStandardStyles.Any, formatProvider, ref timeSpanResult))
			{
				result = timeSpanResult.parsedTimeSpan;
				return true;
			}
			result = default(TimeSpan);
			return false;
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x000BEB20 File Offset: 0x000BCD20
		internal static TimeSpan ParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles)
		{
			TimeSpanParse.TimeSpanResult timeSpanResult = new TimeSpanParse.TimeSpanResult(true, input);
			TimeSpanParse.TryParseExactTimeSpan(input, format, formatProvider, styles, ref timeSpanResult);
			return timeSpanResult.parsedTimeSpan;
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x000BEB48 File Offset: 0x000BCD48
		internal static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpanParse.TimeSpanResult timeSpanResult = new TimeSpanParse.TimeSpanResult(false, input);
			if (TimeSpanParse.TryParseExactTimeSpan(input, format, formatProvider, styles, ref timeSpanResult))
			{
				result = timeSpanResult.parsedTimeSpan;
				return true;
			}
			result = default(TimeSpan);
			return false;
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x000BEB84 File Offset: 0x000BCD84
		internal static TimeSpan ParseExactMultiple(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles)
		{
			TimeSpanParse.TimeSpanResult timeSpanResult = new TimeSpanParse.TimeSpanResult(true, input);
			TimeSpanParse.TryParseExactMultipleTimeSpan(input, formats, formatProvider, styles, ref timeSpanResult);
			return timeSpanResult.parsedTimeSpan;
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x000BEBAC File Offset: 0x000BCDAC
		internal static bool TryParseExactMultiple(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpanParse.TimeSpanResult timeSpanResult = new TimeSpanParse.TimeSpanResult(false, input);
			if (TimeSpanParse.TryParseExactMultipleTimeSpan(input, formats, formatProvider, styles, ref timeSpanResult))
			{
				result = timeSpanResult.parsedTimeSpan;
				return true;
			}
			result = default(TimeSpan);
			return false;
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x000BEBE8 File Offset: 0x000BCDE8
		private static bool TryParseTimeSpan(ReadOnlySpan<char> input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result)
		{
			input = input.Trim();
			if (input.IsEmpty)
			{
				return result.SetBadTimeSpanFailure();
			}
			TimeSpanParse.TimeSpanTokenizer timeSpanTokenizer = new TimeSpanParse.TimeSpanTokenizer(input);
			TimeSpanParse.TimeSpanRawInfo timeSpanRawInfo = default(TimeSpanParse.TimeSpanRawInfo);
			timeSpanRawInfo.Init(DateTimeFormatInfo.GetInstance(formatProvider));
			TimeSpanParse.TimeSpanToken nextToken = timeSpanTokenizer.GetNextToken();
			while (nextToken._ttt != TimeSpanParse.TTT.End)
			{
				if (!timeSpanRawInfo.ProcessToken(ref nextToken, ref result))
				{
					return result.SetBadTimeSpanFailure();
				}
				nextToken = timeSpanTokenizer.GetNextToken();
			}
			return TimeSpanParse.ProcessTerminalState(ref timeSpanRawInfo, style, ref result) || result.SetBadTimeSpanFailure();
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x000BEC6C File Offset: 0x000BCE6C
		private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._lastSeenTTT == TimeSpanParse.TTT.Num)
			{
				TimeSpanParse.TimeSpanToken timeSpanToken = default(TimeSpanParse.TimeSpanToken);
				timeSpanToken._ttt = TimeSpanParse.TTT.Sep;
				if (!raw.ProcessToken(ref timeSpanToken, ref result))
				{
					return result.SetBadTimeSpanFailure();
				}
			}
			bool result2;
			switch (raw._numCount)
			{
			case 1:
				result2 = TimeSpanParse.ProcessTerminal_D(ref raw, style, ref result);
				break;
			case 2:
				result2 = TimeSpanParse.ProcessTerminal_HM(ref raw, style, ref result);
				break;
			case 3:
				result2 = TimeSpanParse.ProcessTerminal_HM_S_D(ref raw, style, ref result);
				break;
			case 4:
				result2 = TimeSpanParse.ProcessTerminal_HMS_F_D(ref raw, style, ref result);
				break;
			case 5:
				result2 = TimeSpanParse.ProcessTerminal_DHMSF(ref raw, style, ref result);
				break;
			default:
				result2 = result.SetBadTimeSpanFailure();
				break;
			}
			return result2;
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x000BED08 File Offset: 0x000BCF08
		private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._sepCount != 6)
			{
				return result.SetBadTimeSpanFailure();
			}
			bool flag = (style & TimeSpanParse.TimeSpanStandardStyles.Invariant) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag2 = (style & TimeSpanParse.TimeSpanStandardStyles.Localized) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag3 = false;
			bool flag4 = false;
			if (flag)
			{
				if (raw.FullMatch(TimeSpanFormat.PositiveInvariantFormatLiterals))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullMatch(TimeSpanFormat.NegativeInvariantFormatLiterals))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (flag2)
			{
				if (!flag4 && raw.FullMatch(raw.PositiveLocalized))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullMatch(raw.NegativeLocalized))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (!flag4)
			{
				return result.SetBadTimeSpanFailure();
			}
			long num;
			if (!TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, raw._numbers4, out num))
			{
				return result.SetOverflowFailure();
			}
			if (!flag3)
			{
				num = -num;
				if (num > 0L)
				{
					return result.SetOverflowFailure();
				}
			}
			result.parsedTimeSpan = new TimeSpan(num);
			return true;
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x000BEDE4 File Offset: 0x000BCFE4
		private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._sepCount != 5 || (style & TimeSpanParse.TimeSpanStandardStyles.RequireFull) != TimeSpanParse.TimeSpanStandardStyles.None)
			{
				return result.SetBadTimeSpanFailure();
			}
			bool flag = (style & TimeSpanParse.TimeSpanStandardStyles.Invariant) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag2 = (style & TimeSpanParse.TimeSpanStandardStyles.Localized) > TimeSpanParse.TimeSpanStandardStyles.None;
			long num = 0L;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			TimeSpanParse.TimeSpanToken timeSpanToken = new TimeSpanParse.TimeSpanToken(0);
			if (flag)
			{
				if (raw.FullHMSFMatch(TimeSpanFormat.PositiveInvariantFormatLiterals))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMSMatch(TimeSpanFormat.PositiveInvariantFormatLiterals))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullAppCompatMatch(TimeSpanFormat.PositiveInvariantFormatLiterals))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullHMSFMatch(TimeSpanFormat.NegativeInvariantFormatLiterals))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMSMatch(TimeSpanFormat.NegativeInvariantFormatLiterals))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullAppCompatMatch(TimeSpanFormat.NegativeInvariantFormatLiterals))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
			}
			if (flag2)
			{
				if (!flag4 && raw.FullHMSFMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMSMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullAppCompatMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullHMSFMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMSMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, raw._numbers3, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullAppCompatMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, raw._numbers3, out num);
					flag5 = (flag5 || !flag4);
				}
			}
			if (flag4)
			{
				if (!flag3)
				{
					num = -num;
					if (num > 0L)
					{
						return result.SetOverflowFailure();
					}
				}
				result.parsedTimeSpan = new TimeSpan(num);
				return true;
			}
			if (!flag5)
			{
				return result.SetBadTimeSpanFailure();
			}
			return result.SetOverflowFailure();
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x000BF180 File Offset: 0x000BD380
		private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._sepCount != 4 || (style & TimeSpanParse.TimeSpanStandardStyles.RequireFull) != TimeSpanParse.TimeSpanStandardStyles.None)
			{
				return result.SetBadTimeSpanFailure();
			}
			bool flag = (style & TimeSpanParse.TimeSpanStandardStyles.Invariant) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag2 = (style & TimeSpanParse.TimeSpanStandardStyles.Localized) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			TimeSpanParse.TimeSpanToken timeSpanToken = new TimeSpanParse.TimeSpanToken(0);
			long num = 0L;
			if (flag)
			{
				if (raw.FullHMSMatch(TimeSpanFormat.PositiveInvariantFormatLiterals))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMMatch(TimeSpanFormat.PositiveInvariantFormatLiterals))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.PartialAppCompatMatch(TimeSpanFormat.PositiveInvariantFormatLiterals))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, timeSpanToken, raw._numbers2, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullHMSMatch(TimeSpanFormat.NegativeInvariantFormatLiterals))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMMatch(TimeSpanFormat.NegativeInvariantFormatLiterals))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.PartialAppCompatMatch(TimeSpanFormat.NegativeInvariantFormatLiterals))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, timeSpanToken, raw._numbers2, out num);
					flag5 = (flag5 || !flag4);
				}
			}
			if (flag2)
			{
				if (!flag4 && raw.FullHMSMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.PartialAppCompatMatch(raw.PositiveLocalized))
				{
					flag3 = true;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, timeSpanToken, raw._numbers2, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullHMSMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.FullDHMMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, raw._numbers1, raw._numbers2, timeSpanToken, timeSpanToken, out num);
					flag5 = (flag5 || !flag4);
				}
				if (!flag4 && raw.PartialAppCompatMatch(raw.NegativeLocalized))
				{
					flag3 = false;
					flag4 = TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, timeSpanToken, raw._numbers2, out num);
					flag5 = (flag5 || !flag4);
				}
			}
			if (flag4)
			{
				if (!flag3)
				{
					num = -num;
					if (num > 0L)
					{
						return result.SetOverflowFailure();
					}
				}
				result.parsedTimeSpan = new TimeSpan(num);
				return true;
			}
			if (!flag5)
			{
				return result.SetBadTimeSpanFailure();
			}
			return result.SetOverflowFailure();
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x000BF4D8 File Offset: 0x000BD6D8
		private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._sepCount != 3 || (style & TimeSpanParse.TimeSpanStandardStyles.RequireFull) != TimeSpanParse.TimeSpanStandardStyles.None)
			{
				return result.SetBadTimeSpanFailure();
			}
			bool flag = (style & TimeSpanParse.TimeSpanStandardStyles.Invariant) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag2 = (style & TimeSpanParse.TimeSpanStandardStyles.Localized) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag3 = false;
			bool flag4 = false;
			if (flag)
			{
				if (raw.FullHMMatch(TimeSpanFormat.PositiveInvariantFormatLiterals))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullHMMatch(TimeSpanFormat.NegativeInvariantFormatLiterals))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (flag2)
			{
				if (!flag4 && raw.FullHMMatch(raw.PositiveLocalized))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullHMMatch(raw.NegativeLocalized))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (!flag4)
			{
				return result.SetBadTimeSpanFailure();
			}
			TimeSpanParse.TimeSpanToken timeSpanToken = new TimeSpanParse.TimeSpanToken(0);
			long num;
			if (!TimeSpanParse.TryTimeToTicks(flag3, timeSpanToken, raw._numbers0, raw._numbers1, timeSpanToken, timeSpanToken, out num))
			{
				return result.SetOverflowFailure();
			}
			if (!flag3)
			{
				num = -num;
				if (num > 0L)
				{
					return result.SetOverflowFailure();
				}
			}
			result.parsedTimeSpan = new TimeSpan(num);
			return true;
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x000BF5B4 File Offset: 0x000BD7B4
		private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			if (raw._sepCount != 2 || (style & TimeSpanParse.TimeSpanStandardStyles.RequireFull) != TimeSpanParse.TimeSpanStandardStyles.None)
			{
				return result.SetBadTimeSpanFailure();
			}
			bool flag = (style & TimeSpanParse.TimeSpanStandardStyles.Invariant) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag2 = (style & TimeSpanParse.TimeSpanStandardStyles.Localized) > TimeSpanParse.TimeSpanStandardStyles.None;
			bool flag3 = false;
			bool flag4 = false;
			if (flag)
			{
				if (raw.FullDMatch(TimeSpanFormat.PositiveInvariantFormatLiterals))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullDMatch(TimeSpanFormat.NegativeInvariantFormatLiterals))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (flag2)
			{
				if (!flag4 && raw.FullDMatch(raw.PositiveLocalized))
				{
					flag4 = true;
					flag3 = true;
				}
				if (!flag4 && raw.FullDMatch(raw.NegativeLocalized))
				{
					flag4 = true;
					flag3 = false;
				}
			}
			if (!flag4)
			{
				return result.SetBadTimeSpanFailure();
			}
			TimeSpanParse.TimeSpanToken timeSpanToken = new TimeSpanParse.TimeSpanToken(0);
			long num;
			if (!TimeSpanParse.TryTimeToTicks(flag3, raw._numbers0, timeSpanToken, timeSpanToken, timeSpanToken, timeSpanToken, out num))
			{
				return result.SetOverflowFailure();
			}
			if (!flag3)
			{
				num = -num;
				if (num > 0L)
				{
					return result.SetOverflowFailure();
				}
			}
			result.parsedTimeSpan = new TimeSpan(num);
			return true;
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x000BF68C File Offset: 0x000BD88C
		private unsafe static bool TryParseExactTimeSpan(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result)
		{
			if (format.Length == 0)
			{
				return result.SetBadFormatSpecifierFailure(null);
			}
			if (format.Length == 1)
			{
				char c = (char)(*format[0]);
				if (c <= 'T')
				{
					if (c == 'G')
					{
						return TimeSpanParse.TryParseTimeSpan(input, TimeSpanParse.TimeSpanStandardStyles.Localized | TimeSpanParse.TimeSpanStandardStyles.RequireFull, formatProvider, ref result);
					}
					if (c != 'T')
					{
						goto IL_73;
					}
				}
				else if (c != 'c')
				{
					if (c == 'g')
					{
						return TimeSpanParse.TryParseTimeSpan(input, TimeSpanParse.TimeSpanStandardStyles.Localized, formatProvider, ref result);
					}
					if (c != 't')
					{
						goto IL_73;
					}
				}
				return TimeSpanParse.TryParseTimeSpanConstant(input, ref result);
				IL_73:
				return result.SetBadFormatSpecifierFailure(new char?((char)(*format[0])));
			}
			return TimeSpanParse.TryParseByFormat(input, format, styles, ref result);
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x000BF730 File Offset: 0x000BD930
		private unsafe static bool TryParseByFormat(ReadOnlySpan<char> input, ReadOnlySpan<char> format, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			int number = 0;
			int number2 = 0;
			int number3 = 0;
			int number4 = 0;
			int leadingZeroes = 0;
			int number5 = 0;
			int i = 0;
			TimeSpanParse.TimeSpanTokenizer timeSpanTokenizer = new TimeSpanParse.TimeSpanTokenizer(input, -1);
			while (i < format.Length)
			{
				char c = (char)(*format[i]);
				int num2;
				if (c <= 'F')
				{
					if (c <= '%')
					{
						if (c != '"')
						{
							if (c != '%')
							{
								goto IL_287;
							}
							int num = DateTimeFormat.ParseNextChar(format, i);
							if (num >= 0 && num != 37)
							{
								num2 = 1;
								goto IL_28E;
							}
							return result.SetInvalidStringFailure();
						}
					}
					else if (c != '\'')
					{
						if (c != 'F')
						{
							goto IL_287;
						}
						num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
						if (num2 > 7 || flag5)
						{
							return result.SetInvalidStringFailure();
						}
						TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, num2, num2, out leadingZeroes, out number5);
						flag5 = true;
						goto IL_28E;
					}
					ValueStringBuilder valueStringBuilder = new ValueStringBuilder(64);
					if (!DateTimeParse.TryParseQuoteString(format, i, ref valueStringBuilder, out num2))
					{
						valueStringBuilder.Dispose();
						return result.SetBadQuoteFailure(c);
					}
					if (!TimeSpanParse.ParseExactLiteral(ref timeSpanTokenizer, ref valueStringBuilder))
					{
						valueStringBuilder.Dispose();
						return result.SetInvalidStringFailure();
					}
					valueStringBuilder.Dispose();
				}
				else if (c <= 'h')
				{
					if (c != '\\')
					{
						switch (c)
						{
						case 'd':
						{
							num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
							int num3;
							if (num2 > 8 || flag || !TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, (num2 < 2) ? 1 : num2, (num2 < 2) ? 8 : num2, out num3, out number))
							{
								return result.SetInvalidStringFailure();
							}
							flag = true;
							break;
						}
						case 'e':
						case 'g':
							goto IL_287;
						case 'f':
							num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
							if (num2 > 7 || flag5 || !TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, num2, num2, out leadingZeroes, out number5))
							{
								return result.SetInvalidStringFailure();
							}
							flag5 = true;
							break;
						case 'h':
							num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
							if (num2 > 2 || flag2 || !TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, num2, out number2))
							{
								return result.SetInvalidStringFailure();
							}
							flag2 = true;
							break;
						default:
							goto IL_287;
						}
					}
					else
					{
						int num = DateTimeFormat.ParseNextChar(format, i);
						if (num < 0 || timeSpanTokenizer.NextChar() != (char)num)
						{
							return result.SetInvalidStringFailure();
						}
						num2 = 2;
					}
				}
				else if (c != 'm')
				{
					if (c != 's')
					{
						goto IL_287;
					}
					num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
					if (num2 > 2 || flag4 || !TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, num2, out number4))
					{
						return result.SetInvalidStringFailure();
					}
					flag4 = true;
				}
				else
				{
					num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
					if (num2 > 2 || flag3 || !TimeSpanParse.ParseExactDigits(ref timeSpanTokenizer, num2, out number3))
					{
						return result.SetInvalidStringFailure();
					}
					flag3 = true;
				}
				IL_28E:
				i += num2;
				continue;
				IL_287:
				return result.SetInvalidStringFailure();
			}
			if (!timeSpanTokenizer.EOL)
			{
				return result.SetBadTimeSpanFailure();
			}
			bool flag6 = (styles & TimeSpanStyles.AssumeNegative) == TimeSpanStyles.None;
			long num4;
			if (TimeSpanParse.TryTimeToTicks(flag6, new TimeSpanParse.TimeSpanToken(number), new TimeSpanParse.TimeSpanToken(number2), new TimeSpanParse.TimeSpanToken(number3), new TimeSpanParse.TimeSpanToken(number4), new TimeSpanParse.TimeSpanToken(number5, leadingZeroes), out num4))
			{
				if (!flag6)
				{
					num4 = -num4;
				}
				result.parsedTimeSpan = new TimeSpan(num4);
				return true;
			}
			return result.SetOverflowFailure();
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x000BFA48 File Offset: 0x000BDC48
		private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, out int result)
		{
			int maxDigitLength = (minDigitLength == 1) ? 2 : minDigitLength;
			int num;
			return TimeSpanParse.ParseExactDigits(ref tokenizer, minDigitLength, maxDigitLength, out num, out result);
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x000BFA6C File Offset: 0x000BDC6C
		private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, int maxDigitLength, out int zeroes, out int result)
		{
			int num = 0;
			int num2 = 0;
			int i;
			for (i = 0; i < maxDigitLength; i++)
			{
				char c = tokenizer.NextChar();
				if (!char.IsAsciiDigit(c))
				{
					tokenizer.BackOne();
					break;
				}
				num = num * 10 + (int)(c - '0');
				if (num == 0)
				{
					num2++;
				}
			}
			zeroes = num2;
			result = num;
			return i >= minDigitLength;
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x000BFAC0 File Offset: 0x000BDCC0
		private unsafe static bool ParseExactLiteral(ref TimeSpanParse.TimeSpanTokenizer tokenizer, ref ValueStringBuilder enquotedString)
		{
			ReadOnlySpan<char> readOnlySpan = enquotedString.AsSpan();
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				if (*readOnlySpan[i] != (ushort)tokenizer.NextChar())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x000BFAFC File Offset: 0x000BDCFC
		private static bool TryParseTimeSpanConstant(ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result)
		{
			return default(TimeSpanParse.StringParser).TryParse(input, ref result);
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x000BFB1C File Offset: 0x000BDD1C
		private static bool TryParseExactMultipleTimeSpan(ReadOnlySpan<char> input, string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result)
		{
			if (formats == null)
			{
				return result.SetArgumentNullFailure("formats");
			}
			if (input.Length == 0)
			{
				return result.SetBadTimeSpanFailure();
			}
			if (formats.Length == 0)
			{
				return result.SetNoFormatSpecifierFailure();
			}
			foreach (string value in formats)
			{
				if (string.IsNullOrEmpty(value))
				{
					return result.SetBadFormatSpecifierFailure(null);
				}
				TimeSpanParse.TimeSpanResult timeSpanResult = new TimeSpanParse.TimeSpanResult(false, input);
				if (TimeSpanParse.TryParseExactTimeSpan(input, value, formatProvider, styles, ref timeSpanResult))
				{
					result.parsedTimeSpan = timeSpanResult.parsedTimeSpan;
					return true;
				}
			}
			return result.SetBadTimeSpanFailure();
		}

		// Token: 0x0200031C RID: 796
		[Flags]
		private enum TimeSpanStandardStyles : byte
		{
			// Token: 0x04000B7E RID: 2942
			None = 0,
			// Token: 0x04000B7F RID: 2943
			Invariant = 1,
			// Token: 0x04000B80 RID: 2944
			Localized = 2,
			// Token: 0x04000B81 RID: 2945
			RequireFull = 4,
			// Token: 0x04000B82 RID: 2946
			Any = 3
		}

		// Token: 0x0200031D RID: 797
		private enum TTT : byte
		{
			// Token: 0x04000B84 RID: 2948
			None,
			// Token: 0x04000B85 RID: 2949
			End,
			// Token: 0x04000B86 RID: 2950
			Num,
			// Token: 0x04000B87 RID: 2951
			Sep,
			// Token: 0x04000B88 RID: 2952
			NumOverflow
		}

		// Token: 0x0200031E RID: 798
		[CompilerFeatureRequired("RefStructs")]
		private ref struct TimeSpanToken
		{
			// Token: 0x060039BC RID: 14780 RVA: 0x000BFBB4 File Offset: 0x000BDDB4
			public TimeSpanToken(TimeSpanParse.TTT type)
			{
				this = new TimeSpanParse.TimeSpanToken(type, 0, 0, default(ReadOnlySpan<char>));
			}

			// Token: 0x060039BD RID: 14781 RVA: 0x000BFBD4 File Offset: 0x000BDDD4
			public TimeSpanToken(int number)
			{
				this = new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.Num, number, 0, default(ReadOnlySpan<char>));
			}

			// Token: 0x060039BE RID: 14782 RVA: 0x000BFBF4 File Offset: 0x000BDDF4
			public TimeSpanToken(int number, int leadingZeroes)
			{
				this = new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.Num, number, leadingZeroes, default(ReadOnlySpan<char>));
			}

			// Token: 0x060039BF RID: 14783 RVA: 0x000BFC13 File Offset: 0x000BDE13
			public TimeSpanToken(TimeSpanParse.TTT type, int number, int leadingZeroes, ReadOnlySpan<char> separator)
			{
				this._ttt = type;
				this._num = number;
				this._zeroes = leadingZeroes;
				this._sep = separator;
			}

			// Token: 0x060039C0 RID: 14784 RVA: 0x000BFC34 File Offset: 0x000BDE34
			public bool NormalizeAndValidateFraction()
			{
				if (this._num == 0)
				{
					return true;
				}
				if (this._zeroes == 0 && this._num > 9999999)
				{
					return false;
				}
				int num = FormattingHelpers.CountDigits((uint)this._num) + this._zeroes;
				if (num == 7)
				{
					return true;
				}
				if (num < 7)
				{
					this._num *= TimeSpanParse.Pow10UpToMaxFractionDigits(7 - num);
					return true;
				}
				if (this._zeroes > 7)
				{
					this._num = 0;
					return true;
				}
				uint num2 = (uint)TimeSpanParse.Pow10UpToMaxFractionDigits(num - 7);
				this._num = (this._num + (int)(num2 / 2U)) / (int)num2;
				return true;
			}

			// Token: 0x04000B89 RID: 2953
			internal TimeSpanParse.TTT _ttt;

			// Token: 0x04000B8A RID: 2954
			internal int _num;

			// Token: 0x04000B8B RID: 2955
			internal int _zeroes;

			// Token: 0x04000B8C RID: 2956
			internal ReadOnlySpan<char> _sep;
		}

		// Token: 0x0200031F RID: 799
		[CompilerFeatureRequired("RefStructs")]
		private ref struct TimeSpanTokenizer
		{
			// Token: 0x060039C1 RID: 14785 RVA: 0x000BFCC4 File Offset: 0x000BDEC4
			internal TimeSpanTokenizer(ReadOnlySpan<char> input)
			{
				this = new TimeSpanParse.TimeSpanTokenizer(input, 0);
			}

			// Token: 0x060039C2 RID: 14786 RVA: 0x000BFCCE File Offset: 0x000BDECE
			internal TimeSpanTokenizer(ReadOnlySpan<char> input, int startPosition)
			{
				this._value = input;
				this._pos = startPosition;
			}

			// Token: 0x060039C3 RID: 14787 RVA: 0x000BFCE0 File Offset: 0x000BDEE0
			internal unsafe TimeSpanParse.TimeSpanToken GetNextToken()
			{
				int pos = this._pos;
				int num = pos;
				ReadOnlySpan<char> value = this._value;
				if (num >= value.Length)
				{
					return new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.End);
				}
				int num2 = (int)(*value[num] - 48);
				if (num2 <= 9)
				{
					int num3 = 0;
					if (num2 == 0)
					{
						num3 = 1;
						int num4;
						while (++num < value.Length && (num4 = (int)(*value[num] - 48)) <= 9)
						{
							if (num4 != 0)
							{
								num2 = num4;
								this._pos = num;
								goto IL_CB;
							}
							num3++;
						}
						this._pos = num;
						return new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.Num, 0, num3, default(ReadOnlySpan<char>));
					}
					IL_CB:
					while (++num < value.Length)
					{
						int num5 = (int)(*value[num] - 48);
						if (num5 > 9)
						{
							break;
						}
						num2 = num2 * 10 + num5;
						if (((long)num2 & (long)((ulong)-268435456)) != 0L)
						{
							this._pos = num;
							return new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.NumOverflow);
						}
					}
					this._pos = num;
					return new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.Num, num2, num3, default(ReadOnlySpan<char>));
				}
				int num6 = 1;
				while (++num < value.Length && !char.IsAsciiDigit((char)(*value[num])))
				{
					num6++;
				}
				this._pos = num;
				return new TimeSpanParse.TimeSpanToken(TimeSpanParse.TTT.Sep, 0, 0, this._value.Slice(pos, num6));
			}

			// Token: 0x17000AFA RID: 2810
			// (get) Token: 0x060039C4 RID: 14788 RVA: 0x000BFE27 File Offset: 0x000BE027
			internal bool EOL
			{
				get
				{
					return this._pos >= this._value.Length - 1;
				}
			}

			// Token: 0x060039C5 RID: 14789 RVA: 0x000BFE41 File Offset: 0x000BE041
			internal void BackOne()
			{
				if (this._pos > 0)
				{
					this._pos--;
				}
			}

			// Token: 0x060039C6 RID: 14790 RVA: 0x000BFE5C File Offset: 0x000BE05C
			internal unsafe char NextChar()
			{
				int num = this._pos + 1;
				this._pos = num;
				int num2 = num;
				if (num2 >= this._value.Length)
				{
					return '\0';
				}
				return (char)(*this._value[num2]);
			}

			// Token: 0x04000B8D RID: 2957
			private readonly ReadOnlySpan<char> _value;

			// Token: 0x04000B8E RID: 2958
			private int _pos;
		}

		// Token: 0x02000320 RID: 800
		[CompilerFeatureRequired("RefStructs")]
		private ref struct TimeSpanRawInfo
		{
			// Token: 0x17000AFB RID: 2811
			// (get) Token: 0x060039C7 RID: 14791 RVA: 0x000BFE98 File Offset: 0x000BE098
			internal TimeSpanFormat.FormatLiterals PositiveLocalized
			{
				get
				{
					if (!this._posLocInit)
					{
						this._posLoc = default(TimeSpanFormat.FormatLiterals);
						this._posLoc.Init(this._fullPosPattern, false);
						this._posLocInit = true;
					}
					return this._posLoc;
				}
			}

			// Token: 0x17000AFC RID: 2812
			// (get) Token: 0x060039C8 RID: 14792 RVA: 0x000BFED2 File Offset: 0x000BE0D2
			internal TimeSpanFormat.FormatLiterals NegativeLocalized
			{
				get
				{
					if (!this._negLocInit)
					{
						this._negLoc = default(TimeSpanFormat.FormatLiterals);
						this._negLoc.Init(this._fullNegPattern, false);
						this._negLocInit = true;
					}
					return this._negLoc;
				}
			}

			// Token: 0x060039C9 RID: 14793 RVA: 0x000BFF0C File Offset: 0x000BE10C
			internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 5 && this._numCount == 4 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.DayHourSep) && this._literals2.EqualsOrdinal(pattern.HourMinuteSep) && this._literals3.EqualsOrdinal(pattern.AppCompatLiteral) && this._literals4.EqualsOrdinal(pattern.End);
			}

			// Token: 0x060039CA RID: 14794 RVA: 0x000BFFAC File Offset: 0x000BE1AC
			internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 4 && this._numCount == 3 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.HourMinuteSep) && this._literals2.EqualsOrdinal(pattern.AppCompatLiteral) && this._literals3.EqualsOrdinal(pattern.End);
			}

			// Token: 0x060039CB RID: 14795 RVA: 0x000C0030 File Offset: 0x000BE230
			internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 6 && this._numCount == 5 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.DayHourSep) && this._literals2.EqualsOrdinal(pattern.HourMinuteSep) && this._literals3.EqualsOrdinal(pattern.MinuteSecondSep) && this._literals4.EqualsOrdinal(pattern.SecondFractionSep) && this._literals5.EqualsOrdinal(pattern.End);
			}

			// Token: 0x060039CC RID: 14796 RVA: 0x000C00EC File Offset: 0x000BE2EC
			internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 2 && this._numCount == 1 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.End);
			}

			// Token: 0x060039CD RID: 14797 RVA: 0x000C0140 File Offset: 0x000BE340
			internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 3 && this._numCount == 2 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.HourMinuteSep) && this._literals2.EqualsOrdinal(pattern.End);
			}

			// Token: 0x060039CE RID: 14798 RVA: 0x000C01AC File Offset: 0x000BE3AC
			internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 4 && this._numCount == 3 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.DayHourSep) && this._literals2.EqualsOrdinal(pattern.HourMinuteSep) && this._literals3.EqualsOrdinal(pattern.End);
			}

			// Token: 0x060039CF RID: 14799 RVA: 0x000C0230 File Offset: 0x000BE430
			internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 4 && this._numCount == 3 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.HourMinuteSep) && this._literals2.EqualsOrdinal(pattern.MinuteSecondSep) && this._literals3.EqualsOrdinal(pattern.End);
			}

			// Token: 0x060039D0 RID: 14800 RVA: 0x000C02B4 File Offset: 0x000BE4B4
			internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 5 && this._numCount == 4 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.DayHourSep) && this._literals2.EqualsOrdinal(pattern.HourMinuteSep) && this._literals3.EqualsOrdinal(pattern.MinuteSecondSep) && this._literals4.EqualsOrdinal(pattern.End);
			}

			// Token: 0x060039D1 RID: 14801 RVA: 0x000C0354 File Offset: 0x000BE554
			internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return this._sepCount == 5 && this._numCount == 4 && this._literals0.EqualsOrdinal(pattern.Start) && this._literals1.EqualsOrdinal(pattern.HourMinuteSep) && this._literals2.EqualsOrdinal(pattern.MinuteSecondSep) && this._literals3.EqualsOrdinal(pattern.SecondFractionSep) && this._literals4.EqualsOrdinal(pattern.End);
			}

			// Token: 0x060039D2 RID: 14802 RVA: 0x000C03F4 File Offset: 0x000BE5F4
			internal void Init(DateTimeFormatInfo dtfi)
			{
				this._lastSeenTTT = TimeSpanParse.TTT.None;
				this._tokenCount = 0;
				this._sepCount = 0;
				this._numCount = 0;
				this._fullPosPattern = dtfi.FullTimeSpanPositivePattern;
				this._fullNegPattern = dtfi.FullTimeSpanNegativePattern;
				this._posLocInit = false;
				this._negLocInit = false;
			}

			// Token: 0x060039D3 RID: 14803 RVA: 0x000C0444 File Offset: 0x000BE644
			internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result)
			{
				switch (tok._ttt)
				{
				case TimeSpanParse.TTT.Num:
					if ((this._tokenCount == 0 && !this.AddSep(default(ReadOnlySpan<char>), ref result)) || !this.AddNum(tok, ref result))
					{
						return false;
					}
					break;
				case TimeSpanParse.TTT.Sep:
					if (!this.AddSep(tok._sep, ref result))
					{
						return false;
					}
					break;
				case TimeSpanParse.TTT.NumOverflow:
					return result.SetOverflowFailure();
				default:
					return result.SetBadTimeSpanFailure();
				}
				this._lastSeenTTT = tok._ttt;
				return true;
			}

			// Token: 0x060039D4 RID: 14804 RVA: 0x000C04C8 File Offset: 0x000BE6C8
			private bool AddSep(ReadOnlySpan<char> sep, ref TimeSpanParse.TimeSpanResult result)
			{
				if (this._sepCount >= 6 || this._tokenCount >= 11)
				{
					return result.SetBadTimeSpanFailure();
				}
				int sepCount = this._sepCount;
				this._sepCount = sepCount + 1;
				switch (sepCount)
				{
				case 0:
					this._literals0 = sep;
					break;
				case 1:
					this._literals1 = sep;
					break;
				case 2:
					this._literals2 = sep;
					break;
				case 3:
					this._literals3 = sep;
					break;
				case 4:
					this._literals4 = sep;
					break;
				default:
					this._literals5 = sep;
					break;
				}
				this._tokenCount++;
				return true;
			}

			// Token: 0x060039D5 RID: 14805 RVA: 0x000C0560 File Offset: 0x000BE760
			private bool AddNum(TimeSpanParse.TimeSpanToken num, ref TimeSpanParse.TimeSpanResult result)
			{
				if (this._numCount >= 5 || this._tokenCount >= 11)
				{
					return result.SetBadTimeSpanFailure();
				}
				int numCount = this._numCount;
				this._numCount = numCount + 1;
				switch (numCount)
				{
				case 0:
					this._numbers0 = num;
					break;
				case 1:
					this._numbers1 = num;
					break;
				case 2:
					this._numbers2 = num;
					break;
				case 3:
					this._numbers3 = num;
					break;
				default:
					this._numbers4 = num;
					break;
				}
				this._tokenCount++;
				return true;
			}

			// Token: 0x04000B8F RID: 2959
			internal TimeSpanParse.TTT _lastSeenTTT;

			// Token: 0x04000B90 RID: 2960
			internal int _tokenCount;

			// Token: 0x04000B91 RID: 2961
			internal int _sepCount;

			// Token: 0x04000B92 RID: 2962
			internal int _numCount;

			// Token: 0x04000B93 RID: 2963
			private TimeSpanFormat.FormatLiterals _posLoc;

			// Token: 0x04000B94 RID: 2964
			private TimeSpanFormat.FormatLiterals _negLoc;

			// Token: 0x04000B95 RID: 2965
			private bool _posLocInit;

			// Token: 0x04000B96 RID: 2966
			private bool _negLocInit;

			// Token: 0x04000B97 RID: 2967
			private string _fullPosPattern;

			// Token: 0x04000B98 RID: 2968
			private string _fullNegPattern;

			// Token: 0x04000B99 RID: 2969
			internal TimeSpanParse.TimeSpanToken _numbers0;

			// Token: 0x04000B9A RID: 2970
			internal TimeSpanParse.TimeSpanToken _numbers1;

			// Token: 0x04000B9B RID: 2971
			internal TimeSpanParse.TimeSpanToken _numbers2;

			// Token: 0x04000B9C RID: 2972
			internal TimeSpanParse.TimeSpanToken _numbers3;

			// Token: 0x04000B9D RID: 2973
			internal TimeSpanParse.TimeSpanToken _numbers4;

			// Token: 0x04000B9E RID: 2974
			internal ReadOnlySpan<char> _literals0;

			// Token: 0x04000B9F RID: 2975
			internal ReadOnlySpan<char> _literals1;

			// Token: 0x04000BA0 RID: 2976
			internal ReadOnlySpan<char> _literals2;

			// Token: 0x04000BA1 RID: 2977
			internal ReadOnlySpan<char> _literals3;

			// Token: 0x04000BA2 RID: 2978
			internal ReadOnlySpan<char> _literals4;

			// Token: 0x04000BA3 RID: 2979
			internal ReadOnlySpan<char> _literals5;
		}

		// Token: 0x02000321 RID: 801
		[CompilerFeatureRequired("RefStructs")]
		private ref struct TimeSpanResult
		{
			// Token: 0x060039D6 RID: 14806 RVA: 0x000C05EB File Offset: 0x000BE7EB
			internal TimeSpanResult(bool throwOnFailure, ReadOnlySpan<char> originalTimeSpanString)
			{
				this.parsedTimeSpan = default(TimeSpan);
				this._throwOnFailure = throwOnFailure;
				this._originalTimeSpanString = originalTimeSpanString;
			}

			// Token: 0x060039D7 RID: 14807 RVA: 0x000C0607 File Offset: 0x000BE807
			internal bool SetNoFormatSpecifierFailure()
			{
				if (!this._throwOnFailure)
				{
					return false;
				}
				throw new FormatException(SR.Format_NoFormatSpecifier);
			}

			// Token: 0x060039D8 RID: 14808 RVA: 0x000C061D File Offset: 0x000BE81D
			internal bool SetBadQuoteFailure(char failingCharacter)
			{
				if (!this._throwOnFailure)
				{
					return false;
				}
				throw new FormatException(SR.Format(SR.Format_BadQuote, failingCharacter));
			}

			// Token: 0x060039D9 RID: 14809 RVA: 0x000C063E File Offset: 0x000BE83E
			internal bool SetInvalidStringFailure()
			{
				if (!this._throwOnFailure)
				{
					return false;
				}
				throw new FormatException(SR.Format_InvalidString);
			}

			// Token: 0x060039DA RID: 14810 RVA: 0x000C0654 File Offset: 0x000BE854
			internal bool SetArgumentNullFailure(string argumentName)
			{
				if (this._throwOnFailure)
				{
					ArgumentNullException.Throw(argumentName);
				}
				return false;
			}

			// Token: 0x060039DB RID: 14811 RVA: 0x000C0665 File Offset: 0x000BE865
			internal bool SetOverflowFailure()
			{
				if (!this._throwOnFailure)
				{
					return false;
				}
				throw new OverflowException(SR.Format(SR.Overflow_TimeSpanElementTooLarge, new string(this._originalTimeSpanString)));
			}

			// Token: 0x060039DC RID: 14812 RVA: 0x000C068B File Offset: 0x000BE88B
			internal bool SetBadTimeSpanFailure()
			{
				if (!this._throwOnFailure)
				{
					return false;
				}
				throw new FormatException(SR.Format(SR.Format_BadTimeSpan, new string(this._originalTimeSpanString)));
			}

			// Token: 0x060039DD RID: 14813 RVA: 0x000C06B1 File Offset: 0x000BE8B1
			internal bool SetBadFormatSpecifierFailure(char? formatSpecifierCharacter = null)
			{
				if (!this._throwOnFailure)
				{
					return false;
				}
				throw new FormatException(SR.Format(SR.Format_BadFormatSpecifier, formatSpecifierCharacter));
			}

			// Token: 0x04000BA4 RID: 2980
			internal TimeSpan parsedTimeSpan;

			// Token: 0x04000BA5 RID: 2981
			private readonly bool _throwOnFailure;

			// Token: 0x04000BA6 RID: 2982
			private readonly ReadOnlySpan<char> _originalTimeSpanString;
		}

		// Token: 0x02000322 RID: 802
		[CompilerFeatureRequired("RefStructs")]
		private ref struct StringParser
		{
			// Token: 0x060039DE RID: 14814 RVA: 0x000C06D4 File Offset: 0x000BE8D4
			internal unsafe void NextChar()
			{
				ReadOnlySpan<char> str = this._str;
				if (this._pos < str.Length)
				{
					this._pos++;
				}
				int pos = this._pos;
				this._ch = (char)((pos < str.Length) ? (*str[pos]) : 0);
			}

			// Token: 0x060039DF RID: 14815 RVA: 0x000C0728 File Offset: 0x000BE928
			internal unsafe char NextNonDigit()
			{
				int num = this._str.Slice(this._pos).IndexOfAnyExceptInRange('0', '9');
				if (num >= 0)
				{
					return (char)(*this._str[this._pos + num]);
				}
				return '\0';
			}

			// Token: 0x060039E0 RID: 14816 RVA: 0x000C076C File Offset: 0x000BE96C
			internal bool TryParse(ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result)
			{
				result.parsedTimeSpan = default(TimeSpan);
				this._str = input;
				this._pos = -1;
				this.NextChar();
				this.SkipBlanks();
				bool flag = false;
				if (this._ch == '-')
				{
					flag = true;
					this.NextChar();
				}
				long num;
				if (this.NextNonDigit() == ':')
				{
					if (!this.ParseTime(out num, ref result))
					{
						return false;
					}
				}
				else
				{
					int num2;
					if (!this.ParseInt(10675199, out num2, ref result))
					{
						return false;
					}
					num = (long)num2 * 864000000000L;
					if (this._ch == '.')
					{
						this.NextChar();
						long num3;
						if (!this.ParseTime(out num3, ref result))
						{
							return false;
						}
						num += num3;
					}
				}
				if (flag)
				{
					num = -num;
					if (num > 0L)
					{
						return result.SetOverflowFailure();
					}
				}
				else if (num < 0L)
				{
					return result.SetOverflowFailure();
				}
				this.SkipBlanks();
				if (this._pos < this._str.Length)
				{
					return result.SetBadTimeSpanFailure();
				}
				result.parsedTimeSpan = new TimeSpan(num);
				return true;
			}

			// Token: 0x060039E1 RID: 14817 RVA: 0x000C0858 File Offset: 0x000BEA58
			internal bool ParseInt(int max, out int i, ref TimeSpanParse.TimeSpanResult result)
			{
				i = 0;
				int pos = this._pos;
				while (char.IsAsciiDigit(this._ch))
				{
					if (((long)i & (long)((ulong)-268435456)) != 0L)
					{
						return result.SetOverflowFailure();
					}
					i = i * 10 + (int)this._ch - 48;
					if (i < 0)
					{
						return result.SetOverflowFailure();
					}
					this.NextChar();
				}
				if (pos == this._pos)
				{
					return result.SetBadTimeSpanFailure();
				}
				return i <= max || result.SetOverflowFailure();
			}

			// Token: 0x060039E2 RID: 14818 RVA: 0x000C08D4 File Offset: 0x000BEAD4
			internal bool ParseTime(out long time, ref TimeSpanParse.TimeSpanResult result)
			{
				time = 0L;
				int num;
				if (!this.ParseInt(23, out num, ref result))
				{
					return false;
				}
				time = (long)num * 36000000000L;
				if (this._ch != ':')
				{
					return result.SetBadTimeSpanFailure();
				}
				this.NextChar();
				if (!this.ParseInt(59, out num, ref result))
				{
					return false;
				}
				time += (long)num * 600000000L;
				if (this._ch == ':')
				{
					this.NextChar();
					if (this._ch != '.')
					{
						if (!this.ParseInt(59, out num, ref result))
						{
							return false;
						}
						time += (long)num * 10000000L;
					}
					if (this._ch == '.')
					{
						this.NextChar();
						int num2 = 10000000;
						while (num2 > 1 && char.IsAsciiDigit(this._ch))
						{
							num2 /= 10;
							time += (long)((int)(this._ch - '0') * num2);
							this.NextChar();
						}
					}
				}
				return true;
			}

			// Token: 0x060039E3 RID: 14819 RVA: 0x000C09B3 File Offset: 0x000BEBB3
			internal void SkipBlanks()
			{
				while (this._ch == ' ' || this._ch == '\t')
				{
					this.NextChar();
				}
			}

			// Token: 0x04000BA7 RID: 2983
			private ReadOnlySpan<char> _str;

			// Token: 0x04000BA8 RID: 2984
			private char _ch;

			// Token: 0x04000BA9 RID: 2985
			private int _pos;
		}
	}
}
