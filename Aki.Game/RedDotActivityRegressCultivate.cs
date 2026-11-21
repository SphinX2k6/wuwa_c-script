using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028B9 RID: 10425
public class RedDotActivityRegressCultivate : RedDotBase
{
	// Token: 0x0601A688 RID: 108168 RVA: 0x0082ADEF File Offset: 0x00828FEF
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A689 RID: 108169 RVA: 0x0082AE0D File Offset: 0x0082900D
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A68A RID: 108170 RVA: 0x0082AE2B File Offset: 0x0082902B
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityRegressModel.Instance.ActivityData.HasReachableCultivateTask();
	}
}
