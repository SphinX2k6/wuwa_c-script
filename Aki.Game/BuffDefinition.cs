using System;
using System.Runtime.CompilerServices;

// Token: 0x02002E93 RID: 11923
[NullableContext(2)]
[Nullable(0)]
public class BuffDefinition
{
	// Token: 0x0400BDEA RID: 48618
	public long? Id;

	// Token: 0x0400BDEB RID: 48619
	[Nullable(1)]
	public string Desc = "";

	// Token: 0x0400BDEC RID: 48620
	public EBuffFormationPolicy FormationPolicy;

	// Token: 0x0400BDED RID: 48621
	public int Probability = 10000;

	// Token: 0x0400BDEE RID: 48622
	public long[] PrematureExpirationEffects;

	// Token: 0x0400BDEF RID: 48623
	public long[] RoutineExpirationEffects;

	// Token: 0x0400BDF0 RID: 48624
	public long[] OverflowEffects;

	// Token: 0x0400BDF1 RID: 48625
	[Nullable(1)]
	public IBuffModifierData[] Modifiers = Array.Empty<IBuffModifierData>();

	// Token: 0x0400BDF2 RID: 48626
	public int StackLimitCount = 1;

	// Token: 0x0400BDF3 RID: 48627
	public EBuffStackingType StackingType;

	// Token: 0x0400BDF4 RID: 48628
	public int DefaultStackCount = 1;

	// Token: 0x0400BDF5 RID: 48629
	public int StackAppendCount;

	// Token: 0x0400BDF6 RID: 48630
	public bool DenyOverflowAdd;

	// Token: 0x0400BDF7 RID: 48631
	public bool ClearStackOnOverflow;

	// Token: 0x0400BDF8 RID: 48632
	public EBuffDurationType DurationPolicy;

	// Token: 0x0400BDF9 RID: 48633
	public float[] DurationMagnitude;

	// Token: 0x0400BDFA RID: 48634
	public float[] DurationMagnitude2;

	// Token: 0x0400BDFB RID: 48635
	public int[] DurationCalculationPolicy;

	// Token: 0x0400BDFC RID: 48636
	public long[] GameplayCueIds;

	// Token: 0x0400BDFD RID: 48637
	public float Period;

	// Token: 0x0400BDFE RID: 48638
	public bool ExecutePeriodicOnAdd;

	// Token: 0x0400BDFF RID: 48639
	public EBuffPeriodicInhibitionPolicy PeriodicInhibitionPolicy;

	// Token: 0x0400BE00 RID: 48640
	public EBuffStackDurationRefreshPolicy StackDurationRefreshPolicy = EBuffStackDurationRefreshPolicy.None;

	// Token: 0x0400BE01 RID: 48641
	public EBuffStackPeriodResetPolicy StackPeriodResetPolicy = EBuffStackPeriodResetPolicy.None;

	// Token: 0x0400BE02 RID: 48642
	public int StackExpirationRemoveNumber;

	// Token: 0x0400BE03 RID: 48643
	public bool DurationAffectedByBulletTime;

	// Token: 0x0400BE04 RID: 48644
	public int[] RemoveBuffWithTags;

	// Token: 0x0400BE05 RID: 48645
	public int[] GrantedTags;

	// Token: 0x0400BE06 RID: 48646
	public int[] AddInstigatorTagRequirements;

	// Token: 0x0400BE07 RID: 48647
	public int[] AddInstigatorTagIgnores;

	// Token: 0x0400BE08 RID: 48648
	public int[] AddTagRequirements;

	// Token: 0x0400BE09 RID: 48649
	public int[] AddTagIgnores;

	// Token: 0x0400BE0A RID: 48650
	public int[] ActivateTagRequirements;

	// Token: 0x0400BE0B RID: 48651
	public int[] ActivateTagIgnores;

	// Token: 0x0400BE0C RID: 48652
	public int[] RemoveTagExistAll;

	// Token: 0x0400BE0D RID: 48653
	public int[] RemoveTagIgnores;

	// Token: 0x0400BE0E RID: 48654
	public int[] ImmuneTags;

	// Token: 0x0400BE0F RID: 48655
	public int[] ImmuneTagIgnores;

	// Token: 0x0400BE10 RID: 48656
	public int[] RemoveTagExistAny;

	// Token: 0x0400BE11 RID: 48657
	public long[] BuffsAddedByStackCountOnRemoved;

	// Token: 0x0400BE12 RID: 48658
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public TBuffAction[] BuffAction;

	// Token: 0x0400BE13 RID: 48659
	public bool HasBuffEffect;

	// Token: 0x0400BE14 RID: 48660
	public bool HasBuffPeriodExecution;

	// Token: 0x0400BE15 RID: 48661
	[Nullable(1)]
	public ExtraEffectParameters[] EffectInfos = Array.Empty<ExtraEffectParameters>();

	// Token: 0x0400BE16 RID: 48662
	public bool DeadRemove = true;

	// Token: 0x0400BE17 RID: 48663
	public bool OnlyLocalAdd;

	// Token: 0x0400BE18 RID: 48664
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public IConfigOverrideRule[] ConfigOverrides;
}
