using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000EC3 RID: 3779
[NullableContext(2)]
public interface ISurvivorsRogueCombatInfo
{
	// Token: 0x17000715 RID: 1813
	// (get) Token: 0x06005DA4 RID: 23972
	// (set) Token: 0x06005DA5 RID: 23973
	ESurvivorsRogueEntityType EntityType { get; set; }

	// Token: 0x17000716 RID: 1814
	// (get) Token: 0x06005DA6 RID: 23974
	// (set) Token: 0x06005DA7 RID: 23975
	int Uid { get; set; }

	// Token: 0x17000717 RID: 1815
	// (get) Token: 0x06005DA8 RID: 23976
	// (set) Token: 0x06005DA9 RID: 23977
	int OwnerId { get; set; }

	// Token: 0x17000718 RID: 1816
	// (get) Token: 0x06005DAA RID: 23978
	// (set) Token: 0x06005DAB RID: 23979
	int TemplateId { get; set; }

	// Token: 0x17000719 RID: 1817
	// (get) Token: 0x06005DAC RID: 23980
	// (set) Token: 0x06005DAD RID: 23981
	int CombatId { get; set; }

	// Token: 0x1700071A RID: 1818
	// (get) Token: 0x06005DAE RID: 23982
	// (set) Token: 0x06005DAF RID: 23983
	int SubTypeId { get; set; }

	// Token: 0x1700071B RID: 1819
	// (get) Token: 0x06005DB0 RID: 23984
	// (set) Token: 0x06005DB1 RID: 23985
	string PrefabPath { get; set; }

	// Token: 0x1700071C RID: 1820
	// (get) Token: 0x06005DB2 RID: 23986
	// (set) Token: 0x06005DB3 RID: 23987
	string AssetPath { get; set; }

	// Token: 0x1700071D RID: 1821
	// (get) Token: 0x06005DB4 RID: 23988
	// (set) Token: 0x06005DB5 RID: 23989
	int PropertyId { get; set; }

	// Token: 0x1700071E RID: 1822
	// (get) Token: 0x06005DB6 RID: 23990
	// (set) Token: 0x06005DB7 RID: 23991
	int? SplineId { get; set; }

	// Token: 0x1700071F RID: 1823
	// (get) Token: 0x06005DB8 RID: 23992
	// (set) Token: 0x06005DB9 RID: 23993
	Dictionary<int, int> BuffIdLayers { get; set; }

	// Token: 0x17000720 RID: 1824
	// (get) Token: 0x06005DBA RID: 23994
	// (set) Token: 0x06005DBB RID: 23995
	Dictionary<int, int> AttributeMap { get; set; }

	// Token: 0x17000721 RID: 1825
	// (get) Token: 0x06005DBC RID: 23996
	// (set) Token: 0x06005DBD RID: 23997
	[Nullable(1)]
	Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000722 RID: 1826
	// (get) Token: 0x06005DBE RID: 23998
	// (set) Token: 0x06005DBF RID: 23999
	[Nullable(1)]
	Rotator Rotation { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x06005DC0 RID: 24000
	[NullableContext(1)]
	void Update(ISurvivorsRogueCombatInfo other);

	// Token: 0x06005DC1 RID: 24001
	bool IsValid();

	// Token: 0x06005DC2 RID: 24002
	void Reset();

	// Token: 0x06005DC3 RID: 24003
	void Release();

	// Token: 0x06005DC4 RID: 24004
	[NullableContext(1)]
	ISurvivorsRogueCombatInfo Clone();
}
