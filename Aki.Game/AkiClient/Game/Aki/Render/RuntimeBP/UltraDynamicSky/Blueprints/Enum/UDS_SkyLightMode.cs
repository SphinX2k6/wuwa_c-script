using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints.Enum
{
	// Token: 0x02003A9A RID: 15002
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Enum/UDS_SkyLightMode.UDS_SkyLightMode")]
	public enum UDS_SkyLightMode : byte
	{
		// Token: 0x0400F7F6 RID: 63478
		Capture_Based,
		// Token: 0x0400F7F7 RID: 63479
		Custom_Cubemap,
		// Token: 0x0400F7F8 RID: 63480
		Cubemap_with_Dynamic_Color_Tinting,
		// Token: 0x0400F7F9 RID: 63481
		UDS_MAX
	}
}
