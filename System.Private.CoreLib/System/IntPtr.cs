using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x0200014F RID: 335
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct IntPtr : IEquatable<IntPtr>, IComparable, IComparable<IntPtr>, ISpanFormattable, IFormattable, ISerializable, IBinaryInteger<IntPtr>, IBinaryNumber<IntPtr>, IBitwiseOperators<IntPtr, IntPtr, IntPtr>, INumber<IntPtr>, IComparisonOperators<IntPtr, IntPtr, bool>, IEqualityOperators<IntPtr, IntPtr, bool>, IModulusOperators<IntPtr, IntPtr, IntPtr>, INumberBase<IntPtr>, IAdditionOperators<IntPtr, IntPtr, IntPtr>, IAdditiveIdentity<IntPtr, IntPtr>, IDecrementOperators<IntPtr>, IDivisionOperators<IntPtr, IntPtr, IntPtr>, IIncrementOperators<IntPtr>, IMultiplicativeIdentity<IntPtr, IntPtr>, IMultiplyOperators<IntPtr, IntPtr, IntPtr>, ISpanParsable<IntPtr>, IParsable<IntPtr>, ISubtractionOperators<IntPtr, IntPtr, IntPtr>, IUnaryPlusOperators<IntPtr, IntPtr>, IUnaryNegationOperators<IntPtr, IntPtr>, IUtf8SpanFormattable, IUtf8SpanParsable<IntPtr>, IShiftOperators<IntPtr, int, IntPtr>, IMinMaxValue<IntPtr>, ISignedNumber<IntPtr>
	{
		// Token: 0x0600165D RID: 5725 RVA: 0x000449BE File Offset: 0x00042BBE
		[NonVersionable]
		public IntPtr(int value)
		{
			this._value = (IntPtr)value;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x000449BE File Offset: 0x00042BBE
		[NonVersionable]
		public IntPtr(long value)
		{
			this._value = (IntPtr)value;
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x000449C8 File Offset: 0x00042BC8
		[CLSCompliant(false)]
		[NonVersionable]
		public unsafe IntPtr(void* value)
		{
			this._value = value;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x000449D4 File Offset: 0x00042BD4
		private IntPtr(SerializationInfo info, StreamingContext context)
		{
			long @int = info.GetInt64("value");
			this._value = (IntPtr)@int;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000449F8 File Offset: 0x00042BF8
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			long value = (long)this;
			info.AddValue("value", value);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00044A20 File Offset: 0x00042C20
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is IntPtr)
			{
				IntPtr other = (IntPtr)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00044A48 File Offset: 0x00042C48
		public override int GetHashCode()
		{
			return ((long)this).GetHashCode();
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00044A60 File Offset: 0x00042C60
		[NonVersionable]
		public int ToInt32()
		{
			return checked((int)this);
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00044A65 File Offset: 0x00042C65
		[NonVersionable]
		public long ToInt64()
		{
			return (long)this;
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00044A6A File Offset: 0x00042C6A
		[NonVersionable]
		public static explicit operator IntPtr(int value)
		{
			return (IntPtr)value;
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00044A6E File Offset: 0x00042C6E
		[NonVersionable]
		public static explicit operator IntPtr(long value)
		{
			return checked((IntPtr)value);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		[NonVersionable]
		public unsafe static explicit operator IntPtr(void* value)
		{
			return value;
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		[NonVersionable]
		public unsafe static explicit operator void*(IntPtr value)
		{
			return value;
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00044A72 File Offset: 0x00042C72
		[NonVersionable]
		public static explicit operator int(IntPtr value)
		{
			return checked((int)value);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00023845 File Offset: 0x00021A45
		[NonVersionable]
		public static explicit operator long(IntPtr value)
		{
			return (long)value;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0000FF2A File Offset: 0x0000E12A
		[NonVersionable]
		public static bool operator ==(IntPtr value1, IntPtr value2)
		{
			return value1 == value2;
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0001306A File Offset: 0x0001126A
		[NonVersionable]
		public static bool operator !=(IntPtr value1, IntPtr value2)
		{
			return value1 != value2;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x00044A76 File Offset: 0x00042C76
		[NonVersionable]
		public static IntPtr Add(IntPtr pointer, int offset)
		{
			return pointer + (IntPtr)offset;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00044A76 File Offset: 0x00042C76
		[NonVersionable]
		public static IntPtr operator +(IntPtr pointer, int offset)
		{
			return pointer + (IntPtr)offset;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00044A7C File Offset: 0x00042C7C
		[NonVersionable]
		public static IntPtr Subtract(IntPtr pointer, int offset)
		{
			return pointer - (IntPtr)offset;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00044A7C File Offset: 0x00042C7C
		[NonVersionable]
		public static IntPtr operator -(IntPtr pointer, int offset)
		{
			return pointer - (IntPtr)offset;
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x00044A82 File Offset: 0x00042C82
		public static int Size
		{
			[NonVersionable]
			get
			{
				return 8;
			}
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00044A89 File Offset: 0x00042C89
		[CLSCompliant(false)]
		[NonVersionable]
		public unsafe void* ToPointer()
		{
			return this;
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00044A8D File Offset: 0x00042C8D
		public static IntPtr MaxValue
		{
			[NonVersionable]
			get
			{
				return (IntPtr)long.MaxValue;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x00044A99 File Offset: 0x00042C99
		public static IntPtr MinValue
		{
			[NonVersionable]
			get
			{
				return (IntPtr)long.MinValue;
			}
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00044AA8 File Offset: 0x00042CA8
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value is IntPtr)
			{
				IntPtr value2 = (IntPtr)value;
				return this.CompareTo(value2);
			}
			if (value == null)
			{
				return 1;
			}
			throw new ArgumentException(SR.Arg_MustBeIntPtr);
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x00044ADB File Offset: 0x00042CDB
		public int CompareTo(IntPtr value)
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

		// Token: 0x06001678 RID: 5752 RVA: 0x00044AEC File Offset: 0x00042CEC
		[NonVersionable]
		public bool Equals(IntPtr other)
		{
			return this == other;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00044AF4 File Offset: 0x00042CF4
		[NullableContext(1)]
		public override string ToString()
		{
			return ((long)this).ToString();
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00044B0C File Offset: 0x00042D0C
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return ((long)this).ToString(format);
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00044B28 File Offset: 0x00042D28
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return ((long)this).ToString(provider);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00044B44 File Offset: 0x00042D44
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return ((long)this).ToString(format, provider);
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00044B60 File Offset: 0x00042D60
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return ((long)this).TryFormat(destination, out charsWritten, format, provider);
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00044B80 File Offset: 0x00042D80
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return ((long)this).TryFormat(utf8Destination, out bytesWritten, format, provider);
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00044B9D File Offset: 0x00042D9D
		[NullableContext(1)]
		public static IntPtr Parse(string s)
		{
			return (IntPtr)long.Parse(s);
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00044BA6 File Offset: 0x00042DA6
		[NullableContext(1)]
		public static IntPtr Parse(string s, NumberStyles style)
		{
			return (IntPtr)long.Parse(s, style);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00044BB0 File Offset: 0x00042DB0
		[NullableContext(1)]
		public static IntPtr Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return (IntPtr)long.Parse(s, provider);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00044BBA File Offset: 0x00042DBA
		[NullableContext(1)]
		public static IntPtr Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			return (IntPtr)long.Parse(s, style, provider);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00044BC5 File Offset: 0x00042DC5
		public static IntPtr Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return (IntPtr)long.Parse(s, provider);
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00044BCF File Offset: 0x00042DCF
		public static IntPtr Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			return (IntPtr)long.Parse(s, style, provider);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00044BDA File Offset: 0x00042DDA
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out IntPtr result)
		{
			Unsafe.SkipInit<IntPtr>(out result);
			return long.TryParse(s, Unsafe.As<IntPtr, long>(ref result));
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00044BEE File Offset: 0x00042DEE
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out IntPtr result)
		{
			Unsafe.SkipInit<IntPtr>(out result);
			return long.TryParse(s, provider, Unsafe.As<IntPtr, long>(ref result));
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00044C03 File Offset: 0x00042E03
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out IntPtr result)
		{
			Unsafe.SkipInit<IntPtr>(out result);
			return long.TryParse(s, style, provider, Unsafe.As<IntPtr, long>(ref result));
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00044C19 File Offset: 0x00042E19
		public static bool TryParse(ReadOnlySpan<char> s, out IntPtr result)
		{
			Unsafe.SkipInit<IntPtr>(out result);
			return long.TryParse(s, Unsafe.As<IntPtr, long>(ref result));
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00044C2D File Offset: 0x00042E2D
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out IntPtr result)
		{
			Unsafe.SkipInit<IntPtr>(out result);
			return long.TryParse(utf8Text, Unsafe.As<IntPtr, long>(ref result));
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00044C41 File Offset: 0x00042E41
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out IntPtr result)
		{
			Unsafe.SkipInit<IntPtr>(out result);
			return long.TryParse(s, provider, Unsafe.As<IntPtr, long>(ref result));
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00044C56 File Offset: 0x00042E56
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out IntPtr result)
		{
			Unsafe.SkipInit<IntPtr>(out result);
			return long.TryParse(s, style, provider, Unsafe.As<IntPtr, long>(ref result));
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0002EA29 File Offset: 0x0002CC29
		IntPtr IAdditionOperators<IntPtr, IntPtr, IntPtr>.op_Addition(IntPtr left, IntPtr right)
		{
			return left + right;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00040289 File Offset: 0x0003E489
		IntPtr IAdditionOperators<IntPtr, IntPtr, IntPtr>.op_CheckedAddition(IntPtr left, IntPtr right)
		{
			return checked(left + right);
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x00044C6C File Offset: 0x00042E6C
		IntPtr IAdditiveIdentity<IntPtr, IntPtr>.AdditiveIdentity
		{
			get
			{
				return (IntPtr)0;
			}
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x00044C70 File Offset: 0x00042E70
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<IntPtr, IntPtr> DivRem(IntPtr left, IntPtr right)
		{
			return Math.DivRem(left, right);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00044C79 File Offset: 0x00042E79
		[Intrinsic]
		public static IntPtr LeadingZeroCount(IntPtr value)
		{
			return (IntPtr)BitOperations.LeadingZeroCount((UIntPtr)value);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00044C82 File Offset: 0x00042E82
		[Intrinsic]
		public static IntPtr PopCount(IntPtr value)
		{
			return (IntPtr)BitOperations.PopCount((UIntPtr)value);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00044C8B File Offset: 0x00042E8B
		[Intrinsic]
		public static IntPtr RotateLeft(IntPtr value, int rotateAmount)
		{
			return (IntPtr)BitOperations.RotateLeft((UIntPtr)value, rotateAmount);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00044C94 File Offset: 0x00042E94
		[Intrinsic]
		public static IntPtr RotateRight(IntPtr value, int rotateAmount)
		{
			return (IntPtr)BitOperations.RotateRight((UIntPtr)value, rotateAmount);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00044C9D File Offset: 0x00042E9D
		[Intrinsic]
		public static IntPtr TrailingZeroCount(IntPtr value)
		{
			return (IntPtr)BitOperations.TrailingZeroCount(value);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00044CA8 File Offset: 0x00042EA8
		unsafe bool IBinaryInteger<IntPtr>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out IntPtr value)
		{
			IntPtr intPtr = (IntPtr)0;
			if (source.Length != 0)
			{
				sbyte b = (sbyte)(*source[0]);
				b = (sbyte)(b >> 31);
				isUnsigned |= (b == 0);
				if (isUnsigned && sbyte.IsNegative(b) && source.Length >= 8)
				{
					value = intPtr;
					return false;
				}
				if (source.Length > 8)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 8).ContainsAnyExcept((byte)b))
					{
						value = intPtr;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[source.Length - 8])))
					{
						value = intPtr;
						return false;
					}
				}
				ref byte source2 = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 8)
				{
					source2 = Unsafe.Add<byte>(ref source2, source.Length - 8);
					intPtr = Unsafe.ReadUnaligned<IntPtr>(ref source2);
					bool isLittleEndian = BitConverter.IsLittleEndian;
					intPtr = BinaryPrimitives.ReverseEndianness(intPtr);
				}
				else
				{
					for (int i = 0; i < source.Length; i++)
					{
						intPtr <<= 8;
						intPtr |= (IntPtr)((UIntPtr)(*Unsafe.Add<byte>(ref source2, i)));
					}
					if (!isUnsigned)
					{
						intPtr |= (IntPtr)1 << (63 & 8 * 8 - 1) >> ((8 - source.Length) * 8 - 1 & 8 * 8 - 1);
					}
				}
			}
			value = intPtr;
			return true;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00044DD0 File Offset: 0x00042FD0
		unsafe bool IBinaryInteger<IntPtr>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out IntPtr value)
		{
			IntPtr intPtr = (IntPtr)0;
			if (source.Length != 0)
			{
				sbyte b = (sbyte)(*source[source.Length - 1]);
				b = (sbyte)(b >> 31);
				isUnsigned |= (b == 0);
				if (isUnsigned && sbyte.IsNegative(b) && source.Length >= 8)
				{
					value = intPtr;
					return false;
				}
				if (source.Length > 8)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(8, ptr.Length - 8).ContainsAnyExcept((byte)b))
					{
						value = intPtr;
						return false;
					}
					if (isUnsigned == sbyte.IsNegative((sbyte)(*source[7])))
					{
						value = intPtr;
						return false;
					}
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 8)
				{
					intPtr = Unsafe.ReadUnaligned<IntPtr>(ref reference);
					if (BitConverter.IsLittleEndian)
					{
						goto IL_11C;
					}
				}
				for (int i = 0; i < source.Length; i++)
				{
					intPtr <<= 8;
					intPtr |= (IntPtr)((UIntPtr)(*Unsafe.Add<byte>(ref reference, i)));
				}
				intPtr <<= ((8 - source.Length) * 8 & 8 * 8 - 1);
				intPtr = BinaryPrimitives.ReverseEndianness(intPtr);
				if (!isUnsigned)
				{
					intPtr |= (IntPtr)1 << (63 & 8 * 8 - 1) >> ((8 - source.Length) * 8 - 1 & 8 * 8 - 1);
				}
			}
			IL_11C:
			value = intPtr;
			return true;
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00044F00 File Offset: 0x00043100
		int IBinaryInteger<IntPtr>.GetShortestBitLength()
		{
			IntPtr intPtr = this;
			if (intPtr >= (IntPtr)0)
			{
				return 64 - BitOperations.LeadingZeroCount((UIntPtr)intPtr);
			}
			return 65 - BitOperations.LeadingZeroCount((UIntPtr)(~(UIntPtr)intPtr));
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		int IBinaryInteger<IntPtr>.GetByteCount()
		{
			return 8;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00044F2C File Offset: 0x0004312C
		bool IBinaryInteger<IntPtr>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				long value = (long)this;
				bool isLittleEndian = BitConverter.IsLittleEndian;
				value = BinaryPrimitives.ReverseEndianness(value);
				Unsafe.WriteUnaligned<long>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00044F6C File Offset: 0x0004316C
		bool IBinaryInteger<IntPtr>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				long value = (long)this;
				if (!BitConverter.IsLittleEndian)
				{
				}
				Unsafe.WriteUnaligned<long>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x00044FA3 File Offset: 0x000431A3
		IntPtr IBinaryNumber<IntPtr>.AllBitsSet
		{
			get
			{
				return (IntPtr)(-1);
			}
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00044FA7 File Offset: 0x000431A7
		public static bool IsPow2(IntPtr value)
		{
			return BitOperations.IsPow2(value);
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00044FAF File Offset: 0x000431AF
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr Log2(IntPtr value)
		{
			if (value < (IntPtr)0)
			{
				ThrowHelper.ThrowValueArgumentOutOfRange_NeedNonNegNumException();
			}
			return (IntPtr)BitOperations.Log2((UIntPtr)value);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00040597 File Offset: 0x0003E797
		IntPtr IBitwiseOperators<IntPtr, IntPtr, IntPtr>.op_BitwiseAnd(IntPtr left, IntPtr right)
		{
			return left & right;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0004059C File Offset: 0x0003E79C
		IntPtr IBitwiseOperators<IntPtr, IntPtr, IntPtr>.op_BitwiseOr(IntPtr left, IntPtr right)
		{
			return left | right;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000405A1 File Offset: 0x0003E7A1
		IntPtr IBitwiseOperators<IntPtr, IntPtr, IntPtr>.op_ExclusiveOr(IntPtr left, IntPtr right)
		{
			return left ^ right;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x000405A6 File Offset: 0x0003E7A6
		IntPtr IBitwiseOperators<IntPtr, IntPtr, IntPtr>.op_OnesComplement(IntPtr value)
		{
			return ~value;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00020126 File Offset: 0x0001E326
		bool IComparisonOperators<IntPtr, IntPtr, bool>.op_LessThan(IntPtr left, IntPtr right)
		{
			return left < right;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0002012C File Offset: 0x0001E32C
		bool IComparisonOperators<IntPtr, IntPtr, bool>.op_LessThanOrEqual(IntPtr left, IntPtr right)
		{
			return left <= right;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00020135 File Offset: 0x0001E335
		bool IComparisonOperators<IntPtr, IntPtr, bool>.op_GreaterThan(IntPtr left, IntPtr right)
		{
			return left > right;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0002013B File Offset: 0x0001E33B
		bool IComparisonOperators<IntPtr, IntPtr, bool>.op_GreaterThanOrEqual(IntPtr left, IntPtr right)
		{
			return left >= right;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000405AA File Offset: 0x0003E7AA
		IntPtr IDecrementOperators<IntPtr>.op_Decrement(IntPtr value)
		{
			return --value;
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x000405B2 File Offset: 0x0003E7B2
		IntPtr IDecrementOperators<IntPtr>.op_CheckedDecrement(IntPtr value)
		{
			return checked(--value);
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x0002EAEC File Offset: 0x0002CCEC
		IntPtr IDivisionOperators<IntPtr, IntPtr, IntPtr>.op_Division(IntPtr left, IntPtr right)
		{
			return left / right;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x000405BA File Offset: 0x0003E7BA
		IntPtr IIncrementOperators<IntPtr>.op_Increment(IntPtr value)
		{
			return ++value;
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x000405C2 File Offset: 0x0003E7C2
		IntPtr IIncrementOperators<IntPtr>.op_CheckedIncrement(IntPtr value)
		{
			return checked(++value);
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x00044FC2 File Offset: 0x000431C2
		IntPtr IMinMaxValue<IntPtr>.MinValue
		{
			get
			{
				return IntPtr.MinValue;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x00044FC9 File Offset: 0x000431C9
		IntPtr IMinMaxValue<IntPtr>.MaxValue
		{
			get
			{
				return IntPtr.MaxValue;
			}
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x0002EE4D File Offset: 0x0002D04D
		IntPtr IModulusOperators<IntPtr, IntPtr, IntPtr>.op_Modulus(IntPtr left, IntPtr right)
		{
			return left % right;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x00044FD0 File Offset: 0x000431D0
		IntPtr IMultiplicativeIdentity<IntPtr, IntPtr>.MultiplicativeIdentity
		{
			get
			{
				return (IntPtr)1;
			}
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x0002EE5D File Offset: 0x0002D05D
		IntPtr IMultiplyOperators<IntPtr, IntPtr, IntPtr>.op_Multiply(IntPtr left, IntPtr right)
		{
			return left * right;
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x000405D8 File Offset: 0x0003E7D8
		IntPtr IMultiplyOperators<IntPtr, IntPtr, IntPtr>.op_CheckedMultiply(IntPtr left, IntPtr right)
		{
			return checked(left * right);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00044FD4 File Offset: 0x000431D4
		public static IntPtr Clamp(IntPtr value, IntPtr min, IntPtr max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00044FE0 File Offset: 0x000431E0
		public static IntPtr CopySign(IntPtr value, IntPtr sign)
		{
			IntPtr intPtr = value;
			if (intPtr < (IntPtr)0)
			{
				intPtr = -intPtr;
			}
			if (sign >= (IntPtr)0)
			{
				if (intPtr < (IntPtr)0)
				{
					Math.ThrowNegateTwosCompOverflow();
				}
				return intPtr;
			}
			return -intPtr;
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x0004500A File Offset: 0x0004320A
		public static IntPtr Max(IntPtr x, IntPtr y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00045013 File Offset: 0x00043213
		IntPtr INumber<IntPtr>.MaxNumber(IntPtr x, IntPtr y)
		{
			return IntPtr.Max(x, y);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x0004501C File Offset: 0x0004321C
		public static IntPtr Min(IntPtr x, IntPtr y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00045025 File Offset: 0x00043225
		IntPtr INumber<IntPtr>.MinNumber(IntPtr x, IntPtr y)
		{
			return IntPtr.Min(x, y);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x0004502E File Offset: 0x0004322E
		public static int Sign(IntPtr value)
		{
			return Math.Sign(value);
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00044FD0 File Offset: 0x000431D0
		IntPtr INumberBase<IntPtr>.One
		{
			get
			{
				return (IntPtr)1;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<IntPtr>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00044C6C File Offset: 0x00042E6C
		IntPtr INumberBase<IntPtr>.Zero
		{
			get
			{
				return (IntPtr)0;
			}
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00045036 File Offset: 0x00043236
		public static IntPtr Abs(IntPtr value)
		{
			return Math.Abs(value);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00045040 File Offset: 0x00043240
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			IntPtr result;
			if (typeof(TOther) == typeof(IntPtr))
			{
				result = (IntPtr)((object)value);
			}
			else if (!IntPtr.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<IntPtr>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00045098 File Offset: 0x00043298
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			IntPtr result;
			if (typeof(TOther) == typeof(IntPtr))
			{
				result = (IntPtr)((object)value);
			}
			else if (!IntPtr.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<IntPtr>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x000450F0 File Offset: 0x000432F0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			IntPtr result;
			if (typeof(TOther) == typeof(IntPtr))
			{
				result = (IntPtr)((object)value);
			}
			else if (!IntPtr.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<IntPtr>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<IntPtr>.IsCanonical(IntPtr value)
		{
			return true;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<IntPtr>.IsComplexNumber(IntPtr value)
		{
			return false;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00045146 File Offset: 0x00043346
		public static bool IsEvenInteger(IntPtr value)
		{
			return (value & (IntPtr)1) == (IntPtr)0;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<IntPtr>.IsFinite(IntPtr value)
		{
			return true;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<IntPtr>.IsImaginaryNumber(IntPtr value)
		{
			return false;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<IntPtr>.IsInfinity(IntPtr value)
		{
			return false;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<IntPtr>.IsInteger(IntPtr value)
		{
			return true;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<IntPtr>.IsNaN(IntPtr value)
		{
			return false;
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00045150 File Offset: 0x00043350
		public static bool IsNegative(IntPtr value)
		{
			return value < (IntPtr)0;
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<IntPtr>.IsNegativeInfinity(IntPtr value)
		{
			return false;
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00045157 File Offset: 0x00043357
		bool INumberBase<IntPtr>.IsNormal(IntPtr value)
		{
			return value > (IntPtr)0;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x0004515E File Offset: 0x0004335E
		public static bool IsOddInteger(IntPtr value)
		{
			return (value & (IntPtr)1) > (IntPtr)0;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00045168 File Offset: 0x00043368
		public static bool IsPositive(IntPtr value)
		{
			return value >= (IntPtr)0;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<IntPtr>.IsPositiveInfinity(IntPtr value)
		{
			return false;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<IntPtr>.IsRealNumber(IntPtr value)
		{
			return true;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<IntPtr>.IsSubnormal(IntPtr value)
		{
			return false;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00045172 File Offset: 0x00043372
		bool INumberBase<IntPtr>.IsZero(IntPtr value)
		{
			return value == (IntPtr)0;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x0004517C File Offset: 0x0004337C
		public static IntPtr MaxMagnitude(IntPtr x, IntPtr y)
		{
			IntPtr intPtr = x;
			if (intPtr < (IntPtr)0)
			{
				intPtr = -intPtr;
				if (intPtr < (IntPtr)0)
				{
					return x;
				}
			}
			IntPtr intPtr2 = y;
			if (intPtr2 < (IntPtr)0)
			{
				intPtr2 = -intPtr2;
				if (intPtr2 < (IntPtr)0)
				{
					return y;
				}
			}
			if (intPtr > intPtr2)
			{
				return x;
			}
			if (intPtr != intPtr2)
			{
				return y;
			}
			if (!IntPtr.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x000451C2 File Offset: 0x000433C2
		IntPtr INumberBase<IntPtr>.MaxMagnitudeNumber(IntPtr x, IntPtr y)
		{
			return IntPtr.MaxMagnitude(x, y);
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x000451CC File Offset: 0x000433CC
		public static IntPtr MinMagnitude(IntPtr x, IntPtr y)
		{
			IntPtr intPtr = x;
			if (intPtr < (IntPtr)0)
			{
				intPtr = -intPtr;
				if (intPtr < (IntPtr)0)
				{
					return y;
				}
			}
			IntPtr intPtr2 = y;
			if (intPtr2 < (IntPtr)0)
			{
				intPtr2 = -intPtr2;
				if (intPtr2 < (IntPtr)0)
				{
					return x;
				}
			}
			if (intPtr < intPtr2)
			{
				return x;
			}
			if (intPtr != intPtr2)
			{
				return y;
			}
			if (!IntPtr.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00045212 File Offset: 0x00043412
		IntPtr INumberBase<IntPtr>.MinMagnitudeNumber(IntPtr x, IntPtr y)
		{
			return IntPtr.MinMagnitude(x, y);
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x0002F0EE File Offset: 0x0002D2EE
		IntPtr INumberBase<IntPtr>.MultiplyAddEstimate(IntPtr left, IntPtr right, IntPtr addend)
		{
			return left * right + addend;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x0004521B File Offset: 0x0004341B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<IntPtr>.TryConvertFromChecked<TOther>(TOther value, out IntPtr result) where TOther : INumberBase<TOther>
		{
			return IntPtr.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00045224 File Offset: 0x00043424
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out IntPtr result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = checked((IntPtr)num);
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
				result = (IntPtr)num2;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (int)((object)value);
				result = (IntPtr)num3;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (long)((object)value);
				result = checked((IntPtr)num4);
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 value3 = (Int128)((object)value);
				result = Int128.op_CheckedExplicit(value3);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (IntPtr)b;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num5 = (float)((object)value);
				result = checked((IntPtr)num5);
				return true;
			}
			result = (IntPtr)0;
			return false;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000453AE File Offset: 0x000435AE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<IntPtr>.TryConvertFromSaturating<TOther>(TOther value, out IntPtr result) where TOther : INumberBase<TOther>
		{
			return IntPtr.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x000453B8 File Offset: 0x000435B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out IntPtr result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 9.223372036854776E+18) ? ((IntPtr)long.MaxValue) : ((num <= -9.223372036854776E+18) ? ((IntPtr)long.MinValue) : ((IntPtr)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half == Half.PositiveInfinity) ? ((IntPtr)long.MaxValue) : ((half == Half.NegativeInfinity) ? ((IntPtr)long.MinValue) : ((IntPtr)half)));
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)((object)value);
				result = (IntPtr)num2;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (int)((object)value);
				result = (IntPtr)num3;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (long)((object)value);
				result = ((num4 >= long.MaxValue) ? ((IntPtr)long.MaxValue) : ((num4 <= long.MinValue) ? ((IntPtr)long.MinValue) : ((IntPtr)num4)));
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 @int = (Int128)((object)value);
				result = ((@int >= long.MaxValue) ? ((IntPtr)long.MaxValue) : ((@int <= long.MinValue) ? ((IntPtr)long.MinValue) : ((IntPtr)@int)));
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (IntPtr)b;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num5 = (float)((object)value);
				result = ((num5 >= 9.223372E+18f) ? ((IntPtr)long.MaxValue) : ((num5 <= -9.223372E+18f) ? ((IntPtr)long.MinValue) : ((IntPtr)num5)));
				return true;
			}
			result = (IntPtr)0;
			return false;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00045646 File Offset: 0x00043846
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<IntPtr>.TryConvertFromTruncating<TOther>(TOther value, out IntPtr result) where TOther : INumberBase<TOther>
		{
			return IntPtr.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00045650 File Offset: 0x00043850
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out IntPtr result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(double))
			{
				double num = (double)((object)value);
				result = ((num >= 9.223372036854776E+18) ? ((IntPtr)long.MaxValue) : ((num <= -9.223372036854776E+18) ? ((IntPtr)long.MinValue) : ((IntPtr)num)));
				return true;
			}
			if (typeof(TOther) == typeof(Half))
			{
				Half half = (Half)((object)value);
				result = ((half == Half.PositiveInfinity) ? ((IntPtr)long.MaxValue) : ((half == Half.NegativeInfinity) ? ((IntPtr)long.MinValue) : ((IntPtr)half)));
				return true;
			}
			if (typeof(TOther) == typeof(short))
			{
				short num2 = (short)((object)value);
				result = (IntPtr)num2;
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (int)((object)value);
				result = (IntPtr)num3;
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (long)((object)value);
				result = (IntPtr)num4;
				return true;
			}
			if (typeof(TOther) == typeof(Int128))
			{
				Int128 value2 = (Int128)((object)value);
				result = (IntPtr)value2;
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (sbyte)((object)value);
				result = (IntPtr)b;
				return true;
			}
			if (typeof(TOther) == typeof(float))
			{
				float num5 = (float)((object)value);
				result = ((num5 >= 9.223372E+18f) ? ((IntPtr)long.MaxValue) : ((num5 <= -9.223372E+18f) ? ((IntPtr)long.MinValue) : ((IntPtr)num5)));
				return true;
			}
			result = (IntPtr)0;
			return false;
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00045868 File Offset: 0x00043A68
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<IntPtr>.TryConvertToChecked<TOther>(IntPtr value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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
					decimal num = unchecked((long)value);
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

		// Token: 0x060016DC RID: 5852 RVA: 0x00045A18 File Offset: 0x00043C18
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<IntPtr>.TryConvertToSaturating<TOther>(IntPtr value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (value >= (IntPtr)255) ? byte.MaxValue : ((value <= (IntPtr)0) ? 0 : ((byte)value));
				result = (TOther)((object)b);
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (value >= (IntPtr)65535) ? char.MaxValue : ((value <= (IntPtr)0) ? '\0' : ((char)value));
				result = (TOther)((object)c);
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (long)value;
				result = (TOther)((object)num);
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (value >= (IntPtr)65535) ? ushort.MaxValue : ((value <= (IntPtr)0) ? 0 : ((ushort)value));
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = ((long)value >= (long)((ulong)-1)) ? uint.MaxValue : (((long)value <= 0L) ? 0U : ((uint)value));
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (ulong)((value <= (IntPtr)0) ? 0L : ((long)value));
				result = (TOther)((object)num4);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (value <= (IntPtr)0) ? UInt128.MinValue : ((UInt128)value);
				result = (TOther)((object)@uint);
				return true;
			}
			if (typeof(TOther) == typeof(UIntPtr))
			{
				UIntPtr uintPtr = (UIntPtr)((value <= (IntPtr)0) ? ((IntPtr)0) : value);
				result = (TOther)((object)uintPtr);
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00045C40 File Offset: 0x00043E40
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<IntPtr>.TryConvertToTruncating<TOther>(IntPtr value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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
				decimal num = (long)value;
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
				ulong num4 = (ulong)((long)value);
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
				result = (TOther)((object)((UIntPtr)value));
				return true;
			}
			result = default(TOther);
			return false;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00045DED File Offset: 0x00043FED
		IntPtr IShiftOperators<IntPtr, int, IntPtr>.op_LeftShift(IntPtr value, int shiftAmount)
		{
			return value << (shiftAmount & 8 * 8 - 1);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00045DFC File Offset: 0x00043FFC
		IntPtr IShiftOperators<IntPtr, int, IntPtr>.op_RightShift(IntPtr value, int shiftAmount)
		{
			return value >> (shiftAmount & 8 * 8 - 1);
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00045E0B File Offset: 0x0004400B
		IntPtr IShiftOperators<IntPtr, int, IntPtr>.op_UnsignedRightShift(IntPtr value, int shiftAmount)
		{
			return value >> (shiftAmount & 8 * 8 - 1);
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00044FA3 File Offset: 0x000431A3
		IntPtr ISignedNumber<IntPtr>.NegativeOne
		{
			get
			{
				return (IntPtr)(-1);
			}
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0002FA55 File Offset: 0x0002DC55
		IntPtr ISubtractionOperators<IntPtr, IntPtr, IntPtr>.op_Subtraction(IntPtr left, IntPtr right)
		{
			return left - right;
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00041384 File Offset: 0x0003F584
		IntPtr ISubtractionOperators<IntPtr, IntPtr, IntPtr>.op_CheckedSubtraction(IntPtr left, IntPtr right)
		{
			return checked(left - right);
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x0003046E File Offset: 0x0002E66E
		IntPtr IUnaryNegationOperators<IntPtr, IntPtr>.op_UnaryNegation(IntPtr value)
		{
			return -value;
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00045E1A File Offset: 0x0004401A
		IntPtr IUnaryNegationOperators<IntPtr, IntPtr>.op_CheckedUnaryNegation(IntPtr value)
		{
			return checked(unchecked((IntPtr)0) - value);
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00007B62 File Offset: 0x00005D62
		IntPtr IUnaryPlusOperators<IntPtr, IntPtr>.op_UnaryPlus(IntPtr value)
		{
			return value;
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00045E20 File Offset: 0x00044020
		public static IntPtr Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			return (IntPtr)long.Parse(utf8Text, style, provider);
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00045E2B File Offset: 0x0004402B
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out IntPtr result)
		{
			Unsafe.SkipInit<IntPtr>(out result);
			return long.TryParse(utf8Text, style, provider, Unsafe.As<IntPtr, long>(ref result));
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00045E41 File Offset: 0x00044041
		public static IntPtr Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return (IntPtr)long.Parse(utf8Text, provider);
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00045E4B File Offset: 0x0004404B
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out IntPtr result)
		{
			Unsafe.SkipInit<IntPtr>(out result);
			return long.TryParse(utf8Text, provider, Unsafe.As<IntPtr, long>(ref result));
		}

		// Token: 0x040004C7 RID: 1223
		private readonly IntPtr _value;

		// Token: 0x040004C8 RID: 1224
		[Intrinsic]
		public static readonly IntPtr Zero;
	}
}
