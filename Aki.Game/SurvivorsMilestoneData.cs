using System;

// Token: 0x02002ABE RID: 10942
public class SurvivorsMilestoneData
{
	// Token: 0x06016C8B RID: 93323 RVA: 0x005C9404 File Offset: 0x005C7604
	public SurvivorsMilestoneData(int id, int sortId, int goal, int dropId, bool isGot = false)
	{
		this.Id = id;
		this.SortId = sortId;
		this.Goal = goal;
		this.DropId = dropId;
		this.IsGot = isGot;
	}

	// Token: 0x06016C8C RID: 93324 RVA: 0x005C9431 File Offset: 0x005C7631
	public bool IsReceivable(int currentPoint)
	{
		return this.IsAchieved(currentPoint) && !this.IsGot;
	}

	// Token: 0x06016C8D RID: 93325 RVA: 0x005C9447 File Offset: 0x005C7647
	public bool IsAchieved(int currentPoint)
	{
		return this.Goal <= currentPoint;
	}

	// Token: 0x0400A936 RID: 43318
	public int Id;

	// Token: 0x0400A937 RID: 43319
	public int SortId;

	// Token: 0x0400A938 RID: 43320
	public int Goal;

	// Token: 0x0400A939 RID: 43321
	public int DropId;

	// Token: 0x0400A93A RID: 43322
	public bool IsGot;
}
