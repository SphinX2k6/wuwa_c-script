using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200341D RID: 13341
public class RedDotRoleSystemRoleList : RedDotBase
{
	// Token: 0x0601CD6C RID: 118124 RVA: 0x0080BEC6 File Offset: 0x0080A0C6
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CD6D RID: 118125 RVA: 0x0080BECC File Offset: 0x0080A0CC
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnEventThreeInt));
		EventSystem.Instance.Add<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.UpdateRoleResonanceDetailView, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.RedDotRefreshPhantomEquip, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RedDotRoleChange, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.RedDotUnLockPhantom, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RedDotCreateRole, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.RoleSystemDeleteRole, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add(EEventName.PhantomEquip, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RoleSkinRedDotRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int, int>(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Add<int>(EEventName.RoleOrnamentRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD6E RID: 118126 RVA: 0x0080C064 File Offset: 0x0080A264
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int, int, int>(EEventName.RoleLevelUp, new Action<int, int, int>(this.OnEventThreeInt));
		EventSystem.Instance.Remove<int, int>(EEventName.RoleBreakUp, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.UpdateRoleResonanceDetailView, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.RedDotRefreshPhantomEquip, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RedDotRoleChange, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.RedDotUnLockPhantom, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RedDotCreateRole, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.RoleSystemChangeRole, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.RoleSystemDeleteRole, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove(EEventName.PhantomEquip, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RoleSkinRedDotRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int, int>(EEventName.WeaponResonanceSuccess, new Action<int, int>(this.OnEventTwoInt));
		EventSystem.Instance.Remove<int>(EEventName.RoleOrnamentRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD6F RID: 118127 RVA: 0x0080C1FC File Offset: 0x0080A3FC
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.GetRoleInstanceById(uId) != null && (RoleSkinModel.Instance.HasRoleSkinRedDotByRoleId(uId) || RoleOrnamentModel.Instance.CheckNewlyAcquiredOrnamentHasRedDotByRoleId(uId) || RoleModel.Instance.RedDotResonanceTabCondition(uId) || (FormationModel.Instance.IsRoleInCurrentFormation(uId) && (RoleModel.Instance.RedDotAttributeTabBreakUpCondition(uId) || WeaponModel.Instance.RedDotWeaponBreachCondition(uId) || WeaponModel.Instance.RedDotWeaponResonanceConditionByRole(uId) || VisionRecommendModel.Instance.CheckVisionOneKeyEquipRedDot(uId) || CalabashSkinModel.Instance.CheckCalabashSkinHasRedDotByRoleId(uId))));
	}

	// Token: 0x0601CD70 RID: 118128 RVA: 0x0080C2A2 File Offset: 0x0080A4A2
	private void OnEventThreeInt(int configId, int exp, int level)
	{
		base.EventCheckWithUid(configId);
	}

	// Token: 0x0601CD71 RID: 118129 RVA: 0x0080C2AB File Offset: 0x0080A4AB
	private void OnEventTwoInt(int roleId, int level)
	{
		base.EventCheckWithUid(roleId);
	}
}
