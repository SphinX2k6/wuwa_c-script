using System;
using System.Runtime.CompilerServices;

// Token: 0x02002156 RID: 8534
[NullableContext(2)]
[Nullable(0)]
public class TowerInformationData
{
	// Token: 0x0400B281 RID: 45697
	public ETowerDetailInformationType Type;

	// Token: 0x0400B282 RID: 45698
	[Nullable(1)]
	public string Title = string.Empty;

	// Token: 0x0400B283 RID: 45699
	public int Priority;

	// Token: 0x0400B284 RID: 45700
	public TowerDetailMonsterData MonsterData;

	// Token: 0x0400B285 RID: 45701
	public TowerDetailBuffData TowerDetailBuffData;
}
