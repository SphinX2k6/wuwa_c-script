using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002BD8 RID: 11224
public class TowerDetailMonsterData
{
	// Token: 0x0400AE75 RID: 44661
	[Nullable(1)]
	public string Title = string.Empty;

	// Token: 0x0400AE76 RID: 44662
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<TowerDetailMonster> MonsterInfos;

	// Token: 0x0400AE77 RID: 44663
	public int Priority;
}
