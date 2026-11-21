using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020001C5 RID: 453
	public readonly struct TimeOnly : IComparable, IComparable<TimeOnly>, IEquatable<TimeOnly>, ISpanFormattable, IFormattable, ISpanParsable<TimeOnly>, IParsable<TimeOnly>, IUtf8SpanFormattable
	{
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x000676ED File Offset: 0x000658ED
		public static TimeOnly MinValue
		{
			get
			{
				return new TimeOnly(0UL);
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x000676F6 File Offset: 0x000658F6
		public static TimeOnly MaxValue
		{
			get
			{
				return new TimeOnly(863999999999UL);
			}
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x00067706 File Offset: 0x00065906
		public TimeOnly(int hour, int minute)
		{
			this = new TimeOnly(DateTime.TimeToTicks(hour, minute, 0, 0));
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x00067717 File Offset: 0x00065917
		public TimeOnly(int hour, int minute, int second)
		{
			this = new TimeOnly(DateTime.TimeToTicks(hour, minute, second, 0));
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00067728 File Offset: 0x00065928
		public TimeOnly(int hour, int minute, int second, int millisecond)
		{
			this = new TimeOnly(DateTime.TimeToTicks(hour, minute, second, millisecond));
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x0006773A File Offset: 0x0006593A
		public TimeOnly(int hour, int minute, int second, int millisecond, int microsecond)
		{
			this = new TimeOnly(DateTime.TimeToTicks(hour, minute, second, millisecond, microsecond));
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0006774E File Offset: 0x0006594E
		public TimeOnly(long ticks)
		{
			if (ticks > 863999999999L)
			{
				throw new ArgumentOutOfRangeException("ticks", SR.ArgumentOutOfRange_TimeOnlyBadTicks);
			}
			this._ticks = ticks;
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x00067773 File Offset: 0x00065973
		internal TimeOnly(ulong ticks)
		{
			this._ticks = (long)ticks;
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x0006777C File Offset: 0x0006597C
		public int Hour
		{
			get
			{
				return new TimeSpan(this._ticks).Hours;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x0006779C File Offset: 0x0006599C
		public int Minute
		{
			get
			{
				return new TimeSpan(this._ticks).Minutes;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x000677BC File Offset: 0x000659BC
		public int Second
		{
			get
			{
				return new TimeSpan(this._ticks).Seconds;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x000677DC File Offset: 0x000659DC
		public int Millisecond
		{
			get
			{
				return new TimeSpan(this._ticks).Milliseconds;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x000677FC File Offset: 0x000659FC
		public int Microsecond
		{
			get
			{
				return new TimeSpan(this._ticks).Microseconds;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x0006781C File Offset: 0x00065A1C
		public int Nanosecond
		{
			get
			{
				return new TimeSpan(this._ticks).Nanoseconds;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x0006783C File Offset: 0x00065A3C
		public long Ticks
		{
			get
			{
				return this._ticks;
			}
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00067844 File Offset: 0x00065A44
		private TimeOnly AddTicks(long ticks)
		{
			return new TimeOnly((this._ticks + 864000000000L + ticks % 864000000000L) % 864000000000L);
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00067874 File Offset: 0x00065A74
		private TimeOnly AddTicks(long ticks, out int wrappedDays)
		{
			wrappedDays = (int)(ticks / 864000000000L);
			long num = this._ticks + ticks % 864000000000L;
			if (num < 0L)
			{
				wrappedDays--;
				num += 864000000000L;
			}
			else if (num >= 864000000000L)
			{
				wrappedDays++;
				num -= 864000000000L;
			}
			return new TimeOnly(num);
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x000678DF File Offset: 0x00065ADF
		public TimeOnly Add(TimeSpan value)
		{
			return this.AddTicks(value.Ticks);
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x000678EE File Offset: 0x00065AEE
		public TimeOnly Add(TimeSpan value, out int wrappedDays)
		{
			return this.AddTicks(value.Ticks, out wrappedDays);
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x000678FE File Offset: 0x00065AFE
		public TimeOnly AddHours(double value)
		{
			return this.AddTicks((long)(value * 36000000000.0));
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x00067912 File Offset: 0x00065B12
		public TimeOnly AddHours(double value, out int wrappedDays)
		{
			return this.AddTicks((long)(value * 36000000000.0), out wrappedDays);
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00067927 File Offset: 0x00065B27
		public TimeOnly AddMinutes(double value)
		{
			return this.AddTicks((long)(value * 600000000.0));
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x0006793B File Offset: 0x00065B3B
		public TimeOnly AddMinutes(double value, out int wrappedDays)
		{
			return this.AddTicks((long)(value * 600000000.0), out wrappedDays);
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x00067950 File Offset: 0x00065B50
		public bool IsBetween(TimeOnly start, TimeOnly end)
		{
			long ticks = start._ticks;
			long ticks2 = end._ticks;
			if (ticks > ticks2)
			{
				return ticks <= this._ticks || ticks2 > this._ticks;
			}
			return ticks <= this._ticks && ticks2 > this._ticks;
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00067998 File Offset: 0x00065B98
		public static bool operator ==(TimeOnly left, TimeOnly right)
		{
			return left._ticks == right._ticks;
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x000679A8 File Offset: 0x00065BA8
		public static bool operator !=(TimeOnly left, TimeOnly right)
		{
			return left._ticks != right._ticks;
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x000679BB File Offset: 0x00065BBB
		public static bool operator >(TimeOnly left, TimeOnly right)
		{
			return left._ticks > right._ticks;
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x000679CB File Offset: 0x00065BCB
		public static bool operator >=(TimeOnly left, TimeOnly right)
		{
			return left._ticks >= right._ticks;
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x000679DE File Offset: 0x00065BDE
		public static bool operator <(TimeOnly left, TimeOnly right)
		{
			return left._ticks < right._ticks;
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x000679EE File Offset: 0x00065BEE
		public static bool operator <=(TimeOnly left, TimeOnly right)
		{
			return left._ticks <= right._ticks;
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00067A01 File Offset: 0x00065C01
		public static TimeSpan operator -(TimeOnly t1, TimeOnly t2)
		{
			return new TimeSpan((t1._ticks - t2._ticks + 864000000000L) % 864000000000L);
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00067A29 File Offset: 0x00065C29
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Deconstruct(out int hour, out int minute)
		{
			hour = this.Hour;
			minute = this.Minute;
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00067A3C File Offset: 0x00065C3C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Deconstruct(out int hour, out int minute, out int second)
		{
			TimeOnly timeOnly = this;
			int num;
			int num2;
			timeOnly.Deconstruct(out num, out num2);
			hour = num;
			minute = num2;
			second = this.Second;
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00067A6C File Offset: 0x00065C6C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Deconstruct(out int hour, out int minute, out int second, out int millisecond)
		{
			TimeOnly timeOnly = this;
			int num;
			int num2;
			int num3;
			timeOnly.Deconstruct(out num, out num2, out num3);
			hour = num;
			minute = num2;
			second = num3;
			millisecond = this.Millisecond;
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00067AA0 File Offset: 0x00065CA0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Deconstruct(out int hour, out int minute, out int second, out int millisecond, out int microsecond)
		{
			TimeOnly timeOnly = this;
			int num;
			int num2;
			int num3;
			int num4;
			timeOnly.Deconstruct(out num, out num2, out num3, out num4);
			hour = num;
			minute = num2;
			second = num3;
			millisecond = num4;
			microsecond = this.Microsecond;
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00067ADA File Offset: 0x00065CDA
		public static TimeOnly FromTimeSpan(TimeSpan timeSpan)
		{
			return new TimeOnly(timeSpan._ticks);
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00067AE8 File Offset: 0x00065CE8
		public static TimeOnly FromDateTime(DateTime dateTime)
		{
			return new TimeOnly(dateTime.TimeOfDay.Ticks);
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00067B09 File Offset: 0x00065D09
		public TimeSpan ToTimeSpan()
		{
			return new TimeSpan(this._ticks);
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x00067B16 File Offset: 0x00065D16
		internal DateTime ToDateTime()
		{
			return new DateTime(this._ticks);
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00067B23 File Offset: 0x00065D23
		public int CompareTo(TimeOnly value)
		{
			return this._ticks.CompareTo(value._ticks);
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00067B38 File Offset: 0x00065D38
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (value is TimeOnly)
			{
				TimeOnly value2 = (TimeOnly)value;
				return this.CompareTo(value2);
			}
			throw new ArgumentException(SR.Arg_MustBeTimeOnly);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x00067998 File Offset: 0x00065B98
		public bool Equals(TimeOnly value)
		{
			return this._ticks == value._ticks;
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x00067B70 File Offset: 0x00065D70
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			if (value is TimeOnly)
			{
				TimeOnly timeOnly = (TimeOnly)value;
				return this._ticks == timeOnly._ticks;
			}
			return false;
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x00067B9C File Offset: 0x00065D9C
		public override int GetHashCode()
		{
			long ticks = this._ticks;
			return (int)ticks ^ (int)(ticks >> 32);
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00067BB8 File Offset: 0x00065DB8
		public static TimeOnly Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider = null, DateTimeStyles style = DateTimeStyles.None)
		{
			TimeOnly result;
			ParseFailureKind parseFailureKind = TimeOnly.TryParseInternal(s, provider, style, out result);
			if (parseFailureKind != ParseFailureKind.None)
			{
				TimeOnly.ThrowOnError(parseFailureKind, s);
			}
			return result;
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x00067BDC File Offset: 0x00065DDC
		public static TimeOnly ParseExact(ReadOnlySpan<char> s, [StringSyntax("TimeOnlyFormat")] ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider provider = null, DateTimeStyles style = DateTimeStyles.None)
		{
			TimeOnly result;
			ParseFailureKind parseFailureKind = TimeOnly.TryParseExactInternal(s, format, provider, style, out result);
			if (parseFailureKind != ParseFailureKind.None)
			{
				TimeOnly.ThrowOnError(parseFailureKind, s);
			}
			return result;
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x00067C00 File Offset: 0x00065E00
		public static TimeOnly ParseExact(ReadOnlySpan<char> s, [Nullable(1)] [StringSyntax("TimeOnlyFormat")] string[] formats)
		{
			return TimeOnly.ParseExact(s, formats, null, DateTimeStyles.None);
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x00067C0C File Offset: 0x00065E0C
		public static TimeOnly ParseExact(ReadOnlySpan<char> s, [Nullable(1)] [StringSyntax("TimeOnlyFormat")] string[] formats, [Nullable(2)] IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			TimeOnly result;
			ParseFailureKind parseFailureKind = TimeOnly.TryParseExactInternal(s, formats, provider, style, out result);
			if (parseFailureKind != ParseFailureKind.None)
			{
				TimeOnly.ThrowOnError(parseFailureKind, s);
			}
			return result;
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x00067C30 File Offset: 0x00065E30
		[NullableContext(1)]
		public static TimeOnly Parse(string s)
		{
			return TimeOnly.Parse(s, null, DateTimeStyles.None);
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00067C3A File Offset: 0x00065E3A
		[NullableContext(1)]
		public static TimeOnly Parse(string s, [Nullable(2)] IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return TimeOnly.Parse(s.AsSpan(), provider, style);
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00067C53 File Offset: 0x00065E53
		[NullableContext(1)]
		public static TimeOnly ParseExact(string s, [StringSyntax("TimeOnlyFormat")] string format)
		{
			return TimeOnly.ParseExact(s, format, null, DateTimeStyles.None);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00067C5E File Offset: 0x00065E5E
		[NullableContext(1)]
		public static TimeOnly ParseExact(string s, [StringSyntax("TimeOnlyFormat")] string format, [Nullable(2)] IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			return TimeOnly.ParseExact(s.AsSpan(), format.AsSpan(), provider, style);
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00067C87 File Offset: 0x00065E87
		[NullableContext(1)]
		public static TimeOnly ParseExact(string s, [StringSyntax("TimeOnlyFormat")] string[] formats)
		{
			return TimeOnly.ParseExact(s, formats, null, DateTimeStyles.None);
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00067C92 File Offset: 0x00065E92
		[NullableContext(1)]
		public static TimeOnly ParseExact(string s, [StringSyntax("TimeOnlyFormat")] string[] formats, [Nullable(2)] IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return TimeOnly.ParseExact(s.AsSpan(), formats, provider, style);
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00067CAC File Offset: 0x00065EAC
		public static bool TryParse(ReadOnlySpan<char> s, out TimeOnly result)
		{
			return TimeOnly.TryParse(s, null, DateTimeStyles.None, out result);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00067CB7 File Offset: 0x00065EB7
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, DateTimeStyles style, out TimeOnly result)
		{
			return TimeOnly.TryParseInternal(s, provider, style, out result) == ParseFailureKind.None;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00067CC8 File Offset: 0x00065EC8
		private static ParseFailureKind TryParseInternal(ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles style, out TimeOnly result)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite)) != DateTimeStyles.None)
			{
				result = default(TimeOnly);
				return ParseFailureKind.Argument_InvalidDateStyles;
			}
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (!DateTimeParse.TryParse(s, DateTimeFormatInfo.GetInstance(provider), style, ref dateTimeResult))
			{
				result = default(TimeOnly);
				return ParseFailureKind.Format_BadTimeOnly;
			}
			if ((dateTimeResult.flags & (ParseFlags.HaveYear | ParseFlags.HaveMonth | ParseFlags.HaveDay | ParseFlags.HaveDate | ParseFlags.TimeZoneUsed | ParseFlags.TimeZoneUtc | ParseFlags.ParsedMonthName | ParseFlags.CaptureOffset | ParseFlags.UtcSortPattern)) != (ParseFlags)0)
			{
				result = default(TimeOnly);
				return ParseFailureKind.Format_DateTimeOnlyContainsNoneDateParts;
			}
			result = new TimeOnly(dateTimeResult.parsedDate.TimeOfDay.Ticks);
			return ParseFailureKind.None;
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00067D48 File Offset: 0x00065F48
		public static bool TryParseExact(ReadOnlySpan<char> s, [StringSyntax("TimeOnlyFormat")] ReadOnlySpan<char> format, out TimeOnly result)
		{
			return TimeOnly.TryParseExact(s, format, null, DateTimeStyles.None, out result);
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00067D54 File Offset: 0x00065F54
		public static bool TryParseExact(ReadOnlySpan<char> s, [StringSyntax("TimeOnlyFormat")] ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider provider, DateTimeStyles style, out TimeOnly result)
		{
			return TimeOnly.TryParseExactInternal(s, format, provider, style, out result) == ParseFailureKind.None;
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00067D64 File Offset: 0x00065F64
		private unsafe static ParseFailureKind TryParseExactInternal(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out TimeOnly result)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite)) != DateTimeStyles.None)
			{
				result = default(TimeOnly);
				return ParseFailureKind.Argument_InvalidDateStyles;
			}
			if (format.Length == 1)
			{
				int num = (int)(*format[0] | 32);
				if (num != 111)
				{
					if (num == 114)
					{
						format = "HH':'mm':'ss";
						provider = CultureInfo.InvariantCulture.DateTimeFormat;
					}
				}
				else
				{
					format = "HH':'mm':'ss'.'fffffff";
					provider = CultureInfo.InvariantCulture.DateTimeFormat;
				}
			}
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (!DateTimeParse.TryParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style, ref dateTimeResult))
			{
				result = default(TimeOnly);
				return ParseFailureKind.Format_BadTimeOnly;
			}
			if ((dateTimeResult.flags & (ParseFlags.HaveYear | ParseFlags.HaveMonth | ParseFlags.HaveDay | ParseFlags.HaveDate | ParseFlags.TimeZoneUsed | ParseFlags.TimeZoneUtc | ParseFlags.ParsedMonthName | ParseFlags.CaptureOffset | ParseFlags.UtcSortPattern)) != (ParseFlags)0)
			{
				result = default(TimeOnly);
				return ParseFailureKind.Format_DateTimeOnlyContainsNoneDateParts;
			}
			result = new TimeOnly(dateTimeResult.parsedDate.TimeOfDay.Ticks);
			return ParseFailureKind.None;
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x00067E3E File Offset: 0x0006603E
		public static bool TryParseExact(ReadOnlySpan<char> s, [Nullable(2)] [NotNullWhen(true)] [StringSyntax("TimeOnlyFormat")] string[] formats, out TimeOnly result)
		{
			return TimeOnly.TryParseExact(s, formats, null, DateTimeStyles.None, out result);
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00067E4A File Offset: 0x0006604A
		[NullableContext(2)]
		public static bool TryParseExact([Nullable(0)] ReadOnlySpan<char> s, [NotNullWhen(true)] [StringSyntax("TimeOnlyFormat")] string[] formats, IFormatProvider provider, DateTimeStyles style, out TimeOnly result)
		{
			return TimeOnly.TryParseExactInternal(s, formats, provider, style, out result) == ParseFailureKind.None;
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00067E5C File Offset: 0x0006605C
		private static ParseFailureKind TryParseExactInternal(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style, out TimeOnly result)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite)) != DateTimeStyles.None || formats == null)
			{
				result = default(TimeOnly);
				return ParseFailureKind.Argument_InvalidDateStyles;
			}
			DateTimeFormatInfo instance = DateTimeFormatInfo.GetInstance(provider);
			for (int i = 0; i < formats.Length; i++)
			{
				DateTimeFormatInfo dtfi = instance;
				string text = formats[i];
				if (string.IsNullOrEmpty(text))
				{
					result = default(TimeOnly);
					return ParseFailureKind.Argument_BadFormatSpecifier;
				}
				if (text.Length == 1)
				{
					int num = (int)(text[0] | ' ');
					if (num != 111)
					{
						if (num == 114)
						{
							text = "HH':'mm':'ss";
							dtfi = CultureInfo.InvariantCulture.DateTimeFormat;
						}
					}
					else
					{
						text = "HH':'mm':'ss'.'fffffff";
						dtfi = CultureInfo.InvariantCulture.DateTimeFormat;
					}
				}
				DateTimeResult dateTimeResult = default(DateTimeResult);
				dateTimeResult.Init(s);
				if (DateTimeParse.TryParseExact(s, text, dtfi, style, ref dateTimeResult) && (dateTimeResult.flags & (ParseFlags.HaveYear | ParseFlags.HaveMonth | ParseFlags.HaveDay | ParseFlags.HaveDate | ParseFlags.TimeZoneUsed | ParseFlags.TimeZoneUtc | ParseFlags.ParsedMonthName | ParseFlags.CaptureOffset | ParseFlags.UtcSortPattern)) == (ParseFlags)0)
				{
					result = new TimeOnly(dateTimeResult.parsedDate.TimeOfDay.Ticks);
					return ParseFailureKind.None;
				}
			}
			result = default(TimeOnly);
			return ParseFailureKind.Format_BadTimeOnly;
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x00067F56 File Offset: 0x00066156
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out TimeOnly result)
		{
			return TimeOnly.TryParse(s, null, DateTimeStyles.None, out result);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00067F61 File Offset: 0x00066161
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, DateTimeStyles style, out TimeOnly result)
		{
			if (s == null)
			{
				result = default(TimeOnly);
				return false;
			}
			return TimeOnly.TryParse(s.AsSpan(), provider, style, out result);
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00067F7D File Offset: 0x0006617D
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string s, [NotNullWhen(true)] [StringSyntax("TimeOnlyFormat")] string format, out TimeOnly result)
		{
			return TimeOnly.TryParseExact(s, format, null, DateTimeStyles.None, out result);
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00067F89 File Offset: 0x00066189
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string s, [NotNullWhen(true)] [StringSyntax("TimeOnlyFormat")] string format, IFormatProvider provider, DateTimeStyles style, out TimeOnly result)
		{
			if (s == null || format == null)
			{
				result = default(TimeOnly);
				return false;
			}
			return TimeOnly.TryParseExact(s.AsSpan(), format.AsSpan(), provider, style, out result);
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00067FB0 File Offset: 0x000661B0
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string s, [NotNullWhen(true)] [StringSyntax("TimeOnlyFormat")] string[] formats, out TimeOnly result)
		{
			return TimeOnly.TryParseExact(s, formats, null, DateTimeStyles.None, out result);
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00067FBC File Offset: 0x000661BC
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string s, [NotNullWhen(true)] [StringSyntax("TimeOnlyFormat")] string[] formats, IFormatProvider provider, DateTimeStyles style, out TimeOnly result)
		{
			if (s == null)
			{
				result = default(TimeOnly);
				return false;
			}
			return TimeOnly.TryParseExact(s.AsSpan(), formats, provider, style, out result);
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00067FDC File Offset: 0x000661DC
		private static void ThrowOnError(ParseFailureKind result, ReadOnlySpan<char> s)
		{
			switch (result)
			{
			case ParseFailureKind.Argument_InvalidDateStyles:
				throw new ArgumentException(SR.Argument_InvalidDateStyles, "style");
			case ParseFailureKind.Argument_BadFormatSpecifier:
				throw new FormatException(SR.Argument_BadFormatSpecifier);
			case ParseFailureKind.Format_BadTimeOnly:
				throw new FormatException(SR.Format(SR.Format_BadTimeOnly, s.ToString()));
			}
			throw new FormatException(SR.Format(SR.Format_DateTimeOnlyContainsNoneDateParts, s.ToString(), "TimeOnly"));
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x0006805D File Offset: 0x0006625D
		[NullableContext(1)]
		public string ToLongTimeString()
		{
			return this.ToString("T");
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x0006806A File Offset: 0x0006626A
		[NullableContext(1)]
		public string ToShortTimeString()
		{
			return this.ToString();
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x00068078 File Offset: 0x00066278
		[NullableContext(1)]
		public override string ToString()
		{
			return this.ToString("t");
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x00068085 File Offset: 0x00066285
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("TimeOnlyFormat")] string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x0006808F File Offset: 0x0006628F
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return this.ToString("t", provider);
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x000680A0 File Offset: 0x000662A0
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("TimeOnlyFormat")] string format, IFormatProvider provider)
		{
			if (string.IsNullOrEmpty(format))
			{
				format = "t";
			}
			if (format.Length == 1)
			{
				int num = (int)(format[0] | ' ');
				string result;
				if (num != 111)
				{
					if (num != 114)
					{
						if (num != 116)
						{
							throw new FormatException(SR.Format_InvalidString);
						}
						result = DateTimeFormat.Format(this.ToDateTime(), format, provider);
					}
					else
					{
						result = string.Create<TimeOnly>(8, this, delegate(Span<char> destination, TimeOnly value)
						{
							int num2;
							DateTimeFormat.TryFormatTimeOnlyR<char>(value.Hour, value.Minute, value.Second, destination, out num2);
						});
					}
				}
				else
				{
					result = string.Create<TimeOnly>(16, this, delegate(Span<char> destination, TimeOnly value)
					{
						int num2;
						DateTimeFormat.TryFormatTimeOnlyO<char>(value.Hour, value.Minute, value.Second, value._ticks % 10000000L, destination, out num2);
					});
				}
				return result;
			}
			DateTimeFormat.IsValidCustomTimeOnlyFormat(format.AsSpan(), true);
			return DateTimeFormat.Format(this.ToDateTime(), format, provider);
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00068178 File Offset: 0x00066378
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("TimeOnlyFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return this.TryFormatCore<char>(destination, out charsWritten, format, provider);
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00068185 File Offset: 0x00066385
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("TimeOnlyFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return this.TryFormatCore<byte>(utf8Destination, out bytesWritten, format, provider);
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00068194 File Offset: 0x00066394
		private unsafe bool TryFormatCore<[IsUnmanaged] TChar>(Span<TChar> destination, out int written, [StringSyntax("TimeOnlyFormat")] ReadOnlySpan<char> format, IFormatProvider provider) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (format.Length == 0)
			{
				format = "t";
			}
			if (format.Length == 1)
			{
				int num = (int)(*format[0] | 32);
				if (num == 111)
				{
					return DateTimeFormat.TryFormatTimeOnlyO<TChar>(this.Hour, this.Minute, this.Second, this._ticks % 10000000L, destination, out written);
				}
				if (num == 114)
				{
					return DateTimeFormat.TryFormatTimeOnlyR<TChar>(this.Hour, this.Minute, this.Second, destination, out written);
				}
				if (num == 116)
				{
					return DateTimeFormat.TryFormat<TChar>(this.ToDateTime(), destination, out written, format, provider);
				}
				ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			}
			if (!DateTimeFormat.IsValidCustomTimeOnlyFormat(format, false))
			{
				throw new FormatException(SR.Format(SR.Format_DateTimeOnlyContainsNoneDateParts, format.ToString(), "TimeOnly"));
			}
			return DateTimeFormat.TryFormat<TChar>(this.ToDateTime(), destination, out written, format, provider);
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00068270 File Offset: 0x00066470
		[NullableContext(1)]
		public static TimeOnly Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return TimeOnly.Parse(s, provider, DateTimeStyles.None);
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x0006827A File Offset: 0x0006647A
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out TimeOnly result)
		{
			return TimeOnly.TryParse(s, provider, DateTimeStyles.None, out result);
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00068285 File Offset: 0x00066485
		public static TimeOnly Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return TimeOnly.Parse(s, provider, DateTimeStyles.None);
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x0006828F File Offset: 0x0006648F
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out TimeOnly result)
		{
			return TimeOnly.TryParse(s, provider, DateTimeStyles.None, out result);
		}

		// Token: 0x04000647 RID: 1607
		private readonly long _ticks;
	}
}
