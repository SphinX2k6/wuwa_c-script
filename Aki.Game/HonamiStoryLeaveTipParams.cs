using System;
using System.Runtime.CompilerServices;

// Token: 0x02001382 RID: 4994
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryLeaveTipParams : IHonamiStoryLeaveTipParams
{
	// Token: 0x17001311 RID: 4881
	// (get) Token: 0x0600C64A RID: 50762 RVA: 0x003B0A87 File Offset: 0x003AEC87
	// (set) Token: 0x0600C64B RID: 50763 RVA: 0x003B0A8F File Offset: 0x003AEC8F
	public EHonamiStoryLeaveType LeaveType { get; set; }

	// Token: 0x17001312 RID: 4882
	// (get) Token: 0x0600C64C RID: 50764 RVA: 0x003B0A98 File Offset: 0x003AEC98
	// (set) Token: 0x0600C64D RID: 50765 RVA: 0x003B0AA0 File Offset: 0x003AECA0
	public Action ConfirmCallback { get; set; }

	// Token: 0x17001313 RID: 4883
	// (get) Token: 0x0600C64E RID: 50766 RVA: 0x003B0AA9 File Offset: 0x003AECA9
	// (set) Token: 0x0600C64F RID: 50767 RVA: 0x003B0AB1 File Offset: 0x003AECB1
	[Nullable(2)]
	public Action CancelCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001314 RID: 4884
	// (get) Token: 0x0600C650 RID: 50768 RVA: 0x003B0ABA File Offset: 0x003AECBA
	// (set) Token: 0x0600C651 RID: 50769 RVA: 0x003B0AC2 File Offset: 0x003AECC2
	public bool ShowSafeLeaveUpdate { get; set; }
}
