using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02002A81 RID: 10881
[NullableContext(2)]
[Nullable(0)]
public class SpecialTransitionViewParams : ISpecialTransitionViewParams
{
	// Token: 0x17001E22 RID: 7714
	// (get) Token: 0x06016A8A RID: 92810 RVA: 0x005BD8F7 File Offset: 0x005BBAF7
	// (set) Token: 0x06016A8B RID: 92811 RVA: 0x005BD8FF File Offset: 0x005BBAFF
	public int? SpineId { get; set; }

	// Token: 0x17001E23 RID: 7715
	// (get) Token: 0x06016A8C RID: 92812 RVA: 0x005BD908 File Offset: 0x005BBB08
	// (set) Token: 0x06016A8D RID: 92813 RVA: 0x005BD910 File Offset: 0x005BBB10
	public string BgPath { get; set; }

	// Token: 0x17001E24 RID: 7716
	// (get) Token: 0x06016A8E RID: 92814 RVA: 0x005BD919 File Offset: 0x005BBB19
	// (set) Token: 0x06016A8F RID: 92815 RVA: 0x005BD921 File Offset: 0x005BBB21
	public ICustomShowUi CustomShowUi { get; set; }

	// Token: 0x17001E25 RID: 7717
	// (get) Token: 0x06016A90 RID: 92816 RVA: 0x005BD92A File Offset: 0x005BBB2A
	// (set) Token: 0x06016A91 RID: 92817 RVA: 0x005BD932 File Offset: 0x005BBB32
	public string AkEvent { get; set; }
}
