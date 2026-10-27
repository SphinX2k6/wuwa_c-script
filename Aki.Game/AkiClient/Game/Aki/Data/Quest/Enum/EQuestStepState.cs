using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Quest.Enum
{
	// Token: 0x02003EC5 RID: 16069
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Quest/Enum/EQuestStepState.EQuestStepState")]
	public enum EQuestStepState : byte
	{
		// Token: 0x04014C00 RID: 84992
		未激活,
		// Token: 0x04014C01 RID: 84993
		可接取,
		// Token: 0x04014C02 RID: 84994
		进行中,
		// Token: 0x04014C03 RID: 84995
		已完成,
		// Token: 0x04014C04 RID: 84996
		已删除,
		// Token: 0x04014C05 RID: 84997
		EQuestStepState_MAX
	}
}
