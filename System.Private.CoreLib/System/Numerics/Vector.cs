using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Numerics
{
	// Token: 0x02000294 RID: 660
	[Intrinsic]
	public static class Vector
	{
		// Token: 0x06002FE6 RID: 12262 RVA: 0x0009CDA4 File Offset: 0x0009AFA4
		[Intrinsic]
		public unsafe static Vector4 AsVector4(this Plane value)
		{
			return *Unsafe.As<Plane, Vector4>(ref value);
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x0009CDB2 File Offset: 0x0009AFB2
		[Intrinsic]
		public unsafe static Vector4 AsVector4(this Quaternion value)
		{
			return *Unsafe.As<Quaternion, Vector4>(ref value);
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x0009CDC0 File Offset: 0x0009AFC0
		internal static int Alignment
		{
			get
			{
				return sizeof(Vector<byte>);
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002FE9 RID: 12265 RVA: 0x0009CDC8 File Offset: 0x0009AFC8
		public static bool IsHardwareAccelerated
		{
			[Intrinsic]
			get
			{
				return Vector.IsHardwareAccelerated;
			}
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x0009CDD0 File Offset: 0x0009AFD0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Abs<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return value;
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value2 = Scalar<T>.Abs(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x0009CE95 File Offset: 0x0009B095
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Add<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return left + right;
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x0009CE9E File Offset: 0x0009B09E
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> AndNot<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return left & ~right;
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x0009CEAC File Offset: 0x0009B0AC
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector<TTo> As<TFrom, TTo>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<TFrom> vector)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<TFrom>();
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<TTo>();
			return *Unsafe.As<Vector<TFrom>, Vector<TTo>>(ref vector);
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x0009CEC4 File Offset: 0x0009B0C4
		[Intrinsic]
		public static Vector<byte> AsVectorByte<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, byte>();
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x0009CECC File Offset: 0x0009B0CC
		[Intrinsic]
		public static Vector<double> AsVectorDouble<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, double>();
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x0009CED4 File Offset: 0x0009B0D4
		[Intrinsic]
		public static Vector<short> AsVectorInt16<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, short>();
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x0009CEDC File Offset: 0x0009B0DC
		[Intrinsic]
		public static Vector<int> AsVectorInt32<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, int>();
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x0009CEE4 File Offset: 0x0009B0E4
		[Intrinsic]
		public static Vector<long> AsVectorInt64<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, long>();
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x0009CEEC File Offset: 0x0009B0EC
		[Intrinsic]
		public static Vector<IntPtr> AsVectorNInt<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, IntPtr>();
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x0009CEF4 File Offset: 0x0009B0F4
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<UIntPtr> AsVectorNUInt<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, UIntPtr>();
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x0009CEFC File Offset: 0x0009B0FC
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<sbyte> AsVectorSByte<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, sbyte>();
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x0009CF04 File Offset: 0x0009B104
		[Intrinsic]
		public static Vector<float> AsVectorSingle<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, float>();
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x0009CF0C File Offset: 0x0009B10C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<ushort> AsVectorUInt16<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, ushort>();
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x0009CF14 File Offset: 0x0009B114
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<uint> AsVectorUInt32<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, uint>();
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x0009CF1C File Offset: 0x0009B11C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<ulong> AsVectorUInt64<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, ulong>();
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x0009CF24 File Offset: 0x0009B124
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> BitwiseAnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return left & right;
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x0009CF2D File Offset: 0x0009B12D
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> BitwiseOr<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return left | right;
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x0009CF38 File Offset: 0x0009B138
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector<T> Ceiling<T>(Vector<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Ceiling(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x0009D094 File Offset: 0x0009B294
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> Ceiling(Vector<double> value)
		{
			Vector<double> result;
			Unsafe.SkipInit<Vector<double>>(out result);
			for (int i = 0; i < Vector<double>.Count; i++)
			{
				double value2 = Scalar<double>.Ceiling(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x0009D0D0 File Offset: 0x0009B2D0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> Ceiling(Vector<float> value)
		{
			Vector<float> result;
			Unsafe.SkipInit<Vector<float>>(out result);
			for (int i = 0; i < Vector<float>.Count; i++)
			{
				float value2 = Scalar<float>.Ceiling(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x0009D10C File Offset: 0x0009B30C
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Clamp<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> min, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> max)
		{
			return Vector.Min<T>(Vector.Max<T>(value, min), max);
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x0009D11B File Offset: 0x0009B31B
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> ClampNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> min, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> max)
		{
			return Vector.MinNative<T>(Vector.MaxNative<T>(value, min), max);
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x0009D12A File Offset: 0x0009B32A
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> ConditionalSelect<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> condition, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return (left & condition) | Vector.AndNot<T>(right, condition);
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x0009D13F File Offset: 0x0009B33F
		[Intrinsic]
		public static Vector<float> ConditionalSelect(Vector<int> condition, Vector<float> left, Vector<float> right)
		{
			return Vector.ConditionalSelect<float>(condition.As<int, float>(), left, right);
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x0009D14E File Offset: 0x0009B34E
		[Intrinsic]
		public static Vector<double> ConditionalSelect(Vector<long> condition, Vector<double> left, Vector<double> right)
		{
			return Vector.ConditionalSelect<double>(condition.As<long, double>(), left, right);
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x0009D15D File Offset: 0x0009B35D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> ConvertToDouble(Vector<long> value)
		{
			if (false)
			{
			}
			return Vector128.ConvertToDouble(value.AsVector128<long>()).AsVector<double>();
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x0009D172 File Offset: 0x0009B372
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> ConvertToDouble(Vector<ulong> value)
		{
			if (false)
			{
			}
			return Vector128.ConvertToDouble(value.AsVector128<ulong>()).AsVector<double>();
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x0009D188 File Offset: 0x0009B388
		[Intrinsic]
		public static Vector<int> ConvertToInt32(Vector<float> value)
		{
			Vector<int> result;
			Unsafe.SkipInit<Vector<int>>(out result);
			for (int i = 0; i < Vector<int>.Count; i++)
			{
				int value2 = float.ConvertToInteger<int>(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x0009D1C4 File Offset: 0x0009B3C4
		[Intrinsic]
		public static Vector<int> ConvertToInt32Native(Vector<float> value)
		{
			Vector<int> result;
			Unsafe.SkipInit<Vector<int>>(out result);
			for (int i = 0; i < Vector<int>.Count; i++)
			{
				int value2 = float.ConvertToIntegerNative<int>(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x0009D200 File Offset: 0x0009B400
		[Intrinsic]
		public static Vector<long> ConvertToInt64(Vector<double> value)
		{
			Vector<long> result;
			Unsafe.SkipInit<Vector<long>>(out result);
			for (int i = 0; i < Vector<long>.Count; i++)
			{
				long value2 = double.ConvertToInteger<long>(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x0009D23C File Offset: 0x0009B43C
		[Intrinsic]
		public static Vector<long> ConvertToInt64Native(Vector<double> value)
		{
			Vector<long> result;
			Unsafe.SkipInit<Vector<long>>(out result);
			for (int i = 0; i < Vector<long>.Count; i++)
			{
				long value2 = double.ConvertToIntegerNative<long>(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x0009D278 File Offset: 0x0009B478
		[Intrinsic]
		public static Vector<float> ConvertToSingle(Vector<int> value)
		{
			Vector<float> result;
			Unsafe.SkipInit<Vector<float>>(out result);
			for (int i = 0; i < Vector<float>.Count; i++)
			{
				float value2 = (float)value.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x0009D2B0 File Offset: 0x0009B4B0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> ConvertToSingle(Vector<uint> value)
		{
			if (false)
			{
			}
			return Vector128.ConvertToSingle(value.AsVector128<uint>()).AsVector<float>();
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x0009D2C8 File Offset: 0x0009B4C8
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<uint> ConvertToUInt32(Vector<float> value)
		{
			Vector<uint> result;
			Unsafe.SkipInit<Vector<uint>>(out result);
			for (int i = 0; i < Vector<uint>.Count; i++)
			{
				uint value2 = float.ConvertToInteger<uint>(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x0009D304 File Offset: 0x0009B504
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<uint> ConvertToUInt32Native(Vector<float> value)
		{
			Vector<uint> result;
			Unsafe.SkipInit<Vector<uint>>(out result);
			for (int i = 0; i < Vector<uint>.Count; i++)
			{
				uint value2 = float.ConvertToIntegerNative<uint>(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x0009D340 File Offset: 0x0009B540
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<ulong> ConvertToUInt64(Vector<double> value)
		{
			Vector<ulong> result;
			Unsafe.SkipInit<Vector<ulong>>(out result);
			for (int i = 0; i < Vector<ulong>.Count; i++)
			{
				ulong value2 = double.ConvertToInteger<ulong>(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x0009D37C File Offset: 0x0009B57C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<ulong> ConvertToUInt64Native(Vector<double> value)
		{
			Vector<ulong> result;
			Unsafe.SkipInit<Vector<ulong>>(out result);
			for (int i = 0; i < Vector<ulong>.Count; i++)
			{
				ulong value2 = double.ConvertToIntegerNative<ulong>(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x0009D3B8 File Offset: 0x0009B5B8
		internal static Vector<T> Cos<T>(Vector<T> vector) where T : ITrigonometricFunctions<T>
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = ITrigonometricFunctions<T>.Cos(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x0009D3FA File Offset: 0x0009B5FA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> Cos(Vector<double> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.CosDouble<Vector<double>, Vector<long>>(vector);
			}
			return Vector.Cos<double>(vector);
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x0009D410 File Offset: 0x0009B610
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> Cos(Vector<float> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.CosSingle<Vector<float>, Vector<int>, Vector<double>, Vector<long>>(vector);
			}
			return Vector.Cos<float>(vector);
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x0009D428 File Offset: 0x0009B628
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> CopySign<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> sign)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return value;
			}
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.CopySign<Vector<T>, T>(value, sign);
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value2 = Scalar<T>.CopySign(value.GetElementUnsafe(i), sign.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x0009D504 File Offset: 0x0009B704
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Create<[Nullable(2)] T>(T value)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x0009D532 File Offset: 0x0009B732
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values)
		{
			if (values.Length < Vector<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.values);
			}
			return Unsafe.ReadUnaligned<Vector<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(values)));
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x0009D558 File Offset: 0x0009B758
		[Intrinsic]
		internal static Vector<T> CreateScalar<T>(T value)
		{
			Vector<T> zero = Vector<T>.Zero;
			zero.SetElementUnsafe(0, value);
			return zero;
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x0009D578 File Offset: 0x0009B778
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector<T> CreateScalarUnsafe<T>(T value)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			result.SetElementUnsafe(0, value);
			return result;
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x0009D59B File Offset: 0x0009B79B
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> CreateSequence<[Nullable(2)] T>(T start, T step)
		{
			return Vector<T>.Indices * step + Vector.Create<T>(start);
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x0009D5B4 File Offset: 0x0009B7B4
		internal static Vector<T> DegreesToRadians<T>(Vector<T> degrees) where T : ITrigonometricFunctions<T>
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = ITrigonometricFunctions<T>.DegreesToRadians(degrees.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x0009D5F6 File Offset: 0x0009B7F6
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> DegreesToRadians(Vector<double> degrees)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.DegreesToRadians<Vector<double>, double>(degrees);
			}
			return Vector.DegreesToRadians<double>(degrees);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x0009D60C File Offset: 0x0009B80C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> DegreesToRadians(Vector<float> degrees)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.DegreesToRadians<Vector<float>, float>(degrees);
			}
			return Vector.DegreesToRadians<float>(degrees);
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x0009D622 File Offset: 0x0009B822
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Divide<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return left / right;
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x0009D62B File Offset: 0x0009B82B
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Divide<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, T right)
		{
			return left / right;
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x0009D634 File Offset: 0x0009B834
		[NullableContext(1)]
		[Intrinsic]
		public static T Dot<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return Vector.Sum<T>(left * right);
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x0009D644 File Offset: 0x0009B844
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Equals<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Equals(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? Scalar<T>.AllBitsSet : default(T);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x0009D69A File Offset: 0x0009B89A
		[Intrinsic]
		public static Vector<long> Equals(Vector<double> left, Vector<double> right)
		{
			return Vector.Equals<double>(left, right).As<double, long>();
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x0009D6A8 File Offset: 0x0009B8A8
		[Intrinsic]
		public static Vector<int> Equals(Vector<int> left, Vector<int> right)
		{
			return Vector.Equals<int>(left, right);
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x0009D6B1 File Offset: 0x0009B8B1
		[Intrinsic]
		public static Vector<long> Equals(Vector<long> left, Vector<long> right)
		{
			return Vector.Equals<long>(left, right);
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x0009D6BA File Offset: 0x0009B8BA
		[Intrinsic]
		public static Vector<int> Equals(Vector<float> left, Vector<float> right)
		{
			return Vector.Equals<float>(left, right).As<float, int>();
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x0009D6C8 File Offset: 0x0009B8C8
		[NullableContext(2)]
		[Intrinsic]
		public static bool EqualsAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return left == right;
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x0009D6D4 File Offset: 0x0009B8D4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool EqualsAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				if (Scalar<T>.Equals(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x0009D70C File Offset: 0x0009B90C
		internal static Vector<T> Exp<T>(Vector<T> vector) where T : IExponentialFunctions<T>
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = IExponentialFunctions<T>.Exp(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x0009D74E File Offset: 0x0009B94E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> Exp(Vector<double> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.ExpDouble<Vector<double>, Vector<ulong>>(vector);
			}
			return Vector.Exp<double>(vector);
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x0009D764 File Offset: 0x0009B964
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> Exp(Vector<float> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.ExpSingle<Vector<float>, Vector<uint>, Vector<double>, Vector<ulong>>(vector);
			}
			return Vector.Exp<float>(vector);
		}

		// Token: 0x06003029 RID: 12329 RVA: 0x0009D77C File Offset: 0x0009B97C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector<T> Floor<T>(Vector<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Floor(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x0009D8D8 File Offset: 0x0009BAD8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> Floor(Vector<double> value)
		{
			Vector<double> result;
			Unsafe.SkipInit<Vector<double>>(out result);
			for (int i = 0; i < Vector<double>.Count; i++)
			{
				double value2 = Scalar<double>.Floor(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x0009D914 File Offset: 0x0009BB14
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> Floor(Vector<float> value)
		{
			Vector<float> result;
			Unsafe.SkipInit<Vector<float>>(out result);
			for (int i = 0; i < Vector<float>.Count; i++)
			{
				float value2 = Scalar<float>.Floor(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x0009D950 File Offset: 0x0009BB50
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> FusedMultiplyAdd(Vector<double> left, Vector<double> right, Vector<double> addend)
		{
			Vector<double> result;
			Unsafe.SkipInit<Vector<double>>(out result);
			for (int i = 0; i < Vector<double>.Count; i++)
			{
				double value = double.FusedMultiplyAdd(left.GetElementUnsafe(i), right.GetElementUnsafe(i), addend.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x0009D99C File Offset: 0x0009BB9C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> FusedMultiplyAdd(Vector<float> left, Vector<float> right, Vector<float> addend)
		{
			Vector<float> result;
			Unsafe.SkipInit<Vector<float>>(out result);
			for (int i = 0; i < Vector<float>.Count; i++)
			{
				float value = float.FusedMultiplyAdd(left.GetElementUnsafe(i), right.GetElementUnsafe(i), addend.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x0009D9E8 File Offset: 0x0009BBE8
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetElement<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<T> vector, int index)
		{
			if (index >= Vector<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return vector.GetElementUnsafe(index);
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x0009DA04 File Offset: 0x0009BC04
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> GreaterThan<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.GreaterThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? Scalar<T>.AllBitsSet : default(T);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x0009DA5A File Offset: 0x0009BC5A
		[Intrinsic]
		public static Vector<long> GreaterThan(Vector<double> left, Vector<double> right)
		{
			return Vector.GreaterThan<double>(left, right).As<double, long>();
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x0009DA68 File Offset: 0x0009BC68
		[Intrinsic]
		public static Vector<int> GreaterThan(Vector<int> left, Vector<int> right)
		{
			return Vector.GreaterThan<int>(left, right);
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x0009DA71 File Offset: 0x0009BC71
		[Intrinsic]
		public static Vector<long> GreaterThan(Vector<long> left, Vector<long> right)
		{
			return Vector.GreaterThan<long>(left, right);
		}

		// Token: 0x06003033 RID: 12339 RVA: 0x0009DA7A File Offset: 0x0009BC7A
		[Intrinsic]
		public static Vector<int> GreaterThan(Vector<float> left, Vector<float> right)
		{
			return Vector.GreaterThan<float>(left, right).As<float, int>();
		}

		// Token: 0x06003034 RID: 12340 RVA: 0x0009DA88 File Offset: 0x0009BC88
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				if (!Scalar<T>.GreaterThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003035 RID: 12341 RVA: 0x0009DAC0 File Offset: 0x0009BCC0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				if (Scalar<T>.GreaterThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x0009DAF8 File Offset: 0x0009BCF8
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> GreaterThanOrEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.GreaterThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? Scalar<T>.AllBitsSet : default(T);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x0009DB4E File Offset: 0x0009BD4E
		[Intrinsic]
		public static Vector<long> GreaterThanOrEqual(Vector<double> left, Vector<double> right)
		{
			return Vector.GreaterThanOrEqual<double>(left, right).As<double, long>();
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x0009DB5C File Offset: 0x0009BD5C
		[Intrinsic]
		public static Vector<int> GreaterThanOrEqual(Vector<int> left, Vector<int> right)
		{
			return Vector.GreaterThanOrEqual<int>(left, right);
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x0009DB65 File Offset: 0x0009BD65
		[Intrinsic]
		public static Vector<long> GreaterThanOrEqual(Vector<long> left, Vector<long> right)
		{
			return Vector.GreaterThanOrEqual<long>(left, right);
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x0009DB6E File Offset: 0x0009BD6E
		[Intrinsic]
		public static Vector<int> GreaterThanOrEqual(Vector<float> left, Vector<float> right)
		{
			return Vector.GreaterThanOrEqual<float>(left, right).As<float, int>();
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x0009DB7C File Offset: 0x0009BD7C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanOrEqualAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				if (!Scalar<T>.GreaterThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x0009DBB4 File Offset: 0x0009BDB4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanOrEqualAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				if (Scalar<T>.GreaterThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x0009DBEC File Offset: 0x0009BDEC
		internal static Vector<T> Hypot<T>(Vector<T> x, Vector<T> y) where T : IRootFunctions<T>
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = IRootFunctions<T>.Hypot(x.GetElementUnsafe(i), y.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x0009DC36 File Offset: 0x0009BE36
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> Hypot(Vector<double> x, Vector<double> y)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.HypotDouble<Vector<double>, Vector<ulong>>(x, y);
			}
			return Vector.Hypot<double>(x, y);
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x0009DC4E File Offset: 0x0009BE4E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> Hypot(Vector<float> x, Vector<float> y)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.HypotSingle<Vector<float>, Vector<double>>(x, y);
			}
			return Vector.Hypot<float>(x, y);
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x0009DC68 File Offset: 0x0009BE68
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> IsNaN<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> vector)
		{
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				return ~Vector.Equals<T>(vector, vector);
			}
			return Vector<T>.Zero;
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x0009DCC0 File Offset: 0x0009BEC0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> IsNegative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return Vector<T>.Zero;
			}
			if (typeof(T) == typeof(float))
			{
				return Vector.LessThan(vector.As<T, int>(), Vector<int>.Zero).As<int, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return Vector.LessThan(vector.As<T, long>(), Vector<long>.Zero).As<long, T>();
			}
			return Vector.LessThan<T>(vector, Vector<T>.Zero);
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x0009DDC8 File Offset: 0x0009BFC8
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> IsPositive<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return Vector<T>.AllBitsSet;
			}
			if (typeof(T) == typeof(float))
			{
				return Vector.GreaterThanOrEqual(vector.As<T, int>(), Vector<int>.Zero).As<int, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return Vector.GreaterThanOrEqual(vector.As<T, long>(), Vector<long>.Zero).As<long, T>();
			}
			return Vector.GreaterThanOrEqual<T>(vector, Vector<T>.Zero);
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x0009DED0 File Offset: 0x0009C0D0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> IsPositiveInfinity<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> vector)
		{
			if (typeof(T) == typeof(float))
			{
				return Vector.Equals<T>(vector, Vector.Create<float>(float.PositiveInfinity).As<float, T>());
			}
			if (typeof(T) == typeof(double))
			{
				return Vector.Equals<T>(vector, Vector.Create<double>(double.PositiveInfinity).As<double, T>());
			}
			return Vector<T>.Zero;
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x0009DF48 File Offset: 0x0009C148
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> IsZero<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> vector)
		{
			return Vector.Equals<T>(vector, Vector<T>.Zero);
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x0009DF58 File Offset: 0x0009C158
		internal static Vector<T> Lerp<T>(Vector<T> x, Vector<T> y, Vector<T> amount) where T : IFloatingPointIeee754<T>
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = IFloatingPointIeee754<T>.Lerp(x.GetElementUnsafe(i), y.GetElementUnsafe(i), amount.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0009DFAA File Offset: 0x0009C1AA
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> Lerp(Vector<double> x, Vector<double> y, Vector<double> amount)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.Lerp<Vector<double>, double>(x, y, amount);
			}
			return Vector.Lerp<double>(x, y, amount);
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x0009DFC4 File Offset: 0x0009C1C4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> Lerp(Vector<float> x, Vector<float> y, Vector<float> amount)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.Lerp<Vector<float>, float>(x, y, amount);
			}
			return Vector.Lerp<float>(x, y, amount);
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x0009DFE0 File Offset: 0x0009C1E0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> LessThan<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.LessThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? Scalar<T>.AllBitsSet : default(T);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0009E036 File Offset: 0x0009C236
		[Intrinsic]
		public static Vector<long> LessThan(Vector<double> left, Vector<double> right)
		{
			return Vector.LessThan<double>(left, right).As<double, long>();
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x0009E044 File Offset: 0x0009C244
		[Intrinsic]
		public static Vector<int> LessThan(Vector<int> left, Vector<int> right)
		{
			return Vector.LessThan<int>(left, right);
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x0009E04D File Offset: 0x0009C24D
		[Intrinsic]
		public static Vector<long> LessThan(Vector<long> left, Vector<long> right)
		{
			return Vector.LessThan<long>(left, right);
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x0009E056 File Offset: 0x0009C256
		[Intrinsic]
		public static Vector<int> LessThan(Vector<float> left, Vector<float> right)
		{
			return Vector.LessThan<float>(left, right).As<float, int>();
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x0009E064 File Offset: 0x0009C264
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				if (!Scalar<T>.LessThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x0009E09C File Offset: 0x0009C29C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				if (Scalar<T>.LessThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x0009E0D4 File Offset: 0x0009C2D4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> LessThanOrEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.LessThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? Scalar<T>.AllBitsSet : default(T);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x0009E12A File Offset: 0x0009C32A
		[Intrinsic]
		public static Vector<long> LessThanOrEqual(Vector<double> left, Vector<double> right)
		{
			return Vector.LessThanOrEqual<double>(left, right).As<double, long>();
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x0009E138 File Offset: 0x0009C338
		[Intrinsic]
		public static Vector<int> LessThanOrEqual(Vector<int> left, Vector<int> right)
		{
			return Vector.LessThanOrEqual<int>(left, right);
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x0009E141 File Offset: 0x0009C341
		[Intrinsic]
		public static Vector<long> LessThanOrEqual(Vector<long> left, Vector<long> right)
		{
			return Vector.LessThanOrEqual<long>(left, right);
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x0009E14A File Offset: 0x0009C34A
		[Intrinsic]
		public static Vector<int> LessThanOrEqual(Vector<float> left, Vector<float> right)
		{
			return Vector.LessThanOrEqual<float>(left, right).As<float, int>();
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x0009E158 File Offset: 0x0009C358
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanOrEqualAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				if (!Scalar<T>.LessThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x0009E190 File Offset: 0x0009C390
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanOrEqualAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				if (Scalar<T>.LessThanOrEqual(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x0009E1C7 File Offset: 0x0009C3C7
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector<T> Load<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			return Vector.LoadUnsafe<T>(ref *source);
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x0009E1CF File Offset: 0x0009C3CF
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector<T> LoadAligned<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			if (source % Vector.Alignment != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			return *(Vector<T>*)source;
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x0009E1EB File Offset: 0x0009C3EB
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector<T> LoadAlignedNonTemporal<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			return Vector.LoadAligned<T>(source);
		}

		// Token: 0x06003059 RID: 12377 RVA: 0x0009E1F3 File Offset: 0x0009C3F3
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> LoadUnsafe<[Nullable(2)] T>([RequiresLocation] [In] ref T source)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			return Unsafe.ReadUnaligned<Vector<T>>(Unsafe.As<T, byte>(Unsafe.AsRef<T>(ref source)));
		}

		// Token: 0x0600305A RID: 12378 RVA: 0x0009E20A File Offset: 0x0009C40A
		[NullableContext(1)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> LoadUnsafe<[Nullable(2)] T>([RequiresLocation] [In] ref T source, UIntPtr elementOffset)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			return Unsafe.ReadUnaligned<Vector<T>>(Unsafe.As<T, byte>(Unsafe.Add<T>(Unsafe.AsRef<T>(ref source), (IntPtr)elementOffset)));
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x0009E228 File Offset: 0x0009C428
		internal static Vector<T> Log<T>(Vector<T> vector) where T : ILogarithmicFunctions<T>
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = ILogarithmicFunctions<T>.Log(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x0009E26A File Offset: 0x0009C46A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> Log(Vector<double> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.LogDouble<Vector<double>, Vector<long>, Vector<ulong>>(vector);
			}
			return Vector.Log<double>(vector);
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x0009E280 File Offset: 0x0009C480
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> Log(Vector<float> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.LogSingle<Vector<float>, Vector<int>, Vector<uint>>(vector);
			}
			return Vector.Log<float>(vector);
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x0009E298 File Offset: 0x0009C498
		internal static Vector<T> Log2<T>(Vector<T> vector) where T : ILogarithmicFunctions<T>
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = ILogarithmicFunctions<T>.Log2(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x0009E2DA File Offset: 0x0009C4DA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> Log2(Vector<double> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.Log2Double<Vector<double>, Vector<long>, Vector<ulong>>(vector);
			}
			return Vector.Log2<double>(vector);
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x0009E2F0 File Offset: 0x0009C4F0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> Log2(Vector<float> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.Log2Single<Vector<float>, Vector<int>, Vector<uint>>(vector);
			}
			return Vector.Log2<float>(vector);
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x0009E308 File Offset: 0x0009C508
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Max<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.Max<Vector<T>, T>(left, right);
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Max(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003062 RID: 12386 RVA: 0x0009E35C File Offset: 0x0009C55C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> MaxMagnitude<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.MaxMagnitude<Vector<T>, T>(left, right);
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.MaxMagnitude(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x0009E3B0 File Offset: 0x0009C5B0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> MaxMagnitudeNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.MaxMagnitudeNumber<Vector<T>, T>(left, right);
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.MaxMagnitudeNumber(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x0009E404 File Offset: 0x0009C604
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> MaxNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return Vector.ConditionalSelect<T>(Vector.GreaterThan<T>(left, right), left, right);
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.GreaterThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? left.GetElementUnsafe(i) : right.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003065 RID: 12389 RVA: 0x0009E474 File Offset: 0x0009C674
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> MaxNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.MaxNumber<Vector<T>, T>(left, right);
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.MaxNumber(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x0009E4C8 File Offset: 0x0009C6C8
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Min<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.Min<Vector<T>, T>(left, right);
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Min(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x0009E51C File Offset: 0x0009C71C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> MinMagnitude<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.MinMagnitude<Vector<T>, T>(left, right);
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.MinMagnitude(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x0009E570 File Offset: 0x0009C770
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> MinMagnitudeNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.MinMagnitudeNumber<Vector<T>, T>(left, right);
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.MinMagnitudeNumber(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x0009E5C4 File Offset: 0x0009C7C4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> MinNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return Vector.ConditionalSelect<T>(Vector.LessThan<T>(left, right), left, right);
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.LessThan(left.GetElementUnsafe(i), right.GetElementUnsafe(i)) ? left.GetElementUnsafe(i) : right.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x0009E634 File Offset: 0x0009C834
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> MinNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.MinNumber<Vector<T>, T>(left, right);
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.MinNumber(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x0009E687 File Offset: 0x0009C887
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Multiply<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return left * right;
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x0009E690 File Offset: 0x0009C890
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Multiply<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, T right)
		{
			return left * right;
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x0009E699 File Offset: 0x0009C899
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Multiply<[Nullable(2)] T>(T left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return right * left;
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x0009E6A4 File Offset: 0x0009C8A4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector<T> MultiplyAddEstimate<T>(Vector<T> left, Vector<T> right, Vector<T> addend)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.MultiplyAddEstimate(left.GetElementUnsafe(i), right.GetElementUnsafe(i), addend.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x0009E6F0 File Offset: 0x0009C8F0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> MultiplyAddEstimate(Vector<double> left, Vector<double> right, Vector<double> addend)
		{
			Vector<double> result;
			Unsafe.SkipInit<Vector<double>>(out result);
			for (int i = 0; i < Vector<double>.Count; i++)
			{
				double value = double.MultiplyAddEstimate(left.GetElementUnsafe(i), right.GetElementUnsafe(i), addend.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x0009E73C File Offset: 0x0009C93C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> MultiplyAddEstimate(Vector<float> left, Vector<float> right, Vector<float> addend)
		{
			Vector<float> result;
			Unsafe.SkipInit<Vector<float>>(out result);
			for (int i = 0; i < Vector<float>.Count; i++)
			{
				float value = float.MultiplyAddEstimate(left.GetElementUnsafe(i), right.GetElementUnsafe(i), addend.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x0009E788 File Offset: 0x0009C988
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> Narrow(Vector<double> low, Vector<double> high)
		{
			Vector<float> result;
			Unsafe.SkipInit<Vector<float>>(out result);
			for (int i = 0; i < Vector<double>.Count; i++)
			{
				float value = (float)low.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector<double>.Count; j < Vector<float>.Count; j++)
			{
				float value2 = (float)high.GetElementUnsafe(j - Vector<double>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x0009E7F0 File Offset: 0x0009C9F0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<sbyte> Narrow(Vector<short> low, Vector<short> high)
		{
			Vector<sbyte> result;
			Unsafe.SkipInit<Vector<sbyte>>(out result);
			for (int i = 0; i < Vector<short>.Count; i++)
			{
				sbyte value = (sbyte)low.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector<short>.Count; j < Vector<sbyte>.Count; j++)
			{
				sbyte value2 = (sbyte)high.GetElementUnsafe(j - Vector<short>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x0009E858 File Offset: 0x0009CA58
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<short> Narrow(Vector<int> low, Vector<int> high)
		{
			Vector<short> result;
			Unsafe.SkipInit<Vector<short>>(out result);
			for (int i = 0; i < Vector<int>.Count; i++)
			{
				short value = (short)low.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector<int>.Count; j < Vector<short>.Count; j++)
			{
				short value2 = (short)high.GetElementUnsafe(j - Vector<int>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x0009E8C0 File Offset: 0x0009CAC0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<int> Narrow(Vector<long> low, Vector<long> high)
		{
			Vector<int> result;
			Unsafe.SkipInit<Vector<int>>(out result);
			for (int i = 0; i < Vector<long>.Count; i++)
			{
				int value = (int)low.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector<long>.Count; j < Vector<int>.Count; j++)
			{
				int value2 = (int)high.GetElementUnsafe(j - Vector<long>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x0009E928 File Offset: 0x0009CB28
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<byte> Narrow(Vector<ushort> low, Vector<ushort> high)
		{
			Vector<byte> result;
			Unsafe.SkipInit<Vector<byte>>(out result);
			for (int i = 0; i < Vector<ushort>.Count; i++)
			{
				byte value = (byte)low.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector<ushort>.Count; j < Vector<byte>.Count; j++)
			{
				byte value2 = (byte)high.GetElementUnsafe(j - Vector<ushort>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x0009E990 File Offset: 0x0009CB90
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<ushort> Narrow(Vector<uint> low, Vector<uint> high)
		{
			Vector<ushort> result;
			Unsafe.SkipInit<Vector<ushort>>(out result);
			for (int i = 0; i < Vector<uint>.Count; i++)
			{
				ushort value = (ushort)low.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector<uint>.Count; j < Vector<ushort>.Count; j++)
			{
				ushort value2 = (ushort)high.GetElementUnsafe(j - Vector<uint>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x0009E9F8 File Offset: 0x0009CBF8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<uint> Narrow(Vector<ulong> low, Vector<ulong> high)
		{
			Vector<uint> result;
			Unsafe.SkipInit<Vector<uint>>(out result);
			for (int i = 0; i < Vector<ulong>.Count; i++)
			{
				uint value = (uint)low.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			for (int j = Vector<ulong>.Count; j < Vector<uint>.Count; j++)
			{
				uint value2 = (uint)high.GetElementUnsafe(j - Vector<ulong>.Count);
				result.SetElementUnsafe(j, value2);
			}
			return result;
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x0009EA5F File Offset: 0x0009CC5F
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Negate<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return -value;
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x0009EA67 File Offset: 0x0009CC67
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> OnesComplement<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return ~value;
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x0009EA70 File Offset: 0x0009CC70
		internal static Vector<T> RadiansToDegrees<T>(Vector<T> radians) where T : ITrigonometricFunctions<T>
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = ITrigonometricFunctions<T>.RadiansToDegrees(radians.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x0009EAB2 File Offset: 0x0009CCB2
		[Intrinsic]
		public static Vector<double> RadiansToDegrees(Vector<double> radians)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.RadiansToDegrees<Vector<double>, double>(radians);
			}
			return Vector.RadiansToDegrees<double>(radians);
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x0009EAC8 File Offset: 0x0009CCC8
		[Intrinsic]
		public static Vector<float> RadiansToDegrees(Vector<float> radians)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.RadiansToDegrees<Vector<float>, float>(radians);
			}
			return Vector.RadiansToDegrees<float>(radians);
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x0009EAE0 File Offset: 0x0009CCE0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector<T> Round<T>(Vector<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Round(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x0009EC3B File Offset: 0x0009CE3B
		[Intrinsic]
		public static Vector<double> Round(Vector<double> vector)
		{
			return Vector.Round<double>(vector);
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x0009EC43 File Offset: 0x0009CE43
		[Intrinsic]
		public static Vector<float> Round(Vector<float> vector)
		{
			return Vector.Round<float>(vector);
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x0009EC4B File Offset: 0x0009CE4B
		[Intrinsic]
		public static Vector<double> Round(Vector<double> vector, MidpointRounding mode)
		{
			return VectorMath.RoundDouble<Vector<double>>(vector, mode);
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x0009EC54 File Offset: 0x0009CE54
		[Intrinsic]
		public static Vector<float> Round(Vector<float> vector, MidpointRounding mode)
		{
			return VectorMath.RoundSingle<Vector<float>>(vector, mode);
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x0009EC5D File Offset: 0x0009CE5D
		[Intrinsic]
		public static Vector<byte> ShiftLeft(Vector<byte> value, int shiftCount)
		{
			return value << shiftCount;
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x0009EC66 File Offset: 0x0009CE66
		[Intrinsic]
		public static Vector<short> ShiftLeft(Vector<short> value, int shiftCount)
		{
			return value << shiftCount;
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x0009EC6F File Offset: 0x0009CE6F
		[Intrinsic]
		public static Vector<int> ShiftLeft(Vector<int> value, int shiftCount)
		{
			return value << shiftCount;
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x0009EC78 File Offset: 0x0009CE78
		[Intrinsic]
		public static Vector<long> ShiftLeft(Vector<long> value, int shiftCount)
		{
			return value << shiftCount;
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x0009EC81 File Offset: 0x0009CE81
		[Intrinsic]
		public static Vector<IntPtr> ShiftLeft(Vector<IntPtr> value, int shiftCount)
		{
			return value << shiftCount;
		}

		// Token: 0x06003087 RID: 12423 RVA: 0x0009EC8A File Offset: 0x0009CE8A
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<UIntPtr> ShiftLeft(Vector<UIntPtr> value, int shiftCount)
		{
			return value << shiftCount;
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x0009EC93 File Offset: 0x0009CE93
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftCount)
		{
			return value << shiftCount;
		}

		// Token: 0x06003089 RID: 12425 RVA: 0x0009EC9C File Offset: 0x0009CE9C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftCount)
		{
			return value << shiftCount;
		}

		// Token: 0x0600308A RID: 12426 RVA: 0x0009ECA5 File Offset: 0x0009CEA5
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<uint> ShiftLeft(Vector<uint> value, int shiftCount)
		{
			return value << shiftCount;
		}

		// Token: 0x0600308B RID: 12427 RVA: 0x0009ECAE File Offset: 0x0009CEAE
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftCount)
		{
			return value << shiftCount;
		}

		// Token: 0x0600308C RID: 12428 RVA: 0x0009ECB7 File Offset: 0x0009CEB7
		[Intrinsic]
		public static Vector<short> ShiftRightArithmetic(Vector<short> value, int shiftCount)
		{
			return value >> shiftCount;
		}

		// Token: 0x0600308D RID: 12429 RVA: 0x0009ECC0 File Offset: 0x0009CEC0
		[Intrinsic]
		public static Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftCount)
		{
			return value >> shiftCount;
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x0009ECC9 File Offset: 0x0009CEC9
		[Intrinsic]
		public static Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftCount)
		{
			return value >> shiftCount;
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x0009ECD2 File Offset: 0x0009CED2
		[Intrinsic]
		public static Vector<IntPtr> ShiftRightArithmetic(Vector<IntPtr> value, int shiftCount)
		{
			return value >> shiftCount;
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x0009ECDB File Offset: 0x0009CEDB
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftCount)
		{
			return value >> shiftCount;
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x0009ECE4 File Offset: 0x0009CEE4
		[Intrinsic]
		public static Vector<byte> ShiftRightLogical(Vector<byte> value, int shiftCount)
		{
			return Vector<byte>.op_UnsignedRightShift(value, shiftCount);
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x0009ECED File Offset: 0x0009CEED
		[Intrinsic]
		public static Vector<short> ShiftRightLogical(Vector<short> value, int shiftCount)
		{
			return Vector<short>.op_UnsignedRightShift(value, shiftCount);
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x0009ECF6 File Offset: 0x0009CEF6
		[Intrinsic]
		public static Vector<int> ShiftRightLogical(Vector<int> value, int shiftCount)
		{
			return Vector<int>.op_UnsignedRightShift(value, shiftCount);
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x0009ECFF File Offset: 0x0009CEFF
		[Intrinsic]
		public static Vector<long> ShiftRightLogical(Vector<long> value, int shiftCount)
		{
			return Vector<long>.op_UnsignedRightShift(value, shiftCount);
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x0009ED08 File Offset: 0x0009CF08
		[Intrinsic]
		public static Vector<IntPtr> ShiftRightLogical(Vector<IntPtr> value, int shiftCount)
		{
			return Vector<IntPtr>.op_UnsignedRightShift(value, shiftCount);
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x0009ED11 File Offset: 0x0009CF11
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<UIntPtr> ShiftRightLogical(Vector<UIntPtr> value, int shiftCount)
		{
			return Vector<UIntPtr>.op_UnsignedRightShift(value, shiftCount);
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x0009ED1A File Offset: 0x0009CF1A
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<sbyte> ShiftRightLogical(Vector<sbyte> value, int shiftCount)
		{
			return Vector<sbyte>.op_UnsignedRightShift(value, shiftCount);
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x0009ED23 File Offset: 0x0009CF23
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<ushort> ShiftRightLogical(Vector<ushort> value, int shiftCount)
		{
			return Vector<ushort>.op_UnsignedRightShift(value, shiftCount);
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x0009ED2C File Offset: 0x0009CF2C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<uint> ShiftRightLogical(Vector<uint> value, int shiftCount)
		{
			return Vector<uint>.op_UnsignedRightShift(value, shiftCount);
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x0009ED35 File Offset: 0x0009CF35
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector<ulong> ShiftRightLogical(Vector<ulong> value, int shiftCount)
		{
			return Vector<ulong>.op_UnsignedRightShift(value, shiftCount);
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x0009ED40 File Offset: 0x0009CF40
		internal static Vector<T> Sin<T>(Vector<T> vector) where T : ITrigonometricFunctions<T>
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = ITrigonometricFunctions<T>.Sin(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x0009ED82 File Offset: 0x0009CF82
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> Sin(Vector<double> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.SinDouble<Vector<double>, Vector<long>>(vector);
			}
			return Vector.Sin<double>(vector);
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x0009ED98 File Offset: 0x0009CF98
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<float> Sin(Vector<float> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.SinSingle<Vector<float>, Vector<int>, Vector<double>, Vector<long>>(vector);
			}
			return Vector.Sin<float>(vector);
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x0009EDB0 File Offset: 0x0009CFB0
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		internal static ValueTuple<Vector<T>, Vector<T>> SinCos<T>(Vector<T> vector) where T : ITrigonometricFunctions<T>
		{
			Vector<T> item;
			Unsafe.SkipInit<Vector<T>>(out item);
			Vector<T> item2;
			Unsafe.SkipInit<Vector<T>>(out item2);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				ValueTuple<T, T> valueTuple = ITrigonometricFunctions<T>.SinCos(vector.GetElementUnsafe(i));
				T item3 = valueTuple.Item1;
				T item4 = valueTuple.Item2;
				item.SetElementUnsafe(i, item3);
				item2.SetElementUnsafe(i, item4);
			}
			return new ValueTuple<Vector<T>, Vector<T>>(item, item2);
		}

		// Token: 0x0600309F RID: 12447 RVA: 0x0009EE16 File Offset: 0x0009D016
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector<double>, Vector<double>> SinCos(Vector<double> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.SinCosDouble<Vector<double>, Vector<long>>(vector);
			}
			return Vector.SinCos<double>(vector);
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x0009EE2C File Offset: 0x0009D02C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector<float>, Vector<float>> SinCos(Vector<float> vector)
		{
			if (Vector.IsHardwareAccelerated)
			{
				return VectorMath.SinCosSingle<Vector<float>, Vector<int>, Vector<double>, Vector<long>>(vector);
			}
			return Vector.SinCos<float>(vector);
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x0009EE44 File Offset: 0x0009D044
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> SquareRoot<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value2 = Scalar<T>.Sqrt(value.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x0009EE80 File Offset: 0x0009D080
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		public unsafe static void Store<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			source.StoreUnsafe(ref *destination);
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x0009EE89 File Offset: 0x0009D089
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void StoreAligned<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			if (destination % Vector.Alignment != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			*(Vector<T>*)destination = source;
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x0009EEA6 File Offset: 0x0009D0A6
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		public unsafe static void StoreAlignedNonTemporal<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			source.StoreAligned(destination);
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x0009EEAF File Offset: 0x0009D0AF
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StoreUnsafe<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<T> source, ref T destination)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<T, byte>(ref destination), source);
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x0009EEC2 File Offset: 0x0009D0C2
		[NullableContext(1)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StoreUnsafe<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<T> source, ref T destination, UIntPtr elementOffset)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			destination = Unsafe.Add<T>(ref destination, (IntPtr)elementOffset);
			Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<T, byte>(ref destination), source);
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x0009EEDE File Offset: 0x0009D0DE
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Subtract<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return left - right;
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x0009EEE8 File Offset: 0x0009D0E8
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Sum<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			T t = default(T);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				t = Scalar<T>.Add(t, value.GetElementUnsafe(i));
			}
			return t;
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x0009EF1D File Offset: 0x0009D11D
		[NullableContext(1)]
		[Intrinsic]
		public static T ToScalar<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			return vector.GetElementUnsafe(0);
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x0009EF2C File Offset: 0x0009D12C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector<T> Truncate<T>(Vector<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Truncate(vector.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x0009F087 File Offset: 0x0009D287
		[Intrinsic]
		public static Vector<double> Truncate(Vector<double> vector)
		{
			return Vector.Truncate<double>(vector);
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x0009F08F File Offset: 0x0009D28F
		[Intrinsic]
		public static Vector<float> Truncate(Vector<float> vector)
		{
			return Vector.Truncate<float>(vector);
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x0009F097 File Offset: 0x0009D297
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Widen(Vector<byte> source, out Vector<ushort> low, out Vector<ushort> high)
		{
			low = Vector.WidenLower(source);
			high = Vector.WidenUpper(source);
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x0009F0B1 File Offset: 0x0009D2B1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Widen(Vector<short> source, out Vector<int> low, out Vector<int> high)
		{
			low = Vector.WidenLower(source);
			high = Vector.WidenUpper(source);
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x0009F0CB File Offset: 0x0009D2CB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Widen(Vector<int> source, out Vector<long> low, out Vector<long> high)
		{
			low = Vector.WidenLower(source);
			high = Vector.WidenUpper(source);
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x0009F0E5 File Offset: 0x0009D2E5
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Widen(Vector<sbyte> source, out Vector<short> low, out Vector<short> high)
		{
			low = Vector.WidenLower(source);
			high = Vector.WidenUpper(source);
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x0009F0FF File Offset: 0x0009D2FF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Widen(Vector<float> source, out Vector<double> low, out Vector<double> high)
		{
			low = Vector.WidenLower(source);
			high = Vector.WidenUpper(source);
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x0009F119 File Offset: 0x0009D319
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Widen(Vector<ushort> source, out Vector<uint> low, out Vector<uint> high)
		{
			low = Vector.WidenLower(source);
			high = Vector.WidenUpper(source);
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x0009F133 File Offset: 0x0009D333
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Widen(Vector<uint> source, out Vector<ulong> low, out Vector<ulong> high)
		{
			low = Vector.WidenLower(source);
			high = Vector.WidenUpper(source);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x0009F150 File Offset: 0x0009D350
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<ushort> WidenLower(Vector<byte> source)
		{
			Vector<ushort> result;
			Unsafe.SkipInit<Vector<ushort>>(out result);
			for (int i = 0; i < Vector<ushort>.Count; i++)
			{
				ushort elementUnsafe = (ushort)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, elementUnsafe);
			}
			return result;
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0009F188 File Offset: 0x0009D388
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<int> WidenLower(Vector<short> source)
		{
			Vector<int> result;
			Unsafe.SkipInit<Vector<int>>(out result);
			for (int i = 0; i < Vector<int>.Count; i++)
			{
				int elementUnsafe = (int)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, elementUnsafe);
			}
			return result;
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x0009F1C0 File Offset: 0x0009D3C0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<long> WidenLower(Vector<int> source)
		{
			Vector<long> result;
			Unsafe.SkipInit<Vector<long>>(out result);
			for (int i = 0; i < Vector<long>.Count; i++)
			{
				long value = (long)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x0009F1F8 File Offset: 0x0009D3F8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<short> WidenLower(Vector<sbyte> source)
		{
			Vector<short> result;
			Unsafe.SkipInit<Vector<short>>(out result);
			for (int i = 0; i < Vector<short>.Count; i++)
			{
				short elementUnsafe = (short)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, elementUnsafe);
			}
			return result;
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x0009F230 File Offset: 0x0009D430
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> WidenLower(Vector<float> source)
		{
			Vector<double> result;
			Unsafe.SkipInit<Vector<double>>(out result);
			for (int i = 0; i < Vector<double>.Count; i++)
			{
				double value = (double)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x0009F268 File Offset: 0x0009D468
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<uint> WidenLower(Vector<ushort> source)
		{
			Vector<uint> result;
			Unsafe.SkipInit<Vector<uint>>(out result);
			for (int i = 0; i < Vector<uint>.Count; i++)
			{
				uint elementUnsafe = (uint)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, elementUnsafe);
			}
			return result;
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x0009F2A0 File Offset: 0x0009D4A0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<ulong> WidenLower(Vector<uint> source)
		{
			Vector<ulong> result;
			Unsafe.SkipInit<Vector<ulong>>(out result);
			for (int i = 0; i < Vector<ulong>.Count; i++)
			{
				ulong value = (ulong)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x0009F2D8 File Offset: 0x0009D4D8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<ushort> WidenUpper(Vector<byte> source)
		{
			Vector<ushort> result;
			Unsafe.SkipInit<Vector<ushort>>(out result);
			for (int i = Vector<ushort>.Count; i < Vector<byte>.Count; i++)
			{
				ushort elementUnsafe = (ushort)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector<ushort>.Count, elementUnsafe);
			}
			return result;
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x0009F31C File Offset: 0x0009D51C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<int> WidenUpper(Vector<short> source)
		{
			Vector<int> result;
			Unsafe.SkipInit<Vector<int>>(out result);
			for (int i = Vector<int>.Count; i < Vector<short>.Count; i++)
			{
				int elementUnsafe = (int)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector<int>.Count, elementUnsafe);
			}
			return result;
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x0009F360 File Offset: 0x0009D560
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<long> WidenUpper(Vector<int> source)
		{
			Vector<long> result;
			Unsafe.SkipInit<Vector<long>>(out result);
			for (int i = Vector<long>.Count; i < Vector<int>.Count; i++)
			{
				long value = (long)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector<long>.Count, value);
			}
			return result;
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x0009F3A4 File Offset: 0x0009D5A4
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<short> WidenUpper(Vector<sbyte> source)
		{
			Vector<short> result;
			Unsafe.SkipInit<Vector<short>>(out result);
			for (int i = Vector<short>.Count; i < Vector<sbyte>.Count; i++)
			{
				short elementUnsafe = (short)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector<short>.Count, elementUnsafe);
			}
			return result;
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x0009F3E8 File Offset: 0x0009D5E8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<double> WidenUpper(Vector<float> source)
		{
			Vector<double> result;
			Unsafe.SkipInit<Vector<double>>(out result);
			for (int i = Vector<double>.Count; i < Vector<float>.Count; i++)
			{
				double value = (double)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector<double>.Count, value);
			}
			return result;
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x0009F42C File Offset: 0x0009D62C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<uint> WidenUpper(Vector<ushort> source)
		{
			Vector<uint> result;
			Unsafe.SkipInit<Vector<uint>>(out result);
			for (int i = Vector<uint>.Count; i < Vector<ushort>.Count; i++)
			{
				uint elementUnsafe = (uint)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector<uint>.Count, elementUnsafe);
			}
			return result;
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x0009F470 File Offset: 0x0009D670
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector<ulong> WidenUpper(Vector<uint> source)
		{
			Vector<ulong> result;
			Unsafe.SkipInit<Vector<ulong>>(out result);
			for (int i = Vector<ulong>.Count; i < Vector<uint>.Count; i++)
			{
				ulong value = (ulong)source.GetElementUnsafe(i);
				result.SetElementUnsafe(i - Vector<ulong>.Count, value);
			}
			return result;
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x0009F4B4 File Offset: 0x0009D6B4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> WithElement<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<T> vector, int index, T value)
		{
			if (index >= Vector<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			Vector<T> result = vector;
			result.SetElementUnsafe(index, value);
			return result;
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x0009F4DC File Offset: 0x0009D6DC
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Xor<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return left ^ right;
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0009F4E5 File Offset: 0x0009D6E5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static T GetElementUnsafe<T>(this Vector<T> vector, int index)
		{
			return *Unsafe.Add<T>(Unsafe.As<Vector<T>, T>(Unsafe.AsRef<Vector<T>>(ref vector)), index);
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x0009F4FD File Offset: 0x0009D6FD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void SetElementUnsafe<T>(this Vector<T> vector, int index, T value)
		{
			*Unsafe.Add<T>(Unsafe.As<Vector<T>, T>(Unsafe.AsRef<Vector<T>>(ref vector)), index) = value;
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x0009F516 File Offset: 0x0009D716
		[Intrinsic]
		public static Vector4 AsVector4(this Vector2 value)
		{
			return value.AsVector128().AsVector4();
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x0009F523 File Offset: 0x0009D723
		[Intrinsic]
		public static Vector4 AsVector4Unsafe(this Vector2 value)
		{
			return value.AsVector128Unsafe().AsVector4();
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x0009F530 File Offset: 0x0009D730
		[Intrinsic]
		public static Vector4 AsVector4(this Vector3 value)
		{
			return value.AsVector128().AsVector4();
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x0009F53D File Offset: 0x0009D73D
		[Intrinsic]
		public static Vector4 AsVector4Unsafe(this Vector3 value)
		{
			return value.AsVector128Unsafe().AsVector4();
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x0009F54A File Offset: 0x0009D74A
		[Intrinsic]
		public unsafe static Plane AsPlane(this Vector4 value)
		{
			return *Unsafe.As<Vector4, Plane>(ref value);
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x0009F558 File Offset: 0x0009D758
		[Intrinsic]
		public unsafe static Quaternion AsQuaternion(this Vector4 value)
		{
			return *Unsafe.As<Vector4, Quaternion>(ref value);
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x0009F566 File Offset: 0x0009D766
		[Intrinsic]
		public static Vector2 AsVector2(this Vector4 value)
		{
			return value.AsVector128().AsVector2();
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x0009F573 File Offset: 0x0009D773
		[Intrinsic]
		public static Vector3 AsVector3(this Vector4 value)
		{
			return value.AsVector128().AsVector3();
		}
	}
}
