using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Enum
{
	// Token: 0x02003E92 RID: 16018
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Enum/EUiCameraAnimationLocationType.EUiCameraAnimationLocationType")]
	public enum EUiCameraAnimationLocationType : byte
	{
		// Token: 0x04014A39 RID: 84537
		WorldLocation,
		// Token: 0x04014A3A RID: 84538
		TargetLocation,
		// Token: 0x04014A3B RID: 84539
		SocketLocation,
		// Token: 0x04014A3C RID: 84540
		EUiCameraAnimationLocationType_MAX
	}
}
