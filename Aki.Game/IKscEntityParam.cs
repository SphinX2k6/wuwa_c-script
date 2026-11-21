using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000332 RID: 818
[NullableContext(2)]
public interface IKscEntityParam
{
	// Token: 0x170006A7 RID: 1703
	// (get) Token: 0x06002E0B RID: 11787
	// (set) Token: 0x06002E0C RID: 11788
	long CreatureId { get; set; }

	// Token: 0x170006A8 RID: 1704
	// (get) Token: 0x06002E0D RID: 11789
	// (set) Token: 0x06002E0E RID: 11790
	int SimpleCombatId { get; set; }

	// Token: 0x170006A9 RID: 1705
	// (get) Token: 0x06002E0F RID: 11791
	// (set) Token: 0x06002E10 RID: 11792
	[Nullable(1)]
	string AssetPath { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170006AA RID: 1706
	// (get) Token: 0x06002E11 RID: 11793
	// (set) Token: 0x06002E12 RID: 11794
	int PropertyId { get; set; }

	// Token: 0x170006AB RID: 1707
	// (get) Token: 0x06002E13 RID: 11795
	// (set) Token: 0x06002E14 RID: 11796
	FTransformDouble Transform { get; set; }

	// Token: 0x170006AC RID: 1708
	// (get) Token: 0x06002E15 RID: 11797
	// (set) Token: 0x06002E16 RID: 11798
	USplineComponent Spline { get; set; }

	// Token: 0x170006AD RID: 1709
	// (get) Token: 0x06002E17 RID: 11799
	// (set) Token: 0x06002E18 RID: 11800
	Dictionary<int, int> Buffs { get; set; }

	// Token: 0x170006AE RID: 1710
	// (get) Token: 0x06002E19 RID: 11801
	// (set) Token: 0x06002E1A RID: 11802
	Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x170006AF RID: 1711
	// (get) Token: 0x06002E1B RID: 11803
	// (set) Token: 0x06002E1C RID: 11804
	EKSC_Faction? Faction { get; set; }

	// Token: 0x170006B0 RID: 1712
	// (get) Token: 0x06002E1D RID: 11805
	// (set) Token: 0x06002E1E RID: 11806
	AActor RenderActor { get; set; }

	// Token: 0x170006B1 RID: 1713
	// (get) Token: 0x06002E1F RID: 11807
	// (set) Token: 0x06002E20 RID: 11808
	bool? IsPreview { get; set; }

	// Token: 0x170006B2 RID: 1714
	// (get) Token: 0x06002E21 RID: 11809
	// (set) Token: 0x06002E22 RID: 11810
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Action<AKSC_Entity> OnEntityAdd { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170006B3 RID: 1715
	// (get) Token: 0x06002E23 RID: 11811
	// (set) Token: 0x06002E24 RID: 11812
	[Nullable(new byte[]
	{
		2,
		1
	})]
	Action<AKSC_Entity> FinishCallback { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170006B4 RID: 1716
	// (get) Token: 0x06002E25 RID: 11813
	// (set) Token: 0x06002E26 RID: 11814
	UniTask? WaitToBegin { get; set; }
}
