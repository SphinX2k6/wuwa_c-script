using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x020028AA RID: 10410
public class RedDotKurotatoLimitRewardTabItem : RedDotBase
{
	// Token: 0x0601A649 RID: 108105 RVA: 0x0082A7D5 File Offset: 0x008289D5
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A64A RID: 108106 RVA: 0x0082A7D8 File Offset: 0x008289D8
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoLimitRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601A64B RID: 108107 RVA: 0x0082A7F6 File Offset: 0x008289F6
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoLimitRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601A64C RID: 108108 RVA: 0x0082A814 File Offset: 0x00828A14
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && activityData.IsLimitedTimeTaskTabHasAnyClaimable(uId);
	}
}
