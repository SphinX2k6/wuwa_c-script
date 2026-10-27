using System;

// Token: 0x02002947 RID: 10567
public interface IRequestChangeRoleParams
{
	// Token: 0x17001D4B RID: 7499
	// (get) Token: 0x06015D3D RID: 89405
	// (set) Token: 0x06015D3E RID: 89406
	bool? FilterSameRole { get; set; }

	// Token: 0x17001D4C RID: 7500
	// (get) Token: 0x06015D3F RID: 89407
	// (set) Token: 0x06015D40 RID: 89408
	bool? GoDownWaitSkillEnd { get; set; }

	// Token: 0x17001D4D RID: 7501
	// (get) Token: 0x06015D41 RID: 89409
	// (set) Token: 0x06015D42 RID: 89410
	bool? ForceInheritTransform { get; set; }

	// Token: 0x17001D4E RID: 7502
	// (get) Token: 0x06015D43 RID: 89411
	// (set) Token: 0x06015D44 RID: 89412
	bool? GoBattleInvincible { get; set; }

	// Token: 0x17001D4F RID: 7503
	// (get) Token: 0x06015D45 RID: 89413
	// (set) Token: 0x06015D46 RID: 89414
	bool? CanUseGoBattleSkill { get; set; }
}
