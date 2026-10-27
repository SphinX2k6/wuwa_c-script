using System;

// Token: 0x02002321 RID: 8993
public class BattlePassUpLevelViewData : IBattlePassUpLevelViewData
{
	// Token: 0x170016B8 RID: 5816
	// (get) Token: 0x06011C9B RID: 72859 RVA: 0x00460ED0 File Offset: 0x0045F0D0
	// (set) Token: 0x06011C9C RID: 72860 RVA: 0x00460ED8 File Offset: 0x0045F0D8
	public int IncreasedLevel { get; set; }

	// Token: 0x170016B9 RID: 5817
	// (get) Token: 0x06011C9D RID: 72861 RVA: 0x00460EE1 File Offset: 0x0045F0E1
	// (set) Token: 0x06011C9E RID: 72862 RVA: 0x00460EE9 File Offset: 0x0045F0E9
	public bool FirstUnlockPass { get; set; }
}
