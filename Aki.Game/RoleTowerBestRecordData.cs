using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C9A RID: 7322
public class RoleTowerBestRecordData
{
	// Token: 0x04009E76 RID: 40566
	public int LevelId;

	// Token: 0x04009E77 RID: 40567
	public int MainRoleId;

	// Token: 0x04009E78 RID: 40568
	public bool IsAllPassed;

	// Token: 0x04009E79 RID: 40569
	[Nullable(1)]
	public List<RoleTowerStageRecordData> StageRecords = new List<RoleTowerStageRecordData>();
}
