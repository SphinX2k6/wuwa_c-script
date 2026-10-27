using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x02003339 RID: 13113
public class RedDotKurotatoNormalRewardBtn : RedDotBase
{
	// Token: 0x0601C956 RID: 117078 RVA: 0x0080427C File Offset: 0x0080247C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoNormalRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601C957 RID: 117079 RVA: 0x0080429A File Offset: 0x0080249A
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoNormalRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601C958 RID: 117080 RVA: 0x008042B8 File Offset: 0x008024B8
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && activityData.IsNormalRewardViewHasRedDot();
	}
}
