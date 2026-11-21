using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Enum
{
	// Token: 0x0200316A RID: 12650
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Enum/EUiCameraAnimationRotationType.EUiCameraAnimationRotationType")]
	public enum EUiCameraAnimationRotationType : byte
	{
		// Token: 0x04010ABF RID: 68287
		WorldRotation,
		// Token: 0x04010AC0 RID: 68288
		CurrentCameraRotation,
		// Token: 0x04010AC1 RID: 68289
		TargetRotation,
		// Token: 0x04010AC2 RID: 68290
		TargetForwardRotation,
		// Token: 0x04010AC3 RID: 68291
		EUiCameraAnimationRotationType_MAX
	}
}
