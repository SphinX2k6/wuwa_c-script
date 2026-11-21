using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C96 RID: 7318
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerStageData
{
	// Token: 0x04009E60 RID: 40544
	public int Id;

	// Token: 0x04009E61 RID: 40545
	public bool IsPassed;

	// Token: 0x04009E62 RID: 40546
	public bool IsCurrent;

	// Token: 0x04009E63 RID: 40547
	public long TimeDeltaSum;

	// Token: 0x04009E64 RID: 40548
	public long PassRemainTime;

	// Token: 0x04009E65 RID: 40549
	public List<int> PassTeamRoleIds = new List<int>();

	// Token: 0x04009E66 RID: 40550
	public List<RoleTowerRoleSnapshotData> RoleSnapshots = new List<RoleTowerRoleSnapshotData>();
}
