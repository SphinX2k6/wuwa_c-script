using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints.Enum
{
	// Token: 0x02003A9B RID: 15003
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Enum/UDS_SkyMode.UDS_SkyMode")]
	public enum UDS_SkyMode : byte
	{
		// Token: 0x0400F7FB RID: 63483
		Volumetric_Clouds,
		// Token: 0x0400F7FC RID: 63484
		Static_Clouds,
		// Token: 0x0400F7FD RID: 63485
		_2D_Dynamic_Clouds,
		// Token: 0x0400F7FE RID: 63486
		No_Clouds,
		// Token: 0x0400F7FF RID: 63487
		_2D_Clouds_using_Color_Curves__Legacy_Mode_,
		// Token: 0x0400F800 RID: 63488
		Volumetric_Aurora,
		// Token: 0x0400F801 RID: 63489
		UDS_MAX
	}
}
