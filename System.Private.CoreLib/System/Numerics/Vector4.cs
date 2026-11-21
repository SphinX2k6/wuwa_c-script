using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace System.Numerics
{
	// Token: 0x0200029A RID: 666
	[Intrinsic]
	public struct Vector4 : IEquatable<Vector4>, IFormattable
	{
		// Token: 0x0600324B RID: 12875 RVA: 0x000A20C5 File Offset: 0x000A02C5
		[Intrinsic]
		public Vector4(float value)
		{
			this = Vector4.Create(value);
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x000A20D3 File Offset: 0x000A02D3
		[Intrinsic]
		public Vector4(Vector2 value, float z, float w)
		{
			this = Vector4.Create(value, z, w);
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x000A20E3 File Offset: 0x000A02E3
		[Intrinsic]
		public Vector4(Vector3 value, float w)
		{
			this = Vector4.Create(value, w);
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x000A20F2 File Offset: 0x000A02F2
		[Intrinsic]
		public Vector4(float x, float y, float z, float w)
		{
			this = Vector4.Create(x, y, z, w);
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x000A2104 File Offset: 0x000A0304
		[Intrinsic]
		public Vector4(ReadOnlySpan<float> values)
		{
			this = Vector4.Create(values);
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x000A2112 File Offset: 0x000A0312
		public static Vector4 E
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(2.7182817f);
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06003251 RID: 12881 RVA: 0x000A211E File Offset: 0x000A031E
		public static Vector4 Epsilon
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(float.Epsilon);
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06003252 RID: 12882 RVA: 0x000A212A File Offset: 0x000A032A
		public static Vector4 NaN
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(float.NaN);
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x000A2136 File Offset: 0x000A0336
		public static Vector4 NegativeInfinity
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(float.NegativeInfinity);
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x000A2142 File Offset: 0x000A0342
		public static Vector4 NegativeZero
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(--0f);
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x000A214E File Offset: 0x000A034E
		public static Vector4 One
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(1f);
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x000A215A File Offset: 0x000A035A
		public static Vector4 Pi
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(3.1415927f);
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06003257 RID: 12887 RVA: 0x000A2166 File Offset: 0x000A0366
		public static Vector4 PositiveInfinity
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(float.PositiveInfinity);
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x000A2172 File Offset: 0x000A0372
		public static Vector4 Tau
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(6.2831855f);
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x000A217E File Offset: 0x000A037E
		public static Vector4 UnitX
		{
			[Intrinsic]
			get
			{
				return Vector4.CreateScalar(1f);
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x000A218A File Offset: 0x000A038A
		public static Vector4 UnitY
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(0f, 1f, 0f, 0f);
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x000A21A5 File Offset: 0x000A03A5
		public static Vector4 UnitZ
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(0f, 0f, 1f, 0f);
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x000A21C0 File Offset: 0x000A03C0
		public static Vector4 UnitW
		{
			[Intrinsic]
			get
			{
				return Vector4.Create(0f, 0f, 0f, 1f);
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x0600325D RID: 12893 RVA: 0x000A21DC File Offset: 0x000A03DC
		public static Vector4 Zero
		{
			[Intrinsic]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x17000946 RID: 2374
		public float this[int index]
		{
			[Intrinsic]
			readonly get
			{
				return this.AsVector128().GetElement(index);
			}
			[Intrinsic]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
				this = this.AsVector128().WithElement(index, value).AsVector4();
			}
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x000A2224 File Offset: 0x000A0424
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 operator +(Vector4 left, Vector4 right)
		{
			return (left.AsVector128() + right.AsVector128()).AsVector4();
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x000A223C File Offset: 0x000A043C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 operator /(Vector4 left, Vector4 right)
		{
			return (left.AsVector128() / right.AsVector128()).AsVector4();
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x000A2254 File Offset: 0x000A0454
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 operator /(Vector4 value1, float value2)
		{
			return (value1.AsVector128() / value2).AsVector4();
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x000A2267 File Offset: 0x000A0467
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Vector4 left, Vector4 right)
		{
			return left.AsVector128() == right.AsVector128();
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x000A227A File Offset: 0x000A047A
		[Intrinsic]
		public static bool operator !=(Vector4 left, Vector4 right)
		{
			return !(left == right);
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x000A2286 File Offset: 0x000A0486
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 operator *(Vector4 left, Vector4 right)
		{
			return (left.AsVector128() * right.AsVector128()).AsVector4();
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x000A229E File Offset: 0x000A049E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 operator *(Vector4 left, float right)
		{
			return (left.AsVector128() * right).AsVector4();
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x000A22B1 File Offset: 0x000A04B1
		[Intrinsic]
		public static Vector4 operator *(float left, Vector4 right)
		{
			return right * left;
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x000A22BA File Offset: 0x000A04BA
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 operator -(Vector4 left, Vector4 right)
		{
			return (left.AsVector128() - right.AsVector128()).AsVector4();
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x000A22D2 File Offset: 0x000A04D2
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 operator -(Vector4 value)
		{
			return (-value.AsVector128()).AsVector4();
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x000A22E4 File Offset: 0x000A04E4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Abs(Vector4 value)
		{
			return Vector128.Abs<float>(value.AsVector128()).AsVector4();
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x000A22F6 File Offset: 0x000A04F6
		[Intrinsic]
		public static Vector4 Add(Vector4 left, Vector4 right)
		{
			return left + right;
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x000A22FF File Offset: 0x000A04FF
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max)
		{
			return Vector128.Clamp<float>(value1.AsVector128(), min.AsVector128(), max.AsVector128()).AsVector4();
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x000A231D File Offset: 0x000A051D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 ClampNative(Vector4 value1, Vector4 min, Vector4 max)
		{
			return Vector128.ClampNative<float>(value1.AsVector128(), min.AsVector128(), max.AsVector128()).AsVector4();
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x000A233B File Offset: 0x000A053B
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 CopySign(Vector4 value, Vector4 sign)
		{
			return Vector128.CopySign<float>(value.AsVector128(), sign.AsVector128()).AsVector4();
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x000A2353 File Offset: 0x000A0553
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Cos(Vector4 vector)
		{
			return Vector128.Cos(vector.AsVector128()).AsVector4();
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x000A2365 File Offset: 0x000A0565
		[Intrinsic]
		public static Vector4 Create(float value)
		{
			return Vector128.Create(value).AsVector4();
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x000A2372 File Offset: 0x000A0572
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Create(Vector2 vector, float z, float w)
		{
			return vector.AsVector128Unsafe().WithElement(2, z).WithElement(3, w).AsVector4();
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x000A238D File Offset: 0x000A058D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Create(Vector3 vector, float w)
		{
			return vector.AsVector128Unsafe().WithElement(3, w).AsVector4();
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x000A23A1 File Offset: 0x000A05A1
		[Intrinsic]
		public static Vector4 Create(float x, float y, float z, float w)
		{
			return Vector128.Create(x, y, z, w).AsVector4();
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x000A23B1 File Offset: 0x000A05B1
		[Intrinsic]
		public static Vector4 Create(ReadOnlySpan<float> values)
		{
			return Vector128.Create<float>(values).AsVector4();
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x000A23BE File Offset: 0x000A05BE
		[Intrinsic]
		internal static Vector4 CreateScalar(float x)
		{
			return Vector128.CreateScalar(x).AsVector4();
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x000A23CB File Offset: 0x000A05CB
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 DegreesToRadians(Vector4 degrees)
		{
			return Vector128.DegreesToRadians(degrees.AsVector128()).AsVector4();
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x000A23DD File Offset: 0x000A05DD
		[Intrinsic]
		public static float Distance(Vector4 value1, Vector4 value2)
		{
			return float.Sqrt(Vector4.DistanceSquared(value1, value2));
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x000A23EC File Offset: 0x000A05EC
		[Intrinsic]
		public static float DistanceSquared(Vector4 value1, Vector4 value2)
		{
			return (value1 - value2).LengthSquared();
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x000A2408 File Offset: 0x000A0608
		[Intrinsic]
		public static Vector4 Divide(Vector4 left, Vector4 right)
		{
			return left / right;
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x000A2411 File Offset: 0x000A0611
		[Intrinsic]
		public static Vector4 Divide(Vector4 left, float divisor)
		{
			return left / divisor;
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x000A241A File Offset: 0x000A061A
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(Vector4 vector1, Vector4 vector2)
		{
			return Vector128.Dot<float>(vector1.AsVector128(), vector2.AsVector128());
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x000A242D File Offset: 0x000A062D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Exp(Vector4 vector)
		{
			return Vector128.Exp(vector.AsVector128()).AsVector4();
		}

		// Token: 0x0600327D RID: 12925 RVA: 0x000A243F File Offset: 0x000A063F
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 FusedMultiplyAdd(Vector4 left, Vector4 right, Vector4 addend)
		{
			return Vector128.FusedMultiplyAdd(left.AsVector128(), right.AsVector128(), addend.AsVector128()).AsVector4();
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x000A245D File Offset: 0x000A065D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Hypot(Vector4 x, Vector4 y)
		{
			return Vector128.Hypot(x.AsVector128(), y.AsVector128()).AsVector4();
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x000A2475 File Offset: 0x000A0675
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount)
		{
			return Vector4.Lerp(value1, value2, Vector4.Create(amount));
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x000A2484 File Offset: 0x000A0684
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Lerp(Vector4 value1, Vector4 value2, Vector4 amount)
		{
			return Vector128.Lerp(value1.AsVector128(), value2.AsVector128(), amount.AsVector128()).AsVector4();
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x000A24A2 File Offset: 0x000A06A2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Log(Vector4 vector)
		{
			return Vector128.Log(vector.AsVector128()).AsVector4();
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x000A24B4 File Offset: 0x000A06B4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Log2(Vector4 vector)
		{
			return Vector128.Log2(vector.AsVector128()).AsVector4();
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x000A24C6 File Offset: 0x000A06C6
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Max(Vector4 value1, Vector4 value2)
		{
			return Vector128.Max<float>(value1.AsVector128(), value2.AsVector128()).AsVector4();
		}

		// Token: 0x06003284 RID: 12932 RVA: 0x000A24DE File Offset: 0x000A06DE
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 MaxMagnitude(Vector4 value1, Vector4 value2)
		{
			return Vector128.MaxMagnitude<float>(value1.AsVector128(), value2.AsVector128()).AsVector4();
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x000A24F6 File Offset: 0x000A06F6
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 MaxMagnitudeNumber(Vector4 value1, Vector4 value2)
		{
			return Vector128.MaxMagnitudeNumber<float>(value1.AsVector128(), value2.AsVector128()).AsVector4();
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x000A250E File Offset: 0x000A070E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 MaxNative(Vector4 value1, Vector4 value2)
		{
			return Vector128.MaxNative<float>(value1.AsVector128(), value2.AsVector128()).AsVector4();
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x000A2526 File Offset: 0x000A0726
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 MaxNumber(Vector4 value1, Vector4 value2)
		{
			return Vector128.MaxNumber<float>(value1.AsVector128(), value2.AsVector128()).AsVector4();
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x000A253E File Offset: 0x000A073E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Min(Vector4 value1, Vector4 value2)
		{
			return Vector128.Min<float>(value1.AsVector128(), value2.AsVector128()).AsVector4();
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x000A2556 File Offset: 0x000A0756
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 MinMagnitude(Vector4 value1, Vector4 value2)
		{
			return Vector128.MinMagnitude<float>(value1.AsVector128(), value2.AsVector128()).AsVector4();
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x000A256E File Offset: 0x000A076E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 MinMagnitudeNumber(Vector4 value1, Vector4 value2)
		{
			return Vector128.MinMagnitudeNumber<float>(value1.AsVector128(), value2.AsVector128()).AsVector4();
		}

		// Token: 0x0600328B RID: 12939 RVA: 0x000A2586 File Offset: 0x000A0786
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 MinNative(Vector4 value1, Vector4 value2)
		{
			return Vector128.MinNative<float>(value1.AsVector128(), value2.AsVector128()).AsVector4();
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x000A259E File Offset: 0x000A079E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 MinNumber(Vector4 value1, Vector4 value2)
		{
			return Vector128.MinNumber<float>(value1.AsVector128(), value2.AsVector128()).AsVector4();
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x000A25B6 File Offset: 0x000A07B6
		[Intrinsic]
		public static Vector4 Multiply(Vector4 left, Vector4 right)
		{
			return left * right;
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x000A25BF File Offset: 0x000A07BF
		[Intrinsic]
		public static Vector4 Multiply(Vector4 left, float right)
		{
			return left * right;
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x000A25C8 File Offset: 0x000A07C8
		[Intrinsic]
		public static Vector4 Multiply(float left, Vector4 right)
		{
			return left * right;
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x000A25D1 File Offset: 0x000A07D1
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 MultiplyAddEstimate(Vector4 left, Vector4 right, Vector4 addend)
		{
			return Vector128.MultiplyAddEstimate(left.AsVector128(), right.AsVector128(), addend.AsVector128()).AsVector4();
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x000A25EF File Offset: 0x000A07EF
		[Intrinsic]
		public static Vector4 Negate(Vector4 value)
		{
			return -value;
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x000A25F7 File Offset: 0x000A07F7
		[Intrinsic]
		public static Vector4 Normalize(Vector4 vector)
		{
			return vector / vector.Length();
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x000A2606 File Offset: 0x000A0806
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 RadiansToDegrees(Vector4 radians)
		{
			return Vector128.RadiansToDegrees(radians.AsVector128()).AsVector4();
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x000A2618 File Offset: 0x000A0818
		[Intrinsic]
		public static Vector4 Round(Vector4 vector)
		{
			return Vector128.Round(vector.AsVector128()).AsVector4();
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x000A262A File Offset: 0x000A082A
		[Intrinsic]
		public static Vector4 Round(Vector4 vector, MidpointRounding mode)
		{
			return Vector128.Round(vector.AsVector128(), mode).AsVector4();
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x000A263D File Offset: 0x000A083D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Sin(Vector4 vector)
		{
			return Vector128.Sin(vector.AsVector128()).AsVector4();
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x000A2650 File Offset: 0x000A0850
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector4, Vector4> SinCos(Vector4 vector)
		{
			ValueTuple<Vector128<float>, Vector128<float>> valueTuple = Vector128.SinCos(vector.AsVector128());
			Vector128<float> item = valueTuple.Item1;
			Vector128<float> item2 = valueTuple.Item2;
			return new ValueTuple<Vector4, Vector4>(item.AsVector4(), item2.AsVector4());
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x000A2686 File Offset: 0x000A0886
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 SquareRoot(Vector4 value)
		{
			return Vector128.Sqrt<float>(value.AsVector128()).AsVector4();
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000A2698 File Offset: 0x000A0898
		[Intrinsic]
		public static Vector4 Subtract(Vector4 left, Vector4 right)
		{
			return left - right;
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000A26A1 File Offset: 0x000A08A1
		public static Vector4 Transform(Vector2 position, Matrix4x4 matrix)
		{
			return Vector4.Transform(position, matrix.AsImpl());
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000A26B0 File Offset: 0x000A08B0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector4 Transform(Vector2 position, in Matrix4x4.Impl matrix)
		{
			Vector4 vector = matrix.X * position.X;
			vector = Vector4.MultiplyAddEstimate(matrix.Y, Vector4.Create(position.Y), vector);
			return vector + matrix.W;
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x000A26F3 File Offset: 0x000A08F3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Transform(Vector2 value, Quaternion rotation)
		{
			return Vector4.Transform(Vector4.Create(value, 0f, 1f), rotation);
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x000A270B File Offset: 0x000A090B
		public static Vector4 Transform(Vector3 position, Matrix4x4 matrix)
		{
			return Vector4.Transform(position, matrix.AsImpl());
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000A271C File Offset: 0x000A091C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector4 Transform(Vector3 position, in Matrix4x4.Impl matrix)
		{
			Vector4 vector = matrix.X * position.X;
			vector = Vector4.MultiplyAddEstimate(matrix.Y, Vector4.Create(position.Y), vector);
			vector = Vector4.MultiplyAddEstimate(matrix.Z, Vector4.Create(position.Z), vector);
			return vector + matrix.W;
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x000A2777 File Offset: 0x000A0977
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Transform(Vector3 value, Quaternion rotation)
		{
			return Vector4.Transform(Vector4.Create(value, 1f), rotation);
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x000A278A File Offset: 0x000A098A
		public static Vector4 Transform(Vector4 vector, Matrix4x4 matrix)
		{
			return Vector4.Transform(vector, matrix.AsImpl());
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000A279C File Offset: 0x000A099C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector4 Transform(Vector4 vector, in Matrix4x4.Impl matrix)
		{
			Vector4 addend = matrix.X * vector.X;
			addend = Vector4.MultiplyAddEstimate(matrix.Y, Vector4.Create(vector.Y), addend);
			addend = Vector4.MultiplyAddEstimate(matrix.Z, Vector4.Create(vector.Z), addend);
			return Vector4.MultiplyAddEstimate(matrix.W, Vector4.Create(vector.W), addend);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000A2804 File Offset: 0x000A0A04
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 Transform(Vector4 value, Quaternion rotation)
		{
			return Quaternion.Concatenate(Quaternion.Concatenate(Quaternion.Conjugate(rotation), value.AsQuaternion()), rotation).AsVector4();
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000A2822 File Offset: 0x000A0A22
		[Intrinsic]
		public static Vector4 Truncate(Vector4 vector)
		{
			return Vector128.Truncate(vector.AsVector128()).AsVector4();
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000A2834 File Offset: 0x000A0A34
		[NullableContext(1)]
		public readonly void CopyTo(float[] array)
		{
			this.AsVector128().CopyTo(array);
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x000A2847 File Offset: 0x000A0A47
		[NullableContext(1)]
		public readonly void CopyTo(float[] array, int index)
		{
			this.AsVector128().CopyTo(array, index);
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x000A285B File Offset: 0x000A0A5B
		public readonly void CopyTo(Span<float> destination)
		{
			this.AsVector128().CopyTo(destination);
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x000A286E File Offset: 0x000A0A6E
		public readonly bool TryCopyTo(Span<float> destination)
		{
			return this.AsVector128().TryCopyTo(destination);
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x000A2884 File Offset: 0x000A0A84
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(Vector4 other)
		{
			return this.AsVector128().Equals(other.AsVector128());
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x000A28AC File Offset: 0x000A0AAC
		[NullableContext(2)]
		public override readonly bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Vector4)
			{
				Vector4 other = (Vector4)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x000A28D1 File Offset: 0x000A0AD1
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x000A28F0 File Offset: 0x000A0AF0
		[Intrinsic]
		public readonly float Length()
		{
			return float.Sqrt(this.LengthSquared());
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x000A28FD File Offset: 0x000A0AFD
		[Intrinsic]
		public readonly float LengthSquared()
		{
			return Vector4.Dot(this, this);
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x000A2910 File Offset: 0x000A0B10
		[NullableContext(1)]
		public override readonly string ToString()
		{
			return this.ToString("G", CultureInfo.CurrentCulture);
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x000A2922 File Offset: 0x000A0B22
		[NullableContext(1)]
		public readonly string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return this.ToString(format, CultureInfo.CurrentCulture);
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x000A2930 File Offset: 0x000A0B30
		[NullableContext(2)]
		[return: Nullable(1)]
		public readonly string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider formatProvider)
		{
			string numberGroupSeparator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 7);
			defaultInterpolatedStringHandler.AppendLiteral("<");
			defaultInterpolatedStringHandler.AppendFormatted(this.X.ToString(format, formatProvider));
			defaultInterpolatedStringHandler.AppendFormatted(numberGroupSeparator);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(this.Y.ToString(format, formatProvider));
			defaultInterpolatedStringHandler.AppendFormatted(numberGroupSeparator);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(this.Z.ToString(format, formatProvider));
			defaultInterpolatedStringHandler.AppendFormatted(numberGroupSeparator);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(this.W.ToString(format, formatProvider));
			defaultInterpolatedStringHandler.AppendLiteral(">");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040008F0 RID: 2288
		public float X;

		// Token: 0x040008F1 RID: 2289
		public float Y;

		// Token: 0x040008F2 RID: 2290
		public float Z;

		// Token: 0x040008F3 RID: 2291
		public float W;
	}
}
