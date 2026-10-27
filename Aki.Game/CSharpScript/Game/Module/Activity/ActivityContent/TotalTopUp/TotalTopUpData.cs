using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F87 RID: 24455
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpData : ActivityBaseData
	{
		// Token: 0x0603E10B RID: 254219 RVA: 0x00EFBD1C File Offset: 0x00EF9F1C
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
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Json", JsonSerializer.Serialize<TotalTopUpActivityInfo>(totalTopUpActivityInfo, null));
			TotalTopUpUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.ProgressData.SetScore(totalTopUpActivityInfo.Score);
			this.UpdateReward(totalTopUpActivityInfo.TotalTopUpRewardInfos.ToList<TotalTopUpRewardInfo>());
			EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, base.Id);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603E10C RID: 254220 RVA: 0x00EFBDE4 File Offset: 0x00EF9FE4
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

		// Token: 0x0603E10D RID: 254221 RVA: 0x00EFC174 File Offset: 0x00EFA374
		public void UpdateReward(List<TotalTopUpRewardInfo> rewardInfoList)
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

		// Token: 0x0603E10E RID: 254222 RVA: 0x00EFC230 File Offset: 0x00EFA430
		public void UpdateGoodsScore(List<TotalTopUpScoreInfo> infoList)
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

		// Token: 0x17008FE2 RID: 36834
		// (get) Token: 0x0603E10F RID: 254223 RVA: 0x00EFC448 File Offset: 0x00EFA648
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

		// Token: 0x0603E110 RID: 254224 RVA: 0x00EFC4A4 File Offset: 0x00EFA6A4
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

		// Token: 0x0402067F RID: 132735
		public readonly List<TotalTopUpRewardData> RewardDataList = new List<TotalTopUpRewardData>();

		// Token: 0x04020680 RID: 132736
		public readonly Dictionary<int, TotalTopUpRewardData> RewardDataMap = new Dictionary<int, TotalTopUpRewardData>();

		// Token: 0x04020681 RID: 132737
		public readonly TotalTopUpProgressData ProgressData = new TotalTopUpProgressData();

		// Token: 0x04020682 RID: 132738
		public readonly Dictionary<int, int> GoodsScoreMap = new Dictionary<int, int>();

		// Token: 0x04020683 RID: 132739
		public readonly Dictionary<int, int> RechargeItemMap = new Dictionary<int, int>();

		// Token: 0x04020684 RID: 132740
		public TotalTopUpPageViewModel PageViewModel = new TotalTopUpPageViewModel();

		// Token: 0x04020685 RID: 132741
		public TotalTopUpViewConfig? ViewConfig;

		// Token: 0x04020686 RID: 132742
		public bool HasRequestedScoreInfo;
	}
}
