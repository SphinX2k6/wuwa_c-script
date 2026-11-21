using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace System.Numerics
{
	// Token: 0x02000293 RID: 659
	[Intrinsic]
	public struct Plane : IEquatable<Plane>
	{
		// Token: 0x06002FD4 RID: 12244 RVA: 0x0009CB87 File Offset: 0x0009AD87
		[Intrinsic]
		public Plane(float x, float y, float z, float d)
		{
			this = Plane.Create(x, y, z, d);
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x0009CB99 File Offset: 0x0009AD99
		[Intrinsic]
		public Plane(Vector3 normal, float d)
		{
			this = Plane.Create(normal, d);
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x0009CBA8 File Offset: 0x0009ADA8
		[Intrinsic]
		public Plane(Vector4 value)
		{
			this = value.AsPlane();
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x0009CBB6 File Offset: 0x0009ADB6
		[Intrinsic]
		internal static Plane Create(float x, float y, float z, float d)
		{
			return Vector128.Create(x, y, z, d).AsPlane();
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x0009CBC6 File Offset: 0x0009ADC6
		[Intrinsic]
		internal static Plane Create(Vector3 normal, float d)
		{
			return Vector4.Create(normal, d).AsPlane();
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x0009CBD4 File Offset: 0x0009ADD4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Plane CreateFromVertices(Vector3 point1, Vector3 point2, Vector3 point3)
		{
			Vector3 vector = Vector3.Normalize(Vector3.Cross(point2 - point1, point3 - point1));
			return Plane.Create(vector, -Vector3.Dot(vector, point1));
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x0009CBFB File Offset: 0x0009ADFB
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Dot(Plane plane, Vector4 value)
		{
			return Vector128.Dot<float>(plane.AsVector128(), value.AsVector128());
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x0009CC0E File Offset: 0x0009AE0E
		public static float DotCoordinate(Plane plane, Vector3 value)
		{
			return Plane.Dot(plane, Vector4.Create(value, 1f));
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x0009CC21 File Offset: 0x0009AE21
		public static float DotNormal(Plane plane, Vector3 value)
		{
			return Vector3.Dot(plane.Normal, value);
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x0009CC30 File Offset: 0x0009AE30
		public static Plane Normalize(Plane value)
		{
			Vector128<float> vector = Vector128.Create(value.Normal.LengthSquared());
			return Vector128.AndNot<float>(value.AsVector128() / Vector128.Sqrt<float>(vector), Vector128.Equals<float>(vector, Vector128.Create(float.PositiveInfinity))).AsPlane();
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x0009CC7C File Offset: 0x0009AE7C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Plane Transform(Plane plane, Matrix4x4 matrix)
		{
			Matrix4x4.Impl impl;
			Matrix4x4.Impl.Invert(matrix.AsImpl(), out impl);
			Vector4 vector = plane.AsVector4();
			Matrix4x4.Impl impl2 = Matrix4x4.Impl.Transpose(impl);
			return Vector4.Transform(vector, impl2).AsPlane();
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x0009CCB2 File Offset: 0x0009AEB2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Plane Transform(Plane plane, Quaternion rotation)
		{
			return Vector4.Transform(plane.AsVector4(), rotation).AsPlane();
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x0009CCC5 File Offset: 0x0009AEC5
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Plane value1, Plane value2)
		{
			return value1.AsVector128() == value2.AsVector128();
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x0009CCD8 File Offset: 0x0009AED8
		[Intrinsic]
		public static bool operator !=(Plane value1, Plane value2)
		{
			return !(value1 == value2);
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x0009CCE4 File Offset: 0x0009AEE4
		[NullableContext(2)]
		public override readonly bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Plane)
			{
				Plane other = (Plane)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x0009CD0C File Offset: 0x0009AF0C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(Plane other)
		{
			return this.AsVector128().Equals(other.AsVector128());
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x0009CD32 File Offset: 0x0009AF32
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<Vector3, float>(this.Normal, this.D);
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x0009CD48 File Offset: 0x0009AF48
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("{Normal:");
			defaultInterpolatedStringHandler.AppendFormatted<Vector3>(this.Normal);
			defaultInterpolatedStringHandler.AppendLiteral(" D:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.D);
			defaultInterpolatedStringHandler.AppendLiteral("}");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040008E3 RID: 2275
		public Vector3 Normal;

		// Token: 0x040008E4 RID: 2276
		public float D;
	}
}
