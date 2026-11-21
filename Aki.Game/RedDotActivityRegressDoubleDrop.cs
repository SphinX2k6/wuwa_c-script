using System;
using CSharpScript.Game.Common.Event;

// Token: 0x020028BB RID: 10427
public class RedDotActivityRegressDoubleDrop : RedDotBase
{
	// Token: 0x0601A690 RID: 108176 RVA: 0x0082AE9F File Offset: 0x0082909F
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A691 RID: 108177 RVA: 0x0082AEBD File Offset: 0x008290BD
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A692 RID: 108178 RVA: 0x0082AEDB File Offset: 0x008290DB
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityRegressModel.Instance.ActivityData.CheckDoubleDropRedDot();
	}
}
