using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Quest.Enum
{
	// Token: 0x0200318C RID: 12684
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Quest/Enum/EQuestStepState.EQuestStepState")]
	public enum EQuestStepState : byte
	{
		// Token: 0x04010BEF RID: 68591
		未激活,
		// Token: 0x04010BF0 RID: 68592
		可接取,
		// Token: 0x04010BF1 RID: 68593
		进行中,
		// Token: 0x04010BF2 RID: 68594
		已完成,
		// Token: 0x04010BF3 RID: 68595
		已删除,
		// Token: 0x04010BF4 RID: 68596
		EQuestStepState_MAX
	}
}
