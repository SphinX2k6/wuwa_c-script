using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Runtime.Intrinsics
{
	// Token: 0x0200054C RID: 1356
	public static class Vector64
	{
		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06004ED3 RID: 20179 RVA: 0x00007B65 File Offset: 0x00005D65
		public static bool IsHardwareAccelerated
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06004ED4 RID: 20180 RVA: 0x0010107C File Offset: 0x000FF27C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Abs<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return vector;
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Abs(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x00101141 File Offset: 0x000FF341
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Add<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return left + right;
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x0010114A File Offset: 0x000FF34A
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> AndNot<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return left & ~right;
		}

		// Token: 0x06004ED7 RID: 20183 RVA: 0x00101158 File Offset: 0x000FF358
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector64<TTo> As<TFrom, TTo>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<TFrom> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<TFrom>();
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<TTo>();
			return *Unsafe.As<Vector64<TFrom>, Vector64<TTo>>(ref vector);
		}

		// Token: 0x06004ED8 RID: 20184 RVA: 0x00101170 File Offset: 0x000FF370
		[Intrinsic]
		public static Vector64<byte> AsByte<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, byte>();
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x00101178 File Offset: 0x000FF378
		[Intrinsic]
		public static Vector64<double> AsDouble<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, double>();
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x00101180 File Offset: 0x000FF380
		[Intrinsic]
		public static Vector64<short> AsInt16<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, short>();
		}

		// Token: 0x06004EDB RID: 20187 RVA: 0x00101188 File Offset: 0x000FF388
		[Intrinsic]
		public static Vector64<int> AsInt32<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, int>();
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x00101190 File Offset: 0x000FF390
		[Intrinsic]
		public static Vector64<long> AsInt64<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, long>();
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x00101198 File Offset: 0x000FF398
		[Intrinsic]
		public static Vector64<IntPtr> AsNInt<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, IntPtr>();
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x001011A0 File Offset: 0x000FF3A0
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<UIntPtr> AsNUInt<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, UIntPtr>();
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x001011A8 File Offset: 0x000FF3A8
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<sbyte> AsSByte<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, sbyte>();
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x001011B0 File Offset: 0x000FF3B0
		[Intrinsic]
		public static Vector64<float> AsSingle<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, float>();
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x001011B8 File Offset: 0x000FF3B8
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ushort> AsUInt16<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, ushort>();
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x001011C0 File Offset: 0x000FF3C0
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<uint> AsUInt32<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, uint>();
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x001011C8 File Offset: 0x000FF3C8
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ulong> AsUInt64<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			return vector.As<T, ulong>();
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x001011D0 File Offset: 0x000FF3D0
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> BitwiseAnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return left & right;
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x001011D9 File Offset: 0x000FF3D9
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> BitwiseOr<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return left | right;
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x001011E4 File Offset: 0x000FF3E4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector64<T> Ceiling<T>(Vector64<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Ceiling(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x0010133F File Offset: 0x000FF53F
		[Intrinsic]
		public static Vector64<float> Ceiling(Vector64<float> vector)
		{
			return Vector64.Ceiling<float>(vector);
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x00101347 File Offset: 0x000FF547
		[Intrinsic]
		public static Vector64<double> Ceiling(Vector64<double> vector)
		{
			return Vector64.Ceiling<double>(vector);
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x0010134F File Offset: 0x000FF54F
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Clamp<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> min, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> max)
		{
			return Vector64.Min<T>(Vector64.Max<T>(value, min), max);
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x0010135E File Offset: 0x000FF55E
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> ClampNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> min, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> max)
		{
			return Vector64.MinNative<T>(Vector64.MaxNative<T>(value, min), max);
		}

		// Token: 0x06004EEB RID: 20203 RVA: 0x0010136D File Offset: 0x000FF56D
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> ConditionalSelect<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> condition, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return (left & condition) | Vector64.AndNot<T>(right, condition);
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x00101384 File Offset: 0x000FF584
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> ConvertToDouble(Vector64<long> vector)
		{
			Vector64<double> result;
			Unsafe.SkipInit<Vector64<double>>(out result);
			for (int i = 0; i < Vector64<double>.Count; i++)
			{
				double value = (double)vector.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x001013BC File Offset: 0x000FF5BC
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> ConvertToDouble(Vector64<ulong> vector)
		{
			Vector64<double> result;
			Unsafe.SkipInit<Vector64<double>>(out result);
			for (int i = 0; i < Vector64<double>.Count; i++)
			{
				double value = vector.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x001013F8 File Offset: 0x000FF5F8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<int> ConvertToInt32(Vector64<float> vector)
		{
			Vector64<int> result;
			Unsafe.SkipInit<Vector64<int>>(out result);
			for (int i = 0; i < Vector64<int>.Count; i++)
			{
				int value = float.ConvertToInteger<int>(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EEF RID: 20207 RVA: 0x00101434 File Offset: 0x000FF634
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<int> ConvertToInt32Native(Vector64<float> vector)
		{
			Vector64<int> result;
			Unsafe.SkipInit<Vector64<int>>(out result);
			for (int i = 0; i < Vector64<int>.Count; i++)
			{
				int value = float.ConvertToIntegerNative<int>(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x00101470 File Offset: 0x000FF670
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<long> ConvertToInt64(Vector64<double> vector)
		{
			Vector64<long> result;
			Unsafe.SkipInit<Vector64<long>>(out result);
			for (int i = 0; i < Vector64<long>.Count; i++)
			{
				long value = double.ConvertToInteger<long>(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x001014AC File Offset: 0x000FF6AC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<long> ConvertToInt64Native(Vector64<double> vector)
		{
			Vector64<long> result;
			Unsafe.SkipInit<Vector64<long>>(out result);
			for (int i = 0; i < Vector64<long>.Count; i++)
			{
				long value = double.ConvertToIntegerNative<long>(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x001014E8 File Offset: 0x000FF6E8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> ConvertToSingle(Vector64<int> vector)
		{
			Vector64<float> result;
			Unsafe.SkipInit<Vector64<float>>(out result);
			for (int i = 0; i < Vector64<float>.Count; i++)
			{
				float value = (float)vector.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x00101520 File Offset: 0x000FF720
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> ConvertToSingle(Vector64<uint> vector)
		{
			Vector64<float> result;
			Unsafe.SkipInit<Vector64<float>>(out result);
			for (int i = 0; i < Vector64<float>.Count; i++)
			{
				float value = vector.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EF4 RID: 20212 RVA: 0x0010155C File Offset: 0x000FF75C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<uint> ConvertToUInt32(Vector64<float> vector)
		{
			Vector64<uint> result;
			Unsafe.SkipInit<Vector64<uint>>(out result);
			for (int i = 0; i < Vector64<uint>.Count; i++)
			{
				uint value = float.ConvertToInteger<uint>(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EF5 RID: 20213 RVA: 0x00101598 File Offset: 0x000FF798
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<uint> ConvertToUInt32Native(Vector64<float> vector)
		{
			Vector64<uint> result;
			Unsafe.SkipInit<Vector64<uint>>(out result);
			for (int i = 0; i < Vector64<uint>.Count; i++)
			{
				uint value = float.ConvertToIntegerNative<uint>(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x001015D4 File Offset: 0x000FF7D4
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<ulong> ConvertToUInt64(Vector64<double> vector)
		{
			Vector64<ulong> result;
			Unsafe.SkipInit<Vector64<ulong>>(out result);
			for (int i = 0; i < Vector64<ulong>.Count; i++)
			{
				ulong value = double.ConvertToInteger<ulong>(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EF7 RID: 20215 RVA: 0x00101610 File Offset: 0x000FF810
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<ulong> ConvertToUInt64Native(Vector64<double> vector)
		{
			Vector64<ulong> result;
			Unsafe.SkipInit<Vector64<ulong>>(out result);
			for (int i = 0; i < Vector64<ulong>.Count; i++)
			{
				ulong value = double.ConvertToIntegerNative<ulong>(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EF8 RID: 20216 RVA: 0x0010164C File Offset: 0x000FF84C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> CopySign<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> sign)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return value;
			}
			if (false)
			{
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value2 = Scalar<T>.CopySign(value.GetElementUnsafe(i), sign.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06004EF9 RID: 20217 RVA: 0x0010171C File Offset: 0x000FF91C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector, T[] destination)
		{
			if (destination.Length < Vector64<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<T, byte>(ref destination[0]), vector);
		}

		// Token: 0x06004EFA RID: 20218 RVA: 0x0010173F File Offset: 0x000FF93F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector, T[] destination, int startIndex)
		{
			if (startIndex >= destination.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
			}
			if (destination.Length - startIndex < Vector64<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<T, byte>(ref destination[startIndex]), vector);
		}

		// Token: 0x06004EFB RID: 20219 RVA: 0x0010176F File Offset: 0x000FF96F
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (destination.Length < Vector64<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(destination)), vector);
		}

		// Token: 0x06004EFC RID: 20220 RVA: 0x00101798 File Offset: 0x000FF998
		internal static Vector64<T> Cos<T>(Vector64<T> vector) where T : ITrigonometricFunctions<T>
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = ITrigonometricFunctions<T>.Cos(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x001017DA File Offset: 0x000FF9DA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> Cos(Vector64<double> vector)
		{
			if (false)
			{
			}
			return Vector64.Cos<double>(vector);
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x001017E5 File Offset: 0x000FF9E5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> Cos(Vector64<float> vector)
		{
			if (false)
			{
			}
			return Vector64.Cos<float>(vector);
		}

		// Token: 0x06004EFF RID: 20223 RVA: 0x001017F0 File Offset: 0x000FF9F0
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Create<[Nullable(2)] T>(T value)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x0010181E File Offset: 0x000FFA1E
		[Intrinsic]
		public static Vector64<byte> Create(byte value)
		{
			return Vector64.Create<byte>(value);
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x00101826 File Offset: 0x000FFA26
		[Intrinsic]
		public static Vector64<double> Create(double value)
		{
			return Vector64.Create<double>(value);
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x0010182E File Offset: 0x000FFA2E
		[Intrinsic]
		public static Vector64<short> Create(short value)
		{
			return Vector64.Create<short>(value);
		}

		// Token: 0x06004F03 RID: 20227 RVA: 0x00101836 File Offset: 0x000FFA36
		[Intrinsic]
		public static Vector64<int> Create(int value)
		{
			return Vector64.Create<int>(value);
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x0010183E File Offset: 0x000FFA3E
		[Intrinsic]
		public static Vector64<long> Create(long value)
		{
			return Vector64.Create<long>(value);
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x00101846 File Offset: 0x000FFA46
		[Intrinsic]
		public static Vector64<IntPtr> Create(IntPtr value)
		{
			return Vector64.Create<IntPtr>(value);
		}

		// Token: 0x06004F06 RID: 20230 RVA: 0x0010184E File Offset: 0x000FFA4E
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<UIntPtr> Create(UIntPtr value)
		{
			return Vector64.Create<UIntPtr>(value);
		}

		// Token: 0x06004F07 RID: 20231 RVA: 0x00101856 File Offset: 0x000FFA56
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<sbyte> Create(sbyte value)
		{
			return Vector64.Create<sbyte>(value);
		}

		// Token: 0x06004F08 RID: 20232 RVA: 0x0010185E File Offset: 0x000FFA5E
		[Intrinsic]
		public static Vector64<float> Create(float value)
		{
			return Vector64.Create<float>(value);
		}

		// Token: 0x06004F09 RID: 20233 RVA: 0x00101866 File Offset: 0x000FFA66
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ushort> Create(ushort value)
		{
			return Vector64.Create<ushort>(value);
		}

		// Token: 0x06004F0A RID: 20234 RVA: 0x0010186E File Offset: 0x000FFA6E
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<uint> Create(uint value)
		{
			return Vector64.Create<uint>(value);
		}

		// Token: 0x06004F0B RID: 20235 RVA: 0x00101876 File Offset: 0x000FFA76
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ulong> Create(ulong value)
		{
			return Vector64.Create<ulong>(value);
		}

		// Token: 0x06004F0C RID: 20236 RVA: 0x0010187E File Offset: 0x000FFA7E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Create<[Nullable(2)] T>(T[] values)
		{
			if (values.Length < Vector64<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return Unsafe.ReadUnaligned<Vector64<T>>(Unsafe.As<T, byte>(ref values[0]));
		}

		// Token: 0x06004F0D RID: 20237 RVA: 0x001018A0 File Offset: 0x000FFAA0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Create<[Nullable(2)] T>(T[] values, int index)
		{
			if (index < 0 || values.Length - index < Vector64<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return Unsafe.ReadUnaligned<Vector64<T>>(Unsafe.As<T, byte>(ref values[index]));
		}

		// Token: 0x06004F0E RID: 20238 RVA: 0x001018C8 File Offset: 0x000FFAC8
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values)
		{
			if (values.Length < Vector64<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.values);
			}
			return Unsafe.ReadUnaligned<Vector64<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(values)));
		}

		// Token: 0x06004F0F RID: 20239 RVA: 0x001018F0 File Offset: 0x000FFAF0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<byte> Create(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7)
		{
			Vector64<byte> result;
			Unsafe.SkipInit<Vector64<byte>>(out result);
			result.SetElementUnsafe(0, e0);
			result.SetElementUnsafe(1, e1);
			result.SetElementUnsafe(2, e2);
			result.SetElementUnsafe(3, e3);
			result.SetElementUnsafe(4, e4);
			result.SetElementUnsafe(5, e5);
			result.SetElementUnsafe(6, e6);
			result.SetElementUnsafe(7, e7);
			return result;
		}

		// Token: 0x06004F10 RID: 20240 RVA: 0x00101954 File Offset: 0x000FFB54
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<short> Create(short e0, short e1, short e2, short e3)
		{
			Vector64<short> result;
			Unsafe.SkipInit<Vector64<short>>(out result);
			result.SetElementUnsafe(0, e0);
			result.SetElementUnsafe(1, e1);
			result.SetElementUnsafe(2, e2);
			result.SetElementUnsafe(3, e3);
			return result;
		}

		// Token: 0x06004F11 RID: 20241 RVA: 0x00101990 File Offset: 0x000FFB90
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<int> Create(int e0, int e1)
		{
			Vector64<int> result;
			Unsafe.SkipInit<Vector64<int>>(out result);
			result.SetElementUnsafe(0, e0);
			result.SetElementUnsafe(1, e1);
			return result;
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x001019B8 File Offset: 0x000FFBB8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<sbyte> Create(sbyte e0, sbyte e1, sbyte e2, sbyte e3, sbyte e4, sbyte e5, sbyte e6, sbyte e7)
		{
			Vector64<sbyte> result;
			Unsafe.SkipInit<Vector64<sbyte>>(out result);
			result.SetElementUnsafe(0, e0);
			result.SetElementUnsafe(1, e1);
			result.SetElementUnsafe(2, e2);
			result.SetElementUnsafe(3, e3);
			result.SetElementUnsafe(4, e4);
			result.SetElementUnsafe(5, e5);
			result.SetElementUnsafe(6, e6);
			result.SetElementUnsafe(7, e7);
			return result;
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x00101A1C File Offset: 0x000FFC1C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> Create(float e0, float e1)
		{
			Vector64<float> result;
			Unsafe.SkipInit<Vector64<float>>(out result);
			result.SetElementUnsafe(0, e0);
			result.SetElementUnsafe(1, e1);
			return result;
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x00101A44 File Offset: 0x000FFC44
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<ushort> Create(ushort e0, ushort e1, ushort e2, ushort e3)
		{
			Vector64<ushort> result;
			Unsafe.SkipInit<Vector64<ushort>>(out result);
			result.SetElementUnsafe(0, e0);
			result.SetElementUnsafe(1, e1);
			result.SetElementUnsafe(2, e2);
			result.SetElementUnsafe(3, e3);
			return result;
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x00101A80 File Offset: 0x000FFC80
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<uint> Create(uint e0, uint e1)
		{
			Vector64<uint> result;
			Unsafe.SkipInit<Vector64<uint>>(out result);
			result.SetElementUnsafe(0, e0);
			result.SetElementUnsafe(1, e1);
			return result;
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x00101AA8 File Offset: 0x000FFCA8
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> CreateScalar<[Nullable(2)] T>(T value)
		{
			Vector64<T> zero = Vector64<T>.Zero;
			zero.SetElementUnsafe(0, value);
			return zero;
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x00101AC5 File Offset: 0x000FFCC5
		[Intrinsic]
		public static Vector64<byte> CreateScalar(byte value)
		{
			return Vector64.CreateScalar<byte>(value);
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x00101ACD File Offset: 0x000FFCCD
		[Intrinsic]
		public static Vector64<double> CreateScalar(double value)
		{
			return Vector64.CreateScalar<double>(value);
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x00101AD5 File Offset: 0x000FFCD5
		[Intrinsic]
		public static Vector64<short> CreateScalar(short value)
		{
			return Vector64.CreateScalar<short>(value);
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x00101ADD File Offset: 0x000FFCDD
		[Intrinsic]
		public static Vector64<int> CreateScalar(int value)
		{
			return Vector64.CreateScalar<int>(value);
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x00101AE5 File Offset: 0x000FFCE5
		[Intrinsic]
		public static Vector64<long> CreateScalar(long value)
		{
			return Vector64.CreateScalar<long>(value);
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x00101AED File Offset: 0x000FFCED
		[Intrinsic]
		public static Vector64<IntPtr> CreateScalar(IntPtr value)
		{
			return Vector64.CreateScalar<IntPtr>(value);
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x00101AF5 File Offset: 0x000FFCF5
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<UIntPtr> CreateScalar(UIntPtr value)
		{
			return Vector64.CreateScalar<UIntPtr>(value);
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x00101AFD File Offset: 0x000FFCFD
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<sbyte> CreateScalar(sbyte value)
		{
			return Vector64.CreateScalar<sbyte>(value);
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x00101B05 File Offset: 0x000FFD05
		[Intrinsic]
		public static Vector64<float> CreateScalar(float value)
		{
			return Vector64.CreateScalar<float>(value);
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x00101B0D File Offset: 0x000FFD0D
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ushort> CreateScalar(ushort value)
		{
			return Vector64.CreateScalar<ushort>(value);
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x00101B15 File Offset: 0x000FFD15
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<uint> CreateScalar(uint value)
		{
			return Vector64.CreateScalar<uint>(value);
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x00101B1D File Offset: 0x000FFD1D
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ulong> CreateScalar(ulong value)
		{
			return Vector64.CreateScalar<ulong>(value);
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x00101B28 File Offset: 0x000FFD28
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> CreateScalarUnsafe<[Nullable(2)] T>(T value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			result.SetElementUnsafe(0, value);
			return result;
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x00101B4B File Offset: 0x000FFD4B
		[Intrinsic]
		public static Vector64<byte> CreateScalarUnsafe(byte value)
		{
			return Vector64.CreateScalarUnsafe<byte>(value);
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x00101B53 File Offset: 0x000FFD53
		[Intrinsic]
		public static Vector64<double> CreateScalarUnsafe(double value)
		{
			return Vector64.CreateScalarUnsafe<double>(value);
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x00101B5B File Offset: 0x000FFD5B
		[Intrinsic]
		public static Vector64<short> CreateScalarUnsafe(short value)
		{
			return Vector64.CreateScalarUnsafe<short>(value);
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x00101B63 File Offset: 0x000FFD63
		[Intrinsic]
		public static Vector64<int> CreateScalarUnsafe(int value)
		{
			return Vector64.CreateScalarUnsafe<int>(value);
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x00101B6B File Offset: 0x000FFD6B
		[Intrinsic]
		public static Vector64<long> CreateScalarUnsafe(long value)
		{
			return Vector64.CreateScalarUnsafe<long>(value);
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x00101B73 File Offset: 0x000FFD73
		[Intrinsic]
		public static Vector64<IntPtr> CreateScalarUnsafe(IntPtr value)
		{
			return Vector64.CreateScalarUnsafe<IntPtr>(value);
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x00101B7B File Offset: 0x000FFD7B
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<UIntPtr> CreateScalarUnsafe(UIntPtr value)
		{
			return Vector64.CreateScalarUnsafe<UIntPtr>(value);
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x00101B83 File Offset: 0x000FFD83
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<sbyte> CreateScalarUnsafe(sbyte value)
		{
			return Vector64.CreateScalarUnsafe<sbyte>(value);
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x00101B8B File Offset: 0x000FFD8B
		[Intrinsic]
		public static Vector64<float> CreateScalarUnsafe(float value)
		{
			return Vector64.CreateScalarUnsafe<float>(value);
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x00101B93 File Offset: 0x000FFD93
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ushort> CreateScalarUnsafe(ushort value)
		{
			return Vector64.CreateScalarUnsafe<ushort>(value);
		}

		// Token: 0x06004F2E RID: 20270 RVA: 0x00101B9B File Offset: 0x000FFD9B
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<uint> CreateScalarUnsafe(uint value)
		{
			return Vector64.CreateScalarUnsafe<uint>(value);
		}

		// Token: 0x06004F2F RID: 20271 RVA: 0x00101BA3 File Offset: 0x000FFDA3
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ulong> CreateScalarUnsafe(ulong value)
		{
			return Vector64.CreateScalarUnsafe<ulong>(value);
		}

		// Token: 0x06004F30 RID: 20272 RVA: 0x00101BAB File Offset: 0x000FFDAB
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> CreateSequence<[Nullable(2)] T>(T start, T step)
		{
			return Vector64<T>.Indices * step + Vector64.Create<T>(start);
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x00101BC4 File Offset: 0x000FFDC4
		internal static Vector64<T> DegreesToRadians<T>(Vector64<T> degrees) where T : ITrigonometricFunctions<T>
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = ITrigonometricFunctions<T>.DegreesToRadians(degrees.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x00101C06 File Offset: 0x000FFE06
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> DegreesToRadians(Vector64<double> degrees)
		{
			if (false)
			{
			}
			return Vector64.DegreesToRadians<double>(degrees);
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x00101C11 File Offset: 0x000FFE11
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> DegreesToRadians(Vector64<float> degrees)
		{
			if (false)
			{
			}
			return Vector64.DegreesToRadians<float>(degrees);
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x00101C1C File Offset: 0x000FFE1C
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Divide<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return left / right;
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x00101C25 File Offset: 0x000FFE25
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Divide<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, T right)
		{
			return left / right;
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x00101C2E File Offset: 0x000FFE2E
		[NullableContext(1)]
		[Intrinsic]
		public static T Dot<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return Vector64.Sum<T>(left * right);
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x00101C3C File Offset: 0x000FFE3C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Equals<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Equals(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? Scalar<T>.AllBitsSet : default(T);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x00101C92 File Offset: 0x000FFE92
		[NullableContext(2)]
		[Intrinsic]
		public static bool EqualsAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return left == right;
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x00101C9C File Offset: 0x000FFE9C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool EqualsAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				if (Scalar<T>.Equals(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x00101CD4 File Offset: 0x000FFED4
		internal static Vector64<T> Exp<T>(Vector64<T> vector) where T : IExponentialFunctions<T>
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = IExponentialFunctions<T>.Exp(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x00101D16 File Offset: 0x000FFF16
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> Exp(Vector64<double> vector)
		{
			if (false)
			{
			}
			return Vector64.Exp<double>(vector);
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x00101D21 File Offset: 0x000FFF21
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> Exp(Vector64<float> vector)
		{
			if (false)
			{
			}
			return Vector64.Exp<float>(vector);
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x00101D2C File Offset: 0x000FFF2C
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ExtractMostSignificantBits<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			uint num = 0U;
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				uint num2 = Scalar<T>.ExtractMostSignificantBit(vector.GetElementUnsafe(i));
				num |= num2 << i;
			}
			return num;
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x00101D64 File Offset: 0x000FFF64
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector64<T> Floor<T>(Vector64<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Floor(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x00101EBF File Offset: 0x001000BF
		[Intrinsic]
		public static Vector64<float> Floor(Vector64<float> vector)
		{
			return Vector64.Floor<float>(vector);
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x00101EC7 File Offset: 0x001000C7
		[Intrinsic]
		public static Vector64<double> Floor(Vector64<double> vector)
		{
			return Vector64.Floor<double>(vector);
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x00101ED0 File Offset: 0x001000D0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> FusedMultiplyAdd(Vector64<double> left, Vector64<double> right, Vector64<double> addend)
		{
			Vector64<double> result;
			Unsafe.SkipInit<Vector64<double>>(out result);
			for (int i = 0; i < Vector64<double>.Count; i++)
			{
				double value = double.FusedMultiplyAdd(left.GetElementUnsafe(i), right.GetElementUnsafe(i), addend.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x00101F1C File Offset: 0x0010011C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> FusedMultiplyAdd(Vector64<float> left, Vector64<float> right, Vector64<float> addend)
		{
			Vector64<float> result;
			Unsafe.SkipInit<Vector64<float>>(out result);
			for (int i = 0; i < Vector64<float>.Count; i++)
			{
				float value = float.FusedMultiplyAdd(left.GetElementUnsafe(i), right.GetElementUnsafe(i), addend.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x00101F68 File Offset: 0x00100168
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetElement<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector, int index)
		{
			if (index >= Vector64<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return vector.GetElementUnsafe(index);
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x00101F84 File Offset: 0x00100184
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> GreaterThan<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.GreaterThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? Scalar<T>.AllBitsSet : default(T);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x00101FDC File Offset: 0x001001DC
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				if (!Scalar<T>.GreaterThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x00102014 File Offset: 0x00100214
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				if (Scalar<T>.GreaterThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x0010204C File Offset: 0x0010024C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> GreaterThanOrEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.GreaterThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? Scalar<T>.AllBitsSet : default(T);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x001020A4 File Offset: 0x001002A4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanOrEqualAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				if (!Scalar<T>.GreaterThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x001020DC File Offset: 0x001002DC
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanOrEqualAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				if (Scalar<T>.GreaterThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x00102114 File Offset: 0x00100314
		internal static Vector64<T> Hypot<T>(Vector64<T> x, Vector64<T> y) where T : IRootFunctions<T>
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = IRootFunctions<T>.Hypot(x.GetElementUnsafe(i), y.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F4B RID: 20299 RVA: 0x0010215E File Offset: 0x0010035E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> Hypot(Vector64<double> x, Vector64<double> y)
		{
			if (false)
			{
			}
			return Vector64.Hypot<double>(x, y);
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x0010216A File Offset: 0x0010036A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> Hypot(Vector64<float> x, Vector64<float> y)
		{
			if (false)
			{
			}
			return Vector64.Hypot<float>(x, y);
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x00102178 File Offset: 0x00100378
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> IsNaN<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				return ~Vector64.Equals<T>(vector, vector);
			}
			return Vector64<T>.Zero;
		}

		// Token: 0x06004F4E RID: 20302 RVA: 0x001021D0 File Offset: 0x001003D0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> IsNegative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return Vector64<T>.Zero;
			}
			if (typeof(T) == typeof(float))
			{
				return Vector64.LessThan<int>(vector.AsInt32<T>(), Vector64<int>.Zero).As<int, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return Vector64.LessThan<long>(vector.AsInt64<T>(), Vector64<long>.Zero).As<long, T>();
			}
			return Vector64.LessThan<T>(vector, Vector64<T>.Zero);
		}

		// Token: 0x06004F4F RID: 20303 RVA: 0x001022D8 File Offset: 0x001004D8
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> IsPositive<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return Vector64<T>.AllBitsSet;
			}
			if (typeof(T) == typeof(float))
			{
				return Vector64.GreaterThanOrEqual<int>(vector.AsInt32<T>(), Vector64<int>.Zero).As<int, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return Vector64.GreaterThanOrEqual<long>(vector.AsInt64<T>(), Vector64<long>.Zero).As<long, T>();
			}
			return Vector64.GreaterThanOrEqual<T>(vector, Vector64<T>.Zero);
		}

		// Token: 0x06004F50 RID: 20304 RVA: 0x001023E0 File Offset: 0x001005E0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> IsPositiveInfinity<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			if (typeof(T) == typeof(float))
			{
				return Vector64.Equals<T>(vector, Vector64.Create(float.PositiveInfinity).As<float, T>());
			}
			if (typeof(T) == typeof(double))
			{
				return Vector64.Equals<T>(vector, Vector64.Create(double.PositiveInfinity).As<double, T>());
			}
			return Vector64<T>.Zero;
		}

		// Token: 0x06004F51 RID: 20305 RVA: 0x00102458 File Offset: 0x00100658
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> IsZero<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			return Vector64.Equals<T>(vector, Vector64<T>.Zero);
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x00102468 File Offset: 0x00100668
		internal static Vector64<T> Lerp<T>(Vector64<T> x, Vector64<T> y, Vector64<T> amount) where T : IFloatingPointIeee754<T>
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = IFloatingPointIeee754<T>.Lerp(x.GetElementUnsafe(i), y.GetElementUnsafe(i), amount.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x001024BA File Offset: 0x001006BA
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> Lerp(Vector64<double> x, Vector64<double> y, Vector64<double> amount)
		{
			if (false)
			{
			}
			return Vector64.Lerp<double>(x, y, amount);
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x001024C7 File Offset: 0x001006C7
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> Lerp(Vector64<float> x, Vector64<float> y, Vector64<float> amount)
		{
			if (false)
			{
			}
			return Vector64.Lerp<float>(x, y, amount);
		}

		// Token: 0x06004F55 RID: 20309 RVA: 0x001024D4 File Offset: 0x001006D4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> LessThan<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.LessThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? Scalar<T>.AllBitsSet : default(T);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x0010252C File Offset: 0x0010072C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				if (!Scalar<T>.LessThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x00102564 File Offset: 0x00100764
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				if (Scalar<T>.LessThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x0010259C File Offset: 0x0010079C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> LessThanOrEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.LessThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? Scalar<T>.AllBitsSet : default(T);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x001025F4 File Offset: 0x001007F4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanOrEqualAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				if (!Scalar<T>.LessThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x0010262C File Offset: 0x0010082C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanOrEqualAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				if (Scalar<T>.LessThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06004F5B RID: 20315 RVA: 0x00102663 File Offset: 0x00100863
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector64<T> Load<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			return Vector64.LoadUnsafe<T>(ref *source);
		}

		// Token: 0x06004F5C RID: 20316 RVA: 0x0010266B File Offset: 0x0010086B
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector64<T> LoadAligned<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			if (source % 8 != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			return *(Vector64<T>*)source;
		}

		// Token: 0x06004F5D RID: 20317 RVA: 0x00102683 File Offset: 0x00100883
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector64<T> LoadAlignedNonTemporal<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			return Vector64.LoadAligned<T>(source);
		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x0010268B File Offset: 0x0010088B
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> LoadUnsafe<[Nullable(2)] T>([RequiresLocation] [In] ref T source)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			return Unsafe.ReadUnaligned<Vector64<T>>(Unsafe.As<T, byte>(Unsafe.AsRef<T>(ref source)));
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x001026A2 File Offset: 0x001008A2
		[NullableContext(1)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> LoadUnsafe<[Nullable(2)] T>([RequiresLocation] [In] ref T source, UIntPtr elementOffset)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			return Unsafe.ReadUnaligned<Vector64<T>>(Unsafe.As<T, byte>(Unsafe.Add<T>(Unsafe.AsRef<T>(ref source), (IntPtr)elementOffset)));
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x001026C0 File Offset: 0x001008C0
		internal static Vector64<T> Log<T>(Vector64<T> vector) where T : ILogarithmicFunctions<T>
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = ILogarithmicFunctions<T>.Log(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F61 RID: 20321 RVA: 0x00102702 File Offset: 0x00100902
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> Log(Vector64<double> vector)
		{
			if (false)
			{
			}
			return Vector64.Log<double>(vector);
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x0010270D File Offset: 0x0010090D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> Log(Vector64<float> vector)
		{
			if (false)
			{
			}
			return Vector64.Log<float>(vector);
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x00102718 File Offset: 0x00100918
		internal static Vector64<T> Log2<T>(Vector64<T> vector) where T : ILogarithmicFunctions<T>
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = ILogarithmicFunctions<T>.Log2(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x0010275A File Offset: 0x0010095A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> Log2(Vector64<double> vector)
		{
			if (false)
			{
			}
			return Vector64.Log2<double>(vector);
		}

		// Token: 0x06004F65 RID: 20325 RVA: 0x00102765 File Offset: 0x00100965
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> Log2(Vector64<float> vector)
		{
			if (false)
			{
			}
			return Vector64.Log2<float>(vector);
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x00102770 File Offset: 0x00100970
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Max<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			if (false)
			{
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Max(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x001027B8 File Offset: 0x001009B8
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> MaxMagnitude<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			if (false)
			{
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.MaxMagnitude(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x00102800 File Offset: 0x00100A00
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> MaxMagnitudeNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			if (false)
			{
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.MaxMagnitudeNumber(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x00102848 File Offset: 0x00100A48
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> MaxNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			if (false)
			{
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.GreaterThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? left.GetElementUnsafe(i) : right.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x001028A4 File Offset: 0x00100AA4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> MaxNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			if (false)
			{
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.MaxNumber(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x001028EC File Offset: 0x00100AEC
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Min<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			if (false)
			{
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Min(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x00102934 File Offset: 0x00100B34
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> MinMagnitude<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			if (false)
			{
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.MinMagnitude(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x0010297C File Offset: 0x00100B7C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> MinMagnitudeNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			if (false)
			{
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.MinMagnitudeNumber(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x001029C4 File Offset: 0x00100BC4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> MinNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			if (false)
			{
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.LessThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? left.GetElementUnsafe(i) : right.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F6F RID: 20335 RVA: 0x00102A20 File Offset: 0x00100C20
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> MinNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			if (false)
			{
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.MinNumber(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F70 RID: 20336 RVA: 0x00102A67 File Offset: 0x00100C67
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Multiply<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return left * right;
		}

		// Token: 0x06004F71 RID: 20337 RVA: 0x00102A70 File Offset: 0x00100C70
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Multiply<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, T right)
		{
			return left * right;
		}

		// Token: 0x06004F72 RID: 20338 RVA: 0x00102A79 File Offset: 0x00100C79
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Multiply<[Nullable(2)] T>(T left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return right * left;
		}

		// Token: 0x06004F73 RID: 20339 RVA: 0x00102A84 File Offset: 0x00100C84
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector64<T> MultiplyAddEstimate<T>(Vector64<T> left, Vector64<T> right, Vector64<T> addend)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.MultiplyAddEstimate(left.GetElementUnsafe(i), right.GetElementUnsafe(i), addend.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F74 RID: 20340 RVA: 0x00102AD0 File Offset: 0x00100CD0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> MultiplyAddEstimate(Vector64<double> left, Vector64<double> right, Vector64<double> addend)
		{
			Vector64<double> result;
			Unsafe.SkipInit<Vector64<double>>(out result);
			for (int i = 0; i < Vector64<double>.Count; i++)
			{
				double value = double.MultiplyAddEstimate(left.GetElementUnsafe(i), right.GetElementUnsafe(i), addend.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F75 RID: 20341 RVA: 0x00102B1C File Offset: 0x00100D1C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> MultiplyAddEstimate(Vector64<float> left, Vector64<float> right, Vector64<float> addend)
		{
			Vector64<float> result;
			Unsafe.SkipInit<Vector64<float>>(out result);
			for (int i = 0; i < Vector64<float>.Count; i++)
			{
				float value = float.MultiplyAddEstimate(left.GetElementUnsafe(i), right.GetElementUnsafe(i), addend.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F76 RID: 20342 RVA: 0x00102B68 File Offset: 0x00100D68
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> Narrow(Vector64<double> lower, Vector64<double> upper)
		{
			Vector64<float> result;
			Unsafe.SkipInit<Vector64<float>>(out result);
			for (int i = 0; i < Vector64<double>.Count; i++)
			{
				float value = (float)lower.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector64<double>.Count; j < Vector64<float>.Count; j++)
			{
				float value2 = (float)upper.GetElementUnsafe(j - Vector64<double>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x00102BD0 File Offset: 0x00100DD0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<sbyte> Narrow(Vector64<short> lower, Vector64<short> upper)
		{
			Vector64<sbyte> result;
			Unsafe.SkipInit<Vector64<sbyte>>(out result);
			for (int i = 0; i < Vector64<short>.Count; i++)
			{
				sbyte value = (sbyte)lower.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector64<short>.Count; j < Vector64<sbyte>.Count; j++)
			{
				sbyte value2 = (sbyte)upper.GetElementUnsafe(j - Vector64<short>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x00102C38 File Offset: 0x00100E38
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<short> Narrow(Vector64<int> lower, Vector64<int> upper)
		{
			Vector64<short> result;
			Unsafe.SkipInit<Vector64<short>>(out result);
			for (int i = 0; i < Vector64<int>.Count; i++)
			{
				short value = (short)lower.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector64<int>.Count; j < Vector64<short>.Count; j++)
			{
				short value2 = (short)upper.GetElementUnsafe(j - Vector64<int>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06004F79 RID: 20345 RVA: 0x00102CA0 File Offset: 0x00100EA0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<int> Narrow(Vector64<long> lower, Vector64<long> upper)
		{
			Vector64<int> result;
			Unsafe.SkipInit<Vector64<int>>(out result);
			for (int i = 0; i < Vector64<long>.Count; i++)
			{
				int value = (int)lower.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector64<long>.Count; j < Vector64<int>.Count; j++)
			{
				int value2 = (int)upper.GetElementUnsafe(j - Vector64<long>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x00102D08 File Offset: 0x00100F08
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<byte> Narrow(Vector64<ushort> lower, Vector64<ushort> upper)
		{
			Vector64<byte> result;
			Unsafe.SkipInit<Vector64<byte>>(out result);
			for (int i = 0; i < Vector64<ushort>.Count; i++)
			{
				byte value = (byte)lower.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector64<ushort>.Count; j < Vector64<byte>.Count; j++)
			{
				byte value2 = (byte)upper.GetElementUnsafe(j - Vector64<ushort>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x00102D70 File Offset: 0x00100F70
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<ushort> Narrow(Vector64<uint> lower, Vector64<uint> upper)
		{
			Vector64<ushort> result;
			Unsafe.SkipInit<Vector64<ushort>>(out result);
			for (int i = 0; i < Vector64<uint>.Count; i++)
			{
				ushort value = (ushort)lower.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector64<uint>.Count; j < Vector64<ushort>.Count; j++)
			{
				ushort value2 = (ushort)upper.GetElementUnsafe(j - Vector64<uint>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x00102DD8 File Offset: 0x00100FD8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<uint> Narrow(Vector64<ulong> lower, Vector64<ulong> upper)
		{
			Vector64<uint> result;
			Unsafe.SkipInit<Vector64<uint>>(out result);
			for (int i = 0; i < Vector64<ulong>.Count; i++)
			{
				uint value = (uint)lower.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector64<ulong>.Count; j < Vector64<uint>.Count; j++)
			{
				uint value2 = (uint)upper.GetElementUnsafe(j - Vector64<ulong>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x00102E3F File Offset: 0x0010103F
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Negate<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			return -vector;
		}

		// Token: 0x06004F7E RID: 20350 RVA: 0x00102E47 File Offset: 0x00101047
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> OnesComplement<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			return ~vector;
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x00102E50 File Offset: 0x00101050
		internal static Vector64<T> RadiansToDegrees<T>(Vector64<T> radians) where T : ITrigonometricFunctions<T>
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = ITrigonometricFunctions<T>.RadiansToDegrees(radians.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x00102E92 File Offset: 0x00101092
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> RadiansToDegrees(Vector64<double> radians)
		{
			if (false)
			{
			}
			return Vector64.RadiansToDegrees<double>(radians);
		}

		// Token: 0x06004F81 RID: 20353 RVA: 0x00102E9D File Offset: 0x0010109D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> RadiansToDegrees(Vector64<float> radians)
		{
			if (false)
			{
			}
			return Vector64.RadiansToDegrees<float>(radians);
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x00102EA8 File Offset: 0x001010A8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector64<T> Round<T>(Vector64<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Round(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x00103003 File Offset: 0x00101203
		[Intrinsic]
		public static Vector64<double> Round(Vector64<double> vector)
		{
			return Vector64.Round<double>(vector);
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x0010300B File Offset: 0x0010120B
		[Intrinsic]
		public static Vector64<float> Round(Vector64<float> vector)
		{
			return Vector64.Round<float>(vector);
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x00103013 File Offset: 0x00101213
		[Intrinsic]
		public static Vector64<double> Round(Vector64<double> vector, MidpointRounding mode)
		{
			return VectorMath.RoundDouble<Vector64<double>>(vector, mode);
		}

		// Token: 0x06004F86 RID: 20358 RVA: 0x0010301C File Offset: 0x0010121C
		[Intrinsic]
		public static Vector64<float> Round(Vector64<float> vector, MidpointRounding mode)
		{
			return VectorMath.RoundSingle<Vector64<float>>(vector, mode);
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x00103025 File Offset: 0x00101225
		[Intrinsic]
		public static Vector64<byte> ShiftLeft(Vector64<byte> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x0010302E File Offset: 0x0010122E
		[Intrinsic]
		public static Vector64<short> ShiftLeft(Vector64<short> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004F89 RID: 20361 RVA: 0x00103037 File Offset: 0x00101237
		[Intrinsic]
		public static Vector64<int> ShiftLeft(Vector64<int> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004F8A RID: 20362 RVA: 0x00103040 File Offset: 0x00101240
		[Intrinsic]
		public static Vector64<long> ShiftLeft(Vector64<long> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004F8B RID: 20363 RVA: 0x00103049 File Offset: 0x00101249
		[Intrinsic]
		public static Vector64<IntPtr> ShiftLeft(Vector64<IntPtr> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004F8C RID: 20364 RVA: 0x00103052 File Offset: 0x00101252
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<UIntPtr> ShiftLeft(Vector64<UIntPtr> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004F8D RID: 20365 RVA: 0x0010305B File Offset: 0x0010125B
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<sbyte> ShiftLeft(Vector64<sbyte> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004F8E RID: 20366 RVA: 0x00103064 File Offset: 0x00101264
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ushort> ShiftLeft(Vector64<ushort> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004F8F RID: 20367 RVA: 0x0010306D File Offset: 0x0010126D
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<uint> ShiftLeft(Vector64<uint> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x00103076 File Offset: 0x00101276
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ulong> ShiftLeft(Vector64<ulong> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x0010307F File Offset: 0x0010127F
		[Intrinsic]
		public static Vector64<short> ShiftRightArithmetic(Vector64<short> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x00103088 File Offset: 0x00101288
		[Intrinsic]
		public static Vector64<int> ShiftRightArithmetic(Vector64<int> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004F93 RID: 20371 RVA: 0x00103091 File Offset: 0x00101291
		[Intrinsic]
		public static Vector64<long> ShiftRightArithmetic(Vector64<long> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004F94 RID: 20372 RVA: 0x0010309A File Offset: 0x0010129A
		[Intrinsic]
		public static Vector64<IntPtr> ShiftRightArithmetic(Vector64<IntPtr> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004F95 RID: 20373 RVA: 0x001030A3 File Offset: 0x001012A3
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<sbyte> ShiftRightArithmetic(Vector64<sbyte> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004F96 RID: 20374 RVA: 0x001030AC File Offset: 0x001012AC
		[Intrinsic]
		public static Vector64<byte> ShiftRightLogical(Vector64<byte> vector, int shiftCount)
		{
			return Vector64<byte>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x001030B5 File Offset: 0x001012B5
		[Intrinsic]
		public static Vector64<short> ShiftRightLogical(Vector64<short> vector, int shiftCount)
		{
			return Vector64<short>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x001030BE File Offset: 0x001012BE
		[Intrinsic]
		public static Vector64<int> ShiftRightLogical(Vector64<int> vector, int shiftCount)
		{
			return Vector64<int>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004F99 RID: 20377 RVA: 0x001030C7 File Offset: 0x001012C7
		[Intrinsic]
		public static Vector64<long> ShiftRightLogical(Vector64<long> vector, int shiftCount)
		{
			return Vector64<long>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x001030D0 File Offset: 0x001012D0
		[Intrinsic]
		public static Vector64<IntPtr> ShiftRightLogical(Vector64<IntPtr> vector, int shiftCount)
		{
			return Vector64<IntPtr>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x001030D9 File Offset: 0x001012D9
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<UIntPtr> ShiftRightLogical(Vector64<UIntPtr> vector, int shiftCount)
		{
			return Vector64<UIntPtr>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x001030E2 File Offset: 0x001012E2
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<sbyte> ShiftRightLogical(Vector64<sbyte> vector, int shiftCount)
		{
			return Vector64<sbyte>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x001030EB File Offset: 0x001012EB
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ushort> ShiftRightLogical(Vector64<ushort> vector, int shiftCount)
		{
			return Vector64<ushort>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x001030F4 File Offset: 0x001012F4
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<uint> ShiftRightLogical(Vector64<uint> vector, int shiftCount)
		{
			return Vector64<uint>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x001030FD File Offset: 0x001012FD
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ulong> ShiftRightLogical(Vector64<ulong> vector, int shiftCount)
		{
			return Vector64<ulong>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x00103108 File Offset: 0x00101308
		[Intrinsic]
		public static Vector64<byte> Shuffle(Vector64<byte> vector, Vector64<byte> indices)
		{
			Vector64<byte> result;
			Unsafe.SkipInit<Vector64<byte>>(out result);
			for (int i = 0; i < Vector64<byte>.Count; i++)
			{
				byte elementUnsafe = indices.GetElementUnsafe(i);
				byte value = 0;
				if ((int)elementUnsafe < Vector64<byte>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x00103154 File Offset: 0x00101354
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<sbyte> Shuffle(Vector64<sbyte> vector, Vector64<sbyte> indices)
		{
			Vector64<sbyte> result;
			Unsafe.SkipInit<Vector64<sbyte>>(out result);
			for (int i = 0; i < Vector64<sbyte>.Count; i++)
			{
				byte b = (byte)indices.GetElementUnsafe(i);
				sbyte value = 0;
				if ((int)b < Vector64<sbyte>.Count)
				{
					value = vector.GetElementUnsafe((int)b);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x001031A0 File Offset: 0x001013A0
		[Intrinsic]
		public static Vector64<short> Shuffle(Vector64<short> vector, Vector64<short> indices)
		{
			Vector64<short> result;
			Unsafe.SkipInit<Vector64<short>>(out result);
			for (int i = 0; i < Vector64<short>.Count; i++)
			{
				ushort num = (ushort)indices.GetElementUnsafe(i);
				short value = 0;
				if ((int)num < Vector64<short>.Count)
				{
					value = vector.GetElementUnsafe((int)num);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x001031EC File Offset: 0x001013EC
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<ushort> Shuffle(Vector64<ushort> vector, Vector64<ushort> indices)
		{
			Vector64<ushort> result;
			Unsafe.SkipInit<Vector64<ushort>>(out result);
			for (int i = 0; i < Vector64<ushort>.Count; i++)
			{
				ushort elementUnsafe = indices.GetElementUnsafe(i);
				ushort value = 0;
				if ((int)elementUnsafe < Vector64<ushort>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x00103238 File Offset: 0x00101438
		[Intrinsic]
		public static Vector64<int> Shuffle(Vector64<int> vector, Vector64<int> indices)
		{
			Vector64<int> result;
			Unsafe.SkipInit<Vector64<int>>(out result);
			for (int i = 0; i < Vector64<int>.Count; i++)
			{
				uint elementUnsafe = (uint)indices.GetElementUnsafe(i);
				int value = 0;
				if ((ulong)elementUnsafe < (ulong)((long)Vector64<int>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x00103284 File Offset: 0x00101484
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector64<uint> Shuffle(Vector64<uint> vector, Vector64<uint> indices)
		{
			Vector64<uint> result;
			Unsafe.SkipInit<Vector64<uint>>(out result);
			for (int i = 0; i < Vector64<uint>.Count; i++)
			{
				uint elementUnsafe = indices.GetElementUnsafe(i);
				uint value = 0U;
				if ((ulong)elementUnsafe < (ulong)((long)Vector64<uint>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x001032D0 File Offset: 0x001014D0
		[Intrinsic]
		public static Vector64<float> Shuffle(Vector64<float> vector, Vector64<int> indices)
		{
			Vector64<float> result;
			Unsafe.SkipInit<Vector64<float>>(out result);
			for (int i = 0; i < Vector64<float>.Count; i++)
			{
				uint elementUnsafe = (uint)indices.GetElementUnsafe(i);
				float value = 0f;
				if ((ulong)elementUnsafe < (ulong)((long)Vector64<float>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x00103320 File Offset: 0x00101520
		internal static Vector64<T> Sin<T>(Vector64<T> vector) where T : ITrigonometricFunctions<T>
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = ITrigonometricFunctions<T>.Sin(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x00103362 File Offset: 0x00101562
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> Sin(Vector64<double> vector)
		{
			if (false)
			{
			}
			return Vector64.Sin<double>(vector);
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x0010336D File Offset: 0x0010156D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<float> Sin(Vector64<float> vector)
		{
			if (false)
			{
			}
			return Vector64.Sin<float>(vector);
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x00103378 File Offset: 0x00101578
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		internal static ValueTuple<Vector64<T>, Vector64<T>> SinCos<T>(Vector64<T> vector) where T : ITrigonometricFunctions<T>
		{
			Vector64<T> item;
			Unsafe.SkipInit<Vector64<T>>(out item);
			Vector64<T> item2;
			Unsafe.SkipInit<Vector64<T>>(out item2);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				ValueTuple<T, T> valueTuple = ITrigonometricFunctions<T>.SinCos(vector.GetElementUnsafe(i));
				T item3 = valueTuple.Item1;
				T item4 = valueTuple.Item2;
				item.SetElementUnsafe(i, item3);
				item2.SetElementUnsafe(i, item4);
			}
			return new ValueTuple<Vector64<T>, Vector64<T>>(item, item2);
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x001033DE File Offset: 0x001015DE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector64<double>, Vector64<double>> SinCos(Vector64<double> vector)
		{
			if (false)
			{
			}
			return Vector64.SinCos<double>(vector);
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x001033E9 File Offset: 0x001015E9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector64<float>, Vector64<float>> SinCos(Vector64<float> vector)
		{
			if (false)
			{
			}
			return Vector64.SinCos<float>(vector);
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x001033F4 File Offset: 0x001015F4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Sqrt<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Sqrt(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x00103430 File Offset: 0x00101630
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		public unsafe static void Store<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			source.StoreUnsafe(ref *destination);
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x00103439 File Offset: 0x00101639
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void StoreAligned<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			if (destination % 8 != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			*(Vector64<T>*)destination = source;
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x00103452 File Offset: 0x00101652
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		public unsafe static void StoreAlignedNonTemporal<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			source.StoreAligned(destination);
		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x0010345B File Offset: 0x0010165B
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StoreUnsafe<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> source, ref T destination)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<T, byte>(ref destination), source);
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x0010346E File Offset: 0x0010166E
		[NullableContext(1)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StoreUnsafe<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> source, ref T destination, UIntPtr elementOffset)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			destination = Unsafe.Add<T>(ref destination, (IntPtr)elementOffset);
			Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<T, byte>(ref destination), source);
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x0010348A File Offset: 0x0010168A
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Subtract<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return left - right;
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x00103494 File Offset: 0x00101694
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Sum<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			T t = default(T);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				t = Scalar<T>.Add(t, vector.GetElementUnsafe(i));
			}
			return t;
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x001034C9 File Offset: 0x001016C9
		[NullableContext(1)]
		[Intrinsic]
		public static T ToScalar<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			return vector.GetElementUnsafe(0);
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x001034D8 File Offset: 0x001016D8
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> ToVector128<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			Vector128<T> result = default(Vector128<T>);
			result.SetLowerUnsafe(vector);
			return result;
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x001034FC File Offset: 0x001016FC
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> ToVector128Unsafe<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			Vector128<T> result;
			Unsafe.SkipInit<Vector128<T>>(out result);
			result.SetLowerUnsafe(vector);
			return result;
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x00103520 File Offset: 0x00101720
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector64<T> Truncate<T>(Vector64<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Truncate(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x0010367B File Offset: 0x0010187B
		[Intrinsic]
		public static Vector64<double> Truncate(Vector64<double> vector)
		{
			return Vector64.Truncate<double>(vector);
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x00103683 File Offset: 0x00101883
		[Intrinsic]
		public static Vector64<float> Truncate(Vector64<float> vector)
		{
			return Vector64.Truncate<float>(vector);
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x0010368B File Offset: 0x0010188B
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryCopyTo<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (destination.Length < Vector64<T>.Count)
			{
				return false;
			}
			Unsafe.WriteUnaligned<Vector64<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(destination)), vector);
			return true;
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x001036AF File Offset: 0x001018AF
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector64<ushort>, Vector64<ushort>> Widen(Vector64<byte> source)
		{
			return new ValueTuple<Vector64<ushort>, Vector64<ushort>>(Vector64.WidenLower(source), Vector64.WidenUpper(source));
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x001036C2 File Offset: 0x001018C2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector64<int>, Vector64<int>> Widen(Vector64<short> source)
		{
			return new ValueTuple<Vector64<int>, Vector64<int>>(Vector64.WidenLower(source), Vector64.WidenUpper(source));
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x001036D5 File Offset: 0x001018D5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector64<long>, Vector64<long>> Widen(Vector64<int> source)
		{
			return new ValueTuple<Vector64<long>, Vector64<long>>(Vector64.WidenLower(source), Vector64.WidenUpper(source));
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x001036E8 File Offset: 0x001018E8
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector64<short>, Vector64<short>> Widen(Vector64<sbyte> source)
		{
			return new ValueTuple<Vector64<short>, Vector64<short>>(Vector64.WidenLower(source), Vector64.WidenUpper(source));
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x001036FB File Offset: 0x001018FB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector64<double>, Vector64<double>> Widen(Vector64<float> source)
		{
			return new ValueTuple<Vector64<double>, Vector64<double>>(Vector64.WidenLower(source), Vector64.WidenUpper(source));
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x0010370E File Offset: 0x0010190E
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector64<uint>, Vector64<uint>> Widen(Vector64<ushort> source)
		{
			return new ValueTuple<Vector64<uint>, Vector64<uint>>(Vector64.WidenLower(source), Vector64.WidenUpper(source));
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x00103721 File Offset: 0x00101921
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector64<ulong>, Vector64<ulong>> Widen(Vector64<uint> source)
		{
			return new ValueTuple<Vector64<ulong>, Vector64<ulong>>(Vector64.WidenLower(source), Vector64.WidenUpper(source));
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x00103734 File Offset: 0x00101934
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<ushort> WidenLower(Vector64<byte> source)
		{
			Vector64<ushort> result;
			Unsafe.SkipInit<Vector64<ushort>>(out result);
			for (int i = 0; i < Vector64<ushort>.Count; i++)
			{
				ushort elementUnsafe = (ushort)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, elementUnsafe);
			}
			return result;
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x0010376C File Offset: 0x0010196C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<int> WidenLower(Vector64<short> source)
		{
			Vector64<int> result;
			Unsafe.SkipInit<Vector64<int>>(out result);
			for (int i = 0; i < Vector64<int>.Count; i++)
			{
				int elementUnsafe = (int)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, elementUnsafe);
			}
			return result;
		}

		// Token: 0x06004FC5 RID: 20421 RVA: 0x001037A4 File Offset: 0x001019A4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<long> WidenLower(Vector64<int> source)
		{
			Vector64<long> result;
			Unsafe.SkipInit<Vector64<long>>(out result);
			for (int i = 0; i < Vector64<long>.Count; i++)
			{
				long value = (long)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FC6 RID: 20422 RVA: 0x001037DC File Offset: 0x001019DC
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<short> WidenLower(Vector64<sbyte> source)
		{
			Vector64<short> result;
			Unsafe.SkipInit<Vector64<short>>(out result);
			for (int i = 0; i < Vector64<short>.Count; i++)
			{
				short elementUnsafe = (short)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, elementUnsafe);
			}
			return result;
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x00103814 File Offset: 0x00101A14
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> WidenLower(Vector64<float> source)
		{
			Vector64<double> result;
			Unsafe.SkipInit<Vector64<double>>(out result);
			for (int i = 0; i < Vector64<double>.Count; i++)
			{
				double value = (double)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x0010384C File Offset: 0x00101A4C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<uint> WidenLower(Vector64<ushort> source)
		{
			Vector64<uint> result;
			Unsafe.SkipInit<Vector64<uint>>(out result);
			for (int i = 0; i < Vector64<uint>.Count; i++)
			{
				uint elementUnsafe = (uint)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, elementUnsafe);
			}
			return result;
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x00103884 File Offset: 0x00101A84
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<ulong> WidenLower(Vector64<uint> source)
		{
			Vector64<ulong> result;
			Unsafe.SkipInit<Vector64<ulong>>(out result);
			for (int i = 0; i < Vector64<ulong>.Count; i++)
			{
				ulong value = (ulong)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x001038BC File Offset: 0x00101ABC
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<ushort> WidenUpper(Vector64<byte> source)
		{
			Vector64<ushort> result;
			Unsafe.SkipInit<Vector64<ushort>>(out result);
			for (int i = Vector64<ushort>.Count; i < Vector64<byte>.Count; i++)
			{
				ushort elementUnsafe = (ushort)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector64<ushort>.Count, elementUnsafe);
			}
			return result;
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x00103900 File Offset: 0x00101B00
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<int> WidenUpper(Vector64<short> source)
		{
			Vector64<int> result;
			Unsafe.SkipInit<Vector64<int>>(out result);
			for (int i = Vector64<int>.Count; i < Vector64<short>.Count; i++)
			{
				int elementUnsafe = (int)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector64<int>.Count, elementUnsafe);
			}
			return result;
		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x00103944 File Offset: 0x00101B44
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<long> WidenUpper(Vector64<int> source)
		{
			Vector64<long> result;
			Unsafe.SkipInit<Vector64<long>>(out result);
			for (int i = Vector64<long>.Count; i < Vector64<int>.Count; i++)
			{
				long value = (long)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector64<long>.Count, value);
			}
			return result;
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x00103988 File Offset: 0x00101B88
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<short> WidenUpper(Vector64<sbyte> source)
		{
			Vector64<short> result;
			Unsafe.SkipInit<Vector64<short>>(out result);
			for (int i = Vector64<short>.Count; i < Vector64<sbyte>.Count; i++)
			{
				short elementUnsafe = (short)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector64<short>.Count, elementUnsafe);
			}
			return result;
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x001039CC File Offset: 0x00101BCC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<double> WidenUpper(Vector64<float> source)
		{
			Vector64<double> result;
			Unsafe.SkipInit<Vector64<double>>(out result);
			for (int i = Vector64<double>.Count; i < Vector64<float>.Count; i++)
			{
				double value = (double)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector64<double>.Count, value);
			}
			return result;
		}

		// Token: 0x06004FCF RID: 20431 RVA: 0x00103A10 File Offset: 0x00101C10
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<uint> WidenUpper(Vector64<ushort> source)
		{
			Vector64<uint> result;
			Unsafe.SkipInit<Vector64<uint>>(out result);
			for (int i = Vector64<uint>.Count; i < Vector64<ushort>.Count; i++)
			{
				uint elementUnsafe = (uint)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector64<uint>.Count, elementUnsafe);
			}
			return result;
		}

		// Token: 0x06004FD0 RID: 20432 RVA: 0x00103A54 File Offset: 0x00101C54
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector64<ulong> WidenUpper(Vector64<uint> source)
		{
			Vector64<ulong> result;
			Unsafe.SkipInit<Vector64<ulong>>(out result);
			for (int i = Vector64<ulong>.Count; i < Vector64<uint>.Count; i++)
			{
				ulong value = (ulong)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector64<ulong>.Count, value);
			}
			return result;
		}

		// Token: 0x06004FD1 RID: 20433 RVA: 0x00103A98 File Offset: 0x00101C98
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> WithElement<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector64<T> vector, int index, T value)
		{
			if (index >= Vector64<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			Vector64<T> result = vector;
			result.SetElementUnsafe(index, value);
			return result;
		}

		// Token: 0x06004FD2 RID: 20434 RVA: 0x00103AC0 File Offset: 0x00101CC0
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Xor<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return left ^ right;
		}

		// Token: 0x06004FD3 RID: 20435 RVA: 0x00103AC9 File Offset: 0x00101CC9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static T GetElementUnsafe<T>(this Vector64<T> vector, int index)
		{
			return *Unsafe.Add<T>(Unsafe.As<Vector64<T>, T>(Unsafe.AsRef<Vector64<T>>(ref vector)), index);
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x00103AE1 File Offset: 0x00101CE1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void SetElementUnsafe<T>(this Vector64<T> vector, int index, T value)
		{
			*Unsafe.Add<T>(Unsafe.As<Vector64<T>, T>(Unsafe.AsRef<Vector64<T>>(ref vector)), index) = value;
		}
	}
}
