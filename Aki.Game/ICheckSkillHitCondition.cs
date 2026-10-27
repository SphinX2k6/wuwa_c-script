using System;

// Token: 0x020017DF RID: 6111
public interface ICheckSkillHitCondition : IBaseCheckConditionInfo
{
	// Token: 0x17000F19 RID: 3865
	// (get) Token: 0x0600B29C RID: 45724
	// (set) Token: 0x0600B29D RID: 45725
	long HitSkillId { get; set; }

	// Token: 0x17000F1A RID: 3866
	// (get) Token: 0x0600B29E RID: 45726
	// (set) Token: 0x0600B29F RID: 45727
	long BulletId { get; set; }
}
