using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028DC RID: 10460
public class BeginnerCarnivalTaskTabRedDot : RedDotBase
{
	// Token: 0x0601A728 RID: 108328 RVA: 0x0082C0F2 File Offset: 0x0082A2F2
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshBeginnerCarnivalTask, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A729 RID: 108329 RVA: 0x0082C110 File Offset: 0x0082A310
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.RefreshBeginnerCarnivalTask, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A72A RID: 108330 RVA: 0x0082C130 File Offset: 0x0082A330
	protected override bool OnCheck(int uId = 0)
	{
		BeginnerCarnivalData beginnerCarnivalData = BeginnerCarnivalController.Instance.GetBeginnerCarnivalData();
		return beginnerCarnivalData != null && beginnerCarnivalData.GetTabRedDotShow(uId);
	}
}
