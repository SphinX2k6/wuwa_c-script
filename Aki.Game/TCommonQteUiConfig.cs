using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x0200262B RID: 9771
[NullableContext(2)]
[Nullable(0)]
public class TCommonQteUiConfig
{
	// Token: 0x1700196E RID: 6510
	// (get) Token: 0x06013F72 RID: 81778 RVA: 0x00505401 File Offset: 0x00503601
	// (set) Token: 0x06013F73 RID: 81779 RVA: 0x00505409 File Offset: 0x00503609
	public SCommonQte_ContinuousClick ContinuousClick { get; set; }

	// Token: 0x1700196F RID: 6511
	// (get) Token: 0x06013F74 RID: 81780 RVA: 0x00505412 File Offset: 0x00503612
	// (set) Token: 0x06013F75 RID: 81781 RVA: 0x0050541A File Offset: 0x0050361A
	public SCommonQte_Drag Drag { get; set; }

	// Token: 0x17001970 RID: 6512
	// (get) Token: 0x06013F76 RID: 81782 RVA: 0x00505423 File Offset: 0x00503623
	// (set) Token: 0x06013F77 RID: 81783 RVA: 0x0050542B File Offset: 0x0050362B
	public SCommonQte_LongPress LongPress { get; set; }

	// Token: 0x17001971 RID: 6513
	// (get) Token: 0x06013F78 RID: 81784 RVA: 0x00505434 File Offset: 0x00503634
	// (set) Token: 0x06013F79 RID: 81785 RVA: 0x0050543C File Offset: 0x0050363C
	public SCommonQte_SelectOption SelectOption { get; set; }

	// Token: 0x17001972 RID: 6514
	// (get) Token: 0x06013F7A RID: 81786 RVA: 0x00505445 File Offset: 0x00503645
	// (set) Token: 0x06013F7B RID: 81787 RVA: 0x0050544D File Offset: 0x0050364D
	public SCommonQte_SingleClick SingleClick { get; set; }
}
