using System;
using System.Runtime.CompilerServices;
using Internal.Win32;

namespace System.Globalization
{
	// Token: 0x020002F8 RID: 760
	public class HijriCalendar : Calendar
	{
		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x000B5723 File Offset: 0x000B3923
		private static ReadOnlySpan<int> HijriMonthDays
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.93F28AF88A06482BE13F8D0354B6A7676DDAED573EA3938C50F6E53E6D6BB0B64).FieldHandle);
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06003749 RID: 14153 RVA: 0x000B572F File Offset: 0x000B392F
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return HijriCalendar.s_calendarMinValue;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x000B5736 File Offset: 0x000B3936
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return HijriCalendar.s_calendarMaxValue;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x0600374B RID: 14155 RVA: 0x000201B4 File Offset: 0x0001E3B4
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.LunarCalendar;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x0600374D RID: 14157 RVA: 0x0001FEB2 File Offset: 0x0001E0B2
		internal override CalendarId ID
		{
			get
			{
				return CalendarId.HIJRI;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x000B5750 File Offset: 0x000B3950
		protected override int DaysInYearBeforeMinSupportedYear
		{
			get
			{
				return 354;
			}
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x000B5758 File Offset: 0x000B3958
		private unsafe long GetAbsoluteDateHijri(int y, int m, int d)
		{
			return this.DaysUpToHijriYear(y) + (long)(*HijriCalendar.HijriMonthDays[m - 1]) + (long)d - 1L - (long)this.HijriAdjustment;
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x000B5790 File Offset: 0x000B3990
		private long DaysUpToHijriYear(int HijriYear)
		{
			int num = (HijriYear - 1) / 30 * 30;
			int i = HijriYear - num - 1;
			long num2 = (long)num * 10631L / 30L + 227013L;
			while (i > 0)
			{
				num2 += (long)(354 + ((this.IsLeapYear(i, 0) > false) ? 1 : 0));
				i--;
			}
			return num2;
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06003751 RID: 14161 RVA: 0x000B57E2 File Offset: 0x000B39E2
		// (set) Token: 0x06003752 RID: 14162 RVA: 0x000B5803 File Offset: 0x000B3A03
		public int HijriAdjustment
		{
			get
			{
				if (this._hijriAdvance == -2147483648)
				{
					this._hijriAdvance = this.GetHijriDateAdjustment();
				}
				return this._hijriAdvance;
			}
			set
			{
				if (value < -2 || value > 2)
				{
					throw new ArgumentOutOfRangeException("value", value, SR.Format(SR.ArgumentOutOfRange_Bounds_Lower_Upper, -2, 2));
				}
				base.VerifyWritable();
				this._hijriAdvance = value;
			}
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x000B5844 File Offset: 0x000B3A44
		internal static void CheckTicksRange(long ticks)
		{
			if (ticks < HijriCalendar.s_calendarMinValue.Ticks || ticks > HijriCalendar.s_calendarMaxValue.Ticks)
			{
				throw new ArgumentOutOfRangeException("time", ticks, SR.Format(CultureInfo.InvariantCulture, SR.ArgumentOutOfRange_CalendarRange, HijriCalendar.s_calendarMinValue, HijriCalendar.s_calendarMaxValue));
			}
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x000B589F File Offset: 0x000B3A9F
		internal static void CheckEraRange(int era)
		{
			if (era != 0 && era != HijriCalendar.HijriEra)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x000B58C2 File Offset: 0x000B3AC2
		internal static void CheckYearRange(int year, int era)
		{
			HijriCalendar.CheckEraRange(era);
			if (year < 1 || year > 9666)
			{
				throw new ArgumentOutOfRangeException("year", SR.Format(SR.ArgumentOutOfRange_Range, 1, 9666));
			}
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x000B58FC File Offset: 0x000B3AFC
		internal static void CheckYearMonthRange(int year, int month, int era)
		{
			HijriCalendar.CheckYearRange(year, era);
			if (year == 9666 && month > 4)
			{
				throw new ArgumentOutOfRangeException("month", month, SR.Format(SR.ArgumentOutOfRange_Range, 1, 4));
			}
			if (month < 1 || month > 12)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Month(month);
			}
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x000B5954 File Offset: 0x000B3B54
		private unsafe int GetDatePart(long ticks, int part)
		{
			HijriCalendar.CheckTicksRange(ticks);
			long num = ticks / 864000000000L + 1L;
			num += (long)this.HijriAdjustment;
			int num2 = (int)((num - 227013L) * 30L / 10631L) + 1;
			long num3 = this.DaysUpToHijriYear(num2);
			long num4 = (long)this.GetDaysInYear(num2, 0);
			if (num < num3)
			{
				num3 -= num4;
				num2--;
			}
			else if (num == num3)
			{
				num2--;
				num3 -= (long)this.GetDaysInYear(num2, 0);
			}
			else if (num > num3 + num4)
			{
				num3 += num4;
				num2++;
			}
			if (part == 0)
			{
				return num2;
			}
			int num5 = 1;
			num -= num3;
			if (part == 1)
			{
				return (int)num;
			}
			while (num5 <= 12 && num > (long)(*HijriCalendar.HijriMonthDays[num5 - 1]))
			{
				num5++;
			}
			num5--;
			if (part == 2)
			{
				return num5;
			}
			int result = (int)(num - (long)(*HijriCalendar.HijriMonthDays[num5 - 1]));
			if (part == 3)
			{
				return result;
			}
			throw new InvalidOperationException(SR.InvalidOperation_DateTimeParsing);
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x000B5A48 File Offset: 0x000B3C48
		public override DateTime AddMonths(DateTime time, int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", months, SR.Format(SR.ArgumentOutOfRange_Range, -120000, 120000));
			}
			int num = this.GetDatePart(time.Ticks, 0);
			int num2 = this.GetDatePart(time.Ticks, 2);
			int num3 = this.GetDatePart(time.Ticks, 3);
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
			int daysInMonth = this.GetDaysInMonth(num, num2);
			if (num3 > daysInMonth)
			{
				num3 = daysInMonth;
			}
			long ticks = this.GetAbsoluteDateHijri(num, num2, num3) * 864000000000L + time.Ticks % 864000000000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x000B3BD1 File Offset: 0x000B1DD1
		public override DateTime AddYears(DateTime time, int years)
		{
			return this.AddMonths(time, years * 12);
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x000B5B3D File Offset: 0x000B3D3D
		public override int GetDayOfMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 3);
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x000B3BE7 File Offset: 0x000B1DE7
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return time.DayOfWeek;
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x000B5B4D File Offset: 0x000B3D4D
		public override int GetDayOfYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 1);
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x000B5B5D File Offset: 0x000B3D5D
		public override int GetDaysInMonth(int year, int month, int era)
		{
			HijriCalendar.CheckYearMonthRange(year, month, era);
			if (month == 12)
			{
				if (!this.IsLeapYear(year, 0))
				{
					return 29;
				}
				return 30;
			}
			else
			{
				if (month % 2 != 1)
				{
					return 29;
				}
				return 30;
			}
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x000B5B87 File Offset: 0x000B3D87
		public override int GetDaysInYear(int year, int era)
		{
			HijriCalendar.CheckYearRange(year, era);
			if (!this.IsLeapYear(year, 0))
			{
				return 354;
			}
			return 355;
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x000B5BA5 File Offset: 0x000B3DA5
		public override int GetEra(DateTime time)
		{
			HijriCalendar.CheckTicksRange(time.Ticks);
			return HijriCalendar.HijriEra;
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06003760 RID: 14176 RVA: 0x000B5BB8 File Offset: 0x000B3DB8
		[Nullable(1)]
		public override int[] Eras
		{
			[NullableContext(1)]
			get
			{
				return new int[]
				{
					HijriCalendar.HijriEra
				};
			}
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x000B5BC8 File Offset: 0x000B3DC8
		public override int GetMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 2);
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x000B5BD8 File Offset: 0x000B3DD8
		public override int GetMonthsInYear(int year, int era)
		{
			HijriCalendar.CheckYearRange(year, era);
			return 12;
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x000B5BE3 File Offset: 0x000B3DE3
		public override int GetYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 0);
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x000B5BF4 File Offset: 0x000B3DF4
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			int daysInMonth = this.GetDaysInMonth(year, month, era);
			if (day < 1 || day > daysInMonth)
			{
				throw new ArgumentOutOfRangeException("day", day, SR.Format(SR.ArgumentOutOfRange_Day, daysInMonth, month));
			}
			return this.IsLeapYear(year, era) && month == 12 && day == 30;
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x000B5C52 File Offset: 0x000B3E52
		public override int GetLeapMonth(int year, int era)
		{
			HijriCalendar.CheckYearRange(year, era);
			return 0;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x000B5C5C File Offset: 0x000B3E5C
		public override bool IsLeapMonth(int year, int month, int era)
		{
			HijriCalendar.CheckYearMonthRange(year, month, era);
			return false;
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x000B5C67 File Offset: 0x000B3E67
		public override bool IsLeapYear(int year, int era)
		{
			HijriCalendar.CheckYearRange(year, era);
			return (year * 11 + 14) % 30 < 11;
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x000B5C80 File Offset: 0x000B3E80
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			int daysInMonth = this.GetDaysInMonth(year, month, era);
			if (day < 1 || day > daysInMonth)
			{
				throw new ArgumentOutOfRangeException("day", day, SR.Format(SR.ArgumentOutOfRange_Day, daysInMonth, month));
			}
			long absoluteDateHijri = this.GetAbsoluteDateHijri(year, month, day);
			if (absoluteDateHijri < 0L)
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadYearMonthDay);
			}
			return new DateTime(absoluteDateHijri * 864000000000L + Calendar.TimeToTicks(hour, minute, second, millisecond));
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06003769 RID: 14185 RVA: 0x000B5CFE File Offset: 0x000B3EFE
		// (set) Token: 0x0600376A RID: 14186 RVA: 0x000B5D28 File Offset: 0x000B3F28
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
				base.VerifyWritable();
				if (value < 99 || value > 9666)
				{
					throw new ArgumentOutOfRangeException("value", value, SR.Format(SR.ArgumentOutOfRange_Range, 99, 9666));
				}
				this._twoDigitYearMax = value;
			}
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x000B5D7C File Offset: 0x000B3F7C
		public override int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(year, "year");
			if (year < 100)
			{
				return base.ToFourDigitYear(year);
			}
			if (year > 9666)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, 1, 9666));
			}
			return year;
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x000B5DD5 File Offset: 0x000B3FD5
		private int GetHijriDateAdjustment()
		{
			if (this._hijriAdvance == -2147483648)
			{
				this._hijriAdvance = HijriCalendar.GetAdvanceHijriDate();
			}
			return this._hijriAdvance;
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x000B5DF8 File Offset: 0x000B3FF8
		private static int GetAdvanceHijriDate()
		{
			int result;
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\International"))
			{
				if (registryKey == null)
				{
					result = 0;
				}
				else
				{
					object value = registryKey.GetValue("AddHijriDate");
					if (value == null)
					{
						result = 0;
					}
					else
					{
						int num = 0;
						string text = value.ToString();
						if (string.Compare(text, 0, "AddHijriDate", 0, "AddHijriDate".Length, StringComparison.OrdinalIgnoreCase) == 0)
						{
							int num2;
							if (text.Length == "AddHijriDate".Length)
							{
								num = -1;
							}
							else if (int.TryParse(text.AsSpan("AddHijriDate".Length), CultureInfo.InvariantCulture, out num2) && num2 >= -2 && num2 <= 2)
							{
								num = num2;
							}
						}
						result = num;
					}
				}
			}
			return result;
		}

		// Token: 0x04000AD6 RID: 2774
		public static readonly int HijriEra = 1;

		// Token: 0x04000AD7 RID: 2775
		private int _hijriAdvance = int.MinValue;

		// Token: 0x04000AD8 RID: 2776
		private static readonly DateTime s_calendarMinValue = new DateTime(622, 7, 18);

		// Token: 0x04000AD9 RID: 2777
		private static readonly DateTime s_calendarMaxValue = DateTime.MaxValue;
	}
}
