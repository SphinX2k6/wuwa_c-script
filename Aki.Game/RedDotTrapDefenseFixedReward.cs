using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x020029BD RID: 10685
public class RedDotTrapDefenseFixedReward : RedDotBase
{
	// Token: 0x0601AB39 RID: 109369 RVA: 0x00834567 File Offset: 0x00832767
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefense);
	}

	// Token: 0x0601AB3A RID: 109370 RVA: 0x00834573 File Offset: 0x00832773
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseFixedReward, new Action(base.EventCheck));
	}

	// Token: 0x0601AB3B RID: 109371 RVA: 0x00834591 File Offset: 0x00832791
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseFixedReward, new Action(base.EventCheck));
	}

	// Token: 0x0601AB3C RID: 109372 RVA: 0x008345AF File Offset: 0x008327AF
	protected override bool OnCheck(int uId = 0)
	{
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		return instance != null && instance.RewardData.RedDotFixedReward();
	}
}
