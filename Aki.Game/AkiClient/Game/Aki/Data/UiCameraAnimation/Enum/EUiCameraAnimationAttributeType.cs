using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Enum
{
	// Token: 0x02003168 RID: 12648
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Enum/EUiCameraAnimationAttributeType.EUiCameraAnimationAttributeType")]
	public enum EUiCameraAnimationAttributeType : byte
	{
		// Token: 0x04010AAE RID: 68270
		None,
		// Token: 0x04010AAF RID: 68271
		Location,
		// Token: 0x04010AB0 RID: 68272
		Rotation,
		// Token: 0x04010AB1 RID: 68273
		ArmLength,
		// Token: 0x04010AB2 RID: 68274
		ArmOffsetLocation,
		// Token: 0x04010AB3 RID: 68275
		ArmOffsetRotation,
		// Token: 0x04010AB4 RID: 68276
		CameraFieldOfView,
		// Token: 0x04010AB5 RID: 68277
		FocalDistance,
		// Token: 0x04010AB6 RID: 68278
		PostProcessBlendWeight,
		// Token: 0x04010AB7 RID: 68279
		Aperture,
		// Token: 0x04010AB8 RID: 68280
		EUiCameraAnimationAttributeType_MAX
	}
}
