using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042A7 RID: 17063
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECurveMoveTargetBlackboardType.ECurveMoveTargetBlackboardType")]
	public enum ECurveMoveTargetBlackboardType : byte
	{
		// Token: 0x04017345 RID: 95045
		Entity,
		// Token: 0x04017346 RID: 95046
		EntityId,
		// Token: 0x04017347 RID: 95047
		CreatureDataId,
		// Token: 0x04017348 RID: 95048
		LocationVector,
		// Token: 0x04017349 RID: 95049
		ECurveMoveTargetBlackboardType_MAX
	}
}
