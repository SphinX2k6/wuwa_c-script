using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace System.Numerics
{
	// Token: 0x02000291 RID: 657
	[Intrinsic]
	public struct Matrix4x4 : IEquatable<Matrix4x4>
	{
		// Token: 0x06002F4D RID: 12109 RVA: 0x00098FB4 File Offset: 0x000971B4
		public Matrix4x4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
		{
			Unsafe.SkipInit<Matrix4x4>(out this);
			this.AsImpl().Init(m11, m12, m13, m14, m21, m22, m23, m24, m31, m32, m33, m34, m41, m42, m43, m44);
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x00098FEF File Offset: 0x000971EF
		public Matrix4x4(Matrix3x2 value)
		{
			Unsafe.SkipInit<Matrix4x4>(out this);
			this.AsImpl().Init(value.AsImpl());
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06002F4F RID: 12111 RVA: 0x0009900C File Offset: 0x0009720C
		public unsafe static Matrix4x4 Identity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return *Matrix4x4.Impl.Identity.AsM4x4();
			}
		}

		// Token: 0x17000906 RID: 2310
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

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06002F52 RID: 12114 RVA: 0x0009904A File Offset: 0x0009724A
		public readonly bool IsIdentity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return this.AsROImpl().IsIdentity;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002F53 RID: 12115 RVA: 0x00099057 File Offset: 0x00097257
		// (set) Token: 0x06002F54 RID: 12116 RVA: 0x00099064 File Offset: 0x00097264
		public Vector3 Translation
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

		// Token: 0x06002F55 RID: 12117 RVA: 0x00099074 File Offset: 0x00097274
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix4x4 operator +(Matrix4x4 value1, Matrix4x4 value2)
		{
			return *(value1.AsImpl() + value2.AsImpl()).AsM4x4();
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x000990A1 File Offset: 0x000972A1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Matrix4x4 value1, Matrix4x4 value2)
		{
			return value1.AsImpl() == value2.AsImpl();
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x000990B6 File Offset: 0x000972B6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Matrix4x4 value1, Matrix4x4 value2)
		{
			return value1.AsImpl() != value2.AsImpl();
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x000990CC File Offset: 0x000972CC
		public unsafe static Matrix4x4 operator *(Matrix4x4 value1, Matrix4x4 value2)
		{
			return *(value1.AsImpl() * value2.AsImpl()).AsM4x4();
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x000990FC File Offset: 0x000972FC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix4x4 operator *(Matrix4x4 value1, float value2)
		{
			return *(value1.AsImpl() * value2).AsM4x4();
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x00099124 File Offset: 0x00097324
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix4x4 operator -(Matrix4x4 value1, Matrix4x4 value2)
		{
			return *(value1.AsImpl() - value2.AsImpl()).AsM4x4();
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x00099154 File Offset: 0x00097354
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix4x4 operator -(Matrix4x4 value)
		{
			return *(-value.AsImpl()).AsM4x4();
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x0009917C File Offset: 0x0009737C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix4x4 Add(Matrix4x4 value1, Matrix4x4 value2)
		{
			return *(value1.AsImpl() + value2.AsImpl()).AsM4x4();
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x000991AC File Offset: 0x000973AC
		public unsafe static Matrix4x4 CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3 cameraForwardVector)
		{
			return *Matrix4x4.Impl.CreateBillboard(objectPosition, cameraPosition, cameraUpVector, cameraForwardVector).AsM4x4();
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x000991D4 File Offset: 0x000973D4
		public unsafe static Matrix4x4 CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3 cameraForwardVector, Vector3 objectForwardVector)
		{
			return *Matrix4x4.Impl.CreateConstrainedBillboard(objectPosition, cameraPosition, rotateAxis, cameraForwardVector, objectForwardVector).AsM4x4();
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x00099200 File Offset: 0x00097400
		public unsafe static Matrix4x4 CreateFromAxisAngle(Vector3 axis, float angle)
		{
			return *Matrix4x4.Impl.CreateFromAxisAngle(axis, angle).AsM4x4();
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x00099224 File Offset: 0x00097424
		public unsafe static Matrix4x4 CreateFromQuaternion(Quaternion quaternion)
		{
			return *Matrix4x4.Impl.CreateFromQuaternion(quaternion).AsM4x4();
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x00099248 File Offset: 0x00097448
		public unsafe static Matrix4x4 CreateFromYawPitchRoll(float yaw, float pitch, float roll)
		{
			return *Matrix4x4.Impl.CreateFromYawPitchRoll(yaw, pitch, roll).AsM4x4();
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x0009926C File Offset: 0x0009746C
		public unsafe static Matrix4x4 CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)
		{
			Vector3 vector = cameraTarget - cameraPosition;
			return *Matrix4x4.Impl.CreateLookTo(cameraPosition, vector, cameraUpVector).AsM4x4();
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x0009929C File Offset: 0x0009749C
		public unsafe static Matrix4x4 CreateLookAtLeftHanded(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)
		{
			Vector3 vector = cameraTarget - cameraPosition;
			return *Matrix4x4.Impl.CreateLookToLeftHanded(cameraPosition, vector, cameraUpVector).AsM4x4();
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x000992CC File Offset: 0x000974CC
		public unsafe static Matrix4x4 CreateLookTo(Vector3 cameraPosition, Vector3 cameraDirection, Vector3 cameraUpVector)
		{
			return *Matrix4x4.Impl.CreateLookTo(cameraPosition, cameraDirection, cameraUpVector).AsM4x4();
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x000992F4 File Offset: 0x000974F4
		public unsafe static Matrix4x4 CreateLookToLeftHanded(Vector3 cameraPosition, Vector3 cameraDirection, Vector3 cameraUpVector)
		{
			return *Matrix4x4.Impl.CreateLookToLeftHanded(cameraPosition, cameraDirection, cameraUpVector).AsM4x4();
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x0009931C File Offset: 0x0009751C
		public unsafe static Matrix4x4 CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane)
		{
			return *Matrix4x4.Impl.CreateOrthographic(width, height, zNearPlane, zFarPlane).AsM4x4();
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x00099340 File Offset: 0x00097540
		public unsafe static Matrix4x4 CreateOrthographicLeftHanded(float width, float height, float zNearPlane, float zFarPlane)
		{
			return *Matrix4x4.Impl.CreateOrthographicLeftHanded(width, height, zNearPlane, zFarPlane).AsM4x4();
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x00099364 File Offset: 0x00097564
		public unsafe static Matrix4x4 CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
		{
			return *Matrix4x4.Impl.CreateOrthographicOffCenter(left, right, bottom, top, zNearPlane, zFarPlane).AsM4x4();
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x0009938C File Offset: 0x0009758C
		public unsafe static Matrix4x4 CreateOrthographicOffCenterLeftHanded(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
		{
			return *Matrix4x4.Impl.CreateOrthographicOffCenterLeftHanded(left, right, bottom, top, zNearPlane, zFarPlane).AsM4x4();
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x000993B4 File Offset: 0x000975B4
		public unsafe static Matrix4x4 CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance)
		{
			return *Matrix4x4.Impl.CreatePerspective(width, height, nearPlaneDistance, farPlaneDistance).AsM4x4();
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x000993D8 File Offset: 0x000975D8
		public unsafe static Matrix4x4 CreatePerspectiveLeftHanded(float width, float height, float nearPlaneDistance, float farPlaneDistance)
		{
			return *Matrix4x4.Impl.CreatePerspectiveLeftHanded(width, height, nearPlaneDistance, farPlaneDistance).AsM4x4();
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x000993FC File Offset: 0x000975FC
		public unsafe static Matrix4x4 CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
		{
			return *Matrix4x4.Impl.CreatePerspectiveFieldOfView(fieldOfView, aspectRatio, nearPlaneDistance, farPlaneDistance).AsM4x4();
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x00099420 File Offset: 0x00097620
		public unsafe static Matrix4x4 CreatePerspectiveFieldOfViewLeftHanded(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
		{
			return *Matrix4x4.Impl.CreatePerspectiveFieldOfViewLeftHanded(fieldOfView, aspectRatio, nearPlaneDistance, farPlaneDistance).AsM4x4();
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00099444 File Offset: 0x00097644
		public unsafe static Matrix4x4 CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance)
		{
			return *Matrix4x4.Impl.CreatePerspectiveOffCenter(left, right, bottom, top, nearPlaneDistance, farPlaneDistance).AsM4x4();
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x0009946C File Offset: 0x0009766C
		public unsafe static Matrix4x4 CreatePerspectiveOffCenterLeftHanded(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance)
		{
			return *Matrix4x4.Impl.CreatePerspectiveOffCenterLeftHanded(left, right, bottom, top, nearPlaneDistance, farPlaneDistance).AsM4x4();
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x00099494 File Offset: 0x00097694
		public unsafe static Matrix4x4 CreateReflection(Plane value)
		{
			return *Matrix4x4.Impl.CreateReflection(value).AsM4x4();
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x000994B8 File Offset: 0x000976B8
		public unsafe static Matrix4x4 CreateRotationX(float radians)
		{
			return *Matrix4x4.Impl.CreateRotationX(radians).AsM4x4();
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x000994D8 File Offset: 0x000976D8
		public unsafe static Matrix4x4 CreateRotationX(float radians, Vector3 centerPoint)
		{
			return *Matrix4x4.Impl.CreateRotationX(radians, centerPoint).AsM4x4();
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x000994FC File Offset: 0x000976FC
		public unsafe static Matrix4x4 CreateRotationY(float radians)
		{
			return *Matrix4x4.Impl.CreateRotationY(radians).AsM4x4();
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x0009951C File Offset: 0x0009771C
		public unsafe static Matrix4x4 CreateRotationY(float radians, Vector3 centerPoint)
		{
			return *Matrix4x4.Impl.CreateRotationY(radians, centerPoint).AsM4x4();
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x00099540 File Offset: 0x00097740
		public unsafe static Matrix4x4 CreateRotationZ(float radians)
		{
			return *Matrix4x4.Impl.CreateRotationZ(radians).AsM4x4();
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00099560 File Offset: 0x00097760
		public unsafe static Matrix4x4 CreateRotationZ(float radians, Vector3 centerPoint)
		{
			return *Matrix4x4.Impl.CreateRotationZ(radians, centerPoint).AsM4x4();
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00099584 File Offset: 0x00097784
		public unsafe static Matrix4x4 CreateScale(float xScale, float yScale, float zScale)
		{
			return *Matrix4x4.Impl.CreateScale(xScale, yScale, zScale).AsM4x4();
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x000995A8 File Offset: 0x000977A8
		public unsafe static Matrix4x4 CreateScale(float xScale, float yScale, float zScale, Vector3 centerPoint)
		{
			return *Matrix4x4.Impl.CreateScale(xScale, yScale, zScale, centerPoint).AsM4x4();
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x000995CC File Offset: 0x000977CC
		public unsafe static Matrix4x4 CreateScale(Vector3 scales)
		{
			return *Matrix4x4.Impl.CreateScale(scales).AsM4x4();
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x000995F0 File Offset: 0x000977F0
		public unsafe static Matrix4x4 CreateScale(Vector3 scales, Vector3 centerPoint)
		{
			return *Matrix4x4.Impl.CreateScale(scales, centerPoint).AsM4x4();
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00099614 File Offset: 0x00097814
		public unsafe static Matrix4x4 CreateScale(float scale)
		{
			return *Matrix4x4.Impl.CreateScale(scale).AsM4x4();
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00099634 File Offset: 0x00097834
		public unsafe static Matrix4x4 CreateScale(float scale, Vector3 centerPoint)
		{
			return *Matrix4x4.Impl.CreateScale(scale, centerPoint).AsM4x4();
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00099658 File Offset: 0x00097858
		public unsafe static Matrix4x4 CreateShadow(Vector3 lightDirection, Plane plane)
		{
			return *Matrix4x4.Impl.CreateShadow(lightDirection, plane).AsM4x4();
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x0009967C File Offset: 0x0009787C
		public unsafe static Matrix4x4 CreateTranslation(Vector3 position)
		{
			return *Matrix4x4.Impl.CreateTranslation(position).AsM4x4();
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x000996A0 File Offset: 0x000978A0
		public unsafe static Matrix4x4 CreateTranslation(float xPosition, float yPosition, float zPosition)
		{
			return *Matrix4x4.Impl.CreateTranslation(xPosition, yPosition, zPosition).AsM4x4();
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x000996C4 File Offset: 0x000978C4
		public unsafe static Matrix4x4 CreateViewport(float x, float y, float width, float height, float minDepth, float maxDepth)
		{
			return *Matrix4x4.Impl.CreateViewport(x, y, width, height, minDepth, maxDepth).AsM4x4();
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x000996EC File Offset: 0x000978EC
		public unsafe static Matrix4x4 CreateViewportLeftHanded(float x, float y, float width, float height, float minDepth, float maxDepth)
		{
			return *Matrix4x4.Impl.CreateViewportLeftHanded(x, y, width, height, minDepth, maxDepth).AsM4x4();
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x00099714 File Offset: 0x00097914
		public unsafe static Matrix4x4 CreateWorld(Vector3 position, Vector3 forward, Vector3 up)
		{
			return *Matrix4x4.Impl.CreateWorld(position, forward, up).AsM4x4();
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x00099739 File Offset: 0x00097939
		public static bool Decompose(Matrix4x4 matrix, out Vector3 scale, out Quaternion rotation, out Vector3 translation)
		{
			return Matrix4x4.Impl.Decompose(matrix.AsImpl(), out scale, out rotation, out translation);
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x0009974A File Offset: 0x0009794A
		public static bool Invert(Matrix4x4 matrix, out Matrix4x4 result)
		{
			Unsafe.SkipInit<Matrix4x4>(out result);
			return Matrix4x4.Impl.Invert(matrix.AsImpl(), result.AsImpl());
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x00099764 File Offset: 0x00097964
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix4x4 Lerp(Matrix4x4 matrix1, Matrix4x4 matrix2, float amount)
		{
			return *Matrix4x4.Impl.Lerp(matrix1.AsImpl(), matrix2.AsImpl(), amount).AsM4x4();
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x00099794 File Offset: 0x00097994
		public unsafe static Matrix4x4 Multiply(Matrix4x4 value1, Matrix4x4 value2)
		{
			return *(value1.AsImpl() * value2.AsImpl()).AsM4x4();
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x000997C4 File Offset: 0x000979C4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix4x4 Multiply(Matrix4x4 value1, float value2)
		{
			return *(value1.AsImpl() * value2).AsM4x4();
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x000997EC File Offset: 0x000979EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix4x4 Negate(Matrix4x4 value)
		{
			return *(-value.AsImpl()).AsM4x4();
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00099814 File Offset: 0x00097A14
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static Matrix4x4 Subtract(Matrix4x4 value1, Matrix4x4 value2)
		{
			return *(value1.AsImpl() - value2.AsImpl()).AsM4x4();
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00099844 File Offset: 0x00097A44
		public unsafe static Matrix4x4 Transform(Matrix4x4 value, Quaternion rotation)
		{
			return *Matrix4x4.Impl.Transform(value.AsImpl(), rotation).AsM4x4();
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x0009986C File Offset: 0x00097A6C
		public unsafe static Matrix4x4 Transpose(Matrix4x4 matrix)
		{
			return *Matrix4x4.Impl.Transpose(matrix.AsImpl()).AsM4x4();
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x00099892 File Offset: 0x00097A92
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly bool Equals([NotNullWhen(true)] object obj)
		{
			return this.AsROImpl().Equals(obj);
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x000998A6 File Offset: 0x00097AA6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Equals(Matrix4x4 other)
		{
			return this.AsROImpl().Equals(other.AsImpl());
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x000998BA File Offset: 0x00097ABA
		public readonly float GetDeterminant()
		{
			return this.AsROImpl().GetDeterminant();
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x000998C7 File Offset: 0x00097AC7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override readonly int GetHashCode()
		{
			return this.AsROImpl().GetHashCode();
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x000998DC File Offset: 0x00097ADC
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(91, 16);
			defaultInterpolatedStringHandler.AppendLiteral("{ {M11:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M11);
			defaultInterpolatedStringHandler.AppendLiteral(" M12:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M12);
			defaultInterpolatedStringHandler.AppendLiteral(" M13:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M13);
			defaultInterpolatedStringHandler.AppendLiteral(" M14:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M14);
			defaultInterpolatedStringHandler.AppendLiteral("} {M21:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M21);
			defaultInterpolatedStringHandler.AppendLiteral(" M22:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M22);
			defaultInterpolatedStringHandler.AppendLiteral(" M23:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M23);
			defaultInterpolatedStringHandler.AppendLiteral(" M24:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M24);
			defaultInterpolatedStringHandler.AppendLiteral("} {M31:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M31);
			defaultInterpolatedStringHandler.AppendLiteral(" M32:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M32);
			defaultInterpolatedStringHandler.AppendLiteral(" M33:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M33);
			defaultInterpolatedStringHandler.AppendLiteral(" M34:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M34);
			defaultInterpolatedStringHandler.AppendLiteral("} {M41:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M41);
			defaultInterpolatedStringHandler.AppendLiteral(" M42:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M42);
			defaultInterpolatedStringHandler.AppendLiteral(" M43:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M43);
			defaultInterpolatedStringHandler.AppendLiteral(" M44:");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.M44);
			defaultInterpolatedStringHandler.AppendLiteral("} }");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00099A97 File Offset: 0x00097C97
		[UnscopedRef]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal ref Matrix4x4.Impl AsImpl()
		{
			return Unsafe.As<Matrix4x4, Matrix4x4.Impl>(ref this);
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00099A9F File Offset: 0x00097C9F
		[UnscopedRef]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal readonly ref readonly Matrix4x4.Impl AsROImpl()
		{
			return Unsafe.As<Matrix4x4, Matrix4x4.Impl>(Unsafe.AsRef<Matrix4x4>(ref this));
		}

		// Token: 0x040008CF RID: 2255
		public float M11;

		// Token: 0x040008D0 RID: 2256
		public float M12;

		// Token: 0x040008D1 RID: 2257
		public float M13;

		// Token: 0x040008D2 RID: 2258
		public float M14;

		// Token: 0x040008D3 RID: 2259
		public float M21;

		// Token: 0x040008D4 RID: 2260
		public float M22;

		// Token: 0x040008D5 RID: 2261
		public float M23;

		// Token: 0x040008D6 RID: 2262
		public float M24;

		// Token: 0x040008D7 RID: 2263
		public float M31;

		// Token: 0x040008D8 RID: 2264
		public float M32;

		// Token: 0x040008D9 RID: 2265
		public float M33;

		// Token: 0x040008DA RID: 2266
		public float M34;

		// Token: 0x040008DB RID: 2267
		public float M41;

		// Token: 0x040008DC RID: 2268
		public float M42;

		// Token: 0x040008DD RID: 2269
		public float M43;

		// Token: 0x040008DE RID: 2270
		public float M44;

		// Token: 0x02000292 RID: 658
		internal struct Impl : IEquatable<Matrix4x4.Impl>
		{
			// Token: 0x06002F93 RID: 12179 RVA: 0x00099AAC File Offset: 0x00097CAC
			[UnscopedRef]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public ref Matrix4x4 AsM4x4()
			{
				return Unsafe.As<Matrix4x4.Impl, Matrix4x4>(ref this);
			}

			// Token: 0x06002F94 RID: 12180 RVA: 0x00099AB4 File Offset: 0x00097CB4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Init(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
			{
				this.X = Vector4.Create(m11, m12, m13, m14);
				this.Y = Vector4.Create(m21, m22, m23, m24);
				this.Z = Vector4.Create(m31, m32, m33, m34);
				this.W = Vector4.Create(m41, m42, m43, m44);
			}

			// Token: 0x06002F95 RID: 12181 RVA: 0x00099B0C File Offset: 0x00097D0C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Init(in Matrix3x2.Impl value)
			{
				this.X = Vector4.Create(value.X, 0f, 0f);
				this.Y = Vector4.Create(value.Y, 0f, 0f);
				this.Z = Vector4.UnitZ;
				this.W = Vector4.Create(value.Z, 0f, 1f);
			}

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x06002F96 RID: 12182 RVA: 0x00099B78 File Offset: 0x00097D78
			public static Matrix4x4.Impl Identity
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					Matrix4x4.Impl result;
					result.X = Vector4.UnitX;
					result.Y = Vector4.UnitY;
					result.Z = Vector4.UnitZ;
					result.W = Vector4.UnitW;
					return result;
				}
			}

			// Token: 0x1700090A RID: 2314
			public float this[int row, int column]
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				readonly get
				{
					if (row >= 4)
					{
						ThrowHelper.ThrowArgumentOutOfRangeException();
					}
					return Unsafe.Add<Vector4>(Unsafe.AsRef<Vector4>(ref this.X), row)[column];
				}
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				set
				{
					if (row >= 4)
					{
						ThrowHelper.ThrowArgumentOutOfRangeException();
					}
					Unsafe.Add<Vector4>(ref this.X, row)[column] = value;
				}
			}

			// Token: 0x1700090B RID: 2315
			// (get) Token: 0x06002F99 RID: 12185 RVA: 0x00099BF8 File Offset: 0x00097DF8
			public readonly bool IsIdentity
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				get
				{
					return this.X == Vector4.UnitX && this.Y == Vector4.UnitY && this.Z == Vector4.UnitZ && this.W == Vector4.UnitW;
				}
			}

			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x06002F9A RID: 12186 RVA: 0x00099C4D File Offset: 0x00097E4D
			// (set) Token: 0x06002F9B RID: 12187 RVA: 0x00099C5A File Offset: 0x00097E5A
			public Vector3 Translation
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				readonly get
				{
					return this.W.AsVector3();
				}
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				set
				{
					this.W = Vector4.Create(value, this.W.W);
				}
			}

			// Token: 0x06002F9C RID: 12188 RVA: 0x00099C74 File Offset: 0x00097E74
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl operator +(in Matrix4x4.Impl left, in Matrix4x4.Impl right)
			{
				Matrix4x4.Impl result;
				result.X = left.X + right.X;
				result.Y = left.Y + right.Y;
				result.Z = left.Z + right.Z;
				result.W = left.W + right.W;
				return result;
			}

			// Token: 0x06002F9D RID: 12189 RVA: 0x00099CE4 File Offset: 0x00097EE4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool operator ==(in Matrix4x4.Impl left, in Matrix4x4.Impl right)
			{
				return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
			}

			// Token: 0x06002F9E RID: 12190 RVA: 0x00099D40 File Offset: 0x00097F40
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool operator !=(in Matrix4x4.Impl left, in Matrix4x4.Impl right)
			{
				return left.X != right.X || left.Y != right.Y || left.Z != right.Z || left.W != right.W;
			}

			// Token: 0x06002F9F RID: 12191 RVA: 0x00099D9C File Offset: 0x00097F9C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl operator *(in Matrix4x4.Impl left, in Matrix4x4.Impl right)
			{
				Matrix4x4.Impl result;
				result.X = Vector4.Transform(left.X, right);
				result.Y = Vector4.Transform(left.Y, right);
				result.Z = Vector4.Transform(left.Z, right);
				result.W = Vector4.Transform(left.W, right);
				return result;
			}

			// Token: 0x06002FA0 RID: 12192 RVA: 0x00099DF8 File Offset: 0x00097FF8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl operator *(in Matrix4x4.Impl left, float right)
			{
				Matrix4x4.Impl result;
				result.X = left.X * right;
				result.Y = left.Y * right;
				result.Z = left.Z * right;
				result.W = left.W * right;
				return result;
			}

			// Token: 0x06002FA1 RID: 12193 RVA: 0x00099E54 File Offset: 0x00098054
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl operator -(in Matrix4x4.Impl left, in Matrix4x4.Impl right)
			{
				Matrix4x4.Impl result;
				result.X = left.X - right.X;
				result.Y = left.Y - right.Y;
				result.Z = left.Z - right.Z;
				result.W = left.W - right.W;
				return result;
			}

			// Token: 0x06002FA2 RID: 12194 RVA: 0x00099EC4 File Offset: 0x000980C4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl operator -(in Matrix4x4.Impl value)
			{
				Matrix4x4.Impl result;
				result.X = -value.X;
				result.Y = -value.Y;
				result.Z = -value.Z;
				result.W = -value.W;
				return result;
			}

			// Token: 0x06002FA3 RID: 12195 RVA: 0x00099F1C File Offset: 0x0009811C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateBillboard(in Vector3 objectPosition, in Vector3 cameraPosition, in Vector3 cameraUpVector, in Vector3 cameraForwardVector)
			{
				Vector3 vector = objectPosition - cameraPosition;
				if (vector.LengthSquared() < 0.0001f)
				{
					vector = -cameraForwardVector;
				}
				else
				{
					vector = Vector3.Normalize(vector);
				}
				Vector3 vector2 = Vector3.Normalize(Vector3.Cross(cameraUpVector, vector));
				Vector3 value = Vector3.Cross(vector, vector2);
				Matrix4x4.Impl result;
				result.X = vector2.AsVector4();
				result.Y = value.AsVector4();
				result.Z = vector.AsVector4();
				result.W = Vector4.Create(objectPosition, 1f);
				return result;
			}

			// Token: 0x06002FA4 RID: 12196 RVA: 0x00099FB8 File Offset: 0x000981B8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateConstrainedBillboard(in Vector3 objectPosition, in Vector3 cameraPosition, in Vector3 rotateAxis, in Vector3 cameraForwardVector, in Vector3 objectForwardVector)
			{
				Vector3 vector = objectPosition - cameraPosition;
				if (vector.LengthSquared() < 0.0001f)
				{
					vector = -cameraForwardVector;
				}
				else
				{
					vector = Vector3.Normalize(vector);
				}
				Vector3 vector2 = rotateAxis;
				if (float.Abs(Vector3.Dot(vector2, vector)) > 0.99825466f)
				{
					vector = objectForwardVector;
					if (float.Abs(Vector3.Dot(vector2, vector)) > 0.99825466f)
					{
						vector = ((float.Abs(vector2.Z) > 0.99825466f) ? Vector3.UnitX : Vector3.Create(0f, 0f, -1f));
					}
				}
				Vector3 vector3 = Vector3.Normalize(Vector3.Cross(vector2, vector));
				Vector3 value = Vector3.Normalize(Vector3.Cross(vector3, vector2));
				Matrix4x4.Impl result;
				result.X = vector3.AsVector4();
				result.Y = vector2.AsVector4();
				result.Z = value.AsVector4();
				result.W = Vector4.Create(objectPosition, 1f);
				return result;
			}

			// Token: 0x06002FA5 RID: 12197 RVA: 0x0009A0B8 File Offset: 0x000982B8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateFromAxisAngle(in Vector3 axis, float angle)
			{
				Quaternion quaternion = Quaternion.CreateFromAxisAngle(axis, angle);
				return Matrix4x4.Impl.CreateFromQuaternion(quaternion);
			}

			// Token: 0x06002FA6 RID: 12198 RVA: 0x0009A0DC File Offset: 0x000982DC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateFromQuaternion(in Quaternion quaternion)
			{
				float num = quaternion.X * quaternion.X;
				float num2 = quaternion.Y * quaternion.Y;
				float num3 = quaternion.Z * quaternion.Z;
				float num4 = quaternion.X * quaternion.Y;
				float num5 = quaternion.Z * quaternion.W;
				float num6 = quaternion.Z * quaternion.X;
				float num7 = quaternion.Y * quaternion.W;
				float num8 = quaternion.Y * quaternion.Z;
				float num9 = quaternion.X * quaternion.W;
				Matrix4x4.Impl result;
				result.X = Vector4.Create(1f - 2f * (num2 + num3), 2f * (num4 + num5), 2f * (num6 - num7), 0f);
				result.Y = Vector4.Create(2f * (num4 - num5), 1f - 2f * (num3 + num), 2f * (num8 + num9), 0f);
				result.Z = Vector4.Create(2f * (num6 + num7), 2f * (num8 - num9), 1f - 2f * (num2 + num), 0f);
				result.W = Vector4.UnitW;
				return result;
			}

			// Token: 0x06002FA7 RID: 12199 RVA: 0x0009A21C File Offset: 0x0009841C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateFromYawPitchRoll(float yaw, float pitch, float roll)
			{
				Quaternion quaternion = Quaternion.CreateFromYawPitchRoll(yaw, pitch, roll);
				return Matrix4x4.Impl.CreateFromQuaternion(quaternion);
			}

			// Token: 0x06002FA8 RID: 12200 RVA: 0x0009A23C File Offset: 0x0009843C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateLookTo(in Vector3 cameraPosition, in Vector3 cameraDirection, in Vector3 cameraUpVector)
			{
				Vector3 vector = -cameraDirection;
				return Matrix4x4.Impl.CreateLookToLeftHanded(cameraPosition, vector, cameraUpVector);
			}

			// Token: 0x06002FA9 RID: 12201 RVA: 0x0009A260 File Offset: 0x00098460
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateLookToLeftHanded(in Vector3 cameraPosition, in Vector3 cameraDirection, in Vector3 cameraUpVector)
			{
				Vector3 vector = Vector3.Normalize(cameraDirection);
				Vector3 vector2 = Vector3.Normalize(Vector3.Cross(cameraUpVector, vector));
				Vector3 vector3 = Vector3.Cross(vector, vector2);
				Vector3 vector4 = -cameraPosition;
				Matrix4x4.Impl impl;
				impl.X = Vector4.Create(vector2, Vector3.Dot(vector2, vector4));
				impl.Y = Vector4.Create(vector3, Vector3.Dot(vector3, vector4));
				impl.Z = Vector4.Create(vector, Vector3.Dot(vector, vector4));
				impl.W = Vector4.UnitW;
				return Matrix4x4.Impl.Transpose(impl);
			}

			// Token: 0x06002FAA RID: 12202 RVA: 0x0009A2F0 File Offset: 0x000984F0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane)
			{
				float num = 1f / (zNearPlane - zFarPlane);
				Matrix4x4.Impl result;
				result.X = Vector4.Create(2f / width, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, 2f / height, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, num, 0f);
				result.W = Vector4.Create(0f, 0f, num * zNearPlane, 1f);
				return result;
			}

			// Token: 0x06002FAB RID: 12203 RVA: 0x0009A388 File Offset: 0x00098588
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateOrthographicLeftHanded(float width, float height, float zNearPlane, float zFarPlane)
			{
				float num = 1f / (zFarPlane - zNearPlane);
				Matrix4x4.Impl result;
				result.X = Vector4.Create(2f / width, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, 2f / height, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, num, 0f);
				result.W = Vector4.Create(0f, 0f, -num * zNearPlane, 1f);
				return result;
			}

			// Token: 0x06002FAC RID: 12204 RVA: 0x0009A420 File Offset: 0x00098620
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
			{
				float num = 1f / (right - left);
				float num2 = 1f / (top - bottom);
				float num3 = 1f / (zNearPlane - zFarPlane);
				Matrix4x4.Impl result;
				result.X = Vector4.Create(num + num, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, num2 + num2, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, num3, 0f);
				result.W = Vector4.Create(-(left + right) * num, -(top + bottom) * num2, num3 * zNearPlane, 1f);
				return result;
			}

			// Token: 0x06002FAD RID: 12205 RVA: 0x0009A4C8 File Offset: 0x000986C8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateOrthographicOffCenterLeftHanded(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
			{
				float num = 1f / (right - left);
				float num2 = 1f / (top - bottom);
				float num3 = 1f / (zFarPlane - zNearPlane);
				Matrix4x4.Impl result;
				result.X = Vector4.Create(num + num, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, num2 + num2, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, num3, 0f);
				result.W = Vector4.Create(-(left + right) * num, -(top + bottom) * num2, -num3 * zNearPlane, 1f);
				return result;
			}

			// Token: 0x06002FAE RID: 12206 RVA: 0x0009A570 File Offset: 0x00098770
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance)
			{
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(nearPlaneDistance, 0f, "nearPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(farPlaneDistance, 0f, "farPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual<float>(nearPlaneDistance, farPlaneDistance, "nearPlaneDistance");
				float num = nearPlaneDistance + nearPlaneDistance;
				float num2 = float.IsPositiveInfinity(farPlaneDistance) ? -1f : (farPlaneDistance / (nearPlaneDistance - farPlaneDistance));
				Matrix4x4.Impl result;
				result.X = Vector4.Create(num / width, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, num / height, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, num2, -1f);
				result.W = Vector4.Create(0f, 0f, num2 * nearPlaneDistance, 0f);
				return result;
			}

			// Token: 0x06002FAF RID: 12207 RVA: 0x0009A63C File Offset: 0x0009883C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreatePerspectiveLeftHanded(float width, float height, float nearPlaneDistance, float farPlaneDistance)
			{
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(nearPlaneDistance, 0f, "nearPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(farPlaneDistance, 0f, "farPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual<float>(nearPlaneDistance, farPlaneDistance, "nearPlaneDistance");
				float num = nearPlaneDistance + nearPlaneDistance;
				float num2 = float.IsPositiveInfinity(farPlaneDistance) ? 1f : (farPlaneDistance / (farPlaneDistance - nearPlaneDistance));
				Matrix4x4.Impl result;
				result.X = Vector4.Create(num / width, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, num / height, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, num2, 1f);
				result.W = Vector4.Create(0f, 0f, -num2 * nearPlaneDistance, 0f);
				return result;
			}

			// Token: 0x06002FB0 RID: 12208 RVA: 0x0009A708 File Offset: 0x00098908
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
			{
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(fieldOfView, 0f, "fieldOfView");
				ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual<float>(fieldOfView, 3.1415927f, "fieldOfView");
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(nearPlaneDistance, 0f, "nearPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(farPlaneDistance, 0f, "farPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual<float>(nearPlaneDistance, farPlaneDistance, "nearPlaneDistance");
				float num = 1f / float.Tan(fieldOfView * 0.5f);
				float x = num / aspectRatio;
				float num2 = float.IsPositiveInfinity(farPlaneDistance) ? -1f : (farPlaneDistance / (nearPlaneDistance - farPlaneDistance));
				Matrix4x4.Impl result;
				result.X = Vector4.Create(x, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, num, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, num2, -1f);
				result.W = Vector4.Create(0f, 0f, num2 * nearPlaneDistance, 0f);
				return result;
			}

			// Token: 0x06002FB1 RID: 12209 RVA: 0x0009A800 File Offset: 0x00098A00
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreatePerspectiveFieldOfViewLeftHanded(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
			{
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(fieldOfView, 0f, "fieldOfView");
				ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual<float>(fieldOfView, 3.1415927f, "fieldOfView");
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(nearPlaneDistance, 0f, "nearPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(farPlaneDistance, 0f, "farPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual<float>(nearPlaneDistance, farPlaneDistance, "nearPlaneDistance");
				float num = 1f / float.Tan(fieldOfView * 0.5f);
				float x = num / aspectRatio;
				float num2 = float.IsPositiveInfinity(farPlaneDistance) ? 1f : (farPlaneDistance / (farPlaneDistance - nearPlaneDistance));
				Matrix4x4.Impl result;
				result.X = Vector4.Create(x, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, num, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, num2, 1f);
				result.W = Vector4.Create(0f, 0f, -num2 * nearPlaneDistance, 0f);
				return result;
			}

			// Token: 0x06002FB2 RID: 12210 RVA: 0x0009A8FC File Offset: 0x00098AFC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance)
			{
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(nearPlaneDistance, 0f, "nearPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(farPlaneDistance, 0f, "farPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual<float>(nearPlaneDistance, farPlaneDistance, "nearPlaneDistance");
				float num = nearPlaneDistance + nearPlaneDistance;
				float num2 = 1f / (right - left);
				float num3 = 1f / (top - bottom);
				float num4 = float.IsPositiveInfinity(farPlaneDistance) ? -1f : (farPlaneDistance / (nearPlaneDistance - farPlaneDistance));
				Matrix4x4.Impl result;
				result.X = Vector4.Create(num * num2, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, num * num3, 0f, 0f);
				result.Z = Vector4.Create((left + right) * num2, (top + bottom) * num3, num4, -1f);
				result.W = Vector4.Create(0f, 0f, num4 * nearPlaneDistance, 0f);
				return result;
			}

			// Token: 0x06002FB3 RID: 12211 RVA: 0x0009A9E8 File Offset: 0x00098BE8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreatePerspectiveOffCenterLeftHanded(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance)
			{
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(nearPlaneDistance, 0f, "nearPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfLessThanOrEqual<float>(farPlaneDistance, 0f, "farPlaneDistance");
				ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual<float>(nearPlaneDistance, farPlaneDistance, "nearPlaneDistance");
				float num = nearPlaneDistance + nearPlaneDistance;
				float num2 = 1f / (right - left);
				float num3 = 1f / (top - bottom);
				float num4 = float.IsPositiveInfinity(farPlaneDistance) ? 1f : (farPlaneDistance / (farPlaneDistance - nearPlaneDistance));
				Matrix4x4.Impl result;
				result.X = Vector4.Create(num * num2, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, num * num3, 0f, 0f);
				result.Z = Vector4.Create(-(left + right) * num2, -(top + bottom) * num3, num4, 1f);
				result.W = Vector4.Create(0f, 0f, -num4 * nearPlaneDistance, 0f);
				return result;
			}

			// Token: 0x06002FB4 RID: 12212 RVA: 0x0009AAD4 File Offset: 0x00098CD4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateReflection(in Plane value)
			{
				Vector4 vector = Plane.Normalize(value).AsVector4();
				Vector4 right = vector * Vector4.Create(-2f, -2f, -2f, 0f);
				Matrix4x4.Impl result;
				result.X = Vector4.MultiplyAddEstimate(Vector4.Create(vector.X), right, Vector4.UnitX);
				result.Y = Vector4.MultiplyAddEstimate(Vector4.Create(vector.Y), right, Vector4.UnitY);
				result.Z = Vector4.MultiplyAddEstimate(Vector4.Create(vector.Z), right, Vector4.UnitZ);
				result.W = Vector4.MultiplyAddEstimate(Vector4.Create(vector.W), right, Vector4.UnitW);
				return result;
			}

			// Token: 0x06002FB5 RID: 12213 RVA: 0x0009AB88 File Offset: 0x00098D88
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateRotationX(float radians)
			{
				ValueTuple<float, float> valueTuple = float.SinCos(radians);
				float item = valueTuple.Item1;
				float item2 = valueTuple.Item2;
				Matrix4x4.Impl result;
				result.X = Vector4.UnitX;
				result.Y = Vector4.Create(0f, item2, item, 0f);
				result.Z = Vector4.Create(0f, -item, item2, 0f);
				result.W = Vector4.UnitW;
				return result;
			}

			// Token: 0x06002FB6 RID: 12214 RVA: 0x0009ABF4 File Offset: 0x00098DF4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateRotationX(float radians, in Vector3 centerPoint)
			{
				ValueTuple<float, float> valueTuple = float.SinCos(radians);
				float item = valueTuple.Item1;
				float item2 = valueTuple.Item2;
				float y = float.MultiplyAddEstimate(centerPoint.Y, 1f - item2, centerPoint.Z * item);
				float z = float.MultiplyAddEstimate(centerPoint.Z, 1f - item2, -centerPoint.Y * item);
				Matrix4x4.Impl result;
				result.X = Vector4.UnitX;
				result.Y = Vector4.Create(0f, item2, item, 0f);
				result.Z = Vector4.Create(0f, -item, item2, 0f);
				result.W = Vector4.Create(0f, y, z, 1f);
				return result;
			}

			// Token: 0x06002FB7 RID: 12215 RVA: 0x0009ACA4 File Offset: 0x00098EA4
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateRotationY(float radians)
			{
				ValueTuple<float, float> valueTuple = float.SinCos(radians);
				float item = valueTuple.Item1;
				float item2 = valueTuple.Item2;
				Matrix4x4.Impl result;
				result.X = Vector4.Create(item2, 0f, -item, 0f);
				result.Y = Vector4.UnitY;
				result.Z = Vector4.Create(item, 0f, item2, 0f);
				result.W = Vector4.UnitW;
				return result;
			}

			// Token: 0x06002FB8 RID: 12216 RVA: 0x0009AD10 File Offset: 0x00098F10
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateRotationY(float radians, in Vector3 centerPoint)
			{
				ValueTuple<float, float> valueTuple = float.SinCos(radians);
				float item = valueTuple.Item1;
				float item2 = valueTuple.Item2;
				float x = float.MultiplyAddEstimate(centerPoint.X, 1f - item2, -centerPoint.Z * item);
				float z = float.MultiplyAddEstimate(centerPoint.Z, 1f - item2, centerPoint.X * item);
				Matrix4x4.Impl result;
				result.X = Vector4.Create(item2, 0f, -item, 0f);
				result.Y = Vector4.UnitY;
				result.Z = Vector4.Create(item, 0f, item2, 0f);
				result.W = Vector4.Create(x, 0f, z, 1f);
				return result;
			}

			// Token: 0x06002FB9 RID: 12217 RVA: 0x0009ADC0 File Offset: 0x00098FC0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateRotationZ(float radians)
			{
				ValueTuple<float, float> valueTuple = float.SinCos(radians);
				float item = valueTuple.Item1;
				float item2 = valueTuple.Item2;
				Matrix4x4.Impl result;
				result.X = Vector4.Create(item2, item, 0f, 0f);
				result.Y = Vector4.Create(-item, item2, 0f, 0f);
				result.Z = Vector4.UnitZ;
				result.W = Vector4.UnitW;
				return result;
			}

			// Token: 0x06002FBA RID: 12218 RVA: 0x0009AE2C File Offset: 0x0009902C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateRotationZ(float radians, in Vector3 centerPoint)
			{
				ValueTuple<float, float> valueTuple = float.SinCos(radians);
				float item = valueTuple.Item1;
				float item2 = valueTuple.Item2;
				float x = float.MultiplyAddEstimate(centerPoint.X, 1f - item2, centerPoint.Y * item);
				float y = float.MultiplyAddEstimate(centerPoint.Y, 1f - item2, -centerPoint.X * item);
				Matrix4x4.Impl result;
				result.X = Vector4.Create(item2, item, 0f, 0f);
				result.Y = Vector4.Create(-item, item2, 0f, 0f);
				result.Z = Vector4.UnitZ;
				result.W = Vector4.Create(x, y, 0f, 1f);
				return result;
			}

			// Token: 0x06002FBB RID: 12219 RVA: 0x0009AEDC File Offset: 0x000990DC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateScale(float scaleX, float scaleY, float scaleZ)
			{
				Matrix4x4.Impl result;
				result.X = Vector4.Create(scaleX, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, scaleY, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, scaleZ, 0f);
				result.W = Vector4.UnitW;
				return result;
			}

			// Token: 0x06002FBC RID: 12220 RVA: 0x0009AF4C File Offset: 0x0009914C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateScale(float scaleX, float scaleY, float scaleZ, in Vector3 centerPoint)
			{
				Matrix4x4.Impl result;
				result.X = Vector4.Create(scaleX, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, scaleY, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, scaleZ, 0f);
				result.W = Vector4.Create(centerPoint * (Vector3.One - Vector3.Create(scaleX, scaleY, scaleZ)), 1f);
				return result;
			}

			// Token: 0x06002FBD RID: 12221 RVA: 0x0009AFDC File Offset: 0x000991DC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateScale(in Vector3 scales)
			{
				Matrix4x4.Impl result;
				result.X = Vector4.Create(scales.X, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, scales.Y, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, scales.Z, 0f);
				result.W = Vector4.UnitW;
				return result;
			}

			// Token: 0x06002FBE RID: 12222 RVA: 0x0009B05C File Offset: 0x0009925C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateScale(in Vector3 scales, in Vector3 centerPoint)
			{
				Matrix4x4.Impl result;
				result.X = Vector4.Create(scales.X, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, scales.Y, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, scales.Z, 0f);
				result.W = Vector4.Create(centerPoint * (Vector3.One - scales), 1f);
				return result;
			}

			// Token: 0x06002FBF RID: 12223 RVA: 0x0009B0FC File Offset: 0x000992FC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateScale(float scale)
			{
				Matrix4x4.Impl result;
				result.X = Vector4.Create(scale, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, scale, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, scale, 0f);
				result.W = Vector4.UnitW;
				return result;
			}

			// Token: 0x06002FC0 RID: 12224 RVA: 0x0009B16C File Offset: 0x0009936C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateScale(float scale, in Vector3 centerPoint)
			{
				Matrix4x4.Impl result;
				result.X = Vector4.Create(scale, 0f, 0f, 0f);
				result.Y = Vector4.Create(0f, scale, 0f, 0f);
				result.Z = Vector4.Create(0f, 0f, scale, 0f);
				result.W = Vector4.Create(centerPoint * (Vector3.One - Vector3.Create(scale)), 1f);
				return result;
			}

			// Token: 0x06002FC1 RID: 12225 RVA: 0x0009B1FC File Offset: 0x000993FC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateShadow(in Vector3 lightDirection, in Plane plane)
			{
				Vector4 vector = Plane.Normalize(plane).AsVector4();
				Vector4 vector2 = lightDirection.AsVector4();
				float num = Vector4.Dot(vector, vector2);
				vector = -vector;
				Matrix4x4.Impl result;
				result.X = Vector4.MultiplyAddEstimate(vector2, Vector4.Create(vector.X), Vector4.Create(num, 0f, 0f, 0f));
				result.Y = Vector4.MultiplyAddEstimate(vector2, Vector4.Create(vector.Y), Vector4.Create(0f, num, 0f, 0f));
				result.Z = Vector4.MultiplyAddEstimate(vector2, Vector4.Create(vector.Z), Vector4.Create(0f, 0f, num, 0f));
				result.W = Vector4.MultiplyAddEstimate(vector2, Vector4.Create(vector.W), Vector4.Create(0f, 0f, 0f, num));
				return result;
			}

			// Token: 0x06002FC2 RID: 12226 RVA: 0x0009B2EC File Offset: 0x000994EC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateTranslation(in Vector3 position)
			{
				Matrix4x4.Impl result;
				result.X = Vector4.UnitX;
				result.Y = Vector4.UnitY;
				result.Z = Vector4.UnitZ;
				result.W = Vector4.Create(position, 1f);
				return result;
			}

			// Token: 0x06002FC3 RID: 12227 RVA: 0x0009B338 File Offset: 0x00099538
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateTranslation(float positionX, float positionY, float positionZ)
			{
				Matrix4x4.Impl result;
				result.X = Vector4.UnitX;
				result.Y = Vector4.UnitY;
				result.Z = Vector4.UnitZ;
				result.W = Vector4.Create(positionX, positionY, positionZ, 1f);
				return result;
			}

			// Token: 0x06002FC4 RID: 12228 RVA: 0x0009B380 File Offset: 0x00099580
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateViewport(float x, float y, float width, float height, float minDepth, float maxDepth)
			{
				Matrix4x4.Impl impl;
				impl.W = Vector4.Create(width, height, 0f, 0f);
				impl.W *= Vector4.Create(0.5f, 0.5f, 0f, 0f);
				impl.X = Vector4.Create(impl.W.X, 0f, 0f, 0f);
				impl.Y = Vector4.Create(0f, -impl.W.Y, 0f, 0f);
				impl.Z = Vector4.Create(0f, 0f, minDepth - maxDepth, 0f);
				impl.W += Vector4.Create(x, y, minDepth, 1f);
				return impl;
			}

			// Token: 0x06002FC5 RID: 12229 RVA: 0x0009B468 File Offset: 0x00099668
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateViewportLeftHanded(float x, float y, float width, float height, float minDepth, float maxDepth)
			{
				Matrix4x4.Impl impl;
				impl.W = Vector4.Create(width, height, 0f, 0f);
				impl.W *= Vector4.Create(0.5f, 0.5f, 0f, 0f);
				impl.X = Vector4.Create(impl.W.X, 0f, 0f, 0f);
				impl.Y = Vector4.Create(0f, -impl.W.Y, 0f, 0f);
				impl.Z = Vector4.Create(0f, 0f, maxDepth - minDepth, 0f);
				impl.W += Vector4.Create(x, y, minDepth, 1f);
				return impl;
			}

			// Token: 0x06002FC6 RID: 12230 RVA: 0x0009B550 File Offset: 0x00099750
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl CreateWorld(in Vector3 position, in Vector3 forward, in Vector3 up)
			{
				Vector3 vector = Vector3.Normalize(-forward);
				Vector3 vector2 = Vector3.Normalize(Vector3.Cross(up, vector));
				Vector3 value = Vector3.Cross(vector, vector2);
				Matrix4x4.Impl result;
				result.X = vector2.AsVector4();
				result.Y = value.AsVector4();
				result.Z = vector.AsVector4();
				result.W = Vector4.Create(position, 1f);
				return result;
			}

			// Token: 0x06002FC7 RID: 12231 RVA: 0x0009B5C8 File Offset: 0x000997C8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public unsafe static bool Decompose(in Matrix4x4.Impl matrix, out Vector3 scale, out Quaternion rotation, out Vector3 translation)
			{
				Matrix4x4.Impl identity = Matrix4x4.Impl.Identity;
				IntPtr intPtr = stackalloc byte[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(Vector3))];
				*intPtr = Vector3.UnitX;
				*(intPtr + (IntPtr)sizeof(Vector3)) = Vector3.UnitY;
				*(intPtr + (IntPtr)2 * (IntPtr)sizeof(Vector3)) = Vector3.UnitZ;
				Vector3* ptr = intPtr;
				translation = matrix.W.AsVector3();
				IntPtr intPtr2 = stackalloc byte[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(Vector3*))];
				*intPtr2 = &identity.X;
				*(intPtr2 + (IntPtr)sizeof(Vector3*)) = &identity.Y;
				*(intPtr2 + (IntPtr)2 * (IntPtr)sizeof(Vector3*)) = &identity.Z;
				Vector3** ptr2 = intPtr2;
				*(*(IntPtr*)ptr2) = matrix.X.AsVector3();
				*(*(IntPtr*)(ptr2 + sizeof(Vector3*) / sizeof(Vector3*))) = matrix.Y.AsVector3();
				*(*(IntPtr*)(ptr2 + (IntPtr)2 * (IntPtr)sizeof(Vector3*) / (IntPtr)sizeof(Vector3*))) = matrix.Z.AsVector3();
				IntPtr intPtr3 = stackalloc byte[(UIntPtr)12];
				*intPtr3 = ((IntPtr*)ptr2)->Length();
				*(intPtr3 + 4) = ((IntPtr*)(ptr2 + sizeof(Vector3*) / sizeof(Vector3*)))->Length();
				*(intPtr3 + (IntPtr)2 * 4) = ((IntPtr*)(ptr2 + (IntPtr)2 * (IntPtr)sizeof(Vector3*) / (IntPtr)sizeof(Vector3*)))->Length();
				float* ptr3 = intPtr3;
				float num = *ptr3;
				float num2 = ptr3[1];
				float num3 = ptr3[2];
				uint num4;
				uint num5;
				uint num6;
				if (num < num2)
				{
					if (num2 < num3)
					{
						num4 = 2U;
						num5 = 1U;
						num6 = 0U;
					}
					else
					{
						num4 = 1U;
						if (num < num3)
						{
							num5 = 2U;
							num6 = 0U;
						}
						else
						{
							num5 = 0U;
							num6 = 2U;
						}
					}
				}
				else if (num < num3)
				{
					num4 = 2U;
					num5 = 0U;
					num6 = 1U;
				}
				else
				{
					num4 = 0U;
					if (num2 < num3)
					{
						num5 = 2U;
						num6 = 1U;
					}
					else
					{
						num5 = 1U;
						num6 = 2U;
					}
				}
				if (ptr3[(ulong)num4 * 4UL / 4UL] < 0.0001f)
				{
					*(*(IntPtr*)(ptr2 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = ptr[(ulong)num4 * (ulong)((long)sizeof(Vector3)) / (ulong)sizeof(Vector3)];
				}
				*(*(IntPtr*)(ptr2 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = Vector3.Normalize(*(*(IntPtr*)(ptr2 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))));
				if (ptr3[(ulong)num5 * 4UL / 4UL] < 0.0001f)
				{
					float num7 = float.Abs(((IntPtr*)(ptr2 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*)))->X);
					float num8 = float.Abs(((IntPtr*)(ptr2 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*)))->Y);
					float num9 = float.Abs(((IntPtr*)(ptr2 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*)))->Z);
					uint num10;
					if (num7 < num8)
					{
						if (num8 < num9)
						{
							num10 = 0U;
						}
						else if (num7 < num9)
						{
							num10 = 0U;
						}
						else
						{
							num10 = 2U;
						}
					}
					else if (num7 < num9)
					{
						num10 = 1U;
					}
					else if (num8 < num9)
					{
						num10 = 1U;
					}
					else
					{
						num10 = 2U;
					}
					*(*(IntPtr*)(ptr2 + (ulong)num5 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = Vector3.Cross(*(*(IntPtr*)(ptr2 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))), ptr[(ulong)num10 * (ulong)((long)sizeof(Vector3)) / (ulong)sizeof(Vector3)]);
				}
				*(*(IntPtr*)(ptr2 + (ulong)num5 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = Vector3.Normalize(*(*(IntPtr*)(ptr2 + (ulong)num5 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))));
				if (ptr3[(ulong)num6 * 4UL / 4UL] < 0.0001f)
				{
					*(*(IntPtr*)(ptr2 + (ulong)num6 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = Vector3.Cross(*(*(IntPtr*)(ptr2 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))), *(*(IntPtr*)(ptr2 + (ulong)num5 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))));
				}
				*(*(IntPtr*)(ptr2 + (ulong)num6 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = Vector3.Normalize(*(*(IntPtr*)(ptr2 + (ulong)num6 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))));
				float num11 = identity.GetDeterminant();
				if (num11 < 0f)
				{
					ptr3[(ulong)num4 * 4UL / 4UL] = -ptr3[(ulong)num4 * 4UL / 4UL];
					*(*(IntPtr*)(ptr2 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))) = -(*(*(IntPtr*)(ptr2 + (ulong)num4 * (ulong)((long)sizeof(Vector3*)) / (ulong)sizeof(Vector3*))));
					num11 = -num11;
				}
				num11 -= 1f;
				num11 *= num11;
				bool result;
				if (0.0001f < num11)
				{
					rotation = Quaternion.Identity;
					result = false;
				}
				else
				{
					rotation = Quaternion.CreateFromRotationMatrix(*identity.AsM4x4());
					result = true;
				}
				scale = Unsafe.ReadUnaligned<Vector3>((void*)ptr3);
				return result;
			}

			// Token: 0x06002FC8 RID: 12232 RVA: 0x0009B9EB File Offset: 0x00099BEB
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool Invert(in Matrix4x4.Impl matrix, out Matrix4x4.Impl result)
			{
				if (Sse.IsSupported)
				{
					return Matrix4x4.Impl.<Invert>g__SseImpl|64_0(matrix, out result);
				}
				return Matrix4x4.Impl.<Invert>g__SoftwareFallback|64_1(matrix, out result);
			}

			// Token: 0x06002FC9 RID: 12233 RVA: 0x0009BA04 File Offset: 0x00099C04
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl Lerp(in Matrix4x4.Impl left, in Matrix4x4.Impl right, float amount)
			{
				Matrix4x4.Impl result;
				result.X = Vector4.Lerp(left.X, right.X, amount);
				result.Y = Vector4.Lerp(left.Y, right.Y, amount);
				result.Z = Vector4.Lerp(left.Z, right.Z, amount);
				result.W = Vector4.Lerp(left.W, right.W, amount);
				return result;
			}

			// Token: 0x06002FCA RID: 12234 RVA: 0x0009BA78 File Offset: 0x00099C78
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl Transform(in Matrix4x4.Impl value, in Quaternion rotation)
			{
				float num = rotation.X + rotation.X;
				float num2 = rotation.Y + rotation.Y;
				float num3 = rotation.Z + rotation.Z;
				float num4 = rotation.W * num;
				float num5 = rotation.W * num2;
				float num6 = rotation.W * num3;
				float num7 = rotation.X * num;
				float num8 = rotation.X * num2;
				float num9 = rotation.X * num3;
				float num10 = rotation.Y * num2;
				float num11 = rotation.Y * num3;
				float num12 = rotation.Z * num3;
				float num13 = 1f - num10 - num12;
				float num14 = num8 - num6;
				float num15 = num9 + num5;
				float num16 = num8 + num6;
				float num17 = 1f - num7 - num12;
				float num18 = num11 - num4;
				float num19 = num9 - num5;
				float num20 = num11 + num4;
				float num21 = 1f - num7 - num10;
				Matrix4x4.Impl result;
				result.X = Vector4.Create(value.X.X * num13 + value.X.Y * num14 + value.X.Z * num15, value.X.X * num16 + value.X.Y * num17 + value.X.Z * num18, value.X.X * num19 + value.X.Y * num20 + value.X.Z * num21, value.X.W);
				result.Y = Vector4.Create(value.Y.X * num13 + value.Y.Y * num14 + value.Y.Z * num15, value.Y.X * num16 + value.Y.Y * num17 + value.Y.Z * num18, value.Y.X * num19 + value.Y.Y * num20 + value.Y.Z * num21, value.Y.W);
				result.Z = Vector4.Create(value.Z.X * num13 + value.Z.Y * num14 + value.Z.Z * num15, value.Z.X * num16 + value.Z.Y * num17 + value.Z.Z * num18, value.Z.X * num19 + value.Z.Y * num20 + value.Z.Z * num21, value.Z.W);
				result.W = Vector4.Create(value.W.X * num13 + value.W.Y * num14 + value.W.Z * num15, value.W.X * num16 + value.W.Y * num17 + value.W.Z * num18, value.W.X * num19 + value.W.Y * num20 + value.W.Z * num21, value.W.W);
				return result;
			}

			// Token: 0x06002FCB RID: 12235 RVA: 0x0009BDC0 File Offset: 0x00099FC0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Matrix4x4.Impl Transpose(in Matrix4x4.Impl matrix)
			{
				if (false)
				{
				}
				Matrix4x4.Impl result;
				if (Sse.IsSupported)
				{
					Vector128<float> left = matrix.X.AsVector128();
					Vector128<float> left2 = matrix.Y.AsVector128();
					Vector128<float> right = matrix.Z.AsVector128();
					Vector128<float> right2 = matrix.W.AsVector128();
					Vector128<float> left3 = Sse.UnpackLow(left, right);
					Vector128<float> right3 = Sse.UnpackLow(left2, right2);
					Vector128<float> left4 = Sse.UnpackHigh(left, right);
					Vector128<float> right4 = Sse.UnpackHigh(left2, right2);
					result.X = Sse.UnpackLow(left3, right3).AsVector4();
					result.Y = Sse.UnpackHigh(left3, right3).AsVector4();
					result.Z = Sse.UnpackLow(left4, right4).AsVector4();
					result.W = Sse.UnpackHigh(left4, right4).AsVector4();
				}
				else
				{
					result.X = Vector4.Create(matrix.X.X, matrix.Y.X, matrix.Z.X, matrix.W.X);
					result.Y = Vector4.Create(matrix.X.Y, matrix.Y.Y, matrix.Z.Y, matrix.W.Y);
					result.Z = Vector4.Create(matrix.X.Z, matrix.Y.Z, matrix.Z.Z, matrix.W.Z);
					result.W = Vector4.Create(matrix.X.W, matrix.Y.W, matrix.Z.W, matrix.W.W);
				}
				return result;
			}

			// Token: 0x06002FCC RID: 12236 RVA: 0x0009BF74 File Offset: 0x0009A174
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public override readonly bool Equals([NotNullWhen(true)] object obj)
			{
				return obj is Matrix4x4 && this.Equals(((Matrix4x4)obj).AsImpl());
			}

			// Token: 0x06002FCD RID: 12237 RVA: 0x0009BFA0 File Offset: 0x0009A1A0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public readonly bool Equals(in Matrix4x4.Impl other)
			{
				return this.X.Equals(other.X) && this.Y.Equals(other.Y) && this.Z.Equals(other.Z) && this.W.Equals(other.W);
			}

			// Token: 0x06002FCE RID: 12238 RVA: 0x0009BFFC File Offset: 0x0009A1FC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public readonly float GetDeterminant()
			{
				float x = this.X.X;
				float y = this.X.Y;
				float z = this.X.Z;
				float w = this.X.W;
				float x2 = this.Y.X;
				float y2 = this.Y.Y;
				float z2 = this.Y.Z;
				float w2 = this.Y.W;
				float x3 = this.Z.X;
				float y3 = this.Z.Y;
				float z3 = this.Z.Z;
				float w3 = this.Z.W;
				float x4 = this.W.X;
				float y4 = this.W.Y;
				float z4 = this.W.Z;
				float w4 = this.W.W;
				float num = z3 * w4 - w3 * z4;
				float num2 = y3 * w4 - w3 * y4;
				float num3 = y3 * z4 - z3 * y4;
				float num4 = x3 * w4 - w3 * x4;
				float num5 = x3 * z4 - z3 * x4;
				float num6 = x3 * y4 - y3 * x4;
				return x * (y2 * num - z2 * num2 + w2 * num3) - y * (x2 * num - z2 * num4 + w2 * num5) + z * (x2 * num2 - y2 * num4 + w2 * num6) - w * (x2 * num3 - y2 * num5 + z2 * num6);
			}

			// Token: 0x06002FCF RID: 12239 RVA: 0x0009C166 File Offset: 0x0009A366
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public override readonly int GetHashCode()
			{
				return HashCode.Combine<Vector4, Vector4, Vector4, Vector4>(this.X, this.Y, this.Z, this.W);
			}

			// Token: 0x06002FD0 RID: 12240 RVA: 0x0009C185 File Offset: 0x0009A385
			readonly bool IEquatable<Matrix4x4.Impl>.Equals(Matrix4x4.Impl other)
			{
				return this.Equals(other);
			}

			// Token: 0x06002FD1 RID: 12241 RVA: 0x0000ACEC File Offset: 0x00008EEC
			private static void ThrowPlatformNotSupportedException()
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06002FD2 RID: 12242 RVA: 0x0009C190 File Offset: 0x0009A390
			[CompilerGenerated]
			internal static bool <Invert>g__SseImpl|64_0(in Matrix4x4.Impl matrix, out Matrix4x4.Impl result)
			{
				if (!Sse.IsSupported)
				{
					Matrix4x4.Impl.ThrowPlatformNotSupportedException();
				}
				Vector128<float> vector = matrix.X.AsVector128();
				Vector128<float> vector2 = matrix.Y.AsVector128();
				Vector128<float> vector3 = matrix.Z.AsVector128();
				Vector128<float> vector4 = matrix.W.AsVector128();
				Vector128<float> left = Sse.Shuffle(vector, vector2, 68);
				Vector128<float> left2 = Sse.Shuffle(vector, vector2, 238);
				Vector128<float> right = Sse.Shuffle(vector3, vector4, 68);
				Vector128<float> right2 = Sse.Shuffle(vector3, vector4, 238);
				vector = Sse.Shuffle(left, right, 136);
				vector2 = Sse.Shuffle(left, right, 221);
				vector3 = Sse.Shuffle(left2, right2, 136);
				vector4 = Sse.Shuffle(left2, right2, 221);
				Vector128<float> vector5 = Vector128.Shuffle(vector3, Vector128.Create(0, 0, 1, 1));
				Vector128<float> vector6 = Vector128.Shuffle(vector4, Vector128.Create(2, 3, 2, 3));
				Vector128<float> vector7 = Vector128.Shuffle(vector, Vector128.Create(0, 0, 1, 1));
				Vector128<float> vector8 = Vector128.Shuffle(vector2, Vector128.Create(2, 3, 2, 3));
				Vector128<float> vector9 = Sse.Shuffle(vector3, vector, 136);
				Vector128<float> vector10 = Sse.Shuffle(vector4, vector2, 221);
				Vector128<float> vector11 = vector5 * vector6;
				Vector128<float> vector12 = vector7 * vector8;
				Vector128<float> vector13 = vector9 * vector10;
				vector5 = Vector128.Shuffle(vector3, Vector128.Create(2, 3, 2, 3));
				vector6 = Vector128.Shuffle(vector4, Vector128.Create(0, 0, 1, 1));
				vector7 = Vector128.Shuffle(vector, Vector128.Create(2, 3, 2, 3));
				vector8 = Vector128.Shuffle(vector2, Vector128.Create(0, 0, 1, 1));
				vector9 = Sse.Shuffle(vector3, vector, 221);
				vector10 = Sse.Shuffle(vector4, vector2, 136);
				vector11 = Vector128.MultiplyAddEstimate(-vector5, vector6, vector11);
				vector12 = Vector128.MultiplyAddEstimate(-vector7, vector8, vector12);
				vector13 = Vector128.MultiplyAddEstimate(-vector9, vector10, vector13);
				vector8 = Sse.Shuffle(vector11, vector13, 93);
				vector5 = Vector128.Shuffle(vector2, Vector128.Create(1, 2, 0, 1));
				vector6 = Sse.Shuffle(vector8, vector11, 50);
				vector7 = Vector128.Shuffle(vector, Vector128.Create(2, 0, 1, 0));
				vector8 = Sse.Shuffle(vector8, vector11, 153);
				Vector128<float> vector14 = Sse.Shuffle(vector12, vector13, 253);
				vector9 = Vector128.Shuffle(vector4, Vector128.Create(1, 2, 0, 1));
				vector10 = Sse.Shuffle(vector14, vector12, 50);
				Vector128<float> vector15 = Vector128.Shuffle(vector3, Vector128.Create(2, 0, 1, 0));
				vector14 = Sse.Shuffle(vector14, vector12, 153);
				Vector128<float> vector16 = vector5 * vector6;
				Vector128<float> vector17 = vector7 * vector8;
				Vector128<float> vector18 = vector9 * vector10;
				Vector128<float> vector19 = vector15 * vector14;
				vector8 = Sse.Shuffle(vector11, vector13, 4);
				vector5 = Vector128.Shuffle(vector2, Vector128.Create(2, 3, 1, 2));
				vector6 = Sse.Shuffle(vector11, vector8, 147);
				vector7 = Vector128.Shuffle(vector, Vector128.Create(3, 2, 3, 1));
				vector8 = Sse.Shuffle(vector11, vector8, 38);
				vector14 = Sse.Shuffle(vector12, vector13, 164);
				vector9 = Vector128.Shuffle(vector4, Vector128.Create(2, 3, 1, 2));
				vector10 = Sse.Shuffle(vector12, vector14, 147);
				vector15 = Vector128.Shuffle(vector3, Vector128.Create(3, 2, 3, 1));
				vector14 = Sse.Shuffle(vector12, vector14, 38);
				vector16 = Vector128.MultiplyAddEstimate(-vector5, vector6, vector16);
				vector17 = Vector128.MultiplyAddEstimate(-vector7, vector8, vector17);
				vector18 = Vector128.MultiplyAddEstimate(-vector9, vector10, vector18);
				vector19 = Vector128.MultiplyAddEstimate(-vector15, vector14, vector19);
				vector5 = Vector128.Shuffle(vector2, Vector128.Create(3, 0, 3, 0));
				vector6 = Sse.Shuffle(vector11, vector13, 74);
				vector6 = Vector128.Shuffle(vector6, Vector128.Create(0, 3, 2, 0));
				vector7 = Vector128.Shuffle(vector, Vector128.Create(1, 3, 0, 2));
				vector8 = Sse.Shuffle(vector11, vector13, 76);
				vector8 = Vector128.Shuffle(vector8, Vector128.Create(3, 0, 1, 2));
				vector9 = Vector128.Shuffle(vector4, Vector128.Create(3, 0, 3, 0));
				vector10 = Sse.Shuffle(vector12, vector13, 234);
				vector10 = Vector128.Shuffle(vector10, Vector128.Create(0, 3, 2, 0));
				vector15 = Vector128.Shuffle(vector3, Vector128.Create(1, 3, 0, 2));
				vector14 = Sse.Shuffle(vector12, vector13, 236);
				vector14 = Vector128.Shuffle(vector14, Vector128.Create(3, 0, 1, 2));
				vector5 *= vector6;
				vector7 *= vector8;
				vector9 *= vector10;
				vector15 *= vector14;
				Vector128<float> right3 = vector16 - vector5;
				vector16 += vector5;
				Vector128<float> right4 = vector17 + vector7;
				vector17 -= vector7;
				Vector128<float> right5 = vector18 - vector9;
				vector18 += vector9;
				Vector128<float> right6 = vector19 + vector15;
				vector19 -= vector15;
				vector16 = Sse.Shuffle(vector16, right3, 216);
				vector17 = Sse.Shuffle(vector17, right4, 216);
				vector18 = Sse.Shuffle(vector18, right5, 216);
				vector19 = Sse.Shuffle(vector19, right6, 216);
				vector16 = Vector128.Shuffle(vector16, Vector128.Create(0, 2, 1, 3));
				vector17 = Vector128.Shuffle(vector17, Vector128.Create(0, 2, 1, 3));
				vector18 = Vector128.Shuffle(vector18, Vector128.Create(0, 2, 1, 3));
				vector19 = Vector128.Shuffle(vector19, Vector128.Create(0, 2, 1, 3));
				float num = Vector4.Dot(vector16.AsVector4(), vector.AsVector4());
				if (float.Abs(num) < 1E-45f)
				{
					Vector4 vector20 = Vector4.Create(float.NaN);
					result.X = vector20;
					result.Y = vector20;
					result.Z = vector20;
					result.W = vector20;
					return false;
				}
				Vector128<float> right7 = Vector128<float>.One / num;
				result.X = (vector16 * right7).AsVector4();
				result.Y = (vector17 * right7).AsVector4();
				result.Z = (vector18 * right7).AsVector4();
				result.W = (vector19 * right7).AsVector4();
				return true;
			}

			// Token: 0x06002FD3 RID: 12243 RVA: 0x0009C784 File Offset: 0x0009A984
			[CompilerGenerated]
			internal static bool <Invert>g__SoftwareFallback|64_1(in Matrix4x4.Impl matrix, out Matrix4x4.Impl result)
			{
				float x = matrix.X.X;
				float y = matrix.X.Y;
				float z = matrix.X.Z;
				float w = matrix.X.W;
				float x2 = matrix.Y.X;
				float y2 = matrix.Y.Y;
				float z2 = matrix.Y.Z;
				float w2 = matrix.Y.W;
				float x3 = matrix.Z.X;
				float y3 = matrix.Z.Y;
				float z3 = matrix.Z.Z;
				float w3 = matrix.Z.W;
				float x4 = matrix.W.X;
				float y4 = matrix.W.Y;
				float z4 = matrix.W.Z;
				float w4 = matrix.W.W;
				float num = z3 * w4 - w3 * z4;
				float num2 = y3 * w4 - w3 * y4;
				float num3 = y3 * z4 - z3 * y4;
				float num4 = x3 * w4 - w3 * x4;
				float num5 = x3 * z4 - z3 * x4;
				float num6 = x3 * y4 - y3 * x4;
				float num7 = y2 * num - z2 * num2 + w2 * num3;
				float num8 = -(x2 * num - z2 * num4 + w2 * num5);
				float num9 = x2 * num2 - y2 * num4 + w2 * num6;
				float num10 = -(x2 * num3 - y2 * num5 + z2 * num6);
				float num11 = x * num7 + y * num8 + z * num9 + w * num10;
				if (float.Abs(num11) < 1E-45f)
				{
					Vector4 vector = Vector4.Create(float.NaN);
					result.X = vector;
					result.Y = vector;
					result.Z = vector;
					result.W = vector;
					return false;
				}
				float num12 = 1f / num11;
				result.X.X = num7 * num12;
				result.Y.X = num8 * num12;
				result.Z.X = num9 * num12;
				result.W.X = num10 * num12;
				result.X.Y = -(y * num - z * num2 + w * num3) * num12;
				result.Y.Y = (x * num - z * num4 + w * num5) * num12;
				result.Z.Y = -(x * num2 - y * num4 + w * num6) * num12;
				result.W.Y = (x * num3 - y * num5 + z * num6) * num12;
				float num13 = z2 * w4 - w2 * z4;
				float num14 = y2 * w4 - w2 * y4;
				float num15 = y2 * z4 - z2 * y4;
				float num16 = x2 * w4 - w2 * x4;
				float num17 = x2 * z4 - z2 * x4;
				float num18 = x2 * y4 - y2 * x4;
				result.X.Z = (y * num13 - z * num14 + w * num15) * num12;
				result.Y.Z = -(x * num13 - z * num16 + w * num17) * num12;
				result.Z.Z = (x * num14 - y * num16 + w * num18) * num12;
				result.W.Z = -(x * num15 - y * num17 + z * num18) * num12;
				float num19 = z2 * w3 - w2 * z3;
				float num20 = y2 * w3 - w2 * y3;
				float num21 = y2 * z3 - z2 * y3;
				float num22 = x2 * w3 - w2 * x3;
				float num23 = x2 * z3 - z2 * x3;
				float num24 = x2 * y3 - y2 * x3;
				result.X.W = -(y * num19 - z * num20 + w * num21) * num12;
				result.Y.W = (x * num19 - z * num22 + w * num23) * num12;
				result.Z.W = -(x * num20 - y * num22 + w * num24) * num12;
				result.W.W = (x * num21 - y * num23 + z * num24) * num12;
				return true;
			}

			// Token: 0x040008DF RID: 2271
			public Vector4 X;

			// Token: 0x040008E0 RID: 2272
			public Vector4 Y;

			// Token: 0x040008E1 RID: 2273
			public Vector4 Z;

			// Token: 0x040008E2 RID: 2274
			public Vector4 W;
		}
	}
}
