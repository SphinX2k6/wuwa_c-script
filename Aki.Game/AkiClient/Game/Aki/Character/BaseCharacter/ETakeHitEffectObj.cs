using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042E4 RID: 17124
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ETakeHitEffectObj.ETakeHitEffectObj")]
	public enum ETakeHitEffectObj : byte
	{
		// Token: 0x040174FF RID: 95487
		Default,
		// Token: 0x04017500 RID: 95488
		子弹未击中,
		// Token: 0x04017501 RID: 95489
		树木,
		// Token: 0x04017502 RID: 95490
		金属,
		// Token: 0x04017503 RID: 95491
		岩石,
		// Token: 0x04017504 RID: 95492
		ETakeHitEffectObj_MAX
	}
}
