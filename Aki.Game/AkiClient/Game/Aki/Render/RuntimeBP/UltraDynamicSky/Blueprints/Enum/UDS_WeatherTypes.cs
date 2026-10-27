using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints.Enum
{
	// Token: 0x02003A9D RID: 15005
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Enum/UDS_WeatherTypes.UDS_WeatherTypes")]
	public enum UDS_WeatherTypes : byte
	{
		// Token: 0x0400F807 RID: 63495
		Clear_Skies,
		// Token: 0x0400F808 RID: 63496
		Partly_Cloudy,
		// Token: 0x0400F809 RID: 63497
		Cloudy,
		// Token: 0x0400F80A RID: 63498
		Overcast,
		// Token: 0x0400F80B RID: 63499
		Foggy,
		// Token: 0x0400F80C RID: 63500
		Light_Rain,
		// Token: 0x0400F80D RID: 63501
		Rain,
		// Token: 0x0400F80E RID: 63502
		Thunderstorm,
		// Token: 0x0400F80F RID: 63503
		Light_Snow,
		// Token: 0x0400F810 RID: 63504
		Snow,
		// Token: 0x0400F811 RID: 63505
		Blizzard,
		// Token: 0x0400F812 RID: 63506
		Select_Preset,
		// Token: 0x0400F813 RID: 63507
		UDS_MAX
	}
}
