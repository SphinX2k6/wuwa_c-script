using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02002BD3 RID: 11219
[NullableContext(1)]
[Nullable(0)]
public class TowerFloorInfo
{
	// Token: 0x060174D8 RID: 95448 RVA: 0x005EC98C File Offset: 0x005EAB8C
	public TowerFloorInfo(int towerId, int star, List<TowerRolePb> formation, List<int> starIndex, bool isQuickPass)
	{
		this.TowerId = towerId;
		this.Star = star;
		this.Formation = formation;
		this.StarIndex = starIndex;
		this.IsQuickPass = isQuickPass;
		TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(this.TowerId);
		this.Difficulties = towerInfo.Value.Difficulty;
		this.Area = towerInfo.Value.AreaNum;
		this.FloorNumber = towerInfo.Value.Floor;
		this.Cost = towerInfo.Value.Cost;
	}

	// Token: 0x0400AE5F RID: 44639
	public readonly int Difficulties = -1;

	// Token: 0x0400AE60 RID: 44640
	public readonly int Area = -1;

	// Token: 0x0400AE61 RID: 44641
	public readonly int FloorNumber = -1;

	// Token: 0x0400AE62 RID: 44642
	public readonly int Cost = -1;

	// Token: 0x0400AE63 RID: 44643
	public readonly int TowerId;

	// Token: 0x0400AE64 RID: 44644
	public int Star;

	// Token: 0x0400AE65 RID: 44645
	public List<TowerRolePb> Formation;

	// Token: 0x0400AE66 RID: 44646
	public List<int> StarIndex;

	// Token: 0x0400AE67 RID: 44647
	public bool IsQuickPass;
}
