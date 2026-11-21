using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Data.Common.Enum
{
	// Token: 0x02003230 RID: 12848
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Data/Common/Enum/EWeatherState.EWeatherState")]
	public enum EWeatherState : byte
	{
		// Token: 0x040113F5 RID: 70645
		晴天,
		// Token: 0x040113F6 RID: 70646
		下雨,
		// Token: 0x040113F7 RID: 70647
		打雷,
		// Token: 0x040113F8 RID: 70648
		多云,
		// Token: 0x040113F9 RID: 70649
		下雪,
		// Token: 0x040113FA RID: 70650
		EWeatherState_MAX
	}
}
