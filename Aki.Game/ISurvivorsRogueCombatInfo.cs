using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000378 RID: 888
[NullableContext(2)]
public interface ISurvivorsRogueCombatInfo
{
	// Token: 0x17000739 RID: 1849
	// (get) Token: 0x0600313B RID: 12603
	// (set) Token: 0x0600313C RID: 12604
	ESurvivorsRogueEntityType EntityType { get; set; }

	// Token: 0x1700073A RID: 1850
	// (get) Token: 0x0600313D RID: 12605
	// (set) Token: 0x0600313E RID: 12606
	int Uid { get; set; }

	// Token: 0x1700073B RID: 1851
	// (get) Token: 0x0600313F RID: 12607
	// (set) Token: 0x06003140 RID: 12608
	int OwnerId { get; set; }

	// Token: 0x1700073C RID: 1852
	// (get) Token: 0x06003141 RID: 12609
	// (set) Token: 0x06003142 RID: 12610
	int TemplateId { get; set; }

	// Token: 0x1700073D RID: 1853
	// (get) Token: 0x06003143 RID: 12611
	// (set) Token: 0x06003144 RID: 12612
	int CombatId { get; set; }

	// Token: 0x1700073E RID: 1854
	// (get) Token: 0x06003145 RID: 12613
	// (set) Token: 0x06003146 RID: 12614
	int SubTypeId { get; set; }

	// Token: 0x1700073F RID: 1855
	// (get) Token: 0x06003147 RID: 12615
	// (set) Token: 0x06003148 RID: 12616
	string PrefabPath { get; set; }

	// Token: 0x17000740 RID: 1856
	// (get) Token: 0x06003149 RID: 12617
	// (set) Token: 0x0600314A RID: 12618
	string AssetPath { get; set; }

	// Token: 0x17000741 RID: 1857
	// (get) Token: 0x0600314B RID: 12619
	// (set) Token: 0x0600314C RID: 12620
	int PropertyId { get; set; }

	// Token: 0x17000742 RID: 1858
	// (get) Token: 0x0600314D RID: 12621
	// (set) Token: 0x0600314E RID: 12622
	int? SplineId { get; set; }

	// Token: 0x17000743 RID: 1859
	// (get) Token: 0x0600314F RID: 12623
	// (set) Token: 0x06003150 RID: 12624
	Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x17000744 RID: 1860
	// (get) Token: 0x06003151 RID: 12625
	// (set) Token: 0x06003152 RID: 12626
	Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x17000745 RID: 1861
	// (get) Token: 0x06003153 RID: 12627
	// (set) Token: 0x06003154 RID: 12628
	[Nullable(1)]
	Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000746 RID: 1862
	// (get) Token: 0x06003155 RID: 12629
	// (set) Token: 0x06003156 RID: 12630
	[Nullable(1)]
	Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x06003157 RID: 12631
	[NullableContext(1)]
	void Update(ISurvivorsRogueCombatInfo other);

	// Token: 0x06003158 RID: 12632
	bool IsValid();

	// Token: 0x06003159 RID: 12633
	void Reset();

	// Token: 0x0600315A RID: 12634
	void Release();

	// Token: 0x0600315B RID: 12635
	[NullableContext(1)]
	ISurvivorsRogueCombatInfo Clone();
}
