using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.TypeScript.Game.NewWorld.Character.SimpleNpc.Blueprint
{
	// Token: 0x02003A13 RID: 14867
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/SimpleNpc/Blueprint/EHolographicState.EHolographicState")]
	public enum EHolographicState : byte
	{
		// Token: 0x0400EF05 RID: 61189
		Start,
		// Token: 0x0400EF06 RID: 61190
		Loop,
		// Token: 0x0400EF07 RID: 61191
		End,
		// Token: 0x0400EF08 RID: 61192
		Over,
		// Token: 0x0400EF09 RID: 61193
		EHolographicState_MAX
	}
}
