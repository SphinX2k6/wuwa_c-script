using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Quest.Enum
{
	// Token: 0x02003EC3 RID: 16067
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Quest/Enum/EQuestHandleType.EQuestHandleType")]
	public enum EQuestHandleType : byte
	{
		// Token: 0x04014BF7 RID: 84983
		TriggerQuestStep,
		// Token: 0x04014BF8 RID: 84984
		FinishQuestStep,
		// Token: 0x04014BF9 RID: 84985
		EQuestHandleType_MAX
	}
}
