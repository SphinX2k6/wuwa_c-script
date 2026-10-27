using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033C0 RID: 13248
public class RedDotMoonChasingBuilding : RedDotBase
{
	// Token: 0x0601CBB2 RID: 117682 RVA: 0x00808B1F File Offset: 0x00806D1F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.TrackMoonHandbookUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.MoonChasingRefreshBuildingRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CBB3 RID: 117683 RVA: 0x00808B59 File Offset: 0x00806D59
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.TrackMoonHandbookUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.MoonChasingRefreshBuildingRedDot, new Action(base.EventCheck));
	}

	// Token: 0x0601CBB4 RID: 117684 RVA: 0x00808B93 File Offset: 0x00806D93
	protected override bool OnCheck(int uId = 0)
	{
		ActivityMoonChasingController.Instance.RefreshActivityRedDot();
		return MoonChasingBuildingModel.Instance.CheckAllBuildingRedDotState();
	}
}
