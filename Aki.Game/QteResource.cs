using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;

// Token: 0x02002629 RID: 9769
[NullableContext(2)]
[Nullable(0)]
public class QteResource : IQteResource
{
	// Token: 0x17001968 RID: 6504
	// (get) Token: 0x06013F65 RID: 81765 RVA: 0x00505393 File Offset: 0x00503593
	// (set) Token: 0x06013F66 RID: 81766 RVA: 0x0050539B File Offset: 0x0050359B
	public ULGUITexturePackerSpriteData Icon { get; set; }

	// Token: 0x17001969 RID: 6505
	// (get) Token: 0x06013F67 RID: 81767 RVA: 0x005053A4 File Offset: 0x005035A4
	// (set) Token: 0x06013F68 RID: 81768 RVA: 0x005053AC File Offset: 0x005035AC
	public EffectScreenPlayData_C ScreenEffect1 { get; set; }

	// Token: 0x1700196A RID: 6506
	// (get) Token: 0x06013F69 RID: 81769 RVA: 0x005053B5 File Offset: 0x005035B5
	// (set) Token: 0x06013F6A RID: 81770 RVA: 0x005053BD File Offset: 0x005035BD
	public EffectModelPostProcess ScreenEffect2 { get; set; }

	// Token: 0x1700196B RID: 6507
	// (get) Token: 0x06013F6B RID: 81771 RVA: 0x005053C6 File Offset: 0x005035C6
	// (set) Token: 0x06013F6C RID: 81772 RVA: 0x005053CE File Offset: 0x005035CE
	public UClass CameraShake { get; set; }

	// Token: 0x1700196C RID: 6508
	// (get) Token: 0x06013F6D RID: 81773 RVA: 0x005053D7 File Offset: 0x005035D7
	// (set) Token: 0x06013F6E RID: 81774 RVA: 0x005053DF File Offset: 0x005035DF
	public UKuroForceFeedbackEffect GamepadShake { get; set; }

	// Token: 0x1700196D RID: 6509
	// (get) Token: 0x06013F6F RID: 81775 RVA: 0x005053E8 File Offset: 0x005035E8
	// (set) Token: 0x06013F70 RID: 81776 RVA: 0x005053F0 File Offset: 0x005035F0
	public UCurveFloat ScaleCurve { get; set; }
}
