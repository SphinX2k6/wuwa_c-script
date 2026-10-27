using System;
using CSharpScript.Game.Common.Event;

// Token: 0x02003347 RID: 13127
public class RedDotActivityRegressCultivate : RedDotBase
{
	// Token: 0x0601C990 RID: 117136 RVA: 0x0080482B File Offset: 0x00802A2B
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C991 RID: 117137 RVA: 0x00804849 File Offset: 0x00802A49
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.RecallActivityInfoUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601C992 RID: 117138 RVA: 0x00804867 File Offset: 0x00802A67
	protected override bool OnCheck(int uId = 0)
	{
		return ActivityRegressModel.Instance.ActivityData.HasReachableCultivateTask();
	}
}
