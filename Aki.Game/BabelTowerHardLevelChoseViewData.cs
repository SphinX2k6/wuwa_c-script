using System;

// Token: 0x020005FA RID: 1530
public class BabelTowerHardLevelChoseViewData : IBabelTowerHardLevelChoseViewData
{
	// Token: 0x17000A49 RID: 2633
	// (get) Token: 0x060047C7 RID: 18375 RVA: 0x0018488F File Offset: 0x00182A8F
	// (set) Token: 0x060047C8 RID: 18376 RVA: 0x00184897 File Offset: 0x00182A97
	public bool IfReturnToBabelTowerMainView { get; set; }

	// Token: 0x17000A4A RID: 2634
	// (get) Token: 0x060047C9 RID: 18377 RVA: 0x001848A0 File Offset: 0x00182AA0
	// (set) Token: 0x060047CA RID: 18378 RVA: 0x001848A8 File Offset: 0x00182AA8
	public bool IfLeaveInstanceDungeonWhenMainViewClose { get; set; }
}
