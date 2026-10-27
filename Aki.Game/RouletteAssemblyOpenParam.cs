using System;

// Token: 0x0200290D RID: 10509
public class RouletteAssemblyOpenParam : IRouletteAssemblyOpenParam
{
	// Token: 0x17001D15 RID: 7445
	// (get) Token: 0x06015AC6 RID: 88774 RVA: 0x0057851D File Offset: 0x0057671D
	// (set) Token: 0x06015AC7 RID: 88775 RVA: 0x00578525 File Offset: 0x00576725
	public ERouletteType? RouletteType { get; set; }

	// Token: 0x17001D16 RID: 7446
	// (get) Token: 0x06015AC8 RID: 88776 RVA: 0x0057852E File Offset: 0x0057672E
	// (set) Token: 0x06015AC9 RID: 88777 RVA: 0x00578536 File Offset: 0x00576736
	public int? SelectGridId { get; set; }

	// Token: 0x17001D17 RID: 7447
	// (get) Token: 0x06015ACA RID: 88778 RVA: 0x0057853F File Offset: 0x0057673F
	// (set) Token: 0x06015ACB RID: 88779 RVA: 0x00578547 File Offset: 0x00576747
	public int? SelectGridIndex { get; set; }

	// Token: 0x17001D18 RID: 7448
	// (get) Token: 0x06015ACC RID: 88780 RVA: 0x00578550 File Offset: 0x00576750
	// (set) Token: 0x06015ACD RID: 88781 RVA: 0x00578558 File Offset: 0x00576758
	public ERouletteExploreId? EndSwitchSkillId { get; set; }

	// Token: 0x17001D19 RID: 7449
	// (get) Token: 0x06015ACE RID: 88782 RVA: 0x00578561 File Offset: 0x00576761
	// (set) Token: 0x06015ACF RID: 88783 RVA: 0x00578569 File Offset: 0x00576769
	public bool? LocateEquippableSpecialItem { get; set; }
}
