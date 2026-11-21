using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System
{
	// Token: 0x020000EF RID: 239
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public readonly struct DateTime : IComparable, ISpanFormattable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanParsable<DateTime>, IParsable<DateTime>, IUtf8SpanFormattable
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00025B06 File Offset: 0x00023D06
		internal static ReadOnlySpan<uint> DaysToMonth365
		{
			get
			{
				return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA4).FieldHandle);
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00025B12 File Offset: 0x00023D12
		internal static ReadOnlySpan<uint> DaysToMonth366
		{
			get
			{
				return RuntimeHelpers.CreateSpan<uint>(fieldof(<PrivateImplementationDetails>.FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D83154).FieldHandle);
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00025B1E File Offset: 0x00023D1E
		private unsafe static ReadOnlySpan<byte> DaysInMonth365
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.9D61D7D7A1AA7E8ED5214C2F39E0C55230433C7BA728C92913CA4E1967FAF8EA), 12);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00025B2C File Offset: 0x00023D2C
		private unsafe static ReadOnlySpan<byte> DaysInMonth366
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.69EADD2D8A0D38E5F581C5F3533EE497009AD4A2B8ECA04B388D4CB5B41ACEA5), 12);
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00025B3A File Offset: 0x00023D3A
		public DateTime(long ticks)
		{
			if (ticks > 3155378975999999999L)
			{
				DateTime.ThrowTicksOutOfRange();
			}
			this._dateData = (ulong)ticks;
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x00025B54 File Offset: 0x00023D54
		private DateTime(ulong dateData)
		{
			this._dateData = dateData;
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00025B5D File Offset: 0x00023D5D
		internal static DateTime UnsafeCreate(long ticks)
		{
			return new DateTime((ulong)ticks);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00025B65 File Offset: 0x00023D65
		public DateTime(long ticks, DateTimeKind kind)
		{
			if (ticks > 3155378975999999999L)
			{
				DateTime.ThrowTicksOutOfRange();
			}
			if (kind > DateTimeKind.Local)
			{
				DateTime.ThrowInvalidKind();
			}
			this._dateData = (ulong)(ticks | (long)((long)((ulong)kind) << 62));
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00025B8E File Offset: 0x00023D8E
		public DateTime(DateOnly date, TimeOnly time)
		{
			this._dateData = (ulong)((long)date.DayNumber * 864000000000L + time.Ticks);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00025BB0 File Offset: 0x00023DB0
		public DateTime(DateOnly date, TimeOnly time, DateTimeKind kind)
		{
			if (kind > DateTimeKind.Local)
			{
				DateTime.ThrowInvalidKind();
			}
			this._dateData = (ulong)((long)date.DayNumber * 864000000000L + time.Ticks | (long)((long)((ulong)kind) << 62));
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00025BE1 File Offset: 0x00023DE1
		internal DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst)
		{
			if (ticks > 3155378975999999999L)
			{
				DateTime.ThrowTicksOutOfRange();
			}
			this._dateData = (ulong)(ticks | (isAmbiguousDst ? -4611686018427387904L : long.MinValue));
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00025C13 File Offset: 0x00023E13
		private static void ThrowTicksOutOfRange()
		{
			throw new ArgumentOutOfRangeException("ticks", SR.ArgumentOutOfRange_DateTimeBadTicks);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00025C24 File Offset: 0x00023E24
		private static void ThrowInvalidKind()
		{
			throw new ArgumentException(SR.Argument_InvalidDateTimeKind, "kind");
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00025C35 File Offset: 0x00023E35
		private static void ThrowMillisecondOutOfRange()
		{
			throw new ArgumentOutOfRangeException("millisecond", SR.Format(SR.ArgumentOutOfRange_Range, 0, 999L));
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00025C5C File Offset: 0x00023E5C
		private static void ThrowMicrosecondOutOfRange()
		{
			throw new ArgumentOutOfRangeException("microsecond", SR.Format(SR.ArgumentOutOfRange_Range, 0, 999L));
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00025C84 File Offset: 0x00023E84
		private static void ThrowDateArithmetic(int param)
		{
			string paramName;
			if (param != 0)
			{
				if (param != 1)
				{
					paramName = "months";
				}
				else
				{
					paramName = "t";
				}
			}
			else
			{
				paramName = "value";
			}
			throw new ArgumentOutOfRangeException(paramName, SR.ArgumentOutOfRange_DateArithmetic);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00025A88 File Offset: 0x00023C88
		private static void ThrowAddOutOfRange()
		{
			throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_AddValue);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00025CBB File Offset: 0x00023EBB
		public DateTime(int year, int month, int day)
		{
			this._dateData = DateTime.DateToTicks(year, month, day);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00025CCB File Offset: 0x00023ECB
		[NullableContext(1)]
		public DateTime(int year, int month, int day, Calendar calendar)
		{
			this = new DateTime(year, month, day, 0, 0, 0, calendar);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00025CDC File Offset: 0x00023EDC
		[NullableContext(1)]
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, DateTimeKind kind)
		{
			ArgumentNullException.ThrowIfNull(calendar, "calendar");
			if ((ulong)millisecond >= 1000UL)
			{
				DateTime.ThrowMillisecondOutOfRange();
			}
			if (kind > DateTimeKind.Local)
			{
				DateTime.ThrowInvalidKind();
			}
			if (second != 60 || !DateTime.SystemSupportsLeapSeconds)
			{
				ulong uticks = calendar.ToDateTime(year, month, day, hour, minute, second, millisecond).UTicks;
				this._dateData = (uticks | (ulong)((ulong)((long)kind) << 62));
				return;
			}
			this = new DateTime(year, month, day, hour, minute, 59, millisecond, calendar, kind);
			this.ValidateLeapSecond();
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00025D68 File Offset: 0x00023F68
		public DateTime(int year, int month, int day, int hour, int minute, int second)
		{
			if (second != 60 || !DateTime.SystemSupportsLeapSeconds)
			{
				this._dateData = DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second);
				return;
			}
			this = new DateTime(year, month, day, hour, minute, 59);
			this.ValidateLeapSecond();
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00025DB8 File Offset: 0x00023FB8
		public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
		{
			if (kind > DateTimeKind.Local)
			{
				DateTime.ThrowInvalidKind();
			}
			if (second != 60 || !DateTime.SystemSupportsLeapSeconds)
			{
				ulong num = DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second);
				this._dateData = (num | (ulong)((ulong)((long)kind) << 62));
				return;
			}
			this = new DateTime(year, month, day, hour, minute, 59, kind);
			this.ValidateLeapSecond();
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00025E1C File Offset: 0x0002401C
		[NullableContext(1)]
		public DateTime(int year, int month, int day, int hour, int minute, int second, Calendar calendar)
		{
			ArgumentNullException.ThrowIfNull(calendar, "calendar");
			if (second != 60 || !DateTime.SystemSupportsLeapSeconds)
			{
				this._dateData = calendar.ToDateTime(year, month, day, hour, minute, second, 0).UTicks;
				return;
			}
			this = new DateTime(year, month, day, hour, minute, 59, calendar);
			this.ValidateLeapSecond();
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00025E80 File Offset: 0x00024080
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			this._dateData = DateTime.Init(year, month, day, hour, minute, second, millisecond, DateTimeKind.Unspecified);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00025EA4 File Offset: 0x000240A4
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind)
		{
			this._dateData = DateTime.Init(year, month, day, hour, minute, second, millisecond, kind);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00025ECC File Offset: 0x000240CC
		[NullableContext(1)]
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar)
		{
			ArgumentNullException.ThrowIfNull(calendar, "calendar");
			if (second != 60 || !DateTime.SystemSupportsLeapSeconds)
			{
				this._dateData = calendar.ToDateTime(year, month, day, hour, minute, second, millisecond).UTicks;
				return;
			}
			this = new DateTime(year, month, day, hour, minute, 59, millisecond, calendar);
			this.ValidateLeapSecond();
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00025F34 File Offset: 0x00024134
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond)
		{
			this = new DateTime(year, month, day, hour, minute, second, millisecond, microsecond, DateTimeKind.Unspecified);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00025F58 File Offset: 0x00024158
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond, DateTimeKind kind)
		{
			ulong num = DateTime.Init(year, month, day, hour, minute, second, millisecond, kind);
			if ((ulong)microsecond >= 1000UL)
			{
				DateTime.ThrowMicrosecondOutOfRange();
			}
			ulong num2 = (num & 4611686018427387903UL) + (ulong)((long)microsecond * 10L);
			this._dateData = (num2 | (num & 13835058055282163712UL));
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00025FB0 File Offset: 0x000241B0
		[NullableContext(1)]
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond, Calendar calendar)
		{
			this = new DateTime(year, month, day, hour, minute, second, millisecond, microsecond, calendar, DateTimeKind.Unspecified);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00025FD4 File Offset: 0x000241D4
		[NullableContext(1)]
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int microsecond, Calendar calendar, DateTimeKind kind)
		{
			this = new DateTime(year, month, day, hour, minute, second, millisecond, calendar, kind);
			if ((ulong)microsecond >= 1000UL)
			{
				DateTime.ThrowMicrosecondOutOfRange();
			}
			this._dateData = new DateTime(this._dateData).AddMicroseconds((double)microsecond)._dateData;
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00026028 File Offset: 0x00024228
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong Init(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind = DateTimeKind.Unspecified)
		{
			if ((ulong)millisecond >= 1000UL)
			{
				DateTime.ThrowMillisecondOutOfRange();
			}
			if (kind > DateTimeKind.Local)
			{
				DateTime.ThrowInvalidKind();
			}
			if (second != 60 || !DateTime.SystemSupportsLeapSeconds)
			{
				return DateTime.DateToTicks(year, month, day) + DateTime.TimeToTicks(hour, minute, second) + (ulong)(millisecond * 10000) | (ulong)((ulong)((long)kind) << 62);
			}
			ref DateTime ptr = new DateTime(year, month, day, hour, minute, 59, millisecond, kind);
			if (!DateTime.IsValidTimeWithLeapSeconds(year, month, day, hour, 59, kind))
			{
				ThrowHelper.ThrowArgumentOutOfRange_BadHourMinuteSecond();
			}
			return ptr._dateData;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x000260AB File Offset: 0x000242AB
		private void ValidateLeapSecond()
		{
			if (!DateTime.IsValidTimeWithLeapSeconds(this.Year, this.Month, this.Day, this.Hour, this.Minute, this.Kind))
			{
				ThrowHelper.ThrowArgumentOutOfRange_BadHourMinuteSecond();
			}
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x000260E0 File Offset: 0x000242E0
		private DateTime(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.info);
			}
			bool flag = false;
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				if (!(name == "ticks"))
				{
					if (name == "dateData")
					{
						this._dateData = Convert.ToUInt64(enumerator.Value, CultureInfo.InvariantCulture);
						IL_7F:
						if (this.UTicks > 3155378975999999999UL)
						{
							throw new SerializationException(SR.Serialization_DateTimeTicksOutOfRange);
						}
						return;
					}
				}
				else
				{
					this._dateData = (ulong)Convert.ToInt64(enumerator.Value, CultureInfo.InvariantCulture);
					flag = true;
				}
			}
			if (!flag)
			{
				throw new SerializationException(SR.Serialization_MissingDateTimeData);
			}
			goto IL_7F;
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00026188 File Offset: 0x00024388
		private ulong UTicks
		{
			get
			{
				return this._dateData & 4611686018427387903UL;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0002619A File Offset: 0x0002439A
		private ulong InternalKind
		{
			get
			{
				return this._dateData & 13835058055282163712UL;
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x000261AC File Offset: 0x000243AC
		public DateTime Add(TimeSpan value)
		{
			return this.AddTicks(value._ticks);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000261BC File Offset: 0x000243BC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private DateTime AddUnits(double value, long maxUnitCount, long ticksPerUnit)
		{
			if (Math.Abs(value) > (double)maxUnitCount)
			{
				DateTime.ThrowAddOutOfRange();
			}
			double num = Math.Truncate(value);
			double num2 = value - num;
			long num3 = (long)num * ticksPerUnit;
			num3 += (long)(num2 * (double)ticksPerUnit);
			return this.AddTicks(num3);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000261F7 File Offset: 0x000243F7
		public DateTime AddDays(double value)
		{
			return this.AddUnits(value, 3652058L, 864000000000L);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0002620F File Offset: 0x0002440F
		public DateTime AddHours(double value)
		{
			return this.AddUnits(value, 87649415L, 36000000000L);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x00026227 File Offset: 0x00024427
		public DateTime AddMilliseconds(double value)
		{
			return this.AddUnits(value, 315537897599999L, 10000L);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x0002623F File Offset: 0x0002443F
		public DateTime AddMicroseconds(double value)
		{
			return this.AddUnits(value, 315537897599999999L, 10L);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00026254 File Offset: 0x00024454
		public DateTime AddMinutes(double value)
		{
			return this.AddUnits(value, 5258964959L, 600000000L);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x0002626C File Offset: 0x0002446C
		public unsafe DateTime AddMonths(int months)
		{
			if (months < -120000 || months > 120000)
			{
				throw new ArgumentOutOfRangeException("months", SR.ArgumentOutOfRange_DateTimeBadMonths);
			}
			int num;
			int num2;
			int num3;
			this.GetDate(out num, out num2, out num3);
			int num4 = num;
			int num5 = num3;
			int num6 = num2 + months;
			int num7 = (num6 > 0) ? ((num6 - 1) / 12) : (num6 / 12 - 1);
			num4 += num7;
			num6 -= num7 * 12;
			if (num4 < 1 || num4 > 9999)
			{
				DateTime.ThrowDateArithmetic(2);
			}
			ReadOnlySpan<uint> readOnlySpan = DateTime.IsLeapYear(num4) ? DateTime.DaysToMonth366 : DateTime.DaysToMonth365;
			uint num8 = *readOnlySpan[num6 - 1];
			int num9 = (int)(*readOnlySpan[num6] - num8);
			if (num5 > num9)
			{
				num5 = num9;
			}
			return new DateTime((ulong)(DateTime.DaysToYear((uint)num4) + num8 + (uint)num5 - 1U) * 864000000000UL + this.UTicks % 864000000000UL | this.InternalKind);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0002635A File Offset: 0x0002455A
		public DateTime AddSeconds(double value)
		{
			return this.AddUnits(value, 315537897599L, 10000000L);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00026372 File Offset: 0x00024572
		public DateTime AddTicks(long value)
		{
			long num = this.Ticks + value;
			if (num > 3155378975999999999L)
			{
				DateTime.ThrowDateArithmetic(0);
			}
			return new DateTime((ulong)(num | (long)this.InternalKind));
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0002639C File Offset: 0x0002459C
		internal bool TryAddTicks(long value, out DateTime result)
		{
			ulong num = (ulong)(this.Ticks + value);
			if (num > 3155378975999999999UL)
			{
				result = default(DateTime);
				return false;
			}
			result = new DateTime(num | this.InternalKind);
			return true;
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000263DC File Offset: 0x000245DC
		public unsafe DateTime AddYears(int value)
		{
			if (value < -10000 || value > 10000)
			{
				throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_DateTimeBadYears);
			}
			int num;
			int num2;
			int num3;
			this.GetDate(out num, out num2, out num3);
			int num4 = num + value;
			if (num4 < 1 || num4 > 9999)
			{
				DateTime.ThrowDateArithmetic(0);
			}
			uint num5 = DateTime.DaysToYear((uint)num4);
			int num6 = num2 - 1;
			int num7 = num3 - 1;
			if (DateTime.IsLeapYear(num4))
			{
				num5 += *DateTime.DaysToMonth366[num6];
			}
			else
			{
				if (num7 == 28 && num6 == 1)
				{
					num7--;
				}
				num5 += *DateTime.DaysToMonth365[num6];
			}
			num5 += (uint)num7;
			return new DateTime((ulong)num5 * 864000000000UL + this.UTicks % 864000000000UL | this.InternalKind);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x000264B8 File Offset: 0x000246B8
		public static int Compare(DateTime t1, DateTime t2)
		{
			long ticks = t1.Ticks;
			long ticks2 = t2.Ticks;
			if (ticks > ticks2)
			{
				return 1;
			}
			if (ticks < ticks2)
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x000264E2 File Offset: 0x000246E2
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is DateTime))
			{
				throw new ArgumentException(SR.Arg_MustBeDateTime);
			}
			return DateTime.Compare(this, (DateTime)value);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0002650D File Offset: 0x0002470D
		public int CompareTo(DateTime value)
		{
			return DateTime.Compare(this, value);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0002651C File Offset: 0x0002471C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static ulong DateToTicks(int year, int month, int day)
		{
			if (year < 1 || year > 9999 || month < 1 || month > 12 || day < 1)
			{
				ThrowHelper.ThrowArgumentOutOfRange_BadYearMonthDay();
			}
			ReadOnlySpan<uint> readOnlySpan = DateTime.IsLeapYear(year) ? DateTime.DaysToMonth366 : DateTime.DaysToMonth365;
			if (day > (int)(*readOnlySpan[month] - *readOnlySpan[month - 1]))
			{
				ThrowHelper.ThrowArgumentOutOfRange_BadYearMonthDay();
			}
			return (ulong)(DateTime.DaysToYear((uint)year) + *readOnlySpan[month - 1] + (uint)day - 1U) * 864000000000UL;
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x0002659C File Offset: 0x0002479C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint DaysToYear(uint year)
		{
			uint num = year - 1U;
			uint num2 = num / 100U;
			return num * 1461U / 4U - num2 + num2 / 4U;
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x000265BF File Offset: 0x000247BF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong TimeToTicks(int hour, int minute, int second)
		{
			if (hour >= 24 || minute >= 60 || second >= 60)
			{
				ThrowHelper.ThrowArgumentOutOfRange_BadHourMinuteSecond();
			}
			return (ulong)(hour * 3600 + minute * 60 + second) * 10000000UL;
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x000265EB File Offset: 0x000247EB
		internal static ulong TimeToTicks(int hour, int minute, int second, int millisecond)
		{
			ulong num = DateTime.TimeToTicks(hour, minute, second);
			if ((ulong)millisecond >= 1000UL)
			{
				DateTime.ThrowMillisecondOutOfRange();
			}
			return num + (ulong)(millisecond * 10000);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0002660D File Offset: 0x0002480D
		internal static ulong TimeToTicks(int hour, int minute, int second, int millisecond, int microsecond)
		{
			ulong num = DateTime.TimeToTicks(hour, minute, second, millisecond);
			if ((ulong)microsecond >= 1000UL)
			{
				DateTime.ThrowMicrosecondOutOfRange();
			}
			return num + (ulong)(microsecond * 10);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00026630 File Offset: 0x00024830
		public unsafe static int DaysInMonth(int year, int month)
		{
			if (month < 1 || month > 12)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Month(month);
			}
			return (int)(*(DateTime.IsLeapYear(year) ? DateTime.DaysInMonth366 : DateTime.DaysInMonth365)[month - 1]);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x0002666C File Offset: 0x0002486C
		internal static long DoubleDateToTicks(double value)
		{
			if (value >= 2958466.0 || value <= -657435.0)
			{
				throw new ArgumentException(SR.Arg_OleAutDateInvalid);
			}
			long num = (long)(value * 86400000.0 + ((value >= 0.0) ? 0.5 : -0.5));
			if (num < 0L)
			{
				num -= num % 86400000L * 2L;
			}
			num += 59926435200000L;
			if (num < 0L || num > 315537897599999L)
			{
				throw new ArgumentException(SR.Arg_OleAutDateScale);
			}
			return num * 10000L;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00026710 File Offset: 0x00024910
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object value)
		{
			if (value is DateTime)
			{
				DateTime d = (DateTime)value;
				return this == d;
			}
			return false;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x0002673A File Offset: 0x0002493A
		public bool Equals(DateTime value)
		{
			return this == value;
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00026748 File Offset: 0x00024948
		public static bool Equals(DateTime t1, DateTime t2)
		{
			return t1 == t2;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00026754 File Offset: 0x00024954
		public static DateTime FromBinary(long dateData)
		{
			if ((dateData & -9223372036854775808L) != 0L)
			{
				long num = dateData & 4611686018427387903L;
				if (num > 4611685154427387904L)
				{
					num -= 4611686018427387904L;
				}
				bool isAmbiguousDst = false;
				long ticks;
				if (num < 0L)
				{
					ticks = TimeZoneInfo.GetLocalUtcOffset(DateTime.MinValue, TimeZoneInfoOptions.NoThrowOnInvalidTime).Ticks;
				}
				else if (num > 3155378975999999999L)
				{
					ticks = TimeZoneInfo.GetLocalUtcOffset(DateTime.MaxValue, TimeZoneInfoOptions.NoThrowOnInvalidTime).Ticks;
				}
				else
				{
					bool flag;
					ticks = TimeZoneInfo.GetUtcOffsetFromUtc(new DateTime(num, DateTimeKind.Utc), TimeZoneInfo.Local, out flag, out isAmbiguousDst).Ticks;
				}
				num += ticks;
				if (num < 0L)
				{
					num += 864000000000L;
				}
				if (num > 3155378975999999999L)
				{
					throw new ArgumentException(SR.Argument_DateTimeBadBinaryData, "dateData");
				}
				return new DateTime(num, DateTimeKind.Local, isAmbiguousDst);
			}
			else
			{
				if ((dateData & 4611686018427387903L) > 3155378975999999999L)
				{
					throw new ArgumentException(SR.Argument_DateTimeBadBinaryData, "dateData");
				}
				return new DateTime((ulong)dateData);
			}
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00026858 File Offset: 0x00024A58
		public static DateTime FromFileTime(long fileTime)
		{
			return DateTime.FromFileTimeUtc(fileTime).ToLocalTime();
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00026874 File Offset: 0x00024A74
		public static DateTime FromFileTimeUtc(long fileTime)
		{
			if (fileTime > 2650467743999999999L)
			{
				throw new ArgumentOutOfRangeException("fileTime", SR.ArgumentOutOfRange_FileTimeInvalid);
			}
			if (DateTime.SystemSupportsLeapSeconds)
			{
				return DateTime.FromFileTimeLeapSecondsAware((ulong)fileTime);
			}
			return new DateTime((ulong)(fileTime + 504911232000000000L | 4611686018427387904L));
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x000268C5 File Offset: 0x00024AC5
		public static DateTime FromOADate(double d)
		{
			return new DateTime(DateTime.DoubleDateToTicks(d), DateTimeKind.Unspecified);
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x000268D3 File Offset: 0x00024AD3
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.info);
			}
			info.AddValue("ticks", this.Ticks);
			info.AddValue("dateData", this._dateData);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00026900 File Offset: 0x00024B00
		public bool IsDaylightSavingTime()
		{
			return this.InternalKind != 4611686018427387904UL && TimeZoneInfo.Local.IsDaylightSavingTime(this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00026926 File Offset: 0x00024B26
		public static DateTime SpecifyKind(DateTime value, DateTimeKind kind)
		{
			if (kind > DateTimeKind.Local)
			{
				DateTime.ThrowInvalidKind();
			}
			return new DateTime(value.UTicks | (ulong)((ulong)((long)kind) << 62));
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00026944 File Offset: 0x00024B44
		public long ToBinary()
		{
			if ((this._dateData & 9223372036854775808UL) != 0UL)
			{
				TimeSpan localUtcOffset = TimeZoneInfo.GetLocalUtcOffset(this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
				long num = this.Ticks - localUtcOffset.Ticks;
				if (num < 0L)
				{
					num = 4611686018427387904L + num;
				}
				return num | long.MinValue;
			}
			return (long)this._dateData;
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x000269A2 File Offset: 0x00024BA2
		public DateTime Date
		{
			get
			{
				ulong uticks = this.UTicks;
				return new DateTime(uticks - uticks % 864000000000UL | this.InternalKind);
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000269C4 File Offset: 0x00024BC4
		internal void GetDate(out int year, out int month, out int day)
		{
			ValueTuple<uint, uint> valueTuple = Math.DivRem(((uint)(this.UTicks / 216000000000UL) | 3U) + 1224U, 146097U);
			uint item = valueTuple.Item1;
			uint item2 = valueTuple.Item2;
			ulong num = Math.BigMul(2939745U, item2 | 3U);
			ushort num2 = (ushort)((uint)num / 11758980U);
			int num3 = (int)(2141 * num2) + 197913;
			year = (int)(100U * item + (uint)(num >> 32));
			month = (int)((ushort)(num3 >> 16));
			day = (int)((ushort)num3 / 2141 + 1);
			if (num2 >= 306)
			{
				year++;
				month -= 12;
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00026A60 File Offset: 0x00024C60
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetTime(out int hour, out int minute, out int second)
		{
			ulong num = this.UTicks / 10000000UL;
			ulong num2 = num / 60UL;
			second = (int)(num - num2 * 60UL);
			ulong num3 = num2 / 60UL;
			minute = (int)(num2 - num3 * 60UL);
			hour = (int)((uint)num3 % 24U);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00026AA4 File Offset: 0x00024CA4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetTime(out int hour, out int minute, out int second, out int millisecond)
		{
			ulong num = this.UTicks / 10000UL;
			ulong num2 = num / 1000UL;
			millisecond = (int)(num - num2 * 1000UL);
			ulong num3 = num2 / 60UL;
			second = (int)(num2 - num3 * 60UL);
			ulong num4 = num3 / 60UL;
			minute = (int)(num3 - num4 * 60UL);
			hour = (int)((uint)num4 % 24U);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00026B00 File Offset: 0x00024D00
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void GetTimePrecise(out int hour, out int minute, out int second, out int tick)
		{
			ulong uticks = this.UTicks;
			ulong num = uticks / 10000000UL;
			tick = (int)(uticks - num * 10000000UL);
			ulong num2 = num / 60UL;
			second = (int)(num - num2 * 60UL);
			ulong num3 = num2 / 60UL;
			minute = (int)(num2 - num3 * 60UL);
			hour = (int)((uint)num3 % 24U);
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00026B54 File Offset: 0x00024D54
		public int Day
		{
			get
			{
				uint num = (((uint)(this.UTicks / 216000000000UL) | 3U) + 1224U) % 146097U;
				ushort num2 = (ushort)((uint)Math.BigMul(2939745U, num | 3U) / 11758980U);
				return (int)((ushort)((int)(2141 * num2) + 197913) / 2141 + 1);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00026BAD File Offset: 0x00024DAD
		public DayOfWeek DayOfWeek
		{
			get
			{
				return ((int)((uint)(this.UTicks / 864000000000UL)) + DayOfWeek.Monday) % (DayOfWeek)7;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00026BC4 File Offset: 0x00024DC4
		public int DayOfYear
		{
			get
			{
				return (int)(1U + (((uint)(this.UTicks / 216000000000UL) | 3U) % 146097U | 3U) * 2939745U / 11758980U);
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00026BF0 File Offset: 0x00024DF0
		public override int GetHashCode()
		{
			long ticks = this.Ticks;
			return (int)ticks ^ (int)(ticks >> 32);
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x00026C0C File Offset: 0x00024E0C
		public int Hour
		{
			get
			{
				return (int)((uint)(this.UTicks / 36000000000UL) % 24U);
			}
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00026C22 File Offset: 0x00024E22
		internal bool IsAmbiguousDaylightSavingTime()
		{
			return this.InternalKind == 13835058055282163712UL;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00026C38 File Offset: 0x00024E38
		public DateTimeKind Kind
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				ulong internalKind = this.InternalKind;
				DateTimeKind result;
				if (internalKind != 0UL)
				{
					if (internalKind != 4611686018427387904UL)
					{
						result = DateTimeKind.Local;
					}
					else
					{
						result = DateTimeKind.Utc;
					}
				}
				else
				{
					result = DateTimeKind.Unspecified;
				}
				return result;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00026C68 File Offset: 0x00024E68
		public int Millisecond
		{
			get
			{
				return (int)(this.UTicks / 10000UL % 1000UL);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00026C7F File Offset: 0x00024E7F
		public int Microsecond
		{
			get
			{
				return (int)(this.UTicks / 10UL % 1000UL);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00026C93 File Offset: 0x00024E93
		public int Nanosecond
		{
			get
			{
				return (int)(this.UTicks % 10UL) * 100;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x00026CA3 File Offset: 0x00024EA3
		public int Minute
		{
			get
			{
				return (int)(this.UTicks / 600000000UL % 60UL);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00026CB8 File Offset: 0x00024EB8
		public int Month
		{
			get
			{
				uint num = (((uint)(this.UTicks / 216000000000UL) | 3U) + 1224U) % 146097U;
				ushort num2 = (ushort)((uint)Math.BigMul(2939745U, num | 3U) / 11758980U);
				return (int)((ushort)((int)(2141 * num2) + 197913 >> 16) - ((num2 >= 306) ? 12 : 0));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x00026D1C File Offset: 0x00024F1C
		public static DateTime Now
		{
			get
			{
				DateTime utcNow = DateTime.UtcNow;
				bool flag;
				long ticks = TimeZoneInfo.GetDateTimeNowUtcOffsetFromUtc(utcNow, out flag).Ticks;
				long num = utcNow.Ticks + ticks;
				if (num > 3155378975999999999L)
				{
					return new DateTime((num < 0L) ? 9223372036854775808UL : 12378751012854775807UL);
				}
				if (!flag)
				{
					return new DateTime((ulong)(num | long.MinValue));
				}
				return new DateTime((ulong)(num | -4611686018427387904L));
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00026D9A File Offset: 0x00024F9A
		public int Second
		{
			get
			{
				return (int)(this.UTicks / 10000000UL % 60UL);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00026188 File Offset: 0x00024388
		public long Ticks
		{
			get
			{
				return (long)(this._dateData & 4611686018427387903UL);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00026DAE File Offset: 0x00024FAE
		public TimeSpan TimeOfDay
		{
			get
			{
				return new TimeSpan((long)(this.UTicks % 864000000000UL));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00026DC8 File Offset: 0x00024FC8
		public static DateTime Today
		{
			get
			{
				return DateTime.Now.Date;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00026DE4 File Offset: 0x00024FE4
		public int Year
		{
			get
			{
				ValueTuple<uint, uint> valueTuple = Math.DivRem((uint)(this.UTicks / 216000000000UL) | 3U, 146097U);
				uint item = valueTuple.Item1;
				uint item2 = valueTuple.Item2;
				return (int)(1U + (100U * item + (item2 | 3U) / 1461U));
			}
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00026E2B File Offset: 0x0002502B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsLeapYear(int year)
		{
			if (year < 1 || year > 9999)
			{
				ThrowHelper.ThrowArgumentOutOfRange_Year();
			}
			return (year & 3) == 0 && ((year & 15) == 0 || year % 25 != 0);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00026E54 File Offset: 0x00025054
		[NullableContext(1)]
		public static DateTime Parse(string s)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.Parse(s, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00026E71 File Offset: 0x00025071
		[NullableContext(1)]
		public static DateTime Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.Parse(s, DateTimeFormatInfo.GetInstance(provider), DateTimeStyles.None);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00026E8F File Offset: 0x0002508F
		[NullableContext(1)]
		public static DateTime Parse(string s, [Nullable(2)] IFormatProvider provider, DateTimeStyles styles)
		{
			DateTimeFormatInfo.ValidateStyles(styles, true);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.Parse(s, DateTimeFormatInfo.GetInstance(provider), styles);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00026EB4 File Offset: 0x000250B4
		public static DateTime Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider = null, DateTimeStyles styles = DateTimeStyles.None)
		{
			DateTimeFormatInfo.ValidateStyles(styles, true);
			return DateTimeParse.Parse(s, DateTimeFormatInfo.GetInstance(provider), styles);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00026ECA File Offset: 0x000250CA
		[NullableContext(1)]
		public static DateTime ParseExact(string s, [StringSyntax("DateTimeFormat")] string format, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			return DateTimeParse.ParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), DateTimeStyles.None);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00026EF8 File Offset: 0x000250F8
		[NullableContext(1)]
		public static DateTime ParseExact(string s, [StringSyntax("DateTimeFormat")] string format, [Nullable(2)] IFormatProvider provider, DateTimeStyles style)
		{
			DateTimeFormatInfo.ValidateStyles(style, false);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			if (format == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.format);
			}
			return DateTimeParse.ParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00026F2D File Offset: 0x0002512D
		public static DateTime ParseExact(ReadOnlySpan<char> s, [StringSyntax("DateTimeFormat")] ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			DateTimeFormatInfo.ValidateStyles(style, false);
			return DateTimeParse.ParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style);
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00026F44 File Offset: 0x00025144
		[NullableContext(1)]
		public static DateTime ParseExact(string s, [StringSyntax("DateTimeFormat")] string[] formats, [Nullable(2)] IFormatProvider provider, DateTimeStyles style)
		{
			DateTimeFormatInfo.ValidateStyles(style, false);
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return DateTimeParse.ParseExactMultiple(s, formats, DateTimeFormatInfo.GetInstance(provider), style);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00026F6A File Offset: 0x0002516A
		public static DateTime ParseExact(ReadOnlySpan<char> s, [Nullable(1)] [StringSyntax("DateTimeFormat")] string[] formats, [Nullable(2)] IFormatProvider provider, DateTimeStyles style = DateTimeStyles.None)
		{
			DateTimeFormatInfo.ValidateStyles(style, false);
			return DateTimeParse.ParseExactMultiple(s, formats, DateTimeFormatInfo.GetInstance(provider), style);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00026F81 File Offset: 0x00025181
		public TimeSpan Subtract(DateTime value)
		{
			return new TimeSpan(this.Ticks - value.Ticks);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00026F96 File Offset: 0x00025196
		public DateTime Subtract(TimeSpan value)
		{
			long num = this.Ticks - value._ticks;
			if (num > 3155378975999999999L)
			{
				DateTime.ThrowDateArithmetic(0);
			}
			return new DateTime((ulong)(num | (long)this.InternalKind));
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00026FC4 File Offset: 0x000251C4
		private static double TicksToOADate(long value)
		{
			if (value == 0L)
			{
				return 0.0;
			}
			if (value < 864000000000L)
			{
				value += 599264352000000000L;
			}
			if (value < 31241376000000000L)
			{
				throw new OverflowException(SR.Arg_OleAutDateInvalid);
			}
			long num = (value - 599264352000000000L) / 10000L;
			if (num < 0L)
			{
				long num2 = num % 86400000L;
				if (num2 != 0L)
				{
					num -= (86400000L + num2) * 2L;
				}
			}
			return (double)num / 86400000.0;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0002704C File Offset: 0x0002524C
		public double ToOADate()
		{
			return DateTime.TicksToOADate(this.Ticks);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0002705C File Offset: 0x0002525C
		public long ToFileTime()
		{
			return this.ToUniversalTime().ToFileTimeUtc();
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00027078 File Offset: 0x00025278
		public long ToFileTimeUtc()
		{
			long num = ((this._dateData & 9223372036854775808UL) != 0UL) ? this.ToUniversalTime().Ticks : this.Ticks;
			if (DateTime.SystemSupportsLeapSeconds)
			{
				return (long)DateTime.ToFileTimeLeapSecondsAware(num);
			}
			num -= 504911232000000000L;
			if (num < 0L)
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_FileTimeInvalid);
			}
			return num;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x000270DC File Offset: 0x000252DC
		public DateTime ToLocalTime()
		{
			if ((this._dateData & 9223372036854775808UL) != 0UL)
			{
				return this;
			}
			bool flag;
			bool flag2;
			long ticks = TimeZoneInfo.GetUtcOffsetFromUtc(this, TimeZoneInfo.Local, out flag, out flag2).Ticks;
			long num = this.Ticks + ticks;
			if (num > 3155378975999999999L)
			{
				return new DateTime((num < 0L) ? 9223372036854775808UL : 12378751012854775807UL);
			}
			if (!flag2)
			{
				return new DateTime((ulong)(num | long.MinValue));
			}
			return new DateTime((ulong)(num | -4611686018427387904L));
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00027178 File Offset: 0x00025378
		[NullableContext(1)]
		public string ToLongDateString()
		{
			return DateTimeFormat.Format(this, "D", null);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0002718B File Offset: 0x0002538B
		[NullableContext(1)]
		public string ToLongTimeString()
		{
			return DateTimeFormat.Format(this, "T", null);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0002719E File Offset: 0x0002539E
		[NullableContext(1)]
		public string ToShortDateString()
		{
			return DateTimeFormat.Format(this, "d", null);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x000271B1 File Offset: 0x000253B1
		[NullableContext(1)]
		public string ToShortTimeString()
		{
			return DateTimeFormat.Format(this, "t", null);
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x000271C4 File Offset: 0x000253C4
		[NullableContext(1)]
		public override string ToString()
		{
			return DateTimeFormat.Format(this, null, null);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x000271D3 File Offset: 0x000253D3
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("DateTimeFormat")] string format)
		{
			return DateTimeFormat.Format(this, format, null);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x000271E2 File Offset: 0x000253E2
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return DateTimeFormat.Format(this, null, provider);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x000271F1 File Offset: 0x000253F1
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("DateTimeFormat")] string format, IFormatProvider provider)
		{
			return DateTimeFormat.Format(this, format, provider);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00027200 File Offset: 0x00025400
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("DateTimeFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return DateTimeFormat.TryFormat<char>(this, destination, out charsWritten, format, provider);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00027212 File Offset: 0x00025412
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("DateTimeFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return DateTimeFormat.TryFormat<byte>(this, utf8Destination, out bytesWritten, format, provider);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00027224 File Offset: 0x00025424
		public DateTime ToUniversalTime()
		{
			return TimeZoneInfo.ConvertTimeToUtc(this, TimeZoneInfoOptions.NoThrowOnInvalidTime);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00027232 File Offset: 0x00025432
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out DateTime result)
		{
			if (s == null)
			{
				result = default(DateTime);
				return false;
			}
			return DateTimeParse.TryParse(s, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out result);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00027252 File Offset: 0x00025452
		public static bool TryParse(ReadOnlySpan<char> s, out DateTime result)
		{
			return DateTimeParse.TryParse(s, DateTimeFormatInfo.CurrentInfo, DateTimeStyles.None, out result);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00027261 File Offset: 0x00025461
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(styles, true);
			if (s == null)
			{
				result = default(DateTime);
				return false;
			}
			return DateTimeParse.TryParse(s, DateTimeFormatInfo.GetInstance(provider), styles, out result);
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00027289 File Offset: 0x00025489
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, DateTimeStyles styles, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(styles, true);
			return DateTimeParse.TryParse(s, DateTimeFormatInfo.GetInstance(provider), styles, out result);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x000272A0 File Offset: 0x000254A0
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string s, [NotNullWhen(true)] [StringSyntax("DateTimeFormat")] string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(style, false);
			if (s == null || format == null)
			{
				result = default(DateTime);
				return false;
			}
			return DateTimeParse.TryParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style, out result);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x000272D3 File Offset: 0x000254D3
		public static bool TryParseExact(ReadOnlySpan<char> s, [StringSyntax("DateTimeFormat")] ReadOnlySpan<char> format, [Nullable(2)] IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(style, false);
			return DateTimeParse.TryParseExact(s, format, DateTimeFormatInfo.GetInstance(provider), style, out result);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x000272EC File Offset: 0x000254EC
		[NullableContext(2)]
		public static bool TryParseExact([NotNullWhen(true)] string s, [NotNullWhen(true)] [StringSyntax("DateTimeFormat")] string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(style, false);
			if (s == null)
			{
				result = default(DateTime);
				return false;
			}
			return DateTimeParse.TryParseExactMultiple(s, formats, DateTimeFormatInfo.GetInstance(provider), style, out result);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00027317 File Offset: 0x00025517
		[NullableContext(2)]
		public static bool TryParseExact([Nullable(0)] ReadOnlySpan<char> s, [NotNullWhen(true)] [StringSyntax("DateTimeFormat")] string[] formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			DateTimeFormatInfo.ValidateStyles(style, false);
			return DateTimeParse.TryParseExactMultiple(s, formats, DateTimeFormatInfo.GetInstance(provider), style, out result);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00027330 File Offset: 0x00025530
		public static DateTime operator +(DateTime d, TimeSpan t)
		{
			long num = d.Ticks + t._ticks;
			if (num > 3155378975999999999L)
			{
				DateTime.ThrowDateArithmetic(1);
			}
			return new DateTime((ulong)(num | (long)d.InternalKind));
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0002735F File Offset: 0x0002555F
		public static DateTime operator -(DateTime d, TimeSpan t)
		{
			long num = d.Ticks - t._ticks;
			if (num > 3155378975999999999L)
			{
				DateTime.ThrowDateArithmetic(1);
			}
			return new DateTime((ulong)(num | (long)d.InternalKind));
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0002738E File Offset: 0x0002558E
		public static TimeSpan operator -(DateTime d1, DateTime d2)
		{
			return new TimeSpan(d1.Ticks - d2.Ticks);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x000273A4 File Offset: 0x000255A4
		public static bool operator ==(DateTime d1, DateTime d2)
		{
			return (d1._dateData ^ d2._dateData) << 2 == 0UL;
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x000273B9 File Offset: 0x000255B9
		public static bool operator !=(DateTime d1, DateTime d2)
		{
			return !(d1 == d2);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x000273C5 File Offset: 0x000255C5
		public static bool operator <(DateTime t1, DateTime t2)
		{
			return t1.Ticks < t2.Ticks;
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x000273D7 File Offset: 0x000255D7
		public static bool operator <=(DateTime t1, DateTime t2)
		{
			return t1.Ticks <= t2.Ticks;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x000273EC File Offset: 0x000255EC
		public static bool operator >(DateTime t1, DateTime t2)
		{
			return t1.Ticks > t2.Ticks;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x000273FE File Offset: 0x000255FE
		public static bool operator >=(DateTime t1, DateTime t2)
		{
			return t1.Ticks >= t2.Ticks;
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00027413 File Offset: 0x00025613
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Deconstruct(out DateOnly date, out TimeOnly time)
		{
			date = DateOnly.FromDateTime(this);
			time = TimeOnly.FromDateTime(this);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00027437 File Offset: 0x00025637
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Deconstruct(out int year, out int month, out int day)
		{
			this.GetDate(out year, out month, out day);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00027442 File Offset: 0x00025642
		[NullableContext(1)]
		public string[] GetDateTimeFormats()
		{
			return this.GetDateTimeFormats(CultureInfo.CurrentCulture);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0002744F File Offset: 0x0002564F
		[NullableContext(1)]
		public string[] GetDateTimeFormats([Nullable(2)] IFormatProvider provider)
		{
			return DateTimeFormat.GetAllDateTimes(this, DateTimeFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00027462 File Offset: 0x00025662
		[NullableContext(1)]
		public string[] GetDateTimeFormats(char format)
		{
			return this.GetDateTimeFormats(format, CultureInfo.CurrentCulture);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00027470 File Offset: 0x00025670
		[NullableContext(1)]
		public string[] GetDateTimeFormats(char format, [Nullable(2)] IFormatProvider provider)
		{
			return DateTimeFormat.GetAllDateTimes(this, format, DateTimeFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00027484 File Offset: 0x00025684
		public TypeCode GetTypeCode()
		{
			return TypeCode.DateTime;
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00027488 File Offset: 0x00025688
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("Boolean");
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00027494 File Offset: 0x00025694
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("Char");
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000274A0 File Offset: 0x000256A0
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("SByte");
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x000274AC File Offset: 0x000256AC
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("Byte");
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000274B8 File Offset: 0x000256B8
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("Int16");
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x000274C4 File Offset: 0x000256C4
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("UInt16");
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x000274D0 File Offset: 0x000256D0
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("Int32");
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x000274DC File Offset: 0x000256DC
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("UInt32");
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000274E8 File Offset: 0x000256E8
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("Int64");
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x000274F4 File Offset: 0x000256F4
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("UInt64");
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00027500 File Offset: 0x00025700
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("Single");
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0002750C File Offset: 0x0002570C
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("Double");
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00027518 File Offset: 0x00025718
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			throw DateTime.InvalidCast("Decimal");
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0002752F File Offset: 0x0002572F
		private static InvalidCastException InvalidCast(string to)
		{
			return new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "DateTime", to));
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00027546 File Offset: 0x00025746
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0002754E File Offset: 0x0002574E
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00027564 File Offset: 0x00025764
		internal unsafe static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result)
		{
			result = default(DateTime);
			if (year < 1 || year > 9999 || month < 1 || month > 12 || day < 1)
			{
				return false;
			}
			if (hour >= 24 || minute >= 60 || (ulong)millisecond >= 1000UL)
			{
				return false;
			}
			ReadOnlySpan<uint> readOnlySpan = DateTime.IsLeapYear(year) ? DateTime.DaysToMonth366 : DateTime.DaysToMonth365;
			if (day > (int)(*readOnlySpan[month] - *readOnlySpan[month - 1]))
			{
				return false;
			}
			ulong num = (ulong)(DateTime.DaysToYear((uint)year) + *readOnlySpan[month - 1] + (uint)day - 1U) * 864000000000UL;
			if (second < 60)
			{
				num += DateTime.TimeToTicks(hour, minute, second) + (ulong)(millisecond * 10000);
			}
			else
			{
				if (second != 60 || !DateTime.SystemSupportsLeapSeconds || !DateTime.IsValidTimeWithLeapSeconds(year, month, day, hour, minute, DateTimeKind.Unspecified))
				{
					return false;
				}
				num += DateTime.TimeToTicks(hour, minute, 59) + 9990000UL;
			}
			result = new DateTime(num);
			return true;
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0002765D File Offset: 0x0002585D
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out DateTime result)
		{
			return DateTime.TryParse(s, provider, DateTimeStyles.None, out result);
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00027668 File Offset: 0x00025868
		public static DateTime Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return DateTime.Parse(s, provider, DateTimeStyles.None);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00027672 File Offset: 0x00025872
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out DateTime result)
		{
			return DateTime.TryParse(s, provider, DateTimeStyles.None, out result);
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0002767D File Offset: 0x0002587D
		internal static bool SystemSupportsLeapSeconds
		{
			get
			{
				return DateTime.LeapSecondCache.s_systemSupportsLeapSeconds;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00027684 File Offset: 0x00025884
		public unsafe static DateTime UtcNow
		{
			get
			{
				method s_pfnGetSystemTimeAsFileTime = DateTime.LeapSecondCache.s_pfnGetSystemTimeAsFileTime;
				ulong num;
				&num;
				s_pfnGetSystemTimeAsFileTime;
				calli();
				ulong num2 = num;
				if (!DateTime.LeapSecondCache.s_systemSupportsLeapSeconds)
				{
					return new DateTime(num2 + 5116597250427387904UL);
				}
				void s_leapSecondCache = DateTime.LeapSecondCache.s_leapSecondCache;
				void @void = num2 - s_leapSecondCache.OSFileTimeTicksAtStartOfValidityWindow;
				if (@void < (ulong)-1294967296)
				{
					return new DateTime(s_leapSecondCache.DotnetDateDataAtStartOfValidityWindow + @void);
				}
				return DateTime.UpdateLeapSecondCacheAndReturnUtcNow();
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000276E8 File Offset: 0x000258E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static bool IsValidTimeWithLeapSeconds(int year, int month, int day, int hour, int minute, DateTimeKind kind)
		{
			Interop.Kernel32.SYSTEMTIME systemtime;
			systemtime.Year = (ushort)year;
			systemtime.Month = (ushort)month;
			systemtime.DayOfWeek = 0;
			systemtime.Day = (ushort)day;
			systemtime.Hour = (ushort)hour;
			systemtime.Minute = (ushort)minute;
			systemtime.Second = 60;
			systemtime.Milliseconds = 0;
			Interop.Kernel32.SYSTEMTIME systemtime2;
			ulong num;
			return (kind != DateTimeKind.Utc && Interop.Kernel32.TzSpecificLocalTimeToSystemTime(IntPtr.Zero, &systemtime, &systemtime2) != Interop.BOOL.FALSE) || (kind != DateTimeKind.Local && Interop.Kernel32.SystemTimeToFileTime(&systemtime, &num) != Interop.BOOL.FALSE);
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0002776C File Offset: 0x0002596C
		private unsafe static DateTime FromFileTimeLeapSecondsAware(ulong fileTime)
		{
			Interop.Kernel32.SYSTEMTIME systemtime;
			if (Interop.Kernel32.FileTimeToSystemTime(&fileTime, &systemtime) == Interop.BOOL.FALSE)
			{
				throw new ArgumentOutOfRangeException("fileTime", SR.ArgumentOutOfRange_DateTimeBadTicks);
			}
			return DateTime.CreateDateTimeFromSystemTime(systemtime, fileTime % 10000UL);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x000277A8 File Offset: 0x000259A8
		private unsafe static ulong ToFileTimeLeapSecondsAware(long ticks)
		{
			DateTime dateTime = new DateTime(ticks);
			int num;
			int num2;
			int num3;
			dateTime.GetDate(out num, out num2, out num3);
			Interop.Kernel32.SYSTEMTIME systemtime;
			systemtime.Year = (ushort)num;
			systemtime.Month = (ushort)num2;
			systemtime.DayOfWeek = 0;
			systemtime.Day = (ushort)num3;
			int num4;
			int num5;
			int num6;
			int num7;
			dateTime.GetTimePrecise(out num4, out num5, out num6, out num7);
			systemtime.Hour = (ushort)num4;
			systemtime.Minute = (ushort)num5;
			systemtime.Second = (ushort)num6;
			systemtime.Milliseconds = 0;
			ulong num8;
			if (Interop.Kernel32.SystemTimeToFileTime(&systemtime, &num8) == Interop.BOOL.FALSE)
			{
				throw new ArgumentOutOfRangeException(null, SR.ArgumentOutOfRange_FileTimeInvalid);
			}
			return num8 + (ulong)num7;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00027844 File Offset: 0x00025A44
		private unsafe static DateTime CreateDateTimeFromSystemTime(in Interop.Kernel32.SYSTEMTIME time, ulong hundredNanoSecond)
		{
			ushort year = time.Year;
			ReadOnlySpan<uint> readOnlySpan = DateTime.IsLeapYear((int)year) ? DateTime.DaysToMonth366 : DateTime.DaysToMonth365;
			int index = (int)(time.Month - 1);
			ulong num = (ulong)(DateTime.DaysToYear((uint)year) + *readOnlySpan[index] + (uint)time.Day - 1U) * 864000000000UL;
			num += (ulong)time.Hour * 36000000000UL;
			num += (ulong)time.Minute * 600000000UL;
			uint second = (uint)time.Second;
			if (second <= 59U)
			{
				ulong num2 = (ulong)(second * 10000000U + (uint)(time.Milliseconds * 10000)) + hundredNanoSecond;
				return new DateTime(num + num2 | 4611686018427387904UL);
			}
			num += 4611686019027387903UL;
			return new DateTime(num);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0002790C File Offset: 0x00025B0C
		private unsafe static bool GetSystemSupportsLeapSeconds()
		{
			Interop.NtDll.SYSTEM_LEAP_SECOND_INFORMATION system_LEAP_SECOND_INFORMATION;
			return Interop.NtDll.NtQuerySystemInformation(206, (void*)(&system_LEAP_SECOND_INFORMATION), (uint)sizeof(Interop.NtDll.SYSTEM_LEAP_SECOND_INFORMATION), null) == 0U && system_LEAP_SECOND_INFORMATION.Enabled > Interop.BOOLEAN.FALSE;
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0002793C File Offset: 0x00025B3C
		private static method GetGetSystemTimeAsFileTimeFnPtr()
		{
			/*
An exception occurred when decompiling this method (06000E9A)

ICSharpCode.Decompiler.DecompilerException: Error decompiling <<<NULL>>> System.DateTime::GetGetSystemTimeAsFileTimeFnPtr()

 ---> System.Exception: Inconsistent stack size at IL_64
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 443
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 271
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x000279B4 File Offset: 0x00025BB4
		private unsafe static DateTime UpdateLeapSecondCacheAndReturnUtcNow()
		{
			method s_pfnGetSystemTimeAsFileTime = DateTime.LeapSecondCache.s_pfnGetSystemTimeAsFileTime;
			ulong num;
			&num;
			s_pfnGetSystemTimeAsFileTime;
			calli();
			ulong hundredNanoSecond = num % 10000UL;
			Interop.Kernel32.SYSTEMTIME systemtime;
			if (Interop.Kernel32.FileTimeToSystemTime(&num, &systemtime) == Interop.BOOL.FALSE)
			{
				return DateTime.<UpdateLeapSecondCacheAndReturnUtcNow>g__LowGranularityNonCachedFallback|236_0();
			}
			if (systemtime.Second >= 60)
			{
				return DateTime.CreateDateTimeFromSystemTime(systemtime, hundredNanoSecond);
			}
			ulong num2 = num + (ulong)-1294967296;
			Interop.Kernel32.SYSTEMTIME systemtime2;
			if (Interop.Kernel32.FileTimeToSystemTime(&num2, &systemtime2) == Interop.BOOL.FALSE)
			{
				return DateTime.<UpdateLeapSecondCacheAndReturnUtcNow>g__LowGranularityNonCachedFallback|236_0();
			}
			ulong num3;
			ulong num4;
			if (systemtime2.Second == systemtime.Second)
			{
				num3 = num;
				num4 = DateTime.CreateDateTimeFromSystemTime(systemtime, hundredNanoSecond)._dateData;
			}
			else
			{
				void @void = systemtime;
				@void.Hour = 0;
				@void.Minute = 0;
				@void.Second = 0;
				@void.Milliseconds = 0;
				void void2;
				if (Interop.Kernel32.SystemTimeToFileTime((Interop.Kernel32.SYSTEMTIME*)(&@void), (ulong*)(&void2)) == Interop.BOOL.FALSE)
				{
					return DateTime.<UpdateLeapSecondCacheAndReturnUtcNow>g__LowGranularityNonCachedFallback|236_0();
				}
				num3 = void2 + 863990000000L - (ulong)-1294967296;
				if (num - num3 >= (ulong)-1294967296)
				{
					return DateTime.CreateDateTimeFromSystemTime(systemtime, hundredNanoSecond);
				}
				num4 = DateTime.CreateDateTimeFromSystemTime(@void, 0UL)._dateData + 863990000000UL - (ulong)-1294967296;
			}
			Volatile.Write<DateTime.LeapSecondCache>(ref DateTime.LeapSecondCache.s_leapSecondCache, new DateTime.LeapSecondCache
			{
				OSFileTimeTicksAtStartOfValidityWindow = num3,
				DotnetDateDataAtStartOfValidityWindow = num4
			});
			return new DateTime(num4 + num - num3);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00027B1C File Offset: 0x00025D1C
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal unsafe static DateTime <UpdateLeapSecondCacheAndReturnUtcNow>g__LowGranularityNonCachedFallback|236_0()
		{
			Interop.Kernel32.SYSTEMTIME systemtime;
			Interop.Kernel32.GetSystemTime(&systemtime);
			return DateTime.CreateDateTimeFromSystemTime(systemtime, 0UL);
		}

		// Token: 0x04000319 RID: 793
		private const int DaysPerYear = 365;

		// Token: 0x0400031A RID: 794
		private const int DaysPer4Years = 1461;

		// Token: 0x0400031B RID: 795
		private const int DaysPer100Years = 36524;

		// Token: 0x0400031C RID: 796
		private const int DaysPer400Years = 146097;

		// Token: 0x0400031D RID: 797
		private const int DaysTo1601 = 584388;

		// Token: 0x0400031E RID: 798
		private const int DaysTo1899 = 693593;

		// Token: 0x0400031F RID: 799
		internal const int DaysTo1970 = 719162;

		// Token: 0x04000320 RID: 800
		internal const int DaysTo10000 = 3652059;

		// Token: 0x04000321 RID: 801
		internal const long MinTicks = 0L;

		// Token: 0x04000322 RID: 802
		internal const long MaxTicks = 3155378975999999999L;

		// Token: 0x04000323 RID: 803
		private const long MaxMicroseconds = 315537897599999999L;

		// Token: 0x04000324 RID: 804
		private const long MaxMillis = 315537897599999L;

		// Token: 0x04000325 RID: 805
		private const long MaxSeconds = 315537897599L;

		// Token: 0x04000326 RID: 806
		private const long MaxMinutes = 5258964959L;

		// Token: 0x04000327 RID: 807
		private const long MaxHours = 87649415L;

		// Token: 0x04000328 RID: 808
		private const long MaxDays = 3652058L;

		// Token: 0x04000329 RID: 809
		internal const long UnixEpochTicks = 621355968000000000L;

		// Token: 0x0400032A RID: 810
		private const long FileTimeOffset = 504911232000000000L;

		// Token: 0x0400032B RID: 811
		private const long DoubleDateOffset = 599264352000000000L;

		// Token: 0x0400032C RID: 812
		private const long OADateMinAsTicks = 31241376000000000L;

		// Token: 0x0400032D RID: 813
		private const double OADateMinAsDouble = -657435.0;

		// Token: 0x0400032E RID: 814
		private const double OADateMaxAsDouble = 2958466.0;

		// Token: 0x0400032F RID: 815
		private const uint EafMultiplier = 2939745U;

		// Token: 0x04000330 RID: 816
		private const uint EafDivider = 11758980U;

		// Token: 0x04000331 RID: 817
		private const ulong TicksPer6Hours = 216000000000UL;

		// Token: 0x04000332 RID: 818
		private const int March1BasedDayOfNewYear = 306;

		// Token: 0x04000333 RID: 819
		public static readonly DateTime MinValue;

		// Token: 0x04000334 RID: 820
		public static readonly DateTime MaxValue = new DateTime(3155378975999999999L, DateTimeKind.Unspecified);

		// Token: 0x04000335 RID: 821
		public static readonly DateTime UnixEpoch = new DateTime(621355968000000000L, DateTimeKind.Utc);

		// Token: 0x04000336 RID: 822
		private const ulong TicksMask = 4611686018427387903UL;

		// Token: 0x04000337 RID: 823
		private const ulong FlagsMask = 13835058055282163712UL;

		// Token: 0x04000338 RID: 824
		private const long TicksCeiling = 4611686018427387904L;

		// Token: 0x04000339 RID: 825
		private const ulong KindUnspecified = 0UL;

		// Token: 0x0400033A RID: 826
		private const ulong KindUtc = 4611686018427387904UL;

		// Token: 0x0400033B RID: 827
		private const ulong KindLocal = 9223372036854775808UL;

		// Token: 0x0400033C RID: 828
		private const ulong KindLocalAmbiguousDst = 13835058055282163712UL;

		// Token: 0x0400033D RID: 829
		private const int KindShift = 62;

		// Token: 0x0400033E RID: 830
		private const string TicksField = "ticks";

		// Token: 0x0400033F RID: 831
		private const string DateDataField = "dateData";

		// Token: 0x04000340 RID: 832
		private readonly ulong _dateData;

		// Token: 0x020000F0 RID: 240
		private sealed class LeapSecondCache
		{
			// Token: 0x04000341 RID: 833
			internal ulong OSFileTimeTicksAtStartOfValidityWindow;

			// Token: 0x04000342 RID: 834
			internal ulong DotnetDateDataAtStartOfValidityWindow;

			// Token: 0x04000343 RID: 835
			internal static DateTime.LeapSecondCache s_leapSecondCache = new DateTime.LeapSecondCache();

			// Token: 0x04000344 RID: 836
			internal static readonly bool s_systemSupportsLeapSeconds = DateTime.GetSystemSupportsLeapSeconds();

			// Token: 0x04000345 RID: 837
			internal static readonly method s_pfnGetSystemTimeAsFileTime = DateTime.GetGetSystemTimeAsFileTimeFnPtr();
		}
	}
}
