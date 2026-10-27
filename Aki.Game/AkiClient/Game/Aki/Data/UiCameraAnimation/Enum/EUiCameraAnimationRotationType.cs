using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Enum
{
	// Token: 0x02003E93 RID: 16019
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Enum/EUiCameraAnimationRotationType.EUiCameraAnimationRotationType")]
	public enum EUiCameraAnimationRotationType : byte
	{
		// Token: 0x04014A3E RID: 84542
		WorldRotation,
		// Token: 0x04014A3F RID: 84543
		CurrentCameraRotation,
		// Token: 0x04014A40 RID: 84544
		TargetRotation,
		// Token: 0x04014A41 RID: 84545
		TargetForwardRotation,
		// Token: 0x04014A42 RID: 84546
		EUiCameraAnimationRotationType_MAX
	}
}
