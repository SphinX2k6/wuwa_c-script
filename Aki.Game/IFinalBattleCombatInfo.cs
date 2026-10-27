using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000E6D RID: 3693
[NullableContext(2)]
public interface IFinalBattleCombatInfo
{
	// Token: 0x17000660 RID: 1632
	// (get) Token: 0x060059B1 RID: 22961
	// (set) Token: 0x060059B2 RID: 22962
	EFinalBattleEntityType EntityType { get; set; }

	// Token: 0x17000661 RID: 1633
	// (get) Token: 0x060059B3 RID: 22963
	// (set) Token: 0x060059B4 RID: 22964
	int Uid { get; set; }

	// Token: 0x17000662 RID: 1634
	// (get) Token: 0x060059B5 RID: 22965
	// (set) Token: 0x060059B6 RID: 22966
	int OwnerId { get; set; }

	// Token: 0x17000663 RID: 1635
	// (get) Token: 0x060059B7 RID: 22967
	// (set) Token: 0x060059B8 RID: 22968
	int TemplateId { get; set; }

	// Token: 0x17000664 RID: 1636
	// (get) Token: 0x060059B9 RID: 22969
	// (set) Token: 0x060059BA RID: 22970
	int CombatId { get; set; }

	// Token: 0x17000665 RID: 1637
	// (get) Token: 0x060059BB RID: 22971
	// (set) Token: 0x060059BC RID: 22972
	int SubTypeId { get; set; }

	// Token: 0x17000666 RID: 1638
	// (get) Token: 0x060059BD RID: 22973
	// (set) Token: 0x060059BE RID: 22974
	string PrefabPath { get; set; }

	// Token: 0x17000667 RID: 1639
	// (get) Token: 0x060059BF RID: 22975
	// (set) Token: 0x060059C0 RID: 22976
	string AssetPath { get; set; }

	// Token: 0x17000668 RID: 1640
	// (get) Token: 0x060059C1 RID: 22977
	// (set) Token: 0x060059C2 RID: 22978
	int PropertyId { get; set; }

	// Token: 0x17000669 RID: 1641
	// (get) Token: 0x060059C3 RID: 22979
	// (set) Token: 0x060059C4 RID: 22980
	int? SplineId { get; set; }

	// Token: 0x1700066A RID: 1642
	// (get) Token: 0x060059C5 RID: 22981
	// (set) Token: 0x060059C6 RID: 22982
	Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x1700066B RID: 1643
	// (get) Token: 0x060059C7 RID: 22983
	// (set) Token: 0x060059C8 RID: 22984
	Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x1700066C RID: 1644
	// (get) Token: 0x060059C9 RID: 22985
	// (set) Token: 0x060059CA RID: 22986
	[Nullable(1)]
	Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700066D RID: 1645
	// (get) Token: 0x060059CB RID: 22987
	// (set) Token: 0x060059CC RID: 22988
	[Nullable(1)]
	Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x060059CD RID: 22989
	[NullableContext(1)]
	void Update(IFinalBattleCombatInfo other);

	// Token: 0x060059CE RID: 22990
	bool IsValid();

	// Token: 0x060059CF RID: 22991
	void Reset();

	// Token: 0x060059D0 RID: 22992
	void Release();

	// Token: 0x060059D1 RID: 22993
	[NullableContext(1)]
	IFinalBattleCombatInfo Clone();
}
