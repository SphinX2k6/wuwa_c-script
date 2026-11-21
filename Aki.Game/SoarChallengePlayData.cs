using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000789 RID: 1929
[NullableContext(1)]
[Nullable(0)]
public class SoarChallengePlayData
{
	// Token: 0x17000B7F RID: 2943
	// (get) Token: 0x0600587A RID: 22650 RVA: 0x001CD598 File Offset: 0x001CB798
	// (set) Token: 0x0600587B RID: 22651 RVA: 0x001CD5A0 File Offset: 0x001CB7A0
	public int TabIndex { get; set; }

	// Token: 0x17000B80 RID: 2944
	// (get) Token: 0x0600587C RID: 22652 RVA: 0x001CD5A9 File Offset: 0x001CB7A9
	// (set) Token: 0x0600587D RID: 22653 RVA: 0x001CD5B1 File Offset: 0x001CB7B1
	public int PlayId { get; set; }

	// Token: 0x17000B81 RID: 2945
	// (get) Token: 0x0600587E RID: 22654 RVA: 0x001CD5BA File Offset: 0x001CB7BA
	// (set) Token: 0x0600587F RID: 22655 RVA: 0x001CD5C2 File Offset: 0x001CB7C2
	public int JumpId { get; set; }

	// Token: 0x17000B82 RID: 2946
	// (get) Token: 0x06005880 RID: 22656 RVA: 0x001CD5CB File Offset: 0x001CB7CB
	// (set) Token: 0x06005881 RID: 22657 RVA: 0x001CD5D3 File Offset: 0x001CB7D3
	public string NameTextId { get; set; } = "";

	// Token: 0x17000B83 RID: 2947
	// (get) Token: 0x06005882 RID: 22658 RVA: 0x001CD5DC File Offset: 0x001CB7DC
	public List<int> RewardIds { get; } = new List<int>();

	// Token: 0x17000B84 RID: 2948
	// (get) Token: 0x06005883 RID: 22659 RVA: 0x001CD5E4 File Offset: 0x001CB7E4
	// (set) Token: 0x06005884 RID: 22660 RVA: 0x001CD5EC File Offset: 0x001CB7EC
	public bool IsUnlock { get; set; }

	// Token: 0x17000B85 RID: 2949
	// (get) Token: 0x06005885 RID: 22661 RVA: 0x001CD5F5 File Offset: 0x001CB7F5
	// (set) Token: 0x06005886 RID: 22662 RVA: 0x001CD5FD File Offset: 0x001CB7FD
	public bool IsNew { get; set; }

	// Token: 0x17000B86 RID: 2950
	// (get) Token: 0x06005887 RID: 22663 RVA: 0x001CD606 File Offset: 0x001CB806
	// (set) Token: 0x06005888 RID: 22664 RVA: 0x001CD60E File Offset: 0x001CB80E
	public int HighestPoint { get; set; }

	// Token: 0x17000B87 RID: 2951
	// (get) Token: 0x06005889 RID: 22665 RVA: 0x001CD617 File Offset: 0x001CB817
	// (set) Token: 0x0600588A RID: 22666 RVA: 0x001CD61F File Offset: 0x001CB81F
	public Func<List<int>, bool> CheckRedDot { get; set; }

	// Token: 0x17000B88 RID: 2952
	// (get) Token: 0x0600588B RID: 22667 RVA: 0x001CD628 File Offset: 0x001CB828
	// (set) Token: 0x0600588C RID: 22668 RVA: 0x001CD630 File Offset: 0x001CB830
	public Func<List<int>, bool> CheckFinished { get; set; }

	// Token: 0x17000B89 RID: 2953
	// (get) Token: 0x0600588D RID: 22669 RVA: 0x001CD639 File Offset: 0x001CB839
	public bool HasRedDot
	{
		get
		{
			return this.CheckRedDot(this.RewardIds);
		}
	}

	// Token: 0x17000B8A RID: 2954
	// (get) Token: 0x0600588E RID: 22670 RVA: 0x001CD64C File Offset: 0x001CB84C
	public bool IsFinished
	{
		get
		{
			return this.CheckFinished(this.RewardIds);
		}
	}
}
