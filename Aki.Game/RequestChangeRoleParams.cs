using System;

// Token: 0x02002948 RID: 10568
public class RequestChangeRoleParams : IRequestChangeRoleParams
{
	// Token: 0x17001D50 RID: 7504
	// (get) Token: 0x06015D47 RID: 89415 RVA: 0x00580B1C File Offset: 0x0057ED1C
	// (set) Token: 0x06015D48 RID: 89416 RVA: 0x00580B24 File Offset: 0x0057ED24
	public bool? FilterSameRole { get; set; }

	// Token: 0x17001D51 RID: 7505
	// (get) Token: 0x06015D49 RID: 89417 RVA: 0x00580B2D File Offset: 0x0057ED2D
	// (set) Token: 0x06015D4A RID: 89418 RVA: 0x00580B35 File Offset: 0x0057ED35
	public bool? GoDownWaitSkillEnd { get; set; }

	// Token: 0x17001D52 RID: 7506
	// (get) Token: 0x06015D4B RID: 89419 RVA: 0x00580B3E File Offset: 0x0057ED3E
	// (set) Token: 0x06015D4C RID: 89420 RVA: 0x00580B46 File Offset: 0x0057ED46
	public bool? ForceInheritTransform { get; set; }

	// Token: 0x17001D53 RID: 7507
	// (get) Token: 0x06015D4D RID: 89421 RVA: 0x00580B4F File Offset: 0x0057ED4F
	// (set) Token: 0x06015D4E RID: 89422 RVA: 0x00580B57 File Offset: 0x0057ED57
	public bool? GoBattleInvincible { get; set; }

	// Token: 0x17001D54 RID: 7508
	// (get) Token: 0x06015D4F RID: 89423 RVA: 0x00580B60 File Offset: 0x0057ED60
	// (set) Token: 0x06015D50 RID: 89424 RVA: 0x00580B68 File Offset: 0x0057ED68
	public bool? CanUseGoBattleSkill { get; set; }
}
