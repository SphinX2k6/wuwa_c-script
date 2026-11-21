using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002990 RID: 10640
public class RedDotAttributeTab : RedDotBase
{
	// Token: 0x0601AA6B RID: 109163 RVA: 0x00832880 File Offset: 0x00830A80
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AA6C RID: 109164 RVA: 0x00832884 File Offset: 0x00830A84
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.RoleSkinRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA6D RID: 109165 RVA: 0x0083293C File Offset: 0x00830B3C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnRoleLevelUp));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnRoleBreakUp));
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.ActiveRole, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.RoleSkinRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA6E RID: 109166 RVA: 0x008329F4 File Offset: 0x00830BF4
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.RedDotAttributeTabBreakUpCondition(uId) || RoleSkinModel.Instance.HasRoleSkinRedDotByRoleId(uId) || CalabashSkinModel.Instance.CheckCalabashSkinHasRedDotByRoleId(uId) || RoleOrnamentModel.Instance.CheckNewlyAddedOrnamentHasRedDotByRoleId(uId) || RoleOrnamentModel.Instance.CheckNewlyAcquiredOrnamentHasRedDotByRoleId(uId);
	}

	// Token: 0x0601AA6F RID: 109167 RVA: 0x00832A42 File Offset: 0x00830C42
	private void OnRoleLevelUp(int roleId, int oldLevel, int newLevel)
	{
		base.EventCheckWithUid(roleId);
	}

	// Token: 0x0601AA70 RID: 109168 RVA: 0x00832A4B File Offset: 0x00830C4B
	private void OnRoleBreakUp(int roleId, int level)
	{
		base.EventCheckWithUid(roleId);
	}
}
