using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002CEA RID: 11498
[NullableContext(2)]
[Nullable(0)]
public class ShowVideoCgConfig : IShowVideoCgConfig
{
	// Token: 0x1700208D RID: 8333
	// (get) Token: 0x06018219 RID: 98841 RVA: 0x00622958 File Offset: 0x00620B58
	// (set) Token: 0x0601821A RID: 98842 RVA: 0x00622960 File Offset: 0x00620B60
	public IMovieBackgroundFadeData BackgroundFade { get; set; }

	// Token: 0x1700208E RID: 8334
	// (get) Token: 0x0601821B RID: 98843 RVA: 0x00622969 File Offset: 0x00620B69
	// (set) Token: 0x0601821C RID: 98844 RVA: 0x00622971 File Offset: 0x00620B71
	public bool? RemainViewWhenEnd { get; set; }

	// Token: 0x1700208F RID: 8335
	// (get) Token: 0x0601821D RID: 98845 RVA: 0x0062297A File Offset: 0x00620B7A
	// (set) Token: 0x0601821E RID: 98846 RVA: 0x00622982 File Offset: 0x00620B82
	public bool? InPlot { get; set; }

	// Token: 0x17002090 RID: 8336
	// (get) Token: 0x0601821F RID: 98847 RVA: 0x0062298B File Offset: 0x00620B8B
	// (set) Token: 0x06018220 RID: 98848 RVA: 0x00622993 File Offset: 0x00620B93
	public IProgramSpecialConfigBase ProgramSpecialConfig { get; set; }

	// Token: 0x17002091 RID: 8337
	// (get) Token: 0x06018221 RID: 98849 RVA: 0x0062299C File Offset: 0x00620B9C
	// (set) Token: 0x06018222 RID: 98850 RVA: 0x006229A4 File Offset: 0x00620BA4
	public float? Mp4FadeOutTime { get; set; }

	// Token: 0x17002092 RID: 8338
	// (get) Token: 0x06018223 RID: 98851 RVA: 0x006229AD File Offset: 0x00620BAD
	// (set) Token: 0x06018224 RID: 98852 RVA: 0x006229B5 File Offset: 0x00620BB5
	public float? BlackBorderFadeOutTime { get; set; }

	// Token: 0x17002093 RID: 8339
	// (get) Token: 0x06018225 RID: 98853 RVA: 0x006229BE File Offset: 0x00620BBE
	// (set) Token: 0x06018226 RID: 98854 RVA: 0x006229C6 File Offset: 0x00620BC6
	public SetBlendAnim Mp4BlendAnim { get; set; }

	// Token: 0x17002094 RID: 8340
	// (get) Token: 0x06018227 RID: 98855 RVA: 0x006229CF File Offset: 0x00620BCF
	// (set) Token: 0x06018228 RID: 98856 RVA: 0x006229D7 File Offset: 0x00620BD7
	public bool? SeamlessEndOnTick { get; set; }
}
