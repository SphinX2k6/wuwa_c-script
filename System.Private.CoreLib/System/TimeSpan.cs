using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020001C8 RID: 456
	[Serializable]
	public readonly struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, ISpanFormattable, IFormattable, ISpanParsable<TimeSpan>, IParsable<TimeSpan>, IUtf8SpanFormattable
	{
		// Token: 0x0600227D RID: 8829 RVA: 0x0006835E File Offset: 0x0006655E
		public TimeSpan(long ticks)
		{
			this._ticks = ticks;
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00068367 File Offset: 0x00066567
		public TimeSpan(int hours, int minutes, int seconds)
		{
			this._ticks = TimeSpan.TimeToTicks(hours, minutes, seconds);
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00068377 File Offset: 0x00066577
		public TimeSpan(int days, int hours, int minutes, int seconds)
		{
			this = new TimeSpan(days, hours, minutes, seconds, 0);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00068385 File Offset: 0x00066585
		public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
		{
			this = new TimeSpan(days, hours, minutes, seconds, milliseconds, 0);
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00068398 File Offset: 0x00066598
		public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds, int microseconds)
		{
			long num = (long)days * 86400000000L + (long)hours * (long)((ulong)-694967296) + (long)minutes * 60000000L + (long)seconds * 1000000L + (long)milliseconds * 1000L + (long)microseconds;
			if (num > 922337203685477580L || num < -922337203685477580L)
			{
				ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong();
			}
			this._ticks = num * 10L;
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x00068408 File Offset: 0x00066608
		public long Ticks
		{
			get
			{
				return this._ticks;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x00068410 File Offset: 0x00066610
		public int Days
		{
			get
			{
				return (int)(this._ticks / 864000000000L);
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x00068423 File Offset: 0x00066623
		public int Hours
		{
			get
			{
				return (int)(this._ticks / 36000000000L % 24L);
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x0006843A File Offset: 0x0006663A
		public int Milliseconds
		{
			get
			{
				return (int)(this._ticks / 10000L % 1000L);
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x00068451 File Offset: 0x00066651
		public int Microseconds
		{
			get
			{
				return (int)(this._ticks / 10L % 1000L);
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x00068465 File Offset: 0x00066665
		public int Nanoseconds
		{
			get
			{
				return (int)(this._ticks % 10L * 100L);
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x00068476 File Offset: 0x00066676
		public int Minutes
		{
			get
			{
				return (int)(this._ticks / 600000000L % 60L);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x0006848A File Offset: 0x0006668A
		public int Seconds
		{
			get
			{
				return (int)(this._ticks / 10000000L % 60L);
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x0006849E File Offset: 0x0006669E
		public double TotalDays
		{
			get
			{
				return (double)this._ticks / 864000000000.0;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x000684B1 File Offset: 0x000666B1
		public double TotalHours
		{
			get
			{
				return (double)this._ticks / 36000000000.0;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x000684C4 File Offset: 0x000666C4
		public double TotalMilliseconds
		{
			get
			{
				double num = (double)this._ticks / 10000.0;
				if (num > 922337203685477.0)
				{
					return 922337203685477.0;
				}
				if (num < -922337203685477.0)
				{
					return -922337203685477.0;
				}
				return num;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x00068510 File Offset: 0x00066710
		public double TotalMicroseconds
		{
			get
			{
				return (double)this._ticks / 10.0;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x00068523 File Offset: 0x00066723
		public double TotalNanoseconds
		{
			get
			{
				return (double)this._ticks * 100.0;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x00068536 File Offset: 0x00066736
		public double TotalMinutes
		{
			get
			{
				return (double)this._ticks / 600000000.0;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x00068549 File Offset: 0x00066749
		public double TotalSeconds
		{
			get
			{
				return (double)this._ticks / 10000000.0;
			}
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x0006855C File Offset: 0x0006675C
		public TimeSpan Add(TimeSpan ts)
		{
			return this + ts;
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x0006856A File Offset: 0x0006676A
		public static int Compare(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks.CompareTo(t2._ticks);
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00068580 File Offset: 0x00066780
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (value is TimeSpan)
			{
				TimeSpan value2 = (TimeSpan)value;
				return this.CompareTo(value2);
			}
			throw new ArgumentException(SR.Arg_MustBeTimeSpan);
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000685B3 File Offset: 0x000667B3
		public int CompareTo(TimeSpan value)
		{
			return TimeSpan.Compare(this, value);
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000685C1 File Offset: 0x000667C1
		public static TimeSpan FromDays(double value)
		{
			return TimeSpan.Interval(value, 864000000000.0);
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000685D2 File Offset: 0x000667D2
		public TimeSpan Duration()
		{
			if (this._ticks == -9223372036854775808L)
			{
				ThrowHelper.ThrowOverflowException_TimeSpanDuration();
			}
			return new TimeSpan((this._ticks >= 0L) ? this._ticks : (-this._ticks));
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00068608 File Offset: 0x00066808
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			if (value is TimeSpan)
			{
				TimeSpan obj = (TimeSpan)value;
				return this.Equals(obj);
			}
			return false;
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x0006862D File Offset: 0x0006682D
		public bool Equals(TimeSpan obj)
		{
			return TimeSpan.Equals(this, obj);
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x0006863B File Offset: 0x0006683B
		public static bool Equals(TimeSpan t1, TimeSpan t2)
		{
			return t1 == t2;
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00068644 File Offset: 0x00066844
		public override int GetHashCode()
		{
			return this._ticks.GetHashCode();
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00068651 File Offset: 0x00066851
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TimeSpan FromUnits(long units, long ticksPerUnit, long minUnits, long maxUnits)
		{
			if (units > maxUnits || units < minUnits)
			{
				ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong();
			}
			return TimeSpan.FromTicks(units * ticksPerUnit);
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00068668 File Offset: 0x00066868
		public static TimeSpan FromDays(int days)
		{
			return TimeSpan.FromUnits((long)days, 864000000000L, -10675199L, 10675199L);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00068688 File Offset: 0x00066888
		public static TimeSpan FromDays(int days, int hours = 0, long minutes = 0L, long seconds = 0L, long milliseconds = 0L, long microseconds = 0L)
		{
			return TimeSpan.FromMicroseconds(Math.BigMul((long)days, 86400000000L) + Math.BigMul((long)hours, (long)((ulong)-694967296)) + Math.BigMul(minutes, 60000000L) + Math.BigMul(seconds, 1000000L) + Math.BigMul(milliseconds, 1000L) + microseconds);
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x000686FC File Offset: 0x000668FC
		public static TimeSpan FromHours(int hours)
		{
			return TimeSpan.FromUnits((long)hours, 36000000000L, -256204778L, 256204778L);
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x0006871C File Offset: 0x0006691C
		public static TimeSpan FromHours(int hours, long minutes = 0L, long seconds = 0L, long milliseconds = 0L, long microseconds = 0L)
		{
			return TimeSpan.FromMicroseconds(Math.BigMul((long)hours, (long)((ulong)-694967296)) + Math.BigMul(minutes, 60000000L) + Math.BigMul(seconds, 1000000L) + Math.BigMul(milliseconds, 1000L) + microseconds);
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x0006877A File Offset: 0x0006697A
		public static TimeSpan FromMinutes(long minutes)
		{
			return TimeSpan.FromUnits(minutes, 600000000L, -15372286728L, 15372286728L);
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x0006879A File Offset: 0x0006699A
		public static TimeSpan FromMinutes(long minutes, long seconds = 0L, long milliseconds = 0L, long microseconds = 0L)
		{
			return TimeSpan.FromMicroseconds(Math.BigMul(minutes, 60000000L) + Math.BigMul(seconds, 1000000L) + Math.BigMul(milliseconds, 1000L) + microseconds);
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x000687DA File Offset: 0x000669DA
		public static TimeSpan FromSeconds(long seconds)
		{
			return TimeSpan.FromUnits(seconds, 10000000L, -922337203685L, 922337203685L);
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x000687FA File Offset: 0x000669FA
		public static TimeSpan FromSeconds(long seconds, long milliseconds = 0L, long microseconds = 0L)
		{
			return TimeSpan.FromMicroseconds(Math.BigMul(seconds, 1000000L) + Math.BigMul(milliseconds, 1000L) + microseconds);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00068829 File Offset: 0x00066A29
		public static TimeSpan FromMilliseconds(long milliseconds, long microseconds = 0L)
		{
			return TimeSpan.FromMicroseconds(Math.BigMul(milliseconds, 1000L) + microseconds);
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00068848 File Offset: 0x00066A48
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TimeSpan FromMicroseconds(Int128 microseconds)
		{
			if (microseconds > 922337203685477580L || microseconds < -922337203685477580L)
			{
				ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong();
			}
			return TimeSpan.FromTicks((long)microseconds * 10L);
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00068895 File Offset: 0x00066A95
		public static TimeSpan FromMicroseconds(long microseconds)
		{
			return TimeSpan.FromUnits(microseconds, 10L, -922337203685477580L, 922337203685477580L);
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x000688B2 File Offset: 0x00066AB2
		public static TimeSpan FromHours(double value)
		{
			return TimeSpan.Interval(value, 36000000000.0);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x000688C3 File Offset: 0x00066AC3
		private static TimeSpan Interval(double value, double scale)
		{
			if (double.IsNaN(value))
			{
				ThrowHelper.ThrowArgumentException_Arg_CannotBeNaN();
			}
			return TimeSpan.IntervalFromDoubleTicks(value * scale);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000688DA File Offset: 0x00066ADA
		private static TimeSpan IntervalFromDoubleTicks(double ticks)
		{
			if (ticks > 9.223372036854776E+18 || ticks < -9.223372036854776E+18 || double.IsNaN(ticks))
			{
				ThrowHelper.ThrowOverflowException_TimeSpanTooLong();
			}
			if (ticks == 9.223372036854776E+18)
			{
				return TimeSpan.MaxValue;
			}
			return new TimeSpan((long)ticks);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x0006891A File Offset: 0x00066B1A
		public static TimeSpan FromMilliseconds(double value)
		{
			return TimeSpan.Interval(value, 10000.0);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x0006892B File Offset: 0x00066B2B
		public static TimeSpan FromMicroseconds(double value)
		{
			return TimeSpan.Interval(value, 10.0);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x0006893C File Offset: 0x00066B3C
		public static TimeSpan FromMinutes(double value)
		{
			return TimeSpan.Interval(value, 600000000.0);
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x0006894D File Offset: 0x00066B4D
		public TimeSpan Negate()
		{
			return -this;
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0006895A File Offset: 0x00066B5A
		public static TimeSpan FromSeconds(double value)
		{
			return TimeSpan.Interval(value, 10000000.0);
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x0006896B File Offset: 0x00066B6B
		public TimeSpan Subtract(TimeSpan ts)
		{
			return this - ts;
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00068979 File Offset: 0x00066B79
		public TimeSpan Multiply(double factor)
		{
			return this * factor;
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00068987 File Offset: 0x00066B87
		public TimeSpan Divide(double divisor)
		{
			return this / divisor;
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00068995 File Offset: 0x00066B95
		public double Divide(TimeSpan ts)
		{
			return this / ts;
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x000689A3 File Offset: 0x00066BA3
		public static TimeSpan FromTicks(long value)
		{
			return new TimeSpan(value);
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x000689AC File Offset: 0x00066BAC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static long TimeToTicks(int hour, int minute, int second)
		{
			long num = (long)hour * 3600L + (long)minute * 60L + (long)second;
			if (num > 922337203685L || num < -922337203685L)
			{
				ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong();
			}
			return num * 10000000L;
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x000689F2 File Offset: 0x00066BF2
		private static void ValidateStyles(TimeSpanStyles style)
		{
			if (style != TimeSpanStyles.None && style != TimeSpanStyles.AssumeNegative)
			{
				ThrowHelper.ThrowArgumentException_InvalidTimeSpanStyles();
			}
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00068A00 File Offset: 0x00066C00
		[NullableContext(1)]
		public static TimeSpan Parse(string s)
		{
			ArgumentNullException.ThrowIfNull(s, ExceptionArgument.input);
			return TimeSpanParse.Parse(s, null);
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00068A16 File Offset: 0x00066C16
		[NullableContext(1)]
		public static TimeSpan Parse(string input, [Nullable(2)] IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			return TimeSpanParse.Parse(input, formatProvider);
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x00068A2E File Offset: 0x00066C2E
		public static TimeSpan Parse(ReadOnlySpan<char> input, [Nullable(2)] IFormatProvider formatProvider = null)
		{
			return TimeSpanParse.Parse(input, formatProvider);
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00068A37 File Offset: 0x00066C37
		[NullableContext(1)]
		public static TimeSpan ParseExact(string input, [StringSyntax("TimeSpanFormat")] string format, [Nullable(2)] IFormatProvider formatProvider)
		{
			ArgumentNullException.ThrowIfNull(input, ExceptionArgument.input);
			ArgumentNullException.ThrowIfNull(format, ExceptionArgument.format);
			return TimeSpanParse.ParseExact(input, format, formatProvider, TimeSpanStyles.None);
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00068A5C File Offset: 0x00066C5C
		[NullableContext(1)]
		public static TimeSpan ParseExact(string input, [StringSyntax("TimeSpanFormat")] string[] formats, [Nullable(2)] IFormatProvider formatProvider)
		{
			if (input == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.input);
			}
			return TimeSpanParse.ParseExactMultiple(input, formats, formatProvider, TimeSpanStyles.None);
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00068A76 File Offset: 0x00066C76
		[NullableContext(1)]
		public static TimeSpan ParseExact(string input, [StringSyntax("TimeSpanFormat")] string format, [Nullable(2)] IFormatProvider formatProvider, TimeSpanStyles styles)
		{
			TimeSpan.ValidateStyles(styles);
			ArgumentNullException.ThrowIfNull(input, ExceptionArgument.input);
			ArgumentNullException.ThrowIfNull(format, ExceptionArgument.format);
			return TimeSpanParse.ParseExact(input, format, formatProvider, styles);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00068AA1 File Offset: 0x00066CA1
		public static TimeSpan ParseExact(ReadOnlySpan<char> input, [StringSyntax("TimeSpanFormat")] ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider formatProvider, TimeSpanStyles styles = TimeSpanStyles.None)
		{
			TimeSpan.ValidateStyles(styles);
			return TimeSpanParse.ParseExact(input, format, formatProvider, styles);
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00068AB2 File Offset: 0x00066CB2
		[NullableContext(1)]
		public static TimeSpan ParseExact(string input, [StringSyntax("TimeSpanFormat")] string[] formats, [Nullable(2)] IFormatProvider formatProvider, TimeSpanStyles styles)
		{
			TimeSpan.ValidateStyles(styles);
			ArgumentNullException.ThrowIfNull(input, ExceptionArgument.input);
			return TimeSpanParse.ParseExactMultiple(input, formats, formatProvider, styles);
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00068AD0 File Offset: 0x00066CD0
		public static TimeSpan ParseExact(ReadOnlySpan<char> input, [Nullable(1)] [StringSyntax("TimeSpanFormat")] string[] formats, [Nullable(2)] IFormatProvider formatProvider, TimeSpanStyles styles = TimeSpanStyles.None)
		{
			TimeSpan.ValidateStyles(styles);
			return TimeSpanParse.ParseExactMultiple(input, formats, formatProvider, styles);
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00068AE1 File Offset: 0x00066CE1
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out TimeSpan result)
		{
			if (s == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParse(s, null, out result);
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00068AFC File Offset: 0x00066CFC
		public static bool TryParse(ReadOnlySpan<char> s, out TimeSpan result)
		{
			return TimeSpanParse.TryParse(s, null, out result);
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x00068B06 File Offset: 0x00066D06
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string input, IFormatProvider formatProvider, out TimeSpan result)
		{
			if (input == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParse(input, formatProvider, out result);
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x00068B21 File Offset: 0x00066D21
		public static bool TryParse(ReadOnlySpan<char> input, [Nullable(2)] IFormatProvider formatProvider, out TimeSpan result)
		{
			return TimeSpanParse.TryParse(input, formatProvider, out result);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00068B2B File Offset: 0x00066D2B
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string input, [NotNullWhen(true)] [StringSyntax("TimeSpanFormat")] string format, IFormatProvider formatProvider, out TimeSpan result)
		{
			if (input == null || format == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParseExact(input, format, formatProvider, TimeSpanStyles.None, out result);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x00068B50 File Offset: 0x00066D50
		public static bool TryParseExact(ReadOnlySpan<char> input, [StringSyntax("TimeSpanFormat")] ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider formatProvider, out TimeSpan result)
		{
			return TimeSpanParse.TryParseExact(input, format, formatProvider, TimeSpanStyles.None, out result);
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00068B5C File Offset: 0x00066D5C
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string input, [NotNullWhen(true)] [StringSyntax("TimeSpanFormat")] string[] formats, IFormatProvider formatProvider, out TimeSpan result)
		{
			if (input == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, TimeSpanStyles.None, out result);
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x00068B79 File Offset: 0x00066D79
		[NullableContext(2)]
		public static bool TryParseExact([Nullable(0)] ReadOnlySpan<char> input, [NotNullWhen(true)] [StringSyntax("TimeSpanFormat")] string[] formats, IFormatProvider formatProvider, out TimeSpan result)
		{
			return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, TimeSpanStyles.None, out result);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00068B85 File Offset: 0x00066D85
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string input, [NotNullWhen(true)] [StringSyntax("TimeSpanFormat")] string format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpan.ValidateStyles(styles);
			if (input == null || format == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParseExact(input, format, formatProvider, styles, out result);
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x00068BB2 File Offset: 0x00066DB2
		public static bool TryParseExact(ReadOnlySpan<char> input, [StringSyntax("TimeSpanFormat")] ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpan.ValidateStyles(styles);
			return TimeSpanParse.TryParseExact(input, format, formatProvider, styles, out result);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x00068BC5 File Offset: 0x00066DC5
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string input, [NotNullWhen(true)] [StringSyntax("TimeSpanFormat")] string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpan.ValidateStyles(styles);
			if (input == null)
			{
				result = default(TimeSpan);
				return false;
			}
			return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, styles, out result);
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00068BEA File Offset: 0x00066DEA
		[NullableContext(2)]
		public static bool TryParseExact([Nullable(0)] ReadOnlySpan<char> input, [NotNullWhen(true)] [StringSyntax("TimeSpanFormat")] string[] formats, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result)
		{
			TimeSpan.ValidateStyles(styles);
			return TimeSpanParse.TryParseExactMultiple(input, formats, formatProvider, styles, out result);
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00068BFD File Offset: 0x00066DFD
		[NullableContext(1)]
		public override string ToString()
		{
			return TimeSpanFormat.FormatC(this);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00068C0A File Offset: 0x00066E0A
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("TimeSpanFormat")] string format)
		{
			return TimeSpanFormat.Format(this, format, null);
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x00068C19 File Offset: 0x00066E19
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("TimeSpanFormat")] string format, IFormatProvider formatProvider)
		{
			return TimeSpanFormat.Format(this, format, formatProvider);
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x00068C28 File Offset: 0x00066E28
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("TimeSpanFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider formatProvider = null)
		{
			return TimeSpanFormat.TryFormat<char>(this, destination, out charsWritten, format, formatProvider);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x00068C3A File Offset: 0x00066E3A
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("TimeSpanFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider formatProvider = null)
		{
			return TimeSpanFormat.TryFormat<byte>(this, utf8Destination, out bytesWritten, format, formatProvider);
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00068C4C File Offset: 0x00066E4C
		public static TimeSpan operator -(TimeSpan t)
		{
			if (t._ticks == -9223372036854775808L)
			{
				ThrowHelper.ThrowOverflowException_NegateTwosCompNum();
			}
			return new TimeSpan(-t._ticks);
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x00068C70 File Offset: 0x00066E70
		public static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
		{
			long num = t1._ticks - t2._ticks;
			long num2 = t1._ticks >> 63;
			if (num2 != t2._ticks >> 63 && num2 != num >> 63)
			{
				ThrowHelper.ThrowOverflowException_TimeSpanTooLong();
			}
			return new TimeSpan(num);
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00007B62 File Offset: 0x00005D62
		public static TimeSpan operator +(TimeSpan t)
		{
			return t;
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00068CB4 File Offset: 0x00066EB4
		public static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
		{
			long num = t1._ticks + t2._ticks;
			long num2 = t1._ticks >> 63;
			if (num2 == t2._ticks >> 63 && num2 != num >> 63)
			{
				ThrowHelper.ThrowOverflowException_TimeSpanTooLong();
			}
			return new TimeSpan(num);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00068CF7 File Offset: 0x00066EF7
		public static TimeSpan operator *(TimeSpan timeSpan, double factor)
		{
			if (double.IsNaN(factor))
			{
				ThrowHelper.ThrowArgumentException_Arg_CannotBeNaN(ExceptionArgument.factor);
			}
			return TimeSpan.IntervalFromDoubleTicks(Math.Round((double)timeSpan.Ticks * factor));
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00068D1C File Offset: 0x00066F1C
		public static TimeSpan operator *(double factor, TimeSpan timeSpan)
		{
			return timeSpan * factor;
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00068D25 File Offset: 0x00066F25
		public static TimeSpan operator /(TimeSpan timeSpan, double divisor)
		{
			if (double.IsNaN(divisor))
			{
				ThrowHelper.ThrowArgumentException_Arg_CannotBeNaN(ExceptionArgument.divisor);
			}
			return TimeSpan.IntervalFromDoubleTicks(Math.Round((double)timeSpan.Ticks / divisor));
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00068D4A File Offset: 0x00066F4A
		public static double operator /(TimeSpan t1, TimeSpan t2)
		{
			return (double)t1.Ticks / (double)t2.Ticks;
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x00068D5D File Offset: 0x00066F5D
		public static bool operator ==(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks == t2._ticks;
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00068D6D File Offset: 0x00066F6D
		public static bool operator !=(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks != t2._ticks;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00068D80 File Offset: 0x00066F80
		public static bool operator <(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks < t2._ticks;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00068D90 File Offset: 0x00066F90
		public static bool operator <=(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks <= t2._ticks;
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00068DA3 File Offset: 0x00066FA3
		public static bool operator >(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks > t2._ticks;
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x00068DB3 File Offset: 0x00066FB3
		public static bool operator >=(TimeSpan t1, TimeSpan t2)
		{
			return t1._ticks >= t2._ticks;
		}

		// Token: 0x0400064B RID: 1611
		public const long NanosecondsPerTick = 100L;

		// Token: 0x0400064C RID: 1612
		public const long TicksPerMicrosecond = 10L;

		// Token: 0x0400064D RID: 1613
		public const long TicksPerMillisecond = 10000L;

		// Token: 0x0400064E RID: 1614
		public const long TicksPerSecond = 10000000L;

		// Token: 0x0400064F RID: 1615
		public const long TicksPerMinute = 600000000L;

		// Token: 0x04000650 RID: 1616
		public const long TicksPerHour = 36000000000L;

		// Token: 0x04000651 RID: 1617
		public const long TicksPerDay = 864000000000L;

		// Token: 0x04000652 RID: 1618
		public const long MicrosecondsPerMillisecond = 1000L;

		// Token: 0x04000653 RID: 1619
		public const long MicrosecondsPerSecond = 1000000L;

		// Token: 0x04000654 RID: 1620
		public const long MicrosecondsPerMinute = 60000000L;

		// Token: 0x04000655 RID: 1621
		public const long MicrosecondsPerHour = 3600000000L;

		// Token: 0x04000656 RID: 1622
		public const long MicrosecondsPerDay = 86400000000L;

		// Token: 0x04000657 RID: 1623
		public const long MillisecondsPerSecond = 1000L;

		// Token: 0x04000658 RID: 1624
		public const long MillisecondsPerMinute = 60000L;

		// Token: 0x04000659 RID: 1625
		public const long MillisecondsPerHour = 3600000L;

		// Token: 0x0400065A RID: 1626
		public const long MillisecondsPerDay = 86400000L;

		// Token: 0x0400065B RID: 1627
		public const long SecondsPerMinute = 60L;

		// Token: 0x0400065C RID: 1628
		public const long SecondsPerHour = 3600L;

		// Token: 0x0400065D RID: 1629
		public const long SecondsPerDay = 86400L;

		// Token: 0x0400065E RID: 1630
		public const long MinutesPerHour = 60L;

		// Token: 0x0400065F RID: 1631
		public const long MinutesPerDay = 1440L;

		// Token: 0x04000660 RID: 1632
		public const int HoursPerDay = 24;

		// Token: 0x04000661 RID: 1633
		public static readonly TimeSpan Zero = new TimeSpan(0L);

		// Token: 0x04000662 RID: 1634
		public static readonly TimeSpan MaxValue = new TimeSpan(long.MaxValue);

		// Token: 0x04000663 RID: 1635
		public static readonly TimeSpan MinValue = new TimeSpan(long.MinValue);

		// Token: 0x04000664 RID: 1636
		internal readonly long _ticks;
	}
}
