using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200341E RID: 13342
public class RedDotAttributeTab : RedDotBase
{
	// Token: 0x0601CD73 RID: 118131 RVA: 0x0080C2BC File Offset: 0x0080A4BC
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CD74 RID: 118132 RVA: 0x0080C2C0 File Offset: 0x0080A4C0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.RoleSkinRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD75 RID: 118133 RVA: 0x0080C378 File Offset: 0x0080A578
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.RoleSkinRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD76 RID: 118134 RVA: 0x0080C430 File Offset: 0x0080A630
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotAttributeTabBreakUpCondition(uId) || RoleSkinModel.Instance.HasRoleSkinRedDotByRoleId(uId) || CalabashSkinModel.Instance.CheckCalabashSkinHasRedDotByRoleId(uId) || RoleOrnamentModel.Instance.CheckNewlyAddedOrnamentHasRedDotByRoleId(uId) || RoleOrnamentModel.Instance.CheckNewlyAcquiredOrnamentHasRedDotByRoleId(uId);
	}

	// Token: 0x0601CD77 RID: 118135 RVA: 0x0080C47E File Offset: 0x0080A67E
	private void OnRoleLevelUp(int roleId, int oldLevel, int newLevel)
	{
		base.EventCheckWithUid(roleId);
	}

	// Token: 0x0601CD78 RID: 118136 RVA: 0x0080C487 File Offset: 0x0080A687
	private void OnRoleBreakUp(int roleId, int level)
	{
		base.EventCheckWithUid(roleId);
	}
}
