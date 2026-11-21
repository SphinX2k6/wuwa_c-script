using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000F2 RID: 242
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public readonly struct DateTimeOffset : IComparable, ISpanFormattable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanParsable<DateTimeOffset>, IParsable<DateTimeOffset>, IUtf8SpanFormattable
	{
		// Token: 0x06000EA0 RID: 3744 RVA: 0x00027B5A File Offset: 0x00025D5A
		private DateTimeOffset(short validOffsetMinutes, DateTime validDateTime)
		{
			this._dateTime = validDateTime;
			this._offsetMinutes = validOffsetMinutes;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00027B6A File Offset: 0x00025D6A
		public DateTimeOffset(long ticks, TimeSpan offset)
		{
			this = new DateTimeOffset(DateTimeOffset.ValidateOffset(offset), DateTimeOffset.ValidateDate(new DateTime(ticks), offset));
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00027B84 File Offset: 0x00025D84
		public DateTimeOffset(DateTime dateTime)
		{
			TimeSpan localUtcOffset;
			if (dateTime.Kind != DateTimeKind.Utc)
			{
				localUtcOffset = TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			}
			else
			{
				localUtcOffset = new TimeSpan(0L);
			}
			this._offsetMinutes = DateTimeOffset.ValidateOffset(localUtcOffset);
			this._dateTime = DateTimeOffset.ValidateDate(dateTime, localUtcOffset);
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00027BC8 File Offset: 0x00025DC8
		public DateTimeOffset(DateTime dateTime, TimeSpan offset)
		{
			if (dateTime.Kind == DateTimeKind.Local)
			{
				if (offset != TimeZoneInfo.GetLocalUtcOffset(dateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime))
				{
					throw new ArgumentException(SR.Argument_OffsetLocalMismatch, "offset");
				}
			}
			else if (dateTime.Kind == DateTimeKind.Utc && offset != TimeSpan.Zero)
			{
				throw new ArgumentException(SR.Argument_OffsetUtcMismatch, "offset");
			}
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			this._dateTime = DateTimeOffset.ValidateDate(dateTime, offset);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00027C3E File Offset: 0x00025E3E
		public DateTimeOffset(DateOnly date, TimeOnly time, TimeSpan offset)
		{
			this = new DateTimeOffset(new DateTime(date, time), offset);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00027C50 File Offset: 0x00025E50
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset)
		{
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			int num = second;
			if (second == 60 && DateTime.SystemSupportsLeapSeconds)
			{
				second = 59;
			}
			this._dateTime = DateTimeOffset.ValidateDate(new DateTime(year, month, day, hour, minute, second), offset);
			if (num == 60 && !DateTime.IsValidTimeWithLeapSeconds(this._dateTime.Year, this._dateTime.Month, this._dateTime.Day, this._dateTime.Hour, this._dateTime.Minute, DateTimeKind.Utc))
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadHourMinuteSecond);
			}
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00027CE8 File Offset: 0x00025EE8
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset)
		{
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			int num = second;
			if (second == 60 && DateTime.SystemSupportsLeapSeconds)
			{
				second = 59;
			}
			this._dateTime = DateTimeOffset.ValidateDate(new DateTime(year, month, day, hour, minute, second, millisecond), offset);
			if (num == 60 && !DateTime.IsValidTimeWithLeapSeconds(this._dateTime.Year, this._dateTime.Month, this._dateTime.Day, this._dateTime.Hour, this._dateTime.Minute, DateTimeKind.Utc))
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadHourMinuteSecond);
			}
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00027D84 File Offset: 0x00025F84
		[NullableContext(1)]
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset)
		{
			this._offsetMinutes = DateTimeOffset.ValidateOffset(offset);
			int num = second;
			if (second == 60 && DateTime.SystemSupportsLeapSeconds)
			{
				second = 59;
			}
			this._dateTime = DateTimeOffset.ValidateDate(new DateTime(year, month, day, hour, minute, second, millisecond, calendar), offset);
			if (num == 60 && !DateTime.IsValidTimeWithLeapSeconds(this._dateTime.Year, this._dateTime.Month, this._dateTime.Day, this._dateTime.Hour, this._dateTime.Minute, DateTimeKind.Utc))
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_BadHourMinuteSecond);
			}
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00027E20 File Offset: 0x00026020
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond, TimeSpan offset)
		{
			this = new DateTimeOffset(year, month, day, hour, minute, second, millisecond, offset);
			if ((ulong)microsecond >= 1000UL)
			{
				throw new ArgumentOutOfRangeException("microsecond", SR.ArgumentOutOfRange_BadHourMinuteSecond);
			}
			this._dateTime = this._dateTime.AddMicroseconds((double)microsecond);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00027E70 File Offset: 0x00026070
		[NullableContext(1)]
		public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond, Calendar calendar, TimeSpan offset)
		{
			this = new DateTimeOffset(year, month, day, hour, minute, second, millisecond, calendar, offset);
			if ((ulong)microsecond >= 1000UL)
			{
				throw new ArgumentOutOfRangeException("microsecond", SR.ArgumentOutOfRange_BadHourMinuteSecond);
			}
			this._dateTime = this._dateTime.AddMicroseconds((double)microsecond);
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x00027EC4 File Offset: 0x000260C4
		public static DateTimeOffset UtcNow
		{
			get
			{
				DateTime utcNow = DateTime.UtcNow;
				return new DateTimeOffset(0, utcNow);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00027EDE File Offset: 0x000260DE
		public DateTime DateTime
		{
			get
			{
				return this.ClockDateTime;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x00027EE6 File Offset: 0x000260E6
		public DateTime UtcDateTime
		{
			get
			{
				return DateTime.SpecifyKind(this._dateTime, DateTimeKind.Utc);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00027EF4 File Offset: 0x000260F4
		public DateTime LocalDateTime
		{
			get
			{
				return this.UtcDateTime.ToLocalTime();
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00027F10 File Offset: 0x00026110
		public DateTimeOffset ToOffset(TimeSpan offset)
		{
			return new DateTimeOffset((this._dateTime + offset).Ticks, offset);
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00027F38 File Offset: 0x00026138
		private DateTime ClockDateTime
		{
			get
			{
				return new DateTime((this._dateTime + this.Offset).Ticks, DateTimeKind.Unspecified);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x00027F64 File Offset: 0x00026164
		public DateTime Date
		{
			get
			{
				return this.ClockDateTime.Date;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x00027F80 File Offset: 0x00026180
		public int Day
		{
			get
			{
				return this.ClockDateTime.Day;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x00027F9C File Offset: 0x0002619C
		public DayOfWeek DayOfWeek
		{
			get
			{
				return this.ClockDateTime.DayOfWeek;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x00027FB8 File Offset: 0x000261B8
		public int DayOfYear
		{
			get
			{
				return this.ClockDateTime.DayOfYear;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x00027FD4 File Offset: 0x000261D4
		public int Hour
		{
			get
			{
				return this.ClockDateTime.Hour;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x00027FF0 File Offset: 0x000261F0
		public int Millisecond
		{
			get
			{
				return this.ClockDateTime.Millisecond;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0002800C File Offset: 0x0002620C
		public int Microsecond
		{
			get
			{
				return this.ClockDateTime.Microsecond;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00028028 File Offset: 0x00026228
		public int Nanosecond
		{
			get
			{
				return this.ClockDateTime.Nanosecond;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00028044 File Offset: 0x00026244
		public int Minute
		{
			get
			{
				return this.ClockDateTime.Minute;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00028060 File Offset: 0x00026260
		public int Month
		{
			get
			{
				return this.ClockDateTime.Month;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0002807B File Offset: 0x0002627B
		public TimeSpan Offset
		{
			get
			{
				return new TimeSpan(0, (int)this._offsetMinutes, 0);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0002808A File Offset: 0x0002628A
		public int TotalOffsetMinutes
		{
			get
			{
				return (int)this._offsetMinutes;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00028094 File Offset: 0x00026294
		public int Second
		{
			get
			{
				return this.ClockDateTime.Second;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x000280B0 File Offset: 0x000262B0
		public long Ticks
		{
			get
			{
				return this.ClockDateTime.Ticks;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x000280CC File Offset: 0x000262CC
		public long UtcTicks
		{
			get
			{
				return this.UtcDateTime.Ticks;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x000280E8 File Offset: 0x000262E8
		public TimeSpan TimeOfDay
		{
			get
			{
				return this.ClockDateTime.TimeOfDay;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00028104 File Offset: 0x00026304
		public int Year
		{
			get
			{
				return this.ClockDateTime.Year;
			}
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00028120 File Offset: 0x00026320
		public DateTimeOffset Add(TimeSpan timeSpan)
		{
			return new DateTimeOffset(this.ClockDateTime.Add(timeSpan), this.Offset);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00028148 File Offset: 0x00026348
		public DateTimeOffset AddDays(double days)
		{
			return new DateTimeOffset(this.ClockDateTime.AddDays(days), this.Offset);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00028170 File Offset: 0x00026370
		public DateTimeOffset AddHours(double hours)
		{
			return new DateTimeOffset(this.ClockDateTime.AddHours(hours), this.Offset);
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00028198 File Offset: 0x00026398
		public DateTimeOffset AddMilliseconds(double milliseconds)
		{
			return new DateTimeOffset(this.ClockDateTime.AddMilliseconds(milliseconds), this.Offset);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000281C0 File Offset: 0x000263C0
		public DateTimeOffset AddMicroseconds(double microseconds)
		{
			return new DateTimeOffset(this.ClockDateTime.AddMicroseconds(microseconds), this.Offset);
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000281E8 File Offset: 0x000263E8
		public DateTimeOffset AddMinutes(double minutes)
		{
			return new DateTimeOffset(this.ClockDateTime.AddMinutes(minutes), this.Offset);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00028210 File Offset: 0x00026410
		public DateTimeOffset AddMonths(int months)
		{
			return new DateTimeOffset(this.ClockDateTime.AddMonths(months), this.Offset);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00028238 File Offset: 0x00026438
		public DateTimeOffset AddSeconds(double seconds)
		{
			return new DateTimeOffset(this.ClockDateTime.AddSeconds(seconds), this.Offset);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00028260 File Offset: 0x00026460
		public DateTimeOffset AddTicks(long ticks)
		{
			return new DateTimeOffset(this.ClockDateTime.AddTicks(ticks), this.Offset);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00028288 File Offset: 0x00026488
		public DateTimeOffset AddYears(int years)
		{
			return new DateTimeOffset(this.ClockDateTime.AddYears(years), this.Offset);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000282AF File Offset: 0x000264AF
		public static int Compare(DateTimeOffset first, DateTimeOffset second)
		{
			return DateTime.Compare(first.UtcDateTime, second.UtcDateTime);
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000282C4 File Offset: 0x000264C4
		int IComparable.CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (obj is DateTimeOffset)
			{
				DateTimeOffset dateTimeOffset = (DateTimeOffset)obj;
				return DateTime.Compare(this.UtcDateTime, dateTimeOffset.UtcDateTime);
			}
			throw new ArgumentException(SR.Arg_MustBeDateTimeOffset);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00028304 File Offset: 0x00026504
		public int CompareTo(DateTimeOffset other)
		{
			return DateTime.Compare(this.UtcDateTime, other.UtcDateTime);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00028318 File Offset: 0x00026518
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is DateTimeOffset && this.UtcDateTime.Equals(((DateTimeOffset)obj).UtcDateTime);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0002834C File Offset: 0x0002654C
		public bool Equals(DateTimeOffset other)
		{
			return this.UtcDateTime.Equals(other.UtcDateTime);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00028370 File Offset: 0x00026570
		public bool EqualsExact(DateTimeOffset other)
		{
			return this.ClockDateTime == other.ClockDateTime && this.Offset == other.Offset && this.ClockDateTime.Kind == other.ClockDateTime.Kind;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000283C6 File Offset: 0x000265C6
		public static bool Equals(DateTimeOffset first, DateTimeOffset second)
		{
			return DateTime.Equals(first.UtcDateTime, second.UtcDateTime);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x000283DB File Offset: 0x000265DB
		public static DateTimeOffset FromFileTime(long fileTime)
		{
			return DateTimeOffset.ToLocalTime(DateTime.FromFileTimeUtc(fileTime), true);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x000283EC File Offset: 0x000265EC
		public static DateTimeOffset FromUnixTimeSeconds(long seconds)
		{
			if (seconds < -62135596800L || seconds > 253402300799L)
			{
				throw new ArgumentOutOfRangeException("seconds", SR.Format(SR.ArgumentOutOfRange_Range, -62135596800L, 253402300799L));
			}
			return new DateTimeOffset(seconds * 10000000L + 621355968000000000L, TimeSpan.Zero);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00028460 File Offset: 0x00026660
		public static DateTimeOffset FromUnixTimeMilliseconds(long milliseconds)
		{
			if (milliseconds < -62135596800000L || milliseconds > 253402300799999L)
			{
				throw new ArgumentOutOfRangeException("milliseconds", SR.Format(SR.ArgumentOutOfRange_Range, -62135596800000L, 253402300799999L));
			}
			return new DateTimeOffset(milliseconds * 10000L + 621355968000000000L, TimeSpan.Zero);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x000284D4 File Offset: 0x000266D4
		void IDeserializationCallback.OnDeserialization(object sender)
		{
			try
			{
				DateTimeOffset.ValidateOffset(this.Offset);
				DateTimeOffset.ValidateDate(this.ClockDateTime, this.Offset);
			}
			catch (ArgumentException innerException)
			{
				throw new SerializationException(SR.Serialization_InvalidData, innerException);
			}
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00028520 File Offset: 0x00026720
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			info.AddValue("DateTime", this._dateTime);
			info.AddValue("OffsetMinutes", this._offsetMinutes);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00028550 File Offset: 0x00026750
		private DateTimeOffset(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			this._dateTime = (DateTime)info.GetValue("DateTime", typeof(DateTime));
			this._offsetMinutes = (short)info.GetValue("OffsetMinutes", typeof(short));
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000285A8 File Offset: 0x000267A8
		public override int GetHashCode()
		{
			return this.UtcDateTime.GetHashCode();
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x000285C4 File Offset: 0x000267C4
		[NullableContext(1)]
		public static DateTimeOffset Parse(string input)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.Parse(input, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out offset).Ticks, offset);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x000285FC File Offset: 0x000267FC
		[NullableContext(1)]
		public static DateTimeOffset Parse(string input, [Nullable(2)] IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			return DateTimeOffset.Parse(input, formatProvider, DateTimeStyles.None);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00028610 File Offset: 0x00026810
		[NullableContext(1)]
		public static DateTimeOffset Parse(string input, [Nullable(2)] IFormatProvider formatProvider, DateTimeStyles styles)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.Parse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00028658 File Offset: 0x00026858
		public static DateTimeOffset Parse(ReadOnlySpan<char> input, [Nullable(2)] IFormatProvider formatProvider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.Parse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0002868F File Offset: 0x0002688F
		[NullableContext(1)]
		public static DateTimeOffset ParseExact(string input, [StringSyntax("DateTimeFormat")] string format, [Nullable(2)] IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			return DateTimeOffset.ParseExact(input, format, formatProvider, DateTimeStyles.None);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x000286B0 File Offset: 0x000268B0
		[NullableContext(1)]
		public static DateTimeOffset ParseExact(string input, [StringSyntax("DateTimeFormat")] string format, [Nullable(2)] IFormatProvider formatProvider, DateTimeStyles styles)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.ParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00028708 File Offset: 0x00026908
		public static DateTimeOffset ParseExact(ReadOnlySpan<char> input, [StringSyntax("DateTimeFormat")] ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider formatProvider, DateTimeStyles styles = DateTimeStyles.None)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.ParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00028740 File Offset: 0x00026940
		[NullableContext(1)]
		public static DateTimeOffset ParseExact(string input, [StringSyntax("DateTimeFormat")] string[] formats, [Nullable(2)] IFormatProvider formatProvider, DateTimeStyles styles)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.ParseExactMultiple(input, formats, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00028788 File Offset: 0x00026988
		public static DateTimeOffset ParseExact(ReadOnlySpan<char> input, [Nullable(1)] [StringSyntax("DateTimeFormat")] string[] formats, [Nullable(2)] IFormatProvider formatProvider, DateTimeStyles styles = DateTimeStyles.None)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			TimeSpan offset;
			return new DateTimeOffset(DateTimeParse.ParseExactMultiple(input, formats, DateTimeFormatInfo.GetInstance(formatProvider), styles, out offset).Ticks, offset);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000287C0 File Offset: 0x000269C0
		public TimeSpan Subtract(DateTimeOffset value)
		{
			return this.UtcDateTime.Subtract(value.UtcDateTime);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x000287E4 File Offset: 0x000269E4
		public DateTimeOffset Subtract(TimeSpan value)
		{
			return new DateTimeOffset(this.ClockDateTime.Subtract(value), this.Offset);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0002880C File Offset: 0x00026A0C
		public long ToFileTime()
		{
			return this.UtcDateTime.ToFileTime();
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00028828 File Offset: 0x00026A28
		public long ToUnixTimeSeconds()
		{
			return this.UtcDateTime.Ticks / 10000000L - 62135596800L;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00028854 File Offset: 0x00026A54
		public long ToUnixTimeMilliseconds()
		{
			return this.UtcDateTime.Ticks / 10000L - 62135596800000L;
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00028880 File Offset: 0x00026A80
		public DateTimeOffset ToLocalTime()
		{
			return this.ToLocalTime(false);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00028889 File Offset: 0x00026A89
		internal DateTimeOffset ToLocalTime(bool throwOnOverflow)
		{
			return DateTimeOffset.ToLocalTime(this.UtcDateTime, throwOnOverflow);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00028898 File Offset: 0x00026A98
		private static DateTimeOffset ToLocalTime(DateTime utcDateTime, bool throwOnOverflow)
		{
			TimeSpan localUtcOffset = TimeZoneInfo.GetLocalUtcOffset(utcDateTime, TimeZoneInfoOptions.NoThrowOnInvalidTime);
			long num = utcDateTime.Ticks + localUtcOffset.Ticks;
			if (num < 0L || num > 3155378975999999999L)
			{
				if (throwOnOverflow)
				{
					throw new ArgumentException(SR.Arg_ArgumentOutOfRangeException);
				}
				num = ((num < 0L) ? 0L : 3155378975999999999L);
			}
			return new DateTimeOffset(num, localUtcOffset);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x000288F6 File Offset: 0x00026AF6
		[NullableContext(1)]
		public override string ToString()
		{
			return DateTimeFormat.Format(this.ClockDateTime, null, null, this.Offset);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0002890B File Offset: 0x00026B0B
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("DateTimeFormat")] string format)
		{
			return DateTimeFormat.Format(this.ClockDateTime, format, null, this.Offset);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00028920 File Offset: 0x00026B20
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider formatProvider)
		{
			return DateTimeFormat.Format(this.ClockDateTime, null, formatProvider, this.Offset);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00028935 File Offset: 0x00026B35
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("DateTimeFormat")] string format, IFormatProvider formatProvider)
		{
			return DateTimeFormat.Format(this.ClockDateTime, format, formatProvider, this.Offset);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0002894A File Offset: 0x00026B4A
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("DateTimeFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider formatProvider = null)
		{
			return DateTimeFormat.TryFormat<char>(this.ClockDateTime, destination, out charsWritten, format, formatProvider, this.Offset);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00028962 File Offset: 0x00026B62
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("DateTimeFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider formatProvider = null)
		{
			return DateTimeFormat.TryFormat<byte>(this.ClockDateTime, utf8Destination, out bytesWritten, format, formatProvider, this.Offset);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0002897A File Offset: 0x00026B7A
		public DateTimeOffset ToUniversalTime()
		{
			return new DateTimeOffset(this.UtcDateTime);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00028988 File Offset: 0x00026B88
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string input, out DateTimeOffset result)
		{
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParse(input, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x000289C0 File Offset: 0x00026BC0
		public static bool TryParse(ReadOnlySpan<char> input, out DateTimeOffset result)
		{
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParse(input, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000289F0 File Offset: 0x00026BF0
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				result = default(DateTimeOffset);
				return false;
			}
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00028A40 File Offset: 0x00026C40
		public static bool TryParse(ReadOnlySpan<char> input, [Nullable(2)] IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParse(input, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00028A80 File Offset: 0x00026C80
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string input, [NotNullWhen(true)] [StringSyntax("DateTimeFormat")] string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null || format == null)
			{
				result = default(DateTimeOffset);
				return false;
			}
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00028ADC File Offset: 0x00026CDC
		public static bool TryParseExact(ReadOnlySpan<char> input, [StringSyntax("DateTimeFormat")] ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParseExact(input, format, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00028B1C File Offset: 0x00026D1C
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string input, [NotNullWhen(true)] [StringSyntax("DateTimeFormat")] string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			if (input == null)
			{
				result = default(DateTimeOffset);
				return false;
			}
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParseExactMultiple(input, formats, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00028B70 File Offset: 0x00026D70
		[NullableContext(2)]
		public static bool TryParseExact([Nullable(0)] ReadOnlySpan<char> input, [NotNullWhen(true)] [StringSyntax("DateTimeFormat")] string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
		{
			styles = DateTimeOffset.ValidateStyles(styles, "styles");
			DateTime dateTime;
			TimeSpan offset;
			bool result2 = DateTimeParse.TryParseExactMultiple(input, formats, DateTimeFormatInfo.GetInstance(formatProvider), styles, out dateTime, out offset);
			result = new DateTimeOffset(dateTime.Ticks, offset);
			return result2;
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00028BB0 File Offset: 0x00026DB0
		private static short ValidateOffset(TimeSpan offset)
		{
			long ticks = offset.Ticks;
			if (ticks % 600000000L != 0L)
			{
				throw new ArgumentException(SR.Argument_OffsetPrecision, "offset");
			}
			if (ticks < -504000000000L || ticks > 504000000000L)
			{
				throw new ArgumentOutOfRangeException("offset", SR.Argument_OffsetOutOfRange);
			}
			return (short)(offset.Ticks / 600000000L);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00028C18 File Offset: 0x00026E18
		private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset)
		{
			long num = dateTime.Ticks - offset.Ticks;
			if (num < 0L || num > 3155378975999999999L)
			{
				throw new ArgumentOutOfRangeException("offset", SR.Argument_UTCOutOfRange);
			}
			return new DateTime(num, DateTimeKind.Unspecified);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00028C60 File Offset: 0x00026E60
		private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind)) != DateTimeStyles.None)
			{
				throw new ArgumentException(SR.Argument_InvalidDateTimeStyles, parameterName);
			}
			if ((style & DateTimeStyles.AssumeLocal) != DateTimeStyles.None && (style & DateTimeStyles.AssumeUniversal) != DateTimeStyles.None)
			{
				throw new ArgumentException(SR.Argument_ConflictingDateTimeStyles, parameterName);
			}
			if ((style & DateTimeStyles.NoCurrentDateDefault) != DateTimeStyles.None)
			{
				throw new ArgumentException(SR.Argument_DateTimeOffsetInvalidDateTimeStyles, parameterName);
			}
			style &= ~DateTimeStyles.RoundtripKind;
			style &= ~DateTimeStyles.AssumeLocal;
			return style;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00028CBB File Offset: 0x00026EBB
		public static implicit operator DateTimeOffset(DateTime dateTime)
		{
			return new DateTimeOffset(dateTime);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00028CC3 File Offset: 0x00026EC3
		public static DateTimeOffset operator +(DateTimeOffset dateTimeOffset, TimeSpan timeSpan)
		{
			return new DateTimeOffset(dateTimeOffset.ClockDateTime + timeSpan, dateTimeOffset.Offset);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00028CDE File Offset: 0x00026EDE
		public static DateTimeOffset operator -(DateTimeOffset dateTimeOffset, TimeSpan timeSpan)
		{
			return new DateTimeOffset(dateTimeOffset.ClockDateTime - timeSpan, dateTimeOffset.Offset);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00028CF9 File Offset: 0x00026EF9
		public static TimeSpan operator -(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime - right.UtcDateTime;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00028D0E File Offset: 0x00026F0E
		public static bool operator ==(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime == right.UtcDateTime;
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00028D23 File Offset: 0x00026F23
		public static bool operator !=(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime != right.UtcDateTime;
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00028D38 File Offset: 0x00026F38
		public static bool operator <(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime < right.UtcDateTime;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00028D4D File Offset: 0x00026F4D
		public static bool operator <=(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime <= right.UtcDateTime;
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00028D62 File Offset: 0x00026F62
		public static bool operator >(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime > right.UtcDateTime;
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00028D77 File Offset: 0x00026F77
		public static bool operator >=(DateTimeOffset left, DateTimeOffset right)
		{
			return left.UtcDateTime >= right.UtcDateTime;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00028D8C File Offset: 0x00026F8C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Deconstruct(out DateOnly date, out TimeOnly time, out TimeSpan offset)
		{
			DateOnly dateOnly;
			TimeOnly timeOnly;
			this.ClockDateTime.Deconstruct(out dateOnly, out timeOnly);
			date = dateOnly;
			time = timeOnly;
			offset = this.Offset;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00028DC5 File Offset: 0x00026FC5
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out DateTimeOffset result)
		{
			return DateTimeOffset.TryParse(s, provider, DateTimeStyles.None, out result);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00028DD0 File Offset: 0x00026FD0
		public static DateTimeOffset Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return DateTimeOffset.Parse(s, provider, DateTimeStyles.None);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00028DDA File Offset: 0x00026FDA
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out DateTimeOffset result)
		{
			return DateTimeOffset.TryParse(s, provider, DateTimeStyles.None, out result);
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x00028DE5 File Offset: 0x00026FE5
		public static DateTimeOffset Now
		{
			get
			{
				return DateTimeOffset.ToLocalTime(DateTime.UtcNow, true);
			}
		}

		// Token: 0x0400034A RID: 842
		public static readonly DateTimeOffset MinValue = new DateTimeOffset(0L, TimeSpan.Zero);

		// Token: 0x0400034B RID: 843
		public static readonly DateTimeOffset MaxValue = new DateTimeOffset(3155378975999999999L, TimeSpan.Zero);

		// Token: 0x0400034C RID: 844
		public static readonly DateTimeOffset UnixEpoch = new DateTimeOffset(621355968000000000L, TimeSpan.Zero);

		// Token: 0x0400034D RID: 845
		private readonly DateTime _dateTime;

		// Token: 0x0400034E RID: 846
		private readonly short _offsetMinutes;
	}
}
