using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;

// Token: 0x02001B13 RID: 6931
[NullableContext(2)]
public interface IQteResource
{
	// Token: 0x1700199A RID: 6554
	// (get) Token: 0x0601143B RID: 70715
	// (set) Token: 0x0601143C RID: 70716
	ULGUITexturePackerSpriteData Icon { get; set; }

	// Token: 0x1700199B RID: 6555
	// (get) Token: 0x0601143D RID: 70717
	// (set) Token: 0x0601143E RID: 70718
	EffectScreenPlayData_C ScreenEffect1 { get; set; }

	// Token: 0x1700199C RID: 6556
	// (get) Token: 0x0601143F RID: 70719
	// (set) Token: 0x06011440 RID: 70720
	EffectModelPostProcess ScreenEffect2 { get; set; }

	// Token: 0x1700199D RID: 6557
	// (get) Token: 0x06011441 RID: 70721
	// (set) Token: 0x06011442 RID: 70722
	UClass CameraShake { get; set; }

	// Token: 0x1700199E RID: 6558
	// (get) Token: 0x06011443 RID: 70723
	// (set) Token: 0x06011444 RID: 70724
	UKuroForceFeedbackEffect GamepadShake { get; set; }

	// Token: 0x1700199F RID: 6559
	// (get) Token: 0x06011445 RID: 70725
	// (set) Token: 0x06011446 RID: 70726
	UCurveFloat ScaleCurve { get; set; }
}
