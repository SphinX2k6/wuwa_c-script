using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BDE RID: 7134
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsLegMatchResultData : IRacingBetsLegMatchResultData
{
	// Token: 0x17001AD6 RID: 6870
	// (get) Token: 0x06011BF5 RID: 72693 RVA: 0x0053A6E6 File Offset: 0x005388E6
	// (set) Token: 0x06011BF6 RID: 72694 RVA: 0x0053A6EE File Offset: 0x005388EE
	public int DangoId { get; set; }

	// Token: 0x17001AD7 RID: 6871
	// (get) Token: 0x06011BF7 RID: 72695 RVA: 0x0053A6F7 File Offset: 0x005388F7
	// (set) Token: 0x06011BF8 RID: 72696 RVA: 0x0053A6FF File Offset: 0x005388FF
	public int Rank { get; set; }

	// Token: 0x17001AD8 RID: 6872
	// (get) Token: 0x06011BF9 RID: 72697 RVA: 0x0053A708 File Offset: 0x00538908
	// (set) Token: 0x06011BFA RID: 72698 RVA: 0x0053A710 File Offset: 0x00538910
	public bool HasAdvanced { get; set; }

	// Token: 0x17001AD9 RID: 6873
	// (get) Token: 0x06011BFB RID: 72699 RVA: 0x0053A719 File Offset: 0x00538919
	// (set) Token: 0x06011BFC RID: 72700 RVA: 0x0053A721 File Offset: 0x00538921
	public ERacingBetsLegMatchType LegMatchType { get; set; }

	// Token: 0x17001ADA RID: 6874
	// (get) Token: 0x06011BFD RID: 72701 RVA: 0x0053A72A File Offset: 0x0053892A
	// (set) Token: 0x06011BFE RID: 72702 RVA: 0x0053A732 File Offset: 0x00538932
	public bool IsChampion { get; set; }

	// Token: 0x17001ADB RID: 6875
	// (get) Token: 0x06011BFF RID: 72703 RVA: 0x0053A73B File Offset: 0x0053893B
	// (set) Token: 0x06011C00 RID: 72704 RVA: 0x0053A743 File Offset: 0x00538943
	public ERacingBetsLegMatchResultType ResultShowType { get; set; }

	// Token: 0x17001ADC RID: 6876
	// (get) Token: 0x06011C01 RID: 72705 RVA: 0x0053A74C File Offset: 0x0053894C
	// (set) Token: 0x06011C02 RID: 72706 RVA: 0x0053A754 File Offset: 0x00538954
	public string AdvancedNextMatchName { get; set; }

	// Token: 0x17001ADD RID: 6877
	// (get) Token: 0x06011C03 RID: 72707 RVA: 0x0053A75D File Offset: 0x0053895D
	// (set) Token: 0x06011C04 RID: 72708 RVA: 0x0053A765 File Offset: 0x00538965
	public string LoserNextMatchName { get; set; }
}
