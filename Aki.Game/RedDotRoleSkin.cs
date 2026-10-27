using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003422 RID: 13346
public class RedDotRoleSkin : RedDotBase
{
	// Token: 0x0601CD8A RID: 118154 RVA: 0x0080C784 File Offset: 0x0080A984
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CD8B RID: 118155 RVA: 0x0080C787 File Offset: 0x0080A987
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleSkinRedDotRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.RoleOrnamentRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD8C RID: 118156 RVA: 0x0080C7C1 File Offset: 0x0080A9C1
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RoleSkinRedDotRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.RoleOrnamentRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CD8D RID: 118157 RVA: 0x0080C7FC File Offset: 0x0080A9FC
	protected override bool OnCheck(int uId = 0)
	{
		return RoleSkinModel.Instance.HasRoleSkinRedDotByRoleId(uId) || FlySkinModel.Instance.CheckFlySkinHasRedDot() || CalabashSkinModel.Instance.CheckCalabashSkinHasRedDotByRoleId(uId) || RoleOrnamentModel.Instance.CheckNewlyAddedOrnamentHasRedDotByRoleId(uId) || RoleOrnamentModel.Instance.CheckNewlyAcquiredOrnamentHasRedDotByRoleId(uId);
	}
}
