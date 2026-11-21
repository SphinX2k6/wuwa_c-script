using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x0200014E RID: 334
	[Intrinsic]
	public readonly struct Int128 : IBinaryInteger<Int128>, IBinaryNumber<Int128>, IBitwiseOperators<Int128, Int128, Int128>, INumber<Int128>, IComparable, IComparable<Int128>, IComparisonOperators<Int128, Int128, bool>, IEqualityOperators<Int128, Int128, bool>, IModulusOperators<Int128, Int128, Int128>, INumberBase<Int128>, IAdditionOperators<Int128, Int128, Int128>, IAdditiveIdentity<Int128, Int128>, IDecrementOperators<Int128>, IDivisionOperators<Int128, Int128, Int128>, IEquatable<Int128>, IIncrementOperators<Int128>, IMultiplicativeIdentity<Int128, Int128>, IMultiplyOperators<Int128, Int128, Int128>, ISpanFormattable, IFormattable, ISpanParsable<Int128>, IParsable<Int128>, ISubtractionOperators<Int128, Int128, Int128>, IUnaryPlusOperators<Int128, Int128>, IUnaryNegationOperators<Int128, Int128>, IUtf8SpanFormattable, IUtf8SpanParsable<Int128>, IShiftOperators<Int128, int, Int128>, IMinMaxValue<Int128>, ISignedNumber<Int128>, IBinaryIntegerParseAndFormatInfo<Int128>
	{
		// Token: 0x060015A9 RID: 5545 RVA: 0x000427DD File Offset: 0x000409DD
		[CLSCompliant(false)]
		public Int128(ulong upper, ulong lower)
		{
			this._lower = lower;
			this._upper = upper;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x000427ED File Offset: 0x000409ED
		internal ulong Lower
		{
			get
			{
				return this._lower;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x000427F5 File Offset: 0x000409F5
		internal ulong Upper
		{
			get
			{
				return this._upper;
			}
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00042800 File Offset: 0x00040A00
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value is Int128)
			{
				Int128 value2 = (Int128)value;
				return this.CompareTo(value2);
			}
			if (value == null)
			{
				return 1;
			}
			throw new ArgumentException(SR.Arg_MustBeInt128);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00042833 File Offset: 0x00040A33
		public int CompareTo(Int128 value)
		{
			if (this < value)
			{
				return -1;
			}
			if (this > value)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00042858 File Offset: 0x00040A58
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Int128)
			{
				Int128 other = (Int128)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x0004287D File Offset: 0x00040A7D
		public bool Equals(Int128 other)
		{
			return this == other;
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x0004288B File Offset: 0x00040A8B
		public override int GetHashCode()
		{
			return HashCode.Combine<ulong, ulong>(this._lower, this._upper);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x0004289E File Offset: 0x00040A9E
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.Int128ToDecStr(this);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000428AB File Offset: 0x00040AAB
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.FormatInt128(this, null, provider);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000428BA File Offset: 0x00040ABA
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return Number.FormatInt128(this, format, null);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000428C9 File Offset: 0x00040AC9
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatInt128(this, format, provider);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000428D8 File Offset: 0x00040AD8
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatInt128<char>(this, format, provider, destination, out charsWritten);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000428EA File Offset: 0x00040AEA
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatInt128<byte>(this, format, provider, utf8Destination, out bytesWritten);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000428FC File Offset: 0x00040AFC
		[NullableContext(1)]
		public static Int128 Parse(string s)
		{
			return Int128.Parse(s, NumberStyles.Integer, null);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00042906 File Offset: 0x00040B06
		[NullableContext(1)]
		public static Int128 Parse(string s, NumberStyles style)
		{
			return Int128.Parse(s, style, null);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00042910 File Offset: 0x00040B10
		[NullableContext(1)]
		public static Int128 Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return Int128.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x0004291A File Offset: 0x00040B1A
		[NullableContext(1)]
		public static Int128 Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Int128.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00042933 File Offset: 0x00040B33
		public static Int128 Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<char, Int128>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00042948 File Offset: 0x00040B48
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out Int128 result)
		{
			return Int128.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00042953 File Offset: 0x00040B53
		public static bool TryParse(ReadOnlySpan<char> s, out Int128 result)
		{
			return Int128.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0004295E File Offset: 0x00040B5E
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out Int128 result)
		{
			return Int128.TryParse(utf8Text, NumberStyles.Integer, null, out result);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00042969 File Offset: 0x00040B69
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out Int128 result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return Number.TryParseBinaryInteger<char, Int128>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00042998 File Offset: 0x00040B98
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out Int128 result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<char, Int128>(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x000429B1 File Offset: 0x00040BB1
		public static explicit operator byte(Int128 value)
		{
			return (byte)value._lower;
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x000429BA File Offset: 0x00040BBA
		public static byte op_CheckedExplicit(Int128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((byte)value._lower);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000429D0 File Offset: 0x00040BD0
		public static explicit operator char(Int128 value)
		{
			return (char)value._lower;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x000429D9 File Offset: 0x00040BD9
		public static char op_CheckedExplicit(Int128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((char)value._lower);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x000429EF File Offset: 0x00040BEF
		public static explicit operator decimal(Int128 value)
		{
			if (Int128.IsNegative(value))
			{
				value = -value;
				return -(decimal)((UInt128)value);
			}
			return (decimal)((UInt128)value);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00042A1D File Offset: 0x00040C1D
		public static explicit operator double(Int128 value)
		{
			if (Int128.IsNegative(value))
			{
				value = -value;
				return -(double)((UInt128)value);
			}
			return (double)((UInt128)value);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00042A49 File Offset: 0x00040C49
		public static explicit operator Half(Int128 value)
		{
			if (Int128.IsNegative(value))
			{
				value = -value;
				return -(Half)((UInt128)value);
			}
			return (Half)((UInt128)value);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00042A77 File Offset: 0x00040C77
		public static explicit operator short(Int128 value)
		{
			return (short)value._lower;
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00042A80 File Offset: 0x00040C80
		public static short op_CheckedExplicit(Int128 value)
		{
			long lower = (long)value._lower;
			if (value._upper != (ulong)(lower >> 63))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((short)lower);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00042AA7 File Offset: 0x00040CA7
		public static explicit operator int(Int128 value)
		{
			return (int)value._lower;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00042AB0 File Offset: 0x00040CB0
		public static int op_CheckedExplicit(Int128 value)
		{
			long lower = (long)value._lower;
			if (value._upper != (ulong)(lower >> 63))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((int)lower);
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x000427ED File Offset: 0x000409ED
		public static explicit operator long(Int128 value)
		{
			return (long)value._lower;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00042AD8 File Offset: 0x00040CD8
		public static long op_CheckedExplicit(Int128 value)
		{
			long lower = (long)value._lower;
			if (value._upper != (ulong)(lower >> 63))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return lower;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00042AFE File Offset: 0x00040CFE
		public static explicit operator IntPtr(Int128 value)
		{
			return (IntPtr)value._lower;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00042B08 File Offset: 0x00040D08
		public static IntPtr op_CheckedExplicit(Int128 value)
		{
			long lower = (long)value._lower;
			if (value._upper != (ulong)(lower >> 63))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((IntPtr)lower);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00042B2F File Offset: 0x00040D2F
		[CLSCompliant(false)]
		public static explicit operator sbyte(Int128 value)
		{
			return (sbyte)value._lower;
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00042B38 File Offset: 0x00040D38
		[CLSCompliant(false)]
		public static sbyte op_CheckedExplicit(Int128 value)
		{
			long lower = (long)value._lower;
			if (value._upper != (ulong)(lower >> 63))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((sbyte)lower);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00042B5F File Offset: 0x00040D5F
		public static explicit operator float(Int128 value)
		{
			if (Int128.IsNegative(value))
			{
				value = -value;
				return -(float)((UInt128)value);
			}
			return (float)((UInt128)value);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x000429D0 File Offset: 0x00040BD0
		[CLSCompliant(false)]
		public static explicit operator ushort(Int128 value)
		{
			return (ushort)value._lower;
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x000429D9 File Offset: 0x00040BD9
		[CLSCompliant(false)]
		public static ushort op_CheckedExplicit(Int128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((ushort)value._lower);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00042B8B File Offset: 0x00040D8B
		[CLSCompliant(false)]
		public static explicit operator uint(Int128 value)
		{
			return (uint)value._lower;
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00042B94 File Offset: 0x00040D94
		[CLSCompliant(false)]
		public static uint op_CheckedExplicit(Int128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((uint)value._lower);
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x000427ED File Offset: 0x000409ED
		[CLSCompliant(false)]
		public static explicit operator ulong(Int128 value)
		{
			return value._lower;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00042BAA File Offset: 0x00040DAA
		[CLSCompliant(false)]
		public static ulong op_CheckedExplicit(Int128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return value._lower;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00042BBF File Offset: 0x00040DBF
		[CLSCompliant(false)]
		public static explicit operator UInt128(Int128 value)
		{
			return new UInt128(value._upper, value._lower);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00042BD2 File Offset: 0x00040DD2
		[CLSCompliant(false)]
		public static UInt128 op_CheckedExplicit(Int128 value)
		{
			if (value._upper < 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return new UInt128(value._upper, value._lower);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00042BF4 File Offset: 0x00040DF4
		[CLSCompliant(false)]
		public static explicit operator UIntPtr(Int128 value)
		{
			return (UIntPtr)value._lower;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00042BFD File Offset: 0x00040DFD
		[CLSCompliant(false)]
		public static UIntPtr op_CheckedExplicit(Int128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((UIntPtr)value._lower);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00042C14 File Offset: 0x00040E14
		public static explicit operator Int128(decimal value)
		{
			value = decimal.Truncate(value);
			Int128 @int = new Int128((ulong)value.High, value.Low64);
			if (decimal.IsNegative(value))
			{
				@int = -@int;
			}
			return @int;
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00042C4F File Offset: 0x00040E4F
		public static explicit operator Int128(double value)
		{
			if (value <= -1.7014118346046923E+38)
			{
				return Int128.MinValue;
			}
			if (double.IsNaN(value))
			{
				return 0;
			}
			if (value >= 1.7014118346046923E+38)
			{
				return Int128.MaxValue;
			}
			return Int128.ToInt128(value);
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00042C8A File Offset: 0x00040E8A
		public static Int128 op_CheckedExplicit(double value)
		{
			if (value < -1.7014118346046923E+38 || double.IsNaN(value) || value >= 1.7014118346046923E+38)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return Int128.ToInt128(value);
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00042CB8 File Offset: 0x00040EB8
		internal static Int128 ToInt128(double value)
		{
			bool flag = double.IsNegative(value);
			if (flag)
			{
				value = -value;
			}
			if (value >= 1.0)
			{
				ulong num = BitConverter.DoubleToUInt64Bits(value);
				Int128 @int = new Int128(num << 12 >> 1 | 9223372036854775808UL, 0UL);
				@int = Int128.op_UnsignedRightShift(@int, 1150 - (int)(num >> 52));
				if (flag)
				{
					@int = -@int;
				}
				return @int;
			}
			return 0;
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00042D23 File Offset: 0x00040F23
		public static explicit operator Int128(float value)
		{
			return (Int128)((double)value);
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00042D2C File Offset: 0x00040F2C
		public static Int128 op_CheckedExplicit(float value)
		{
			return Int128.op_CheckedExplicit((double)value);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00042D35 File Offset: 0x00040F35
		public static implicit operator Int128(byte value)
		{
			return new Int128(0UL, (ulong)value);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00042D35 File Offset: 0x00040F35
		public static implicit operator Int128(char value)
		{
			return new Int128(0UL, (ulong)value);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00042D40 File Offset: 0x00040F40
		public static implicit operator Int128(short value)
		{
			long num = (long)value;
			return new Int128((ulong)(num >> 63), (ulong)num);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00042D5C File Offset: 0x00040F5C
		public static implicit operator Int128(int value)
		{
			long num = (long)value;
			return new Int128((ulong)(num >> 63), (ulong)num);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00042D78 File Offset: 0x00040F78
		public static implicit operator Int128(long value)
		{
			return new Int128((ulong)(value >> 63), (ulong)value);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00042D94 File Offset: 0x00040F94
		public static implicit operator Int128(IntPtr value)
		{
			long num = (long)value;
			return new Int128((ulong)(num >> 63), (ulong)num);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00042DB0 File Offset: 0x00040FB0
		[CLSCompliant(false)]
		public static implicit operator Int128(sbyte value)
		{
			long num = (long)value;
			return new Int128((ulong)(num >> 63), (ulong)num);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00042D35 File Offset: 0x00040F35
		[CLSCompliant(false)]
		public static implicit operator Int128(ushort value)
		{
			return new Int128(0UL, (ulong)value);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00042D35 File Offset: 0x00040F35
		[CLSCompliant(false)]
		public static implicit operator Int128(uint value)
		{
			return new Int128(0UL, (ulong)value);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00042DCA File Offset: 0x00040FCA
		[CLSCompliant(false)]
		public static implicit operator Int128(ulong value)
		{
			return new Int128(0UL, value);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00042D35 File Offset: 0x00040F35
		[CLSCompliant(false)]
		public static implicit operator Int128(UIntPtr value)
		{
			return new Int128(0UL, (ulong)value);
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00042DD4 File Offset: 0x00040FD4
		public static Int128 operator +(Int128 left, Int128 right)
		{
			ulong num = left._lower + right._lower;
			ulong num2 = (ulong)((num < left._lower) ? 1L : 0L);
			return new Int128(left._upper + right._upper + num2, num);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00042E10 File Offset: 0x00041010
		public static Int128 op_CheckedAddition(Int128 left, Int128 right)
		{
			Int128 @int = left + right;
			uint num = (uint)(left._upper >> 63);
			if (num == (uint)(right._upper >> 63) && num != (uint)(@int._upper >> 63))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return @int;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x00042E50 File Offset: 0x00041050
		Int128 IAdditiveIdentity<Int128, Int128>.AdditiveIdentity
		{
			get
			{
				return default(Int128);
			}
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00042E68 File Offset: 0x00041068
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<Int128, Int128> DivRem(Int128 left, Int128 right)
		{
			Int128 @int = left / right;
			return new ValueTuple<Int128, Int128>(@int, left - @int * right);
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00042E90 File Offset: 0x00041090
		public static Int128 LeadingZeroCount(Int128 value)
		{
			return Int128.LeadingZeroCountAsInt32(value);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00042E9D File Offset: 0x0004109D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int LeadingZeroCountAsInt32(Int128 value)
		{
			if (value._upper == 0UL)
			{
				return 64 + BitOperations.LeadingZeroCount(value._lower);
			}
			return BitOperations.LeadingZeroCount(value._upper);
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00042EC1 File Offset: 0x000410C1
		public static Int128 PopCount(Int128 value)
		{
			return ulong.PopCount(value._lower) + ulong.PopCount(value._upper);
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00042EDF File Offset: 0x000410DF
		public static Int128 RotateLeft(Int128 value, int rotateAmount)
		{
			return value << rotateAmount | Int128.op_UnsignedRightShift(value, 128 - rotateAmount);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00042EFA File Offset: 0x000410FA
		public static Int128 RotateRight(Int128 value, int rotateAmount)
		{
			return Int128.op_UnsignedRightShift(value, rotateAmount) | value << 128 - rotateAmount;
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00042F15 File Offset: 0x00041115
		public static Int128 TrailingZeroCount(Int128 value)
		{
			if (value._lower == 0UL)
			{
				return 64UL + ulong.TrailingZeroCount(value._upper);
			}
			return ulong.TrailingZeroCount(value._lower);
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00042F44 File Offset: 0x00041144
		unsafe bool IBinaryInteger<Int128>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out Int128 value)
		{
			Int128 @int = default(Int128);
			if (source.Length != 0)
			{
				sbyte b = (sbyte)(*source[0]);
				b = (sbyte)(b >> 31);
				isUnsigned |= (b == 0);
				if (isUnsigned && sbyte.IsNegative(b) && source.Length >= 16)
				{
					value = @int;
					return false;
				}
				if (source.Length > 16)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 16).ContainsAnyExcept((byte)b))
					{
						value = @int;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[source.Length - 16])))
					{
						value = @int;
						return false;
					}
				}
				ref byte source2 = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 16)
				{
					source2 = Unsafe.Add<byte>(ref source2, source.Length - 16);
					@int = Unsafe.ReadUnaligned<Int128>(ref source2);
					bool isLittleEndian = BitConverter.IsLittleEndian;
					@int = BinaryPrimitives.ReverseEndianness(@int);
				}
				else
				{
					for (int i = 0; i < source.Length; i++)
					{
						@int <<= 8;
						@int |= *Unsafe.Add<byte>(ref source2, i);
					}
					if (!isUnsigned)
					{
						@int |= Int128.One << 127 >> (16 - source.Length) * 8 - 1;
					}
				}
			}
			value = @int;
			return true;
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00043090 File Offset: 0x00041290
		unsafe bool IBinaryInteger<Int128>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out Int128 value)
		{
			Int128 @int = default(Int128);
			if (source.Length != 0)
			{
				sbyte b = (sbyte)(*source[source.Length - 1]);
				b = (sbyte)(b >> 31);
				isUnsigned |= (b == 0);
				if (isUnsigned && sbyte.IsNegative(b) && source.Length >= 16)
				{
					value = @int;
					return false;
				}
				if (source.Length > 16)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(16, ptr.Length - 16).ContainsAnyExcept((byte)b))
					{
						value = @int;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[15])))
					{
						value = @int;
						return false;
					}
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 16)
				{
					@int = Unsafe.ReadUnaligned<Int128>(ref reference);
					if (BitConverter.IsLittleEndian)
					{
						goto IL_136;
					}
				}
				for (int i = 0; i < source.Length; i++)
				{
					@int <<= 8;
					@int |= *Unsafe.Add<byte>(ref reference, i);
				}
				@int <<= (16 - source.Length) * 8;
				@int = BinaryPrimitives.ReverseEndianness(@int);
				if (!isUnsigned)
				{
					@int |= Int128.One << 127 >> (16 - source.Length) * 8 - 1;
				}
			}
			IL_136:
			value = @int;
			return true;
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x000431DC File Offset: 0x000413DC
		int IBinaryInteger<Int128>.GetShortestBitLength()
		{
			Int128 value = this;
			if (Int128.IsPositive(value))
			{
				return 128 - Int128.LeadingZeroCountAsInt32(value);
			}
			return 129 - Int128.LeadingZeroCountAsInt32(~value);
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00027484 File Offset: 0x00025684
		int IBinaryInteger<Int128>.GetByteCount()
		{
			return 16;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00043218 File Offset: 0x00041418
		bool IBinaryInteger<Int128>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 16)
			{
				ulong value = this._lower;
				ulong value2 = this._upper;
				bool isLittleEndian = BitConverter.IsLittleEndian;
				value = BinaryPrimitives.ReverseEndianness(value);
				value2 = BinaryPrimitives.ReverseEndianness(value2);
				ref byte reference = ref MemoryMarshal.GetReference<byte>(destination);
				Unsafe.WriteUnaligned<ulong>(ref reference, value2);
				Unsafe.WriteUnaligned<ulong>(Unsafe.AddByteOffset<byte>(ref reference, (IntPtr)8), value);
				bytesWritten = 16;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00043278 File Offset: 0x00041478
		bool IBinaryInteger<Int128>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 16)
			{
				ulong lower = this._lower;
				ulong upper = this._upper;
				if (!BitConverter.IsLittleEndian)
				{
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(destination);
				Unsafe.WriteUnaligned<ulong>(ref reference, lower);
				Unsafe.WriteUnaligned<ulong>(Unsafe.AddByteOffset<byte>(ref reference, (IntPtr)8), upper);
				bytesWritten = 16;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x000432C9 File Offset: 0x000414C9
		Int128 IBinaryNumber<Int128>.AllBitsSet
		{
			get
			{
				return new Int128(ulong.MaxValue, ulong.MaxValue);
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x000432D4 File Offset: 0x000414D4
		public static bool IsPow2(Int128 value)
		{
			return Int128.PopCount(value) == 1U && Int128.IsPositive(value);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000432F1 File Offset: 0x000414F1
		public static Int128 Log2(Int128 value)
		{
			if (Int128.IsNegative(value))
			{
				ThrowHelper.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
			}
			if (value._upper == 0UL)
			{
				return ulong.Log2(value._lower);
			}
			return 64UL + ulong.Log2(value._upper);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0004332D File Offset: 0x0004152D
		public static Int128 operator &(Int128 left, Int128 right)
		{
			return new Int128(left._upper & right._upper, left._lower & right._lower);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0004334E File Offset: 0x0004154E
		public static Int128 operator |(Int128 left, Int128 right)
		{
			return new Int128(left._upper | right._upper, left._lower | right._lower);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x0004336F File Offset: 0x0004156F
		public static Int128 operator ^(Int128 left, Int128 right)
		{
			return new Int128(left._upper ^ right._upper, left._lower ^ right._lower);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00043390 File Offset: 0x00041590
		public static Int128 operator ~(Int128 value)
		{
			return new Int128(~value._upper, ~value._lower);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000433A5 File Offset: 0x000415A5
		public static bool operator <(Int128 left, Int128 right)
		{
			return left._upper < right._upper || (left._upper == right._upper && left._lower < right._lower);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x000433D5 File Offset: 0x000415D5
		public static bool operator <=(Int128 left, Int128 right)
		{
			return left._upper < right._upper || (left._upper == right._upper && left._lower <= right._lower);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00043408 File Offset: 0x00041608
		public static bool operator >(Int128 left, Int128 right)
		{
			return left._upper > right._upper || (left._upper == right._upper && left._lower > right._lower);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00043438 File Offset: 0x00041638
		public static bool operator >=(Int128 left, Int128 right)
		{
			return left._upper > right._upper || (left._upper == right._upper && left._lower >= right._lower);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x0004346B File Offset: 0x0004166B
		public static Int128 operator --(Int128 value)
		{
			return value - Int128.One;
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00043478 File Offset: 0x00041678
		public static Int128 op_CheckedDecrement(Int128 value)
		{
			return Int128.op_CheckedSubtraction(value, Int128.One);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00043488 File Offset: 0x00041688
		public static Int128 operator /(Int128 left, Int128 right)
		{
			if (right == -1 && left._upper == 9223372036854775808UL && left._lower == 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			bool flag = ((left._upper ^ right._upper) & 9223372036854775808UL) != 0UL;
			if (Int128.IsNegative(left))
			{
				left = ~left + 1U;
			}
			if (Int128.IsNegative(right))
			{
				right = ~right + 1U;
			}
			UInt128 value = (UInt128)left / (UInt128)right;
			if (flag)
			{
				value = ~value + 1U;
			}
			return new Int128(value.Upper, value.Lower);
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00043547 File Offset: 0x00041747
		public static Int128 op_CheckedDivision(Int128 left, Int128 right)
		{
			return left / right;
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00043550 File Offset: 0x00041750
		public static bool operator ==(Int128 left, Int128 right)
		{
			return left._lower == right._lower && left._upper == right._upper;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00043570 File Offset: 0x00041770
		public static bool operator !=(Int128 left, Int128 right)
		{
			return left._lower != right._lower || left._upper != right._upper;
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00043593 File Offset: 0x00041793
		public static Int128 operator ++(Int128 value)
		{
			return value + Int128.One;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000435A0 File Offset: 0x000417A0
		public static Int128 op_CheckedIncrement(Int128 value)
		{
			return Int128.op_CheckedAddition(value, Int128.One);
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x000435AD File Offset: 0x000417AD
		public static Int128 MinValue
		{
			get
			{
				return new Int128(9223372036854775808UL, 0UL);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x000435BF File Offset: 0x000417BF
		public static Int128 MaxValue
		{
			get
			{
				return new Int128(9223372036854775807UL, ulong.MaxValue);
			}
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x000435D4 File Offset: 0x000417D4
		public static Int128 operator %(Int128 left, Int128 right)
		{
			Int128 left2 = left / right;
			return left - left2 * right;
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x000435F6 File Offset: 0x000417F6
		Int128 IMultiplicativeIdentity<Int128, Int128>.MultiplicativeIdentity
		{
			get
			{
				return Int128.One;
			}
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x000435FD File Offset: 0x000417FD
		public static Int128 operator *(Int128 left, Int128 right)
		{
			return (Int128)((UInt128)left * (UInt128)right);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00043618 File Offset: 0x00041818
		public static Int128 op_CheckedMultiply(Int128 left, Int128 right)
		{
			Int128 int2;
			Int128 @int = Int128.BigMul(left, right, out int2);
			if ((@int != 0 || int2 < 0) && (~@int != 0 || int2 >= 0))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return int2;
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x00043674 File Offset: 0x00041874
		internal static Int128 BigMul(Int128 left, Int128 right, out Int128 lower)
		{
			UInt128 value2;
			UInt128 value = UInt128.BigMul((UInt128)left, (UInt128)right, out value2);
			lower = (Int128)value2;
			return (Int128)value - (left >> 127 & right) - (right >> 127 & left);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x000436CB File Offset: 0x000418CB
		public static Int128 Clamp(Int128 value, Int128 min, Int128 max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<Int128>(min, max);
			}
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x000436F4 File Offset: 0x000418F4
		public static Int128 CopySign(Int128 value, Int128 sign)
		{
			Int128 @int = value;
			if (Int128.IsNegative(@int))
			{
				@int = -@int;
			}
			if (Int128.IsPositive(sign))
			{
				if (Int128.IsNegative(@int))
				{
					Math.ThrowNegateTwosCompOverflow();
				}
				return @int;
			}
			return -@int;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0004372F File Offset: 0x0004192F
		public static Int128 Max(Int128 x, Int128 y)
		{
			if (!(x >= y))
			{
				return y;
			}
			return x;
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0004373D File Offset: 0x0004193D
		Int128 INumber<Int128>.MaxNumber(Int128 x, Int128 y)
		{
			return Int128.Max(x, y);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00043746 File Offset: 0x00041946
		public static Int128 Min(Int128 x, Int128 y)
		{
			if (!(x <= y))
			{
				return y;
			}
			return x;
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x00043754 File Offset: 0x00041954
		Int128 INumber<Int128>.MinNumber(Int128 x, Int128 y)
		{
			return Int128.Min(x, y);
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00043760 File Offset: 0x00041960
		public static int Sign(Int128 value)
		{
			if (Int128.IsNegative(value))
			{
				return -1;
			}
			if (value != default(Int128))
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x0004378B File Offset: 0x0004198B
		public static Int128 One
		{
			get
			{
				return new Int128(0UL, 1UL);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<Int128>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00043798 File Offset: 0x00041998
		public static Int128 Zero
		{
			get
			{
				return default(Int128);
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x000437AE File Offset: 0x000419AE
		public static Int128 Abs(Int128 value)
		{
			if (Int128.IsNegative(value))
			{
				value = -value;
				if (Int128.IsNegative(value))
				{
					Math.ThrowNegateTwosCompOverflow();
				}
			}
			return value;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x000437D0 File Offset: 0x000419D0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int128 CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			Int128 result;
			if (typeof(TOther) == typeof(Int128))
			{
				result = (Int128)((object)value);
			}
			else if (!Int128.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<Int128>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00043828 File Offset: 0x00041A28
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int128 CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			Int128 result;
			if (typeof(TOther) == typeof(Int128))
			{
				result = (Int128)((object)value);
			}
			else if (!Int128.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<Int128>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00043880 File Offset: 0x00041A80
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int128 CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			Int128 result;
			if (typeof(TOther) == typeof(Int128))
			{
				result = (Int128)((object)value);
			}
			else if (!Int128.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<Int128>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<Int128>.IsCanonical(Int128 value)
		{
			return true;
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<Int128>.IsComplexNumber(Int128 value)
		{
			return false;
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x000438D6 File Offset: 0x00041AD6
		public static bool IsEvenInteger(Int128 value)
		{
			return (value._lower & 1UL) == 0UL;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<Int128>.IsFinite(Int128 value)
		{
			return true;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<Int128>.IsImaginaryNumber(Int128 value)
		{
			return false;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<Int128>.IsInfinity(Int128 value)
		{
			return false;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<Int128>.IsInteger(Int128 value)
		{
			return true;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<Int128>.IsNaN(Int128 value)
		{
			return false;
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000438E5 File Offset: 0x00041AE5
		public static bool IsNegative(Int128 value)
		{
			return value._upper < 0UL;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<Int128>.IsNegativeInfinity(Int128 value)
		{
			return false;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000438F1 File Offset: 0x00041AF1
		bool INumberBase<Int128>.IsNormal(Int128 value)
		{
			return value != 0;
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x000438FF File Offset: 0x00041AFF
		public static bool IsOddInteger(Int128 value)
		{
			return (value._lower & 1UL) > 0UL;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x0004390E File Offset: 0x00041B0E
		public static bool IsPositive(Int128 value)
		{
			return value._upper >= 0UL;
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<Int128>.IsPositiveInfinity(Int128 value)
		{
			return false;
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<Int128>.IsRealNumber(Int128 value)
		{
			return true;
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<Int128>.IsSubnormal(Int128 value)
		{
			return false;
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0004391D File Offset: 0x00041B1D
		bool INumberBase<Int128>.IsZero(Int128 value)
		{
			return value == 0;
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0004392C File Offset: 0x00041B2C
		public static Int128 MaxMagnitude(Int128 x, Int128 y)
		{
			Int128 @int = x;
			if (Int128.IsNegative(@int))
			{
				@int = -@int;
				if (Int128.IsNegative(@int))
				{
					return x;
				}
			}
			Int128 int2 = y;
			if (Int128.IsNegative(int2))
			{
				int2 = -int2;
				if (Int128.IsNegative(int2))
				{
					return y;
				}
			}
			if (@int > int2)
			{
				return x;
			}
			if (!(@int == int2))
			{
				return y;
			}
			if (!Int128.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00043990 File Offset: 0x00041B90
		Int128 INumberBase<Int128>.MaxMagnitudeNumber(Int128 x, Int128 y)
		{
			return Int128.MaxMagnitude(x, y);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0004399C File Offset: 0x00041B9C
		public static Int128 MinMagnitude(Int128 x, Int128 y)
		{
			Int128 @int = x;
			if (Int128.IsNegative(@int))
			{
				@int = -@int;
				if (Int128.IsNegative(@int))
				{
					return y;
				}
			}
			Int128 int2 = y;
			if (Int128.IsNegative(int2))
			{
				int2 = -int2;
				if (Int128.IsNegative(int2))
				{
					return x;
				}
			}
			if (@int < int2)
			{
				return x;
			}
			if (!(@int == int2))
			{
				return y;
			}
			if (!Int128.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00043A00 File Offset: 0x00041C00
		Int128 INumberBase<Int128>.MinMagnitudeNumber(Int128 x, Int128 y)
		{
			return Int128.MinMagnitude(x, y);
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00043A09 File Offset: 0x00041C09
		Int128 INumberBase<Int128>.MultiplyAddEstimate(Int128 left, Int128 right, Int128 addend)
		{
			return left * right + addend;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00043A18 File Offset: 0x00041C18
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Int128>.TryConvertFromChecked<TOther>(TOther value, out Int128 result) where TOther : INumberBase<TOther>
		{
			return Int128.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00043A24 File Offset: 0x00041C24
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out Int128 result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double value2 = (double)((object)value);
				result = Int128.op_CheckedExplicit(value2);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half value3 = (Half)((object)value);
				result = Half.op_CheckedExplicit(value3);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short value4 = (short)((object)value);
				result = value4;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int value5 = (int)((object)value);
				result = value5;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long value6 = (long)((object)value);
				result = value6;
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr value7 = (IntPtr)((object)value);
				result = value7;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte value8 = (sbyte)((object)value);
				result = value8;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float value9 = (float)((object)value);
				result = Int128.op_CheckedExplicit(value9);
				return true;
			}
			result = default(Int128);
			return false;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00043BE9 File Offset: 0x00041DE9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Int128>.TryConvertFromSaturating<TOther>(TOther value, out Int128 result) where TOther : INumberBase<TOther>
		{
			return Int128.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00043BF4 File Offset: 0x00041DF4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out Int128 result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 1.7014118346046923E+38) ? Int128.MaxValue : ((num <= -1.7014118346046923E+38) ? Int128.MinValue : ((Int128)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half == Half.PositiveInfinity) ? Int128.MaxValue : ((half == Half.NegativeInfinity) ? Int128.MinValue : ((Int128)half)));
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short value2 = (short)((object)value);
				result = value2;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int value3 = (int)((object)value);
				result = value3;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long value4 = (long)((object)value);
				result = value4;
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr value5 = (IntPtr)((object)value);
				result = value5;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte value6 = (sbyte)((object)value);
				result = value6;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num2 = (float)((object)value);
				result = ((num2 >= 1.7014118E+38f) ? Int128.MaxValue : ((num2 <= -1.7014118E+38f) ? Int128.MinValue : ((Int128)num2)));
				return true;
			}
			result = default(Int128);
			return false;
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00043E27 File Offset: 0x00042027
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Int128>.TryConvertFromTruncating<TOther>(TOther value, out Int128 result) where TOther : INumberBase<TOther>
		{
			return Int128.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00043E30 File Offset: 0x00042030
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out Int128 result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 1.7014118346046923E+38) ? Int128.MaxValue : ((num <= -1.7014118346046923E+38) ? Int128.MinValue : ((Int128)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half == Half.PositiveInfinity) ? Int128.MaxValue : ((half == Half.NegativeInfinity) ? Int128.MinValue : ((Int128)half)));
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short value2 = (short)((object)value);
				result = value2;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int value3 = (int)((object)value);
				result = value3;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long value4 = (long)((object)value);
				result = value4;
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr value5 = (IntPtr)((object)value);
				result = value5;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte value6 = (sbyte)((object)value);
				result = value6;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num2 = (float)((object)value);
				result = ((num2 >= 1.7014118E+38f) ? Int128.MaxValue : ((num2 <= -1.7014118E+38f) ? Int128.MinValue : ((Int128)num2)));
				return true;
			}
			result = default(Int128);
			return false;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00044064 File Offset: 0x00042264
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Int128>.TryConvertToChecked<TOther>(Int128 value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = Int128.op_CheckedExplicit(value);
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = Int128.op_CheckedExplicit(value);
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = Int128.op_CheckedExplicit(value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = Int128.op_CheckedExplicit(value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = Int128.op_CheckedExplicit(value);
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = Int128.op_CheckedExplicit(value);
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = Int128.op_CheckedExplicit(value);
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0004422C File Offset: 0x0004242C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Int128>.TryConvertToSaturating<TOther>(Int128 value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (value >= byte.MaxValue) ? byte.MaxValue : ((value <= 0) ? 0 : ((byte)value));
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (value >= char.MaxValue) ? char.MaxValue : ((value <= '\0') ? '\0' : ((char)value));
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (value >= new Int128((ulong)-1, ulong.MaxValue)) ? decimal.MaxValue : ((value <= new Int128(18446744069414584320UL, 1UL)) ? decimal.MinValue : ((decimal)value));
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (value >= ushort.MaxValue) ? ushort.MaxValue : ((value <= 0) ? 0 : ((ushort)value));
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (value >= uint.MaxValue) ? uint.MaxValue : ((value <= 0U) ? 0U : ((uint)value));
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (value >= ulong.MaxValue) ? ulong.MaxValue : ((value <= 0UL) ? 0UL : ((ulong)value));
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (value <= 0) ? UInt128.MinValue : ((UInt128)value);
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (value >= UIntPtr.MaxValue) ? UIntPtr.MaxValue : ((value <= UIntPtr.MinValue) ? UIntPtr.MinValue : ((UIntPtr)value));
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00044540 File Offset: 0x00042740
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Int128>.TryConvertToTruncating<TOther>(Int128 value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)value;
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)value;
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (value >= new Int128((ulong)-1, ulong.MaxValue)) ? decimal.MaxValue : ((value <= new Int128(18446744069414584320UL, 1UL)) ? decimal.MinValue : ((decimal)value));
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)value;
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)value;
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (ulong)value;
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (UInt128)value;
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)value;
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00044746 File Offset: 0x00042946
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out Int128 result)
		{
			return Int128.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00044754 File Offset: 0x00042954
		public static Int128 operator <<(Int128 value, int shiftAmount)
		{
			shiftAmount &= 127;
			if ((shiftAmount & 64) != 0)
			{
				return new Int128(value._lower << shiftAmount, 0UL);
			}
			if (shiftAmount != 0)
			{
				ulong lower = value._lower << shiftAmount;
				return new Int128(value._upper << shiftAmount | value._lower >> 64 - shiftAmount, lower);
			}
			return value;
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x000447B4 File Offset: 0x000429B4
		public static Int128 operator >>(Int128 value, int shiftAmount)
		{
			shiftAmount &= 127;
			if ((shiftAmount & 64) != 0)
			{
				ulong lower = value._upper >> shiftAmount;
				return new Int128(value._upper >> 63, lower);
			}
			if (shiftAmount != 0)
			{
				ulong lower2 = value._lower >> shiftAmount | value._upper << 64 - shiftAmount;
				return new Int128(value._upper >> shiftAmount, lower2);
			}
			return value;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0004481C File Offset: 0x00042A1C
		public static Int128 op_UnsignedRightShift(Int128 value, int shiftAmount)
		{
			shiftAmount &= 127;
			if ((shiftAmount & 64) != 0)
			{
				ulong lower = value._upper >> shiftAmount;
				return new Int128(0UL, lower);
			}
			if (shiftAmount != 0)
			{
				ulong lower2 = value._lower >> shiftAmount | value._upper << 64 - shiftAmount;
				return new Int128(value._upper >> shiftAmount, lower2);
			}
			return value;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x000432C9 File Offset: 0x000414C9
		public static Int128 NegativeOne
		{
			get
			{
				return new Int128(ulong.MaxValue, ulong.MaxValue);
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0004487B File Offset: 0x00042A7B
		public static Int128 Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return Int128.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00044885 File Offset: 0x00042A85
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out Int128 result)
		{
			return Int128.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00044890 File Offset: 0x00042A90
		public static Int128 operator -(Int128 left, Int128 right)
		{
			ulong num = left._lower - right._lower;
			ulong num2 = (ulong)((num > left._lower) ? 1L : 0L);
			return new Int128(left._upper - right._upper - num2, num);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x000448CC File Offset: 0x00042ACC
		public static Int128 op_CheckedSubtraction(Int128 left, Int128 right)
		{
			Int128 @int = left - right;
			uint num = (uint)(left._upper >> 63);
			if (num != (uint)(right._upper >> 63) && num != (uint)(@int._upper >> 63))
			{
				ThrowHelper.ThrowOverflowException();
			}
			return @int;
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0004490C File Offset: 0x00042B0C
		public static Int128 operator -(Int128 value)
		{
			return Int128.Zero - value;
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00044919 File Offset: 0x00042B19
		public static Int128 op_CheckedUnaryNegation(Int128 value)
		{
			return Int128.op_CheckedSubtraction(Int128.Zero, value);
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00007B62 File Offset: 0x00005D62
		public static Int128 operator +(Int128 value)
		{
			return value;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00044926 File Offset: 0x00042B26
		public static Int128 Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<byte, Int128>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0004493B File Offset: 0x00042B3B
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out Int128 result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<byte, Int128>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00044954 File Offset: 0x00042B54
		public static Int128 Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return Int128.Parse(utf8Text, NumberStyles.Integer, provider);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0004495E File Offset: 0x00042B5E
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out Int128 result)
		{
			return Int128.TryParse(utf8Text, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x000070DD File Offset: 0x000052DD
		bool IBinaryIntegerParseAndFormatInfo<Int128>.IsSigned
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06001656 RID: 5718 RVA: 0x00044969 File Offset: 0x00042B69
		int IBinaryIntegerParseAndFormatInfo<Int128>.MaxDigitCount
		{
			get
			{
				return 39;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x0001A499 File Offset: 0x00018699
		int IBinaryIntegerParseAndFormatInfo<Int128>.MaxHexDigitCount
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x0004496D File Offset: 0x00042B6D
		Int128 IBinaryIntegerParseAndFormatInfo<Int128>.MaxValueDiv10
		{
			get
			{
				return new Int128(922337203685477580UL, 14757395258967641292UL);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00044986 File Offset: 0x00042B86
		[Nullable(1)]
		string IBinaryIntegerParseAndFormatInfo<Int128>.OverflowMessage
		{
			get
			{
				return SR.Overflow_Int128;
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0004498D File Offset: 0x00042B8D
		bool IBinaryIntegerParseAndFormatInfo<Int128>.IsGreaterThanAsUnsigned(Int128 left, Int128 right)
		{
			return (UInt128)left > (UInt128)right;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x000449A0 File Offset: 0x00042BA0
		Int128 IBinaryIntegerParseAndFormatInfo<Int128>.MultiplyBy10(Int128 value)
		{
			return value * 10;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x000449AF File Offset: 0x00042BAF
		Int128 IBinaryIntegerParseAndFormatInfo<Int128>.MultiplyBy16(Int128 value)
		{
			return value * 16;
		}

		// Token: 0x040004C5 RID: 1221
		private readonly ulong _lower;

		// Token: 0x040004C6 RID: 1222
		private readonly ulong _upper;
	}
}
