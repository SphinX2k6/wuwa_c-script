using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x02001F28 RID: 7976
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerFightFinishViewParams
{
	// Token: 0x0400A8C7 RID: 43207
	public int TotalScore;

	// Token: 0x0400A8C8 RID: 43208
	[Nullable(2)]
	public string GradeResId;

	// Token: 0x0400A8C9 RID: 43209
	public bool IsNewRecord;

	// Token: 0x0400A8CA RID: 43210
	public bool IsEndless;

	// Token: 0x0400A8CB RID: 43211
	public List<IRewardExploreConfirmButton> ButtonList;

	// Token: 0x0400A8CC RID: 43212
	public List<ShipTowerFightFinishItemData> AreaList;
}
