using System;

// Token: 0x0200153B RID: 5435
public class LevelUpViewViedData : ILevelUpViewViedData
{
	// Token: 0x17001450 RID: 5200
	// (get) Token: 0x0600D9AC RID: 55724 RVA: 0x0040840C File Offset: 0x0040660C
	// (set) Token: 0x0600D9AD RID: 55725 RVA: 0x00408414 File Offset: 0x00406614
	public bool AddExp { get; set; }

	// Token: 0x17001451 RID: 5201
	// (get) Token: 0x0600D9AE RID: 55726 RVA: 0x0040841D File Offset: 0x0040661D
	// (set) Token: 0x0600D9AF RID: 55727 RVA: 0x00408425 File Offset: 0x00406625
	public int PreLevel { get; set; }

	// Token: 0x17001452 RID: 5202
	// (get) Token: 0x0600D9B0 RID: 55728 RVA: 0x0040842E File Offset: 0x0040662E
	// (set) Token: 0x0600D9B1 RID: 55729 RVA: 0x00408436 File Offset: 0x00406636
	public int PreExp { get; set; }

	// Token: 0x17001453 RID: 5203
	// (get) Token: 0x0600D9B2 RID: 55730 RVA: 0x0040843F File Offset: 0x0040663F
	// (set) Token: 0x0600D9B3 RID: 55731 RVA: 0x00408447 File Offset: 0x00406647
	public int CurLevel { get; set; }

	// Token: 0x17001454 RID: 5204
	// (get) Token: 0x0600D9B4 RID: 55732 RVA: 0x00408450 File Offset: 0x00406650
	// (set) Token: 0x0600D9B5 RID: 55733 RVA: 0x00408458 File Offset: 0x00406658
	public int CurExp { get; set; }
}
