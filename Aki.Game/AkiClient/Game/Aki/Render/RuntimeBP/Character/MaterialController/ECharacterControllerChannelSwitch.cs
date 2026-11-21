using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003128 RID: 12584
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/ECharacterControllerChannelSwitch.ECharacterControllerChannelSwitch")]
	public enum ECharacterControllerChannelSwitch : byte
	{
		// Token: 0x04010735 RID: 67381
		RGB,
		// Token: 0x04010736 RID: 67382
		R,
		// Token: 0x04010737 RID: 67383
		G,
		// Token: 0x04010738 RID: 67384
		B,
		// Token: 0x04010739 RID: 67385
		A,
		// Token: 0x0401073A RID: 67386
		ECharacterControllerChannelSwitch_MAX
	}
}
