using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.Statistics
{
	// Token: 0x02003DC0 RID: 15808
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/Statistics/EEffectStatisticsSortType.EEffectStatisticsSortType")]
	public enum EEffectStatisticsSortType : byte
	{
		// Token: 0x04013D66 RID: 81254
		ExistTime,
		// Token: 0x04013D67 RID: 81255
		Distance,
		// Token: 0x04013D68 RID: 81256
		TickCount,
		// Token: 0x04013D69 RID: 81257
		EEffectStatisticsSortType_MAX
	}
}
