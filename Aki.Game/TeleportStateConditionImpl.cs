using System;

// Token: 0x02002A74 RID: 10868
public class TeleportStateConditionImpl : ISkipTeleportStateCondition, ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E12 RID: 7698
	// (get) Token: 0x06016A21 RID: 92705 RVA: 0x005BC294 File Offset: 0x005BA494
	// (set) Token: 0x06016A22 RID: 92706 RVA: 0x005BC29C File Offset: 0x005BA49C
	public ESkipConditionType ConditionType { get; set; }

	// Token: 0x17001E13 RID: 7699
	// (get) Token: 0x06016A23 RID: 92707 RVA: 0x005BC2A5 File Offset: 0x005BA4A5
	// (set) Token: 0x06016A24 RID: 92708 RVA: 0x005BC2AD File Offset: 0x005BA4AD
	public int MarkId { get; set; }

	// Token: 0x17001E14 RID: 7700
	// (get) Token: 0x06016A25 RID: 92709 RVA: 0x005BC2B6 File Offset: 0x005BA4B6
	// (set) Token: 0x06016A26 RID: 92710 RVA: 0x005BC2BE File Offset: 0x005BA4BE
	public ETeleportState CheckTeleportState { get; set; }
}
