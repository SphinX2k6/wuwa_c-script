using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E66 RID: 11878
[NullableContext(1)]
public interface IBulletDamageParam
{
	// Token: 0x170022AF RID: 8879
	// (get) Token: 0x060195F8 RID: 103928
	// (set) Token: 0x060195F9 RID: 103929
	long DamageDataId { get; set; }

	// Token: 0x170022B0 RID: 8880
	// (get) Token: 0x060195FA RID: 103930
	// (set) Token: 0x060195FB RID: 103931
	long? BulletId { get; set; }

	// Token: 0x170022B1 RID: 8881
	// (get) Token: 0x060195FC RID: 103932
	// (set) Token: 0x060195FD RID: 103933
	Entity Attacker { get; set; }

	// Token: 0x170022B2 RID: 8882
	// (get) Token: 0x060195FE RID: 103934
	// (set) Token: 0x060195FF RID: 103935
	Entity DirectTarget { get; set; }

	// Token: 0x170022B3 RID: 8883
	// (get) Token: 0x06019600 RID: 103936
	// (set) Token: 0x06019601 RID: 103937
	int SkillLevel { get; set; }

	// Token: 0x170022B4 RID: 8884
	// (get) Token: 0x06019602 RID: 103938
	// (set) Token: 0x06019603 RID: 103939
	FVectorDouble HitPosition { get; set; }

	// Token: 0x170022B5 RID: 8885
	// (get) Token: 0x06019604 RID: 103940
	// (set) Token: 0x06019605 RID: 103941
	float ExtraRate { get; set; }

	// Token: 0x170022B6 RID: 8886
	// (get) Token: 0x06019606 RID: 103942
	// (set) Token: 0x06019607 RID: 103943
	bool IsAddEnergy { get; set; }

	// Token: 0x170022B7 RID: 8887
	// (get) Token: 0x06019608 RID: 103944
	// (set) Token: 0x06019609 RID: 103945
	bool IsCounterAttack { get; set; }

	// Token: 0x170022B8 RID: 8888
	// (get) Token: 0x0601960A RID: 103946
	// (set) Token: 0x0601960B RID: 103947
	bool ForceCritical { get; set; }

	// Token: 0x170022B9 RID: 8889
	// (get) Token: 0x0601960C RID: 103948
	// (set) Token: 0x0601960D RID: 103949
	bool IsBlocked { get; set; }

	// Token: 0x170022BA RID: 8890
	// (get) Token: 0x0601960E RID: 103950
	// (set) Token: 0x0601960F RID: 103951
	int PartId { get; set; }

	// Token: 0x170022BB RID: 8891
	// (get) Token: 0x06019610 RID: 103952
	// (set) Token: 0x06019611 RID: 103953
	long? CounterSkillMessageId { get; set; }

	// Token: 0x170022BC RID: 8892
	// (get) Token: 0x06019612 RID: 103954
	// (set) Token: 0x06019613 RID: 103955
	long? CounterSkillId { get; set; }

	// Token: 0x170022BD RID: 8893
	// (get) Token: 0x06019614 RID: 103956
	// (set) Token: 0x06019615 RID: 103957
	ECounterAttackType? CounterType { get; set; }
}
