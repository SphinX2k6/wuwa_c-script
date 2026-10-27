using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BossPiling;

// Token: 0x0200336B RID: 13163
public class RedDotBossPilingReward : RedDotBase
{
	// Token: 0x0601CA34 RID: 117300 RVA: 0x00805B98 File Offset: 0x00803D98
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnBossPilingReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CA35 RID: 117301 RVA: 0x00805BB6 File Offset: 0x00803DB6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnBossPilingReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CA36 RID: 117302 RVA: 0x00805BD4 File Offset: 0x00803DD4
	protected override bool OnCheck(int uId = 0)
	{
		BossPilingActivityData activityData = BossPilingModel.Instance.GetActivityData();
		return activityData != null && activityData.CheckTaskRedDot();
	}
}
