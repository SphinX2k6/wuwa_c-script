using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000EB0 RID: 3760
[NullableContext(2)]
public interface IPotatoCombatInfo
{
	// Token: 0x170006E6 RID: 1766
	// (get) Token: 0x06005CC7 RID: 23751
	// (set) Token: 0x06005CC8 RID: 23752
	EPotatoEntityType EntityType { get; set; }

	// Token: 0x170006E7 RID: 1767
	// (get) Token: 0x06005CC9 RID: 23753
	// (set) Token: 0x06005CCA RID: 23754
	int Uid { get; set; }

	// Token: 0x170006E8 RID: 1768
	// (get) Token: 0x06005CCB RID: 23755
	// (set) Token: 0x06005CCC RID: 23756
	int OwnerId { get; set; }

	// Token: 0x170006E9 RID: 1769
	// (get) Token: 0x06005CCD RID: 23757
	// (set) Token: 0x06005CCE RID: 23758
	int TemplateId { get; set; }

	// Token: 0x170006EA RID: 1770
	// (get) Token: 0x06005CCF RID: 23759
	// (set) Token: 0x06005CD0 RID: 23760
	int CombatId { get; set; }

	// Token: 0x170006EB RID: 1771
	// (get) Token: 0x06005CD1 RID: 23761
	// (set) Token: 0x06005CD2 RID: 23762
	int SubTypeId { get; set; }

	// Token: 0x170006EC RID: 1772
	// (get) Token: 0x06005CD3 RID: 23763
	// (set) Token: 0x06005CD4 RID: 23764
	string PrefabPath { get; set; }

	// Token: 0x170006ED RID: 1773
	// (get) Token: 0x06005CD5 RID: 23765
	// (set) Token: 0x06005CD6 RID: 23766
	string AssetPath { get; set; }

	// Token: 0x170006EE RID: 1774
	// (get) Token: 0x06005CD7 RID: 23767
	// (set) Token: 0x06005CD8 RID: 23768
	int PropertyId { get; set; }

	// Token: 0x170006EF RID: 1775
	// (get) Token: 0x06005CD9 RID: 23769
	// (set) Token: 0x06005CDA RID: 23770
	int? SplineId { get; set; }

	// Token: 0x170006F0 RID: 1776
	// (get) Token: 0x06005CDB RID: 23771
	// (set) Token: 0x06005CDC RID: 23772
	Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x170006F1 RID: 1777
	// (get) Token: 0x06005CDD RID: 23773
	// (set) Token: 0x06005CDE RID: 23774
	Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x170006F2 RID: 1778
	// (get) Token: 0x06005CDF RID: 23775
	// (set) Token: 0x06005CE0 RID: 23776
	[Nullable(1)]
	Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170006F3 RID: 1779
	// (get) Token: 0x06005CE1 RID: 23777
	// (set) Token: 0x06005CE2 RID: 23778
	[Nullable(1)]
	Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x06005CE3 RID: 23779
	[NullableContext(1)]
	void Update(IPotatoCombatInfo other);

	// Token: 0x06005CE4 RID: 23780
	bool IsValid();

	// Token: 0x06005CE5 RID: 23781
	void Reset();

	// Token: 0x06005CE6 RID: 23782
	void Release();

	// Token: 0x06005CE7 RID: 23783
	[NullableContext(1)]
	IPotatoCombatInfo Clone();
}
