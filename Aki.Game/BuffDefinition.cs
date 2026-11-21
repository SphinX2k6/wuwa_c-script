using System;
using System.Runtime.CompilerServices;

// Token: 0x020023E5 RID: 9189
[NullableContext(2)]
[Nullable(0)]
public class BuffDefinition
{
	// Token: 0x0400C181 RID: 49537
	public long? Id;

	// Token: 0x0400C182 RID: 49538
	[Nullable(1)]
	public string Desc = "";

	// Token: 0x0400C183 RID: 49539
	public EBuffFormationPolicy FormationPolicy;

	// Token: 0x0400C184 RID: 49540
	public int Probability = 10000;

	// Token: 0x0400C185 RID: 49541
	public long[] PrematureExpirationEffects;

	// Token: 0x0400C186 RID: 49542
	public long[] RoutineExpirationEffects;

	// Token: 0x0400C187 RID: 49543
	public long[] OverflowEffects;

	// Token: 0x0400C188 RID: 49544
	[Nullable(1)]
	public IBuffModifierData[] Modifiers = Array.Empty<IBuffModifierData>();

	// Token: 0x0400C189 RID: 49545
	public int StackLimitCount = 1;

	// Token: 0x0400C18A RID: 49546
	public EBuffStackingType StackingType;

	// Token: 0x0400C18B RID: 49547
	public int DefaultStackCount = 1;

	// Token: 0x0400C18C RID: 49548
	public int StackAppendCount;

	// Token: 0x0400C18D RID: 49549
	public bool DenyOverflowAdd;

	// Token: 0x0400C18E RID: 49550
	public bool ClearStackOnOverflow;

	// Token: 0x0400C18F RID: 49551
	public EBuffDurationType DurationPolicy;

	// Token: 0x0400C190 RID: 49552
	public float[] DurationMagnitude;

	// Token: 0x0400C191 RID: 49553
	public float[] DurationMagnitude2;

	// Token: 0x0400C192 RID: 49554
	public int[] DurationCalculationPolicy;

	// Token: 0x0400C193 RID: 49555
	public long[] GameplayCueIds;

	// Token: 0x0400C194 RID: 49556
	public float Period;

	// Token: 0x0400C195 RID: 49557
	public bool ExecutePeriodicOnAdd;

	// Token: 0x0400C196 RID: 49558
	public EBuffPeriodicInhibitionPolicy PeriodicInhibitionPolicy;

	// Token: 0x0400C197 RID: 49559
	public EBuffStackDurationRefreshPolicy StackDurationRefreshPolicy = EBuffStackDurationRefreshPolicy.None;

	// Token: 0x0400C198 RID: 49560
	public EBuffStackPeriodResetPolicy StackPeriodResetPolicy = EBuffStackPeriodResetPolicy.None;

	// Token: 0x0400C199 RID: 49561
	public int StackExpirationRemoveNumber;

	// Token: 0x0400C19A RID: 49562
	public bool DurationAffectedByBulletTime;

	// Token: 0x0400C19B RID: 49563
	public int[] RemoveBuffWithTags;

	// Token: 0x0400C19C RID: 49564
	public int[] GrantedTags;

	// Token: 0x0400C19D RID: 49565
	public int[] AddInstigatorTagRequirements;

	// Token: 0x0400C19E RID: 49566
	public int[] AddInstigatorTagIgnores;

	// Token: 0x0400C19F RID: 49567
	public int[] AddTagRequirements;

	// Token: 0x0400C1A0 RID: 49568
	public int[] AddTagIgnores;

	// Token: 0x0400C1A1 RID: 49569
	public int[] ActivateTagRequirements;

	// Token: 0x0400C1A2 RID: 49570
	public int[] ActivateTagIgnores;

	// Token: 0x0400C1A3 RID: 49571
	public int[] RemoveTagExistAll;

	// Token: 0x0400C1A4 RID: 49572
	public int[] RemoveTagIgnores;

	// Token: 0x0400C1A5 RID: 49573
	public int[] ImmuneTags;

	// Token: 0x0400C1A6 RID: 49574
	public int[] ImmuneTagIgnores;

	// Token: 0x0400C1A7 RID: 49575
	public int[] RemoveTagExistAny;

	// Token: 0x0400C1A8 RID: 49576
	public long[] BuffsAddedByStackCountOnRemoved;

	// Token: 0x0400C1A9 RID: 49577
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TBuffAction[] BuffAction;

	// Token: 0x0400C1AA RID: 49578
	public bool HasBuffEffect;

	// Token: 0x0400C1AB RID: 49579
	public bool HasBuffPeriodExecution;

	// Token: 0x0400C1AC RID: 49580
	[Nullable(1)]
	public ExtraEffectParameters[] EffectInfos = Array.Empty<ExtraEffectParameters>();

	// Token: 0x0400C1AD RID: 49581
	public bool DeadRemove = true;

	// Token: 0x0400C1AE RID: 49582
	public bool DyingRemove = true;

	// Token: 0x0400C1AF RID: 49583
	public bool OnlyLocalAdd;

	// Token: 0x0400C1B0 RID: 49584
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IConfigOverrideRule[] ConfigOverrides;
}
