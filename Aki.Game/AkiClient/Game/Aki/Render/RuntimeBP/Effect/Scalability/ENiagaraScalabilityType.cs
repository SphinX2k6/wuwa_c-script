using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scalability
{
	// Token: 0x0200310C RID: 12556
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scalability/ENiagaraScalabilityType.ENiagaraScalabilityType")]
	public enum ENiagaraScalabilityType : byte
	{
		// Token: 0x04010515 RID: 66837
		None,
		// Token: 0x04010516 RID: 66838
		Normal,
		// Token: 0x04010517 RID: 66839
		Scene,
		// Token: 0x04010518 RID: 66840
		FarSkill,
		// Token: 0x04010519 RID: 66841
		Importance,
		// Token: 0x0401051A RID: 66842
		ENiagaraScalabilityType_MAX
	}
}
