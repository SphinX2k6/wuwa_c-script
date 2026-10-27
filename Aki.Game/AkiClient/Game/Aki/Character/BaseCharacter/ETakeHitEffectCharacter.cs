using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042E3 RID: 17123
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ETakeHitEffectCharacter.ETakeHitEffectCharacter")]
	public enum ETakeHitEffectCharacter : byte
	{
		// Token: 0x040174F9 RID: 95481
		_default,
		// Token: 0x040174FA RID: 95482
		肉质,
		// Token: 0x040174FB RID: 95483
		金属,
		// Token: 0x040174FC RID: 95484
		矿石,
		// Token: 0x040174FD RID: 95485
		ETakeHitEffectCharacter_MAX
	}
}
