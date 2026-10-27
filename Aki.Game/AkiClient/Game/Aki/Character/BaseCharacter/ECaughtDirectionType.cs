using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200429D RID: 17053
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECaughtDirectionType.ECaughtDirectionType")]
	public enum ECaughtDirectionType : byte
	{
		// Token: 0x040172F2 RID: 94962
		CaughtDirection,
		// Token: 0x040172F3 RID: 94963
		BoxDirection,
		// Token: 0x040172F4 RID: 94964
		SpeedDirection,
		// Token: 0x040172F5 RID: 94965
		None,
		// Token: 0x040172F6 RID: 94966
		ECaughtDirectionType_MAX
	}
}
