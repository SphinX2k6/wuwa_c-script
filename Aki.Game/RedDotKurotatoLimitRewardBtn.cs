using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x020028A9 RID: 10409
public class RedDotKurotatoLimitRewardBtn : RedDotBase
{
	// Token: 0x0601A645 RID: 108101 RVA: 0x0082A762 File Offset: 0x00828962
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoLimitRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601A646 RID: 108102 RVA: 0x0082A780 File Offset: 0x00828980
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoLimitRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601A647 RID: 108103 RVA: 0x0082A7A0 File Offset: 0x008289A0
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && (activityData.IsLimitTimeRewardViewHasRedDot() || activityData.IsScoreRewardHasRedDot());
	}
}
