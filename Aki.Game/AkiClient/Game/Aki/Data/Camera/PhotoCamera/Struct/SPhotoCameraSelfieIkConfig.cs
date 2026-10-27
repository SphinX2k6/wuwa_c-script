using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct
{
	// Token: 0x02003FB7 RID: 16311
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 44)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraSelfieIkConfig.SPhotoCameraSelfieIkConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 44)]
	public struct SPhotoCameraSelfieIkConfig : IEqualityOperators<SPhotoCameraSelfieIkConfig, SPhotoCameraSelfieIkConfig, bool>, IEquatable<SPhotoCameraSelfieIkConfig>, IUnrealScriptStruct
	{
		// Token: 0x06029BFC RID: 171004 RVA: 0x009CB9EC File Offset: 0x009C9BEC
		public SPhotoCameraSelfieIkConfig(FVector IkPointToCameraOffset, float HeadIKPitchLimitMin, float HeadIKPitchLimitMax, float HeadIKYawLimitMin, float HeadIKYawLimitMax, float CollisionRadiusOffset, FVector IKCameraRotationOffsetFromHandSpace)
		{
			this.IkPointToCameraOffset = IkPointToCameraOffset;
			this.HeadIKPitchLimitMin = HeadIKPitchLimitMin;
			this.HeadIKPitchLimitMax = HeadIKPitchLimitMax;
			this.HeadIKYawLimitMin = HeadIKYawLimitMin;
			this.HeadIKYawLimitMax = HeadIKYawLimitMax;
			this.CollisionRadiusOffset = CollisionRadiusOffset;
			this.IKCameraRotationOffsetFromHandSpace = IKCameraRotationOffsetFromHandSpace;
		}

		// Token: 0x06029BFD RID: 171005 RVA: 0x009CBA24 File Offset: 0x009C9C24
		public static bool operator ==(SPhotoCameraSelfieIkConfig left, SPhotoCameraSelfieIkConfig right)
		{
			return left.IkPointToCameraOffset == right.IkPointToCameraOffset && left.HeadIKPitchLimitMin == right.HeadIKPitchLimitMin && left.HeadIKPitchLimitMax == right.HeadIKPitchLimitMax && left.HeadIKYawLimitMin == right.HeadIKYawLimitMin && left.HeadIKYawLimitMax == right.HeadIKYawLimitMax && left.CollisionRadiusOffset == right.CollisionRadiusOffset && left.IKCameraRotationOffsetFromHandSpace == right.IKCameraRotationOffsetFromHandSpace;
		}

		// Token: 0x06029BFE RID: 171006 RVA: 0x009CBA9D File Offset: 0x009C9C9D
		public static bool operator !=(SPhotoCameraSelfieIkConfig left, SPhotoCameraSelfieIkConfig right)
		{
			return !(left == right);
		}

		// Token: 0x06029BFF RID: 171007 RVA: 0x009CBAA9 File Offset: 0x009C9CA9
		public bool Equals(SPhotoCameraSelfieIkConfig other)
		{
			return this == other;
		}

		// Token: 0x06029C00 RID: 171008 RVA: 0x009CBAB8 File Offset: 0x009C9CB8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SPhotoCameraSelfieIkConfig)
			{
				SPhotoCameraSelfieIkConfig other = (SPhotoCameraSelfieIkConfig)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06029C01 RID: 171009 RVA: 0x009CBADD File Offset: 0x009C9CDD
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, float, float, float, float, float, FVector>(this.IkPointToCameraOffset, this.HeadIKPitchLimitMin, this.HeadIKPitchLimitMax, this.HeadIKYawLimitMin, this.HeadIKYawLimitMax, this.CollisionRadiusOffset, this.IKCameraRotationOffsetFromHandSpace);
		}

		// Token: 0x06029C02 RID: 171010 RVA: 0x009CBB0E File Offset: 0x009C9D0E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPhotoCameraSelfieIkConfig._ScriptStructPtr != 0) ? SPhotoCameraSelfieIkConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraSelfieIkConfig.SPhotoCameraSelfieIkConfig", ref SPhotoCameraSelfieIkConfig._ScriptStructPtr);
		}

		// Token: 0x04015708 RID: 87816
		[FieldOffset(0)]
		public FVector IkPointToCameraOffset;

		// Token: 0x04015709 RID: 87817
		[FieldOffset(12)]
		public float HeadIKPitchLimitMin;

		// Token: 0x0401570A RID: 87818
		[FieldOffset(16)]
		public float HeadIKPitchLimitMax;

		// Token: 0x0401570B RID: 87819
		[FieldOffset(20)]
		public float HeadIKYawLimitMin;

		// Token: 0x0401570C RID: 87820
		[FieldOffset(24)]
		public float HeadIKYawLimitMax;

		// Token: 0x0401570D RID: 87821
		[FieldOffset(28)]
		public float CollisionRadiusOffset;

		// Token: 0x0401570E RID: 87822
		[FieldOffset(32)]
		public FVector IKCameraRotationOffsetFromHandSpace;

		// Token: 0x0401570F RID: 87823
		public const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraSelfieIkConfig.SPhotoCameraSelfieIkConfig";

		// Token: 0x04015710 RID: 87824
		private static IntPtr _ScriptStructPtr;
	}
}
