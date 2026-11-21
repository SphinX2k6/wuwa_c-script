using System;

// Token: 0x02001D28 RID: 7464
public class SkillNodeDataInfo
{
	// Token: 0x17001B81 RID: 7041
	// (get) Token: 0x06012830 RID: 75824 RVA: 0x00578E39 File Offset: 0x00577039
	// (set) Token: 0x06012831 RID: 75825 RVA: 0x00578E41 File Offset: 0x00577041
	public int SkillNodeId { get; set; }

	// Token: 0x17001B82 RID: 7042
	// (get) Token: 0x06012832 RID: 75826 RVA: 0x00578E4A File Offset: 0x0057704A
	// (set) Token: 0x06012833 RID: 75827 RVA: 0x00578E52 File Offset: 0x00577052
	public bool IsActive { get; set; }

	// Token: 0x17001B83 RID: 7043
	// (get) Token: 0x06012834 RID: 75828 RVA: 0x00578E5B File Offset: 0x0057705B
	// (set) Token: 0x06012835 RID: 75829 RVA: 0x00578E63 File Offset: 0x00577063
	public int SkillId { get; set; }

	// Token: 0x06012836 RID: 75830 RVA: 0x00578E6C File Offset: 0x0057706C
	public SkillNodeDataInfo(int skillNodeId, bool isActive, int skillId)
	{
		this.SkillNodeId = skillNodeId;
		this.IsActive = isActive;
		this.SkillId = skillId;
	}
}
