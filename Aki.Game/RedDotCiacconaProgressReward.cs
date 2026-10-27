using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.CiacconaGal;

// Token: 0x02003373 RID: 13171
public class RedDotCiacconaProgressReward : RedDotBase
{
	// Token: 0x0601CA53 RID: 117331 RVA: 0x00805F94 File Offset: 0x00804194
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.OnCiacconaRewardDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CA54 RID: 117332 RVA: 0x00805FB2 File Offset: 0x008041B2
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnCiacconaRewardDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CA55 RID: 117333 RVA: 0x00805FD0 File Offset: 0x008041D0
	protected override bool OnCheck(int uId = 0)
	{
		return CiacconaGalModel.Instance.HasAnyProgressReward();
	}
}
