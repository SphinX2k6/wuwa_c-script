using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
	// Token: 0x02000124 RID: 292
	internal static class DateTimeFormat
	{
		// Token: 0x060011B4 RID: 4532 RVA: 0x00030E10 File Offset: 0x0002F010
		internal unsafe static void FormatDigits<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> outputBuffer, int value, int minimumLength) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			switch (minimumLength)
			{
			case 1:
				if (value < 10)
				{
					outputBuffer.Append(INumberBase<TChar>.CreateTruncating<int>(value + 48));
					return;
				}
				break;
			case 2:
				if (value < 100)
				{
					fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(outputBuffer.AppendSpan(2)))
					{
						TChar* ptr = reference;
						Number.WriteTwoDigits<TChar>((uint)value, ptr);
					}
					return;
				}
				break;
			case 4:
				if (value < 10000)
				{
					fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(outputBuffer.AppendSpan(4)))
					{
						TChar* ptr2 = reference;
						Number.WriteFourDigits<TChar>((uint)value, ptr2);
					}
					return;
				}
				break;
			}
			TChar* ptr3 = stackalloc TChar[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(TChar))];
			TChar* ptr4 = Number.UInt32ToDecChars<TChar>(ptr3 + (IntPtr)16 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), (uint)value, minimumLength);
			outputBuffer.Append(new ReadOnlySpan<TChar>((void*)ptr4, (int)((long)((ptr3 + (IntPtr)16 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar) - ptr4) / (IntPtr)sizeof(TChar) * (IntPtr)sizeof(TChar)))));
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00030EE4 File Offset: 0x0002F0E4
		internal unsafe static int ParseRepeatPattern(ReadOnlySpan<char> format, int pos, char patternChar)
		{
			int num = pos + 1;
			while (num < format.Length && *format[num] == (ushort)patternChar)
			{
				num++;
			}
			return num - pos;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00030F14 File Offset: 0x0002F114
		private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi)
		{
			if (repeat == 3)
			{
				return dtfi.GetAbbreviatedDayName((DayOfWeek)dayOfWeek);
			}
			return dtfi.GetDayName((DayOfWeek)dayOfWeek);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00030F29 File Offset: 0x0002F129
		private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi)
		{
			if (repeatCount == 3)
			{
				return dtfi.GetAbbreviatedMonthName(month);
			}
			return dtfi.GetMonthName(month);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00030F40 File Offset: 0x0002F140
		private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi)
		{
			if (dtfi.Calendar.IsLeapYear(dtfi.Calendar.GetYear(time)))
			{
				return dtfi.InternalGetMonthName(month, MonthNameStyles.LeapYear, repeatCount == 3);
			}
			if (month >= 7)
			{
				month++;
			}
			if (repeatCount == 3)
			{
				return dtfi.GetAbbreviatedMonthName(month);
			}
			return dtfi.GetMonthName(month);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00030F90 File Offset: 0x0002F190
		internal unsafe static int ParseQuoteString<[IsUnmanaged] TChar>([ScopedRef] ReadOnlySpan<char> format, int pos, ref ValueListBuilder<TChar> result) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int length = format.Length;
			int num = pos;
			char c = (char)(*format[pos++]);
			bool flag = false;
			while (pos < length)
			{
				char c2 = (char)(*format[pos++]);
				if (c2 == c)
				{
					flag = true;
					break;
				}
				if (c2 == '\\')
				{
					if (pos >= length)
					{
						throw new FormatException(SR.Format_InvalidString);
					}
					result.Append(IUtfChar<TChar>.CastFrom((char)(*format[pos++])));
				}
				else
				{
					DateTimeFormat.AppendChar<TChar>(ref result, c2);
				}
			}
			if (!flag)
			{
				throw new FormatException(SR.Format(SR.Format_BadQuote, c));
			}
			return pos - num;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00031031 File Offset: 0x0002F231
		internal unsafe static int ParseNextChar(ReadOnlySpan<char> format, int pos)
		{
			if (pos + 1 >= format.Length)
			{
				return -1;
			}
			return (int)(*format[pos + 1]);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0003104C File Offset: 0x0002F24C
		private unsafe static bool IsUseGenitiveForm(ReadOnlySpan<char> format, int index, int tokenLen, char patternToMatch)
		{
			int num = 0;
			int num2 = index - 1;
			while (num2 >= 0 && *format[num2] != (ushort)patternToMatch)
			{
				num2--;
			}
			if (num2 >= 0)
			{
				while (--num2 >= 0 && *format[num2] == (ushort)patternToMatch)
				{
					num++;
				}
				if (num <= 1)
				{
					return true;
				}
			}
			num2 = index + tokenLen;
			while (num2 < format.Length && *format[num2] != (ushort)patternToMatch)
			{
				num2++;
			}
			if (num2 < format.Length)
			{
				num = 0;
				while (++num2 < format.Length && *format[num2] == (ushort)patternToMatch)
				{
					num++;
				}
				if (num <= 1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x000310EC File Offset: 0x0002F2EC
		private unsafe static void FormatCustomized<[IsUnmanaged] TChar>(DateTime dateTime, [ScopedRef] ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset, ref ValueListBuilder<TChar> result) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			Calendar calendar = dtfi.Calendar;
			bool flag = calendar.ID == CalendarId.HEBREW;
			bool flag2 = calendar.ID == CalendarId.JAPAN;
			bool timeOnly = true;
			int i = 0;
			while (i < format.Length)
			{
				char c = (char)(*format[i]);
				int num2;
				if (c <= 'K')
				{
					if (c <= '/')
					{
						if (c <= '%')
						{
							if (c != '"')
							{
								if (c != '%')
								{
									goto IL_667;
								}
								int num = DateTimeFormat.ParseNextChar(format, i);
								if (num >= 0 && num != 37)
								{
									char c2 = (char)num;
									DateTimeFormat.FormatCustomized<TChar>(dateTime, new ReadOnlySpan<char>(ref c2), dtfi, offset, ref result);
									num2 = 2;
									goto IL_673;
								}
								throw new FormatException(SR.Format_InvalidString);
							}
						}
						else if (c != '\'')
						{
							if (c != '/')
							{
								goto IL_667;
							}
							result.Append(dtfi.DateSeparatorTChar<TChar>());
							num2 = 1;
							goto IL_673;
						}
						num2 = DateTimeFormat.ParseQuoteString<TChar>(format, i, ref result);
					}
					else if (c <= 'F')
					{
						if (c != ':')
						{
							if (c != 'F')
							{
								goto IL_667;
							}
							goto IL_209;
						}
						else
						{
							result.Append(dtfi.TimeSeparatorTChar<TChar>());
							num2 = 1;
						}
					}
					else if (c != 'H')
					{
						if (c != 'K')
						{
							goto IL_667;
						}
						num2 = 1;
						DateTimeFormat.FormatCustomizedRoundripTimeZone<TChar>(dateTime, offset, ref result);
					}
					else
					{
						num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
						DateTimeFormat.FormatDigits<TChar>(ref result, dateTime.Hour, Math.Min(num2, 2));
					}
				}
				else if (c <= 'm')
				{
					if (c <= '\\')
					{
						if (c != 'M')
						{
							if (c != '\\')
							{
								goto IL_667;
							}
							int num = DateTimeFormat.ParseNextChar(format, i);
							if (num < 0)
							{
								throw new FormatException(SR.Format_InvalidString);
							}
							result.Append(IUtfChar<TChar>.CastFrom(num));
							num2 = 2;
						}
						else
						{
							num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
							int month = calendar.GetMonth(dateTime);
							if (num2 <= 2)
							{
								if (flag)
								{
									HebrewNumber.Append<TChar>(ref result, month);
								}
								else
								{
									DateTimeFormat.FormatDigits<TChar>(ref result, month, num2);
								}
							}
							else if (flag)
							{
								DateTimeFormat.AppendString<TChar>(ref result, DateTimeFormat.FormatHebrewMonthName(dateTime, month, num2, dtfi));
							}
							else if ((dtfi.FormatFlags & DateTimeFormatFlags.UseGenitiveMonth) != DateTimeFormatFlags.None)
							{
								DateTimeFormat.AppendString<TChar>(ref result, dtfi.InternalGetMonthName(month, DateTimeFormat.IsUseGenitiveForm(format, i, num2, 'd') ? MonthNameStyles.Genitive : MonthNameStyles.Regular, num2 == 3));
							}
							else
							{
								DateTimeFormat.AppendString<TChar>(ref result, DateTimeFormat.FormatMonth(month, num2, dtfi));
							}
							timeOnly = false;
						}
					}
					else
					{
						switch (c)
						{
						case 'd':
							num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
							if (num2 <= 2)
							{
								int dayOfMonth = calendar.GetDayOfMonth(dateTime);
								if (flag)
								{
									HebrewNumber.Append<TChar>(ref result, dayOfMonth);
								}
								else
								{
									DateTimeFormat.FormatDigits<TChar>(ref result, dayOfMonth, num2);
								}
							}
							else
							{
								int dayOfWeek = (int)calendar.GetDayOfWeek(dateTime);
								DateTimeFormat.AppendString<TChar>(ref result, DateTimeFormat.FormatDayOfWeek(dayOfWeek, num2, dtfi));
							}
							timeOnly = false;
							break;
						case 'e':
							goto IL_667;
						case 'f':
							goto IL_209;
						case 'g':
							num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
							DateTimeFormat.AppendString<TChar>(ref result, dtfi.GetEraName(calendar.GetEra(dateTime)));
							break;
						case 'h':
						{
							num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
							int num3 = dateTime.Hour;
							if (num3 > 12)
							{
								num3 -= 12;
							}
							else if (num3 == 0)
							{
								num3 = 12;
							}
							DateTimeFormat.FormatDigits<TChar>(ref result, num3, Math.Min(num2, 2));
							break;
						}
						default:
							if (c != 'm')
							{
								goto IL_667;
							}
							num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
							DateTimeFormat.FormatDigits<TChar>(ref result, dateTime.Minute, Math.Min(num2, 2));
							break;
						}
					}
				}
				else if (c <= 't')
				{
					if (c != 's')
					{
						if (c != 't')
						{
							goto IL_667;
						}
						num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
						if (num2 == 1)
						{
							string text = (dateTime.Hour < 12) ? dtfi.AMDesignator : dtfi.PMDesignator;
							if (text.Length >= 1)
							{
								DateTimeFormat.AppendChar<TChar>(ref result, text[0]);
							}
						}
						else
						{
							result.Append((dateTime.Hour < 12) ? dtfi.AMDesignatorTChar<TChar>() : dtfi.PMDesignatorTChar<TChar>());
						}
					}
					else
					{
						num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
						DateTimeFormat.FormatDigits<TChar>(ref result, dateTime.Second, Math.Min(num2, 2));
					}
				}
				else if (c != 'y')
				{
					if (c != 'z')
					{
						goto IL_667;
					}
					num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
					DateTimeFormat.FormatCustomizedTimeZone<TChar>(dateTime, offset, num2, timeOnly, ref result);
				}
				else
				{
					int year = calendar.GetYear(dateTime);
					num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
					if (flag2 && !LocalAppContextSwitches.FormatJapaneseFirstYearAsANumber && year == 1 && ((i + num2 < format.Length && *format[i + num2] == 24180) || (i + num2 < format.Length - 1 && *format[i + num2] == 39 && *format[i + num2 + 1] == 24180)))
					{
						DateTimeFormat.AppendChar<TChar>(ref result, "元"[0]);
					}
					else if (dtfi.HasForceTwoDigitYears)
					{
						DateTimeFormat.FormatDigits<TChar>(ref result, year, Math.Min(num2, 2));
					}
					else if (calendar.ID == CalendarId.HEBREW)
					{
						HebrewNumber.Append<TChar>(ref result, year);
					}
					else if (num2 <= 2)
					{
						DateTimeFormat.FormatDigits<TChar>(ref result, year % 100, num2);
					}
					else if (num2 <= 16)
					{
						DateTimeFormat.FormatDigits<TChar>(ref result, year, num2);
					}
					else
					{
						DateTimeFormat.AppendString<TChar>(ref result, year.ToString("D" + num2.ToString(CultureInfo.InvariantCulture), CultureInfo.InvariantCulture));
					}
					timeOnly = false;
				}
				IL_673:
				i += num2;
				continue;
				IL_209:
				num2 = DateTimeFormat.ParseRepeatPattern(format, i, c);
				if (num2 > 7)
				{
					throw new FormatException(SR.Format_InvalidString);
				}
				int num4 = (int)(dateTime.Ticks % 10000000L);
				num4 /= TimeSpanParse.Pow10UpToMaxFractionDigits(7 - num2);
				if (c == 'f')
				{
					DateTimeFormat.FormatFraction<TChar>(ref result, num4, DateTimeFormat.fixedNumberFormats[num2 - 1]);
					goto IL_673;
				}
				int num5 = num2;
				while (num5 > 0 && num4 % 10 == 0)
				{
					num4 /= 10;
					num5--;
				}
				if (num5 > 0)
				{
					DateTimeFormat.FormatFraction<TChar>(ref result, num4, DateTimeFormat.fixedNumberFormats[num5 - 1]);
					goto IL_673;
				}
				if (result.Length > 0 && *result[result.Length - 1] == IUtfChar<TChar>.CastFrom('.'))
				{
					int length = result.Length;
					result.Length = length - 1;
					goto IL_673;
				}
				goto IL_673;
				IL_667:
				DateTimeFormat.AppendChar<TChar>(ref result, c);
				num2 = 1;
				goto IL_673;
			}
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00031784 File Offset: 0x0002F984
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void AppendChar<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> result, char ch) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (typeof(TChar) == typeof(char) || char.IsAscii(ch))
			{
				result.Append(IUtfChar<TChar>.CastFrom(ch));
				return;
			}
			Rune rune = new Rune(ch);
			rune.EncodeToUtf8(MemoryMarshal.AsBytes<TChar>(result.AppendSpan(rune.Utf8SequenceLength)));
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x000317EC File Offset: 0x0002F9EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void AppendString<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> result, [ScopedRef] ReadOnlySpan<char> s) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (typeof(TChar) == typeof(char))
			{
				result.Append(Unsafe.BitCast<ReadOnlySpan<char>, ReadOnlySpan<TChar>>(s));
				return;
			}
			Encoding.UTF8.GetBytes(s, Unsafe.BitCast<Span<TChar>, Span<byte>>(result.AppendSpan(Encoding.UTF8.GetByteCount(s))));
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00031844 File Offset: 0x0002FA44
		internal unsafe static void FormatFraction<[IsUnmanaged] TChar>(ref ValueListBuilder<TChar> result, int fraction, ReadOnlySpan<char> fractionFormat) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			Span<TChar> source = new Span<TChar>(stackalloc byte[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(TChar))], 11);
			int length;
			if (!(typeof(TChar) == typeof(char)))
			{
				fraction.TryFormat(Unsafe.BitCast<Span<TChar>, Span<byte>>(source), out length, fractionFormat, CultureInfo.InvariantCulture);
			}
			else
			{
				fraction.TryFormat(Unsafe.BitCast<Span<TChar>, Span<char>>(source), out length, fractionFormat, CultureInfo.InvariantCulture);
			}
			result.Append(source.Slice(0, length));
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000318C4 File Offset: 0x0002FAC4
		private unsafe static void FormatCustomizedTimeZone<[IsUnmanaged] TChar>(DateTime dateTime, TimeSpan offset, int tokenLen, bool timeOnly, ref ValueListBuilder<TChar> result) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (offset.Ticks == -9223372036854775808L)
			{
				if (timeOnly && dateTime.Ticks < 864000000000L)
				{
					offset = TimeZoneInfo.GetLocalUtcOffset(DateTime.Now, TimeZoneInfoOptions.NoThrowOnInvalidTime);
				}
				else if (dateTime.Kind == DateTimeKind.Utc)
				{
					offset = default(TimeSpan);
				}
				else
				{
					offset = TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime);
				}
			}
			if (offset.Ticks >= 0L)
			{
				result.Append(IUtfChar<TChar>.CastFrom('+'));
			}
			else
			{
				result.Append(IUtfChar<TChar>.CastFrom('-'));
				offset = offset.Negate();
			}
			if (tokenLen <= 1)
			{
				ValueTuple<int, int> valueTuple = Math.DivRem(offset.Hours, 10);
				int item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				if (item != 0)
				{
					result.Append(IUtfChar<TChar>.CastFrom(48 + item));
				}
				result.Append(IUtfChar<TChar>.CastFrom(48 + item2));
				return;
			}
			if (tokenLen == 2)
			{
				fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(result.AppendSpan(2)))
				{
					TChar* ptr = reference;
					Number.WriteTwoDigits<TChar>((uint)offset.Hours, ptr);
				}
				return;
			}
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(result.AppendSpan(5)))
			{
				TChar* ptr2 = reference;
				Number.WriteTwoDigits<TChar>((uint)offset.Hours, ptr2);
				ptr2[(IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)offset.Minutes, ptr2 + (IntPtr)3 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00031A34 File Offset: 0x0002FC34
		private unsafe static void FormatCustomizedRoundripTimeZone<[IsUnmanaged] TChar>(DateTime dateTime, TimeSpan offset, ref ValueListBuilder<TChar> result) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (offset.Ticks == -9223372036854775808L)
			{
				DateTimeKind kind = dateTime.Kind;
				if (kind == DateTimeKind.Utc)
				{
					result.Append(IUtfChar<TChar>.CastFrom('Z'));
					return;
				}
				if (kind != DateTimeKind.Local)
				{
					return;
				}
				offset = TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
			if (offset.Ticks >= 0L)
			{
				result.Append(IUtfChar<TChar>.CastFrom('+'));
			}
			else
			{
				result.Append(IUtfChar<TChar>.CastFrom('-'));
				offset = offset.Negate();
			}
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(result.AppendSpan(5)))
			{
				TChar* ptr = reference;
				Number.WriteTwoDigits<TChar>((uint)offset.Hours, ptr);
				ptr[(IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)offset.Minutes, ptr + (IntPtr)3 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00031B14 File Offset: 0x0002FD14
		internal static string ExpandStandardFormatToCustomPattern(char format, DateTimeFormatInfo dtfi)
		{
			if (format > 'U')
			{
				if (format != 'Y')
				{
					switch (format)
					{
					case 'd':
						return dtfi.ShortDatePattern;
					case 'e':
						goto IL_14F;
					case 'f':
						return dtfi.LongDatePattern + " " + dtfi.ShortTimePattern;
					case 'g':
						return dtfi.GeneralShortTimePattern;
					default:
						switch (format)
						{
						case 'm':
							goto IL_FF;
						case 'n':
						case 'p':
						case 'q':
						case 'v':
						case 'w':
						case 'x':
							goto IL_14F;
						case 'o':
							goto IL_108;
						case 'r':
							goto IL_110;
						case 's':
							return dtfi.SortableDateTimePattern;
						case 't':
							return dtfi.ShortTimePattern;
						case 'u':
							return dtfi.UniversalSortableDateTimePattern;
						case 'y':
							break;
						default:
							goto IL_14F;
						}
						break;
					}
				}
				return dtfi.YearMonthPattern;
			}
			switch (format)
			{
			case 'D':
				return dtfi.LongDatePattern;
			case 'E':
				goto IL_14F;
			case 'F':
				return dtfi.FullDateTimePattern;
			case 'G':
				return dtfi.GeneralLongTimePattern;
			default:
				switch (format)
				{
				case 'M':
					break;
				case 'N':
				case 'P':
				case 'Q':
				case 'S':
					goto IL_14F;
				case 'O':
					goto IL_108;
				case 'R':
					goto IL_110;
				case 'T':
					return dtfi.LongTimePattern;
				case 'U':
					return dtfi.FullDateTimePattern;
				default:
					goto IL_14F;
				}
				break;
			}
			IL_FF:
			return dtfi.MonthDayPattern;
			IL_108:
			return "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";
			IL_110:
			return dtfi.RFC1123Pattern;
			IL_14F:
			throw new FormatException(SR.Format_InvalidString);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00031C7C File Offset: 0x0002FE7C
		internal static string Format(DateTime dateTime, string format, IFormatProvider provider)
		{
			return DateTimeFormat.Format(dateTime, format, provider, new TimeSpan(long.MinValue));
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00031C94 File Offset: 0x0002FE94
		internal unsafe static string Format(DateTime dateTime, string format, IFormatProvider provider, TimeSpan offset)
		{
			DateTimeFormatInfo dateTimeFormatInfo;
			if (string.IsNullOrEmpty(format))
			{
				dateTimeFormatInfo = DateTimeFormatInfo.GetInstance(provider);
				if (offset.Ticks == -9223372036854775808L)
				{
					if (DateTimeFormat.IsTimeOnlySpecialCase(dateTime, dateTimeFormatInfo))
					{
						string text = string.FastAllocateString(19);
						int num;
						DateTimeFormat.TryFormatS<char>(dateTime, new Span<char>(text.GetRawStringData(), text.Length), out num);
						return text;
					}
					if (dateTimeFormatInfo == DateTimeFormatInfo.InvariantInfo)
					{
						string text2 = string.FastAllocateString(19);
						int num2;
						DateTimeFormat.TryFormatInvariantG<char>(dateTime, offset, new Span<char>(text2.GetRawStringData(), text2.Length), out num2);
						return text2;
					}
					format = dateTimeFormatInfo.GeneralLongTimePattern;
				}
				else if (DateTimeFormat.IsTimeOnlySpecialCase(dateTime, dateTimeFormatInfo))
				{
					format = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz";
					dateTimeFormatInfo = DateTimeFormatInfo.InvariantInfo;
				}
				else
				{
					if (dateTimeFormatInfo == DateTimeFormatInfo.InvariantInfo)
					{
						string text3 = string.FastAllocateString(26);
						int num3;
						DateTimeFormat.TryFormatInvariantG<char>(dateTime, offset, new Span<char>(text3.GetRawStringData(), text3.Length), out num3);
						return text3;
					}
					format = dateTimeFormatInfo.DateTimeOffsetPattern;
				}
			}
			else if (format.Length == 1)
			{
				char c = format[0];
				string text4;
				int length;
				if (c <= 'R')
				{
					if (c != 'O')
					{
						if (c != 'R')
						{
							goto IL_211;
						}
						goto IL_17C;
					}
				}
				else
				{
					if (c == 'U')
					{
						dateTimeFormatInfo = DateTimeFormatInfo.GetInstance(provider);
						DateTimeFormat.PrepareFormatU(ref dateTime, ref dateTimeFormatInfo, offset);
						format = dateTimeFormatInfo.FullDateTimePattern;
						goto IL_230;
					}
					switch (c)
					{
					case 'o':
						break;
					case 'p':
					case 'q':
					case 't':
						goto IL_211;
					case 'r':
						goto IL_17C;
					case 's':
						text4 = string.FastAllocateString(19);
						DateTimeFormat.TryFormatS<char>(dateTime, new Span<char>(text4.GetRawStringData(), text4.Length), out length);
						return text4;
					case 'u':
						text4 = string.FastAllocateString(20);
						DateTimeFormat.TryFormatu<char>(dateTime, offset, new Span<char>(text4.GetRawStringData(), text4.Length), out length);
						return text4;
					default:
						goto IL_211;
					}
				}
				Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)66], 33);
				DateTimeFormat.TryFormatO<char>(dateTime, offset, destination, out length);
				return destination.Slice(0, length).ToString();
				IL_17C:
				text4 = string.FastAllocateString(29);
				DateTimeFormat.TryFormatR<char>(dateTime, offset, new Span<char>(text4.GetRawStringData(), text4.Length), out length);
				return text4;
				IL_211:
				dateTimeFormatInfo = DateTimeFormatInfo.GetInstance(provider);
				format = DateTimeFormat.ExpandStandardFormatToCustomPattern(format[0], dateTimeFormatInfo);
			}
			else
			{
				dateTimeFormatInfo = DateTimeFormatInfo.GetInstance(provider);
			}
			IL_230:
			Span<char> initialSpan = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ValueListBuilder<char> valueListBuilder = new ValueListBuilder<char>(initialSpan);
			DateTimeFormat.FormatCustomized<char>(dateTime, format, dateTimeFormatInfo, offset, ref valueListBuilder);
			string result = valueListBuilder.AsSpan().ToString();
			valueListBuilder.Dispose();
			return result;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00031F1B File Offset: 0x0003011B
		internal static bool TryFormat<[IsUnmanaged] TChar>(DateTime dateTime, Span<TChar> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			return DateTimeFormat.TryFormat<TChar>(dateTime, destination, out charsWritten, format, provider, new TimeSpan(long.MinValue));
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00031F38 File Offset: 0x00030138
		internal unsafe static bool TryFormat<[IsUnmanaged] TChar>(DateTime dateTime, Span<TChar> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, TimeSpan offset) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			DateTimeFormatInfo dateTimeFormatInfo;
			if (format.IsEmpty)
			{
				dateTimeFormatInfo = DateTimeFormatInfo.GetInstance(provider);
				if (offset.Ticks == -9223372036854775808L)
				{
					if (DateTimeFormat.IsTimeOnlySpecialCase(dateTime, dateTimeFormatInfo))
					{
						return DateTimeFormat.TryFormatS<TChar>(dateTime, destination, out charsWritten);
					}
					if (dateTimeFormatInfo == DateTimeFormatInfo.InvariantInfo)
					{
						return DateTimeFormat.TryFormatInvariantG<TChar>(dateTime, offset, destination, out charsWritten);
					}
					format = dateTimeFormatInfo.GeneralLongTimePattern;
				}
				else if (DateTimeFormat.IsTimeOnlySpecialCase(dateTime, dateTimeFormatInfo))
				{
					format = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz";
					dateTimeFormatInfo = DateTimeFormatInfo.InvariantInfo;
				}
				else
				{
					if (dateTimeFormatInfo == DateTimeFormatInfo.InvariantInfo)
					{
						return DateTimeFormat.TryFormatInvariantG<TChar>(dateTime, offset, destination, out charsWritten);
					}
					format = dateTimeFormatInfo.DateTimeOffsetPattern;
				}
			}
			else if (format.Length == 1)
			{
				char c = (char)(*format[0]);
				if (c <= 'R')
				{
					if (c != 'O')
					{
						if (c != 'R')
						{
							goto IL_142;
						}
						goto IL_101;
					}
				}
				else
				{
					if (c == 'U')
					{
						dateTimeFormatInfo = DateTimeFormatInfo.GetInstance(provider);
						DateTimeFormat.PrepareFormatU(ref dateTime, ref dateTimeFormatInfo, offset);
						format = dateTimeFormatInfo.FullDateTimePattern;
						goto IL_16A;
					}
					switch (c)
					{
					case 'o':
						break;
					case 'p':
					case 'q':
					case 't':
						goto IL_142;
					case 'r':
						goto IL_101;
					case 's':
						return DateTimeFormat.TryFormatS<TChar>(dateTime, destination, out charsWritten);
					case 'u':
						return DateTimeFormat.TryFormatu<TChar>(dateTime, offset, destination, out charsWritten);
					default:
						goto IL_142;
					}
				}
				return DateTimeFormat.TryFormatO<TChar>(dateTime, offset, destination, out charsWritten);
				IL_101:
				return DateTimeFormat.TryFormatR<TChar>(dateTime, offset, destination, out charsWritten);
				IL_142:
				dateTimeFormatInfo = DateTimeFormatInfo.GetInstance(provider);
				format = DateTimeFormat.ExpandStandardFormatToCustomPattern((char)(*format[0]), dateTimeFormatInfo);
			}
			else
			{
				dateTimeFormatInfo = DateTimeFormatInfo.GetInstance(provider);
			}
			IL_16A:
			ValueListBuilder<TChar> valueListBuilder = new ValueListBuilder<TChar>(destination);
			DateTimeFormat.FormatCustomized<TChar>(dateTime, format, dateTimeFormatInfo, offset, ref valueListBuilder);
			bool flag = Unsafe.AreSame<TChar>(MemoryMarshal.GetReference<TChar>(destination), MemoryMarshal.GetReference<TChar>(valueListBuilder.AsSpan()));
			if (flag)
			{
				charsWritten = valueListBuilder.Length;
			}
			else
			{
				flag = valueListBuilder.TryCopyTo(destination, out charsWritten);
			}
			valueListBuilder.Dispose();
			return flag;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x000320FC File Offset: 0x000302FC
		private static bool IsTimeOnlySpecialCase(DateTime dateTime, DateTimeFormatInfo dtfi)
		{
			bool flag = dateTime.Ticks < 864000000000L;
			if (flag)
			{
				CalendarId id = dtfi.Calendar.ID;
				switch (id)
				{
				case CalendarId.JAPAN:
				case CalendarId.TAIWAN:
				case CalendarId.HIJRI:
				case CalendarId.HEBREW:
					break;
				case CalendarId.KOREA:
				case CalendarId.THAI:
					goto IL_52;
				default:
					if (id != CalendarId.JULIAN && id - CalendarId.PERSIAN > 1)
					{
						goto IL_52;
					}
					break;
				}
				bool flag2 = true;
				goto IL_54;
				IL_52:
				flag2 = false;
				IL_54:
				flag = flag2;
			}
			return flag;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00032160 File Offset: 0x00030360
		private static void PrepareFormatU(ref DateTime dateTime, ref DateTimeFormatInfo dtfi, TimeSpan offset)
		{
			if (offset.Ticks != -9223372036854775808L)
			{
				throw new FormatException(SR.Format_InvalidString);
			}
			if (dtfi.Calendar.GetType() != typeof(GregorianCalendar))
			{
				dtfi = (DateTimeFormatInfo)dtfi.Clone();
				dtfi.Calendar = GregorianCalendar.GetDefaultInstance();
			}
			dateTime = dateTime.ToUniversalTime();
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x000321D0 File Offset: 0x000303D0
		internal unsafe static bool IsValidCustomDateOnlyFormat(ReadOnlySpan<char> format, bool throwOnError)
		{
			int i = 0;
			while (i < format.Length)
			{
				char c = (char)(*format[i]);
				if (c <= 'K')
				{
					if (c <= ':')
					{
						if (c != '"' && c != '\'')
						{
							if (c == ':')
							{
								goto IL_117;
							}
						}
						else
						{
							char c2 = (char)(*format[i++]);
							while (i < format.Length && *format[i] != (ushort)c2)
							{
								i++;
							}
							if (i < format.Length)
							{
								i++;
								continue;
							}
							if (throwOnError)
							{
								throw new FormatException(SR.Format(SR.Format_BadQuote, c2));
							}
							return false;
						}
					}
					else if (c == 'F' || c == 'H' || c == 'K')
					{
						goto IL_117;
					}
				}
				else if (c <= 'h')
				{
					if (c != '\\')
					{
						if (c == 'f' || c == 'h')
						{
							goto IL_117;
						}
					}
					else
					{
						if (i != format.Length - 1)
						{
							i += 2;
							continue;
						}
						if (throwOnError)
						{
							throw new FormatException(SR.Format_InvalidString);
						}
						return false;
					}
				}
				else if (c <= 's')
				{
					if (c == 'm' || c == 's')
					{
						goto IL_117;
					}
				}
				else if (c == 't' || c == 'z')
				{
					goto IL_117;
				}
				i++;
				continue;
				IL_117:
				if (throwOnError)
				{
					throw new FormatException(SR.Format_InvalidString);
				}
				return false;
			}
			return true;
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00032318 File Offset: 0x00030518
		internal unsafe static bool IsValidCustomTimeOnlyFormat(ReadOnlySpan<char> format, bool throwOnError)
		{
			int length = format.Length;
			int i = 0;
			while (i < length)
			{
				char c = (char)(*format[i]);
				if (c <= 'M')
				{
					if (c <= '\'')
					{
						if (c == '"' || c == '\'')
						{
							char c2 = (char)(*format[i++]);
							while (i < length && *format[i] != (ushort)c2)
							{
								i++;
							}
							if (i < length)
							{
								i++;
								continue;
							}
							if (throwOnError)
							{
								throw new FormatException(SR.Format(SR.Format_BadQuote, c2));
							}
							return false;
						}
					}
					else if (c == '/' || c == 'M')
					{
						goto IL_D1;
					}
				}
				else if (c <= 'd')
				{
					if (c != '\\')
					{
						if (c == 'd')
						{
							goto IL_D1;
						}
					}
					else
					{
						if (i != length - 1)
						{
							i += 2;
							continue;
						}
						if (throwOnError)
						{
							throw new FormatException(SR.Format_InvalidString);
						}
						return false;
					}
				}
				else if (c == 'k' || c == 'y' || c == 'z')
				{
					goto IL_D1;
				}
				i++;
				continue;
				IL_D1:
				if (throwOnError)
				{
					throw new FormatException(SR.Format_InvalidString);
				}
				return false;
			}
			return true;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00032414 File Offset: 0x00030614
		internal unsafe static bool TryFormatTimeOnlyO<[IsUnmanaged] TChar>(int hour, int minute, int second, long fraction, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (destination.Length < 16)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = 16;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				Number.WriteTwoDigits<TChar>((uint)hour, ptr);
				ptr[(IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)minute, ptr + (IntPtr)3 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)5 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)second, ptr + (IntPtr)6 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)8 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('.');
				Number.WriteDigits<TChar>((uint)fraction, ptr + (IntPtr)9 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), 7);
			}
			return true;
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x000324DC File Offset: 0x000306DC
		internal unsafe static bool TryFormatTimeOnlyR<[IsUnmanaged] TChar>(int hour, int minute, int second, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (destination.Length < 8)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = 8;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				Number.WriteTwoDigits<TChar>((uint)hour, ptr);
				ptr[(IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)minute, ptr + (IntPtr)3 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)5 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)second, ptr + (IntPtr)6 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
			}
			return true;
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00032570 File Offset: 0x00030770
		internal unsafe static bool TryFormatDateOnlyO<[IsUnmanaged] TChar>(int year, int month, int day, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (destination.Length < 10)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = 10;
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				Number.WriteFourDigits<TChar>((uint)year, ptr);
				ptr[(IntPtr)4 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('-');
				Number.WriteTwoDigits<TChar>((uint)month, ptr + (IntPtr)5 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)7 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('-');
				Number.WriteTwoDigits<TChar>((uint)day, ptr + (IntPtr)8 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
			}
			return true;
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00032604 File Offset: 0x00030804
		internal unsafe static bool TryFormatDateOnlyR<[IsUnmanaged] TChar>(DayOfWeek dayOfWeek, int year, int month, int day, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (destination.Length < 16)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = 16;
			string text = DateTimeFormat.s_invariantAbbreviatedDayNames[(int)dayOfWeek];
			string text2 = DateTimeFormat.s_invariantAbbreviatedMonthNames[month - 1];
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				char value = text[2];
				*ptr = IUtfChar<TChar>.CastFrom(text[0]);
				ptr[sizeof(TChar) / sizeof(TChar)] = IUtfChar<TChar>.CastFrom(text[1]);
				ptr[(IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(value);
				ptr[(IntPtr)3 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(',');
				ptr[(IntPtr)4 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(' ');
				Number.WriteTwoDigits<TChar>((uint)day, ptr + (IntPtr)5 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)7 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(' ');
				value = text2[2];
				ptr[(IntPtr)8 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(text2[0]);
				ptr[(IntPtr)9 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(text2[1]);
				ptr[(IntPtr)10 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(value);
				ptr[(IntPtr)11 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(' ');
				Number.WriteFourDigits<TChar>((uint)year, ptr + (IntPtr)12 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
			}
			return true;
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x000327AC File Offset: 0x000309AC
		internal unsafe static bool TryFormatO<[IsUnmanaged] TChar>(DateTime dateTime, TimeSpan offset, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num = 27;
			DateTimeKind dateTimeKind = DateTimeKind.Local;
			if (offset.Ticks == -9223372036854775808L)
			{
				dateTimeKind = dateTime.Kind;
				if (dateTimeKind == DateTimeKind.Local)
				{
					offset = TimeZoneInfo.Local.GetUtcOffset(dateTime);
					num += 6;
				}
				else if (dateTimeKind == DateTimeKind.Utc)
				{
					num++;
				}
			}
			else
			{
				num += 6;
			}
			if (destination.Length < num)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = num;
			int value;
			int value2;
			int value3;
			dateTime.GetDate(out value, out value2, out value3);
			int value4;
			int value5;
			int value6;
			int value7;
			dateTime.GetTimePrecise(out value4, out value5, out value6, out value7);
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				Number.WriteFourDigits<TChar>((uint)value, ptr);
				ptr[(IntPtr)4 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('-');
				Number.WriteTwoDigits<TChar>((uint)value2, ptr + (IntPtr)5 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)7 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('-');
				Number.WriteTwoDigits<TChar>((uint)value3, ptr + (IntPtr)8 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)10 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('T');
				Number.WriteTwoDigits<TChar>((uint)value4, ptr + (IntPtr)11 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)13 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)value5, ptr + (IntPtr)14 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)16 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)value6, ptr + (IntPtr)17 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)19 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('.');
				Number.WriteDigits<TChar>((uint)value7, ptr + (IntPtr)20 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar), 7);
				if (dateTimeKind == DateTimeKind.Local)
				{
					int num2 = (int)(offset.Ticks / 600000000L);
					char value8 = '+';
					if (num2 < 0)
					{
						value8 = '-';
						num2 = -num2;
					}
					ValueTuple<int, int> valueTuple = Math.DivRem(num2, 60);
					int item = valueTuple.Item1;
					uint item2 = (uint)valueTuple.Item2;
					ptr[(IntPtr)27 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(value8);
					Number.WriteTwoDigits<TChar>((uint)item, ptr + (IntPtr)28 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
					ptr[(IntPtr)30 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
					Number.WriteTwoDigits<TChar>(item2, ptr + (IntPtr)31 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				}
				else if (dateTimeKind == DateTimeKind.Utc)
				{
					ptr[(IntPtr)27 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('Z');
				}
			}
			return true;
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00032A3C File Offset: 0x00030C3C
		internal unsafe static bool TryFormatS<[IsUnmanaged] TChar>(DateTime dateTime, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (destination.Length < 19)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = 19;
			int value;
			int value2;
			int value3;
			dateTime.GetDate(out value, out value2, out value3);
			int value4;
			int value5;
			int value6;
			dateTime.GetTime(out value4, out value5, out value6);
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				Number.WriteFourDigits<TChar>((uint)value, ptr);
				ptr[(IntPtr)4 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('-');
				Number.WriteTwoDigits<TChar>((uint)value2, ptr + (IntPtr)5 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)7 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('-');
				Number.WriteTwoDigits<TChar>((uint)value3, ptr + (IntPtr)8 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)10 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('T');
				Number.WriteTwoDigits<TChar>((uint)value4, ptr + (IntPtr)11 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)13 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)value5, ptr + (IntPtr)14 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)16 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)value6, ptr + (IntPtr)17 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
			}
			return true;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00032B8C File Offset: 0x00030D8C
		internal unsafe static bool TryFormatu<[IsUnmanaged] TChar>(DateTime dateTime, TimeSpan offset, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (destination.Length < 20)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = 20;
			if (offset.Ticks != -9223372036854775808L)
			{
				dateTime -= offset;
			}
			int value;
			int value2;
			int value3;
			dateTime.GetDate(out value, out value2, out value3);
			int value4;
			int value5;
			int value6;
			dateTime.GetTime(out value4, out value5, out value6);
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				Number.WriteFourDigits<TChar>((uint)value, ptr);
				ptr[(IntPtr)4 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('-');
				Number.WriteTwoDigits<TChar>((uint)value2, ptr + (IntPtr)5 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)7 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('-');
				Number.WriteTwoDigits<TChar>((uint)value3, ptr + (IntPtr)8 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)10 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(' ');
				Number.WriteTwoDigits<TChar>((uint)value4, ptr + (IntPtr)11 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)13 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)value5, ptr + (IntPtr)14 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)16 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)value6, ptr + (IntPtr)17 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)19 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('Z');
			}
			return true;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00032D14 File Offset: 0x00030F14
		internal unsafe static bool TryFormatR<[IsUnmanaged] TChar>(DateTime dateTime, TimeSpan offset, Span<TChar> destination, out int charsWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (destination.Length < 29)
			{
				charsWritten = 0;
				return false;
			}
			charsWritten = 29;
			if (offset.Ticks != -9223372036854775808L)
			{
				dateTime -= offset;
			}
			int value;
			int num;
			int value2;
			dateTime.GetDate(out value, out num, out value2);
			int value3;
			int value4;
			int value5;
			dateTime.GetTime(out value3, out value4, out value5);
			string text = DateTimeFormat.s_invariantAbbreviatedDayNames[(int)dateTime.DayOfWeek];
			string text2 = DateTimeFormat.s_invariantAbbreviatedMonthNames[num - 1];
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				char value6 = text[2];
				*ptr = IUtfChar<TChar>.CastFrom(text[0]);
				ptr[sizeof(TChar) / sizeof(TChar)] = IUtfChar<TChar>.CastFrom(text[1]);
				ptr[(IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(value6);
				ptr[(IntPtr)3 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(',');
				ptr[(IntPtr)4 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(' ');
				Number.WriteTwoDigits<TChar>((uint)value2, ptr + (IntPtr)5 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)7 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(' ');
				value6 = text2[2];
				ptr[(IntPtr)8 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(text2[0]);
				ptr[(IntPtr)9 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(text2[1]);
				ptr[(IntPtr)10 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(value6);
				ptr[(IntPtr)11 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(' ');
				Number.WriteFourDigits<TChar>((uint)value, ptr + (IntPtr)12 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)16 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(' ');
				Number.WriteTwoDigits<TChar>((uint)value3, ptr + (IntPtr)17 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)19 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)value4, ptr + (IntPtr)20 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)22 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)value5, ptr + (IntPtr)23 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)25 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(' ');
				ptr[(IntPtr)26 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('G');
				ptr[(IntPtr)27 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('M');
				ptr[(IntPtr)28 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('T');
			}
			return true;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00033020 File Offset: 0x00031220
		internal unsafe static bool TryFormatInvariantG<[IsUnmanaged] TChar>(DateTime value, TimeSpan offset, Span<TChar> destination, out int bytesWritten) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			int num = 19;
			if (offset.Ticks != -9223372036854775808L)
			{
				num += 7;
			}
			if (destination.Length < num)
			{
				bytesWritten = 0;
				return false;
			}
			bytesWritten = num;
			int value2;
			int value3;
			int value4;
			value.GetDate(out value2, out value3, out value4);
			int value5;
			int value6;
			int value7;
			value.GetTime(out value5, out value6, out value7);
			fixed (TChar* reference = MemoryMarshal.GetReference<TChar>(destination))
			{
				TChar* ptr = reference;
				Number.WriteTwoDigits<TChar>((uint)value3, ptr);
				ptr[(IntPtr)2 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('/');
				Number.WriteTwoDigits<TChar>((uint)value4, ptr + (IntPtr)3 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)5 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom('/');
				Number.WriteFourDigits<TChar>((uint)value2, ptr + (IntPtr)6 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)10 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(' ');
				Number.WriteTwoDigits<TChar>((uint)value5, ptr + (IntPtr)11 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)13 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)value6, ptr + (IntPtr)14 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				ptr[(IntPtr)16 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
				Number.WriteTwoDigits<TChar>((uint)value7, ptr + (IntPtr)17 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				if (offset.Ticks != -9223372036854775808L)
				{
					int num2 = (int)(offset.Ticks / 600000000L);
					TChar tchar = IUtfChar<TChar>.CastFrom('+');
					if (num2 < 0)
					{
						tchar = IUtfChar<TChar>.CastFrom('-');
						num2 = -num2;
					}
					ValueTuple<int, int> valueTuple = Math.DivRem(num2, 60);
					int item = valueTuple.Item1;
					num2 = valueTuple.Item2;
					ptr[(IntPtr)19 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(' ');
					ptr[(IntPtr)20 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = tchar;
					Number.WriteTwoDigits<TChar>((uint)item, ptr + (IntPtr)21 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
					ptr[(IntPtr)23 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar)] = IUtfChar<TChar>.CastFrom(':');
					Number.WriteTwoDigits<TChar>((uint)num2, ptr + (IntPtr)24 * (IntPtr)sizeof(TChar) / (IntPtr)sizeof(TChar));
				}
			}
			return true;
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00033268 File Offset: 0x00031468
		internal static string[] GetAllDateTimes(DateTime dateTime, char format, DateTimeFormatInfo dtfi)
		{
			string[] allDateTimePatterns;
			string[] array;
			if (format <= 'U')
			{
				switch (format)
				{
				case 'D':
				case 'F':
				case 'G':
					break;
				case 'E':
					goto IL_133;
				default:
					switch (format)
					{
					case 'M':
					case 'T':
						break;
					case 'N':
					case 'P':
					case 'Q':
					case 'S':
						goto IL_133;
					case 'O':
					case 'R':
						goto IL_11A;
					case 'U':
					{
						DateTime dateTime2 = dateTime.ToUniversalTime();
						allDateTimePatterns = dtfi.GetAllDateTimePatterns(format);
						array = new string[allDateTimePatterns.Length];
						for (int i = 0; i < allDateTimePatterns.Length; i++)
						{
							array[i] = DateTimeFormat.Format(dateTime2, allDateTimePatterns[i], dtfi);
						}
						return array;
					}
					default:
						goto IL_133;
					}
					break;
				}
			}
			else if (format != 'Y')
			{
				switch (format)
				{
				case 'd':
				case 'f':
				case 'g':
					break;
				case 'e':
					goto IL_133;
				default:
					switch (format)
					{
					case 'm':
					case 't':
					case 'y':
						break;
					case 'n':
					case 'p':
					case 'q':
					case 'v':
					case 'w':
					case 'x':
						goto IL_133;
					case 'o':
					case 'r':
					case 's':
					case 'u':
						goto IL_11A;
					default:
						goto IL_133;
					}
					break;
				}
			}
			allDateTimePatterns = dtfi.GetAllDateTimePatterns(format);
			array = new string[allDateTimePatterns.Length];
			for (int j = 0; j < allDateTimePatterns.Length; j++)
			{
				array[j] = DateTimeFormat.Format(dateTime, allDateTimePatterns[j], dtfi);
			}
			return array;
			IL_11A:
			return new string[]
			{
				DateTimeFormat.Format(dateTime, char.ToString(format), dtfi)
			};
			IL_133:
			throw new FormatException(SR.Format_InvalidString);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x000333B4 File Offset: 0x000315B4
		internal static string[] GetAllDateTimes(DateTime dateTime, DateTimeFormatInfo dtfi)
		{
			List<string> list = new List<string>(132);
			foreach (char format in "dDfFgGmMoOrRstTuUyY")
			{
				foreach (string item in DateTimeFormat.GetAllDateTimes(dateTime, format, dtfi))
				{
					list.Add(item);
				}
			}
			return list.ToArray();
		}

		// Token: 0x040003C7 RID: 967
		internal static readonly DateTimeFormatInfo InvariantFormatInfo = CultureInfo.InvariantCulture.DateTimeFormat;

		// Token: 0x040003C8 RID: 968
		private static readonly string[] s_invariantAbbreviatedMonthNames = DateTimeFormat.InvariantFormatInfo.AbbreviatedMonthNames;

		// Token: 0x040003C9 RID: 969
		private static readonly string[] s_invariantAbbreviatedDayNames = DateTimeFormat.InvariantFormatInfo.AbbreviatedDayNames;

		// Token: 0x040003CA RID: 970
		internal static readonly string[] fixedNumberFormats = new string[]
		{
			"0",
			"00",
			"000",
			"0000",
			"00000",
			"000000",
			"0000000"
		};
	}
}
