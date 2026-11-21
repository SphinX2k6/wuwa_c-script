using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Numerics
{
	// Token: 0x0200028F RID: 655
	[Intrinsic]
	public struct Matrix3x2 : IEquatable<Matrix3x2>
	{
		// Token: 0x06002F03 RID: 12035 RVA: 0x00097F69 File Offset: 0x00096169
		public Matrix3x2(float m11, float m12, float m21, float m22, float m31, float m32)
		{
			Unsafe.SkipInit<Matrix3x2>(out this);
			this.AsImpl().Init(m11, m12, m21, m22, m31, m32);
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06002F04 RID: 12036 RVA: 0x00097F88 File Offset: 0x00096188
		public unsafe static Matrix3x2 Identity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return *Matrix3x2.Impl.Identity.AsM3x2();
			}
		}

		// Token: 0x170008FE RID: 2302
		public float this[int row, int column]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return this.AsROImpl()[row, column];
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
				this.AsImpl()[row, column] = value;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x00097FC6 File Offset: 0x000961C6
		public readonly bool IsIdentity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.AsROImpl().IsIdentity;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002F08 RID: 12040 RVA: 0x00097FD3 File Offset: 0x000961D3
		// (set) Token: 0x06002F09 RID: 12041 RVA: 0x00097FE0 File Offset: 0x000961E0
		public Vector2 Translation
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			readonly get
			{
				return this.AsROImpl().Translation;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
				this.AsImpl().Translation = value;
			}
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00097FF0 File Offset: 0x000961F0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix3x2 operator +(Matrix3x2 value1, Matrix3x2 value2)
		{
			return *(value1.AsImpl() + value2.AsImpl()).AsM3x2();
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x0009801D File Offset: 0x0009621D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Matrix3x2 value1, Matrix3x2 value2)
		{
			return value1.AsImpl() == value2.AsImpl();
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x00098032 File Offset: 0x00096232
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Matrix3x2 value1, Matrix3x2 value2)
		{
			return value1.AsImpl() != value2.AsImpl();
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x00098048 File Offset: 0x00096248
		public unsafe static Matrix3x2 operator *(Matrix3x2 value1, Matrix3x2 value2)
		{
			return *(value1.AsImpl() * value2.AsImpl()).AsM3x2();
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x00098078 File Offset: 0x00096278
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix3x2 operator *(Matrix3x2 value1, float value2)
		{
			return *(value1.AsImpl() * value2).AsM3x2();
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x000980A0 File Offset: 0x000962A0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix3x2 operator -(Matrix3x2 value1, Matrix3x2 value2)
		{
			return *(value1.AsImpl() - value2.AsImpl()).AsM3x2();
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x000980D0 File Offset: 0x000962D0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix3x2 operator -(Matrix3x2 value)
		{
			return *(-value.AsImpl()).AsM3x2();
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x000980F8 File Offset: 0x000962F8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix3x2 Add(Matrix3x2 value1, Matrix3x2 value2)
		{
			return *(value1.AsImpl() + value2.AsImpl()).AsM3x2();
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x00098128 File Offset: 0x00096328
		public unsafe static Matrix3x2 CreateRotation(float radians)
		{
			return *Matrix3x2.Impl.CreateRotation(radians).AsM3x2();
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x00098148 File Offset: 0x00096348
		public unsafe static Matrix3x2 CreateRotation(float radians, Vector2 centerPoint)
		{
			return *Matrix3x2.Impl.CreateRotation(radians, centerPoint).AsM3x2();
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x0009816C File Offset: 0x0009636C
		public unsafe static Matrix3x2 CreateScale(Vector2 scales)
		{
			return *Matrix3x2.Impl.CreateScale(scales).AsM3x2();
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x0009818C File Offset: 0x0009638C
		public unsafe static Matrix3x2 CreateScale(float xScale, float yScale)
		{
			return *Matrix3x2.Impl.CreateScale(xScale, yScale).AsM3x2();
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x000981B0 File Offset: 0x000963B0
		public unsafe static Matrix3x2 CreateScale(float xScale, float yScale, Vector2 centerPoint)
		{
			return *Matrix3x2.Impl.CreateScale(xScale, yScale, centerPoint).AsM3x2();
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x000981D4 File Offset: 0x000963D4
		public unsafe static Matrix3x2 CreateScale(Vector2 scales, Vector2 centerPoint)
		{
			return *Matrix3x2.Impl.CreateScale(scales, centerPoint).AsM3x2();
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x000981F8 File Offset: 0x000963F8
		public unsafe static Matrix3x2 CreateScale(float scale)
		{
			return *Matrix3x2.Impl.CreateScale(scale).AsM3x2();
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x00098218 File Offset: 0x00096418
		public unsafe static Matrix3x2 CreateScale(float scale, Vector2 centerPoint)
		{
			return *Matrix3x2.Impl.CreateScale(scale, centerPoint).AsM3x2();
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x0009823C File Offset: 0x0009643C
		public unsafe static Matrix3x2 CreateSkew(float radiansX, float radiansY)
		{
			return *Matrix3x2.Impl.CreateSkew(radiansX, radiansY).AsM3x2();
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x00098260 File Offset: 0x00096460
		public unsafe static Matrix3x2 CreateSkew(float radiansX, float radiansY, Vector2 centerPoint)
		{
			return *Matrix3x2.Impl.CreateSkew(radiansX, radiansY, centerPoint).AsM3x2();
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x00098284 File Offset: 0x00096484
		public unsafe static Matrix3x2 CreateTranslation(Vector2 position)
		{
			return *Matrix3x2.Impl.CreateTranslation(position).AsM3x2();
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x000982A4 File Offset: 0x000964A4
		public unsafe static Matrix3x2 CreateTranslation(float xPosition, float yPosition)
		{
			return *Matrix3x2.Impl.CreateTranslation(xPosition, yPosition).AsM3x2();
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x000982C5 File Offset: 0x000964C5
		public static bool Invert(Matrix3x2 matrix, out Matrix3x2 result)
		{
			Unsafe.SkipInit<Matrix3x2>(out result);
			return Matrix3x2.Impl.Invert(matrix.AsImpl(), result.AsImpl());
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x000982E0 File Offset: 0x000964E0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix3x2 Lerp(Matrix3x2 matrix1, Matrix3x2 matrix2, float amount)
		{
			return *Matrix3x2.Impl.Lerp(matrix1.AsImpl(), matrix2.AsImpl(), amount).AsM3x2();
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x00098310 File Offset: 0x00096510
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix3x2 Multiply(Matrix3x2 value1, Matrix3x2 value2)
		{
			return *(value1.AsImpl() * value2.AsImpl()).AsM3x2();
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x00098340 File Offset: 0x00096540
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix3x2 Multiply(Matrix3x2 value1, float value2)
		{
			return *(value1.AsImpl() * value2).AsM3x2();
		}

		// Token: 0x06002F22 RID: 12066 RVA: 0x00098368 File Offset: 0x00096568
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix3x2 Negate(Matrix3x2 value)
		{
			return *(-value.AsImpl()).AsM3x2();
		}

		// Token: 0x06002F23 RID: 12067 RVA: 0x00098390 File Offset: 0x00096590
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix3x2 Subtract(Matrix3x2 value1, Matrix3x2 value2)
		{
			return *(value1.AsImpl() - value2.AsImpl()).AsM3x2();
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x000983BD File Offset: 0x000965BD
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly bool Equals([NotNullWhen(true)] object obj)
		{
			return this.AsROImpl().Equals(obj);
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x000983D1 File Offset: 0x000965D1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(Matrix3x2 other)
		{
			return this.AsROImpl().Equals(other.AsImpl());
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x000983E5 File Offset: 0x000965E5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly float GetDeterminant()
		{
			return this.AsROImpl().GetDeterminant();
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x000983F2 File Offset: 0x000965F2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly int GetHashCode()
		{
			return this.AsROImpl().GetHashCode();
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00098408 File Offset: 0x00096608
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 6);
			defaultInterpolatedStringHandler.AppendLiteral("{ {M11:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M11);
			defaultInterpolatedStringHandler.AppendLiteral(" M12:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M12);
			defaultInterpolatedStringHandler.AppendLiteral("} {M21:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M21);
			defaultInterpolatedStringHandler.AppendLiteral(" M22:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M22);
			defaultInterpolatedStringHandler.AppendLiteral("} {M31:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M31);
			defaultInterpolatedStringHandler.AppendLiteral(" M32:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M32);
			defaultInterpolatedStringHandler.AppendLiteral("} }");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x000984C8 File Offset: 0x000966C8
		[UnscopedRef]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ref Matrix3x2.Impl AsImpl()
		{
			return Unsafe.As<Matrix3x2, Matrix3x2.Impl>(ref this);
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x000984D0 File Offset: 0x000966D0
		[UnscopedRef]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal readonly ref readonly Matrix3x2.Impl AsROImpl()
		{
			return Unsafe.As<Matrix3x2, Matrix3x2.Impl>(Unsafe.AsRef<Matrix3x2>(ref this));
		}

		// Token: 0x040008C6 RID: 2246
		public float M11;

		// Token: 0x040008C7 RID: 2247
		public float M12;

		// Token: 0x040008C8 RID: 2248
		public float M21;

		// Token: 0x040008C9 RID: 2249
		public float M22;

		// Token: 0x040008CA RID: 2250
		public float M31;

		// Token: 0x040008CB RID: 2251
		public float M32;

		// Token: 0x02000290 RID: 656
		internal struct Impl : IEquatable<Matrix3x2.Impl>
		{
			// Token: 0x06002F2B RID: 12075 RVA: 0x000984DD File Offset: 0x000966DD
			[UnscopedRef]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public ref Matrix3x2 AsM3x2()
			{
				return Unsafe.As<Matrix3x2.Impl, Matrix3x2>(ref this);
			}

			// Token: 0x06002F2C RID: 12076 RVA: 0x000984E5 File Offset: 0x000966E5
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Init(float m11, float m12, float m21, float m22, float m31, float m32)
			{
				this.X = Vector2.Create(m11, m12);
				this.Y = Vector2.Create(m21, m22);
				this.Z = Vector2.Create(m31, m32);
			}

			// Token: 0x17000901 RID: 2305
			// (get) Token: 0x06002F2D RID: 12077 RVA: 0x00098514 File Offset: 0x00096714
			public static Matrix3x2.Impl Identity
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					Matrix3x2.Impl result;
					result.X = Vector2.UnitX;
					result.Y = Vector2.UnitY;
					result.Z = Vector2.Zero;
					return result;
				}
			}

			// Token: 0x17000902 RID: 2306
			public float this[int row, int column]
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				readonly get
				{
					if (row >= 3)
					{
						ThrowHelper.ThrowArgumentOutOfRangeException();
					}
					return Unsafe.Add<Vector2>(Unsafe.AsRef<Vector2>(ref this.X), row)[column];
				}
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				set
				{
					if (row >= 3)
					{
						ThrowHelper.ThrowArgumentOutOfRangeException();
					}
					Unsafe.Add<Vector2>(ref this.X, row)[column] = value;
				}
			}

			// Token: 0x17000903 RID: 2307
			// (get) Token: 0x06002F30 RID: 12080 RVA: 0x00098586 File Offset: 0x00096786
			public readonly bool IsIdentity
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return this.X == Vector2.UnitX && this.Y == Vector2.UnitY && this.Z == Vector2.Zero;
				}
			}

			// Token: 0x17000904 RID: 2308
			// (get) Token: 0x06002F31 RID: 12081 RVA: 0x000985BE File Offset: 0x000967BE
			// (set) Token: 0x06002F32 RID: 12082 RVA: 0x000985C6 File Offset: 0x000967C6
			public Vector2 Translation
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				readonly get
				{
					return this.Z;
				}
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				set
				{
					this.Z = value;
				}
			}

			// Token: 0x06002F33 RID: 12083 RVA: 0x000985D0 File Offset: 0x000967D0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl operator +(in Matrix3x2.Impl left, in Matrix3x2.Impl right)
			{
				Matrix3x2.Impl result;
				result.X = left.X + right.X;
				result.Y = left.Y + right.Y;
				result.Z = left.Z + right.Z;
				return result;
			}

			// Token: 0x06002F34 RID: 12084 RVA: 0x00098626 File Offset: 0x00096826
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool operator ==(in Matrix3x2.Impl left, in Matrix3x2.Impl right)
			{
				return left.X == right.X && left.Y == right.Y && left.Z == right.Z;
			}

			// Token: 0x06002F35 RID: 12085 RVA: 0x00098661 File Offset: 0x00096861
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool operator !=(in Matrix3x2.Impl left, in Matrix3x2.Impl right)
			{
				return left.X != right.X || left.Y != right.Y || left.Z != right.Z;
			}

			// Token: 0x06002F36 RID: 12086 RVA: 0x0009869C File Offset: 0x0009689C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl operator *(in Matrix3x2.Impl left, in Matrix3x2.Impl right)
			{
				Matrix3x2.Impl result;
				result.X = Vector2.Create(left.X.X * right.X.X + left.X.Y * right.Y.X, left.X.X * right.X.Y + left.X.Y * right.Y.Y);
				result.Y = Vector2.Create(left.Y.X * right.X.X + left.Y.Y * right.Y.X, left.Y.X * right.X.Y + left.Y.Y * right.Y.Y);
				result.Z = Vector2.Create(left.Z.X * right.X.X + left.Z.Y * right.Y.X + right.Z.X, left.Z.X * right.X.Y + left.Z.Y * right.Y.Y + right.Z.Y);
				return result;
			}

			// Token: 0x06002F37 RID: 12087 RVA: 0x00098800 File Offset: 0x00096A00
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl operator *(in Matrix3x2.Impl left, float right)
			{
				Matrix3x2.Impl result;
				result.X = left.X * right;
				result.Y = left.Y * right;
				result.Z = left.Z * right;
				return result;
			}

			// Token: 0x06002F38 RID: 12088 RVA: 0x00098848 File Offset: 0x00096A48
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl operator -(in Matrix3x2.Impl left, in Matrix3x2.Impl right)
			{
				Matrix3x2.Impl result;
				result.X = left.X - right.X;
				result.Y = left.Y - right.Y;
				result.Z = left.Z - right.Z;
				return result;
			}

			// Token: 0x06002F39 RID: 12089 RVA: 0x000988A0 File Offset: 0x00096AA0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl operator -(in Matrix3x2.Impl value)
			{
				Matrix3x2.Impl result;
				result.X = -value.X;
				result.Y = -value.Y;
				result.Z = -value.Z;
				return result;
			}

			// Token: 0x06002F3A RID: 12090 RVA: 0x000988E4 File Offset: 0x00096AE4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateRotation(float radians)
			{
				radians = float.Ieee754Remainder(radians, 6.2831855f);
				float num;
				float num2;
				if (radians > -1.7453294E-05f && radians < 1.7453294E-05f)
				{
					num = 1f;
					num2 = 0f;
				}
				else if (radians > 1.570779f && radians < 1.5708138f)
				{
					num = 0f;
					num2 = 1f;
				}
				else if (radians < -3.1415753f || radians > 3.1415753f)
				{
					num = -1f;
					num2 = 0f;
				}
				else if (radians > -1.5708138f && radians < -1.570779f)
				{
					num = 0f;
					num2 = -1f;
				}
				else
				{
					ValueTuple<float, float> valueTuple = float.SinCos(radians);
					num2 = valueTuple.Item1;
					num = valueTuple.Item2;
				}
				Matrix3x2.Impl result;
				result.X = Vector2.Create(num, num2);
				result.Y = Vector2.Create(-num2, num);
				result.Z = Vector2.Zero;
				return result;
			}

			// Token: 0x06002F3B RID: 12091 RVA: 0x000989B4 File Offset: 0x00096BB4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateRotation(float radians, Vector2 centerPoint)
			{
				radians = float.Ieee754Remainder(radians, 6.2831855f);
				float num;
				float num2;
				if (radians > -1.7453294E-05f && radians < 1.7453294E-05f)
				{
					num = 1f;
					num2 = 0f;
				}
				else if (radians > 1.570779f && radians < 1.5708138f)
				{
					num = 0f;
					num2 = 1f;
				}
				else if (radians < -3.1415753f || radians > 3.1415753f)
				{
					num = -1f;
					num2 = 0f;
				}
				else if (radians > -1.5708138f && radians < -1.570779f)
				{
					num = 0f;
					num2 = -1f;
				}
				else
				{
					ValueTuple<float, float> valueTuple = float.SinCos(radians);
					num2 = valueTuple.Item1;
					num = valueTuple.Item2;
				}
				float x = centerPoint.X * (1f - num) + centerPoint.Y * num2;
				float y = centerPoint.Y * (1f - num) - centerPoint.X * num2;
				Matrix3x2.Impl result;
				result.X = Vector2.Create(num, num2);
				result.Y = Vector2.Create(-num2, num);
				result.Z = Vector2.Create(x, y);
				return result;
			}

			// Token: 0x06002F3C RID: 12092 RVA: 0x00098AB8 File Offset: 0x00096CB8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateScale(Vector2 scales)
			{
				Matrix3x2.Impl result;
				result.X = Vector2.CreateScalar(scales.X);
				result.Y = Vector2.Create(0f, scales.Y);
				result.Z = Vector2.Zero;
				return result;
			}

			// Token: 0x06002F3D RID: 12093 RVA: 0x00098AFC File Offset: 0x00096CFC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateScale(float scaleX, float scaleY)
			{
				Matrix3x2.Impl result;
				result.X = Vector2.CreateScalar(scaleX);
				result.Y = Vector2.Create(0f, scaleY);
				result.Z = Vector2.Zero;
				return result;
			}

			// Token: 0x06002F3E RID: 12094 RVA: 0x00098B38 File Offset: 0x00096D38
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateScale(float scaleX, float scaleY, Vector2 centerPoint)
			{
				Matrix3x2.Impl result;
				result.X = Vector2.CreateScalar(scaleX);
				result.Y = Vector2.Create(0f, scaleY);
				result.Z = centerPoint * (Vector2.One - Vector2.Create(scaleX, scaleY));
				return result;
			}

			// Token: 0x06002F3F RID: 12095 RVA: 0x00098B84 File Offset: 0x00096D84
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateScale(Vector2 scales, Vector2 centerPoint)
			{
				Matrix3x2.Impl result;
				result.X = Vector2.CreateScalar(scales.X);
				result.Y = Vector2.Create(0f, scales.Y);
				result.Z = centerPoint * (Vector2.One - scales);
				return result;
			}

			// Token: 0x06002F40 RID: 12096 RVA: 0x00098BD4 File Offset: 0x00096DD4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateScale(float scale)
			{
				Matrix3x2.Impl result;
				result.X = Vector2.CreateScalar(scale);
				result.Y = Vector2.Create(0f, scale);
				result.Z = Vector2.Zero;
				return result;
			}

			// Token: 0x06002F41 RID: 12097 RVA: 0x00098C10 File Offset: 0x00096E10
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateScale(float scale, Vector2 centerPoint)
			{
				Matrix3x2.Impl result;
				result.X = Vector2.CreateScalar(scale);
				result.Y = Vector2.Create(0f, scale);
				result.Z = centerPoint * (Vector2.One - Vector2.Create(scale));
				return result;
			}

			// Token: 0x06002F42 RID: 12098 RVA: 0x00098C5C File Offset: 0x00096E5C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateSkew(float radiansX, float radiansY)
			{
				Matrix3x2.Impl result;
				result.X = Vector2.Create(1f, float.Tan(radiansY));
				result.Y = Vector2.Create(float.Tan(radiansX), 1f);
				result.Z = Vector2.Zero;
				return result;
			}

			// Token: 0x06002F43 RID: 12099 RVA: 0x00098CA4 File Offset: 0x00096EA4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateSkew(float radiansX, float radiansY, Vector2 centerPoint)
			{
				float num = float.Tan(radiansX);
				float num2 = float.Tan(radiansY);
				float x = -centerPoint.Y * num;
				float y = -centerPoint.X * num2;
				Matrix3x2.Impl result;
				result.X = Vector2.Create(1f, num2);
				result.Y = Vector2.Create(num, 1f);
				result.Z = Vector2.Create(x, y);
				return result;
			}

			// Token: 0x06002F44 RID: 12100 RVA: 0x00098D08 File Offset: 0x00096F08
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateTranslation(Vector2 position)
			{
				Matrix3x2.Impl result;
				result.X = Vector2.UnitX;
				result.Y = Vector2.UnitY;
				result.Z = position;
				return result;
			}

			// Token: 0x06002F45 RID: 12101 RVA: 0x00098D38 File Offset: 0x00096F38
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl CreateTranslation(float positionX, float positionY)
			{
				Matrix3x2.Impl result;
				result.X = Vector2.UnitX;
				result.Y = Vector2.UnitY;
				result.Z = Vector2.Create(positionX, positionY);
				return result;
			}

			// Token: 0x06002F46 RID: 12102 RVA: 0x00098D6C File Offset: 0x00096F6C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool Invert(in Matrix3x2.Impl matrix, out Matrix3x2.Impl result)
			{
				float num = matrix.X.X * matrix.Y.Y - matrix.Y.X * matrix.X.Y;
				if (float.Abs(num) < 1E-45f)
				{
					Vector2 vector = Vector2.Create(float.NaN);
					result.X = vector;
					result.Y = vector;
					result.Z = vector;
					return false;
				}
				float num2 = 1f / num;
				result.X = Vector2.Create(matrix.Y.Y * num2, -matrix.X.Y * num2);
				result.Y = Vector2.Create(-matrix.Y.X * num2, matrix.X.X * num2);
				result.Z = Vector2.Create((matrix.Y.X * matrix.Z.Y - matrix.Z.X * matrix.Y.Y) * num2, (matrix.Z.X * matrix.X.Y - matrix.X.X * matrix.Z.Y) * num2);
				return true;
			}

			// Token: 0x06002F47 RID: 12103 RVA: 0x00098E9C File Offset: 0x0009709C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix3x2.Impl Lerp(in Matrix3x2.Impl left, in Matrix3x2.Impl right, float amount)
			{
				Matrix3x2.Impl result;
				result.X = Vector2.Lerp(left.X, right.X, amount);
				result.Y = Vector2.Lerp(left.Y, right.Y, amount);
				result.Z = Vector2.Lerp(left.Z, right.Z, amount);
				return result;
			}

			// Token: 0x06002F48 RID: 12104 RVA: 0x00098EF8 File Offset: 0x000970F8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public override readonly bool Equals([NotNullWhen(true)] object obj)
			{
				return obj is Matrix3x2 && this.Equals(((Matrix3x2)obj).AsImpl());
			}

			// Token: 0x06002F49 RID: 12105 RVA: 0x00098F23 File Offset: 0x00097123
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public readonly bool Equals(in Matrix3x2.Impl other)
			{
				return this.X.Equals(other.X) && this.Y.Equals(other.Y) && this.Z.Equals(other.Z);
			}

			// Token: 0x06002F4A RID: 12106 RVA: 0x00098F5E File Offset: 0x0009715E
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public readonly float GetDeterminant()
			{
				return this.X.X * this.Y.Y - this.Y.X * this.X.Y;
			}

			// Token: 0x06002F4B RID: 12107 RVA: 0x00098F8F File Offset: 0x0009718F
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public override readonly int GetHashCode()
			{
				return HashCode.Combine<Vector2, Vector2, Vector2>(this.X, this.Y, this.Z);
			}

			// Token: 0x06002F4C RID: 12108 RVA: 0x00098FA8 File Offset: 0x000971A8
			readonly bool IEquatable<Matrix3x2.Impl>.Equals(Matrix3x2.Impl other)
			{
				return this.Equals(other);
			}

			// Token: 0x040008CC RID: 2252
			public Vector2 X;

			// Token: 0x040008CD RID: 2253
			public Vector2 Y;

			// Token: 0x040008CE RID: 2254
			public Vector2 Z;
		}
	}
}
