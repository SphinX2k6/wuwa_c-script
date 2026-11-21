using System;
using System.Runtime.CompilerServices;

// Token: 0x020015BC RID: 5564
[NullableContext(1)]
[Nullable(0)]
public class ActivityPreheatLogData : PlayerCommonLogData
{
	// Token: 0x170014B8 RID: 5304
	// (get) Token: 0x0600DD5B RID: 56667 RVA: 0x004174DA File Offset: 0x004156DA
	// (set) Token: 0x0600DD5C RID: 56668 RVA: 0x004174E2 File Offset: 0x004156E2
	public override string event_id { get; set; } = "1030";

	// Token: 0x04007D10 RID: 32016
	public int i_activity_id;

	// Token: 0x04007D11 RID: 32017
	public int i_activity_type;

	// Token: 0x04007D12 RID: 32018
	public int i_time_left;

	// Token: 0x04007D13 RID: 32019
	public int i_type;
}
