using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x02000309 RID: 777
	public class PersianCalendar : Calendar
	{
		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x060038BA RID: 14522 RVA: 0x000BBCC3 File Offset: 0x000B9EC3
		private static ReadOnlySpan<int> DaysToMonth
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.FC5B0FD4492EC7BC85845E312A7A1469DF87CA5BCA5B5B9E0B3030E6E11E48E64).FieldHandle);
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x060038BB RID: 14523 RVA: 0x000BBCCF File Offset: 0x000B9ECF
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return PersianCalendar.s_minDate;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x060038BC RID: 14524 RVA: 0x000BBCD6 File Offset: 0x000B9ED6
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return PersianCalendar.s_maxDate;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x060038BD RID: 14525 RVA: 0x000070DD File Offset: 0x000052DD
		public override CalendarAlgorithmType AlgorithmType
		{
			get
			{
				return CalendarAlgorithmType.SolarCalendar;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x060038BF RID: 14527 RVA: 0x000070DD File Offset: 0x000052DD
		internal override CalendarId BaseCalendarID
		{
			get
			{
				return CalendarId.GREGORIAN;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x060038C0 RID: 14528 RVA: 0x0003052E File Offset: 0x0002E72E
		internal override CalendarId ID
		{
			get
			{
				return CalendarId.PERSIAN;
			}
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x000BBCE0 File Offset: 0x000B9EE0
		private static long GetAbsoluteDatePersian(int year, int month, int day)
		{
			if (year < 1 || year > 9378 || month < 1 || month > 12)
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadYearMonthDay);
			}
			int num = PersianCalendar.DaysInPreviousMonths(month) + day - 1;
			int num2 = (int)(365.242189 * (double)(year - 1));
			return CalendricalCalculationsHelper.PersianNewYearOnOrBefore(PersianCalendar.s_persianEpoch + (long)num2 + 180L) + (long)num;
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x000BBD40 File Offset: 0x000B9F40
		internal static void CheckTicksRange(long ticks)
		{
			if (ticks < PersianCalendar.s_minDate.Ticks || ticks > PersianCalendar.s_maxDate.Ticks)
			{
				throw new ArgumentOutOfRangeException("time", ticks, SR.Format(SR.ArgumentOutOfRange_CalendarRange, PersianCalendar.s_minDate, PersianCalendar.s_maxDate));
			}
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x000BBD96 File Offset: 0x000B9F96
		internal static void CheckEraRange(int era)
		{
			if (era != 0 && era != PersianCalendar.PersianEra)
			{
				throw new ArgumentOutOfRangeException("era", era, SR.ArgumentOutOfRange_InvalidEraValue);
			}
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x000BBDB9 File Offset: 0x000B9FB9
		internal static void CheckYearRange(int year, int era)
		{
			PersianCalendar.CheckEraRange(era);
			if (year < 1 || year > 9378)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, 1, 9378));
			}
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x000BBDF8 File Offset: 0x000B9FF8
		internal static void CheckYearMonthRange(int year, int month, int era)
		{
			PersianCalendar.CheckYearRange(year, era);
			if (year == 9378 && month > 10)
			{
				throw new ArgumentOutOfRangeException("month", month, SR.Format(SR.ArgumentOutOfRange_Range, 1, 10));
			}
			if (month < 1 || month > 12)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Month(month);
			}
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x000BBE50 File Offset: 0x000BA050
		private unsafe static int MonthFromOrdinalDay(int ordinalDay)
		{
			int num = 0;
			while (ordinalDay > *PersianCalendar.DaysToMonth[num])
			{
				num++;
			}
			return num;
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x000BBE78 File Offset: 0x000BA078
		private unsafe static int DaysInPreviousMonths(int month)
		{
			month--;
			return *PersianCalendar.DaysToMonth[month];
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x000BBE9C File Offset: 0x000BA09C
		private int GetDatePart(long ticks, int part)
		{
			PersianCalendar.CheckTicksRange(ticks);
			long num = ticks / 864000000000L + 1L;
			int num2 = (int)Math.Floor((double)(CalendricalCalculationsHelper.PersianNewYearOnOrBefore(num) - PersianCalendar.s_persianEpoch) / 365.242189 + 0.5) + 1;
			if (part == 0)
			{
				return num2;
			}
			int num3 = (int)(num - CalendricalCalculationsHelper.GetNumberOfDays(this.ToDateTime(num2, 1, 1, 0, 0, 0, 0, 1)));
			if (part == 1)
			{
				return num3;
			}
			int num4 = PersianCalendar.MonthFromOrdinalDay(num3);
			if (part == 2)
			{
				return num4;
			}
			int result = num3 - PersianCalendar.DaysInPreviousMonths(num4);
			if (part == 3)
			{
				return result;
			}
			throw new InvalidOperationException(SR.InvalidOperation_DateTimeParsing);
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x000BBF34 File Offset: 0x000BA134
		internal void GetDate(long ticks, out int year, out int month, out int day)
		{
			PersianCalendar.CheckTicksRange(ticks);
			long num = ticks / 864000000000L + 1L;
			long num2 = CalendricalCalculationsHelper.PersianNewYearOnOrBefore(num);
			year = (int)Math.Floor((double)(num2 - PersianCalendar.s_persianEpoch) / 365.242189 + 0.5) + 1;
			int num3 = (int)(num - CalendricalCalculationsHelper.GetNumberOfDays(this.ToDateTime(year, 1, 1, 0, 0, 0, 0, 1)));
			month = PersianCalendar.MonthFromOrdinalDay(num3);
			day = num3 - PersianCalendar.DaysInPreviousMonths(month);
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x000BBFB0 File Offset: 0x000BA1B0
		public override DateTime AddMonths(DateTime time, int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", months, SR.Format(SR.ArgumentOutOfRange_Range, -120000, 120000));
			}
			int num;
			int num2;
			int num3;
			this.GetDate(time.Ticks, out num, out num2, out num3);
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
			long ticks = PersianCalendar.GetAbsoluteDatePersian(num, num2, num3) * 864000000000L + time.Ticks % 864000000000L;
			Calendar.CheckAddResult(ticks, this.MinSupportedDateTime, this.MaxSupportedDateTime);
			return new DateTime(ticks);
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x000B3BD1 File Offset: 0x000B1DD1
		public override DateTime AddYears(DateTime time, int years)
		{
			return this.AddMonths(time, years * 12);
		}

		// Token: 0x060038CC RID: 14540 RVA: 0x000BC08A File Offset: 0x000BA28A
		public override int GetDayOfMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 3);
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x000B3BE7 File Offset: 0x000B1DE7
		public override DayOfWeek GetDayOfWeek(DateTime time)
		{
			return time.DayOfWeek;
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x000BC09A File Offset: 0x000BA29A
		public override int GetDayOfYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 1);
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x000BC0AC File Offset: 0x000BA2AC
		public unsafe override int GetDaysInMonth(int year, int month, int era)
		{
			PersianCalendar.CheckYearMonthRange(year, month, era);
			if (month == 10 && year == 9378)
			{
				return 13;
			}
			int num = *PersianCalendar.DaysToMonth[month] - *PersianCalendar.DaysToMonth[month - 1];
			if (month == 12 && !this.IsLeapYear(year))
			{
				num--;
			}
			return num;
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x000BC108 File Offset: 0x000BA308
		public unsafe override int GetDaysInYear(int year, int era)
		{
			PersianCalendar.CheckYearRange(year, era);
			if (year == 9378)
			{
				return *PersianCalendar.DaysToMonth[9] + 13;
			}
			if (!this.IsLeapYear(year, 0))
			{
				return 365;
			}
			return 366;
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x000BC14D File Offset: 0x000BA34D
		public override int GetEra(DateTime time)
		{
			PersianCalendar.CheckTicksRange(time.Ticks);
			return PersianCalendar.PersianEra;
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x060038D2 RID: 14546 RVA: 0x000BC160 File Offset: 0x000BA360
		[Nullable(1)]
		public override int[] Eras
		{
			[NullableContext(1)]
			get
			{
				return new int[]
				{
					PersianCalendar.PersianEra
				};
			}
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x000BC170 File Offset: 0x000BA370
		public override int GetMonth(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 2);
		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x000BC180 File Offset: 0x000BA380
		public override int GetMonthsInYear(int year, int era)
		{
			PersianCalendar.CheckYearRange(year, era);
			if (year == 9378)
			{
				return 10;
			}
			return 12;
		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x000BC196 File Offset: 0x000BA396
		public override int GetYear(DateTime time)
		{
			return this.GetDatePart(time.Ticks, 0);
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x000BC1A8 File Offset: 0x000BA3A8
		public override bool IsLeapDay(int year, int month, int day, int era)
		{
			int daysInMonth = this.GetDaysInMonth(year, month, era);
			if (day < 1 || day > daysInMonth)
			{
				throw new ArgumentOutOfRangeException("day", day, SR.Format(SR.ArgumentOutOfRange_Day, daysInMonth, month));
			}
			return this.IsLeapYear(year, era) && month == 12 && day == 30;
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x000BC206 File Offset: 0x000BA406
		public override int GetLeapMonth(int year, int era)
		{
			PersianCalendar.CheckYearRange(year, era);
			return 0;
		}

		// Token: 0x060038D8 RID: 14552 RVA: 0x000BC210 File Offset: 0x000BA410
		public override bool IsLeapMonth(int year, int month, int era)
		{
			PersianCalendar.CheckYearMonthRange(year, month, era);
			return false;
		}

		// Token: 0x060038D9 RID: 14553 RVA: 0x000BC21B File Offset: 0x000BA41B
		public override bool IsLeapYear(int year, int era)
		{
			PersianCalendar.CheckYearRange(year, era);
			return year != 9378 && PersianCalendar.GetAbsoluteDatePersian(year + 1, 1, 1) - PersianCalendar.GetAbsoluteDatePersian(year, 1, 1) == 366L;
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x000BC24C File Offset: 0x000BA44C
		public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
		{
			int daysInMonth = this.GetDaysInMonth(year, month, era);
			if (day < 1 || day > daysInMonth)
			{
				throw new ArgumentOutOfRangeException("day", day, SR.Format(SR.ArgumentOutOfRange_Day, daysInMonth, month));
			}
			long absoluteDatePersian = PersianCalendar.GetAbsoluteDatePersian(year, month, day);
			if (absoluteDatePersian < 0L)
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadYearMonthDay);
			}
			return new DateTime(absoluteDatePersian * 864000000000L + Calendar.TimeToTicks(hour, minute, second, millisecond));
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x060038DB RID: 14555 RVA: 0x000BC2C9 File Offset: 0x000BA4C9
		// (set) Token: 0x060038DC RID: 14556 RVA: 0x000BC2F0 File Offset: 0x000BA4F0
		public override int TwoDigitYearMax
		{
			get
			{
				if (this._twoDigitYearMax == -1)
				{
					this._twoDigitYearMax = Calendar.GetSystemTwoDigitYearSetting(this.ID, 1410);
				}
				return this._twoDigitYearMax;
			}
			set
			{
				base.VerifyWritable();
				if (value < 99 || value > 9378)
				{
					throw new ArgumentOutOfRangeException("value", value, SR.Format(SR.ArgumentOutOfRange_Range, 99, 9378));
				}
				this._twoDigitYearMax = value;
			}
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x000BC344 File Offset: 0x000BA544
		public override int ToFourDigitYear(int year)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(year, "year");
			if (year < 100)
			{
				return base.ToFourDigitYear(year);
			}
			if (year > 9378)
			{
				throw new ArgumentOutOfRangeException("year", year, SR.Format(SR.ArgumentOutOfRange_Range, 1, 9378));
			}
			return year;
		}

		// Token: 0x04000B3F RID: 2879
		public static readonly int PersianEra = 1;

		// Token: 0x04000B40 RID: 2880
		private static readonly long s_persianEpoch = new DateTime(622, 3, 22).Ticks / 864000000000L;

		// Token: 0x04000B41 RID: 2881
		private static readonly DateTime s_minDate = new DateTime(622, 3, 22);

		// Token: 0x04000B42 RID: 2882
		private static readonly DateTime s_maxDate = DateTime.MaxValue;
	}
}
