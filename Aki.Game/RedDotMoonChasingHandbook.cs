using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002934 RID: 10548
public class RedDotMoonChasingHandbook : RedDotBase
{
	// Token: 0x0601A8B2 RID: 108722 RVA: 0x0082F1C5 File Offset: 0x0082D3C5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.TrackMoonHandbookUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8B3 RID: 108723 RVA: 0x0082F1E3 File Offset: 0x0082D3E3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.TrackMoonHandbookUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A8B4 RID: 108724 RVA: 0x0082F201 File Offset: 0x0082D401
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return false;
	}
}
