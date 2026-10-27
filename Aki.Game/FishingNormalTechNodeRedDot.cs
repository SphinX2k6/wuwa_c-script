using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;

// Token: 0x02003385 RID: 13189
public class FishingNormalTechNodeRedDot : RedDotBase
{
	// Token: 0x0601CAAF RID: 117423 RVA: 0x008069D5 File Offset: 0x00804BD5
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FishingNormalTech);
	}

	// Token: 0x0601CAB0 RID: 117424 RVA: 0x008069E1 File Offset: 0x00804BE1
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFishingTechNodeRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnFishingTechNodeRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAB1 RID: 117425 RVA: 0x00806A1B File Offset: 0x00804C1B
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnFishingTechNodeRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnFishingTechNodeRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CAB2 RID: 117426 RVA: 0x00806A58 File Offset: 0x00804C58
	protected override bool OnCheck(int uId = 0)
	{
		FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(uId);
		return fishingTechById.Type != 4 && fishingTechById.Type != 5 && FishingModel.Instance.GetTechNodeCanLevelUp(uId);
	}
}
