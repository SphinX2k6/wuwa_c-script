using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x02000324 RID: 804
	[NullableContext(1)]
	[Nullable(0)]
	public class UmAlQuraCalendar : Calendar
	{
		// Token: 0x060039E4 RID: 14820 RVA: 0x000C09D4 File Offset: 0x000BEBD4
		private unsafe static UmAlQuraCalendar.DateMapping[] InitDateMapping()
		{
			ReadOnlySpan<short> readOnlySpan = RuntimeHelpers.CreateSpan<short>(fieldof(<PrivateImplementationDetails>.7BEC6AD454781FDCD8D475B3418629CBABB3BF9CA66FA80009D608A1A60D06962).FieldHandle);
			UmAlQuraCalendar.DateMapping[] array = new UmAlQuraCalendar.DateMapping[readOnlySpan.Length / 4];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new UmAlQuraCalendar.DateMapping((int)(*readOnlySpan[i * 4]), (int)(*readOnlySpan[i * 4 + 1]), (int)(*readOnlySpan[i * 4 + 2]), (int)(*readOnlySpan[i * 4 + 3]));
			}
			return array;
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060039E5 RID: 14821 RVA: 0x000C0A48 File Offset: 0x000BEC48
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return UmAlQuraCalendar.s_minDate;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x000C0A4F File Offset: 0x000BEC4F
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return UmAlQuraCalendar.s_maxDate;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060039E7 RID: 14823 RVA: 0x000201B4 File Offset: 0x0001E3B4
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.LunarCalendar;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060039E9 RID: 14825 RVA: 0x0001FEB2 File Offset: 0x0001E0B2
		internal override CalendarId BaseCalendarID
		{
			get
			{
				return CalendarId.HIJRI;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060039EA RID: 14826 RVA: 0x0003052A File Offset: 0x0002E72A
		internal override CalendarId ID
		{
			get
			{
				return CalendarId.UMALQURA;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060039EB RID: 14827 RVA: 0x000C0A56 File Offset: 0x000BEC56
		protected override int DaysInYearBeforeMinSupportedYear
		{
			get
			{
				return 355;
			}
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x000C0A60 File Offset: 0x000BEC60
		private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, out int yg, out int mg, out int dg)
		{
			int num = HijriDay - 1;
			int num2 = HijriYear - 1318;
			DateTime gregorianDate = UmAlQuraCalendar.s_hijriYearInfo[num2].GregorianDate;
			int num3 = UmAlQuraCalendar.s_hijriYearInfo[num2].HijriMonthsLengthFlags;
			for (int i = 1; i < HijriMonth; i++)
			{
				num = num + 29 + (num3 & 1);
				num3 >>= 1;
			}
			gregorianDate.AddDays((double)num).GetDate(out yg, out mg, out dg);
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x000C0AD0 File Offset: 0x000BECD0
		private static long GetAbsoluteDateUmAlQura(int year, int month, int day)
		{
			int year2;
			int month2;
			int day2;
			UmAlQuraCalendar.ConvertHijriToGregorian(year, month, day, out year2, out month2, out day2);
			return GregorianCalendar.GetAbsoluteDate(year2, month2, day2);
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x000C0AF4 File Offset: 0x000BECF4
		internal static void CheckTicksRange(long ticks)
		{
			if (ticks < UmAlQuraCalendar.s_minDate.Ticks || ticks > UmAlQuraCalendar.s_maxDate.Ticks)
			{
				throw new ArgumentOutOfRangeException("time", ticks, SR.Format(CultureInfo.InvariantCulture, SR.ArgumentOutOfRange_CalendarRange, UmAlQuraCalendar.s_minDate, UmAlQuraCalendar.s_maxDate));
			}
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x000C0B4F File Offset: 0x000BED4F
		internal static void CheckEraRange(int era)
		{
			if (era != 0 && era != 1)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x000C0B70 File Offset: 0x000BED70
		internal static void CheckYearRange(int year, int era)
		{
			UmAlQuraCalendar.CheckEraRange(era);
			if (year < 1318 || year > 1500)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, 1318, 1500));
			}
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x000C0BC2 File Offset: 0x000BEDC2
		internal static void CheckYearMonthRange(int year, int month, int era)
		{
			UmAlQuraCalendar.CheckYearRange(year, era);
			if (month < 1 || month > 12)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Month(month);
			}
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x000C0BDC File Offset: 0x000BEDDC
		private static void ConvertGregorianToHijri(DateTime time, out int HijriYear, out int HijriMonth, out int HijriDay)
		{
			int num = (int)((time.Ticks - UmAlQuraCalendar.s_minDate.Ticks) / 864000000000L) / 355;
			while (time.CompareTo(UmAlQuraCalendar.s_hijriYearInfo[++num].GregorianDate) > 0)
			{
			}
			if (time.CompareTo(UmAlQuraCalendar.s_hijriYearInfo[num].GregorianDate) != 0)
			{
				num--;
			}
			TimeSpan timeSpan = time.Subtract(UmAlQuraCalendar.s_hijriYearInfo[num].GregorianDate);
			int num2 = num + 1318;
			int num3 = 1;
			int num4 = 1;
			double num5 = timeSpan.TotalDays;
			int num6 = UmAlQuraCalendar.s_hijriYearInfo[num].HijriMonthsLengthFlags;
			int num7 = 29 + (num6 & 1);
			while (num5 >= (double)num7)
			{
				num5 -= (double)num7;
				num6 >>= 1;
				num7 = 29 + (num6 & 1);
				num3++;
			}
			num4 += (int)num5;
			HijriDay = num4;
			HijriMonth = num3;
			HijriYear = num2;
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x000C0CC8 File Offset: 0x000BEEC8
		private static int GetDatePart(DateTime time, int part)
		{
			UmAlQuraCalendar.CheckTicksRange(time.Ticks);
			int num;
			int num2;
			int num3;
			UmAlQuraCalendar.ConvertGregorianToHijri(time, out num, out num2, out num3);
			if (part == 0)
			{
				return num;
			}
			if (part == 2)
			{
				return num2;
			}
			if (part == 3)
			{
				return num3;
			}
			if (part == 1)
			{
				return (int)(UmAlQuraCalendar.GetAbsoluteDateUmAlQura(num, num2, num3) - UmAlQuraCalendar.GetAbsoluteDateUmAlQura(num, 1, 1) + 1L);
			}
			throw new InvalidOperationException(SR.InvalidOperation_DateTimeParsing);
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x000C0D24 File Offset: 0x000BEF24
		public override DateTime AddMonths(DateTime time, int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", months, SR.Format(SR.ArgumentOutOfRange_Range, -120000, 120000));
			}
			int num = UmAlQuraCalendar.GetDatePart(time, 0);
			int num2 = UmAlQuraCalendar.GetDatePart(time, 2);
			int num3 = UmAlQuraCalendar.GetDatePart(time, 3);
			int num4 = num2 - 1 + months;
			if (num4 >= 0)
			{
				num2 = num4 % 12 + 1;
				num += num4 / 12;
			}
			else
			{
				num2 = 12 + (num4 + 1) % 12;
				num += (num4 - 11) / 12;
			}
			if (num3 > 29)
			{
				int daysInMonth = this.GetDaysInMonth(num, num2);
				if (num3 > daysInMonth)
				{
					num3 = daysInMonth;
				}
			}
			UmAlQuraCalendar.CheckYearRange(num, 1);
			DateTime result = new DateTime(UmAlQuraCalendar.GetAbsoluteDateUmAlQura(num, num2, num3) * 864000000000L + time.Ticks % 864000000000L);
			Calendar.CheckAddResult(result.Ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return result;
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x000B3BD1 File Offset: 0x000B1DD1
		public override DateTime AddYears(DateTime time, int years)
		{
			return this.AddMonths(time, years * 12);
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x000C0E19 File Offset: 0x000BF019
		public override int GetDayOfMonth(DateTime time)
		{
			return UmAlQuraCalendar.GetDatePart(time, 3);
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x000B3BE7 File Offset: 0x000B1DE7
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return time.DayOfWeek;
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x000C0E22 File Offset: 0x000BF022
		public override int GetDayOfYear(DateTime time)
		{
			return UmAlQuraCalendar.GetDatePart(time, 1);
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x000C0E2B File Offset: 0x000BF02B
		public override int GetDaysInMonth(int year, int month, int era)
		{
			UmAlQuraCalendar.CheckYearMonthRange(year, month, era);
			if ((UmAlQuraCalendar.s_hijriYearInfo[year - 1318].HijriMonthsLengthFlags & 1 << month - 1) == 0)
			{
				return 29;
			}
			return 30;
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x000C0E5C File Offset: 0x000BF05C
		internal static int RealGetDaysInYear(int year)
		{
			int num = 0;
			int num2 = UmAlQuraCalendar.s_hijriYearInfo[year - 1318].HijriMonthsLengthFlags;
			for (int i = 1; i <= 12; i++)
			{
				num = num + 29 + (num2 & 1);
				num2 >>= 1;
			}
			return num;
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x000C0E9D File Offset: 0x000BF09D
		public override int GetDaysInYear(int year, int era)
		{
			UmAlQuraCalendar.CheckYearRange(year, era);
			return UmAlQuraCalendar.RealGetDaysInYear(year);
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x000C0EAC File Offset: 0x000BF0AC
		public override int GetEra(DateTime time)
		{
			UmAlQuraCalendar.CheckTicksRange(time.Ticks);
			return 1;
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x000A787E File Offset: 0x000A5A7E
		public override int[] Eras
		{
			get
			{
				return new int[]
				{
					1
				};
			}
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x000C0EBB File Offset: 0x000BF0BB
		public override int GetMonth(DateTime time)
		{
			return UmAlQuraCalendar.GetDatePart(time, 2);
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x000C0EC4 File Offset: 0x000BF0C4
		public override int GetMonthsInYear(int year, int era)
		{
			UmAlQuraCalendar.CheckYearRange(year, era);
			return 12;
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x000C0ECF File Offset: 0x000BF0CF
		public override int GetYear(DateTime time)
		{
			return UmAlQuraCalendar.GetDatePart(time, 0);
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x000C0ED8 File Offset: 0x000BF0D8
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			if (day >= 1 && day <= 29)
			{
				UmAlQuraCalendar.CheckYearMonthRange(year, month, era);
				return false;
			}
			int daysInMonth = this.GetDaysInMonth(year, month, era);
			if (day < 1 || day > daysInMonth)
			{
				throw new ArgumentOutOfRangeException("day", day, SR.Format(SR.ArgumentOutOfRange_Day, daysInMonth, month));
			}
			return false;
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x000C0F34 File Offset: 0x000BF134
		public override int GetLeapMonth(int year, int era)
		{
			UmAlQuraCalendar.CheckYearRange(year, era);
			return 0;
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x000C0F3E File Offset: 0x000BF13E
		public override bool IsLeapMonth(int year, int month, int era)
		{
			UmAlQuraCalendar.CheckYearMonthRange(year, month, era);
			return false;
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x000C0F49 File Offset: 0x000BF149
		public override bool IsLeapYear(int year, int era)
		{
			UmAlQuraCalendar.CheckYearRange(year, era);
			return UmAlQuraCalendar.RealGetDaysInYear(year) == 355;
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x000C0F60 File Offset: 0x000BF160
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			if (day >= 1 && day <= 29)
			{
				UmAlQuraCalendar.CheckYearMonthRange(year, month, era);
			}
			else
			{
				int daysInMonth = this.GetDaysInMonth(year, month, era);
				if (day < 1 || day > daysInMonth)
				{
					throw new ArgumentOutOfRangeException("day", day, SR.Format(SR.ArgumentOutOfRange_Day, daysInMonth, month));
				}
			}
			long absoluteDateUmAlQura = UmAlQuraCalendar.GetAbsoluteDateUmAlQura(year, month, day);
			if (absoluteDateUmAlQura < 0L)
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadYearMonthDay);
			}
			return new DateTime(absoluteDateUmAlQura * 864000000000L + Calendar.TimeToTicks(hour, minute, second, millisecond));
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06003A06 RID: 14854 RVA: 0x000B5CFE File Offset: 0x000B3EFE
		// (set) Token: 0x06003A07 RID: 14855 RVA: 0x000C0FF4 File Offset: 0x000BF1F4
		public override int TwoDigitYearMax
		{
			get
			{
				if (this._twoDigitYearMax == -1)
				{
					this._twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 1451);
				}
				return this._twoDigitYearMax;
			}
			set
			{
				if (value != 99 && (value < 1318 || value > 1500))
				{
					throw new ArgumentOutOfRangeException("value", value, SR.Format(SR.ArgumentOutOfRange_Range, 1318, 1500));
				}
				base.VerifyWritable();
				this._twoDigitYearMax = value;
			}
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x000C1054 File Offset: 0x000BF254
		public override int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(year, "year");
			if (year < 100)
			{
				return base.ToFourDigitYear(year);
			}
			if (year < 1318 || year > 1500)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, 1318, 1500));
			}
			return year;
		}

		// Token: 0x04000BAD RID: 2989
		private static readonly UmAlQuraCalendar.DateMapping[] s_hijriYearInfo = UmAlQuraCalendar.InitDateMapping();

		// Token: 0x04000BAE RID: 2990
		public const int UmAlQuraEra = 1;

		// Token: 0x04000BAF RID: 2991
		private static readonly DateTime s_minDate = new DateTime(1900, 4, 30);

		// Token: 0x04000BB0 RID: 2992
		private static readonly DateTime s_maxDate = new DateTime(new DateTime(2077, 11, 16, 23, 59, 59, 999).Ticks + 9999L);

		// Token: 0x02000325 RID: 805
		private readonly struct DateMapping
		{
			// Token: 0x06003A0A RID: 14858 RVA: 0x000C1117 File Offset: 0x000BF317
			internal DateMapping(int MonthsLengthFlags, int GYear, int GMonth, int GDay)
			{
				this.HijriMonthsLengthFlags = MonthsLengthFlags;
				this.GregorianDate = new DateTime(GYear, GMonth, GDay);
			}

			// Token: 0x04000BB1 RID: 2993
			internal readonly int HijriMonthsLengthFlags;

			// Token: 0x04000BB2 RID: 2994
			internal readonly DateTime GregorianDate;
		}
	}
}
