using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000ED RID: 237
	public readonly struct DateOnly : IComparable, IComparable<DateOnly>, IEquatable<DateOnly>, ISpanFormattable, IFormattable, ISpanParsable<DateOnly>, IParsable<DateOnly>, IUtf8SpanFormattable
	{
		// Token: 0x06000DA4 RID: 3492 RVA: 0x000250DF File Offset: 0x000232DF
		private static int DayNumberFromDateTime(DateTime dt)
		{
			return (int)(dt.Ticks / 864000000000L);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x000250F3 File Offset: 0x000232F3
		private DateTime GetEquivalentDateTime()
		{
			return DateTime.UnsafeCreate((long)this._dayNumber * 864000000000L);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0002510B File Offset: 0x0002330B
		private DateOnly(int dayNumber)
		{
			this._dayNumber = dayNumber;
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00025114 File Offset: 0x00023314
		public static DateOnly MinValue
		{
			get
			{
				return new DateOnly(0);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x0002511C File Offset: 0x0002331C
		public static DateOnly MaxValue
		{
			get
			{
				return new DateOnly(3652058);
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00025128 File Offset: 0x00023328
		public DateOnly(int year, int month, int day)
		{
			this._dayNumber = DateOnly.DayNumberFromDateTime(new DateTime(year, month, day));
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0002513D File Offset: 0x0002333D
		[NullableContext(1)]
		public DateOnly(int year, int month, int day, Calendar calendar)
		{
			this._dayNumber = DateOnly.DayNumberFromDateTime(new DateTime(year, month, day, calendar));
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00025154 File Offset: 0x00023354
		public static DateOnly FromDayNumber(int dayNumber)
		{
			if (dayNumber > 3652058)
			{
				ThrowHelper.ThrowArgumentOutOfRange_DayNumber(dayNumber);
			}
			return new DateOnly(dayNumber);
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000DAC RID: 3500 RVA: 0x0002516C File Offset: 0x0002336C
		public int Year
		{
			get
			{
				return this.GetEquivalentDateTime().Year;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x00025188 File Offset: 0x00023388
		public int Month
		{
			get
			{
				return this.GetEquivalentDateTime().Month;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000DAE RID: 3502 RVA: 0x000251A4 File Offset: 0x000233A4
		public int Day
		{
			get
			{
				return this.GetEquivalentDateTime().Day;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x000251BF File Offset: 0x000233BF
		public DayOfWeek DayOfWeek
		{
			get
			{
				return (this._dayNumber + DayOfWeek.Monday) % (DayOfWeek)7;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x000251CC File Offset: 0x000233CC
		public int DayOfYear
		{
			get
			{
				return this.GetEquivalentDateTime().DayOfYear;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x000251E7 File Offset: 0x000233E7
		public int DayNumber
		{
			get
			{
				return this._dayNumber;
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x000251EF File Offset: 0x000233EF
		public DateOnly AddDays(int value)
		{
			int num = this._dayNumber + value;
			if (num > 3652058)
			{
				DateOnly.<AddDays>g__ThrowOutOfRange|25_0();
			}
			return new DateOnly(num);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0002520C File Offset: 0x0002340C
		public DateOnly AddMonths(int value)
		{
			return new DateOnly(DateOnly.DayNumberFromDateTime(this.GetEquivalentDateTime().AddMonths(value)));
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00025234 File Offset: 0x00023434
		public DateOnly AddYears(int value)
		{
			return new DateOnly(DateOnly.DayNumberFromDateTime(this.GetEquivalentDateTime().AddYears(value)));
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0002525A File Offset: 0x0002345A
		public static bool operator ==(DateOnly left, DateOnly right)
		{
			return left._dayNumber == right._dayNumber;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0002526A File Offset: 0x0002346A
		public static bool operator !=(DateOnly left, DateOnly right)
		{
			return left._dayNumber != right._dayNumber;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0002527D File Offset: 0x0002347D
		public static bool operator >(DateOnly left, DateOnly right)
		{
			return left._dayNumber > right._dayNumber;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0002528D File Offset: 0x0002348D
		public static bool operator >=(DateOnly left, DateOnly right)
		{
			return left._dayNumber >= right._dayNumber;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x000252A0 File Offset: 0x000234A0
		public static bool operator <(DateOnly left, DateOnly right)
		{
			return left._dayNumber < right._dayNumber;
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x000252B0 File Offset: 0x000234B0
		public static bool operator <=(DateOnly left, DateOnly right)
		{
			return left._dayNumber <= right._dayNumber;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x000252C4 File Offset: 0x000234C4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Deconstruct(out int year, out int month, out int day)
		{
			this.GetEquivalentDateTime().GetDate(out year, out month, out day);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000252E2 File Offset: 0x000234E2
		public DateTime ToDateTime(TimeOnly time)
		{
			return new DateTime((long)this._dayNumber * 864000000000L + time.Ticks);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00025302 File Offset: 0x00023502
		public DateTime ToDateTime(TimeOnly time, DateTimeKind kind)
		{
			return new DateTime((long)this._dayNumber * 864000000000L + time.Ticks, kind);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00025323 File Offset: 0x00023523
		public static DateOnly FromDateTime(DateTime dateTime)
		{
			return new DateOnly(DateOnly.DayNumberFromDateTime(dateTime));
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00025330 File Offset: 0x00023530
		public int CompareTo(DateOnly value)
		{
			return this._dayNumber.CompareTo(value._dayNumber);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00025344 File Offset: 0x00023544
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (value is DateOnly)
			{
				DateOnly value2 = (DateOnly)value;
				return this.CompareTo(value2);
			}
			throw new ArgumentException(SR.Arg_MustBeDateOnly);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0002525A File Offset: 0x0002345A
		public bool Equals(DateOnly value)
		{
			return this._dayNumber == value._dayNumber;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0002537C File Offset: 0x0002357C
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			if (value is DateOnly)
			{
				DateOnly dateOnly = (DateOnly)value;
				return this._dayNumber == dateOnly._dayNumber;
			}
			return false;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x000251E7 File Offset: 0x000233E7
		public override int GetHashCode()
		{
			return this._dayNumber;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x000253A8 File Offset: 0x000235A8
		public static DateOnly Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider = null, DateTimeStyles style = DateTimeStyles.None)
		{
			DateOnly result;
			ParseFailureKind parseFailureKind = DateOnly.TryParseInternal(s, provider, style, out result);
			if (parseFailureKind != ParseFailureKind.None)
			{
				DateOnly.ThrowOnError(parseFailureKind, s);
			}
			return result;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x000253CC File Offset: 0x000235CC
		public static DateOnly ParseExact(ReadOnlySpan<char> s, [StringSyntax("DateOnlyFormat")] ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider provider = null, DateTimeStyles style = DateTimeStyles.None)
		{
			DateOnly result;
			ParseFailureKind parseFailureKind = DateOnly.TryParseExactInternal(s, format, provider, style, out result);
			if (parseFailureKind != ParseFailureKind.None)
			{
				DateOnly.ThrowOnError(parseFailureKind, s);
			}
			return result;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x000253F0 File Offset: 0x000235F0
		public static DateOnly ParseExact(ReadOnlySpan<char> s, [Nullable(1)] [StringSyntax("DateOnlyFormat")] string[] formats)
		{
			return DateOnly.ParseExact(s, formats, null, DateTimeStyles.None);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x000253FC File Offset: 0x000235FC
		public static DateOnly ParseExact(ReadOnlySpan<char> s, [Nullable(1)] [StringSyntax("DateOnlyFormat")] string[] formats, [Nullable(2)] IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			DateOnly result;
			ParseFailureKind parseFailureKind = DateOnly.TryParseExactInternal(s, formats, provider, style, out result);
			if (parseFailureKind != ParseFailureKind.None)
			{
				DateOnly.ThrowOnError(parseFailureKind, s);
			}
			return result;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00025420 File Offset: 0x00023620
		[NullableContext(1)]
		public static DateOnly Parse(string s)
		{
			return DateOnly.Parse(s, null, DateTimeStyles.None);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0002542A File Offset: 0x0002362A
		[NullableContext(1)]
		public static DateOnly Parse(string s, [Nullable(2)] IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateOnly.Parse(s.AsSpan(), provider, style);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00025443 File Offset: 0x00023643
		[NullableContext(1)]
		public static DateOnly ParseExact(string s, [StringSyntax("DateOnlyFormat")] string format)
		{
			return DateOnly.ParseExact(s, format, null, DateTimeStyles.None);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0002544E File Offset: 0x0002364E
		[NullableContext(1)]
		public static DateOnly ParseExact(string s, [StringSyntax("DateOnlyFormat")] string format, [Nullable(2)] IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			return DateOnly.ParseExact(s.AsSpan(), format.AsSpan(), provider, style);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00025477 File Offset: 0x00023677
		[NullableContext(1)]
		public static DateOnly ParseExact(string s, [StringSyntax("DateOnlyFormat")] string[] formats)
		{
			return DateOnly.ParseExact(s, formats, null, DateTimeStyles.None);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00025482 File Offset: 0x00023682
		[NullableContext(1)]
		public static DateOnly ParseExact(string s, [StringSyntax("DateOnlyFormat")] string[] formats, [Nullable(2)] IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateOnly.ParseExact(s.AsSpan(), formats, provider, style);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0002549C File Offset: 0x0002369C
		public static bool TryParse(ReadOnlySpan<char> s, out DateOnly result)
		{
			return DateOnly.TryParse(s, null, DateTimeStyles.None, out result);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x000254A7 File Offset: 0x000236A7
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, DateTimeStyles style, out DateOnly result)
		{
			return DateOnly.TryParseInternal(s, provider, style, out result) == ParseFailureKind.None;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000254B8 File Offset: 0x000236B8
		private static ParseFailureKind TryParseInternal(ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles style, out DateOnly result)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite)) != DateTimeStyles.None)
			{
				result = default(DateOnly);
				return ParseFailureKind.Argument_InvalidDateStyles;
			}
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (!DateTimeParse.TryParse(s, DateTimeFormatInfo.GetInstance(provider), style, ref dateTimeResult))
			{
				result = default(DateOnly);
				return ParseFailureKind.Format_BadDateOnly;
			}
			if ((dateTimeResult.flags & (ParseFlags.HaveHour | ParseFlags.HaveMinute | ParseFlags.HaveSecond | ParseFlags.HaveTime | ParseFlags.TimeZoneUsed | ParseFlags.TimeZoneUtc | ParseFlags.CaptureOffset | ParseFlags.UtcSortPattern)) != (ParseFlags)0)
			{
				result = default(DateOnly);
				return ParseFailureKind.Format_DateTimeOnlyContainsNoneDateParts;
			}
			result = new DateOnly(DateOnly.DayNumberFromDateTime(dateTimeResult.parsedDate));
			return ParseFailureKind.None;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0002552F File Offset: 0x0002372F
		public static bool TryParseExact(ReadOnlySpan<char> s, [StringSyntax("DateOnlyFormat")] ReadOnlySpan<char> format, out DateOnly result)
		{
			return DateOnly.TryParseExact(s, format, null, DateTimeStyles.None, out result);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0002553B File Offset: 0x0002373B
		public static bool TryParseExact(ReadOnlySpan<char> s, [StringSyntax("DateOnlyFormat")] ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider provider, DateTimeStyles style, out DateOnly result)
		{
			return DateOnly.TryParseExactInternal(s, format, provider, style, out result) == ParseFailureKind.None;
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0002554C File Offset: 0x0002374C
		private unsafe static ParseFailureKind TryParseExactInternal(ReadOnlySpan<char> s, ReadOnlySpan<char> format, IFormatProvider provider, DateTimeStyles style, out DateOnly result)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite)) != DateTimeStyles.None)
			{
				result = default(DateOnly);
				return ParseFailureKind.Argument_InvalidDateStyles;
			}
			if (format.Length == 1)
			{
				int num = (int)(*format[0] | 32);
				if (num != 111)
				{
					if (num == 114)
					{
						format = "ddd, dd MMM yyyy";
						provider = CultureInfo.InvariantCulture.DateTimeFormat;
					}
				}
				else
				{
					format = "yyyy'-'MM'-'dd";
					provider = CultureInfo.InvariantCulture.DateTimeFormat;
				}
			}
			DateTimeResult dateTimeResult = default(DateTimeResult);
			dateTimeResult.Init(s);
			if (!DateTimeParse.TryParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style, ref dateTimeResult))
			{
				result = default(DateOnly);
				return ParseFailureKind.Format_BadDateOnly;
			}
			if ((dateTimeResult.flags & (ParseFlags.HaveHour | ParseFlags.HaveMinute | ParseFlags.HaveSecond | ParseFlags.HaveTime | ParseFlags.TimeZoneUsed | ParseFlags.TimeZoneUtc | ParseFlags.CaptureOffset | ParseFlags.UtcSortPattern)) != (ParseFlags)0)
			{
				result = default(DateOnly);
				return ParseFailureKind.Format_DateTimeOnlyContainsNoneDateParts;
			}
			result = new DateOnly(DateOnly.DayNumberFromDateTime(dateTimeResult.parsedDate));
			return ParseFailureKind.None;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0002561D File Offset: 0x0002381D
		public static bool TryParseExact(ReadOnlySpan<char> s, [Nullable(2)] [NotNullWhen(true)] [StringSyntax("DateOnlyFormat")] string[] formats, out DateOnly result)
		{
			return DateOnly.TryParseExact(s, formats, null, DateTimeStyles.None, out result);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00025629 File Offset: 0x00023829
		[NullableContext(2)]
		public static bool TryParseExact([Nullable(0)] ReadOnlySpan<char> s, [NotNullWhen(true)] [StringSyntax("DateOnlyFormat")] string[] formats, IFormatProvider provider, DateTimeStyles style, out DateOnly result)
		{
			return DateOnly.TryParseExactInternal(s, formats, provider, style, out result) == ParseFailureKind.None;
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0002563C File Offset: 0x0002383C
		private static ParseFailureKind TryParseExactInternal(ReadOnlySpan<char> s, string[] formats, IFormatProvider provider, DateTimeStyles style, out DateOnly result)
		{
			if ((style & ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite)) != DateTimeStyles.None || formats == null)
			{
				result = default(DateOnly);
				return ParseFailureKind.Argument_InvalidDateStyles;
			}
			DateTimeFormatInfo instance = DateTimeFormatInfo.GetInstance(provider);
			for (int i = 0; i < formats.Length; i++)
			{
				DateTimeFormatInfo dtfi = instance;
				string text = formats[i];
				if (string.IsNullOrEmpty(text))
				{
					result = default(DateOnly);
					return ParseFailureKind.Argument_BadFormatSpecifier;
				}
				if (text.Length == 1)
				{
					int num = (int)(text[0] | ' ');
					if (num != 111)
					{
						if (num == 114)
						{
							text = "ddd, dd MMM yyyy";
							dtfi = CultureInfo.InvariantCulture.DateTimeFormat;
						}
					}
					else
					{
						text = "yyyy'-'MM'-'dd";
						dtfi = CultureInfo.InvariantCulture.DateTimeFormat;
					}
				}
				DateTimeResult dateTimeResult = default(DateTimeResult);
				dateTimeResult.Init(s);
				if (DateTimeParse.TryParseExact(s, text, dtfi, style, ref dateTimeResult) && (dateTimeResult.flags & (ParseFlags.HaveHour | ParseFlags.HaveMinute | ParseFlags.HaveSecond | ParseFlags.HaveTime | ParseFlags.TimeZoneUsed | ParseFlags.TimeZoneUtc | ParseFlags.CaptureOffset | ParseFlags.UtcSortPattern)) == (ParseFlags)0)
				{
					result = new DateOnly(DateOnly.DayNumberFromDateTime(dateTimeResult.parsedDate));
					return ParseFailureKind.None;
				}
			}
			result = default(DateOnly);
			return ParseFailureKind.Format_BadDateOnly;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0002572D File Offset: 0x0002392D
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out DateOnly result)
		{
			return DateOnly.TryParse(s, null, DateTimeStyles.None, out result);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00025738 File Offset: 0x00023938
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, DateTimeStyles style, out DateOnly result)
		{
			if (s == null)
			{
				result = default(DateOnly);
				return false;
			}
			return DateOnly.TryParse(s.AsSpan(), provider, style, out result);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00025754 File Offset: 0x00023954
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string s, [NotNullWhen(true)] [StringSyntax("DateOnlyFormat")] string format, out DateOnly result)
		{
			return DateOnly.TryParseExact(s, format, null, DateTimeStyles.None, out result);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00025760 File Offset: 0x00023960
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string s, [NotNullWhen(true)] [StringSyntax("DateOnlyFormat")] string format, IFormatProvider provider, DateTimeStyles style, out DateOnly result)
		{
			if (s == null || format == null)
			{
				result = default(DateOnly);
				return false;
			}
			return DateOnly.TryParseExact(s.AsSpan(), format.AsSpan(), provider, style, out result);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00025787 File Offset: 0x00023987
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string s, [NotNullWhen(true)] [StringSyntax("DateOnlyFormat")] string[] formats, out DateOnly result)
		{
			return DateOnly.TryParseExact(s, formats, null, DateTimeStyles.None, out result);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00025793 File Offset: 0x00023993
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string s, [NotNullWhen(true)] [StringSyntax("DateOnlyFormat")] string[] formats, IFormatProvider provider, DateTimeStyles style, out DateOnly result)
		{
			if (s == null)
			{
				result = default(DateOnly);
				return false;
			}
			return DateOnly.TryParseExact(s.AsSpan(), formats, provider, style, out result);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x000257B4 File Offset: 0x000239B4
		private static void ThrowOnError(ParseFailureKind result, ReadOnlySpan<char> s)
		{
			switch (result)
			{
			case ParseFailureKind.Argument_InvalidDateStyles:
				throw new ArgumentException(SR.Argument_InvalidDateStyles, "style");
			case ParseFailureKind.Argument_BadFormatSpecifier:
				throw new FormatException(SR.Argument_BadFormatSpecifier);
			case ParseFailureKind.Format_BadDateOnly:
				throw new FormatException(SR.Format(SR.Format_BadDateOnly, s.ToString()));
			default:
				throw new FormatException(SR.Format(SR.Format_DateTimeOnlyContainsNoneDateParts, s.ToString(), "DateOnly"));
			}
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00025831 File Offset: 0x00023A31
		[NullableContext(1)]
		public string ToLongDateString()
		{
			return this.ToString("D");
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0002583E File Offset: 0x00023A3E
		[NullableContext(1)]
		public string ToShortDateString()
		{
			return this.ToString();
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0002584C File Offset: 0x00023A4C
		[NullableContext(1)]
		public override string ToString()
		{
			return this.ToString("d");
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00025859 File Offset: 0x00023A59
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("DateOnlyFormat")] string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00025863 File Offset: 0x00023A63
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return this.ToString("d", provider);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00025874 File Offset: 0x00023A74
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("DateOnlyFormat")] string format, IFormatProvider provider)
		{
			if (string.IsNullOrEmpty(format))
			{
				format = "d";
			}
			if (format.Length == 1)
			{
				int num = (int)(format[0] | ' ');
				if (num <= 109)
				{
					if (num != 100 && num != 109)
					{
						goto IL_B6;
					}
				}
				else
				{
					if (num == 111)
					{
						return string.Create<DateOnly>(10, this, delegate(Span<char> destination, DateOnly value)
						{
							int num2;
							DateTimeFormat.TryFormatDateOnlyO<char>(value.Year, value.Month, value.Day, destination, out num2);
						});
					}
					if (num == 114)
					{
						return string.Create<DateOnly>(16, this, delegate(Span<char> destination, DateOnly value)
						{
							int num2;
							DateTimeFormat.TryFormatDateOnlyR<char>(value.DayOfWeek, value.Year, value.Month, value.Day, destination, out num2);
						});
					}
					if (num != 121)
					{
						goto IL_B6;
					}
				}
				return DateTimeFormat.Format(this.GetEquivalentDateTime(), format, provider);
				IL_B6:
				throw new FormatException(SR.Format_InvalidString);
			}
			DateTimeFormat.IsValidCustomDateOnlyFormat(format.AsSpan(), true);
			return DateTimeFormat.Format(this.GetEquivalentDateTime(), format, provider);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0002595E File Offset: 0x00023B5E
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("DateOnlyFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return this.TryFormatCore<char>(destination, out charsWritten, format, provider);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0002596B File Offset: 0x00023B6B
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("DateOnlyFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return this.TryFormatCore<byte>(utf8Destination, out bytesWritten, format, provider);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00025978 File Offset: 0x00023B78
		private unsafe bool TryFormatCore<[IsUnmanaged] TChar>(Span<TChar> destination, out int charsWritten, [StringSyntax("DateOnlyFormat")] ReadOnlySpan<char> format, IFormatProvider provider = null) where TChar : struct, ValueType, IUtfChar<TChar>
		{
			if (format.Length == 0)
			{
				format = "d";
			}
			if (format.Length == 1)
			{
				int num = (int)(*format[0] | 32);
				if (num <= 109)
				{
					if (num != 100 && num != 109)
					{
						goto IL_99;
					}
				}
				else
				{
					if (num == 111)
					{
						return DateTimeFormat.TryFormatDateOnlyO<TChar>(this.Year, this.Month, this.Day, destination, out charsWritten);
					}
					if (num == 114)
					{
						return DateTimeFormat.TryFormatDateOnlyR<TChar>(this.DayOfWeek, this.Year, this.Month, this.Day, destination, out charsWritten);
					}
					if (num != 121)
					{
						goto IL_99;
					}
				}
				return DateTimeFormat.TryFormat<TChar>(this.GetEquivalentDateTime(), destination, out charsWritten, format, provider);
				IL_99:
				ThrowHelper.ThrowFormatException_BadFormatSpecifier();
			}
			if (!DateTimeFormat.IsValidCustomDateOnlyFormat(format, false))
			{
				throw new FormatException(SR.Format(SR.Format_DateTimeOnlyContainsNoneDateParts, format.ToString(), "DateOnly"));
			}
			return DateTimeFormat.TryFormat<TChar>(this.GetEquivalentDateTime(), destination, out charsWritten, format, provider);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00025A5E File Offset: 0x00023C5E
		[NullableContext(1)]
		public static DateOnly Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return DateOnly.Parse(s, provider, DateTimeStyles.None);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00025A68 File Offset: 0x00023C68
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out DateOnly result)
		{
			return DateOnly.TryParse(s, provider, DateTimeStyles.None, out result);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00025A73 File Offset: 0x00023C73
		public static DateOnly Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return DateOnly.Parse(s, provider, DateTimeStyles.None);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00025A7D File Offset: 0x00023C7D
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out DateOnly result)
		{
			return DateOnly.TryParse(s, provider, DateTimeStyles.None, out result);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00025A88 File Offset: 0x00023C88
		[CompilerGenerated]
		internal static void <AddDays>g__ThrowOutOfRange|25_0()
		{
			throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_AddValue);
		}

		// Token: 0x04000315 RID: 789
		private readonly int _dayNumber;
	}
}
