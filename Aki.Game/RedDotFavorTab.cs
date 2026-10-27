using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002849 RID: 10313
public class RedDotFavorTab : RedDotBase
{
	// Token: 0x0601543C RID: 87100 RVA: 0x0055F397 File Offset: 0x0055D597
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601543D RID: 87101 RVA: 0x0055F39A File Offset: 0x0055D59A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int, int>(EEventName.UnLockRoleFavorItem, new Action<int, int>(this.OnUnLockRoleFavorItem));
		EventSystem.Instance.Add<int>(EEventName.UpdateRoleFavorData, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601543E RID: 87102 RVA: 0x0055F3D4 File Offset: 0x0055D5D4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.UnLockRoleFavorItem, new Action<int, int>(this.OnUnLockRoleFavorItem));
		EventSystem.Instance.Remove<int>(EEventName.UpdateRoleFavorData, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601543F RID: 87103 RVA: 0x0055F410 File Offset: 0x0055D610
	protected override bool OnCheck(int roleId)
	{
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		return roleDataById != null && roleDataById.GetFavorData().IsExistCanUnlockFavorItem();
	}

	// Token: 0x06015440 RID: 87104 RVA: 0x0055F43A File Offset: 0x0055D63A
	private void OnUnLockRoleFavorItem(int roleId, int _)
	{
		base.EventCheckWithUid(roleId);
	}
}
