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
	// Token: 0x020001E8 RID: 488
	[CLSCompliant(false)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct UInt32 : IComparable, IConvertible, ISpanFormattable, IFormattable, IComparable<uint>, IEquatable<uint>, IBinaryInteger<uint>, IBinaryNumber<uint>, IBitwiseOperators<uint, uint, uint>, INumber<uint>, IComparisonOperators<uint, uint, bool>, IEqualityOperators<uint, uint, bool>, IModulusOperators<uint, uint, uint>, INumberBase<uint>, IAdditionOperators<uint, uint, uint>, IAdditiveIdentity<uint, uint>, IDecrementOperators<uint>, IDivisionOperators<uint, uint, uint>, IIncrementOperators<uint>, IMultiplicativeIdentity<uint, uint>, IMultiplyOperators<uint, uint, uint>, ISpanParsable<uint>, IParsable<uint>, ISubtractionOperators<uint, uint, uint>, IUnaryPlusOperators<uint, uint>, IUnaryNegationOperators<uint, uint>, IUtf8SpanFormattable, IUtf8SpanParsable<uint>, IShiftOperators<uint, int, uint>, IMinMaxValue<uint>, IUnsignedNumber<uint>, IBinaryIntegerParseAndFormatInfo<uint>
	{
		// Token: 0x0600253C RID: 9532 RVA: 0x00072E2D File Offset: 0x0007102D
		public static ulong BigMul(uint left, uint right)
		{
			return Math.BigMul(left, right);
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00072E38 File Offset: 0x00071038
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value == null)
			{
				return 1;
			}
			if (!(value is uint))
			{
				throw new ArgumentException(SR.Arg_MustBeUInt32);
			}
			uint num = (uint)value;
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

		// Token: 0x0600253E RID: 9534 RVA: 0x00072E73 File Offset: 0x00071073
		public int CompareTo(uint value)
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

		// Token: 0x0600253F RID: 9535 RVA: 0x00072E84 File Offset: 0x00071084
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is uint && this == (uint)obj;
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00072E9A File Offset: 0x0007109A
		[NonVersionable]
		public bool Equals(uint obj)
		{
			return this == obj;
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00072EA1 File Offset: 0x000710A1
		public override int GetHashCode()
		{
			return (int)this;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00072EA5 File Offset: 0x000710A5
		[NullableContext(1)]
		public override string ToString()
		{
			return Number.UInt32ToDecStr(this);
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x00072EA5 File Offset: 0x000710A5
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return Number.UInt32ToDecStr(this);
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x00072EAE File Offset: 0x000710AE
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return Number.FormatUInt32(this, format, null);
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x00072EB9 File Offset: 0x000710B9
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return Number.FormatUInt32(this, format, provider);
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00072EC4 File Offset: 0x000710C4
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatUInt32<char>(this, format, provider, destination, out charsWritten);
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00072ED2 File Offset: 0x000710D2
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return Number.TryFormatUInt32<byte>(this, format, provider, utf8Destination, out bytesWritten);
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00072EE0 File Offset: 0x000710E0
		[NullableContext(1)]
		public static uint Parse(string s)
		{
			return uint.Parse(s, NumberStyles.Integer, null);
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x00072EEA File Offset: 0x000710EA
		[NullableContext(1)]
		public static uint Parse(string s, NumberStyles style)
		{
			return uint.Parse(s, style, null);
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00072EF4 File Offset: 0x000710F4
		[NullableContext(1)]
		public static uint Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return uint.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00072EFE File Offset: 0x000710FE
		[NullableContext(1)]
		public static uint Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			if (s == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.s);
			}
			return uint.Parse(s.AsSpan(), style, provider);
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00072F17 File Offset: 0x00071117
		public static uint Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<char, uint>(s, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00072F2C File Offset: 0x0007112C
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out uint result)
		{
			return uint.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00072F37 File Offset: 0x00071137
		public static bool TryParse(ReadOnlySpan<char> s, out uint result)
		{
			return uint.TryParse(s, NumberStyles.Integer, null, out result);
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00072F42 File Offset: 0x00071142
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out uint result)
		{
			return uint.TryParse(utf8Text, NumberStyles.Integer, null, out result);
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00072F4D File Offset: 0x0007114D
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out uint result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			if (s == null)
			{
				result = 0U;
				return false;
			}
			return Number.TryParseBinaryInteger<char, uint>(s.AsSpan(), style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x00072F73 File Offset: 0x00071173
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out uint result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<char, uint>(s, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00029CD6 File Offset: 0x00027ED6
		public TypeCode GetTypeCode()
		{
			return TypeCode.UInt32;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x00072F8C File Offset: 0x0007118C
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return Convert.ToBoolean(this);
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00072F95 File Offset: 0x00071195
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return Convert.ToChar(this);
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00072F9E File Offset: 0x0007119E
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return Convert.ToSByte(this);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00072FA7 File Offset: 0x000711A7
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return Convert.ToByte(this);
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00072FB0 File Offset: 0x000711B0
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return Convert.ToInt16(this);
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00072FB9 File Offset: 0x000711B9
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return Convert.ToUInt16(this);
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00072FC2 File Offset: 0x000711C2
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return Convert.ToInt32(this);
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00072EA1 File Offset: 0x000710A1
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return this;
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00072FCB File Offset: 0x000711CB
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return Convert.ToInt64(this);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00072FD4 File Offset: 0x000711D4
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return Convert.ToUInt64(this);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00072FDD File Offset: 0x000711DD
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return Convert.ToSingle(this);
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00072FE6 File Offset: 0x000711E6
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return Convert.ToDouble(this);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00072FEF File Offset: 0x000711EF
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return Convert.ToDecimal(this);
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00072FF8 File Offset: 0x000711F8
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			throw new InvalidCastException(SR.Format(SR.InvalidCast_FromTo, "UInt32", "DateTime"));
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00073013 File Offset: 0x00071213
		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return Convert.DefaultToType(this, type, provider);
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x0002EA29 File Offset: 0x0002CC29
		uint IAdditionOperators<uint, uint, uint>.op_Addition(uint left, uint right)
		{
			return left + right;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00073023 File Offset: 0x00071223
		uint IAdditionOperators<uint, uint, uint>.op_CheckedAddition(uint left, uint right)
		{
			return checked(left + right);
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x00007B65 File Offset: 0x00005D65
		uint IAdditiveIdentity<uint, uint>.AdditiveIdentity
		{
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00073028 File Offset: 0x00071228
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<uint, uint> DivRem(uint left, uint right)
		{
			return Math.DivRem(left, right);
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00040297 File Offset: 0x0003E497
		[Intrinsic]
		public static uint LeadingZeroCount(uint value)
		{
			return (uint)BitOperations.LeadingZeroCount(value);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x0004029F File Offset: 0x0003E49F
		[Intrinsic]
		public static uint PopCount(uint value)
		{
			return (uint)BitOperations.PopCount(value);
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x000402A7 File Offset: 0x0003E4A7
		[Intrinsic]
		public static uint RotateLeft(uint value, int rotateAmount)
		{
			return BitOperations.RotateLeft(value, rotateAmount);
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x000402B0 File Offset: 0x0003E4B0
		[Intrinsic]
		public static uint RotateRight(uint value, int rotateAmount)
		{
			return BitOperations.RotateRight(value, rotateAmount);
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00073031 File Offset: 0x00071231
		[Intrinsic]
		public static uint TrailingZeroCount(uint value)
		{
			return (uint)BitOperations.TrailingZeroCount(value);
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x0007303C File Offset: 0x0007123C
		unsafe bool IBinaryInteger<uint>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out uint value)
		{
			uint num = 0U;
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[0])))
				{
					value = num;
					return false;
				}
				if (source.Length > 4)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 4).ContainsAnyExcept(0))
					{
						value = num;
						return false;
					}
				}
				ref byte source2 = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 4)
				{
					source2 = Unsafe.Add<byte>(ref source2, source.Length - 4);
					num = Unsafe.ReadUnaligned<uint>(ref source2);
					bool isLittleEndian = BitConverter.IsLittleEndian;
					num = BinaryPrimitives.ReverseEndianness(num);
				}
				else
				{
					for (int i = 0; i < source.Length; i++)
					{
						num <<= 8;
						num |= (uint)(*Unsafe.Add<byte>(ref source2, i));
					}
				}
			}
			value = num;
			return true;
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x000730F8 File Offset: 0x000712F8
		unsafe bool IBinaryInteger<uint>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out uint value)
		{
			uint num = 0U;
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[source.Length - 1])))
				{
					value = num;
					return false;
				}
				if (source.Length > 4)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(4, ptr.Length - 4).ContainsAnyExcept(0))
					{
						value = num;
						return false;
					}
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 4)
				{
					num = Unsafe.ReadUnaligned<uint>(ref reference);
					if (BitConverter.IsLittleEndian)
					{
						goto IL_A2;
					}
				}
				for (int i = 0; i < source.Length; i++)
				{
					uint num2 = (uint)(*Unsafe.Add<byte>(ref reference, i));
					num2 <<= i * 8;
					num |= num2;
				}
			}
			IL_A2:
			value = num;
			return true;
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x000731AB File Offset: 0x000713AB
		int IBinaryInteger<uint>.GetShortestBitLength()
		{
			return 32 - BitOperations.LeadingZeroCount(this);
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x000211FB File Offset: 0x0001F3FB
		int IBinaryInteger<uint>.GetByteCount()
		{
			return 4;
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x000731B8 File Offset: 0x000713B8
		bool IBinaryInteger<uint>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 4)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				uint value = BinaryPrimitives.ReverseEndianness(this);
				Unsafe.WriteUnaligned<uint>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 4;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x000731F4 File Offset: 0x000713F4
		bool IBinaryInteger<uint>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 4)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				uint value = this;
				Unsafe.WriteUnaligned<uint>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 4;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x0003F19A File Offset: 0x0003D39A
		uint IBinaryNumber<uint>.AllBitsSet
		{
			get
			{
				return 4294967295U;
			}
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x000200FE File Offset: 0x0001E2FE
		public static bool IsPow2(uint value)
		{
			return BitOperations.IsPow2(value);
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x0007322A File Offset: 0x0007142A
		[Intrinsic]
		public static uint Log2(uint value)
		{
			return (uint)BitOperations.Log2(value);
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00040597 File Offset: 0x0003E797
		uint IBitwiseOperators<uint, uint, uint>.op_BitwiseAnd(uint left, uint right)
		{
			return left & right;
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x0004059C File Offset: 0x0003E79C
		uint IBitwiseOperators<uint, uint, uint>.op_BitwiseOr(uint left, uint right)
		{
			return left | right;
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x000405A1 File Offset: 0x0003E7A1
		uint IBitwiseOperators<uint, uint, uint>.op_ExclusiveOr(uint left, uint right)
		{
			return left ^ right;
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x000405A6 File Offset: 0x0003E7A6
		uint IBitwiseOperators<uint, uint, uint>.op_OnesComplement(uint value)
		{
			return ~value;
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x00073232 File Offset: 0x00071432
		bool IComparisonOperators<uint, uint, bool>.op_LessThan(uint left, uint right)
		{
			return left < right;
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x0002E7F1 File Offset: 0x0002C9F1
		bool IComparisonOperators<uint, uint, bool>.op_LessThanOrEqual(uint left, uint right)
		{
			return left <= right;
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000413DF File Offset: 0x0003F5DF
		bool IComparisonOperators<uint, uint, bool>.op_GreaterThan(uint left, uint right)
		{
			return left > right;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x0002E7FA File Offset: 0x0002C9FA
		bool IComparisonOperators<uint, uint, bool>.op_GreaterThanOrEqual(uint left, uint right)
		{
			return left >= right;
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x000405AA File Offset: 0x0003E7AA
		uint IDecrementOperators<uint>.op_Decrement(uint value)
		{
			return value -= 1U;
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x00073238 File Offset: 0x00071438
		uint IDecrementOperators<uint>.op_CheckedDecrement(uint value)
		{
			return checked(value -= 1U);
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x00073240 File Offset: 0x00071440
		uint IDivisionOperators<uint, uint, uint>.op_Division(uint left, uint right)
		{
			return left / right;
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x0000FF2A File Offset: 0x0000E12A
		bool IEqualityOperators<uint, uint, bool>.op_Equality(uint left, uint right)
		{
			return left == right;
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x0001306A File Offset: 0x0001126A
		bool IEqualityOperators<uint, uint, bool>.op_Inequality(uint left, uint right)
		{
			return left != right;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000405BA File Offset: 0x0003E7BA
		uint IIncrementOperators<uint>.op_Increment(uint value)
		{
			return value += 1U;
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x00073245 File Offset: 0x00071445
		uint IIncrementOperators<uint>.op_CheckedIncrement(uint value)
		{
			return checked(value += 1U);
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x00007B65 File Offset: 0x00005D65
		uint IMinMaxValue<uint>.MinValue
		{
			get
			{
				return 0U;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x0003F19A File Offset: 0x0003D39A
		uint IMinMaxValue<uint>.MaxValue
		{
			get
			{
				return 4294967295U;
			}
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x0007324D File Offset: 0x0007144D
		uint IModulusOperators<uint, uint, uint>.op_Modulus(uint left, uint right)
		{
			return left % right;
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x000070DD File Offset: 0x000052DD
		uint IMultiplicativeIdentity<uint, uint>.MultiplicativeIdentity
		{
			get
			{
				return 1U;
			}
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x0002EE5D File Offset: 0x0002D05D
		uint IMultiplyOperators<uint, uint, uint>.op_Multiply(uint left, uint right)
		{
			return left * right;
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x00073252 File Offset: 0x00071452
		uint IMultiplyOperators<uint, uint, uint>.op_CheckedMultiply(uint left, uint right)
		{
			return checked(left * right);
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00073257 File Offset: 0x00071457
		public static uint Clamp(uint value, uint min, uint max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00007B62 File Offset: 0x00005D62
		uint INumber<uint>.CopySign(uint value, uint sign)
		{
			return value;
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x00073261 File Offset: 0x00071461
		public static uint Max(uint x, uint y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x0600258C RID: 9612 RVA: 0x0007326A File Offset: 0x0007146A
		uint INumber<uint>.MaxNumber(uint x, uint y)
		{
			return uint.Max(x, y);
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00073273 File Offset: 0x00071473
		public static uint Min(uint x, uint y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x0007327C File Offset: 0x0007147C
		uint INumber<uint>.MinNumber(uint x, uint y)
		{
			return uint.Min(x, y);
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x000201AE File Offset: 0x0001E3AE
		public static int Sign(uint value)
		{
			return (value > 0U) ? 1 : 0;
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x000070DD File Offset: 0x000052DD
		uint INumberBase<uint>.One
		{
			get
			{
				return 1U;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<uint>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x00007B65 File Offset: 0x00005D65
		uint INumberBase<uint>.Zero
		{
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x00007B62 File Offset: 0x00005D62
		uint INumberBase<uint>.Abs(uint value)
		{
			return value;
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00073288 File Offset: 0x00071488
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			uint result;
			if (typeof(TOther) == typeof(uint))
			{
				result = (uint)((object)value);
			}
			else if (!uint.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<uint>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000732E0 File Offset: 0x000714E0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			uint result;
			if (typeof(TOther) == typeof(uint))
			{
				result = (uint)((object)value);
			}
			else if (!uint.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<uint>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00073338 File Offset: 0x00071538
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			uint result;
			if (typeof(TOther) == typeof(uint))
			{
				result = (uint)((object)value);
			}
			else if (!uint.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<uint>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<uint>.IsCanonical(uint value)
		{
			return true;
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<uint>.IsComplexNumber(uint value)
		{
			return false;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x000202BE File Offset: 0x0001E4BE
		public static bool IsEvenInteger(uint value)
		{
			return (value & 1U) == 0U;
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<uint>.IsFinite(uint value)
		{
			return true;
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<uint>.IsImaginaryNumber(uint value)
		{
			return false;
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<uint>.IsInfinity(uint value)
		{
			return false;
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<uint>.IsInteger(uint value)
		{
			return true;
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<uint>.IsNaN(uint value)
		{
			return false;
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<uint>.IsNegative(uint value)
		{
			return false;
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<uint>.IsNegativeInfinity(uint value)
		{
			return false;
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x000201AE File Offset: 0x0001E3AE
		bool INumberBase<uint>.IsNormal(uint value)
		{
			return value > 0U;
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x000202C6 File Offset: 0x0001E4C6
		public static bool IsOddInteger(uint value)
		{
			return (value & 1U) > 0U;
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<uint>.IsPositive(uint value)
		{
			return true;
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<uint>.IsPositiveInfinity(uint value)
		{
			return false;
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<uint>.IsRealNumber(uint value)
		{
			return true;
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<uint>.IsSubnormal(uint value)
		{
			return false;
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x000202CE File Offset: 0x0001E4CE
		bool INumberBase<uint>.IsZero(uint value)
		{
			return value == 0U;
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x0007326A File Offset: 0x0007146A
		uint INumberBase<uint>.MaxMagnitude(uint x, uint y)
		{
			return uint.Max(x, y);
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0007326A File Offset: 0x0007146A
		uint INumberBase<uint>.MaxMagnitudeNumber(uint x, uint y)
		{
			return uint.Max(x, y);
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x0007327C File Offset: 0x0007147C
		uint INumberBase<uint>.MinMagnitude(uint x, uint y)
		{
			return uint.Min(x, y);
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x0007327C File Offset: 0x0007147C
		uint INumberBase<uint>.MinMagnitudeNumber(uint x, uint y)
		{
			return uint.Min(x, y);
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x0002F0EE File Offset: 0x0002D2EE
		uint INumberBase<uint>.MultiplyAddEstimate(uint left, uint right, uint addend)
		{
			return left * right + addend;
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x0007338E File Offset: 0x0007158E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<uint>.TryConvertFromChecked<TOther>(TOther value, out uint result) where TOther : INumberBase<TOther>
		{
			return uint.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x00073398 File Offset: 0x00071598
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out uint result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (uint)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (uint)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal value2 = (decimal)((object)value);
				result = (uint)value2;
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num = (ushort)((object)value);
				result = (uint)num;
				return true;
			}
			checked
			{
				if (typeof(TOther) == typeof(ulong))
				{
					ulong num2 = (ulong)((object)value);
					result = (uint)num2;
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
					result = (uint)uintPtr;
					return true;
				}
				result = 0U;
				return false;
			}
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x000734EF File Offset: 0x000716EF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<uint>.TryConvertFromSaturating<TOther>(TOther value, out uint result) where TOther : INumberBase<TOther>
		{
			return uint.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x000734F8 File Offset: 0x000716F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out uint result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (uint)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (uint)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 4294967295m) ? 4294967295U : ((num <= 0m) ? 0U : ((uint)num)));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)((object)value);
				result = (uint)num2;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num3 = (ulong)((object)value);
				result = ((num3 >= (ulong)-1) ? 4294967295U : ((uint)num3));
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (UInt128)((object)value);
				result = ((@uint >= 4294967295U) ? 4294967295U : ((uint)@uint));
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = ((uintPtr >= (UIntPtr)(-1)) ? 4294967295U : ((uint)uintPtr));
				return true;
			}
			result = 0U;
			return false;
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x00073694 File Offset: 0x00071894
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<uint>.TryConvertFromTruncating<TOther>(TOther value, out uint result) where TOther : INumberBase<TOther>
		{
			return uint.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x000736A0 File Offset: 0x000718A0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out uint result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (uint)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (uint)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 4294967295m) ? 4294967295U : ((num <= 0m) ? 0U : ((uint)num)));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)((object)value);
				result = (uint)num2;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num3 = (ulong)((object)value);
				result = (uint)num3;
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 value2 = (UInt128)((object)value);
				result = (uint)value2;
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((object)value);
				result = (uint)uintPtr;
				return true;
			}
			result = 0U;
			return false;
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00073818 File Offset: 0x00071A18
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<uint>.TryConvertToChecked<TOther>(uint value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)value;
				result = (TOther)((object)half);
				return true;
			}
			checked
			{
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
					long num4 = (long)(unchecked((ulong)value));
					result = (TOther)((object)num4);
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
					float num5 = value;
					result = (TOther)((object)num5);
					return true;
				}
				result = default(TOther);
				return false;
			}
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x000739FC File Offset: 0x00071BFC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<uint>.TryConvertToSaturating<TOther>(uint value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = value;
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
				short num2 = (value >= 32767U) ? short.MaxValue : ((short)value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (int)((value >= 2147483647U) ? 2147483647U : value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (long)((ulong)value);
				result = (TOther)((object)num4);
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
				sbyte b = (value >= 127U) ? sbyte.MaxValue : ((sbyte)value);
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num5 = value;
				result = (TOther)((object)num5);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00073C04 File Offset: 0x00071E04
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<uint>.TryConvertToTruncating<TOther>(uint value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = value;
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
				result = (TOther)((object)((int)value));
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num3 = (long)((ulong)value);
				result = (TOther)((object)num3);
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
				float num4 = value;
				result = (TOther)((object)num4);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x00073DE5 File Offset: 0x00071FE5
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out uint result)
		{
			return uint.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x00041357 File Offset: 0x0003F557
		uint IShiftOperators<uint, int, uint>.op_LeftShift(uint value, int shiftAmount)
		{
			return value << shiftAmount;
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x00041367 File Offset: 0x0003F567
		uint IShiftOperators<uint, int, uint>.op_RightShift(uint value, int shiftAmount)
		{
			return value >> shiftAmount;
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x00041367 File Offset: 0x0003F567
		uint IShiftOperators<uint, int, uint>.op_UnsignedRightShift(uint value, int shiftAmount)
		{
			return value >> shiftAmount;
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x00073DF0 File Offset: 0x00071FF0
		public static uint Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return uint.Parse(s, NumberStyles.Integer, provider);
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00073DFA File Offset: 0x00071FFA
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out uint result)
		{
			return uint.TryParse(s, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x0002FA55 File Offset: 0x0002DC55
		uint ISubtractionOperators<uint, uint, uint>.op_Subtraction(uint left, uint right)
		{
			return left - right;
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x00073E05 File Offset: 0x00072005
		uint ISubtractionOperators<uint, uint, uint>.op_CheckedSubtraction(uint left, uint right)
		{
			return checked(left - right);
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x00073E0A File Offset: 0x0007200A
		uint IUnaryNegationOperators<uint, uint>.op_UnaryNegation(uint value)
		{
			return 0U - value;
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00073E0F File Offset: 0x0007200F
		uint IUnaryNegationOperators<uint, uint>.op_CheckedUnaryNegation(uint value)
		{
			return checked(0U - value);
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x00007B62 File Offset: 0x00005D62
		uint IUnaryPlusOperators<uint, uint>.op_UnaryPlus(uint value)
		{
			return value;
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x00073E14 File Offset: 0x00072014
		public static uint Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.ParseBinaryInteger<byte, uint>(utf8Text, style, NumberFormatInfo.GetInstance(provider));
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00073E29 File Offset: 0x00072029
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out uint result)
		{
			NumberFormatInfo.ValidateParseStyleInteger(style);
			return Number.TryParseBinaryInteger<byte, uint>(utf8Text, style, NumberFormatInfo.GetInstance(provider), out result) == Number.ParsingStatus.OK;
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00073E42 File Offset: 0x00072042
		public static uint Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return uint.Parse(utf8Text, NumberStyles.Integer, provider);
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00073E4C File Offset: 0x0007204C
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out uint result)
		{
			return uint.TryParse(utf8Text, NumberStyles.Integer, provider, out result);
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x00007B65 File Offset: 0x00005D65
		bool IBinaryIntegerParseAndFormatInfo<uint>.IsSigned
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060025C6 RID: 9670 RVA: 0x00029CD6 File Offset: 0x00027ED6
		int IBinaryIntegerParseAndFormatInfo<uint>.MaxDigitCount
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060025C7 RID: 9671 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		int IBinaryIntegerParseAndFormatInfo<uint>.MaxHexDigitCount
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060025C8 RID: 9672 RVA: 0x00073E57 File Offset: 0x00072057
		uint IBinaryIntegerParseAndFormatInfo<uint>.MaxValueDiv10
		{
			get
			{
				return 429496729U;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060025C9 RID: 9673 RVA: 0x00073E5E File Offset: 0x0007205E
		[Nullable(1)]
		string IBinaryIntegerParseAndFormatInfo<uint>.OverflowMessage
		{
			get
			{
				return SR.Overflow_UInt32;
			}
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x000413DF File Offset: 0x0003F5DF
		bool IBinaryIntegerParseAndFormatInfo<uint>.IsGreaterThanAsUnsigned(uint left, uint right)
		{
			return left > right;
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x000413E5 File Offset: 0x0003F5E5
		uint IBinaryIntegerParseAndFormatInfo<uint>.MultiplyBy10(uint value)
		{
			return value * 10U;
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x000413EB File Offset: 0x0003F5EB
		uint IBinaryIntegerParseAndFormatInfo<uint>.MultiplyBy16(uint value)
		{
			return value * 16U;
		}

		// Token: 0x040006E5 RID: 1765
		private readonly uint m_value;

		// Token: 0x040006E6 RID: 1766
		public const uint MaxValue = 4294967295U;

		// Token: 0x040006E7 RID: 1767
		public const uint MinValue = 0U;
	}
}
