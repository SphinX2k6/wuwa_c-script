using System;

// Token: 0x0200295A RID: 10586
public interface IChangeRoleParams
{
	// Token: 0x17001D70 RID: 7536
	// (get) Token: 0x06015DEE RID: 89582
	// (set) Token: 0x06015DEF RID: 89583
	bool? UseGoBattleSkill { get; set; }

	// Token: 0x17001D71 RID: 7537
	// (get) Token: 0x06015DF0 RID: 89584
	// (set) Token: 0x06015DF1 RID: 89585
	double? CoolDown { get; set; }

	// Token: 0x17001D72 RID: 7538
	// (get) Token: 0x06015DF2 RID: 89586
	// (set) Token: 0x06015DF3 RID: 89587
	bool? GoDownWaitSkillEnd { get; set; }

	// Token: 0x17001D73 RID: 7539
	// (get) Token: 0x06015DF4 RID: 89588
	// (set) Token: 0x06015DF5 RID: 89589
	bool? AllowRefreshTransform { get; set; }

	// Token: 0x17001D74 RID: 7540
	// (get) Token: 0x06015DF6 RID: 89590
	// (set) Token: 0x06015DF7 RID: 89591
	bool? ForceInheritTransform { get; set; }

	// Token: 0x17001D75 RID: 7541
	// (get) Token: 0x06015DF8 RID: 89592
	// (set) Token: 0x06015DF9 RID: 89593
	bool? ForceChangeRole { get; set; }
}
