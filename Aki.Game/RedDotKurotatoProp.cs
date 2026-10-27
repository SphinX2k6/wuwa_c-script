using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x0200333A RID: 13114
public class RedDotKurotatoProp : RedDotBase
{
	// Token: 0x0601C95A RID: 117082 RVA: 0x008042E3 File Offset: 0x008024E3
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601C95B RID: 117083 RVA: 0x00804301 File Offset: 0x00802501
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601C95C RID: 117084 RVA: 0x0080431F File Offset: 0x0080251F
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotKurotatoWeaponAndProp);
	}

	// Token: 0x0601C95D RID: 117085 RVA: 0x0080432C File Offset: 0x0080252C
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && activityData.IsKurotatoItemHasRedDot();
	}
}
