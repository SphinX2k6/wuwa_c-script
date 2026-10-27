using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EBF RID: 7871
[NullableContext(1)]
public interface IHonamiStoryLeaveTipParams
{
	// Token: 0x170012E3 RID: 4835
	// (get) Token: 0x0600F227 RID: 61991
	EHonamiStoryLeaveType LeaveType { get; }

	// Token: 0x170012E4 RID: 4836
	// (get) Token: 0x0600F228 RID: 61992
	Action ConfirmCallback { get; }

	// Token: 0x170012E5 RID: 4837
	// (get) Token: 0x0600F229 RID: 61993
	[Nullable(2)]
	Action CancelCallback { [NullableContext(2)] get; }

	// Token: 0x170012E6 RID: 4838
	// (get) Token: 0x0600F22A RID: 61994
	bool ShowSafeLeaveUpdate { get; }
}
