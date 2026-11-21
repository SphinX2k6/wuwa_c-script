using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;

// Token: 0x02002245 RID: 8773
[NullableContext(2)]
public interface IVideoParamHub
{
	// Token: 0x170020EC RID: 8428
	// (get) Token: 0x06015AB1 RID: 88753
	// (set) Token: 0x06015AB2 RID: 88754
	VideoData VideoDataConf { get; set; }

	// Token: 0x170020ED RID: 8429
	// (get) Token: 0x06015AB3 RID: 88755
	// (set) Token: 0x06015AB4 RID: 88756
	Action VideoCloseCb { get; set; }

	// Token: 0x170020EE RID: 8430
	// (get) Token: 0x06015AB5 RID: 88757
	// (set) Token: 0x06015AB6 RID: 88758
	IMovieBackgroundFadeData BackgroundColor { get; set; }

	// Token: 0x170020EF RID: 8431
	// (get) Token: 0x06015AB7 RID: 88759
	// (set) Token: 0x06015AB8 RID: 88760
	bool? RemainViewWhenEnd { get; set; }

	// Token: 0x170020F0 RID: 8432
	// (get) Token: 0x06015AB9 RID: 88761
	// (set) Token: 0x06015ABA RID: 88762
	IProgramSpecialConfigBase ProgramSpecialConfig { get; set; }

	// Token: 0x170020F1 RID: 8433
	// (get) Token: 0x06015ABB RID: 88763
	// (set) Token: 0x06015ABC RID: 88764
	float? Mp4FadeOutTime { get; set; }

	// Token: 0x170020F2 RID: 8434
	// (get) Token: 0x06015ABD RID: 88765
	// (set) Token: 0x06015ABE RID: 88766
	float? BlackBorderFadeOutTime { get; set; }

	// Token: 0x170020F3 RID: 8435
	// (get) Token: 0x06015ABF RID: 88767
	// (set) Token: 0x06015AC0 RID: 88768
	SetBlendAnim Mp4BlendAnim { get; set; }

	// Token: 0x170020F4 RID: 8436
	// (get) Token: 0x06015AC1 RID: 88769
	// (set) Token: 0x06015AC2 RID: 88770
	bool? SeamlessEndOnTick { get; set; }

	// Token: 0x170020F5 RID: 8437
	// (get) Token: 0x06015AC3 RID: 88771
	// (set) Token: 0x06015AC4 RID: 88772
	EVideoSkipType SkipType { get; set; }

	// Token: 0x170020F6 RID: 8438
	// (get) Token: 0x06015AC5 RID: 88773
	// (set) Token: 0x06015AC6 RID: 88774
	Action SkipCallback { get; set; }
}
