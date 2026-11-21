using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C98 RID: 7320
public class RoleTowerFloorData
{
	// Token: 0x04009E6A RID: 40554
	public int Id;

	// Token: 0x04009E6B RID: 40555
	public bool IsPassed;

	// Token: 0x04009E6C RID: 40556
	public bool IsCurrent;

	// Token: 0x04009E6D RID: 40557
	public long TimeDeltaSum;

	// Token: 0x04009E6E RID: 40558
	public long PassRemainTime;

	// Token: 0x04009E6F RID: 40559
	[Nullable(1)]
	public List<int> PassTeamRoleIds = new List<int>();
}
