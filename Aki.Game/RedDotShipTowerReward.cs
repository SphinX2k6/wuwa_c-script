using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x0200299E RID: 10654
public class RedDotShipTowerReward : RedDotBase
{
	// Token: 0x0601AAAD RID: 109229 RVA: 0x008331C5 File Offset: 0x008313C5
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.ShipTower);
	}

	// Token: 0x0601AAAE RID: 109230 RVA: 0x008331CE File Offset: 0x008313CE
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateShipTowerReward, new Action(base.EventCheck));
	}

	// Token: 0x0601AAAF RID: 109231 RVA: 0x008331EC File Offset: 0x008313EC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateShipTowerReward, new Action(base.EventCheck));
	}

	// Token: 0x0601AAB0 RID: 109232 RVA: 0x0083320A File Offset: 0x0083140A
	protected override bool OnCheck(int uId = 0)
	{
		bool flag = ShipTowerModel.Instance.IsCanReceiveAward();
		if (flag)
		{
			AdventureGuideModel.Instance.ReportPeriodicActivityRewardAppear(EDungeonSubType.ShipTower);
			return flag;
		}
		AdventureGuideModel.Instance.ReportPeriodicActivityRewardClear(EDungeonSubType.ShipTower);
		return flag;
	}
}
