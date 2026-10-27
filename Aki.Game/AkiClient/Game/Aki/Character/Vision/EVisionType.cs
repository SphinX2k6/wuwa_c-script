using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Character.Vision
{
	// Token: 0x0200402C RID: 16428
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Character/Vision/EVisionType.EVisionType")]
	public enum EVisionType : byte
	{
		// Token: 0x04015B70 RID: 88944
		召唤,
		// Token: 0x04015B71 RID: 88945
		变身,
		// Token: 0x04015B72 RID: 88946
		探索,
		// Token: 0x04015B73 RID: 88947
		操控,
		// Token: 0x04015B74 RID: 88948
		驻场,
		// Token: 0x04015B75 RID: 88949
		BossRush,
		// Token: 0x04015B76 RID: 88950
		新探索,
		// Token: 0x04015B77 RID: 88951
		EVisionType_MAX
	}
}
