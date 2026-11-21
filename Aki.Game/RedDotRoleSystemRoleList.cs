using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200298F RID: 10639
public class RedDotRoleSystemRoleList : RedDotBase
{
	// Token: 0x0601AA64 RID: 109156 RVA: 0x0083248A File Offset: 0x0083068A
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AA65 RID: 109157 RVA: 0x00832490 File Offset: 0x00830690
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

	// Token: 0x0601AA66 RID: 109158 RVA: 0x00832628 File Offset: 0x00830828
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

	// Token: 0x0601AA67 RID: 109159 RVA: 0x008327C0 File Offset: 0x008309C0
	protected override bool OnCheck(int uId = 0)
	{
		return RoleModel.Instance.GetRoleInstanceById(uId) != null && (RoleSkinModel.Instance.HasRoleSkinRedDotByRoleId(uId) || RoleOrnamentModel.Instance.CheckNewlyAcquiredOrnamentHasRedDotByRoleId(uId) || RoleModel.Instance.RedDotResonanceTabCondition(uId) || (FormationModel.Instance.IsRoleInCurrentFormation(uId) && (RoleModel.Instance.RedDotAttributeTabBreakUpCondition(uId) || WeaponModel.Instance.RedDotWeaponBreachCondition(uId) || WeaponModel.Instance.RedDotWeaponResonanceConditionByRole(uId) || VisionRecommendModel.Instance.CheckVisionOneKeyEquipRedDot(uId) || CalabashSkinModel.Instance.CheckCalabashSkinHasRedDotByRoleId(uId))));
	}

	// Token: 0x0601AA68 RID: 109160 RVA: 0x00832866 File Offset: 0x00830A66
	private void OnEventThreeInt(int configId, int exp, int level)
	{
		base.EventCheckWithUid(configId);
	}

	// Token: 0x0601AA69 RID: 109161 RVA: 0x0083286F File Offset: 0x00830A6F
	private void OnEventTwoInt(int roleId, int level)
	{
		base.EventCheckWithUid(roleId);
	}
}
