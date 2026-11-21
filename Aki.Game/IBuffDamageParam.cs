using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020023B6 RID: 9142
[NullableContext(1)]
public interface IBuffDamageParam
{
	// Token: 0x17002322 RID: 8994
	// (get) Token: 0x06016EA4 RID: 93860
	// (set) Token: 0x06016EA5 RID: 93861
	long? BuffId { get; set; }

	// Token: 0x17002323 RID: 8995
	// (get) Token: 0x06016EA6 RID: 93862
	// (set) Token: 0x06016EA7 RID: 93863
	long? BulletId { get; set; }

	// Token: 0x17002324 RID: 8996
	// (get) Token: 0x06016EA8 RID: 93864
	// (set) Token: 0x06016EA9 RID: 93865
	long DamageDataId { get; set; }

	// Token: 0x17002325 RID: 8997
	// (get) Token: 0x06016EAA RID: 93866
	// (set) Token: 0x06016EAB RID: 93867
	Entity Attacker { get; set; }

	// Token: 0x17002326 RID: 8998
	// (get) Token: 0x06016EAC RID: 93868
	// (set) Token: 0x06016EAD RID: 93869
	int SkillLevel { get; set; }

	// Token: 0x17002327 RID: 8999
	// (get) Token: 0x06016EAE RID: 93870
	// (set) Token: 0x06016EAF RID: 93871
	FVectorDouble HitPosition { get; set; }
}
