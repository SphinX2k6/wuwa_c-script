using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B29 RID: 15145
	[NullableContext(1)]
	[Nullable(0)]
	public class SlidingBlocksGameServerData
	{
		// Token: 0x06026EF3 RID: 159475 RVA: 0x00AE57B8 File Offset: 0x00AE39B8
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

		// Token: 0x06026EF4 RID: 159476 RVA: 0x00AE582B File Offset: 0x00AE3A2B
		public void Reset()
		{
			this.InstanceId = 0;
			this.MainTitleTextKey = null;
			this.RewardTitleTextKey = null;
			this.HistoryScore = 0;
		}

		// Token: 0x04015434 RID: 87092
		[Nullable(2)]
		public string MainTitleTextKey;

		// Token: 0x04015435 RID: 87093
		[Nullable(2)]
		public string AchieveTextKey;

		// Token: 0x04015436 RID: 87094
		[Nullable(2)]
		public string RewardTitleTextKey;

		// Token: 0x04015437 RID: 87095
		public bool IsWin;

		// Token: 0x04015438 RID: 87096
		public int HistoryScore;

		// Token: 0x04015439 RID: 87097
		public List<TItem> RewardList = new List<TItem>();

		// Token: 0x0401543A RID: 87098
		public int InstanceId;

		// Token: 0x0401543B RID: 87099
		public int[] HistoryReceivedRewardIds = Array.Empty<int>();
	}
}
