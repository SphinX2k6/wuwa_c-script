using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x02003338 RID: 13112
public class RedDotKurotatoLimitRewardTabItem : RedDotBase
{
	// Token: 0x0601C951 RID: 117073 RVA: 0x00804211 File Offset: 0x00802411
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601C952 RID: 117074 RVA: 0x00804214 File Offset: 0x00802414
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoLimitRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601C953 RID: 117075 RVA: 0x00804232 File Offset: 0x00802432
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoLimitRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601C954 RID: 117076 RVA: 0x00804250 File Offset: 0x00802450
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && activityData.IsLimitedTimeTaskTabHasAnyClaimable(uId);
	}
}
