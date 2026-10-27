using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A17 RID: 18967
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRewardData
	{
		// Token: 0x060313CD RID: 201677 RVA: 0x00B6ADF5 File Offset: 0x00B68FF5
		public static TrapDefenseRewardData Create(int activityId)
		{
			TrapDefenseRewardData trapDefenseRewardData = new TrapDefenseRewardData();
			trapDefenseRewardData.ActivityId = activityId;
			trapDefenseRewardData.Init();
			return trapDefenseRewardData;
		}

		// Token: 0x060313CE RID: 201678 RVA: 0x00B6AE0C File Offset: 0x00B6900C
		public void UpdateRewardsByServerData(TrapDefenseRewardInfo[] serverDataList)
		{
			foreach (TrapDefenseRewardInfo trapDefenseRewardInfo in serverDataList)
			{
				ConditionTask taskInfo = trapDefenseRewardInfo.TaskInfo;
				int key = (taskInfo != null) ? taskInfo.Id : 0;
				TrapDefenseRewardItemData trapDefenseRewardItemData;
				if (this.RewardDataMap.TryGetValue(key, out trapDefenseRewardItemData))
				{
					trapDefenseRewardItemData.UpdateByServerData(trapDefenseRewardInfo);
				}
			}
		}

		// Token: 0x060313CF RID: 201679 RVA: 0x00B6AE58 File Offset: 0x00B69058
		public void SetLimitTime(long beginTime, long endTime)
		{
			this.LimitBeginTime = beginTime;
			this.LimitEndTime = endTime;
		}

		// Token: 0x060313D0 RID: 201680 RVA: 0x00B6AE68 File Offset: 0x00B69068
		public void SetLimitTime(int beginTime, int endTime)
		{
			this.LimitBeginTime = (long)beginTime;
			this.LimitEndTime = (long)endTime;
		}

		// Token: 0x060313D1 RID: 201681 RVA: 0x00B6AE7C File Offset: 0x00B6907C
		public List<TrapDefenseRewardItemData> GetRewardListByType(ETrapDefenseRewardType type)
		{
			List<TrapDefenseRewardItemData> list;
			if (this.RewardTypeMap.TryGetValue(type, out list))
			{
				list.Sort(new Comparison<TrapDefenseRewardItemData>(this.RewardListSortFunc));
				return list;
			}
			return new List<TrapDefenseRewardItemData>();
		}

		// Token: 0x060313D2 RID: 201682 RVA: 0x00B6AEB4 File Offset: 0x00B690B4
		[NullableContext(0)]
		public ValueTuple<int, int> GetRewardProgressByType(ETrapDefenseRewardType type)
		{
			List<TrapDefenseRewardItemData> rewardListByType = this.GetRewardListByType(type);
			int num = 0;
			using (List<TrapDefenseRewardItemData>.Enumerator enumerator = rewardListByType.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State == ETrapDefenseRewardState.Claimed)
					{
						num++;
					}
				}
			}
			return new ValueTuple<int, int>(num, rewardListByType.Count);
		}

		// Token: 0x060313D3 RID: 201683 RVA: 0x00B6AF1C File Offset: 0x00B6911C
		[NullableContext(0)]
		public ValueTuple<int, int> GetLimitRewardTotalProgress()
		{
			int num = 0;
			int num2 = 0;
			for (int i = 1; i < 5; i++)
			{
				ETrapDefenseRewardType type = (ETrapDefenseRewardType)i;
				ValueTuple<int, int> rewardProgressByType = this.GetRewardProgressByType(type);
				int item = rewardProgressByType.Item1;
				int item2 = rewardProgressByType.Item2;
				num += item;
				num2 += item2;
			}
			num2++;
			int num3 = num;
			TrapDefenseSpecialRewardData specialRewardData = this.SpecialRewardData;
			num = num3 + (((specialRewardData != null && specialRewardData.State == ETrapDefenseRewardState.Claimed) > false) ? 1 : 0);
			return new ValueTuple<int, int>(num, num2);
		}

		// Token: 0x060313D4 RID: 201684 RVA: 0x00B6AF84 File Offset: 0x00B69184
		public string GetLimitRewardRemainTimeStr()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3((double)this.LimitEndTime * TimeUtil.Instance.Millisecond - serverTime);
			return ((remainTimeDataFormat != null) ? remainTimeDataFormat.CountDownText : null) ?? "";
		}

		// Token: 0x060313D5 RID: 201685 RVA: 0x00B6AFD0 File Offset: 0x00B691D0
		public bool IsOpenLimitReward()
		{
			double startTime = (double)this.LimitBeginTime * TimeUtil.Instance.Millisecond;
			double endTime = (double)this.LimitEndTime * TimeUtil.Instance.Millisecond;
			return TimeUtil.Instance.IsInTimeSpan(startTime, endTime);
		}

		// Token: 0x060313D6 RID: 201686 RVA: 0x00B6B010 File Offset: 0x00B69210
		public void RequestClaimRewardByType(ETrapDefenseRewardType type)
		{
			List<int> list = new List<int>();
			foreach (TrapDefenseRewardItemData trapDefenseRewardItemData in this.GetRewardListByType(type))
			{
				if (trapDefenseRewardItemData.State == ETrapDefenseRewardState.CanClaim)
				{
					list.Add(trapDefenseRewardItemData.Id);
				}
			}
			TrapDefenseController.Instance.RequestTrapDefenseRewardClaim(list);
		}

		// Token: 0x060313D7 RID: 201687 RVA: 0x00B6B084 File Offset: 0x00B69284
		public void RequestFixedReward()
		{
			List<int> list = new List<int>();
			foreach (TrapDefenseRewardItemData trapDefenseRewardItemData in this.FixedRewardDataList)
			{
				if (trapDefenseRewardItemData.State == ETrapDefenseRewardState.CanClaim)
				{
					list.Add(trapDefenseRewardItemData.Id);
				}
			}
			TrapDefenseController.Instance.RequestTrapDefenseRewardClaim(list);
		}

		// Token: 0x060313D8 RID: 201688 RVA: 0x00B6B0F8 File Offset: 0x00B692F8
		private void Init()
		{
			TrapDefenseConfig instance = TrapDefenseConfig.Instance;
			foreach (TrapDefenseReward config in (((instance != null) ? instance.GetRewardListByActivityId(this.ActivityId) : null) ?? Array.Empty<TrapDefenseReward>()))
			{
				ETrapDefenseRewardType type = (ETrapDefenseRewardType)config.Type;
				if (!this.RewardTypeMap.ContainsKey(type))
				{
					this.RewardTypeMap.Add(type, new List<TrapDefenseRewardItemData>());
				}
				TrapDefenseRewardItemData trapDefenseRewardItemData = TrapDefenseRewardItemData.Create(config);
				if (!config.IsPermanent)
				{
					this.RewardTypeMap[type].Add(trapDefenseRewardItemData);
				}
				this.RewardDataMap.Add(trapDefenseRewardItemData.Id, trapDefenseRewardItemData);
				if (config.IsPermanent)
				{
					this.FixedRewardDataList.Add(trapDefenseRewardItemData);
				}
			}
			foreach (List<TrapDefenseRewardItemData> list in this.RewardTypeMap.Values)
			{
				list.Sort(new Comparison<TrapDefenseRewardItemData>(this.RewardListSortFunc));
			}
			TrapDefenseConfig instance2 = TrapDefenseConfig.Instance;
			IReadOnlyList<TrapDefenseSpecialReward> readOnlyList = (instance2 != null) ? instance2.GetSpecialRewardByActivityId(this.ActivityId) : null;
			if (readOnlyList != null && readOnlyList.Count > 0)
			{
				this.SpecialRewardData = TrapDefenseSpecialRewardData.Create(readOnlyList[0]);
			}
		}

		// Token: 0x060313D9 RID: 201689 RVA: 0x00B6B258 File Offset: 0x00B69458
		private int RewardListSortFunc(TrapDefenseRewardItemData a, TrapDefenseRewardItemData b)
		{
			if (a.State != b.State)
			{
				if (a.State >= b.State)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				if (a.Id <= b.Id)
				{
					return -1;
				}
				return 1;
			}
		}

		// Token: 0x060313DA RID: 201690 RVA: 0x00B6B28B File Offset: 0x00B6948B
		public void SortFixedRewardList()
		{
			this.FixedRewardDataList.Sort(new Comparison<TrapDefenseRewardItemData>(this.RewardListSortFunc));
		}

		// Token: 0x060313DB RID: 201691 RVA: 0x00B6B2A4 File Offset: 0x00B694A4
		[NullableContext(0)]
		public ValueTuple<int, int> GetFixedRewardTotalProgress()
		{
			int num = 0;
			using (List<TrapDefenseRewardItemData>.Enumerator enumerator = this.FixedRewardDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State == ETrapDefenseRewardState.Claimed)
					{
						num++;
					}
				}
			}
			int count = this.FixedRewardDataList.Count;
			return new ValueTuple<int, int>(num, count);
		}

		// Token: 0x060313DC RID: 201692 RVA: 0x00B6B310 File Offset: 0x00B69510
		public bool IsCanClaimLimitReward()
		{
			foreach (List<TrapDefenseRewardItemData> list in this.RewardTypeMap.Values)
			{
				using (List<TrapDefenseRewardItemData>.Enumerator enumerator2 = list.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.State == ETrapDefenseRewardState.CanClaim)
						{
							return true;
						}
					}
				}
			}
			TrapDefenseSpecialRewardData specialRewardData = this.SpecialRewardData;
			return specialRewardData != null && specialRewardData.State == ETrapDefenseRewardState.CanClaim;
		}

		// Token: 0x060313DD RID: 201693 RVA: 0x00B6B3B8 File Offset: 0x00B695B8
		public bool IsCanClaimLimitRewardByType(ETrapDefenseRewardType type)
		{
			using (List<TrapDefenseRewardItemData>.Enumerator enumerator = this.GetRewardListByType(type).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State == ETrapDefenseRewardState.CanClaim)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060313DE RID: 201694 RVA: 0x00B6B414 File Offset: 0x00B69614
		public bool IsCanClaimFixedReward()
		{
			using (List<TrapDefenseRewardItemData>.Enumerator enumerator = this.FixedRewardDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State == ETrapDefenseRewardState.CanClaim)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060313DF RID: 201695 RVA: 0x00B6B470 File Offset: 0x00B69670
		public bool RedDotFixedReward()
		{
			return this.IsCanClaimFixedReward();
		}

		// Token: 0x060313E0 RID: 201696 RVA: 0x00B6B478 File Offset: 0x00B69678
		public bool RedDotLimitReward()
		{
			return this.IsCanClaimLimitReward();
		}

		// Token: 0x060313E1 RID: 201697 RVA: 0x00B6B480 File Offset: 0x00B69680
		public bool IsAllRewardClaimed()
		{
			TrapDefenseSpecialRewardData specialRewardData = this.SpecialRewardData;
			if (specialRewardData == null || specialRewardData.State != ETrapDefenseRewardState.Claimed)
			{
				return false;
			}
			using (List<TrapDefenseRewardItemData>.Enumerator enumerator = this.FixedRewardDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State != ETrapDefenseRewardState.Claimed)
					{
						return false;
					}
				}
			}
			foreach (List<TrapDefenseRewardItemData> list in this.RewardTypeMap.Values)
			{
				using (List<TrapDefenseRewardItemData>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.State != ETrapDefenseRewardState.Claimed)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x060313E2 RID: 201698 RVA: 0x00B6B578 File Offset: 0x00B69778
		public bool IsFixedRewardAllClaimed()
		{
			using (List<TrapDefenseRewardItemData>.Enumerator enumerator = this.FixedRewardDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State != ETrapDefenseRewardState.Claimed)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0401A532 RID: 107826
		private int ActivityId;

		// Token: 0x0401A533 RID: 107827
		public Dictionary<ETrapDefenseRewardType, List<TrapDefenseRewardItemData>> RewardTypeMap = new Dictionary<ETrapDefenseRewardType, List<TrapDefenseRewardItemData>>();

		// Token: 0x0401A534 RID: 107828
		[Nullable(2)]
		public TrapDefenseSpecialRewardData SpecialRewardData;

		// Token: 0x0401A535 RID: 107829
		public Dictionary<int, TrapDefenseRewardItemData> RewardDataMap = new Dictionary<int, TrapDefenseRewardItemData>();

		// Token: 0x0401A536 RID: 107830
		public List<TrapDefenseRewardItemData> FixedRewardDataList = new List<TrapDefenseRewardItemData>();

		// Token: 0x0401A537 RID: 107831
		public long LimitBeginTime;

		// Token: 0x0401A538 RID: 107832
		public long LimitEndTime;
	}
}
