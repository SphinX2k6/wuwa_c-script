using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x020054CD RID: 21709
	[NullableContext(1)]
	[Nullable(0)]
	public class LinkageRewardActivityData : ActivityBaseData
	{
		// Token: 0x06035CB7 RID: 220343 RVA: 0x00F07060 File Offset: 0x00F05260
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

		// Token: 0x06035CB8 RID: 220344 RVA: 0x00F07227 File Offset: 0x00F05427
		private static int GetRequiredCheckInDay(int sortedIndex)
		{
			return sortedIndex + 1;
		}

		// Token: 0x06035CB9 RID: 220345 RVA: 0x00F0722C File Offset: 0x00F0542C
		public override bool GetExDataRedPointShowState()
		{
			return this.IsExitsRewardToGet();
		}

		// Token: 0x06035CBA RID: 220346 RVA: 0x00F07234 File Offset: 0x00F05434
		protected override bool GetExDataFinishShowState()
		{
			return this.IsAllRewardsClaimed();
		}

		// Token: 0x06035CBB RID: 220347 RVA: 0x00F0723C File Offset: 0x00F0543C
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

		// Token: 0x06035CBC RID: 220348 RVA: 0x00F072F8 File Offset: 0x00F054F8
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

		// Token: 0x06035CBD RID: 220349 RVA: 0x00F073A4 File Offset: 0x00F055A4
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

		// Token: 0x06035CBE RID: 220350 RVA: 0x00F07434 File Offset: 0x00F05634
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

		// Token: 0x06035CBF RID: 220351 RVA: 0x00F074C4 File Offset: 0x00F056C4
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

		// Token: 0x06035CC0 RID: 220352 RVA: 0x00F07544 File Offset: 0x00F05744
		public List<TimePointRewardData> GetRewardDataList()
		{
			List<TimePointRewardData> list = new List<TimePointRewardData>(this.NormalRewardDataMap.Values);
			list.Sort((TimePointRewardData a, TimePointRewardData b) => a.Id.CompareTo(b.Id));
			return list;
		}

		// Token: 0x06035CC1 RID: 220353 RVA: 0x00F0757B File Offset: 0x00F0577B
		public List<TimePointRewardData> GetKeepRewardDataList()
		{
			List<TimePointRewardData> list = new List<TimePointRewardData>(this.KeepRewardDataMap.Values);
			list.Sort((TimePointRewardData a, TimePointRewardData b) => a.Id.CompareTo(b.Id));
			return list;
		}

		// Token: 0x06035CC2 RID: 220354 RVA: 0x00F075B2 File Offset: 0x00F057B2
		public int GetCurrentCheckInDay()
		{
			return this.CurrentCheckInDay;
		}

		// Token: 0x0401C76B RID: 116587
		private readonly Dictionary<int, TimePointRewardData> NormalRewardDataMap = new Dictionary<int, TimePointRewardData>();

		// Token: 0x0401C76C RID: 116588
		private readonly Dictionary<int, TimePointRewardData> KeepRewardDataMap = new Dictionary<int, TimePointRewardData>();

		// Token: 0x0401C76D RID: 116589
		private int CurrentCheckInDay;
	}
}
