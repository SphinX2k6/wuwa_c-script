using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x0200333C RID: 13116
public class RedDotKurotatoWeapon : RedDotBase
{
	// Token: 0x0601C964 RID: 117092 RVA: 0x008043D7 File Offset: 0x008025D7
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601C965 RID: 117093 RVA: 0x008043F5 File Offset: 0x008025F5
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601C966 RID: 117094 RVA: 0x00804413 File Offset: 0x00802613
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotKurotatoWeaponAndProp);
	}

	// Token: 0x0601C967 RID: 117095 RVA: 0x00804420 File Offset: 0x00802620
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && activityData.IsKurotatoWeaponHasRedDot();
	}
}
