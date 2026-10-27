using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime
{
	// Token: 0x02003AAB RID: 15019
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/ETrailQuality.ETrailQuality")]
	public enum ETrailQuality : byte
	{
		// Token: 0x0400F8C0 RID: 63680
		ExLow,
		// Token: 0x0400F8C1 RID: 63681
		Low,
		// Token: 0x0400F8C2 RID: 63682
		Midium,
		// Token: 0x0400F8C3 RID: 63683
		High,
		// Token: 0x0400F8C4 RID: 63684
		ExHigh,
		// Token: 0x0400F8C5 RID: 63685
		ETrailQuality_MAX
	}
}
