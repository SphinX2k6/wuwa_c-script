using System;

// Token: 0x02001FEF RID: 8175
public class TeleportStateConditionImpl : ISkipTeleportStateCondition, ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E6A RID: 7786
	// (get) Token: 0x06014442 RID: 83010 RVA: 0x005E841C File Offset: 0x005E661C
	// (set) Token: 0x06014443 RID: 83011 RVA: 0x005E8424 File Offset: 0x005E6624
	public ESkipConditionType ConditionType { get; set; }

	// Token: 0x17001E6B RID: 7787
	// (get) Token: 0x06014444 RID: 83012 RVA: 0x005E842D File Offset: 0x005E662D
	// (set) Token: 0x06014445 RID: 83013 RVA: 0x005E8435 File Offset: 0x005E6635
	public int MarkId { get; set; }

	// Token: 0x17001E6C RID: 7788
	// (get) Token: 0x06014446 RID: 83014 RVA: 0x005E843E File Offset: 0x005E663E
	// (set) Token: 0x06014447 RID: 83015 RVA: 0x005E8446 File Offset: 0x005E6646
	public ETeleportState CheckTeleportState { get; set; }
}
