using System;

// Token: 0x02002E09 RID: 11785
public class BulletConditionResult
{
	// Token: 0x06018C96 RID: 101526 RVA: 0x0065A16A File Offset: 0x0065836A
	public void Clear()
	{
		this.HasConstResult = false;
		this.ConstResult = false;
		this.KeepEnable = false;
		this.KeepDisable = false;
	}

	// Token: 0x0400B91A RID: 47386
	public bool HasConstResult;

	// Token: 0x0400B91B RID: 47387
	public bool ConstResult;

	// Token: 0x0400B91C RID: 47388
	public bool KeepEnable;

	// Token: 0x0400B91D RID: 47389
	public bool KeepDisable;
}
