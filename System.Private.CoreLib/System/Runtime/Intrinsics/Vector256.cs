using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Runtime.Intrinsics
{
	// Token: 0x02000546 RID: 1350
	public static class Vector256
	{
		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06004BA6 RID: 19366 RVA: 0x00007B65 File Offset: 0x00005D65
		public static bool IsHardwareAccelerated
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x000FB27C File Offset: 0x000F947C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Abs<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return vector;
			}
			return Vector256.Create<T>(Vector128.Abs<T>(vector._lower), Vector128.Abs<T>(vector._upper));
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x000FB32D File Offset: 0x000F952D
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Add<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return left + right;
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x000FB336 File Offset: 0x000F9536
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> AndNot<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return left & ~right;
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x000FB344 File Offset: 0x000F9544
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector256<TTo> As<TFrom, TTo>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<TFrom> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<TFrom>();
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<TTo>();
			return *Unsafe.As<Vector256<TFrom>, Vector256<TTo>>(ref vector);
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x000FB35C File Offset: 0x000F955C
		[Intrinsic]
		public static Vector256<byte> AsByte<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, byte>();
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x000FB364 File Offset: 0x000F9564
		[Intrinsic]
		public static Vector256<double> AsDouble<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, double>();
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x000FB36C File Offset: 0x000F956C
		[Intrinsic]
		public static Vector256<short> AsInt16<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, short>();
		}

		// Token: 0x06004BAE RID: 19374 RVA: 0x000FB374 File Offset: 0x000F9574
		[Intrinsic]
		public static Vector256<int> AsInt32<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, int>();
		}

		// Token: 0x06004BAF RID: 19375 RVA: 0x000FB37C File Offset: 0x000F957C
		[Intrinsic]
		public static Vector256<long> AsInt64<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, long>();
		}

		// Token: 0x06004BB0 RID: 19376 RVA: 0x000FB384 File Offset: 0x000F9584
		[Intrinsic]
		public static Vector256<IntPtr> AsNInt<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, IntPtr>();
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x000FB38C File Offset: 0x000F958C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<UIntPtr> AsNUInt<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, UIntPtr>();
		}

		// Token: 0x06004BB2 RID: 19378 RVA: 0x000FB394 File Offset: 0x000F9594
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<sbyte> AsSByte<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, sbyte>();
		}

		// Token: 0x06004BB3 RID: 19379 RVA: 0x000FB39C File Offset: 0x000F959C
		[Intrinsic]
		public static Vector256<float> AsSingle<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, float>();
		}

		// Token: 0x06004BB4 RID: 19380 RVA: 0x000FB3A4 File Offset: 0x000F95A4
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ushort> AsUInt16<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, ushort>();
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x000FB3AC File Offset: 0x000F95AC
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<uint> AsUInt32<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, uint>();
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x000FB3B4 File Offset: 0x000F95B4
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ulong> AsUInt64<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector.As<T, ulong>();
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x000FB3BC File Offset: 0x000F95BC
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> AsVector256<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			Vector256<T> result = default(Vector256<T>);
			Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<Vector256<T>, byte>(ref result), value);
			return result;
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x000FB3E4 File Offset: 0x000F95E4
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
		})] this Vector256<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			return Unsafe.ReadUnaligned<Vector<T>>(Unsafe.As<Vector256<T>, byte>(ref value));
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x000FB3F7 File Offset: 0x000F95F7
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> BitwiseAnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return left & right;
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x000FB400 File Offset: 0x000F9600
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> BitwiseOr<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return left | right;
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x000FB40C File Offset: 0x000F960C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector256<T> Ceiling<T>(Vector256<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector256.Create<T>(Vector128.Ceiling<T>(vector._lower), Vector128.Ceiling<T>(vector._upper));
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x000FB553 File Offset: 0x000F9753
		[Intrinsic]
		public static Vector256<float> Ceiling(Vector256<float> vector)
		{
			return Vector256.Ceiling<float>(vector);
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x000FB55B File Offset: 0x000F975B
		[Intrinsic]
		public static Vector256<double> Ceiling(Vector256<double> vector)
		{
			return Vector256.Ceiling<double>(vector);
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x000FB563 File Offset: 0x000F9763
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Clamp<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> min, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> max)
		{
			return Vector256.Min<T>(Vector256.Max<T>(value, min), max);
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x000FB572 File Offset: 0x000F9772
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> ClampNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> min, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> max)
		{
			return Vector256.MinNative<T>(Vector256.MaxNative<T>(value, min), max);
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x000FB581 File Offset: 0x000F9781
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> ConditionalSelect<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> condition, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return (left & condition) | Vector256.AndNot<T>(right, condition);
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x000FB596 File Offset: 0x000F9796
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> ConvertToDouble(Vector256<long> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.ConvertToDouble(vector._lower), Vector128.ConvertToDouble(vector._upper));
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x000FB5B6 File Offset: 0x000F97B6
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> ConvertToDouble(Vector256<ulong> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.ConvertToDouble(vector._lower), Vector128.ConvertToDouble(vector._upper));
		}

		// Token: 0x06004BC3 RID: 19395 RVA: 0x000FB5D6 File Offset: 0x000F97D6
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<int> ConvertToInt32(Vector256<float> vector)
		{
			return Vector256.Create(Vector128.ConvertToInt32(vector._lower), Vector128.ConvertToInt32(vector._upper));
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x000FB5F3 File Offset: 0x000F97F3
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<int> ConvertToInt32Native(Vector256<float> vector)
		{
			return Vector256.Create(Vector128.ConvertToInt32Native(vector._lower), Vector128.ConvertToInt32Native(vector._upper));
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x000FB610 File Offset: 0x000F9810
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<long> ConvertToInt64(Vector256<double> vector)
		{
			return Vector256.Create(Vector128.ConvertToInt64(vector._lower), Vector128.ConvertToInt64(vector._upper));
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x000FB62D File Offset: 0x000F982D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<long> ConvertToInt64Native(Vector256<double> vector)
		{
			return Vector256.Create(Vector128.ConvertToInt64Native(vector._lower), Vector128.ConvertToInt64Native(vector._upper));
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x000FB64A File Offset: 0x000F984A
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> ConvertToSingle(Vector256<int> vector)
		{
			return Vector256.Create(Vector128.ConvertToSingle(vector._lower), Vector128.ConvertToSingle(vector._upper));
		}

		// Token: 0x06004BC8 RID: 19400 RVA: 0x000FB667 File Offset: 0x000F9867
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> ConvertToSingle(Vector256<uint> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.ConvertToSingle(vector._lower), Vector128.ConvertToSingle(vector._upper));
		}

		// Token: 0x06004BC9 RID: 19401 RVA: 0x000FB687 File Offset: 0x000F9887
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<uint> ConvertToUInt32(Vector256<float> vector)
		{
			return Vector256.Create(Vector128.ConvertToUInt32(vector._lower), Vector128.ConvertToUInt32(vector._upper));
		}

		// Token: 0x06004BCA RID: 19402 RVA: 0x000FB6A4 File Offset: 0x000F98A4
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<uint> ConvertToUInt32Native(Vector256<float> vector)
		{
			return Vector256.Create(Vector128.ConvertToUInt32Native(vector._lower), Vector128.ConvertToUInt32Native(vector._upper));
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x000FB6C1 File Offset: 0x000F98C1
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<ulong> ConvertToUInt64(Vector256<double> vector)
		{
			return Vector256.Create(Vector128.ConvertToUInt64(vector._lower), Vector128.ConvertToUInt64(vector._upper));
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x000FB6DE File Offset: 0x000F98DE
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<ulong> ConvertToUInt64Native(Vector256<double> vector)
		{
			return Vector256.Create(Vector128.ConvertToUInt64Native(vector._lower), Vector128.ConvertToUInt64Native(vector._upper));
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x000FB6FC File Offset: 0x000F98FC
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> CopySign<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> sign)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return value;
			}
			if (false)
			{
			}
			return Vector256.Create<T>(Vector128.CopySign<T>(value._lower, sign._lower), Vector128.CopySign<T>(value._upper, sign._upper));
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x000FB7BC File Offset: 0x000F99BC
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector, T[] destination)
		{
			if (destination.Length < Vector256<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<T, byte>(ref destination[0]), vector);
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x000FB7DF File Offset: 0x000F99DF
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector, T[] destination, int startIndex)
		{
			if (startIndex >= destination.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
			}
			if (destination.Length - startIndex < Vector256<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<T, byte>(ref destination[startIndex]), vector);
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x000FB80F File Offset: 0x000F9A0F
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (destination.Length < Vector256<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(destination)), vector);
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x000FB835 File Offset: 0x000F9A35
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> Cos(Vector256<double> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Cos(vector._lower), Vector128.Cos(vector._upper));
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x000FB855 File Offset: 0x000F9A55
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> Cos(Vector256<float> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Cos(vector._lower), Vector128.Cos(vector._upper));
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x000FB875 File Offset: 0x000F9A75
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Create<[Nullable(2)] T>(T value)
		{
			Vector128<T> vector = Vector128.Create<T>(value);
			return Vector256.Create<T>(vector, vector);
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x000FB883 File Offset: 0x000F9A83
		[Intrinsic]
		public static Vector256<byte> Create(byte value)
		{
			return Vector256.Create<byte>(value);
		}

		// Token: 0x06004BD5 RID: 19413 RVA: 0x000FB88B File Offset: 0x000F9A8B
		[Intrinsic]
		public static Vector256<double> Create(double value)
		{
			return Vector256.Create<double>(value);
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x000FB893 File Offset: 0x000F9A93
		[Intrinsic]
		public static Vector256<short> Create(short value)
		{
			return Vector256.Create<short>(value);
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x000FB89B File Offset: 0x000F9A9B
		[Intrinsic]
		public static Vector256<int> Create(int value)
		{
			return Vector256.Create<int>(value);
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x000FB8A3 File Offset: 0x000F9AA3
		[Intrinsic]
		public static Vector256<long> Create(long value)
		{
			return Vector256.Create<long>(value);
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x000FB8AB File Offset: 0x000F9AAB
		[Intrinsic]
		public static Vector256<IntPtr> Create(IntPtr value)
		{
			return Vector256.Create<IntPtr>(value);
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x000FB8B3 File Offset: 0x000F9AB3
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<UIntPtr> Create(UIntPtr value)
		{
			return Vector256.Create<UIntPtr>(value);
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x000FB8BB File Offset: 0x000F9ABB
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<sbyte> Create(sbyte value)
		{
			return Vector256.Create<sbyte>(value);
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x000FB8C3 File Offset: 0x000F9AC3
		[Intrinsic]
		public static Vector256<float> Create(float value)
		{
			return Vector256.Create<float>(value);
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x000FB8CB File Offset: 0x000F9ACB
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ushort> Create(ushort value)
		{
			return Vector256.Create<ushort>(value);
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x000FB8D3 File Offset: 0x000F9AD3
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<uint> Create(uint value)
		{
			return Vector256.Create<uint>(value);
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x000FB8DB File Offset: 0x000F9ADB
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ulong> Create(ulong value)
		{
			return Vector256.Create<ulong>(value);
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x000FB8E3 File Offset: 0x000F9AE3
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Create<[Nullable(2)] T>(T[] values)
		{
			if (values.Length < Vector256<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return Unsafe.ReadUnaligned<Vector256<T>>(Unsafe.As<T, byte>(ref values[0]));
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x000FB905 File Offset: 0x000F9B05
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Create<[Nullable(2)] T>(T[] values, int index)
		{
			if (index < 0 || values.Length - index < Vector256<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return Unsafe.ReadUnaligned<Vector256<T>>(Unsafe.As<T, byte>(ref values[index]));
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x000FB92D File Offset: 0x000F9B2D
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values)
		{
			if (values.Length < Vector256<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.values);
			}
			return Unsafe.ReadUnaligned<Vector256<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(values)));
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x000FB954 File Offset: 0x000F9B54
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<byte> Create(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7, byte e8, byte e9, byte e10, byte e11, byte e12, byte e13, byte e14, byte e15, byte e16, byte e17, byte e18, byte e19, byte e20, byte e21, byte e22, byte e23, byte e24, byte e25, byte e26, byte e27, byte e28, byte e29, byte e30, byte e31)
		{
			return Vector256.Create(Vector128.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15), Vector128.Create(e16, e17, e18, e19, e20, e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31));
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x000FB9AC File Offset: 0x000F9BAC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> Create(double e0, double e1, double e2, double e3)
		{
			return Vector256.Create(Vector128.Create(e0, e1), Vector128.Create(e2, e3));
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x000FB9C4 File Offset: 0x000F9BC4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<short> Create(short e0, short e1, short e2, short e3, short e4, short e5, short e6, short e7, short e8, short e9, short e10, short e11, short e12, short e13, short e14, short e15)
		{
			return Vector256.Create(Vector128.Create(e0, e1, e2, e3, e4, e5, e6, e7), Vector128.Create(e8, e9, e10, e11, e12, e13, e14, e15));
		}

		// Token: 0x06004BE6 RID: 19430 RVA: 0x000FB9FC File Offset: 0x000F9BFC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<int> Create(int e0, int e1, int e2, int e3, int e4, int e5, int e6, int e7)
		{
			return Vector256.Create(Vector128.Create(e0, e1, e2, e3), Vector128.Create(e4, e5, e6, e7));
		}

		// Token: 0x06004BE7 RID: 19431 RVA: 0x000FBA19 File Offset: 0x000F9C19
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<long> Create(long e0, long e1, long e2, long e3)
		{
			return Vector256.Create(Vector128.Create(e0, e1), Vector128.Create(e2, e3));
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x000FBA30 File Offset: 0x000F9C30
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<sbyte> Create(sbyte e0, sbyte e1, sbyte e2, sbyte e3, sbyte e4, sbyte e5, sbyte e6, sbyte e7, sbyte e8, sbyte e9, sbyte e10, sbyte e11, sbyte e12, sbyte e13, sbyte e14, sbyte e15, sbyte e16, sbyte e17, sbyte e18, sbyte e19, sbyte e20, sbyte e21, sbyte e22, sbyte e23, sbyte e24, sbyte e25, sbyte e26, sbyte e27, sbyte e28, sbyte e29, sbyte e30, sbyte e31)
		{
			return Vector256.Create(Vector128.Create(e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15), Vector128.Create(e16, e17, e18, e19, e20, e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31));
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x000FBA88 File Offset: 0x000F9C88
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> Create(float e0, float e1, float e2, float e3, float e4, float e5, float e6, float e7)
		{
			return Vector256.Create(Vector128.Create(e0, e1, e2, e3), Vector128.Create(e4, e5, e6, e7));
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x000FBAA8 File Offset: 0x000F9CA8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<ushort> Create(ushort e0, ushort e1, ushort e2, ushort e3, ushort e4, ushort e5, ushort e6, ushort e7, ushort e8, ushort e9, ushort e10, ushort e11, ushort e12, ushort e13, ushort e14, ushort e15)
		{
			return Vector256.Create(Vector128.Create(e0, e1, e2, e3, e4, e5, e6, e7), Vector128.Create(e8, e9, e10, e11, e12, e13, e14, e15));
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x000FBAE0 File Offset: 0x000F9CE0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<uint> Create(uint e0, uint e1, uint e2, uint e3, uint e4, uint e5, uint e6, uint e7)
		{
			return Vector256.Create(Vector128.Create(e0, e1, e2, e3), Vector128.Create(e4, e5, e6, e7));
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x000FBAFD File Offset: 0x000F9CFD
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<ulong> Create(ulong e0, ulong e1, ulong e2, ulong e3)
		{
			return Vector256.Create(Vector128.Create(e0, e1), Vector128.Create(e2, e3));
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x000FBB12 File Offset: 0x000F9D12
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value)
		{
			return Vector256.Create<T>(Vector128.Create<T>(value, value));
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x000FBB20 File Offset: 0x000F9D20
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> value)
		{
			return Vector256.Create<T>(value, value);
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x000FBB2C File Offset: 0x000F9D2C
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> lower, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> upper)
		{
			if (false)
			{
			}
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			Vector256<T> result;
			Unsafe.SkipInit<Vector256<T>>(out result);
			result.SetLowerUnsafe(lower);
			result.SetUpperUnsafe(upper);
			return result;
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x000FBB59 File Offset: 0x000F9D59
		public static Vector256<byte> Create(Vector128<byte> lower, Vector128<byte> upper)
		{
			return Vector256.Create<byte>(lower, upper);
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x000FBB62 File Offset: 0x000F9D62
		public static Vector256<double> Create(Vector128<double> lower, Vector128<double> upper)
		{
			return Vector256.Create<double>(lower, upper);
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x000FBB6B File Offset: 0x000F9D6B
		public static Vector256<short> Create(Vector128<short> lower, Vector128<short> upper)
		{
			return Vector256.Create<short>(lower, upper);
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x000FBB74 File Offset: 0x000F9D74
		public static Vector256<int> Create(Vector128<int> lower, Vector128<int> upper)
		{
			return Vector256.Create<int>(lower, upper);
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x000FBB7D File Offset: 0x000F9D7D
		public static Vector256<long> Create(Vector128<long> lower, Vector128<long> upper)
		{
			return Vector256.Create<long>(lower, upper);
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x000FBB86 File Offset: 0x000F9D86
		public static Vector256<IntPtr> Create(Vector128<IntPtr> lower, Vector128<IntPtr> upper)
		{
			return Vector256.Create<IntPtr>(lower, upper);
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x000FBB8F File Offset: 0x000F9D8F
		[CLSCompliant(false)]
		public static Vector256<UIntPtr> Create(Vector128<UIntPtr> lower, Vector128<UIntPtr> upper)
		{
			return Vector256.Create<UIntPtr>(lower, upper);
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x000FBB98 File Offset: 0x000F9D98
		[CLSCompliant(false)]
		public static Vector256<sbyte> Create(Vector128<sbyte> lower, Vector128<sbyte> upper)
		{
			return Vector256.Create<sbyte>(lower, upper);
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x000FBBA1 File Offset: 0x000F9DA1
		public static Vector256<float> Create(Vector128<float> lower, Vector128<float> upper)
		{
			return Vector256.Create<float>(lower, upper);
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x000FBBAA File Offset: 0x000F9DAA
		[CLSCompliant(false)]
		public static Vector256<ushort> Create(Vector128<ushort> lower, Vector128<ushort> upper)
		{
			return Vector256.Create<ushort>(lower, upper);
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x000FBBB3 File Offset: 0x000F9DB3
		[CLSCompliant(false)]
		public static Vector256<uint> Create(Vector128<uint> lower, Vector128<uint> upper)
		{
			return Vector256.Create<uint>(lower, upper);
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x000FBBBC File Offset: 0x000F9DBC
		[CLSCompliant(false)]
		public static Vector256<ulong> Create(Vector128<ulong> lower, Vector128<ulong> upper)
		{
			return Vector256.Create<ulong>(lower, upper);
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x000FBBC5 File Offset: 0x000F9DC5
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> CreateScalar<[Nullable(2)] T>(T value)
		{
			return Vector128.CreateScalar<T>(value).ToVector256<T>();
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x000FBBD2 File Offset: 0x000F9DD2
		[Intrinsic]
		public static Vector256<byte> CreateScalar(byte value)
		{
			return Vector256.CreateScalar<byte>(value);
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x000FBBDA File Offset: 0x000F9DDA
		[Intrinsic]
		public static Vector256<double> CreateScalar(double value)
		{
			return Vector256.CreateScalar<double>(value);
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x000FBBE2 File Offset: 0x000F9DE2
		[Intrinsic]
		public static Vector256<short> CreateScalar(short value)
		{
			return Vector256.CreateScalar<short>(value);
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x000FBBEA File Offset: 0x000F9DEA
		[Intrinsic]
		public static Vector256<int> CreateScalar(int value)
		{
			return Vector256.CreateScalar<int>(value);
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x000FBBF2 File Offset: 0x000F9DF2
		[Intrinsic]
		public static Vector256<long> CreateScalar(long value)
		{
			return Vector256.CreateScalar<long>(value);
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x000FBBFA File Offset: 0x000F9DFA
		[Intrinsic]
		public static Vector256<IntPtr> CreateScalar(IntPtr value)
		{
			return Vector256.CreateScalar<IntPtr>(value);
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x000FBC02 File Offset: 0x000F9E02
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<UIntPtr> CreateScalar(UIntPtr value)
		{
			return Vector256.CreateScalar<UIntPtr>(value);
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x000FBC0A File Offset: 0x000F9E0A
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<sbyte> CreateScalar(sbyte value)
		{
			return Vector256.CreateScalar<sbyte>(value);
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x000FBC12 File Offset: 0x000F9E12
		[Intrinsic]
		public static Vector256<float> CreateScalar(float value)
		{
			return Vector256.CreateScalar<float>(value);
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x000FBC1A File Offset: 0x000F9E1A
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ushort> CreateScalar(ushort value)
		{
			return Vector256.CreateScalar<ushort>(value);
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x000FBC22 File Offset: 0x000F9E22
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<uint> CreateScalar(uint value)
		{
			return Vector256.CreateScalar<uint>(value);
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x000FBC2A File Offset: 0x000F9E2A
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ulong> CreateScalar(ulong value)
		{
			return Vector256.CreateScalar<ulong>(value);
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x000FBC34 File Offset: 0x000F9E34
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> CreateScalarUnsafe<[Nullable(2)] T>(T value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			Vector256<T> result;
			Unsafe.SkipInit<Vector256<T>>(out result);
			result.SetElementUnsafe(0, value);
			return result;
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x000FBC57 File Offset: 0x000F9E57
		[Intrinsic]
		public static Vector256<byte> CreateScalarUnsafe(byte value)
		{
			return Vector256.CreateScalarUnsafe<byte>(value);
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x000FBC5F File Offset: 0x000F9E5F
		[Intrinsic]
		public static Vector256<double> CreateScalarUnsafe(double value)
		{
			return Vector256.CreateScalarUnsafe<double>(value);
		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x000FBC67 File Offset: 0x000F9E67
		[Intrinsic]
		public static Vector256<short> CreateScalarUnsafe(short value)
		{
			return Vector256.CreateScalarUnsafe<short>(value);
		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x000FBC6F File Offset: 0x000F9E6F
		[Intrinsic]
		public static Vector256<int> CreateScalarUnsafe(int value)
		{
			return Vector256.CreateScalarUnsafe<int>(value);
		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x000FBC77 File Offset: 0x000F9E77
		[Intrinsic]
		public static Vector256<long> CreateScalarUnsafe(long value)
		{
			return Vector256.CreateScalarUnsafe<long>(value);
		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x000FBC7F File Offset: 0x000F9E7F
		[Intrinsic]
		public static Vector256<IntPtr> CreateScalarUnsafe(IntPtr value)
		{
			return Vector256.CreateScalarUnsafe<IntPtr>(value);
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x000FBC87 File Offset: 0x000F9E87
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<UIntPtr> CreateScalarUnsafe(UIntPtr value)
		{
			return Vector256.CreateScalarUnsafe<UIntPtr>(value);
		}

		// Token: 0x06004C11 RID: 19473 RVA: 0x000FBC8F File Offset: 0x000F9E8F
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<sbyte> CreateScalarUnsafe(sbyte value)
		{
			return Vector256.CreateScalarUnsafe<sbyte>(value);
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x000FBC97 File Offset: 0x000F9E97
		[Intrinsic]
		public static Vector256<float> CreateScalarUnsafe(float value)
		{
			return Vector256.CreateScalarUnsafe<float>(value);
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x000FBC9F File Offset: 0x000F9E9F
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ushort> CreateScalarUnsafe(ushort value)
		{
			return Vector256.CreateScalarUnsafe<ushort>(value);
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x000FBCA7 File Offset: 0x000F9EA7
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<uint> CreateScalarUnsafe(uint value)
		{
			return Vector256.CreateScalarUnsafe<uint>(value);
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x000FBCAF File Offset: 0x000F9EAF
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ulong> CreateScalarUnsafe(ulong value)
		{
			return Vector256.CreateScalarUnsafe<ulong>(value);
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x000FBCB7 File Offset: 0x000F9EB7
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> CreateSequence<[Nullable(2)] T>(T start, T step)
		{
			return Vector256<T>.Indices * step + Vector256.Create<T>(start);
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x000FBCCF File Offset: 0x000F9ECF
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> DegreesToRadians(Vector256<double> degrees)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.DegreesToRadians(degrees._lower), Vector128.DegreesToRadians(degrees._upper));
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x000FBCEF File Offset: 0x000F9EEF
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> DegreesToRadians(Vector256<float> degrees)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.DegreesToRadians(degrees._lower), Vector128.DegreesToRadians(degrees._upper));
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x000FBD0F File Offset: 0x000F9F0F
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Divide<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return left / right;
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x000FBD18 File Offset: 0x000F9F18
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Divide<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, T right)
		{
			return left / right;
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x000FBD21 File Offset: 0x000F9F21
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Dot<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Sum<T>(left * right);
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x000FBD2F File Offset: 0x000F9F2F
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Equals<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(Vector128.Equals<T>(left._lower, right._lower), Vector128.Equals<T>(left._upper, right._upper));
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x000FBD58 File Offset: 0x000F9F58
		[NullableContext(2)]
		[Intrinsic]
		public static bool EqualsAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return left == right;
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x000FBD61 File Offset: 0x000F9F61
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool EqualsAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector128.EqualsAny<T>(left._lower, right._lower) || Vector128.EqualsAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x000FBD89 File Offset: 0x000F9F89
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> Exp(Vector256<double> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Exp(vector._lower), Vector128.Exp(vector._upper));
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x000FBDA9 File Offset: 0x000F9FA9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> Exp(Vector256<float> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Exp(vector._lower), Vector128.Exp(vector._upper));
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x000FBDC9 File Offset: 0x000F9FC9
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ExtractMostSignificantBits<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			return vector._lower.ExtractMostSignificantBits<T>() | vector._upper.ExtractMostSignificantBits<T>() << Vector128<T>.Count;
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x000FBDEC File Offset: 0x000F9FEC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector256<T> Floor<T>(Vector256<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector256.Create<T>(Vector128.Floor<T>(vector._lower), Vector128.Floor<T>(vector._upper));
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x000FBF33 File Offset: 0x000FA133
		[Intrinsic]
		public static Vector256<float> Floor(Vector256<float> vector)
		{
			return Vector256.Floor<float>(vector);
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x000FBF3B File Offset: 0x000FA13B
		[Intrinsic]
		public static Vector256<double> Floor(Vector256<double> vector)
		{
			return Vector256.Floor<double>(vector);
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x000FBF43 File Offset: 0x000FA143
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> FusedMultiplyAdd(Vector256<double> left, Vector256<double> right, Vector256<double> addend)
		{
			return Vector256.Create(Vector128.FusedMultiplyAdd(left._lower, right._lower, addend._lower), Vector128.FusedMultiplyAdd(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x000FBF78 File Offset: 0x000FA178
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> FusedMultiplyAdd(Vector256<float> left, Vector256<float> right, Vector256<float> addend)
		{
			return Vector256.Create(Vector128.FusedMultiplyAdd(left._lower, right._lower, addend._lower), Vector128.FusedMultiplyAdd(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x000FBFAD File Offset: 0x000FA1AD
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetElement<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector, int index)
		{
			if (index >= Vector256<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return vector.GetElementUnsafe(index);
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x000FBFC6 File Offset: 0x000FA1C6
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> GetLower<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			return vector._lower;
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x000FBFD3 File Offset: 0x000FA1D3
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> GetUpper<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			return vector._upper;
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x000FBFE0 File Offset: 0x000FA1E0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> GreaterThan<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(Vector128.GreaterThan<T>(left._lower, right._lower), Vector128.GreaterThan<T>(left._upper, right._upper));
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x000FC009 File Offset: 0x000FA209
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector128.GreaterThanAll<T>(left._lower, right._lower) && Vector128.GreaterThanAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x000FC031 File Offset: 0x000FA231
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector128.GreaterThanAny<T>(left._lower, right._lower) || Vector128.GreaterThanAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x000FC059 File Offset: 0x000FA259
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> GreaterThanOrEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(Vector128.GreaterThanOrEqual<T>(left._lower, right._lower), Vector128.GreaterThanOrEqual<T>(left._upper, right._upper));
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x000FC082 File Offset: 0x000FA282
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanOrEqualAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector128.GreaterThanOrEqualAll<T>(left._lower, right._lower) && Vector128.GreaterThanOrEqualAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x000FC0AA File Offset: 0x000FA2AA
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanOrEqualAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector128.GreaterThanOrEqualAny<T>(left._lower, right._lower) || Vector128.GreaterThanOrEqualAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x000FC0D2 File Offset: 0x000FA2D2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> Hypot(Vector256<double> x, Vector256<double> y)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Hypot(x._lower, y._lower), Vector128.Hypot(x._upper, y._upper));
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x000FC0FE File Offset: 0x000FA2FE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> Hypot(Vector256<float> x, Vector256<float> y)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Hypot(x._lower, y._lower), Vector128.Hypot(x._upper, y._upper));
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x000FC12C File Offset: 0x000FA32C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> IsNaN<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				return ~Vector256.Equals<T>(vector, vector);
			}
			return Vector256<T>.Zero;
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x000FC184 File Offset: 0x000FA384
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> IsNegative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return Vector256<T>.Zero;
			}
			if (typeof(T) == typeof(float))
			{
				return Vector256.LessThan<int>(vector.AsInt32<T>(), Vector256<int>.Zero).As<int, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return Vector256.LessThan<long>(vector.AsInt64<T>(), Vector256<long>.Zero).As<long, T>();
			}
			return Vector256.LessThan<T>(vector, Vector256<T>.Zero);
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x000FC28C File Offset: 0x000FA48C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> IsPositive<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return Vector256<T>.AllBitsSet;
			}
			if (typeof(T) == typeof(float))
			{
				return Vector256.GreaterThanOrEqual<int>(vector.AsInt32<T>(), Vector256<int>.Zero).As<int, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return Vector256.GreaterThanOrEqual<long>(vector.AsInt64<T>(), Vector256<long>.Zero).As<long, T>();
			}
			return Vector256.GreaterThanOrEqual<T>(vector, Vector256<T>.Zero);
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x000FC394 File Offset: 0x000FA594
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> IsPositiveInfinity<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			if (typeof(T) == typeof(float))
			{
				return Vector256.Equals<T>(vector, Vector256.Create(float.PositiveInfinity).As<float, T>());
			}
			if (typeof(T) == typeof(double))
			{
				return Vector256.Equals<T>(vector, Vector256.Create(double.PositiveInfinity).As<double, T>());
			}
			return Vector256<T>.Zero;
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x000FC40C File Offset: 0x000FA60C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> IsZero<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			return Vector256.Equals<T>(vector, Vector256<T>.Zero);
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x000FC419 File Offset: 0x000FA619
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> Lerp(Vector256<double> x, Vector256<double> y, Vector256<double> amount)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Lerp(x._lower, y._lower, amount._lower), Vector128.Lerp(x._upper, y._upper, amount._upper));
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x000FC451 File Offset: 0x000FA651
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> Lerp(Vector256<float> x, Vector256<float> y, Vector256<float> amount)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Lerp(x._lower, y._lower, amount._lower), Vector128.Lerp(x._upper, y._upper, amount._upper));
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x000FC489 File Offset: 0x000FA689
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> LessThan<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(Vector128.LessThan<T>(left._lower, right._lower), Vector128.LessThan<T>(left._upper, right._upper));
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x000FC4B2 File Offset: 0x000FA6B2
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector128.LessThanAll<T>(left._lower, right._lower) && Vector128.LessThanAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x000FC4DA File Offset: 0x000FA6DA
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector128.LessThanAny<T>(left._lower, right._lower) || Vector128.LessThanAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x000FC502 File Offset: 0x000FA702
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> LessThanOrEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(Vector128.LessThanOrEqual<T>(left._lower, right._lower), Vector128.LessThanOrEqual<T>(left._upper, right._upper));
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x000FC52B File Offset: 0x000FA72B
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanOrEqualAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector128.LessThanOrEqualAll<T>(left._lower, right._lower) && Vector128.LessThanOrEqualAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x000FC553 File Offset: 0x000FA753
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanOrEqualAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector128.LessThanOrEqualAny<T>(left._lower, right._lower) || Vector128.LessThanOrEqualAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004C3F RID: 19519 RVA: 0x000FC57B File Offset: 0x000FA77B
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector256<T> Load<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			return Vector256.LoadUnsafe<T>(ref *source);
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x000FC583 File Offset: 0x000FA783
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector256<T> LoadAligned<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			if (source % 32 != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			return *(Vector256<T>*)source;
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x000FC59C File Offset: 0x000FA79C
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector256<T> LoadAlignedNonTemporal<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			return Vector256.LoadAligned<T>(source);
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x000FC5A4 File Offset: 0x000FA7A4
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> LoadUnsafe<[Nullable(2)] T>([RequiresLocation] [In] ref T source)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			return Unsafe.ReadUnaligned<Vector256<T>>(Unsafe.As<T, byte>(Unsafe.AsRef<T>(ref source)));
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x000FC5BB File Offset: 0x000FA7BB
		[NullableContext(1)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> LoadUnsafe<[Nullable(2)] T>([RequiresLocation] [In] ref T source, UIntPtr elementOffset)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			return Unsafe.ReadUnaligned<Vector256<T>>(Unsafe.As<T, byte>(Unsafe.Add<T>(Unsafe.AsRef<T>(ref source), (IntPtr)elementOffset)));
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x000FC5D8 File Offset: 0x000FA7D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> Log(Vector256<double> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Log(vector._lower), Vector128.Log(vector._upper));
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x000FC5F8 File Offset: 0x000FA7F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> Log(Vector256<float> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Log(vector._lower), Vector128.Log(vector._upper));
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x000FC618 File Offset: 0x000FA818
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> Log2(Vector256<double> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Log2(vector._lower), Vector128.Log2(vector._upper));
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x000FC638 File Offset: 0x000FA838
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> Log2(Vector256<float> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Log2(vector._lower), Vector128.Log2(vector._upper));
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x000FC658 File Offset: 0x000FA858
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Max<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			if (false)
			{
			}
			return Vector256.Create<T>(Vector128.Max<T>(left._lower, right._lower), Vector128.Max<T>(left._upper, right._upper));
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x000FC684 File Offset: 0x000FA884
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> MaxMagnitude<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			if (false)
			{
			}
			return Vector256.Create<T>(Vector128.MaxMagnitude<T>(left._lower, right._lower), Vector128.MaxMagnitude<T>(left._upper, right._upper));
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x000FC6B0 File Offset: 0x000FA8B0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> MaxMagnitudeNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			if (false)
			{
			}
			return Vector256.Create<T>(Vector128.MaxMagnitudeNumber<T>(left._lower, right._lower), Vector128.MaxMagnitudeNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x000FC6DC File Offset: 0x000FA8DC
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> MaxNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			if (false)
			{
			}
			return Vector256.Create<T>(Vector128.MaxNative<T>(left._lower, right._lower), Vector128.MaxNative<T>(left._upper, right._upper));
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x000FC708 File Offset: 0x000FA908
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> MaxNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			if (false)
			{
			}
			return Vector256.Create<T>(Vector128.MaxNumber<T>(left._lower, right._lower), Vector128.MaxNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x000FC734 File Offset: 0x000FA934
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Min<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			if (false)
			{
			}
			return Vector256.Create<T>(Vector128.Min<T>(left._lower, right._lower), Vector128.Min<T>(left._upper, right._upper));
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x000FC760 File Offset: 0x000FA960
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> MinMagnitude<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			if (false)
			{
			}
			return Vector256.Create<T>(Vector128.MinMagnitude<T>(left._lower, right._lower), Vector128.MinMagnitude<T>(left._upper, right._upper));
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x000FC78C File Offset: 0x000FA98C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> MinMagnitudeNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			if (false)
			{
			}
			return Vector256.Create<T>(Vector128.MinMagnitudeNumber<T>(left._lower, right._lower), Vector128.MinMagnitudeNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x000FC7B8 File Offset: 0x000FA9B8
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> MinNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			if (false)
			{
			}
			return Vector256.Create<T>(Vector128.MinNative<T>(left._lower, right._lower), Vector128.MinNative<T>(left._upper, right._upper));
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x000FC7E4 File Offset: 0x000FA9E4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> MinNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			if (false)
			{
			}
			return Vector256.Create<T>(Vector128.MinNumber<T>(left._lower, right._lower), Vector128.MinNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x000FC810 File Offset: 0x000FAA10
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Multiply<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return left * right;
		}

		// Token: 0x06004C53 RID: 19539 RVA: 0x000FC819 File Offset: 0x000FAA19
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Multiply<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, T right)
		{
			return left * right;
		}

		// Token: 0x06004C54 RID: 19540 RVA: 0x000FC822 File Offset: 0x000FAA22
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Multiply<[Nullable(2)] T>(T left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return right * left;
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x000FC82B File Offset: 0x000FAA2B
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector256<T> MultiplyAddEstimate<T>(Vector256<T> left, Vector256<T> right, Vector256<T> addend)
		{
			return Vector256.Create<T>(Vector128.MultiplyAddEstimate<T>(left._lower, right._lower, addend._lower), Vector128.MultiplyAddEstimate<T>(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x000FC860 File Offset: 0x000FAA60
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> MultiplyAddEstimate(Vector256<double> left, Vector256<double> right, Vector256<double> addend)
		{
			return Vector256.Create(Vector128.MultiplyAddEstimate(left._lower, right._lower, addend._lower), Vector128.MultiplyAddEstimate(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x000FC895 File Offset: 0x000FAA95
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> MultiplyAddEstimate(Vector256<float> left, Vector256<float> right, Vector256<float> addend)
		{
			return Vector256.Create(Vector128.MultiplyAddEstimate(left._lower, right._lower, addend._lower), Vector128.MultiplyAddEstimate(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x000FC8CA File Offset: 0x000FAACA
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> Narrow(Vector256<double> lower, Vector256<double> upper)
		{
			return Vector256.Create(Vector128.Narrow(lower._lower, lower._upper), Vector128.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x000FC8F3 File Offset: 0x000FAAF3
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<sbyte> Narrow(Vector256<short> lower, Vector256<short> upper)
		{
			return Vector256.Create(Vector128.Narrow(lower._lower, lower._upper), Vector128.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x000FC91C File Offset: 0x000FAB1C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<short> Narrow(Vector256<int> lower, Vector256<int> upper)
		{
			return Vector256.Create(Vector128.Narrow(lower._lower, lower._upper), Vector128.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x000FC945 File Offset: 0x000FAB45
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<int> Narrow(Vector256<long> lower, Vector256<long> upper)
		{
			return Vector256.Create(Vector128.Narrow(lower._lower, lower._upper), Vector128.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x000FC96E File Offset: 0x000FAB6E
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<byte> Narrow(Vector256<ushort> lower, Vector256<ushort> upper)
		{
			return Vector256.Create(Vector128.Narrow(lower._lower, lower._upper), Vector128.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x000FC997 File Offset: 0x000FAB97
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<ushort> Narrow(Vector256<uint> lower, Vector256<uint> upper)
		{
			return Vector256.Create(Vector128.Narrow(lower._lower, lower._upper), Vector128.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x000FC9C0 File Offset: 0x000FABC0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<uint> Narrow(Vector256<ulong> lower, Vector256<ulong> upper)
		{
			return Vector256.Create(Vector128.Narrow(lower._lower, lower._upper), Vector128.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x000FC9E9 File Offset: 0x000FABE9
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Negate<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			return -vector;
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x000FC9F1 File Offset: 0x000FABF1
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> OnesComplement<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			return ~vector;
		}

		// Token: 0x06004C61 RID: 19553 RVA: 0x000FC9F9 File Offset: 0x000FABF9
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> RadiansToDegrees(Vector256<double> radians)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.RadiansToDegrees(radians._lower), Vector128.RadiansToDegrees(radians._upper));
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x000FCA19 File Offset: 0x000FAC19
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> RadiansToDegrees(Vector256<float> radians)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.RadiansToDegrees(radians._lower), Vector128.RadiansToDegrees(radians._upper));
		}

		// Token: 0x06004C63 RID: 19555 RVA: 0x000FCA3C File Offset: 0x000FAC3C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector256<T> Round<T>(Vector256<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector256.Create<T>(Vector128.Round<T>(vector._lower), Vector128.Round<T>(vector._upper));
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x000FCB83 File Offset: 0x000FAD83
		[Intrinsic]
		public static Vector256<double> Round(Vector256<double> vector)
		{
			return Vector256.Round<double>(vector);
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x000FCB8B File Offset: 0x000FAD8B
		[Intrinsic]
		public static Vector256<float> Round(Vector256<float> vector)
		{
			return Vector256.Round<float>(vector);
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x000FCB93 File Offset: 0x000FAD93
		[Intrinsic]
		public static Vector256<double> Round(Vector256<double> vector, MidpointRounding mode)
		{
			return VectorMath.RoundDouble<Vector256<double>>(vector, mode);
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x000FCB9C File Offset: 0x000FAD9C
		[Intrinsic]
		public static Vector256<float> Round(Vector256<float> vector, MidpointRounding mode)
		{
			return VectorMath.RoundSingle<Vector256<float>>(vector, mode);
		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x000FCBA5 File Offset: 0x000FADA5
		[Intrinsic]
		public static Vector256<byte> ShiftLeft(Vector256<byte> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x000FCBAE File Offset: 0x000FADAE
		[Intrinsic]
		public static Vector256<short> ShiftLeft(Vector256<short> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x000FCBB7 File Offset: 0x000FADB7
		[Intrinsic]
		public static Vector256<int> ShiftLeft(Vector256<int> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x000FCBC0 File Offset: 0x000FADC0
		[Intrinsic]
		public static Vector256<long> ShiftLeft(Vector256<long> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x000FCBC9 File Offset: 0x000FADC9
		[Intrinsic]
		public static Vector256<IntPtr> ShiftLeft(Vector256<IntPtr> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x000FCBD2 File Offset: 0x000FADD2
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<UIntPtr> ShiftLeft(Vector256<UIntPtr> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x000FCBDB File Offset: 0x000FADDB
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<sbyte> ShiftLeft(Vector256<sbyte> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x000FCBE4 File Offset: 0x000FADE4
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ushort> ShiftLeft(Vector256<ushort> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x000FCBED File Offset: 0x000FADED
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<uint> ShiftLeft(Vector256<uint> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x000FCBF6 File Offset: 0x000FADF6
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ulong> ShiftLeft(Vector256<ulong> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x000FCBFF File Offset: 0x000FADFF
		[Intrinsic]
		public static Vector256<short> ShiftRightArithmetic(Vector256<short> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x000FCC08 File Offset: 0x000FAE08
		[Intrinsic]
		public static Vector256<int> ShiftRightArithmetic(Vector256<int> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x000FCC11 File Offset: 0x000FAE11
		[Intrinsic]
		public static Vector256<long> ShiftRightArithmetic(Vector256<long> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x000FCC1A File Offset: 0x000FAE1A
		[Intrinsic]
		public static Vector256<IntPtr> ShiftRightArithmetic(Vector256<IntPtr> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x000FCC23 File Offset: 0x000FAE23
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x000FCC2C File Offset: 0x000FAE2C
		[Intrinsic]
		public static Vector256<byte> ShiftRightLogical(Vector256<byte> vector, int shiftCount)
		{
			return Vector256<byte>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x000FCC35 File Offset: 0x000FAE35
		[Intrinsic]
		public static Vector256<short> ShiftRightLogical(Vector256<short> vector, int shiftCount)
		{
			return Vector256<short>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x000FCC3E File Offset: 0x000FAE3E
		[Intrinsic]
		public static Vector256<int> ShiftRightLogical(Vector256<int> vector, int shiftCount)
		{
			return Vector256<int>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x000FCC47 File Offset: 0x000FAE47
		[Intrinsic]
		public static Vector256<long> ShiftRightLogical(Vector256<long> vector, int shiftCount)
		{
			return Vector256<long>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x000FCC50 File Offset: 0x000FAE50
		[Intrinsic]
		public static Vector256<IntPtr> ShiftRightLogical(Vector256<IntPtr> vector, int shiftCount)
		{
			return Vector256<IntPtr>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x000FCC59 File Offset: 0x000FAE59
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<UIntPtr> ShiftRightLogical(Vector256<UIntPtr> vector, int shiftCount)
		{
			return Vector256<UIntPtr>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004C7D RID: 19581 RVA: 0x000FCC62 File Offset: 0x000FAE62
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<sbyte> ShiftRightLogical(Vector256<sbyte> vector, int shiftCount)
		{
			return Vector256<sbyte>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x000FCC6B File Offset: 0x000FAE6B
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> vector, int shiftCount)
		{
			return Vector256<ushort>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x000FCC74 File Offset: 0x000FAE74
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<uint> ShiftRightLogical(Vector256<uint> vector, int shiftCount)
		{
			return Vector256<uint>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x000FCC7D File Offset: 0x000FAE7D
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> vector, int shiftCount)
		{
			return Vector256<ulong>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004C81 RID: 19585 RVA: 0x000FCC88 File Offset: 0x000FAE88
		[Intrinsic]
		public static Vector256<byte> Shuffle(Vector256<byte> vector, Vector256<byte> indices)
		{
			Vector256<byte> result;
			Unsafe.SkipInit<Vector256<byte>>(out result);
			for (int i = 0; i < Vector256<byte>.Count; i++)
			{
				byte elementUnsafe = indices.GetElementUnsafe(i);
				byte value = 0;
				if ((int)elementUnsafe < Vector256<byte>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004C82 RID: 19586 RVA: 0x000FCCD4 File Offset: 0x000FAED4
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<sbyte> Shuffle(Vector256<sbyte> vector, Vector256<sbyte> indices)
		{
			Vector256<sbyte> result;
			Unsafe.SkipInit<Vector256<sbyte>>(out result);
			for (int i = 0; i < Vector256<sbyte>.Count; i++)
			{
				byte b = (byte)indices.GetElementUnsafe(i);
				sbyte value = 0;
				if ((int)b < Vector256<sbyte>.Count)
				{
					value = vector.GetElementUnsafe((int)b);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004C83 RID: 19587 RVA: 0x000FCD20 File Offset: 0x000FAF20
		[Intrinsic]
		public static Vector256<short> Shuffle(Vector256<short> vector, Vector256<short> indices)
		{
			Vector256<short> result;
			Unsafe.SkipInit<Vector256<short>>(out result);
			for (int i = 0; i < Vector256<short>.Count; i++)
			{
				ushort num = (ushort)indices.GetElementUnsafe(i);
				short value = 0;
				if ((int)num < Vector256<short>.Count)
				{
					value = vector.GetElementUnsafe((int)num);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x000FCD6C File Offset: 0x000FAF6C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ushort> Shuffle(Vector256<ushort> vector, Vector256<ushort> indices)
		{
			Vector256<ushort> result;
			Unsafe.SkipInit<Vector256<ushort>>(out result);
			for (int i = 0; i < Vector256<ushort>.Count; i++)
			{
				ushort elementUnsafe = indices.GetElementUnsafe(i);
				ushort value = 0;
				if ((int)elementUnsafe < Vector256<ushort>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x000FCDB8 File Offset: 0x000FAFB8
		[Intrinsic]
		public static Vector256<int> Shuffle(Vector256<int> vector, Vector256<int> indices)
		{
			Vector256<int> result;
			Unsafe.SkipInit<Vector256<int>>(out result);
			for (int i = 0; i < Vector256<int>.Count; i++)
			{
				uint elementUnsafe = (uint)indices.GetElementUnsafe(i);
				int value = 0;
				if ((ulong)elementUnsafe < (ulong)((long)Vector256<int>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x000FCE04 File Offset: 0x000FB004
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<uint> Shuffle(Vector256<uint> vector, Vector256<uint> indices)
		{
			Vector256<uint> result;
			Unsafe.SkipInit<Vector256<uint>>(out result);
			for (int i = 0; i < Vector256<uint>.Count; i++)
			{
				uint elementUnsafe = indices.GetElementUnsafe(i);
				uint value = 0U;
				if ((ulong)elementUnsafe < (ulong)((long)Vector256<uint>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x000FCE50 File Offset: 0x000FB050
		[Intrinsic]
		public static Vector256<float> Shuffle(Vector256<float> vector, Vector256<int> indices)
		{
			Vector256<float> result;
			Unsafe.SkipInit<Vector256<float>>(out result);
			for (int i = 0; i < Vector256<float>.Count; i++)
			{
				uint elementUnsafe = (uint)indices.GetElementUnsafe(i);
				float value = 0f;
				if ((ulong)elementUnsafe < (ulong)((long)Vector256<float>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x000FCEA0 File Offset: 0x000FB0A0
		[Intrinsic]
		public static Vector256<long> Shuffle(Vector256<long> vector, Vector256<long> indices)
		{
			Vector256<long> result;
			Unsafe.SkipInit<Vector256<long>>(out result);
			for (int i = 0; i < Vector256<long>.Count; i++)
			{
				ulong elementUnsafe = (ulong)indices.GetElementUnsafe(i);
				long value = 0L;
				if (elementUnsafe < (ulong)Vector256<long>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x000FCEF0 File Offset: 0x000FB0F0
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector256<ulong> Shuffle(Vector256<ulong> vector, Vector256<ulong> indices)
		{
			Vector256<ulong> result;
			Unsafe.SkipInit<Vector256<ulong>>(out result);
			for (int i = 0; i < Vector256<ulong>.Count; i++)
			{
				ulong elementUnsafe = indices.GetElementUnsafe(i);
				ulong value = 0UL;
				if (elementUnsafe < (ulong)Vector256<ulong>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x000FCF40 File Offset: 0x000FB140
		[Intrinsic]
		public static Vector256<double> Shuffle(Vector256<double> vector, Vector256<long> indices)
		{
			Vector256<double> result;
			Unsafe.SkipInit<Vector256<double>>(out result);
			for (int i = 0; i < Vector256<double>.Count; i++)
			{
				ulong elementUnsafe = (ulong)indices.GetElementUnsafe(i);
				double value = 0.0;
				if (elementUnsafe < (ulong)Vector256<double>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x000FCF94 File Offset: 0x000FB194
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> Sin(Vector256<double> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Sin(vector._lower), Vector128.Sin(vector._upper));
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x000FCFB4 File Offset: 0x000FB1B4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<float> Sin(Vector256<float> vector)
		{
			if (false)
			{
			}
			return Vector256.Create(Vector128.Sin(vector._lower), Vector128.Sin(vector._upper));
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x000FCFD4 File Offset: 0x000FB1D4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector256<double>, Vector256<double>> SinCos(Vector256<double> vector)
		{
			if (false)
			{
			}
			ValueTuple<Vector128<double>, Vector128<double>> valueTuple = Vector128.SinCos(vector._lower);
			Vector128<double> item = valueTuple.Item1;
			Vector128<double> item2 = valueTuple.Item2;
			ValueTuple<Vector128<double>, Vector128<double>> valueTuple2 = Vector128.SinCos(vector._upper);
			Vector128<double> item3 = valueTuple2.Item1;
			Vector128<double> item4 = valueTuple2.Item2;
			return new ValueTuple<Vector256<double>, Vector256<double>>(Vector256.Create(item, item3), Vector256.Create(item2, item4));
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x000FD028 File Offset: 0x000FB228
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector256<float>, Vector256<float>> SinCos(Vector256<float> vector)
		{
			if (false)
			{
			}
			ValueTuple<Vector128<float>, Vector128<float>> valueTuple = Vector128.SinCos(vector._lower);
			Vector128<float> item = valueTuple.Item1;
			Vector128<float> item2 = valueTuple.Item2;
			ValueTuple<Vector128<float>, Vector128<float>> valueTuple2 = Vector128.SinCos(vector._upper);
			Vector128<float> item3 = valueTuple2.Item1;
			Vector128<float> item4 = valueTuple2.Item2;
			return new ValueTuple<Vector256<float>, Vector256<float>>(Vector256.Create(item, item3), Vector256.Create(item2, item4));
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x000FD07B File Offset: 0x000FB27B
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Sqrt<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			return Vector256.Create<T>(Vector128.Sqrt<T>(vector._lower), Vector128.Sqrt<T>(vector._upper));
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x000FD098 File Offset: 0x000FB298
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		public unsafe static void Store<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			source.StoreUnsafe(ref *destination);
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x000FD0A1 File Offset: 0x000FB2A1
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void StoreAligned<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			if (destination % 32 != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			*(Vector256<T>*)destination = source;
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x000FD0BB File Offset: 0x000FB2BB
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		public unsafe static void StoreAlignedNonTemporal<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			source.StoreAligned(destination);
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x000FD0C4 File Offset: 0x000FB2C4
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StoreUnsafe<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> source, ref T destination)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<T, byte>(ref destination), source);
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x000FD0D7 File Offset: 0x000FB2D7
		[NullableContext(1)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StoreUnsafe<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> source, ref T destination, UIntPtr elementOffset)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			destination = Unsafe.Add<T>(ref destination, (IntPtr)elementOffset);
			Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<T, byte>(ref destination), source);
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x000FD0F3 File Offset: 0x000FB2F3
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Subtract<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return left - right;
		}

		// Token: 0x06004C96 RID: 19606 RVA: 0x000FD0FC File Offset: 0x000FB2FC
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Sum<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			return Scalar<T>.Add(Vector128.Sum<T>(vector._lower), Vector128.Sum<T>(vector._upper));
		}

		// Token: 0x06004C97 RID: 19607 RVA: 0x000FD119 File Offset: 0x000FB319
		[NullableContext(1)]
		[Intrinsic]
		public static T ToScalar<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			return vector.GetElementUnsafe(0);
		}

		// Token: 0x06004C98 RID: 19608 RVA: 0x000FD128 File Offset: 0x000FB328
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> ToVector512<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			Vector512<T> result = default(Vector512<T>);
			result.SetLowerUnsafe(vector);
			return result;
		}

		// Token: 0x06004C99 RID: 19609 RVA: 0x000FD14C File Offset: 0x000FB34C
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> ToVector512Unsafe<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			Vector512<T> result;
			Unsafe.SkipInit<Vector512<T>>(out result);
			result.SetLowerUnsafe(vector);
			return result;
		}

		// Token: 0x06004C9A RID: 19610 RVA: 0x000FD170 File Offset: 0x000FB370
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector256<T> Truncate<T>(Vector256<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector256.Create<T>(Vector128.Truncate<T>(vector._lower), Vector128.Truncate<T>(vector._upper));
		}

		// Token: 0x06004C9B RID: 19611 RVA: 0x000FD2B7 File Offset: 0x000FB4B7
		[Intrinsic]
		public static Vector256<double> Truncate(Vector256<double> vector)
		{
			return Vector256.Truncate<double>(vector);
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x000FD2BF File Offset: 0x000FB4BF
		[Intrinsic]
		public static Vector256<float> Truncate(Vector256<float> vector)
		{
			return Vector256.Truncate<float>(vector);
		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x000FD2C7 File Offset: 0x000FB4C7
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryCopyTo<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (destination.Length < Vector256<T>.Count)
			{
				return false;
			}
			Unsafe.WriteUnaligned<Vector256<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(destination)), vector);
			return true;
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x000FD2EB File Offset: 0x000FB4EB
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector256<ushort>, Vector256<ushort>> Widen(Vector256<byte> source)
		{
			return new ValueTuple<Vector256<ushort>, Vector256<ushort>>(Vector256.WidenLower(source), Vector256.WidenUpper(source));
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x000FD2FE File Offset: 0x000FB4FE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector256<int>, Vector256<int>> Widen(Vector256<short> source)
		{
			return new ValueTuple<Vector256<int>, Vector256<int>>(Vector256.WidenLower(source), Vector256.WidenUpper(source));
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x000FD311 File Offset: 0x000FB511
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector256<long>, Vector256<long>> Widen(Vector256<int> source)
		{
			return new ValueTuple<Vector256<long>, Vector256<long>>(Vector256.WidenLower(source), Vector256.WidenUpper(source));
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x000FD324 File Offset: 0x000FB524
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector256<short>, Vector256<short>> Widen(Vector256<sbyte> source)
		{
			return new ValueTuple<Vector256<short>, Vector256<short>>(Vector256.WidenLower(source), Vector256.WidenUpper(source));
		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x000FD337 File Offset: 0x000FB537
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector256<double>, Vector256<double>> Widen(Vector256<float> source)
		{
			return new ValueTuple<Vector256<double>, Vector256<double>>(Vector256.WidenLower(source), Vector256.WidenUpper(source));
		}

		// Token: 0x06004CA3 RID: 19619 RVA: 0x000FD34A File Offset: 0x000FB54A
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector256<uint>, Vector256<uint>> Widen(Vector256<ushort> source)
		{
			return new ValueTuple<Vector256<uint>, Vector256<uint>>(Vector256.WidenLower(source), Vector256.WidenUpper(source));
		}

		// Token: 0x06004CA4 RID: 19620 RVA: 0x000FD35D File Offset: 0x000FB55D
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector256<ulong>, Vector256<ulong>> Widen(Vector256<uint> source)
		{
			return new ValueTuple<Vector256<ulong>, Vector256<ulong>>(Vector256.WidenLower(source), Vector256.WidenUpper(source));
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x000FD370 File Offset: 0x000FB570
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<ushort> WidenLower(Vector256<byte> source)
		{
			Vector128<byte> lower = source._lower;
			return Vector256.Create(Vector128.WidenLower(lower), Vector128.WidenUpper(lower));
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x000FD398 File Offset: 0x000FB598
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<int> WidenLower(Vector256<short> source)
		{
			Vector128<short> lower = source._lower;
			return Vector256.Create(Vector128.WidenLower(lower), Vector128.WidenUpper(lower));
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x000FD3C0 File Offset: 0x000FB5C0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<long> WidenLower(Vector256<int> source)
		{
			Vector128<int> lower = source._lower;
			return Vector256.Create(Vector128.WidenLower(lower), Vector128.WidenUpper(lower));
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x000FD3E8 File Offset: 0x000FB5E8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<short> WidenLower(Vector256<sbyte> source)
		{
			Vector128<sbyte> lower = source._lower;
			return Vector256.Create(Vector128.WidenLower(lower), Vector128.WidenUpper(lower));
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x000FD410 File Offset: 0x000FB610
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> WidenLower(Vector256<float> source)
		{
			Vector128<float> lower = source._lower;
			return Vector256.Create(Vector128.WidenLower(lower), Vector128.WidenUpper(lower));
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x000FD438 File Offset: 0x000FB638
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<uint> WidenLower(Vector256<ushort> source)
		{
			Vector128<ushort> lower = source._lower;
			return Vector256.Create(Vector128.WidenLower(lower), Vector128.WidenUpper(lower));
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x000FD460 File Offset: 0x000FB660
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<ulong> WidenLower(Vector256<uint> source)
		{
			Vector128<uint> lower = source._lower;
			return Vector256.Create(Vector128.WidenLower(lower), Vector128.WidenUpper(lower));
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x000FD488 File Offset: 0x000FB688
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<ushort> WidenUpper(Vector256<byte> source)
		{
			Vector128<byte> upper = source._upper;
			return Vector256.Create(Vector128.WidenLower(upper), Vector128.WidenUpper(upper));
		}

		// Token: 0x06004CAD RID: 19629 RVA: 0x000FD4B0 File Offset: 0x000FB6B0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<int> WidenUpper(Vector256<short> source)
		{
			Vector128<short> upper = source._upper;
			return Vector256.Create(Vector128.WidenLower(upper), Vector128.WidenUpper(upper));
		}

		// Token: 0x06004CAE RID: 19630 RVA: 0x000FD4D8 File Offset: 0x000FB6D8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<long> WidenUpper(Vector256<int> source)
		{
			Vector128<int> upper = source._upper;
			return Vector256.Create(Vector128.WidenLower(upper), Vector128.WidenUpper(upper));
		}

		// Token: 0x06004CAF RID: 19631 RVA: 0x000FD500 File Offset: 0x000FB700
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<short> WidenUpper(Vector256<sbyte> source)
		{
			Vector128<sbyte> upper = source._upper;
			return Vector256.Create(Vector128.WidenLower(upper), Vector128.WidenUpper(upper));
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x000FD528 File Offset: 0x000FB728
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<double> WidenUpper(Vector256<float> source)
		{
			Vector128<float> upper = source._upper;
			return Vector256.Create(Vector128.WidenLower(upper), Vector128.WidenUpper(upper));
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x000FD550 File Offset: 0x000FB750
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<uint> WidenUpper(Vector256<ushort> source)
		{
			Vector128<ushort> upper = source._upper;
			return Vector256.Create(Vector128.WidenLower(upper), Vector128.WidenUpper(upper));
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x000FD578 File Offset: 0x000FB778
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector256<ulong> WidenUpper(Vector256<uint> source)
		{
			Vector128<uint> upper = source._upper;
			return Vector256.Create(Vector128.WidenLower(upper), Vector128.WidenUpper(upper));
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x000FD5A0 File Offset: 0x000FB7A0
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> WithElement<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector, int index, T value)
		{
			if (index >= Vector256<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			Vector256<T> result = vector;
			result.SetElementUnsafe(index, value);
			return result;
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x000FD5C8 File Offset: 0x000FB7C8
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> WithLower<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			Vector256<T> result = vector;
			result.SetLowerUnsafe(value);
			return result;
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x000FD5E8 File Offset: 0x000FB7E8
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> WithUpper<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector256<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			Vector256<T> result = vector;
			result.SetUpperUnsafe(value);
			return result;
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x000FD605 File Offset: 0x000FB805
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Xor<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return left ^ right;
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x000FD60E File Offset: 0x000FB80E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static T GetElementUnsafe<T>(this Vector256<T> vector, int index)
		{
			return *Unsafe.Add<T>(Unsafe.As<Vector256<T>, T>(Unsafe.AsRef<Vector256<T>>(ref vector)), index);
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x000FD626 File Offset: 0x000FB826
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void SetElementUnsafe<T>(this Vector256<T> vector, int index, T value)
		{
			*Unsafe.Add<T>(Unsafe.As<Vector256<T>, T>(Unsafe.AsRef<Vector256<T>>(ref vector)), index) = value;
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x000FD63F File Offset: 0x000FB83F
		internal unsafe static void SetLowerUnsafe<T>(this Vector256<T> vector, Vector128<T> value)
		{
			*Unsafe.AsRef<Vector128<T>>(ref vector._lower) = value;
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x000FD652 File Offset: 0x000FB852
		internal unsafe static void SetUpperUnsafe<T>(this Vector256<T> vector, Vector128<T> value)
		{
			*Unsafe.AsRef<Vector128<T>>(ref vector._upper) = value;
		}
	}
}
