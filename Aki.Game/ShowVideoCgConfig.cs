using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002244 RID: 8772
[NullableContext(2)]
[Nullable(0)]
public class ShowVideoCgConfig : IShowVideoCgConfig
{
	// Token: 0x170020E2 RID: 8418
	// (get) Token: 0x06015A9C RID: 88732 RVA: 0x006485CC File Offset: 0x006467CC
	// (set) Token: 0x06015A9D RID: 88733 RVA: 0x006485D4 File Offset: 0x006467D4
	public IMovieBackgroundFadeData BackgroundFade { get; set; }

	// Token: 0x170020E3 RID: 8419
	// (get) Token: 0x06015A9E RID: 88734 RVA: 0x006485DD File Offset: 0x006467DD
	// (set) Token: 0x06015A9F RID: 88735 RVA: 0x006485E5 File Offset: 0x006467E5
	public bool? RemainViewWhenEnd { get; set; }

	// Token: 0x170020E4 RID: 8420
	// (get) Token: 0x06015AA0 RID: 88736 RVA: 0x006485EE File Offset: 0x006467EE
	// (set) Token: 0x06015AA1 RID: 88737 RVA: 0x006485F6 File Offset: 0x006467F6
	public bool? InPlot { get; set; }

	// Token: 0x170020E5 RID: 8421
	// (get) Token: 0x06015AA2 RID: 88738 RVA: 0x006485FF File Offset: 0x006467FF
	// (set) Token: 0x06015AA3 RID: 88739 RVA: 0x00648607 File Offset: 0x00646807
	public IProgramSpecialConfigBase ProgramSpecialConfig { get; set; }

	// Token: 0x170020E6 RID: 8422
	// (get) Token: 0x06015AA4 RID: 88740 RVA: 0x00648610 File Offset: 0x00646810
	// (set) Token: 0x06015AA5 RID: 88741 RVA: 0x00648618 File Offset: 0x00646818
	public float? Mp4FadeOutTime { get; set; }

	// Token: 0x170020E7 RID: 8423
	// (get) Token: 0x06015AA6 RID: 88742 RVA: 0x00648621 File Offset: 0x00646821
	// (set) Token: 0x06015AA7 RID: 88743 RVA: 0x00648629 File Offset: 0x00646829
	public float? BlackBorderFadeOutTime { get; set; }

	// Token: 0x170020E8 RID: 8424
	// (get) Token: 0x06015AA8 RID: 88744 RVA: 0x00648632 File Offset: 0x00646832
	// (set) Token: 0x06015AA9 RID: 88745 RVA: 0x0064863A File Offset: 0x0064683A
	public SetBlendAnim Mp4BlendAnim { get; set; }

	// Token: 0x170020E9 RID: 8425
	// (get) Token: 0x06015AAA RID: 88746 RVA: 0x00648643 File Offset: 0x00646843
	// (set) Token: 0x06015AAB RID: 88747 RVA: 0x0064864B File Offset: 0x0064684B
	public bool? SeamlessEndOnTick { get; set; }

	// Token: 0x170020EA RID: 8426
	// (get) Token: 0x06015AAC RID: 88748 RVA: 0x00648654 File Offset: 0x00646854
	// (set) Token: 0x06015AAD RID: 88749 RVA: 0x0064865C File Offset: 0x0064685C
	public EVideoSkipType SkipType { get; set; }

	// Token: 0x170020EB RID: 8427
	// (get) Token: 0x06015AAE RID: 88750 RVA: 0x00648665 File Offset: 0x00646865
	// (set) Token: 0x06015AAF RID: 88751 RVA: 0x0064866D File Offset: 0x0064686D
	public Action SkipCallback { get; set; }
}
