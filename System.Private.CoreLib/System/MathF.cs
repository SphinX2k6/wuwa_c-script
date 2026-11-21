using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace System
{
	// Token: 0x0200008A RID: 138
	public static class MathF
	{
		// Token: 0x060004F0 RID: 1264
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Acos(float x);

		// Token: 0x060004F1 RID: 1265
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Acosh(float x);

		// Token: 0x060004F2 RID: 1266
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Asin(float x);

		// Token: 0x060004F3 RID: 1267
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Asinh(float x);

		// Token: 0x060004F4 RID: 1268
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Atan(float x);

		// Token: 0x060004F5 RID: 1269
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Atan2(float y, float x);

		// Token: 0x060004F6 RID: 1270
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Atanh(float x);

		// Token: 0x060004F7 RID: 1271
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Cbrt(float x);

		// Token: 0x060004F8 RID: 1272
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Ceiling(float x);

		// Token: 0x060004F9 RID: 1273
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Cos(float x);

		// Token: 0x060004FA RID: 1274
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Cosh(float x);

		// Token: 0x060004FB RID: 1275
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Exp(float x);

		// Token: 0x060004FC RID: 1276
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Floor(float x);

		// Token: 0x060004FD RID: 1277
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Log(float x);

		// Token: 0x060004FE RID: 1278
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Log10(float x);

		// Token: 0x060004FF RID: 1279
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Pow(float x, float y);

		// Token: 0x06000500 RID: 1280
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Sin(float x);

		// Token: 0x06000501 RID: 1281 RVA: 0x00010A81 File Offset: 0x0000EC81
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<float, float> SinCos(float x)
		{
			return new ValueTuple<float, float>(MathF.Sin(x), MathF.Cos(x));
		}

		// Token: 0x06000502 RID: 1282
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Sinh(float x);

		// Token: 0x06000503 RID: 1283
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Sqrt(float x);

		// Token: 0x06000504 RID: 1284
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Tan(float x);

		// Token: 0x06000505 RID: 1285
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Tanh(float x);

		// Token: 0x06000506 RID: 1286
		[Intrinsic]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FusedMultiplyAdd(float x, float y, float z);

		// Token: 0x06000507 RID: 1287
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Log2(float x);

		// Token: 0x06000508 RID: 1288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern float ModF(float x, float* intptr);

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00010A94 File Offset: 0x0000EC94
		private static ReadOnlySpan<float> RoundPower10Single
		{
			get
			{
				return RuntimeHelpers.CreateSpan<float>(fieldof(<PrivateImplementationDetails>.64A0AD5A7BF0B569FABE66AF3006423DA81FF79CD282E8D781CD013B1FD7D5CE4).FieldHandle);
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Abs(float x)
		{
			return Math.Abs(x);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00010AA8 File Offset: 0x0000ECA8
		public static float BitDecrement(float x)
		{
			uint num = BitConverter.SingleToUInt32Bits(x);
			if (!float.IsFinite(x))
			{
				if (num != 2139095040U)
				{
					return x;
				}
				return float.MaxValue;
			}
			else
			{
				if (num == 0U)
				{
					return -1E-45f;
				}
				if (float.IsNegative(x))
				{
					num += 1U;
				}
				else
				{
					num -= 1U;
				}
				return BitConverter.UInt32BitsToSingle(num);
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00010AF8 File Offset: 0x0000ECF8
		public static float BitIncrement(float x)
		{
			uint num = BitConverter.SingleToUInt32Bits(x);
			if (!float.IsFinite(x))
			{
				if (num != 4286578688U)
				{
					return x;
				}
				return float.MinValue;
			}
			else
			{
				if (num == 2147483648U)
				{
					return float.Epsilon;
				}
				if (float.IsNegative(x))
				{
					num -= 1U;
				}
				else
				{
					num += 1U;
				}
				return BitConverter.UInt32BitsToSingle(num);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00010B4A File Offset: 0x0000ED4A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float CopySign(float x, float y)
		{
			if (Vector128.IsHardwareAccelerated)
			{
				return Vector128.ConditionalSelect<float>(Vector128.CreateScalarUnsafe(--0f), Vector128.CreateScalarUnsafe(y), Vector128.CreateScalarUnsafe(x)).ToScalar<float>();
			}
			return MathF.<CopySign>g__SoftwareFallback|38_0(x, y);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00010B7C File Offset: 0x0000ED7C
		public static float IEEERemainder(float x, float y)
		{
			if (float.IsNaN(x))
			{
				return x;
			}
			if (float.IsNaN(y))
			{
				return y;
			}
			float num = x % y;
			if (float.IsNaN(num))
			{
				return float.NaN;
			}
			if (num == 0f && float.IsNegative(x))
			{
				return --0f;
			}
			float num2 = num - MathF.Abs(y) * (float)MathF.Sign(x);
			if (MathF.Abs(num2) == MathF.Abs(num))
			{
				float x2 = x / y;
				if (MathF.Abs(MathF.Round(x2)) > MathF.Abs(x2))
				{
					return num2;
				}
				return num;
			}
			else
			{
				if (MathF.Abs(num2) < MathF.Abs(num))
				{
					return num2;
				}
				return num;
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00010C10 File Offset: 0x0000EE10
		public static int ILogB(float x)
		{
			if (float.IsNormal(x))
			{
				return (int)x.Exponent;
			}
			if (float.IsZero(x))
			{
				return int.MinValue;
			}
			if (!float.IsFinite(x))
			{
				return int.MaxValue;
			}
			return -126 - (BitOperations.TrailingZeroCount(x.TrailingSignificand) - 8);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00010C50 File Offset: 0x0000EE50
		public static float Log(float x, float y)
		{
			if (float.IsNaN(x))
			{
				return x;
			}
			if (float.IsNaN(y))
			{
				return y;
			}
			if (y == 1f)
			{
				return float.NaN;
			}
			if (x != 1f && (y == 0f || float.IsPositiveInfinity(y)))
			{
				return float.NaN;
			}
			return MathF.Log(x) / MathF.Log(y);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00010CAA File Offset: 0x0000EEAA
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Max(float x, float y)
		{
			return Math.Max(x, y);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00010CB4 File Offset: 0x0000EEB4
		[Intrinsic]
		public static float MaxMagnitude(float x, float y)
		{
			float num = MathF.Abs(x);
			float num2 = MathF.Abs(y);
			if (num > num2 || float.IsNaN(num))
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!float.IsNegative(x))
			{
				return x;
			}
			return y;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00010CEE File Offset: 0x0000EEEE
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Min(float x, float y)
		{
			return Math.Min(x, y);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		[Intrinsic]
		public static float MinMagnitude(float x, float y)
		{
			float num = MathF.Abs(x);
			float num2 = MathF.Abs(y);
			if (num < num2 || float.IsNaN(num))
			{
				return x;
			}
			if (num != num2)
			{
				return y;
			}
			if (!float.IsNegative(x))
			{
				return y;
			}
			return x;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00010D32 File Offset: 0x0000EF32
		[Intrinsic]
		public static float ReciprocalEstimate(float x)
		{
			return 1f / x;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00010D3B File Offset: 0x0000EF3B
		[Intrinsic]
		public static float ReciprocalSqrtEstimate(float x)
		{
			return 1f / MathF.Sqrt(x);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00010D4C File Offset: 0x0000EF4C
		[Intrinsic]
		public static float Round(float x)
		{
			if (MathF.Abs(x) >= 8388608f)
			{
				return x;
			}
			float num = MathF.CopySign(8388608f, x);
			return MathF.CopySign(x + num - num, x);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00010D7F File Offset: 0x0000EF7F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Round(float x, int digits)
		{
			return MathF.Round(x, digits, MidpointRounding.ToEven);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00010D8C File Offset: 0x0000EF8C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Round(float x, MidpointRounding mode)
		{
			switch (mode)
			{
			case MidpointRounding.ToEven:
				return MathF.Round(x);
			case MidpointRounding.AwayFromZero:
				if (false)
				{
				}
				return MathF.Truncate(x + MathF.CopySign(0.49999997f, x));
			case MidpointRounding.ToZero:
				return MathF.Truncate(x);
			case MidpointRounding.ToNegativeInfinity:
				return MathF.Floor(x);
			case MidpointRounding.ToPositiveInfinity:
				return MathF.Ceiling(x);
			default:
				ThrowHelper.ThrowArgumentException_InvalidEnumValue<MidpointRounding>(mode, "mode");
				return 0f;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00010DF8 File Offset: 0x0000EFF8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float Round(float x, int digits, MidpointRounding mode)
		{
			if (digits > 6)
			{
				ThrowHelper.ThrowArgumentOutOfRange_RoundingDigits_MathF("digits");
			}
			if (MathF.Abs(x) < 100000000f)
			{
				float num = *MathF.RoundPower10Single[digits];
				x = MathF.Round(x * num, mode) / num;
			}
			return x;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00010E3E File Offset: 0x0000F03E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Sign(float x)
		{
			return Math.Sign(x);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00010E46 File Offset: 0x0000F046
		[Intrinsic]
		public unsafe static float Truncate(float x)
		{
			MathF.ModF(x, &x);
			return x;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00010E54 File Offset: 0x0000F054
		public static float ScaleB(float x, int n)
		{
			float num = x;
			if (n > 127)
			{
				num *= 1.7014118E+38f;
				n -= 127;
				if (n > 127)
				{
					num *= 1.7014118E+38f;
					n -= 127;
					if (n > 127)
					{
						n = 127;
					}
				}
			}
			else if (n < -126)
			{
				num *= 1.9721523E-31f;
				n += 102;
				if (n < -126)
				{
					num *= 1.9721523E-31f;
					n += 102;
					if (n < -126)
					{
						n = -126;
					}
				}
			}
			float num2 = BitConverter.Int32BitsToSingle(127 + n << 23);
			return num * num2;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00010ED4 File Offset: 0x0000F0D4
		[CompilerGenerated]
		internal static float <CopySign>g__SoftwareFallback|38_0(float x, float y)
		{
			uint num = BitConverter.SingleToUInt32Bits(x);
			uint num2 = BitConverter.SingleToUInt32Bits(y);
			return BitConverter.UInt32BitsToSingle((num & 2147483647U) | (num2 & 2147483648U));
		}

		// Token: 0x04000268 RID: 616
		public const float E = 2.7182817f;

		// Token: 0x04000269 RID: 617
		public const float PI = 3.1415927f;

		// Token: 0x0400026A RID: 618
		public const float Tau = 6.2831855f;
	}
}
