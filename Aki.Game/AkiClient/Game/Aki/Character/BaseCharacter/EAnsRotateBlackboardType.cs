using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200428C RID: 17036
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/EAnsRotateBlackboardType.EAnsRotateBlackboardType")]
	public enum EAnsRotateBlackboardType : byte
	{
		// Token: 0x04017282 RID: 94850
		EntityId,
		// Token: 0x04017283 RID: 94851
		Location,
		// Token: 0x04017284 RID: 94852
		Direct,
		// Token: 0x04017285 RID: 94853
		Int,
		// Token: 0x04017286 RID: 94854
		EAnsRotateBlackboardType_MAX
	}
}
