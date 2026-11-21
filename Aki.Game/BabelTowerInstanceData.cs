using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005F2 RID: 1522
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerInstanceData
{
	// Token: 0x04003605 RID: 13829
	public int LevelId;

	// Token: 0x04003606 RID: 13830
	public int CurStarNum;

	// Token: 0x04003607 RID: 13831
	public int UseReviveCount;

	// Token: 0x04003608 RID: 13832
	public int RoleCd;

	// Token: 0x04003609 RID: 13833
	public List<int> BuffSelection;

	// Token: 0x0400360A RID: 13834
	public List<int> DeTermIdList;

	// Token: 0x0400360B RID: 13835
	[Nullable(1)]
	public string TraceId = "";
}
