using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x0200654F RID: 25935
	[NullableContext(1)]
	[Nullable(0)]
	public class LinkageRewardActivityData : ActivityBaseData
	{
		// Token: 0x06040FF2 RID: 266226 RVA: 0x00FC0070 File Offset: 0x00FBE270
		protected override void PhraseEx(ActivityData data)
		{
			this.NormalRewardDataMap.Clear();
			this.KeepRewardDataMap.Clear();
			LinkageCheckInActivityData linkageCheckInActivityData = data.LinkageCheckInActivityData;
			if (linkageCheckInActivityData == null)
			{
				return;
			}
			int checkInDay = linkageCheckInActivityData.CheckInDay;
			this.CurrentCheckInDay = checkInDay;
			HashSet<int> hashSet = new HashSet<int>(linkageCheckInActivityData.NormalReward);
			HashSet<int> hashSet2 = new HashSet<int>(linkageCheckInActivityData.KeepReward);
			IReadOnlyList<LinkageReward> listByActivityId = LinkageRewardActivityConfig.Instance.GetListByActivityId(base.Id);
			if (listByActivityId == null || listByActivityId.Count == 0)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
				return;
			}
			List<LinkageReward> list = new List<LinkageReward>(listByActivityId);
			list.Sort((LinkageReward a, LinkageReward b) => a.Id.CompareTo(b.Id));
			for (int i = 0; i < list.Count; i++)
			{
				LinkageReward linkageReward = list[i];
				int requiredCheckInDay = LinkageRewardActivityData.GetRequiredCheckInDay(i);
				TimePointRewardData timePointRewardData = new TimePointRewardData
				{
					Id = linkageReward.Id,
					RewardTime = (long)requiredCheckInDay,
					HasClaimed = hashSet.Contains(linkageReward.Id)
				};
				timePointRewardData.HasUnlock = (!timePointRewardData.HasClaimed && checkInDay >= requiredCheckInDay);
				this.NormalRewardDataMap[linkageReward.Id] = timePointRewardData;
				if (linkageReward.KeepDropId > 0)
				{
					TimePointRewardData timePointRewardData2 = new TimePointRewardData
					{
						Id = linkageReward.Id,
						RewardTime = (long)requiredCheckInDay,
						HasClaimed = hashSet2.Contains(linkageReward.Id)
					};
					timePointRewardData2.HasUnlock = (!timePointRewardData2.HasClaimed && checkInDay >= requiredCheckInDay);
					this.KeepRewardDataMap[linkageReward.Id] = timePointRewardData2;
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06040FF3 RID: 266227 RVA: 0x00FC0237 File Offset: 0x00FBE437
		private static int GetRequiredCheckInDay(int sortedIndex)
		{
			return sortedIndex + 1;
		}

		// Token: 0x06040FF4 RID: 266228 RVA: 0x00FC023C File Offset: 0x00FBE43C
		public override bool GetExDataRedPointShowState()
		{
			return this.IsExitsRewardToGet();
		}

		// Token: 0x06040FF5 RID: 266229 RVA: 0x00FC0244 File Offset: 0x00FBE444
		protected override bool GetExDataFinishShowState()
		{
			return this.IsAllRewardsClaimed();
		}

		// Token: 0x06040FF6 RID: 266230 RVA: 0x00FC024C File Offset: 0x00FBE44C
		private bool IsAllRewardsClaimed()
		{
			if (this.NormalRewardDataMap.Count <= 0)
			{
				return false;
			}
			using (Dictionary<int, TimePointRewardData>.ValueCollection.Enumerator enumerator = this.NormalRewardDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState != ETimePointRewardState.UnlockAndClaimed)
					{
						return false;
					}
				}
			}
			using (Dictionary<int, TimePointRewardData>.ValueCollection.Enumerator enumerator = this.KeepRewardDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState != ETimePointRewardState.UnlockAndClaimed)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06040FF7 RID: 266231 RVA: 0x00FC0308 File Offset: 0x00FBE508
		private bool IsExitsRewardToGet()
		{
			using (Dictionary<int, TimePointRewardData>.ValueCollection.Enumerator enumerator = this.NormalRewardDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState == ETimePointRewardState.UnlockAndUnClaimed)
					{
						return true;
					}
				}
			}
			using (Dictionary<int, TimePointRewardData>.ValueCollection.Enumerator enumerator = this.KeepRewardDataMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState == ETimePointRewardState.UnlockAndUnClaimed)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06040FF8 RID: 266232 RVA: 0x00FC03B4 File Offset: 0x00FBE5B4
		public void SetRewardsToGotState(IReadOnlyList<int> ids, LinkageCheckInType linkageCheckInType)
		{
			bool flag = false;
			Dictionary<int, TimePointRewardData> dictionary = (linkageCheckInType == LinkageCheckInType.KeepCheckIn) ? this.KeepRewardDataMap : this.NormalRewardDataMap;
			foreach (int key in ids)
			{
				TimePointRewardData timePointRewardData;
				if (dictionary.TryGetValue(key, out timePointRewardData) && !timePointRewardData.HasClaimed)
				{
					timePointRewardData.HasClaimed = true;
					flag = true;
				}
			}
			if (!flag)
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06040FF9 RID: 266233 RVA: 0x00FC0444 File Offset: 0x00FBE644
		public void RevertOptimisticClaimReward(IReadOnlyList<int> ids, LinkageCheckInType linkageCheckInType)
		{
			bool flag = false;
			Dictionary<int, TimePointRewardData> dictionary = (linkageCheckInType == LinkageCheckInType.KeepCheckIn) ? this.KeepRewardDataMap : this.NormalRewardDataMap;
			foreach (int key in ids)
			{
				TimePointRewardData timePointRewardData;
				if (dictionary.TryGetValue(key, out timePointRewardData) && timePointRewardData.HasClaimed)
				{
					timePointRewardData.HasClaimed = false;
					flag = true;
				}
			}
			if (!flag)
			{
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06040FFA RID: 266234 RVA: 0x00FC04D4 File Offset: 0x00FBE6D4
		public int[] GetUnlockUnclaimedRewardIds(LinkageCheckInType linkageCheckInType)
		{
			Dictionary<int, TimePointRewardData> dictionary = (linkageCheckInType == LinkageCheckInType.KeepCheckIn) ? this.KeepRewardDataMap : this.NormalRewardDataMap;
			List<int> list = new List<int>();
			foreach (TimePointRewardData timePointRewardData in dictionary.Values)
			{
				if (timePointRewardData.RewardState == ETimePointRewardState.UnlockAndUnClaimed)
				{
					list.Add(timePointRewardData.Id);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06040FFB RID: 266235 RVA: 0x00FC0554 File Offset: 0x00FBE754
		public List<TimePointRewardData> GetRewardDataList()
		{
			List<TimePointRewardData> list = new List<TimePointRewardData>(this.NormalRewardDataMap.Values);
			list.Sort((TimePointRewardData a, TimePointRewardData b) => a.Id.CompareTo(b.Id));
			return list;
		}

		// Token: 0x06040FFC RID: 266236 RVA: 0x00FC058B File Offset: 0x00FBE78B
		public List<TimePointRewardData> GetKeepRewardDataList()
		{
			List<TimePointRewardData> list = new List<TimePointRewardData>(this.KeepRewardDataMap.Values);
			list.Sort((TimePointRewardData a, TimePointRewardData b) => a.Id.CompareTo(b.Id));
			return list;
		}

		// Token: 0x06040FFD RID: 266237 RVA: 0x00FC05C2 File Offset: 0x00FBE7C2
		public int GetCurrentCheckInDay()
		{
			return this.CurrentCheckInDay;
		}

		// Token: 0x04021E3A RID: 138810
		private readonly Dictionary<int, TimePointRewardData> NormalRewardDataMap = new Dictionary<int, TimePointRewardData>();

		// Token: 0x04021E3B RID: 138811
		private readonly Dictionary<int, TimePointRewardData> KeepRewardDataMap = new Dictionary<int, TimePointRewardData>();

		// Token: 0x04021E3C RID: 138812
		private int CurrentCheckInDay;
	}
}
