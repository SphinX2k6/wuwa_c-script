using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Numerics
{
	// Token: 0x02000298 RID: 664
	[Intrinsic]
	public struct Vector2 : IEquatable<Vector2>, IFormattable
	{
		// Token: 0x0600318D RID: 12685 RVA: 0x000A0F3E File Offset: 0x0009F13E
		[Intrinsic]
		public Vector2(float value)
		{
			this = Vector2.Create(value);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x000A0F4C File Offset: 0x0009F14C
		[Intrinsic]
		public Vector2(float x, float y)
		{
			this = Vector2.Create(x, y);
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x000A0F5B File Offset: 0x0009F15B
		[Intrinsic]
		public Vector2(ReadOnlySpan<float> values)
		{
			this = Vector2.Create(values);
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x000A0F69 File Offset: 0x0009F169
		public static Vector2 E
		{
			[Intrinsic]
			get
			{
				return Vector2.Create(2.7182817f);
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x000A0F75 File Offset: 0x0009F175
		public static Vector2 Epsilon
		{
			[Intrinsic]
			get
			{
				return Vector2.Create(float.Epsilon);
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x000A0F81 File Offset: 0x0009F181
		public static Vector2 NaN
		{
			[Intrinsic]
			get
			{
				return Vector2.Create(float.NaN);
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x000A0F8D File Offset: 0x0009F18D
		public static Vector2 NegativeInfinity
		{
			[Intrinsic]
			get
			{
				return Vector2.Create(float.NegativeInfinity);
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x000A0F99 File Offset: 0x0009F199
		public static Vector2 NegativeZero
		{
			[Intrinsic]
			get
			{
				return Vector2.Create(--0f);
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x000A0FA5 File Offset: 0x0009F1A5
		public static Vector2 One
		{
			[Intrinsic]
			get
			{
				return Vector2.Create(1f);
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x000A0FB1 File Offset: 0x0009F1B1
		public static Vector2 Pi
		{
			[Intrinsic]
			get
			{
				return Vector2.Create(3.1415927f);
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x000A0FBD File Offset: 0x0009F1BD
		public static Vector2 PositiveInfinity
		{
			[Intrinsic]
			get
			{
				return Vector2.Create(float.PositiveInfinity);
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x000A0FC9 File Offset: 0x0009F1C9
		public static Vector2 Tau
		{
			[Intrinsic]
			get
			{
				return Vector2.Create(6.2831855f);
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x000A0FD5 File Offset: 0x0009F1D5
		public static Vector2 UnitX
		{
			[Intrinsic]
			get
			{
				return Vector2.CreateScalar(1f);
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x000A0FE1 File Offset: 0x0009F1E1
		public static Vector2 UnitY
		{
			[Intrinsic]
			get
			{
				return Vector2.Create(0f, 1f);
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x000A0FF4 File Offset: 0x0009F1F4
		public static Vector2 Zero
		{
			[Intrinsic]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000929 RID: 2345
		public float this[int index]
		{
			[Intrinsic]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				if (index >= 2)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
				}
				return this.AsVector128Unsafe().GetElement(index);
			}
			[Intrinsic]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
				if (index >= 2)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
				}
				this = this.AsVector128Unsafe().WithElement(index, value).AsVector2();
			}
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x000A1052 File Offset: 0x0009F252
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator +(Vector2 left, Vector2 right)
		{
			return (left.AsVector128Unsafe() + right.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x000A106A File Offset: 0x0009F26A
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator /(Vector2 left, Vector2 right)
		{
			return (left.AsVector128Unsafe() / right.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x000A1082 File Offset: 0x0009F282
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator /(Vector2 value1, float value2)
		{
			return (value1.AsVector128Unsafe() / value2).AsVector2();
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x000A1095 File Offset: 0x0009F295
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Vector2 left, Vector2 right)
		{
			return left.AsVector128() == right.AsVector128();
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x000A10A8 File Offset: 0x0009F2A8
		[Intrinsic]
		public static bool operator !=(Vector2 left, Vector2 right)
		{
			return !(left == right);
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x000A10B4 File Offset: 0x0009F2B4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator *(Vector2 left, Vector2 right)
		{
			return (left.AsVector128Unsafe() * right.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x000A10CC File Offset: 0x0009F2CC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator *(Vector2 left, float right)
		{
			return (left.AsVector128Unsafe() * right).AsVector2();
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x000A10DF File Offset: 0x0009F2DF
		[Intrinsic]
		public static Vector2 operator *(float left, Vector2 right)
		{
			return right * left;
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x000A10E8 File Offset: 0x0009F2E8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator -(Vector2 left, Vector2 right)
		{
			return (left.AsVector128Unsafe() - right.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x000A1100 File Offset: 0x0009F300
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 operator -(Vector2 value)
		{
			return (-value.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x000A1112 File Offset: 0x0009F312
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Abs(Vector2 value)
		{
			return Vector128.Abs<float>(value.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x000A1124 File Offset: 0x0009F324
		[Intrinsic]
		public static Vector2 Add(Vector2 left, Vector2 right)
		{
			return left + right;
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x000A112D File Offset: 0x0009F32D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max)
		{
			return Vector128.Clamp<float>(value1.AsVector128Unsafe(), min.AsVector128Unsafe(), max.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x000A114B File Offset: 0x0009F34B
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 ClampNative(Vector2 value1, Vector2 min, Vector2 max)
		{
			return Vector128.ClampNative<float>(value1.AsVector128Unsafe(), min.AsVector128Unsafe(), max.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x000A1169 File Offset: 0x0009F369
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 CopySign(Vector2 value, Vector2 sign)
		{
			return Vector128.CopySign<float>(value.AsVector128Unsafe(), sign.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x000A1181 File Offset: 0x0009F381
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Cos(Vector2 vector)
		{
			return Vector128.Cos(vector.AsVector128()).AsVector2();
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x000A1193 File Offset: 0x0009F393
		[Intrinsic]
		public static Vector2 Create(float value)
		{
			return Vector128.Create(value).AsVector2();
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x000A11A0 File Offset: 0x0009F3A0
		[Intrinsic]
		public static Vector2 Create(float x, float y)
		{
			return Vector128.Create(x, y, 0f, 0f).AsVector2();
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x000A11B8 File Offset: 0x0009F3B8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Create(ReadOnlySpan<float> values)
		{
			if (values.Length < 2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.values);
			}
			return Unsafe.ReadUnaligned<Vector2>(Unsafe.As<float, byte>(MemoryMarshal.GetReference<float>(values)));
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x000A11DA File Offset: 0x0009F3DA
		[Intrinsic]
		internal static Vector2 CreateScalar(float x)
		{
			return Vector128.CreateScalar(x).AsVector2();
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x000A11E7 File Offset: 0x0009F3E7
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 DegreesToRadians(Vector2 degrees)
		{
			return Vector128.DegreesToRadians(degrees.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x000A11F9 File Offset: 0x0009F3F9
		[Intrinsic]
		public static float Distance(Vector2 value1, Vector2 value2)
		{
			return float.Sqrt(Vector2.DistanceSquared(value1, value2));
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x000A1208 File Offset: 0x0009F408
		[Intrinsic]
		public static float DistanceSquared(Vector2 value1, Vector2 value2)
		{
			return (value1 - value2).LengthSquared();
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x000A1224 File Offset: 0x0009F424
		[Intrinsic]
		public static Vector2 Divide(Vector2 left, Vector2 right)
		{
			return left / right;
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x000A122D File Offset: 0x0009F42D
		[Intrinsic]
		public static Vector2 Divide(Vector2 left, float divisor)
		{
			return left / divisor;
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x000A1236 File Offset: 0x0009F436
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(Vector2 value1, Vector2 value2)
		{
			return Vector128.Dot<float>(value1.AsVector128(), value2.AsVector128());
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x000A1249 File Offset: 0x0009F449
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Exp(Vector2 vector)
		{
			return Vector128.Exp(vector.AsVector128()).AsVector2();
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x000A125B File Offset: 0x0009F45B
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 FusedMultiplyAdd(Vector2 left, Vector2 right, Vector2 addend)
		{
			return Vector128.FusedMultiplyAdd(left.AsVector128Unsafe(), right.AsVector128Unsafe(), addend.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x000A1279 File Offset: 0x0009F479
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Hypot(Vector2 x, Vector2 y)
		{
			return Vector128.Hypot(x.AsVector128Unsafe(), y.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x000A1291 File Offset: 0x0009F491
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)
		{
			return Vector2.Lerp(value1, value2, Vector2.Create(amount));
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x000A12A0 File Offset: 0x0009F4A0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Lerp(Vector2 value1, Vector2 value2, Vector2 amount)
		{
			return Vector128.Lerp(value1.AsVector128Unsafe(), value2.AsVector128Unsafe(), amount.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x000A12BE File Offset: 0x0009F4BE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Log(Vector2 vector)
		{
			return Vector128.Log(Vector4.Create(vector, 1f, 1f).AsVector128()).AsVector2();
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x000A12DF File Offset: 0x0009F4DF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Log2(Vector2 vector)
		{
			return Vector128.Log2(Vector4.Create(vector, 1f, 1f).AsVector128()).AsVector2();
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x000A1300 File Offset: 0x0009F500
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Max(Vector2 value1, Vector2 value2)
		{
			return Vector128.Max<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x000A1318 File Offset: 0x0009F518
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MaxMagnitude(Vector2 value1, Vector2 value2)
		{
			return Vector128.MaxMagnitude<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x000A1330 File Offset: 0x0009F530
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MaxMagnitudeNumber(Vector2 value1, Vector2 value2)
		{
			return Vector128.MaxMagnitudeNumber<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x000A1348 File Offset: 0x0009F548
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MaxNative(Vector2 value1, Vector2 value2)
		{
			return Vector128.MaxNative<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x000A1360 File Offset: 0x0009F560
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MaxNumber(Vector2 value1, Vector2 value2)
		{
			return Vector128.MaxNumber<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x000A1378 File Offset: 0x0009F578
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Min(Vector2 value1, Vector2 value2)
		{
			return Vector128.Min<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x000A1390 File Offset: 0x0009F590
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MinMagnitude(Vector2 value1, Vector2 value2)
		{
			return Vector128.MinMagnitude<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x000A13A8 File Offset: 0x0009F5A8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MinMagnitudeNumber(Vector2 value1, Vector2 value2)
		{
			return Vector128.MinMagnitudeNumber<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x000A13C0 File Offset: 0x0009F5C0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MinNative(Vector2 value1, Vector2 value2)
		{
			return Vector128.MinNative<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x000A13D8 File Offset: 0x0009F5D8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MinNumber(Vector2 value1, Vector2 value2)
		{
			return Vector128.MinNumber<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x000A13F0 File Offset: 0x0009F5F0
		[Intrinsic]
		public static Vector2 Multiply(Vector2 left, Vector2 right)
		{
			return left * right;
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x000A13F9 File Offset: 0x0009F5F9
		[Intrinsic]
		public static Vector2 Multiply(Vector2 left, float right)
		{
			return left * right;
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x000A1402 File Offset: 0x0009F602
		[Intrinsic]
		public static Vector2 Multiply(float left, Vector2 right)
		{
			return left * right;
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x000A140B File Offset: 0x0009F60B
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 MultiplyAddEstimate(Vector2 left, Vector2 right, Vector2 addend)
		{
			return Vector128.MultiplyAddEstimate(left.AsVector128Unsafe(), right.AsVector128Unsafe(), addend.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x000A1429 File Offset: 0x0009F629
		[Intrinsic]
		public static Vector2 Negate(Vector2 value)
		{
			return -value;
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x000A1431 File Offset: 0x0009F631
		[Intrinsic]
		public static Vector2 Normalize(Vector2 value)
		{
			return value / value.Length();
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x000A1440 File Offset: 0x0009F640
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 RadiansToDegrees(Vector2 radians)
		{
			return Vector128.RadiansToDegrees(radians.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x000A1452 File Offset: 0x0009F652
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Reflect(Vector2 vector, Vector2 normal)
		{
			Vector2 vector2 = Vector2.Create(Vector2.Dot(vector, normal));
			return Vector2.MultiplyAddEstimate(-(vector2 + vector2), normal, vector);
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x000A1472 File Offset: 0x0009F672
		[Intrinsic]
		public static Vector2 Round(Vector2 vector)
		{
			return Vector128.Round(vector.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x000A1484 File Offset: 0x0009F684
		[Intrinsic]
		public static Vector2 Round(Vector2 vector, MidpointRounding mode)
		{
			return Vector128.Round(vector.AsVector128Unsafe(), mode).AsVector2();
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x000A1497 File Offset: 0x0009F697
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Sin(Vector2 vector)
		{
			return Vector128.Sin(vector.AsVector128()).AsVector2();
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x000A14AC File Offset: 0x0009F6AC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector2, Vector2> SinCos(Vector2 vector)
		{
			ValueTuple<Vector128<float>, Vector128<float>> valueTuple = Vector128.SinCos(vector.AsVector128());
			Vector128<float> item = valueTuple.Item1;
			Vector128<float> item2 = valueTuple.Item2;
			return new ValueTuple<Vector2, Vector2>(item.AsVector2(), item2.AsVector2());
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x000A14E2 File Offset: 0x0009F6E2
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 SquareRoot(Vector2 value)
		{
			return Vector128.Sqrt<float>(value.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x000A14F4 File Offset: 0x0009F6F4
		[Intrinsic]
		public static Vector2 Subtract(Vector2 left, Vector2 right)
		{
			return left - right;
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x000A14FD File Offset: 0x0009F6FD
		public static Vector2 Transform(Vector2 position, Matrix3x2 matrix)
		{
			return Vector2.Transform(position, matrix.AsImpl());
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x000A150C File Offset: 0x0009F70C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector2 Transform(Vector2 position, in Matrix3x2.Impl matrix)
		{
			Vector2 vector = matrix.X * position.X;
			vector = Vector2.MultiplyAddEstimate(matrix.Y, Vector2.Create(position.Y), vector);
			return vector + matrix.Z;
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x000A154F File Offset: 0x0009F74F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Transform(Vector2 position, Matrix4x4 matrix)
		{
			return Vector4.Transform(position, matrix.AsImpl()).AsVector128().AsVector2();
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000A1568 File Offset: 0x0009F768
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 Transform(Vector2 value, Quaternion rotation)
		{
			return Vector4.Transform(value, rotation).AsVector2();
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x000A1576 File Offset: 0x0009F776
		public static Vector2 TransformNormal(Vector2 normal, Matrix3x2 matrix)
		{
			return Vector2.TransformNormal(normal, matrix.AsImpl());
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000A1588 File Offset: 0x0009F788
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector2 TransformNormal(Vector2 normal, in Matrix3x2.Impl matrix)
		{
			Vector2 addend = matrix.X * normal.X;
			return Vector2.MultiplyAddEstimate(matrix.Y, Vector2.Create(normal.Y), addend);
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x000A15C0 File Offset: 0x0009F7C0
		public static Vector2 TransformNormal(Vector2 normal, Matrix4x4 matrix)
		{
			return Vector2.TransformNormal(normal, matrix.AsImpl());
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x000A15D0 File Offset: 0x0009F7D0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector2 TransformNormal(Vector2 normal, in Matrix4x4.Impl matrix)
		{
			Vector4 vector = matrix.X * normal.X;
			vector = Vector4.MultiplyAddEstimate(matrix.Y, Vector4.Create(normal.Y), vector);
			return vector.AsVector2();
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x000A160D File Offset: 0x0009F80D
		[Intrinsic]
		public static Vector2 Truncate(Vector2 vector)
		{
			return Vector128.Truncate(vector.AsVector128Unsafe()).AsVector2();
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x000A161F File Offset: 0x0009F81F
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly void CopyTo(float[] array)
		{
			if (array.Length < 2)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector2>(Unsafe.As<float, byte>(ref array[0]), this);
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x000A1643 File Offset: 0x0009F843
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly void CopyTo(float[] array, int index)
		{
			if (index >= array.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
			}
			if (array.Length - index < 2)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector2>(Unsafe.As<float, byte>(ref array[index]), this);
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x000A1674 File Offset: 0x0009F874
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly void CopyTo(Span<float> destination)
		{
			if (destination.Length < 2)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector2>(Unsafe.As<float, byte>(MemoryMarshal.GetReference<float>(destination)), this);
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x000A169B File Offset: 0x0009F89B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool TryCopyTo(Span<float> destination)
		{
			if (destination.Length < 2)
			{
				return false;
			}
			Unsafe.WriteUnaligned<Vector2>(Unsafe.As<float, byte>(MemoryMarshal.GetReference<float>(destination)), this);
			return true;
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x000A16C0 File Offset: 0x0009F8C0
		[NullableContext(2)]
		public override readonly bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Vector2)
			{
				Vector2 other = (Vector2)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x000A16E8 File Offset: 0x0009F8E8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(Vector2 other)
		{
			return this.AsVector128().Equals(other.AsVector128());
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x000A170E File Offset: 0x0009F90E
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.X, this.Y);
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x000A1721 File Offset: 0x0009F921
		[Intrinsic]
		public readonly float Length()
		{
			return float.Sqrt(this.LengthSquared());
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x000A172E File Offset: 0x0009F92E
		[Intrinsic]
		public readonly float LengthSquared()
		{
			return Vector2.Dot(this, this);
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x000A1741 File Offset: 0x0009F941
		[NullableContext(1)]
		public override readonly string ToString()
		{
			return this.ToString("G", CultureInfo.CurrentCulture);
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x000A1753 File Offset: 0x0009F953
		[NullableContext(1)]
		public readonly string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return this.ToString(format, CultureInfo.CurrentCulture);
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x000A1764 File Offset: 0x0009F964
		[NullableContext(2)]
		[return: Nullable(1)]
		public readonly string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider formatProvider)
		{
			string numberGroupSeparator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<");
			defaultInterpolatedStringHandler.AppendFormatted(this.X.ToString(format, formatProvider));
			defaultInterpolatedStringHandler.AppendFormatted(numberGroupSeparator);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(this.Y.ToString(format, formatProvider));
			defaultInterpolatedStringHandler.AppendLiteral(">");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040008EB RID: 2283
		public float X;

		// Token: 0x040008EC RID: 2284
		public float Y;
	}
}
