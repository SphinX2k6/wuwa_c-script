using System;

// Token: 0x020018C5 RID: 6341
public class ItemInteractionPanelItemInfo : IItemInteractionPanelItemInfo
{
	// Token: 0x17000F67 RID: 3943
	// (get) Token: 0x0600BA07 RID: 47623 RVA: 0x002A2349 File Offset: 0x002A0549
	// (set) Token: 0x0600BA08 RID: 47624 RVA: 0x002A2351 File Offset: 0x002A0551
	public int ItemConfigId { get; set; }

	// Token: 0x17000F68 RID: 3944
	// (get) Token: 0x0600BA09 RID: 47625 RVA: 0x002A235A File Offset: 0x002A055A
	// (set) Token: 0x0600BA0A RID: 47626 RVA: 0x002A2362 File Offset: 0x002A0562
	public int CurrentCount { get; set; }

	// Token: 0x17000F69 RID: 3945
	// (get) Token: 0x0600BA0B RID: 47627 RVA: 0x002A236B File Offset: 0x002A056B
	// (set) Token: 0x0600BA0C RID: 47628 RVA: 0x002A2373 File Offset: 0x002A0573
	public int? NeedCount { get; set; }
}
