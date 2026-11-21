using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x020029AF RID: 10671
public class RedDotTowerReward : RedDotBase
{
	// Token: 0x0601AB09 RID: 109321 RVA: 0x008340BA File Offset: 0x008322BA
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnTowerRewardReceived, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotTowerReward, new Action(base.EventCheck));
	}

	// Token: 0x0601AB0A RID: 109322 RVA: 0x008340F4 File Offset: 0x008322F4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnTowerRewardReceived, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotTowerReward, new Action(base.EventCheck));
	}

	// Token: 0x0601AB0B RID: 109323 RVA: 0x0083412E File Offset: 0x0083232E
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
