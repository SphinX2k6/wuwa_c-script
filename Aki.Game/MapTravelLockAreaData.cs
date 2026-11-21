using System;

// Token: 0x0200078B RID: 1931
public class MapTravelLockAreaData
{
	// Token: 0x06005898 RID: 22680 RVA: 0x001CD6E8 File Offset: 0x001CB8E8
	public MapTravelLockAreaData(int areaId)
	{
		this.AreaId = areaId;
	}

	// Token: 0x17000B8F RID: 2959
	// (get) Token: 0x06005899 RID: 22681 RVA: 0x001CD6F7 File Offset: 0x001CB8F7
	public int AreaId { get; }

	// Token: 0x17000B90 RID: 2960
	// (get) Token: 0x0600589A RID: 22682 RVA: 0x001CD6FF File Offset: 0x001CB8FF
	// (set) Token: 0x0600589B RID: 22683 RVA: 0x001CD707 File Offset: 0x001CB907
	public int ConditionGroupId { get; set; }

	// Token: 0x17000B91 RID: 2961
	// (get) Token: 0x0600589C RID: 22684 RVA: 0x001CD710 File Offset: 0x001CB910
	// (set) Token: 0x0600589D RID: 22685 RVA: 0x001CD718 File Offset: 0x001CB918
	public int JumpId { get; set; }
}
