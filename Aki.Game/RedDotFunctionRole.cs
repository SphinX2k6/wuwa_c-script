using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033A1 RID: 13217
public class RedDotFunctionRole : RedDotBase
{
	// Token: 0x0601CB1E RID: 117534 RVA: 0x00807713 File Offset: 0x00805913
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.BattleViewResonanceButton);
	}

	// Token: 0x0601CB1F RID: 117535 RVA: 0x0080771C File Offset: 0x0080591C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.UpdateRoleResonanceDetailView, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MainViewRoleButtonRefreshByRoleSkin, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MainViewRoleButtonRefreshByRoleOrnament, new Action(base.EventCheck));
	}

	// Token: 0x0601CB20 RID: 117536 RVA: 0x008077B8 File Offset: 0x008059B8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.UpdateRoleResonanceDetailView, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MainViewRoleButtonRefreshByRoleSkin, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MainViewRoleButtonRefreshByRoleOrnament, new Action(base.EventCheck));
	}

	// Token: 0x0601CB21 RID: 117537 RVA: 0x00807851 File Offset: 0x00805A51
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotCondition();
	}
}
