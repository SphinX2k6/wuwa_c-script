using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002E67 RID: 11879
[NullableContext(1)]
[Nullable(0)]
public class BulletDamageParams : IBulletDamageParam
{
	// Token: 0x170022BE RID: 8894
	// (get) Token: 0x06019616 RID: 103958 RVA: 0x0068CA9F File Offset: 0x0068AC9F
	// (set) Token: 0x06019617 RID: 103959 RVA: 0x0068CAA7 File Offset: 0x0068ACA7
	public long DamageDataId { get; set; }

	// Token: 0x170022BF RID: 8895
	// (get) Token: 0x06019618 RID: 103960 RVA: 0x0068CAB0 File Offset: 0x0068ACB0
	// (set) Token: 0x06019619 RID: 103961 RVA: 0x0068CAB8 File Offset: 0x0068ACB8
	public long? BulletId { get; set; }

	// Token: 0x170022C0 RID: 8896
	// (get) Token: 0x0601961A RID: 103962 RVA: 0x0068CAC1 File Offset: 0x0068ACC1
	// (set) Token: 0x0601961B RID: 103963 RVA: 0x0068CAC9 File Offset: 0x0068ACC9
	public Entity Attacker { get; set; }

	// Token: 0x170022C1 RID: 8897
	// (get) Token: 0x0601961C RID: 103964 RVA: 0x0068CAD2 File Offset: 0x0068ACD2
	// (set) Token: 0x0601961D RID: 103965 RVA: 0x0068CADA File Offset: 0x0068ACDA
	public Entity DirectTarget { get; set; }

	// Token: 0x170022C2 RID: 8898
	// (get) Token: 0x0601961E RID: 103966 RVA: 0x0068CAE3 File Offset: 0x0068ACE3
	// (set) Token: 0x0601961F RID: 103967 RVA: 0x0068CAEB File Offset: 0x0068ACEB
	public int SkillLevel { get; set; }

	// Token: 0x170022C3 RID: 8899
	// (get) Token: 0x06019620 RID: 103968 RVA: 0x0068CAF4 File Offset: 0x0068ACF4
	// (set) Token: 0x06019621 RID: 103969 RVA: 0x0068CAFC File Offset: 0x0068ACFC
	public FVectorDouble HitPosition { get; set; }

	// Token: 0x170022C4 RID: 8900
	// (get) Token: 0x06019622 RID: 103970 RVA: 0x0068CB05 File Offset: 0x0068AD05
	// (set) Token: 0x06019623 RID: 103971 RVA: 0x0068CB0D File Offset: 0x0068AD0D
	public float ExtraRate { get; set; }

	// Token: 0x170022C5 RID: 8901
	// (get) Token: 0x06019624 RID: 103972 RVA: 0x0068CB16 File Offset: 0x0068AD16
	// (set) Token: 0x06019625 RID: 103973 RVA: 0x0068CB1E File Offset: 0x0068AD1E
	public bool IsAddEnergy { get; set; }

	// Token: 0x170022C6 RID: 8902
	// (get) Token: 0x06019626 RID: 103974 RVA: 0x0068CB27 File Offset: 0x0068AD27
	// (set) Token: 0x06019627 RID: 103975 RVA: 0x0068CB2F File Offset: 0x0068AD2F
	public bool IsCounterAttack { get; set; }

	// Token: 0x170022C7 RID: 8903
	// (get) Token: 0x06019628 RID: 103976 RVA: 0x0068CB38 File Offset: 0x0068AD38
	// (set) Token: 0x06019629 RID: 103977 RVA: 0x0068CB40 File Offset: 0x0068AD40
	public bool ForceCritical { get; set; }

	// Token: 0x170022C8 RID: 8904
	// (get) Token: 0x0601962A RID: 103978 RVA: 0x0068CB49 File Offset: 0x0068AD49
	// (set) Token: 0x0601962B RID: 103979 RVA: 0x0068CB51 File Offset: 0x0068AD51
	public bool IsBlocked { get; set; }

	// Token: 0x170022C9 RID: 8905
	// (get) Token: 0x0601962C RID: 103980 RVA: 0x0068CB5A File Offset: 0x0068AD5A
	// (set) Token: 0x0601962D RID: 103981 RVA: 0x0068CB62 File Offset: 0x0068AD62
	public int PartId { get; set; }

	// Token: 0x170022CA RID: 8906
	// (get) Token: 0x0601962E RID: 103982 RVA: 0x0068CB6B File Offset: 0x0068AD6B
	// (set) Token: 0x0601962F RID: 103983 RVA: 0x0068CB73 File Offset: 0x0068AD73
	public long? CounterSkillMessageId { get; set; }

	// Token: 0x170022CB RID: 8907
	// (get) Token: 0x06019630 RID: 103984 RVA: 0x0068CB7C File Offset: 0x0068AD7C
	// (set) Token: 0x06019631 RID: 103985 RVA: 0x0068CB84 File Offset: 0x0068AD84
	public long? CounterSkillId { get; set; }

	// Token: 0x170022CC RID: 8908
	// (get) Token: 0x06019632 RID: 103986 RVA: 0x0068CB8D File Offset: 0x0068AD8D
	// (set) Token: 0x06019633 RID: 103987 RVA: 0x0068CB95 File Offset: 0x0068AD95
	public ECounterAttackType? CounterType { get; set; }
}
