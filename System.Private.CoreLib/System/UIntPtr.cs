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
	// Token: 0x020001EB RID: 491
	[CLSCompliant(false)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct UIntPtr : IEquatable<UIntPtr>, IComparable, IComparable<UIntPtr>, ISpanFormattable, IFormattable, ISerializable, IBinaryInteger<UIntPtr>, IBinaryNumber<UIntPtr>, IBitwiseOperators<UIntPtr, UIntPtr, UIntPtr>, INumber<UIntPtr>, IComparisonOperators<UIntPtr, UIntPtr, bool>, IEqualityOperators<UIntPtr, UIntPtr, bool>, IModulusOperators<UIntPtr, UIntPtr, UIntPtr>, INumberBase<UIntPtr>, IAdditionOperators<UIntPtr, UIntPtr, UIntPtr>, IAdditiveIdentity<UIntPtr, UIntPtr>, IDecrementOperators<UIntPtr>, IDivisionOperators<UIntPtr, UIntPtr, UIntPtr>, IIncrementOperators<UIntPtr>, IMultiplicativeIdentity<UIntPtr, UIntPtr>, IMultiplyOperators<UIntPtr, UIntPtr, UIntPtr>, ISpanParsable<UIntPtr>, IParsable<UIntPtr>, ISubtractionOperators<UIntPtr, UIntPtr, UIntPtr>, IUnaryPlusOperators<UIntPtr, UIntPtr>, IUnaryNegationOperators<UIntPtr, UIntPtr>, IUtf8SpanFormattable, IUtf8SpanParsable<UIntPtr>, IShiftOperators<UIntPtr, int, UIntPtr>, IMinMaxValue<UIntPtr>, IUnsignedNumber<UIntPtr>
	{
		// Token: 0x0600271B RID: 10011 RVA: 0x00077012 File Offset: 0x00075212
		[NonVersionable]
		public UIntPtr(uint value)
		{
			this._value = (UIntPtr)value;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00077012 File Offset: 0x00075212
		[NonVersionable]
		public UIntPtr(ulong value)
		{
			this._value = (UIntPtr)value;
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x0007701C File Offset: 0x0007521C
		[NonVersionable]
		public unsafe UIntPtr(void* value)
		{
			this._value = value;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00077028 File Offset: 0x00075228
		private UIntPtr(SerializationInfo info, StreamingContext context)
		{
			ulong @uint = info.GetUInt64("value");
			this._value = (UIntPtr)@uint;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0007704C File Offset: 0x0007524C
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			ulong value = (ulong)this;
			info.AddValue("value", value);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00077074 File Offset: 0x00075274
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is UIntPtr)
			{
				UIntPtr other = (UIntPtr)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x0007709C File Offset: 0x0007529C
		public override int GetHashCode()
		{
			return ((ulong)this).GetHashCode();
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000770B4 File Offset: 0x000752B4
		[NonVersionable]
		public uint ToUInt32()
		{
			return checked((uint)this);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000770B9 File Offset: 0x000752B9
		[NonVersionable]
		public ulong ToUInt64()
		{
			return (ulong)this;
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000770BE File Offset: 0x000752BE
		[NonVersionable]
		public static explicit operator UIntPtr(uint value)
		{
			return (UIntPtr)value;
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000770C2 File Offset: 0x000752C2
		[NonVersionable]
		public static explicit operator UIntPtr(ulong value)
		{
			return checked((UIntPtr)value);
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00007B62 File Offset: 0x00005D62
		[NonVersionable]
		public unsafe static explicit operator UIntPtr(void* value)
		{
			return value;
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00007B62 File Offset: 0x00005D62
		[NonVersionable]
		public unsafe static explicit operator void*(UIntPtr value)
		{
			return value;
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x000770C6 File Offset: 0x000752C6
		[NonVersionable]
		public static explicit operator uint(UIntPtr value)
		{
			return checked((uint)value);
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00023841 File Offset: 0x00021A41
		[NonVersionable]
		public static explicit operator ulong(UIntPtr value)
		{
			return (ulong)value;
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x0000FF2A File Offset: 0x0000E12A
		[NonVersionable]
		public static bool operator ==(UIntPtr value1, UIntPtr value2)
		{
			return value1 == value2;
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x0001306A File Offset: 0x0001126A
		[NonVersionable]
		public static bool operator !=(UIntPtr value1, UIntPtr value2)
		{
			return value1 != value2;
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00044A76 File Offset: 0x00042C76
		[NonVersionable]
		public static UIntPtr Add(UIntPtr pointer, int offset)
		{
			return pointer + (UIntPtr)((IntPtr)offset);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00044A76 File Offset: 0x00042C76
		[NonVersionable]
		public static UIntPtr operator +(UIntPtr pointer, int offset)
		{
			return pointer + (UIntPtr)((IntPtr)offset);
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00044A7C File Offset: 0x00042C7C
		[NonVersionable]
		public static UIntPtr Subtract(UIntPtr pointer, int offset)
		{
			return pointer - (UIntPtr)((IntPtr)offset);
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00044A7C File Offset: 0x00042C7C
		[NonVersionable]
		public static UIntPtr operator -(UIntPtr pointer, int offset)
		{
			return pointer - (UIntPtr)((IntPtr)offset);
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x00044A82 File Offset: 0x00042C82
		public static int Size
		{
			[NonVersionable]
			get
			{
				return 8;
			}
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00044A89 File Offset: 0x00042C89
		[NonVersionable]
		public unsafe void* ToPointer()
		{
			return this;
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x000770CA File Offset: 0x000752CA
		public static UIntPtr MaxValue
		{
			[NonVersionable]
			get
			{
				return (UIntPtr)(-1L);
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06002733 RID: 10035 RVA: 0x00044C6C File Offset: 0x00042E6C
		public static UIntPtr MinValue
		{
			[NonVersionable]
			get
			{
				return (UIntPtr)((IntPtr)0);
			}
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x000770D0 File Offset: 0x000752D0
		[NullableContext(2)]
		public int CompareTo(object value)
		{
			if (value is UIntPtr)
			{
				UIntPtr value2 = (UIntPtr)value;
				return this.CompareTo(value2);
			}
			if (value == null)
			{
				return 1;
			}
			throw new ArgumentException(SR.Arg_MustBeUIntPtr);
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x00077103 File Offset: 0x00075303
		public int CompareTo(UIntPtr value)
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

		// Token: 0x06002736 RID: 10038 RVA: 0x00044AEC File Offset: 0x00042CEC
		[NonVersionable]
		public bool Equals(UIntPtr other)
		{
			return this == other;
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x00077114 File Offset: 0x00075314
		[NullableContext(1)]
		public override string ToString()
		{
			return ((ulong)this).ToString();
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x0007712C File Offset: 0x0007532C
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return ((ulong)this).ToString(format);
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x00077148 File Offset: 0x00075348
		[NullableContext(1)]
		public string ToString([Nullable(2)] IFormatProvider provider)
		{
			return ((ulong)this).ToString(provider);
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x00077164 File Offset: 0x00075364
		[NullableContext(2)]
		[return: Nullable(1)]
		public string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider provider)
		{
			return ((ulong)this).ToString(format, provider);
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x00077180 File Offset: 0x00075380
		public bool TryFormat(Span<char> destination, out int charsWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return ((ulong)this).TryFormat(destination, out charsWritten, format, provider);
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x000771A0 File Offset: 0x000753A0
		public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, [StringSyntax("NumericFormat")] ReadOnlySpan<char> format = default(ReadOnlySpan<char>), [Nullable(2)] IFormatProvider provider = null)
		{
			return ((ulong)this).TryFormat(utf8Destination, out bytesWritten, format, provider);
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x000771BD File Offset: 0x000753BD
		[NullableContext(1)]
		public static UIntPtr Parse(string s)
		{
			return (UIntPtr)ulong.Parse(s);
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000771C6 File Offset: 0x000753C6
		[NullableContext(1)]
		public static UIntPtr Parse(string s, NumberStyles style)
		{
			return (UIntPtr)ulong.Parse(s, style);
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000771D0 File Offset: 0x000753D0
		[NullableContext(1)]
		public static UIntPtr Parse(string s, [Nullable(2)] IFormatProvider provider)
		{
			return (UIntPtr)ulong.Parse(s, provider);
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x000771DA File Offset: 0x000753DA
		[NullableContext(1)]
		public static UIntPtr Parse(string s, NumberStyles style, [Nullable(2)] IFormatProvider provider)
		{
			return (UIntPtr)ulong.Parse(s, style, provider);
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x000771E5 File Offset: 0x000753E5
		public static UIntPtr Parse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider)
		{
			return (UIntPtr)ulong.Parse(s, provider);
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x000771EF File Offset: 0x000753EF
		public static UIntPtr Parse(ReadOnlySpan<char> s, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			return (UIntPtr)ulong.Parse(s, style, provider);
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000771FA File Offset: 0x000753FA
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, out UIntPtr result)
		{
			Unsafe.SkipInit<UIntPtr>(out result);
			return ulong.TryParse(s, Unsafe.As<UIntPtr, ulong>(ref result));
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x0007720E File Offset: 0x0007540E
		public static bool TryParse(ReadOnlySpan<char> s, [Nullable(2)] IFormatProvider provider, out UIntPtr result)
		{
			Unsafe.SkipInit<UIntPtr>(out result);
			return ulong.TryParse(s, provider, Unsafe.As<UIntPtr, ulong>(ref result));
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x00077223 File Offset: 0x00075423
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, out UIntPtr result)
		{
			Unsafe.SkipInit<UIntPtr>(out result);
			return ulong.TryParse(s, style, provider, Unsafe.As<UIntPtr, ulong>(ref result));
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x00077239 File Offset: 0x00075439
		public static bool TryParse(ReadOnlySpan<char> s, out UIntPtr result)
		{
			Unsafe.SkipInit<UIntPtr>(out result);
			return ulong.TryParse(s, Unsafe.As<UIntPtr, ulong>(ref result));
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0007724D File Offset: 0x0007544D
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, out UIntPtr result)
		{
			Unsafe.SkipInit<UIntPtr>(out result);
			return ulong.TryParse(utf8Text, Unsafe.As<UIntPtr, ulong>(ref result));
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00077261 File Offset: 0x00075461
		[NullableContext(2)]
		public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, out UIntPtr result)
		{
			Unsafe.SkipInit<UIntPtr>(out result);
			return ulong.TryParse(s, provider, Unsafe.As<UIntPtr, ulong>(ref result));
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x00077276 File Offset: 0x00075476
		public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, [Nullable(2)] IFormatProvider provider, out UIntPtr result)
		{
			Unsafe.SkipInit<UIntPtr>(out result);
			return ulong.TryParse(s, style, provider, Unsafe.As<UIntPtr, ulong>(ref result));
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0002EA29 File Offset: 0x0002CC29
		UIntPtr IAdditionOperators<UIntPtr, UIntPtr, UIntPtr>.op_Addition(UIntPtr left, UIntPtr right)
		{
			return left + right;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00073023 File Offset: 0x00071223
		UIntPtr IAdditionOperators<UIntPtr, UIntPtr, UIntPtr>.op_CheckedAddition(UIntPtr left, UIntPtr right)
		{
			return checked(left + right);
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x0600274C RID: 10060 RVA: 0x00044C6C File Offset: 0x00042E6C
		UIntPtr IAdditiveIdentity<UIntPtr, UIntPtr>.AdditiveIdentity
		{
			get
			{
				return (UIntPtr)((IntPtr)0);
			}
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x0007728C File Offset: 0x0007548C
		[return: TupleElementNames(new string[]
		{
			"Quotient",
			"Remainder"
		})]
		public static ValueTuple<UIntPtr, UIntPtr> DivRem(UIntPtr left, UIntPtr right)
		{
			return Math.DivRem(left, right);
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x00044C79 File Offset: 0x00042E79
		[Intrinsic]
		public static UIntPtr LeadingZeroCount(UIntPtr value)
		{
			return (UIntPtr)((IntPtr)BitOperations.LeadingZeroCount(value));
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00044C82 File Offset: 0x00042E82
		[Intrinsic]
		public static UIntPtr PopCount(UIntPtr value)
		{
			return (UIntPtr)((IntPtr)BitOperations.PopCount(value));
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x00044C8B File Offset: 0x00042E8B
		[Intrinsic]
		public static UIntPtr RotateLeft(UIntPtr value, int rotateAmount)
		{
			return BitOperations.RotateLeft(value, rotateAmount);
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00044C94 File Offset: 0x00042E94
		[Intrinsic]
		public static UIntPtr RotateRight(UIntPtr value, int rotateAmount)
		{
			return BitOperations.RotateRight(value, rotateAmount);
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00077295 File Offset: 0x00075495
		[Intrinsic]
		public static UIntPtr TrailingZeroCount(UIntPtr value)
		{
			return (UIntPtr)((IntPtr)BitOperations.TrailingZeroCount(value));
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x000772A0 File Offset: 0x000754A0
		unsafe bool IBinaryInteger<UIntPtr>.TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out UIntPtr value)
		{
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[0])))
				{
					value = uintPtr;
					return false;
				}
				if (source.Length > 8)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(0, ptr.Length - 8).ContainsAnyExcept(0))
					{
						value = uintPtr;
						return false;
					}
				}
				ref byte source2 = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 8)
				{
					source2 = Unsafe.Add<byte>(ref source2, source.Length - 8);
					uintPtr = Unsafe.ReadUnaligned<UIntPtr>(ref source2);
					bool isLittleEndian = BitConverter.IsLittleEndian;
					uintPtr = BinaryPrimitives.ReverseEndianness(uintPtr);
				}
				else
				{
					for (int i = 0; i < source.Length; i++)
					{
						uintPtr <<= 8;
						uintPtr |= (UIntPtr)(*Unsafe.Add<byte>(ref source2, i));
					}
				}
			}
			value = uintPtr;
			return true;
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0007735C File Offset: 0x0007555C
		unsafe bool IBinaryInteger<UIntPtr>.TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out UIntPtr value)
		{
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			if (source.Length != 0)
			{
				if (!isUnsigned && sbyte.IsNegative((sbyte)(*source[source.Length - 1])))
				{
					value = uintPtr;
					return false;
				}
				if (source.Length > 8)
				{
					ref ReadOnlySpan<byte> ptr = ref source;
					if (ptr.Slice(8, ptr.Length - 8).ContainsAnyExcept(0))
					{
						value = uintPtr;
						return false;
					}
				}
				ref byte reference = ref MemoryMarshal.GetReference<byte>(source);
				if (source.Length >= 8)
				{
					uintPtr = Unsafe.ReadUnaligned<UIntPtr>(ref reference);
					if (BitConverter.IsLittleEndian)
					{
						goto IL_AB;
					}
				}
				for (int i = 0; i < source.Length; i++)
				{
					UIntPtr uintPtr2 = (UIntPtr)(*Unsafe.Add<byte>(ref reference, i));
					uintPtr2 <<= (i * 8 & 8 * 8 - 1);
					uintPtr |= uintPtr2;
				}
			}
			IL_AB:
			value = uintPtr;
			return true;
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x00077418 File Offset: 0x00075618
		int IBinaryInteger<UIntPtr>.GetShortestBitLength()
		{
			return 64 - BitOperations.LeadingZeroCount(this);
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		int IBinaryInteger<UIntPtr>.GetByteCount()
		{
			return 8;
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x00077424 File Offset: 0x00075624
		bool IBinaryInteger<UIntPtr>.TryWriteBigEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				ulong value = (ulong)this;
				bool isLittleEndian = BitConverter.IsLittleEndian;
				value = BinaryPrimitives.ReverseEndianness(value);
				Unsafe.WriteUnaligned<ulong>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00077464 File Offset: 0x00075664
		bool IBinaryInteger<UIntPtr>.TryWriteLittleEndian(Span<byte> destination, out int bytesWritten)
		{
			if (destination.Length >= 8)
			{
				ulong value = (ulong)this;
				if (!BitConverter.IsLittleEndian)
				{
				}
				Unsafe.WriteUnaligned<ulong>(MemoryMarshal.GetReference<byte>(destination), value);
				bytesWritten = 8;
				return true;
			}
			bytesWritten = 0;
			return false;
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06002759 RID: 10073 RVA: 0x000770CA File Offset: 0x000752CA
		UIntPtr IBinaryNumber<UIntPtr>.AllBitsSet
		{
			[NonVersionable]
			get
			{
				return (UIntPtr)(-1L);
			}
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x0007749B File Offset: 0x0007569B
		public static bool IsPow2(UIntPtr value)
		{
			return BitOperations.IsPow2(value);
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000774A3 File Offset: 0x000756A3
		[Intrinsic]
		public static UIntPtr Log2(UIntPtr value)
		{
			return (UIntPtr)((IntPtr)BitOperations.Log2(value));
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x00040597 File Offset: 0x0003E797
		UIntPtr IBitwiseOperators<UIntPtr, UIntPtr, UIntPtr>.op_BitwiseAnd(UIntPtr left, UIntPtr right)
		{
			return left & right;
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x0004059C File Offset: 0x0003E79C
		UIntPtr IBitwiseOperators<UIntPtr, UIntPtr, UIntPtr>.op_BitwiseOr(UIntPtr left, UIntPtr right)
		{
			return left | right;
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000405A1 File Offset: 0x0003E7A1
		UIntPtr IBitwiseOperators<UIntPtr, UIntPtr, UIntPtr>.op_ExclusiveOr(UIntPtr left, UIntPtr right)
		{
			return left ^ right;
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000405A6 File Offset: 0x0003E7A6
		UIntPtr IBitwiseOperators<UIntPtr, UIntPtr, UIntPtr>.op_OnesComplement(UIntPtr value)
		{
			return ~value;
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00073232 File Offset: 0x00071432
		bool IComparisonOperators<UIntPtr, UIntPtr, bool>.op_LessThan(UIntPtr left, UIntPtr right)
		{
			return left < right;
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x0002E7F1 File Offset: 0x0002C9F1
		bool IComparisonOperators<UIntPtr, UIntPtr, bool>.op_LessThanOrEqual(UIntPtr left, UIntPtr right)
		{
			return left <= right;
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x000413DF File Offset: 0x0003F5DF
		bool IComparisonOperators<UIntPtr, UIntPtr, bool>.op_GreaterThan(UIntPtr left, UIntPtr right)
		{
			return left > right;
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x0002E7FA File Offset: 0x0002C9FA
		bool IComparisonOperators<UIntPtr, UIntPtr, bool>.op_GreaterThanOrEqual(UIntPtr left, UIntPtr right)
		{
			return left >= right;
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x000405AA File Offset: 0x0003E7AA
		UIntPtr IDecrementOperators<UIntPtr>.op_Decrement(UIntPtr value)
		{
			return --value;
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00073238 File Offset: 0x00071438
		UIntPtr IDecrementOperators<UIntPtr>.op_CheckedDecrement(UIntPtr value)
		{
			return checked(--value);
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00073240 File Offset: 0x00071440
		UIntPtr IDivisionOperators<UIntPtr, UIntPtr, UIntPtr>.op_Division(UIntPtr left, UIntPtr right)
		{
			return left / right;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x000405BA File Offset: 0x0003E7BA
		UIntPtr IIncrementOperators<UIntPtr>.op_Increment(UIntPtr value)
		{
			return ++value;
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00073245 File Offset: 0x00071445
		UIntPtr IIncrementOperators<UIntPtr>.op_CheckedIncrement(UIntPtr value)
		{
			return checked(++value);
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x000774AC File Offset: 0x000756AC
		UIntPtr IMinMaxValue<UIntPtr>.MinValue
		{
			get
			{
				return UIntPtr.MinValue;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x000774B3 File Offset: 0x000756B3
		UIntPtr IMinMaxValue<UIntPtr>.MaxValue
		{
			get
			{
				return UIntPtr.MaxValue;
			}
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x0007324D File Offset: 0x0007144D
		UIntPtr IModulusOperators<UIntPtr, UIntPtr, UIntPtr>.op_Modulus(UIntPtr left, UIntPtr right)
		{
			return left % right;
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x00044FD0 File Offset: 0x000431D0
		UIntPtr IMultiplicativeIdentity<UIntPtr, UIntPtr>.MultiplicativeIdentity
		{
			get
			{
				return (UIntPtr)((IntPtr)1);
			}
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x0002EE5D File Offset: 0x0002D05D
		UIntPtr IMultiplyOperators<UIntPtr, UIntPtr, UIntPtr>.op_Multiply(UIntPtr left, UIntPtr right)
		{
			return left * right;
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00073252 File Offset: 0x00071452
		UIntPtr IMultiplyOperators<UIntPtr, UIntPtr, UIntPtr>.op_CheckedMultiply(UIntPtr left, UIntPtr right)
		{
			return checked(left * right);
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x000774BA File Offset: 0x000756BA
		public static UIntPtr Clamp(UIntPtr value, UIntPtr min, UIntPtr max)
		{
			return Math.Clamp(value, min, max);
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00007B62 File Offset: 0x00005D62
		UIntPtr INumber<UIntPtr>.CopySign(UIntPtr value, UIntPtr sign)
		{
			return value;
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x000774C4 File Offset: 0x000756C4
		public static UIntPtr Max(UIntPtr x, UIntPtr y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x000774CD File Offset: 0x000756CD
		UIntPtr INumber<UIntPtr>.MaxNumber(UIntPtr x, UIntPtr y)
		{
			return UIntPtr.Max(x, y);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x000774D6 File Offset: 0x000756D6
		public static UIntPtr Min(UIntPtr x, UIntPtr y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x000774DF File Offset: 0x000756DF
		UIntPtr INumber<UIntPtr>.MinNumber(UIntPtr x, UIntPtr y)
		{
			return UIntPtr.Min(x, y);
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00045157 File Offset: 0x00043357
		public static int Sign(UIntPtr value)
		{
			return (value > (UIntPtr)((IntPtr)0)) ? 1 : 0;
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x00044FD0 File Offset: 0x000431D0
		UIntPtr INumberBase<UIntPtr>.One
		{
			get
			{
				return (UIntPtr)((IntPtr)1);
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int INumberBase<UIntPtr>.Radix
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x00044C6C File Offset: 0x00042E6C
		UIntPtr INumberBase<UIntPtr>.Zero
		{
			get
			{
				return (UIntPtr)((IntPtr)0);
			}
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x00007B62 File Offset: 0x00005D62
		UIntPtr INumberBase<UIntPtr>.Abs(UIntPtr value)
		{
			return value;
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x000774E8 File Offset: 0x000756E8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr CreateChecked<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			UIntPtr result;
			if (typeof(TOther) == typeof(UIntPtr))
			{
				result = (UIntPtr)((object)value);
			}
			else if (!UIntPtr.TryConvertFromChecked<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToChecked<UIntPtr>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x00077540 File Offset: 0x00075740
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr CreateSaturating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			UIntPtr result;
			if (typeof(TOther) == typeof(UIntPtr))
			{
				result = (UIntPtr)((object)value);
			}
			else if (!UIntPtr.TryConvertFromSaturating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToSaturating<UIntPtr>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x00077598 File Offset: 0x00075798
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr CreateTruncating<[Nullable(0)] TOther>(TOther value) where TOther : INumberBase<TOther>
		{
			UIntPtr result;
			if (typeof(TOther) == typeof(UIntPtr))
			{
				result = (UIntPtr)((object)value);
			}
			else if (!UIntPtr.TryConvertFromTruncating<TOther>(value, out result) && !INumberBase<TOther>.TryConvertToTruncating<UIntPtr>(value, out result))
			{
				ThrowHelper.ThrowNotSupportedException();
			}
			return result;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<UIntPtr>.IsCanonical(UIntPtr value)
		{
			return true;
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UIntPtr>.IsComplexNumber(UIntPtr value)
		{
			return false;
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00045146 File Offset: 0x00043346
		public static bool IsEvenInteger(UIntPtr value)
		{
			return (value & (UIntPtr)((IntPtr)1)) == (UIntPtr)((IntPtr)0);
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<UIntPtr>.IsFinite(UIntPtr value)
		{
			return true;
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UIntPtr>.IsImaginaryNumber(UIntPtr value)
		{
			return false;
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UIntPtr>.IsInfinity(UIntPtr value)
		{
			return false;
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<UIntPtr>.IsInteger(UIntPtr value)
		{
			return true;
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UIntPtr>.IsNaN(UIntPtr value)
		{
			return false;
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UIntPtr>.IsNegative(UIntPtr value)
		{
			return false;
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UIntPtr>.IsNegativeInfinity(UIntPtr value)
		{
			return false;
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x00045157 File Offset: 0x00043357
		bool INumberBase<UIntPtr>.IsNormal(UIntPtr value)
		{
			return value > (UIntPtr)((IntPtr)0);
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x0004515E File Offset: 0x0004335E
		public static bool IsOddInteger(UIntPtr value)
		{
			return (value & (UIntPtr)((IntPtr)1)) > (UIntPtr)((IntPtr)0);
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<UIntPtr>.IsPositive(UIntPtr value)
		{
			return true;
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UIntPtr>.IsPositiveInfinity(UIntPtr value)
		{
			return false;
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x000070DD File Offset: 0x000052DD
		bool INumberBase<UIntPtr>.IsRealNumber(UIntPtr value)
		{
			return true;
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x00007B65 File Offset: 0x00005D65
		bool INumberBase<UIntPtr>.IsSubnormal(UIntPtr value)
		{
			return false;
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x00045172 File Offset: 0x00043372
		bool INumberBase<UIntPtr>.IsZero(UIntPtr value)
		{
			return value == (UIntPtr)((IntPtr)0);
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x000774CD File Offset: 0x000756CD
		UIntPtr INumberBase<UIntPtr>.MaxMagnitude(UIntPtr x, UIntPtr y)
		{
			return UIntPtr.Max(x, y);
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x000774CD File Offset: 0x000756CD
		UIntPtr INumberBase<UIntPtr>.MaxMagnitudeNumber(UIntPtr x, UIntPtr y)
		{
			return UIntPtr.Max(x, y);
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x000774DF File Offset: 0x000756DF
		UIntPtr INumberBase<UIntPtr>.MinMagnitude(UIntPtr x, UIntPtr y)
		{
			return UIntPtr.Min(x, y);
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x000774DF File Offset: 0x000756DF
		UIntPtr INumberBase<UIntPtr>.MinMagnitudeNumber(UIntPtr x, UIntPtr y)
		{
			return UIntPtr.Min(x, y);
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x0002F0EE File Offset: 0x0002D2EE
		UIntPtr INumberBase<UIntPtr>.MultiplyAddEstimate(UIntPtr left, UIntPtr right, UIntPtr addend)
		{
			return left * right + addend;
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x000775EE File Offset: 0x000757EE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UIntPtr>.TryConvertFromChecked<TOther>(TOther value, out UIntPtr result) where TOther : INumberBase<TOther>
		{
			return UIntPtr.TryConvertFromChecked<TOther>(value, out result);
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x000775F8 File Offset: 0x000757F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromChecked<TOther>(TOther value, out UIntPtr result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (UIntPtr)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (UIntPtr)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal value2 = (decimal)((object)value);
				result = checked((UIntPtr)((ulong)value2));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num = (ushort)((object)value);
				result = (UIntPtr)num;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num2 = (uint)((object)value);
				result = (UIntPtr)num2;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num3 = (ulong)((object)value);
				result = checked((UIntPtr)num3);
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 value3 = (UInt128)((object)value);
				result = UInt128.op_CheckedExplicit(value3);
				return true;
			}
			result = (UIntPtr)((IntPtr)0);
			return false;
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x00077754 File Offset: 0x00075954
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UIntPtr>.TryConvertFromSaturating<TOther>(TOther value, out UIntPtr result) where TOther : INumberBase<TOther>
		{
			return UIntPtr.TryConvertFromSaturating<TOther>(value, out result);
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x00077760 File Offset: 0x00075960
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromSaturating<TOther>(TOther value, out UIntPtr result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (UIntPtr)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (UIntPtr)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 18446744073709551615m) ? ((UIntPtr)(-1L)) : ((UIntPtr)((num <= 0m) ? ((IntPtr)0) : ((IntPtr)((UIntPtr)((ulong)num))))));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)((object)value);
				result = (UIntPtr)num2;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)((object)value);
				result = (UIntPtr)num3;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (ulong)((object)value);
				result = ((num4 >= ulong.MaxValue) ? ((UIntPtr)(-1L)) : ((UIntPtr)num4));
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 @uint = (UInt128)((object)value);
				result = ((@uint >= ulong.MaxValue) ? ((UIntPtr)(-1L)) : ((UIntPtr)@uint));
				return true;
			}
			result = (UIntPtr)((IntPtr)0);
			return false;
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00077901 File Offset: 0x00075B01
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UIntPtr>.TryConvertFromTruncating<TOther>(TOther value, out UIntPtr result) where TOther : INumberBase<TOther>
		{
			return UIntPtr.TryConvertFromTruncating<TOther>(value, out result);
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x0007790C File Offset: 0x00075B0C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool TryConvertFromTruncating<TOther>(TOther value, out UIntPtr result) where TOther : INumberBase<TOther>
		{
			if (typeof(TOther) == typeof(byte))
			{
				byte b = (byte)((object)value);
				result = (UIntPtr)b;
				return true;
			}
			if (typeof(TOther) == typeof(char))
			{
				char c = (char)((object)value);
				result = (UIntPtr)c;
				return true;
			}
			if (typeof(TOther) == typeof(decimal))
			{
				decimal num = (decimal)((object)value);
				result = ((num >= 18446744073709551615m) ? ((UIntPtr)(-1L)) : ((UIntPtr)((num <= 0m) ? ((IntPtr)0) : ((IntPtr)((UIntPtr)((ulong)num))))));
				return true;
			}
			if (typeof(TOther) == typeof(ushort))
			{
				ushort num2 = (ushort)((object)value);
				result = (UIntPtr)num2;
				return true;
			}
			if (typeof(TOther) == typeof(uint))
			{
				uint num3 = (uint)((object)value);
				result = (UIntPtr)num3;
				return true;
			}
			if (typeof(TOther) == typeof(ulong))
			{
				ulong num4 = (ulong)((object)value);
				result = (UIntPtr)num4;
				return true;
			}
			if (typeof(TOther) == typeof(UInt128))
			{
				UInt128 value2 = (UInt128)((object)value);
				result = (UIntPtr)value2;
				return true;
			}
			result = (UIntPtr)((IntPtr)0);
			return false;
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00077A90 File Offset: 0x00075C90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UIntPtr>.TryConvertToChecked<TOther>(UIntPtr value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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
					long num4 = (long)value;
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

		// Token: 0x0600279A RID: 10138 RVA: 0x00077C74 File Offset: 0x00075E74
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UIntPtr>.TryConvertToSaturating<TOther>(UIntPtr value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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
				short num2 = (value >= (UIntPtr)((IntPtr)32767)) ? short.MaxValue : ((short)value);
				result = (TOther)((object)num2);
				return true;
			}
			if (typeof(TOther) == typeof(int))
			{
				int num3 = (value >= (UIntPtr)((IntPtr)int.MaxValue)) ? int.MaxValue : ((int)value);
				result = (TOther)((object)num3);
				return true;
			}
			if (typeof(TOther) == typeof(long))
			{
				long num4 = (long)(((ulong)value >= 9223372036854775807UL) ? 9223372036854775807UL : ((ulong)value));
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
				IntPtr intPtr = (value >= (UIntPtr)IntPtr.MaxValue) ? IntPtr.MaxValue : ((IntPtr)value);
				result = (TOther)((object)intPtr);
				return true;
			}
			if (typeof(TOther) == typeof(sbyte))
			{
				sbyte b = (value >= (UIntPtr)((IntPtr)127)) ? sbyte.MaxValue : ((sbyte)value);
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

		// Token: 0x0600279B RID: 10139 RVA: 0x00077EA8 File Offset: 0x000760A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		bool INumberBase<UIntPtr>.TryConvertToTruncating<TOther>(UIntPtr value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther>
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
				int num3 = (int)value;
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
				result = (TOther)((object)((IntPtr)value));
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

		// Token: 0x0600279C RID: 10140 RVA: 0x00045DED File Offset: 0x00043FED
		UIntPtr IShiftOperators<UIntPtr, int, UIntPtr>.op_LeftShift(UIntPtr value, int shiftAmount)
		{
			return value << (shiftAmount & 8 * 8 - 1);
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x00045E0B File Offset: 0x0004400B
		UIntPtr IShiftOperators<UIntPtr, int, UIntPtr>.op_RightShift(UIntPtr value, int shiftAmount)
		{
			return value >> (shiftAmount & 8 * 8 - 1);
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x00045E0B File Offset: 0x0004400B
		UIntPtr IShiftOperators<UIntPtr, int, UIntPtr>.op_UnsignedRightShift(UIntPtr value, int shiftAmount)
		{
			return value >> (shiftAmount & 8 * 8 - 1);
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x0002FA55 File Offset: 0x0002DC55
		UIntPtr ISubtractionOperators<UIntPtr, UIntPtr, UIntPtr>.op_Subtraction(UIntPtr left, UIntPtr right)
		{
			return left - right;
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00073E05 File Offset: 0x00072005
		UIntPtr ISubtractionOperators<UIntPtr, UIntPtr, UIntPtr>.op_CheckedSubtraction(UIntPtr left, UIntPtr right)
		{
			return checked(left - right);
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x00078089 File Offset: 0x00076289
		UIntPtr IUnaryNegationOperators<UIntPtr, UIntPtr>.op_UnaryNegation(UIntPtr value)
		{
			return (UIntPtr)((IntPtr)0 - (IntPtr)value);
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x0007808F File Offset: 0x0007628F
		UIntPtr IUnaryNegationOperators<UIntPtr, UIntPtr>.op_CheckedUnaryNegation(UIntPtr value)
		{
			return (UIntPtr)(checked(unchecked((IntPtr)0) - (IntPtr)value));
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00007B62 File Offset: 0x00005D62
		UIntPtr IUnaryPlusOperators<UIntPtr, UIntPtr>.op_UnaryPlus(UIntPtr value)
		{
			return value;
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00078095 File Offset: 0x00076295
		public static UIntPtr Parse(ReadOnlySpan<byte> utf8Text, NumberStyles style = NumberStyles.Integer, [Nullable(2)] IFormatProvider provider = null)
		{
			return (UIntPtr)ulong.Parse(utf8Text, style, provider);
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000780A0 File Offset: 0x000762A0
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, NumberStyles style, [Nullable(2)] IFormatProvider provider, out UIntPtr result)
		{
			Unsafe.SkipInit<UIntPtr>(out result);
			return ulong.TryParse(utf8Text, style, provider, Unsafe.As<UIntPtr, ulong>(ref result));
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000780B6 File Offset: 0x000762B6
		public static UIntPtr Parse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider)
		{
			return (UIntPtr)ulong.Parse(utf8Text, provider);
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000780C0 File Offset: 0x000762C0
		public static bool TryParse(ReadOnlySpan<byte> utf8Text, [Nullable(2)] IFormatProvider provider, out UIntPtr result)
		{
			Unsafe.SkipInit<UIntPtr>(out result);
			return ulong.TryParse(utf8Text, provider, Unsafe.As<UIntPtr, ulong>(ref result));
		}

		// Token: 0x040006ED RID: 1773
		private readonly UIntPtr _value;

		// Token: 0x040006EE RID: 1774
		[Intrinsic]
		public static readonly UIntPtr Zero;
	}
}
