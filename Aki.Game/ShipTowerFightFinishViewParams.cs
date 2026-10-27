using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x020029AD RID: 10669
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerFightFinishViewParams
{
	// Token: 0x0400A4DD RID: 42205
	public int TotalScore;

	// Token: 0x0400A4DE RID: 42206
	[Nullable(2)]
	public string GradeResId;

	// Token: 0x0400A4DF RID: 42207
	public bool IsNewRecord;

	// Token: 0x0400A4E0 RID: 42208
	public bool IsEndless;

	// Token: 0x0400A4E1 RID: 42209
	public List<IRewardExploreConfirmButton> ButtonList;

	// Token: 0x0400A4E2 RID: 42210
	public List<ShipTowerFightFinishItemData> AreaList;
}
