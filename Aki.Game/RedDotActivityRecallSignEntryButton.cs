using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028B2 RID: 10418
public class RedDotActivityRecallSignEntryButton : RedDotBase
{
	// Token: 0x0601A66D RID: 108141 RVA: 0x0082AAF7 File Offset: 0x00828CF7
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A66E RID: 108142 RVA: 0x0082AB15 File Offset: 0x00828D15
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A66F RID: 108143 RVA: 0x0082AB33 File Offset: 0x00828D33
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityRegressModel.Instance.HasSignRewardCanClaimed();
	}
}
