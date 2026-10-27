using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController
{
	// Token: 0x02003E10 RID: 15888
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/MaterialController/ECharacterControllerChannelSwitch.ECharacterControllerChannelSwitch")]
	public enum ECharacterControllerChannelSwitch : byte
	{
		// Token: 0x0401428A RID: 82570
		RGB,
		// Token: 0x0401428B RID: 82571
		R,
		// Token: 0x0401428C RID: 82572
		G,
		// Token: 0x0401428D RID: 82573
		B,
		// Token: 0x0401428E RID: 82574
		A,
		// Token: 0x0401428F RID: 82575
		ECharacterControllerChannelSwitch_MAX
	}
}
