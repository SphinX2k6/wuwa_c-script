using System;

// Token: 0x02000C99 RID: 3225
public class CheckSkillHitCondition : IBaseCheckConditionInfo, ICheckSkillHitCondition
{
	// Token: 0x17000F3E RID: 3902
	// (get) Token: 0x06008689 RID: 34441 RVA: 0x0028F8E7 File Offset: 0x0028DAE7
	// (set) Token: 0x0600868A RID: 34442 RVA: 0x0028F8EF File Offset: 0x0028DAEF
	public long HitSkillId { get; set; }

	// Token: 0x17000F3F RID: 3903
	// (get) Token: 0x0600868B RID: 34443 RVA: 0x0028F8F8 File Offset: 0x0028DAF8
	// (set) Token: 0x0600868C RID: 34444 RVA: 0x0028F900 File Offset: 0x0028DB00
	public long BulletId { get; set; }
}
