using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C9B RID: 7323
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerStageRecordData
{
	// Token: 0x04009E7A RID: 40570
	public int StageId;

	// Token: 0x04009E7B RID: 40571
	public long RemainTimeMs;

	// Token: 0x04009E7C RID: 40572
	public bool IsPassed;

	// Token: 0x04009E7D RID: 40573
	public List<int> RoleIds = new List<int>();

	// Token: 0x04009E7E RID: 40574
	public List<RoleTowerFloorRecordData> FloorRecords = new List<RoleTowerFloorRecordData>();
}
