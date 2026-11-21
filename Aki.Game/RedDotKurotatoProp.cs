using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x020028AC RID: 10412
public class RedDotKurotatoProp : RedDotBase
{
	// Token: 0x0601A652 RID: 108114 RVA: 0x0082A8A7 File Offset: 0x00828AA7
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A653 RID: 108115 RVA: 0x0082A8C5 File Offset: 0x00828AC5
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A654 RID: 108116 RVA: 0x0082A8E3 File Offset: 0x00828AE3
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotKurotatoWeaponAndProp);
	}

	// Token: 0x0601A655 RID: 108117 RVA: 0x0082A8F0 File Offset: 0x00828AF0
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && activityData.IsKurotatoItemHasRedDot();
	}
}
