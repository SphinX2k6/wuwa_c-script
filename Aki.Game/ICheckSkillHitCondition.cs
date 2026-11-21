using System;

// Token: 0x02000C98 RID: 3224
public interface ICheckSkillHitCondition : IBaseCheckConditionInfo
{
	// Token: 0x17000F3C RID: 3900
	// (get) Token: 0x06008685 RID: 34437
	// (set) Token: 0x06008686 RID: 34438
	long HitSkillId { get; set; }

	// Token: 0x17000F3D RID: 3901
	// (get) Token: 0x06008687 RID: 34439
	// (set) Token: 0x06008688 RID: 34440
	long BulletId { get; set; }
}
