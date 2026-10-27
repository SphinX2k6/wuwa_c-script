using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Condition.Enum
{
	// Token: 0x02003FA1 RID: 16289
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Condition/Enum/SConDitionGroupType.SConditionGroupType")]
	public enum SConditionGroupType : byte
	{
		// Token: 0x040155AA RID: 87466
		AND,
		// Token: 0x040155AB RID: 87467
		OR,
		// Token: 0x040155AC RID: 87468
		SConditionGroupType_MAX
	}
}
