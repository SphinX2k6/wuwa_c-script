using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Quest.Enum
{
	// Token: 0x02003EC4 RID: 16068
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Quest/Enum/EQuestStepOrder.EQuestStepOrder")]
	public enum EQuestStepOrder : byte
	{
		// Token: 0x04014BFB RID: 84987
		起始步骤,
		// Token: 0x04014BFC RID: 84988
		过程步骤,
		// Token: 0x04014BFD RID: 84989
		结束步骤,
		// Token: 0x04014BFE RID: 84990
		EQuestStepOrder_MAX
	}
}
