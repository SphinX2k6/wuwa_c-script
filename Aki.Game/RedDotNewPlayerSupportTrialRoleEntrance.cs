using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002956 RID: 10582
public class RedDotNewPlayerSupportTrialRoleEntrance : RedDotBase
{
	// Token: 0x0601A957 RID: 108887 RVA: 0x00830428 File Offset: 0x0082E628
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnActivityNewPlayerSupportEntranceRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x0601A958 RID: 108888 RVA: 0x0083048C File Offset: 0x0082E68C
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnActivityNewPlayerSupportEntranceRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int, int>(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x0601A959 RID: 108889 RVA: 0x008304F0 File Offset: 0x0082E6F0
	protected override bool OnCheck(int uId = 0)
	{
		ActivityNewPlayerSupportData activityData = ActivityNewPlayerSupportController.Instance.ActivityData;
		return activityData != null && (activityData.IsTrialRoleUpgradeRedPoint() || activityData.IsTrialRoleEntranceRedDot());
	}

	// Token: 0x0601A95A RID: 108890 RVA: 0x0083051D File Offset: 0x0082E71D
	private void OnGroupTrialRoleChanged(int preRoleId, int curRoleId, int groupId)
	{
		base.EventCheck();
	}
}
