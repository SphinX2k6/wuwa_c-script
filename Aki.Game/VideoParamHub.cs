using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;

// Token: 0x02002CEC RID: 11500
[NullableContext(2)]
[Nullable(0)]
public class VideoParamHub : IVideoParamHub
{
	// Token: 0x1700209E RID: 8350
	// (get) Token: 0x0601823C RID: 98876 RVA: 0x006229E8 File Offset: 0x00620BE8
	// (set) Token: 0x0601823D RID: 98877 RVA: 0x006229F0 File Offset: 0x00620BF0
	public VideoData VideoDataConf { get; set; }

	// Token: 0x1700209F RID: 8351
	// (get) Token: 0x0601823E RID: 98878 RVA: 0x006229F9 File Offset: 0x00620BF9
	// (set) Token: 0x0601823F RID: 98879 RVA: 0x00622A01 File Offset: 0x00620C01
	public Action VideoCloseCb { get; set; }

	// Token: 0x170020A0 RID: 8352
	// (get) Token: 0x06018240 RID: 98880 RVA: 0x00622A0A File Offset: 0x00620C0A
	// (set) Token: 0x06018241 RID: 98881 RVA: 0x00622A12 File Offset: 0x00620C12
	public IMovieBackgroundFadeData BackgroundColor { get; set; }

	// Token: 0x170020A1 RID: 8353
	// (get) Token: 0x06018242 RID: 98882 RVA: 0x00622A1B File Offset: 0x00620C1B
	// (set) Token: 0x06018243 RID: 98883 RVA: 0x00622A23 File Offset: 0x00620C23
	public bool? RemainViewWhenEnd { get; set; }

	// Token: 0x170020A2 RID: 8354
	// (get) Token: 0x06018244 RID: 98884 RVA: 0x00622A2C File Offset: 0x00620C2C
	// (set) Token: 0x06018245 RID: 98885 RVA: 0x00622A34 File Offset: 0x00620C34
	public IProgramSpecialConfigBase ProgramSpecialConfig { get; set; }

	// Token: 0x170020A3 RID: 8355
	// (get) Token: 0x06018246 RID: 98886 RVA: 0x00622A3D File Offset: 0x00620C3D
	// (set) Token: 0x06018247 RID: 98887 RVA: 0x00622A45 File Offset: 0x00620C45
	public float? Mp4FadeOutTime { get; set; }

	// Token: 0x170020A4 RID: 8356
	// (get) Token: 0x06018248 RID: 98888 RVA: 0x00622A4E File Offset: 0x00620C4E
	// (set) Token: 0x06018249 RID: 98889 RVA: 0x00622A56 File Offset: 0x00620C56
	public float? BlackBorderFadeOutTime { get; set; }

	// Token: 0x170020A5 RID: 8357
	// (get) Token: 0x0601824A RID: 98890 RVA: 0x00622A5F File Offset: 0x00620C5F
	// (set) Token: 0x0601824B RID: 98891 RVA: 0x00622A67 File Offset: 0x00620C67
	public SetBlendAnim Mp4BlendAnim { get; set; }

	// Token: 0x170020A6 RID: 8358
	// (get) Token: 0x0601824C RID: 98892 RVA: 0x00622A70 File Offset: 0x00620C70
	// (set) Token: 0x0601824D RID: 98893 RVA: 0x00622A78 File Offset: 0x00620C78
	public bool? SeamlessEndOnTick { get; set; }
}
