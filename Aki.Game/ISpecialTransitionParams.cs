using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001FFA RID: 8186
[NullableContext(1)]
public interface ISpecialTransitionParams
{
	// Token: 0x17001E70 RID: 7792
	// (get) Token: 0x0601449A RID: 83098
	// (set) Token: 0x0601449B RID: 83099
	ISpecialTransitionViewParams ViewParams { get; set; }

	// Token: 0x17001E71 RID: 7793
	// (get) Token: 0x0601449C RID: 83100
	// (set) Token: 0x0601449D RID: 83101
	ISpecialTransitionFlowParams FlowParams { get; set; }

	// Token: 0x17001E72 RID: 7794
	// (get) Token: 0x0601449E RID: 83102
	// (set) Token: 0x0601449F RID: 83103
	ECustomScreenLoading? LoadingType { get; set; }
}
