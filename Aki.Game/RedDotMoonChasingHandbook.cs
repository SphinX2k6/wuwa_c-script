using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033C2 RID: 13250
public class RedDotMoonChasingHandbook : RedDotBase
{
	// Token: 0x0601CBBA RID: 117690 RVA: 0x00808C01 File Offset: 0x00806E01
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.TrackMoonHandbookUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CBBB RID: 117691 RVA: 0x00808C1F File Offset: 0x00806E1F
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.TrackMoonHandbookUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CBBC RID: 117692 RVA: 0x00808C3D File Offset: 0x00806E3D
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return false;
	}
}
