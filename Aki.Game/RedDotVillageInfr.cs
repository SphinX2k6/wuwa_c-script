using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.VillageInfr;

// Token: 0x0200344C RID: 13388
public class RedDotVillageInfr : RedDotBase
{
	// Token: 0x0601CE49 RID: 118345 RVA: 0x0080DFB0 File Offset: 0x0080C1B0
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.VillageInfrVillageDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.VillageInfrActivityTaskDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.VillageInfrScoreRewardDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CE4A RID: 118346 RVA: 0x0080E011 File Offset: 0x0080C211
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.VillageInfrVillageDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601CE4B RID: 118347 RVA: 0x0080E030 File Offset: 0x0080C230
	protected override bool OnCheck(int uId = 0)
	{
		VillageInfrModel instance = VillageInfrModel.Instance;
		return instance.HasTreeCanLevelUp() || instance.GetCanVillageLevelUp() || instance.HasScoreReward() || instance.GetTaskRedDot();
	}
}
