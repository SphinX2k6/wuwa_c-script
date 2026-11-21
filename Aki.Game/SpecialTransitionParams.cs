using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001FFB RID: 8187
[NullableContext(1)]
[Nullable(0)]
public class SpecialTransitionParams : ISpecialTransitionParams
{
	// Token: 0x17001E73 RID: 7795
	// (get) Token: 0x060144A0 RID: 83104 RVA: 0x005E9AEC File Offset: 0x005E7CEC
	// (set) Token: 0x060144A1 RID: 83105 RVA: 0x005E9AF4 File Offset: 0x005E7CF4
	public ISpecialTransitionViewParams ViewParams { get; set; }

	// Token: 0x17001E74 RID: 7796
	// (get) Token: 0x060144A2 RID: 83106 RVA: 0x005E9AFD File Offset: 0x005E7CFD
	// (set) Token: 0x060144A3 RID: 83107 RVA: 0x005E9B05 File Offset: 0x005E7D05
	public ISpecialTransitionFlowParams FlowParams { get; set; }

	// Token: 0x17001E75 RID: 7797
	// (get) Token: 0x060144A4 RID: 83108 RVA: 0x005E9B0E File Offset: 0x005E7D0E
	// (set) Token: 0x060144A5 RID: 83109 RVA: 0x005E9B16 File Offset: 0x005E7D16
	public ECustomScreenLoading? LoadingType { get; set; }
}
