using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;

// Token: 0x020028F8 RID: 10488
public class FishingRoleTechNodeRedDot : RedDotBase
{
	// Token: 0x0601A7AC RID: 108460 RVA: 0x0082D05E File Offset: 0x0082B25E
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFishingTechNodeRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnFishingTechNodeRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7AD RID: 108461 RVA: 0x0082D098 File Offset: 0x0082B298
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnFishingTechNodeRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnFishingTechNodeRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7AE RID: 108462 RVA: 0x0082D0D2 File Offset: 0x0082B2D2
	protected override bool OnCheck(int uId = 0)
	{
		return FishingModel.Instance.GetTechNodeCanLevelUp(uId);
	}
}
