using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003302 RID: 13058
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECurveMoveTargetBlackboardType.ECurveMoveTargetBlackboardType")]
	public enum ECurveMoveTargetBlackboardType : byte
	{
		// Token: 0x04012043 RID: 73795
		Entity,
		// Token: 0x04012044 RID: 73796
		EntityId,
		// Token: 0x04012045 RID: 73797
		CreatureDataId,
		// Token: 0x04012046 RID: 73798
		LocationVector,
		// Token: 0x04012047 RID: 73799
		ECurveMoveTargetBlackboardType_MAX
	}
}
