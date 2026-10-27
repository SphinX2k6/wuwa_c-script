using System;
using System.Runtime.CompilerServices;

// Token: 0x02002BDB RID: 11227
[NullableContext(2)]
[Nullable(0)]
public class TowerInformationData
{
	// Token: 0x0400AE7C RID: 44668
	public ETowerDetailInformationType Type;

	// Token: 0x0400AE7D RID: 44669
	[Nullable(1)]
	public string Title = string.Empty;

	// Token: 0x0400AE7E RID: 44670
	public int Priority;

	// Token: 0x0400AE7F RID: 44671
	public TowerDetailMonsterData MonsterData;

	// Token: 0x0400AE80 RID: 44672
	public TowerDetailBuffData TowerDetailBuffData;
}
