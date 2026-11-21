using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x020030AB RID: 12459
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/EEffectState.EEffectState")]
	public enum EEffectState : byte
	{
		// Token: 0x0400FC50 RID: 64592
		State1,
		// Token: 0x0400FC51 RID: 64593
		State2,
		// Token: 0x0400FC52 RID: 64594
		State3,
		// Token: 0x0400FC53 RID: 64595
		State4,
		// Token: 0x0400FC54 RID: 64596
		State5,
		// Token: 0x0400FC55 RID: 64597
		EEffectState_MAX
	}
}
