using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002A7E RID: 10878
[NullableContext(1)]
public interface ISpecialTransitionParams
{
	// Token: 0x17001E18 RID: 7704
	// (get) Token: 0x06016A75 RID: 92789
	// (set) Token: 0x06016A76 RID: 92790
	ISpecialTransitionViewParams ViewParams { get; set; }

	// Token: 0x17001E19 RID: 7705
	// (get) Token: 0x06016A77 RID: 92791
	// (set) Token: 0x06016A78 RID: 92792
	ISpecialTransitionFlowParams FlowParams { get; set; }

	// Token: 0x17001E1A RID: 7706
	// (get) Token: 0x06016A79 RID: 92793
	// (set) Token: 0x06016A7A RID: 92794
	ECustomScreenLoading? LoadingType { get; set; }
}
