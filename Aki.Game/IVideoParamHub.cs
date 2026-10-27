using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;

// Token: 0x02002CEB RID: 11499
[NullableContext(2)]
public interface IVideoParamHub
{
	// Token: 0x17002095 RID: 8341
	// (get) Token: 0x0601822A RID: 98858
	// (set) Token: 0x0601822B RID: 98859
	VideoData VideoDataConf { get; set; }

	// Token: 0x17002096 RID: 8342
	// (get) Token: 0x0601822C RID: 98860
	// (set) Token: 0x0601822D RID: 98861
	Action VideoCloseCb { get; set; }

	// Token: 0x17002097 RID: 8343
	// (get) Token: 0x0601822E RID: 98862
	// (set) Token: 0x0601822F RID: 98863
	IMovieBackgroundFadeData BackgroundColor { get; set; }

	// Token: 0x17002098 RID: 8344
	// (get) Token: 0x06018230 RID: 98864
	// (set) Token: 0x06018231 RID: 98865
	bool? RemainViewWhenEnd { get; set; }

	// Token: 0x17002099 RID: 8345
	// (get) Token: 0x06018232 RID: 98866
	// (set) Token: 0x06018233 RID: 98867
	IProgramSpecialConfigBase ProgramSpecialConfig { get; set; }

	// Token: 0x1700209A RID: 8346
	// (get) Token: 0x06018234 RID: 98868
	// (set) Token: 0x06018235 RID: 98869
	float? Mp4FadeOutTime { get; set; }

	// Token: 0x1700209B RID: 8347
	// (get) Token: 0x06018236 RID: 98870
	// (set) Token: 0x06018237 RID: 98871
	float? BlackBorderFadeOutTime { get; set; }

	// Token: 0x1700209C RID: 8348
	// (get) Token: 0x06018238 RID: 98872
	// (set) Token: 0x06018239 RID: 98873
	SetBlendAnim Mp4BlendAnim { get; set; }

	// Token: 0x1700209D RID: 8349
	// (get) Token: 0x0601823A RID: 98874
	// (set) Token: 0x0601823B RID: 98875
	bool? SeamlessEndOnTick { get; set; }
}
