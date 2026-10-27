using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints.Enum
{
	// Token: 0x02003A9E RID: 15006
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Enum/UDS_WeatherVariables.UDS_WeatherVariables")]
	public enum UDS_WeatherVariables : byte
	{
		// Token: 0x0400F815 RID: 63509
		Weather_Intensity,
		// Token: 0x0400F816 RID: 63510
		Cloudiness,
		// Token: 0x0400F817 RID: 63511
		Wind_Intensity,
		// Token: 0x0400F818 RID: 63512
		Rain_Snow,
		// Token: 0x0400F819 RID: 63513
		UDS_MAX
	}
}
