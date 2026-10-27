using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B7F RID: 19327
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidingBlocksGameServerData
	{
		// Token: 0x06032162 RID: 205154 RVA: 0x00BA1628 File Offset: 0x00B9F828
		public void Init(int instanceId, int historyScore, int[] historyReceivedRewardIds)
		{
			this.InstanceId = instanceId;
			this.HistoryReceivedRewardIds = historyReceivedRewardIds;
			this.HistoryScore = historyScore;
			AvoidBlockLevel? config = ConfigAvoidBlockLevelByInstId.GetConfig(instanceId, true);
			if (config == null)
			{
				return;
			}
			this.MainTitleTextKey = config.Value.MainTitleText;
			this.AchieveTextKey = config.Value.AchieveText;
			this.RewardTitleTextKey = config.Value.RewardTitleText;
		}

		// Token: 0x06032163 RID: 205155 RVA: 0x00BA169B File Offset: 0x00B9F89B
		public void Reset()
		{
			this.InstanceId = 0;
			this.MainTitleTextKey = null;
			this.RewardTitleTextKey = null;
			this.HistoryScore = 0;
		}

		// Token: 0x0401AAE0 RID: 109280
		[Nullable(2)]
		public string MainTitleTextKey;

		// Token: 0x0401AAE1 RID: 109281
		[Nullable(2)]
		public string AchieveTextKey;

		// Token: 0x0401AAE2 RID: 109282
		[Nullable(2)]
		public string RewardTitleTextKey;

		// Token: 0x0401AAE3 RID: 109283
		public bool IsWin;

		// Token: 0x0401AAE4 RID: 109284
		public int HistoryScore;

		// Token: 0x0401AAE5 RID: 109285
		public List<TItem> RewardList = new List<TItem>();

		// Token: 0x0401AAE6 RID: 109286
		public int InstanceId;

		// Token: 0x0401AAE7 RID: 109287
		public int[] HistoryReceivedRewardIds = Array.Empty<int>();
	}
}
