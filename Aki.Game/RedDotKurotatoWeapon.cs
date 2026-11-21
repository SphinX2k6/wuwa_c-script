using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x020028AE RID: 10414
public class RedDotKurotatoWeapon : RedDotBase
{
	// Token: 0x0601A65C RID: 108124 RVA: 0x0082A99B File Offset: 0x00828B9B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A65D RID: 108125 RVA: 0x0082A9B9 File Offset: 0x00828BB9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A65E RID: 108126 RVA: 0x0082A9D7 File Offset: 0x00828BD7
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.RedDotKurotatoWeaponAndProp);
	}

	// Token: 0x0601A65F RID: 108127 RVA: 0x0082A9E4 File Offset: 0x00828BE4
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && activityData.IsKurotatoWeaponHasRedDot();
	}
}
