using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;

// Token: 0x02001B14 RID: 6932
[NullableContext(2)]
[Nullable(0)]
public class QteResource : IQteResource
{
	// Token: 0x170019A0 RID: 6560
	// (get) Token: 0x06011447 RID: 70727 RVA: 0x00514257 File Offset: 0x00512457
	// (set) Token: 0x06011448 RID: 70728 RVA: 0x0051425F File Offset: 0x0051245F
	public ULGUITexturePackerSpriteData Icon { get; set; }

	// Token: 0x170019A1 RID: 6561
	// (get) Token: 0x06011449 RID: 70729 RVA: 0x00514268 File Offset: 0x00512468
	// (set) Token: 0x0601144A RID: 70730 RVA: 0x00514270 File Offset: 0x00512470
	public EffectScreenPlayData_C ScreenEffect1 { get; set; }

	// Token: 0x170019A2 RID: 6562
	// (get) Token: 0x0601144B RID: 70731 RVA: 0x00514279 File Offset: 0x00512479
	// (set) Token: 0x0601144C RID: 70732 RVA: 0x00514281 File Offset: 0x00512481
	public EffectModelPostProcess ScreenEffect2 { get; set; }

	// Token: 0x170019A3 RID: 6563
	// (get) Token: 0x0601144D RID: 70733 RVA: 0x0051428A File Offset: 0x0051248A
	// (set) Token: 0x0601144E RID: 70734 RVA: 0x00514292 File Offset: 0x00512492
	public UClass CameraShake { get; set; }

	// Token: 0x170019A4 RID: 6564
	// (get) Token: 0x0601144F RID: 70735 RVA: 0x0051429B File Offset: 0x0051249B
	// (set) Token: 0x06011450 RID: 70736 RVA: 0x005142A3 File Offset: 0x005124A3
	public UKuroForceFeedbackEffect GamepadShake { get; set; }

	// Token: 0x170019A5 RID: 6565
	// (get) Token: 0x06011451 RID: 70737 RVA: 0x005142AC File Offset: 0x005124AC
	// (set) Token: 0x06011452 RID: 70738 RVA: 0x005142B4 File Offset: 0x005124B4
	public UCurveFloat ScaleCurve { get; set; }
}
