using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.AdventureGuide;

// Token: 0x0200342C RID: 13356
public class RedDotShipTowerReward : RedDotBase
{
	// Token: 0x0601CDB5 RID: 118197 RVA: 0x0080CC01 File Offset: 0x0080AE01
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.ShipTower);
	}

	// Token: 0x0601CDB6 RID: 118198 RVA: 0x0080CC0A File Offset: 0x0080AE0A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateShipTowerReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CDB7 RID: 118199 RVA: 0x0080CC28 File Offset: 0x0080AE28
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateShipTowerReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CDB8 RID: 118200 RVA: 0x0080CC46 File Offset: 0x0080AE46
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
