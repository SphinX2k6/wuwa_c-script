using System;
using CSharpScript.Game.Common.Event;

// Token: 0x0200291C RID: 10524
public class RedDotInfluenceReward : RedDotBase
{
	// Token: 0x0601A846 RID: 108614 RVA: 0x0082E351 File Offset: 0x0082C551
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.InfluenceReputation);
	}

	// Token: 0x0601A847 RID: 108615 RVA: 0x0082E35A File Offset: 0x0082C55A
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601A848 RID: 108616 RVA: 0x0082E35D File Offset: 0x0082C55D
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RedDotInfluence, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A849 RID: 108617 RVA: 0x0082E397 File Offset: 0x0082C597
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RedDotInfluence, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601A84A RID: 108618 RVA: 0x0082E3D1 File Offset: 0x0082C5D1
	protected override bool OnCheck(int uId = 0)
	{
		return InfluenceReputationModel.Instance.RedDotInfluenceRewardCondition(uId);
	}
}
