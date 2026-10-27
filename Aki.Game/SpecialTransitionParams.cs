using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002A7F RID: 10879
[NullableContext(1)]
[Nullable(0)]
public class SpecialTransitionParams : ISpecialTransitionParams
{
	// Token: 0x17001E1B RID: 7707
	// (get) Token: 0x06016A7B RID: 92795 RVA: 0x005BD8BC File Offset: 0x005BBABC
	// (set) Token: 0x06016A7C RID: 92796 RVA: 0x005BD8C4 File Offset: 0x005BBAC4
	public ISpecialTransitionViewParams ViewParams { get; set; }

	// Token: 0x17001E1C RID: 7708
	// (get) Token: 0x06016A7D RID: 92797 RVA: 0x005BD8CD File Offset: 0x005BBACD
	// (set) Token: 0x06016A7E RID: 92798 RVA: 0x005BD8D5 File Offset: 0x005BBAD5
	public ISpecialTransitionFlowParams FlowParams { get; set; }

	// Token: 0x17001E1D RID: 7709
	// (get) Token: 0x06016A7F RID: 92799 RVA: 0x005BD8DE File Offset: 0x005BBADE
	// (set) Token: 0x06016A80 RID: 92800 RVA: 0x005BD8E6 File Offset: 0x005BBAE6
	public ECustomScreenLoading? LoadingType { get; set; }
}
