using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Common.Enum
{
	// Token: 0x02003FA7 RID: 16295
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Common/Enum/EWeatherState.EWeatherState")]
	public enum EWeatherState : byte
	{
		// Token: 0x040155D0 RID: 87504
		晴天,
		// Token: 0x040155D1 RID: 87505
		下雨,
		// Token: 0x040155D2 RID: 87506
		打雷,
		// Token: 0x040155D3 RID: 87507
		多云,
		// Token: 0x040155D4 RID: 87508
		下雪,
		// Token: 0x040155D5 RID: 87509
		EWeatherState_MAX
	}
}
