using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033E4 RID: 13284
public class RedDotNewPlayerSupportTrialRoleEntrance : RedDotBase
{
	// Token: 0x0601CC5F RID: 117855 RVA: 0x00809E64 File Offset: 0x00808064
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.OnActivityNewPlayerSupportEntranceRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add<int, int, int>(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x0601CC60 RID: 117856 RVA: 0x00809EC8 File Offset: 0x008080C8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.CurWorldLevelChange, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.OnActivityNewPlayerSupportEntranceRedDotUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int, int, int>(EEventName.OnGroupTrialRoleChanged, new Action<int, int, int>(this.OnGroupTrialRoleChanged));
	}

	// Token: 0x0601CC61 RID: 117857 RVA: 0x00809F2C File Offset: 0x0080812C
	protected override bool OnCheck(int uId = 0)
	{
		ActivityNewPlayerSupportData activityData = ActivityNewPlayerSupportController.Instance.ActivityData;
		return activityData != null && (activityData.IsTrialRoleUpgradeRedPoint() || activityData.IsTrialRoleEntranceRedDot());
	}

	// Token: 0x0601CC62 RID: 117858 RVA: 0x00809F59 File Offset: 0x00808159
	private void OnGroupTrialRoleChanged(int preRoleId, int curRoleId, int groupId)
	{
		base.EventCheck();
	}
}
