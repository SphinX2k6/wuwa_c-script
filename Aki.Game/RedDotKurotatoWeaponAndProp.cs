using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Kurotato.Data;

// Token: 0x020028AF RID: 10415
public class RedDotKurotatoWeaponAndProp : RedDotBase
{
	// Token: 0x0601A661 RID: 108129 RVA: 0x0082AA0F File Offset: 0x00828C0F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A662 RID: 108130 RVA: 0x0082AA2D File Offset: 0x00828C2D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnRefreshKurotatoWeaponAndPropRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A663 RID: 108131 RVA: 0x0082AA4C File Offset: 0x00828C4C
	protected override ERedDotName? OnGetParentName()
	{
		return null;
	}

	// Token: 0x0601A664 RID: 108132 RVA: 0x0082AA64 File Offset: 0x00828C64
	protected override bool OnCheck(int uId = 0)
	{
		KurotatoActivityData activityData = KurotatoActivityController.Instance.GetActivityData();
		return activityData != null && (activityData.IsKurotatoItemHasRedDot() || activityData.IsKurotatoWeaponHasRedDot());
	}
}
