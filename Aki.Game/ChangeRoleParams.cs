using System;

// Token: 0x0200295B RID: 10587
public class ChangeRoleParams : IChangeRoleParams
{
	// Token: 0x17001D76 RID: 7542
	// (get) Token: 0x06015DFA RID: 89594 RVA: 0x00584038 File Offset: 0x00582238
	// (set) Token: 0x06015DFB RID: 89595 RVA: 0x00584040 File Offset: 0x00582240
	public bool? UseGoBattleSkill { get; set; }

	// Token: 0x17001D77 RID: 7543
	// (get) Token: 0x06015DFC RID: 89596 RVA: 0x00584049 File Offset: 0x00582249
	// (set) Token: 0x06015DFD RID: 89597 RVA: 0x00584051 File Offset: 0x00582251
	public double? CoolDown { get; set; }

	// Token: 0x17001D78 RID: 7544
	// (get) Token: 0x06015DFE RID: 89598 RVA: 0x0058405A File Offset: 0x0058225A
	// (set) Token: 0x06015DFF RID: 89599 RVA: 0x00584062 File Offset: 0x00582262
	public bool? GoDownWaitSkillEnd { get; set; }

	// Token: 0x17001D79 RID: 7545
	// (get) Token: 0x06015E00 RID: 89600 RVA: 0x0058406B File Offset: 0x0058226B
	// (set) Token: 0x06015E01 RID: 89601 RVA: 0x00584073 File Offset: 0x00582273
	public bool? AllowRefreshTransform { get; set; }

	// Token: 0x17001D7A RID: 7546
	// (get) Token: 0x06015E02 RID: 89602 RVA: 0x0058407C File Offset: 0x0058227C
	// (set) Token: 0x06015E03 RID: 89603 RVA: 0x00584084 File Offset: 0x00582284
	public bool? ForceInheritTransform { get; set; }

	// Token: 0x17001D7B RID: 7547
	// (get) Token: 0x06015E04 RID: 89604 RVA: 0x0058408D File Offset: 0x0058228D
	// (set) Token: 0x06015E05 RID: 89605 RVA: 0x00584095 File Offset: 0x00582295
	public bool? ForceChangeRole { get; set; }
}
