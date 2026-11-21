using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F6E RID: 20334
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpData : ActivityBaseData
	{
		// Token: 0x060330A5 RID: 209061 RVA: 0x00E4D9E8 File Offset: 0x00E4BBE8
		protected unsafe override void PhraseEx(ActivityData data)
		{
			TotalTopUpActivityInfo totalTopUpActivityInfo = (data != null) ? data.TotalTopUpActivityInfo : null;
			if (totalTopUpActivityInfo == null)
			{
				return;
			}
			string message = "活动数据Phrase";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Score", totalTopUpActivityInfo.Score);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Json", totalTopUpActivityInfo);
			TotalTopUpUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.ProgressData.SetScore(totalTopUpActivityInfo.Score);
			this.UpdateReward(totalTopUpActivityInfo.TotalTopUpRewardInfos);
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, base.Id);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x060330A6 RID: 209062 RVA: 0x00E4DAA4 File Offset: 0x00E4BCA4
		public void InitData(TotalTopUpActivityInfo info, int activityId)
		{
			RepeatedField<TotalTopUpRewardInfo> repeatedField = (info != null) ? info.TotalTopUpRewardInfos : null;
			this.ProgressData.Reset();
			this.RewardDataMap.Clear();
			this.RewardDataList.Clear();
			for (int i = 0; i < repeatedField.Count; i++)
			{
				TotalTopUpRewardInfo totalTopUpRewardInfo = repeatedField[i];
				TotalTopUpRewardData totalTopUpRewardData = new TotalTopUpRewardData();
				TotalTopUpReward? rewardConfigById = TotalTopUpConfig.Instance.GetRewardConfigById(totalTopUpRewardInfo.Id);
				totalTopUpRewardData.Id = totalTopUpRewardInfo.Id;
				totalTopUpRewardData.Score = totalTopUpRewardInfo.Score;
				totalTopUpRewardData.State = (ETotalTopUpRewardState)totalTopUpRewardInfo.Status;
				MapField<int, int> rewardContent = totalTopUpRewardInfo.RewardContent;
				totalTopUpRewardData.ItemMap.Clear();
				if (rewardContent != null)
				{
					foreach (KeyValuePair<int, int> keyValuePair in rewardContent)
					{
						totalTopUpRewardData.ItemMap[keyValuePair.Key] = keyValuePair.Value;
					}
				}
				int[] array = ((rewardConfigById != null) ? rewardConfigById.GetValueOrDefault().GetPreviewButtonRegistryArray() : null) ?? Array.Empty<int>();
				totalTopUpRewardData.PreviewButtonRegistry.Clear();
				foreach (int item in array)
				{
					totalTopUpRewardData.PreviewButtonRegistry.Add(item);
				}
				List<int> list = TotalTopUpData.SortRewardItemIds(totalTopUpRewardData.ItemMap, array);
				totalTopUpRewardData.ItemIdList.Clear();
				foreach (int item2 in list)
				{
					totalTopUpRewardData.ItemIdList.Add(item2);
				}
				int num = (totalTopUpRewardData.ItemIdList.Count > 0) ? totalTopUpRewardData.ItemIdList[0] : 0;
				totalTopUpRewardData.FirstItemId = num;
				int num2;
				totalTopUpRewardData.FirstItemCount = ((num == 0) ? 0 : (totalTopUpRewardData.ItemMap.TryGetValue(num, out num2) ? num2 : 0));
				switch ((rewardConfigById != null) ? rewardConfigById.Value.PreviewFunction : 0)
				{
				case 1:
				case 5:
					totalTopUpRewardData.TotalTopUpRolePackageData = TotalTopUpRolePackageData.TryParsePackageData(totalTopUpRewardData.FirstItemId);
					break;
				case 2:
				case 6:
					totalTopUpRewardData.TotalTopUpWeaponPackageData = TotalTopUpWeaponPackageData.TryParseWeaponPackageData(totalTopUpRewardData.FirstItemId);
					break;
				}
				this.RewardDataList.Add(totalTopUpRewardData);
				this.RewardDataMap[totalTopUpRewardData.Id] = totalTopUpRewardData;
			}
			this.RewardDataList.Sort((TotalTopUpRewardData a, TotalTopUpRewardData b) => a.Score - b.Score);
			TotalTopUpRewardData totalTopUpRewardData2 = (this.RewardDataList.Count > 0) ? this.RewardDataList[0] : null;
			if (totalTopUpRewardData2 == null || totalTopUpRewardData2.Score != 0)
			{
				TotalTopUpUtil.Error("First reward is not appropriate", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			for (int k = 1; k < this.RewardDataList.Count; k++)
			{
				int score = this.RewardDataList[k].Score;
				this.ProgressData.PushLevel(score);
			}
			this.ProgressData.SortLevel();
			this.ProgressData.SetScore(info.Score);
			this.PageViewModel.InitData(this, activityId);
			this.ViewConfig = TotalTopUpConfig.Instance.GetViewConfigByActivityId(activityId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x060330A7 RID: 209063 RVA: 0x00E4DE34 File Offset: 0x00E4C034
		public void UpdateReward(IEnumerable<TotalTopUpRewardInfo> rewardInfoList)
		{
			TotalTopUpUtil.Debug("更新奖励状态", default(ReadOnlySpan<ValueTuple<string, object>>));
			foreach (TotalTopUpRewardInfo totalTopUpRewardInfo in rewardInfoList)
			{
				TotalTopUpRewardData totalTopUpRewardData;
				if (!this.RewardDataMap.TryGetValue(totalTopUpRewardInfo.Id, out totalTopUpRewardData))
				{
					string message = "更新领奖时，奖励数据不存在";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("RewardId", totalTopUpRewardInfo.Id);
					TotalTopUpUtil.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					totalTopUpRewardData.State = (ETotalTopUpRewardState)totalTopUpRewardInfo.Status;
				}
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x060330A8 RID: 209064 RVA: 0x00E4DEEC File Offset: 0x00E4C0EC
		public void UpdateGoodsScore(IEnumerable<TotalTopUpScoreInfo> infoList)
		{
			this.GoodsScoreMap.Clear();
			this.RechargeItemMap.Clear();
			foreach (TotalTopUpScoreInfo totalTopUpScoreInfo in infoList)
			{
				if (totalTopUpScoreInfo.Type == 0)
				{
					this.RechargeItemMap[totalTopUpScoreInfo.GoodsId] = totalTopUpScoreInfo.Score;
				}
				else
				{
					this.GoodsScoreMap[totalTopUpScoreInfo.GoodsId] = totalTopUpScoreInfo.Score;
				}
			}
			List<string> list = new List<string>();
			foreach (int key in this.GoodsScoreMap.Keys)
			{
				int num;
				this.GoodsScoreMap.TryGetValue(key, out num);
				list.Add(string.Concat(new string[]
				{
					"[",
					key.ToString(),
					":",
					num.ToString(),
					"]"
				}));
			}
			string message = "更新GoodsScoreMap";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Content", string.Join(",", list));
			TotalTopUpUtil.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			List<string> list2 = new List<string>();
			foreach (int key2 in this.RechargeItemMap.Keys)
			{
				int num2;
				this.RechargeItemMap.TryGetValue(key2, out num2);
				list2.Add(string.Concat(new string[]
				{
					"[",
					key2.ToString(),
					":",
					num2.ToString(),
					"]"
				}));
			}
			string message2 = "更新RechargeItemMap";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Content", string.Join(",", list2));
			TotalTopUpUtil.Debug(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x170063B4 RID: 25524
		// (get) Token: 0x060330A9 RID: 209065 RVA: 0x00E4E100 File Offset: 0x00E4C300
		public override bool RedPointShowState
		{
			get
			{
				using (List<TotalTopUpRewardData>.Enumerator enumerator = this.RewardDataList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.State == ETotalTopUpRewardState.CanClaim)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x060330AA RID: 209066 RVA: 0x00E4E15C File Offset: 0x00E4C35C
		private static List<int> SortRewardItemIds(Dictionary<int, int> itemMap, int[] order)
		{
			List<int> list = new List<int>();
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int num in order)
			{
				if (itemMap.ContainsKey(num) && !hashSet.Contains(num))
				{
					list.Add(num);
					hashSet.Add(num);
				}
			}
			List<int> list2 = new List<int>();
			foreach (int item in itemMap.Keys)
			{
				if (!hashSet.Contains(item))
				{
					list2.Add(item);
				}
			}
			list2.Sort((int a, int b) => a - b);
			foreach (int item2 in list2)
			{
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x0401B151 RID: 110929
		public readonly List<TotalTopUpRewardData> RewardDataList = new List<TotalTopUpRewardData>();

		// Token: 0x0401B152 RID: 110930
		public readonly Dictionary<int, TotalTopUpRewardData> RewardDataMap = new Dictionary<int, TotalTopUpRewardData>();

		// Token: 0x0401B153 RID: 110931
		public readonly TotalTopUpProgressData ProgressData = new TotalTopUpProgressData();

		// Token: 0x0401B154 RID: 110932
		public readonly Dictionary<int, int> GoodsScoreMap = new Dictionary<int, int>();

		// Token: 0x0401B155 RID: 110933
		public readonly Dictionary<int, int> RechargeItemMap = new Dictionary<int, int>();

		// Token: 0x0401B156 RID: 110934
		public TotalTopUpPageViewModel PageViewModel = new TotalTopUpPageViewModel();

		// Token: 0x0401B157 RID: 110935
		public TotalTopUpViewConfig? ViewConfig;

		// Token: 0x0401B158 RID: 110936
		public bool HasRequestedScoreInfo;
	}
}
