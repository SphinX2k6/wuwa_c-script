using System;

// Token: 0x020017E0 RID: 6112
public class CheckSkillHitCondition : IBaseCheckConditionInfo, ICheckSkillHitCondition
{
	// Token: 0x17000F1B RID: 3867
	// (get) Token: 0x0600B2A0 RID: 45728 RVA: 0x0028533B File Offset: 0x0028353B
	// (set) Token: 0x0600B2A1 RID: 45729 RVA: 0x00285343 File Offset: 0x00283543
	public long HitSkillId { get; set; }

	// Token: 0x17000F1C RID: 3868
	// (get) Token: 0x0600B2A2 RID: 45730 RVA: 0x0028534C File Offset: 0x0028354C
	// (set) Token: 0x0600B2A3 RID: 45731 RVA: 0x00285354 File Offset: 0x00283554
	public long BulletId { get; set; }
}
