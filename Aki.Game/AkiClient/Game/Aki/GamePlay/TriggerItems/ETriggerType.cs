using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.GamePlay.TriggerItems
{
	// Token: 0x02003E52 RID: 15954
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/GamePlay/TriggerItems/ETriggerType.ETriggerType")]
	public enum ETriggerType : byte
	{
		// Token: 0x04014683 RID: 83587
		Wall,
		// Token: 0x04014684 RID: 83588
		NotOpened,
		// Token: 0x04014685 RID: 83589
		Hurt,
		// Token: 0x04014686 RID: 83590
		Plot,
		// Token: 0x04014687 RID: 83591
		Events,
		// Token: 0x04014688 RID: 83592
		ControlObject,
		// Token: 0x04014689 RID: 83593
		EffectArea,
		// Token: 0x0401468A RID: 83594
		ETriggerType_MAX
	}
}
