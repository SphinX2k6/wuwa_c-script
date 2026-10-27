using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020014DD RID: 5341
public class RedDotActivityRun : RedDotBase
{
	// Token: 0x0600981D RID: 38941 RVA: 0x0020E32B File Offset: 0x0020C52B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshRunActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0600981E RID: 38942 RVA: 0x0020E349 File Offset: 0x0020C549
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshRunActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0600981F RID: 38943 RVA: 0x0020E368 File Offset: 0x0020C568
	protected override bool OnCheck(int uid = 0)
	{
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(uid);
		return activityRunData != null && activityRunData.GetRedPoint();
	}
}
