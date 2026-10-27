using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints.Enum
{
	// Token: 0x02003A9C RID: 15004
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Enum/UDS_TemperatureType.UDS_TemperatureType")]
	public enum UDS_TemperatureType : byte
	{
		// Token: 0x0400F803 RID: 63491
		Fahrenheit,
		// Token: 0x0400F804 RID: 63492
		Celsius,
		// Token: 0x0400F805 RID: 63493
		UDS_MAX
	}
}
