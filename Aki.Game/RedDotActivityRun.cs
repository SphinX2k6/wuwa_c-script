using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02000995 RID: 2453
public class RedDotActivityRun : RedDotBase
{
	// Token: 0x06006BF7 RID: 27639 RVA: 0x0021806B File Offset: 0x0021626B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshRunActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x06006BF8 RID: 27640 RVA: 0x00218089 File Offset: 0x00216289
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshRunActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x06006BF9 RID: 27641 RVA: 0x002180A8 File Offset: 0x002162A8
	protected override bool OnCheck(int uid = 0)
	{
		ActivityRunData activityRunData = ActivityRunModel.Instance.GetActivityRunData(uid);
		return activityRunData != null && activityRunData.GetRedPoint();
	}
}
