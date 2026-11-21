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
	// Token: 0x0200014C RID: 332
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct Int32 : IComparable, IConvertible, ISpanFormattable, IFormattable, IComparable<int>, IEquatable<int>, IBinaryInteger<int>, IBinaryNumber<int>, IBitwiseOperators<int, int, int>, INumber<int>, IComparisonOperators<int, int, bool>, IEqualityOperators<int, int, bool>, IModulusOperators<int, int, int>, INumberBase<int>, IAdditionOperators<int, int, int>, IAdditiveIdentity<int, int>, IDecrementOperators<int>, IDivisionOperators<int, int, int>, IIncrementOperators<int>, IMultiplicativeIdentity<int, int>, IMultiplyOperators<int, int, int>, ISpanParsable<int>, IParsable<int>, ISubtractionOperators<int, int, int>, IUnaryPlusOperators<int, int>, IUnaryNegationOperators<int, int>, IUtf8SpanFormattable, IUtf8SpanParsable<int>, IShiftOperators<int, int, int>, IMinMaxValue<int>, ISignedNumber<int>, IBinaryIntegerParseAndFormatInfo<int>
	{
		// Token: 0x06001485 RID: 5253 RVA: 0x00040082 File Offset: 0x0003E282
		public static long BigMul(int left, int right)
		{
			return Math.BigMul(left, right);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0004008C File Offset: 0x0003E28C
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is int))
			{
				throw new ArgumentException(SR.Arg_MustBeInt32);
			}
			int num = (int)value;
			if (this < num)
			{
				return -1;
			}
			if (this > num)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x000400C7 File Offset: 0x0003E2C7
		public int CompareTo(int value)
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

		// Token: 0x06001488 RID: 5256 RVA: 0x000400D8 File Offset: 0x0003E2D8
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is int && this == (int)obj;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x000400EE File Offset: 0x0003E2EE
		[NonVersionable]
		public bool Equals(int obj)
		{
			return this == obj;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x000400F5 File Offset: 0x0003E2F5
		public override int GetHashCode()
		{
			return this;
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000400F9 File Offset: 0x0003E2F9
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.Int32ToDecStr(this);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00040102 File Offset: 0x0003E302
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0004010C File Offset: 0x0003E30C
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.FormatInt32(this, 0, null, provider);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00040118 File Offset: 0x0003E318
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatInt32(this, -1, format, provider);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00040124 File Offset: 0x0003E324
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatInt32<char>(this, -1, format, provider, destination, out charsWritten);
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00040133 File Offset: 0x0003E333
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatInt32<byte>(this, -1, format, provider, utf8Destination, out bytesWritten);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00040142 File Offset: 0x0003E342
		[NullableContext(1)]
		public static int Parse(string s)
		{
			return int.Parse(s, NumberStyles.Integer, null);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0004014C File Offset: 0x0003E34C
		[NullableContext(1)]
		public static int Parse(string s, NumberStyles style)
		{
			return int.Parse(s, style, null);
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00040156 File Offset: 0x0003E356
		[NullableContext(1)]
		public static int Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return int.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00040160 File Offset: 0x0003E360
		[NullableContext(1)]
		public static int Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return int.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00040179 File Offset: 0x0003E379
		public static int Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<char, int>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0004018E File Offset: 0x0003E38E
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out int result)
		{
			return int.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00040199 File Offset: 0x0003E399
		public static bool TryParse(ReadOnlySpan<char> s, out int result)
		{
			return int.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x000401A4 File Offset: 0x0003E3A4
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out int result)
		{
			return int.TryParse(utf8Text, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x000401AF File Offset: 0x0003E3AF
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out int result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0;
				return false;
			}
			return Number.TryParseBinaryInteger<char, int>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x000401D5 File Offset: 0x0003E3D5
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out int result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<char, int>(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x000401EE File Offset: 0x0003E3EE
		public TypeCode GetTypeCode()
		{
			return TypeCode.Int32;
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x000401F2 File Offset: 0x0003E3F2
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x000401FB File Offset: 0x0003E3FB
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00040204 File Offset: 0x0003E404
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0004020D File Offset: 0x0003E40D
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00040216 File Offset: 0x0003E416
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0004021F File Offset: 0x0003E41F
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x000400F5 File Offset: 0x0003E2F5
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00040228 File Offset: 0x0003E428
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return Convert.ToUInt32(this);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00040231 File Offset: 0x0003E431
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x0004023A File Offset: 0x0003E43A
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00040243 File Offset: 0x0003E443
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0004024C File Offset: 0x0003E44C
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00040255 File Offset: 0x0003E455
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0004025E File Offset: 0x0003E45E
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "Int32", "DateTime"));
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00040279 File Offset: 0x0003E479
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0002EA29 File Offset: 0x0002CC29
		int IAdditionOperators<int, int, int>.op_Addition(int left, int right)
		{
			return left + right;
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00040289 File Offset: 0x0003E489
		int IAdditionOperators<int, int, int>.op_CheckedAddition(int left, int right)
		{
			return checked(left + right);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x00007B65 File Offset: 0x00005D65
		int IAdditiveIdentity<int, int>.AdditiveIdentity
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0004028E File Offset: 0x0003E48E
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<int, int> DivRem(int left, int right)
		{
			return Math.DivRem(left, right);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00040297 File Offset: 0x0003E497
		[Intrinsic]
		public static int LeadingZeroCount(int value)
		{
			return BitOperations.LeadingZeroCount((uint)value);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0004029F File Offset: 0x0003E49F
		[Intrinsic]
		public static int PopCount(int value)
		{
			return BitOperations.PopCount((uint)value);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x000402A7 File Offset: 0x0003E4A7
		[Intrinsic]
		public static int RotateLeft(int value, int rotateAmount)
		{
			return (int)BitOperations.RotateLeft((uint)value, rotateAmount);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x000402B0 File Offset: 0x0003E4B0
		[Intrinsic]
		public static int RotateRight(int value, int rotateAmount)
		{
			return (int)BitOperations.RotateRight((uint)value, rotateAmount);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x000402B9 File Offset: 0x0003E4B9
		[Intrinsic]
		public static int TrailingZeroCount(int value)
		{
			return BitOperations.TrailingZeroCount(value);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x000402C4 File Offset: 0x0003E4C4
		unsafe bool IBinaryInteger<int>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out int value)
		{
			int num = 0;
			if (source.Length != 0)
			{
				sbyte b = (sbyte)(*source[0]);
				b = (sbyte)(b >> 31);
				isUnsigned |= (b == 0);
				if (isUnsigned && sbyte.IsNegative(b) && source.Length >= 4)
				{
					value = num;
					return false;
				}
				if (source.Length > 4)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 4).ContainsAnyExcept((byte)b))
					{
						value = num;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[source.Length - 4])))
					{
						value = num;
						return false;
					}
				}
				ref byte source2 = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 4)
				{
					source2 = Unsafe.Add<byte>(ref source2, source.Length - 4);
					num = Unsafe.ReadUnaligned<int>(ref source2);
					bool isLittleEndian = BitConverter.IsLittleEndian;
					num = BinaryPrimitives.ReverseEndianness(num);
				}
				else
				{
					for (int i = 0; i < source.Length; i++)
					{
						num <<= 8;
						num |= (int)(*Unsafe.Add<byte>(ref source2, i));
					}
					if (!isUnsigned)
					{
						num |= -2147483648 >> (4 - source.Length) * 8 - 1;
					}
				}
			}
			value = num;
			return true;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000403D8 File Offset: 0x0003E5D8
		unsafe bool IBinaryInteger<int>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out int value)
		{
			int num = 0;
			if (source.Length != 0)
			{
				sbyte b = (sbyte)(*source[source.Length - 1]);
				b = (sbyte)(b >> 31);
				isUnsigned |= (b == 0);
				if (isUnsigned && sbyte.IsNegative(b) && source.Length >= 4)
				{
					value = num;
					return false;
				}
				if (source.Length > 4)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(4, ptr.Length - 4).ContainsAnyExcept((byte)b))
					{
						value = num;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[3])))
					{
						value = num;
						return false;
					}
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 4)
				{
					num = Unsafe.ReadUnaligned<int>(ref reference);
					if (BitConverter.IsLittleEndian)
					{
						goto IL_102;
					}
				}
				for (int i = 0; i < source.Length; i++)
				{
					num <<= 8;
					num |= (int)(*Unsafe.Add<byte>(ref reference, i));
				}
				num <<= (4 - source.Length) * 8;
				num = BinaryPrimitives.ReverseEndianness(num);
				if (!isUnsigned)
				{
					num |= -2147483648 >> (4 - source.Length) * 8 - 1;
				}
			}
			IL_102:
			value = num;
			return true;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x000404EC File Offset: 0x0003E6EC
		int IBinaryInteger<int>.GetShortestBitLength()
		{
			int num = this;
			if (num >= 0)
			{
				return 32 - int.LeadingZeroCount(num);
			}
			return 33 - int.LeadingZeroCount(~num);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x000211FB File Offset: 0x0001F3FB
		int IBinaryInteger<int>.GetByteCount()
		{
			return 4;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00040514 File Offset: 0x0003E714
		bool IBinaryInteger<int>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 4)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				int value = BinaryPrimitives.ReverseEndianness(this);
				Unsafe.WriteUnaligned<int>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 4;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00040550 File Offset: 0x0003E750
		bool IBinaryInteger<int>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 4)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				int value = this;
				Unsafe.WriteUnaligned<int>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 4;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0003F19A File Offset: 0x0003D39A
		int IBinaryNumber<int>.AllBitsSet
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0003F19D File Offset: 0x0003D39D
		public static bool IsPow2(int value)
		{
			return BitOperations.IsPow2(value);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00040586 File Offset: 0x0003E786
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Log2(int value)
		{
			if (value < 0)
			{
				ThrowHelper.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
			}
			return BitOperations.Log2((uint)value);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00040597 File Offset: 0x0003E797
		int IBitwiseOperators<int, int, int>.op_BitwiseAnd(int left, int right)
		{
			return left & right;
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0004059C File Offset: 0x0003E79C
		int IBitwiseOperators<int, int, int>.op_BitwiseOr(int left, int right)
		{
			return left | right;
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x000405A1 File Offset: 0x0003E7A1
		int IBitwiseOperators<int, int, int>.op_ExclusiveOr(int left, int right)
		{
			return left ^ right;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x000405A6 File Offset: 0x0003E7A6
		int IBitwiseOperators<int, int, int>.op_OnesComplement(int value)
		{
			return ~value;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00020126 File Offset: 0x0001E326
		bool IComparisonOperators<int, int, bool>.op_LessThan(int left, int right)
		{
			return left < right;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0002012C File Offset: 0x0001E32C
		bool IComparisonOperators<int, int, bool>.op_LessThanOrEqual(int left, int right)
		{
			return left <= right;
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00020135 File Offset: 0x0001E335
		bool IComparisonOperators<int, int, bool>.op_GreaterThan(int left, int right)
		{
			return left > right;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0002013B File Offset: 0x0001E33B
		bool IComparisonOperators<int, int, bool>.op_GreaterThanOrEqual(int left, int right)
		{
			return left >= right;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x000405AA File Offset: 0x0003E7AA
		int IDecrementOperators<int>.op_Decrement(int value)
		{
			return --value;
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x000405B2 File Offset: 0x0003E7B2
		int IDecrementOperators<int>.op_CheckedDecrement(int value)
		{
			return checked(--value);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0002EAEC File Offset: 0x0002CCEC
		int IDivisionOperators<int, int, int>.op_Division(int left, int right)
		{
			return left / right;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0000FF2A File Offset: 0x0000E12A
		bool IEqualityOperators<int, int, bool>.op_Equality(int left, int right)
		{
			return left == right;
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0001306A File Offset: 0x0001126A
		bool IEqualityOperators<int, int, bool>.op_Inequality(int left, int right)
		{
			return left != right;
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000405BA File Offset: 0x0003E7BA
		int IIncrementOperators<int>.op_Increment(int value)
		{
			return ++value;
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000405C2 File Offset: 0x0003E7C2
		int IIncrementOperators<int>.op_CheckedIncrement(int value)
		{
			return checked(++value);
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x000405CA File Offset: 0x0003E7CA
		int IMinMaxValue<int>.MinValue
		{
			get
			{
				return -2147483648;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x000405D1 File Offset: 0x0003E7D1
		int IMinMaxValue<int>.MaxValue
		{
			get
			{
				return 2147483647;
			}
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0002EE4D File Offset: 0x0002D04D
		int IModulusOperators<int, int, int>.op_Modulus(int left, int right)
		{
			return left % right;
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x000070DD File Offset: 0x000052DD
		int IMultiplicativeIdentity<int, int>.MultiplicativeIdentity
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0002EE5D File Offset: 0x0002D05D
		int IMultiplyOperators<int, int, int>.op_Multiply(int left, int right)
		{
			return left * right;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000405D8 File Offset: 0x0003E7D8
		int IMultiplyOperators<int, int, int>.op_CheckedMultiply(int left, int right)
		{
			return checked(left * right);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x000405DD File Offset: 0x0003E7DD
		public static int Clamp(int value, int min, int max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000405E8 File Offset: 0x0003E7E8
		public static int CopySign(int value, int sign)
		{
			int num = value;
			if (num < 0)
			{
				num = -num;
			}
			if (sign >= 0)
			{
				if (num < 0)
				{
					Math.ThrowNegateTwosCompOverflow();
				}
				return num;
			}
			return -num;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0004060F File Offset: 0x0003E80F
		public static int Max(int x, int y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00040618 File Offset: 0x0003E818
		int INumber<int>.MaxNumber(int x, int y)
		{
			return int.Max(x, y);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00040621 File Offset: 0x0003E821
		public static int Min(int x, int y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0004062A File Offset: 0x0003E82A
		int INumber<int>.MinNumber(int x, int y)
		{
			return int.Min(x, y);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000108A5 File Offset: 0x0000EAA5
		public static int Sign(int value)
		{
			return Math.Sign(value);
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x000070DD File Offset: 0x000052DD
		int INumberBase<int>.One
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<int>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00007B65 File Offset: 0x00005D65
		int INumberBase<int>.Zero
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00040633 File Offset: 0x0003E833
		public static int Abs(int value)
		{
			return Math.Abs(value);
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0004063C File Offset: 0x0003E83C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			int result;
			if (typeof(TOther) == typeof(int))
			{
				result = (int)((object)value);
			}
			else if (!int.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<int>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00040694 File Offset: 0x0003E894
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			int result;
			if (typeof(TOther) == typeof(int))
			{
				result = (int)((object)value);
			}
			else if (!int.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<int>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x000406EC File Offset: 0x0003E8EC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			int result;
			if (typeof(TOther) == typeof(int))
			{
				result = (int)((object)value);
			}
			else if (!int.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<int>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<int>.IsCanonical(int value)
		{
			return true;
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<int>.IsComplexNumber(int value)
		{
			return false;
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x000202BE File Offset: 0x0001E4BE
		public static bool IsEvenInteger(int value)
		{
			return (value & 1) == 0;
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<int>.IsFinite(int value)
		{
			return true;
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<int>.IsImaginaryNumber(int value)
		{
			return false;
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<int>.IsInfinity(int value)
		{
			return false;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<int>.IsInteger(int value)
		{
			return true;
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<int>.IsNaN(int value)
		{
			return false;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0003F38A File Offset: 0x0003D58A
		public static bool IsNegative(int value)
		{
			return value < 0;
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<int>.IsNegativeInfinity(int value)
		{
			return false;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x000201AE File Offset: 0x0001E3AE
		bool INumberBase<int>.IsNormal(int value)
		{
			return value != 0;
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x000202C6 File Offset: 0x0001E4C6
		public static bool IsOddInteger(int value)
		{
			return (value & 1) != 0;
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00004FFE File Offset: 0x000031FE
		public static bool IsPositive(int value)
		{
			return value >= 0;
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<int>.IsPositiveInfinity(int value)
		{
			return false;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<int>.IsRealNumber(int value)
		{
			return true;
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<int>.IsSubnormal(int value)
		{
			return false;
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x000202CE File Offset: 0x0001E4CE
		bool INumberBase<int>.IsZero(int value)
		{
			return value == 0;
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00040744 File Offset: 0x0003E944
		public static int MaxMagnitude(int x, int y)
		{
			int num = x;
			if (num < 0)
			{
				num = -num;
				if (num < 0)
				{
					return x;
				}
			}
			int num2 = y;
			if (num2 < 0)
			{
				num2 = -num2;
				if (num2 < 0)
				{
					return y;
				}
			}
			if (num > num2)
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!int.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00040786 File Offset: 0x0003E986
		int INumberBase<int>.MaxMagnitudeNumber(int x, int y)
		{
			return int.MaxMagnitude(x, y);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00040790 File Offset: 0x0003E990
		public static int MinMagnitude(int x, int y)
		{
			int num = x;
			if (num < 0)
			{
				num = -num;
				if (num < 0)
				{
					return y;
				}
			}
			int num2 = y;
			if (num2 < 0)
			{
				num2 = -num2;
				if (num2 < 0)
				{
					return x;
				}
			}
			if (num < num2)
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!int.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000407D2 File Offset: 0x0003E9D2
		int INumberBase<int>.MinMagnitudeNumber(int x, int y)
		{
			return int.MinMagnitude(x, y);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0002F0EE File Offset: 0x0002D2EE
		int INumberBase<int>.MultiplyAddEstimate(int left, int right, int addend)
		{
			return left * right + addend;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000407DB File Offset: 0x0003E9DB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<int>.TryConvertFromChecked<TOther>(TOther value, out int result) where TOther : INumberBase<TOther>
		{
			return int.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000407E4 File Offset: 0x0003E9E4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out int result) where TOther : INumberBase<TOther>
		{
			checked
			{
				if (typeof(TOther) == typeof(double))
				{
					double num = (double)((object)value);
					result = (int)num;
					return true;
				}
				if (typeof(TOther) == typeof(Half))
				{
					Half value2 = (Half)((object)value);
					result = Half.op_CheckedExplicit(value2);
					return true;
				}
				if (typeof(TOther) == typeof(short))
				{
					short num2 = (short)((object)value);
					result = (int)num2;
					return true;
				}
				if (typeof(TOther) == typeof(long))
				{
					long num3 = (long)((object)value);
					result = (int)num3;
					return true;
				}
				if (typeof(TOther) == typeof(Int128))
				{
					Int128 value3 = (Int128)((object)value);
					result = Int128.op_CheckedExplicit(value3);
					return true;
				}
				if (typeof(TOther) == typeof(IntPtr))
				{
					IntPtr intPtr = (IntPtr)((object)value);
					result = (int)intPtr;
					return true;
				}
				if (typeof(TOther) == typeof(sbyte))
				{
					sbyte b = (sbyte)((object)value);
					result = (int)b;
					return true;
				}
				if (typeof(TOther) == typeof(float))
				{
					float num4 = (float)((object)value);
					result = (int)num4;
					return true;
				}
				result = 0;
				return false;
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0004096B File Offset: 0x0003EB6B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<int>.TryConvertFromSaturating<TOther>(TOther value, out int result) where TOther : INumberBase<TOther>
		{
			return int.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00040974 File Offset: 0x0003EB74
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out int result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 2147483647.0) ? 2147483647 : ((num <= -2147483648.0) ? -2147483648 : ((int)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half == Half.PositiveInfinity) ? 2147483647 : ((half == Half.NegativeInfinity) ? -2147483648 : ((int)half)));
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)((object)value);
				result = (int)num2;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num3 = (long)((object)value);
				result = ((num3 >= 2147483647L) ? 2147483647 : ((num3 <= -2147483648L) ? -2147483648 : ((int)num3)));
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = (Int128)((object)value);
				result = ((@int >= 2147483647) ? 2147483647 : ((@int <= -2147483648) ? -2147483648 : ((int)@int)));
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				result = ((intPtr >= (IntPtr)2147483647) ? 2147483647 : ((intPtr <= (IntPtr)(-2147483648)) ? -2147483648 : ((int)intPtr)));
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (int)b;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num4 = (float)((object)value);
				result = ((num4 >= 2.1474836E+09f) ? 2147483647 : ((num4 <= -2.1474836E+09f) ? -2147483648 : ((int)num4)));
				return true;
			}
			result = 0;
			return false;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00040BDF File Offset: 0x0003EDDF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<int>.TryConvertFromTruncating<TOther>(TOther value, out int result) where TOther : INumberBase<TOther>
		{
			return int.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00040BE8 File Offset: 0x0003EDE8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out int result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 2147483647.0) ? 2147483647 : ((num <= -2147483648.0) ? -2147483648 : ((int)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half == Half.PositiveInfinity) ? 2147483647 : ((half == Half.NegativeInfinity) ? -2147483648 : ((int)half)));
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)((object)value);
				result = (int)num2;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num3 = (long)((object)value);
				result = (int)num3;
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 value2 = (Int128)((object)value);
				result = (int)value2;
				return true;
			}
			if (typeof(TOther) == typeof(IntPtr))
			{
				IntPtr intPtr = (IntPtr)((object)value);
				result = (int)intPtr;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (int)b;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num4 = (float)((object)value);
				result = ((num4 >= 2.1474836E+09f) ? 2147483647 : ((num4 <= -2.1474836E+09f) ? -2147483648 : ((int)num4)));
				return true;
			}
			result = 0;
			return false;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00040DE0 File Offset: 0x0003EFE0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<int>.TryConvertToChecked<TOther>(int value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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
					decimal num = value;
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

		// Token: 0x060014FD RID: 5373 RVA: 0x00040F90 File Offset: 0x0003F190
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<int>.TryConvertToSaturating<TOther>(int value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (value >= 255) ? byte.MaxValue : ((value <= 0) ? 0 : ((byte)value));
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (value >= 65535) ? char.MaxValue : ((value <= 0) ? '\0' : ((char)value));
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (value >= 65535) ? ushort.MaxValue : ((value <= 0) ? 0 : ((ushort)value));
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)((value <= 0) ? 0 : value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (ulong)((value <= 0) ? 0L : ((long)value));
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
				UIntPtr uintPtr = (UIntPtr)((value <= 0) ? ((IntPtr)0) : ((IntPtr)value));
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x000411A0 File Offset: 0x0003F3A0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<int>.TryConvertToTruncating<TOther>(int value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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
				decimal num = value;
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
				result = (TOther)((object)((uint)value));
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num3 = (ulong)((long)value);
				result = (TOther)((object)num3);
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
				UIntPtr uintPtr = (UIntPtr)((IntPtr)value);
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0004134C File Offset: 0x0003F54C
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out int result)
		{
			return int.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00041357 File Offset: 0x0003F557
		int IShiftOperators<int, int, int>.op_LeftShift(int value, int shiftAmount)
		{
			return value << shiftAmount;
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0004135F File Offset: 0x0003F55F
		int IShiftOperators<int, int, int>.op_RightShift(int value, int shiftAmount)
		{
			return value >> shiftAmount;
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00041367 File Offset: 0x0003F567
		int IShiftOperators<int, int, int>.op_UnsignedRightShift(int value, int shiftAmount)
		{
			return (int)((uint)value >> shiftAmount);
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x0003F19A File Offset: 0x0003D39A
		int ISignedNumber<int>.NegativeOne
		{
			get
			{
				return -1;
			}
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0004136F File Offset: 0x0003F56F
		public static int Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return int.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00041379 File Offset: 0x0003F579
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out int result)
		{
			return int.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x0002FA55 File Offset: 0x0002DC55
		int ISubtractionOperators<int, int, int>.op_Subtraction(int left, int right)
		{
			return left - right;
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00041384 File Offset: 0x0003F584
		int ISubtractionOperators<int, int, int>.op_CheckedSubtraction(int left, int right)
		{
			return checked(left - right);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0003046E File Offset: 0x0002E66E
		int IUnaryNegationOperators<int, int>.op_UnaryNegation(int value)
		{
			return -value;
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00041389 File Offset: 0x0003F589
		int IUnaryNegationOperators<int, int>.op_CheckedUnaryNegation(int value)
		{
			return checked(0 - value);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00007B62 File Offset: 0x00005D62
		int IUnaryPlusOperators<int, int>.op_UnaryPlus(int value)
		{
			return value;
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0004138E File Offset: 0x0003F58E
		public static int Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<byte, int>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000413A3 File Offset: 0x0003F5A3
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out int result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<byte, int>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x000413BC File Offset: 0x0003F5BC
		public static int Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return int.Parse(utf8Text, NumberStyles.Integer, provider);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000413C6 File Offset: 0x0003F5C6
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out int result)
		{
			return int.TryParse(utf8Text, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x000070DD File Offset: 0x000052DD
		bool IBinaryIntegerParseAndFormatInfo<int>.IsSigned
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x00029CD6 File Offset: 0x00027ED6
		int IBinaryIntegerParseAndFormatInfo<int>.MaxDigitCount
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		int IBinaryIntegerParseAndFormatInfo<int>.MaxHexDigitCount
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x000413D1 File Offset: 0x0003F5D1
		int IBinaryIntegerParseAndFormatInfo<int>.MaxValueDiv10
		{
			get
			{
				return 214748364;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x000413D8 File Offset: 0x0003F5D8
		[Nullable(1)]
		string IBinaryIntegerParseAndFormatInfo<int>.OverflowMessage
		{
			get
			{
				return SR.Overflow_Int32;
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000413DF File Offset: 0x0003F5DF
		bool IBinaryIntegerParseAndFormatInfo<int>.IsGreaterThanAsUnsigned(int left, int right)
		{
			return left > right;
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000413E5 File Offset: 0x0003F5E5
		int IBinaryIntegerParseAndFormatInfo<int>.MultiplyBy10(int value)
		{
			return value * 10;
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x000413EB File Offset: 0x0003F5EB
		int IBinaryIntegerParseAndFormatInfo<int>.MultiplyBy16(int value)
		{
			return value * 16;
		}

		// Token: 0x040004BF RID: 1215
		private readonly int m_value;

		// Token: 0x040004C0 RID: 1216
		public const int MaxValue = 2147483647;

		// Token: 0x040004C1 RID: 1217
		public const int MinValue = -2147483648;
	}
}
