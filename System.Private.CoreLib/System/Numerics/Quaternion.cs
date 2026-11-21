using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace System.Numerics
{
	// Token: 0x02000295 RID: 661
	[Intrinsic]
	public struct Quaternion : IEquatable<Quaternion>
	{
		// Token: 0x060030CE RID: 12494 RVA: 0x0009F580 File Offset: 0x0009D780
		[Intrinsic]
		public Quaternion(float x, float y, float z, float w)
		{
			this = Quaternion.Create(x, y, z, w);
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x0009F592 File Offset: 0x0009D792
		[Intrinsic]
		public Quaternion(Vector3 vectorPart, float scalarPart)
		{
			this = Quaternion.Create(vectorPart, scalarPart);
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060030D0 RID: 12496 RVA: 0x0009F5A4 File Offset: 0x0009D7A4
		public static Quaternion Zero
		{
			[Intrinsic]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x0009F5BA File Offset: 0x0009D7BA
		public static Quaternion Identity
		{
			[Intrinsic]
			get
			{
				return Quaternion.Create(0f, 0f, 0f, 1f);
			}
		}

		// Token: 0x17000911 RID: 2321
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
				this = this.AsVector128().WithElement(index, value).AsQuaternion();
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x0009F607 File Offset: 0x0009D807
		public readonly bool IsIdentity
		{
			get
			{
				return this == Quaternion.Identity;
			}
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x0009F619 File Offset: 0x0009D819
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion operator +(Quaternion value1, Quaternion value2)
		{
			return (value1.AsVector128() + value2.AsVector128()).AsQuaternion();
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x0009F631 File Offset: 0x0009D831
		public static Quaternion operator /(Quaternion value1, Quaternion value2)
		{
			return value1 * Quaternion.Inverse(value2);
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x0009F63F File Offset: 0x0009D83F
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Quaternion value1, Quaternion value2)
		{
			return value1.AsVector128() == value2.AsVector128();
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x0009F652 File Offset: 0x0009D852
		[Intrinsic]
		public static bool operator !=(Quaternion value1, Quaternion value2)
		{
			return !(value1 == value2);
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x0009F660 File Offset: 0x0009D860
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion operator *(Quaternion value1, Quaternion value2)
		{
			Vector128<float> vector = value1.AsVector128();
			Vector128<float> vector2 = value2.AsVector128();
			Vector128<float> vector3 = vector2 * vector.GetElement(3);
			vector3 = Vector128.MultiplyAddEstimate(Vector128.Shuffle(vector2, Vector128.Create(3, 2, 1, 0)) * vector.GetElement(0), Vector128.Create(1f, -1f, 1f, -1f), vector3);
			vector3 = Vector128.MultiplyAddEstimate(Vector128.Shuffle(vector2, Vector128.Create(2, 3, 0, 1)) * vector.GetElement(1), Vector128.Create(1f, 1f, -1f, -1f), vector3);
			vector3 = Vector128.MultiplyAddEstimate(Vector128.Shuffle(vector2, Vector128.Create(1, 0, 3, 2)) * vector.GetElement(2), Vector128.Create(-1f, 1f, 1f, -1f), vector3);
			return vector3.AsQuaternion();
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x0009F73E File Offset: 0x0009D93E
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion operator *(Quaternion value1, float value2)
		{
			return (value1.AsVector128() * value2).AsQuaternion();
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x0009F751 File Offset: 0x0009D951
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion operator -(Quaternion value1, Quaternion value2)
		{
			return (value1.AsVector128() - value2.AsVector128()).AsQuaternion();
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x0009F769 File Offset: 0x0009D969
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion operator -(Quaternion value)
		{
			return (-value.AsVector128()).AsQuaternion();
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x0009F77B File Offset: 0x0009D97B
		[Intrinsic]
		public static Quaternion Add(Quaternion value1, Quaternion value2)
		{
			return value1 + value2;
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x0009F784 File Offset: 0x0009D984
		public static Quaternion Concatenate(Quaternion value1, Quaternion value2)
		{
			return value2 * value1;
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x0009F78D File Offset: 0x0009D98D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Conjugate(Quaternion value)
		{
			return (value.AsVector128() * Vector128.Create(-1f, -1f, -1f, 1f)).AsQuaternion();
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x0009F7B8 File Offset: 0x0009D9B8
		[Intrinsic]
		internal static Quaternion Create(float x, float y, float z, float w)
		{
			return Vector128.Create(x, y, z, w).AsQuaternion();
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x0009F7C8 File Offset: 0x0009D9C8
		[Intrinsic]
		internal static Quaternion Create(Vector3 vectorPart, float scalarPart)
		{
			return Vector4.Create(vectorPart, scalarPart).AsQuaternion();
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x0009F7D8 File Offset: 0x0009D9D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion CreateFromAxisAngle(Vector3 axis, float angle)
		{
			ValueTuple<float, float> valueTuple = float.SinCos(angle * 0.5f);
			float item = valueTuple.Item1;
			float item2 = valueTuple.Item2;
			return (Vector4.Create(axis, 1f) * Vector4.Create(Vector3.Create(item), item2)).AsQuaternion();
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x0009F820 File Offset: 0x0009DA20
		public static Quaternion CreateFromRotationMatrix(Matrix4x4 matrix)
		{
			float num = matrix.M11 + matrix.M22 + matrix.M33;
			Quaternion result = default(Quaternion);
			if (num > 0f)
			{
				float num2 = float.Sqrt(num + 1f);
				result.W = num2 * 0.5f;
				num2 = 0.5f / num2;
				result.X = (matrix.M23 - matrix.M32) * num2;
				result.Y = (matrix.M31 - matrix.M13) * num2;
				result.Z = (matrix.M12 - matrix.M21) * num2;
			}
			else if (matrix.M11 >= matrix.M22 && matrix.M11 >= matrix.M33)
			{
				float num3 = float.Sqrt(1f + matrix.M11 - matrix.M22 - matrix.M33);
				float num4 = 0.5f / num3;
				result.X = 0.5f * num3;
				result.Y = (matrix.M12 + matrix.M21) * num4;
				result.Z = (matrix.M13 + matrix.M31) * num4;
				result.W = (matrix.M23 - matrix.M32) * num4;
			}
			else if (matrix.M22 > matrix.M33)
			{
				float num5 = float.Sqrt(1f + matrix.M22 - matrix.M11 - matrix.M33);
				float num6 = 0.5f / num5;
				result.X = (matrix.M21 + matrix.M12) * num6;
				result.Y = 0.5f * num5;
				result.Z = (matrix.M32 + matrix.M23) * num6;
				result.W = (matrix.M31 - matrix.M13) * num6;
			}
			else
			{
				float num7 = float.Sqrt(1f + matrix.M33 - matrix.M11 - matrix.M22);
				float num8 = 0.5f / num7;
				result.X = (matrix.M31 + matrix.M13) * num8;
				result.Y = (matrix.M32 + matrix.M23) * num8;
				result.Z = 0.5f * num7;
				result.W = (matrix.M12 - matrix.M21) * num8;
			}
			return result;
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x0009FA74 File Offset: 0x0009DC74
		public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll)
		{
			ValueTuple<Vector3, Vector3> valueTuple = Vector3.SinCos(Vector3.Create(roll, pitch, yaw) * 0.5f);
			Vector3 item = valueTuple.Item1;
			Vector3 item2 = valueTuple.Item2;
			float x = item.X;
			float x2 = item2.X;
			float num = x;
			float y = item.Y;
			float y2 = item2.Y;
			float num2 = y;
			float z = item.Z;
			float z2 = item2.Z;
			float num3 = z;
			Quaternion result;
			result.X = z2 * num2 * x2 + num3 * y2 * num;
			result.Y = num3 * y2 * x2 - z2 * num2 * num;
			result.Z = z2 * y2 * num - num3 * num2 * x2;
			result.W = z2 * y2 * x2 + num3 * num2 * num;
			return result;
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x0009FB31 File Offset: 0x0009DD31
		public static Quaternion Divide(Quaternion value1, Quaternion value2)
		{
			return value1 / value2;
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x0009FB3A File Offset: 0x0009DD3A
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(Quaternion quaternion1, Quaternion quaternion2)
		{
			return Vector128.Dot<float>(quaternion1.AsVector128(), quaternion2.AsVector128());
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x0009FB50 File Offset: 0x0009DD50
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Inverse(Quaternion value)
		{
			Vector128<float> vector = Vector128.Create(value.LengthSquared());
			return Vector128.AndNot<float>(Quaternion.Conjugate(value).AsVector128() / vector, Vector128.LessThanOrEqual<float>(vector, Vector128.Create(1.1920929E-07f))).AsQuaternion();
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x0009FB98 File Offset: 0x0009DD98
		public static Quaternion Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
		{
			Vector128<float> vector = quaternion2.AsVector128();
			vector = Vector128.ConditionalSelect<float>(Vector128.GreaterThanOrEqual<float>(Vector128.Create(Quaternion.Dot(quaternion1, quaternion2)), Vector128<float>.Zero), vector, -vector);
			return Quaternion.Normalize(Vector128.MultiplyAddEstimate(quaternion1.AsVector128(), Vector128.Create(1f - amount), vector * amount).AsQuaternion());
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x0009FBF7 File Offset: 0x0009DDF7
		public static Quaternion Multiply(Quaternion value1, Quaternion value2)
		{
			return value1 * value2;
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x0009FC00 File Offset: 0x0009DE00
		[Intrinsic]
		public static Quaternion Multiply(Quaternion value1, float value2)
		{
			return value1 * value2;
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x0009FC09 File Offset: 0x0009DE09
		[Intrinsic]
		public static Quaternion Negate(Quaternion value)
		{
			return -value;
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x0009FC11 File Offset: 0x0009DE11
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Quaternion Normalize(Quaternion value)
		{
			return (value.AsVector128() / value.Length()).AsQuaternion();
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x0009FC2C File Offset: 0x0009DE2C
		public static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
		{
			float num = Quaternion.Dot(quaternion1, quaternion2);
			float num2 = 1f;
			if (num < 0f)
			{
				num = -num;
				num2 = -1f;
			}
			float value;
			float value2;
			if (num > 0.999999f)
			{
				value = 1f - amount;
				value2 = amount * num2;
			}
			else
			{
				float num3 = float.Acos(num);
				float num4 = 1f / float.Sin(num3);
				value = float.Sin((1f - amount) * num3) * num4;
				value2 = float.Sin(amount * num3) * num4 * num2;
			}
			return quaternion1 * value + quaternion2 * value2;
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x0009FCBA File Offset: 0x0009DEBA
		[Intrinsic]
		public static Quaternion Subtract(Quaternion value1, Quaternion value2)
		{
			return value1 - value2;
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x0009FCC4 File Offset: 0x0009DEC4
		[NullableContext(2)]
		public override readonly bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Quaternion)
			{
				Quaternion other = (Quaternion)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x0009FCEC File Offset: 0x0009DEEC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(Quaternion other)
		{
			return this.AsVector128().Equals(other.AsVector128());
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x0009FD12 File Offset: 0x0009DF12
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x0009FD31 File Offset: 0x0009DF31
		[Intrinsic]
		public readonly float Length()
		{
			return float.Sqrt(this.LengthSquared());
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x0009FD3E File Offset: 0x0009DF3E
		[Intrinsic]
		public readonly float LengthSquared()
		{
			return Quaternion.Dot(this, this);
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x0009FD54 File Offset: 0x0009DF54
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 4);
			defaultInterpolatedStringHandler.AppendLiteral("{X:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(" Y:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Y);
			defaultInterpolatedStringHandler.AppendLiteral(" Z:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Z);
			defaultInterpolatedStringHandler.AppendLiteral(" W:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.W);
			defaultInterpolatedStringHandler.AppendLiteral("}");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040008E5 RID: 2277
		public float X;

		// Token: 0x040008E6 RID: 2278
		public float Y;

		// Token: 0x040008E7 RID: 2279
		public float Z;

		// Token: 0x040008E8 RID: 2280
		public float W;
	}
}
