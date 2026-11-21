using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.UiCameraAnimation.Enum
{
	// Token: 0x02003169 RID: 12649
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/UiCameraAnimation/Enum/EUiCameraAnimationLocationType.EUiCameraAnimationLocationType")]
	public enum EUiCameraAnimationLocationType : byte
	{
		// Token: 0x04010ABA RID: 68282
		WorldLocation,
		// Token: 0x04010ABB RID: 68283
		TargetLocation,
		// Token: 0x04010ABC RID: 68284
		SocketLocation,
		// Token: 0x04010ABD RID: 68285
		EUiCameraAnimationLocationType_MAX
	}
}
