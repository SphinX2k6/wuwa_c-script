using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000365 RID: 869
[NullableContext(2)]
public interface IPotatoCombatInfo
{
	// Token: 0x1700070A RID: 1802
	// (get) Token: 0x0600305E RID: 12382
	// (set) Token: 0x0600305F RID: 12383
	EPotatoEntityType EntityType { get; set; }

	// Token: 0x1700070B RID: 1803
	// (get) Token: 0x06003060 RID: 12384
	// (set) Token: 0x06003061 RID: 12385
	int Uid { get; set; }

	// Token: 0x1700070C RID: 1804
	// (get) Token: 0x06003062 RID: 12386
	// (set) Token: 0x06003063 RID: 12387
	int OwnerId { get; set; }

	// Token: 0x1700070D RID: 1805
	// (get) Token: 0x06003064 RID: 12388
	// (set) Token: 0x06003065 RID: 12389
	int TemplateId { get; set; }

	// Token: 0x1700070E RID: 1806
	// (get) Token: 0x06003066 RID: 12390
	// (set) Token: 0x06003067 RID: 12391
	int CombatId { get; set; }

	// Token: 0x1700070F RID: 1807
	// (get) Token: 0x06003068 RID: 12392
	// (set) Token: 0x06003069 RID: 12393
	int SubTypeId { get; set; }

	// Token: 0x17000710 RID: 1808
	// (get) Token: 0x0600306A RID: 12394
	// (set) Token: 0x0600306B RID: 12395
	string PrefabPath { get; set; }

	// Token: 0x17000711 RID: 1809
	// (get) Token: 0x0600306C RID: 12396
	// (set) Token: 0x0600306D RID: 12397
	string AssetPath { get; set; }

	// Token: 0x17000712 RID: 1810
	// (get) Token: 0x0600306E RID: 12398
	// (set) Token: 0x0600306F RID: 12399
	int PropertyId { get; set; }

	// Token: 0x17000713 RID: 1811
	// (get) Token: 0x06003070 RID: 12400
	// (set) Token: 0x06003071 RID: 12401
	int? SplineId { get; set; }

	// Token: 0x17000714 RID: 1812
	// (get) Token: 0x06003072 RID: 12402
	// (set) Token: 0x06003073 RID: 12403
	Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x17000715 RID: 1813
	// (get) Token: 0x06003074 RID: 12404
	// (set) Token: 0x06003075 RID: 12405
	Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x17000716 RID: 1814
	// (get) Token: 0x06003076 RID: 12406
	// (set) Token: 0x06003077 RID: 12407
	[Nullable(1)]
	Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000717 RID: 1815
	// (get) Token: 0x06003078 RID: 12408
	// (set) Token: 0x06003079 RID: 12409
	[Nullable(1)]
	Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x0600307A RID: 12410
	[NullableContext(1)]
	void Update(IPotatoCombatInfo other);

	// Token: 0x0600307B RID: 12411
	bool IsValid();

	// Token: 0x0600307C RID: 12412
	void Reset();

	// Token: 0x0600307D RID: 12413
	void Release();

	// Token: 0x0600307E RID: 12414
	[NullableContext(1)]
	IPotatoCombatInfo Clone();
}
