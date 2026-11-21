using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039BF RID: 14783
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseRewardData
	{
		// Token: 0x0602615D RID: 155997 RVA: 0x00AAEDF1 File Offset: 0x00AACFF1
		public static TrapDefenseRewardData Create(int activityId)
		{
			TrapDefenseRewardData trapDefenseRewardData = new TrapDefenseRewardData();
			trapDefenseRewardData.ActivityId = activityId;
			trapDefenseRewardData.Init();
			return trapDefenseRewardData;
		}

		// Token: 0x0602615E RID: 155998 RVA: 0x00AAEE08 File Offset: 0x00AAD008
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

		// Token: 0x0602615F RID: 155999 RVA: 0x00AAEE54 File Offset: 0x00AAD054
		public void SetLimitTime(long beginTime, long endTime)
		{
			this.LimitBeginTime = beginTime;
			this.LimitEndTime = endTime;
		}

		// Token: 0x06026160 RID: 156000 RVA: 0x00AAEE64 File Offset: 0x00AAD064
		public void SetLimitTime(int beginTime, int endTime)
		{
			this.LimitBeginTime = (long)beginTime;
			this.LimitEndTime = (long)endTime;
		}

		// Token: 0x06026161 RID: 156001 RVA: 0x00AAEE78 File Offset: 0x00AAD078
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

		// Token: 0x06026162 RID: 156002 RVA: 0x00AAEEB0 File Offset: 0x00AAD0B0
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

		// Token: 0x06026163 RID: 156003 RVA: 0x00AAEF18 File Offset: 0x00AAD118
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

		// Token: 0x06026164 RID: 156004 RVA: 0x00AAEF80 File Offset: 0x00AAD180
		public string GetLimitRewardRemainTimeStr()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3((double)this.LimitEndTime * TimeUtil.Instance.Millisecond - serverTime);
			return ((remainTimeDataFormat != null) ? remainTimeDataFormat.CountDownText : null) ?? "";
		}

		// Token: 0x06026165 RID: 156005 RVA: 0x00AAEFCC File Offset: 0x00AAD1CC
		public bool IsOpenLimitReward()
		{
			double startTime = (double)this.LimitBeginTime * TimeUtil.Instance.Millisecond;
			double endTime = (double)this.LimitEndTime * TimeUtil.Instance.Millisecond;
			return TimeUtil.Instance.IsInTimeSpan(startTime, endTime);
		}

		// Token: 0x06026166 RID: 156006 RVA: 0x00AAF00C File Offset: 0x00AAD20C
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

		// Token: 0x06026167 RID: 156007 RVA: 0x00AAF080 File Offset: 0x00AAD280
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

		// Token: 0x06026168 RID: 156008 RVA: 0x00AAF0F4 File Offset: 0x00AAD2F4
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

		// Token: 0x06026169 RID: 156009 RVA: 0x00AAF254 File Offset: 0x00AAD454
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

		// Token: 0x0602616A RID: 156010 RVA: 0x00AAF287 File Offset: 0x00AAD487
		public void SortFixedRewardList()
		{
			this.FixedRewardDataList.Sort(new Comparison<TrapDefenseRewardItemData>(this.RewardListSortFunc));
		}

		// Token: 0x0602616B RID: 156011 RVA: 0x00AAF2A0 File Offset: 0x00AAD4A0
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

		// Token: 0x0602616C RID: 156012 RVA: 0x00AAF30C File Offset: 0x00AAD50C
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

		// Token: 0x0602616D RID: 156013 RVA: 0x00AAF3B4 File Offset: 0x00AAD5B4
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

		// Token: 0x0602616E RID: 156014 RVA: 0x00AAF410 File Offset: 0x00AAD610
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

		// Token: 0x0602616F RID: 156015 RVA: 0x00AAF46C File Offset: 0x00AAD66C
		public bool RedDotFixedReward()
		{
			return this.IsCanClaimFixedReward();
		}

		// Token: 0x06026170 RID: 156016 RVA: 0x00AAF474 File Offset: 0x00AAD674
		public bool RedDotLimitReward()
		{
			return this.IsCanClaimLimitReward();
		}

		// Token: 0x06026171 RID: 156017 RVA: 0x00AAF47C File Offset: 0x00AAD67C
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

		// Token: 0x06026172 RID: 156018 RVA: 0x00AAF574 File Offset: 0x00AAD774
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

		// Token: 0x04014E89 RID: 85641
		private int ActivityId;

		// Token: 0x04014E8A RID: 85642
		public Dictionary<ETrapDefenseRewardType, List<TrapDefenseRewardItemData>> RewardTypeMap = new Dictionary<ETrapDefenseRewardType, List<TrapDefenseRewardItemData>>();

		// Token: 0x04014E8B RID: 85643
		[Nullable(2)]
		public TrapDefenseSpecialRewardData SpecialRewardData;

		// Token: 0x04014E8C RID: 85644
		public Dictionary<int, TrapDefenseRewardItemData> RewardDataMap = new Dictionary<int, TrapDefenseRewardItemData>();

		// Token: 0x04014E8D RID: 85645
		public List<TrapDefenseRewardItemData> FixedRewardDataList = new List<TrapDefenseRewardItemData>();

		// Token: 0x04014E8E RID: 85646
		public long LimitBeginTime;

		// Token: 0x04014E8F RID: 85647
		public long LimitEndTime;
	}
}
