using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000635 RID: 1589
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerRankItemData
{
	// Token: 0x06004A12 RID: 18962 RVA: 0x00193010 File Offset: 0x00191210
	public void CopyFrom(BabelTowerRankItemData other)
	{
		this.Ranking = other.Ranking;
		this.Name = other.Name;
		this.ShowName = other.ShowName;
		this.HeadId = other.HeadId;
		this.TowerLevel = other.TowerLevel;
		this.PassStar = other.PassStar;
		this.PassTime = other.PassTime;
		this.RoleIdList = new List<int>(other.RoleIdList);
		this.RoleLevelList = new List<int>(other.RoleLevelList);
		this.IsMyRank = other.IsMyRank;
		this.HasData = other.HasData;
		this.TitleId = other.TitleId;
		this.TitleStarLevel = other.TitleStarLevel;
		this.PlayerId = other.PlayerId;
		this.ShowRoleList = other.ShowRoleList;
	}

	// Token: 0x040036E9 RID: 14057
	public int Ranking;

	// Token: 0x040036EA RID: 14058
	public string Name = "";

	// Token: 0x040036EB RID: 14059
	public bool ShowName = true;

	// Token: 0x040036EC RID: 14060
	public int HeadId;

	// Token: 0x040036ED RID: 14061
	public int TowerLevel;

	// Token: 0x040036EE RID: 14062
	public int PassStar;

	// Token: 0x040036EF RID: 14063
	public int PassTime;

	// Token: 0x040036F0 RID: 14064
	public List<int> RoleIdList = new List<int>();

	// Token: 0x040036F1 RID: 14065
	public List<int> RoleLevelList = new List<int>();

	// Token: 0x040036F2 RID: 14066
	public bool IsMyRank;

	// Token: 0x040036F3 RID: 14067
	public bool HasData;

	// Token: 0x040036F4 RID: 14068
	public int TitleId;

	// Token: 0x040036F5 RID: 14069
	public int TitleStarLevel;

	// Token: 0x040036F6 RID: 14070
	public int PlayerId;

	// Token: 0x040036F7 RID: 14071
	public bool ShowRoleList;
}
