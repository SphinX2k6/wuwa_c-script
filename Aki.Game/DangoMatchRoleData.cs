using System;

// Token: 0x020026FE RID: 9982
public class DangoMatchRoleData : IDangoMatchRoleData
{
	// Token: 0x17001AD7 RID: 6871
	// (get) Token: 0x0601478A RID: 83850 RVA: 0x0052BBF0 File Offset: 0x00529DF0
	// (set) Token: 0x0601478B RID: 83851 RVA: 0x0052BBF8 File Offset: 0x00529DF8
	public int GroupMatchId { get; set; }

	// Token: 0x17001AD8 RID: 6872
	// (get) Token: 0x0601478C RID: 83852 RVA: 0x0052BC01 File Offset: 0x00529E01
	// (set) Token: 0x0601478D RID: 83853 RVA: 0x0052BC09 File Offset: 0x00529E09
	public int DangoId { get; set; }

	// Token: 0x17001AD9 RID: 6873
	// (get) Token: 0x0601478E RID: 83854 RVA: 0x0052BC12 File Offset: 0x00529E12
	// (set) Token: 0x0601478F RID: 83855 RVA: 0x0052BC1A File Offset: 0x00529E1A
	public bool IsMatchFinished { get; set; }

	// Token: 0x17001ADA RID: 6874
	// (get) Token: 0x06014790 RID: 83856 RVA: 0x0052BC23 File Offset: 0x00529E23
	// (set) Token: 0x06014791 RID: 83857 RVA: 0x0052BC2B File Offset: 0x00529E2B
	public bool IsPromote { get; set; }

	// Token: 0x17001ADB RID: 6875
	// (get) Token: 0x06014792 RID: 83858 RVA: 0x0052BC34 File Offset: 0x00529E34
	// (set) Token: 0x06014793 RID: 83859 RVA: 0x0052BC3C File Offset: 0x00529E3C
	public bool IsBasicGroupMatch { get; set; }
}
