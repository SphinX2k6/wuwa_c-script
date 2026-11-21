using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x020052FB RID: 21243
	[NullableContext(1)]
	[Nullable(0)]
	public class NewbieMainData : ActivityBaseData
	{
		// Token: 0x170066B3 RID: 26291
		// (get) Token: 0x06034DBC RID: 216508 RVA: 0x00EC6EDC File Offset: 0x00EC50DC
		public int ProgressScore
		{
			get
			{
				return this.ProgressScoreInternal;
			}
		}

		// Token: 0x06034DBD RID: 216509 RVA: 0x00EC6EE4 File Offset: 0x00EC50E4
		protected override void PhraseEx(ActivityData data)
		{
			NewbieMainActivityPb newbieMainActivityPb = data.NewbieMainActivityPb;
			if (newbieMainActivityPb == null)
			{
				return;
			}
			this.ParseTabs(newbieMainActivityPb.NewbieMainTabs);
			this.ParseTakenRewards(newbieMainActivityPb.TakenScoreRewardIds);
			this.ProgressScoreInternal = newbieMainActivityPb.ProgressScore;
		}

		// Token: 0x06034DBE RID: 216510 RVA: 0x00EC6F20 File Offset: 0x00EC5120
		private void ParseTabs(IList<NewbieMainTabPb> tabs)
		{
			this.TabDataMap.Clear();
			if (tabs == null)
			{
				return;
			}
			foreach (NewbieMainTabPb newbieMainTabPb in tabs)
			{
				NewbieMainTabData newbieMainTabData = new NewbieMainTabData(newbieMainTabPb.TabId);
				newbieMainTabData.SetCompletedTaskIds(newbieMainTabPb.CompletedTaskIds);
				this.TabDataMap[newbieMainTabPb.TabId] = newbieMainTabData;
			}
		}

		// Token: 0x06034DBF RID: 216511 RVA: 0x00EC6F9C File Offset: 0x00EC519C
		private void ParseTakenRewards(IList<int> ids)
		{
			this.TakenScoreRewardIds = new HashSet<int>(ids ?? new List<int>());
		}

		// Token: 0x06034DC0 RID: 216512 RVA: 0x00EC6FB4 File Offset: 0x00EC51B4
		public void UpdateTabs(IList<NewbieMainTabPb> tabs)
		{
			if (tabs == null)
			{
				return;
			}
			foreach (NewbieMainTabPb newbieMainTabPb in tabs)
			{
				NewbieMainTabData newbieMainTabData;
				if (!this.TabDataMap.TryGetValue(newbieMainTabPb.TabId, out newbieMainTabData))
				{
					newbieMainTabData = new NewbieMainTabData(newbieMainTabPb.TabId);
					this.TabDataMap[newbieMainTabPb.TabId] = newbieMainTabData;
				}
				newbieMainTabData.SetCompletedTaskIds(newbieMainTabPb.CompletedTaskIds);
			}
		}

		// Token: 0x06034DC1 RID: 216513 RVA: 0x00EC7038 File Offset: 0x00EC5238
		public void UpdateProgressScore(int score)
		{
			this.ProgressScoreInternal = score;
		}

		// Token: 0x06034DC2 RID: 216514 RVA: 0x00EC7044 File Offset: 0x00EC5244
		public void AddTakenScoreRewardIds(IList<int> ids)
		{
			foreach (int item in ids)
			{
				this.TakenScoreRewardIds.Add(item);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06034DC3 RID: 216515 RVA: 0x00EC70A8 File Offset: 0x00EC52A8
		public bool IsScoreRewardTaken(int rewardId)
		{
			return this.TakenScoreRewardIds.Contains(rewardId);
		}

		// Token: 0x06034DC4 RID: 216516 RVA: 0x00EC70B6 File Offset: 0x00EC52B6
		public HashSet<int> GetTakenScoreRewardIds()
		{
			return this.TakenScoreRewardIds;
		}

		// Token: 0x06034DC5 RID: 216517 RVA: 0x00EC70C0 File Offset: 0x00EC52C0
		[NullableContext(2)]
		public NewbieMainTabData GetTabData(int tabId)
		{
			NewbieMainTabData result;
			if (!this.TabDataMap.TryGetValue(tabId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06034DC6 RID: 216518 RVA: 0x00EC70E0 File Offset: 0x00EC52E0
		public Dictionary<int, NewbieMainTabData> GetAllTabData()
		{
			return this.TabDataMap;
		}

		// Token: 0x06034DC7 RID: 216519 RVA: 0x00EC70E8 File Offset: 0x00EC52E8
		public override bool GetExDataRedPointShowState()
		{
			IReadOnlyList<NewbieMainActReward> rewardListByActivityId = NewbieMainConfig.Instance.GetRewardListByActivityId(base.Id);
			if (rewardListByActivityId == null)
			{
				return false;
			}
			foreach (NewbieMainActReward newbieMainActReward in rewardListByActivityId)
			{
				if (!this.TakenScoreRewardIds.Contains(newbieMainActReward.Id) && this.ProgressScoreInternal >= newbieMainActReward.Score)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06034DC8 RID: 216520 RVA: 0x00EC716C File Offset: 0x00EC536C
		protected override bool GetExDataFinishShowState()
		{
			IReadOnlyList<NewbieMainActReward> rewardListByActivityId = NewbieMainConfig.Instance.GetRewardListByActivityId(base.Id);
			if (rewardListByActivityId == null || rewardListByActivityId.Count == 0)
			{
				return false;
			}
			foreach (NewbieMainActReward newbieMainActReward in rewardListByActivityId)
			{
				if (!this.TakenScoreRewardIds.Contains(newbieMainActReward.Id))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0401BF46 RID: 114502
		private readonly Dictionary<int, NewbieMainTabData> TabDataMap = new Dictionary<int, NewbieMainTabData>();

		// Token: 0x0401BF47 RID: 114503
		private HashSet<int> TakenScoreRewardIds = new HashSet<int>();

		// Token: 0x0401BF48 RID: 114504
		private int ProgressScoreInternal;
	}
}
