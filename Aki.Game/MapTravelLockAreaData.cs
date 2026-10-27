using System;

// Token: 0x020012D7 RID: 4823
public class MapTravelLockAreaData
{
	// Token: 0x060084FD RID: 34045 RVA: 0x001C488C File Offset: 0x001C2A8C
	public MapTravelLockAreaData(int areaId)
	{
		this.AreaId = areaId;
	}

	// Token: 0x17000B6F RID: 2927
	// (get) Token: 0x060084FE RID: 34046 RVA: 0x001C489B File Offset: 0x001C2A9B
	public int AreaId { get; }

	// Token: 0x17000B70 RID: 2928
	// (get) Token: 0x060084FF RID: 34047 RVA: 0x001C48A3 File Offset: 0x001C2AA3
	// (set) Token: 0x06008500 RID: 34048 RVA: 0x001C48AB File Offset: 0x001C2AAB
	public int ConditionGroupId { get; set; }

	// Token: 0x17000B71 RID: 2929
	// (get) Token: 0x06008501 RID: 34049 RVA: 0x001C48B4 File Offset: 0x001C2AB4
	// (set) Token: 0x06008502 RID: 34050 RVA: 0x001C48BC File Offset: 0x001C2ABC
	public int JumpId { get; set; }
}
