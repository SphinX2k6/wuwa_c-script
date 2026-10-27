using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Enum
{
	// Token: 0x02003E91 RID: 16017
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Enum/EUiCameraAnimationAttributeType.EUiCameraAnimationAttributeType")]
	public enum EUiCameraAnimationAttributeType : byte
	{
		// Token: 0x04014A2D RID: 84525
		None,
		// Token: 0x04014A2E RID: 84526
		Location,
		// Token: 0x04014A2F RID: 84527
		Rotation,
		// Token: 0x04014A30 RID: 84528
		ArmLength,
		// Token: 0x04014A31 RID: 84529
		ArmOffsetLocation,
		// Token: 0x04014A32 RID: 84530
		ArmOffsetRotation,
		// Token: 0x04014A33 RID: 84531
		CameraFieldOfView,
		// Token: 0x04014A34 RID: 84532
		FocalDistance,
		// Token: 0x04014A35 RID: 84533
		PostProcessBlendWeight,
		// Token: 0x04014A36 RID: 84534
		Aperture,
		// Token: 0x04014A37 RID: 84535
		EUiCameraAnimationAttributeType_MAX
	}
}
