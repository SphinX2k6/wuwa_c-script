using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;

// Token: 0x02003386 RID: 13190
public class FishingRoleTechNodeRedDot : RedDotBase
{
	// Token: 0x0601CAB4 RID: 117428 RVA: 0x00806A9A File Offset: 0x00804C9A
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFishingTechNodeRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnFishingTechNodeRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAB5 RID: 117429 RVA: 0x00806AD4 File Offset: 0x00804CD4
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnFishingTechNodeRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnFishingTechNodeRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAB6 RID: 117430 RVA: 0x00806B0E File Offset: 0x00804D0E
	protected override bool OnCheck(int uId = 0)
	{
		return FishingModel.Instance.GetTechNodeCanLevelUp(uId);
	}
}
