using System;

// Token: 0x0200203A RID: 8250
public class SurvivorsMilestoneData
{
	// Token: 0x060146BC RID: 83644 RVA: 0x005F5F58 File Offset: 0x005F4158
	public SurvivorsMilestoneData(int id, int sortId, int goal, int dropId, bool isGot = false)
	{
		this.Id = id;
		this.SortId = sortId;
		this.Goal = goal;
		this.DropId = dropId;
		this.IsGot = isGot;
	}

	// Token: 0x060146BD RID: 83645 RVA: 0x005F5F85 File Offset: 0x005F4185
	public bool IsReceivable(int currentPoint)
	{
		return this.IsAchieved(currentPoint) && !this.IsGot;
	}

	// Token: 0x060146BE RID: 83646 RVA: 0x005F5F9B File Offset: 0x005F419B
	public bool IsAchieved(int currentPoint)
	{
		return this.Goal <= currentPoint;
	}

	// Token: 0x0400AD3C RID: 44348
	public int Id;

	// Token: 0x0400AD3D RID: 44349
	public int SortId;

	// Token: 0x0400AD3E RID: 44350
	public int Goal;

	// Token: 0x0400AD3F RID: 44351
	public int DropId;

	// Token: 0x0400AD40 RID: 44352
	public bool IsGot;
}
