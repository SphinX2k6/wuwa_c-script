using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200190C RID: 6412
public class RecommendData
{
	// Token: 0x0600FDC2 RID: 64962 RVA: 0x004A093C File Offset: 0x0049EB3C
	public RecommendData()
	{
		this.MonsterIdList = new List<int>();
	}

	// Token: 0x04008D2D RID: 36141
	public int RoleId;

	// Token: 0x04008D2E RID: 36142
	[Nullable(1)]
	public List<int> MonsterIdList;

	// Token: 0x04008D2F RID: 36143
	public int FetterGroupId;

	// Token: 0x04008D30 RID: 36144
	public int MainPropId;
}
