using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02001681 RID: 5761
public class RedDotCommonActivityPage : RedDotBase
{
	// Token: 0x0600A301 RID: 41729 RVA: 0x00240497 File Offset: 0x0023E697
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.ActivityEntrance);
	}

	// Token: 0x0600A302 RID: 41730 RVA: 0x002404A0 File Offset: 0x0023E6A0
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0600A303 RID: 41731 RVA: 0x002404A3 File Offset: 0x0023E6A3
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0600A304 RID: 41732 RVA: 0x002404C1 File Offset: 0x0023E6C1
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0600A305 RID: 41733 RVA: 0x002404DF File Offset: 0x0023E6DF
	protected override bool OnCheck(int uid)
	{
		return ActivityModel.Instance.GetActivityRedDotState(uid);
	}
}
