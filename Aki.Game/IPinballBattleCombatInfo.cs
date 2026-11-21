using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000358 RID: 856
[NullableContext(2)]
public interface IPinballBattleCombatInfo
{
	// Token: 0x170006E9 RID: 1769
	// (get) Token: 0x06002FE6 RID: 12262
	// (set) Token: 0x06002FE7 RID: 12263
	EPinballBattleEntityType EntityType { get; set; }

	// Token: 0x170006EA RID: 1770
	// (get) Token: 0x06002FE8 RID: 12264
	// (set) Token: 0x06002FE9 RID: 12265
	int Uid { get; set; }

	// Token: 0x170006EB RID: 1771
	// (get) Token: 0x06002FEA RID: 12266
	// (set) Token: 0x06002FEB RID: 12267
	int OwnerId { get; set; }

	// Token: 0x170006EC RID: 1772
	// (get) Token: 0x06002FEC RID: 12268
	// (set) Token: 0x06002FED RID: 12269
	int TemplateId { get; set; }

	// Token: 0x170006ED RID: 1773
	// (get) Token: 0x06002FEE RID: 12270
	// (set) Token: 0x06002FEF RID: 12271
	int CombatId { get; set; }

	// Token: 0x170006EE RID: 1774
	// (get) Token: 0x06002FF0 RID: 12272
	// (set) Token: 0x06002FF1 RID: 12273
	int SubTypeId { get; set; }

	// Token: 0x170006EF RID: 1775
	// (get) Token: 0x06002FF2 RID: 12274
	// (set) Token: 0x06002FF3 RID: 12275
	string PrefabPath { get; set; }

	// Token: 0x170006F0 RID: 1776
	// (get) Token: 0x06002FF4 RID: 12276
	// (set) Token: 0x06002FF5 RID: 12277
	string AssetPath { get; set; }

	// Token: 0x170006F1 RID: 1777
	// (get) Token: 0x06002FF6 RID: 12278
	// (set) Token: 0x06002FF7 RID: 12279
	int PropertyId { get; set; }

	// Token: 0x170006F2 RID: 1778
	// (get) Token: 0x06002FF8 RID: 12280
	// (set) Token: 0x06002FF9 RID: 12281
	int? SplineId { get; set; }

	// Token: 0x170006F3 RID: 1779
	// (get) Token: 0x06002FFA RID: 12282
	// (set) Token: 0x06002FFB RID: 12283
	Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x170006F4 RID: 1780
	// (get) Token: 0x06002FFC RID: 12284
	// (set) Token: 0x06002FFD RID: 12285
	Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x170006F5 RID: 1781
	// (get) Token: 0x06002FFE RID: 12286
	// (set) Token: 0x06002FFF RID: 12287
	[Nullable(1)]
	Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170006F6 RID: 1782
	// (get) Token: 0x06003000 RID: 12288
	// (set) Token: 0x06003001 RID: 12289
	[Nullable(1)]
	Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x06003002 RID: 12290
	[NullableContext(1)]
	void Update(IPinballBattleCombatInfo other);

	// Token: 0x06003003 RID: 12291
	bool IsValid();

	// Token: 0x06003004 RID: 12292
	void Reset();

	// Token: 0x06003005 RID: 12293
	void Release();

	// Token: 0x06003006 RID: 12294
	[NullableContext(1)]
	IPinballBattleCombatInfo Clone();
}
