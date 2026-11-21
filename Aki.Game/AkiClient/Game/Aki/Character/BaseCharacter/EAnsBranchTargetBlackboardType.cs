using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032EC RID: 13036
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAnsBranchTargetBlackboardType.EAnsBranchTargetBlackboardType")]
	public enum EAnsBranchTargetBlackboardType : byte
	{
		// Token: 0x04011F9C RID: 73628
		EntityId,
		// Token: 0x04011F9D RID: 73629
		Location,
		// Token: 0x04011F9E RID: 73630
		EAnsBranchTargetBlackboardType_MAX
	}
}
