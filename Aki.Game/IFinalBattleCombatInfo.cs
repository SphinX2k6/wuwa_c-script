using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000322 RID: 802
[NullableContext(2)]
public interface IFinalBattleCombatInfo
{
	// Token: 0x17000684 RID: 1668
	// (get) Token: 0x06002D48 RID: 11592
	// (set) Token: 0x06002D49 RID: 11593
	EFinalBattleEntityType EntityType { get; set; }

	// Token: 0x17000685 RID: 1669
	// (get) Token: 0x06002D4A RID: 11594
	// (set) Token: 0x06002D4B RID: 11595
	int Uid { get; set; }

	// Token: 0x17000686 RID: 1670
	// (get) Token: 0x06002D4C RID: 11596
	// (set) Token: 0x06002D4D RID: 11597
	int OwnerId { get; set; }

	// Token: 0x17000687 RID: 1671
	// (get) Token: 0x06002D4E RID: 11598
	// (set) Token: 0x06002D4F RID: 11599
	int TemplateId { get; set; }

	// Token: 0x17000688 RID: 1672
	// (get) Token: 0x06002D50 RID: 11600
	// (set) Token: 0x06002D51 RID: 11601
	int CombatId { get; set; }

	// Token: 0x17000689 RID: 1673
	// (get) Token: 0x06002D52 RID: 11602
	// (set) Token: 0x06002D53 RID: 11603
	int SubTypeId { get; set; }

	// Token: 0x1700068A RID: 1674
	// (get) Token: 0x06002D54 RID: 11604
	// (set) Token: 0x06002D55 RID: 11605
	string PrefabPath { get; set; }

	// Token: 0x1700068B RID: 1675
	// (get) Token: 0x06002D56 RID: 11606
	// (set) Token: 0x06002D57 RID: 11607
	string AssetPath { get; set; }

	// Token: 0x1700068C RID: 1676
	// (get) Token: 0x06002D58 RID: 11608
	// (set) Token: 0x06002D59 RID: 11609
	int PropertyId { get; set; }

	// Token: 0x1700068D RID: 1677
	// (get) Token: 0x06002D5A RID: 11610
	// (set) Token: 0x06002D5B RID: 11611
	int? SplineId { get; set; }

	// Token: 0x1700068E RID: 1678
	// (get) Token: 0x06002D5C RID: 11612
	// (set) Token: 0x06002D5D RID: 11613
	Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x1700068F RID: 1679
	// (get) Token: 0x06002D5E RID: 11614
	// (set) Token: 0x06002D5F RID: 11615
	Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x17000690 RID: 1680
	// (get) Token: 0x06002D60 RID: 11616
	// (set) Token: 0x06002D61 RID: 11617
	[Nullable(1)]
	Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000691 RID: 1681
	// (get) Token: 0x06002D62 RID: 11618
	// (set) Token: 0x06002D63 RID: 11619
	[Nullable(1)]
	Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x06002D64 RID: 11620
	[NullableContext(1)]
	void Update(IFinalBattleCombatInfo other);

	// Token: 0x06002D65 RID: 11621
	bool IsValid();

	// Token: 0x06002D66 RID: 11622
	void Reset();

	// Token: 0x06002D67 RID: 11623
	void Release();

	// Token: 0x06002D68 RID: 11624
	[NullableContext(1)]
	IFinalBattleCombatInfo Clone();
}
