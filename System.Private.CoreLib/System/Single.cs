using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x020001A3 RID: 419
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct Single : IComparable, IConvertible, ISpanFormattable, IFormattable, IComparable<float>, IEquatable<float>, IBinaryFloatingPointIeee754<float>, IBinaryNumber<float>, IBitwiseOperators<float, float, float>, INumber<float>, IComparisonOperators<float, float, bool>, IEqualityOperators<float, float, bool>, IModulusOperators<float, float, float>, INumberBase<float>, IAdditionOperators<float, float, float>, IAdditiveIdentity<float, float>, IDecrementOperators<float>, IDivisionOperators<float, float, float>, IIncrementOperators<float>, IMultiplicativeIdentity<float, float>, IMultiplyOperators<float, float, float>, ISpanParsable<float>, IParsable<float>, ISubtractionOperators<float, float, float>, IUnaryPlusOperators<float, float>, IUnaryNegationOperators<float, float>, IUtf8SpanFormattable, IUtf8SpanParsable<float>, IFloatingPointIeee754<float>, IExponentialFunctions<float>, IFloatingPointConstants<float>, IFloatingPoint<float>, ISignedNumber<float>, IHyperbolicFunctions<float>, ILogarithmicFunctions<float>, IPowerFunctions<float>, IRootFunctions<float>, ITrigonometricFunctions<float>, IMinMaxValue<float>, IBinaryFloatParseAndFormatInfo<float>
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x0005839B File Offset: 0x0005659B
		internal byte BiasedExponent
		{
			get
			{
				return float.ExtractBiasedExponentFromBits(BitConverter.SingleToUInt32Bits(this));
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x000583A9 File Offset: 0x000565A9
		internal sbyte Exponent
		{
			get
			{
				return (sbyte)(this.BiasedExponent - 127);
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x000583B5 File Offset: 0x000565B5
		internal uint Significand
		{
			get
			{
				return this.TrailingSignificand | ((this.BiasedExponent != 0) ? 8388608U : 0U);
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x000583CE File Offset: 0x000565CE
		internal uint TrailingSignificand
		{
			get
			{
				return float.ExtractTrailingSignificandFromBits(BitConverter.SingleToUInt32Bits(this));
			}
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x000583DC File Offset: 0x000565DC
		internal static byte ExtractBiasedExponentFromBits(uint bits)
		{
			return (byte)(bits >> 23 & 255U);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x000583E9 File Offset: 0x000565E9
		internal static uint ExtractTrailingSignificandFromBits(uint bits)
		{
			return bits & 8388607U;
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x000583F2 File Offset: 0x000565F2
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsFinite(float f)
		{
			return (~BitConverter.SingleToUInt32Bits(f) & 2139095040U) > 0U;
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x00058404 File Offset: 0x00056604
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInfinity(float f)
		{
			return (BitConverter.SingleToUInt32Bits(f) & 2147483647U) == 2139095040U;
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0002E6BF File Offset: 0x0002C8BF
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNaN(float f)
		{
			return f != f;
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x00058419 File Offset: 0x00056619
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool IsNaNOrZero(float f)
		{
			return (BitConverter.SingleToUInt32Bits(f) - 1U & 2147483647U) >= 2139095040U;
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00058433 File Offset: 0x00056633
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegative(float f)
		{
			return BitConverter.SingleToInt32Bits(f) < 0;
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0005843E File Offset: 0x0005663E
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegativeInfinity(float f)
		{
			return f == float.NegativeInfinity;
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00058448 File Offset: 0x00056648
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNormal(float f)
		{
			return (BitConverter.SingleToUInt32Bits(f) & 2147483647U) - 8388608U < 2130706432U;
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00058463 File Offset: 0x00056663
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPositiveInfinity(float f)
		{
			return f == float.PositiveInfinity;
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0005846D File Offset: 0x0005666D
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsSubnormal(float f)
		{
			return (BitConverter.SingleToUInt32Bits(f) & 2147483647U) - 1U < 8388607U;
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00058484 File Offset: 0x00056684
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool IsZero(float f)
		{
			return f == 0f;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00058490 File Offset: 0x00056690
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value is float)
			{
				float value2 = (float)value;
				return this.CompareTo(value2);
			}
			if (value != null)
			{
				throw new ArgumentException(SR.Arg_MustBeSingle);
			}
			return 1;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x000584C5 File Offset: 0x000566C5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(float value)
		{
			if (this < value)
			{
				return -1;
			}
			if (this > value)
			{
				return 1;
			}
			if (this == value)
			{
				return 0;
			}
			if (!float.IsNaN(this))
			{
				return 1;
			}
			if (!float.IsNaN(value))
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0000FF2A File Offset: 0x0000E12A
		[NonVersionable]
		public static bool operator ==(float left, float right)
		{
			return left == right;
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0001306A File Offset: 0x0001126A
		[NonVersionable]
		public static bool operator !=(float left, float right)
		{
			return left != right;
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x00020126 File Offset: 0x0001E326
		[NonVersionable]
		public static bool operator <(float left, float right)
		{
			return left < right;
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00020135 File Offset: 0x0001E335
		[NonVersionable]
		public static bool operator >(float left, float right)
		{
			return left > right;
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0002E7F1 File Offset: 0x0002C9F1
		[NonVersionable]
		public static bool operator <=(float left, float right)
		{
			return left <= right;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0002E7FA File Offset: 0x0002C9FA
		[NonVersionable]
		public static bool operator >=(float left, float right)
		{
			return left >= right;
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x000584F4 File Offset: 0x000566F4
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is float)
			{
				float obj2 = (float)obj;
				return this.Equals(obj2);
			}
			return false;
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00058519 File Offset: 0x00056719
		public bool Equals(float obj)
		{
			return obj == this || (float.IsNaN(obj) && float.IsNaN(this));
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00058534 File Offset: 0x00056734
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			uint num = BitConverter.SingleToUInt32Bits(this);
			if (float.IsNaNOrZero(this))
			{
				num &= 2139095040U;
			}
			return (int)num;
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0005855B File Offset: 0x0005675B
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.FormatFloat<float>(this, null, NumberFormatInfo.CurrentInfo);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0005856A File Offset: 0x0005676A
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.FormatFloat<float>(this, null, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0005857A File Offset: 0x0005677A
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return Number.FormatFloat<float>(this, format, NumberFormatInfo.CurrentInfo);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00058589 File Offset: 0x00056789
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatFloat<float>(this, format, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00058599 File Offset: 0x00056799
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatFloat<float, char>(this, format, NumberFormatInfo.GetInstance(provider), destination, out charsWritten);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x000585AC File Offset: 0x000567AC
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatFloat<float, byte>(this, format, NumberFormatInfo.GetInstance(provider), utf8Destination, out bytesWritten);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x000585BF File Offset: 0x000567BF
		[NullableContext(1)]
		public static float Parse(string s)
		{
			return float.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x000585CD File Offset: 0x000567CD
		[NullableContext(1)]
		public static float Parse(string s, NumberStyles style)
		{
			return float.Parse(s, style, null);
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x000585D7 File Offset: 0x000567D7
		[NullableContext(1)]
		public static float Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return float.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x000585E5 File Offset: 0x000567E5
		[NullableContext(1)]
		public static float Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return float.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x000585FE File Offset: 0x000567FE
		public static float Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return Number.ParseFloat<char, float>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00058613 File Offset: 0x00056813
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out float result)
		{
			return float.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null, out result);
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x00058622 File Offset: 0x00056822
		public static bool TryParse(ReadOnlySpan<char> s, out float result)
		{
			return float.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null, out result);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x00058631 File Offset: 0x00056831
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out float result)
		{
			return float.TryParse(utf8Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null, out result);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00058640 File Offset: 0x00056840
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out float result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				result = 0f;
				return false;
			}
			return Number.TryParseFloat<char, float>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00058667 File Offset: 0x00056867
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out float result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return Number.TryParseFloat<char, float>(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0005867D File Offset: 0x0005687D
		public TypeCode GetTypeCode()
		{
			return TypeCode.Single;
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00058681 File Offset: 0x00056881
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0005868A File Offset: 0x0005688A
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Single", "Char"));
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x000586A5 File Offset: 0x000568A5
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000586AE File Offset: 0x000568AE
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x000586B7 File Offset: 0x000568B7
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x000586C0 File Offset: 0x000568C0
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x000586C9 File Offset: 0x000568C9
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x000586D2 File Offset: 0x000568D2
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x000586DB File Offset: 0x000568DB
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000586E4 File Offset: 0x000568E4
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000586ED File Offset: 0x000568ED
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000586F1 File Offset: 0x000568F1
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x000586FA File Offset: 0x000568FA
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00058703 File Offset: 0x00056903
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Single", "DateTime"));
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0005871E File Offset: 0x0005691E
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0002EA29 File Offset: 0x0002CC29
		float IAdditionOperators<float, float, float>.op_Addition(float left, float right)
		{
			return left + right;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x0005872E File Offset: 0x0005692E
		float IAdditiveIdentity<float, float>.AdditiveIdentity
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x00058735 File Offset: 0x00056935
		float IBinaryNumber<float>.AllBitsSet
		{
			get
			{
				return BitConverter.UInt32BitsToSingle(uint.MaxValue);
			}
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00058740 File Offset: 0x00056940
		public static bool IsPow2(float value)
		{
			uint num = BitConverter.SingleToUInt32Bits(value);
			if (num <= 0U)
			{
				return false;
			}
			byte b = float.ExtractBiasedExponentFromBits(num);
			uint num2 = float.ExtractTrailingSignificandFromBits(num);
			if (b == 0)
			{
				return uint.PopCount(num2) == 1U;
			}
			return b != byte.MaxValue && num2 == 0U;
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00058783 File Offset: 0x00056983
		[Intrinsic]
		public static float Log2(float value)
		{
			return MathF.Log2(value);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0005878B File Offset: 0x0005698B
		float IBitwiseOperators<float, float, float>.op_BitwiseAnd(float left, float right)
		{
			return BitConverter.UInt32BitsToSingle(BitConverter.SingleToUInt32Bits(left) & BitConverter.SingleToUInt32Bits(right));
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0005879F File Offset: 0x0005699F
		float IBitwiseOperators<float, float, float>.op_BitwiseOr(float left, float right)
		{
			return BitConverter.UInt32BitsToSingle(BitConverter.SingleToUInt32Bits(left) | BitConverter.SingleToUInt32Bits(right));
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x000587B3 File Offset: 0x000569B3
		float IBitwiseOperators<float, float, float>.op_ExclusiveOr(float left, float right)
		{
			return BitConverter.UInt32BitsToSingle(BitConverter.SingleToUInt32Bits(left) ^ BitConverter.SingleToUInt32Bits(right));
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x000587C7 File Offset: 0x000569C7
		float IBitwiseOperators<float, float, float>.op_OnesComplement(float value)
		{
			return BitConverter.UInt32BitsToSingle(~BitConverter.SingleToUInt32Bits(value));
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x000587D5 File Offset: 0x000569D5
		float IDecrementOperators<float>.op_Decrement(float value)
		{
			return value -= 1f;
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0002EAEC File Offset: 0x0002CCEC
		float IDivisionOperators<float, float, float>.op_Division(float left, float right)
		{
			return left / right;
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x000587E1 File Offset: 0x000569E1
		[Intrinsic]
		public static float Exp(float x)
		{
			return MathF.Exp(x);
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x000587E9 File Offset: 0x000569E9
		public static float ExpM1(float x)
		{
			return MathF.Exp(x) - 1f;
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000587F7 File Offset: 0x000569F7
		public static float Exp2(float x)
		{
			return MathF.Pow(2f, x);
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00058804 File Offset: 0x00056A04
		public static float Exp2M1(float x)
		{
			return MathF.Pow(2f, x) - 1f;
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00058817 File Offset: 0x00056A17
		public static float Exp10(float x)
		{
			return MathF.Pow(10f, x);
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00058824 File Offset: 0x00056A24
		public static float Exp10M1(float x)
		{
			return MathF.Pow(10f, x) - 1f;
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00058837 File Offset: 0x00056A37
		[Intrinsic]
		public static float Ceiling(float x)
		{
			return MathF.Ceiling(x);
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0005883F File Offset: 0x00056A3F
		[NullableContext(1)]
		[Intrinsic]
		public static TInteger ConvertToInteger<[Nullable(0)] TInteger>(float value) where TInteger : IBinaryInteger<TInteger>
		{
			return INumberBase<TInteger>.CreateSaturating<float>(value);
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0005883F File Offset: 0x00056A3F
		[NullableContext(1)]
		[Intrinsic]
		public static TInteger ConvertToIntegerNative<[Nullable(0)] TInteger>(float value) where TInteger : IBinaryInteger<TInteger>
		{
			return INumberBase<TInteger>.CreateSaturating<float>(value);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0005884D File Offset: 0x00056A4D
		[Intrinsic]
		public static float Floor(float x)
		{
			return MathF.Floor(x);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00058855 File Offset: 0x00056A55
		[Intrinsic]
		public static float Round(float x)
		{
			return MathF.Round(x);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0005885D File Offset: 0x00056A5D
		public static float Round(float x, int digits)
		{
			return MathF.Round(x, digits);
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00058866 File Offset: 0x00056A66
		public static float Round(float x, MidpointRounding mode)
		{
			return MathF.Round(x, mode);
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0005886F File Offset: 0x00056A6F
		public static float Round(float x, int digits, MidpointRounding mode)
		{
			return MathF.Round(x, digits, mode);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00058879 File Offset: 0x00056A79
		[Intrinsic]
		public static float Truncate(float x)
		{
			return MathF.Truncate(x);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x000070DD File Offset: 0x000052DD
		int IFloatingPoint<float>.GetExponentByteCount()
		{
			return 1;
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00058884 File Offset: 0x00056A84
		int IFloatingPoint<float>.GetExponentShortestBitLength()
		{
			sbyte exponent = this.Exponent;
			if (exponent >= 0)
			{
				return (int)(8 - sbyte.LeadingZeroCount(exponent));
			}
			return (int)(9 - sbyte.LeadingZeroCount(~exponent));
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x000211FB File Offset: 0x0001F3FB
		int IFloatingPoint<float>.GetSignificandByteCount()
		{
			return 4;
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x000588B0 File Offset: 0x00056AB0
		int IFloatingPoint<float>.GetSignificandBitLength()
		{
			return 24;
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x000588B4 File Offset: 0x00056AB4
		bool IFloatingPoint<float>.TryWriteExponentBigEndian(Span<byte> destination, out int bytesWritten)
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

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000588E8 File Offset: 0x00056AE8
		bool IFloatingPoint<float>.TryWriteExponentLittleEndian(Span<byte> destination, out int bytesWritten)
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

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0005891C File Offset: 0x00056B1C
		bool IFloatingPoint<float>.TryWriteSignificandBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 4)
			{
				uint value = this.Significand;
				bool isLittleEndian = BitConverter.IsLittleEndian;
				value = BinaryPrimitives.ReverseEndianness(value);
				Unsafe.WriteUnaligned<uint>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 4;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0005895C File Offset: 0x00056B5C
		bool IFloatingPoint<float>.TryWriteSignificandLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 4)
			{
				uint significand = this.Significand;
				if (!BitConverter.IsLittleEndian)
				{
				}
				Unsafe.WriteUnaligned<uint>(MemoryMarshal.GetReference<byte>(destination), significand);
				bytesWritten = 4;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x00058996 File Offset: 0x00056B96
		float IFloatingPointConstants<float>.E
		{
			get
			{
				return 2.7182817f;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0005899D File Offset: 0x00056B9D
		float IFloatingPointConstants<float>.Pi
		{
			get
			{
				return 3.1415927f;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x000589A4 File Offset: 0x00056BA4
		float IFloatingPointConstants<float>.Tau
		{
			get
			{
				return 6.2831855f;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x000589AB File Offset: 0x00056BAB
		float IFloatingPointIeee754<float>.Epsilon
		{
			get
			{
				return 1E-45f;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x000589B2 File Offset: 0x00056BB2
		float IFloatingPointIeee754<float>.NaN
		{
			get
			{
				return float.NaN;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x000589B9 File Offset: 0x00056BB9
		float IFloatingPointIeee754<float>.NegativeInfinity
		{
			get
			{
				return float.NegativeInfinity;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x000589C0 File Offset: 0x00056BC0
		float IFloatingPointIeee754<float>.NegativeZero
		{
			get
			{
				return --0f;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x000589C7 File Offset: 0x00056BC7
		float IFloatingPointIeee754<float>.PositiveInfinity
		{
			get
			{
				return float.PositiveInfinity;
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x000589CE File Offset: 0x00056BCE
		[Intrinsic]
		public static float Atan2(float y, float x)
		{
			return MathF.Atan2(y, x);
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x000589D7 File Offset: 0x00056BD7
		public static float Atan2Pi(float y, float x)
		{
			return float.Atan2(y, x) / 3.1415927f;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x000589E6 File Offset: 0x00056BE6
		public static float BitDecrement(float x)
		{
			return MathF.BitDecrement(x);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x000589EE File Offset: 0x00056BEE
		public static float BitIncrement(float x)
		{
			return MathF.BitIncrement(x);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000589F6 File Offset: 0x00056BF6
		[Intrinsic]
		public static float FusedMultiplyAdd(float left, float right, float addend)
		{
			return MathF.FusedMultiplyAdd(left, right, addend);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00058A00 File Offset: 0x00056C00
		public static float Ieee754Remainder(float left, float right)
		{
			return MathF.IEEERemainder(left, right);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x00058A09 File Offset: 0x00056C09
		public static int ILogB(float x)
		{
			return MathF.ILogB(x);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00058A11 File Offset: 0x00056C11
		public static float Lerp(float value1, float value2, float amount)
		{
			return float.MultiplyAddEstimate(value1, 1f - amount, value2 * amount);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00058A23 File Offset: 0x00056C23
		[Intrinsic]
		public static float ReciprocalEstimate(float x)
		{
			return MathF.ReciprocalEstimate(x);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00058A2B File Offset: 0x00056C2B
		[Intrinsic]
		public static float ReciprocalSqrtEstimate(float x)
		{
			return MathF.ReciprocalSqrtEstimate(x);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00058A33 File Offset: 0x00056C33
		public static float ScaleB(float x, int n)
		{
			return MathF.ScaleB(x, n);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00058A3C File Offset: 0x00056C3C
		[Intrinsic]
		public static float Acosh(float x)
		{
			return MathF.Acosh(x);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00058A44 File Offset: 0x00056C44
		[Intrinsic]
		public static float Asinh(float x)
		{
			return MathF.Asinh(x);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00058A4C File Offset: 0x00056C4C
		[Intrinsic]
		public static float Atanh(float x)
		{
			return MathF.Atanh(x);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x00058A54 File Offset: 0x00056C54
		[Intrinsic]
		public static float Cosh(float x)
		{
			return MathF.Cosh(x);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00058A5C File Offset: 0x00056C5C
		[Intrinsic]
		public static float Sinh(float x)
		{
			return MathF.Sinh(x);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00058A64 File Offset: 0x00056C64
		[Intrinsic]
		public static float Tanh(float x)
		{
			return MathF.Tanh(x);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00058A6C File Offset: 0x00056C6C
		float IIncrementOperators<float>.op_Increment(float value)
		{
			return value += 1f;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00058A78 File Offset: 0x00056C78
		[Intrinsic]
		public static float Log(float x)
		{
			return MathF.Log(x);
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00058A80 File Offset: 0x00056C80
		public static float Log(float x, float newBase)
		{
			return MathF.Log(x, newBase);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00058A89 File Offset: 0x00056C89
		public static float LogP1(float x)
		{
			return MathF.Log(x + 1f);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00058A97 File Offset: 0x00056C97
		[Intrinsic]
		public static float Log10(float x)
		{
			return MathF.Log10(x);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00058A9F File Offset: 0x00056C9F
		public static float Log2P1(float x)
		{
			return MathF.Log2(x + 1f);
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00058AAD File Offset: 0x00056CAD
		public static float Log10P1(float x)
		{
			return MathF.Log10(x + 1f);
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x00058ABB File Offset: 0x00056CBB
		float IMinMaxValue<float>.MinValue
		{
			get
			{
				return -3.4028235E+38f;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x00058AC2 File Offset: 0x00056CC2
		float IMinMaxValue<float>.MaxValue
		{
			get
			{
				return 3.4028235E+38f;
			}
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0002EE4D File Offset: 0x0002D04D
		float IModulusOperators<float, float, float>.op_Modulus(float left, float right)
		{
			return left % right;
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00058AC9 File Offset: 0x00056CC9
		float IMultiplicativeIdentity<float, float>.MultiplicativeIdentity
		{
			get
			{
				return 1f;
			}
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0002EE5D File Offset: 0x0002D05D
		float IMultiplyOperators<float, float, float>.op_Multiply(float left, float right)
		{
			return left * right;
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00058AD0 File Offset: 0x00056CD0
		public static float Clamp(float value, float min, float max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00058ADA File Offset: 0x00056CDA
		public static float CopySign(float value, float sign)
		{
			return MathF.CopySign(value, sign);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00058AE3 File Offset: 0x00056CE3
		[Intrinsic]
		public static float Max(float x, float y)
		{
			return MathF.Max(x, y);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00058AEC File Offset: 0x00056CEC
		[Intrinsic]
		public static float MaxNumber(float x, float y)
		{
			if (x != y)
			{
				if (float.IsNaN(y))
				{
					return x;
				}
				if (y >= x)
				{
					return y;
				}
				return x;
			}
			else
			{
				if (!float.IsNegative(y))
				{
					return y;
				}
				return x;
			}
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00058B0F File Offset: 0x00056D0F
		[Intrinsic]
		public static float Min(float x, float y)
		{
			return MathF.Min(x, y);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00058B18 File Offset: 0x00056D18
		[Intrinsic]
		public static float MinNumber(float x, float y)
		{
			if (x != y)
			{
				if (float.IsNaN(y))
				{
					return x;
				}
				if (x >= y)
				{
					return y;
				}
				return x;
			}
			else
			{
				if (!float.IsNegative(x))
				{
					return y;
				}
				return x;
			}
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00058B3B File Offset: 0x00056D3B
		public static int Sign(float value)
		{
			return MathF.Sign(value);
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x00058AC9 File Offset: 0x00056CC9
		float INumberBase<float>.One
		{
			get
			{
				return 1f;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<float>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x0005872E File Offset: 0x0005692E
		float INumberBase<float>.Zero
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00058B43 File Offset: 0x00056D43
		[Intrinsic]
		public static float Abs(float value)
		{
			return MathF.Abs(value);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00058B4C File Offset: 0x00056D4C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			float result;
			if (typeof(TOther) == typeof(float))
			{
				result = (float)((object)value);
			}
			else if (!float.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<float>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00058BA4 File Offset: 0x00056DA4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			float result;
			if (typeof(TOther) == typeof(float))
			{
				result = (float)((object)value);
			}
			else if (!float.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<float>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x00058BFC File Offset: 0x00056DFC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			float result;
			if (typeof(TOther) == typeof(float))
			{
				result = (float)((object)value);
			}
			else if (!float.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<float>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<float>.IsCanonical(float value)
		{
			return true;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<float>.IsComplexNumber(float value)
		{
			return false;
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00058C52 File Offset: 0x00056E52
		public static bool IsEvenInteger(float value)
		{
			return float.IsInteger(value) && float.Abs(value % 2f) == 0f;
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<float>.IsImaginaryNumber(float value)
		{
			return false;
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00058C71 File Offset: 0x00056E71
		public static bool IsInteger(float value)
		{
			return float.IsFinite(value) && value == float.Truncate(value);
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00058C86 File Offset: 0x00056E86
		public static bool IsOddInteger(float value)
		{
			return float.IsInteger(value) && float.Abs(value % 2f) == 1f;
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00058CA5 File Offset: 0x00056EA5
		public static bool IsPositive(float value)
		{
			return BitConverter.SingleToInt32Bits(value) >= 0;
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0002F058 File Offset: 0x0002D258
		public static bool IsRealNumber(float value)
		{
			return value == value;
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00058CB3 File Offset: 0x00056EB3
		bool INumberBase<float>.IsZero(float value)
		{
			return float.IsZero(value);
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00058CBB File Offset: 0x00056EBB
		[Intrinsic]
		public static float MaxMagnitude(float x, float y)
		{
			return MathF.MaxMagnitude(x, y);
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00058CC4 File Offset: 0x00056EC4
		[Intrinsic]
		public static float MaxMagnitudeNumber(float x, float y)
		{
			float num = float.Abs(x);
			float num2 = float.Abs(y);
			if (num > num2 || float.IsNaN(num2))
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!float.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00058CFE File Offset: 0x00056EFE
		[Intrinsic]
		public static float MinMagnitude(float x, float y)
		{
			return MathF.MinMagnitude(x, y);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00058D08 File Offset: 0x00056F08
		[Intrinsic]
		public static float MinMagnitudeNumber(float x, float y)
		{
			float num = float.Abs(x);
			float num2 = float.Abs(y);
			if (num < num2 || float.IsNaN(num2))
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!float.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0002F0EE File Offset: 0x0002D2EE
		[Intrinsic]
		public static float MultiplyAddEstimate(float left, float right, float addend)
		{
			return left * right + addend;
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00058D42 File Offset: 0x00056F42
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<float>.TryConvertFromChecked<TOther>(TOther value, out float result) where TOther : INumberBase<TOther>
		{
			return float.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00058D42 File Offset: 0x00056F42
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<float>.TryConvertFromSaturating<TOther>(TOther value, out float result) where TOther : INumberBase<TOther>
		{
			return float.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00058D42 File Offset: 0x00056F42
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<float>.TryConvertFromTruncating<TOther>(TOther value, out float result) where TOther : INumberBase<TOther>
		{
			return float.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00058D4C File Offset: 0x00056F4C
		private static bool TryConvertFrom<TOther>(TOther value, out float result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = (float)num;
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half value2 = (Half)((object)value);
				result = (float)value2;
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)((object)value);
				result = (float)num2;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (int)((object)value);
				result = (float)num3;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (long)((object)value);
				result = (float)num4;
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 value3 = (Int128)((object)value);
				result = (float)value3;
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				result = (float)intPtr;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (float)b;
				return true;
			}
			result = 0f;
			return false;
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00058EDC File Offset: 0x000570DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<float>.TryConvertToChecked<TOther>(float value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			checked
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
					decimal num = (decimal)value;
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
					UInt128 @uint = UInt128.op_CheckedExplicit(value);
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
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00059089 File Offset: 0x00057289
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<float>.TryConvertToSaturating<TOther>(float value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			return float.TryConvertTo<TOther>(value, out result);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00059089 File Offset: 0x00057289
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<float>.TryConvertToTruncating<TOther>(float value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			return float.TryConvertTo<TOther>(value, out result);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00059094 File Offset: 0x00057294
		private static bool TryConvertTo<TOther>(float value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (value >= 255f) ? byte.MaxValue : ((value <= 0f) ? 0 : ((byte)value));
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (value >= 65535f) ? char.MaxValue : ((value <= 0f) ? '\0' : ((char)value));
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (value >= 7.9228163E+28f) ? decimal.MaxValue : ((value <= -7.9228163E+28f) ? decimal.MinValue : (float.IsNaN(value) ? 0.0m : ((decimal)value)));
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (value >= 65535f) ? ushort.MaxValue : ((value <= 0f) ? 0 : ((ushort)value));
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (value >= 4.2949673E+09f) ? uint.MaxValue : ((value <= 0f) ? 0U : ((uint)value));
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (value >= 1.8446744E+19f) ? ulong.MaxValue : ((value <= 0f) ? 0UL : (float.IsNaN(value) ? 0UL : ((ulong)value)));
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (value == float.PositiveInfinity) ? UInt128.MaxValue : ((value <= 0f) ? UInt128.MinValue : ((UInt128)value));
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (value >= 1.8446744E+19f) ? ((UIntPtr)(-1L)) : ((UIntPtr)((value <= 0f) ? ((IntPtr)0) : ((IntPtr)((UIntPtr)value))));
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0005933C File Offset: 0x0005753C
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out float result)
		{
			return float.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0005934B File Offset: 0x0005754B
		[Intrinsic]
		public static float Pow(float x, float y)
		{
			return MathF.Pow(x, y);
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00059354 File Offset: 0x00057554
		[Intrinsic]
		public static float Cbrt(float x)
		{
			return MathF.Cbrt(x);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0005935C File Offset: 0x0005755C
		public static float Hypot(float x, float y)
		{
			float result;
			if (float.IsFinite(x) && float.IsFinite(y))
			{
				float num = float.Abs(x);
				float num2 = float.Abs(y);
				if (num == 0f)
				{
					result = num2;
				}
				else if (num2 == 0f)
				{
					result = num;
				}
				else
				{
					double num3 = (double)num;
					double num4 = num3 * num3;
					double num5 = (double)num2;
					num5 *= num5;
					result = (float)double.Sqrt(num4 + num5);
				}
			}
			else if (float.IsInfinity(x) || float.IsInfinity(y))
			{
				result = float.PositiveInfinity;
			}
			else
			{
				result = float.NaN;
			}
			return result;
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x000593D4 File Offset: 0x000575D4
		public static float RootN(float x, int n)
		{
			float result;
			if (n > 0)
			{
				if (n == 2)
				{
					result = ((x != 0f) ? float.Sqrt(x) : 0f);
				}
				else if (n == 3)
				{
					result = float.Cbrt(x);
				}
				else
				{
					result = float.<RootN>g__PositiveN|231_0(x, n);
				}
			}
			else if (n < 0)
			{
				result = float.<RootN>g__NegativeN|231_1(x, n);
			}
			else
			{
				result = float.NaN;
			}
			return result;
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0005942D File Offset: 0x0005762D
		[Intrinsic]
		public static float Sqrt(float x)
		{
			return MathF.Sqrt(x);
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x00059435 File Offset: 0x00057635
		float ISignedNumber<float>.NegativeOne
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0005943C File Offset: 0x0005763C
		public static float Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return float.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0005944A File Offset: 0x0005764A
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out float result)
		{
			return float.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0002FA55 File Offset: 0x0002DC55
		float ISubtractionOperators<float, float, float>.op_Subtraction(float left, float right)
		{
			return left - right;
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00059459 File Offset: 0x00057659
		[Intrinsic]
		public static float Acos(float x)
		{
			return MathF.Acos(x);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00059461 File Offset: 0x00057661
		public static float AcosPi(float x)
		{
			return float.Acos(x) / 3.1415927f;
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0005946F File Offset: 0x0005766F
		[Intrinsic]
		public static float Asin(float x)
		{
			return MathF.Asin(x);
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00059477 File Offset: 0x00057677
		public static float AsinPi(float x)
		{
			return float.Asin(x) / 3.1415927f;
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00059485 File Offset: 0x00057685
		[Intrinsic]
		public static float Atan(float x)
		{
			return MathF.Atan(x);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0005948D File Offset: 0x0005768D
		public static float AtanPi(float x)
		{
			return float.Atan(x) / 3.1415927f;
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0005949B File Offset: 0x0005769B
		[Intrinsic]
		public static float Cos(float x)
		{
			return MathF.Cos(x);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x000594A4 File Offset: 0x000576A4
		public static float CosPi(float x)
		{
			float result;
			if (float.IsFinite(x))
			{
				float num = float.Abs(x);
				if (num < 8388608f)
				{
					if (num > 0.25f)
					{
						int num2 = (int)num;
						float num3 = num - (float)num2;
						float num4 = int.IsOddInteger(num2) ? -1f : 1f;
						if (num3 <= 0.25f)
						{
							if (num3 != 0f)
							{
								result = num4 * float.CosForIntervalPiBy4(num3 * 3.1415927f);
							}
							else
							{
								result = num4;
							}
						}
						else if (num3 <= 0.5f)
						{
							if (num3 != 0.5f)
							{
								result = num4 * float.SinForIntervalPiBy4((0.5f - num3) * 3.1415927f);
							}
							else
							{
								result = 0f;
							}
						}
						else if ((double)num3 <= 0.75)
						{
							result = -num4 * float.SinForIntervalPiBy4((num3 - 0.5f) * 3.1415927f);
						}
						else
						{
							result = -num4 * float.CosForIntervalPiBy4((1f - num3) * 3.1415927f);
						}
					}
					else if (num >= 0.0078125f)
					{
						result = float.CosForIntervalPiBy4(x * 3.1415927f);
					}
					else if (num >= 0.00012207031f)
					{
						float num5 = x * 3.1415927f;
						result = 1f - num5 * num5 * 0.5f;
					}
					else
					{
						result = 1f;
					}
				}
				else if (num < 16777216f)
				{
					result = (int.IsOddInteger(BitConverter.SingleToInt32Bits(num)) ? -1f : 1f);
				}
				else
				{
					result = 1f;
				}
			}
			else
			{
				result = float.NaN;
			}
			return result;
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00059613 File Offset: 0x00057813
		public static float DegreesToRadians(float degrees)
		{
			return degrees * 3.1415927f / 180f;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00059622 File Offset: 0x00057822
		public static float RadiansToDegrees(float radians)
		{
			return radians * 180f / 3.1415927f;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00059631 File Offset: 0x00057831
		[Intrinsic]
		public static float Sin(float x)
		{
			return MathF.Sin(x);
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00059639 File Offset: 0x00057839
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<float, float> SinCos(float x)
		{
			return MathF.SinCos(x);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00059644 File Offset: 0x00057844
		[return: TupleElementNames(new string[]
		{
			"SinPi",
			"CosPi"
		})]
		public static ValueTuple<float, float> SinCosPi(float x)
		{
			float item;
			float item2;
			if (float.IsFinite(x))
			{
				float num = float.Abs(x);
				if (num < 8388608f)
				{
					if (num > 0.25f)
					{
						int num2 = (int)num;
						float num3 = num - (float)num2;
						float num4 = int.IsOddInteger(num2) ? -1f : 1f;
						float num5 = ((x > 0f) ? 1f : -1f) * num4;
						float num6 = num4;
						if (num3 <= 0.25f)
						{
							if (num3 != 0f)
							{
								float x2 = num3 * 3.1415927f;
								item = num5 * float.SinForIntervalPiBy4(x2);
								item2 = num6 * float.CosForIntervalPiBy4(x2);
							}
							else
							{
								item = x * 0f;
								item2 = num6;
							}
						}
						else if (num3 <= 0.5f)
						{
							if (num3 != 0.5f)
							{
								float x3 = (0.5f - num3) * 3.1415927f;
								item = num5 * float.CosForIntervalPiBy4(x3);
								item2 = num6 * float.SinForIntervalPiBy4(x3);
							}
							else
							{
								item = num5;
								item2 = 0f;
							}
						}
						else if (num3 <= 0.75f)
						{
							float x4 = (num3 - 0.5f) * 3.1415927f;
							item = num5 * float.CosForIntervalPiBy4(x4);
							item2 = -num6 * float.SinForIntervalPiBy4(x4);
						}
						else
						{
							float x5 = (1f - num3) * 3.1415927f;
							item = num5 * float.SinForIntervalPiBy4(x5);
							item2 = -num6 * float.CosForIntervalPiBy4(x5);
						}
					}
					else if (num >= 0.0078125f)
					{
						float x6 = x * 3.1415927f;
						item = float.SinForIntervalPiBy4(x6);
						item2 = float.CosForIntervalPiBy4(x6);
					}
					else if (num >= 0.00012207031f)
					{
						float num7 = x * 3.1415927f;
						float num8 = num7 * num7;
						item = num7 - num8 * num7 * 0.16666667f;
						item2 = 1f - num8 * 0.5f;
					}
					else
					{
						item = x * 3.1415927f;
						item2 = 1f;
					}
				}
				else if (num < 16777216f)
				{
					item = x * 0f;
					item2 = (int.IsOddInteger(BitConverter.SingleToInt32Bits(num)) ? -1f : 1f);
				}
				else
				{
					item = x * 0f;
					item2 = 1f;
				}
			}
			else
			{
				item = float.NaN;
				item2 = float.NaN;
			}
			return new ValueTuple<float, float>(item, item2);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00059860 File Offset: 0x00057A60
		public static float SinPi(float x)
		{
			float result;
			if (float.IsFinite(x))
			{
				float num = float.Abs(x);
				if (num < 8388608f)
				{
					if (num > 0.25f)
					{
						int num2 = (int)num;
						float num3 = num - (float)num2;
						float num4 = ((x > 0f) ? 1f : -1f) * (int.IsOddInteger(num2) ? -1f : 1f);
						if (num3 <= 0.25f)
						{
							if (num3 != 0f)
							{
								result = num4 * float.SinForIntervalPiBy4(num3 * 3.1415927f);
							}
							else
							{
								result = x * 0f;
							}
						}
						else if (num3 <= 0.5f)
						{
							if (num3 != 0.5f)
							{
								result = num4 * float.CosForIntervalPiBy4((0.5f - num3) * 3.1415927f);
							}
							else
							{
								result = num4;
							}
						}
						else if (num3 <= 0.75f)
						{
							result = num4 * float.CosForIntervalPiBy4((num3 - 0.5f) * 3.1415927f);
						}
						else
						{
							result = num4 * float.SinForIntervalPiBy4((1f - num3) * 3.1415927f);
						}
					}
					else if (num >= 0.0078125f)
					{
						result = float.SinForIntervalPiBy4(x * 3.1415927f);
					}
					else if (num >= 0.00012207031f)
					{
						float num5 = x * 3.1415927f;
						result = num5 - num5 * num5 * num5 * 0.16666667f;
					}
					else
					{
						result = x * 3.1415927f;
					}
				}
				else
				{
					result = x * 0f;
				}
			}
			else
			{
				result = float.NaN;
			}
			return result;
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000599BC File Offset: 0x00057BBC
		[Intrinsic]
		public static float Tan(float x)
		{
			return MathF.Tan(x);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000599C4 File Offset: 0x00057BC4
		public static float TanPi(float x)
		{
			float result;
			if (float.IsFinite(x))
			{
				float num = float.Abs(x);
				float num2 = (x > 0f) ? 1f : -1f;
				if (num < 8388608f)
				{
					if (num > 0.25f)
					{
						int num3 = (int)num;
						float num4 = num - (float)num3;
						if (num4 <= 0.25f)
						{
							if (num4 != 0f)
							{
								result = num2 * float.TanForIntervalPiBy4(num4 * 3.1415927f, false);
							}
							else
							{
								result = num2 * (int.IsOddInteger(num3) ? --0f : 0f);
							}
						}
						else if (num4 <= 0.5f)
						{
							if (num4 != 0.5f)
							{
								result = -num2 * float.TanForIntervalPiBy4((0.5f - num4) * 3.1415927f, true);
							}
							else
							{
								result = num2 * (int.IsOddInteger(num3) ? float.NegativeInfinity : float.PositiveInfinity);
							}
						}
						else if (num4 <= 0.75f)
						{
							result = num2 * float.TanForIntervalPiBy4((num4 - 0.5f) * 3.1415927f, true);
						}
						else
						{
							result = -num2 * float.TanForIntervalPiBy4((1f - num4) * 3.1415927f, false);
						}
					}
					else if (num >= 0.0078125f)
					{
						result = float.TanForIntervalPiBy4(x * 3.1415927f, false);
					}
					else if (num >= 0.00012207031f)
					{
						float num5 = x * 3.1415927f;
						result = num5 + num5 * num5 * num5 * 0.33333334f;
					}
					else
					{
						result = x * 3.1415927f;
					}
				}
				else if (num < 16777216f)
				{
					int value = BitConverter.SingleToInt32Bits(num);
					result = num2 * (int.IsOddInteger(value) ? --0f : 0f);
				}
				else
				{
					result = num2 * 0f;
				}
			}
			else
			{
				result = float.NaN;
			}
			return result;
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0003046E File Offset: 0x0002E66E
		float IUnaryNegationOperators<float, float>.op_UnaryNegation(float value)
		{
			return -value;
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0002395C File Offset: 0x00021B5C
		float IUnaryPlusOperators<float, float>.op_UnaryPlus(float value)
		{
			return value;
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00059B6A File Offset: 0x00057D6A
		public static float Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseFloat<byte, float>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00059B7F File Offset: 0x00057D7F
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out float result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseFloat<byte, float>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00059B95 File Offset: 0x00057D95
		public static float Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return float.Parse(utf8Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00059BA3 File Offset: 0x00057DA3
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out float result)
		{
			return float.TryParse(utf8Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x00059BB2 File Offset: 0x00057DB2
		int IBinaryFloatParseAndFormatInfo<float>.NumberBufferLength
		{
			get
			{
				return 114;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x000304C1 File Offset: 0x0002E6C1
		ulong IBinaryFloatParseAndFormatInfo<float>.ZeroBits
		{
			get
			{
				return 0UL;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x00059BB6 File Offset: 0x00057DB6
		ulong IBinaryFloatParseAndFormatInfo<float>.InfinityBits
		{
			get
			{
				return 2139095040UL;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x00059BBE File Offset: 0x00057DBE
		ulong IBinaryFloatParseAndFormatInfo<float>.NormalMantissaMask
		{
			get
			{
				return 16777215UL;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x00059BC6 File Offset: 0x00057DC6
		ulong IBinaryFloatParseAndFormatInfo<float>.DenormalMantissaMask
		{
			get
			{
				return 8388607UL;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x00059BCE File Offset: 0x00057DCE
		int IBinaryFloatParseAndFormatInfo<float>.MinBinaryExponent
		{
			get
			{
				return -126;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x0005757F File Offset: 0x0005577F
		int IBinaryFloatParseAndFormatInfo<float>.MaxBinaryExponent
		{
			get
			{
				return 127;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x00059BD2 File Offset: 0x00057DD2
		int IBinaryFloatParseAndFormatInfo<float>.MinDecimalExponent
		{
			get
			{
				return -45;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00044969 File Offset: 0x00042B69
		int IBinaryFloatParseAndFormatInfo<float>.MaxDecimalExponent
		{
			get
			{
				return 39;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0005757F File Offset: 0x0005577F
		int IBinaryFloatParseAndFormatInfo<float>.ExponentBias
		{
			get
			{
				return 127;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		ushort IBinaryFloatParseAndFormatInfo<float>.ExponentBits
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x00059BD6 File Offset: 0x00057DD6
		int IBinaryFloatParseAndFormatInfo<float>.OverflowDecimalExponent
		{
			get
			{
				return 58;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x000200F7 File Offset: 0x0001E2F7
		int IBinaryFloatParseAndFormatInfo<float>.InfinityExponent
		{
			get
			{
				return 255;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x000588B0 File Offset: 0x00056AB0
		ushort IBinaryFloatParseAndFormatInfo<float>.NormalMantissaBits
		{
			get
			{
				return 24;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0003052A File Offset: 0x0002E72A
		ushort IBinaryFloatParseAndFormatInfo<float>.DenormalMantissaBits
		{
			get
			{
				return 23;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x00059BDA File Offset: 0x00057DDA
		int IBinaryFloatParseAndFormatInfo<float>.MinFastFloatDecimalExponent
		{
			get
			{
				return -65;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00059BDE File Offset: 0x00057DDE
		int IBinaryFloatParseAndFormatInfo<float>.MaxFastFloatDecimalExponent
		{
			get
			{
				return 38;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x00059BE2 File Offset: 0x00057DE2
		int IBinaryFloatParseAndFormatInfo<float>.MinExponentRoundToEven
		{
			get
			{
				return -17;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00029CD6 File Offset: 0x00027ED6
		int IBinaryFloatParseAndFormatInfo<float>.MaxExponentRoundToEven
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x00029CD6 File Offset: 0x00027ED6
		int IBinaryFloatParseAndFormatInfo<float>.MaxExponentFastPath
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x00059BE6 File Offset: 0x00057DE6
		ulong IBinaryFloatParseAndFormatInfo<float>.MaxMantissaFastPath
		{
			get
			{
				return 16777216UL;
			}
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00059BEE File Offset: 0x00057DEE
		float IBinaryFloatParseAndFormatInfo<float>.BitsToFloat(ulong bits)
		{
			return BitConverter.UInt32BitsToSingle((uint)bits);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00059BF7 File Offset: 0x00057DF7
		ulong IBinaryFloatParseAndFormatInfo<float>.FloatToBits(float value)
		{
			return (ulong)BitConverter.SingleToUInt32Bits(value);
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x000401EE File Offset: 0x0003E3EE
		int IBinaryFloatParseAndFormatInfo<float>.MaxRoundTripDigits
		{
			get
			{
				return 9;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x0003EE4B File Offset: 0x0003D04B
		int IBinaryFloatParseAndFormatInfo<float>.MaxPrecisionCustomFormat
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00059C00 File Offset: 0x00057E00
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float CosForIntervalPiBy4(float x)
		{
			double num = (double)(x * x);
			return (float)((((-2.755731727234419E-07 * num + 2.480158729876704E-05) * num + -0.0013888888888887398) * num + 0.041666666666666664) * (num * num) + (1.0 - 0.5 * num));
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00059C5C File Offset: 0x00057E5C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float SinForIntervalPiBy4(float x)
		{
			double num = (double)(x * x);
			return (float)((((2.7557316103728802E-06 * num + -0.00019841269836761127) * num + 0.00833333333333095) * num + -0.16666666666666666) * ((double)x * num) + (double)x);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00059CA4 File Offset: 0x00057EA4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float TanForIntervalPiBy4(float x, bool isReciprocal)
		{
			double num = (double)(x * x);
			double num2 = 0.01844239256901656;
			num2 = -0.5139650547885454 + num2 * num;
			num2 = 1.1558882143468838 + num2 * num;
			double num3 = -0.017203248047148168;
			num3 = 0.3852960712639954 + num3 * num;
			double num4 = (double)x * num;
			num4 *= num3 / num2;
			num4 += (double)x;
			if (isReciprocal)
			{
				num4 = -1.0 / num4;
			}
			return (float)num4;
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00059D18 File Offset: 0x00057F18
		[CompilerGenerated]
		internal static float <RootN>g__PositiveN|231_0(float x, int n)
		{
			float num;
			if (float.IsFinite(x))
			{
				if (x != 0f)
				{
					if (x > 0f || float.IsOddInteger((float)n))
					{
						num = (float)double.Pow((double)float.Abs(x), 1.0 / (double)n);
						num = float.CopySign(num, x);
					}
					else
					{
						num = float.NaN;
					}
				}
				else if (float.IsEvenInteger((float)n))
				{
					num = 0f;
				}
				else
				{
					num = float.CopySign(0f, x);
				}
			}
			else if (float.IsNaN(x))
			{
				num = float.NaN;
			}
			else if (x > 0f)
			{
				num = float.PositiveInfinity;
			}
			else
			{
				num = (int.IsOddInteger(n) ? float.NegativeInfinity : float.NaN);
			}
			return num;
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00059DC8 File Offset: 0x00057FC8
		[CompilerGenerated]
		internal static float <RootN>g__NegativeN|231_1(float x, int n)
		{
			float num;
			if (float.IsFinite(x))
			{
				if (x != 0f)
				{
					if (x > 0f || float.IsOddInteger((float)n))
					{
						num = (float)double.Pow((double)float.Abs(x), 1.0 / (double)n);
						num = float.CopySign(num, x);
					}
					else
					{
						num = float.NaN;
					}
				}
				else if (float.IsEvenInteger((float)n))
				{
					num = float.PositiveInfinity;
				}
				else
				{
					num = float.CopySign(float.PositiveInfinity, x);
				}
			}
			else if (float.IsNaN(x))
			{
				num = float.NaN;
			}
			else if (x > 0f)
			{
				num = 0f;
			}
			else
			{
				num = (int.IsOddInteger(n) ? --0f : float.NaN);
			}
			return num;
		}

		// Token: 0x04000566 RID: 1382
		private readonly float m_value;

		// Token: 0x04000567 RID: 1383
		public const float MinValue = -3.4028235E+38f;

		// Token: 0x04000568 RID: 1384
		public const float MaxValue = 3.4028235E+38f;

		// Token: 0x04000569 RID: 1385
		public const float Epsilon = 1E-45f;

		// Token: 0x0400056A RID: 1386
		public const float NegativeInfinity = float.NegativeInfinity;

		// Token: 0x0400056B RID: 1387
		public const float PositiveInfinity = float.PositiveInfinity;

		// Token: 0x0400056C RID: 1388
		public const float NaN = float.NaN;

		// Token: 0x0400056D RID: 1389
		public const float NegativeZero = --0f;

		// Token: 0x0400056E RID: 1390
		public const float E = 2.7182817f;

		// Token: 0x0400056F RID: 1391
		public const float Pi = 3.1415927f;

		// Token: 0x04000570 RID: 1392
		public const float Tau = 6.2831855f;
	}
}
