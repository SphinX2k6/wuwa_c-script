using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Quest.Enum
{
	// Token: 0x02003EC7 RID: 16071
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Quest/Enum/EQuestType.EQuestType")]
	public enum EQuestType : byte
	{
		// Token: 0x04014C0C RID: 85004
		主线任务,
		// Token: 0x04014C0D RID: 85005
		支线任务,
		// Token: 0x04014C0E RID: 85006
		EQuestType_MAX
	}
}
