using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042E2 RID: 17122
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ESwim.ESwim")]
	public enum ESwim : byte
	{
		// Token: 0x040174F4 RID: 95476
		NormalSwim,
		// Token: 0x040174F5 RID: 95477
		FastSwim,
		// Token: 0x040174F6 RID: 95478
		Floating,
		// Token: 0x040174F7 RID: 95479
		ESwim_MAX
	}
}
