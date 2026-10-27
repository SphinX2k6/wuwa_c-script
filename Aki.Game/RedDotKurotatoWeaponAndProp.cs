using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x0200333D RID: 13117
public class RedDotKurotatoWeaponAndProp : RedDotBase
{
	// Token: 0x0601C969 RID: 117097 RVA: 0x0080444B File Offset: 0x0080264B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601C96A RID: 117098 RVA: 0x00804469 File Offset: 0x00802669
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601C96B RID: 117099 RVA: 0x00804488 File Offset: 0x00802688
	protected override ERedDotName? OnGetParentName()
	{
		return null;
	}

	// Token: 0x0601C96C RID: 117100 RVA: 0x008044A0 File Offset: 0x008026A0
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && (activityData.IsKurotatoItemHasRedDot() || activityData.IsKurotatoWeaponHasRedDot());
	}
}
