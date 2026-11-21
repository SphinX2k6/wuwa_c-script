using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x020028AD RID: 10413
public class RedDotKurotatoRole : RedDotBase
{
	// Token: 0x0601A657 RID: 108119 RVA: 0x0082A91B File Offset: 0x00828B1B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoRoleRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A658 RID: 108120 RVA: 0x0082A939 File Offset: 0x00828B39
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoRoleRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A659 RID: 108121 RVA: 0x0082A958 File Offset: 0x00828B58
	protected override ERedDotName? OnGetParentName()
	{
		return null;
	}

	// Token: 0x0601A65A RID: 108122 RVA: 0x0082A970 File Offset: 0x00828B70
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && activityData.IsRoleHasRedDot();
	}
}
