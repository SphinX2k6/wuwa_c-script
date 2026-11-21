using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000333 RID: 819
[NullableContext(2)]
[Nullable(0)]
public class KscEntityParam : IKscEntityParam
{
	// Token: 0x170006B5 RID: 1717
	// (get) Token: 0x06002E27 RID: 11815 RVA: 0x00110351 File Offset: 0x0010E551
	// (set) Token: 0x06002E28 RID: 11816 RVA: 0x00110359 File Offset: 0x0010E559
	public long CreatureId { get; set; }

	// Token: 0x170006B6 RID: 1718
	// (get) Token: 0x06002E29 RID: 11817 RVA: 0x00110362 File Offset: 0x0010E562
	// (set) Token: 0x06002E2A RID: 11818 RVA: 0x0011036A File Offset: 0x0010E56A
	public int SimpleCombatId { get; set; }

	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x06002E2B RID: 11819 RVA: 0x00110373 File Offset: 0x0010E573
	// (set) Token: 0x06002E2C RID: 11820 RVA: 0x0011037B File Offset: 0x0010E57B
	[Nullable(1)]
	public string AssetPath { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x06002E2D RID: 11821 RVA: 0x00110384 File Offset: 0x0010E584
	// (set) Token: 0x06002E2E RID: 11822 RVA: 0x0011038C File Offset: 0x0010E58C
	public int PropertyId { get; set; }

	// Token: 0x170006B9 RID: 1721
	// (get) Token: 0x06002E2F RID: 11823 RVA: 0x00110395 File Offset: 0x0010E595
	// (set) Token: 0x06002E30 RID: 11824 RVA: 0x0011039D File Offset: 0x0010E59D
	public FTransformDouble Transform { get; set; }

	// Token: 0x170006BA RID: 1722
	// (get) Token: 0x06002E31 RID: 11825 RVA: 0x001103A6 File Offset: 0x0010E5A6
	// (set) Token: 0x06002E32 RID: 11826 RVA: 0x001103AE File Offset: 0x0010E5AE
	public USplineComponent Spline { get; set; }

	// Token: 0x170006BB RID: 1723
	// (get) Token: 0x06002E33 RID: 11827 RVA: 0x001103B7 File Offset: 0x0010E5B7
	// (set) Token: 0x06002E34 RID: 11828 RVA: 0x001103BF File Offset: 0x0010E5BF
	public Dictionary<int, int> Buffs { get; set; }

	// Token: 0x170006BC RID: 1724
	// (get) Token: 0x06002E35 RID: 11829 RVA: 0x001103C8 File Offset: 0x0010E5C8
	// (set) Token: 0x06002E36 RID: 11830 RVA: 0x001103D0 File Offset: 0x0010E5D0
	public Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x170006BD RID: 1725
	// (get) Token: 0x06002E37 RID: 11831 RVA: 0x001103D9 File Offset: 0x0010E5D9
	// (set) Token: 0x06002E38 RID: 11832 RVA: 0x001103E1 File Offset: 0x0010E5E1
	public EKSC_Faction? Faction { get; set; }

	// Token: 0x170006BE RID: 1726
	// (get) Token: 0x06002E39 RID: 11833 RVA: 0x001103EA File Offset: 0x0010E5EA
	// (set) Token: 0x06002E3A RID: 11834 RVA: 0x001103F2 File Offset: 0x0010E5F2
	public AActor RenderActor { get; set; }

	// Token: 0x170006BF RID: 1727
	// (get) Token: 0x06002E3B RID: 11835 RVA: 0x001103FB File Offset: 0x0010E5FB
	// (set) Token: 0x06002E3C RID: 11836 RVA: 0x00110403 File Offset: 0x0010E603
	public bool? IsPreview { get; set; }

	// Token: 0x170006C0 RID: 1728
	// (get) Token: 0x06002E3D RID: 11837 RVA: 0x0011040C File Offset: 0x0010E60C
	// (set) Token: 0x06002E3E RID: 11838 RVA: 0x00110414 File Offset: 0x0010E614
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<AKSC_Entity> OnEntityAdd { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170006C1 RID: 1729
	// (get) Token: 0x06002E3F RID: 11839 RVA: 0x0011041D File Offset: 0x0010E61D
	// (set) Token: 0x06002E40 RID: 11840 RVA: 0x00110425 File Offset: 0x0010E625
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<AKSC_Entity> FinishCallback { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170006C2 RID: 1730
	// (get) Token: 0x06002E41 RID: 11841 RVA: 0x0011042E File Offset: 0x0010E62E
	// (set) Token: 0x06002E42 RID: 11842 RVA: 0x00110436 File Offset: 0x0010E636
	public UniTask? WaitToBegin { get; set; }
}
