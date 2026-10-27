using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.VillageInfr;

// Token: 0x0200344D RID: 13389
public class RedDotVillageInfrTask : RedDotBase
{
	// Token: 0x0601CE4D RID: 118349 RVA: 0x0080E06B File Offset: 0x0080C26B
	protected override ERedDotName? OnGetParentName()
	{
		return new ERedDotName?(ERedDotName.VillageInfr);
	}

	// Token: 0x0601CE4E RID: 118350 RVA: 0x0080E077 File Offset: 0x0080C277
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.VillageInfrActivityTaskDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.VillageInfrScoreRewardDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CE4F RID: 118351 RVA: 0x0080E0B1 File Offset: 0x0080C2B1
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.VillageInfrActivityTaskDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Remove(EEventName.VillageInfrScoreRewardDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CE50 RID: 118352 RVA: 0x0080E0EB File Offset: 0x0080C2EB
	protected override bool OnCheck(int uId = 0)
	{
		return VillageInfrModel.Instance.GetTaskRedDot() || VillageInfrModel.Instance.HasScoreReward();
	}
}
