using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200429F RID: 17055
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECaughtType.ECaughtType")]
	public enum ECaughtType : byte
	{
		// Token: 0x040172FD RID: 94973
		Socket,
		// Token: 0x040172FE RID: 94974
		Bullet,
		// Token: 0x040172FF RID: 94975
		ECaughtType_MAX
	}
}
