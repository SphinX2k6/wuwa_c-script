using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UltraDynamicSky.Blueprints.Enum
{
	// Token: 0x02003A98 RID: 15000
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UltraDynamicSky/Blueprints/Enum/UDS_NoiseType.UDS_NoiseType")]
	public enum UDS_NoiseType : byte
	{
		// Token: 0x0400F7E9 RID: 63465
		Classic,
		// Token: 0x0400F7EA RID: 63466
		Voronoi,
		// Token: 0x0400F7EB RID: 63467
		Voronoi_Smooth,
		// Token: 0x0400F7EC RID: 63468
		Voronoi_Diverse,
		// Token: 0x0400F7ED RID: 63469
		Custom,
		// Token: 0x0400F7EE RID: 63470
		UDS_MAX
	}
}
