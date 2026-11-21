using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Numerics
{
	// Token: 0x02000299 RID: 665
	[Intrinsic]
	public struct Vector3 : IEquatable<Vector3>, IFormattable
	{
		// Token: 0x060031EC RID: 12780 RVA: 0x000A17E1 File Offset: 0x0009F9E1
		[Intrinsic]
		public Vector3(float value)
		{
			this = Vector3.Create(value);
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x000A17EF File Offset: 0x0009F9EF
		[Intrinsic]
		public Vector3(Vector2 value, float z)
		{
			this = Vector3.Create(value, z);
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x000A17FE File Offset: 0x0009F9FE
		[Intrinsic]
		public Vector3(float x, float y, float z)
		{
			this = Vector3.Create(x, y, z);
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x000A180E File Offset: 0x0009FA0E
		[Intrinsic]
		public Vector3(ReadOnlySpan<float> values)
		{
			this = Vector3.Create(values);
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x000A181C File Offset: 0x0009FA1C
		public static Vector3 E
		{
			[Intrinsic]
			get
			{
				return Vector3.Create(2.7182817f);
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x060031F1 RID: 12785 RVA: 0x000A1828 File Offset: 0x0009FA28
		public static Vector3 Epsilon
		{
			[Intrinsic]
			get
			{
				return Vector3.Create(float.Epsilon);
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x060031F2 RID: 12786 RVA: 0x000A1834 File Offset: 0x0009FA34
		public static Vector3 NaN
		{
			[Intrinsic]
			get
			{
				return Vector3.Create(float.NaN);
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x060031F3 RID: 12787 RVA: 0x000A1840 File Offset: 0x0009FA40
		public static Vector3 NegativeInfinity
		{
			[Intrinsic]
			get
			{
				return Vector3.Create(float.NegativeInfinity);
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x000A184C File Offset: 0x0009FA4C
		public static Vector3 NegativeZero
		{
			[Intrinsic]
			get
			{
				return Vector3.Create(--0f);
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x000A1858 File Offset: 0x0009FA58
		public static Vector3 One
		{
			[Intrinsic]
			get
			{
				return Vector3.Create(1f);
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x060031F6 RID: 12790 RVA: 0x000A1864 File Offset: 0x0009FA64
		public static Vector3 Pi
		{
			[Intrinsic]
			get
			{
				return Vector3.Create(3.1415927f);
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060031F7 RID: 12791 RVA: 0x000A1870 File Offset: 0x0009FA70
		public static Vector3 PositiveInfinity
		{
			[Intrinsic]
			get
			{
				return Vector3.Create(float.PositiveInfinity);
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060031F8 RID: 12792 RVA: 0x000A187C File Offset: 0x0009FA7C
		public static Vector3 Tau
		{
			[Intrinsic]
			get
			{
				return Vector3.Create(6.2831855f);
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060031F9 RID: 12793 RVA: 0x000A1888 File Offset: 0x0009FA88
		public static Vector3 UnitX
		{
			[Intrinsic]
			get
			{
				return Vector3.CreateScalar(1f);
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060031FA RID: 12794 RVA: 0x000A1894 File Offset: 0x0009FA94
		public static Vector3 UnitY
		{
			[Intrinsic]
			get
			{
				return Vector3.Create(0f, 1f, 0f);
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x000A18AA File Offset: 0x0009FAAA
		public static Vector3 UnitZ
		{
			[Intrinsic]
			get
			{
				return Vector3.Create(0f, 0f, 1f);
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x000A18C0 File Offset: 0x0009FAC0
		public static Vector3 Zero
		{
			[Intrinsic]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000937 RID: 2359
		public float this[int index]
		{
			[Intrinsic]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				if (index >= 3)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
				}
				return this.AsVector128Unsafe().GetElement(index);
			}
			[Intrinsic]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
				if (index >= 3)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.index);
				}
				this = this.AsVector128Unsafe().WithElement(index, value).AsVector3();
			}
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x000A191E File Offset: 0x0009FB1E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator +(Vector3 left, Vector3 right)
		{
			return (left.AsVector128Unsafe() + right.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x000A1936 File Offset: 0x0009FB36
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator /(Vector3 left, Vector3 right)
		{
			return (left.AsVector128Unsafe() / right.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x000A194E File Offset: 0x0009FB4E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator /(Vector3 value1, float value2)
		{
			return (value1.AsVector128Unsafe() / value2).AsVector3();
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x000A1961 File Offset: 0x0009FB61
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Vector3 left, Vector3 right)
		{
			return left.AsVector128() == right.AsVector128();
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x000A1974 File Offset: 0x0009FB74
		[Intrinsic]
		public static bool operator !=(Vector3 left, Vector3 right)
		{
			return !(left == right);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x000A1980 File Offset: 0x0009FB80
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator *(Vector3 left, Vector3 right)
		{
			return (left.AsVector128Unsafe() * right.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x000A1998 File Offset: 0x0009FB98
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator *(Vector3 left, float right)
		{
			return (left.AsVector128Unsafe() * right).AsVector3();
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x000A19AB File Offset: 0x0009FBAB
		[Intrinsic]
		public static Vector3 operator *(float left, Vector3 right)
		{
			return right * left;
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x000A19B4 File Offset: 0x0009FBB4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator -(Vector3 left, Vector3 right)
		{
			return (left.AsVector128Unsafe() - right.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x000A19CC File Offset: 0x0009FBCC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 operator -(Vector3 value)
		{
			return (-value.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x000A19DE File Offset: 0x0009FBDE
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Abs(Vector3 value)
		{
			return Vector128.Abs<float>(value.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x000A19F0 File Offset: 0x0009FBF0
		[Intrinsic]
		public static Vector3 Add(Vector3 left, Vector3 right)
		{
			return left + right;
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x000A19F9 File Offset: 0x0009FBF9
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Clamp(Vector3 value1, Vector3 min, Vector3 max)
		{
			return Vector128.Clamp<float>(value1.AsVector128Unsafe(), min.AsVector128Unsafe(), max.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x000A1A17 File Offset: 0x0009FC17
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 ClampNative(Vector3 value1, Vector3 min, Vector3 max)
		{
			return Vector128.ClampNative<float>(value1.AsVector128Unsafe(), min.AsVector128Unsafe(), max.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x000A1A35 File Offset: 0x0009FC35
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 CopySign(Vector3 value, Vector3 sign)
		{
			return Vector128.CopySign<float>(value.AsVector128Unsafe(), sign.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x000A1A4D File Offset: 0x0009FC4D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Cos(Vector3 vector)
		{
			return Vector128.Cos(vector.AsVector128()).AsVector3();
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x000A1A5F File Offset: 0x0009FC5F
		[Intrinsic]
		public static Vector3 Create(float value)
		{
			return Vector128.Create(value).AsVector3();
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x000A1A6C File Offset: 0x0009FC6C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Create(Vector2 vector, float z)
		{
			return vector.AsVector128Unsafe().WithElement(2, z).AsVector3();
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x000A1A80 File Offset: 0x0009FC80
		[Intrinsic]
		public static Vector3 Create(float x, float y, float z)
		{
			return Vector128.Create(x, y, z, 0f).AsVector3();
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x000A1A94 File Offset: 0x0009FC94
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Create(ReadOnlySpan<float> values)
		{
			if (values.Length < 3)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.values);
			}
			return Unsafe.ReadUnaligned<Vector3>(Unsafe.As<float, byte>(MemoryMarshal.GetReference<float>(values)));
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x000A1AB6 File Offset: 0x0009FCB6
		[Intrinsic]
		internal static Vector3 CreateScalar(float x)
		{
			return Vector128.CreateScalar(x).AsVector3();
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x000A1AC4 File Offset: 0x0009FCC4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Cross(Vector3 vector1, Vector3 vector2)
		{
			Vector128<float> vector3 = vector1.AsVector128();
			Vector128<float> vector4 = vector2.AsVector128();
			Vector128<float> addend = Vector128.Shuffle(vector3, Vector128.Create(1, 2, 0, 3)) * Vector128.Shuffle(vector4, Vector128.Create(2, 0, 1, 3));
			return Vector128.MultiplyAddEstimate(-Vector128.Shuffle(vector3, Vector128.Create(2, 0, 1, 3)), Vector128.Shuffle(vector4, Vector128.Create(1, 2, 0, 3)), addend).AsVector3();
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x000A1B2F File Offset: 0x0009FD2F
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 DegreesToRadians(Vector3 degrees)
		{
			return Vector128.DegreesToRadians(degrees.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x000A1B41 File Offset: 0x0009FD41
		[Intrinsic]
		public static float Distance(Vector3 value1, Vector3 value2)
		{
			return float.Sqrt(Vector3.DistanceSquared(value1, value2));
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x000A1B50 File Offset: 0x0009FD50
		[Intrinsic]
		public static float DistanceSquared(Vector3 value1, Vector3 value2)
		{
			return (value1 - value2).LengthSquared();
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x000A1B6C File Offset: 0x0009FD6C
		[Intrinsic]
		public static Vector3 Divide(Vector3 left, Vector3 right)
		{
			return left / right;
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x000A1B75 File Offset: 0x0009FD75
		[Intrinsic]
		public static Vector3 Divide(Vector3 left, float divisor)
		{
			return left / divisor;
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x000A1B7E File Offset: 0x0009FD7E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(Vector3 vector1, Vector3 vector2)
		{
			return Vector128.Dot<float>(vector1.AsVector128(), vector2.AsVector128());
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x000A1B91 File Offset: 0x0009FD91
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Exp(Vector3 vector)
		{
			return Vector128.Exp(vector.AsVector128()).AsVector3();
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x000A1BA3 File Offset: 0x0009FDA3
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 FusedMultiplyAdd(Vector3 left, Vector3 right, Vector3 addend)
		{
			return Vector128.FusedMultiplyAdd(left.AsVector128Unsafe(), right.AsVector128Unsafe(), addend.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x000A1BC1 File Offset: 0x0009FDC1
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Hypot(Vector3 x, Vector3 y)
		{
			return Vector128.Hypot(x.AsVector128Unsafe(), y.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x000A1BD9 File Offset: 0x0009FDD9
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount)
		{
			return Vector3.Lerp(value1, value2, Vector3.Create(amount));
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x000A1BE8 File Offset: 0x0009FDE8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Lerp(Vector3 value1, Vector3 value2, Vector3 amount)
		{
			return Vector128.Lerp(value1.AsVector128Unsafe(), value2.AsVector128Unsafe(), amount.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x000A1C06 File Offset: 0x0009FE06
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Log(Vector3 vector)
		{
			return Vector128.Log(Vector4.Create(vector, 1f).AsVector128()).AsVector3();
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x000A1C22 File Offset: 0x0009FE22
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Log2(Vector3 vector)
		{
			return Vector128.Log2(Vector4.Create(vector, 1f).AsVector128()).AsVector3();
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x000A1C3E File Offset: 0x0009FE3E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Max(Vector3 value1, Vector3 value2)
		{
			return Vector128.Max<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x000A1C56 File Offset: 0x0009FE56
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MaxMagnitude(Vector3 value1, Vector3 value2)
		{
			return Vector128.MaxMagnitude<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x000A1C6E File Offset: 0x0009FE6E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MaxMagnitudeNumber(Vector3 value1, Vector3 value2)
		{
			return Vector128.MaxMagnitudeNumber<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x000A1C86 File Offset: 0x0009FE86
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MaxNative(Vector3 value1, Vector3 value2)
		{
			return Vector128.MaxNative<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x000A1C9E File Offset: 0x0009FE9E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MaxNumber(Vector3 value1, Vector3 value2)
		{
			return Vector128.MaxNumber<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x000A1CB6 File Offset: 0x0009FEB6
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Min(Vector3 value1, Vector3 value2)
		{
			return Vector128.Min<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x000A1CCE File Offset: 0x0009FECE
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MinMagnitude(Vector3 value1, Vector3 value2)
		{
			return Vector128.MinMagnitude<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x000A1CE6 File Offset: 0x0009FEE6
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MinMagnitudeNumber(Vector3 value1, Vector3 value2)
		{
			return Vector128.MinMagnitudeNumber<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x000A1CFE File Offset: 0x0009FEFE
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MinNative(Vector3 value1, Vector3 value2)
		{
			return Vector128.MinNative<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x000A1D16 File Offset: 0x0009FF16
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MinNumber(Vector3 value1, Vector3 value2)
		{
			return Vector128.MinNumber<float>(value1.AsVector128Unsafe(), value2.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x000A1D2E File Offset: 0x0009FF2E
		[Intrinsic]
		public static Vector3 Multiply(Vector3 left, Vector3 right)
		{
			return left * right;
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x000A1D37 File Offset: 0x0009FF37
		[Intrinsic]
		public static Vector3 Multiply(Vector3 left, float right)
		{
			return left * right;
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x000A1D40 File Offset: 0x0009FF40
		[Intrinsic]
		public static Vector3 Multiply(float left, Vector3 right)
		{
			return left * right;
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x000A1D49 File Offset: 0x0009FF49
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 MultiplyAddEstimate(Vector3 left, Vector3 right, Vector3 addend)
		{
			return Vector128.MultiplyAddEstimate(left.AsVector128Unsafe(), right.AsVector128Unsafe(), addend.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x000A1D67 File Offset: 0x0009FF67
		[Intrinsic]
		public static Vector3 Negate(Vector3 value)
		{
			return -value;
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x000A1D6F File Offset: 0x0009FF6F
		[Intrinsic]
		public static Vector3 Normalize(Vector3 value)
		{
			return value / value.Length();
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x000A1D7E File Offset: 0x0009FF7E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 RadiansToDegrees(Vector3 radians)
		{
			return Vector128.RadiansToDegrees(radians.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x000A1D90 File Offset: 0x0009FF90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Reflect(Vector3 vector, Vector3 normal)
		{
			Vector3 vector2 = Vector3.Create(Vector3.Dot(vector, normal));
			return Vector3.MultiplyAddEstimate(-(vector2 + vector2), normal, vector);
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x000A1DB0 File Offset: 0x0009FFB0
		[Intrinsic]
		public static Vector3 Round(Vector3 vector)
		{
			return Vector128.Round(vector.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x000A1DC2 File Offset: 0x0009FFC2
		[Intrinsic]
		public static Vector3 Round(Vector3 vector, MidpointRounding mode)
		{
			return Vector128.Round(vector.AsVector128Unsafe(), mode).AsVector3();
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x000A1DD5 File Offset: 0x0009FFD5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Sin(Vector3 vector)
		{
			return Vector128.Sin(vector.AsVector128()).AsVector3();
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x000A1DE8 File Offset: 0x0009FFE8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Sin",
			"Cos"
		})]
		public static ValueTuple<Vector3, Vector3> SinCos(Vector3 vector)
		{
			ValueTuple<Vector128<float>, Vector128<float>> valueTuple = Vector128.SinCos(vector.AsVector128());
			Vector128<float> item = valueTuple.Item1;
			Vector128<float> item2 = valueTuple.Item2;
			return new ValueTuple<Vector3, Vector3>(item.AsVector3(), item2.AsVector3());
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x000A1E1E File Offset: 0x000A001E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 SquareRoot(Vector3 value)
		{
			return Vector128.Sqrt<float>(value.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x000A1E30 File Offset: 0x000A0030
		[Intrinsic]
		public static Vector3 Subtract(Vector3 left, Vector3 right)
		{
			return left - right;
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x000A1E39 File Offset: 0x000A0039
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Transform(Vector3 position, Matrix4x4 matrix)
		{
			return Vector4.Transform(position, matrix.AsImpl()).AsVector128().AsVector3();
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x000A1E52 File Offset: 0x000A0052
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 Transform(Vector3 value, Quaternion rotation)
		{
			return Vector4.Transform(value, rotation).AsVector3();
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x000A1E60 File Offset: 0x000A0060
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 TransformNormal(Vector3 normal, Matrix4x4 matrix)
		{
			return Vector3.TransformNormal(normal, matrix.AsImpl());
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x000A1E70 File Offset: 0x000A0070
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector3 TransformNormal(Vector3 normal, in Matrix4x4.Impl matrix)
		{
			Vector4 vector = matrix.X * normal.X;
			vector = Vector4.MultiplyAddEstimate(matrix.Y, Vector4.Create(normal.Y), vector);
			vector = Vector4.MultiplyAddEstimate(matrix.Z, Vector4.Create(normal.Z), vector);
			return vector.AsVector3();
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x000A1EC5 File Offset: 0x000A00C5
		[Intrinsic]
		public static Vector3 Truncate(Vector3 vector)
		{
			return Vector128.Truncate(vector.AsVector128Unsafe()).AsVector3();
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x000A1ED7 File Offset: 0x000A00D7
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly void CopyTo(float[] array)
		{
			if (array.Length < 3)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector3>(Unsafe.As<float, byte>(ref array[0]), this);
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x000A1EFB File Offset: 0x000A00FB
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly void CopyTo(float[] array, int index)
		{
			if (index >= array.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
			}
			if (array.Length - index < 3)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector3>(Unsafe.As<float, byte>(ref array[index]), this);
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000A1F2C File Offset: 0x000A012C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly void CopyTo(Span<float> destination)
		{
			if (destination.Length < 3)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector3>(Unsafe.As<float, byte>(MemoryMarshal.GetReference<float>(destination)), this);
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x000A1F53 File Offset: 0x000A0153
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool TryCopyTo(Span<float> destination)
		{
			if (destination.Length < 3)
			{
				return false;
			}
			Unsafe.WriteUnaligned<Vector3>(Unsafe.As<float, byte>(MemoryMarshal.GetReference<float>(destination)), this);
			return true;
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x000A1F78 File Offset: 0x000A0178
		[NullableContext(2)]
		public override readonly bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Vector3)
			{
				Vector3 other = (Vector3)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x000A1FA0 File Offset: 0x000A01A0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(Vector3 other)
		{
			return this.AsVector128().Equals(other.AsVector128());
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x000A1FC6 File Offset: 0x000A01C6
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.X, this.Y, this.Z);
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x000A1FDF File Offset: 0x000A01DF
		[Intrinsic]
		public readonly float Length()
		{
			return float.Sqrt(this.LengthSquared());
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x000A1FEC File Offset: 0x000A01EC
		[Intrinsic]
		public readonly float LengthSquared()
		{
			return Vector3.Dot(this, this);
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x000A1FFF File Offset: 0x000A01FF
		[NullableContext(1)]
		public override readonly string ToString()
		{
			return this.ToString("G", CultureInfo.CurrentCulture);
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x000A2011 File Offset: 0x000A0211
		[NullableContext(1)]
		public readonly string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return this.ToString(format, CultureInfo.CurrentCulture);
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x000A2020 File Offset: 0x000A0220
		[NullableContext(2)]
		[return: Nullable(1)]
		public readonly string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider formatProvider)
		{
			string numberGroupSeparator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 5);
			defaultInterpolatedStringHandler.AppendLiteral("<");
			defaultInterpolatedStringHandler.AppendFormatted(this.X.ToString(format, formatProvider));
			defaultInterpolatedStringHandler.AppendFormatted(numberGroupSeparator);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(this.Y.ToString(format, formatProvider));
			defaultInterpolatedStringHandler.AppendFormatted(numberGroupSeparator);
			defaultInterpolatedStringHandler.AppendLiteral(" ");
			defaultInterpolatedStringHandler.AppendFormatted(this.Z.ToString(format, formatProvider));
			defaultInterpolatedStringHandler.AppendLiteral(">");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040008ED RID: 2285
		public float X;

		// Token: 0x040008EE RID: 2286
		public float Y;

		// Token: 0x040008EF RID: 2287
		public float Z;
	}
}
