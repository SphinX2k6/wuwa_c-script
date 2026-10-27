using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002A84 RID: 10884
[NullableContext(2)]
public interface IFadeEffect
{
	// Token: 0x17001E2C RID: 7724
	// (get) Token: 0x06016AA0 RID: 92832
	// (set) Token: 0x06016AA1 RID: 92833
	EFadeInScreenShowType? FadeColor { get; set; }

	// Token: 0x17001E2D RID: 7725
	// (get) Token: 0x06016AA2 RID: 92834
	// (set) Token: 0x06016AA3 RID: 92835
	float? FadeInTime { get; set; }

	// Token: 0x17001E2E RID: 7726
	// (get) Token: 0x06016AA4 RID: 92836
	// (set) Token: 0x06016AA5 RID: 92837
	float? FadeOutTime { get; set; }

	// Token: 0x17001E2F RID: 7727
	// (get) Token: 0x06016AA6 RID: 92838
	// (set) Token: 0x06016AA7 RID: 92839
	string ScreenEffect { get; set; }
}
