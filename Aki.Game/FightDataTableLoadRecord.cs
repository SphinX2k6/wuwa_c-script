using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200312D RID: 12589
[NullableContext(2)]
[Nullable(0)]
public class FightDataTableLoadRecord
{
	// Token: 0x0400D24E RID: 53838
	public UDataTable SkillDataTable;

	// Token: 0x0400D24F RID: 53839
	public UDataTable BulletDataTable;

	// Token: 0x0400D250 RID: 53840
	public UDataTable HitEffectDataTable;

	// Token: 0x0400D251 RID: 53841
	public UDataTable CameraDataTable;

	// Token: 0x0400D252 RID: 53842
	[Nullable(1)]
	public List<int> SkillIds = new List<int>();

	// Token: 0x0400D253 RID: 53843
	[Nullable(1)]
	public List<long> BulletIds = new List<long>();
}
