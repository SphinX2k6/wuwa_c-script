using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.VillageInfr;

// Token: 0x020029C0 RID: 10688
public class RedDotVillageInfr : RedDotBase
{
	// Token: 0x0601AB49 RID: 109385 RVA: 0x00834698 File Offset: 0x00832898
	protected override void AddCheckEvent()
	{
		EventSystem.Instance.Add(EEventName.VillageInfrVillageDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.VillageInfrActivityTaskDataUpdate, new Action(base.EventCheck));
		EventSystem.Instance.Add(EEventName.VillageInfrScoreRewardDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AB4A RID: 109386 RVA: 0x008346F9 File Offset: 0x008328F9
	protected override void RemoveCheckEvent()
	{
		EventSystem.Instance.Remove(EEventName.VillageInfrVillageDataUpdate, new Action(base.EventCheck));
	}

	// Token: 0x0601AB4B RID: 109387 RVA: 0x00834718 File Offset: 0x00832918
	protected override bool OnCheck(int uId = 0)
	{
		VillageInfrModel instance = VillageInfrModel.Instance;
		return instance.HasTreeCanLevelUp() || instance.GetCanVillageLevelUp() || instance.HasScoreReward() || instance.GetTaskRedDot();
	}
}
