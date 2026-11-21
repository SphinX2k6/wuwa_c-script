using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;

// Token: 0x020028F7 RID: 10487
public class FishingNormalTechNodeRedDot : RedDotBase
{
	// Token: 0x0601A7A7 RID: 108455 RVA: 0x0082CF99 File Offset: 0x0082B199
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.FishingNormalTech);
	}

	// Token: 0x0601A7A8 RID: 108456 RVA: 0x0082CFA5 File Offset: 0x0082B1A5
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add<int>(EEventName.OnFishingTechNodeRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Add<int>(EEventName.OnFishingTechNodeRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7A9 RID: 108457 RVA: 0x0082CFDF File Offset: 0x0082B1DF
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnFishingTechNodeRefresh, new Action<int>(base.EventCheckWithUid));
		EventSystem.Instance.Remove<int>(EEventName.OnFishingTechNodeRedDotRefresh, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A7AA RID: 108458 RVA: 0x0082D01C File Offset: 0x0082B21C
	protected override bool OnCheck(int uId = 0)
	{
		FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(uId);
		return fishingTechById.Type != 4 && fishingTechById.Type != 5 && FishingModel.Instance.GetTechNodeCanLevelUp(uId);
	}
}
