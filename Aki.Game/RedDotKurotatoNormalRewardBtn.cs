using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x020028AB RID: 10411
public class RedDotKurotatoNormalRewardBtn : RedDotBase
{
	// Token: 0x0601A64E RID: 108110 RVA: 0x0082A840 File Offset: 0x00828A40
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoNormalRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601A64F RID: 108111 RVA: 0x0082A85E File Offset: 0x00828A5E
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoNormalRewardData, new Action(base.EventCheck));
	}

	// Token: 0x0601A650 RID: 108112 RVA: 0x0082A87C File Offset: 0x00828A7C
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && activityData.IsNormalRewardViewHasRedDot();
	}
}
