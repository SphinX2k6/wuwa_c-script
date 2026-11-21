using System;

// Token: 0x020006FE RID: 1790
public class DangoMonopolyRoundRewardItemData : IDangoMonopolyRoundRewardItemData
{
	// Token: 0x17000AE7 RID: 2791
	// (get) Token: 0x060052B1 RID: 21169 RVA: 0x001B7B02 File Offset: 0x001B5D02
	// (set) Token: 0x060052B2 RID: 21170 RVA: 0x001B7B0A File Offset: 0x001B5D0A
	public bool IsReceived { get; set; }

	// Token: 0x17000AE8 RID: 2792
	// (get) Token: 0x060052B3 RID: 21171 RVA: 0x001B7B13 File Offset: 0x001B5D13
	// (set) Token: 0x060052B4 RID: 21172 RVA: 0x001B7B1B File Offset: 0x001B5D1B
	public bool IsCanReceived { get; set; }

	// Token: 0x17000AE9 RID: 2793
	// (get) Token: 0x060052B5 RID: 21173 RVA: 0x001B7B24 File Offset: 0x001B5D24
	// (set) Token: 0x060052B6 RID: 21174 RVA: 0x001B7B2C File Offset: 0x001B5D2C
	public int ItemId { get; set; }

	// Token: 0x17000AEA RID: 2794
	// (get) Token: 0x060052B7 RID: 21175 RVA: 0x001B7B35 File Offset: 0x001B5D35
	// (set) Token: 0x060052B8 RID: 21176 RVA: 0x001B7B3D File Offset: 0x001B5D3D
	public int Count { get; set; }

	// Token: 0x17000AEB RID: 2795
	// (get) Token: 0x060052B9 RID: 21177 RVA: 0x001B7B46 File Offset: 0x001B5D46
	// (set) Token: 0x060052BA RID: 21178 RVA: 0x001B7B4E File Offset: 0x001B5D4E
	public int BoardId { get; set; }

	// Token: 0x17000AEC RID: 2796
	// (get) Token: 0x060052BB RID: 21179 RVA: 0x001B7B57 File Offset: 0x001B5D57
	// (set) Token: 0x060052BC RID: 21180 RVA: 0x001B7B5F File Offset: 0x001B5D5F
	public bool IsCurrent { get; set; }

	// Token: 0x17000AED RID: 2797
	// (get) Token: 0x060052BD RID: 21181 RVA: 0x001B7B68 File Offset: 0x001B5D68
	// (set) Token: 0x060052BE RID: 21182 RVA: 0x001B7B70 File Offset: 0x001B5D70
	public int Position { get; set; }
}
