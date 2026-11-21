using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02001DC4 RID: 7620
public class RedDotFavorTab : RedDotBase
{
	// Token: 0x06012E3A RID: 77370 RVA: 0x0058A0F3 File Offset: 0x005882F3
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x06012E3B RID: 77371 RVA: 0x0058A0F6 File Offset: 0x005882F6
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int, int>(EEventName.UnLockRoleFavorItem, new Action<int, int>(this.OnUnLockRoleFavorItem));
		EventSystem.Instance.Add<int>(EEventName.UpdateRoleFavorData, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x06012E3C RID: 77372 RVA: 0x0058A130 File Offset: 0x00588330
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.UnLockRoleFavorItem, new Action<int, int>(this.OnUnLockRoleFavorItem));
		EventSystem.Instance.Remove<int>(EEventName.UpdateRoleFavorData, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x06012E3D RID: 77373 RVA: 0x0058A16C File Offset: 0x0058836C
	protected override bool OnCheck(int roleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		return roleDataById != null && roleDataById.GetFavorData().IsExistCanUnlockFavorItem();
	}

	// Token: 0x06012E3E RID: 77374 RVA: 0x0058A196 File Offset: 0x00588396
	private void OnUnLockRoleFavorItem(int roleId, int _)
	{
		base.EventCheckWithUid(roleId);
	}
}
