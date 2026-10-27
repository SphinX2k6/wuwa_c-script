using System;

// Token: 0x020027AD RID: 10157
public class SkillNodeDataInfo
{
	// Token: 0x17001B2A RID: 6954
	// (get) Token: 0x06014E31 RID: 85553 RVA: 0x0054E111 File Offset: 0x0054C311
	// (set) Token: 0x06014E32 RID: 85554 RVA: 0x0054E119 File Offset: 0x0054C319
	public int SkillNodeId { get; set; }

	// Token: 0x17001B2B RID: 6955
	// (get) Token: 0x06014E33 RID: 85555 RVA: 0x0054E122 File Offset: 0x0054C322
	// (set) Token: 0x06014E34 RID: 85556 RVA: 0x0054E12A File Offset: 0x0054C32A
	public bool IsActive { get; set; }

	// Token: 0x17001B2C RID: 6956
	// (get) Token: 0x06014E35 RID: 85557 RVA: 0x0054E133 File Offset: 0x0054C333
	// (set) Token: 0x06014E36 RID: 85558 RVA: 0x0054E13B File Offset: 0x0054C33B
	public int SkillId { get; set; }

	// Token: 0x06014E37 RID: 85559 RVA: 0x0054E144 File Offset: 0x0054C344
	public SkillNodeDataInfo(int skillNodeId, bool isActive, int skillId)
	{
		this.SkillNodeId = skillNodeId;
		this.IsActive = isActive;
		this.SkillId = skillId;
	}
}
