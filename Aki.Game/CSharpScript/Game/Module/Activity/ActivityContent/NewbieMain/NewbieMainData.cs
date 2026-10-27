using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x0200637D RID: 25469
	[NullableContext(1)]
	[Nullable(0)]
	public class NewbieMainData : ActivityBaseData
	{
		// Token: 0x17009351 RID: 37713
		// (get) Token: 0x060400FB RID: 262395 RVA: 0x00F7FF78 File Offset: 0x00F7E178
		public int ProgressScore
		{
			get
			{
				return this.ProgressScoreInternal;
			}
		}

		// Token: 0x060400FC RID: 262396 RVA: 0x00F7FF80 File Offset: 0x00F7E180
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

		// Token: 0x060400FD RID: 262397 RVA: 0x00F7FFBC File Offset: 0x00F7E1BC
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

		// Token: 0x060400FE RID: 262398 RVA: 0x00F80038 File Offset: 0x00F7E238
		private void ParseTakenRewards(IList<int> ids)
		{
			this.TakenScoreRewardIds = new HashSet<int>(ids ?? new List<int>());
		}

		// Token: 0x060400FF RID: 262399 RVA: 0x00F80050 File Offset: 0x00F7E250
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

		// Token: 0x06040100 RID: 262400 RVA: 0x00F800D4 File Offset: 0x00F7E2D4
		public void UpdateProgressScore(int score)
		{
			this.ProgressScoreInternal = score;
		}

		// Token: 0x06040101 RID: 262401 RVA: 0x00F800E0 File Offset: 0x00F7E2E0
		public void AddTakenScoreRewardIds(IList<int> ids)
		{
			foreach (int item in ids)
			{
				this.TakenScoreRewardIds.Add(item);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06040102 RID: 262402 RVA: 0x00F80144 File Offset: 0x00F7E344
		public bool IsScoreRewardTaken(int rewardId)
		{
			return this.TakenScoreRewardIds.Contains(rewardId);
		}

		// Token: 0x06040103 RID: 262403 RVA: 0x00F80152 File Offset: 0x00F7E352
		public HashSet<int> GetTakenScoreRewardIds()
		{
			return this.TakenScoreRewardIds;
		}

		// Token: 0x06040104 RID: 262404 RVA: 0x00F8015C File Offset: 0x00F7E35C
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

		// Token: 0x06040105 RID: 262405 RVA: 0x00F8017C File Offset: 0x00F7E37C
		public Dictionary<int, NewbieMainTabData> GetAllTabData()
		{
			return this.TabDataMap;
		}

		// Token: 0x06040106 RID: 262406 RVA: 0x00F80184 File Offset: 0x00F7E384
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

		// Token: 0x06040107 RID: 262407 RVA: 0x00F80208 File Offset: 0x00F7E408
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

		// Token: 0x04021617 RID: 136727
		private readonly Dictionary<int, NewbieMainTabData> TabDataMap = new Dictionary<int, NewbieMainTabData>();

		// Token: 0x04021618 RID: 136728
		private HashSet<int> TakenScoreRewardIds = new HashSet<int>();

		// Token: 0x04021619 RID: 136729
		private int ProgressScoreInternal;
	}
}
