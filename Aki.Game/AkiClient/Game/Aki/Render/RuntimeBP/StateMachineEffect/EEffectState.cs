using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.StateMachineEffect
{
	// Token: 0x02003AC6 RID: 15046
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/StateMachineEffect/EEffectState.EEffectState")]
	public enum EEffectState : byte
	{
		// Token: 0x0400FB01 RID: 64257
		State1,
		// Token: 0x0400FB02 RID: 64258
		State2,
		// Token: 0x0400FB03 RID: 64259
		State3,
		// Token: 0x0400FB04 RID: 64260
		State4,
		// Token: 0x0400FB05 RID: 64261
		State5,
		// Token: 0x0400FB06 RID: 64262
		EEffectState_MAX
	}
}
