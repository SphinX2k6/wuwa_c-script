using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CiacconaGal;

// Token: 0x020028E5 RID: 10469
public class RedDotCiacconaProgressReward : RedDotBase
{
	// Token: 0x0601A74B RID: 108363 RVA: 0x0082C558 File Offset: 0x0082A758
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnCiacconaRewardDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A74C RID: 108364 RVA: 0x0082C576 File Offset: 0x0082A776
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnCiacconaRewardDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601A74D RID: 108365 RVA: 0x0082C594 File Offset: 0x0082A794
	protected override bool OnCheck(int uId = 0)
	{
		return CiacconaGalModel.Instance.HasAnyProgressReward();
	}
}
