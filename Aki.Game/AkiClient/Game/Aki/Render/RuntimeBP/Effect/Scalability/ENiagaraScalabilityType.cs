using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scalability
{
	// Token: 0x02003DD1 RID: 15825
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Scalability/ENiagaraScalabilityType.ENiagaraScalabilityType")]
	public enum ENiagaraScalabilityType : byte
	{
		// Token: 0x04013EA3 RID: 81571
		None,
		// Token: 0x04013EA4 RID: 81572
		Normal,
		// Token: 0x04013EA5 RID: 81573
		Scene,
		// Token: 0x04013EA6 RID: 81574
		FarSkill,
		// Token: 0x04013EA7 RID: 81575
		Importance,
		// Token: 0x04013EA8 RID: 81576
		ENiagaraScalabilityType_MAX
	}
}
