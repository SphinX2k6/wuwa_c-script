using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020033E5 RID: 13285
public class RedDotTrialRoleGroup : RedDotBase
{
	// Token: 0x0601CC64 RID: 117860 RVA: 0x00809F6C File Offset: 0x0080816C
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnGroupTrialRoleRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x0601CC65 RID: 117861 RVA: 0x00809FD0 File Offset: 0x008081D0
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnGroupTrialRoleRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int, int>(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x0601CC66 RID: 117862 RVA: 0x0080A031 File Offset: 0x00808231
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601CC67 RID: 117863 RVA: 0x0080A034 File Offset: 0x00808234
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CC68 RID: 117864 RVA: 0x0080A038 File Offset: 0x00808238
	protected override bool OnCheck(int uId = 0)
	{
		if (uId == 0 || !RoleUtils.IsTrialRole(uId))
		{
			return false;
		}
		bool trialRoleUnlockRedDotById = TrialRoleModel.Instance.GetTrialRoleUnlockRedDotById(uId);
		bool upgradeRedDotById = TrialRoleModel.Instance.GetUpgradeRedDotById(uId);
		return trialRoleUnlockRedDotById || upgradeRedDotById;
	}

	// Token: 0x0601CC69 RID: 117865 RVA: 0x0080A06B File Offset: 0x0080826B
	private void OnGroupTrialRoleChanged(int preRoleId, int curRoleId, int groupId)
	{
		base.EventCheck();
	}
}
