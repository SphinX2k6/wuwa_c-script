using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;

// Token: 0x02002246 RID: 8774
[NullableContext(2)]
[Nullable(0)]
public class VideoParamHub : IVideoParamHub
{
	// Token: 0x170020F7 RID: 8439
	// (get) Token: 0x06015AC7 RID: 88775 RVA: 0x0064867E File Offset: 0x0064687E
	// (set) Token: 0x06015AC8 RID: 88776 RVA: 0x00648686 File Offset: 0x00646886
	public VideoData VideoDataConf { get; set; }

	// Token: 0x170020F8 RID: 8440
	// (get) Token: 0x06015AC9 RID: 88777 RVA: 0x0064868F File Offset: 0x0064688F
	// (set) Token: 0x06015ACA RID: 88778 RVA: 0x00648697 File Offset: 0x00646897
	public Action VideoCloseCb { get; set; }

	// Token: 0x170020F9 RID: 8441
	// (get) Token: 0x06015ACB RID: 88779 RVA: 0x006486A0 File Offset: 0x006468A0
	// (set) Token: 0x06015ACC RID: 88780 RVA: 0x006486A8 File Offset: 0x006468A8
	public IMovieBackgroundFadeData BackgroundColor { get; set; }

	// Token: 0x170020FA RID: 8442
	// (get) Token: 0x06015ACD RID: 88781 RVA: 0x006486B1 File Offset: 0x006468B1
	// (set) Token: 0x06015ACE RID: 88782 RVA: 0x006486B9 File Offset: 0x006468B9
	public bool? RemainViewWhenEnd { get; set; }

	// Token: 0x170020FB RID: 8443
	// (get) Token: 0x06015ACF RID: 88783 RVA: 0x006486C2 File Offset: 0x006468C2
	// (set) Token: 0x06015AD0 RID: 88784 RVA: 0x006486CA File Offset: 0x006468CA
	public IProgramSpecialConfigBase ProgramSpecialConfig { get; set; }

	// Token: 0x170020FC RID: 8444
	// (get) Token: 0x06015AD1 RID: 88785 RVA: 0x006486D3 File Offset: 0x006468D3
	// (set) Token: 0x06015AD2 RID: 88786 RVA: 0x006486DB File Offset: 0x006468DB
	public float? Mp4FadeOutTime { get; set; }

	// Token: 0x170020FD RID: 8445
	// (get) Token: 0x06015AD3 RID: 88787 RVA: 0x006486E4 File Offset: 0x006468E4
	// (set) Token: 0x06015AD4 RID: 88788 RVA: 0x006486EC File Offset: 0x006468EC
	public float? BlackBorderFadeOutTime { get; set; }

	// Token: 0x170020FE RID: 8446
	// (get) Token: 0x06015AD5 RID: 88789 RVA: 0x006486F5 File Offset: 0x006468F5
	// (set) Token: 0x06015AD6 RID: 88790 RVA: 0x006486FD File Offset: 0x006468FD
	public SetBlendAnim Mp4BlendAnim { get; set; }

	// Token: 0x170020FF RID: 8447
	// (get) Token: 0x06015AD7 RID: 88791 RVA: 0x00648706 File Offset: 0x00646906
	// (set) Token: 0x06015AD8 RID: 88792 RVA: 0x0064870E File Offset: 0x0064690E
	public bool? SeamlessEndOnTick { get; set; }

	// Token: 0x17002100 RID: 8448
	// (get) Token: 0x06015AD9 RID: 88793 RVA: 0x00648717 File Offset: 0x00646917
	// (set) Token: 0x06015ADA RID: 88794 RVA: 0x0064871F File Offset: 0x0064691F
	public EVideoSkipType SkipType { get; set; }

	// Token: 0x17002101 RID: 8449
	// (get) Token: 0x06015ADB RID: 88795 RVA: 0x00648728 File Offset: 0x00646928
	// (set) Token: 0x06015ADC RID: 88796 RVA: 0x00648730 File Offset: 0x00646930
	public Action SkipCallback { get; set; }
}
