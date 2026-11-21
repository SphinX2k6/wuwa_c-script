using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020006B2 RID: 1714
public class RedDotActivityCorniceMeeting : RedDotBase
{
	// Token: 0x06004ED5 RID: 20181 RVA: 0x001A87CE File Offset: 0x001A69CE
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCorniceMeetingRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x06004ED6 RID: 20182 RVA: 0x001A87EC File Offset: 0x001A69EC
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCorniceMeetingRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x06004ED7 RID: 20183 RVA: 0x001A880C File Offset: 0x001A6A0C
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
