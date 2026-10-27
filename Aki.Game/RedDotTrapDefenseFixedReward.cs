using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x02003449 RID: 13385
public class RedDotTrapDefenseFixedReward : RedDotBase
{
	// Token: 0x0601CE39 RID: 118329 RVA: 0x0080DE7F File Offset: 0x0080C07F
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefense);
	}

	// Token: 0x0601CE3A RID: 118330 RVA: 0x0080DE8B File Offset: 0x0080C08B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseFixedReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CE3B RID: 118331 RVA: 0x0080DEA9 File Offset: 0x0080C0A9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseFixedReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CE3C RID: 118332 RVA: 0x0080DEC7 File Offset: 0x0080C0C7
	protected override bool OnCheck(int uId = 0)
	{
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		return instance != null && instance.RewardData.RedDotFixedReward();
	}
}
