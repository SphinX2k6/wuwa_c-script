using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000EA3 RID: 3747
[NullableContext(2)]
public interface IPinballBattleCombatInfo
{
	// Token: 0x170006C5 RID: 1733
	// (get) Token: 0x06005C4F RID: 23631
	// (set) Token: 0x06005C50 RID: 23632
	EPinballBattleEntityType EntityType { get; set; }

	// Token: 0x170006C6 RID: 1734
	// (get) Token: 0x06005C51 RID: 23633
	// (set) Token: 0x06005C52 RID: 23634
	int Uid { get; set; }

	// Token: 0x170006C7 RID: 1735
	// (get) Token: 0x06005C53 RID: 23635
	// (set) Token: 0x06005C54 RID: 23636
	int OwnerId { get; set; }

	// Token: 0x170006C8 RID: 1736
	// (get) Token: 0x06005C55 RID: 23637
	// (set) Token: 0x06005C56 RID: 23638
	int TemplateId { get; set; }

	// Token: 0x170006C9 RID: 1737
	// (get) Token: 0x06005C57 RID: 23639
	// (set) Token: 0x06005C58 RID: 23640
	int CombatId { get; set; }

	// Token: 0x170006CA RID: 1738
	// (get) Token: 0x06005C59 RID: 23641
	// (set) Token: 0x06005C5A RID: 23642
	int SubTypeId { get; set; }

	// Token: 0x170006CB RID: 1739
	// (get) Token: 0x06005C5B RID: 23643
	// (set) Token: 0x06005C5C RID: 23644
	string PrefabPath { get; set; }

	// Token: 0x170006CC RID: 1740
	// (get) Token: 0x06005C5D RID: 23645
	// (set) Token: 0x06005C5E RID: 23646
	string AssetPath { get; set; }

	// Token: 0x170006CD RID: 1741
	// (get) Token: 0x06005C5F RID: 23647
	// (set) Token: 0x06005C60 RID: 23648
	int PropertyId { get; set; }

	// Token: 0x170006CE RID: 1742
	// (get) Token: 0x06005C61 RID: 23649
	// (set) Token: 0x06005C62 RID: 23650
	int? SplineId { get; set; }

	// Token: 0x170006CF RID: 1743
	// (get) Token: 0x06005C63 RID: 23651
	// (set) Token: 0x06005C64 RID: 23652
	Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x170006D0 RID: 1744
	// (get) Token: 0x06005C65 RID: 23653
	// (set) Token: 0x06005C66 RID: 23654
	Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x170006D1 RID: 1745
	// (get) Token: 0x06005C67 RID: 23655
	// (set) Token: 0x06005C68 RID: 23656
	[Nullable(1)]
	Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170006D2 RID: 1746
	// (get) Token: 0x06005C69 RID: 23657
	// (set) Token: 0x06005C6A RID: 23658
	[Nullable(1)]
	Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x06005C6B RID: 23659
	[NullableContext(1)]
	void Update(IPinballBattleCombatInfo other);

	// Token: 0x06005C6C RID: 23660
	bool IsValid();

	// Token: 0x06005C6D RID: 23661
	void Reset();

	// Token: 0x06005C6E RID: 23662
	void Release();

	// Token: 0x06005C6F RID: 23663
	[NullableContext(1)]
	IPinballBattleCombatInfo Clone();
}
