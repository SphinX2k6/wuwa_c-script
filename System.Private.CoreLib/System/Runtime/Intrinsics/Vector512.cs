using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Runtime.Intrinsics
{
	// Token: 0x02000549 RID: 1353
	public static class Vector512
	{
		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06004D3D RID: 19773 RVA: 0x00007B65 File Offset: 0x00005D65
		public static bool IsHardwareAccelerated
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x000FE108 File Offset: 0x000FC308
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Abs<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return vector;
			}
			return Vector512.Create<T>(Vector256.Abs<T>(vector._lower), Vector256.Abs<T>(vector._upper));
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x000FE1B9 File Offset: 0x000FC3B9
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Add<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return left + right;
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x000FE1C2 File Offset: 0x000FC3C2
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> AndNot<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return left & ~right;
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x000FE1D0 File Offset: 0x000FC3D0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector512<TTo> As<TFrom, TTo>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<TFrom> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<TFrom>();
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<TTo>();
			return *Unsafe.As<Vector512<TFrom>, Vector512<TTo>>(ref vector);
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x000FE1E8 File Offset: 0x000FC3E8
		[Intrinsic]
		public static Vector512<byte> AsByte<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, byte>();
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x000FE1F0 File Offset: 0x000FC3F0
		[Intrinsic]
		public static Vector512<double> AsDouble<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, double>();
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x000FE1F8 File Offset: 0x000FC3F8
		[Intrinsic]
		public static Vector512<short> AsInt16<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, short>();
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x000FE200 File Offset: 0x000FC400
		[Intrinsic]
		public static Vector512<int> AsInt32<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, int>();
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x000FE208 File Offset: 0x000FC408
		[Intrinsic]
		public static Vector512<long> AsInt64<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, long>();
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x000FE210 File Offset: 0x000FC410
		[Intrinsic]
		public static Vector512<IntPtr> AsNInt<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, IntPtr>();
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x000FE218 File Offset: 0x000FC418
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<UIntPtr> AsNUInt<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, UIntPtr>();
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x000FE220 File Offset: 0x000FC420
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<sbyte> AsSByte<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, sbyte>();
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x000FE228 File Offset: 0x000FC428
		[Intrinsic]
		public static Vector512<float> AsSingle<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, float>();
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x000FE230 File Offset: 0x000FC430
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ushort> AsUInt16<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, ushort>();
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x000FE238 File Offset: 0x000FC438
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<uint> AsUInt32<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, uint>();
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x000FE240 File Offset: 0x000FC440
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ulong> AsUInt64<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return vector.As<T, ulong>();
		}

		// Token: 0x06004D4E RID: 19790 RVA: 0x000FE248 File Offset: 0x000FC448
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> AsVector512<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			Vector512<T> result = default(Vector512<T>);
			Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<Vector512<T>, byte>(ref result), value);
			return result;
		}

		// Token: 0x06004D4F RID: 19791 RVA: 0x000FE270 File Offset: 0x000FC470
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> AsVector<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			return Unsafe.ReadUnaligned<Vector<T>>(Unsafe.As<Vector512<T>, byte>(ref value));
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x000FE283 File Offset: 0x000FC483
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> BitwiseAnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return left & right;
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x000FE28C File Offset: 0x000FC48C
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> BitwiseOr<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return left | right;
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x000FE298 File Offset: 0x000FC498
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector512<T> Ceiling<T>(Vector512<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector512.Create<T>(Vector256.Ceiling<T>(vector._lower), Vector256.Ceiling<T>(vector._upper));
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x000FE3DF File Offset: 0x000FC5DF
		[Intrinsic]
		public static Vector512<float> Ceiling(Vector512<float> vector)
		{
			return Vector512.Ceiling<float>(vector);
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x000FE3E7 File Offset: 0x000FC5E7
		[Intrinsic]
		public static Vector512<double> Ceiling(Vector512<double> vector)
		{
			return Vector512.Ceiling<double>(vector);
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x000FE3EF File Offset: 0x000FC5EF
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Clamp<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> min, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> max)
		{
			return Vector512.Min<T>(Vector512.Max<T>(value, min), max);
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x000FE3FE File Offset: 0x000FC5FE
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> ClampNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> min, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> max)
		{
			return Vector512.MinNative<T>(Vector512.MaxNative<T>(value, min), max);
		}

		// Token: 0x06004D57 RID: 19799 RVA: 0x000FE40D File Offset: 0x000FC60D
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> ConditionalSelect<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> condition, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return (left & condition) | Vector512.AndNot<T>(right, condition);
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x000FE422 File Offset: 0x000FC622
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> ConvertToDouble(Vector512<long> vector)
		{
			return Vector512.Create(Vector256.ConvertToDouble(vector._lower), Vector256.ConvertToDouble(vector._upper));
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x000FE43F File Offset: 0x000FC63F
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> ConvertToDouble(Vector512<ulong> vector)
		{
			return Vector512.Create(Vector256.ConvertToDouble(vector._lower), Vector256.ConvertToDouble(vector._upper));
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x000FE45C File Offset: 0x000FC65C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<int> ConvertToInt32(Vector512<float> vector)
		{
			return Vector512.Create(Vector256.ConvertToInt32(vector._lower), Vector256.ConvertToInt32(vector._upper));
		}

		// Token: 0x06004D5B RID: 19803 RVA: 0x000FE479 File Offset: 0x000FC679
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<int> ConvertToInt32Native(Vector512<float> vector)
		{
			return Vector512.Create(Vector256.ConvertToInt32Native(vector._lower), Vector256.ConvertToInt32Native(vector._upper));
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x000FE496 File Offset: 0x000FC696
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<long> ConvertToInt64(Vector512<double> vector)
		{
			return Vector512.Create(Vector256.ConvertToInt64(vector._lower), Vector256.ConvertToInt64(vector._upper));
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x000FE4B3 File Offset: 0x000FC6B3
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<long> ConvertToInt64Native(Vector512<double> vector)
		{
			return Vector512.Create(Vector256.ConvertToInt64Native(vector._lower), Vector256.ConvertToInt64Native(vector._upper));
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x000FE4D0 File Offset: 0x000FC6D0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> ConvertToSingle(Vector512<int> vector)
		{
			return Vector512.Create(Vector256.ConvertToSingle(vector._lower), Vector256.ConvertToSingle(vector._upper));
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x000FE4ED File Offset: 0x000FC6ED
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> ConvertToSingle(Vector512<uint> vector)
		{
			return Vector512.Create(Vector256.ConvertToSingle(vector._lower), Vector256.ConvertToSingle(vector._upper));
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x000FE50A File Offset: 0x000FC70A
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<uint> ConvertToUInt32(Vector512<float> vector)
		{
			return Vector512.Create(Vector256.ConvertToUInt32(vector._lower), Vector256.ConvertToUInt32(vector._upper));
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x000FE527 File Offset: 0x000FC727
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<uint> ConvertToUInt32Native(Vector512<float> vector)
		{
			return Vector512.Create(Vector256.ConvertToUInt32Native(vector._lower), Vector256.ConvertToUInt32Native(vector._upper));
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x000FE544 File Offset: 0x000FC744
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<ulong> ConvertToUInt64(Vector512<double> vector)
		{
			return Vector512.Create(Vector256.ConvertToUInt64(vector._lower), Vector256.ConvertToUInt64(vector._upper));
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x000FE561 File Offset: 0x000FC761
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<ulong> ConvertToUInt64Native(Vector512<double> vector)
		{
			return Vector512.Create(Vector256.ConvertToUInt64Native(vector._lower), Vector256.ConvertToUInt64Native(vector._upper));
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x000FE580 File Offset: 0x000FC780
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> CopySign<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> sign)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return value;
			}
			if (false)
			{
			}
			return Vector512.Create<T>(Vector256.CopySign<T>(value._lower, sign._lower), Vector256.CopySign<T>(value._upper, sign._upper));
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x000FE640 File Offset: 0x000FC840
		[NullableContext(1)]
		public static void CopyTo<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector, T[] destination)
		{
			if (destination.Length < Vector512<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<T, byte>(ref destination[0]), vector);
		}

		// Token: 0x06004D66 RID: 19814 RVA: 0x000FE663 File Offset: 0x000FC863
		[NullableContext(1)]
		public static void CopyTo<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector, T[] destination, int startIndex)
		{
			if (startIndex >= destination.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
			}
			if (destination.Length - startIndex < Vector512<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<T, byte>(ref destination[startIndex]), vector);
		}

		// Token: 0x06004D67 RID: 19815 RVA: 0x000FE693 File Offset: 0x000FC893
		[NullableContext(2)]
		public static void CopyTo<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (destination.Length < Vector512<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(destination)), vector);
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x000FE6B9 File Offset: 0x000FC8B9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> Cos(Vector512<double> vector)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Cos(vector._lower), Vector256.Cos(vector._upper));
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x000FE6D9 File Offset: 0x000FC8D9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> Cos(Vector512<float> vector)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Cos(vector._lower), Vector256.Cos(vector._upper));
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x000FE6F9 File Offset: 0x000FC8F9
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Create<[Nullable(2)] T>(T value)
		{
			Vector256<T> vector = Vector256.Create<T>(value);
			return Vector512.Create<T>(vector, vector);
		}

		// Token: 0x06004D6B RID: 19819 RVA: 0x000FE707 File Offset: 0x000FC907
		[Intrinsic]
		public static Vector512<byte> Create(byte value)
		{
			return Vector512.Create<byte>(value);
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x000FE70F File Offset: 0x000FC90F
		[Intrinsic]
		public static Vector512<double> Create(double value)
		{
			return Vector512.Create<double>(value);
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x000FE717 File Offset: 0x000FC917
		[Intrinsic]
		public static Vector512<short> Create(short value)
		{
			return Vector512.Create<short>(value);
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x000FE71F File Offset: 0x000FC91F
		[Intrinsic]
		public static Vector512<int> Create(int value)
		{
			return Vector512.Create<int>(value);
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x000FE727 File Offset: 0x000FC927
		[Intrinsic]
		public static Vector512<long> Create(long value)
		{
			return Vector512.Create<long>(value);
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x000FE72F File Offset: 0x000FC92F
		[Intrinsic]
		public static Vector512<IntPtr> Create(IntPtr value)
		{
			return Vector512.Create<IntPtr>(value);
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x000FE737 File Offset: 0x000FC937
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<UIntPtr> Create(UIntPtr value)
		{
			return Vector512.Create<UIntPtr>(value);
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x000FE73F File Offset: 0x000FC93F
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<sbyte> Create(sbyte value)
		{
			return Vector512.Create<sbyte>(value);
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x000FE747 File Offset: 0x000FC947
		[Intrinsic]
		public static Vector512<float> Create(float value)
		{
			return Vector512.Create<float>(value);
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x000FE74F File Offset: 0x000FC94F
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ushort> Create(ushort value)
		{
			return Vector512.Create<ushort>(value);
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x000FE757 File Offset: 0x000FC957
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<uint> Create(uint value)
		{
			return Vector512.Create<uint>(value);
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x000FE75F File Offset: 0x000FC95F
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ulong> Create(ulong value)
		{
			return Vector512.Create<ulong>(value);
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x000FE767 File Offset: 0x000FC967
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Create<[Nullable(2)] T>(T[] values)
		{
			if (values.Length < Vector512<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return Unsafe.ReadUnaligned<Vector512<T>>(Unsafe.As<T, byte>(ref values[0]));
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x000FE789 File Offset: 0x000FC989
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Create<[Nullable(2)] T>(T[] values, int index)
		{
			if (index < 0 || values.Length - index < Vector512<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return Unsafe.ReadUnaligned<Vector512<T>>(Unsafe.As<T, byte>(ref values[index]));
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x000FE7B1 File Offset: 0x000FC9B1
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values)
		{
			if (values.Length < Vector512<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.values);
			}
			return Unsafe.ReadUnaligned<Vector512<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(values)));
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x000FE7D8 File Offset: 0x000FC9D8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<byte> Create(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7, byte e8, byte e9, byte e10, byte e11, byte e12, byte e13, byte e14, byte e15, byte e16, byte e17, byte e18, byte e19, byte e20, byte e21, byte e22, byte e23, byte e24, byte e25, byte e26, byte e27, byte e28, byte e29, byte e30, byte e31, byte e32, byte e33, byte e34, byte e35, byte e36, byte e37, byte e38, byte e39, byte e40, byte e41, byte e42, byte e43, byte e44, byte e45, byte e46, byte e47, byte e48, byte e49, byte e50, byte e51, byte e52, byte e53, byte e54, byte e55, byte e56, byte e57, byte e58, byte e59, byte e60, byte e61, byte e62, byte e63)
		{
			return Vector512.Create(Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15, e16, e17, e18, e19, e20, e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31), Vector256.Create(e32, e33, e34, e35, e36, e37, e38, e39, e40, e41, e42, e43, e44, e45, e46, e47, e48, e49, e50, e51, e52, e53, e54, e55, e56, e57, e58, e59, e60, e61, e62, e63));
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x000FE870 File Offset: 0x000FCA70
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> Create(double e0, double e1, double e2, double e3, double e4, double e5, double e6, double e7)
		{
			return Vector512.Create(Vector256.Create(e0, e1, e2, e3), Vector256.Create(e4, e5, e6, e7));
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x000FE890 File Offset: 0x000FCA90
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<short> Create(short e0, short e1, short e2, short e3, short e4, short e5, short e6, short e7, short e8, short e9, short e10, short e11, short e12, short e13, short e14, short e15, short e16, short e17, short e18, short e19, short e20, short e21, short e22, short e23, short e24, short e25, short e26, short e27, short e28, short e29, short e30, short e31)
		{
			return Vector512.Create(Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15), Vector256.Create(e16, e17, e18, e19, e20, e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31));
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x000FE8E8 File Offset: 0x000FCAE8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<int> Create(int e0, int e1, int e2, int e3, int e4, int e5, int e6, int e7, int e8, int e9, int e10, int e11, int e12, int e13, int e14, int e15)
		{
			return Vector512.Create(Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7), Vector256.Create(e8, e9, e10, e11, e12, e13, e14, e15));
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x000FE920 File Offset: 0x000FCB20
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<long> Create(long e0, long e1, long e2, long e3, long e4, long e5, long e6, long e7)
		{
			return Vector512.Create(Vector256.Create(e0, e1, e2, e3), Vector256.Create(e4, e5, e6, e7));
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x000FE940 File Offset: 0x000FCB40
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<sbyte> Create(sbyte e0, sbyte e1, sbyte e2, sbyte e3, sbyte e4, sbyte e5, sbyte e6, sbyte e7, sbyte e8, sbyte e9, sbyte e10, sbyte e11, sbyte e12, sbyte e13, sbyte e14, sbyte e15, sbyte e16, sbyte e17, sbyte e18, sbyte e19, sbyte e20, sbyte e21, sbyte e22, sbyte e23, sbyte e24, sbyte e25, sbyte e26, sbyte e27, sbyte e28, sbyte e29, sbyte e30, sbyte e31, sbyte e32, sbyte e33, sbyte e34, sbyte e35, sbyte e36, sbyte e37, sbyte e38, sbyte e39, sbyte e40, sbyte e41, sbyte e42, sbyte e43, sbyte e44, sbyte e45, sbyte e46, sbyte e47, sbyte e48, sbyte e49, sbyte e50, sbyte e51, sbyte e52, sbyte e53, sbyte e54, sbyte e55, sbyte e56, sbyte e57, sbyte e58, sbyte e59, sbyte e60, sbyte e61, sbyte e62, sbyte e63)
		{
			return Vector512.Create(Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15, e16, e17, e18, e19, e20, e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31), Vector256.Create(e32, e33, e34, e35, e36, e37, e38, e39, e40, e41, e42, e43, e44, e45, e46, e47, e48, e49, e50, e51, e52, e53, e54, e55, e56, e57, e58, e59, e60, e61, e62, e63));
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x000FE9D8 File Offset: 0x000FCBD8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> Create(float e0, float e1, float e2, float e3, float e4, float e5, float e6, float e7, float e8, float e9, float e10, float e11, float e12, float e13, float e14, float e15)
		{
			return Vector512.Create(Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7), Vector256.Create(e8, e9, e10, e11, e12, e13, e14, e15));
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x000FEA10 File Offset: 0x000FCC10
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<ushort> Create(ushort e0, ushort e1, ushort e2, ushort e3, ushort e4, ushort e5, ushort e6, ushort e7, ushort e8, ushort e9, ushort e10, ushort e11, ushort e12, ushort e13, ushort e14, ushort e15, ushort e16, ushort e17, ushort e18, ushort e19, ushort e20, ushort e21, ushort e22, ushort e23, ushort e24, ushort e25, ushort e26, ushort e27, ushort e28, ushort e29, ushort e30, ushort e31)
		{
			return Vector512.Create(Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15), Vector256.Create(e16, e17, e18, e19, e20, e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31));
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x000FEA68 File Offset: 0x000FCC68
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<uint> Create(uint e0, uint e1, uint e2, uint e3, uint e4, uint e5, uint e6, uint e7, uint e8, uint e9, uint e10, uint e11, uint e12, uint e13, uint e14, uint e15)
		{
			return Vector512.Create(Vector256.Create(e0, e1, e2, e3, e4, e5, e6, e7), Vector256.Create(e8, e9, e10, e11, e12, e13, e14, e15));
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x000FEAA0 File Offset: 0x000FCCA0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<ulong> Create(ulong e0, ulong e1, ulong e2, ulong e3, ulong e4, ulong e5, ulong e6, ulong e7)
		{
			return Vector512.Create(Vector256.Create(e0, e1, e2, e3), Vector256.Create(e4, e5, e6, e7));
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x000FEABD File Offset: 0x000FCCBD
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value)
		{
			return Vector512.Create<T>(Vector128.Create<T>(value, value));
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x000FEACB File Offset: 0x000FCCCB
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> value)
		{
			return Vector512.Create<T>(Vector256.Create<T>(value, value));
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x000FEAD9 File Offset: 0x000FCCD9
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> value)
		{
			return Vector512.Create<T>(value, value);
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x000FEAE4 File Offset: 0x000FCCE4
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> lower, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> upper)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			Vector512<T> result;
			Unsafe.SkipInit<Vector512<T>>(out result);
			result.SetLowerUnsafe(lower);
			result.SetUpperUnsafe(upper);
			return result;
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x000FEB0E File Offset: 0x000FCD0E
		public static Vector512<byte> Create(Vector256<byte> lower, Vector256<byte> upper)
		{
			return Vector512.Create<byte>(lower, upper);
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x000FEB17 File Offset: 0x000FCD17
		public static Vector512<double> Create(Vector256<double> lower, Vector256<double> upper)
		{
			return Vector512.Create<double>(lower, upper);
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x000FEB20 File Offset: 0x000FCD20
		public static Vector512<short> Create(Vector256<short> lower, Vector256<short> upper)
		{
			return Vector512.Create<short>(lower, upper);
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x000FEB29 File Offset: 0x000FCD29
		public static Vector512<int> Create(Vector256<int> lower, Vector256<int> upper)
		{
			return Vector512.Create<int>(lower, upper);
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x000FEB32 File Offset: 0x000FCD32
		public static Vector512<long> Create(Vector256<long> lower, Vector256<long> upper)
		{
			return Vector512.Create<long>(lower, upper);
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x000FEB3B File Offset: 0x000FCD3B
		public static Vector512<IntPtr> Create(Vector256<IntPtr> lower, Vector256<IntPtr> upper)
		{
			return Vector512.Create<IntPtr>(lower, upper);
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x000FEB44 File Offset: 0x000FCD44
		[CLSCompliant(false)]
		public static Vector512<UIntPtr> Create(Vector256<UIntPtr> lower, Vector256<UIntPtr> upper)
		{
			return Vector512.Create<UIntPtr>(lower, upper);
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x000FEB4D File Offset: 0x000FCD4D
		[CLSCompliant(false)]
		public static Vector512<sbyte> Create(Vector256<sbyte> lower, Vector256<sbyte> upper)
		{
			return Vector512.Create<sbyte>(lower, upper);
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x000FEB56 File Offset: 0x000FCD56
		public static Vector512<float> Create(Vector256<float> lower, Vector256<float> upper)
		{
			return Vector512.Create<float>(lower, upper);
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x000FEB5F File Offset: 0x000FCD5F
		[CLSCompliant(false)]
		public static Vector512<ushort> Create(Vector256<ushort> lower, Vector256<ushort> upper)
		{
			return Vector512.Create<ushort>(lower, upper);
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x000FEB68 File Offset: 0x000FCD68
		[CLSCompliant(false)]
		public static Vector512<uint> Create(Vector256<uint> lower, Vector256<uint> upper)
		{
			return Vector512.Create<uint>(lower, upper);
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x000FEB71 File Offset: 0x000FCD71
		[CLSCompliant(false)]
		public static Vector512<ulong> Create(Vector256<ulong> lower, Vector256<ulong> upper)
		{
			return Vector512.Create<ulong>(lower, upper);
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x000FEB7A File Offset: 0x000FCD7A
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> CreateScalar<[Nullable(2)] T>(T value)
		{
			return Vector256.CreateScalar<T>(value).ToVector512<T>();
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x000FEB87 File Offset: 0x000FCD87
		[Intrinsic]
		public static Vector512<byte> CreateScalar(byte value)
		{
			return Vector512.CreateScalar<byte>(value);
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x000FEB8F File Offset: 0x000FCD8F
		[Intrinsic]
		public static Vector512<double> CreateScalar(double value)
		{
			return Vector512.CreateScalar<double>(value);
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x000FEB97 File Offset: 0x000FCD97
		[Intrinsic]
		public static Vector512<short> CreateScalar(short value)
		{
			return Vector512.CreateScalar<short>(value);
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x000FEB9F File Offset: 0x000FCD9F
		[Intrinsic]
		public static Vector512<int> CreateScalar(int value)
		{
			return Vector512.CreateScalar<int>(value);
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x000FEBA7 File Offset: 0x000FCDA7
		[Intrinsic]
		public static Vector512<long> CreateScalar(long value)
		{
			return Vector512.CreateScalar<long>(value);
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x000FEBAF File Offset: 0x000FCDAF
		[Intrinsic]
		public static Vector512<IntPtr> CreateScalar(IntPtr value)
		{
			return Vector512.CreateScalar<IntPtr>(value);
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x000FEBB7 File Offset: 0x000FCDB7
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<UIntPtr> CreateScalar(UIntPtr value)
		{
			return Vector512.CreateScalar<UIntPtr>(value);
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x000FEBBF File Offset: 0x000FCDBF
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<sbyte> CreateScalar(sbyte value)
		{
			return Vector512.CreateScalar<sbyte>(value);
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x000FEBC7 File Offset: 0x000FCDC7
		[Intrinsic]
		public static Vector512<float> CreateScalar(float value)
		{
			return Vector512.CreateScalar<float>(value);
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x000FEBCF File Offset: 0x000FCDCF
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ushort> CreateScalar(ushort value)
		{
			return Vector512.CreateScalar<ushort>(value);
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x000FEBD7 File Offset: 0x000FCDD7
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<uint> CreateScalar(uint value)
		{
			return Vector512.CreateScalar<uint>(value);
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x000FEBDF File Offset: 0x000FCDDF
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ulong> CreateScalar(ulong value)
		{
			return Vector512.CreateScalar<ulong>(value);
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x000FEBE8 File Offset: 0x000FCDE8
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> CreateScalarUnsafe<[Nullable(2)] T>(T value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			Vector512<T> result;
			Unsafe.SkipInit<Vector512<T>>(out result);
			result.SetElementUnsafe(0, value);
			return result;
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x000FEC0B File Offset: 0x000FCE0B
		[Intrinsic]
		public static Vector512<byte> CreateScalarUnsafe(byte value)
		{
			return Vector512.CreateScalarUnsafe<byte>(value);
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x000FEC13 File Offset: 0x000FCE13
		[Intrinsic]
		public static Vector512<double> CreateScalarUnsafe(double value)
		{
			return Vector512.CreateScalarUnsafe<double>(value);
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x000FEC1B File Offset: 0x000FCE1B
		[Intrinsic]
		public static Vector512<short> CreateScalarUnsafe(short value)
		{
			return Vector512.CreateScalarUnsafe<short>(value);
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x000FEC23 File Offset: 0x000FCE23
		[Intrinsic]
		public static Vector512<int> CreateScalarUnsafe(int value)
		{
			return Vector512.CreateScalarUnsafe<int>(value);
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x000FEC2B File Offset: 0x000FCE2B
		[Intrinsic]
		public static Vector512<long> CreateScalarUnsafe(long value)
		{
			return Vector512.CreateScalarUnsafe<long>(value);
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x000FEC33 File Offset: 0x000FCE33
		[Intrinsic]
		public static Vector512<IntPtr> CreateScalarUnsafe(IntPtr value)
		{
			return Vector512.CreateScalarUnsafe<IntPtr>(value);
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x000FEC3B File Offset: 0x000FCE3B
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<UIntPtr> CreateScalarUnsafe(UIntPtr value)
		{
			return Vector512.CreateScalarUnsafe<UIntPtr>(value);
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x000FEC43 File Offset: 0x000FCE43
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<sbyte> CreateScalarUnsafe(sbyte value)
		{
			return Vector512.CreateScalarUnsafe<sbyte>(value);
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x000FEC4B File Offset: 0x000FCE4B
		[Intrinsic]
		public static Vector512<float> CreateScalarUnsafe(float value)
		{
			return Vector512.CreateScalarUnsafe<float>(value);
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x000FEC53 File Offset: 0x000FCE53
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ushort> CreateScalarUnsafe(ushort value)
		{
			return Vector512.CreateScalarUnsafe<ushort>(value);
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x000FEC5B File Offset: 0x000FCE5B
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<uint> CreateScalarUnsafe(uint value)
		{
			return Vector512.CreateScalarUnsafe<uint>(value);
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x000FEC63 File Offset: 0x000FCE63
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ulong> CreateScalarUnsafe(ulong value)
		{
			return Vector512.CreateScalarUnsafe<ulong>(value);
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x000FEC6B File Offset: 0x000FCE6B
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> CreateSequence<[Nullable(2)] T>(T start, T step)
		{
			return Vector512<T>.Indices * step + Vector512.Create<T>(start);
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x000FEC83 File Offset: 0x000FCE83
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> DegreesToRadians(Vector512<double> degrees)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.DegreesToRadians(degrees._lower), Vector256.DegreesToRadians(degrees._upper));
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x000FECA3 File Offset: 0x000FCEA3
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> DegreesToRadians(Vector512<float> degrees)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.DegreesToRadians(degrees._lower), Vector256.DegreesToRadians(degrees._upper));
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x000FECC3 File Offset: 0x000FCEC3
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Divide<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return left / right;
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x000FECCC File Offset: 0x000FCECC
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Divide<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, T right)
		{
			return left / right;
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x000FECD5 File Offset: 0x000FCED5
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Dot<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Sum<T>(left * right);
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x000FECE3 File Offset: 0x000FCEE3
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Equals<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(Vector256.Equals<T>(left._lower, right._lower), Vector256.Equals<T>(left._upper, right._upper));
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x000FED0C File Offset: 0x000FCF0C
		[NullableContext(2)]
		[Intrinsic]
		public static bool EqualsAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return left == right;
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x000FED15 File Offset: 0x000FCF15
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool EqualsAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector256.EqualsAny<T>(left._lower, right._lower) || Vector256.EqualsAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x000FED3D File Offset: 0x000FCF3D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> Exp(Vector512<double> vector)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Exp(vector._lower), Vector256.Exp(vector._upper));
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x000FED5D File Offset: 0x000FCF5D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> Exp(Vector512<float> vector)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Exp(vector._lower), Vector256.Exp(vector._upper));
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x000FED7D File Offset: 0x000FCF7D
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ExtractMostSignificantBits<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			return (ulong)vector._lower.ExtractMostSignificantBits<T>() | (ulong)vector._upper.ExtractMostSignificantBits<T>() << Vector256<T>.Count;
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x000FEDA4 File Offset: 0x000FCFA4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector512<T> Floor<T>(Vector512<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector512.Create<T>(Vector256.Floor<T>(vector._lower), Vector256.Floor<T>(vector._upper));
		}

		// Token: 0x06004DBB RID: 19899 RVA: 0x000FEEEB File Offset: 0x000FD0EB
		[Intrinsic]
		public static Vector512<float> Floor(Vector512<float> vector)
		{
			return Vector512.Floor<float>(vector);
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x000FEEF3 File Offset: 0x000FD0F3
		[Intrinsic]
		public static Vector512<double> Floor(Vector512<double> vector)
		{
			return Vector512.Floor<double>(vector);
		}

		// Token: 0x06004DBD RID: 19901 RVA: 0x000FEEFB File Offset: 0x000FD0FB
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> FusedMultiplyAdd(Vector512<double> left, Vector512<double> right, Vector512<double> addend)
		{
			return Vector512.Create(Vector256.FusedMultiplyAdd(left._lower, right._lower, addend._lower), Vector256.FusedMultiplyAdd(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004DBE RID: 19902 RVA: 0x000FEF30 File Offset: 0x000FD130
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> FusedMultiplyAdd(Vector512<float> left, Vector512<float> right, Vector512<float> addend)
		{
			return Vector512.Create(Vector256.FusedMultiplyAdd(left._lower, right._lower, addend._lower), Vector256.FusedMultiplyAdd(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x000FEF65 File Offset: 0x000FD165
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetElement<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector, int index)
		{
			if (index >= Vector512<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return vector.GetElementUnsafe(index);
		}

		// Token: 0x06004DC0 RID: 19904 RVA: 0x000FEF7E File Offset: 0x000FD17E
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> GetLower<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			return vector._lower;
		}

		// Token: 0x06004DC1 RID: 19905 RVA: 0x000FEF8B File Offset: 0x000FD18B
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> GetUpper<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			return vector._upper;
		}

		// Token: 0x06004DC2 RID: 19906 RVA: 0x000FEF98 File Offset: 0x000FD198
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> GreaterThan<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(Vector256.GreaterThan<T>(left._lower, right._lower), Vector256.GreaterThan<T>(left._upper, right._upper));
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x000FEFC1 File Offset: 0x000FD1C1
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector256.GreaterThanAll<T>(left._lower, right._lower) && Vector256.GreaterThanAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x000FEFE9 File Offset: 0x000FD1E9
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector256.GreaterThanAny<T>(left._lower, right._lower) || Vector256.GreaterThanAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x000FF011 File Offset: 0x000FD211
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> GreaterThanOrEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(Vector256.GreaterThanOrEqual<T>(left._lower, right._lower), Vector256.GreaterThanOrEqual<T>(left._upper, right._upper));
		}

		// Token: 0x06004DC6 RID: 19910 RVA: 0x000FF03A File Offset: 0x000FD23A
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanOrEqualAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector256.GreaterThanOrEqualAll<T>(left._lower, right._lower) && Vector256.GreaterThanOrEqualAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x000FF062 File Offset: 0x000FD262
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanOrEqualAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector256.GreaterThanOrEqualAny<T>(left._lower, right._lower) || Vector256.GreaterThanOrEqualAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004DC8 RID: 19912 RVA: 0x000FF08A File Offset: 0x000FD28A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> Hypot(Vector512<double> x, Vector512<double> y)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Hypot(x._lower, y._lower), Vector256.Hypot(x._upper, y._upper));
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x000FF0B6 File Offset: 0x000FD2B6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> Hypot(Vector512<float> x, Vector512<float> y)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Hypot(x._lower, y._lower), Vector256.Hypot(x._upper, y._upper));
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x000FF0E4 File Offset: 0x000FD2E4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> IsNaN<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				return ~Vector512.Equals<T>(vector, vector);
			}
			return Vector512<T>.Zero;
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x000FF13C File Offset: 0x000FD33C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> IsNegative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return Vector512<T>.Zero;
			}
			if (typeof(T) == typeof(float))
			{
				return Vector512.LessThan<int>(vector.AsInt32<T>(), Vector512<int>.Zero).As<int, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return Vector512.LessThan<long>(vector.AsInt64<T>(), Vector512<long>.Zero).As<long, T>();
			}
			return Vector512.LessThan<T>(vector, Vector512<T>.Zero);
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x000FF244 File Offset: 0x000FD444
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> IsPositive<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return Vector512<T>.AllBitsSet;
			}
			if (typeof(T) == typeof(float))
			{
				return Vector512.GreaterThanOrEqual<int>(vector.AsInt32<T>(), Vector512<int>.Zero).As<int, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return Vector512.GreaterThanOrEqual<long>(vector.AsInt64<T>(), Vector512<long>.Zero).As<long, T>();
			}
			return Vector512.GreaterThanOrEqual<T>(vector, Vector512<T>.Zero);
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x000FF34C File Offset: 0x000FD54C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> IsPositiveInfinity<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			if (typeof(T) == typeof(float))
			{
				return Vector512.Equals<T>(vector, Vector512.Create(float.PositiveInfinity).As<float, T>());
			}
			if (typeof(T) == typeof(double))
			{
				return Vector512.Equals<T>(vector, Vector512.Create(double.PositiveInfinity).As<double, T>());
			}
			return Vector512<T>.Zero;
		}

		// Token: 0x06004DCE RID: 19918 RVA: 0x000FF3C4 File Offset: 0x000FD5C4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> IsZero<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			return Vector512.Equals<T>(vector, Vector512<T>.Zero);
		}

		// Token: 0x06004DCF RID: 19919 RVA: 0x000FF3D1 File Offset: 0x000FD5D1
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> Lerp(Vector512<double> x, Vector512<double> y, Vector512<double> amount)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Lerp(x._lower, y._lower, amount._lower), Vector256.Lerp(x._upper, y._upper, amount._upper));
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x000FF409 File Offset: 0x000FD609
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> Lerp(Vector512<float> x, Vector512<float> y, Vector512<float> amount)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Lerp(x._lower, y._lower, amount._lower), Vector256.Lerp(x._upper, y._upper, amount._upper));
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x000FF441 File Offset: 0x000FD641
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> LessThan<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(Vector256.LessThan<T>(left._lower, right._lower), Vector256.LessThan<T>(left._upper, right._upper));
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x000FF46A File Offset: 0x000FD66A
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector256.LessThanAll<T>(left._lower, right._lower) && Vector256.LessThanAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x000FF492 File Offset: 0x000FD692
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector256.LessThanAny<T>(left._lower, right._lower) || Vector256.LessThanAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004DD4 RID: 19924 RVA: 0x000FF4BA File Offset: 0x000FD6BA
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> LessThanOrEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(Vector256.LessThanOrEqual<T>(left._lower, right._lower), Vector256.LessThanOrEqual<T>(left._upper, right._upper));
		}

		// Token: 0x06004DD5 RID: 19925 RVA: 0x000FF4E3 File Offset: 0x000FD6E3
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanOrEqualAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector256.LessThanOrEqualAll<T>(left._lower, right._lower) && Vector256.LessThanOrEqualAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x000FF50B File Offset: 0x000FD70B
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanOrEqualAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector256.LessThanOrEqualAny<T>(left._lower, right._lower) || Vector256.LessThanOrEqualAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x000FF533 File Offset: 0x000FD733
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector512<T> Load<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			return Vector512.LoadUnsafe<T>(ref *source);
		}

		// Token: 0x06004DD8 RID: 19928 RVA: 0x000FF53B File Offset: 0x000FD73B
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector512<T> LoadAligned<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			if (source % 64 != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			return *(Vector512<T>*)source;
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x000FF554 File Offset: 0x000FD754
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector512<T> LoadAlignedNonTemporal<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			return Vector512.LoadAligned<T>(source);
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x000FF55C File Offset: 0x000FD75C
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> LoadUnsafe<[Nullable(2)] T>([RequiresLocation] [In] ref T source)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			return Unsafe.ReadUnaligned<Vector512<T>>(Unsafe.As<T, byte>(Unsafe.AsRef<T>(ref source)));
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x000FF573 File Offset: 0x000FD773
		[NullableContext(1)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> LoadUnsafe<[Nullable(2)] T>([RequiresLocation] [In] ref T source, UIntPtr elementOffset)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			return Unsafe.ReadUnaligned<Vector512<T>>(Unsafe.As<T, byte>(Unsafe.Add<T>(Unsafe.AsRef<T>(ref source), (IntPtr)elementOffset)));
		}

		// Token: 0x06004DDC RID: 19932 RVA: 0x000FF590 File Offset: 0x000FD790
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> Log(Vector512<double> vector)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Log(vector._lower), Vector256.Log(vector._upper));
		}

		// Token: 0x06004DDD RID: 19933 RVA: 0x000FF5B0 File Offset: 0x000FD7B0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> Log(Vector512<float> vector)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Log(vector._lower), Vector256.Log(vector._upper));
		}

		// Token: 0x06004DDE RID: 19934 RVA: 0x000FF5D0 File Offset: 0x000FD7D0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> Log2(Vector512<double> vector)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Log2(vector._lower), Vector256.Log2(vector._upper));
		}

		// Token: 0x06004DDF RID: 19935 RVA: 0x000FF5F0 File Offset: 0x000FD7F0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> Log2(Vector512<float> vector)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Log2(vector._lower), Vector256.Log2(vector._upper));
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x000FF610 File Offset: 0x000FD810
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Max<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			if (false)
			{
			}
			return Vector512.Create<T>(Vector256.Max<T>(left._lower, right._lower), Vector256.Max<T>(left._upper, right._upper));
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x000FF63C File Offset: 0x000FD83C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> MaxMagnitude<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			if (false)
			{
			}
			return Vector512.Create<T>(Vector256.MaxMagnitude<T>(left._lower, right._lower), Vector256.MaxMagnitude<T>(left._upper, right._upper));
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x000FF668 File Offset: 0x000FD868
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> MaxMagnitudeNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			if (false)
			{
			}
			return Vector512.Create<T>(Vector256.MaxMagnitudeNumber<T>(left._lower, right._lower), Vector256.MaxMagnitudeNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x000FF694 File Offset: 0x000FD894
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> MaxNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			if (false)
			{
			}
			return Vector512.Create<T>(Vector256.MaxNative<T>(left._lower, right._lower), Vector256.MaxNative<T>(left._upper, right._upper));
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x000FF6C0 File Offset: 0x000FD8C0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> MaxNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			if (false)
			{
			}
			return Vector512.Create<T>(Vector256.MaxNumber<T>(left._lower, right._lower), Vector256.MaxNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004DE5 RID: 19941 RVA: 0x000FF6EC File Offset: 0x000FD8EC
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Min<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			if (false)
			{
			}
			return Vector512.Create<T>(Vector256.Min<T>(left._lower, right._lower), Vector256.Min<T>(left._upper, right._upper));
		}

		// Token: 0x06004DE6 RID: 19942 RVA: 0x000FF718 File Offset: 0x000FD918
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> MinMagnitude<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			if (false)
			{
			}
			return Vector512.Create<T>(Vector256.MinMagnitude<T>(left._lower, right._lower), Vector256.MinMagnitude<T>(left._upper, right._upper));
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x000FF744 File Offset: 0x000FD944
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> MinMagnitudeNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			if (false)
			{
			}
			return Vector512.Create<T>(Vector256.MinMagnitudeNumber<T>(left._lower, right._lower), Vector256.MinMagnitudeNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x000FF770 File Offset: 0x000FD970
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> MinNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			if (false)
			{
			}
			return Vector512.Create<T>(Vector256.MinNative<T>(left._lower, right._lower), Vector256.MinNative<T>(left._upper, right._upper));
		}

		// Token: 0x06004DE9 RID: 19945 RVA: 0x000FF79C File Offset: 0x000FD99C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> MinNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			if (false)
			{
			}
			return Vector512.Create<T>(Vector256.MinNumber<T>(left._lower, right._lower), Vector256.MinNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x000FF7C8 File Offset: 0x000FD9C8
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Multiply<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return left * right;
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x000FF7D1 File Offset: 0x000FD9D1
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Multiply<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, T right)
		{
			return left * right;
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x000FF7DA File Offset: 0x000FD9DA
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Multiply<[Nullable(2)] T>(T left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return right * left;
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x000FF7E3 File Offset: 0x000FD9E3
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector512<T> MultiplyAddEstimate<T>(Vector512<T> left, Vector512<T> right, Vector512<T> addend)
		{
			return Vector512.Create<T>(Vector256.MultiplyAddEstimate<T>(left._lower, right._lower, addend._lower), Vector256.MultiplyAddEstimate<T>(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x000FF818 File Offset: 0x000FDA18
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> MultiplyAddEstimate(Vector512<double> left, Vector512<double> right, Vector512<double> addend)
		{
			return Vector512.Create(Vector256.MultiplyAddEstimate(left._lower, right._lower, addend._lower), Vector256.MultiplyAddEstimate(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x000FF84D File Offset: 0x000FDA4D
		[Intrinsic]
		public static Vector512<float> MultiplyAddEstimate(Vector512<float> left, Vector512<float> right, Vector512<float> addend)
		{
			return Vector512.Create(Vector256.MultiplyAddEstimate(left._lower, right._lower, addend._lower), Vector256.MultiplyAddEstimate(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x000FF882 File Offset: 0x000FDA82
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> Narrow(Vector512<double> lower, Vector512<double> upper)
		{
			return Vector512.Create(Vector256.Narrow(lower._lower, lower._upper), Vector256.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x000FF8AB File Offset: 0x000FDAAB
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<sbyte> Narrow(Vector512<short> lower, Vector512<short> upper)
		{
			return Vector512.Create(Vector256.Narrow(lower._lower, lower._upper), Vector256.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x000FF8D4 File Offset: 0x000FDAD4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<short> Narrow(Vector512<int> lower, Vector512<int> upper)
		{
			return Vector512.Create(Vector256.Narrow(lower._lower, lower._upper), Vector256.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x000FF8FD File Offset: 0x000FDAFD
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<int> Narrow(Vector512<long> lower, Vector512<long> upper)
		{
			return Vector512.Create(Vector256.Narrow(lower._lower, lower._upper), Vector256.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x000FF926 File Offset: 0x000FDB26
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<byte> Narrow(Vector512<ushort> lower, Vector512<ushort> upper)
		{
			return Vector512.Create(Vector256.Narrow(lower._lower, lower._upper), Vector256.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004DF5 RID: 19957 RVA: 0x000FF94F File Offset: 0x000FDB4F
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<ushort> Narrow(Vector512<uint> lower, Vector512<uint> upper)
		{
			return Vector512.Create(Vector256.Narrow(lower._lower, lower._upper), Vector256.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x000FF978 File Offset: 0x000FDB78
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<uint> Narrow(Vector512<ulong> lower, Vector512<ulong> upper)
		{
			return Vector512.Create(Vector256.Narrow(lower._lower, lower._upper), Vector256.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x000FF9A1 File Offset: 0x000FDBA1
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Negate<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			return -vector;
		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x000FF9A9 File Offset: 0x000FDBA9
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> OnesComplement<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			return ~vector;
		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x000FF9B1 File Offset: 0x000FDBB1
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> RadiansToDegrees(Vector512<double> radians)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.RadiansToDegrees(radians._lower), Vector256.RadiansToDegrees(radians._upper));
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x000FF9D1 File Offset: 0x000FDBD1
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> RadiansToDegrees(Vector512<float> radians)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.RadiansToDegrees(radians._lower), Vector256.RadiansToDegrees(radians._upper));
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x000FF9F4 File Offset: 0x000FDBF4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector512<T> Round<T>(Vector512<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector512.Create<T>(Vector256.Round<T>(vector._lower), Vector256.Round<T>(vector._upper));
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x000FFB3B File Offset: 0x000FDD3B
		[Intrinsic]
		public static Vector512<double> Round(Vector512<double> vector)
		{
			return Vector512.Round<double>(vector);
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x000FFB43 File Offset: 0x000FDD43
		[Intrinsic]
		public static Vector512<float> Round(Vector512<float> vector)
		{
			return Vector512.Round<float>(vector);
		}

		// Token: 0x06004DFE RID: 19966 RVA: 0x000FFB4B File Offset: 0x000FDD4B
		[Intrinsic]
		public static Vector512<double> Round(Vector512<double> vector, MidpointRounding mode)
		{
			return VectorMath.RoundDouble<Vector512<double>>(vector, mode);
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x000FFB54 File Offset: 0x000FDD54
		[Intrinsic]
		public static Vector512<float> Round(Vector512<float> vector, MidpointRounding mode)
		{
			return VectorMath.RoundSingle<Vector512<float>>(vector, mode);
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x000FFB5D File Offset: 0x000FDD5D
		[Intrinsic]
		public static Vector512<byte> ShiftLeft(Vector512<byte> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004E01 RID: 19969 RVA: 0x000FFB66 File Offset: 0x000FDD66
		[Intrinsic]
		public static Vector512<short> ShiftLeft(Vector512<short> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x000FFB6F File Offset: 0x000FDD6F
		[Intrinsic]
		public static Vector512<int> ShiftLeft(Vector512<int> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x000FFB78 File Offset: 0x000FDD78
		[Intrinsic]
		public static Vector512<long> ShiftLeft(Vector512<long> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x000FFB81 File Offset: 0x000FDD81
		[Intrinsic]
		public static Vector512<IntPtr> ShiftLeft(Vector512<IntPtr> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x000FFB8A File Offset: 0x000FDD8A
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<UIntPtr> ShiftLeft(Vector512<UIntPtr> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x000FFB93 File Offset: 0x000FDD93
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<sbyte> ShiftLeft(Vector512<sbyte> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x000FFB9C File Offset: 0x000FDD9C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ushort> ShiftLeft(Vector512<ushort> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x000FFBA5 File Offset: 0x000FDDA5
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<uint> ShiftLeft(Vector512<uint> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x000FFBAE File Offset: 0x000FDDAE
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ulong> ShiftLeft(Vector512<ulong> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x000FFBB7 File Offset: 0x000FDDB7
		[Intrinsic]
		public static Vector512<short> ShiftRightArithmetic(Vector512<short> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x000FFBC0 File Offset: 0x000FDDC0
		[Intrinsic]
		public static Vector512<int> ShiftRightArithmetic(Vector512<int> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x000FFBC9 File Offset: 0x000FDDC9
		[Intrinsic]
		public static Vector512<long> ShiftRightArithmetic(Vector512<long> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x000FFBD2 File Offset: 0x000FDDD2
		[Intrinsic]
		public static Vector512<IntPtr> ShiftRightArithmetic(Vector512<IntPtr> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x000FFBDB File Offset: 0x000FDDDB
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<sbyte> ShiftRightArithmetic(Vector512<sbyte> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x000FFBE4 File Offset: 0x000FDDE4
		[Intrinsic]
		public static Vector512<byte> ShiftRightLogical(Vector512<byte> vector, int shiftCount)
		{
			return Vector512<byte>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x000FFBED File Offset: 0x000FDDED
		[Intrinsic]
		public static Vector512<short> ShiftRightLogical(Vector512<short> vector, int shiftCount)
		{
			return Vector512<short>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x000FFBF6 File Offset: 0x000FDDF6
		[Intrinsic]
		public static Vector512<int> ShiftRightLogical(Vector512<int> vector, int shiftCount)
		{
			return Vector512<int>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x000FFBFF File Offset: 0x000FDDFF
		[Intrinsic]
		public static Vector512<long> ShiftRightLogical(Vector512<long> vector, int shiftCount)
		{
			return Vector512<long>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x000FFC08 File Offset: 0x000FDE08
		[Intrinsic]
		public static Vector512<IntPtr> ShiftRightLogical(Vector512<IntPtr> vector, int shiftCount)
		{
			return Vector512<IntPtr>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x000FFC11 File Offset: 0x000FDE11
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<UIntPtr> ShiftRightLogical(Vector512<UIntPtr> vector, int shiftCount)
		{
			return Vector512<UIntPtr>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x000FFC1A File Offset: 0x000FDE1A
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<sbyte> ShiftRightLogical(Vector512<sbyte> vector, int shiftCount)
		{
			return Vector512<sbyte>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x000FFC23 File Offset: 0x000FDE23
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ushort> ShiftRightLogical(Vector512<ushort> vector, int shiftCount)
		{
			return Vector512<ushort>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x000FFC2C File Offset: 0x000FDE2C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<uint> ShiftRightLogical(Vector512<uint> vector, int shiftCount)
		{
			return Vector512<uint>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x000FFC35 File Offset: 0x000FDE35
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ulong> ShiftRightLogical(Vector512<ulong> vector, int shiftCount)
		{
			return Vector512<ulong>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x000FFC40 File Offset: 0x000FDE40
		[Intrinsic]
		public static Vector512<byte> Shuffle(Vector512<byte> vector, Vector512<byte> indices)
		{
			Vector512<byte> result;
			Unsafe.SkipInit<Vector512<byte>>(out result);
			for (int i = 0; i < Vector512<byte>.Count; i++)
			{
				byte elementUnsafe = indices.GetElementUnsafe(i);
				byte value = 0;
				if ((int)elementUnsafe < Vector512<byte>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x000FFC8C File Offset: 0x000FDE8C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<sbyte> Shuffle(Vector512<sbyte> vector, Vector512<sbyte> indices)
		{
			Vector512<sbyte> result;
			Unsafe.SkipInit<Vector512<sbyte>>(out result);
			for (int i = 0; i < Vector512<sbyte>.Count; i++)
			{
				byte b = (byte)indices.GetElementUnsafe(i);
				sbyte value = 0;
				if ((int)b < Vector512<sbyte>.Count)
				{
					value = vector.GetElementUnsafe((int)b);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x000FFCD8 File Offset: 0x000FDED8
		[Intrinsic]
		public static Vector512<short> Shuffle(Vector512<short> vector, Vector512<short> indices)
		{
			Vector512<short> result;
			Unsafe.SkipInit<Vector512<short>>(out result);
			for (int i = 0; i < Vector512<short>.Count; i++)
			{
				ushort num = (ushort)indices.GetElementUnsafe(i);
				short value = 0;
				if ((int)num < Vector512<short>.Count)
				{
					value = vector.GetElementUnsafe((int)num);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x000FFD24 File Offset: 0x000FDF24
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ushort> Shuffle(Vector512<ushort> vector, Vector512<ushort> indices)
		{
			Vector512<ushort> result;
			Unsafe.SkipInit<Vector512<ushort>>(out result);
			for (int i = 0; i < Vector512<ushort>.Count; i++)
			{
				ushort elementUnsafe = indices.GetElementUnsafe(i);
				ushort value = 0;
				if ((int)elementUnsafe < Vector512<ushort>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x000FFD70 File Offset: 0x000FDF70
		[Intrinsic]
		public static Vector512<int> Shuffle(Vector512<int> vector, Vector512<int> indices)
		{
			Vector512<int> result;
			Unsafe.SkipInit<Vector512<int>>(out result);
			for (int i = 0; i < Vector512<int>.Count; i++)
			{
				uint elementUnsafe = (uint)indices.GetElementUnsafe(i);
				int value = 0;
				if ((ulong)elementUnsafe < (ulong)((long)Vector512<int>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x000FFDBC File Offset: 0x000FDFBC
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<uint> Shuffle(Vector512<uint> vector, Vector512<uint> indices)
		{
			Vector512<uint> result;
			Unsafe.SkipInit<Vector512<uint>>(out result);
			for (int i = 0; i < Vector512<uint>.Count; i++)
			{
				uint elementUnsafe = indices.GetElementUnsafe(i);
				uint value = 0U;
				if ((ulong)elementUnsafe < (ulong)((long)Vector512<uint>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004E1F RID: 19999 RVA: 0x000FFE08 File Offset: 0x000FE008
		[Intrinsic]
		public static Vector512<float> Shuffle(Vector512<float> vector, Vector512<int> indices)
		{
			Vector512<float> result;
			Unsafe.SkipInit<Vector512<float>>(out result);
			for (int i = 0; i < Vector512<float>.Count; i++)
			{
				uint elementUnsafe = (uint)indices.GetElementUnsafe(i);
				float value = 0f;
				if ((ulong)elementUnsafe < (ulong)((long)Vector512<float>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004E20 RID: 20000 RVA: 0x000FFE58 File Offset: 0x000FE058
		[Intrinsic]
		public static Vector512<long> Shuffle(Vector512<long> vector, Vector512<long> indices)
		{
			Vector512<long> result;
			Unsafe.SkipInit<Vector512<long>>(out result);
			for (int i = 0; i < Vector512<long>.Count; i++)
			{
				ulong elementUnsafe = (ulong)indices.GetElementUnsafe(i);
				long value = 0L;
				if (elementUnsafe < (ulong)Vector512<long>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x000FFEA8 File Offset: 0x000FE0A8
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector512<ulong> Shuffle(Vector512<ulong> vector, Vector512<ulong> indices)
		{
			Vector512<ulong> result;
			Unsafe.SkipInit<Vector512<ulong>>(out result);
			for (int i = 0; i < Vector512<ulong>.Count; i++)
			{
				ulong elementUnsafe = indices.GetElementUnsafe(i);
				ulong value = 0UL;
				if (elementUnsafe < (ulong)Vector512<ulong>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x000FFEF8 File Offset: 0x000FE0F8
		[Intrinsic]
		public static Vector512<double> Shuffle(Vector512<double> vector, Vector512<long> indices)
		{
			Vector512<double> result;
			Unsafe.SkipInit<Vector512<double>>(out result);
			for (int i = 0; i < Vector512<double>.Count; i++)
			{
				ulong elementUnsafe = (ulong)indices.GetElementUnsafe(i);
				double value = 0.0;
				if (elementUnsafe < (ulong)Vector512<double>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x000FFF4C File Offset: 0x000FE14C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> Sin(Vector512<double> vector)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Sin(vector._lower), Vector256.Sin(vector._upper));
		}

		// Token: 0x06004E24 RID: 20004 RVA: 0x000FFF6C File Offset: 0x000FE16C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<float> Sin(Vector512<float> vector)
		{
			if (false)
			{
			}
			return Vector512.Create(Vector256.Sin(vector._lower), Vector256.Sin(vector._upper));
		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x000FFF8C File Offset: 0x000FE18C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector512<double>, Vector512<double>> SinCos(Vector512<double> vector)
		{
			if (false)
			{
			}
			ValueTuple<Vector256<double>, Vector256<double>> valueTuple = Vector256.SinCos(vector._lower);
			Vector256<double> item = valueTuple.Item1;
			Vector256<double> item2 = valueTuple.Item2;
			ValueTuple<Vector256<double>, Vector256<double>> valueTuple2 = Vector256.SinCos(vector._upper);
			Vector256<double> item3 = valueTuple2.Item1;
			Vector256<double> item4 = valueTuple2.Item2;
			return new ValueTuple<Vector512<double>, Vector512<double>>(Vector512.Create(item, item3), Vector512.Create(item2, item4));
		}

		// Token: 0x06004E26 RID: 20006 RVA: 0x000FFFE0 File Offset: 0x000FE1E0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector512<float>, Vector512<float>> SinCos(Vector512<float> vector)
		{
			if (false)
			{
			}
			ValueTuple<Vector256<float>, Vector256<float>> valueTuple = Vector256.SinCos(vector._lower);
			Vector256<float> item = valueTuple.Item1;
			Vector256<float> item2 = valueTuple.Item2;
			ValueTuple<Vector256<float>, Vector256<float>> valueTuple2 = Vector256.SinCos(vector._upper);
			Vector256<float> item3 = valueTuple2.Item1;
			Vector256<float> item4 = valueTuple2.Item2;
			return new ValueTuple<Vector512<float>, Vector512<float>>(Vector512.Create(item, item3), Vector512.Create(item2, item4));
		}

		// Token: 0x06004E27 RID: 20007 RVA: 0x00100033 File Offset: 0x000FE233
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Sqrt<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			return Vector512.Create<T>(Vector256.Sqrt<T>(vector._lower), Vector256.Sqrt<T>(vector._upper));
		}

		// Token: 0x06004E28 RID: 20008 RVA: 0x00100050 File Offset: 0x000FE250
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		public unsafe static void Store<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			source.StoreUnsafe(ref *destination);
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x00100059 File Offset: 0x000FE259
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void StoreAligned<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			if (destination % 64 != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			*(Vector512<T>*)destination = source;
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x00100073 File Offset: 0x000FE273
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		public unsafe static void StoreAlignedNonTemporal<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			source.StoreAligned(destination);
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x0010007C File Offset: 0x000FE27C
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StoreUnsafe<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> source, ref T destination)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<T, byte>(ref destination), source);
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x0010008F File Offset: 0x000FE28F
		[NullableContext(1)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StoreUnsafe<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> source, ref T destination, UIntPtr elementOffset)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			destination = Unsafe.Add<T>(ref destination, (IntPtr)elementOffset);
			Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<T, byte>(ref destination), source);
		}

		// Token: 0x06004E2D RID: 20013 RVA: 0x001000AB File Offset: 0x000FE2AB
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Subtract<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return left - right;
		}

		// Token: 0x06004E2E RID: 20014 RVA: 0x001000B4 File Offset: 0x000FE2B4
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Sum<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			return Scalar<T>.Add(Vector256.Sum<T>(vector._lower), Vector256.Sum<T>(vector._upper));
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x001000D1 File Offset: 0x000FE2D1
		[NullableContext(1)]
		[Intrinsic]
		public static T ToScalar<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			return vector.GetElementUnsafe(0);
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x001000E0 File Offset: 0x000FE2E0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector512<T> Truncate<T>(Vector512<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector512.Create<T>(Vector256.Truncate<T>(vector._lower), Vector256.Truncate<T>(vector._upper));
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x00100227 File Offset: 0x000FE427
		[Intrinsic]
		public static Vector512<double> Truncate(Vector512<double> vector)
		{
			return Vector512.Truncate<double>(vector);
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x0010022F File Offset: 0x000FE42F
		[Intrinsic]
		public static Vector512<float> Truncate(Vector512<float> vector)
		{
			return Vector512.Truncate<float>(vector);
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x00100237 File Offset: 0x000FE437
		[NullableContext(2)]
		public static bool TryCopyTo<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (destination.Length < Vector512<T>.Count)
			{
				return false;
			}
			Unsafe.WriteUnaligned<Vector512<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(destination)), vector);
			return true;
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x0010025B File Offset: 0x000FE45B
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector512<ushort>, Vector512<ushort>> Widen(Vector512<byte> source)
		{
			return new ValueTuple<Vector512<ushort>, Vector512<ushort>>(Vector512.WidenLower(source), Vector512.WidenUpper(source));
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x0010026E File Offset: 0x000FE46E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector512<int>, Vector512<int>> Widen(Vector512<short> source)
		{
			return new ValueTuple<Vector512<int>, Vector512<int>>(Vector512.WidenLower(source), Vector512.WidenUpper(source));
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x00100281 File Offset: 0x000FE481
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector512<long>, Vector512<long>> Widen(Vector512<int> source)
		{
			return new ValueTuple<Vector512<long>, Vector512<long>>(Vector512.WidenLower(source), Vector512.WidenUpper(source));
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x00100294 File Offset: 0x000FE494
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector512<short>, Vector512<short>> Widen(Vector512<sbyte> source)
		{
			return new ValueTuple<Vector512<short>, Vector512<short>>(Vector512.WidenLower(source), Vector512.WidenUpper(source));
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x001002A7 File Offset: 0x000FE4A7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector512<double>, Vector512<double>> Widen(Vector512<float> source)
		{
			return new ValueTuple<Vector512<double>, Vector512<double>>(Vector512.WidenLower(source), Vector512.WidenUpper(source));
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x001002BA File Offset: 0x000FE4BA
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector512<uint>, Vector512<uint>> Widen(Vector512<ushort> source)
		{
			return new ValueTuple<Vector512<uint>, Vector512<uint>>(Vector512.WidenLower(source), Vector512.WidenUpper(source));
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x001002CD File Offset: 0x000FE4CD
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector512<ulong>, Vector512<ulong>> Widen(Vector512<uint> source)
		{
			return new ValueTuple<Vector512<ulong>, Vector512<ulong>>(Vector512.WidenLower(source), Vector512.WidenUpper(source));
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x001002E0 File Offset: 0x000FE4E0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<ushort> WidenLower(Vector512<byte> source)
		{
			Vector256<byte> lower = source._lower;
			return Vector512.Create(Vector256.WidenLower(lower), Vector256.WidenUpper(lower));
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x00100308 File Offset: 0x000FE508
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<int> WidenLower(Vector512<short> source)
		{
			Vector256<short> lower = source._lower;
			return Vector512.Create(Vector256.WidenLower(lower), Vector256.WidenUpper(lower));
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x00100330 File Offset: 0x000FE530
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<long> WidenLower(Vector512<int> source)
		{
			Vector256<int> lower = source._lower;
			return Vector512.Create(Vector256.WidenLower(lower), Vector256.WidenUpper(lower));
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x00100358 File Offset: 0x000FE558
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<short> WidenLower(Vector512<sbyte> source)
		{
			Vector256<sbyte> lower = source._lower;
			return Vector512.Create(Vector256.WidenLower(lower), Vector256.WidenUpper(lower));
		}

		// Token: 0x06004E3F RID: 20031 RVA: 0x00100380 File Offset: 0x000FE580
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> WidenLower(Vector512<float> source)
		{
			Vector256<float> lower = source._lower;
			return Vector512.Create(Vector256.WidenLower(lower), Vector256.WidenUpper(lower));
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x001003A8 File Offset: 0x000FE5A8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<uint> WidenLower(Vector512<ushort> source)
		{
			Vector256<ushort> lower = source._lower;
			return Vector512.Create(Vector256.WidenLower(lower), Vector256.WidenUpper(lower));
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x001003D0 File Offset: 0x000FE5D0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<ulong> WidenLower(Vector512<uint> source)
		{
			Vector256<uint> lower = source._lower;
			return Vector512.Create(Vector256.WidenLower(lower), Vector256.WidenUpper(lower));
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x001003F8 File Offset: 0x000FE5F8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<ushort> WidenUpper(Vector512<byte> source)
		{
			Vector256<byte> upper = source._upper;
			return Vector512.Create(Vector256.WidenLower(upper), Vector256.WidenUpper(upper));
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x00100420 File Offset: 0x000FE620
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<int> WidenUpper(Vector512<short> source)
		{
			Vector256<short> upper = source._upper;
			return Vector512.Create(Vector256.WidenLower(upper), Vector256.WidenUpper(upper));
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x00100448 File Offset: 0x000FE648
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<long> WidenUpper(Vector512<int> source)
		{
			Vector256<int> upper = source._upper;
			return Vector512.Create(Vector256.WidenLower(upper), Vector256.WidenUpper(upper));
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x00100470 File Offset: 0x000FE670
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<short> WidenUpper(Vector512<sbyte> source)
		{
			Vector256<sbyte> upper = source._upper;
			return Vector512.Create(Vector256.WidenLower(upper), Vector256.WidenUpper(upper));
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x00100498 File Offset: 0x000FE698
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<double> WidenUpper(Vector512<float> source)
		{
			Vector256<float> upper = source._upper;
			return Vector512.Create(Vector256.WidenLower(upper), Vector256.WidenUpper(upper));
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x001004C0 File Offset: 0x000FE6C0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<uint> WidenUpper(Vector512<ushort> source)
		{
			Vector256<ushort> upper = source._upper;
			return Vector512.Create(Vector256.WidenLower(upper), Vector256.WidenUpper(upper));
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x001004E8 File Offset: 0x000FE6E8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector512<ulong> WidenUpper(Vector512<uint> source)
		{
			Vector256<uint> upper = source._upper;
			return Vector512.Create(Vector256.WidenLower(upper), Vector256.WidenUpper(upper));
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x00100510 File Offset: 0x000FE710
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> WithElement<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector, int index, T value)
		{
			if (index >= Vector512<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			Vector512<T> result = vector;
			result.SetElementUnsafe(index, value);
			return result;
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x00100538 File Offset: 0x000FE738
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> WithLower<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			Vector512<T> result = vector;
			result.SetLowerUnsafe(value);
			return result;
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x00100558 File Offset: 0x000FE758
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> WithUpper<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector512<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			Vector512<T> result = vector;
			result.SetUpperUnsafe(value);
			return result;
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x00100575 File Offset: 0x000FE775
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Xor<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return left ^ right;
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x0010057E File Offset: 0x000FE77E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static T GetElementUnsafe<T>(this Vector512<T> vector, int index)
		{
			return *Unsafe.Add<T>(Unsafe.As<Vector512<T>, T>(Unsafe.AsRef<Vector512<T>>(ref vector)), index);
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x00100596 File Offset: 0x000FE796
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void SetElementUnsafe<T>(this Vector512<T> vector, int index, T value)
		{
			*Unsafe.Add<T>(Unsafe.As<Vector512<T>, T>(Unsafe.AsRef<Vector512<T>>(ref vector)), index) = value;
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x001005AF File Offset: 0x000FE7AF
		internal unsafe static void SetLowerUnsafe<T>(this Vector512<T> vector, Vector256<T> value)
		{
			*Unsafe.AsRef<Vector256<T>>(ref vector._lower) = value;
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x001005C2 File Offset: 0x000FE7C2
		internal unsafe static void SetUpperUnsafe<T>(this Vector512<T> vector, Vector256<T> value)
		{
			*Unsafe.AsRef<Vector256<T>>(ref vector._upper) = value;
		}
	}
}
