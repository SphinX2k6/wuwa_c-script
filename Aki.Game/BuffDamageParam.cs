using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E65 RID: 11877
[NullableContext(1)]
[Nullable(0)]
public class BuffDamageParam : IBuffDamageParam
{
	// Token: 0x170022A9 RID: 8873
	// (get) Token: 0x060195E9 RID: 103913 RVA: 0x0068C9C6 File Offset: 0x0068ABC6
	// (set) Token: 0x060195EA RID: 103914 RVA: 0x0068C9CE File Offset: 0x0068ABCE
	public long? BuffId { get; set; }

	// Token: 0x170022AA RID: 8874
	// (get) Token: 0x060195EB RID: 103915 RVA: 0x0068C9D7 File Offset: 0x0068ABD7
	// (set) Token: 0x060195EC RID: 103916 RVA: 0x0068C9DF File Offset: 0x0068ABDF
	public long? BulletId { get; set; }

	// Token: 0x170022AB RID: 8875
	// (get) Token: 0x060195ED RID: 103917 RVA: 0x0068C9E8 File Offset: 0x0068ABE8
	// (set) Token: 0x060195EE RID: 103918 RVA: 0x0068C9F0 File Offset: 0x0068ABF0
	public long DamageDataId { get; set; }

	// Token: 0x170022AC RID: 8876
	// (get) Token: 0x060195EF RID: 103919 RVA: 0x0068C9F9 File Offset: 0x0068ABF9
	// (set) Token: 0x060195F0 RID: 103920 RVA: 0x0068CA01 File Offset: 0x0068AC01
	public Entity Attacker { get; set; }

	// Token: 0x170022AD RID: 8877
	// (get) Token: 0x060195F1 RID: 103921 RVA: 0x0068CA0A File Offset: 0x0068AC0A
	// (set) Token: 0x060195F2 RID: 103922 RVA: 0x0068CA12 File Offset: 0x0068AC12
	public int SkillLevel { get; set; }

	// Token: 0x170022AE RID: 8878
	// (get) Token: 0x060195F3 RID: 103923 RVA: 0x0068CA1B File Offset: 0x0068AC1B
	// (set) Token: 0x060195F4 RID: 103924 RVA: 0x0068CA23 File Offset: 0x0068AC23
	public FVectorDouble HitPosition { get; set; }

	// Token: 0x060195F5 RID: 103925 RVA: 0x0068CA2C File Offset: 0x0068AC2C
	public BuffDamageParam()
	{
	}

	// Token: 0x060195F6 RID: 103926 RVA: 0x0068CA34 File Offset: 0x0068AC34
	public BuffDamageParam(IBuffDamageParam source)
	{
		this.BuffId = source.BuffId;
		this.BulletId = source.BulletId;
		this.DamageDataId = source.DamageDataId;
		this.Attacker = source.Attacker;
		this.SkillLevel = source.SkillLevel;
		this.HitPosition = source.HitPosition;
	}

	// Token: 0x060195F7 RID: 103927 RVA: 0x0068CA8F File Offset: 0x0068AC8F
	public BuffDamageParam(IBuffDamageParam source, FVectorDouble hitPosition) : this(source)
	{
		this.HitPosition = hitPosition;
	}
}
