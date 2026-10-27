using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020011FE RID: 4606
public class RedDotActivityCorniceMeeting : RedDotBase
{
	// Token: 0x06007B3F RID: 31551 RVA: 0x0019FB16 File Offset: 0x0019DD16
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCorniceMeetingRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x06007B40 RID: 31552 RVA: 0x0019FB34 File Offset: 0x0019DD34
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCorniceMeetingRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x06007B41 RID: 31553 RVA: 0x0019FB54 File Offset: 0x0019DD54
	protected override bool OnCheck(int uid)
	{
		ActivityCorniceMeetingData currentActivityData = ActivityCorniceMeetingController.Instance.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			return false;
		}
		ActivityCorniceMeetingLevelEntryData levelEntryData = currentActivityData.GetLevelEntryData(uid);
		return levelEntryData != null && levelEntryData.GetRedDot();
	}
}
