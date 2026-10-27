using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002CE9 RID: 11497
[NullableContext(2)]
public interface IShowVideoCgConfig
{
	// Token: 0x17002085 RID: 8325
	// (get) Token: 0x06018209 RID: 98825
	// (set) Token: 0x0601820A RID: 98826
	IMovieBackgroundFadeData BackgroundFade { get; set; }

	// Token: 0x17002086 RID: 8326
	// (get) Token: 0x0601820B RID: 98827
	// (set) Token: 0x0601820C RID: 98828
	bool? RemainViewWhenEnd { get; set; }

	// Token: 0x17002087 RID: 8327
	// (get) Token: 0x0601820D RID: 98829
	// (set) Token: 0x0601820E RID: 98830
	bool? InPlot { get; set; }

	// Token: 0x17002088 RID: 8328
	// (get) Token: 0x0601820F RID: 98831
	// (set) Token: 0x06018210 RID: 98832
	IProgramSpecialConfigBase ProgramSpecialConfig { get; set; }

	// Token: 0x17002089 RID: 8329
	// (get) Token: 0x06018211 RID: 98833
	// (set) Token: 0x06018212 RID: 98834
	float? Mp4FadeOutTime { get; set; }

	// Token: 0x1700208A RID: 8330
	// (get) Token: 0x06018213 RID: 98835
	// (set) Token: 0x06018214 RID: 98836
	float? BlackBorderFadeOutTime { get; set; }

	// Token: 0x1700208B RID: 8331
	// (get) Token: 0x06018215 RID: 98837
	// (set) Token: 0x06018216 RID: 98838
	SetBlendAnim Mp4BlendAnim { get; set; }

	// Token: 0x1700208C RID: 8332
	// (get) Token: 0x06018217 RID: 98839
	// (set) Token: 0x06018218 RID: 98840
	bool? SeamlessEndOnTick { get; set; }
}
