using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EC0 RID: 7872
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryLeaveTipParams : IHonamiStoryLeaveTipParams
{
	// Token: 0x170012E7 RID: 4839
	// (get) Token: 0x0600F22B RID: 61995 RVA: 0x003A4F87 File Offset: 0x003A3187
	// (set) Token: 0x0600F22C RID: 61996 RVA: 0x003A4F8F File Offset: 0x003A318F
	public EHonamiStoryLeaveType LeaveType { get; set; }

	// Token: 0x170012E8 RID: 4840
	// (get) Token: 0x0600F22D RID: 61997 RVA: 0x003A4F98 File Offset: 0x003A3198
	// (set) Token: 0x0600F22E RID: 61998 RVA: 0x003A4FA0 File Offset: 0x003A31A0
	public Action ConfirmCallback { get; set; }

	// Token: 0x170012E9 RID: 4841
	// (get) Token: 0x0600F22F RID: 61999 RVA: 0x003A4FA9 File Offset: 0x003A31A9
	// (set) Token: 0x0600F230 RID: 62000 RVA: 0x003A4FB1 File Offset: 0x003A31B1
	[Nullable(2)]
	public Action CancelCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170012EA RID: 4842
	// (get) Token: 0x0600F231 RID: 62001 RVA: 0x003A4FBA File Offset: 0x003A31BA
	// (set) Token: 0x0600F232 RID: 62002 RVA: 0x003A4FC2 File Offset: 0x003A31C2
	public bool ShowSafeLeaveUpdate { get; set; }
}
