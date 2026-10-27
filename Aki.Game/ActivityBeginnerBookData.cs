using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200118F RID: 4495
[NullableContext(1)]
[Nullable(0)]
public class ActivityBeginnerBookData : ActivityBaseData
{
	// Token: 0x060076FB RID: 30459 RVA: 0x0018C76C File Offset: 0x0018A96C
	protected override void PhraseEx(ActivityData data)
	{
		this.AllBeginnerTargetList.Clear();
		ActivityBeginnerBookConfig instance = ActivityBeginnerBookConfig.Instance;
		List<WorldNewJourney> list = ConfigCommon.ToList<WorldNewJourney>((instance != null) ? instance.GetAllActivityBeginnerConfig() : null);
		if (list != null)
		{
			list.Sort((WorldNewJourney a, WorldNewJourney b) => a.Sort - b.Sort);
			foreach (WorldNewJourney worldNewJourney in list)
			{
				this.AllBeginnerTargetList.Add(worldNewJourney.Id);
			}
		}
	}

	// Token: 0x060076FC RID: 30460 RVA: 0x0018C810 File Offset: 0x0018AA10
	protected override bool GetExDataFinishShowState()
	{
		foreach (int beginnerId in this.AllBeginnerTargetList)
		{
			if (!this.GetFinishState(beginnerId))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060076FD RID: 30461 RVA: 0x0018C86C File Offset: 0x0018AA6C
	public bool GetEnableJump(int beginnerId)
	{
		ActivityBeginnerBookConfig instance = ActivityBeginnerBookConfig.Instance;
		bool flag;
		return (instance != null && instance.GetActivityBeginnerConfig(beginnerId).ConditionId == 0) || (this.UnLockBeginnerMap.TryGetValue(beginnerId, out flag) && flag);
	}

	// Token: 0x060076FE RID: 30462 RVA: 0x0018C8B0 File Offset: 0x0018AAB0
	public bool GetFinishState(int beginnerId)
	{
		bool flag;
		return this.FinishBeginnerMap.TryGetValue(beginnerId, out flag) && flag;
	}

	// Token: 0x0400368A RID: 13962
	public List<int> AllBeginnerTargetList = new List<int>();

	// Token: 0x0400368B RID: 13963
	public Dictionary<int, bool> UnLockBeginnerMap = new Dictionary<int, bool>();

	// Token: 0x0400368C RID: 13964
	public Dictionary<int, bool> FinishBeginnerMap = new Dictionary<int, bool>();
}
