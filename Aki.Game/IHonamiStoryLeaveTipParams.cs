using System;
using System.Runtime.CompilerServices;

// Token: 0x02001381 RID: 4993
[NullableContext(1)]
public interface IHonamiStoryLeaveTipParams
{
	// Token: 0x1700130D RID: 4877
	// (get) Token: 0x0600C646 RID: 50758
	EHonamiStoryLeaveType LeaveType { get; }

	// Token: 0x1700130E RID: 4878
	// (get) Token: 0x0600C647 RID: 50759
	Action ConfirmCallback { get; }

	// Token: 0x1700130F RID: 4879
	// (get) Token: 0x0600C648 RID: 50760
	[Nullable(2)]
	Action CancelCallback { [NullableContext(2)] get; }

	// Token: 0x17001310 RID: 4880
	// (get) Token: 0x0600C649 RID: 50761
	bool ShowSafeLeaveUpdate { get; }
}
