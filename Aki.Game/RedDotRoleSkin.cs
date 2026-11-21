using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002994 RID: 10644
public class RedDotRoleSkin : RedDotBase
{
	// Token: 0x0601AA82 RID: 109186 RVA: 0x00832D48 File Offset: 0x00830F48
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601AA83 RID: 109187 RVA: 0x00832D4B File Offset: 0x00830F4B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleSkinRedDotRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.RoleOrnamentRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA84 RID: 109188 RVA: 0x00832D85 File Offset: 0x00830F85
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RoleSkinRedDotRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.RoleOrnamentRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AA85 RID: 109189 RVA: 0x00832DC0 File Offset: 0x00830FC0
	protected override bool OnCheck(int uId = 0)
	{
		return RoleSkinModel.Instance.HasRoleSkinRedDotByRoleId(uId) || FlySkinModel.Instance.CheckFlySkinHasRedDot() || CalabashSkinModel.Instance.CheckCalabashSkinHasRedDotByRoleId(uId) || RoleOrnamentModel.Instance.CheckNewlyAddedOrnamentHasRedDotByRoleId(uId) || RoleOrnamentModel.Instance.CheckNewlyAcquiredOrnamentHasRedDotByRoleId(uId);
	}
}
