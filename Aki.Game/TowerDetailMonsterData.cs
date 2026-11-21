using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002153 RID: 8531
public class TowerDetailMonsterData
{
	// Token: 0x0400B27A RID: 45690
	[Nullable(1)]
	public string Title = string.Empty;

	// Token: 0x0400B27B RID: 45691
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<TowerDetailMonster> MonsterInfos;

	// Token: 0x0400B27C RID: 45692
	public int Priority;
}
