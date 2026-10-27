using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002427 RID: 9255
public class RecommendData
{
	// Token: 0x0601290C RID: 76044 RVA: 0x0049336F File Offset: 0x0049156F
	public RecommendData()
	{
		this.MonsterIdList = new List<int>();
	}

	// Token: 0x04008BE6 RID: 35814
	public int RoleId;

	// Token: 0x04008BE7 RID: 35815
	[Nullable(1)]
	public List<int> MonsterIdList;

	// Token: 0x04008BE8 RID: 35816
	public int FetterGroupId;

	// Token: 0x04008BE9 RID: 35817
	public int MainPropId;
}
