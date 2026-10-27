using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.TrapDefense;

// Token: 0x0200344A RID: 13386
public class RedDotTrapDefenseLimitReward : RedDotBase
{
	// Token: 0x0601CE3E RID: 118334 RVA: 0x0080DEE6 File Offset: 0x0080C0E6
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.TrapDefense);
	}

	// Token: 0x0601CE3F RID: 118335 RVA: 0x0080DEF2 File Offset: 0x0080C0F2
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RedDotUpdateTrapDefenseLimitReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CE40 RID: 118336 RVA: 0x0080DF10 File Offset: 0x0080C110
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RedDotUpdateTrapDefenseLimitReward, new Action(base.EventCheck));
	}

	// Token: 0x0601CE41 RID: 118337 RVA: 0x0080DF2E File Offset: 0x0080C12E
	protected override bool OnCheck(int uId = 0)
	{
		TrapDefenseModel instance = TrapDefenseModel.Instance;
		return instance != null && instance.RewardData.RedDotLimitReward();
	}
}
