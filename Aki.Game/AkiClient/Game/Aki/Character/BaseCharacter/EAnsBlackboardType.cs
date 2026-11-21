using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032EB RID: 13035
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAnsBlackboardType.EAnsBlackboardType")]
	public enum EAnsBlackboardType : byte
	{
		// Token: 0x04011F96 RID: 73622
		Direct,
		// Token: 0x04011F97 RID: 73623
		Location,
		// Token: 0x04011F98 RID: 73624
		EntityId,
		// Token: 0x04011F99 RID: 73625
		Int,
		// Token: 0x04011F9A RID: 73626
		EAnsBlackboardType_MAX
	}
}
