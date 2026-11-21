using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Effect.Struct
{
	// Token: 0x02003228 RID: 12840
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Effect/Struct/EEffectPlay.EEffectPlay")]
	public enum EEffectPlay : byte
	{
		// Token: 0x040113B1 RID: 70577
		Default,
		// Token: 0x040113B2 RID: 70578
		Play,
		// Token: 0x040113B3 RID: 70579
		DoNotPlay,
		// Token: 0x040113B4 RID: 70580
		EEffectPlay_MAX
	}
}
