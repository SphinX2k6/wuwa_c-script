using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02002932 RID: 10546
public class RedDotMoonChasingBuilding : RedDotBase
{
	// Token: 0x0601A8AA RID: 108714 RVA: 0x0082F0E3 File Offset: 0x0082D2E3
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.TrackMoonHandbookUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshBuildingRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A8AB RID: 108715 RVA: 0x0082F11D File Offset: 0x0082D31D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.TrackMoonHandbookUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshBuildingRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601A8AC RID: 108716 RVA: 0x0082F157 File Offset: 0x0082D357
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return MoonChasingBuildingModel.Instance.CheckAllBuildingRedDotState();
	}
}
