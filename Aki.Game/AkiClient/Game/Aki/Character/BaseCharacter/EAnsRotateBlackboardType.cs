using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032ED RID: 13037
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAnsRotateBlackboardType.EAnsRotateBlackboardType")]
	public enum EAnsRotateBlackboardType : byte
	{
		// Token: 0x04011FA0 RID: 73632
		EntityId,
		// Token: 0x04011FA1 RID: 73633
		Location,
		// Token: 0x04011FA2 RID: 73634
		Direct,
		// Token: 0x04011FA3 RID: 73635
		Int,
		// Token: 0x04011FA4 RID: 73636
		EAnsRotateBlackboardType_MAX
	}
}
