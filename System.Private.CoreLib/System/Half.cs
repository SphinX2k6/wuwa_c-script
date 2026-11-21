using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000137 RID: 311
	public readonly struct Half : IComparable, ISpanFormattable, IFormattable, IComparable<Half>, IEquatable<Half>, IBinaryFloatingPointIeee754<Half>, IBinaryNumber<Half>, IBitwiseOperators<Half, Half, Half>, INumber<Half>, IComparisonOperators<Half, Half, bool>, IEqualityOperators<Half, Half, bool>, IModulusOperators<Half, Half, Half>, INumberBase<Half>, IAdditionOperators<Half, Half, Half>, IAdditiveIdentity<Half, Half>, IDecrementOperators<Half>, IDivisionOperators<Half, Half, Half>, IIncrementOperators<Half>, IMultiplicativeIdentity<Half, Half>, IMultiplyOperators<Half, Half, Half>, ISpanParsable<Half>, IParsable<Half>, ISubtractionOperators<Half, Half, Half>, IUnaryPlusOperators<Half, Half>, IUnaryNegationOperators<Half, Half>, IUtf8SpanFormattable, IUtf8SpanParsable<Half>, IFloatingPointIeee754<Half>, IExponentialFunctions<Half>, IFloatingPointConstants<Half>, IFloatingPoint<Half>, ISignedNumber<Half>, IHyperbolicFunctions<Half>, ILogarithmicFunctions<Half>, IPowerFunctions<Half>, IRootFunctions<Half>, ITrigonometricFunctions<Half>, IMinMaxValue<Half>, IBinaryFloatParseAndFormatInfo<Half>
	{
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x0003BF09 File Offset: 0x0003A109
		public static Half Epsilon
		{
			get
			{
				return new Half(1);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x0003BF11 File Offset: 0x0003A111
		public static Half PositiveInfinity
		{
			get
			{
				return new Half(31744);
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x0003BF1D File Offset: 0x0003A11D
		public static Half NegativeInfinity
		{
			get
			{
				return new Half(64512);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x0003BF29 File Offset: 0x0003A129
		public static Half NaN
		{
			get
			{
				return new Half(65024);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x0003BF35 File Offset: 0x0003A135
		public static Half MinValue
		{
			get
			{
				return new Half(64511);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x0003BF41 File Offset: 0x0003A141
		public static Half MaxValue
		{
			get
			{
				return new Half(31743);
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0003BF4D File Offset: 0x0003A14D
		internal Half(ushort value)
		{
			this._value = value;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0003BF56 File Offset: 0x0003A156
		private Half(bool sign, ushort exp, ushort sig)
		{
			this._value = (ushort)(((((sign > false) ? 1 : 0) << 15) ? 1 : 0) + ((int)exp << 10) + (int)sig);
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x0003BF6D File Offset: 0x0003A16D
		internal byte BiasedExponent
		{
			get
			{
				return Half.ExtractBiasedExponentFromBits(this._value);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x0003BF7A File Offset: 0x0003A17A
		internal sbyte Exponent
		{
			get
			{
				return (sbyte)(this.BiasedExponent - 15);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0003BF86 File Offset: 0x0003A186
		internal ushort Significand
		{
			get
			{
				return this.TrailingSignificand | ((this.BiasedExponent != 0) ? 1024 : 0);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060012A7 RID: 4775 RVA: 0x0003BFA0 File Offset: 0x0003A1A0
		internal ushort TrailingSignificand
		{
			get
			{
				return Half.ExtractTrailingSignificandFromBits(this._value);
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0003BFAD File Offset: 0x0003A1AD
		internal static byte ExtractBiasedExponentFromBits(ushort bits)
		{
			return (byte)(bits >> 10 & 31);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0003BFB7 File Offset: 0x0003A1B7
		internal static ushort ExtractTrailingSignificandFromBits(ushort bits)
		{
			return bits & 1023;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x0003BFC4 File Offset: 0x0003A1C4
		public static bool operator <(Half left, Half right)
		{
			if (Half.IsNaN(left) || Half.IsNaN(right))
			{
				return false;
			}
			bool flag = Half.IsNegative(left);
			if (flag != Half.IsNegative(right))
			{
				return flag && !Half.AreZero(left, right);
			}
			return left._value != right._value && (left._value < right._value ^ flag);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0003C023 File Offset: 0x0003A223
		public static bool operator >(Half left, Half right)
		{
			return right < left;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0003C02C File Offset: 0x0003A22C
		public static bool operator <=(Half left, Half right)
		{
			if (Half.IsNaN(left) || Half.IsNaN(right))
			{
				return false;
			}
			bool flag = Half.IsNegative(left);
			if (flag != Half.IsNegative(right))
			{
				return flag || Half.AreZero(left, right);
			}
			return left._value == right._value || (left._value < right._value ^ flag);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0003C088 File Offset: 0x0003A288
		public static bool operator >=(Half left, Half right)
		{
			return right <= left;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0003C091 File Offset: 0x0003A291
		public static bool operator ==(Half left, Half right)
		{
			return !Half.IsNaN(left) && !Half.IsNaN(right) && (left._value == right._value || Half.AreZero(left, right));
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0003C0BC File Offset: 0x0003A2BC
		public static bool operator !=(Half left, Half right)
		{
			return !(left == right);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0003C0C8 File Offset: 0x0003A2C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsFinite(Half value)
		{
			return (~value._value & 31744) > 0;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0003C0DA File Offset: 0x0003A2DA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInfinity(Half value)
		{
			return ((ulong)value._value & 18446744073709518847UL) == 31744UL;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0003C0F2 File Offset: 0x0003A2F2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNaN(Half value)
		{
			return ((ulong)value._value & 18446744073709518847UL) > 31744UL;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0003C10A File Offset: 0x0003A30A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool IsNaNOrZero(Half value)
		{
			return ((ulong)(value._value - 1) & 18446744073709518847UL) >= 31744UL;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0003C127 File Offset: 0x0003A327
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegative(Half value)
		{
			return (short)value._value < 0;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0003C133 File Offset: 0x0003A333
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegativeInfinity(Half value)
		{
			return value._value == 64512;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0003C142 File Offset: 0x0003A342
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNormal(Half value)
		{
			return (ushort)(((ulong)value._value & 18446744073709518847UL) - 1024UL) < 30720;
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0003C161 File Offset: 0x0003A361
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPositiveInfinity(Half value)
		{
			return value._value == 31744;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x0003C170 File Offset: 0x0003A370
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsSubnormal(Half value)
		{
			return (ushort)(((ulong)value._value & 18446744073709518847UL) - 1UL) < 1023;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x0003C18B File Offset: 0x0003A38B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool IsZero(Half value)
		{
			return ((ulong)value._value & 18446744073709518847UL) == 0UL;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0003C19F File Offset: 0x0003A39F
		[NullableContext(1)]
		public static Half Parse(string s)
		{
			return Half.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0003C1AD File Offset: 0x0003A3AD
		[NullableContext(1)]
		public static Half Parse(string s, NumberStyles style)
		{
			return Half.Parse(s, style, null);
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x0003C1B7 File Offset: 0x0003A3B7
		[NullableContext(1)]
		public static Half Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return Half.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0003C1C5 File Offset: 0x0003A3C5
		[NullableContext(1)]
		public static Half Parse(string s, NumberStyles style = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, [Nullable(2)] IFormatProvider provider = null)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return Half.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0003C1DE File Offset: 0x0003A3DE
		public static Half Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return Number.ParseFloat<char, Half>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0003C1F3 File Offset: 0x0003A3F3
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out Half result)
		{
			return Half.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null, out result);
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0003C202 File Offset: 0x0003A402
		public static bool TryParse(ReadOnlySpan<char> s, out Half result)
		{
			return Half.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null, out result);
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0003C211 File Offset: 0x0003A411
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out Half result)
		{
			return Half.TryParse(utf8Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null, out result);
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0003C220 File Offset: 0x0003A420
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out Half result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				result = Half.Zero;
				return false;
			}
			return Number.TryParseFloat<char, Half>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0003C24B File Offset: 0x0003A44B
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out Half result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return Number.TryParseFloat<char, Half>(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0003C261 File Offset: 0x0003A461
		private static bool AreZero(Half left, Half right)
		{
			return ((int)(left._value | right._value) & -32769) == 0;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0003C27C File Offset: 0x0003A47C
		[NullableContext(2)]
		public int CompareTo(object obj)
		{
			if (obj is Half)
			{
				Half other = (Half)obj;
				return this.CompareTo(other);
			}
			if (obj != null)
			{
				throw new ArgumentException(SR.Arg_MustBeHalf);
			}
			return 1;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0003C2B4 File Offset: 0x0003A4B4
		public int CompareTo(Half other)
		{
			if (this < other)
			{
				return -1;
			}
			if (this > other)
			{
				return 1;
			}
			if (this == other)
			{
				return 0;
			}
			if (!Half.IsNaN(this))
			{
				return 1;
			}
			if (!Half.IsNaN(other))
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0003C30C File Offset: 0x0003A50C
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Half)
			{
				Half other = (Half)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0003C331 File Offset: 0x0003A531
		public bool Equals(Half other)
		{
			return this._value == other._value || Half.AreZero(this, other) || (Half.IsNaN(this) && Half.IsNaN(other));
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0003C368 File Offset: 0x0003A568
		public override int GetHashCode()
		{
			uint num = (uint)this._value;
			if (Half.IsNaNOrZero(this))
			{
				num &= 31744U;
			}
			return (int)num;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0003C392 File Offset: 0x0003A592
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.FormatFloat<Half>(this, null, NumberFormatInfo.CurrentInfo);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0003C3A5 File Offset: 0x0003A5A5
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return Number.FormatFloat<Half>(this, format, NumberFormatInfo.CurrentInfo);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0003C3B8 File Offset: 0x0003A5B8
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.FormatFloat<Half>(this, null, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0003C3CC File Offset: 0x0003A5CC
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatFloat<Half>(this, format, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0003C3E0 File Offset: 0x0003A5E0
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatFloat<Half, char>(this, format, NumberFormatInfo.GetInstance(provider), destination, out charsWritten);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0003C3F7 File Offset: 0x0003A5F7
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatFloat<Half, byte>(this, format, NumberFormatInfo.GetInstance(provider), utf8Destination, out bytesWritten);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0003C40E File Offset: 0x0003A60E
		public static explicit operator Half(char value)
		{
			return (Half)((float)value);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x0003C417 File Offset: 0x0003A617
		public static explicit operator Half(decimal value)
		{
			return (Half)((float)value);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0003C428 File Offset: 0x0003A628
		public static explicit operator Half(double value)
		{
			ulong num = BitConverter.DoubleToUInt64Bits(value);
			bool flag = (num & 9223372036854775808UL) >> 63 > 0UL;
			int num2 = (int)((num & 9218868437227405312UL) >> 52);
			ulong num3 = num & 4503599627370495UL;
			if (num2 == 2047)
			{
				if (num3 != 0UL)
				{
					return Half.CreateHalfNaN(flag, num3 << 12);
				}
				if (!flag)
				{
					return Half.PositiveInfinity;
				}
				return Half.NegativeInfinity;
			}
			else
			{
				uint num4 = (uint)Half.ShiftRightJam(num3, 38);
				if ((num2 | (int)num4) == 0)
				{
					return new Half(flag, 0, 0);
				}
				return new Half(Half.RoundPackToHalf(flag, (short)(num2 - 1009), (ushort)(num4 | 16384U)));
			}
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x0003C40E File Offset: 0x0003A60E
		public static explicit operator Half(short value)
		{
			return (Half)((float)value);
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0003C40E File Offset: 0x0003A60E
		public static explicit operator Half(int value)
		{
			return (Half)((float)value);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0003C40E File Offset: 0x0003A60E
		public static explicit operator Half(long value)
		{
			return (Half)((float)value);
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0003C40E File Offset: 0x0003A60E
		public static explicit operator Half(IntPtr value)
		{
			return (Half)((float)value);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0003C4C4 File Offset: 0x0003A6C4
		public static explicit operator Half(float value)
		{
			uint num = (BitConverter.SingleToUInt32Bits(value) & 2147483648U) >> 16;
			uint num2 = (uint)(Unsafe.BitCast<bool, sbyte>(float.IsNaN(value)) - 1);
			value = float.Abs(value);
			value = float.Min(65520f, value);
			uint num3 = BitConverter.SingleToUInt32Bits(float.Max(value, BitConverter.UInt32BitsToSingle(947912704U)));
			num3 &= 2139095040U;
			num3 += 109051904U;
			value += BitConverter.UInt32BitsToSingle(num3);
			int num4 = (int)BitConverter.SingleToUInt32Bits(value);
			uint num5 = ~num2 & 31744U;
			int num6 = num4 - 1056964608;
			uint num7 = (uint)num6 >> 13;
			uint num8 = (uint)((num6 & (int)num2) + (int)num7 & (int)(~(int)num5));
			uint num9 = num5 | num;
			return BitConverter.UInt16BitsToHalf((ushort)(num8 | num9));
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0003C40E File Offset: 0x0003A60E
		[CLSCompliant(false)]
		public static explicit operator Half(ushort value)
		{
			return (Half)((float)value);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0003C565 File Offset: 0x0003A765
		[CLSCompliant(false)]
		public static explicit operator Half(uint value)
		{
			return (Half)value;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0003C565 File Offset: 0x0003A765
		[CLSCompliant(false)]
		public static explicit operator Half(ulong value)
		{
			return (Half)value;
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0003C565 File Offset: 0x0003A765
		[CLSCompliant(false)]
		public static explicit operator Half(UIntPtr value)
		{
			return (Half)value;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0003C56F File Offset: 0x0003A76F
		public static explicit operator byte(Half value)
		{
			return (byte)((float)value);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0003C579 File Offset: 0x0003A779
		public static byte op_CheckedExplicit(Half value)
		{
			return checked((byte)((float)value));
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0003C583 File Offset: 0x0003A783
		public static explicit operator char(Half value)
		{
			return (char)((float)value);
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0003C58D File Offset: 0x0003A78D
		public static char op_CheckedExplicit(Half value)
		{
			return checked((char)((float)value));
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0003C597 File Offset: 0x0003A797
		public static explicit operator decimal(Half value)
		{
			return (decimal)((float)value);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0003C5A5 File Offset: 0x0003A7A5
		public static explicit operator short(Half value)
		{
			return (short)((float)value);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0003C5AF File Offset: 0x0003A7AF
		public static short op_CheckedExplicit(Half value)
		{
			return checked((short)((float)value));
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0003C5B9 File Offset: 0x0003A7B9
		public static explicit operator int(Half value)
		{
			return (int)((float)value);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0003C5C3 File Offset: 0x0003A7C3
		public static int op_CheckedExplicit(Half value)
		{
			return checked((int)((float)value));
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0003C5CD File Offset: 0x0003A7CD
		public static explicit operator long(Half value)
		{
			return (long)((float)value);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0003C5D7 File Offset: 0x0003A7D7
		public static long op_CheckedExplicit(Half value)
		{
			return checked((long)((float)value));
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0003C5E1 File Offset: 0x0003A7E1
		public static explicit operator Int128(Half value)
		{
			return (Int128)((double)value);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0003C5EF File Offset: 0x0003A7EF
		public static Int128 op_CheckedExplicit(Half value)
		{
			return Int128.op_CheckedExplicit((double)value);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0003C5FD File Offset: 0x0003A7FD
		public static explicit operator IntPtr(Half value)
		{
			return (IntPtr)((float)value);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0003C607 File Offset: 0x0003A807
		public static IntPtr op_CheckedExplicit(Half value)
		{
			return checked((IntPtr)((float)value));
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0003C611 File Offset: 0x0003A811
		[CLSCompliant(false)]
		public static explicit operator sbyte(Half value)
		{
			return (sbyte)((float)value);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0003C61B File Offset: 0x0003A81B
		[CLSCompliant(false)]
		public static sbyte op_CheckedExplicit(Half value)
		{
			return checked((sbyte)((float)value));
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0003C583 File Offset: 0x0003A783
		[CLSCompliant(false)]
		public static explicit operator ushort(Half value)
		{
			return (ushort)((float)value);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0003C58D File Offset: 0x0003A78D
		[CLSCompliant(false)]
		public static ushort op_CheckedExplicit(Half value)
		{
			return checked((ushort)((float)value));
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0003C625 File Offset: 0x0003A825
		[CLSCompliant(false)]
		public static explicit operator uint(Half value)
		{
			return (uint)((float)value);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0003C62F File Offset: 0x0003A82F
		[CLSCompliant(false)]
		public static uint op_CheckedExplicit(Half value)
		{
			return checked((uint)((float)value));
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0003C639 File Offset: 0x0003A839
		[CLSCompliant(false)]
		public static explicit operator ulong(Half value)
		{
			return (ulong)((float)value);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0003C643 File Offset: 0x0003A843
		[CLSCompliant(false)]
		public static ulong op_CheckedExplicit(Half value)
		{
			return checked((ulong)((float)value));
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0003C64D File Offset: 0x0003A84D
		[CLSCompliant(false)]
		public static explicit operator UInt128(Half value)
		{
			return (UInt128)((double)value);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0003C65B File Offset: 0x0003A85B
		[CLSCompliant(false)]
		public static UInt128 op_CheckedExplicit(Half value)
		{
			return UInt128.op_CheckedExplicit((double)value);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0003C669 File Offset: 0x0003A869
		[CLSCompliant(false)]
		public static explicit operator UIntPtr(Half value)
		{
			return (UIntPtr)((float)value);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0003C673 File Offset: 0x0003A873
		[CLSCompliant(false)]
		public static UIntPtr op_CheckedExplicit(Half value)
		{
			return checked((UIntPtr)((float)value));
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0003C40E File Offset: 0x0003A60E
		public static implicit operator Half(byte value)
		{
			return (Half)((float)value);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0003C40E File Offset: 0x0003A60E
		[CLSCompliant(false)]
		public static implicit operator Half(sbyte value)
		{
			return (Half)((float)value);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0003C680 File Offset: 0x0003A880
		public static explicit operator double(Half value)
		{
			bool flag = Half.IsNegative(value);
			int num = (int)value.BiasedExponent;
			uint num2 = (uint)value.TrailingSignificand;
			if (num != 31)
			{
				if (num == 0)
				{
					if (num2 == 0U)
					{
						return BitConverter.UInt64BitsToDouble(flag ? 9223372036854775808UL : 0UL);
					}
					ValueTuple<int, uint> valueTuple = Half.NormSubnormalF16Sig(num2);
					num = valueTuple.Item1;
					num2 = valueTuple.Item2;
					num--;
				}
				return Half.CreateDouble(flag, (ushort)(num + 1008), (ulong)num2 << 42);
			}
			if (num2 != 0U)
			{
				return Half.CreateDoubleNaN(flag, (ulong)num2 << 54);
			}
			if (!flag)
			{
				return double.PositiveInfinity;
			}
			return double.NegativeInfinity;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0003C718 File Offset: 0x0003A918
		public static explicit operator float(Half value)
		{
			short num = BitConverter.HalfToInt16Bits(value);
			uint num2 = (uint)num & 2147483648U;
			short num3 = num & 31744;
			uint num4 = (uint)(-(uint)Unsafe.BitCast<bool, byte>(num3 == 0));
			int num5 = (int)Unsafe.BitCast<bool, byte>(num3 == 31744);
			uint num6 = num4 & 947912704U;
			uint num7 = 939524096U | num6;
			uint num8 = (uint)((uint)num << 13);
			num7 <<= num5;
			return BitConverter.UInt32BitsToSingle(BitConverter.SingleToUInt32Bits(BitConverter.UInt32BitsToSingle((num8 & 268427264U) + num7) - BitConverter.UInt32BitsToSingle(num6)) | num2);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0003C790 File Offset: 0x0003A990
		[return: TupleElementNames(new string[]
		{
			"Exp",
			"Sig"
		})]
		private static ValueTuple<int, uint> NormSubnormalF16Sig(uint sig)
		{
			int num = BitOperations.LeadingZeroCount(sig) - 16 - 5;
			return new ValueTuple<int, uint>(1 - num, sig << num);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0003C7B8 File Offset: 0x0003A9B8
		private static Half CreateHalfNaN(bool sign, ulong significand)
		{
			int num = (((sign > false) ? 1 : 0) << 15) ? 1 : 0;
			uint num2 = (uint)(significand >> 54);
			return BitConverter.UInt16BitsToHalf((ushort)(num | 32256 | (int)num2));
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0003C7E0 File Offset: 0x0003A9E0
		private static ushort RoundPackToHalf(bool sign, short exp, ushort sig)
		{
			int num = (int)(sig & 15);
			if (exp >= 29)
			{
				if (exp < 0)
				{
					sig = (ushort)Half.ShiftRightJam((uint)sig, (int)(-(int)exp));
					exp = 0;
					num = (int)(sig & 15);
				}
				else if (exp > 29 || sig + 8 >= 32768)
				{
					if (!sign)
					{
						return 31744;
					}
					return 64512;
				}
			}
			sig = (ushort)(sig + 8 >> 4);
			sig &= ((~(((num ^ 8) == 0 & true) ? 1 : 0)) ? 1 : 0);
			if (sig == 0)
			{
				exp = 0;
			}
			return new Half(sign, (ushort)exp, sig)._value;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0003C859 File Offset: 0x0003AA59
		private static uint ShiftRightJam(uint i, int dist)
		{
			if (dist >= 31)
			{
				return (i > 0U) ? 1U : 0U;
			}
			return i >> dist | ((i << -dist > 0U) ? 1U : 0U);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0003C879 File Offset: 0x0003AA79
		private static ulong ShiftRightJam(ulong l, int dist)
		{
			if (dist >= 63)
			{
				return (ulong)((l > 0UL) ? 1L : 0L);
			}
			return l >> dist | (ulong)((l << -dist > 0UL) ? 1L : 0L);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0003C8A0 File Offset: 0x0003AAA0
		private static double CreateDoubleNaN(bool sign, ulong significand)
		{
			ulong num = (ulong)((ulong)((sign > false) ? 1L : 0L) << 63);
			ulong num2 = significand >> 12;
			return BitConverter.UInt64BitsToDouble(num | 9221120237041090560UL | num2);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0003C8CB File Offset: 0x0003AACB
		private static double CreateDouble(bool sign, ushort exp, ulong sig)
		{
			return BitConverter.UInt64BitsToDouble((ulong)((((sign > false) ? 1L : 0L) << 63) + (long)((long)((ulong)exp) << 52) + (long)sig));
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0003C8E2 File Offset: 0x0003AAE2
		public static Half operator +(Half left, Half right)
		{
			return (Half)((float)left + (float)right);
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x0003C8F8 File Offset: 0x0003AAF8
		Half IAdditiveIdentity<Half, Half>.AdditiveIdentity
		{
			get
			{
				return new Half(0);
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x0003C900 File Offset: 0x0003AB00
		Half IBinaryNumber<Half>.AllBitsSet
		{
			get
			{
				return BitConverter.UInt16BitsToHalf(ushort.MaxValue);
			}
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0003C90C File Offset: 0x0003AB0C
		public static bool IsPow2(Half value)
		{
			ushort num = BitConverter.HalfToUInt16Bits(value);
			if ((short)num <= 0)
			{
				return false;
			}
			byte b = Half.ExtractBiasedExponentFromBits(num);
			ushort num2 = Half.ExtractTrailingSignificandFromBits(num);
			if (b == 0)
			{
				return ushort.PopCount(num2) == 1;
			}
			return b != 31 && num2 == 0;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0003C94D File Offset: 0x0003AB4D
		public static Half Log2(Half value)
		{
			return (Half)MathF.Log2((float)value);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0003C960 File Offset: 0x0003AB60
		Half IBitwiseOperators<Half, Half, Half>.op_BitwiseAnd(Half left, Half right)
		{
			return new Half(left._value & right._value);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0003C975 File Offset: 0x0003AB75
		Half IBitwiseOperators<Half, Half, Half>.op_BitwiseOr(Half left, Half right)
		{
			return new Half(left._value | right._value);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0003C98A File Offset: 0x0003AB8A
		Half IBitwiseOperators<Half, Half, Half>.op_ExclusiveOr(Half left, Half right)
		{
			return new Half(left._value ^ right._value);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0003C99F File Offset: 0x0003AB9F
		Half IBitwiseOperators<Half, Half, Half>.op_OnesComplement(Half value)
		{
			return new Half(~value._value);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x0003C9AE File Offset: 0x0003ABAE
		public static Half operator --(Half value)
		{
			return (Half)((float)value - 1f);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x0003C9C2 File Offset: 0x0003ABC2
		public static Half operator /(Half left, Half right)
		{
			return (Half)((float)left / (float)right);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0003C9D8 File Offset: 0x0003ABD8
		public static Half Exp(Half x)
		{
			return (Half)MathF.Exp((float)x);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0003C9EB File Offset: 0x0003ABEB
		public static Half ExpM1(Half x)
		{
			return (Half)float.ExpM1((float)x);
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0003C9FE File Offset: 0x0003ABFE
		public static Half Exp2(Half x)
		{
			return (Half)float.Exp2((float)x);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0003CA11 File Offset: 0x0003AC11
		public static Half Exp2M1(Half x)
		{
			return (Half)float.Exp2M1((float)x);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0003CA24 File Offset: 0x0003AC24
		public static Half Exp10(Half x)
		{
			return (Half)float.Exp10((float)x);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0003CA37 File Offset: 0x0003AC37
		public static Half Exp10M1(Half x)
		{
			return (Half)float.Exp10M1((float)x);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0003CA4A File Offset: 0x0003AC4A
		public static Half Ceiling(Half x)
		{
			return (Half)MathF.Ceiling((float)x);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0003CA5D File Offset: 0x0003AC5D
		[NullableContext(1)]
		public static TInteger ConvertToInteger<[Nullable(0)] TInteger>(Half value) where TInteger : IBinaryInteger<TInteger>
		{
			return INumberBase<TInteger>.CreateSaturating<Half>(value);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0003CA5D File Offset: 0x0003AC5D
		[NullableContext(1)]
		public static TInteger ConvertToIntegerNative<[Nullable(0)] TInteger>(Half value) where TInteger : IBinaryInteger<TInteger>
		{
			return INumberBase<TInteger>.CreateSaturating<Half>(value);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0003CA6B File Offset: 0x0003AC6B
		public static Half Floor(Half x)
		{
			return (Half)MathF.Floor((float)x);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0003CA7E File Offset: 0x0003AC7E
		public static Half Round(Half x)
		{
			return (Half)MathF.Round((float)x);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0003CA91 File Offset: 0x0003AC91
		public static Half Round(Half x, int digits)
		{
			return (Half)MathF.Round((float)x, digits);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0003CAA5 File Offset: 0x0003ACA5
		public static Half Round(Half x, MidpointRounding mode)
		{
			return (Half)MathF.Round((float)x, mode);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0003CAB9 File Offset: 0x0003ACB9
		public static Half Round(Half x, int digits, MidpointRounding mode)
		{
			return (Half)MathF.Round((float)x, digits, mode);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x0003CACE File Offset: 0x0003ACCE
		public static Half Truncate(Half x)
		{
			return (Half)MathF.Truncate((float)x);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000070DD File Offset: 0x000052DD
		int IFloatingPoint<Half>.GetExponentByteCount()
		{
			return 1;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0003CAE4 File Offset: 0x0003ACE4
		int IFloatingPoint<Half>.GetExponentShortestBitLength()
		{
			sbyte exponent = this.Exponent;
			if (exponent >= 0)
			{
				return (int)(8 - sbyte.LeadingZeroCount(exponent));
			}
			return (int)(9 - sbyte.LeadingZeroCount(~exponent));
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int IFloatingPoint<Half>.GetSignificandByteCount()
		{
			return 2;
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00030502 File Offset: 0x0002E702
		int IFloatingPoint<Half>.GetSignificandBitLength()
		{
			return 11;
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0003CB10 File Offset: 0x0003AD10
		bool IFloatingPoint<Half>.TryWriteExponentBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 1)
			{
				sbyte exponent = this.Exponent;
				Unsafe.WriteUnaligned<sbyte>(MemoryMarshal.GetReference<byte>(destination), exponent);
				bytesWritten = 1;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0003CB44 File Offset: 0x0003AD44
		bool IFloatingPoint<Half>.TryWriteExponentLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 1)
			{
				sbyte exponent = this.Exponent;
				Unsafe.WriteUnaligned<sbyte>(MemoryMarshal.GetReference<byte>(destination), exponent);
				bytesWritten = 1;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0003CB78 File Offset: 0x0003AD78
		bool IFloatingPoint<Half>.TryWriteSignificandBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				ushort value = this.Significand;
				bool isLittleEndian = BitConverter.IsLittleEndian;
				value = BinaryPrimitives.ReverseEndianness(value);
				Unsafe.WriteUnaligned<ushort>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0003CBB8 File Offset: 0x0003ADB8
		bool IFloatingPoint<Half>.TryWriteSignificandLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				ushort significand = this.Significand;
				if (!BitConverter.IsLittleEndian)
				{
				}
				Unsafe.WriteUnaligned<ushort>(MemoryMarshal.GetReference<byte>(destination), significand);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x0003CBF2 File Offset: 0x0003ADF2
		public static Half E
		{
			get
			{
				return new Half(16752);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x0003CBFE File Offset: 0x0003ADFE
		public static Half Pi
		{
			get
			{
				return new Half(16968);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x0003CC0A File Offset: 0x0003AE0A
		public static Half Tau
		{
			get
			{
				return new Half(17992);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x0003CC16 File Offset: 0x0003AE16
		public static Half NegativeZero
		{
			get
			{
				return new Half(32768);
			}
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0003CC22 File Offset: 0x0003AE22
		public static Half Atan2(Half y, Half x)
		{
			return (Half)MathF.Atan2((float)y, (float)x);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0003CC3C File Offset: 0x0003AE3C
		public static Half Atan2Pi(Half y, Half x)
		{
			return (Half)float.Atan2Pi((float)y, (float)x);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0003CC58 File Offset: 0x0003AE58
		public static Half BitDecrement(Half x)
		{
			uint num = (uint)x._value;
			if (!Half.IsFinite(x))
			{
				if (num != 31744U)
				{
					return x;
				}
				return Half.MaxValue;
			}
			else
			{
				if (num == 0U)
				{
					return -Half.Epsilon;
				}
				if (Half.IsNegative(x))
				{
					num += 1U;
				}
				else
				{
					num -= 1U;
				}
				return new Half((ushort)num);
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0003CCAC File Offset: 0x0003AEAC
		public static Half BitIncrement(Half x)
		{
			uint num = (uint)x._value;
			if (!Half.IsFinite(x))
			{
				if (num != 64512U)
				{
					return x;
				}
				return Half.MinValue;
			}
			else
			{
				if (num == 32768U)
				{
					return Half.Epsilon;
				}
				if (Half.IsNegative(x))
				{
					num -= 1U;
				}
				else
				{
					num += 1U;
				}
				return new Half((ushort)num);
			}
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0003CCFF File Offset: 0x0003AEFF
		public static Half FusedMultiplyAdd(Half left, Half right, Half addend)
		{
			return (Half)MathF.FusedMultiplyAdd((float)left, (float)right, (float)addend);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0003CD20 File Offset: 0x0003AF20
		public static Half Ieee754Remainder(Half left, Half right)
		{
			return (Half)MathF.IEEERemainder((float)left, (float)right);
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0003CD3A File Offset: 0x0003AF3A
		public static int ILogB(Half x)
		{
			if (Half.IsNormal(x))
			{
				return (int)x.Exponent;
			}
			if (Half.IsZero(x))
			{
				return int.MinValue;
			}
			if (!Half.IsFinite(x))
			{
				return int.MaxValue;
			}
			return -14 - (BitOperations.TrailingZeroCount((int)x.TrailingSignificand) - 5);
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0003CD79 File Offset: 0x0003AF79
		public static Half Lerp(Half value1, Half value2, Half amount)
		{
			return (Half)float.Lerp((float)value1, (float)value2, (float)amount);
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0003CD9A File Offset: 0x0003AF9A
		public static Half ReciprocalEstimate(Half x)
		{
			return (Half)MathF.ReciprocalEstimate((float)x);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0003CDAD File Offset: 0x0003AFAD
		public static Half ReciprocalSqrtEstimate(Half x)
		{
			return (Half)MathF.ReciprocalSqrtEstimate((float)x);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0003CDC0 File Offset: 0x0003AFC0
		public static Half ScaleB(Half x, int n)
		{
			return (Half)MathF.ScaleB((float)x, n);
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x0003CDD4 File Offset: 0x0003AFD4
		public static Half Acosh(Half x)
		{
			return (Half)MathF.Acosh((float)x);
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0003CDE7 File Offset: 0x0003AFE7
		public static Half Asinh(Half x)
		{
			return (Half)MathF.Asinh((float)x);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0003CDFA File Offset: 0x0003AFFA
		public static Half Atanh(Half x)
		{
			return (Half)MathF.Atanh((float)x);
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0003CE0D File Offset: 0x0003B00D
		public static Half Cosh(Half x)
		{
			return (Half)MathF.Cosh((float)x);
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0003CE20 File Offset: 0x0003B020
		public static Half Sinh(Half x)
		{
			return (Half)MathF.Sinh((float)x);
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x0003CE33 File Offset: 0x0003B033
		public static Half Tanh(Half x)
		{
			return (Half)MathF.Tanh((float)x);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0003CE46 File Offset: 0x0003B046
		public static Half operator ++(Half value)
		{
			return (Half)((float)value + 1f);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0003CE5A File Offset: 0x0003B05A
		public static Half Log(Half x)
		{
			return (Half)MathF.Log((float)x);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0003CE6D File Offset: 0x0003B06D
		public static Half Log(Half x, Half newBase)
		{
			return (Half)MathF.Log((float)x, (float)newBase);
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0003CE87 File Offset: 0x0003B087
		public static Half Log10(Half x)
		{
			return (Half)MathF.Log10((float)x);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0003CE9A File Offset: 0x0003B09A
		public static Half LogP1(Half x)
		{
			return (Half)float.LogP1((float)x);
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0003CEAD File Offset: 0x0003B0AD
		public static Half Log2P1(Half x)
		{
			return (Half)float.Log2P1((float)x);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0003CEC0 File Offset: 0x0003B0C0
		public static Half Log10P1(Half x)
		{
			return (Half)float.Log10P1((float)x);
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0003CED3 File Offset: 0x0003B0D3
		public static Half operator %(Half left, Half right)
		{
			return (Half)((float)left % (float)right);
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x0003CEE9 File Offset: 0x0003B0E9
		public static Half MultiplicativeIdentity
		{
			get
			{
				return new Half(15360);
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0003CEF5 File Offset: 0x0003B0F5
		public static Half operator *(Half left, Half right)
		{
			return (Half)((float)left * (float)right);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0003CF0B File Offset: 0x0003B10B
		public static Half Clamp(Half value, Half min, Half max)
		{
			return (Half)Math.Clamp((float)value, (float)min, (float)max);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0003CF2C File Offset: 0x0003B12C
		public static Half CopySign(Half value, Half sign)
		{
			ulong value2 = (ulong)value._value;
			uint value3 = (uint)sign._value;
			return new Half((ushort)((value2 & 18446744073709518847UL) | (ulong)(value3 & 32768U)));
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0003CF5D File Offset: 0x0003B15D
		public static Half Max(Half x, Half y)
		{
			return (Half)MathF.Max((float)x, (float)y);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0003CF77 File Offset: 0x0003B177
		public static Half MaxNumber(Half x, Half y)
		{
			if (x != y)
			{
				if (Half.IsNaN(y))
				{
					return x;
				}
				if (!(y < x))
				{
					return y;
				}
				return x;
			}
			else
			{
				if (!Half.IsNegative(y))
				{
					return y;
				}
				return x;
			}
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x0003CFA4 File Offset: 0x0003B1A4
		public static Half Min(Half x, Half y)
		{
			return (Half)MathF.Min((float)x, (float)y);
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0003CFBE File Offset: 0x0003B1BE
		public static Half MinNumber(Half x, Half y)
		{
			if (x != y)
			{
				if (Half.IsNaN(y))
				{
					return x;
				}
				if (!(x < y))
				{
					return y;
				}
				return x;
			}
			else
			{
				if (!Half.IsNegative(x))
				{
					return y;
				}
				return x;
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0003CFEB File Offset: 0x0003B1EB
		public static int Sign(Half value)
		{
			if (Half.IsNaN(value))
			{
				throw new ArithmeticException(SR.Arithmetic_NaN);
			}
			if (Half.IsZero(value))
			{
				return 0;
			}
			if (Half.IsNegative(value))
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0003CEE9 File Offset: 0x0003B0E9
		public static Half One
		{
			get
			{
				return new Half(15360);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<Half>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x0003C8F8 File Offset: 0x0003AAF8
		public static Half Zero
		{
			get
			{
				return new Half(0);
			}
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0003D015 File Offset: 0x0003B215
		public static Half Abs(Half value)
		{
			return new Half((ushort)((int)value._value & -32769));
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0003D02C File Offset: 0x0003B22C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Half CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			Half result;
			if (typeof(TOther) == typeof(Half))
			{
				result = (Half)((object)value);
			}
			else if (!Half.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<Half>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0003D084 File Offset: 0x0003B284
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Half CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			Half result;
			if (typeof(TOther) == typeof(Half))
			{
				result = (Half)((object)value);
			}
			else if (!Half.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<Half>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0003D0DC File Offset: 0x0003B2DC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Half CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			Half result;
			if (typeof(TOther) == typeof(Half))
			{
				result = (Half)((object)value);
			}
			else if (!Half.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<Half>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<Half>.IsCanonical(Half value)
		{
			return true;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<Half>.IsComplexNumber(Half value)
		{
			return false;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0003D132 File Offset: 0x0003B332
		public static bool IsEvenInteger(Half value)
		{
			return float.IsEvenInteger((float)value);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<Half>.IsImaginaryNumber(Half value)
		{
			return false;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0003D140 File Offset: 0x0003B340
		public static bool IsInteger(Half value)
		{
			return float.IsInteger((float)value);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0003D14E File Offset: 0x0003B34E
		public static bool IsOddInteger(Half value)
		{
			return float.IsOddInteger((float)value);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0003D15C File Offset: 0x0003B35C
		public static bool IsPositive(Half value)
		{
			return (short)value._value >= 0;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0003D16B File Offset: 0x0003B36B
		public static bool IsRealNumber(Half value)
		{
			return value == value;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0003D174 File Offset: 0x0003B374
		bool INumberBase<Half>.IsZero(Half value)
		{
			return Half.IsZero(value);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0003D17C File Offset: 0x0003B37C
		public static Half MaxMagnitude(Half x, Half y)
		{
			return (Half)MathF.MaxMagnitude((float)x, (float)y);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0003D198 File Offset: 0x0003B398
		public static Half MaxMagnitudeNumber(Half x, Half y)
		{
			Half left = Half.Abs(x);
			Half half = Half.Abs(y);
			if (left > half || Half.IsNaN(half))
			{
				return x;
			}
			if (!(left == half))
			{
				return y;
			}
			if (!Half.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x0003D1DC File Offset: 0x0003B3DC
		public static Half MinMagnitude(Half x, Half y)
		{
			return (Half)MathF.MinMagnitude((float)x, (float)y);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0003D1F8 File Offset: 0x0003B3F8
		public static Half MinMagnitudeNumber(Half x, Half y)
		{
			Half left = Half.Abs(x);
			Half half = Half.Abs(y);
			if (left < half || Half.IsNaN(half))
			{
				return x;
			}
			if (!(left == half))
			{
				return y;
			}
			if (!Half.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0003D23C File Offset: 0x0003B43C
		public static Half MultiplyAddEstimate(Half left, Half right, Half addend)
		{
			return (Half)float.MultiplyAddEstimate((float)left, (float)right, (float)addend);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0003D25D File Offset: 0x0003B45D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Half>.TryConvertFromChecked<TOther>(TOther value, out Half result) where TOther : INumberBase<TOther>
		{
			return Half.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x0003D25D File Offset: 0x0003B45D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Half>.TryConvertFromSaturating<TOther>(TOther value, out Half result) where TOther : INumberBase<TOther>
		{
			return Half.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x0003D25D File Offset: 0x0003B45D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Half>.TryConvertFromTruncating<TOther>(TOther value, out Half result) where TOther : INumberBase<TOther>
		{
			return Half.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0003D268 File Offset: 0x0003B468
		private static bool TryConvertFrom<TOther>(TOther value, out Half result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double value2 = (double)((object)value);
				result = (Half)value2;
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short value3 = (short)((object)value);
				result = (Half)value3;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int value4 = (int)((object)value);
				result = (Half)value4;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long value5 = (long)((object)value);
				result = (Half)value5;
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 value6 = (Int128)((object)value);
				result = (Half)value6;
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr value7 = (IntPtr)((object)value);
				result = (Half)value7;
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
				result = (Half)value9;
				return true;
			}
			result = default(Half);
			return false;
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0003D430 File Offset: 0x0003B630
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Half>.TryConvertToChecked<TOther>(Half value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = Half.op_CheckedExplicit(value);
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = Half.op_CheckedExplicit(value);
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
				ushort num2 = Half.op_CheckedExplicit(value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = Half.op_CheckedExplicit(value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = Half.op_CheckedExplicit(value);
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = Half.op_CheckedExplicit(value);
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = Half.op_CheckedExplicit(value);
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0003D5F5 File Offset: 0x0003B7F5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Half>.TryConvertToSaturating<TOther>(Half value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			return Half.TryConvertTo<TOther>(value, out result);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0003D5F5 File Offset: 0x0003B7F5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<Half>.TryConvertToTruncating<TOther>(Half value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			return Half.TryConvertTo<TOther>(value, out result);
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0003D600 File Offset: 0x0003B800
		private static bool TryConvertTo<TOther>(Half value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (value >= byte.MaxValue) ? byte.MaxValue : ((value <= 0) ? 0 : ((byte)value));
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (value == Half.PositiveInfinity) ? char.MaxValue : ((value <= Half.Zero) ? '\0' : ((char)value));
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (value == Half.PositiveInfinity) ? decimal.MaxValue : ((value == Half.NegativeInfinity) ? decimal.MinValue : (Half.IsNaN(value) ? 0.0m : ((decimal)value)));
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (value == Half.PositiveInfinity) ? ushort.MaxValue : ((value <= Half.Zero) ? 0 : ((ushort)value));
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (value == Half.PositiveInfinity) ? uint.MaxValue : ((value <= Half.Zero) ? 0U : ((uint)value));
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (value == Half.PositiveInfinity) ? ulong.MaxValue : ((value <= Half.Zero) ? 0UL : (Half.IsNaN(value) ? 0UL : ((ulong)value)));
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (value == Half.PositiveInfinity) ? UInt128.MaxValue : ((value <= Half.Zero) ? UInt128.MinValue : ((UInt128)value));
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (value == Half.PositiveInfinity) ? UIntPtr.MaxValue : ((value <= Half.Zero) ? UIntPtr.MinValue : ((UIntPtr)value));
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0003D91B File Offset: 0x0003BB1B
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out Half result)
		{
			return Half.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0003D92A File Offset: 0x0003BB2A
		public static Half Pow(Half x, Half y)
		{
			return (Half)MathF.Pow((float)x, (float)y);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0003D944 File Offset: 0x0003BB44
		public static Half Cbrt(Half x)
		{
			return (Half)MathF.Cbrt((float)x);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x0003D957 File Offset: 0x0003BB57
		public static Half Hypot(Half x, Half y)
		{
			return (Half)float.Hypot((float)x, (float)y);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x0003D971 File Offset: 0x0003BB71
		public static Half RootN(Half x, int n)
		{
			return (Half)float.RootN((float)x, n);
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0003D985 File Offset: 0x0003BB85
		public static Half Sqrt(Half x)
		{
			return (Half)MathF.Sqrt((float)x);
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x0003D998 File Offset: 0x0003BB98
		public static Half NegativeOne
		{
			get
			{
				return new Half(48128);
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0003D9A4 File Offset: 0x0003BBA4
		public static Half Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return Half.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x0003D9B2 File Offset: 0x0003BBB2
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out Half result)
		{
			return Half.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x0003D9C1 File Offset: 0x0003BBC1
		public static Half operator -(Half left, Half right)
		{
			return (Half)((float)left - (float)right);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0003D9D7 File Offset: 0x0003BBD7
		public static Half Acos(Half x)
		{
			return (Half)MathF.Acos((float)x);
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0003D9EA File Offset: 0x0003BBEA
		public static Half AcosPi(Half x)
		{
			return (Half)float.AcosPi((float)x);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0003D9FD File Offset: 0x0003BBFD
		public static Half Asin(Half x)
		{
			return (Half)MathF.Asin((float)x);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0003DA10 File Offset: 0x0003BC10
		public static Half AsinPi(Half x)
		{
			return (Half)float.AsinPi((float)x);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0003DA23 File Offset: 0x0003BC23
		public static Half Atan(Half x)
		{
			return (Half)MathF.Atan((float)x);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0003DA36 File Offset: 0x0003BC36
		public static Half AtanPi(Half x)
		{
			return (Half)float.AtanPi((float)x);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0003DA49 File Offset: 0x0003BC49
		public static Half Cos(Half x)
		{
			return (Half)MathF.Cos((float)x);
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0003DA5C File Offset: 0x0003BC5C
		public static Half CosPi(Half x)
		{
			return (Half)float.CosPi((float)x);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0003DA6F File Offset: 0x0003BC6F
		public static Half DegreesToRadians(Half degrees)
		{
			return (Half)float.DegreesToRadians((float)degrees);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0003DA82 File Offset: 0x0003BC82
		public static Half RadiansToDegrees(Half radians)
		{
			return (Half)float.RadiansToDegrees((float)radians);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0003DA95 File Offset: 0x0003BC95
		public static Half Sin(Half x)
		{
			return (Half)MathF.Sin((float)x);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0003DAA8 File Offset: 0x0003BCA8
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Half, Half> SinCos(Half x)
		{
			ValueTuple<float, float> valueTuple = MathF.SinCos((float)x);
			float item = valueTuple.Item1;
			float item2 = valueTuple.Item2;
			return new ValueTuple<Half, Half>((Half)item, (Half)item2);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0003DAE0 File Offset: 0x0003BCE0
		[return: TupleElementNames(new string[]
		{
			"SinPi",
			"CosPi"
		})]
		public static ValueTuple<Half, Half> SinCosPi(Half x)
		{
			ValueTuple<float, float> valueTuple = float.SinCosPi((float)x);
			float item = valueTuple.Item1;
			float item2 = valueTuple.Item2;
			return new ValueTuple<Half, Half>((Half)item, (Half)item2);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0003DB17 File Offset: 0x0003BD17
		public static Half SinPi(Half x)
		{
			return (Half)float.SinPi((float)x);
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0003DB2A File Offset: 0x0003BD2A
		public static Half Tan(Half x)
		{
			return (Half)MathF.Tan((float)x);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0003DB3D File Offset: 0x0003BD3D
		public static Half TanPi(Half x)
		{
			return (Half)float.TanPi((float)x);
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0003DB50 File Offset: 0x0003BD50
		public static Half operator -(Half value)
		{
			return (Half)(-(float)value);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00007B62 File Offset: 0x00005D62
		public static Half operator +(Half value)
		{
			return value;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0003DB5F File Offset: 0x0003BD5F
		public static Half Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseFloat<byte, Half>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0003DB74 File Offset: 0x0003BD74
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out Half result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseFloat<byte, Half>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0003DB8A File Offset: 0x0003BD8A
		public static Half Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return Half.Parse(utf8Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0003DB98 File Offset: 0x0003BD98
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out Half result)
		{
			return Half.TryParse(utf8Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0003052A File Offset: 0x0002E72A
		int IBinaryFloatParseAndFormatInfo<Half>.NumberBufferLength
		{
			get
			{
				return 23;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x000304C1 File Offset: 0x0002E6C1
		ulong IBinaryFloatParseAndFormatInfo<Half>.ZeroBits
		{
			get
			{
				return 0UL;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0003DBA7 File Offset: 0x0003BDA7
		ulong IBinaryFloatParseAndFormatInfo<Half>.InfinityBits
		{
			get
			{
				return 31744UL;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0003DBAF File Offset: 0x0003BDAF
		ulong IBinaryFloatParseAndFormatInfo<Half>.NormalMantissaMask
		{
			get
			{
				return 2047UL;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0003DBB7 File Offset: 0x0003BDB7
		ulong IBinaryFloatParseAndFormatInfo<Half>.DenormalMantissaMask
		{
			get
			{
				return 1023UL;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x0003DBBF File Offset: 0x0003BDBF
		int IBinaryFloatParseAndFormatInfo<Half>.MinBinaryExponent
		{
			get
			{
				return -14;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x000299CE File Offset: 0x00027BCE
		int IBinaryFloatParseAndFormatInfo<Half>.MaxBinaryExponent
		{
			get
			{
				return 15;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x0003DBC3 File Offset: 0x0003BDC3
		int IBinaryFloatParseAndFormatInfo<Half>.MinDecimalExponent
		{
			get
			{
				return -8;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x00022705 File Offset: 0x00020905
		int IBinaryFloatParseAndFormatInfo<Half>.MaxDecimalExponent
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x000299CE File Offset: 0x00027BCE
		int IBinaryFloatParseAndFormatInfo<Half>.ExponentBias
		{
			get
			{
				return 15;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x00022705 File Offset: 0x00020905
		ushort IBinaryFloatParseAndFormatInfo<Half>.ExponentBits
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x00029ADC File Offset: 0x00027CDC
		int IBinaryFloatParseAndFormatInfo<Half>.OverflowDecimalExponent
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06001393 RID: 5011 RVA: 0x0003DBC7 File Offset: 0x0003BDC7
		int IBinaryFloatParseAndFormatInfo<Half>.InfinityExponent
		{
			get
			{
				return 31;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x00030502 File Offset: 0x0002E702
		ushort IBinaryFloatParseAndFormatInfo<Half>.NormalMantissaBits
		{
			get
			{
				return 11;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06001395 RID: 5013 RVA: 0x00029CD6 File Offset: 0x00027ED6
		ushort IBinaryFloatParseAndFormatInfo<Half>.DenormalMantissaBits
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x0003DBC3 File Offset: 0x0003BDC3
		int IBinaryFloatParseAndFormatInfo<Half>.MinFastFloatDecimalExponent
		{
			get
			{
				return -8;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06001397 RID: 5015 RVA: 0x000211FB File Offset: 0x0001F3FB
		int IBinaryFloatParseAndFormatInfo<Half>.MaxFastFloatDecimalExponent
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0003DBCB File Offset: 0x0003BDCB
		int IBinaryFloatParseAndFormatInfo<Half>.MinExponentRoundToEven
		{
			get
			{
				return -21;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00022705 File Offset: 0x00020905
		int IBinaryFloatParseAndFormatInfo<Half>.MaxExponentRoundToEven
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x000211FB File Offset: 0x0001F3FB
		int IBinaryFloatParseAndFormatInfo<Half>.MaxExponentFastPath
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x0003DBCF File Offset: 0x0003BDCF
		ulong IBinaryFloatParseAndFormatInfo<Half>.MaxMantissaFastPath
		{
			get
			{
				return 2048UL;
			}
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0003DBD7 File Offset: 0x0003BDD7
		Half IBinaryFloatParseAndFormatInfo<Half>.BitsToFloat(ulong bits)
		{
			return BitConverter.UInt16BitsToHalf((ushort)bits);
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0003DBE0 File Offset: 0x0003BDE0
		ulong IBinaryFloatParseAndFormatInfo<Half>.FloatToBits(Half value)
		{
			return (ulong)BitConverter.HalfToUInt16Bits(value);
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x00022705 File Offset: 0x00020905
		int IBinaryFloatParseAndFormatInfo<Half>.MaxRoundTripDigits
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x00022705 File Offset: 0x00020905
		int IBinaryFloatParseAndFormatInfo<Half>.MaxPrecisionCustomFormat
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x040004AE RID: 1198
		internal readonly ushort _value;
	}
}
