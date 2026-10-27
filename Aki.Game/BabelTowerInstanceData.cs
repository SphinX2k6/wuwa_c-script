using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200113E RID: 4414
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerInstanceData
{
	// Token: 0x0400356C RID: 13676
	public int LevelId;

	// Token: 0x0400356D RID: 13677
	public int CurStarNum;

	// Token: 0x0400356E RID: 13678
	public int UseReviveCount;

	// Token: 0x0400356F RID: 13679
	public int RoleCd;

	// Token: 0x04003570 RID: 13680
	public List<int> BuffSelection;

	// Token: 0x04003571 RID: 13681
	public List<int> DeTermIdList;

	// Token: 0x04003572 RID: 13682
	[Nullable(1)]
	public string TraceId = "";
}
