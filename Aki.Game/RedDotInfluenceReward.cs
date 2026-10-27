using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020033AA RID: 13226
public class RedDotInfluenceReward : RedDotBase
{
	// Token: 0x0601CB4E RID: 117582 RVA: 0x00807D8D File Offset: 0x00805F8D
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.InfluenceReputation);
	}

	// Token: 0x0601CB4F RID: 117583 RVA: 0x00807D96 File Offset: 0x00805F96
	protected override bool IsMultiple()
	{
		return true;
	}

	// Token: 0x0601CB50 RID: 117584 RVA: 0x00807D99 File Offset: 0x00805F99
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Add<int>(EEventName.RedDotInfluence, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CB51 RID: 117585 RVA: 0x00807DD3 File Offset: 0x00805FD3
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotRefreshItemData, new Action(base.EventCheck));
		EventSystem.Instance.Remove<int>(EEventName.RedDotInfluence, new Action<int>(base.EventCheckWithUid));
	}

	// Token: 0x0601CB52 RID: 117586 RVA: 0x00807E0D File Offset: 0x0080600D
	protected override bool OnCheck(int uId = 0)
	{
		return InfluenceReputationModel.Instance.RedDotInfluenceRewardCondition(uId);
	}
}
