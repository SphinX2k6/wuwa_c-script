using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200299A RID: 10650
public class RedDotRoleOrnamentTab : RedDotBase
{
	// Token: 0x0601AAA0 RID: 109216 RVA: 0x008330BD File Offset: 0x008312BD
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RoleOrnamentRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AAA1 RID: 109217 RVA: 0x008330DB File Offset: 0x008312DB
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RoleOrnamentRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601AAA2 RID: 109218 RVA: 0x008330F9 File Offset: 0x008312F9
	protected override bool OnCheck(int roleId = 0)
	{
		return RoleOrnamentModel.Instance.CheckNewlyAddedOrnamentHasRedDotByRoleId(roleId) || RoleOrnamentModel.Instance.CheckNewlyAcquiredOrnamentHasRedDotByRoleId(roleId);
	}
}
