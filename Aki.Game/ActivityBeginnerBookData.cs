using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000643 RID: 1603
[NullableContext(1)]
[Nullable(0)]
public class ActivityBeginnerBookData : ActivityBaseData
{
	// Token: 0x06004A92 RID: 19090 RVA: 0x0019534C File Offset: 0x0019354C
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

	// Token: 0x06004A93 RID: 19091 RVA: 0x001953F0 File Offset: 0x001935F0
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

	// Token: 0x06004A94 RID: 19092 RVA: 0x0019544C File Offset: 0x0019364C
	public bool GetEnableJump(int beginnerId)
	{
		ActivityBeginnerBookConfig instance = ActivityBeginnerBookConfig.Instance;
		bool flag;
		return (instance != null && instance.GetActivityBeginnerConfig(beginnerId).ConditionId == 0) || (this.UnLockBeginnerMap.TryGetValue(beginnerId, out flag) && flag);
	}

	// Token: 0x06004A95 RID: 19093 RVA: 0x00195490 File Offset: 0x00193690
	public bool GetFinishState(int beginnerId)
	{
		bool flag;
		return this.FinishBeginnerMap.TryGetValue(beginnerId, out flag) && flag;
	}

	// Token: 0x04003723 RID: 14115
	public List<int> AllBeginnerTargetList = new List<int>();

	// Token: 0x04003724 RID: 14116
	public Dictionary<int, bool> UnLockBeginnerMap = new Dictionary<int, bool>();

	// Token: 0x04003725 RID: 14117
	public Dictionary<int, bool> FinishBeginnerMap = new Dictionary<int, bool>();
}
