using System;

// Token: 0x02001ED6 RID: 7894
public class ChangeRoleParams : IChangeRoleParams
{
	// Token: 0x17001DCF RID: 7631
	// (get) Token: 0x060137FE RID: 79870 RVA: 0x005AF038 File Offset: 0x005AD238
	// (set) Token: 0x060137FF RID: 79871 RVA: 0x005AF040 File Offset: 0x005AD240
	public bool? UseGoBattleSkill { get; set; }

	// Token: 0x17001DD0 RID: 7632
	// (get) Token: 0x06013800 RID: 79872 RVA: 0x005AF049 File Offset: 0x005AD249
	// (set) Token: 0x06013801 RID: 79873 RVA: 0x005AF051 File Offset: 0x005AD251
	public double? CoolDown { get; set; }

	// Token: 0x17001DD1 RID: 7633
	// (get) Token: 0x06013802 RID: 79874 RVA: 0x005AF05A File Offset: 0x005AD25A
	// (set) Token: 0x06013803 RID: 79875 RVA: 0x005AF062 File Offset: 0x005AD262
	public bool? GoDownWaitSkillEnd { get; set; }

	// Token: 0x17001DD2 RID: 7634
	// (get) Token: 0x06013804 RID: 79876 RVA: 0x005AF06B File Offset: 0x005AD26B
	// (set) Token: 0x06013805 RID: 79877 RVA: 0x005AF073 File Offset: 0x005AD273
	public bool? AllowRefreshTransform { get; set; }

	// Token: 0x17001DD3 RID: 7635
	// (get) Token: 0x06013806 RID: 79878 RVA: 0x005AF07C File Offset: 0x005AD27C
	// (set) Token: 0x06013807 RID: 79879 RVA: 0x005AF084 File Offset: 0x005AD284
	public bool? ForceInheritTransform { get; set; }

	// Token: 0x17001DD4 RID: 7636
	// (get) Token: 0x06013808 RID: 79880 RVA: 0x005AF08D File Offset: 0x005AD28D
	// (set) Token: 0x06013809 RID: 79881 RVA: 0x005AF095 File Offset: 0x005AD295
	public bool? ForceChangeRole { get; set; }
}
