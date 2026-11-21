using System;
using System.Buffers.Binary;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Buffers.Text
{
	// Token: 0x020003B0 RID: 944
	public static class Utf8Parser
	{
		// Token: 0x06003D9A RID: 15770 RVA: 0x000CDA00 File Offset: 0x000CBC00
		public unsafe static bool TryParse(ReadOnlySpan<byte> source, out bool value, out int bytesConsumed, char standardFormat = '\0')
		{
			if (standardFormat != '\0' && standardFormat != 'G' && standardFormat != 'l')
			{
				ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			}
			if (source.Length >= 4)
			{
				int num = BinaryPrimitives.ReadInt32LittleEndian(source) & -538976289;
				if (num == 1163219540)
				{
					bytesConsumed = 4;
					value = true;
					return true;
				}
				if (source.Length > 4 && num == 1397506374 && ((int)(*source[4]) & -33) == 69)
				{
					bytesConsumed = 5;
					value = false;
					return true;
				}
			}
			bytesConsumed = 0;
			value = false;
			return false;
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x000CDA78 File Offset: 0x000CBC78
		public static bool TryParse(ReadOnlySpan<byte> source, out DateTime value, out int bytesConsumed, char standardFormat = '\0')
		{
			if (standardFormat <= 'G')
			{
				if (standardFormat == '\0' || standardFormat == 'G')
				{
					DateTimeOffset dateTimeOffset;
					return Utf8Parser.TryParseDateTimeG(source, out value, out dateTimeOffset, out bytesConsumed);
				}
			}
			else if (standardFormat != 'O')
			{
				if (standardFormat != 'R')
				{
					if (standardFormat == 'l')
					{
						DateTimeOffset dateTimeOffset2;
						if (!Utf8Parser.TryParseDateTimeOffsetR(source, 32U, out dateTimeOffset2, out bytesConsumed))
						{
							value = default(DateTime);
							return false;
						}
						value = dateTimeOffset2.DateTime;
						return true;
					}
				}
				else
				{
					DateTimeOffset dateTimeOffset3;
					if (!Utf8Parser.TryParseDateTimeOffsetR(source, 0U, out dateTimeOffset3, out bytesConsumed))
					{
						value = default(DateTime);
						return false;
					}
					value = dateTimeOffset3.DateTime;
					return true;
				}
			}
			else
			{
				DateTimeOffset dateTimeOffset4;
				DateTimeKind dateTimeKind;
				if (!Utf8Parser.TryParseDateTimeOffsetO(source, out dateTimeOffset4, out bytesConsumed, out dateTimeKind))
				{
					value = default(DateTime);
					bytesConsumed = 0;
					return false;
				}
				if (dateTimeKind != DateTimeKind.Utc)
				{
					if (dateTimeKind == DateTimeKind.Local)
					{
						value = dateTimeOffset4.LocalDateTime;
					}
					else
					{
						value = dateTimeOffset4.DateTime;
					}
				}
				else
				{
					value = dateTimeOffset4.UtcDateTime;
				}
				return true;
			}
			return ParserHelpers.TryParseThrowFormatException<DateTime>(out value, out bytesConsumed);
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x000CDB5C File Offset: 0x000CBD5C
		public static bool TryParse(ReadOnlySpan<byte> source, out DateTimeOffset value, out int bytesConsumed, char standardFormat = '\0')
		{
			if (standardFormat <= 'G')
			{
				if (standardFormat == '\0')
				{
					return Utf8Parser.TryParseDateTimeOffsetDefault(source, out value, out bytesConsumed);
				}
				if (standardFormat == 'G')
				{
					DateTime dateTime;
					return Utf8Parser.TryParseDateTimeG(source, out dateTime, out value, out bytesConsumed);
				}
			}
			else
			{
				if (standardFormat == 'O')
				{
					DateTimeKind dateTimeKind;
					return Utf8Parser.TryParseDateTimeOffsetO(source, out value, out bytesConsumed, out dateTimeKind);
				}
				if (standardFormat == 'R')
				{
					return Utf8Parser.TryParseDateTimeOffsetR(source, 0U, out value, out bytesConsumed);
				}
				if (standardFormat == 'l')
				{
					return Utf8Parser.TryParseDateTimeOffsetR(source, 32U, out value, out bytesConsumed);
				}
			}
			return ParserHelpers.TryParseThrowFormatException<DateTimeOffset>(out value, out bytesConsumed);
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x000CDBD0 File Offset: 0x000CBDD0
		private unsafe static bool TryParseDateTimeOffsetDefault(ReadOnlySpan<byte> source, out DateTimeOffset value, out int bytesConsumed)
		{
			if (source.Length < 26)
			{
				bytesConsumed = 0;
				value = default(DateTimeOffset);
				return false;
			}
			DateTime dateTime;
			DateTimeOffset dateTimeOffset;
			int num;
			if (!Utf8Parser.TryParseDateTimeG(source, out dateTime, out dateTimeOffset, out num))
			{
				bytesConsumed = 0;
				value = default(DateTimeOffset);
				return false;
			}
			if (*source[19] != 32)
			{
				bytesConsumed = 0;
				value = default(DateTimeOffset);
				return false;
			}
			byte b = *source[20];
			if (b != 43 && b != 45)
			{
				bytesConsumed = 0;
				value = default(DateTimeOffset);
				return false;
			}
			uint num2 = (uint)(*source[21] - 48);
			uint num3 = (uint)(*source[22] - 48);
			if (num2 > 9U || num3 > 9U)
			{
				bytesConsumed = 0;
				value = default(DateTimeOffset);
				return false;
			}
			int offsetHours = (int)(num2 * 10U + num3);
			if (*source[23] != 58)
			{
				bytesConsumed = 0;
				value = default(DateTimeOffset);
				return false;
			}
			uint num4 = (uint)(*source[24] - 48);
			uint num5 = (uint)(*source[25] - 48);
			if (num4 > 9U || num5 > 9U)
			{
				bytesConsumed = 0;
				value = default(DateTimeOffset);
				return false;
			}
			int offsetMinutes = (int)(num4 * 10U + num5);
			if (!Utf8Parser.TryCreateDateTimeOffset(dateTime, b == 45, offsetHours, offsetMinutes, out value))
			{
				bytesConsumed = 0;
				value = default(DateTimeOffset);
				return false;
			}
			bytesConsumed = 26;
			return true;
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x000CDD04 File Offset: 0x000CBF04
		private unsafe static bool TryParseDateTimeG(ReadOnlySpan<byte> source, out DateTime value, out DateTimeOffset valueAsOffset, out int bytesConsumed)
		{
			if (source.Length < 19)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			uint num = (uint)(*source[0] - 48);
			uint num2 = (uint)(*source[1] - 48);
			if (num > 9U || num2 > 9U)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			int month = (int)(num * 10U + num2);
			if (*source[2] != 47)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			uint num3 = (uint)(*source[3] - 48);
			uint num4 = (uint)(*source[4] - 48);
			if (num3 > 9U || num4 > 9U)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			int day = (int)(num3 * 10U + num4);
			if (*source[5] != 47)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			uint num5 = (uint)(*source[6] - 48);
			uint num6 = (uint)(*source[7] - 48);
			uint num7 = (uint)(*source[8] - 48);
			uint num8 = (uint)(*source[9] - 48);
			if (num5 > 9U || num6 > 9U || num7 > 9U || num8 > 9U)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			int year = (int)(num5 * 1000U + num6 * 100U + num7 * 10U + num8);
			if (*source[10] != 32)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			uint num9 = (uint)(*source[11] - 48);
			uint num10 = (uint)(*source[12] - 48);
			if (num9 > 9U || num10 > 9U)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			int hour = (int)(num9 * 10U + num10);
			if (*source[13] != 58)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			uint num11 = (uint)(*source[14] - 48);
			uint num12 = (uint)(*source[15] - 48);
			if (num11 > 9U || num12 > 9U)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			int minute = (int)(num11 * 10U + num12);
			if (*source[16] != 58)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			uint num13 = (uint)(*source[17] - 48);
			uint num14 = (uint)(*source[18] - 48);
			if (num13 > 9U || num14 > 9U)
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			int second = (int)(num13 * 10U + num14);
			if (!Utf8Parser.TryCreateDateTimeOffsetInterpretingDataAsLocalTime(year, month, day, hour, minute, second, 0, out valueAsOffset))
			{
				bytesConsumed = 0;
				value = default(DateTime);
				valueAsOffset = default(DateTimeOffset);
				return false;
			}
			bytesConsumed = 19;
			value = valueAsOffset.DateTime;
			return true;
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x000CDFE0 File Offset: 0x000CC1E0
		private static bool TryCreateDateTimeOffset(DateTime dateTime, bool offsetNegative, int offsetHours, int offsetMinutes, out DateTimeOffset value)
		{
			if (offsetHours > 14)
			{
				value = default(DateTimeOffset);
				return false;
			}
			if (offsetMinutes > 59)
			{
				value = default(DateTimeOffset);
				return false;
			}
			if (offsetHours == 14 && offsetMinutes != 0)
			{
				value = default(DateTimeOffset);
				return false;
			}
			long num = ((long)offsetHours * 3600L + (long)offsetMinutes * 60L) * 10000000L;
			if (offsetNegative)
			{
				num = -num;
			}
			try
			{
				value = new DateTimeOffset(dateTime.Ticks, new TimeSpan(num));
			}
			catch (ArgumentOutOfRangeException)
			{
				value = default(DateTimeOffset);
				return false;
			}
			return true;
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x000CE078 File Offset: 0x000CC278
		private static bool TryCreateDateTimeOffset(int year, int month, int day, int hour, int minute, int second, int fraction, bool offsetNegative, int offsetHours, int offsetMinutes, out DateTimeOffset value)
		{
			DateTime dateTime;
			if (!Utf8Parser.TryCreateDateTime(year, month, day, hour, minute, second, fraction, DateTimeKind.Unspecified, out dateTime))
			{
				value = default(DateTimeOffset);
				return false;
			}
			if (!Utf8Parser.TryCreateDateTimeOffset(dateTime, offsetNegative, offsetHours, offsetMinutes, out value))
			{
				value = default(DateTimeOffset);
				return false;
			}
			return true;
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x000CE0C0 File Offset: 0x000CC2C0
		private static bool TryCreateDateTimeOffsetInterpretingDataAsLocalTime(int year, int month, int day, int hour, int minute, int second, int fraction, out DateTimeOffset value)
		{
			DateTime dateTime;
			if (!Utf8Parser.TryCreateDateTime(year, month, day, hour, minute, second, fraction, DateTimeKind.Local, out dateTime))
			{
				value = default(DateTimeOffset);
				return false;
			}
			try
			{
				value = new DateTimeOffset(dateTime);
			}
			catch (ArgumentOutOfRangeException)
			{
				value = default(DateTimeOffset);
				return false;
			}
			return true;
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x000CE11C File Offset: 0x000CC31C
		private unsafe static bool TryCreateDateTime(int year, int month, int day, int hour, int minute, int second, int fraction, DateTimeKind kind, out DateTime value)
		{
			if (year == 0)
			{
				value = default(DateTime);
				return false;
			}
			if (month - 1 >= 12)
			{
				value = default(DateTime);
				return false;
			}
			uint num = (uint)(day - 1);
			if (num >= 28U && (ulong)num >= (ulong)((long)DateTime.DaysInMonth(year, month)))
			{
				value = default(DateTime);
				return false;
			}
			if (hour > 23)
			{
				value = default(DateTime);
				return false;
			}
			if (minute > 59)
			{
				value = default(DateTime);
				return false;
			}
			if (second > 59)
			{
				value = default(DateTime);
				return false;
			}
			ReadOnlySpan<int> readOnlySpan = DateTime.IsLeapYear(year) ? GregorianCalendar.DaysToMonth366 : GregorianCalendar.DaysToMonth365;
			int num2 = year - 1;
			long num3 = (long)(num2 * 365 + num2 / 4 - num2 / 100 + num2 / 400 + *readOnlySpan[month - 1] + day - 1) * 864000000000L;
			int num4 = hour * 3600 + minute * 60 + second;
			num3 += (long)num4 * 10000000L;
			num3 += (long)fraction;
			value = new DateTime(num3, kind);
			return true;
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x000CE218 File Offset: 0x000CC418
		private unsafe static bool TryParseDateTimeOffsetO(ReadOnlySpan<byte> source, out DateTimeOffset value, out int bytesConsumed, out DateTimeKind kind)
		{
			if (source.Length < 27)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			uint num = (uint)(*source[0] - 48);
			uint num2 = (uint)(*source[1] - 48);
			uint num3 = (uint)(*source[2] - 48);
			uint num4 = (uint)(*source[3] - 48);
			if (num > 9U || num2 > 9U || num3 > 9U || num4 > 9U)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			int year = (int)(num * 1000U + num2 * 100U + num3 * 10U + num4);
			if (*source[4] != 45)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			uint num5 = (uint)(*source[5] - 48);
			uint num6 = (uint)(*source[6] - 48);
			if (num5 > 9U || num6 > 9U)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			int month = (int)(num5 * 10U + num6);
			if (*source[7] != 45)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			uint num7 = (uint)(*source[8] - 48);
			uint num8 = (uint)(*source[9] - 48);
			if (num7 > 9U || num8 > 9U)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			int day = (int)(num7 * 10U + num8);
			if (*source[10] != 84)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			uint num9 = (uint)(*source[11] - 48);
			uint num10 = (uint)(*source[12] - 48);
			if (num9 > 9U || num10 > 9U)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			int hour = (int)(num9 * 10U + num10);
			if (*source[13] != 58)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			uint num11 = (uint)(*source[14] - 48);
			uint num12 = (uint)(*source[15] - 48);
			if (num11 > 9U || num12 > 9U)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			int minute = (int)(num11 * 10U + num12);
			if (*source[16] != 58)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			uint num13 = (uint)(*source[17] - 48);
			uint num14 = (uint)(*source[18] - 48);
			if (num13 > 9U || num14 > 9U)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			int second = (int)(num13 * 10U + num14);
			if (*source[19] != 46)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			uint num15 = (uint)(*source[20] - 48);
			uint num16 = (uint)(*source[21] - 48);
			uint num17 = (uint)(*source[22] - 48);
			uint num18 = (uint)(*source[23] - 48);
			uint num19 = (uint)(*source[24] - 48);
			uint num20 = (uint)(*source[25] - 48);
			uint num21 = (uint)(*source[26] - 48);
			if (num15 > 9U || num16 > 9U || num17 > 9U || num18 > 9U || num19 > 9U || num20 > 9U || num21 > 9U)
			{
				value = default(DateTimeOffset);
				bytesConsumed = 0;
				kind = DateTimeKind.Unspecified;
				return false;
			}
			int fraction = (int)(num15 * 1000000U + num16 * 100000U + num17 * 10000U + num18 * 1000U + num19 * 100U + num20 * 10U + num21);
			byte b = (source.Length <= 27) ? 0 : (*source[27]);
			if (b != 90 && b != 43 && b != 45)
			{
				if (!Utf8Parser.TryCreateDateTimeOffsetInterpretingDataAsLocalTime(year, month, day, hour, minute, second, fraction, out value))
				{
					value = default(DateTimeOffset);
					bytesConsumed = 0;
					kind = DateTimeKind.Unspecified;
					return false;
				}
				bytesConsumed = 27;
				kind = DateTimeKind.Unspecified;
				return true;
			}
			else if (b == 90)
			{
				if (!Utf8Parser.TryCreateDateTimeOffset(year, month, day, hour, minute, second, fraction, false, 0, 0, out value))
				{
					value = default(DateTimeOffset);
					bytesConsumed = 0;
					kind = DateTimeKind.Unspecified;
					return false;
				}
				bytesConsumed = 28;
				kind = DateTimeKind.Utc;
				return true;
			}
			else
			{
				if (source.Length < 33)
				{
					value = default(DateTimeOffset);
					bytesConsumed = 0;
					kind = DateTimeKind.Unspecified;
					return false;
				}
				uint num22 = (uint)(*source[28] - 48);
				uint num23 = (uint)(*source[29] - 48);
				if (num22 > 9U || num23 > 9U)
				{
					value = default(DateTimeOffset);
					bytesConsumed = 0;
					kind = DateTimeKind.Unspecified;
					return false;
				}
				int offsetHours = (int)(num22 * 10U + num23);
				if (*source[30] != 58)
				{
					value = default(DateTimeOffset);
					bytesConsumed = 0;
					kind = DateTimeKind.Unspecified;
					return false;
				}
				uint num24 = (uint)(*source[31] - 48);
				uint num25 = (uint)(*source[32] - 48);
				if (num24 > 9U || num25 > 9U)
				{
					value = default(DateTimeOffset);
					bytesConsumed = 0;
					kind = DateTimeKind.Unspecified;
					return false;
				}
				int offsetMinutes = (int)(num24 * 10U + num25);
				if (!Utf8Parser.TryCreateDateTimeOffset(year, month, day, hour, minute, second, fraction, b == 45, offsetHours, offsetMinutes, out value))
				{
					value = default(DateTimeOffset);
					bytesConsumed = 0;
					kind = DateTimeKind.Unspecified;
					return false;
				}
				bytesConsumed = 33;
				kind = DateTimeKind.Local;
				return true;
			}
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x000CE6FC File Offset: 0x000CC8FC
		private unsafe static bool TryParseDateTimeOffsetR(ReadOnlySpan<byte> source, uint caseFlipXorMask, out DateTimeOffset dateTimeOffset, out int bytesConsumed)
		{
			if (source.Length < 29)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			uint num = (uint)(*source[0]) ^ caseFlipXorMask;
			uint num2 = (uint)(*source[1]);
			uint num3 = (uint)(*source[2]);
			uint num4 = (uint)(*source[3]);
			uint num5 = num << 24 | num2 << 16 | num3 << 8 | num4;
			DayOfWeek dayOfWeek;
			if (num5 <= 1398895660U)
			{
				if (num5 == 1181903148U)
				{
					dayOfWeek = DayOfWeek.Friday;
					goto IL_D5;
				}
				if (num5 == 1299148332U)
				{
					dayOfWeek = DayOfWeek.Monday;
					goto IL_D5;
				}
				if (num5 == 1398895660U)
				{
					dayOfWeek = DayOfWeek.Saturday;
					goto IL_D5;
				}
			}
			else if (num5 <= 1416131884U)
			{
				if (num5 == 1400204844U)
				{
					dayOfWeek = DayOfWeek.Sunday;
					goto IL_D5;
				}
				if (num5 == 1416131884U)
				{
					dayOfWeek = DayOfWeek.Thursday;
					goto IL_D5;
				}
			}
			else
			{
				if (num5 == 1416979756U)
				{
					dayOfWeek = DayOfWeek.Tuesday;
					goto IL_D5;
				}
				if (num5 == 1466262572U)
				{
					dayOfWeek = DayOfWeek.Wednesday;
					goto IL_D5;
				}
			}
			bytesConsumed = 0;
			dateTimeOffset = default(DateTimeOffset);
			return false;
			IL_D5:
			if (*source[4] != 32)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			uint num6 = (uint)(*source[5] - 48);
			uint num7 = (uint)(*source[6] - 48);
			if (num6 > 9U || num7 > 9U)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			int day = (int)(num6 * 10U + num7);
			if (*source[7] != 32)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			uint num8 = (uint)(*source[8]) ^ caseFlipXorMask;
			uint num9 = (uint)(*source[9]);
			uint num10 = (uint)(*source[10]);
			uint num11 = (uint)(*source[11]);
			uint num12 = num8 << 24 | num9 << 16 | num10 << 8 | num11;
			int month;
			if (num12 <= 1249209376U)
			{
				if (num12 <= 1147495200U)
				{
					if (num12 == 1097888288U)
					{
						month = 4;
						goto IL_261;
					}
					if (num12 == 1098213152U)
					{
						month = 8;
						goto IL_261;
					}
					if (num12 == 1147495200U)
					{
						month = 12;
						goto IL_261;
					}
				}
				else
				{
					if (num12 == 1181049376U)
					{
						month = 2;
						goto IL_261;
					}
					if (num12 == 1247899168U)
					{
						month = 1;
						goto IL_261;
					}
					if (num12 == 1249209376U)
					{
						month = 7;
						goto IL_261;
					}
				}
			}
			else if (num12 <= 1298233632U)
			{
				if (num12 == 1249209888U)
				{
					month = 6;
					goto IL_261;
				}
				if (num12 == 1298231840U)
				{
					month = 3;
					goto IL_261;
				}
				if (num12 == 1298233632U)
				{
					month = 5;
					goto IL_261;
				}
			}
			else
			{
				if (num12 == 1315927584U)
				{
					month = 11;
					goto IL_261;
				}
				if (num12 == 1331917856U)
				{
					month = 10;
					goto IL_261;
				}
				if (num12 == 1399156768U)
				{
					month = 9;
					goto IL_261;
				}
			}
			bytesConsumed = 0;
			dateTimeOffset = default(DateTimeOffset);
			return false;
			IL_261:
			uint num13 = (uint)(*source[12] - 48);
			uint num14 = (uint)(*source[13] - 48);
			uint num15 = (uint)(*source[14] - 48);
			uint num16 = (uint)(*source[15] - 48);
			if (num13 > 9U || num14 > 9U || num15 > 9U || num16 > 9U)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			int year = (int)(num13 * 1000U + num14 * 100U + num15 * 10U + num16);
			if (*source[16] != 32)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			uint num17 = (uint)(*source[17] - 48);
			uint num18 = (uint)(*source[18] - 48);
			if (num17 > 9U || num18 > 9U)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			int hour = (int)(num17 * 10U + num18);
			if (*source[19] != 58)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			uint num19 = (uint)(*source[20] - 48);
			uint num20 = (uint)(*source[21] - 48);
			if (num19 > 9U || num20 > 9U)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			int minute = (int)(num19 * 10U + num20);
			if (*source[22] != 58)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			uint num21 = (uint)(*source[23] - 48);
			uint num22 = (uint)(*source[24] - 48);
			if (num21 > 9U || num22 > 9U)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			int second = (int)(num21 * 10U + num22);
			uint num23 = (uint)(*source[25]);
			uint num24 = (uint)(*source[26]) ^ caseFlipXorMask;
			uint num25 = (uint)(*source[27]) ^ caseFlipXorMask;
			uint num26 = (uint)(*source[28]) ^ caseFlipXorMask;
			if ((num23 << 24 | num24 << 16 | num25 << 8 | num26) != 541543764U)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			if (!Utf8Parser.TryCreateDateTimeOffset(year, month, day, hour, minute, second, 0, false, 0, 0, out dateTimeOffset))
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			if (dayOfWeek != dateTimeOffset.DayOfWeek)
			{
				bytesConsumed = 0;
				dateTimeOffset = default(DateTimeOffset);
				return false;
			}
			bytesConsumed = 29;
			return true;
		}

		// Token: 0x06003DA5 RID: 15781 RVA: 0x000CEB84 File Offset: 0x000CCD84
		public unsafe static bool TryParse(ReadOnlySpan<byte> source, out decimal value, out int bytesConsumed, char standardFormat = '\0')
		{
			Utf8Parser.ParseNumberOptions options;
			if (standardFormat != '\0')
			{
				switch (standardFormat)
				{
				case 'E':
				case 'G':
					goto IL_2F;
				case 'F':
					break;
				default:
					switch (standardFormat)
					{
					case 'e':
					case 'g':
						goto IL_2F;
					case 'f':
						break;
					default:
						return ParserHelpers.TryParseThrowFormatException<decimal>(out value, out bytesConsumed);
					}
					break;
				}
				options = (Utf8Parser.ParseNumberOptions)0;
				goto IL_3F;
			}
			IL_2F:
			options = Utf8Parser.ParseNumberOptions.AllowExponent;
			IL_3F:
			Span<byte> digits = new Span<byte>(stackalloc byte[(UIntPtr)31], 31);
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.Decimal, digits);
			bool flag;
			if (!Utf8Parser.TryParseNumber(source, ref numberBuffer, out bytesConsumed, options, out flag))
			{
				value = 0m;
				return false;
			}
			if (!flag && (standardFormat == 'E' || standardFormat == 'e'))
			{
				value = 0m;
				bytesConsumed = 0;
				return false;
			}
			value = 0m;
			if (!Number.TryNumberToDecimal(ref numberBuffer, ref value))
			{
				value = 0m;
				bytesConsumed = 0;
				return false;
			}
			return true;
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x000CEC34 File Offset: 0x000CCE34
		public unsafe static bool TryParse(ReadOnlySpan<byte> source, out float value, out int bytesConsumed, char standardFormat = '\0')
		{
			Span<byte> digits = new Span<byte>(stackalloc byte[(UIntPtr)114], 114);
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.FloatingPoint, digits);
			if (Utf8Parser.TryParseNormalAsFloatingPoint(source, ref numberBuffer, out bytesConsumed, standardFormat))
			{
				value = Number.NumberToFloat<float>(ref numberBuffer);
				return true;
			}
			return Utf8Parser.TryParseAsSpecialFloatingPoint<float>(source, float.PositiveInfinity, float.NegativeInfinity, float.NaN, out value, out bytesConsumed);
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x000CEC88 File Offset: 0x000CCE88
		public unsafe static bool TryParse(ReadOnlySpan<byte> source, out double value, out int bytesConsumed, char standardFormat = '\0')
		{
			Span<byte> digits = new Span<byte>(stackalloc byte[(UIntPtr)769], 769);
			Number.NumberBuffer numberBuffer = new Number.NumberBuffer(Number.NumberBufferKind.FloatingPoint, digits);
			if (Utf8Parser.TryParseNormalAsFloatingPoint(source, ref numberBuffer, out bytesConsumed, standardFormat))
			{
				value = Number.NumberToFloat<double>(ref numberBuffer);
				return true;
			}
			return Utf8Parser.TryParseAsSpecialFloatingPoint<double>(source, double.PositiveInfinity, double.NegativeInfinity, double.NaN, out value, out bytesConsumed);
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x000CECEC File Offset: 0x000CCEEC
		private static bool TryParseNormalAsFloatingPoint(ReadOnlySpan<byte> source, ref Number.NumberBuffer number, out int bytesConsumed, char standardFormat)
		{
			Utf8Parser.ParseNumberOptions options;
			if (standardFormat != '\0')
			{
				switch (standardFormat)
				{
				case 'E':
				case 'G':
					goto IL_2F;
				case 'F':
					break;
				default:
					switch (standardFormat)
					{
					case 'e':
					case 'g':
						goto IL_2F;
					case 'f':
						break;
					default:
						return ParserHelpers.TryParseThrowFormatException(out bytesConsumed);
					}
					break;
				}
				options = (Utf8Parser.ParseNumberOptions)0;
				goto IL_3E;
			}
			IL_2F:
			options = Utf8Parser.ParseNumberOptions.AllowExponent;
			IL_3E:
			bool flag;
			if (!Utf8Parser.TryParseNumber(source, ref number, out bytesConsumed, options, out flag))
			{
				return false;
			}
			if (!flag && (standardFormat == 'E' || standardFormat == 'e'))
			{
				bytesConsumed = 0;
				return false;
			}
			return true;
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x000CED5C File Offset: 0x000CCF5C
		private unsafe static bool TryParseAsSpecialFloatingPoint<T>(ReadOnlySpan<byte> source, T positiveInfinity, T negativeInfinity, T nan, out T value, out int bytesConsumed) where T : struct
		{
			int num = 0;
			int num2 = source.Length;
			bool flag = false;
			if (num2 >= 4)
			{
				byte b = *source[num];
				if (b != 43)
				{
					if (b != 45)
					{
						goto IL_2E;
					}
					flag = true;
				}
				num++;
				num2--;
			}
			IL_2E:
			if (num2 >= 3)
			{
				if (((int)(*source[num] ^ 110) & -33) == 0 && ((int)(*source[num + 1] ^ 97) & -33) == 0 && ((int)(*source[num + 2] ^ 110) & -33) == 0)
				{
					value = nan;
					bytesConsumed = 3 + num;
					return true;
				}
				if (num2 >= 8 && ((BinaryPrimitives.ReadInt32LittleEndian(source.Slice(num)) ^ 1768320617) & -538976289) == 0 && ((BinaryPrimitives.ReadInt32LittleEndian(source.Slice(num + 4)) ^ 2037672302) & -538976289) == 0)
				{
					value = (flag ? negativeInfinity : positiveInfinity);
					bytesConsumed = 8 + num;
					return true;
				}
			}
			value = default(T);
			bytesConsumed = 0;
			return false;
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x000CEE44 File Offset: 0x000CD044
		public static bool TryParse(ReadOnlySpan<byte> source, out Guid value, out int bytesConsumed, char standardFormat = '\0')
		{
			while (standardFormat != '\0')
			{
				if (standardFormat <= 'D')
				{
					if (standardFormat == 'B')
					{
						return Utf8Parser.TryParseGuidCore(source, out value, out bytesConsumed, 32123);
					}
					if (standardFormat == 'D')
					{
						standardFormat = '\0';
						continue;
					}
				}
				else
				{
					if (standardFormat == 'N')
					{
						return Utf8Parser.TryParseGuidN(source, out value, out bytesConsumed);
					}
					if (standardFormat == 'P')
					{
						return Utf8Parser.TryParseGuidCore(source, out value, out bytesConsumed, 10536);
					}
				}
				return ParserHelpers.TryParseThrowFormatException<Guid>(source, out value, out bytesConsumed);
			}
			return Utf8Parser.TryParseGuidCore(source, out value, out bytesConsumed, 0);
		}

		// Token: 0x06003DAB RID: 15787 RVA: 0x000CEEB0 File Offset: 0x000CD0B0
		private static bool TryParseGuidN(ReadOnlySpan<byte> text, out Guid value, out int bytesConsumed)
		{
			if (text.Length < 32)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			uint a;
			int num;
			if (!Utf8Parser.TryParseUInt32X(text.Slice(0, 8), out a, out num) || num != 8)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			ushort num2;
			if (!Utf8Parser.TryParseUInt16X(text.Slice(8, 4), out num2, out num) || num != 4)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			ushort num3;
			if (!Utf8Parser.TryParseUInt16X(text.Slice(12, 4), out num3, out num) || num != 4)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			ushort num4;
			if (!Utf8Parser.TryParseUInt16X(text.Slice(16, 4), out num4, out num) || num != 4)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			ulong num5;
			if (!Utf8Parser.TryParseUInt64X(text.Slice(20), out num5, out num) || num != 12)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			bytesConsumed = 32;
			value = new Guid((int)a, (short)num2, (short)num3, (byte)(num4 >> 8), (byte)num4, (byte)(num5 >> 40), (byte)(num5 >> 32), (byte)(num5 >> 24), (byte)(num5 >> 16), (byte)(num5 >> 8), (byte)num5);
			return true;
		}

		// Token: 0x06003DAC RID: 15788 RVA: 0x000CEFC8 File Offset: 0x000CD1C8
		private unsafe static bool TryParseGuidCore(ReadOnlySpan<byte> source, out Guid value, out int bytesConsumed, int ends)
		{
			int num = 36 + ((ends != 0) ? 2 : 0);
			if (source.Length < num)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			if (ends != 0)
			{
				if (*source[0] != (byte)ends)
				{
					value = default(Guid);
					bytesConsumed = 0;
					return false;
				}
				source = source.Slice(1);
				ends >>= 8;
			}
			uint a;
			int num2;
			if (!Utf8Parser.TryParseUInt32X(source, out a, out num2))
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			if (num2 != 8)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			if (*source[num2] != 45)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			source = source.Slice(9);
			ushort num3;
			if (!Utf8Parser.TryParseUInt16X(source, out num3, out num2))
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			if (num2 != 4)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			if (*source[num2] != 45)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			source = source.Slice(5);
			ushort num4;
			if (!Utf8Parser.TryParseUInt16X(source, out num4, out num2))
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			if (num2 != 4)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			if (*source[num2] != 45)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			source = source.Slice(5);
			ushort num5;
			if (!Utf8Parser.TryParseUInt16X(source, out num5, out num2))
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			if (num2 != 4)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			if (*source[num2] != 45)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			source = source.Slice(5);
			ulong num6;
			if (!Utf8Parser.TryParseUInt64X(source, out num6, out num2))
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			if (num2 != 12)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			if (ends != 0 && *source[num2] != (byte)ends)
			{
				value = default(Guid);
				bytesConsumed = 0;
				return false;
			}
			bytesConsumed = num;
			value = new Guid((int)a, (short)num3, (short)num4, (byte)(num5 >> 8), (byte)num5, (byte)(num6 >> 40), (byte)(num6 >> 32), (byte)(num6 >> 24), (byte)(num6 >> 16), (byte)(num6 >> 8), (byte)num6);
			return true;
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x000CF1D0 File Offset: 0x000CD3D0
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<byte> source, out sbyte value, out int bytesConsumed, char standardFormat = '\0')
		{
			while (standardFormat != '\0')
			{
				int num = (int)(standardFormat | ' ');
				if (num <= 103)
				{
					if (num != 100 && num != 103)
					{
						goto IL_55;
					}
				}
				else
				{
					if (num == 110)
					{
						return Utf8Parser.TryParseSByteN(source, out value, out bytesConsumed);
					}
					if (num != 114)
					{
						if (num != 120)
						{
							goto IL_55;
						}
						Unsafe.SkipInit<sbyte>(out value);
						return Utf8Parser.TryParseByteX(source, Unsafe.As<sbyte, byte>(ref value), out bytesConsumed);
					}
				}
				standardFormat = '\0';
				continue;
				IL_55:
				return ParserHelpers.TryParseThrowFormatException<sbyte>(source, out value, out bytesConsumed);
			}
			return Utf8Parser.TryParseSByteD(source, out value, out bytesConsumed);
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x000CF23C File Offset: 0x000CD43C
		public static bool TryParse(ReadOnlySpan<byte> source, out short value, out int bytesConsumed, char standardFormat = '\0')
		{
			while (standardFormat != '\0')
			{
				int num = (int)(standardFormat | ' ');
				if (num <= 103)
				{
					if (num != 100 && num != 103)
					{
						goto IL_55;
					}
				}
				else
				{
					if (num == 110)
					{
						return Utf8Parser.TryParseInt16N(source, out value, out bytesConsumed);
					}
					if (num != 114)
					{
						if (num != 120)
						{
							goto IL_55;
						}
						Unsafe.SkipInit<short>(out value);
						return Utf8Parser.TryParseUInt16X(source, Unsafe.As<short, ushort>(ref value), out bytesConsumed);
					}
				}
				standardFormat = '\0';
				continue;
				IL_55:
				return ParserHelpers.TryParseThrowFormatException<short>(source, out value, out bytesConsumed);
			}
			return Utf8Parser.TryParseInt16D(source, out value, out bytesConsumed);
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x000CF2A8 File Offset: 0x000CD4A8
		public static bool TryParse(ReadOnlySpan<byte> source, out int value, out int bytesConsumed, char standardFormat = '\0')
		{
			while (standardFormat != '\0')
			{
				int num = (int)(standardFormat | ' ');
				if (num <= 103)
				{
					if (num != 100 && num != 103)
					{
						goto IL_55;
					}
				}
				else
				{
					if (num == 110)
					{
						return Utf8Parser.TryParseInt32N(source, out value, out bytesConsumed);
					}
					if (num != 114)
					{
						if (num != 120)
						{
							goto IL_55;
						}
						Unsafe.SkipInit<int>(out value);
						return Utf8Parser.TryParseUInt32X(source, Unsafe.As<int, uint>(ref value), out bytesConsumed);
					}
				}
				standardFormat = '\0';
				continue;
				IL_55:
				return ParserHelpers.TryParseThrowFormatException<int>(source, out value, out bytesConsumed);
			}
			return Utf8Parser.TryParseInt32D(source, out value, out bytesConsumed);
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x000CF314 File Offset: 0x000CD514
		public static bool TryParse(ReadOnlySpan<byte> source, out long value, out int bytesConsumed, char standardFormat = '\0')
		{
			while (standardFormat != '\0')
			{
				int num = (int)(standardFormat | ' ');
				if (num <= 103)
				{
					if (num != 100 && num != 103)
					{
						goto IL_55;
					}
				}
				else
				{
					if (num == 110)
					{
						return Utf8Parser.TryParseInt64N(source, out value, out bytesConsumed);
					}
					if (num != 114)
					{
						if (num != 120)
						{
							goto IL_55;
						}
						Unsafe.SkipInit<long>(out value);
						return Utf8Parser.TryParseUInt64X(source, Unsafe.As<long, ulong>(ref value), out bytesConsumed);
					}
				}
				standardFormat = '\0';
				continue;
				IL_55:
				return ParserHelpers.TryParseThrowFormatException<long>(source, out value, out bytesConsumed);
			}
			return Utf8Parser.TryParseInt64D(source, out value, out bytesConsumed);
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x000CF380 File Offset: 0x000CD580
		private unsafe static bool TryParseSByteD(ReadOnlySpan<byte> source, out sbyte value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 1;
				int num2 = 0;
				int num3 = (int)(*source[num2]);
				if (num3 == 45)
				{
					num = -1;
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_123;
					}
					num3 = (int)(*source[num2]);
				}
				else if (num3 == 43)
				{
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_123;
					}
					num3 = (int)(*source[num2]);
				}
				int num4 = 0;
				if (ParserHelpers.IsDigit(num3))
				{
					if (num3 == 48)
					{
						do
						{
							num2++;
							if (num2 >= source.Length)
							{
								goto IL_12B;
							}
							num3 = (int)(*source[num2]);
						}
						while (num3 == 48);
						if (!ParserHelpers.IsDigit(num3))
						{
							goto IL_12B;
						}
					}
					num4 = num3 - 48;
					num2++;
					if (num2 < source.Length)
					{
						num3 = (int)(*source[num2]);
						if (ParserHelpers.IsDigit(num3))
						{
							num2++;
							num4 = 10 * num4 + num3 - 48;
							if (num2 < source.Length)
							{
								num3 = (int)(*source[num2]);
								if (ParserHelpers.IsDigit(num3))
								{
									num2++;
									num4 = num4 * 10 + num3 - 48;
									if ((ulong)num4 > (ulong)(127L + (long)((-1 * num + 1) / 2)) || (num2 < source.Length && ParserHelpers.IsDigit((int)(*source[num2]))))
									{
										goto IL_123;
									}
								}
							}
						}
					}
					IL_12B:
					bytesConsumed = num2;
					value = (sbyte)(num4 * num);
					return true;
				}
			}
			IL_123:
			bytesConsumed = 0;
			value = 0;
			return false;
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x000CF4C4 File Offset: 0x000CD6C4
		private unsafe static bool TryParseInt16D(ReadOnlySpan<byte> source, out short value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 1;
				int num2 = 0;
				int num3 = (int)(*source[num2]);
				if (num3 == 45)
				{
					num = -1;
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_186;
					}
					num3 = (int)(*source[num2]);
				}
				else if (num3 == 43)
				{
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_186;
					}
					num3 = (int)(*source[num2]);
				}
				int num4 = 0;
				if (ParserHelpers.IsDigit(num3))
				{
					if (num3 == 48)
					{
						do
						{
							num2++;
							if (num2 >= source.Length)
							{
								goto IL_18E;
							}
							num3 = (int)(*source[num2]);
						}
						while (num3 == 48);
						if (!ParserHelpers.IsDigit(num3))
						{
							goto IL_18E;
						}
					}
					num4 = num3 - 48;
					num2++;
					if (num2 < source.Length)
					{
						num3 = (int)(*source[num2]);
						if (ParserHelpers.IsDigit(num3))
						{
							num2++;
							num4 = 10 * num4 + num3 - 48;
							if (num2 < source.Length)
							{
								num3 = (int)(*source[num2]);
								if (ParserHelpers.IsDigit(num3))
								{
									num2++;
									num4 = 10 * num4 + num3 - 48;
									if (num2 < source.Length)
									{
										num3 = (int)(*source[num2]);
										if (ParserHelpers.IsDigit(num3))
										{
											num2++;
											num4 = 10 * num4 + num3 - 48;
											if (num2 < source.Length)
											{
												num3 = (int)(*source[num2]);
												if (ParserHelpers.IsDigit(num3))
												{
													num2++;
													num4 = num4 * 10 + num3 - 48;
													if ((ulong)num4 > (ulong)(32767L + (long)((-1 * num + 1) / 2)) || (num2 < source.Length && ParserHelpers.IsDigit((int)(*source[num2]))))
													{
														goto IL_186;
													}
												}
											}
										}
									}
								}
							}
						}
					}
					IL_18E:
					bytesConsumed = num2;
					value = (short)(num4 * num);
					return true;
				}
			}
			IL_186:
			bytesConsumed = 0;
			value = 0;
			return false;
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x000CF66C File Offset: 0x000CD86C
		private unsafe static bool TryParseInt32D(ReadOnlySpan<byte> source, out int value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 1;
				int num2 = 0;
				int num3 = (int)(*source[num2]);
				if (num3 == 45)
				{
					num = -1;
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_281;
					}
					num3 = (int)(*source[num2]);
				}
				else if (num3 == 43)
				{
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_281;
					}
					num3 = (int)(*source[num2]);
				}
				int num4 = 0;
				if (ParserHelpers.IsDigit(num3))
				{
					if (num3 == 48)
					{
						do
						{
							num2++;
							if (num2 >= source.Length)
							{
								goto IL_289;
							}
							num3 = (int)(*source[num2]);
						}
						while (num3 == 48);
						if (!ParserHelpers.IsDigit(num3))
						{
							goto IL_289;
						}
					}
					num4 = num3 - 48;
					num2++;
					if (num2 < source.Length)
					{
						num3 = (int)(*source[num2]);
						if (ParserHelpers.IsDigit(num3))
						{
							num2++;
							num4 = 10 * num4 + num3 - 48;
							if (num2 < source.Length)
							{
								num3 = (int)(*source[num2]);
								if (ParserHelpers.IsDigit(num3))
								{
									num2++;
									num4 = 10 * num4 + num3 - 48;
									if (num2 < source.Length)
									{
										num3 = (int)(*source[num2]);
										if (ParserHelpers.IsDigit(num3))
										{
											num2++;
											num4 = 10 * num4 + num3 - 48;
											if (num2 < source.Length)
											{
												num3 = (int)(*source[num2]);
												if (ParserHelpers.IsDigit(num3))
												{
													num2++;
													num4 = 10 * num4 + num3 - 48;
													if (num2 < source.Length)
													{
														num3 = (int)(*source[num2]);
														if (ParserHelpers.IsDigit(num3))
														{
															num2++;
															num4 = 10 * num4 + num3 - 48;
															if (num2 < source.Length)
															{
																num3 = (int)(*source[num2]);
																if (ParserHelpers.IsDigit(num3))
																{
																	num2++;
																	num4 = 10 * num4 + num3 - 48;
																	if (num2 < source.Length)
																	{
																		num3 = (int)(*source[num2]);
																		if (ParserHelpers.IsDigit(num3))
																		{
																			num2++;
																			num4 = 10 * num4 + num3 - 48;
																			if (num2 < source.Length)
																			{
																				num3 = (int)(*source[num2]);
																				if (ParserHelpers.IsDigit(num3))
																				{
																					num2++;
																					num4 = 10 * num4 + num3 - 48;
																					if (num2 < source.Length)
																					{
																						num3 = (int)(*source[num2]);
																						if (ParserHelpers.IsDigit(num3))
																						{
																							num2++;
																							if (num4 > 214748364)
																							{
																								goto IL_281;
																							}
																							num4 = num4 * 10 + num3 - 48;
																							if ((ulong)num4 > (ulong)(2147483647L + (long)((-1 * num + 1) / 2)) || (num2 < source.Length && ParserHelpers.IsDigit((int)(*source[num2]))))
																							{
																								goto IL_281;
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					IL_289:
					bytesConsumed = num2;
					value = num4 * num;
					return true;
				}
			}
			IL_281:
			bytesConsumed = 0;
			value = 0;
			return false;
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x000CF90C File Offset: 0x000CDB0C
		private unsafe static bool TryParseInt64D(ReadOnlySpan<byte> source, out long value, out int bytesConsumed)
		{
			long num = 0L;
			int i = 0;
			while (i < source.Length)
			{
				UIntPtr uintPtr = (UIntPtr)(*source[i] - 48);
				if ((uint)uintPtr <= 9U)
				{
					ulong num2 = (ulong)uintPtr;
					int num3 = 19 + i;
					i++;
					if (source.Length < num3)
					{
						while (i < source.Length)
						{
							UIntPtr uintPtr2 = (UIntPtr)(*source[i] - 48);
							if ((uint)uintPtr2 > 9U)
							{
								break;
							}
							num2 = num2 * 10UL + (ulong)uintPtr2;
							i++;
						}
					}
					else
					{
						while (i < source.Length)
						{
							UIntPtr uintPtr3 = (UIntPtr)(*source[i] - 48);
							if ((uint)uintPtr3 > 9U)
							{
								break;
							}
							i++;
							if (num2 < 922337203685477580UL)
							{
								num2 = num2 * 10UL + (ulong)uintPtr3;
							}
							else
							{
								if (num2 != 922337203685477580UL || (int)uintPtr3 + (int)num > 7)
								{
									goto IL_100;
								}
								num2 = 9223372036854775800UL + (ulong)uintPtr3;
							}
						}
					}
					bytesConsumed = i;
					value = (long)((num2 ^ (ulong)num) - (ulong)num);
					return true;
				}
				if (i != 0)
				{
					break;
				}
				i++;
				if ((uint)uintPtr == 4294967293U)
				{
					num -= 1L;
				}
				else if ((uint)uintPtr != 4294967291U)
				{
					break;
				}
			}
			IL_100:
			bytesConsumed = 0;
			value = 0L;
			return false;
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x000CFA24 File Offset: 0x000CDC24
		private unsafe static bool TryParseSByteN(ReadOnlySpan<byte> source, out sbyte value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 1;
				int num2 = 0;
				int num3 = (int)(*source[num2]);
				if (num3 == 45)
				{
					num = -1;
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_F9;
					}
					num3 = (int)(*source[num2]);
				}
				else if (num3 == 43)
				{
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_F9;
					}
					num3 = (int)(*source[num2]);
				}
				int num4;
				if (num3 != 46)
				{
					if (ParserHelpers.IsDigit(num3))
					{
						num4 = num3 - 48;
						for (;;)
						{
							num2++;
							if (num2 >= source.Length)
							{
								goto IL_101;
							}
							num3 = (int)(*source[num2]);
							if (num3 != 44)
							{
								if (num3 == 46)
								{
									goto IL_D4;
								}
								if (!ParserHelpers.IsDigit(num3))
								{
									goto IL_101;
								}
								num4 = num4 * 10 + num3 - 48;
								if (num4 > 127 + (-1 * num + 1) / 2)
								{
									break;
								}
							}
						}
						goto IL_F9;
					}
					goto IL_F9;
				}
				else
				{
					num4 = 0;
					num2++;
					if (num2 >= source.Length || *source[num2] != 48)
					{
						goto IL_F9;
					}
				}
				do
				{
					IL_D4:
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_101;
					}
					num3 = (int)(*source[num2]);
				}
				while (num3 == 48);
				if (ParserHelpers.IsDigit(num3))
				{
					goto IL_F9;
				}
				IL_101:
				bytesConsumed = num2;
				value = (sbyte)(num4 * num);
				return true;
			}
			IL_F9:
			bytesConsumed = 0;
			value = 0;
			return false;
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x000CFB3C File Offset: 0x000CDD3C
		private unsafe static bool TryParseInt16N(ReadOnlySpan<byte> source, out short value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 1;
				int num2 = 0;
				int num3 = (int)(*source[num2]);
				if (num3 == 45)
				{
					num = -1;
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_FF;
					}
					num3 = (int)(*source[num2]);
				}
				else if (num3 == 43)
				{
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_FF;
					}
					num3 = (int)(*source[num2]);
				}
				int num4;
				if (num3 != 46)
				{
					if (ParserHelpers.IsDigit(num3))
					{
						num4 = num3 - 48;
						for (;;)
						{
							num2++;
							if (num2 >= source.Length)
							{
								goto IL_107;
							}
							num3 = (int)(*source[num2]);
							if (num3 != 44)
							{
								if (num3 == 46)
								{
									goto IL_DA;
								}
								if (!ParserHelpers.IsDigit(num3))
								{
									goto IL_107;
								}
								num4 = num4 * 10 + num3 - 48;
								if (num4 > 32767 + (-1 * num + 1) / 2)
								{
									break;
								}
							}
						}
						goto IL_FF;
					}
					goto IL_FF;
				}
				else
				{
					num4 = 0;
					num2++;
					if (num2 >= source.Length || *source[num2] != 48)
					{
						goto IL_FF;
					}
				}
				do
				{
					IL_DA:
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_107;
					}
					num3 = (int)(*source[num2]);
				}
				while (num3 == 48);
				if (ParserHelpers.IsDigit(num3))
				{
					goto IL_FF;
				}
				IL_107:
				bytesConsumed = num2;
				value = (short)(num4 * num);
				return true;
			}
			IL_FF:
			bytesConsumed = 0;
			value = 0;
			return false;
		}

		// Token: 0x06003DB7 RID: 15799 RVA: 0x000CFC5C File Offset: 0x000CDE5C
		private unsafe static bool TryParseInt32N(ReadOnlySpan<byte> source, out int value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 1;
				int num2 = 0;
				int num3 = (int)(*source[num2]);
				if (num3 == 45)
				{
					num = -1;
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_10A;
					}
					num3 = (int)(*source[num2]);
				}
				else if (num3 == 43)
				{
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_10A;
					}
					num3 = (int)(*source[num2]);
				}
				int num4;
				if (num3 != 46)
				{
					if (ParserHelpers.IsDigit(num3))
					{
						num4 = num3 - 48;
						for (;;)
						{
							num2++;
							if (num2 >= source.Length)
							{
								goto IL_112;
							}
							num3 = (int)(*source[num2]);
							if (num3 != 44)
							{
								if (num3 == 46)
								{
									goto IL_E5;
								}
								if (!ParserHelpers.IsDigit(num3))
								{
									goto IL_112;
								}
								if (num4 > 214748364)
								{
									break;
								}
								num4 = num4 * 10 + num3 - 48;
								if ((ulong)num4 > (ulong)(2147483647L + (long)((-1 * num + 1) / 2)))
								{
									break;
								}
							}
						}
						goto IL_10A;
					}
					goto IL_10A;
				}
				else
				{
					num4 = 0;
					num2++;
					if (num2 >= source.Length || *source[num2] != 48)
					{
						goto IL_10A;
					}
				}
				do
				{
					IL_E5:
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_112;
					}
					num3 = (int)(*source[num2]);
				}
				while (num3 == 48);
				if (ParserHelpers.IsDigit(num3))
				{
					goto IL_10A;
				}
				IL_112:
				bytesConsumed = num2;
				value = num4 * num;
				return true;
			}
			IL_10A:
			bytesConsumed = 0;
			value = 0;
			return false;
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x000CFD84 File Offset: 0x000CDF84
		private unsafe static bool TryParseInt64N(ReadOnlySpan<byte> source, out long value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 1;
				int num2 = 0;
				int num3 = (int)(*source[num2]);
				if (num3 == 45)
				{
					num = -1;
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_115;
					}
					num3 = (int)(*source[num2]);
				}
				else if (num3 == 43)
				{
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_115;
					}
					num3 = (int)(*source[num2]);
				}
				long num4;
				if (num3 != 46)
				{
					if (ParserHelpers.IsDigit(num3))
					{
						num4 = (long)(num3 - 48);
						for (;;)
						{
							num2++;
							if (num2 >= source.Length)
							{
								goto IL_11E;
							}
							num3 = (int)(*source[num2]);
							if (num3 != 44)
							{
								if (num3 == 46)
								{
									goto IL_F0;
								}
								if (!ParserHelpers.IsDigit(num3))
								{
									goto IL_11E;
								}
								if (num4 > 922337203685477580L)
								{
									break;
								}
								num4 = num4 * 10L + (long)num3 - 48L;
								if (num4 > 9223372036854775807L + (long)((-1 * num + 1) / 2))
								{
									break;
								}
							}
						}
						goto IL_115;
					}
					goto IL_115;
				}
				else
				{
					num4 = 0L;
					num2++;
					if (num2 >= source.Length || *source[num2] != 48)
					{
						goto IL_115;
					}
				}
				do
				{
					IL_F0:
					num2++;
					if (num2 >= source.Length)
					{
						goto IL_11E;
					}
					num3 = (int)(*source[num2]);
				}
				while (num3 == 48);
				if (ParserHelpers.IsDigit(num3))
				{
					goto IL_115;
				}
				IL_11E:
				bytesConsumed = num2;
				value = num4 * (long)num;
				return true;
			}
			IL_115:
			bytesConsumed = 0;
			value = 0L;
			return false;
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x000CFEBC File Offset: 0x000CE0BC
		public static bool TryParse(ReadOnlySpan<byte> source, out byte value, out int bytesConsumed, char standardFormat = '\0')
		{
			while (standardFormat != '\0')
			{
				int num = (int)(standardFormat | ' ');
				if (num <= 103)
				{
					if (num != 100 && num != 103)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 110)
					{
						return Utf8Parser.TryParseByteN(source, out value, out bytesConsumed);
					}
					if (num != 114)
					{
						if (num != 120)
						{
							goto IL_4A;
						}
						return Utf8Parser.TryParseByteX(source, out value, out bytesConsumed);
					}
				}
				standardFormat = '\0';
				continue;
				IL_4A:
				return ParserHelpers.TryParseThrowFormatException<byte>(source, out value, out bytesConsumed);
			}
			return Utf8Parser.TryParseByteD(source, out value, out bytesConsumed);
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x000CFF1C File Offset: 0x000CE11C
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<byte> source, out ushort value, out int bytesConsumed, char standardFormat = '\0')
		{
			while (standardFormat != '\0')
			{
				int num = (int)(standardFormat | ' ');
				if (num <= 103)
				{
					if (num != 100 && num != 103)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 110)
					{
						return Utf8Parser.TryParseUInt16N(source, out value, out bytesConsumed);
					}
					if (num != 114)
					{
						if (num != 120)
						{
							goto IL_4A;
						}
						return Utf8Parser.TryParseUInt16X(source, out value, out bytesConsumed);
					}
				}
				standardFormat = '\0';
				continue;
				IL_4A:
				return ParserHelpers.TryParseThrowFormatException<ushort>(source, out value, out bytesConsumed);
			}
			return Utf8Parser.TryParseUInt16D(source, out value, out bytesConsumed);
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x000CFF7C File Offset: 0x000CE17C
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<byte> source, out uint value, out int bytesConsumed, char standardFormat = '\0')
		{
			while (standardFormat != '\0')
			{
				int num = (int)(standardFormat | ' ');
				if (num <= 103)
				{
					if (num != 100 && num != 103)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 110)
					{
						return Utf8Parser.TryParseUInt32N(source, out value, out bytesConsumed);
					}
					if (num != 114)
					{
						if (num != 120)
						{
							goto IL_4A;
						}
						return Utf8Parser.TryParseUInt32X(source, out value, out bytesConsumed);
					}
				}
				standardFormat = '\0';
				continue;
				IL_4A:
				return ParserHelpers.TryParseThrowFormatException<uint>(source, out value, out bytesConsumed);
			}
			return Utf8Parser.TryParseUInt32D(source, out value, out bytesConsumed);
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x000CFFDC File Offset: 0x000CE1DC
		[CLSCompliant(false)]
		public static bool TryParse(ReadOnlySpan<byte> source, out ulong value, out int bytesConsumed, char standardFormat = '\0')
		{
			while (standardFormat != '\0')
			{
				int num = (int)(standardFormat | ' ');
				if (num <= 103)
				{
					if (num != 100 && num != 103)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 110)
					{
						return Utf8Parser.TryParseUInt64N(source, out value, out bytesConsumed);
					}
					if (num != 114)
					{
						if (num != 120)
						{
							goto IL_4A;
						}
						return Utf8Parser.TryParseUInt64X(source, out value, out bytesConsumed);
					}
				}
				standardFormat = '\0';
				continue;
				IL_4A:
				return ParserHelpers.TryParseThrowFormatException<ulong>(source, out value, out bytesConsumed);
			}
			return Utf8Parser.TryParseUInt64D(source, out value, out bytesConsumed);
		}

		// Token: 0x06003DBD RID: 15805 RVA: 0x000D003C File Offset: 0x000CE23C
		private unsafe static bool TryParseByteD(ReadOnlySpan<byte> source, out byte value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 0;
				int num2 = (int)(*source[num]);
				int num3 = 0;
				if (ParserHelpers.IsDigit(num2))
				{
					if (num2 == 48)
					{
						do
						{
							num++;
							if (num >= source.Length)
							{
								goto IL_DD;
							}
							num2 = (int)(*source[num]);
						}
						while (num2 == 48);
						if (!ParserHelpers.IsDigit(num2))
						{
							goto IL_DD;
						}
					}
					num3 = num2 - 48;
					num++;
					if (num < source.Length)
					{
						num2 = (int)(*source[num]);
						if (ParserHelpers.IsDigit(num2))
						{
							num++;
							num3 = 10 * num3 + num2 - 48;
							if (num < source.Length)
							{
								num2 = (int)(*source[num]);
								if (ParserHelpers.IsDigit(num2))
								{
									num++;
									num3 = num3 * 10 + num2 - 48;
									if (num3 > 255 || (num < source.Length && ParserHelpers.IsDigit((int)(*source[num]))))
									{
										goto IL_D5;
									}
								}
							}
						}
					}
					IL_DD:
					bytesConsumed = num;
					value = (byte)num3;
					return true;
				}
			}
			IL_D5:
			bytesConsumed = 0;
			value = 0;
			return false;
		}

		// Token: 0x06003DBE RID: 15806 RVA: 0x000D0130 File Offset: 0x000CE330
		private unsafe static bool TryParseUInt16D(ReadOnlySpan<byte> source, out ushort value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 0;
				int num2 = (int)(*source[num]);
				int num3 = 0;
				if (ParserHelpers.IsDigit(num2))
				{
					if (num2 == 48)
					{
						do
						{
							num++;
							if (num >= source.Length)
							{
								goto IL_13D;
							}
							num2 = (int)(*source[num]);
						}
						while (num2 == 48);
						if (!ParserHelpers.IsDigit(num2))
						{
							goto IL_13D;
						}
					}
					num3 = num2 - 48;
					num++;
					if (num < source.Length)
					{
						num2 = (int)(*source[num]);
						if (ParserHelpers.IsDigit(num2))
						{
							num++;
							num3 = 10 * num3 + num2 - 48;
							if (num < source.Length)
							{
								num2 = (int)(*source[num]);
								if (ParserHelpers.IsDigit(num2))
								{
									num++;
									num3 = 10 * num3 + num2 - 48;
									if (num < source.Length)
									{
										num2 = (int)(*source[num]);
										if (ParserHelpers.IsDigit(num2))
										{
											num++;
											num3 = 10 * num3 + num2 - 48;
											if (num < source.Length)
											{
												num2 = (int)(*source[num]);
												if (ParserHelpers.IsDigit(num2))
												{
													num++;
													num3 = num3 * 10 + num2 - 48;
													if (num3 > 65535 || (num < source.Length && ParserHelpers.IsDigit((int)(*source[num]))))
													{
														goto IL_135;
													}
												}
											}
										}
									}
								}
							}
						}
					}
					IL_13D:
					bytesConsumed = num;
					value = (ushort)num3;
					return true;
				}
			}
			IL_135:
			bytesConsumed = 0;
			value = 0;
			return false;
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x000D0284 File Offset: 0x000CE484
		private unsafe static bool TryParseUInt32D(ReadOnlySpan<byte> source, out uint value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 0;
				int num2 = (int)(*source[num]);
				int num3 = 0;
				if (ParserHelpers.IsDigit(num2))
				{
					if (num2 == 48)
					{
						do
						{
							num++;
							if (num >= source.Length)
							{
								goto IL_23D;
							}
							num2 = (int)(*source[num]);
						}
						while (num2 == 48);
						if (!ParserHelpers.IsDigit(num2))
						{
							goto IL_23D;
						}
					}
					num3 = num2 - 48;
					num++;
					if (num < source.Length)
					{
						num2 = (int)(*source[num]);
						if (ParserHelpers.IsDigit(num2))
						{
							num++;
							num3 = 10 * num3 + num2 - 48;
							if (num < source.Length)
							{
								num2 = (int)(*source[num]);
								if (ParserHelpers.IsDigit(num2))
								{
									num++;
									num3 = 10 * num3 + num2 - 48;
									if (num < source.Length)
									{
										num2 = (int)(*source[num]);
										if (ParserHelpers.IsDigit(num2))
										{
											num++;
											num3 = 10 * num3 + num2 - 48;
											if (num < source.Length)
											{
												num2 = (int)(*source[num]);
												if (ParserHelpers.IsDigit(num2))
												{
													num++;
													num3 = 10 * num3 + num2 - 48;
													if (num < source.Length)
													{
														num2 = (int)(*source[num]);
														if (ParserHelpers.IsDigit(num2))
														{
															num++;
															num3 = 10 * num3 + num2 - 48;
															if (num < source.Length)
															{
																num2 = (int)(*source[num]);
																if (ParserHelpers.IsDigit(num2))
																{
																	num++;
																	num3 = 10 * num3 + num2 - 48;
																	if (num < source.Length)
																	{
																		num2 = (int)(*source[num]);
																		if (ParserHelpers.IsDigit(num2))
																		{
																			num++;
																			num3 = 10 * num3 + num2 - 48;
																			if (num < source.Length)
																			{
																				num2 = (int)(*source[num]);
																				if (ParserHelpers.IsDigit(num2))
																				{
																					num++;
																					num3 = 10 * num3 + num2 - 48;
																					if (num < source.Length)
																					{
																						num2 = (int)(*source[num]);
																						if (ParserHelpers.IsDigit(num2))
																						{
																							num++;
																							if (num3 > 429496729 || (num3 == 429496729 && num2 > 53))
																							{
																								goto IL_235;
																							}
																							num3 = num3 * 10 + num2 - 48;
																							if (num < source.Length && ParserHelpers.IsDigit((int)(*source[num])))
																							{
																								goto IL_235;
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					IL_23D:
					bytesConsumed = num;
					value = (uint)num3;
					return true;
				}
			}
			IL_235:
			bytesConsumed = 0;
			value = 0U;
			return false;
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x000D04D8 File Offset: 0x000CE6D8
		private unsafe static bool TryParseUInt64D(ReadOnlySpan<byte> source, out ulong value, out int bytesConsumed)
		{
			if (!source.IsEmpty)
			{
				UIntPtr uintPtr = (UIntPtr)(*source[0] - 48);
				if ((uint)uintPtr <= 9U)
				{
					ulong num = (ulong)uintPtr;
					int i = 1;
					if (source.Length < 20)
					{
						while (i < source.Length)
						{
							UIntPtr uintPtr2 = (UIntPtr)(*source[i] - 48);
							if ((uint)uintPtr2 > 9U)
							{
								break;
							}
							num = num * 10UL + (ulong)uintPtr2;
							i++;
						}
					}
					else
					{
						while (i < source.Length)
						{
							UIntPtr uintPtr3 = (UIntPtr)(*source[i] - 48);
							if ((uint)uintPtr3 > 9U)
							{
								break;
							}
							i++;
							if (num < 1844674407370955161UL)
							{
								num = num * 10UL + (ulong)uintPtr3;
							}
							else
							{
								if (num != 1844674407370955161UL || (uint)uintPtr3 > 5U)
								{
									goto IL_C0;
								}
								num = 18446744073709551610UL + (ulong)uintPtr3;
							}
						}
					}
					bytesConsumed = i;
					value = num;
					return true;
				}
			}
			IL_C0:
			bytesConsumed = 0;
			value = 0UL;
			return false;
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x000D05B0 File Offset: 0x000CE7B0
		private unsafe static bool TryParseByteN(ReadOnlySpan<byte> source, out byte value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 0;
				int num2 = (int)(*source[num]);
				if (num2 == 43)
				{
					num++;
					if (num >= source.Length)
					{
						goto IL_CE;
					}
					num2 = (int)(*source[num]);
				}
				int num3;
				if (num2 != 46)
				{
					if (ParserHelpers.IsDigit(num2))
					{
						num3 = num2 - 48;
						for (;;)
						{
							num++;
							if (num >= source.Length)
							{
								goto IL_D6;
							}
							num2 = (int)(*source[num]);
							if (num2 != 44)
							{
								if (num2 == 46)
								{
									goto IL_A9;
								}
								if (!ParserHelpers.IsDigit(num2))
								{
									goto IL_D6;
								}
								num3 = num3 * 10 + num2 - 48;
								if (num3 > 255)
								{
									break;
								}
							}
						}
						goto IL_CE;
					}
					goto IL_CE;
				}
				else
				{
					num3 = 0;
					num++;
					if (num >= source.Length || *source[num] != 48)
					{
						goto IL_CE;
					}
				}
				do
				{
					IL_A9:
					num++;
					if (num >= source.Length)
					{
						goto IL_D6;
					}
					num2 = (int)(*source[num]);
				}
				while (num2 == 48);
				if (ParserHelpers.IsDigit(num2))
				{
					goto IL_CE;
				}
				IL_D6:
				bytesConsumed = num;
				value = (byte)num3;
				return true;
			}
			IL_CE:
			bytesConsumed = 0;
			value = 0;
			return false;
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x000D069C File Offset: 0x000CE89C
		private unsafe static bool TryParseUInt16N(ReadOnlySpan<byte> source, out ushort value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 0;
				int num2 = (int)(*source[num]);
				if (num2 == 43)
				{
					num++;
					if (num >= source.Length)
					{
						goto IL_CE;
					}
					num2 = (int)(*source[num]);
				}
				int num3;
				if (num2 != 46)
				{
					if (ParserHelpers.IsDigit(num2))
					{
						num3 = num2 - 48;
						for (;;)
						{
							num++;
							if (num >= source.Length)
							{
								goto IL_D6;
							}
							num2 = (int)(*source[num]);
							if (num2 != 44)
							{
								if (num2 == 46)
								{
									goto IL_A9;
								}
								if (!ParserHelpers.IsDigit(num2))
								{
									goto IL_D6;
								}
								num3 = num3 * 10 + num2 - 48;
								if (num3 > 65535)
								{
									break;
								}
							}
						}
						goto IL_CE;
					}
					goto IL_CE;
				}
				else
				{
					num3 = 0;
					num++;
					if (num >= source.Length || *source[num] != 48)
					{
						goto IL_CE;
					}
				}
				do
				{
					IL_A9:
					num++;
					if (num >= source.Length)
					{
						goto IL_D6;
					}
					num2 = (int)(*source[num]);
				}
				while (num2 == 48);
				if (ParserHelpers.IsDigit(num2))
				{
					goto IL_CE;
				}
				IL_D6:
				bytesConsumed = num;
				value = (ushort)num3;
				return true;
			}
			IL_CE:
			bytesConsumed = 0;
			value = 0;
			return false;
		}

		// Token: 0x06003DC3 RID: 15811 RVA: 0x000D0788 File Offset: 0x000CE988
		private unsafe static bool TryParseUInt32N(ReadOnlySpan<byte> source, out uint value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 0;
				int num2 = (int)(*source[num]);
				if (num2 == 43)
				{
					num++;
					if (num >= source.Length)
					{
						goto IL_DE;
					}
					num2 = (int)(*source[num]);
				}
				int num3;
				if (num2 != 46)
				{
					if (!ParserHelpers.IsDigit(num2))
					{
						goto IL_DE;
					}
					num3 = num2 - 48;
					for (;;)
					{
						num++;
						if (num >= source.Length)
						{
							goto IL_E6;
						}
						num2 = (int)(*source[num]);
						if (num2 != 44)
						{
							if (num2 == 46)
							{
								break;
							}
							if (!ParserHelpers.IsDigit(num2))
							{
								goto IL_E6;
							}
							if (num3 > 429496729 || (num3 == 429496729 && num2 > 53))
							{
								goto IL_DE;
							}
							num3 = num3 * 10 + num2 - 48;
						}
					}
				}
				else
				{
					num3 = 0;
					num++;
					if (num >= source.Length || *source[num] != 48)
					{
						goto IL_DE;
					}
				}
				do
				{
					num++;
					if (num >= source.Length)
					{
						goto IL_E6;
					}
					num2 = (int)(*source[num]);
				}
				while (num2 == 48);
				if (ParserHelpers.IsDigit(num2))
				{
					goto IL_DE;
				}
				IL_E6:
				bytesConsumed = num;
				value = (uint)num3;
				return true;
			}
			IL_DE:
			bytesConsumed = 0;
			value = 0U;
			return false;
		}

		// Token: 0x06003DC4 RID: 15812 RVA: 0x000D0884 File Offset: 0x000CEA84
		private unsafe static bool TryParseUInt64N(ReadOnlySpan<byte> source, out ulong value, out int bytesConsumed)
		{
			if (source.Length >= 1)
			{
				int num = 0;
				int num2 = (int)(*source[num]);
				if (num2 == 43)
				{
					num++;
					if (num >= source.Length)
					{
						goto IL_EB;
					}
					num2 = (int)(*source[num]);
				}
				long num3;
				if (num2 != 46)
				{
					if (!ParserHelpers.IsDigit(num2))
					{
						goto IL_EB;
					}
					num3 = (long)(num2 - 48);
					for (;;)
					{
						num++;
						if (num >= source.Length)
						{
							goto IL_F4;
						}
						num2 = (int)(*source[num]);
						if (num2 != 44)
						{
							if (num2 == 46)
							{
								break;
							}
							if (!ParserHelpers.IsDigit(num2))
							{
								goto IL_F4;
							}
							if (num3 > 1844674407370955161L || (num3 == 1844674407370955161L && num2 > 53))
							{
								goto IL_EB;
							}
							num3 = num3 * 10L + (long)num2 - 48L;
						}
					}
				}
				else
				{
					num3 = 0L;
					num++;
					if (num >= source.Length || *source[num] != 48)
					{
						goto IL_EB;
					}
				}
				do
				{
					num++;
					if (num >= source.Length)
					{
						goto IL_F4;
					}
					num2 = (int)(*source[num]);
				}
				while (num2 == 48);
				if (ParserHelpers.IsDigit(num2))
				{
					goto IL_EB;
				}
				IL_F4:
				bytesConsumed = num;
				value = (ulong)num3;
				return true;
			}
			IL_EB:
			bytesConsumed = 0;
			value = 0UL;
			return false;
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x000D098C File Offset: 0x000CEB8C
		private unsafe static bool TryParseByteX(ReadOnlySpan<byte> source, out byte value, out int bytesConsumed)
		{
			if (source.Length < 1)
			{
				bytesConsumed = 0;
				value = 0;
				return false;
			}
			ReadOnlySpan<byte> charToHexLookup = HexConverter.CharToHexLookup;
			byte index = *source[0];
			byte b = *charToHexLookup[(int)index];
			if (b == 255)
			{
				bytesConsumed = 0;
				value = 0;
				return false;
			}
			uint num = (uint)b;
			if (source.Length <= 2)
			{
				for (int i = 1; i < source.Length; i++)
				{
					index = *source[i];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = i;
						value = (byte)num;
						return true;
					}
					num = (num << 4) + (uint)b;
				}
			}
			else
			{
				for (int j = 1; j < 2; j++)
				{
					index = *source[j];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = j;
						value = (byte)num;
						return true;
					}
					num = (num << 4) + (uint)b;
				}
				for (int k = 2; k < source.Length; k++)
				{
					index = *source[k];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = k;
						value = (byte)num;
						return true;
					}
					if (num > 15U)
					{
						bytesConsumed = 0;
						value = 0;
						return false;
					}
					num = (num << 4) + (uint)b;
				}
			}
			bytesConsumed = source.Length;
			value = (byte)num;
			return true;
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x000D0AC4 File Offset: 0x000CECC4
		private unsafe static bool TryParseUInt16X(ReadOnlySpan<byte> source, out ushort value, out int bytesConsumed)
		{
			if (source.Length < 1)
			{
				bytesConsumed = 0;
				value = 0;
				return false;
			}
			ReadOnlySpan<byte> charToHexLookup = HexConverter.CharToHexLookup;
			byte index = *source[0];
			byte b = *charToHexLookup[(int)index];
			if (b == 255)
			{
				bytesConsumed = 0;
				value = 0;
				return false;
			}
			uint num = (uint)b;
			if (source.Length <= 4)
			{
				for (int i = 1; i < source.Length; i++)
				{
					index = *source[i];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = i;
						value = (ushort)num;
						return true;
					}
					num = (num << 4) + (uint)b;
				}
			}
			else
			{
				for (int j = 1; j < 4; j++)
				{
					index = *source[j];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = j;
						value = (ushort)num;
						return true;
					}
					num = (num << 4) + (uint)b;
				}
				for (int k = 4; k < source.Length; k++)
				{
					index = *source[k];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = k;
						value = (ushort)num;
						return true;
					}
					if (num > 4095U)
					{
						bytesConsumed = 0;
						value = 0;
						return false;
					}
					num = (num << 4) + (uint)b;
				}
			}
			bytesConsumed = source.Length;
			value = (ushort)num;
			return true;
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x000D0C00 File Offset: 0x000CEE00
		private unsafe static bool TryParseUInt32X(ReadOnlySpan<byte> source, out uint value, out int bytesConsumed)
		{
			if (source.Length < 1)
			{
				bytesConsumed = 0;
				value = 0U;
				return false;
			}
			ReadOnlySpan<byte> charToHexLookup = HexConverter.CharToHexLookup;
			byte index = *source[0];
			byte b = *charToHexLookup[(int)index];
			if (b == 255)
			{
				bytesConsumed = 0;
				value = 0U;
				return false;
			}
			uint num = (uint)b;
			if (source.Length <= 8)
			{
				for (int i = 1; i < source.Length; i++)
				{
					index = *source[i];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = i;
						value = num;
						return true;
					}
					num = (num << 4) + (uint)b;
				}
			}
			else
			{
				for (int j = 1; j < 8; j++)
				{
					index = *source[j];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = j;
						value = num;
						return true;
					}
					num = (num << 4) + (uint)b;
				}
				for (int k = 8; k < source.Length; k++)
				{
					index = *source[k];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = k;
						value = num;
						return true;
					}
					if (num > 268435455U)
					{
						bytesConsumed = 0;
						value = 0U;
						return false;
					}
					num = (num << 4) + (uint)b;
				}
			}
			bytesConsumed = source.Length;
			value = num;
			return true;
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x000D0D38 File Offset: 0x000CEF38
		private unsafe static bool TryParseUInt64X(ReadOnlySpan<byte> source, out ulong value, out int bytesConsumed)
		{
			if (source.Length < 1)
			{
				bytesConsumed = 0;
				value = 0UL;
				return false;
			}
			ReadOnlySpan<byte> charToHexLookup = HexConverter.CharToHexLookup;
			byte index = *source[0];
			byte b = *charToHexLookup[(int)index];
			if (b == 255)
			{
				bytesConsumed = 0;
				value = 0UL;
				return false;
			}
			ulong num = (ulong)b;
			if (source.Length <= 16)
			{
				for (int i = 1; i < source.Length; i++)
				{
					index = *source[i];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = i;
						value = num;
						return true;
					}
					num = (num << 4) + (ulong)b;
				}
			}
			else
			{
				for (int j = 1; j < 16; j++)
				{
					index = *source[j];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = j;
						value = num;
						return true;
					}
					num = (num << 4) + (ulong)b;
				}
				for (int k = 16; k < source.Length; k++)
				{
					index = *source[k];
					b = *charToHexLookup[(int)index];
					if (b == 255)
					{
						bytesConsumed = k;
						value = num;
						return true;
					}
					if (num > 1152921504606846975UL)
					{
						bytesConsumed = 0;
						value = 0UL;
						return false;
					}
					num = (num << 4) + (ulong)b;
				}
			}
			bytesConsumed = source.Length;
			value = num;
			return true;
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x000D0E80 File Offset: 0x000CF080
		private unsafe static bool TryParseNumber(ReadOnlySpan<byte> source, ref Number.NumberBuffer number, out int bytesConsumed, Utf8Parser.ParseNumberOptions options, out bool textUsedExponentNotation)
		{
			textUsedExponentNotation = false;
			if (source.Length == 0)
			{
				bytesConsumed = 0;
				return false;
			}
			Span<byte> digits = number.Digits;
			int i = 0;
			byte b = *source[i];
			if (b != 43)
			{
				if (b != 45)
				{
					goto IL_55;
				}
				number.IsNegative = true;
			}
			i++;
			if (i >= source.Length)
			{
				bytesConsumed = 0;
				return false;
			}
			b = *source[i];
			IL_55:
			int num = i;
			int num2 = 0;
			int num3 = digits.Length - 1;
			while (i < source.Length)
			{
				b = *source[i];
				if (b != 48)
				{
					break;
				}
				i++;
			}
			if (i == source.Length)
			{
				bytesConsumed = i;
				return true;
			}
			int num4 = i;
			int num5 = 0;
			while (i < source.Length)
			{
				b = *source[i];
				int num6 = (int)(b - 48);
				if (num6 > 9)
				{
					break;
				}
				i++;
				num2++;
				if (num2 >= num3)
				{
					num5 |= num6;
				}
			}
			number.HasNonZeroTail = (num5 != 0);
			int num7 = i - num;
			int num8 = i - num4;
			int num9 = Math.Min(num8, num3);
			source.Slice(num4, num9).CopyTo(digits);
			int num10 = num9;
			number.Scale = num8;
			if (i == source.Length)
			{
				*digits[num10] = 0;
				number.DigitsCount = num10;
				bytesConsumed = i;
				return true;
			}
			int num11 = 0;
			if (b == 46)
			{
				i++;
				int num12 = i;
				while (i < source.Length)
				{
					b = *source[i];
					int num13 = (int)(b - 48);
					if (num13 > 9)
					{
						break;
					}
					i++;
					num2++;
					if (num2 >= num3)
					{
						num5 |= num13;
					}
				}
				number.HasNonZeroTail = (num5 != 0);
				num11 = i - num12;
				int num14 = num12;
				if (num10 == 0)
				{
					while (num14 < i && *source[num14] == 48)
					{
						number.Scale--;
						num14++;
					}
				}
				int num15 = Math.Min(i - num14, num3 - num10);
				source.Slice(num14, num15).CopyTo(digits.Slice(num10));
				num10 += num15;
				if (i == source.Length)
				{
					if (num7 == 0 && num11 == 0)
					{
						bytesConsumed = 0;
						return false;
					}
					*digits[num10] = 0;
					number.DigitsCount = num10;
					bytesConsumed = i;
					return true;
				}
			}
			if (num7 == 0 && num11 == 0)
			{
				bytesConsumed = 0;
				return false;
			}
			if (((int)b & -33) != 69)
			{
				*digits[num10] = 0;
				number.DigitsCount = num10;
				bytesConsumed = i;
				return true;
			}
			textUsedExponentNotation = true;
			i++;
			if ((options & Utf8Parser.ParseNumberOptions.AllowExponent) == (Utf8Parser.ParseNumberOptions)0)
			{
				bytesConsumed = 0;
				return false;
			}
			if (i == source.Length)
			{
				bytesConsumed = 0;
				return false;
			}
			bool flag = false;
			b = *source[i];
			if (b != 43)
			{
				if (b != 45)
				{
					goto IL_2A0;
				}
				flag = true;
			}
			i++;
			if (i == source.Length)
			{
				bytesConsumed = 0;
				return false;
			}
			b = *source[i];
			IL_2A0:
			if (b - 48 > 9)
			{
				bytesConsumed = 0;
				return false;
			}
			uint maxValue;
			int num16;
			if (!Utf8Parser.TryParseUInt32D(source.Slice(i), out maxValue, out num16))
			{
				maxValue = uint.MaxValue;
				for (i += 10; i < source.Length; i++)
				{
					b = *source[i];
					if (b - 48 > 9)
					{
						break;
					}
				}
			}
			i += num16;
			if (flag)
			{
				if ((long)number.Scale < (long)(18446744071562067968UL + (ulong)maxValue))
				{
					number.Scale = int.MinValue;
				}
				else
				{
					number.Scale -= (int)maxValue;
				}
			}
			else if ((long)number.Scale > (long)(2147483647UL - (ulong)maxValue))
			{
				number.Scale = int.MaxValue;
			}
			else
			{
				number.Scale += (int)maxValue;
			}
			*digits[num10] = 0;
			number.DigitsCount = num10;
			bytesConsumed = i;
			return true;
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x000D11F4 File Offset: 0x000CF3F4
		private unsafe static bool TryParseTimeSpanBigG(ReadOnlySpan<byte> source, out TimeSpan value, out int bytesConsumed)
		{
			int i = 0;
			byte b = 0;
			while (i < source.Length)
			{
				b = *source[i];
				if (b != 32 && b != 9)
				{
					break;
				}
				i++;
			}
			if (i == source.Length)
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			bool isNegative = false;
			if (b == 45)
			{
				isNegative = true;
				i++;
				if (i == source.Length)
				{
					value = default(TimeSpan);
					bytesConsumed = 0;
					return false;
				}
			}
			uint days;
			int num;
			if (!Utf8Parser.TryParseUInt32D(source.Slice(i), out days, out num))
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			i += num;
			if (i == source.Length || *source[i++] != 58)
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			uint hours;
			if (!Utf8Parser.TryParseUInt32D(source.Slice(i), out hours, out num))
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			i += num;
			if (i == source.Length || *source[i++] != 58)
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			uint minutes;
			if (!Utf8Parser.TryParseUInt32D(source.Slice(i), out minutes, out num))
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			i += num;
			if (i == source.Length || *source[i++] != 58)
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			uint seconds;
			if (!Utf8Parser.TryParseUInt32D(source.Slice(i), out seconds, out num))
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			i += num;
			if (i == source.Length || *source[i++] != 46)
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			uint fraction;
			if (!Utf8Parser.TryParseTimeSpanFraction(source.Slice(i), out fraction, out num))
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			i += num;
			if (!Utf8Parser.TryCreateTimeSpan(isNegative, days, hours, minutes, seconds, fraction, out value))
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			if (i != source.Length && (*source[i] == 46 || *source[i] == 58))
			{
				value = default(TimeSpan);
				bytesConsumed = 0;
				return false;
			}
			bytesConsumed = i;
			return true;
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x000D1404 File Offset: 0x000CF604
		private static bool TryParseTimeSpanC(ReadOnlySpan<byte> source, out TimeSpan value, out int bytesConsumed)
		{
			Utf8Parser.TimeSpanSplitter timeSpanSplitter = default(Utf8Parser.TimeSpanSplitter);
			if (!timeSpanSplitter.TrySplitTimeSpan(source, true, out bytesConsumed))
			{
				value = default(TimeSpan);
				return false;
			}
			bool isNegative = timeSpanSplitter.IsNegative;
			uint separators = timeSpanSplitter.Separators;
			bool flag;
			if (separators <= 16842752U)
			{
				if (separators == 0U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, timeSpanSplitter.V1, 0U, 0U, 0U, 0U, out value);
					goto IL_172;
				}
				if (separators == 16777216U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, 0U, timeSpanSplitter.V1, timeSpanSplitter.V2, 0U, 0U, out value);
					goto IL_172;
				}
				if (separators == 16842752U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, 0U, timeSpanSplitter.V1, timeSpanSplitter.V2, timeSpanSplitter.V3, 0U, out value);
					goto IL_172;
				}
			}
			else if (separators <= 33619968U)
			{
				if (separators == 16843264U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, 0U, timeSpanSplitter.V1, timeSpanSplitter.V2, timeSpanSplitter.V3, timeSpanSplitter.V4, out value);
					goto IL_172;
				}
				if (separators == 33619968U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, timeSpanSplitter.V1, timeSpanSplitter.V2, timeSpanSplitter.V3, 0U, 0U, out value);
					goto IL_172;
				}
			}
			else
			{
				if (separators == 33620224U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, timeSpanSplitter.V1, timeSpanSplitter.V2, timeSpanSplitter.V3, timeSpanSplitter.V4, 0U, out value);
					goto IL_172;
				}
				if (separators == 33620226U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, timeSpanSplitter.V1, timeSpanSplitter.V2, timeSpanSplitter.V3, timeSpanSplitter.V4, timeSpanSplitter.V5, out value);
					goto IL_172;
				}
			}
			value = default(TimeSpan);
			flag = false;
			IL_172:
			if (!flag)
			{
				bytesConsumed = 0;
				return false;
			}
			return true;
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x000D158C File Offset: 0x000CF78C
		public static bool TryParse(ReadOnlySpan<byte> source, out TimeSpan value, out int bytesConsumed, char standardFormat = '\0')
		{
			if (standardFormat <= 'T')
			{
				if (standardFormat != '\0')
				{
					if (standardFormat == 'G')
					{
						return Utf8Parser.TryParseTimeSpanBigG(source, out value, out bytesConsumed);
					}
					if (standardFormat != 'T')
					{
						goto IL_44;
					}
				}
			}
			else if (standardFormat != 'c')
			{
				if (standardFormat == 'g')
				{
					return Utf8Parser.TryParseTimeSpanLittleG(source, out value, out bytesConsumed);
				}
				if (standardFormat != 't')
				{
					goto IL_44;
				}
			}
			return Utf8Parser.TryParseTimeSpanC(source, out value, out bytesConsumed);
			IL_44:
			return ParserHelpers.TryParseThrowFormatException<TimeSpan>(out value, out bytesConsumed);
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x000D15E8 File Offset: 0x000CF7E8
		private unsafe static bool TryParseTimeSpanFraction(ReadOnlySpan<byte> source, out uint value, out int bytesConsumed)
		{
			int i = 0;
			if (i == source.Length)
			{
				value = 0U;
				bytesConsumed = 0;
				return false;
			}
			uint num = (uint)(*source[i] - 48);
			if (num > 9U)
			{
				value = 0U;
				bytesConsumed = 0;
				return false;
			}
			i++;
			uint num2 = num;
			int num3 = 1;
			while (i < source.Length)
			{
				num = (uint)(*source[i] - 48);
				if (num > 9U)
				{
					break;
				}
				i++;
				num3++;
				if (num3 > 7)
				{
					value = 0U;
					bytesConsumed = 0;
					return false;
				}
				num2 = 10U * num2 + num;
			}
			switch (num3)
			{
			case 2:
				num2 *= 100000U;
				break;
			case 3:
				num2 *= 10000U;
				break;
			case 4:
				num2 *= 1000U;
				break;
			case 5:
				num2 *= 100U;
				break;
			case 6:
				num2 *= 10U;
				break;
			case 7:
				break;
			default:
				num2 *= 1000000U;
				break;
			}
			value = num2;
			bytesConsumed = i;
			return true;
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x000D16C4 File Offset: 0x000CF8C4
		private static bool TryCreateTimeSpan(bool isNegative, uint days, uint hours, uint minutes, uint seconds, uint fraction, out TimeSpan timeSpan)
		{
			if (hours > 23U || minutes > 59U || seconds > 59U)
			{
				timeSpan = default(TimeSpan);
				return false;
			}
			long num = (long)(((ulong)days * 3600UL * 24UL + (ulong)hours * 3600UL + (ulong)minutes * 60UL + (ulong)seconds) * 1000UL);
			long ticks;
			if (isNegative)
			{
				num = -num;
				if (num < -922337203685477L)
				{
					timeSpan = default(TimeSpan);
					return false;
				}
				long num2 = num * 10000L;
				if (num2 < (long)(9223372036854775808UL + (ulong)fraction))
				{
					timeSpan = default(TimeSpan);
					return false;
				}
				ticks = num2 - (long)((ulong)fraction);
			}
			else
			{
				if (num > 922337203685477L)
				{
					timeSpan = default(TimeSpan);
					return false;
				}
				long num3 = num * 10000L;
				if (num3 > (long)(9223372036854775807UL - (ulong)fraction))
				{
					timeSpan = default(TimeSpan);
					return false;
				}
				ticks = num3 + (long)((ulong)fraction);
			}
			timeSpan = new TimeSpan(ticks);
			return true;
		}

		// Token: 0x06003DCF RID: 15823 RVA: 0x000D17AC File Offset: 0x000CF9AC
		private static bool TryParseTimeSpanLittleG(ReadOnlySpan<byte> source, out TimeSpan value, out int bytesConsumed)
		{
			Utf8Parser.TimeSpanSplitter timeSpanSplitter = default(Utf8Parser.TimeSpanSplitter);
			if (!timeSpanSplitter.TrySplitTimeSpan(source, false, out bytesConsumed))
			{
				value = default(TimeSpan);
				return false;
			}
			bool isNegative = timeSpanSplitter.IsNegative;
			uint separators = timeSpanSplitter.Separators;
			bool flag;
			if (separators <= 16842752U)
			{
				if (separators == 0U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, timeSpanSplitter.V1, 0U, 0U, 0U, 0U, out value);
					goto IL_133;
				}
				if (separators == 16777216U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, 0U, timeSpanSplitter.V1, timeSpanSplitter.V2, 0U, 0U, out value);
					goto IL_133;
				}
				if (separators == 16842752U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, 0U, timeSpanSplitter.V1, timeSpanSplitter.V2, timeSpanSplitter.V3, 0U, out value);
					goto IL_133;
				}
			}
			else
			{
				if (separators == 16843008U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, timeSpanSplitter.V1, timeSpanSplitter.V2, timeSpanSplitter.V3, timeSpanSplitter.V4, 0U, out value);
					goto IL_133;
				}
				if (separators == 16843010U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, timeSpanSplitter.V1, timeSpanSplitter.V2, timeSpanSplitter.V3, timeSpanSplitter.V4, timeSpanSplitter.V5, out value);
					goto IL_133;
				}
				if (separators == 16843264U)
				{
					flag = Utf8Parser.TryCreateTimeSpan(isNegative, 0U, timeSpanSplitter.V1, timeSpanSplitter.V2, timeSpanSplitter.V3, timeSpanSplitter.V4, out value);
					goto IL_133;
				}
			}
			value = default(TimeSpan);
			flag = false;
			IL_133:
			if (!flag)
			{
				bytesConsumed = 0;
				return false;
			}
			return true;
		}

		// Token: 0x020003B1 RID: 945
		[Flags]
		private enum ParseNumberOptions
		{
			// Token: 0x04000CCE RID: 3278
			AllowExponent = 1
		}

		// Token: 0x020003B2 RID: 946
		private enum ComponentParseResult : byte
		{
			// Token: 0x04000CD0 RID: 3280
			NoMoreData,
			// Token: 0x04000CD1 RID: 3281
			Colon,
			// Token: 0x04000CD2 RID: 3282
			Period,
			// Token: 0x04000CD3 RID: 3283
			ParseFailure
		}

		// Token: 0x020003B3 RID: 947
		private struct TimeSpanSplitter
		{
			// Token: 0x06003DD0 RID: 15824 RVA: 0x000D18F8 File Offset: 0x000CFAF8
			public unsafe bool TrySplitTimeSpan(ReadOnlySpan<byte> source, bool periodUsedToSeparateDay, out int bytesConsumed)
			{
				int i = 0;
				byte b = 0;
				while (i < source.Length)
				{
					b = *source[i];
					if (b != 32 && b != 9)
					{
						break;
					}
					i++;
				}
				if (i == source.Length)
				{
					bytesConsumed = 0;
					return false;
				}
				if (b == 45)
				{
					this.IsNegative = true;
					i++;
					if (i == source.Length)
					{
						bytesConsumed = 0;
						return false;
					}
				}
				int num;
				if (!Utf8Parser.TryParseUInt32D(source.Slice(i), out this.V1, out num))
				{
					bytesConsumed = 0;
					return false;
				}
				i += num;
				Utf8Parser.ComponentParseResult componentParseResult = Utf8Parser.TimeSpanSplitter.ParseComponent(source, periodUsedToSeparateDay, ref i, out this.V2);
				if (componentParseResult == Utf8Parser.ComponentParseResult.ParseFailure)
				{
					bytesConsumed = 0;
					return false;
				}
				if (componentParseResult == Utf8Parser.ComponentParseResult.NoMoreData)
				{
					bytesConsumed = i;
					return true;
				}
				this.Separators |= (uint)((uint)componentParseResult << 24);
				componentParseResult = Utf8Parser.TimeSpanSplitter.ParseComponent(source, false, ref i, out this.V3);
				if (componentParseResult == Utf8Parser.ComponentParseResult.ParseFailure)
				{
					bytesConsumed = 0;
					return false;
				}
				if (componentParseResult == Utf8Parser.ComponentParseResult.NoMoreData)
				{
					bytesConsumed = i;
					return true;
				}
				this.Separators |= (uint)((uint)componentParseResult << 16);
				componentParseResult = Utf8Parser.TimeSpanSplitter.ParseComponent(source, false, ref i, out this.V4);
				if (componentParseResult == Utf8Parser.ComponentParseResult.ParseFailure)
				{
					bytesConsumed = 0;
					return false;
				}
				if (componentParseResult == Utf8Parser.ComponentParseResult.NoMoreData)
				{
					bytesConsumed = i;
					return true;
				}
				this.Separators |= (uint)((uint)componentParseResult << 8);
				componentParseResult = Utf8Parser.TimeSpanSplitter.ParseComponent(source, false, ref i, out this.V5);
				if (componentParseResult == Utf8Parser.ComponentParseResult.ParseFailure)
				{
					bytesConsumed = 0;
					return false;
				}
				if (componentParseResult == Utf8Parser.ComponentParseResult.NoMoreData)
				{
					bytesConsumed = i;
					return true;
				}
				this.Separators |= (uint)componentParseResult;
				if (i != source.Length && (*source[i] == 46 || *source[i] == 58))
				{
					bytesConsumed = 0;
					return false;
				}
				bytesConsumed = i;
				return true;
			}

			// Token: 0x06003DD1 RID: 15825 RVA: 0x000D1A6C File Offset: 0x000CFC6C
			private unsafe static Utf8Parser.ComponentParseResult ParseComponent(ReadOnlySpan<byte> source, bool neverParseAsFraction, ref int srcIndex, out uint value)
			{
				if (srcIndex == source.Length)
				{
					value = 0U;
					return Utf8Parser.ComponentParseResult.NoMoreData;
				}
				byte b = *source[srcIndex];
				if (b == 58 || (b == 46 && neverParseAsFraction))
				{
					srcIndex++;
					int num;
					if (!Utf8Parser.TryParseUInt32D(source.Slice(srcIndex), out value, out num))
					{
						value = 0U;
						return Utf8Parser.ComponentParseResult.ParseFailure;
					}
					srcIndex += num;
					if (b != 58)
					{
						return Utf8Parser.ComponentParseResult.Period;
					}
					return Utf8Parser.ComponentParseResult.Colon;
				}
				else
				{
					if (b != 46)
					{
						value = 0U;
						return Utf8Parser.ComponentParseResult.NoMoreData;
					}
					srcIndex++;
					int num2;
					if (!Utf8Parser.TryParseTimeSpanFraction(source.Slice(srcIndex), out value, out num2))
					{
						value = 0U;
						return Utf8Parser.ComponentParseResult.ParseFailure;
					}
					srcIndex += num2;
					return Utf8Parser.ComponentParseResult.Period;
				}
			}

			// Token: 0x04000CD4 RID: 3284
			public uint V1;

			// Token: 0x04000CD5 RID: 3285
			public uint V2;

			// Token: 0x04000CD6 RID: 3286
			public uint V3;

			// Token: 0x04000CD7 RID: 3287
			public uint V4;

			// Token: 0x04000CD8 RID: 3288
			public uint V5;

			// Token: 0x04000CD9 RID: 3289
			public bool IsNegative;

			// Token: 0x04000CDA RID: 3290
			public uint Separators;
		}
	}
}
