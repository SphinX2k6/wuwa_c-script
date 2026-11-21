using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.VillageInfr;

// Token: 0x020029C1 RID: 10689
public class RedDotVillageInfrTask : RedDotBase
{
	// Token: 0x0601AB4D RID: 109389 RVA: 0x00834753 File Offset: 0x00832953
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.VillageInfr);
	}

	// Token: 0x0601AB4E RID: 109390 RVA: 0x0083475F File Offset: 0x0083295F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.VillageInfrActivityTaskDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.VillageInfrScoreRewardDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AB4F RID: 109391 RVA: 0x00834799 File Offset: 0x00832999
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.VillageInfrActivityTaskDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.VillageInfrScoreRewardDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AB50 RID: 109392 RVA: 0x008347D3 File Offset: 0x008329D3
	protected override bool OnCheck(int uId = 0)
	{
		return VillageInfrModel.Instance.GetTaskRedDot() || VillageInfrModel.Instance.HasScoreReward();
	}
}
