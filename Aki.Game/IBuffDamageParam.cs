using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E64 RID: 11876
[NullableContext(1)]
public interface IBuffDamageParam
{
	// Token: 0x170022A3 RID: 8867
	// (get) Token: 0x060195DD RID: 103901
	// (set) Token: 0x060195DE RID: 103902
	long? BuffId { get; set; }

	// Token: 0x170022A4 RID: 8868
	// (get) Token: 0x060195DF RID: 103903
	// (set) Token: 0x060195E0 RID: 103904
	long? BulletId { get; set; }

	// Token: 0x170022A5 RID: 8869
	// (get) Token: 0x060195E1 RID: 103905
	// (set) Token: 0x060195E2 RID: 103906
	long DamageDataId { get; set; }

	// Token: 0x170022A6 RID: 8870
	// (get) Token: 0x060195E3 RID: 103907
	// (set) Token: 0x060195E4 RID: 103908
	Entity Attacker { get; set; }

	// Token: 0x170022A7 RID: 8871
	// (get) Token: 0x060195E5 RID: 103909
	// (set) Token: 0x060195E6 RID: 103910
	int SkillLevel { get; set; }

	// Token: 0x170022A8 RID: 8872
	// (get) Token: 0x060195E7 RID: 103911
	// (set) Token: 0x060195E8 RID: 103912
	FVectorDouble HitPosition { get; set; }
}
