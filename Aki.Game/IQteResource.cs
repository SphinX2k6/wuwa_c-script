using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;

// Token: 0x02002628 RID: 9768
[NullableContext(2)]
public interface IQteResource
{
	// Token: 0x17001962 RID: 6498
	// (get) Token: 0x06013F59 RID: 81753
	// (set) Token: 0x06013F5A RID: 81754
	ULGUITexturePackerSpriteData Icon { get; set; }

	// Token: 0x17001963 RID: 6499
	// (get) Token: 0x06013F5B RID: 81755
	// (set) Token: 0x06013F5C RID: 81756
	EffectScreenPlayData_C ScreenEffect1 { get; set; }

	// Token: 0x17001964 RID: 6500
	// (get) Token: 0x06013F5D RID: 81757
	// (set) Token: 0x06013F5E RID: 81758
	EffectModelPostProcess ScreenEffect2 { get; set; }

	// Token: 0x17001965 RID: 6501
	// (get) Token: 0x06013F5F RID: 81759
	// (set) Token: 0x06013F60 RID: 81760
	UClass CameraShake { get; set; }

	// Token: 0x17001966 RID: 6502
	// (get) Token: 0x06013F61 RID: 81761
	// (set) Token: 0x06013F62 RID: 81762
	UKuroForceFeedbackEffect GamepadShake { get; set; }

	// Token: 0x17001967 RID: 6503
	// (get) Token: 0x06013F63 RID: 81763
	// (set) Token: 0x06013F64 RID: 81764
	UCurveFloat ScaleCurve { get; set; }
}
