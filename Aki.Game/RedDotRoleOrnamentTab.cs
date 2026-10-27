using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003428 RID: 13352
public class RedDotRoleOrnamentTab : RedDotBase
{
	// Token: 0x0601CDA8 RID: 118184 RVA: 0x0080CAF9 File Offset: 0x0080ACF9
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleOrnamentRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CDA9 RID: 118185 RVA: 0x0080CB17 File Offset: 0x0080AD17
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RoleOrnamentRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CDAA RID: 118186 RVA: 0x0080CB35 File Offset: 0x0080AD35
	protected override bool OnCheck(int roleId = 0)
	{
		return RoleOrnamentModel.Instance.CheckNewlyAddedOrnamentHasRedDotByRoleId(roleId) || RoleOrnamentModel.Instance.CheckNewlyAcquiredOrnamentHasRedDotByRoleId(roleId);
	}
}
