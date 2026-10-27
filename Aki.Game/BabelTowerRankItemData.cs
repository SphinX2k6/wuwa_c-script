using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001181 RID: 4481
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerRankItemData
{
	// Token: 0x0600767B RID: 30331 RVA: 0x0018A460 File Offset: 0x00188660
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

	// Token: 0x04003650 RID: 13904
	public int Ranking;

	// Token: 0x04003651 RID: 13905
	public string Name = "";

	// Token: 0x04003652 RID: 13906
	public bool ShowName = true;

	// Token: 0x04003653 RID: 13907
	public int HeadId;

	// Token: 0x04003654 RID: 13908
	public int TowerLevel;

	// Token: 0x04003655 RID: 13909
	public int PassStar;

	// Token: 0x04003656 RID: 13910
	public int PassTime;

	// Token: 0x04003657 RID: 13911
	public List<int> RoleIdList = new List<int>();

	// Token: 0x04003658 RID: 13912
	public List<int> RoleLevelList = new List<int>();

	// Token: 0x04003659 RID: 13913
	public bool IsMyRank;

	// Token: 0x0400365A RID: 13914
	public bool HasData;

	// Token: 0x0400365B RID: 13915
	public int TitleId;

	// Token: 0x0400365C RID: 13916
	public int TitleStarLevel;

	// Token: 0x0400365D RID: 13917
	public int PlayerId;

	// Token: 0x0400365E RID: 13918
	public bool ShowRoleList;
}
