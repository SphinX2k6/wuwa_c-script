using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020001EA RID: 490
	[CLSCompliant(false)]
	[Intrinsic]
	public readonly struct UInt128 : IBinaryInteger<UInt128>, IBinaryNumber<UInt128>, IBitwiseOperators<UInt128, UInt128, UInt128>, INumber<UInt128>, IComparable, IComparable<UInt128>, IComparisonOperators<UInt128, UInt128, bool>, IEqualityOperators<UInt128, UInt128, bool>, IModulusOperators<UInt128, UInt128, UInt128>, INumberBase<UInt128>, IAdditionOperators<UInt128, UInt128, UInt128>, IAdditiveIdentity<UInt128, UInt128>, IDecrementOperators<UInt128>, IDivisionOperators<UInt128, UInt128, UInt128>, IEquatable<UInt128>, IIncrementOperators<UInt128>, IMultiplicativeIdentity<UInt128, UInt128>, IMultiplyOperators<UInt128, UInt128, UInt128>, ISpanFormattable, IFormattable, ISpanParsable<UInt128>, IParsable<UInt128>, ISubtractionOperators<UInt128, UInt128, UInt128>, IUnaryPlusOperators<UInt128, UInt128>, IUnaryNegationOperators<UInt128, UInt128>, IUtf8SpanFormattable, IUtf8SpanParsable<UInt128>, IShiftOperators<UInt128, int, UInt128>, IMinMaxValue<UInt128>, IUnsignedNumber<UInt128>, IBinaryIntegerParseAndFormatInfo<UInt128>
	{
		// Token: 0x0600265E RID: 9822 RVA: 0x00074EC2 File Offset: 0x000730C2
		[CLSCompliant(false)]
		public UInt128(ulong upper, ulong lower)
		{
			this._lower = lower;
			this._upper = upper;
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x00074ED2 File Offset: 0x000730D2
		internal ulong Lower
		{
			get
			{
				return this._lower;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x00074EDA File Offset: 0x000730DA
		internal ulong Upper
		{
			get
			{
				return this._upper;
			}
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x00074EE4 File Offset: 0x000730E4
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value is UInt128)
			{
				UInt128 value2 = (UInt128)value;
				return this.CompareTo(value2);
			}
			if (value == null)
			{
				return 1;
			}
			throw new ArgumentException(SR.Arg_MustBeUInt128);
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x00074F17 File Offset: 0x00073117
		public int CompareTo(UInt128 value)
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

		// Token: 0x06002663 RID: 9827 RVA: 0x00074F3C File Offset: 0x0007313C
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is UInt128)
			{
				UInt128 other = (UInt128)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x00074F61 File Offset: 0x00073161
		public bool Equals(UInt128 other)
		{
			return this == other;
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x00074F6F File Offset: 0x0007316F
		public override int GetHashCode()
		{
			return HashCode.Combine<ulong, ulong>(this._lower, this._upper);
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00074F82 File Offset: 0x00073182
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.UInt128ToDecStr(this);
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x00074F8F File Offset: 0x0007318F
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.FormatUInt128(this, null, provider);
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x00074F9E File Offset: 0x0007319E
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return Number.FormatUInt128(this, format, null);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00074FAD File Offset: 0x000731AD
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatUInt128(this, format, provider);
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00074FBC File Offset: 0x000731BC
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatUInt128<char>(this, format, provider, destination, out charsWritten);
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00074FCE File Offset: 0x000731CE
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatUInt128<byte>(this, format, provider, utf8Destination, out bytesWritten);
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00074FE0 File Offset: 0x000731E0
		[NullableContext(1)]
		public static UInt128 Parse(string s)
		{
			return UInt128.Parse(s, NumberStyles.Integer, null);
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x00074FEA File Offset: 0x000731EA
		[NullableContext(1)]
		public static UInt128 Parse(string s, NumberStyles style)
		{
			return UInt128.Parse(s, style, null);
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x00074FF4 File Offset: 0x000731F4
		[NullableContext(1)]
		public static UInt128 Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return UInt128.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00074FFE File Offset: 0x000731FE
		[NullableContext(1)]
		public static UInt128 Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return UInt128.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00075017 File Offset: 0x00073217
		public static UInt128 Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<char, UInt128>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x0007502C File Offset: 0x0007322C
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out UInt128 result)
		{
			return UInt128.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00075037 File Offset: 0x00073237
		public static bool TryParse(ReadOnlySpan<char> s, out UInt128 result)
		{
			return UInt128.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00075042 File Offset: 0x00073242
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out UInt128 result)
		{
			return UInt128.TryParse(utf8Text, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x0007504D File Offset: 0x0007324D
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out UInt128 result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return Number.TryParseBinaryInteger<char, UInt128>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x0007507C File Offset: 0x0007327C
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out UInt128 result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<char, UInt128>(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00075095 File Offset: 0x00073295
		public static explicit operator byte(UInt128 value)
		{
			return (byte)value._lower;
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x0007509E File Offset: 0x0007329E
		public static byte op_CheckedExplicit(UInt128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((byte)value._lower);
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x000750B4 File Offset: 0x000732B4
		public static explicit operator char(UInt128 value)
		{
			return (char)value._lower;
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x000750BD File Offset: 0x000732BD
		public static char op_CheckedExplicit(UInt128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((char)value._lower);
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x000750D4 File Offset: 0x000732D4
		public static explicit operator decimal(UInt128 value)
		{
			ulong lower = value._lower;
			if (value._upper > (ulong)-1)
			{
				Number.ThrowOverflowException(SR.Overflow_Decimal);
			}
			uint hi = (uint)value._upper;
			return new decimal((int)lower, (int)(lower >> 32), (int)hi, false, 0);
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x00075114 File Offset: 0x00073314
		public static explicit operator double(UInt128 value)
		{
			if (value._upper == 0UL)
			{
				return value._lower;
			}
			if (value._upper >> 24 == 0UL)
			{
				double num = BitConverter.UInt64BitsToDouble(4841369599423283200UL | value._lower << 12 >> 12) - 4503599627370496.0;
				double num2 = BitConverter.UInt64BitsToDouble(5075556780046548992UL | (ulong)(value >> 52)) - 2.028240960365167E+31;
				return num + num2;
			}
			double num3 = BitConverter.UInt64BitsToDouble(4949455990480175104UL | (ulong)(value >> 12) >> 12 | (value._lower & 16777215UL)) - 7.555786372591432E+22;
			double num4 = BitConverter.UInt64BitsToDouble(5183643171103440896UL | (ulong)(value >> 76)) - 3.402823669209385E+38;
			return num3 + num4;
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x000751EC File Offset: 0x000733EC
		public static explicit operator Half(UInt128 value)
		{
			return (Half)((double)value);
		}

		// Token: 0x0600267D RID: 9853 RVA: 0x000751FA File Offset: 0x000733FA
		public static explicit operator short(UInt128 value)
		{
			return (short)value._lower;
		}

		// Token: 0x0600267E RID: 9854 RVA: 0x00075203 File Offset: 0x00073403
		public static short op_CheckedExplicit(UInt128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((short)value._lower);
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x00075219 File Offset: 0x00073419
		public static explicit operator int(UInt128 value)
		{
			return (int)value._lower;
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x00075222 File Offset: 0x00073422
		public static int op_CheckedExplicit(UInt128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((int)value._lower);
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x00074ED2 File Offset: 0x000730D2
		public static explicit operator long(UInt128 value)
		{
			return (long)value._lower;
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x00075238 File Offset: 0x00073438
		public static long op_CheckedExplicit(UInt128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((long)value._lower);
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x0007524E File Offset: 0x0007344E
		[CLSCompliant(false)]
		public static explicit operator Int128(UInt128 value)
		{
			return new Int128(value._upper, value._lower);
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x00075261 File Offset: 0x00073461
		[CLSCompliant(false)]
		public static Int128 op_CheckedExplicit(UInt128 value)
		{
			if (value._upper < 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return new Int128(value._upper, value._lower);
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x00075283 File Offset: 0x00073483
		public static explicit operator IntPtr(UInt128 value)
		{
			return (IntPtr)value._lower;
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x0007528C File Offset: 0x0007348C
		public static IntPtr op_CheckedExplicit(UInt128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((IntPtr)value._lower);
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000752A2 File Offset: 0x000734A2
		[CLSCompliant(false)]
		public static explicit operator sbyte(UInt128 value)
		{
			return (sbyte)value._lower;
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x000752AB File Offset: 0x000734AB
		[CLSCompliant(false)]
		public static sbyte op_CheckedExplicit(UInt128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((sbyte)value._lower);
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000752C1 File Offset: 0x000734C1
		public static explicit operator float(UInt128 value)
		{
			return (float)((double)value);
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000750B4 File Offset: 0x000732B4
		[CLSCompliant(false)]
		public static explicit operator ushort(UInt128 value)
		{
			return (ushort)value._lower;
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x000750BD File Offset: 0x000732BD
		[CLSCompliant(false)]
		public static ushort op_CheckedExplicit(UInt128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((ushort)value._lower);
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x000752CB File Offset: 0x000734CB
		[CLSCompliant(false)]
		public static explicit operator uint(UInt128 value)
		{
			return (uint)value._lower;
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000752D4 File Offset: 0x000734D4
		[CLSCompliant(false)]
		public static uint op_CheckedExplicit(UInt128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((uint)value._lower);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00074ED2 File Offset: 0x000730D2
		[CLSCompliant(false)]
		public static explicit operator ulong(UInt128 value)
		{
			return value._lower;
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000752EA File Offset: 0x000734EA
		[CLSCompliant(false)]
		public static ulong op_CheckedExplicit(UInt128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return value._lower;
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000752FF File Offset: 0x000734FF
		[CLSCompliant(false)]
		public static explicit operator UIntPtr(UInt128 value)
		{
			return (UIntPtr)value._lower;
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00075308 File Offset: 0x00073508
		[CLSCompliant(false)]
		public static UIntPtr op_CheckedExplicit(UInt128 value)
		{
			if (value._upper != 0UL)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return checked((UIntPtr)value._lower);
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x0007531E File Offset: 0x0007351E
		public static explicit operator UInt128(decimal value)
		{
			value = decimal.Truncate(value);
			if (value < 0.0m)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return new UInt128((ulong)value.High, value.Low64);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00075353 File Offset: 0x00073553
		public static explicit operator UInt128(double value)
		{
			if (double.IsNegative(value) || double.IsNaN(value))
			{
				return UInt128.MinValue;
			}
			if (value >= 3.402823669209385E+38)
			{
				return UInt128.MaxValue;
			}
			return UInt128.ToUInt128(value);
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00075383 File Offset: 0x00073583
		public static UInt128 op_CheckedExplicit(double value)
		{
			if (value < 0.0 || double.IsNaN(value) || value >= 3.402823669209385E+38)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return UInt128.ToUInt128(value);
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000753B0 File Offset: 0x000735B0
		internal static UInt128 ToUInt128(double value)
		{
			if (value >= 1.0)
			{
				ulong num = BitConverter.DoubleToUInt64Bits(value);
				return new UInt128(num << 12 >> 1 | 9223372036854775808UL, 0UL) >> 1150 - (int)(num >> 52);
			}
			return UInt128.MinValue;
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00075400 File Offset: 0x00073600
		public static explicit operator UInt128(short value)
		{
			long num = (long)value;
			return new UInt128((ulong)(num >> 63), (ulong)num);
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x0007541A File Offset: 0x0007361A
		public static UInt128 op_CheckedExplicit(short value)
		{
			if (value < 0)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return new UInt128(0UL, (ulong)((ushort)value));
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x00075430 File Offset: 0x00073630
		public static explicit operator UInt128(int value)
		{
			long num = (long)value;
			return new UInt128((ulong)(num >> 63), (ulong)num);
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x0007544A File Offset: 0x0007364A
		public static UInt128 op_CheckedExplicit(int value)
		{
			if (value < 0)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return new UInt128(0UL, (ulong)value);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00075460 File Offset: 0x00073660
		public static explicit operator UInt128(long value)
		{
			return new UInt128((ulong)(value >> 63), (ulong)value);
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00075479 File Offset: 0x00073679
		public static UInt128 op_CheckedExplicit(long value)
		{
			if (value < 0L)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return new UInt128(0UL, (ulong)value);
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00075490 File Offset: 0x00073690
		public static explicit operator UInt128(IntPtr value)
		{
			long num = (long)value;
			return new UInt128((ulong)(num >> 63), (ulong)num);
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000754AA File Offset: 0x000736AA
		public static UInt128 op_CheckedExplicit(IntPtr value)
		{
			if (value < (IntPtr)0)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return new UInt128(0UL, (ulong)value);
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000754C0 File Offset: 0x000736C0
		[CLSCompliant(false)]
		public static explicit operator UInt128(sbyte value)
		{
			long num = (long)value;
			return new UInt128((ulong)(num >> 63), (ulong)num);
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x000754DA File Offset: 0x000736DA
		[CLSCompliant(false)]
		public static UInt128 op_CheckedExplicit(sbyte value)
		{
			if (value < 0)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return new UInt128(0UL, (ulong)((byte)value));
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x000754EF File Offset: 0x000736EF
		public static explicit operator UInt128(float value)
		{
			return (UInt128)((double)value);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x000754F8 File Offset: 0x000736F8
		public static UInt128 op_CheckedExplicit(float value)
		{
			return UInt128.op_CheckedExplicit((double)value);
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00075501 File Offset: 0x00073701
		public static implicit operator UInt128(byte value)
		{
			return new UInt128(0UL, (ulong)value);
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x00075501 File Offset: 0x00073701
		public static implicit operator UInt128(char value)
		{
			return new UInt128(0UL, (ulong)value);
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00075501 File Offset: 0x00073701
		[CLSCompliant(false)]
		public static implicit operator UInt128(ushort value)
		{
			return new UInt128(0UL, (ulong)value);
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00075501 File Offset: 0x00073701
		[CLSCompliant(false)]
		public static implicit operator UInt128(uint value)
		{
			return new UInt128(0UL, (ulong)value);
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x0007550C File Offset: 0x0007370C
		[CLSCompliant(false)]
		public static implicit operator UInt128(ulong value)
		{
			return new UInt128(0UL, value);
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00075501 File Offset: 0x00073701
		[CLSCompliant(false)]
		public static implicit operator UInt128(UIntPtr value)
		{
			return new UInt128(0UL, (ulong)value);
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x00075518 File Offset: 0x00073718
		private void WriteLittleEndianUnsafe(Span<byte> destination)
		{
			ulong lower = this._lower;
			ulong upper = this._upper;
			if (!BitConverter.IsLittleEndian)
			{
			}
			ref byte reference = ref MemoryMarshal.GetReference<byte>(destination);
			Unsafe.WriteUnaligned<ulong>(ref reference, lower);
			Unsafe.WriteUnaligned<ulong>(Unsafe.AddByteOffset<byte>(ref reference, (IntPtr)8), upper);
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x00075554 File Offset: 0x00073754
		public static UInt128 operator +(UInt128 left, UInt128 right)
		{
			ulong num = left._lower + right._lower;
			ulong num2 = (ulong)((num < left._lower) ? 1L : 0L);
			return new UInt128(left._upper + right._upper + num2, num);
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x00075590 File Offset: 0x00073790
		public static UInt128 op_CheckedAddition(UInt128 left, UInt128 right)
		{
			ulong num = left._lower + right._lower;
			ulong num2 = (ulong)((num < left._lower) ? 1L : 0L);
			return new UInt128(checked(left._upper + right._upper + num2), num);
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x000755CC File Offset: 0x000737CC
		UInt128 IAdditiveIdentity<UInt128, UInt128>.AdditiveIdentity
		{
			get
			{
				return default(UInt128);
			}
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x000755E4 File Offset: 0x000737E4
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<UInt128, UInt128> DivRem(UInt128 left, UInt128 right)
		{
			UInt128 @uint = left / right;
			return new ValueTuple<UInt128, UInt128>(@uint, left - @uint * right);
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x0007560C File Offset: 0x0007380C
		public static UInt128 LeadingZeroCount(UInt128 value)
		{
			return (uint)UInt128.LeadingZeroCountAsInt32(value);
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00075619 File Offset: 0x00073819
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int LeadingZeroCountAsInt32(UInt128 value)
		{
			if (value._upper == 0UL)
			{
				return 64 + BitOperations.LeadingZeroCount(value._lower);
			}
			return BitOperations.LeadingZeroCount(value._upper);
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x0007563D File Offset: 0x0007383D
		public static UInt128 PopCount(UInt128 value)
		{
			return ulong.PopCount(value._lower) + ulong.PopCount(value._upper);
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x0007565B File Offset: 0x0007385B
		public static UInt128 RotateLeft(UInt128 value, int rotateAmount)
		{
			return value << rotateAmount | UInt128.op_UnsignedRightShift(value, 128 - rotateAmount);
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x00075676 File Offset: 0x00073876
		public static UInt128 RotateRight(UInt128 value, int rotateAmount)
		{
			return UInt128.op_UnsignedRightShift(value, rotateAmount) | value << 128 - rotateAmount;
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x00075691 File Offset: 0x00073891
		public static UInt128 TrailingZeroCount(UInt128 value)
		{
			if (value._lower == 0UL)
			{
				return 64UL + ulong.TrailingZeroCount(value._upper);
			}
			return ulong.TrailingZeroCount(value._lower);
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x000756C0 File Offset: 0x000738C0
		unsafe bool IBinaryInteger<UInt128>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out UInt128 value)
		{
			UInt128 @uint = default(UInt128);
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[0])))
				{
					value = @uint;
					return false;
				}
				if (source.Length > 16)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 16).ContainsAnyExcept(0))
					{
						value = @uint;
						return false;
					}
				}
				ref byte source2 = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 16)
				{
					source2 = Unsafe.Add<byte>(ref source2, source.Length - 16);
					@uint = Unsafe.ReadUnaligned<UInt128>(ref source2);
					bool isLittleEndian = BitConverter.IsLittleEndian;
					@uint = BinaryPrimitives.ReverseEndianness(@uint);
				}
				else
				{
					for (int i = 0; i < source.Length; i++)
					{
						@uint <<= 8;
						@uint |= *Unsafe.Add<byte>(ref source2, i);
					}
				}
			}
			value = @uint;
			return true;
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x0007579C File Offset: 0x0007399C
		unsafe bool IBinaryInteger<UInt128>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out UInt128 value)
		{
			UInt128 @uint = default(UInt128);
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[source.Length - 1])))
				{
					value = @uint;
					return false;
				}
				if (source.Length > 16)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(16, ptr.Length - 16).ContainsAnyExcept(0))
					{
						value = @uint;
						return false;
					}
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 16)
				{
					@uint = Unsafe.ReadUnaligned<UInt128>(ref reference);
					if (BitConverter.IsLittleEndian)
					{
						goto IL_BE;
					}
				}
				for (int i = 0; i < source.Length; i++)
				{
					UInt128 uint2 = *Unsafe.Add<byte>(ref reference, i);
					uint2 <<= i * 8;
					@uint |= uint2;
				}
			}
			IL_BE:
			value = @uint;
			return true;
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x0007586F File Offset: 0x00073A6F
		int IBinaryInteger<UInt128>.GetShortestBitLength()
		{
			return 128 - UInt128.LeadingZeroCountAsInt32(this);
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00027484 File Offset: 0x00025684
		int IBinaryInteger<UInt128>.GetByteCount()
		{
			return 16;
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00075884 File Offset: 0x00073A84
		bool IBinaryInteger<UInt128>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
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

		// Token: 0x060026B8 RID: 9912 RVA: 0x000758E2 File Offset: 0x00073AE2
		bool IBinaryInteger<UInt128>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 16)
			{
				this.WriteLittleEndianUnsafe(destination);
				bytesWritten = 16;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x00075900 File Offset: 0x00073B00
		UInt128 IBinaryNumber<UInt128>.AllBitsSet
		{
			get
			{
				return new UInt128(ulong.MaxValue, ulong.MaxValue);
			}
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0007590B File Offset: 0x00073B0B
		public static bool IsPow2(UInt128 value)
		{
			return UInt128.PopCount(value) == 1U;
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x0007591E File Offset: 0x00073B1E
		public static UInt128 Log2(UInt128 value)
		{
			if (value._upper == 0UL)
			{
				return ulong.Log2(value._lower);
			}
			return 64UL + ulong.Log2(value._upper);
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x0007594D File Offset: 0x00073B4D
		public static UInt128 operator &(UInt128 left, UInt128 right)
		{
			return new UInt128(left._upper & right._upper, left._lower & right._lower);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x0007596E File Offset: 0x00073B6E
		public static UInt128 operator |(UInt128 left, UInt128 right)
		{
			return new UInt128(left._upper | right._upper, left._lower | right._lower);
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x0007598F File Offset: 0x00073B8F
		public static UInt128 operator ^(UInt128 left, UInt128 right)
		{
			return new UInt128(left._upper ^ right._upper, left._lower ^ right._lower);
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x000759B0 File Offset: 0x00073BB0
		public static UInt128 operator ~(UInt128 value)
		{
			return new UInt128(~value._upper, ~value._lower);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x000759C5 File Offset: 0x00073BC5
		public static bool operator <(UInt128 left, UInt128 right)
		{
			return left._upper < right._upper || (left._upper == right._upper && left._lower < right._lower);
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x000759F5 File Offset: 0x00073BF5
		public static bool operator <=(UInt128 left, UInt128 right)
		{
			return left._upper < right._upper || (left._upper == right._upper && left._lower <= right._lower);
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00075A28 File Offset: 0x00073C28
		public static bool operator >(UInt128 left, UInt128 right)
		{
			return left._upper > right._upper || (left._upper == right._upper && left._lower > right._lower);
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00075A58 File Offset: 0x00073C58
		public static bool operator >=(UInt128 left, UInt128 right)
		{
			return left._upper > right._upper || (left._upper == right._upper && left._lower >= right._lower);
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00075A8B File Offset: 0x00073C8B
		public static UInt128 operator --(UInt128 value)
		{
			return value - UInt128.One;
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x00075A98 File Offset: 0x00073C98
		public static UInt128 op_CheckedDecrement(UInt128 value)
		{
			return UInt128.op_CheckedSubtraction(value, UInt128.One);
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00075AA8 File Offset: 0x00073CA8
		public static UInt128 operator /(UInt128 left, UInt128 right)
		{
			if (right._upper == 0UL)
			{
				if (right._lower == 0UL)
				{
					ThrowHelper.ThrowDivideByZeroException();
				}
				if (left._upper == 0UL)
				{
					return left._lower / right._lower;
				}
			}
			if (!(right >= left))
			{
				return UInt128.<op_Division>g__DivideSlow|111_2(left, right);
			}
			if (!(right == left))
			{
				return UInt128.Zero;
			}
			return UInt128.One;
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00075B0A File Offset: 0x00073D0A
		public static UInt128 op_CheckedDivision(UInt128 left, UInt128 right)
		{
			return left / right;
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00075B13 File Offset: 0x00073D13
		public static bool operator ==(UInt128 left, UInt128 right)
		{
			return left._lower == right._lower && left._upper == right._upper;
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x00075B33 File Offset: 0x00073D33
		public static bool operator !=(UInt128 left, UInt128 right)
		{
			return left._lower != right._lower || left._upper != right._upper;
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x00075B56 File Offset: 0x00073D56
		public static UInt128 operator ++(UInt128 value)
		{
			return value + UInt128.One;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x00075B63 File Offset: 0x00073D63
		public static UInt128 op_CheckedIncrement(UInt128 value)
		{
			return UInt128.op_CheckedAddition(value, UInt128.One);
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x00075B70 File Offset: 0x00073D70
		public static UInt128 MinValue
		{
			get
			{
				return new UInt128(0UL, 0UL);
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x00075900 File Offset: 0x00073B00
		public static UInt128 MaxValue
		{
			get
			{
				return new UInt128(ulong.MaxValue, ulong.MaxValue);
			}
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x00075B7C File Offset: 0x00073D7C
		public static UInt128 operator %(UInt128 left, UInt128 right)
		{
			UInt128 left2 = left / right;
			return left - left2 * right;
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x00075B9E File Offset: 0x00073D9E
		UInt128 IMultiplicativeIdentity<UInt128, UInt128>.MultiplicativeIdentity
		{
			get
			{
				return UInt128.One;
			}
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x00075BA8 File Offset: 0x00073DA8
		public static UInt128 operator *(UInt128 left, UInt128 right)
		{
			ulong lower;
			return new UInt128(Math.BigMul(left._lower, right._lower, out lower) + (left._upper * right._lower + left._lower * right._upper), lower);
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x00075BEC File Offset: 0x00073DEC
		public static UInt128 op_CheckedMultiply(UInt128 left, UInt128 right)
		{
			UInt128 result;
			if (UInt128.BigMul(left, right, out result) != 0U)
			{
				ThrowHelper.ThrowOverflowException();
			}
			return result;
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00075C18 File Offset: 0x00073E18
		internal static UInt128 BigMul(UInt128 left, UInt128 right, out UInt128 lower)
		{
			ulong lower2 = left._lower;
			ulong upper = left._upper;
			ulong lower3 = right._lower;
			ulong upper2 = right._upper;
			UInt128 @uint = Math.BigMul(lower2, lower3);
			UInt128 uint2 = Math.BigMul(upper, lower3) + @uint._upper;
			UInt128 uint3 = Math.BigMul(lower2, upper2) + uint2._lower;
			lower = new UInt128(uint3._lower, @uint._lower);
			return Math.BigMul(upper, upper2) + uint2._upper + uint3._upper;
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00075CBB File Offset: 0x00073EBB
		public static UInt128 Clamp(UInt128 value, UInt128 min, UInt128 max)
		{
			if (min > max)
			{
				Math.ThrowMinMaxException<UInt128>(min, max);
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

		// Token: 0x060026D4 RID: 9940 RVA: 0x00007B62 File Offset: 0x00005D62
		UInt128 INumber<UInt128>.CopySign(UInt128 value, UInt128 sign)
		{
			return value;
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x00075CE4 File Offset: 0x00073EE4
		public static UInt128 Max(UInt128 x, UInt128 y)
		{
			if (!(x >= y))
			{
				return y;
			}
			return x;
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00075CF2 File Offset: 0x00073EF2
		UInt128 INumber<UInt128>.MaxNumber(UInt128 x, UInt128 y)
		{
			return UInt128.Max(x, y);
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x00075CFB File Offset: 0x00073EFB
		public static UInt128 Min(UInt128 x, UInt128 y)
		{
			if (!(x <= y))
			{
				return y;
			}
			return x;
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00075D09 File Offset: 0x00073F09
		UInt128 INumber<UInt128>.MinNumber(UInt128 x, UInt128 y)
		{
			return UInt128.Min(x, y);
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00075D12 File Offset: 0x00073F12
		public static int Sign(UInt128 value)
		{
			return (!(value == 0U)) ? 1 : 0;
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x00075D23 File Offset: 0x00073F23
		public static UInt128 One
		{
			get
			{
				return new UInt128(0UL, 1UL);
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<UInt128>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060026DC RID: 9948 RVA: 0x00075D30 File Offset: 0x00073F30
		public static UInt128 Zero
		{
			get
			{
				return default(UInt128);
			}
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x00007B62 File Offset: 0x00005D62
		UInt128 INumberBase<UInt128>.Abs(UInt128 value)
		{
			return value;
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00075D48 File Offset: 0x00073F48
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UInt128 CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			UInt128 result;
			if (typeof(TOther) == typeof(UInt128))
			{
				result = (UInt128)((object)value);
			}
			else if (!UInt128.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<UInt128>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x00075DA0 File Offset: 0x00073FA0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UInt128 CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			UInt128 result;
			if (typeof(TOther) == typeof(UInt128))
			{
				result = (UInt128)((object)value);
			}
			else if (!UInt128.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<UInt128>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x00075DF8 File Offset: 0x00073FF8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UInt128 CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			UInt128 result;
			if (typeof(TOther) == typeof(UInt128))
			{
				result = (UInt128)((object)value);
			}
			else if (!UInt128.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<UInt128>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<UInt128>.IsCanonical(UInt128 value)
		{
			return true;
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UInt128>.IsComplexNumber(UInt128 value)
		{
			return false;
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00075E4E File Offset: 0x0007404E
		public static bool IsEvenInteger(UInt128 value)
		{
			return (value._lower & 1UL) == 0UL;
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<UInt128>.IsFinite(UInt128 value)
		{
			return true;
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UInt128>.IsImaginaryNumber(UInt128 value)
		{
			return false;
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UInt128>.IsInfinity(UInt128 value)
		{
			return false;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<UInt128>.IsInteger(UInt128 value)
		{
			return true;
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UInt128>.IsNaN(UInt128 value)
		{
			return false;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UInt128>.IsNegative(UInt128 value)
		{
			return false;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UInt128>.IsNegativeInfinity(UInt128 value)
		{
			return false;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00075E5D File Offset: 0x0007405D
		bool INumberBase<UInt128>.IsNormal(UInt128 value)
		{
			return value != 0U;
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x00075E6B File Offset: 0x0007406B
		public static bool IsOddInteger(UInt128 value)
		{
			return (value._lower & 1UL) > 0UL;
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<UInt128>.IsPositive(UInt128 value)
		{
			return true;
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UInt128>.IsPositiveInfinity(UInt128 value)
		{
			return false;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<UInt128>.IsRealNumber(UInt128 value)
		{
			return true;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UInt128>.IsSubnormal(UInt128 value)
		{
			return false;
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x00075E7A File Offset: 0x0007407A
		bool INumberBase<UInt128>.IsZero(UInt128 value)
		{
			return value == 0U;
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x00075CF2 File Offset: 0x00073EF2
		UInt128 INumberBase<UInt128>.MaxMagnitude(UInt128 x, UInt128 y)
		{
			return UInt128.Max(x, y);
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x00075CF2 File Offset: 0x00073EF2
		UInt128 INumberBase<UInt128>.MaxMagnitudeNumber(UInt128 x, UInt128 y)
		{
			return UInt128.Max(x, y);
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x00075D09 File Offset: 0x00073F09
		UInt128 INumberBase<UInt128>.MinMagnitude(UInt128 x, UInt128 y)
		{
			return UInt128.Min(x, y);
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x00075D09 File Offset: 0x00073F09
		UInt128 INumberBase<UInt128>.MinMagnitudeNumber(UInt128 x, UInt128 y)
		{
			return UInt128.Min(x, y);
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00075E88 File Offset: 0x00074088
		UInt128 INumberBase<UInt128>.MultiplyAddEstimate(UInt128 left, UInt128 right, UInt128 addend)
		{
			return left * right + addend;
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x00075E97 File Offset: 0x00074097
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UInt128>.TryConvertFromChecked<TOther>(TOther value, out UInt128 result) where TOther : INumberBase<TOther>
		{
			return UInt128.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x00075EA0 File Offset: 0x000740A0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out UInt128 result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte value2 = (byte)((object)value);
				result = value2;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char value3 = (char)((object)value);
				result = value3;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal value4 = (decimal)((object)value);
				result = (UInt128)value4;
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort value5 = (ushort)((object)value);
				result = value5;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint value6 = (uint)((object)value);
				result = value6;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong value7 = (ulong)((object)value);
				result = value7;
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr value8 = (UIntPtr)((object)value);
				result = value8;
				return true;
			}
			result = default(UInt128);
			return false;
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x0007602E File Offset: 0x0007422E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UInt128>.TryConvertFromSaturating<TOther>(TOther value, out UInt128 result) where TOther : INumberBase<TOther>
		{
			return UInt128.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x00076038 File Offset: 0x00074238
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out UInt128 result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte value2 = (byte)((object)value);
				result = value2;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char value3 = (char)((object)value);
				result = value3;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num < 0m) ? UInt128.MinValue : ((UInt128)num));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort value4 = (ushort)((object)value);
				result = value4;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint value5 = (uint)((object)value);
				result = value5;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong value6 = (ulong)((object)value);
				result = value6;
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr value7 = (UIntPtr)((object)value);
				result = value7;
				return true;
			}
			result = default(UInt128);
			return false;
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x000761DA File Offset: 0x000743DA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UInt128>.TryConvertFromTruncating<TOther>(TOther value, out UInt128 result) where TOther : INumberBase<TOther>
		{
			return UInt128.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x000761E4 File Offset: 0x000743E4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out UInt128 result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte value2 = (byte)((object)value);
				result = value2;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char value3 = (char)((object)value);
				result = value3;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num < 0m) ? UInt128.MinValue : ((UInt128)num));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort value4 = (ushort)((object)value);
				result = value4;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint value5 = (uint)((object)value);
				result = value5;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong value6 = (ulong)((object)value);
				result = value6;
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr value7 = (UIntPtr)((object)value);
				result = value7;
				return true;
			}
			result = default(UInt128);
			return false;
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x00076388 File Offset: 0x00074588
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UInt128>.TryConvertToChecked<TOther>(UInt128 value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)value;
				result = (TOther)((object)half);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = UInt128.op_CheckedExplicit(value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = UInt128.op_CheckedExplicit(value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = UInt128.op_CheckedExplicit(value);
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = UInt128.op_CheckedExplicit(value);
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = UInt128.op_CheckedExplicit(value);
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = UInt128.op_CheckedExplicit(value);
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num5 = (float)value;
				result = (TOther)((object)num5);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x00076588 File Offset: 0x00074788
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UInt128>.TryConvertToSaturating<TOther>(UInt128 value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)value;
				result = (TOther)((object)half);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (value >= new UInt128(0UL, 32767UL)) ? short.MaxValue : ((short)value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (value >= new UInt128(0UL, 2147483647UL)) ? int.MaxValue : ((int)value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (value >= new UInt128(0UL, 9223372036854775807UL)) ? long.MaxValue : ((long)value);
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = (value >= new UInt128(9223372036854775807UL, ulong.MaxValue)) ? Int128.MaxValue : ((Int128)value);
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (value >= new UInt128(0UL, 9223372036854775807UL)) ? IntPtr.MaxValue : ((IntPtr)value);
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (value >= new UInt128(0UL, 127UL)) ? sbyte.MaxValue : ((sbyte)value);
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num5 = (float)value;
				result = (TOther)((object)num5);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00076838 File Offset: 0x00074A38
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UInt128>.TryConvertToTruncating<TOther>(UInt128 value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)value;
				result = (TOther)((object)half);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)value;
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (int)value;
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (long)value;
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = (Int128)value;
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)value;
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)value;
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num5 = (float)value;
				result = (TOther)((object)num5);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x00076A36 File Offset: 0x00074C36
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out UInt128 result)
		{
			return UInt128.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x00076A44 File Offset: 0x00074C44
		public static UInt128 operator <<(UInt128 value, int shiftAmount)
		{
			shiftAmount &= 127;
			if ((shiftAmount & 64) != 0)
			{
				return new UInt128(value._lower << shiftAmount, 0UL);
			}
			if (shiftAmount != 0)
			{
				ulong lower = value._lower << shiftAmount;
				return new UInt128(value._upper << shiftAmount | value._lower >> 64 - shiftAmount, lower);
			}
			return value;
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x00076AA1 File Offset: 0x00074CA1
		public static UInt128 operator >>(UInt128 value, int shiftAmount)
		{
			return UInt128.op_UnsignedRightShift(value, shiftAmount);
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x00076AAC File Offset: 0x00074CAC
		public static UInt128 op_UnsignedRightShift(UInt128 value, int shiftAmount)
		{
			shiftAmount &= 127;
			if ((shiftAmount & 64) != 0)
			{
				ulong lower = value._upper >> shiftAmount;
				return new UInt128(0UL, lower);
			}
			if (shiftAmount != 0)
			{
				ulong lower2 = value._lower >> shiftAmount | value._upper << 64 - shiftAmount;
				return new UInt128(value._upper >> shiftAmount, lower2);
			}
			return value;
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x00076B0B File Offset: 0x00074D0B
		public static UInt128 Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return UInt128.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00076B15 File Offset: 0x00074D15
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out UInt128 result)
		{
			return UInt128.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x00076B20 File Offset: 0x00074D20
		public static UInt128 operator -(UInt128 left, UInt128 right)
		{
			ulong num = left._lower - right._lower;
			ulong num2 = (ulong)((num > left._lower) ? 1L : 0L);
			return new UInt128(left._upper - right._upper - num2, num);
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x00076B5C File Offset: 0x00074D5C
		public static UInt128 op_CheckedSubtraction(UInt128 left, UInt128 right)
		{
			ulong num = left._lower - right._lower;
			ulong num2 = (ulong)((num > left._lower) ? 1L : 0L);
			return new UInt128(checked(left._upper - right._upper - num2), num);
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x00076B97 File Offset: 0x00074D97
		public static UInt128 operator -(UInt128 value)
		{
			return UInt128.Zero - value;
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x00076BA4 File Offset: 0x00074DA4
		public static UInt128 op_CheckedUnaryNegation(UInt128 value)
		{
			return UInt128.op_CheckedSubtraction(UInt128.Zero, value);
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x00007B62 File Offset: 0x00005D62
		public static UInt128 operator +(UInt128 value)
		{
			return value;
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00076BB1 File Offset: 0x00074DB1
		public static UInt128 Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<byte, UInt128>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00076BC6 File Offset: 0x00074DC6
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out UInt128 result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<byte, UInt128>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00076BDF File Offset: 0x00074DDF
		public static UInt128 Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return UInt128.Parse(utf8Text, NumberStyles.Integer, provider);
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00076BE9 File Offset: 0x00074DE9
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out UInt128 result)
		{
			return UInt128.TryParse(utf8Text, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x00007B65 File Offset: 0x00005D65
		bool IBinaryIntegerParseAndFormatInfo<UInt128>.IsSigned
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x00044969 File Offset: 0x00042B69
		int IBinaryIntegerParseAndFormatInfo<UInt128>.MaxDigitCount
		{
			get
			{
				return 39;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x0001A499 File Offset: 0x00018699
		int IBinaryIntegerParseAndFormatInfo<UInt128>.MaxHexDigitCount
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x00076BF4 File Offset: 0x00074DF4
		UInt128 IBinaryIntegerParseAndFormatInfo<UInt128>.MaxValueDiv10
		{
			get
			{
				return new UInt128(1844674407370955161UL, 11068046444225730969UL);
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x00076C0D File Offset: 0x00074E0D
		[Nullable(1)]
		string IBinaryIntegerParseAndFormatInfo<UInt128>.OverflowMessage
		{
			get
			{
				return SR.Overflow_UInt128;
			}
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00076C14 File Offset: 0x00074E14
		bool IBinaryIntegerParseAndFormatInfo<UInt128>.IsGreaterThanAsUnsigned(UInt128 left, UInt128 right)
		{
			return left > right;
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x00076C1D File Offset: 0x00074E1D
		UInt128 IBinaryIntegerParseAndFormatInfo<UInt128>.MultiplyBy10(UInt128 value)
		{
			return value * 10;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00076C2C File Offset: 0x00074E2C
		UInt128 IBinaryIntegerParseAndFormatInfo<UInt128>.MultiplyBy16(UInt128 value)
		{
			return value * 16;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00076C3C File Offset: 0x00074E3C
		[CompilerGenerated]
		internal unsafe static uint <op_Division>g__AddDivisor|111_0(Span<uint> left, ReadOnlySpan<uint> right)
		{
			ulong num = 0UL;
			for (int i = 0; i < right.Length; i++)
			{
				ref uint ptr = ref left[i];
				ulong num2 = (ulong)ptr + num + (ulong)(*right[i]);
				ptr = (uint)num2;
				num = num2 >> 32;
			}
			return (uint)num;
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00076C84 File Offset: 0x00074E84
		[CompilerGenerated]
		internal static bool <op_Division>g__DivideGuessTooBig|111_1(ulong q, ulong valHi, uint valLo, uint divHi, uint divLo)
		{
			ulong num = (ulong)divHi * q;
			ulong num2 = (ulong)divLo * q;
			num += num2 >> 32;
			num2 = (ulong)((uint)num2);
			return num > valHi || (num == valHi && num2 > (ulong)valLo);
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00076CB8 File Offset: 0x00074EB8
		[CompilerGenerated]
		internal unsafe static UInt128 <op_Division>g__DivideSlow|111_2(UInt128 quotient, UInt128 divisor)
		{
			uint* ptr = stackalloc uint[(UIntPtr)16];
			Unsafe.WriteUnaligned<uint>(ref *(byte*)ptr, (uint)quotient._lower);
			Unsafe.WriteUnaligned<uint>(ref *(byte*)(ptr + 1), (uint)(quotient._lower >> 32));
			Unsafe.WriteUnaligned<uint>(ref *(byte*)(ptr + 2), (uint)quotient._upper);
			Unsafe.WriteUnaligned<uint>(ref *(byte*)(ptr + 3), (uint)(quotient._upper >> 32));
			Span<uint> span = new Span<uint>((void*)ptr, 4 - UInt128.LeadingZeroCountAsInt32(quotient) / 32);
			uint* ptr2 = stackalloc uint[(UIntPtr)16];
			Unsafe.WriteUnaligned<uint>(ref *(byte*)ptr2, (uint)divisor._lower);
			Unsafe.WriteUnaligned<uint>(ref *(byte*)(ptr2 + 1), (uint)(divisor._lower >> 32));
			Unsafe.WriteUnaligned<uint>(ref *(byte*)(ptr2 + 2), (uint)divisor._upper);
			Unsafe.WriteUnaligned<uint>(ref *(byte*)(ptr2 + 3), (uint)(divisor._upper >> 32));
			Span<uint> span2 = new Span<uint>((void*)ptr2, 4 - UInt128.LeadingZeroCountAsInt32(divisor) / 32);
			Span<uint> span3 = new Span<uint>(stackalloc byte[(UIntPtr)16], 4);
			span3.Clear();
			Span<uint> span4 = span3.Slice(0, span.Length - span2.Length + 1);
			uint num = *span2[span2.Length - 1];
			uint num2 = (span2.Length > 1) ? (*span2[span2.Length - 2]) : 0U;
			int num3 = BitOperations.LeadingZeroCount(num);
			int num4 = 32 - num3;
			if (num3 > 0)
			{
				uint num5 = (span2.Length > 2) ? (*span2[span2.Length - 3]) : 0U;
				num = (num << num3 | num2 >> num4);
				num2 = (num2 << num3 | num5 >> num4);
			}
			for (int i = span.Length; i >= span2.Length; i--)
			{
				int num6 = i - span2.Length;
				uint num7 = (i < span.Length) ? (*span[i]) : 0U;
				ulong num8 = (ulong)num7 << 32 | (ulong)(*span[i - 1]);
				uint num9 = (i > 1) ? (*span[i - 2]) : 0U;
				if (num3 > 0)
				{
					uint num10 = (i > 2) ? (*span[i - 3]) : 0U;
					num8 = (num8 << num3 | (ulong)(num9 >> num4));
					num9 = (num9 << num3 | num10 >> num4);
				}
				ulong num11 = num8 / (ulong)num;
				if (num11 > (ulong)-1)
				{
					num11 = (ulong)-1;
				}
				while (UInt128.<op_Division>g__DivideGuessTooBig|111_1(num11, num8, num9, num, num2))
				{
					num11 -= 1UL;
				}
				if (num11 > 0UL && UInt128.<op_Division>g__SubtractDivisor|111_3(span.Slice(num6), span2, num11) != num7)
				{
					UInt128.<op_Division>g__AddDivisor|111_0(span.Slice(num6), span2);
					num11 -= 1UL;
				}
				if (num6 < span4.Length)
				{
					*span4[num6] = (uint)num11;
				}
				if (i < span.Length)
				{
					*span[i] = 0U;
				}
			}
			return new UInt128((ulong)(*span3[3]) << 32 | (ulong)(*span3[2]), (ulong)(*span3[1]) << 32 | (ulong)(*span3[0]));
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x00076FC0 File Offset: 0x000751C0
		[CompilerGenerated]
		internal unsafe static uint <op_Division>g__SubtractDivisor|111_3(Span<uint> left, ReadOnlySpan<uint> right, ulong q)
		{
			ulong num = 0UL;
			for (int i = 0; i < right.Length; i++)
			{
				num += (ulong)(*right[i]) * q;
				uint num2 = (uint)num;
				num >>= 32;
				ref uint ptr = ref left[i];
				if (ptr < num2)
				{
					num += 1UL;
				}
				ptr -= num2;
			}
			return (uint)num;
		}

		// Token: 0x040006EB RID: 1771
		private readonly ulong _lower;

		// Token: 0x040006EC RID: 1772
		private readonly ulong _upper;
	}
}
