using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002913 RID: 10515
public class RedDotFunctionRole : RedDotBase
{
	// Token: 0x0601A816 RID: 108566 RVA: 0x0082DCD7 File Offset: 0x0082BED7
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewResonanceButton);
	}

	// Token: 0x0601A817 RID: 108567 RVA: 0x0082DCE0 File Offset: 0x0082BEE0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.UpdateRoleResonanceDetailView, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MainViewRoleButtonRefreshByRoleSkin, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MainViewRoleButtonRefreshByRoleOrnament, new Action(base.EventCheck));
	}

	// Token: 0x0601A818 RID: 108568 RVA: 0x0082DD7C File Offset: 0x0082BF7C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.UpdateRoleResonanceDetailView, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MainViewRoleButtonRefreshByRoleSkin, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MainViewRoleButtonRefreshByRoleOrnament, new Action(base.EventCheck));
	}

	// Token: 0x0601A819 RID: 108569 RVA: 0x0082DE15 File Offset: 0x0082C015
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotCondition();
	}
}
