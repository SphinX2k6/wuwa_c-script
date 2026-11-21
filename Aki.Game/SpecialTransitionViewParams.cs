using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001FFD RID: 8189
[NullableContext(2)]
[Nullable(0)]
public class SpecialTransitionViewParams : ISpecialTransitionViewParams
{
	// Token: 0x17001E7A RID: 7802
	// (get) Token: 0x060144AF RID: 83119 RVA: 0x005E9B27 File Offset: 0x005E7D27
	// (set) Token: 0x060144B0 RID: 83120 RVA: 0x005E9B2F File Offset: 0x005E7D2F
	public int? SpineId { get; set; }

	// Token: 0x17001E7B RID: 7803
	// (get) Token: 0x060144B1 RID: 83121 RVA: 0x005E9B38 File Offset: 0x005E7D38
	// (set) Token: 0x060144B2 RID: 83122 RVA: 0x005E9B40 File Offset: 0x005E7D40
	public string BgPath { get; set; }

	// Token: 0x17001E7C RID: 7804
	// (get) Token: 0x060144B3 RID: 83123 RVA: 0x005E9B49 File Offset: 0x005E7D49
	// (set) Token: 0x060144B4 RID: 83124 RVA: 0x005E9B51 File Offset: 0x005E7D51
	public ICustomShowUi CustomShowUi { get; set; }

	// Token: 0x17001E7D RID: 7805
	// (get) Token: 0x060144B5 RID: 83125 RVA: 0x005E9B5A File Offset: 0x005E7D5A
	// (set) Token: 0x060144B6 RID: 83126 RVA: 0x005E9B62 File Offset: 0x005E7D62
	public string AkEvent { get; set; }
}
