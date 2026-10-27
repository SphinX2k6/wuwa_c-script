using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200429E RID: 17054
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/ECaughtResultType.ECaughtResultType")]
	public enum ECaughtResultType : byte
	{
		// Token: 0x040172F8 RID: 94968
		Success,
		// Token: 0x040172F9 RID: 94969
		Fail,
		// Token: 0x040172FA RID: 94970
		Ignore,
		// Token: 0x040172FB RID: 94971
		ECaughtResultType_MAX
	}
}
