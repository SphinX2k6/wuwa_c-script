using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Quest.Enum
{
	// Token: 0x02003EC6 RID: 16070
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Quest/Enum/EQuestStepType.EQuestStepType")]
	public enum EQuestStepType : byte
	{
		// Token: 0x04014C07 RID: 84999
		Sequence,
		// Token: 0x04014C08 RID: 85000
		战斗,
		// Token: 0x04014C09 RID: 85001
		收集,
		// Token: 0x04014C0A RID: 85002
		EQuestStepType_MAX
	}
}
