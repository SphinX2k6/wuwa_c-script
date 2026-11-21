using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x020029BE RID: 10686
public class RedDotTrapDefenseLimitReward : RedDotBase
{
	// Token: 0x0601AB3E RID: 109374 RVA: 0x008345CE File Offset: 0x008327CE
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefense);
	}

	// Token: 0x0601AB3F RID: 109375 RVA: 0x008345DA File Offset: 0x008327DA
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseLimitReward, new Action(base.EventCheck));
	}

	// Token: 0x0601AB40 RID: 109376 RVA: 0x008345F8 File Offset: 0x008327F8
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseLimitReward, new Action(base.EventCheck));
	}

	// Token: 0x0601AB41 RID: 109377 RVA: 0x00834616 File Offset: 0x00832816
	protected override bool OnCheck(int uId = 0)
	{
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		return instance != null && instance.RewardData.RedDotLimitReward();
	}
}
