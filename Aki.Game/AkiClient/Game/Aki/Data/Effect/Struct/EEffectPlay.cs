using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Effect.Struct
{
	// Token: 0x02003F98 RID: 16280
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Effect/Struct/EEffectPlay.EEffectPlay")]
	public enum EEffectPlay : byte
	{
		// Token: 0x0401555F RID: 87391
		Default,
		// Token: 0x04015560 RID: 87392
		Play,
		// Token: 0x04015561 RID: 87393
		DoNotPlay,
		// Token: 0x04015562 RID: 87394
		EEffectPlay_MAX
	}
}
