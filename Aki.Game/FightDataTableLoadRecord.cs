using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002688 RID: 9864
[NullableContext(2)]
[Nullable(0)]
public class FightDataTableLoadRecord
{
	// Token: 0x0400D670 RID: 54896
	public UDataTable SkillDataTable;

	// Token: 0x0400D671 RID: 54897
	public UDataTable BulletDataTable;

	// Token: 0x0400D672 RID: 54898
	public UDataTable HitEffectDataTable;

	// Token: 0x0400D673 RID: 54899
	public UDataTable CameraDataTable;

	// Token: 0x0400D674 RID: 54900
	[Nullable(1)]
	public List<int> SkillIds = new List<int>();

	// Token: 0x0400D675 RID: 54901
	[Nullable(1)]
	public List<long> BulletIds = new List<long>();
}
