using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct
{
	// Token: 0x0200323F RID: 12863
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 44)]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraSelfieIkConfig.SPhotoCameraSelfieIkConfig")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 44)]
	public struct SPhotoCameraSelfieIkConfig : IEqualityOperators<SPhotoCameraSelfieIkConfig, SPhotoCameraSelfieIkConfig, bool>, IEquatable<SPhotoCameraSelfieIkConfig>, IUnrealScriptStruct
	{
		// Token: 0x06020228 RID: 131624 RVA: 0x0093E17F File Offset: 0x0093C37F
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

		// Token: 0x06020229 RID: 131625 RVA: 0x0093E1B8 File Offset: 0x0093C3B8
		public static bool operator ==(SPhotoCameraSelfieIkConfig left, SPhotoCameraSelfieIkConfig right)
		{
			return left.IkPointToCameraOffset == right.IkPointToCameraOffset && left.HeadIKPitchLimitMin == right.HeadIKPitchLimitMin && left.HeadIKPitchLimitMax == right.HeadIKPitchLimitMax && left.HeadIKYawLimitMin == right.HeadIKYawLimitMin && left.HeadIKYawLimitMax == right.HeadIKYawLimitMax && left.CollisionRadiusOffset == right.CollisionRadiusOffset && left.IKCameraRotationOffsetFromHandSpace == right.IKCameraRotationOffsetFromHandSpace;
		}

		// Token: 0x0602022A RID: 131626 RVA: 0x0093E231 File Offset: 0x0093C431
		public static bool operator !=(SPhotoCameraSelfieIkConfig left, SPhotoCameraSelfieIkConfig right)
		{
			return !(left == right);
		}

		// Token: 0x0602022B RID: 131627 RVA: 0x0093E23D File Offset: 0x0093C43D
		public bool Equals(SPhotoCameraSelfieIkConfig other)
		{
			return this == other;
		}

		// Token: 0x0602022C RID: 131628 RVA: 0x0093E24C File Offset: 0x0093C44C
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

		// Token: 0x0602022D RID: 131629 RVA: 0x0093E271 File Offset: 0x0093C471
		public override int GetHashCode()
		{
			return HashCode.Combine<FVector, float, float, float, float, float, FVector>(this.IkPointToCameraOffset, this.HeadIKPitchLimitMin, this.HeadIKPitchLimitMax, this.HeadIKYawLimitMin, this.HeadIKYawLimitMax, this.CollisionRadiusOffset, this.IKCameraRotationOffsetFromHandSpace);
		}

		// Token: 0x0602022E RID: 131630 RVA: 0x0093E2A2 File Offset: 0x0093C4A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPhotoCameraSelfieIkConfig._ScriptStructPtr != 0) ? SPhotoCameraSelfieIkConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraSelfieIkConfig.SPhotoCameraSelfieIkConfig", ref SPhotoCameraSelfieIkConfig._ScriptStructPtr);
		}

		// Token: 0x040114B0 RID: 70832
		[FieldOffset(0)]
		public FVector IkPointToCameraOffset;

		// Token: 0x040114B1 RID: 70833
		[FieldOffset(12)]
		public float HeadIKPitchLimitMin;

		// Token: 0x040114B2 RID: 70834
		[FieldOffset(16)]
		public float HeadIKPitchLimitMax;

		// Token: 0x040114B3 RID: 70835
		[FieldOffset(20)]
		public float HeadIKYawLimitMin;

		// Token: 0x040114B4 RID: 70836
		[FieldOffset(24)]
		public float HeadIKYawLimitMax;

		// Token: 0x040114B5 RID: 70837
		[FieldOffset(28)]
		public float CollisionRadiusOffset;

		// Token: 0x040114B6 RID: 70838
		[FieldOffset(32)]
		public FVector IKCameraRotationOffsetFromHandSpace;

		// Token: 0x040114B7 RID: 70839
		public const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraSelfieIkConfig.SPhotoCameraSelfieIkConfig";

		// Token: 0x040114B8 RID: 70840
		private static IntPtr _ScriptStructPtr;
	}
}
