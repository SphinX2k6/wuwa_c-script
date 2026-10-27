using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x02003337 RID: 13111
public class RedDotKurotatoLimitRewardBtn : RedDotBase
{
	// Token: 0x0601C94D RID: 117069 RVA: 0x0080419E File Offset: 0x0080239E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoLimitRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601C94E RID: 117070 RVA: 0x008041BC File Offset: 0x008023BC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoLimitRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601C94F RID: 117071 RVA: 0x008041DC File Offset: 0x008023DC
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && (activityData.IsLimitTimeRewardViewHasRedDot() || activityData.IsScoreRewardHasRedDot());
	}
}
