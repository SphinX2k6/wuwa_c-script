using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints.Enum
{
	// Token: 0x02003A97 RID: 14999
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Enum/UDS_FeatureToggle.UDS_FeatureToggle")]
	public enum UDS_FeatureToggle : byte
	{
		// Token: 0x0400F7E4 RID: 63460
		Use_Built_In_Component,
		// Token: 0x0400F7E5 RID: 63461
		Use_Custom_Actor,
		// Token: 0x0400F7E6 RID: 63462
		Disable_Completely,
		// Token: 0x0400F7E7 RID: 63463
		UDS_MAX
	}
}
