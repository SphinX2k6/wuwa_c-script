using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x0200333B RID: 13115
public class RedDotKurotatoRole : RedDotBase
{
	// Token: 0x0601C95F RID: 117087 RVA: 0x00804357 File Offset: 0x00802557
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoRoleRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601C960 RID: 117088 RVA: 0x00804375 File Offset: 0x00802575
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoRoleRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601C961 RID: 117089 RVA: 0x00804394 File Offset: 0x00802594
	protected override ERedDotName? OnGetParentName()
	{
		return null;
	}

	// Token: 0x0601C962 RID: 117090 RVA: 0x008043AC File Offset: 0x008025AC
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && activityData.IsRoleHasRedDot();
	}
}
