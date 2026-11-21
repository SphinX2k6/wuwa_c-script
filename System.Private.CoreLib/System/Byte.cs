using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x020000E1 RID: 225
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct Byte : IComparable, IConvertible, ISpanFormattable, IFormattable, IComparable<byte>, IEquatable<byte>, IBinaryInteger<byte>, IBinaryNumber<byte>, IBitwiseOperators<byte, byte, byte>, INumber<byte>, IComparisonOperators<byte, byte, bool>, IEqualityOperators<byte, byte, bool>, IModulusOperators<byte, byte, byte>, INumberBase<byte>, IAdditionOperators<byte, byte, byte>, IAdditiveIdentity<byte, byte>, IDecrementOperators<byte>, IDivisionOperators<byte, byte, byte>, IIncrementOperators<byte>, IMultiplicativeIdentity<byte, byte>, IMultiplyOperators<byte, byte, byte>, ISpanParsable<byte>, IParsable<byte>, ISubtractionOperators<byte, byte, byte>, IUnaryPlusOperators<byte, byte>, IUnaryNegationOperators<byte, byte>, IUtf8SpanFormattable, IUtf8SpanParsable<byte>, IShiftOperators<byte, int, byte>, IMinMaxValue<byte>, IUnsignedNumber<byte>, IUtfChar<byte>, IBinaryIntegerParseAndFormatInfo<byte>
	{
		// Token: 0x06000ACB RID: 2763 RVA: 0x0001FD8C File Offset: 0x0001DF8C
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is byte))
			{
				throw new ArgumentException(SR.Arg_MustBeByte);
			}
			return (int)(this - (byte)value);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0001FDAF File Offset: 0x0001DFAF
		public int CompareTo(byte value)
		{
			return (int)(this - value);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0001FDB5 File Offset: 0x0001DFB5
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is byte && this == (byte)obj;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0001FA8C File Offset: 0x0001DC8C
		[NonVersionable]
		public bool Equals(byte obj)
		{
			return this == obj;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0001FC49 File Offset: 0x0001DE49
		public override int GetHashCode()
		{
			return (int)this;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0001FDCB File Offset: 0x0001DFCB
		[NullableContext(1)]
		public static byte Parse(string s)
		{
			return byte.Parse(s, NumberStyles.Integer, null);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0001FDD5 File Offset: 0x0001DFD5
		[NullableContext(1)]
		public static byte Parse(string s, NumberStyles style)
		{
			return byte.Parse(s, style, null);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0001FDDF File Offset: 0x0001DFDF
		[NullableContext(1)]
		public static byte Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return byte.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0001FDE9 File Offset: 0x0001DFE9
		[NullableContext(1)]
		public static byte Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return byte.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0001FE02 File Offset: 0x0001E002
		public static byte Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<char, byte>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0001FE17 File Offset: 0x0001E017
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out byte result)
		{
			return byte.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0001FE22 File Offset: 0x0001E022
		public static bool TryParse(ReadOnlySpan<char> s, out byte result)
		{
			return byte.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0001FE2D File Offset: 0x0001E02D
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out byte result)
		{
			return byte.TryParse(utf8Text, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0001FE38 File Offset: 0x0001E038
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out byte result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return Number.TryParseBinaryInteger<char, byte>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0001FE5E File Offset: 0x0001E05E
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out byte result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<char, byte>(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0001FE77 File Offset: 0x0001E077
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.UInt32ToDecStr((uint)this);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0001FE80 File Offset: 0x0001E080
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return Number.FormatUInt32((uint)this, format, null);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0001FE77 File Offset: 0x0001E077
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.UInt32ToDecStr((uint)this);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0001FE8B File Offset: 0x0001E08B
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatUInt32((uint)this, format, provider);
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0001FE96 File Offset: 0x0001E096
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatUInt32<char>((uint)this, format, provider, destination, out charsWritten);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0001FEA4 File Offset: 0x0001E0A4
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatUInt32<byte>((uint)this, format, provider, utf8Destination, out bytesWritten);
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0001FEB2 File Offset: 0x0001E0B2
		public TypeCode GetTypeCode()
		{
			return TypeCode.Byte;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0001FEB5 File Offset: 0x0001E0B5
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0001FEBE File Offset: 0x0001E0BE
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0001FEC7 File Offset: 0x0001E0C7
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0001FC49 File Offset: 0x0001DE49
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0001FED0 File Offset: 0x0001E0D0
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0001FED9 File Offset: 0x0001E0D9
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0001FEE2 File Offset: 0x0001E0E2
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0001FEEB File Offset: 0x0001E0EB
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0001FEF4 File Offset: 0x0001E0F4
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0001FEFD File Offset: 0x0001E0FD
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0001FF06 File Offset: 0x0001E106
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0001FF0F File Offset: 0x0001E10F
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0001FF18 File Offset: 0x0001E118
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0001FF21 File Offset: 0x0001E121
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Byte", "DateTime"));
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0001FF3C File Offset: 0x0001E13C
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0001FF4C File Offset: 0x0001E14C
		byte IAdditionOperators<byte, byte, byte>.op_Addition(byte left, byte right)
		{
			return left + right;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0001FF52 File Offset: 0x0001E152
		byte IAdditionOperators<byte, byte, byte>.op_CheckedAddition(byte left, byte right)
		{
			return checked(left + right);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x00007B65 File Offset: 0x00005D65
		byte IAdditiveIdentity<byte, byte>.AdditiveIdentity
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0001FF58 File Offset: 0x0001E158
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<byte, byte> DivRem(byte left, byte right)
		{
			return Math.DivRem(left, right);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0001FF61 File Offset: 0x0001E161
		public static byte LeadingZeroCount(byte value)
		{
			return (byte)(BitOperations.LeadingZeroCount((uint)value) - 24);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0001FF6D File Offset: 0x0001E16D
		public static byte PopCount(byte value)
		{
			return (byte)BitOperations.PopCount((uint)value);
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0001FF76 File Offset: 0x0001E176
		public static byte RotateLeft(byte value, int rotateAmount)
		{
			return (byte)((int)value << (rotateAmount & 7) | value >> (8 - rotateAmount & 7));
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0001FF8C File Offset: 0x0001E18C
		public static byte RotateRight(byte value, int rotateAmount)
		{
			return (byte)(value >> (rotateAmount & 7) | (int)value << (8 - rotateAmount & 7));
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0001FFA2 File Offset: 0x0001E1A2
		public static byte TrailingZeroCount(byte value)
		{
			return (byte)(BitOperations.TrailingZeroCount((int)value << 24) - 24);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
		unsafe bool IBinaryInteger<byte>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out byte value)
		{
			byte b = 0;
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[0])))
				{
					value = b;
					return false;
				}
				if (source.Length > 1)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 1).ContainsAnyExcept(0))
					{
						value = b;
						return false;
					}
				}
				b = *Unsafe.Add<byte>(MemoryMarshal.GetReference<byte>(source), source.Length - 1);
			}
			value = b;
			return true;
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00020028 File Offset: 0x0001E228
		unsafe bool IBinaryInteger<byte>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out byte value)
		{
			byte b = 0;
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[source.Length - 1])))
				{
					value = b;
					return false;
				}
				if (source.Length > 1)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(1, ptr.Length - 1).ContainsAnyExcept(0))
					{
						value = b;
						return false;
					}
				}
				b = *MemoryMarshal.GetReference<byte>(source);
			}
			value = b;
			return true;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00020095 File Offset: 0x0001E295
		int IBinaryInteger<byte>.GetShortestBitLength()
		{
			return (int)(8 - byte.LeadingZeroCount(this));
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000070DD File Offset: 0x000052DD
		int IBinaryInteger<byte>.GetByteCount()
		{
			return 1;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x000200A0 File Offset: 0x0001E2A0
		unsafe bool IBinaryInteger<byte>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 1)
			{
				byte b = this;
				*MemoryMarshal.GetReference<byte>(destination) = b;
				bytesWritten = 1;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x000200CC File Offset: 0x0001E2CC
		unsafe bool IBinaryInteger<byte>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 1)
			{
				byte b = this;
				*MemoryMarshal.GetReference<byte>(destination) = b;
				bytesWritten = 1;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x000200F7 File Offset: 0x0001E2F7
		byte IBinaryNumber<byte>.AllBitsSet
		{
			get
			{
				return 255;
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x000200FE File Offset: 0x0001E2FE
		public static bool IsPow2(byte value)
		{
			return BitOperations.IsPow2((uint)value);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00020106 File Offset: 0x0001E306
		public static byte Log2(byte value)
		{
			return (byte)BitOperations.Log2((uint)value);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0002010F File Offset: 0x0001E30F
		byte IBitwiseOperators<byte, byte, byte>.op_BitwiseAnd(byte left, byte right)
		{
			return left & right;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00020115 File Offset: 0x0001E315
		byte IBitwiseOperators<byte, byte, byte>.op_BitwiseOr(byte left, byte right)
		{
			return left | right;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0002011B File Offset: 0x0001E31B
		byte IBitwiseOperators<byte, byte, byte>.op_ExclusiveOr(byte left, byte right)
		{
			return left ^ right;
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00020121 File Offset: 0x0001E321
		byte IBitwiseOperators<byte, byte, byte>.op_OnesComplement(byte value)
		{
			return ~value;
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00020126 File Offset: 0x0001E326
		bool IComparisonOperators<byte, byte, bool>.op_LessThan(byte left, byte right)
		{
			return left < right;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0002012C File Offset: 0x0001E32C
		bool IComparisonOperators<byte, byte, bool>.op_LessThanOrEqual(byte left, byte right)
		{
			return left <= right;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00020135 File Offset: 0x0001E335
		bool IComparisonOperators<byte, byte, bool>.op_GreaterThan(byte left, byte right)
		{
			return left > right;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0002013B File Offset: 0x0001E33B
		bool IComparisonOperators<byte, byte, bool>.op_GreaterThanOrEqual(byte left, byte right)
		{
			return left >= right;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00020144 File Offset: 0x0001E344
		byte IDecrementOperators<byte>.op_Decrement(byte value)
		{
			return value -= 1;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0002014D File Offset: 0x0001E34D
		byte IDecrementOperators<byte>.op_CheckedDecrement(byte value)
		{
			return checked(value -= 1);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00020156 File Offset: 0x0001E356
		byte IDivisionOperators<byte, byte, byte>.op_Division(byte left, byte right)
		{
			return left / right;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0000FF2A File Offset: 0x0000E12A
		bool IEqualityOperators<byte, byte, bool>.op_Equality(byte left, byte right)
		{
			return left == right;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0001306A File Offset: 0x0001126A
		bool IEqualityOperators<byte, byte, bool>.op_Inequality(byte left, byte right)
		{
			return left != right;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0002015C File Offset: 0x0001E35C
		byte IIncrementOperators<byte>.op_Increment(byte value)
		{
			return value += 1;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00020165 File Offset: 0x0001E365
		byte IIncrementOperators<byte>.op_CheckedIncrement(byte value)
		{
			return checked(value += 1);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00007B65 File Offset: 0x00005D65
		byte IMinMaxValue<byte>.MinValue
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x000200F7 File Offset: 0x0001E2F7
		byte IMinMaxValue<byte>.MaxValue
		{
			get
			{
				return 255;
			}
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0002016E File Offset: 0x0001E36E
		byte IModulusOperators<byte, byte, byte>.op_Modulus(byte left, byte right)
		{
			return left % right;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x000070DD File Offset: 0x000052DD
		byte IMultiplicativeIdentity<byte, byte>.MultiplicativeIdentity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00020174 File Offset: 0x0001E374
		byte IMultiplyOperators<byte, byte, byte>.op_Multiply(byte left, byte right)
		{
			return left * right;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0002017A File Offset: 0x0001E37A
		byte IMultiplyOperators<byte, byte, byte>.op_CheckedMultiply(byte left, byte right)
		{
			return checked(left * right);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00020180 File Offset: 0x0001E380
		public static byte Clamp(byte value, byte min, byte max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00007B62 File Offset: 0x00005D62
		byte INumber<byte>.CopySign(byte value, byte sign)
		{
			return value;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0002018A File Offset: 0x0001E38A
		public static byte Max(byte x, byte y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00020193 File Offset: 0x0001E393
		byte INumber<byte>.MaxNumber(byte x, byte y)
		{
			return byte.Max(x, y);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0002019C File Offset: 0x0001E39C
		public static byte Min(byte x, byte y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x000201A5 File Offset: 0x0001E3A5
		byte INumber<byte>.MinNumber(byte x, byte y)
		{
			return byte.Min(x, y);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x000201AE File Offset: 0x0001E3AE
		public static int Sign(byte value)
		{
			return (value > 0) ? 1 : 0;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x000070DD File Offset: 0x000052DD
		byte INumberBase<byte>.One
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<byte>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00007B65 File Offset: 0x00005D65
		byte INumberBase<byte>.Zero
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00007B62 File Offset: 0x00005D62
		byte INumberBase<byte>.Abs(byte value)
		{
			return value;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x000201B8 File Offset: 0x0001E3B8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			byte result;
			if (typeof(TOther) == typeof(byte))
			{
				result = (byte)((object)value);
			}
			else if (!byte.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<byte>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00020210 File Offset: 0x0001E410
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			byte result;
			if (typeof(TOther) == typeof(byte))
			{
				result = (byte)((object)value);
			}
			else if (!byte.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<byte>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00020268 File Offset: 0x0001E468
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			byte result;
			if (typeof(TOther) == typeof(byte))
			{
				result = (byte)((object)value);
			}
			else if (!byte.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<byte>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<byte>.IsCanonical(byte value)
		{
			return true;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<byte>.IsComplexNumber(byte value)
		{
			return false;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x000202BE File Offset: 0x0001E4BE
		public static bool IsEvenInteger(byte value)
		{
			return (value & 1) == 0;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<byte>.IsFinite(byte value)
		{
			return true;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<byte>.IsImaginaryNumber(byte value)
		{
			return false;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<byte>.IsInfinity(byte value)
		{
			return false;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<byte>.IsInteger(byte value)
		{
			return true;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<byte>.IsNaN(byte value)
		{
			return false;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<byte>.IsNegative(byte value)
		{
			return false;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<byte>.IsNegativeInfinity(byte value)
		{
			return false;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x000201AE File Offset: 0x0001E3AE
		bool INumberBase<byte>.IsNormal(byte value)
		{
			return value > 0;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x000202C6 File Offset: 0x0001E4C6
		public static bool IsOddInteger(byte value)
		{
			return (value & 1) > 0;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<byte>.IsPositive(byte value)
		{
			return true;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<byte>.IsPositiveInfinity(byte value)
		{
			return false;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<byte>.IsRealNumber(byte value)
		{
			return true;
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<byte>.IsSubnormal(byte value)
		{
			return false;
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x000202CE File Offset: 0x0001E4CE
		bool INumberBase<byte>.IsZero(byte value)
		{
			return value == 0;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00020193 File Offset: 0x0001E393
		byte INumberBase<byte>.MaxMagnitude(byte x, byte y)
		{
			return byte.Max(x, y);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00020193 File Offset: 0x0001E393
		byte INumberBase<byte>.MaxMagnitudeNumber(byte x, byte y)
		{
			return byte.Max(x, y);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x000201A5 File Offset: 0x0001E3A5
		byte INumberBase<byte>.MinMagnitude(byte x, byte y)
		{
			return byte.Min(x, y);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x000201A5 File Offset: 0x0001E3A5
		byte INumberBase<byte>.MinMagnitudeNumber(byte x, byte y)
		{
			return byte.Min(x, y);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x000202D4 File Offset: 0x0001E4D4
		byte INumberBase<byte>.MultiplyAddEstimate(byte left, byte right, byte addend)
		{
			return left * right + addend;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000202DC File Offset: 0x0001E4DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<byte>.TryConvertFromChecked<TOther>(TOther value, out byte result) where TOther : INumberBase<TOther>
		{
			return byte.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000202E8 File Offset: 0x0001E4E8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out byte result) where TOther : INumberBase<TOther>
		{
			checked
			{
				if (typeof(TOther) == typeof(char))
				{
					char c = (char)((object)value);
					result = (byte)c;
					return true;
				}
				if (typeof(TOther) == typeof(decimal))
				{
					decimal value2 = (decimal)((object)value);
					result = (byte)value2;
					return true;
				}
				if (typeof(TOther) == typeof(ushort))
				{
					ushort num = (ushort)((object)value);
					result = (byte)num;
					return true;
				}
				if (typeof(TOther) == typeof(uint))
				{
					uint num2 = (uint)((object)value);
					result = (byte)num2;
					return true;
				}
				if (typeof(TOther) == typeof(ulong))
				{
					ulong num3 = (ulong)((object)value);
					result = (byte)num3;
					return true;
				}
				if (typeof(TOther) == typeof(UInt128))
				{
					UInt128 value3 = (UInt128)((object)value);
					result = UInt128.op_CheckedExplicit(value3);
					return true;
				}
				if (typeof(TOther) == typeof(UIntPtr))
				{
					UIntPtr uintPtr = (UIntPtr)((object)value);
					result = (byte)uintPtr;
					return true;
				}
				result = 0;
				return false;
			}
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00020442 File Offset: 0x0001E642
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<byte>.TryConvertFromSaturating<TOther>(TOther value, out byte result) where TOther : INumberBase<TOther>
		{
			return byte.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0002044C File Offset: 0x0001E64C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out byte result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = ((c >= 'ÿ') ? 255 : ((byte)c));
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 255m) ? 255 : ((num <= 0m) ? 0 : ((byte)num)));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)((object)value);
				result = ((num2 >= 255) ? 255 : ((byte)num2));
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)((object)value);
				result = ((num3 >= 255U) ? 255 : ((byte)num3));
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (ulong)((object)value);
				result = ((num4 >= 255UL) ? 255 : ((byte)num4));
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (UInt128)((object)value);
				result = ((@uint >= 255) ? 255 : ((byte)@uint));
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = ((uintPtr >= (UIntPtr)((IntPtr)255)) ? 255 : ((byte)uintPtr));
				return true;
			}
			result = 0;
			return false;
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x00020638 File Offset: 0x0001E838
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<byte>.TryConvertFromTruncating<TOther>(TOther value, out byte result) where TOther : INumberBase<TOther>
		{
			return byte.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00020644 File Offset: 0x0001E844
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out byte result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (byte)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 255m) ? 255 : ((num <= 0m) ? 0 : ((byte)num)));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)((object)value);
				result = (byte)num2;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)((object)value);
				result = (byte)num3;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (ulong)((object)value);
				result = (byte)num4;
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 value2 = (UInt128)((object)value);
				result = (byte)value2;
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = (byte)uintPtr;
				return true;
			}
			result = 0;
			return false;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000207C8 File Offset: 0x0001E9C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<byte>.TryConvertToChecked<TOther>(byte value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = value;
				result = (TOther)((object)half);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				result = (TOther)((object)((short)value));
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				result = (TOther)((object)((int)value));
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num2 = (long)((ulong)value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = value;
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((UIntPtr)value);
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = checked((sbyte)value);
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num3 = (float)value;
				result = (TOther)((object)num3);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x000209A8 File Offset: 0x0001EBA8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<byte>.TryConvertToSaturating<TOther>(byte value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = value;
				result = (TOther)((object)half);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				result = (TOther)((object)((short)value));
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				result = (TOther)((object)((int)value));
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num2 = (long)((ulong)value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = value;
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((UIntPtr)value);
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (value >= 127) ? sbyte.MaxValue : ((sbyte)value);
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num3 = (float)value;
				result = (TOther)((object)num3);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00020B90 File Offset: 0x0001ED90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<byte>.TryConvertToTruncating<TOther>(byte value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = value;
				result = (TOther)((object)half);
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				result = (TOther)((object)((short)value));
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				result = (TOther)((object)((int)value));
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num2 = (long)((ulong)value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = value;
				result = (TOther)((object)@int);
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((UIntPtr)value);
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
				float num3 = (float)value;
				result = (TOther)((object)num3);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00020D6E File Offset: 0x0001EF6E
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out byte result)
		{
			return byte.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00020D79 File Offset: 0x0001EF79
		byte IShiftOperators<byte, int, byte>.op_LeftShift(byte value, int shiftAmount)
		{
			return (byte)(value << shiftAmount);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00020D82 File Offset: 0x0001EF82
		byte IShiftOperators<byte, int, byte>.op_RightShift(byte value, int shiftAmount)
		{
			return (byte)(value >> shiftAmount);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00020D8B File Offset: 0x0001EF8B
		byte IShiftOperators<byte, int, byte>.op_UnsignedRightShift(byte value, int shiftAmount)
		{
			return (byte)((uint)value >> shiftAmount);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00020D94 File Offset: 0x0001EF94
		public static byte Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return byte.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00020D9E File Offset: 0x0001EF9E
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out byte result)
		{
			return byte.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00020DA9 File Offset: 0x0001EFA9
		byte ISubtractionOperators<byte, byte, byte>.op_Subtraction(byte left, byte right)
		{
			return left - right;
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00020DAF File Offset: 0x0001EFAF
		byte ISubtractionOperators<byte, byte, byte>.op_CheckedSubtraction(byte left, byte right)
		{
			return checked(left - right);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00020DB5 File Offset: 0x0001EFB5
		byte IUnaryNegationOperators<byte, byte>.op_UnaryNegation(byte value)
		{
			return -value;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00020DBA File Offset: 0x0001EFBA
		byte IUnaryNegationOperators<byte, byte>.op_CheckedUnaryNegation(byte value)
		{
			return checked(0 - value);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		byte IUnaryPlusOperators<byte, byte>.op_UnaryPlus(byte value)
		{
			return value;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00020DC4 File Offset: 0x0001EFC4
		public static byte Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<byte, byte>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00020DD9 File Offset: 0x0001EFD9
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out byte result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<byte, byte>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00020DF2 File Offset: 0x0001EFF2
		public static byte Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return byte.Parse(utf8Text, NumberStyles.Integer, provider);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00020DFC File Offset: 0x0001EFFC
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out byte result)
		{
			return byte.TryParse(utf8Text, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00007B62 File Offset: 0x00005D62
		byte IUtfChar<byte>.CastFrom(byte value)
		{
			return value;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		byte IUtfChar<byte>.CastFrom(char value)
		{
			return (byte)value;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		byte IUtfChar<byte>.CastFrom(int value)
		{
			return (byte)value;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		byte IUtfChar<byte>.CastFrom(uint value)
		{
			return (byte)value;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		byte IUtfChar<byte>.CastFrom(ulong value)
		{
			return (byte)value;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00007B62 File Offset: 0x00005D62
		uint IUtfChar<byte>.CastToUInt32(byte value)
		{
			return (uint)value;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00007B65 File Offset: 0x00005D65
		bool IBinaryIntegerParseAndFormatInfo<byte>.IsSigned
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0001FC46 File Offset: 0x0001DE46
		int IBinaryIntegerParseAndFormatInfo<byte>.MaxDigitCount
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int IBinaryIntegerParseAndFormatInfo<byte>.MaxHexDigitCount
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00020E07 File Offset: 0x0001F007
		byte IBinaryIntegerParseAndFormatInfo<byte>.MaxValueDiv10
		{
			get
			{
				return 25;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00020E0B File Offset: 0x0001F00B
		[Nullable(1)]
		string IBinaryIntegerParseAndFormatInfo<byte>.OverflowMessage
		{
			get
			{
				return SR.Overflow_Byte;
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00020135 File Offset: 0x0001E335
		bool IBinaryIntegerParseAndFormatInfo<byte>.IsGreaterThanAsUnsigned(byte left, byte right)
		{
			return left > right;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00020E12 File Offset: 0x0001F012
		byte IBinaryIntegerParseAndFormatInfo<byte>.MultiplyBy10(byte value)
		{
			return value * 10;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00020E19 File Offset: 0x0001F019
		byte IBinaryIntegerParseAndFormatInfo<byte>.MultiplyBy16(byte value)
		{
			return value * 16;
		}

		// Token: 0x04000304 RID: 772
		private readonly byte m_value;

		// Token: 0x04000305 RID: 773
		public const byte MaxValue = 255;

		// Token: 0x04000306 RID: 774
		public const byte MinValue = 0;
	}
}
