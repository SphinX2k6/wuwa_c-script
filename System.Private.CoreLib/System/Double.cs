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
	// Token: 0x02000101 RID: 257
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct Double : IComparable, IConvertible, ISpanFormattable, IFormattable, IComparable<double>, IEquatable<double>, IBinaryFloatingPointIeee754<double>, IBinaryNumber<double>, IBitwiseOperators<double, double, double>, INumber<double>, IComparisonOperators<double, double, bool>, IEqualityOperators<double, double, bool>, IModulusOperators<double, double, double>, INumberBase<double>, IAdditionOperators<double, double, double>, IAdditiveIdentity<double, double>, IDecrementOperators<double>, IDivisionOperators<double, double, double>, IIncrementOperators<double>, IMultiplicativeIdentity<double, double>, IMultiplyOperators<double, double, double>, ISpanParsable<double>, IParsable<double>, ISubtractionOperators<double, double, double>, IUnaryPlusOperators<double, double>, IUnaryNegationOperators<double, double>, IUtf8SpanFormattable, IUtf8SpanParsable<double>, IFloatingPointIeee754<double>, IExponentialFunctions<double>, IFloatingPointConstants<double>, IFloatingPoint<double>, ISignedNumber<double>, IHyperbolicFunctions<double>, ILogarithmicFunctions<double>, IPowerFunctions<double>, IRootFunctions<double>, ITrigonometricFunctions<double>, IMinMaxValue<double>, IBinaryFloatParseAndFormatInfo<double>
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0002E627 File Offset: 0x0002C827
		internal ushort BiasedExponent
		{
			get
			{
				return double.ExtractBiasedExponentFromBits(BitConverter.DoubleToUInt64Bits(this));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x0002E635 File Offset: 0x0002C835
		internal short Exponent
		{
			get
			{
				return (short)(this.BiasedExponent - 1023);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0002E644 File Offset: 0x0002C844
		internal ulong Significand
		{
			get
			{
				return this.TrailingSignificand | ((this.BiasedExponent != 0) ? 4503599627370496UL : 0UL);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x0002E662 File Offset: 0x0002C862
		internal ulong TrailingSignificand
		{
			get
			{
				return double.ExtractTrailingSignificandFromBits(BitConverter.DoubleToUInt64Bits(this));
			}
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0002E670 File Offset: 0x0002C870
		internal static ushort ExtractBiasedExponentFromBits(ulong bits)
		{
			return (ushort)(bits >> 52 & 2047UL);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0002E67E File Offset: 0x0002C87E
		internal static ulong ExtractTrailingSignificandFromBits(ulong bits)
		{
			return bits & 4503599627370495UL;
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0002E68B File Offset: 0x0002C88B
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsFinite(double d)
		{
			return (~BitConverter.DoubleToUInt64Bits(d) & 9218868437227405312UL) > 0UL;
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0002E6A2 File Offset: 0x0002C8A2
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInfinity(double d)
		{
			return (BitConverter.DoubleToUInt64Bits(d) & 9223372036854775807UL) == 9218868437227405312UL;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0002E6BF File Offset: 0x0002C8BF
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNaN(double d)
		{
			return d != d;
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0002E6C8 File Offset: 0x0002C8C8
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool IsNaNOrZero(double d)
		{
			return (BitConverter.DoubleToUInt64Bits(d) - 1UL & 9223372036854775807UL) >= 9218868437227405312UL;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0002E6EB File Offset: 0x0002C8EB
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegative(double d)
		{
			return BitConverter.DoubleToInt64Bits(d) < 0L;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0002E6F7 File Offset: 0x0002C8F7
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegativeInfinity(double d)
		{
			return d == double.NegativeInfinity;
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0002E705 File Offset: 0x0002C905
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNormal(double d)
		{
			return (BitConverter.DoubleToUInt64Bits(d) & 9223372036854775807UL) - 4503599627370496UL < 9214364837600034816UL;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0002E72C File Offset: 0x0002C92C
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPositiveInfinity(double d)
		{
			return d == double.PositiveInfinity;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0002E73A File Offset: 0x0002C93A
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsSubnormal(double d)
		{
			return (BitConverter.DoubleToUInt64Bits(d) & 9223372036854775807UL) - 1UL < 4503599627370495UL;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0002E75A File Offset: 0x0002C95A
		[NonVersionable]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool IsZero(double d)
		{
			return d == 0.0;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0002E768 File Offset: 0x0002C968
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value is double)
			{
				double value2 = (double)value;
				return this.CompareTo(value2);
			}
			if (value != null)
			{
				throw new ArgumentException(SR.Arg_MustBeDouble);
			}
			return 1;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0002E79D File Offset: 0x0002C99D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int CompareTo(double value)
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
			if (!double.IsNaN(this))
			{
				return 1;
			}
			if (!double.IsNaN(value))
			{
				return -1;
			}
			return 0;
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0002E7CC File Offset: 0x0002C9CC
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is double)
			{
				double obj2 = (double)obj;
				return this.Equals(obj2);
			}
			return false;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0000FF2A File Offset: 0x0000E12A
		[NonVersionable]
		public static bool operator ==(double left, double right)
		{
			return left == right;
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0001306A File Offset: 0x0001126A
		[NonVersionable]
		public static bool operator !=(double left, double right)
		{
			return left != right;
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00020126 File Offset: 0x0001E326
		[NonVersionable]
		public static bool operator <(double left, double right)
		{
			return left < right;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00020135 File Offset: 0x0001E335
		[NonVersionable]
		public static bool operator >(double left, double right)
		{
			return left > right;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0002E7F1 File Offset: 0x0002C9F1
		[NonVersionable]
		public static bool operator <=(double left, double right)
		{
			return left <= right;
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0002E7FA File Offset: 0x0002C9FA
		[NonVersionable]
		public static bool operator >=(double left, double right)
		{
			return left >= right;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0002E803 File Offset: 0x0002CA03
		public bool Equals(double obj)
		{
			return obj == this || (double.IsNaN(obj) && double.IsNaN(this));
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0002E820 File Offset: 0x0002CA20
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			ulong num = BitConverter.DoubleToUInt64Bits(this);
			if (double.IsNaNOrZero(this))
			{
				num &= 9218868437227405312UL;
			}
			return (int)num ^ (int)(num >> 32);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0002E852 File Offset: 0x0002CA52
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.FormatFloat<double>(this, null, NumberFormatInfo.CurrentInfo);
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0002E861 File Offset: 0x0002CA61
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return Number.FormatFloat<double>(this, format, NumberFormatInfo.CurrentInfo);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0002E870 File Offset: 0x0002CA70
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.FormatFloat<double>(this, null, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0002E880 File Offset: 0x0002CA80
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatFloat<double>(this, format, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0002E890 File Offset: 0x0002CA90
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatFloat<double, char>(this, format, NumberFormatInfo.GetInstance(provider), destination, out charsWritten);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0002E8A3 File Offset: 0x0002CAA3
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatFloat<double, byte>(this, format, NumberFormatInfo.GetInstance(provider), utf8Destination, out bytesWritten);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0002E8B6 File Offset: 0x0002CAB6
		[NullableContext(1)]
		public static double Parse(string s)
		{
			return double.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null);
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0002E8C4 File Offset: 0x0002CAC4
		[NullableContext(1)]
		public static double Parse(string s, NumberStyles style)
		{
			return double.Parse(s, style, null);
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0002E8CE File Offset: 0x0002CACE
		[NullableContext(1)]
		public static double Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return double.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0002E8DC File Offset: 0x0002CADC
		[NullableContext(1)]
		public static double Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return double.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0002E8F5 File Offset: 0x0002CAF5
		public static double Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return Number.ParseFloat<char, double>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0002E90A File Offset: 0x0002CB0A
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out double result)
		{
			return double.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null, out result);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0002E919 File Offset: 0x0002CB19
		public static bool TryParse(ReadOnlySpan<char> s, out double result)
		{
			return double.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null, out result);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0002E928 File Offset: 0x0002CB28
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out double result)
		{
			return double.TryParse(utf8Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, null, out result);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0002E937 File Offset: 0x0002CB37
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out double result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			if (s == null)
			{
				result = 0.0;
				return false;
			}
			return Number.TryParseFloat<char, double>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0002E962 File Offset: 0x0002CB62
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out double result)
		{
			NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
			return Number.TryParseFloat<char, double>(s, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0002E978 File Offset: 0x0002CB78
		public TypeCode GetTypeCode()
		{
			return TypeCode.Double;
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0002E97C File Offset: 0x0002CB7C
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0002E985 File Offset: 0x0002CB85
		char IConvertible.ToChar(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Double", "Char"));
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0002E9A0 File Offset: 0x0002CBA0
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0002E9A9 File Offset: 0x0002CBA9
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0002E9B2 File Offset: 0x0002CBB2
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0002E9BB File Offset: 0x0002CBBB
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0002E9C4 File Offset: 0x0002CBC4
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0002E9CD File Offset: 0x0002CBCD
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0002E9D6 File Offset: 0x0002CBD6
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0002E9DF File Offset: 0x0002CBDF
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0002E9E8 File Offset: 0x0002CBE8
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0002E9F1 File Offset: 0x0002CBF1
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0002E9F5 File Offset: 0x0002CBF5
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0002E9FE File Offset: 0x0002CBFE
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Double", "DateTime"));
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0002EA19 File Offset: 0x0002CC19
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0002EA29 File Offset: 0x0002CC29
		double IAdditionOperators<double, double, double>.op_Addition(double left, double right)
		{
			return left + right;
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x0002EA2E File Offset: 0x0002CC2E
		double IAdditiveIdentity<double, double>.AdditiveIdentity
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x0002EA39 File Offset: 0x0002CC39
		double IBinaryNumber<double>.AllBitsSet
		{
			get
			{
				return BitConverter.UInt64BitsToDouble(ulong.MaxValue);
			}
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0002EA44 File Offset: 0x0002CC44
		public static bool IsPow2(double value)
		{
			ulong num = BitConverter.DoubleToUInt64Bits(value);
			if (num <= 0UL)
			{
				return false;
			}
			ushort num2 = double.ExtractBiasedExponentFromBits(num);
			ulong num3 = double.ExtractTrailingSignificandFromBits(num);
			if (num2 == 0)
			{
				return ulong.PopCount(num3) == 1UL;
			}
			return num2 != 2047 && num3 == 0UL;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0002EA8A File Offset: 0x0002CC8A
		[Intrinsic]
		public static double Log2(double value)
		{
			return Math.Log2(value);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0002EA92 File Offset: 0x0002CC92
		double IBitwiseOperators<double, double, double>.op_BitwiseAnd(double left, double right)
		{
			return BitConverter.UInt64BitsToDouble(BitConverter.DoubleToUInt64Bits(left) & BitConverter.DoubleToUInt64Bits(right));
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0002EAA6 File Offset: 0x0002CCA6
		double IBitwiseOperators<double, double, double>.op_BitwiseOr(double left, double right)
		{
			return BitConverter.UInt64BitsToDouble(BitConverter.DoubleToUInt64Bits(left) | BitConverter.DoubleToUInt64Bits(right));
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0002EABA File Offset: 0x0002CCBA
		double IBitwiseOperators<double, double, double>.op_ExclusiveOr(double left, double right)
		{
			return BitConverter.UInt64BitsToDouble(BitConverter.DoubleToUInt64Bits(left) ^ BitConverter.DoubleToUInt64Bits(right));
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0002EACE File Offset: 0x0002CCCE
		double IBitwiseOperators<double, double, double>.op_OnesComplement(double value)
		{
			return BitConverter.UInt64BitsToDouble(~BitConverter.DoubleToUInt64Bits(value));
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0002EADC File Offset: 0x0002CCDC
		double IDecrementOperators<double>.op_Decrement(double value)
		{
			return value -= 1.0;
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0002EAEC File Offset: 0x0002CCEC
		double IDivisionOperators<double, double, double>.op_Division(double left, double right)
		{
			return left / right;
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0002EAF1 File Offset: 0x0002CCF1
		[Intrinsic]
		public static double Exp(double x)
		{
			return Math.Exp(x);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0002EAF9 File Offset: 0x0002CCF9
		public static double ExpM1(double x)
		{
			return Math.Exp(x) - 1.0;
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0002EB0B File Offset: 0x0002CD0B
		public static double Exp2(double x)
		{
			return Math.Pow(2.0, x);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0002EB1C File Offset: 0x0002CD1C
		public static double Exp2M1(double x)
		{
			return Math.Pow(2.0, x) - 1.0;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0002EB37 File Offset: 0x0002CD37
		public static double Exp10(double x)
		{
			return Math.Pow(10.0, x);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0002EB48 File Offset: 0x0002CD48
		public static double Exp10M1(double x)
		{
			return Math.Pow(10.0, x) - 1.0;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0002EB63 File Offset: 0x0002CD63
		[Intrinsic]
		public static double Ceiling(double x)
		{
			return Math.Ceiling(x);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0002EB6B File Offset: 0x0002CD6B
		[NullableContext(1)]
		[Intrinsic]
		public static TInteger ConvertToInteger<[Nullable(0)] TInteger>(double value) where TInteger : IBinaryInteger<TInteger>
		{
			return INumberBase<TInteger>.CreateSaturating<double>(value);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0002EB6B File Offset: 0x0002CD6B
		[NullableContext(1)]
		[Intrinsic]
		public static TInteger ConvertToIntegerNative<[Nullable(0)] TInteger>(double value) where TInteger : IBinaryInteger<TInteger>
		{
			return INumberBase<TInteger>.CreateSaturating<double>(value);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0002EB79 File Offset: 0x0002CD79
		[Intrinsic]
		public static double Floor(double x)
		{
			return Math.Floor(x);
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0002EB81 File Offset: 0x0002CD81
		[Intrinsic]
		public static double Round(double x)
		{
			return Math.Round(x);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0002EB89 File Offset: 0x0002CD89
		public static double Round(double x, int digits)
		{
			return Math.Round(x, digits);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0002EB92 File Offset: 0x0002CD92
		public static double Round(double x, MidpointRounding mode)
		{
			return Math.Round(x, mode);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0002EB9B File Offset: 0x0002CD9B
		public static double Round(double x, int digits, MidpointRounding mode)
		{
			return Math.Round(x, digits, mode);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0002EBA5 File Offset: 0x0002CDA5
		[Intrinsic]
		public static double Truncate(double x)
		{
			return Math.Truncate(x);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int IFloatingPoint<double>.GetExponentByteCount()
		{
			return 2;
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0002EBB0 File Offset: 0x0002CDB0
		int IFloatingPoint<double>.GetExponentShortestBitLength()
		{
			short exponent = this.Exponent;
			if (exponent >= 0)
			{
				return (int)(16 - short.LeadingZeroCount(exponent));
			}
			return (int)(17 - short.LeadingZeroCount(~exponent));
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		int IFloatingPoint<double>.GetSignificandByteCount()
		{
			return 8;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		int IFloatingPoint<double>.GetSignificandBitLength()
		{
			return 53;
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0002EBE4 File Offset: 0x0002CDE4
		bool IFloatingPoint<double>.TryWriteExponentBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				short value = this.Exponent;
				bool isLittleEndian = BitConverter.IsLittleEndian;
				value = BinaryPrimitives.ReverseEndianness(value);
				Unsafe.WriteUnaligned<short>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0002EC24 File Offset: 0x0002CE24
		bool IFloatingPoint<double>.TryWriteExponentLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 2)
			{
				short exponent = this.Exponent;
				if (!BitConverter.IsLittleEndian)
				{
				}
				Unsafe.WriteUnaligned<short>(MemoryMarshal.GetReference<byte>(destination), exponent);
				bytesWritten = 2;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0002EC60 File Offset: 0x0002CE60
		bool IFloatingPoint<double>.TryWriteSignificandBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				ulong value = this.Significand;
				bool isLittleEndian = BitConverter.IsLittleEndian;
				value = BinaryPrimitives.ReverseEndianness(value);
				Unsafe.WriteUnaligned<ulong>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0002ECA0 File Offset: 0x0002CEA0
		bool IFloatingPoint<double>.TryWriteSignificandLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				ulong significand = this.Significand;
				if (!BitConverter.IsLittleEndian)
				{
				}
				Unsafe.WriteUnaligned<ulong>(MemoryMarshal.GetReference<byte>(destination), significand);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0002ECDA File Offset: 0x0002CEDA
		double IFloatingPointConstants<double>.E
		{
			get
			{
				return 2.718281828459045;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x0002ECE5 File Offset: 0x0002CEE5
		double IFloatingPointConstants<double>.Pi
		{
			get
			{
				return 3.141592653589793;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060010A1 RID: 4257 RVA: 0x0002ECF0 File Offset: 0x0002CEF0
		double IFloatingPointConstants<double>.Tau
		{
			get
			{
				return 6.283185307179586;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0002ECFB File Offset: 0x0002CEFB
		double IFloatingPointIeee754<double>.Epsilon
		{
			get
			{
				return 5E-324;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x0002ED06 File Offset: 0x0002CF06
		double IFloatingPointIeee754<double>.NaN
		{
			get
			{
				return double.NaN;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0002ED11 File Offset: 0x0002CF11
		double IFloatingPointIeee754<double>.NegativeInfinity
		{
			get
			{
				return double.NegativeInfinity;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0002ED1C File Offset: 0x0002CF1C
		double IFloatingPointIeee754<double>.NegativeZero
		{
			get
			{
				return --0.0;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x0002ED27 File Offset: 0x0002CF27
		double IFloatingPointIeee754<double>.PositiveInfinity
		{
			get
			{
				return double.PositiveInfinity;
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0002ED32 File Offset: 0x0002CF32
		[Intrinsic]
		public static double Atan2(double y, double x)
		{
			return Math.Atan2(y, x);
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0002ED3B File Offset: 0x0002CF3B
		public static double Atan2Pi(double y, double x)
		{
			return double.Atan2(y, x) / 3.141592653589793;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0002ED4E File Offset: 0x0002CF4E
		public static double BitDecrement(double x)
		{
			return Math.BitDecrement(x);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0002ED56 File Offset: 0x0002CF56
		public static double BitIncrement(double x)
		{
			return Math.BitIncrement(x);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0002ED5E File Offset: 0x0002CF5E
		[Intrinsic]
		public static double FusedMultiplyAdd(double left, double right, double addend)
		{
			return Math.FusedMultiplyAdd(left, right, addend);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0002ED68 File Offset: 0x0002CF68
		public static double Ieee754Remainder(double left, double right)
		{
			return Math.IEEERemainder(left, right);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0002ED71 File Offset: 0x0002CF71
		public static int ILogB(double x)
		{
			return Math.ILogB(x);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0002ED79 File Offset: 0x0002CF79
		public static double Lerp(double value1, double value2, double amount)
		{
			return double.MultiplyAddEstimate(value1, 1.0 - amount, value2 * amount);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0002ED8F File Offset: 0x0002CF8F
		[Intrinsic]
		public static double ReciprocalEstimate(double x)
		{
			return Math.ReciprocalEstimate(x);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0002ED97 File Offset: 0x0002CF97
		[Intrinsic]
		public static double ReciprocalSqrtEstimate(double x)
		{
			return Math.ReciprocalSqrtEstimate(x);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0002ED9F File Offset: 0x0002CF9F
		public static double ScaleB(double x, int n)
		{
			return Math.ScaleB(x, n);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0002EDA8 File Offset: 0x0002CFA8
		[Intrinsic]
		public static double Acosh(double x)
		{
			return Math.Acosh(x);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0002EDB0 File Offset: 0x0002CFB0
		[Intrinsic]
		public static double Asinh(double x)
		{
			return Math.Asinh(x);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		[Intrinsic]
		public static double Atanh(double x)
		{
			return Math.Atanh(x);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0002EDC0 File Offset: 0x0002CFC0
		[Intrinsic]
		public static double Cosh(double x)
		{
			return Math.Cosh(x);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0002EDC8 File Offset: 0x0002CFC8
		[Intrinsic]
		public static double Sinh(double x)
		{
			return Math.Sinh(x);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0002EDD0 File Offset: 0x0002CFD0
		[Intrinsic]
		public static double Tanh(double x)
		{
			return Math.Tanh(x);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0002EDD8 File Offset: 0x0002CFD8
		double IIncrementOperators<double>.op_Increment(double value)
		{
			return value += 1.0;
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0002EDE8 File Offset: 0x0002CFE8
		[Intrinsic]
		public static double Log(double x)
		{
			return Math.Log(x);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0002EDF0 File Offset: 0x0002CFF0
		public static double Log(double x, double newBase)
		{
			return Math.Log(x, newBase);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0002EDF9 File Offset: 0x0002CFF9
		public static double LogP1(double x)
		{
			return Math.Log(x + 1.0);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0002EE0B File Offset: 0x0002D00B
		public static double Log2P1(double x)
		{
			return Math.Log2(x + 1.0);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0002EE1D File Offset: 0x0002D01D
		[Intrinsic]
		public static double Log10(double x)
		{
			return Math.Log10(x);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0002EE25 File Offset: 0x0002D025
		public static double Log10P1(double x)
		{
			return Math.Log10(x + 1.0);
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x0002EE37 File Offset: 0x0002D037
		double IMinMaxValue<double>.MinValue
		{
			get
			{
				return -1.7976931348623157E+308;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x0002EE42 File Offset: 0x0002D042
		double IMinMaxValue<double>.MaxValue
		{
			get
			{
				return 1.7976931348623157E+308;
			}
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0002EE4D File Offset: 0x0002D04D
		double IModulusOperators<double, double, double>.op_Modulus(double left, double right)
		{
			return left % right;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0002EE52 File Offset: 0x0002D052
		double IMultiplicativeIdentity<double, double>.MultiplicativeIdentity
		{
			get
			{
				return 1.0;
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0002EE5D File Offset: 0x0002D05D
		double IMultiplyOperators<double, double, double>.op_Multiply(double left, double right)
		{
			return left * right;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0002EE62 File Offset: 0x0002D062
		public static double Clamp(double value, double min, double max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0002EE6C File Offset: 0x0002D06C
		public static double CopySign(double value, double sign)
		{
			return Math.CopySign(value, sign);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0002EE75 File Offset: 0x0002D075
		[Intrinsic]
		public static double Max(double x, double y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0002EE7E File Offset: 0x0002D07E
		[Intrinsic]
		public static double MaxNumber(double x, double y)
		{
			if (x != y)
			{
				if (double.IsNaN(y))
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
				if (!double.IsNegative(y))
				{
					return y;
				}
				return x;
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0002EEA1 File Offset: 0x0002D0A1
		[Intrinsic]
		public static double Min(double x, double y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0002EEAA File Offset: 0x0002D0AA
		[Intrinsic]
		public static double MinNumber(double x, double y)
		{
			if (x != y)
			{
				if (double.IsNaN(y))
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
				if (!double.IsNegative(x))
				{
					return y;
				}
				return x;
			}
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0002EECD File Offset: 0x0002D0CD
		public static int Sign(double value)
		{
			return Math.Sign(value);
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0002EE52 File Offset: 0x0002D052
		double INumberBase<double>.One
		{
			get
			{
				return 1.0;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<double>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0002EA2E File Offset: 0x0002CC2E
		double INumberBase<double>.Zero
		{
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0002EED5 File Offset: 0x0002D0D5
		[Intrinsic]
		public static double Abs(double value)
		{
			return Math.Abs(value);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0002EEE0 File Offset: 0x0002D0E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			double result;
			if (typeof(TOther) == typeof(double))
			{
				result = (double)((object)value);
			}
			else if (!double.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<double>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0002EF38 File Offset: 0x0002D138
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			double result;
			if (typeof(TOther) == typeof(double))
			{
				result = (double)((object)value);
			}
			else if (!double.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<double>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0002EF90 File Offset: 0x0002D190
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			double result;
			if (typeof(TOther) == typeof(double))
			{
				result = (double)((object)value);
			}
			else if (!double.TryConvertFrom<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<double>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<double>.IsCanonical(double value)
		{
			return true;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<double>.IsComplexNumber(double value)
		{
			return false;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0002EFE6 File Offset: 0x0002D1E6
		public static bool IsEvenInteger(double value)
		{
			return double.IsInteger(value) && double.Abs(value % 2.0) == 0.0;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<double>.IsImaginaryNumber(double value)
		{
			return false;
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0002F00D File Offset: 0x0002D20D
		public static bool IsInteger(double value)
		{
			return double.IsFinite(value) && value == double.Truncate(value);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0002F022 File Offset: 0x0002D222
		public static bool IsOddInteger(double value)
		{
			return double.IsInteger(value) && double.Abs(value % 2.0) == 1.0;
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0002F049 File Offset: 0x0002D249
		public static bool IsPositive(double value)
		{
			return BitConverter.DoubleToInt64Bits(value) >= 0L;
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0002F058 File Offset: 0x0002D258
		public static bool IsRealNumber(double value)
		{
			return value == value;
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0002F05E File Offset: 0x0002D25E
		bool INumberBase<double>.IsZero(double value)
		{
			return double.IsZero(value);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0002F066 File Offset: 0x0002D266
		[Intrinsic]
		public static double MaxMagnitude(double x, double y)
		{
			return Math.MaxMagnitude(x, y);
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0002F070 File Offset: 0x0002D270
		[Intrinsic]
		public static double MaxMagnitudeNumber(double x, double y)
		{
			double num = double.Abs(x);
			double num2 = double.Abs(y);
			if (num > num2 || double.IsNaN(num2))
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!double.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0002F0AA File Offset: 0x0002D2AA
		[Intrinsic]
		public static double MinMagnitude(double x, double y)
		{
			return Math.MinMagnitude(x, y);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0002F0B4 File Offset: 0x0002D2B4
		[Intrinsic]
		public static double MinMagnitudeNumber(double x, double y)
		{
			double num = double.Abs(x);
			double num2 = double.Abs(y);
			if (num < num2 || double.IsNaN(num2))
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!double.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0002F0EE File Offset: 0x0002D2EE
		[Intrinsic]
		public static double MultiplyAddEstimate(double left, double right, double addend)
		{
			return left * right + addend;
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0002F0F5 File Offset: 0x0002D2F5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<double>.TryConvertFromChecked<TOther>(TOther value, out double result) where TOther : INumberBase<TOther>
		{
			return double.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0002F0F5 File Offset: 0x0002D2F5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<double>.TryConvertFromSaturating<TOther>(TOther value, out double result) where TOther : INumberBase<TOther>
		{
			return double.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0002F0F5 File Offset: 0x0002D2F5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<double>.TryConvertFromTruncating<TOther>(TOther value, out double result) where TOther : INumberBase<TOther>
		{
			return double.TryConvertFrom<TOther>(value, out result);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0002F100 File Offset: 0x0002D300
		private static bool TryConvertFrom<TOther>(TOther value, out double result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(Half))
			{
				Half value2 = (Half)((object)value);
				result = (double)value2;
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num = (short)((object)value);
				result = (double)num;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num2 = (int)((object)value);
				result = (double)num2;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num3 = (long)((object)value);
				result = (double)num3;
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 value3 = (Int128)((object)value);
				result = (double)value3;
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				result = (double)intPtr;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (double)b;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num4 = (float)((object)value);
				result = (double)num4;
				return true;
			}
			result = 0.0;
			return false;
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x0002F294 File Offset: 0x0002D494
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<double>.TryConvertToChecked<TOther>(double value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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

		// Token: 0x060010E5 RID: 4325 RVA: 0x0002F441 File Offset: 0x0002D641
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<double>.TryConvertToSaturating<TOther>(double value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			return double.TryConvertTo<TOther>(value, out result);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0002F441 File Offset: 0x0002D641
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<double>.TryConvertToTruncating<TOther>(double value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			return double.TryConvertTo<TOther>(value, out result);
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0002F44C File Offset: 0x0002D64C
		private static bool TryConvertTo<TOther>(double value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (value >= 255.0) ? byte.MaxValue : ((value <= 0.0) ? 0 : ((byte)value));
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (value >= 65535.0) ? char.MaxValue : ((value <= 0.0) ? '\0' : ((char)value));
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (value >= 7.922816251426434E+28) ? decimal.MaxValue : ((value <= -7.922816251426434E+28) ? decimal.MinValue : (double.IsNaN(value) ? 0.0m : ((decimal)value)));
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (value >= 65535.0) ? ushort.MaxValue : ((value <= 0.0) ? 0 : ((ushort)value));
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (value >= 4294967295.0) ? uint.MaxValue : ((value <= 0.0) ? 0U : ((uint)value));
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (value >= 1.8446744073709552E+19) ? ulong.MaxValue : ((value <= 0.0) ? 0UL : (double.IsNaN(value) ? 0UL : ((ulong)value)));
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (value >= 3.402823669209385E+38) ? UInt128.MaxValue : ((value <= 0.0) ? UInt128.MinValue : ((UInt128)value));
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (value >= 1.8446744073709552E+19) ? ((UIntPtr)(-1L)) : ((UIntPtr)((value <= 0.0) ? ((IntPtr)0) : ((IntPtr)((UIntPtr)value))));
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0002F734 File Offset: 0x0002D934
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out double result)
		{
			return double.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0002F743 File Offset: 0x0002D943
		[Intrinsic]
		public static double Pow(double x, double y)
		{
			return Math.Pow(x, y);
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0002F74C File Offset: 0x0002D94C
		[Intrinsic]
		public static double Cbrt(double x)
		{
			return Math.Cbrt(x);
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x0002F754 File Offset: 0x0002D954
		public static double Hypot(double x, double y)
		{
			double result;
			if (double.IsFinite(x) && double.IsFinite(y))
			{
				double num = double.Abs(x);
				double num2 = double.Abs(y);
				if (num == 0.0)
				{
					result = num2;
				}
				else if (num2 == 0.0)
				{
					result = num;
				}
				else
				{
					ulong num3 = BitConverter.DoubleToUInt64Bits(num);
					ulong num4 = BitConverter.DoubleToUInt64Bits(num2);
					uint num5 = (uint)(num3 >> 52 & 2047UL);
					uint num6 = (uint)(num4 >> 52 & 2047UL);
					int num7 = (int)(num5 - num6);
					double num8 = 1.0;
					if (num7 <= 54 && num7 >= -54)
					{
						if (num5 > 1523U || num6 > 1523U)
						{
							num8 = 4.149515568880993E+180;
							num3 -= 2702159776422297600UL;
							num4 -= 2702159776422297600UL;
						}
						else if (num5 < 523U || num6 < 523U)
						{
							num8 = 2.409919865102884E-181;
							num3 += 2702159776422297600UL;
							num4 += 2702159776422297600UL;
							if (num5 == 0U)
							{
								num3 += 4503599627370496UL;
								num = BitConverter.UInt64BitsToDouble(num3);
								num -= 9.232978617785736E-128;
								num3 = BitConverter.DoubleToUInt64Bits(num);
							}
							if (num6 == 0U)
							{
								num4 += 4503599627370496UL;
								num2 = BitConverter.UInt64BitsToDouble(num4);
								num2 -= 9.232978617785736E-128;
								num4 = BitConverter.DoubleToUInt64Bits(num2);
							}
						}
						num = BitConverter.UInt64BitsToDouble(num3);
						num2 = BitConverter.UInt64BitsToDouble(num4);
						if (num < num2)
						{
							double num9 = num;
							num = num2;
							num2 = num9;
							ulong num10 = num3;
							num3 = num4;
							num4 = num10;
						}
						double num11 = BitConverter.UInt64BitsToDouble(num3 & 18446744073575333888UL);
						double num12 = BitConverter.UInt64BitsToDouble(num4 & 18446744073575333888UL);
						double num13 = num - num11;
						double num14 = num2 - num12;
						double num15 = num * num;
						double num16 = num2 * num2;
						double num17 = num15 + num16;
						double num18 = num15 - num17 + num16;
						num18 += num11 * num11 - num15;
						num18 += 2.0 * num11 * num13;
						num18 += num13 * num13;
						if (num7 == 0)
						{
							num18 += num12 * num12 - num16;
							num18 += 2.0 * num12 * num14;
							num18 += num14 * num14;
						}
						result = double.Sqrt(num17 + num18) * num8;
					}
					else
					{
						result = num + num2;
					}
				}
			}
			else if (double.IsInfinity(x) || double.IsInfinity(y))
			{
				result = double.PositiveInfinity;
			}
			else
			{
				result = double.NaN;
			}
			return result;
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0002F9C0 File Offset: 0x0002DBC0
		public static double RootN(double x, int n)
		{
			double result;
			if (n > 0)
			{
				if (n == 2)
				{
					result = ((x != 0.0) ? double.Sqrt(x) : 0.0);
				}
				else if (n == 3)
				{
					result = double.Cbrt(x);
				}
				else
				{
					result = double.<RootN>g__PositiveN|231_0(x, n);
				}
			}
			else if (n < 0)
			{
				result = double.<RootN>g__NegativeN|231_1(x, n);
			}
			else
			{
				result = double.NaN;
			}
			return result;
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0002FA25 File Offset: 0x0002DC25
		[Intrinsic]
		public static double Sqrt(double x)
		{
			return Math.Sqrt(x);
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x0002FA2D File Offset: 0x0002DC2D
		double ISignedNumber<double>.NegativeOne
		{
			get
			{
				return -1.0;
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0002FA38 File Offset: 0x0002DC38
		public static double Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return double.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0002FA46 File Offset: 0x0002DC46
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out double result)
		{
			return double.TryParse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0002FA55 File Offset: 0x0002DC55
		double ISubtractionOperators<double, double, double>.op_Subtraction(double left, double right)
		{
			return left - right;
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0002FA5A File Offset: 0x0002DC5A
		[Intrinsic]
		public static double Acos(double x)
		{
			return Math.Acos(x);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0002FA62 File Offset: 0x0002DC62
		public static double AcosPi(double x)
		{
			return double.Acos(x) / 3.141592653589793;
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0002FA74 File Offset: 0x0002DC74
		[Intrinsic]
		public static double Asin(double x)
		{
			return Math.Asin(x);
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0002FA7C File Offset: 0x0002DC7C
		public static double AsinPi(double x)
		{
			return double.Asin(x) / 3.141592653589793;
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0002FA8E File Offset: 0x0002DC8E
		[Intrinsic]
		public static double Atan(double x)
		{
			return Math.Atan(x);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0002FA96 File Offset: 0x0002DC96
		public static double AtanPi(double x)
		{
			return double.Atan(x) / 3.141592653589793;
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0002FAA8 File Offset: 0x0002DCA8
		[Intrinsic]
		public static double Cos(double x)
		{
			return Math.Cos(x);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0002FAB0 File Offset: 0x0002DCB0
		public static double CosPi(double x)
		{
			double result;
			if (double.IsFinite(x))
			{
				double num = double.Abs(x);
				if (num < 4503599627370496.0)
				{
					if (num > 0.25)
					{
						long num2 = (long)num;
						double num3 = num - (double)num2;
						double num4 = long.IsOddInteger(num2) ? -1.0 : 1.0;
						if (num3 <= 0.25)
						{
							if (num3 != 0.0)
							{
								result = num4 * double.CosForIntervalPiBy4(num3 * 3.141592653589793, 0.0);
							}
							else
							{
								result = num4;
							}
						}
						else if (num3 <= 0.5)
						{
							if (num3 != 0.5)
							{
								result = num4 * double.SinForIntervalPiBy4((0.5 - num3) * 3.141592653589793, 0.0);
							}
							else
							{
								result = 0.0;
							}
						}
						else if (num3 <= 0.75)
						{
							result = -num4 * double.SinForIntervalPiBy4((num3 - 0.5) * 3.141592653589793, 0.0);
						}
						else
						{
							result = -num4 * double.CosForIntervalPiBy4((1.0 - num3) * 3.141592653589793, 0.0);
						}
					}
					else if (num >= 6.103515625E-05)
					{
						result = double.CosForIntervalPiBy4(x * 3.141592653589793, 0.0);
					}
					else if (num >= 7.450580596923828E-09)
					{
						double num5 = x * 3.141592653589793;
						result = 1.0 - num5 * num5 * 0.5;
					}
					else
					{
						result = 1.0;
					}
				}
				else if (num < 9007199254740992.0)
				{
					result = (long.IsOddInteger(BitConverter.DoubleToInt64Bits(num)) ? -1.0 : 1.0);
				}
				else
				{
					result = 1.0;
				}
			}
			else
			{
				result = double.NaN;
			}
			return result;
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0002FCC1 File Offset: 0x0002DEC1
		public static double DegreesToRadians(double degrees)
		{
			return degrees * 3.141592653589793 / 180.0;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0002FCD8 File Offset: 0x0002DED8
		public static double RadiansToDegrees(double radians)
		{
			return radians * 180.0 / 3.141592653589793;
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0002FCEF File Offset: 0x0002DEEF
		[Intrinsic]
		public static double Sin(double x)
		{
			return Math.Sin(x);
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0002FCF7 File Offset: 0x0002DEF7
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<double, double> SinCos(double x)
		{
			return Math.SinCos(x);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0002FD00 File Offset: 0x0002DF00
		[return: TupleElementNames(new string[]
		{
			"SinPi",
			"CosPi"
		})]
		public static ValueTuple<double, double> SinCosPi(double x)
		{
			double item;
			double item2;
			if (double.IsFinite(x))
			{
				double num = double.Abs(x);
				if (num < 4503599627370496.0)
				{
					if (num > 0.25)
					{
						long num2 = (long)num;
						double num3 = num - (double)num2;
						double num4 = long.IsOddInteger(num2) ? -1.0 : 1.0;
						double num5 = ((x > 0.0) ? 1.0 : -1.0) * num4;
						double num6 = num4;
						if (num3 <= 0.25)
						{
							if (num3 != 0.0)
							{
								double x2 = num3 * 3.141592653589793;
								item = num5 * double.SinForIntervalPiBy4(x2, 0.0);
								item2 = num6 * double.CosForIntervalPiBy4(x2, 0.0);
							}
							else
							{
								item = x * 0.0;
								item2 = num6;
							}
						}
						else if (num3 <= 0.5)
						{
							if (num3 != 0.5)
							{
								double x3 = (0.5 - num3) * 3.141592653589793;
								item = num5 * double.CosForIntervalPiBy4(x3, 0.0);
								item2 = num6 * double.SinForIntervalPiBy4(x3, 0.0);
							}
							else
							{
								item = num5;
								item2 = 0.0;
							}
						}
						else if (num3 <= 0.75)
						{
							double x4 = (num3 - 0.5) * 3.141592653589793;
							item = num5 * double.CosForIntervalPiBy4(x4, 0.0);
							item2 = -num6 * double.SinForIntervalPiBy4(x4, 0.0);
						}
						else
						{
							double x5 = (1.0 - num3) * 3.141592653589793;
							item = num5 * double.SinForIntervalPiBy4(x5, 0.0);
							item2 = -num6 * double.CosForIntervalPiBy4(x5, 0.0);
						}
					}
					else if (num >= 0.0001220703125)
					{
						double x6 = x * 3.141592653589793;
						item = double.SinForIntervalPiBy4(x6, 0.0);
						item2 = double.CosForIntervalPiBy4(x6, 0.0);
					}
					else if (num >= 7.450580596923828E-09)
					{
						double num7 = x * 3.141592653589793;
						double num8 = num7 * num7;
						item = num7 - num8 * num7 * 0.16666666666666666;
						item2 = 1.0 - num8 * 0.5;
					}
					else
					{
						item = x * 3.141592653589793;
						item2 = 1.0;
					}
				}
				else if (num < 9007199254740992.0)
				{
					item = x * 0.0;
					item2 = (long.IsOddInteger(BitConverter.DoubleToInt64Bits(num)) ? -1.0 : 1.0);
				}
				else
				{
					item = x * 0.0;
					item2 = 1.0;
				}
			}
			else
			{
				item = double.NaN;
				item2 = double.NaN;
			}
			return new ValueTuple<double, double>(item, item2);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00030014 File Offset: 0x0002E214
		public static double SinPi(double x)
		{
			double result;
			if (double.IsFinite(x))
			{
				double num = double.Abs(x);
				if (num < 4503599627370496.0)
				{
					if (num > 0.25)
					{
						long num2 = (long)num;
						double num3 = num - (double)num2;
						double num4 = ((x > 0.0) ? 1.0 : -1.0) * (long.IsOddInteger(num2) ? -1.0 : 1.0);
						if (num3 <= 0.25)
						{
							if (num3 != 0.0)
							{
								result = num4 * double.SinForIntervalPiBy4(num3 * 3.141592653589793, 0.0);
							}
							else
							{
								result = x * 0.0;
							}
						}
						else if (num3 <= 0.5)
						{
							if (num3 != 0.5)
							{
								result = num4 * double.CosForIntervalPiBy4((0.5 - num3) * 3.141592653589793, 0.0);
							}
							else
							{
								result = num4;
							}
						}
						else if (num3 <= 0.75)
						{
							result = num4 * double.CosForIntervalPiBy4((num3 - 0.5) * 3.141592653589793, 0.0);
						}
						else
						{
							result = num4 * double.SinForIntervalPiBy4((1.0 - num3) * 3.141592653589793, 0.0);
						}
					}
					else if (num >= 0.0001220703125)
					{
						result = double.SinForIntervalPiBy4(x * 3.141592653589793, 0.0);
					}
					else if (num >= 7.450580596923828E-09)
					{
						double num5 = x * 3.141592653589793;
						result = num5 - num5 * num5 * num5 * 0.16666666666666666;
					}
					else
					{
						result = x * 3.141592653589793;
					}
				}
				else
				{
					result = x * 0.0;
				}
			}
			else
			{
				result = double.NaN;
			}
			return result;
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00030210 File Offset: 0x0002E410
		[Intrinsic]
		public static double Tan(double x)
		{
			return Math.Tan(x);
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00030218 File Offset: 0x0002E418
		public static double TanPi(double x)
		{
			double result;
			if (double.IsFinite(x))
			{
				double num = double.Abs(x);
				double num2 = (x > 0.0) ? 1.0 : -1.0;
				if (num < 4503599627370496.0)
				{
					if (num > 0.25)
					{
						long num3 = (long)num;
						double num4 = num - (double)num3;
						if (num4 <= 0.25)
						{
							if (num4 != 0.0)
							{
								result = num2 * double.TanForIntervalPiBy4(num4 * 3.141592653589793, 0.0, false);
							}
							else
							{
								result = num2 * (long.IsOddInteger(num3) ? --0.0 : 0.0);
							}
						}
						else if (num4 <= 0.5)
						{
							if (num4 != 0.5)
							{
								result = -num2 * double.TanForIntervalPiBy4((0.5 - num4) * 3.141592653589793, 0.0, true);
							}
							else
							{
								result = num2 * (long.IsOddInteger(num3) ? double.NegativeInfinity : double.PositiveInfinity);
							}
						}
						else if (num4 <= 0.75)
						{
							result = num2 * double.TanForIntervalPiBy4((num4 - 0.5) * 3.141592653589793, 0.0, true);
						}
						else
						{
							result = -num2 * double.TanForIntervalPiBy4((1.0 - num4) * 3.141592653589793, 0.0, false);
						}
					}
					else if (num >= 6.103515625E-05)
					{
						result = double.TanForIntervalPiBy4(x * 3.141592653589793, 0.0, false);
					}
					else if (num >= 7.450580596923828E-09)
					{
						double num5 = x * 3.141592653589793;
						result = num5 + num5 * num5 * num5 * 0.3333333333333333;
					}
					else
					{
						result = x * 3.141592653589793;
					}
				}
				else if (num < 9007199254740992.0)
				{
					long value = BitConverter.DoubleToInt64Bits(num);
					result = num2 * (long.IsOddInteger(value) ? --0.0 : 0.0);
				}
				else
				{
					result = num2 * 0.0;
				}
			}
			else
			{
				result = double.NaN;
			}
			return result;
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0003046E File Offset: 0x0002E66E
		double IUnaryNegationOperators<double, double>.op_UnaryNegation(double value)
		{
			return -value;
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x000239EA File Offset: 0x00021BEA
		double IUnaryPlusOperators<double, double>.op_UnaryPlus(double value)
		{
			return value;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00030472 File Offset: 0x0002E672
		public static double Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseFloat<byte, double>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00030487 File Offset: 0x0002E687
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out double result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseFloat<byte, double>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0003049D File Offset: 0x0002E69D
		public static double Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return double.Parse(utf8Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider);
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x000304AB File Offset: 0x0002E6AB
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out double result)
		{
			return double.TryParse(utf8Text, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, provider, out result);
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x000304BA File Offset: 0x0002E6BA
		int IBinaryFloatParseAndFormatInfo<double>.NumberBufferLength
		{
			get
			{
				return 769;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x000304C1 File Offset: 0x0002E6C1
		ulong IBinaryFloatParseAndFormatInfo<double>.ZeroBits
		{
			get
			{
				return 0UL;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x000304C5 File Offset: 0x0002E6C5
		ulong IBinaryFloatParseAndFormatInfo<double>.InfinityBits
		{
			get
			{
				return 9218868437227405312UL;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x000304D0 File Offset: 0x0002E6D0
		ulong IBinaryFloatParseAndFormatInfo<double>.NormalMantissaMask
		{
			get
			{
				return 9007199254740991UL;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x000304DB File Offset: 0x0002E6DB
		ulong IBinaryFloatParseAndFormatInfo<double>.DenormalMantissaMask
		{
			get
			{
				return 4503599627370495UL;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000304E6 File Offset: 0x0002E6E6
		int IBinaryFloatParseAndFormatInfo<double>.MinBinaryExponent
		{
			get
			{
				return -1022;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x000304ED File Offset: 0x0002E6ED
		int IBinaryFloatParseAndFormatInfo<double>.MaxBinaryExponent
		{
			get
			{
				return 1023;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000304F4 File Offset: 0x0002E6F4
		int IBinaryFloatParseAndFormatInfo<double>.MinDecimalExponent
		{
			get
			{
				return -324;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x000304FB File Offset: 0x0002E6FB
		int IBinaryFloatParseAndFormatInfo<double>.MaxDecimalExponent
		{
			get
			{
				return 309;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x000304ED File Offset: 0x0002E6ED
		int IBinaryFloatParseAndFormatInfo<double>.ExponentBias
		{
			get
			{
				return 1023;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x00030502 File Offset: 0x0002E702
		ushort IBinaryFloatParseAndFormatInfo<double>.ExponentBits
		{
			get
			{
				return 11;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x00030506 File Offset: 0x0002E706
		int IBinaryFloatParseAndFormatInfo<double>.OverflowDecimalExponent
		{
			get
			{
				return 376;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x0003050D File Offset: 0x0002E70D
		int IBinaryFloatParseAndFormatInfo<double>.InfinityExponent
		{
			get
			{
				return 2047;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		ushort IBinaryFloatParseAndFormatInfo<double>.NormalMantissaBits
		{
			get
			{
				return 53;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x00030514 File Offset: 0x0002E714
		ushort IBinaryFloatParseAndFormatInfo<double>.DenormalMantissaBits
		{
			get
			{
				return 52;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x00030518 File Offset: 0x0002E718
		int IBinaryFloatParseAndFormatInfo<double>.MinFastFloatDecimalExponent
		{
			get
			{
				return -342;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x0003051F File Offset: 0x0002E71F
		int IBinaryFloatParseAndFormatInfo<double>.MaxFastFloatDecimalExponent
		{
			get
			{
				return 308;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x00030526 File Offset: 0x0002E726
		int IBinaryFloatParseAndFormatInfo<double>.MinExponentRoundToEven
		{
			get
			{
				return -4;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0003052A File Offset: 0x0002E72A
		int IBinaryFloatParseAndFormatInfo<double>.MaxExponentRoundToEven
		{
			get
			{
				return 23;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x0003052E File Offset: 0x0002E72E
		int IBinaryFloatParseAndFormatInfo<double>.MaxExponentFastPath
		{
			get
			{
				return 22;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00030532 File Offset: 0x0002E732
		ulong IBinaryFloatParseAndFormatInfo<double>.MaxMantissaFastPath
		{
			get
			{
				return 9007199254740992UL;
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0003053D File Offset: 0x0002E73D
		double IBinaryFloatParseAndFormatInfo<double>.BitsToFloat(ulong bits)
		{
			return BitConverter.UInt64BitsToDouble(bits);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00030545 File Offset: 0x0002E745
		ulong IBinaryFloatParseAndFormatInfo<double>.FloatToBits(double value)
		{
			return BitConverter.DoubleToUInt64Bits(value);
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x0003054D File Offset: 0x0002E74D
		int IBinaryFloatParseAndFormatInfo<double>.MaxRoundTripDigits
		{
			get
			{
				return 17;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x000299CE File Offset: 0x00027BCE
		int IBinaryFloatParseAndFormatInfo<double>.MaxPrecisionCustomFormat
		{
			get
			{
				return 15;
			}
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00030554 File Offset: 0x0002E754
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double CosForIntervalPiBy4(double x, double xTail)
		{
			double num = x * x;
			double num2 = 0.5 * num;
			double num3 = 1.0 - num2;
			return (((((-1.1382639806794487E-11 * num + 2.0876146382232963E-09) * num + -2.755731727234419E-07) * num + 2.480158729876704E-05) * num + -0.0013888888888887398) * num + 0.041666666666666664) * (num * num) + (1.0 - num3 - num2 - x * xTail) + num3;
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x000305DC File Offset: 0x0002E7DC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double SinForIntervalPiBy4(double x, double xTail)
		{
			double num = x * x;
			double num2 = num * x;
			double num3 = 1.5918144304485914E-10;
			num3 = num3 * num + -2.5051132068021698E-08;
			num3 = num3 * num + 2.7557316103728802E-06;
			num3 = num3 * num + -0.00019841269836761127;
			num3 = num3 * num + 0.00833333333333095;
			if (xTail == 0.0)
			{
				num3 = num * num3 + -0.16666666666666666;
				num3 = num2 * num3 + x;
			}
			else
			{
				num3 = x - (num * (0.5 * xTail - num2 * num3) - xTail - num2 * -0.16666666666666666);
			}
			return num3;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00030678 File Offset: 0x0002E878
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double TanForIntervalPiBy4(double x, double xTail, bool isReciprocal)
		{
			int num = 0;
			if (x > 0.68)
			{
				num = 1;
				x = 0.7853981633974483 - x + (3.0616169978683824E-17 - xTail);
				xTail = 0.0;
			}
			else if (x < -0.68)
			{
				num = -1;
				x = 0.7853981633974483 + x + (3.0616169978683824E-17 + xTail);
				xTail = 0.0;
			}
			double num2 = x * x + 2.0 * x * xTail;
			double num3 = -0.00023237149408856356;
			num3 = 0.026065662039864542 + num3 * num2;
			num3 = -0.5156585157290311 + num3 * num2;
			num3 = 1.1171374792793767 + num3 * num2;
			double num4 = 0.0002240444485370221;
			num4 = -0.022934508005756565 + num4 * num2;
			num4 = 0.3723791597597922 + num4 * num2;
			double num5 = x * num2;
			num5 *= num4 / num3;
			num5 += xTail;
			double num6 = x + num5;
			if (num != 0)
			{
				if (isReciprocal)
				{
					num6 = (double)num * (2.0 * num6 / (num6 - 1.0)) - 1.0;
				}
				else
				{
					num6 = (double)num * (1.0 - 2.0 * num6 / (1.0 + num6));
				}
			}
			else if (isReciprocal)
			{
				double num7 = BitConverter.UInt64BitsToDouble(BitConverter.DoubleToUInt64Bits(num6) & 18446744069414584320UL);
				double num8 = num5 - (num7 - x);
				double num9 = -1.0 / num6;
				double num10 = BitConverter.UInt64BitsToDouble(BitConverter.DoubleToUInt64Bits(num9) & 18446744069414584320UL);
				num6 = num10 + num9 * (1.0 + num10 * num7 + num10 * num8);
			}
			return num6;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00030838 File Offset: 0x0002EA38
		[CompilerGenerated]
		internal static double <RootN>g__PositiveN|231_0(double x, int n)
		{
			double num;
			if (double.IsFinite(x))
			{
				if (x != 0.0)
				{
					if (x > 0.0 || double.IsOddInteger((double)n))
					{
						num = double.Pow(double.Abs(x), 1.0 / (double)n);
						num = double.CopySign(num, x);
					}
					else
					{
						num = double.NaN;
					}
				}
				else if (double.IsEvenInteger((double)n))
				{
					num = 0.0;
				}
				else
				{
					num = double.CopySign(0.0, x);
				}
			}
			else if (double.IsNaN(x))
			{
				num = double.NaN;
			}
			else if (x > 0.0)
			{
				num = double.PositiveInfinity;
			}
			else
			{
				num = (int.IsOddInteger(n) ? double.NegativeInfinity : double.NaN);
			}
			return num;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00030910 File Offset: 0x0002EB10
		[CompilerGenerated]
		internal static double <RootN>g__NegativeN|231_1(double x, int n)
		{
			double num;
			if (double.IsFinite(x))
			{
				if (x != 0.0)
				{
					if (x > 0.0 || double.IsOddInteger((double)n))
					{
						num = double.Pow(double.Abs(x), 1.0 / (double)n);
						num = double.CopySign(num, x);
					}
					else
					{
						num = double.NaN;
					}
				}
				else if (double.IsEvenInteger((double)n))
				{
					num = double.PositiveInfinity;
				}
				else
				{
					num = double.CopySign(double.PositiveInfinity, x);
				}
			}
			else if (double.IsNaN(x))
			{
				num = double.NaN;
			}
			else if (x > 0.0)
			{
				num = 0.0;
			}
			else
			{
				num = (int.IsOddInteger(n) ? --0.0 : double.NaN);
			}
			return num;
		}

		// Token: 0x04000394 RID: 916
		private readonly double m_value;

		// Token: 0x04000395 RID: 917
		public const double MinValue = -1.7976931348623157E+308;

		// Token: 0x04000396 RID: 918
		public const double MaxValue = 1.7976931348623157E+308;

		// Token: 0x04000397 RID: 919
		public const double Epsilon = 5E-324;

		// Token: 0x04000398 RID: 920
		public const double NegativeInfinity = double.NegativeInfinity;

		// Token: 0x04000399 RID: 921
		public const double PositiveInfinity = double.PositiveInfinity;

		// Token: 0x0400039A RID: 922
		public const double NaN = double.NaN;

		// Token: 0x0400039B RID: 923
		public const double NegativeZero = --0.0;

		// Token: 0x0400039C RID: 924
		public const double E = 2.718281828459045;

		// Token: 0x0400039D RID: 925
		public const double Pi = 3.141592653589793;

		// Token: 0x0400039E RID: 926
		public const double Tau = 6.283185307179586;
	}
}
