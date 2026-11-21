using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x02001B16 RID: 6934
[NullableContext(2)]
[Nullable(0)]
public class TCommonQteUiConfig
{
	// Token: 0x170019A6 RID: 6566
	// (get) Token: 0x06011454 RID: 70740 RVA: 0x005142C5 File Offset: 0x005124C5
	// (set) Token: 0x06011455 RID: 70741 RVA: 0x005142CD File Offset: 0x005124CD
	public SCommonQte_ContinuousClick ContinuousClick { get; set; }

	// Token: 0x170019A7 RID: 6567
	// (get) Token: 0x06011456 RID: 70742 RVA: 0x005142D6 File Offset: 0x005124D6
	// (set) Token: 0x06011457 RID: 70743 RVA: 0x005142DE File Offset: 0x005124DE
	public SCommonQte_Drag Drag { get; set; }

	// Token: 0x170019A8 RID: 6568
	// (get) Token: 0x06011458 RID: 70744 RVA: 0x005142E7 File Offset: 0x005124E7
	// (set) Token: 0x06011459 RID: 70745 RVA: 0x005142EF File Offset: 0x005124EF
	public SCommonQte_LongPress LongPress { get; set; }

	// Token: 0x170019A9 RID: 6569
	// (get) Token: 0x0601145A RID: 70746 RVA: 0x005142F8 File Offset: 0x005124F8
	// (set) Token: 0x0601145B RID: 70747 RVA: 0x00514300 File Offset: 0x00512500
	public SCommonQte_SelectOption SelectOption { get; set; }

	// Token: 0x170019AA RID: 6570
	// (get) Token: 0x0601145C RID: 70748 RVA: 0x00514309 File Offset: 0x00512509
	// (set) Token: 0x0601145D RID: 70749 RVA: 0x00514311 File Offset: 0x00512511
	public SCommonQte_SingleClick SingleClick { get; set; }
}
