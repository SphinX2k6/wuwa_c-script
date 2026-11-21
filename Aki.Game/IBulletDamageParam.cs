using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020023B8 RID: 9144
[NullableContext(1)]
public interface IBulletDamageParam
{
	// Token: 0x1700232E RID: 9006
	// (get) Token: 0x06016EBF RID: 93887
	// (set) Token: 0x06016EC0 RID: 93888
	long DamageDataId { get; set; }

	// Token: 0x1700232F RID: 9007
	// (get) Token: 0x06016EC1 RID: 93889
	// (set) Token: 0x06016EC2 RID: 93890
	long? BulletId { get; set; }

	// Token: 0x17002330 RID: 9008
	// (get) Token: 0x06016EC3 RID: 93891
	// (set) Token: 0x06016EC4 RID: 93892
	Entity Attacker { get; set; }

	// Token: 0x17002331 RID: 9009
	// (get) Token: 0x06016EC5 RID: 93893
	// (set) Token: 0x06016EC6 RID: 93894
	Entity DirectTarget { get; set; }

	// Token: 0x17002332 RID: 9010
	// (get) Token: 0x06016EC7 RID: 93895
	// (set) Token: 0x06016EC8 RID: 93896
	int SkillLevel { get; set; }

	// Token: 0x17002333 RID: 9011
	// (get) Token: 0x06016EC9 RID: 93897
	// (set) Token: 0x06016ECA RID: 93898
	FVectorDouble HitPosition { get; set; }

	// Token: 0x17002334 RID: 9012
	// (get) Token: 0x06016ECB RID: 93899
	// (set) Token: 0x06016ECC RID: 93900
	float ExtraRate { get; set; }

	// Token: 0x17002335 RID: 9013
	// (get) Token: 0x06016ECD RID: 93901
	// (set) Token: 0x06016ECE RID: 93902
	bool IsAddEnergy { get; set; }

	// Token: 0x17002336 RID: 9014
	// (get) Token: 0x06016ECF RID: 93903
	// (set) Token: 0x06016ED0 RID: 93904
	bool IsCounterAttack { get; set; }

	// Token: 0x17002337 RID: 9015
	// (get) Token: 0x06016ED1 RID: 93905
	// (set) Token: 0x06016ED2 RID: 93906
	bool ForceCritical { get; set; }

	// Token: 0x17002338 RID: 9016
	// (get) Token: 0x06016ED3 RID: 93907
	// (set) Token: 0x06016ED4 RID: 93908
	bool IsBlocked { get; set; }

	// Token: 0x17002339 RID: 9017
	// (get) Token: 0x06016ED5 RID: 93909
	// (set) Token: 0x06016ED6 RID: 93910
	int PartId { get; set; }

	// Token: 0x1700233A RID: 9018
	// (get) Token: 0x06016ED7 RID: 93911
	// (set) Token: 0x06016ED8 RID: 93912
	long? CounterSkillMessageId { get; set; }

	// Token: 0x1700233B RID: 9019
	// (get) Token: 0x06016ED9 RID: 93913
	// (set) Token: 0x06016EDA RID: 93914
	long? CounterSkillId { get; set; }

	// Token: 0x1700233C RID: 9020
	// (get) Token: 0x06016EDB RID: 93915
	// (set) Token: 0x06016EDC RID: 93916
	ECounterAttackType? CounterType { get; set; }
}
