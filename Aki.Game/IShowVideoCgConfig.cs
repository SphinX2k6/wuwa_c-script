using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002243 RID: 8771
[NullableContext(2)]
public interface IShowVideoCgConfig
{
	// Token: 0x170020D8 RID: 8408
	// (get) Token: 0x06015A88 RID: 88712
	// (set) Token: 0x06015A89 RID: 88713
	IMovieBackgroundFadeData BackgroundFade { get; set; }

	// Token: 0x170020D9 RID: 8409
	// (get) Token: 0x06015A8A RID: 88714
	// (set) Token: 0x06015A8B RID: 88715
	bool? RemainViewWhenEnd { get; set; }

	// Token: 0x170020DA RID: 8410
	// (get) Token: 0x06015A8C RID: 88716
	// (set) Token: 0x06015A8D RID: 88717
	bool? InPlot { get; set; }

	// Token: 0x170020DB RID: 8411
	// (get) Token: 0x06015A8E RID: 88718
	// (set) Token: 0x06015A8F RID: 88719
	IProgramSpecialConfigBase ProgramSpecialConfig { get; set; }

	// Token: 0x170020DC RID: 8412
	// (get) Token: 0x06015A90 RID: 88720
	// (set) Token: 0x06015A91 RID: 88721
	float? Mp4FadeOutTime { get; set; }

	// Token: 0x170020DD RID: 8413
	// (get) Token: 0x06015A92 RID: 88722
	// (set) Token: 0x06015A93 RID: 88723
	float? BlackBorderFadeOutTime { get; set; }

	// Token: 0x170020DE RID: 8414
	// (get) Token: 0x06015A94 RID: 88724
	// (set) Token: 0x06015A95 RID: 88725
	SetBlendAnim Mp4BlendAnim { get; set; }

	// Token: 0x170020DF RID: 8415
	// (get) Token: 0x06015A96 RID: 88726
	// (set) Token: 0x06015A97 RID: 88727
	bool? SeamlessEndOnTick { get; set; }

	// Token: 0x170020E0 RID: 8416
	// (get) Token: 0x06015A98 RID: 88728
	// (set) Token: 0x06015A99 RID: 88729
	EVideoSkipType SkipType { get; set; }

	// Token: 0x170020E1 RID: 8417
	// (get) Token: 0x06015A9A RID: 88730
	// (set) Token: 0x06015A9B RID: 88731
	Action SkipCallback { get; set; }
}
