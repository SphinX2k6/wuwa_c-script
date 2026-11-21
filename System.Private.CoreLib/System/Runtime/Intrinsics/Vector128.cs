using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace System.Runtime.Intrinsics
{
	// Token: 0x02000543 RID: 1347
	public static class Vector128
	{
		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060049F9 RID: 18937 RVA: 0x000F7EFC File Offset: 0x000F60FC
		public static bool IsHardwareAccelerated
		{
			[Intrinsic]
			get
			{
				return Vector128.IsHardwareAccelerated;
			}
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x000F7F04 File Offset: 0x000F6104
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Abs<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return vector;
			}
			return Vector128.Create<T>(Vector64.Abs<T>(vector._lower), Vector64.Abs<T>(vector._upper));
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x000F7FB5 File Offset: 0x000F61B5
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Add<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return left + right;
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x000F7FBE File Offset: 0x000F61BE
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> AndNot<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return left & ~right;
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x000F7FCC File Offset: 0x000F61CC
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector128<TTo> As<TFrom, TTo>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<TFrom> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<TFrom>();
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<TTo>();
			return *Unsafe.As<Vector128<TFrom>, Vector128<TTo>>(ref vector);
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x000F7FE4 File Offset: 0x000F61E4
		[Intrinsic]
		public static Vector128<byte> AsByte<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, byte>();
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x000F7FEC File Offset: 0x000F61EC
		[Intrinsic]
		public static Vector128<double> AsDouble<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, double>();
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x000F7FF4 File Offset: 0x000F61F4
		[Intrinsic]
		public static Vector128<short> AsInt16<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, short>();
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x000F7FFC File Offset: 0x000F61FC
		[Intrinsic]
		public static Vector128<int> AsInt32<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, int>();
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x000F8004 File Offset: 0x000F6204
		[Intrinsic]
		public static Vector128<long> AsInt64<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, long>();
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x000F800C File Offset: 0x000F620C
		[Intrinsic]
		public static Vector128<IntPtr> AsNInt<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, IntPtr>();
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x000F8014 File Offset: 0x000F6214
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<UIntPtr> AsNUInt<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, UIntPtr>();
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x000F801C File Offset: 0x000F621C
		[Intrinsic]
		internal unsafe static Plane AsPlane(this Vector128<float> value)
		{
			return *Unsafe.As<Vector128<float>, Plane>(ref value);
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x000F802A File Offset: 0x000F622A
		[Intrinsic]
		internal unsafe static Quaternion AsQuaternion(this Vector128<float> value)
		{
			return *Unsafe.As<Vector128<float>, Quaternion>(ref value);
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x000F8038 File Offset: 0x000F6238
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<sbyte> AsSByte<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, sbyte>();
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x000F8040 File Offset: 0x000F6240
		[Intrinsic]
		public static Vector128<float> AsSingle<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, float>();
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x000F8048 File Offset: 0x000F6248
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ushort> AsUInt16<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, ushort>();
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x000F8050 File Offset: 0x000F6250
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<uint> AsUInt32<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, uint>();
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x000F8058 File Offset: 0x000F6258
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ulong> AsUInt64<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector.As<T, ulong>();
		}

		// Token: 0x06004A0C RID: 18956 RVA: 0x000F8060 File Offset: 0x000F6260
		[Intrinsic]
		internal unsafe static Vector128<float> AsVector128(this Plane value)
		{
			return *Unsafe.As<Plane, Vector128<float>>(ref value);
		}

		// Token: 0x06004A0D RID: 18957 RVA: 0x000F806E File Offset: 0x000F626E
		[Intrinsic]
		internal unsafe static Vector128<float> AsVector128(this Quaternion value)
		{
			return *Unsafe.As<Quaternion, Vector128<float>>(ref value);
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x000F807C File Offset: 0x000F627C
		[Intrinsic]
		public static Vector128<float> AsVector128(this Vector2 value)
		{
			return Vector4.Create(value, 0f, 0f).AsVector128();
		}

		// Token: 0x06004A0F RID: 18959 RVA: 0x000F8093 File Offset: 0x000F6293
		[Intrinsic]
		public static Vector128<float> AsVector128(this Vector3 value)
		{
			return Vector4.Create(value, 0f).AsVector128();
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x000F80A5 File Offset: 0x000F62A5
		[Intrinsic]
		public unsafe static Vector128<float> AsVector128(this Vector4 value)
		{
			return *Unsafe.As<Vector4, Vector128<float>>(ref value);
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x000F80B3 File Offset: 0x000F62B3
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> AsVector128<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			return Unsafe.ReadUnaligned<Vector128<T>>(Unsafe.As<Vector<T>, byte>(ref value));
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x000F80C8 File Offset: 0x000F62C8
		[Intrinsic]
		public static Vector128<float> AsVector128Unsafe(this Vector2 value)
		{
			Vector128<float> result;
			Unsafe.SkipInit<Vector128<float>>(out result);
			Unsafe.WriteUnaligned<Vector2>(Unsafe.As<Vector128<float>, byte>(ref result), value);
			return result;
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x000F80EC File Offset: 0x000F62EC
		[Intrinsic]
		public static Vector128<float> AsVector128Unsafe(this Vector3 value)
		{
			Vector128<float> result;
			Unsafe.SkipInit<Vector128<float>>(out result);
			Unsafe.WriteUnaligned<Vector3>(Unsafe.As<Vector128<float>, byte>(ref result), value);
			return result;
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x000F810E File Offset: 0x000F630E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 AsVector2(this Vector128<float> value)
		{
			return Unsafe.ReadUnaligned<Vector2>(Unsafe.As<Vector128<float>, byte>(ref value));
		}

		// Token: 0x06004A15 RID: 18965 RVA: 0x000F811C File Offset: 0x000F631C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 AsVector3(this Vector128<float> value)
		{
			return Unsafe.ReadUnaligned<Vector3>(Unsafe.As<Vector128<float>, byte>(ref value));
		}

		// Token: 0x06004A16 RID: 18966 RVA: 0x000F812A File Offset: 0x000F632A
		[Intrinsic]
		public unsafe static Vector4 AsVector4(this Vector128<float> value)
		{
			return *Unsafe.As<Vector128<float>, Vector4>(ref value);
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x000F8138 File Offset: 0x000F6338
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
		})] this Vector128<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			Vector<T> result = default(Vector<T>);
			Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<Vector<T>, byte>(ref result), value);
			return result;
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x000F8160 File Offset: 0x000F6360
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> BitwiseAnd<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return left & right;
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x000F8169 File Offset: 0x000F6369
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> BitwiseOr<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return left | right;
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x000F8174 File Offset: 0x000F6374
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<T> Ceiling<T>(Vector128<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector128.Create<T>(Vector64.Ceiling<T>(vector._lower), Vector64.Ceiling<T>(vector._upper));
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x000F82BB File Offset: 0x000F64BB
		[Intrinsic]
		public static Vector128<float> Ceiling(Vector128<float> vector)
		{
			return Vector128.Ceiling<float>(vector);
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x000F82C3 File Offset: 0x000F64C3
		[Intrinsic]
		public static Vector128<double> Ceiling(Vector128<double> vector)
		{
			return Vector128.Ceiling<double>(vector);
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x000F82CB File Offset: 0x000F64CB
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Clamp<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> min, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> max)
		{
			return Vector128.Min<T>(Vector128.Max<T>(value, min), max);
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x000F82DA File Offset: 0x000F64DA
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> ClampNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> min, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> max)
		{
			return Vector128.MinNative<T>(Vector128.MaxNative<T>(value, min), max);
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x000F82E9 File Offset: 0x000F64E9
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> ConditionalSelect<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> condition, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return (left & condition) | Vector128.AndNot<T>(right, condition);
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x000F8300 File Offset: 0x000F6500
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> ConvertToDouble(Vector128<long> vector)
		{
			if (Sse2.IsSupported)
			{
				if (false)
				{
				}
				Vector128<int> vector2 = Sse2.And(vector, Vector128.Create((long)((ulong)-1))).AsInt32<long>();
				vector2 = Sse2.Or(vector2, Vector128.Create(4841369599423283200L).AsInt32<long>());
				return Sse2.Add(Sse2.Subtract(Sse2.Xor(Sse2.ShiftRightLogical(vector, 32), Vector128.Create(4985484789646622720L)).AsDouble<long>(), Vector128.Create(4985484789647671296L).AsDouble<long>()), vector2.AsDouble<int>());
			}
			return Vector128.Create(Vector64.ConvertToDouble(vector._lower), Vector64.ConvertToDouble(vector._upper));
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x000F83A8 File Offset: 0x000F65A8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> ConvertToDouble(Vector128<ulong> vector)
		{
			if (Sse2.IsSupported)
			{
				if (false)
				{
				}
				Vector128<uint> vector2 = Sse2.And(vector, Vector128.Create((ulong)-1)).AsUInt32<ulong>();
				vector2 = Sse2.Or(vector2, Vector128.Create(4841369599423283200UL).AsUInt32<ulong>());
				return Sse2.Add(Sse2.Subtract(Sse2.Xor(Sse2.ShiftRightLogical(vector, 32), Vector128.Create(4985484787499139072UL)).AsDouble<ulong>(), Vector128.Create(4985484787500187648UL).AsDouble<ulong>()), vector2.AsDouble<uint>());
			}
			return Vector128.Create(Vector64.ConvertToDouble(vector._lower), Vector64.ConvertToDouble(vector._upper));
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x000F844E File Offset: 0x000F664E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<int> ConvertToInt32(Vector128<float> vector)
		{
			return Vector128.Create(Vector64.ConvertToInt32(vector._lower), Vector64.ConvertToInt32(vector._upper));
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x000F846B File Offset: 0x000F666B
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<int> ConvertToInt32Native(Vector128<float> vector)
		{
			return Vector128.Create(Vector64.ConvertToInt32Native(vector._lower), Vector64.ConvertToInt32Native(vector._upper));
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x000F8488 File Offset: 0x000F6688
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<long> ConvertToInt64(Vector128<double> vector)
		{
			return Vector128.Create(Vector64.ConvertToInt64(vector._lower), Vector64.ConvertToInt64(vector._upper));
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x000F84A5 File Offset: 0x000F66A5
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<long> ConvertToInt64Native(Vector128<double> vector)
		{
			return Vector128.Create(Vector64.ConvertToInt64Native(vector._lower), Vector64.ConvertToInt64Native(vector._upper));
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x000F84C2 File Offset: 0x000F66C2
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> ConvertToSingle(Vector128<int> vector)
		{
			return Vector128.Create(Vector64.ConvertToSingle(vector._lower), Vector64.ConvertToSingle(vector._upper));
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x000F84E0 File Offset: 0x000F66E0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> ConvertToSingle(Vector128<uint> vector)
		{
			if (Sse2.IsSupported)
			{
				Vector128<int> value = Sse2.And(vector, Vector128.Create(65535U)).AsInt32<uint>();
				Vector128<int> value2 = Sse2.ShiftRightLogical(vector, 16).AsInt32<uint>();
				Vector128<float> right = Sse2.ConvertToVector128Single(value);
				Vector128<float> left = Sse2.ConvertToVector128Single(value2);
				if (false)
				{
				}
				return Sse.Add(Sse.Multiply(left, Vector128.Create(65536f)), right);
			}
			return Vector128.<ConvertToSingle>g__SoftwareFallback|49_0(vector);
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x000F8544 File Offset: 0x000F6744
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<uint> ConvertToUInt32(Vector128<float> vector)
		{
			return Vector128.Create(Vector64.ConvertToUInt32(vector._lower), Vector64.ConvertToUInt32(vector._upper));
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x000F8561 File Offset: 0x000F6761
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<uint> ConvertToUInt32Native(Vector128<float> vector)
		{
			return Vector128.Create(Vector64.ConvertToUInt32Native(vector._lower), Vector64.ConvertToUInt32Native(vector._upper));
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x000F857E File Offset: 0x000F677E
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<ulong> ConvertToUInt64(Vector128<double> vector)
		{
			return Vector128.Create(Vector64.ConvertToUInt64(vector._lower), Vector64.ConvertToUInt64(vector._upper));
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x000F859B File Offset: 0x000F679B
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<ulong> ConvertToUInt64Native(Vector128<double> vector)
		{
			return Vector128.Create(Vector64.ConvertToUInt64Native(vector._lower), Vector64.ConvertToUInt64Native(vector._upper));
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x000F85B8 File Offset: 0x000F67B8
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> CopySign<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> value, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> sign)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return value;
			}
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.CopySign<Vector128<T>, T>(value, sign);
			}
			return Vector128.Create<T>(Vector64.CopySign<T>(value._lower, sign._lower), Vector64.CopySign<T>(value._upper, sign._upper));
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x000F8684 File Offset: 0x000F6884
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector, T[] destination)
		{
			if (destination.Length < Vector128<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<T, byte>(ref destination[0]), vector);
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x000F86A7 File Offset: 0x000F68A7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector, T[] destination, int startIndex)
		{
			if (startIndex >= destination.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
			}
			if (destination.Length - startIndex < Vector128<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<T, byte>(ref destination[startIndex]), vector);
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x000F86D7 File Offset: 0x000F68D7
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (destination.Length < Vector128<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(destination)), vector);
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x000F86FD File Offset: 0x000F68FD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> Cos(Vector128<double> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.CosDouble<Vector128<double>, Vector128<long>>(vector);
			}
			return Vector128.Create(Vector64.Cos(vector._lower), Vector64.Cos(vector._upper));
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x000F8728 File Offset: 0x000F6928
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> Cos(Vector128<float> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				if (false)
				{
				}
				return VectorMath.CosSingle<Vector128<float>, Vector128<int>, Vector128<double>, Vector128<long>>(vector);
			}
			return Vector128.Create(Vector64.Cos(vector._lower), Vector64.Cos(vector._upper));
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x000F8756 File Offset: 0x000F6956
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Create<[Nullable(2)] T>(T value)
		{
			Vector64<T> vector = Vector64.Create<T>(value);
			return Vector128.Create<T>(vector, vector);
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x000F8764 File Offset: 0x000F6964
		[Intrinsic]
		public static Vector128<byte> Create(byte value)
		{
			return Vector128.Create<byte>(value);
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x000F876C File Offset: 0x000F696C
		[Intrinsic]
		public static Vector128<double> Create(double value)
		{
			return Vector128.Create<double>(value);
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x000F8774 File Offset: 0x000F6974
		[Intrinsic]
		public static Vector128<short> Create(short value)
		{
			return Vector128.Create<short>(value);
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x000F877C File Offset: 0x000F697C
		[Intrinsic]
		public static Vector128<int> Create(int value)
		{
			return Vector128.Create<int>(value);
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x000F8784 File Offset: 0x000F6984
		[Intrinsic]
		public static Vector128<long> Create(long value)
		{
			return Vector128.Create<long>(value);
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x000F878C File Offset: 0x000F698C
		[Intrinsic]
		public static Vector128<IntPtr> Create(IntPtr value)
		{
			return Vector128.Create<IntPtr>(value);
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x000F8794 File Offset: 0x000F6994
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<UIntPtr> Create(UIntPtr value)
		{
			return Vector128.Create<UIntPtr>(value);
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x000F879C File Offset: 0x000F699C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<sbyte> Create(sbyte value)
		{
			return Vector128.Create<sbyte>(value);
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x000F87A4 File Offset: 0x000F69A4
		[Intrinsic]
		public static Vector128<float> Create(float value)
		{
			return Vector128.Create<float>(value);
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x000F87AC File Offset: 0x000F69AC
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ushort> Create(ushort value)
		{
			return Vector128.Create<ushort>(value);
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x000F87B4 File Offset: 0x000F69B4
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<uint> Create(uint value)
		{
			return Vector128.Create<uint>(value);
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x000F87BC File Offset: 0x000F69BC
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ulong> Create(ulong value)
		{
			return Vector128.Create<ulong>(value);
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x000F87C4 File Offset: 0x000F69C4
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Create<[Nullable(2)] T>(T[] values)
		{
			if (values.Length < Vector128<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return Unsafe.ReadUnaligned<Vector128<T>>(Unsafe.As<T, byte>(ref values[0]));
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x000F87E6 File Offset: 0x000F69E6
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Create<[Nullable(2)] T>(T[] values, int index)
		{
			if (index < 0 || values.Length - index < Vector128<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			return Unsafe.ReadUnaligned<Vector128<T>>(Unsafe.As<T, byte>(ref values[index]));
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x000F880E File Offset: 0x000F6A0E
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values)
		{
			if (values.Length < Vector128<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.values);
			}
			return Unsafe.ReadUnaligned<Vector128<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(values)));
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x000F8834 File Offset: 0x000F6A34
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<byte> Create(byte e0, byte e1, byte e2, byte e3, byte e4, byte e5, byte e6, byte e7, byte e8, byte e9, byte e10, byte e11, byte e12, byte e13, byte e14, byte e15)
		{
			return Vector128.Create(Vector64.Create(e0, e1, e2, e3, e4, e5, e6, e7), Vector64.Create(e8, e9, e10, e11, e12, e13, e14, e15));
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x000F886C File Offset: 0x000F6A6C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> Create(double e0, double e1)
		{
			return Vector128.Create(Vector64.Create(e0), Vector64.Create(e1));
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x000F887F File Offset: 0x000F6A7F
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<short> Create(short e0, short e1, short e2, short e3, short e4, short e5, short e6, short e7)
		{
			return Vector128.Create(Vector64.Create(e0, e1, e2, e3), Vector64.Create(e4, e5, e6, e7));
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x000F889C File Offset: 0x000F6A9C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<int> Create(int e0, int e1, int e2, int e3)
		{
			return Vector128.Create(Vector64.Create(e0, e1), Vector64.Create(e2, e3));
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x000F88B1 File Offset: 0x000F6AB1
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<long> Create(long e0, long e1)
		{
			return Vector128.Create(Vector64.Create(e0), Vector64.Create(e1));
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x000F88C4 File Offset: 0x000F6AC4
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<sbyte> Create(sbyte e0, sbyte e1, sbyte e2, sbyte e3, sbyte e4, sbyte e5, sbyte e6, sbyte e7, sbyte e8, sbyte e9, sbyte e10, sbyte e11, sbyte e12, sbyte e13, sbyte e14, sbyte e15)
		{
			return Vector128.Create(Vector64.Create(e0, e1, e2, e3, e4, e5, e6, e7), Vector64.Create(e8, e9, e10, e11, e12, e13, e14, e15));
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x000F88FC File Offset: 0x000F6AFC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> Create(float e0, float e1, float e2, float e3)
		{
			return Vector128.Create(Vector64.Create(e0, e1), Vector64.Create(e2, e3));
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x000F8911 File Offset: 0x000F6B11
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<ushort> Create(ushort e0, ushort e1, ushort e2, ushort e3, ushort e4, ushort e5, ushort e6, ushort e7)
		{
			return Vector128.Create(Vector64.Create(e0, e1, e2, e3), Vector64.Create(e4, e5, e6, e7));
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x000F892E File Offset: 0x000F6B2E
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<uint> Create(uint e0, uint e1, uint e2, uint e3)
		{
			return Vector128.Create(Vector64.Create(e0, e1), Vector64.Create(e2, e3));
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x000F8943 File Offset: 0x000F6B43
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<ulong> Create(ulong e0, ulong e1)
		{
			return Vector128.Create(Vector64.Create(e0), Vector64.Create(e1));
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x000F8956 File Offset: 0x000F6B56
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value)
		{
			return Vector128.Create<T>(value, value);
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x000F8960 File Offset: 0x000F6B60
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Create<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> lower, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> upper)
		{
			if (false)
			{
			}
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			Vector128<T> result;
			Unsafe.SkipInit<Vector128<T>>(out result);
			result.SetLowerUnsafe(lower);
			result.SetUpperUnsafe(upper);
			return result;
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x000F898D File Offset: 0x000F6B8D
		public static Vector128<byte> Create(Vector64<byte> lower, Vector64<byte> upper)
		{
			return Vector128.Create<byte>(lower, upper);
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x000F8996 File Offset: 0x000F6B96
		public static Vector128<double> Create(Vector64<double> lower, Vector64<double> upper)
		{
			return Vector128.Create<double>(lower, upper);
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x000F899F File Offset: 0x000F6B9F
		public static Vector128<short> Create(Vector64<short> lower, Vector64<short> upper)
		{
			return Vector128.Create<short>(lower, upper);
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x000F89A8 File Offset: 0x000F6BA8
		public static Vector128<int> Create(Vector64<int> lower, Vector64<int> upper)
		{
			return Vector128.Create<int>(lower, upper);
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x000F89B1 File Offset: 0x000F6BB1
		public static Vector128<long> Create(Vector64<long> lower, Vector64<long> upper)
		{
			return Vector128.Create<long>(lower, upper);
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x000F89BA File Offset: 0x000F6BBA
		public static Vector128<IntPtr> Create(Vector64<IntPtr> lower, Vector64<IntPtr> upper)
		{
			return Vector128.Create<IntPtr>(lower, upper);
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x000F89C3 File Offset: 0x000F6BC3
		[CLSCompliant(false)]
		public static Vector128<UIntPtr> Create(Vector64<UIntPtr> lower, Vector64<UIntPtr> upper)
		{
			return Vector128.Create<UIntPtr>(lower, upper);
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x000F89CC File Offset: 0x000F6BCC
		[CLSCompliant(false)]
		public static Vector128<sbyte> Create(Vector64<sbyte> lower, Vector64<sbyte> upper)
		{
			return Vector128.Create<sbyte>(lower, upper);
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x000F89D5 File Offset: 0x000F6BD5
		public static Vector128<float> Create(Vector64<float> lower, Vector64<float> upper)
		{
			return Vector128.Create<float>(lower, upper);
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x000F89DE File Offset: 0x000F6BDE
		[CLSCompliant(false)]
		public static Vector128<ushort> Create(Vector64<ushort> lower, Vector64<ushort> upper)
		{
			return Vector128.Create<ushort>(lower, upper);
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x000F89E7 File Offset: 0x000F6BE7
		[CLSCompliant(false)]
		public static Vector128<uint> Create(Vector64<uint> lower, Vector64<uint> upper)
		{
			return Vector128.Create<uint>(lower, upper);
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x000F89F0 File Offset: 0x000F6BF0
		[CLSCompliant(false)]
		public static Vector128<ulong> Create(Vector64<ulong> lower, Vector64<ulong> upper)
		{
			return Vector128.Create<ulong>(lower, upper);
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x000F89F9 File Offset: 0x000F6BF9
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> CreateScalar<[Nullable(2)] T>(T value)
		{
			return Vector64.CreateScalar<T>(value).ToVector128<T>();
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x000F8A06 File Offset: 0x000F6C06
		[Intrinsic]
		public static Vector128<byte> CreateScalar(byte value)
		{
			return Vector128.CreateScalar<byte>(value);
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x000F8A0E File Offset: 0x000F6C0E
		[Intrinsic]
		public static Vector128<double> CreateScalar(double value)
		{
			return Vector128.CreateScalar<double>(value);
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x000F8A16 File Offset: 0x000F6C16
		[Intrinsic]
		public static Vector128<short> CreateScalar(short value)
		{
			return Vector128.CreateScalar<short>(value);
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x000F8A1E File Offset: 0x000F6C1E
		[Intrinsic]
		public static Vector128<int> CreateScalar(int value)
		{
			return Vector128.CreateScalar<int>(value);
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x000F8A26 File Offset: 0x000F6C26
		[Intrinsic]
		public static Vector128<long> CreateScalar(long value)
		{
			return Vector128.CreateScalar<long>(value);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x000F8A2E File Offset: 0x000F6C2E
		[Intrinsic]
		public static Vector128<IntPtr> CreateScalar(IntPtr value)
		{
			return Vector128.CreateScalar<IntPtr>(value);
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x000F8A36 File Offset: 0x000F6C36
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<UIntPtr> CreateScalar(UIntPtr value)
		{
			return Vector128.CreateScalar<UIntPtr>(value);
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x000F8A3E File Offset: 0x000F6C3E
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<sbyte> CreateScalar(sbyte value)
		{
			return Vector128.CreateScalar<sbyte>(value);
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x000F8A46 File Offset: 0x000F6C46
		[Intrinsic]
		public static Vector128<float> CreateScalar(float value)
		{
			return Vector128.CreateScalar<float>(value);
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x000F8A4E File Offset: 0x000F6C4E
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ushort> CreateScalar(ushort value)
		{
			return Vector128.CreateScalar<ushort>(value);
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x000F8A56 File Offset: 0x000F6C56
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<uint> CreateScalar(uint value)
		{
			return Vector128.CreateScalar<uint>(value);
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x000F8A5E File Offset: 0x000F6C5E
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ulong> CreateScalar(ulong value)
		{
			return Vector128.CreateScalar<ulong>(value);
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x000F8A68 File Offset: 0x000F6C68
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> CreateScalarUnsafe<[Nullable(2)] T>(T value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			Vector128<T> result;
			Unsafe.SkipInit<Vector128<T>>(out result);
			result.SetElementUnsafe(0, value);
			return result;
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x000F8A8B File Offset: 0x000F6C8B
		[Intrinsic]
		public static Vector128<byte> CreateScalarUnsafe(byte value)
		{
			return Vector128.CreateScalarUnsafe<byte>(value);
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x000F8A93 File Offset: 0x000F6C93
		[Intrinsic]
		public static Vector128<double> CreateScalarUnsafe(double value)
		{
			return Vector128.CreateScalarUnsafe<double>(value);
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x000F8A9B File Offset: 0x000F6C9B
		[Intrinsic]
		public static Vector128<short> CreateScalarUnsafe(short value)
		{
			return Vector128.CreateScalarUnsafe<short>(value);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x000F8AA3 File Offset: 0x000F6CA3
		[Intrinsic]
		public static Vector128<int> CreateScalarUnsafe(int value)
		{
			return Vector128.CreateScalarUnsafe<int>(value);
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x000F8AAB File Offset: 0x000F6CAB
		[Intrinsic]
		public static Vector128<long> CreateScalarUnsafe(long value)
		{
			return Vector128.CreateScalarUnsafe<long>(value);
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x000F8AB3 File Offset: 0x000F6CB3
		[Intrinsic]
		public static Vector128<IntPtr> CreateScalarUnsafe(IntPtr value)
		{
			return Vector128.CreateScalarUnsafe<IntPtr>(value);
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x000F8ABB File Offset: 0x000F6CBB
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<UIntPtr> CreateScalarUnsafe(UIntPtr value)
		{
			return Vector128.CreateScalarUnsafe<UIntPtr>(value);
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x000F8AC3 File Offset: 0x000F6CC3
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<sbyte> CreateScalarUnsafe(sbyte value)
		{
			return Vector128.CreateScalarUnsafe<sbyte>(value);
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x000F8ACB File Offset: 0x000F6CCB
		[Intrinsic]
		public static Vector128<float> CreateScalarUnsafe(float value)
		{
			return Vector128.CreateScalarUnsafe<float>(value);
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x000F8AD3 File Offset: 0x000F6CD3
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ushort> CreateScalarUnsafe(ushort value)
		{
			return Vector128.CreateScalarUnsafe<ushort>(value);
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x000F8ADB File Offset: 0x000F6CDB
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<uint> CreateScalarUnsafe(uint value)
		{
			return Vector128.CreateScalarUnsafe<uint>(value);
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x000F8AE3 File Offset: 0x000F6CE3
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ulong> CreateScalarUnsafe(ulong value)
		{
			return Vector128.CreateScalarUnsafe<ulong>(value);
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x000F8AEB File Offset: 0x000F6CEB
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> CreateSequence<[Nullable(2)] T>(T start, T step)
		{
			return Vector128<T>.Indices * step + Vector128.Create<T>(start);
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x000F8B03 File Offset: 0x000F6D03
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> DegreesToRadians(Vector128<double> degrees)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.DegreesToRadians<Vector128<double>, double>(degrees);
			}
			return Vector128.Create(Vector64.DegreesToRadians(degrees._lower), Vector64.DegreesToRadians(degrees._upper));
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x000F8B2E File Offset: 0x000F6D2E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> DegreesToRadians(Vector128<float> degrees)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.DegreesToRadians<Vector128<float>, float>(degrees);
			}
			return Vector128.Create(Vector64.DegreesToRadians(degrees._lower), Vector64.DegreesToRadians(degrees._upper));
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x000F8B59 File Offset: 0x000F6D59
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Divide<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return left / right;
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x000F8B62 File Offset: 0x000F6D62
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Divide<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, T right)
		{
			return left / right;
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x000F8B6B File Offset: 0x000F6D6B
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Dot<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Sum<T>(left * right);
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x000F8B79 File Offset: 0x000F6D79
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Equals<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(Vector64.Equals<T>(left._lower, right._lower), Vector64.Equals<T>(left._upper, right._upper));
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x000F8BA2 File Offset: 0x000F6DA2
		[NullableContext(2)]
		[Intrinsic]
		public static bool EqualsAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return left == right;
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x000F8BAB File Offset: 0x000F6DAB
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool EqualsAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector64.EqualsAny<T>(left._lower, right._lower) || Vector64.EqualsAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x000F8BD3 File Offset: 0x000F6DD3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> Exp(Vector128<double> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.ExpDouble<Vector128<double>, Vector128<ulong>>(vector);
			}
			return Vector128.Create(Vector64.Exp(vector._lower), Vector64.Exp(vector._upper));
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x000F8BFE File Offset: 0x000F6DFE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> Exp(Vector128<float> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				if (false)
				{
				}
				return VectorMath.ExpSingle<Vector128<float>, Vector128<uint>, Vector128<double>, Vector128<ulong>>(vector);
			}
			return Vector128.Create(Vector64.Exp(vector._lower), Vector64.Exp(vector._upper));
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x000F8C2C File Offset: 0x000F6E2C
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ExtractMostSignificantBits<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			return vector._lower.ExtractMostSignificantBits<T>() | vector._upper.ExtractMostSignificantBits<T>() << Vector64<T>.Count;
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x000F8C50 File Offset: 0x000F6E50
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<T> Floor<T>(Vector128<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector128.Create<T>(Vector64.Floor<T>(vector._lower), Vector64.Floor<T>(vector._upper));
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x000F8D97 File Offset: 0x000F6F97
		[Intrinsic]
		public static Vector128<float> Floor(Vector128<float> vector)
		{
			return Vector128.Floor<float>(vector);
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x000F8D9F File Offset: 0x000F6F9F
		[Intrinsic]
		public static Vector128<double> Floor(Vector128<double> vector)
		{
			return Vector128.Floor<double>(vector);
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x000F8DA7 File Offset: 0x000F6FA7
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> FusedMultiplyAdd(Vector128<double> left, Vector128<double> right, Vector128<double> addend)
		{
			return Vector128.Create(Vector64.FusedMultiplyAdd(left._lower, right._lower, addend._lower), Vector64.FusedMultiplyAdd(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004A84 RID: 19076 RVA: 0x000F8DDC File Offset: 0x000F6FDC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> FusedMultiplyAdd(Vector128<float> left, Vector128<float> right, Vector128<float> addend)
		{
			return Vector128.Create(Vector64.FusedMultiplyAdd(left._lower, right._lower, addend._lower), Vector64.FusedMultiplyAdd(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004A85 RID: 19077 RVA: 0x000F8E11 File Offset: 0x000F7011
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T GetElement<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector, int index)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			if (index >= Vector128<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			return vector.GetElementUnsafe(index);
		}

		// Token: 0x06004A86 RID: 19078 RVA: 0x000F8E2F File Offset: 0x000F702F
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> GetLower<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			return vector._lower;
		}

		// Token: 0x06004A87 RID: 19079 RVA: 0x000F8E3C File Offset: 0x000F703C
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> GetUpper<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			return vector._upper;
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x000F8E49 File Offset: 0x000F7049
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> GreaterThan<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(Vector64.GreaterThan<T>(left._lower, right._lower), Vector64.GreaterThan<T>(left._upper, right._upper));
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x000F8E72 File Offset: 0x000F7072
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector64.GreaterThanAll<T>(left._lower, right._lower) && Vector64.GreaterThanAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x000F8E9A File Offset: 0x000F709A
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector64.GreaterThanAny<T>(left._lower, right._lower) || Vector64.GreaterThanAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x000F8EC2 File Offset: 0x000F70C2
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> GreaterThanOrEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(Vector64.GreaterThanOrEqual<T>(left._lower, right._lower), Vector64.GreaterThanOrEqual<T>(left._upper, right._upper));
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x000F8EEB File Offset: 0x000F70EB
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanOrEqualAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector64.GreaterThanOrEqualAll<T>(left._lower, right._lower) && Vector64.GreaterThanOrEqualAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x000F8F13 File Offset: 0x000F7113
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GreaterThanOrEqualAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector64.GreaterThanOrEqualAny<T>(left._lower, right._lower) || Vector64.GreaterThanOrEqualAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x000F8F3B File Offset: 0x000F713B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> Hypot(Vector128<double> x, Vector128<double> y)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.HypotDouble<Vector128<double>, Vector128<ulong>>(x, y);
			}
			return Vector128.Create(Vector64.Hypot(x._lower, y._lower), Vector64.Hypot(x._upper, y._upper));
		}

		// Token: 0x06004A8F RID: 19087 RVA: 0x000F8F73 File Offset: 0x000F7173
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> Hypot(Vector128<float> x, Vector128<float> y)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				if (false)
				{
				}
				return VectorMath.HypotSingle<Vector128<float>, Vector128<double>>(x, y);
			}
			return Vector128.Create(Vector64.Hypot(x._lower, y._lower), Vector64.Hypot(x._upper, y._upper));
		}

		// Token: 0x06004A90 RID: 19088 RVA: 0x000F8FB0 File Offset: 0x000F71B0
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> IsNaN<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			if (typeof(T) == typeof(float) || typeof(T) == typeof(double))
			{
				return ~Vector128.Equals<T>(vector, vector);
			}
			return Vector128<T>.Zero;
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x000F9008 File Offset: 0x000F7208
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> IsNegative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return Vector128<T>.Zero;
			}
			if (typeof(T) == typeof(float))
			{
				return Vector128.LessThan<int>(vector.AsInt32<T>(), Vector128<int>.Zero).As<int, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return Vector128.LessThan<long>(vector.AsInt64<T>(), Vector128<long>.Zero).As<long, T>();
			}
			return Vector128.LessThan<T>(vector, Vector128<T>.Zero);
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x000F9110 File Offset: 0x000F7310
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> IsPositive<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr))
			{
				return Vector128<T>.AllBitsSet;
			}
			if (typeof(T) == typeof(float))
			{
				return Vector128.GreaterThanOrEqual<int>(vector.AsInt32<T>(), Vector128<int>.Zero).As<int, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return Vector128.GreaterThanOrEqual<long>(vector.AsInt64<T>(), Vector128<long>.Zero).As<long, T>();
			}
			return Vector128.GreaterThanOrEqual<T>(vector, Vector128<T>.Zero);
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x000F9218 File Offset: 0x000F7418
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> IsPositiveInfinity<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			if (typeof(T) == typeof(float))
			{
				return Vector128.Equals<T>(vector, Vector128.Create(float.PositiveInfinity).As<float, T>());
			}
			if (typeof(T) == typeof(double))
			{
				return Vector128.Equals<T>(vector, Vector128.Create(double.PositiveInfinity).As<double, T>());
			}
			return Vector128<T>.Zero;
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x000F9290 File Offset: 0x000F7490
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> IsZero<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			return Vector128.Equals<T>(vector, Vector128<T>.Zero);
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x000F92A0 File Offset: 0x000F74A0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> Lerp(Vector128<double> x, Vector128<double> y, Vector128<double> amount)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.Lerp<Vector128<double>, double>(x, y, amount);
			}
			return Vector128.Create(Vector64.Lerp(x._lower, y._lower, amount._lower), Vector64.Lerp(x._upper, y._upper, amount._upper));
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x000F92F0 File Offset: 0x000F74F0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> Lerp(Vector128<float> x, Vector128<float> y, Vector128<float> amount)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.Lerp<Vector128<float>, float>(x, y, amount);
			}
			return Vector128.Create(Vector64.Lerp(x._lower, y._lower, amount._lower), Vector64.Lerp(x._upper, y._upper, amount._upper));
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x000F9340 File Offset: 0x000F7540
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> LessThan<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(Vector64.LessThan<T>(left._lower, right._lower), Vector64.LessThan<T>(left._upper, right._upper));
		}

		// Token: 0x06004A98 RID: 19096 RVA: 0x000F9369 File Offset: 0x000F7569
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector64.LessThanAll<T>(left._lower, right._lower) && Vector64.LessThanAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004A99 RID: 19097 RVA: 0x000F9391 File Offset: 0x000F7591
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector64.LessThanAny<T>(left._lower, right._lower) || Vector64.LessThanAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x000F93B9 File Offset: 0x000F75B9
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> LessThanOrEqual<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(Vector64.LessThanOrEqual<T>(left._lower, right._lower), Vector64.LessThanOrEqual<T>(left._upper, right._upper));
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x000F93E2 File Offset: 0x000F75E2
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanOrEqualAll<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector64.LessThanOrEqualAll<T>(left._lower, right._lower) && Vector64.LessThanOrEqualAll<T>(left._upper, right._upper);
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x000F940A File Offset: 0x000F760A
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool LessThanOrEqualAny<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector64.LessThanOrEqualAny<T>(left._lower, right._lower) || Vector64.LessThanOrEqualAny<T>(left._upper, right._upper);
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x000F9432 File Offset: 0x000F7632
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector128<T> Load<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			return Vector128.LoadUnsafe<T>(ref *source);
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x000F943A File Offset: 0x000F763A
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector128<T> LoadAligned<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			if (source % 16 != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			return *(Vector128<T>*)source;
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x000F9453 File Offset: 0x000F7653
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector128<T> LoadAlignedNonTemporal<T>([Nullable(new byte[]
		{
			0,
			1
		})] T* source)
		{
			return Vector128.LoadAligned<T>(source);
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x000F945B File Offset: 0x000F765B
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> LoadUnsafe<[Nullable(2)] T>([RequiresLocation] [In] ref T source)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			return Unsafe.ReadUnaligned<Vector128<T>>(Unsafe.As<T, byte>(Unsafe.AsRef<T>(ref source)));
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x000F9472 File Offset: 0x000F7672
		[NullableContext(1)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> LoadUnsafe<[Nullable(2)] T>([RequiresLocation] [In] ref T source, UIntPtr elementOffset)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			return Unsafe.ReadUnaligned<Vector128<T>>(Unsafe.As<T, byte>(Unsafe.Add<T>(Unsafe.AsRef<T>(ref source), (IntPtr)elementOffset)));
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x000F948F File Offset: 0x000F768F
		internal static Vector128<ushort> LoadUnsafe(ref char source)
		{
			return Vector128.LoadUnsafe<ushort>(Unsafe.As<char, ushort>(ref source));
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x000F949C File Offset: 0x000F769C
		internal static Vector128<ushort> LoadUnsafe(ref char source, UIntPtr elementOffset)
		{
			return Vector128.LoadUnsafe<ushort>(Unsafe.As<char, ushort>(ref source), elementOffset);
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x000F94AA File Offset: 0x000F76AA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> Log(Vector128<double> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.LogDouble<Vector128<double>, Vector128<long>, Vector128<ulong>>(vector);
			}
			return Vector128.Create(Vector64.Log(vector._lower), Vector64.Log(vector._upper));
		}

		// Token: 0x06004AA5 RID: 19109 RVA: 0x000F94D5 File Offset: 0x000F76D5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> Log(Vector128<float> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.LogSingle<Vector128<float>, Vector128<int>, Vector128<uint>>(vector);
			}
			return Vector128.Create(Vector64.Log(vector._lower), Vector64.Log(vector._upper));
		}

		// Token: 0x06004AA6 RID: 19110 RVA: 0x000F9500 File Offset: 0x000F7700
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> Log2(Vector128<double> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.Log2Double<Vector128<double>, Vector128<long>, Vector128<ulong>>(vector);
			}
			return Vector128.Create(Vector64.Log2(vector._lower), Vector64.Log2(vector._upper));
		}

		// Token: 0x06004AA7 RID: 19111 RVA: 0x000F952B File Offset: 0x000F772B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> Log2(Vector128<float> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.Log2Single<Vector128<float>, Vector128<int>, Vector128<uint>>(vector);
			}
			return Vector128.Create(Vector64.Log2(vector._lower), Vector64.Log2(vector._upper));
		}

		// Token: 0x06004AA8 RID: 19112 RVA: 0x000F9556 File Offset: 0x000F7756
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Max<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.Max<Vector128<T>, T>(left, right);
			}
			return Vector128.Create<T>(Vector64.Max<T>(left._lower, right._lower), Vector64.Max<T>(left._upper, right._upper));
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x000F958E File Offset: 0x000F778E
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> MaxMagnitude<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.MaxMagnitude<Vector128<T>, T>(left, right);
			}
			return Vector128.Create<T>(Vector64.MaxMagnitude<T>(left._lower, right._lower), Vector64.MaxMagnitude<T>(left._upper, right._upper));
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x000F95C6 File Offset: 0x000F77C6
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> MaxMagnitudeNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.MaxMagnitudeNumber<Vector128<T>, T>(left, right);
			}
			return Vector128.Create<T>(Vector64.MaxMagnitudeNumber<T>(left._lower, right._lower), Vector64.MaxMagnitudeNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x000F95FE File Offset: 0x000F77FE
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> MaxNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return Vector128.ConditionalSelect<T>(Vector128.GreaterThan<T>(left, right), left, right);
			}
			return Vector128.Create<T>(Vector64.MaxNative<T>(left._lower, right._lower), Vector64.MaxNative<T>(left._upper, right._upper));
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x000F963D File Offset: 0x000F783D
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> MaxNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.MaxNumber<Vector128<T>, T>(left, right);
			}
			return Vector128.Create<T>(Vector64.MaxNumber<T>(left._lower, right._lower), Vector64.MaxNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x000F9675 File Offset: 0x000F7875
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Min<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.Min<Vector128<T>, T>(left, right);
			}
			return Vector128.Create<T>(Vector64.Min<T>(left._lower, right._lower), Vector64.Min<T>(left._upper, right._upper));
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x000F96AD File Offset: 0x000F78AD
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> MinMagnitude<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.MinMagnitude<Vector128<T>, T>(left, right);
			}
			return Vector128.Create<T>(Vector64.MinMagnitude<T>(left._lower, right._lower), Vector64.MinMagnitude<T>(left._upper, right._upper));
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x000F96E5 File Offset: 0x000F78E5
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> MinMagnitudeNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.MinMagnitudeNumber<Vector128<T>, T>(left, right);
			}
			return Vector128.Create<T>(Vector64.MinMagnitudeNumber<T>(left._lower, right._lower), Vector64.MinMagnitudeNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x000F971D File Offset: 0x000F791D
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> MinNative<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return Vector128.ConditionalSelect<T>(Vector128.LessThan<T>(left, right), left, right);
			}
			return Vector128.Create<T>(Vector64.MinNative<T>(left._lower, right._lower), Vector64.MinNative<T>(left._upper, right._upper));
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x000F975C File Offset: 0x000F795C
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> MinNumber<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.MinNumber<Vector128<T>, T>(left, right);
			}
			return Vector128.Create<T>(Vector64.MinNumber<T>(left._lower, right._lower), Vector64.MinNumber<T>(left._upper, right._upper));
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x000F9794 File Offset: 0x000F7994
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Multiply<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return left * right;
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x000F979D File Offset: 0x000F799D
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Multiply<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, T right)
		{
			return left * right;
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x000F97A6 File Offset: 0x000F79A6
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Multiply<[Nullable(2)] T>(T left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return right * left;
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x000F97AF File Offset: 0x000F79AF
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<T> MultiplyAddEstimate<T>(Vector128<T> left, Vector128<T> right, Vector128<T> addend)
		{
			return Vector128.Create<T>(Vector64.MultiplyAddEstimate<T>(left._lower, right._lower, addend._lower), Vector64.MultiplyAddEstimate<T>(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x000F97E4 File Offset: 0x000F79E4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> MultiplyAddEstimate(Vector128<double> left, Vector128<double> right, Vector128<double> addend)
		{
			return Vector128.Create(Vector64.MultiplyAddEstimate(left._lower, right._lower, addend._lower), Vector64.MultiplyAddEstimate(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x000F9819 File Offset: 0x000F7A19
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> MultiplyAddEstimate(Vector128<float> left, Vector128<float> right, Vector128<float> addend)
		{
			return Vector128.Create(Vector64.MultiplyAddEstimate(left._lower, right._lower, addend._lower), Vector64.MultiplyAddEstimate(left._upper, right._upper, addend._upper));
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x000F984E File Offset: 0x000F7A4E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> Narrow(Vector128<double> lower, Vector128<double> upper)
		{
			return Vector128.Create(Vector64.Narrow(lower._lower, lower._upper), Vector64.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x000F9877 File Offset: 0x000F7A77
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<sbyte> Narrow(Vector128<short> lower, Vector128<short> upper)
		{
			return Vector128.Create(Vector64.Narrow(lower._lower, lower._upper), Vector64.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x000F98A0 File Offset: 0x000F7AA0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<short> Narrow(Vector128<int> lower, Vector128<int> upper)
		{
			return Vector128.Create(Vector64.Narrow(lower._lower, lower._upper), Vector64.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x000F98C9 File Offset: 0x000F7AC9
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<int> Narrow(Vector128<long> lower, Vector128<long> upper)
		{
			return Vector128.Create(Vector64.Narrow(lower._lower, lower._upper), Vector64.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004ABC RID: 19132 RVA: 0x000F98F2 File Offset: 0x000F7AF2
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<byte> Narrow(Vector128<ushort> lower, Vector128<ushort> upper)
		{
			return Vector128.Create(Vector64.Narrow(lower._lower, lower._upper), Vector64.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004ABD RID: 19133 RVA: 0x000F991B File Offset: 0x000F7B1B
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<ushort> Narrow(Vector128<uint> lower, Vector128<uint> upper)
		{
			return Vector128.Create(Vector64.Narrow(lower._lower, lower._upper), Vector64.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x000F9944 File Offset: 0x000F7B44
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<uint> Narrow(Vector128<ulong> lower, Vector128<ulong> upper)
		{
			return Vector128.Create(Vector64.Narrow(lower._lower, lower._upper), Vector64.Narrow(upper._lower, upper._upper));
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x000F996D File Offset: 0x000F7B6D
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Negate<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			return -vector;
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x000F9975 File Offset: 0x000F7B75
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> OnesComplement<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			return ~vector;
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x000F997D File Offset: 0x000F7B7D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> RadiansToDegrees(Vector128<double> radians)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.RadiansToDegrees<Vector128<double>, double>(radians);
			}
			return Vector128.Create(Vector64.RadiansToDegrees(radians._lower), Vector64.RadiansToDegrees(radians._upper));
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x000F99A8 File Offset: 0x000F7BA8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> RadiansToDegrees(Vector128<float> radians)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.RadiansToDegrees<Vector128<float>, float>(radians);
			}
			return Vector128.Create(Vector64.RadiansToDegrees(radians._lower), Vector64.RadiansToDegrees(radians._upper));
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x000F99D4 File Offset: 0x000F7BD4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<T> Round<T>(Vector128<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector128.Create<T>(Vector64.Round<T>(vector._lower), Vector64.Round<T>(vector._upper));
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x000F9B1B File Offset: 0x000F7D1B
		[Intrinsic]
		public static Vector128<double> Round(Vector128<double> vector)
		{
			return Vector128.Round<double>(vector);
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x000F9B23 File Offset: 0x000F7D23
		[Intrinsic]
		public static Vector128<float> Round(Vector128<float> vector)
		{
			return Vector128.Round<float>(vector);
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x000F9B2B File Offset: 0x000F7D2B
		[Intrinsic]
		public static Vector128<double> Round(Vector128<double> vector, MidpointRounding mode)
		{
			return VectorMath.RoundDouble<Vector128<double>>(vector, mode);
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x000F9B34 File Offset: 0x000F7D34
		[Intrinsic]
		public static Vector128<float> Round(Vector128<float> vector, MidpointRounding mode)
		{
			return VectorMath.RoundSingle<Vector128<float>>(vector, mode);
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x000F9B3D File Offset: 0x000F7D3D
		[Intrinsic]
		public static Vector128<byte> ShiftLeft(Vector128<byte> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x000F9B46 File Offset: 0x000F7D46
		[Intrinsic]
		public static Vector128<short> ShiftLeft(Vector128<short> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x000F9B4F File Offset: 0x000F7D4F
		[Intrinsic]
		public static Vector128<int> ShiftLeft(Vector128<int> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x000F9B58 File Offset: 0x000F7D58
		[Intrinsic]
		public static Vector128<long> ShiftLeft(Vector128<long> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x000F9B61 File Offset: 0x000F7D61
		[Intrinsic]
		public static Vector128<IntPtr> ShiftLeft(Vector128<IntPtr> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x000F9B6A File Offset: 0x000F7D6A
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<UIntPtr> ShiftLeft(Vector128<UIntPtr> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x000F9B73 File Offset: 0x000F7D73
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<sbyte> ShiftLeft(Vector128<sbyte> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x000F9B7C File Offset: 0x000F7D7C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ushort> ShiftLeft(Vector128<ushort> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x000F9B85 File Offset: 0x000F7D85
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<uint> ShiftLeft(Vector128<uint> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x000F9B8E File Offset: 0x000F7D8E
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ulong> ShiftLeft(Vector128<ulong> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x000F9B97 File Offset: 0x000F7D97
		[Intrinsic]
		public static Vector128<short> ShiftRightArithmetic(Vector128<short> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x000F9BA0 File Offset: 0x000F7DA0
		[Intrinsic]
		public static Vector128<int> ShiftRightArithmetic(Vector128<int> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x000F9BA9 File Offset: 0x000F7DA9
		[Intrinsic]
		public static Vector128<long> ShiftRightArithmetic(Vector128<long> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x000F9BB2 File Offset: 0x000F7DB2
		[Intrinsic]
		public static Vector128<IntPtr> ShiftRightArithmetic(Vector128<IntPtr> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x000F9BBB File Offset: 0x000F7DBB
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x000F9BC4 File Offset: 0x000F7DC4
		[Intrinsic]
		public static Vector128<byte> ShiftRightLogical(Vector128<byte> vector, int shiftCount)
		{
			return Vector128<byte>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x000F9BCD File Offset: 0x000F7DCD
		[Intrinsic]
		public static Vector128<short> ShiftRightLogical(Vector128<short> vector, int shiftCount)
		{
			return Vector128<short>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x000F9BD6 File Offset: 0x000F7DD6
		[Intrinsic]
		public static Vector128<int> ShiftRightLogical(Vector128<int> vector, int shiftCount)
		{
			return Vector128<int>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x000F9BDF File Offset: 0x000F7DDF
		[Intrinsic]
		public static Vector128<long> ShiftRightLogical(Vector128<long> vector, int shiftCount)
		{
			return Vector128<long>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x000F9BE8 File Offset: 0x000F7DE8
		[Intrinsic]
		public static Vector128<IntPtr> ShiftRightLogical(Vector128<IntPtr> vector, int shiftCount)
		{
			return Vector128<IntPtr>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x000F9BF1 File Offset: 0x000F7DF1
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<UIntPtr> ShiftRightLogical(Vector128<UIntPtr> vector, int shiftCount)
		{
			return Vector128<UIntPtr>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x000F9BFA File Offset: 0x000F7DFA
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> vector, int shiftCount)
		{
			return Vector128<sbyte>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x000F9C03 File Offset: 0x000F7E03
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> vector, int shiftCount)
		{
			return Vector128<ushort>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x000F9C0C File Offset: 0x000F7E0C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<uint> ShiftRightLogical(Vector128<uint> vector, int shiftCount)
		{
			return Vector128<uint>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x000F9C15 File Offset: 0x000F7E15
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> vector, int shiftCount)
		{
			return Vector128<ulong>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x000F9C20 File Offset: 0x000F7E20
		[Intrinsic]
		public static Vector128<byte> Shuffle(Vector128<byte> vector, Vector128<byte> indices)
		{
			Vector128<byte> result;
			Unsafe.SkipInit<Vector128<byte>>(out result);
			for (int i = 0; i < Vector128<byte>.Count; i++)
			{
				byte elementUnsafe = indices.GetElementUnsafe(i);
				byte value = 0;
				if ((int)elementUnsafe < Vector128<byte>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x000F9C6C File Offset: 0x000F7E6C
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<sbyte> Shuffle(Vector128<sbyte> vector, Vector128<sbyte> indices)
		{
			Vector128<sbyte> result;
			Unsafe.SkipInit<Vector128<sbyte>>(out result);
			for (int i = 0; i < Vector128<sbyte>.Count; i++)
			{
				byte b = (byte)indices.GetElementUnsafe(i);
				sbyte value = 0;
				if ((int)b < Vector128<sbyte>.Count)
				{
					value = vector.GetElementUnsafe((int)b);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x000F9CB7 File Offset: 0x000F7EB7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<byte> ShuffleUnsafe(Vector128<byte> vector, Vector128<byte> indices)
		{
			if (Ssse3.IsSupported)
			{
				return Ssse3.Shuffle(vector, indices);
			}
			if (false)
			{
			}
			if (false)
			{
			}
			return Vector128.Shuffle(vector, indices);
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x000F9CD8 File Offset: 0x000F7ED8
		[Intrinsic]
		public static Vector128<short> Shuffle(Vector128<short> vector, Vector128<short> indices)
		{
			Vector128<short> result;
			Unsafe.SkipInit<Vector128<short>>(out result);
			for (int i = 0; i < Vector128<short>.Count; i++)
			{
				ushort num = (ushort)indices.GetElementUnsafe(i);
				short value = 0;
				if ((int)num < Vector128<short>.Count)
				{
					value = vector.GetElementUnsafe((int)num);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x000F9D24 File Offset: 0x000F7F24
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ushort> Shuffle(Vector128<ushort> vector, Vector128<ushort> indices)
		{
			Vector128<ushort> result;
			Unsafe.SkipInit<Vector128<ushort>>(out result);
			for (int i = 0; i < Vector128<ushort>.Count; i++)
			{
				ushort elementUnsafe = indices.GetElementUnsafe(i);
				ushort value = 0;
				if ((int)elementUnsafe < Vector128<ushort>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x000F9D70 File Offset: 0x000F7F70
		[Intrinsic]
		public static Vector128<int> Shuffle(Vector128<int> vector, Vector128<int> indices)
		{
			Vector128<int> result;
			Unsafe.SkipInit<Vector128<int>>(out result);
			for (int i = 0; i < Vector128<int>.Count; i++)
			{
				uint elementUnsafe = (uint)indices.GetElementUnsafe(i);
				int value = 0;
				if ((ulong)elementUnsafe < (ulong)((long)Vector128<int>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x000F9DBC File Offset: 0x000F7FBC
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<uint> Shuffle(Vector128<uint> vector, Vector128<uint> indices)
		{
			Vector128<uint> result;
			Unsafe.SkipInit<Vector128<uint>>(out result);
			for (int i = 0; i < Vector128<uint>.Count; i++)
			{
				uint elementUnsafe = indices.GetElementUnsafe(i);
				uint value = 0U;
				if ((ulong)elementUnsafe < (ulong)((long)Vector128<uint>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x000F9E08 File Offset: 0x000F8008
		[Intrinsic]
		public static Vector128<float> Shuffle(Vector128<float> vector, Vector128<int> indices)
		{
			Vector128<float> result;
			Unsafe.SkipInit<Vector128<float>>(out result);
			for (int i = 0; i < Vector128<float>.Count; i++)
			{
				uint elementUnsafe = (uint)indices.GetElementUnsafe(i);
				float value = 0f;
				if ((ulong)elementUnsafe < (ulong)((long)Vector128<float>.Count))
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x000F9E58 File Offset: 0x000F8058
		[Intrinsic]
		public static Vector128<long> Shuffle(Vector128<long> vector, Vector128<long> indices)
		{
			Vector128<long> result;
			Unsafe.SkipInit<Vector128<long>>(out result);
			for (int i = 0; i < Vector128<long>.Count; i++)
			{
				ulong elementUnsafe = (ulong)indices.GetElementUnsafe(i);
				long value = 0L;
				if (elementUnsafe < (ulong)Vector128<long>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x000F9EA8 File Offset: 0x000F80A8
		[Intrinsic]
		[CLSCompliant(false)]
		public static Vector128<ulong> Shuffle(Vector128<ulong> vector, Vector128<ulong> indices)
		{
			Vector128<ulong> result;
			Unsafe.SkipInit<Vector128<ulong>>(out result);
			for (int i = 0; i < Vector128<ulong>.Count; i++)
			{
				ulong elementUnsafe = indices.GetElementUnsafe(i);
				ulong value = 0UL;
				if (elementUnsafe < (ulong)Vector128<ulong>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x000F9EF8 File Offset: 0x000F80F8
		[Intrinsic]
		public static Vector128<double> Shuffle(Vector128<double> vector, Vector128<long> indices)
		{
			Vector128<double> result;
			Unsafe.SkipInit<Vector128<double>>(out result);
			for (int i = 0; i < Vector128<double>.Count; i++)
			{
				ulong elementUnsafe = (ulong)indices.GetElementUnsafe(i);
				double value = 0.0;
				if (elementUnsafe < (ulong)Vector128<double>.Count)
				{
					value = vector.GetElementUnsafe((int)elementUnsafe);
				}
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x000F9F4C File Offset: 0x000F814C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> Sin(Vector128<double> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.SinDouble<Vector128<double>, Vector128<long>>(vector);
			}
			return Vector128.Create(Vector64.Sin(vector._lower), Vector64.Sin(vector._upper));
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x000F9F77 File Offset: 0x000F8177
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<float> Sin(Vector128<float> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				if (false)
				{
				}
				return VectorMath.SinSingle<Vector128<float>, Vector128<int>, Vector128<double>, Vector128<long>>(vector);
			}
			return Vector128.Create(Vector64.Sin(vector._lower), Vector64.Sin(vector._upper));
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x000F9FA8 File Offset: 0x000F81A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector128<double>, Vector128<double>> SinCos(Vector128<double> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return VectorMath.SinCosDouble<Vector128<double>, Vector128<long>>(vector);
			}
			ValueTuple<Vector64<double>, Vector64<double>> valueTuple = Vector64.SinCos(vector._lower);
			Vector64<double> item = valueTuple.Item1;
			Vector64<double> item2 = valueTuple.Item2;
			ValueTuple<Vector64<double>, Vector64<double>> valueTuple2 = Vector64.SinCos(vector._upper);
			Vector64<double> item3 = valueTuple2.Item1;
			Vector64<double> item4 = valueTuple2.Item2;
			return new ValueTuple<Vector128<double>, Vector128<double>>(Vector128.Create(item, item3), Vector128.Create(item2, item4));
		}

		// Token: 0x06004AEF RID: 19183 RVA: 0x000FA008 File Offset: 0x000F8208
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector128<float>, Vector128<float>> SinCos(Vector128<float> vector)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				if (false)
				{
				}
				return VectorMath.SinCosSingle<Vector128<float>, Vector128<int>, Vector128<double>, Vector128<long>>(vector);
			}
			ValueTuple<Vector64<float>, Vector64<float>> valueTuple = Vector64.SinCos(vector._lower);
			Vector64<float> item = valueTuple.Item1;
			Vector64<float> item2 = valueTuple.Item2;
			ValueTuple<Vector64<float>, Vector64<float>> valueTuple2 = Vector64.SinCos(vector._upper);
			Vector64<float> item3 = valueTuple2.Item1;
			Vector64<float> item4 = valueTuple2.Item2;
			return new ValueTuple<Vector128<float>, Vector128<float>>(Vector128.Create(item, item3), Vector128.Create(item2, item4));
		}

		// Token: 0x06004AF0 RID: 19184 RVA: 0x000FA069 File Offset: 0x000F8269
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Sqrt<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			return Vector128.Create<T>(Vector64.Sqrt<T>(vector._lower), Vector64.Sqrt<T>(vector._upper));
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x000FA086 File Offset: 0x000F8286
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		public unsafe static void Store<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			source.StoreUnsafe(ref *destination);
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x000FA08F File Offset: 0x000F828F
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void StoreAligned<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			if (destination % 16 != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			*(Vector128<T>*)destination = source;
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x000FA0A9 File Offset: 0x000F82A9
		[NullableContext(2)]
		[Intrinsic]
		[CLSCompliant(false)]
		public unsafe static void StoreAlignedNonTemporal<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> source, [Nullable(new byte[]
		{
			0,
			1
		})] T* destination)
		{
			source.StoreAligned(destination);
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x000FA0B2 File Offset: 0x000F82B2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void StoreLowerUnsafe<T>(this Vector128<T> source, ref T destination, UIntPtr elementOffset = 0)
		{
			Unsafe.WriteUnaligned<double>(Unsafe.As<T, byte>(Unsafe.Add<T>(ref destination, elementOffset)), source.AsDouble<T>().ToScalar<double>());
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x000FA0D0 File Offset: 0x000F82D0
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StoreUnsafe<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> source, ref T destination)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<T, byte>(ref destination), source);
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x000FA0E3 File Offset: 0x000F82E3
		[NullableContext(1)]
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StoreUnsafe<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> source, ref T destination, UIntPtr elementOffset)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			destination = Unsafe.Add<T>(ref destination, (IntPtr)elementOffset);
			Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<T, byte>(ref destination), source);
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x000FA0FF File Offset: 0x000F82FF
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Subtract<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return left - right;
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x000FA108 File Offset: 0x000F8308
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static T Sum<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			return Scalar<T>.Add(Vector64.Sum<T>(vector._lower), Vector64.Sum<T>(vector._upper));
		}

		// Token: 0x06004AF9 RID: 19193 RVA: 0x000FA125 File Offset: 0x000F8325
		[NullableContext(1)]
		[Intrinsic]
		public static T ToScalar<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			return vector.GetElementUnsafe(0);
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x000FA134 File Offset: 0x000F8334
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> ToVector256<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			Vector256<T> result = default(Vector256<T>);
			result.SetLowerUnsafe(vector);
			return result;
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x000FA158 File Offset: 0x000F8358
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> ToVector256Unsafe<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			Vector256<T> result;
			Unsafe.SkipInit<Vector256<T>>(out result);
			result.SetLowerUnsafe(vector);
			return result;
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x000FA17C File Offset: 0x000F837C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<T> Truncate<T>(Vector128<T> vector)
		{
			if (typeof(T) == typeof(byte) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
			{
				return vector;
			}
			return Vector128.Create<T>(Vector64.Truncate<T>(vector._lower), Vector64.Truncate<T>(vector._upper));
		}

		// Token: 0x06004AFD RID: 19197 RVA: 0x000FA2C3 File Offset: 0x000F84C3
		[Intrinsic]
		public static Vector128<double> Truncate(Vector128<double> vector)
		{
			return Vector128.Truncate<double>(vector);
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x000FA2CB File Offset: 0x000F84CB
		[Intrinsic]
		public static Vector128<float> Truncate(Vector128<float> vector)
		{
			return Vector128.Truncate<float>(vector);
		}

		// Token: 0x06004AFF RID: 19199 RVA: 0x000FA2D3 File Offset: 0x000F84D3
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryCopyTo<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (destination.Length < Vector128<T>.Count)
			{
				return false;
			}
			Unsafe.WriteUnaligned<Vector128<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(destination)), vector);
			return true;
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x000FA2F7 File Offset: 0x000F84F7
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector128<ushort>, Vector128<ushort>> Widen(Vector128<byte> source)
		{
			return new ValueTuple<Vector128<ushort>, Vector128<ushort>>(Vector128.WidenLower(source), Vector128.WidenUpper(source));
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x000FA30A File Offset: 0x000F850A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector128<int>, Vector128<int>> Widen(Vector128<short> source)
		{
			return new ValueTuple<Vector128<int>, Vector128<int>>(Vector128.WidenLower(source), Vector128.WidenUpper(source));
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x000FA31D File Offset: 0x000F851D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector128<long>, Vector128<long>> Widen(Vector128<int> source)
		{
			return new ValueTuple<Vector128<long>, Vector128<long>>(Vector128.WidenLower(source), Vector128.WidenUpper(source));
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x000FA330 File Offset: 0x000F8530
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector128<short>, Vector128<short>> Widen(Vector128<sbyte> source)
		{
			return new ValueTuple<Vector128<short>, Vector128<short>>(Vector128.WidenLower(source), Vector128.WidenUpper(source));
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x000FA343 File Offset: 0x000F8543
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector128<double>, Vector128<double>> Widen(Vector128<float> source)
		{
			return new ValueTuple<Vector128<double>, Vector128<double>>(Vector128.WidenLower(source), Vector128.WidenUpper(source));
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x000FA356 File Offset: 0x000F8556
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector128<uint>, Vector128<uint>> Widen(Vector128<ushort> source)
		{
			return new ValueTuple<Vector128<uint>, Vector128<uint>>(Vector128.WidenLower(source), Vector128.WidenUpper(source));
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x000FA369 File Offset: 0x000F8569
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		public static ValueTuple<Vector128<ulong>, Vector128<ulong>> Widen(Vector128<uint> source)
		{
			return new ValueTuple<Vector128<ulong>, Vector128<ulong>>(Vector128.WidenLower(source), Vector128.WidenUpper(source));
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x000FA37C File Offset: 0x000F857C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<ushort> WidenLower(Vector128<byte> source)
		{
			Vector64<byte> lower = source._lower;
			return Vector128.Create(Vector64.WidenLower(lower), Vector64.WidenUpper(lower));
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x000FA3A4 File Offset: 0x000F85A4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<int> WidenLower(Vector128<short> source)
		{
			Vector64<short> lower = source._lower;
			return Vector128.Create(Vector64.WidenLower(lower), Vector64.WidenUpper(lower));
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x000FA3CC File Offset: 0x000F85CC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<long> WidenLower(Vector128<int> source)
		{
			Vector64<int> lower = source._lower;
			return Vector128.Create(Vector64.WidenLower(lower), Vector64.WidenUpper(lower));
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x000FA3F4 File Offset: 0x000F85F4
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<short> WidenLower(Vector128<sbyte> source)
		{
			Vector64<sbyte> lower = source._lower;
			return Vector128.Create(Vector64.WidenLower(lower), Vector64.WidenUpper(lower));
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x000FA41C File Offset: 0x000F861C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> WidenLower(Vector128<float> source)
		{
			Vector64<float> lower = source._lower;
			return Vector128.Create(Vector64.WidenLower(lower), Vector64.WidenUpper(lower));
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x000FA444 File Offset: 0x000F8644
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<uint> WidenLower(Vector128<ushort> source)
		{
			Vector64<ushort> lower = source._lower;
			return Vector128.Create(Vector64.WidenLower(lower), Vector64.WidenUpper(lower));
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x000FA46C File Offset: 0x000F866C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<ulong> WidenLower(Vector128<uint> source)
		{
			Vector64<uint> lower = source._lower;
			return Vector128.Create(Vector64.WidenLower(lower), Vector64.WidenUpper(lower));
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x000FA494 File Offset: 0x000F8694
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<ushort> WidenUpper(Vector128<byte> source)
		{
			Vector64<byte> upper = source._upper;
			return Vector128.Create(Vector64.WidenLower(upper), Vector64.WidenUpper(upper));
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x000FA4BC File Offset: 0x000F86BC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<int> WidenUpper(Vector128<short> source)
		{
			Vector64<short> upper = source._upper;
			return Vector128.Create(Vector64.WidenLower(upper), Vector64.WidenUpper(upper));
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x000FA4E4 File Offset: 0x000F86E4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<long> WidenUpper(Vector128<int> source)
		{
			Vector64<int> upper = source._upper;
			return Vector128.Create(Vector64.WidenLower(upper), Vector64.WidenUpper(upper));
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x000FA50C File Offset: 0x000F870C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<short> WidenUpper(Vector128<sbyte> source)
		{
			Vector64<sbyte> upper = source._upper;
			return Vector128.Create(Vector64.WidenLower(upper), Vector64.WidenUpper(upper));
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x000FA534 File Offset: 0x000F8734
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<double> WidenUpper(Vector128<float> source)
		{
			Vector64<float> upper = source._upper;
			return Vector128.Create(Vector64.WidenLower(upper), Vector64.WidenUpper(upper));
		}

		// Token: 0x06004B13 RID: 19219 RVA: 0x000FA55C File Offset: 0x000F875C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<uint> WidenUpper(Vector128<ushort> source)
		{
			Vector64<ushort> upper = source._upper;
			return Vector128.Create(Vector64.WidenLower(upper), Vector64.WidenUpper(upper));
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x000FA584 File Offset: 0x000F8784
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector128<ulong> WidenUpper(Vector128<uint> source)
		{
			Vector64<uint> upper = source._upper;
			return Vector128.Create(Vector64.WidenLower(upper), Vector64.WidenUpper(upper));
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x000FA5AC File Offset: 0x000F87AC
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> WithElement<[Nullable(2)] T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector, int index, T value)
		{
			if (index >= Vector128<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
			}
			Vector128<T> result = vector;
			result.SetElementUnsafe(index, value);
			return result;
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x000FA5D4 File Offset: 0x000F87D4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> WithLower<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			Vector128<T> result = vector;
			result.SetLowerUnsafe(value);
			return result;
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x000FA5F4 File Offset: 0x000F87F4
		[NullableContext(2)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> WithUpper<T>([Nullable(new byte[]
		{
			0,
			1
		})] this Vector128<T> vector, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			Vector128<T> result = vector;
			result.SetUpperUnsafe(value);
			return result;
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x000FA611 File Offset: 0x000F8811
		[NullableContext(2)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Xor<T>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return left ^ right;
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x000FA61A File Offset: 0x000F881A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static T GetElementUnsafe<T>(this Vector128<T> vector, int index)
		{
			return *Unsafe.Add<T>(Unsafe.As<Vector128<T>, T>(Unsafe.AsRef<Vector128<T>>(ref vector)), index);
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x000FA632 File Offset: 0x000F8832
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void SetElementUnsafe<T>(this Vector128<T> vector, int index, T value)
		{
			*Unsafe.Add<T>(Unsafe.As<Vector128<T>, T>(Unsafe.AsRef<Vector128<T>>(ref vector)), index) = value;
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x000FA64B File Offset: 0x000F884B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void SetLowerUnsafe<T>(this Vector128<T> vector, Vector64<T> value)
		{
			*Unsafe.AsRef<Vector64<T>>(ref vector._lower) = value;
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x000FA65E File Offset: 0x000F885E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void SetUpperUnsafe<T>(this Vector128<T> vector, Vector64<T> value)
		{
			*Unsafe.AsRef<Vector64<T>>(ref vector._upper) = value;
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x000FA671 File Offset: 0x000F8871
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<byte> UnpackLow(Vector128<byte> left, Vector128<byte> right)
		{
			if (Sse2.IsSupported)
			{
				return Sse2.UnpackLow(left, right);
			}
			ThrowHelper.ThrowNotSupportedException();
			return AdvSimd.Arm64.ZipLow(left, right);
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x000FA690 File Offset: 0x000F8890
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<byte> UnpackHigh(Vector128<byte> left, Vector128<byte> right)
		{
			if (Sse2.IsSupported)
			{
				return Sse2.UnpackHigh(left, right);
			}
			ThrowHelper.ThrowNotSupportedException();
			return AdvSimd.Arm64.ZipHigh(left, right);
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x000FA6AF File Offset: 0x000F88AF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<byte> AddSaturate(Vector128<byte> left, Vector128<byte> right)
		{
			if (Sse2.IsSupported)
			{
				return Sse2.AddSaturate(left, right);
			}
			ThrowHelper.ThrowNotSupportedException();
			return AdvSimd.AddSaturate(left, right);
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x000FA6CE File Offset: 0x000F88CE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<byte> SubtractSaturate(Vector128<byte> left, Vector128<byte> right)
		{
			if (Sse2.IsSupported)
			{
				return Sse2.SubtractSaturate(left, right);
			}
			ThrowHelper.ThrowNotSupportedException();
			return AdvSimd.SubtractSaturate(left, right);
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x000FA6ED File Offset: 0x000F88ED
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<ushort> AddSaturate(Vector128<ushort> left, Vector128<ushort> right)
		{
			if (Sse2.IsSupported)
			{
				return Sse2.AddSaturate(left, right);
			}
			ThrowHelper.ThrowNotSupportedException();
			return AdvSimd.AddSaturate(left, right);
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x000FA70C File Offset: 0x000F890C
		[CompilerGenerated]
		internal static Vector128<float> <ConvertToSingle>g__SoftwareFallback|49_0(Vector128<uint> vector)
		{
			Vector128<float> result;
			Unsafe.SkipInit<Vector128<float>>(out result);
			for (int i = 0; i < Vector128<float>.Count; i++)
			{
				float value = vector.GetElementUnsafe(i);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}
	}
}
