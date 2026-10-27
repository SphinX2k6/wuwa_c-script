using System;

// Token: 0x02001146 RID: 4422
public class BabelTowerHardLevelChoseViewData : IBabelTowerHardLevelChoseViewData
{
	// Token: 0x17000A29 RID: 2601
	// (get) Token: 0x06007430 RID: 29744 RVA: 0x0017BD41 File Offset: 0x00179F41
	// (set) Token: 0x06007431 RID: 29745 RVA: 0x0017BD49 File Offset: 0x00179F49
	public bool IfReturnToBabelTowerMainView { get; set; }

	// Token: 0x17000A2A RID: 2602
	// (get) Token: 0x06007432 RID: 29746 RVA: 0x0017BD52 File Offset: 0x00179F52
	// (set) Token: 0x06007433 RID: 29747 RVA: 0x0017BD5A File Offset: 0x00179F5A
	public bool IfLeaveInstanceDungeonWhenMainViewClose { get; set; }
}
