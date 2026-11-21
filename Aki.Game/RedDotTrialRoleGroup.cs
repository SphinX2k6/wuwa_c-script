using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002957 RID: 10583
public class RedDotTrialRoleGroup : RedDotBase
{
	// Token: 0x0601A95C RID: 108892 RVA: 0x00830530 File Offset: 0x0082E730
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnGroupTrialRoleRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x0601A95D RID: 108893 RVA: 0x00830594 File Offset: 0x0082E794
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnGroupTrialRoleRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int, int>(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x0601A95E RID: 108894 RVA: 0x008305F5 File Offset: 0x0082E7F5
	protected override bool IsAllEventParamAsUId()
	{
		return false;
	}

	// Token: 0x0601A95F RID: 108895 RVA: 0x008305F8 File Offset: 0x0082E7F8
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A960 RID: 108896 RVA: 0x008305FC File Offset: 0x0082E7FC
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

	// Token: 0x0601A961 RID: 108897 RVA: 0x0083062F File Offset: 0x0082E82F
	private void OnGroupTrialRoleChanged(int preRoleId, int curRoleId, int groupId)
	{
		base.EventCheck();
	}
}
