using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x0200343B RID: 13371
public class RedDotTowerReward : RedDotBase
{
	// Token: 0x0601CE09 RID: 118281 RVA: 0x0080D9D2 File Offset: 0x0080BBD2
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRewardReceived, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotTowerReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CE0A RID: 118282 RVA: 0x0080DA0C File Offset: 0x0080BC0C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRewardReceived, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotTowerReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CE0B RID: 118283 RVA: 0x0080DA46 File Offset: 0x0080BC46
	protected override bool OnCheck(int uId = 0)
	{
		if (TowerModel.Instance.CanGetReward())
		{
			AdventureGuideModel instance = AdventureGuideModel.Instance;
			if (instance != null)
			{
				instance.ReportPeriodicActivityRewardAppear(EDungeonSubType.LoopTower);
			}
		}
		else
		{
			AdventureGuideModel instance2 = AdventureGuideModel.Instance;
			if (instance2 != null)
			{
				instance2.ReportPeriodicActivityRewardClear(EDungeonSubType.LoopTower);
			}
		}
		return TowerModel.Instance.CanGetReward();
	}
}
