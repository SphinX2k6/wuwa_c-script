using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200214E RID: 8526
[NullableContext(1)]
[Nullable(0)]
public class TowerFloorInfo
{
	// Token: 0x06014F09 RID: 85769 RVA: 0x006194C8 File Offset: 0x006176C8
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

	// Token: 0x0400B264 RID: 45668
	public readonly int Difficulties = -1;

	// Token: 0x0400B265 RID: 45669
	public readonly int Area = -1;

	// Token: 0x0400B266 RID: 45670
	public readonly int FloorNumber = -1;

	// Token: 0x0400B267 RID: 45671
	public readonly int Cost = -1;

	// Token: 0x0400B268 RID: 45672
	public readonly int TowerId;

	// Token: 0x0400B269 RID: 45673
	public int Star;

	// Token: 0x0400B26A RID: 45674
	public List<TowerRolePb> Formation;

	// Token: 0x0400B26B RID: 45675
	public List<int> StarIndex;

	// Token: 0x0400B26C RID: 45676
	public bool IsQuickPass;
}
