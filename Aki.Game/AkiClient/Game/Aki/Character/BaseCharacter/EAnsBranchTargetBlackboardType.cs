using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200428B RID: 17035
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAnsBranchTargetBlackboardType.EAnsBranchTargetBlackboardType")]
	public enum EAnsBranchTargetBlackboardType : byte
	{
		// Token: 0x0401727E RID: 94846
		EntityId,
		// Token: 0x0401727F RID: 94847
		Location,
		// Token: 0x04017280 RID: 94848
		EAnsBranchTargetBlackboardType_MAX
	}
}
