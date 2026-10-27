using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Reward;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FarmGold
{
	// Token: 0x0200664D RID: 26189
	[NullableContext(1)]
	[Nullable(0)]
	public class FarmGoldData : ActivityBaseData
	{
		// Token: 0x06041A2E RID: 268846 RVA: 0x00FEB9E9 File Offset: 0x00FE9BE9
		protected override void PhraseEx(ActivityData data)
		{
			this.CurrentData = data;
			this.FinishPointList = new List<int>(data.FarmGoldInfo.PointsRewardGet);
			this.PhraseLevelData(data.FarmGoldInfo.LevelPlayTasks);
			this.PhraseRewardInfo();
		}

		// Token: 0x06041A2F RID: 268847 RVA: 0x00FEBA20 File Offset: 0x00FE9C20
		public void AddFinishPointId(List<int> ids)
		{
			foreach (int item in ids)
			{
				if (!this.FinishPointList.Contains(item))
				{
					ActivityData currentData = this.CurrentData;
					if (currentData != null)
					{
						currentData.FarmGoldInfo.PointsRewardGet.Add(item);
					}
					this.FinishPointList.Add(item);
				}
			}
		}

		// Token: 0x06041A30 RID: 268848 RVA: 0x00FEBAA0 File Offset: 0x00FE9CA0
		public void FinishLevelReward(List<int> instIds)
		{
			foreach (int num in instIds)
			{
				FarmGoldLevelData levelInfoByInstId = this.GetLevelInfoByInstId(num);
				if (levelInfoByInstId != null)
				{
					levelInfoByInstId.FinishLevelReward();
				}
				ActivityData currentData = this.CurrentData;
				bool flag;
				if (currentData == null)
				{
					flag = (null != null);
				}
				else
				{
					FarmGoldInfo farmGoldInfo = currentData.FarmGoldInfo;
					flag = (((farmGoldInfo != null) ? farmGoldInfo.LevelPlayTasks : null) != null);
				}
				if (flag)
				{
					foreach (FarmGoldLevelPlayInfo farmGoldLevelPlayInfo in this.CurrentData.FarmGoldInfo.LevelPlayTasks)
					{
						if (farmGoldLevelPlayInfo.InstId == num)
						{
							farmGoldLevelPlayInfo.LevelRewardGet = true;
							break;
						}
					}
				}
			}
		}

		// Token: 0x06041A31 RID: 268849 RVA: 0x00FEBB74 File Offset: 0x00FE9D74
		public List<int> GetAllCanClaimLevelRewardIds()
		{
			List<int> list = new List<int>();
			foreach (FarmGoldLevelData farmGoldLevelData in this.CurrentLevelData)
			{
				if (!farmGoldLevelData.GetHasGetLevelReward() && farmGoldLevelData.GetIfPassLevel())
				{
					list.Add(farmGoldLevelData.GetInstId());
				}
			}
			return list;
		}

		// Token: 0x06041A32 RID: 268850 RVA: 0x00FEBBE4 File Offset: 0x00FE9DE4
		public List<int> GetAllCanClaimScoreRewardIds()
		{
			List<int> list = new List<int>();
			int currentFullScore = this.GetCurrentFullScore();
			foreach (FarmGoldScore farmGoldScore in FarmGoldConfig.Instance.GetScoreConfigByActivityId(base.Id))
			{
				if (!this.FinishPointList.Contains(farmGoldScore.Id) && currentFullScore >= farmGoldScore.Score)
				{
					list.Add(farmGoldScore.Id);
				}
			}
			return list;
		}

		// Token: 0x06041A33 RID: 268851 RVA: 0x00FEBC70 File Offset: 0x00FE9E70
		public int GetCurrentFullScore()
		{
			int num = 0;
			foreach (FarmGoldLevelData farmGoldLevelData in this.CurrentLevelData)
			{
				num += farmGoldLevelData.GetPoint();
			}
			return num;
		}

		// Token: 0x06041A34 RID: 268852 RVA: 0x00FEBCC8 File Offset: 0x00FE9EC8
		public void PhraseLevelData(RepeatedField<FarmGoldLevelPlayInfo> data)
		{
			this.CurrentLevelData = new List<FarmGoldLevelData>();
			this.CurrentLevelRewardInfo = new List<IActivityRewardData>();
			for (int i = 0; i < data.Count; i++)
			{
				FarmGoldLevelPlayInfo data2 = data[i];
				FarmGoldLevelData farmGoldLevelData = new FarmGoldLevelData();
				farmGoldLevelData.Phrase(base.Id, data2, i);
				this.SetDifficultyFromPreviousLevel(farmGoldLevelData, i);
				this.CurrentLevelData.Add(farmGoldLevelData);
				IActivityRewardData item = this.CreateLevelReward(farmGoldLevelData);
				this.CurrentLevelRewardInfo.Add(item);
			}
		}

		// Token: 0x06041A35 RID: 268853 RVA: 0x00FEBD40 File Offset: 0x00FE9F40
		private void SetDifficultyFromPreviousLevel(FarmGoldLevelData levelData, int index)
		{
			if (!levelData.HasSelectDifficult && index > 0)
			{
				FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index - 1);
				if (levelDataByIndex != null)
				{
					levelData.SetDifficult(levelDataByIndex.GetSelectDifficult());
				}
			}
		}

		// Token: 0x06041A36 RID: 268854 RVA: 0x00FEBD74 File Offset: 0x00FE9F74
		public void RestoreDifficultySettings()
		{
			for (int i = 0; i < this.CurrentLevelData.Count; i++)
			{
				FarmGoldLevelData levelData = this.CurrentLevelData[i];
				this.SetDifficultyFromPreviousLevel(levelData, i);
			}
		}

		// Token: 0x06041A37 RID: 268855 RVA: 0x00FEBDAC File Offset: 0x00FE9FAC
		public void RefreshLevelData(FarmGoldLevelPlayInfo data)
		{
			ActivityData currentData = this.CurrentData;
			bool flag;
			if (currentData == null)
			{
				flag = (null != null);
			}
			else
			{
				FarmGoldInfo farmGoldInfo = currentData.FarmGoldInfo;
				flag = (((farmGoldInfo != null) ? farmGoldInfo.LevelPlayTasks : null) != null);
			}
			if (flag)
			{
				foreach (FarmGoldLevelPlayInfo farmGoldLevelPlayInfo in this.CurrentData.FarmGoldInfo.LevelPlayTasks)
				{
					if (farmGoldLevelPlayInfo.InstId == data.InstId)
					{
						farmGoldLevelPlayInfo.Point = data.Point;
						farmGoldLevelPlayInfo.LevelRewardGet = data.LevelRewardGet;
						break;
					}
				}
			}
			FarmGoldLevelData farmGoldLevelData = null;
			int index = -1;
			for (int i = 0; i < this.CurrentLevelData.Count; i++)
			{
				if (this.CurrentLevelData[i].GetInstId() == data.InstId)
				{
					farmGoldLevelData = this.CurrentLevelData[i];
					index = i;
					break;
				}
			}
			if (farmGoldLevelData != null)
			{
				ActivityData currentData2 = this.CurrentData;
				bool flag2;
				if (currentData2 == null)
				{
					flag2 = (null != null);
				}
				else
				{
					FarmGoldInfo farmGoldInfo2 = currentData2.FarmGoldInfo;
					flag2 = (((farmGoldInfo2 != null) ? farmGoldInfo2.LevelPlayTasks : null) != null);
				}
				if (flag2)
				{
					farmGoldLevelData.Phrase(base.Id, data, index);
					this.PhraseLevelData(this.CurrentData.FarmGoldInfo.LevelPlayTasks);
				}
			}
		}

		// Token: 0x06041A38 RID: 268856 RVA: 0x00FEBED8 File Offset: 0x00FEA0D8
		public void PhraseRewardInfo()
		{
			this.CurrentScoreRewardInfo = new List<IActivityRewardData>();
			int currentFullScore = this.GetCurrentFullScore();
			foreach (FarmGoldScore farmGoldScore in FarmGoldConfig.Instance.GetScoreConfigByActivityId(base.Id))
			{
				IActivityRewardData item = this.CreateScoreReward(farmGoldScore.Id, this.FinishPointList, currentFullScore);
				this.CurrentScoreRewardInfo.Add(item);
			}
			EventSystem.Instance.Emit<int>(EEventName.FarmGoldRefreshRewardRedDot, base.Id);
		}

		// Token: 0x06041A39 RID: 268857 RVA: 0x00FEBF74 File Offset: 0x00FEA174
		private IActivityRewardData CreateLevelReward(FarmGoldLevelData levelData)
		{
			FarmGoldActivity config = levelData.GetConfig();
			bool hasGetLevelReward = levelData.GetHasGetLevelReward();
			bool flag = levelData.GetPoint() >= config.PassScore;
			EActivityRewardState eactivityRewardState = hasGetLevelReward ? EActivityRewardState.Claimed : (flag ? EActivityRewardState.Enable : EActivityRewardState.Disabled);
			FarmGoldController controller = FarmGoldController.Instance;
			return new ActivityRewardData
			{
				Id = new int?(config.Id),
				NameText = ConfigMultiTextLang.GetLocalTextNew(config.LevelRewardDesc, null),
				RewardState = eactivityRewardState,
				ClickFunction = delegate
				{
					List<int> allCanClaimLevelRewardIds = this.GetAllCanClaimLevelRewardIds();
					if (allCanClaimLevelRewardIds.Count > 0)
					{
						controller.RequestFarmGoldLevelPlay(this.Id, allCanClaimLevelRewardIds);
					}
				},
				RewardList = this.GetRewardItems(config.RewardId).ToArray(),
				RewardButtonText = ConfigMultiTextLang.GetLocalTextNew(this.GetButtonText((int)eactivityRewardState), null)
			};
		}

		// Token: 0x06041A3A RID: 268858 RVA: 0x00FEC034 File Offset: 0x00FEA234
		private IActivityRewardData CreateScoreReward(int scoreId, List<int> finishGetIdList, int currentPoint)
		{
			FarmGoldScore? scoreConfigById = FarmGoldConfig.Instance.GetScoreConfigById(scoreId);
			if (scoreConfigById == null)
			{
				return new ActivityRewardData
				{
					NameText = "",
					RewardState = EActivityRewardState.Disabled
				};
			}
			FarmGoldScore value = scoreConfigById.Value;
			string nameText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("FarmGoldFullScoreTips", null), new string[]
			{
				value.Score.ToString()
			});
			EActivityRewardState eactivityRewardState = finishGetIdList.Contains(scoreId) ? EActivityRewardState.Claimed : ((currentPoint >= value.Score) ? EActivityRewardState.Enable : EActivityRewardState.Disabled);
			FarmGoldController controller = FarmGoldController.Instance;
			return new ActivityRewardData
			{
				Id = new int?(value.RewardId),
				NameText = nameText,
				RewardState = eactivityRewardState,
				ClickFunction = delegate
				{
					List<int> allCanClaimScoreRewardIds = this.GetAllCanClaimScoreRewardIds();
					if (allCanClaimScoreRewardIds.Count > 0)
					{
						controller.RequestFarmGoldPoint(this.Id, allCanClaimScoreRewardIds);
					}
				},
				RewardList = this.GetRewardItems(value.RewardId).ToArray(),
				RewardButtonText = ConfigMultiTextLang.GetLocalTextNew(this.GetButtonText((int)eactivityRewardState), null)
			};
		}

		// Token: 0x06041A3B RID: 268859 RVA: 0x00FEC138 File Offset: 0x00FEA338
		private string GetButtonText(int state)
		{
			switch (state)
			{
			case 0:
				return "PrefabTextItem_1443074454_Text";
			case 1:
				return "CollectActivity_state_CanRecive";
			case 2:
				return "CollectActivity_state_recived";
			default:
				return "";
			}
		}

		// Token: 0x06041A3C RID: 268860 RVA: 0x00FEC165 File Offset: 0x00FEA365
		private List<TItem> GetRewardItems(int dropId)
		{
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
		}

		// Token: 0x06041A3D RID: 268861 RVA: 0x00FEC172 File Offset: 0x00FEA372
		public override bool GetExDataRedPointShowState()
		{
			return base.GetPreGuideQuestFinishState() && (this.GetIfCanTakeReward() || this.IfHaveNewLevel());
		}

		// Token: 0x06041A3E RID: 268862 RVA: 0x00FEC190 File Offset: 0x00FEA390
		protected override bool GetExDataFinishShowState()
		{
			if (this.CurrentData == null)
			{
				return false;
			}
			using (List<IActivityRewardData>.Enumerator enumerator = this.CurrentScoreRewardInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState != EActivityRewardState.Claimed)
					{
						return false;
					}
				}
			}
			using (List<IActivityRewardData>.Enumerator enumerator = this.CurrentLevelRewardInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState != EActivityRewardState.Claimed)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06041A3F RID: 268863 RVA: 0x00FEC23C File Offset: 0x00FEA43C
		private bool IfHaveNewLevel()
		{
			using (List<FarmGoldLevelData>.Enumerator enumerator = this.CurrentLevelData.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.GetNewOpenState())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06041A40 RID: 268864 RVA: 0x00FEC298 File Offset: 0x00FEA498
		private bool GetIfCanTakeReward()
		{
			using (List<IActivityRewardData>.Enumerator enumerator = this.CurrentScoreRewardInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState == EActivityRewardState.Enable)
					{
						return true;
					}
				}
			}
			using (List<IActivityRewardData>.Enumerator enumerator = this.CurrentLevelRewardInfo.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RewardState == EActivityRewardState.Enable)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06041A41 RID: 268865 RVA: 0x00FEC338 File Offset: 0x00FEA538
		public bool EntranceRedDot()
		{
			return this.GetExDataRedPointShowState();
		}

		// Token: 0x06041A42 RID: 268866 RVA: 0x00FEC340 File Offset: 0x00FEA540
		private int SortRewardCompare(IActivityRewardData a, IActivityRewardData b)
		{
			int rewardSort = this.GetRewardSort(b);
			int rewardSort2 = this.GetRewardSort(a);
			if (rewardSort == rewardSort2)
			{
				return a.Id.GetValueOrDefault() - b.Id.GetValueOrDefault();
			}
			return rewardSort - rewardSort2;
		}

		// Token: 0x06041A43 RID: 268867 RVA: 0x00FEC382 File Offset: 0x00FEA582
		public void RebuildData()
		{
			if (this.CurrentData != null)
			{
				this.PhraseEx(this.CurrentData);
			}
		}

		// Token: 0x06041A44 RID: 268868 RVA: 0x00FEC398 File Offset: 0x00FEA598
		public IActivityRewardViewData GetRewardPopUpViewData()
		{
			this.RebuildData();
			return this.GetRewardViewData();
		}

		// Token: 0x06041A45 RID: 268869 RVA: 0x00FEC3A8 File Offset: 0x00FEA5A8
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"ClaimedNum",
			"TotalNum"
		})]
		public ValueTuple<int, int> GetAllRewardClaimedAndTotalNum()
		{
			int num = 0;
			int num2 = 0;
			foreach (IActivityRewardData activityRewardData in this.CurrentLevelRewardInfo)
			{
				num2++;
				if (activityRewardData.RewardState == EActivityRewardState.Claimed)
				{
					num++;
				}
			}
			foreach (IActivityRewardData activityRewardData2 in this.CurrentScoreRewardInfo)
			{
				num2++;
				if (activityRewardData2.RewardState == EActivityRewardState.Claimed)
				{
					num++;
				}
			}
			return new ValueTuple<int, int>(num, num2);
		}

		// Token: 0x06041A46 RID: 268870 RVA: 0x00FEC458 File Offset: 0x00FEA658
		public string GetScoreDesc()
		{
			return this.GetCurrentFullScore().ToString();
		}

		// Token: 0x06041A47 RID: 268871 RVA: 0x00FEC474 File Offset: 0x00FEA674
		public IActivityRewardViewData GetRewardViewData()
		{
			string tabTips = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("FarmGoldFullPoint", null), new string[]
			{
				this.GetCurrentFullScore().ToString()
			});
			List<IActivityRewardData> list = new List<IActivityRewardData>(this.CurrentLevelRewardInfo);
			FarmGoldData.ManualSort(list, new Comparison<IActivityRewardData>(this.SortLevelRewardCompare));
			ActivityRewardDataPage item = new ActivityRewardDataPage
			{
				DataList = list,
				TabName = ConfigMultiTextLang.GetLocalTextNew("FarmGoldLevelRewardText", null),
				TabTips = " "
			};
			List<IActivityRewardData> list2 = new List<IActivityRewardData>(this.CurrentScoreRewardInfo);
			FarmGoldData.ManualSort(list2, new Comparison<IActivityRewardData>(this.SortRewardCompare));
			ActivityRewardDataPage item2 = new ActivityRewardDataPage
			{
				DataList = list2,
				TabName = ConfigMultiTextLang.GetLocalTextNew("FarmGoldScoreRewardText", null),
				TabTips = tabTips
			};
			return new ActivityRewardViewData
			{
				DataPageList = new List<IActivityRewardDataPage>
				{
					item,
					item2
				},
				Source = EActivityRewardSource.FarmGold
			};
		}

		// Token: 0x06041A48 RID: 268872 RVA: 0x00FEC560 File Offset: 0x00FEA760
		private static void ManualSort(List<IActivityRewardData> list, Comparison<IActivityRewardData> comparer)
		{
			for (int i = 0; i < list.Count - 1; i++)
			{
				for (int j = i + 1; j < list.Count; j++)
				{
					if (comparer(list[i], list[j]) > 0)
					{
						IActivityRewardData value = list[i];
						list[i] = list[j];
						list[j] = value;
					}
				}
			}
		}

		// Token: 0x06041A49 RID: 268873 RVA: 0x00FEC5C8 File Offset: 0x00FEA7C8
		private int SortLevelRewardCompare(IActivityRewardData a, IActivityRewardData b)
		{
			int rewardSort = this.GetRewardSort(a);
			int rewardSort2 = this.GetRewardSort(b);
			if (rewardSort == rewardSort2)
			{
				return a.Id.GetValueOrDefault() - b.Id.GetValueOrDefault();
			}
			return rewardSort2 - rewardSort;
		}

		// Token: 0x06041A4A RID: 268874 RVA: 0x00FEC60C File Offset: 0x00FEA80C
		private int GetRewardSort(IActivityRewardData data)
		{
			switch (data.RewardState)
			{
			case EActivityRewardState.Disabled:
				return 2;
			case EActivityRewardState.Enable:
				return 3;
			case EActivityRewardState.Claimed:
				return 1;
			default:
				return 4;
			}
		}

		// Token: 0x06041A4B RID: 268875 RVA: 0x00FEC63C File Offset: 0x00FEA83C
		[NullableContext(2)]
		public FarmGoldLevelData GetLevelInfoByInstId(int instId)
		{
			foreach (FarmGoldLevelData farmGoldLevelData in this.CurrentLevelData)
			{
				if (farmGoldLevelData.GetInstId() == instId)
				{
					return farmGoldLevelData;
				}
			}
			return null;
		}

		// Token: 0x06041A4C RID: 268876 RVA: 0x00FEC698 File Offset: 0x00FEA898
		public bool HaveRewardCanTake()
		{
			return this.GetIfCanTakeReward();
		}

		// Token: 0x06041A4D RID: 268877 RVA: 0x00FEC6A0 File Offset: 0x00FEA8A0
		public void SaveOpenState(int instId)
		{
			FarmGoldLevelData levelInfoByInstId = this.GetLevelInfoByInstId(instId);
			if (levelInfoByInstId != null)
			{
				levelInfoByInstId.SaveOpenState();
			}
		}

		// Token: 0x06041A4E RID: 268878 RVA: 0x00FEC6BE File Offset: 0x00FEA8BE
		public bool GetInsOpenState(int instanceId)
		{
			FarmGoldLevelData levelInfoByInstId = this.GetLevelInfoByInstId(instanceId);
			return levelInfoByInstId != null && levelInfoByInstId.GetNewOpenState();
		}

		// Token: 0x06041A4F RID: 268879 RVA: 0x00FEC6D2 File Offset: 0x00FEA8D2
		public string GetInsUnlockState(int instanceId)
		{
			FarmGoldLevelData levelInfoByInstId = this.GetLevelInfoByInstId(instanceId);
			return ((levelInfoByInstId != null) ? levelInfoByInstId.GetUnlockTimeText() : null) ?? "";
		}

		// Token: 0x06041A50 RID: 268880 RVA: 0x00FEC6F0 File Offset: 0x00FEA8F0
		public string GetInsUnlockText(int instanceId)
		{
			FarmGoldLevelData levelInfoByInstId = this.GetLevelInfoByInstId(instanceId);
			return ((levelInfoByInstId != null) ? levelInfoByInstId.GetUnlockTimeText() : null) ?? "";
		}

		// Token: 0x06041A51 RID: 268881 RVA: 0x00FEC70E File Offset: 0x00FEA90E
		public List<FarmGoldLevelData> GetAllLevelData()
		{
			return this.CurrentLevelData;
		}

		// Token: 0x06041A52 RID: 268882 RVA: 0x00FEC716 File Offset: 0x00FEA916
		[NullableContext(2)]
		public FarmGoldLevelData GetLevelDataByIndex(int index)
		{
			if (index < 0 || index >= this.CurrentLevelData.Count)
			{
				return null;
			}
			return this.CurrentLevelData[index];
		}

		// Token: 0x06041A53 RID: 268883 RVA: 0x00FEC738 File Offset: 0x00FEA938
		public string GetLevelNameTextByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetNameText() : null) ?? "";
		}

		// Token: 0x06041A54 RID: 268884 RVA: 0x00FEC756 File Offset: 0x00FEA956
		public string GetLevelDescTextByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetDescText() : null) ?? "";
		}

		// Token: 0x06041A55 RID: 268885 RVA: 0x00FEC774 File Offset: 0x00FEA974
		public List<int> GetLevelRecommendElementByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetRecommendElement() : null) ?? new List<int>();
		}

		// Token: 0x06041A56 RID: 268886 RVA: 0x00FEC792 File Offset: 0x00FEA992
		public string GetLevelSubTitleTextByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetSubTitleText() : null) ?? "";
		}

		// Token: 0x06041A57 RID: 268887 RVA: 0x00FEC7B0 File Offset: 0x00FEA9B0
		public bool GetLevelLockStateByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return levelDataByIndex != null && !levelDataByIndex.GetIsOpen();
		}

		// Token: 0x06041A58 RID: 268888 RVA: 0x00FEC7D3 File Offset: 0x00FEA9D3
		public int GetLevelInstanceDungeonIdByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			if (levelDataByIndex == null)
			{
				return 0;
			}
			return levelDataByIndex.GetInstId();
		}

		// Token: 0x06041A59 RID: 268889 RVA: 0x00FEC7E7 File Offset: 0x00FEA9E7
		public string GetLevelUnlockTextByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetUnlockTimeText() : null) ?? "";
		}

		// Token: 0x06041A5A RID: 268890 RVA: 0x00FEC805 File Offset: 0x00FEAA05
		public bool GetLevelFinishStateByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return levelDataByIndex != null && levelDataByIndex.GetFinishState();
		}

		// Token: 0x06041A5B RID: 268891 RVA: 0x00FEC819 File Offset: 0x00FEAA19
		public int GetLevelRecommendLevelByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			if (levelDataByIndex == null)
			{
				return 0;
			}
			return levelDataByIndex.GetRecommendLevel();
		}

		// Token: 0x06041A5C RID: 268892 RVA: 0x00FEC82D File Offset: 0x00FEAA2D
		public bool GetLevelRedDotStateByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return levelDataByIndex != null && levelDataByIndex.GetRedDotState();
		}

		// Token: 0x06041A5D RID: 268893 RVA: 0x00FEC844 File Offset: 0x00FEAA44
		public int GetLevelDifficultIndexByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			if (levelDataByIndex != null)
			{
				return levelDataByIndex.GetSelectDifficultIndex();
			}
			if (index > 0)
			{
				levelDataByIndex = this.GetLevelDataByIndex(index - 1);
				if (levelDataByIndex != null)
				{
					return levelDataByIndex.GetSelectDifficultIndex();
				}
			}
			return 1;
		}

		// Token: 0x06041A5E RID: 268894 RVA: 0x00FEC87C File Offset: 0x00FEAA7C
		public string GetLevelBgByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetInstanceBg() : null) ?? "";
		}

		// Token: 0x06041A5F RID: 268895 RVA: 0x00FEC89C File Offset: 0x00FEAA9C
		public string GetDifficultTogText(int difficultId)
		{
			FarmGoldDifficulty farmGoldDifficultById = FarmGoldConfig.Instance.GetFarmGoldDifficultById(difficultId);
			string str = ConfigMultiTextLang.GetLocalTextNew(farmGoldDifficultById.Desc, null) ?? "";
			string str2 = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("FarmGoldPointMultiply", null) ?? "", new string[]
			{
				(farmGoldDifficultById.Magnification / 100).ToString()
			});
			return str + "•" + str2;
		}

		// Token: 0x06041A60 RID: 268896 RVA: 0x00FEC910 File Offset: 0x00FEAB10
		public string GetDifficultTitle(int difficultId)
		{
			FarmGoldDifficulty farmGoldDifficultById = FarmGoldConfig.Instance.GetFarmGoldDifficultById(difficultId);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(farmGoldDifficultById.Desc, null);
			string str = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("FarmGoldPointMultiply", null) ?? "", new string[]
			{
				(farmGoldDifficultById.Magnification / 100).ToString()
			});
			return localTextNew + "•" + str;
		}

		// Token: 0x06041A61 RID: 268897 RVA: 0x00FEC978 File Offset: 0x00FEAB78
		public int GetDifficultRecommendLevel(int difficultId)
		{
			return FarmGoldConfig.Instance.GetFarmGoldDifficultById(difficultId).RecommendedLevel;
		}

		// Token: 0x06041A62 RID: 268898 RVA: 0x00FEC998 File Offset: 0x00FEAB98
		public void SetInsDifficult(int instId, int difficult)
		{
			FarmGoldLevelData levelInfoByInstId = this.GetLevelInfoByInstId(instId);
			if (levelInfoByInstId != null)
			{
				levelInfoByInstId.SetDifficult(difficult);
			}
		}

		// Token: 0x06041A63 RID: 268899 RVA: 0x00FEC9B8 File Offset: 0x00FEABB8
		public void SaveLevelBattleSelectRolesAndTags(int instId, IReadOnlyList<int> selectRoleList, IReadOnlyList<int> tags)
		{
			for (int i = 0; i < selectRoleList.Count; i++)
			{
				ActivityModel.Instance.SaveActivityData(base.Id, 2, instId, i, selectRoleList[i]);
			}
			for (int j = 0; j < tags.Count; j++)
			{
				ActivityModel.Instance.SaveActivityData(base.Id, 3, instId, j, tags[j]);
			}
		}

		// Token: 0x06041A64 RID: 268900 RVA: 0x00FECA1C File Offset: 0x00FEAC1C
		[return: TupleElementNames(new string[]
		{
			"roldIds",
			"tags"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<List<int>, List<int>> GetBattleSelectRolesAndTags(int instId)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < 3; i++)
			{
				int activityCacheData = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 2, instId, i);
				list.Add(activityCacheData);
			}
			List<int> list2 = new List<int>();
			for (int j = 0; j < 3; j++)
			{
				int activityCacheData2 = ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 3, instId, j);
				list2.Add(activityCacheData2);
			}
			return new ValueTuple<List<int>, List<int>>(list, list2);
		}

		// Token: 0x04022285 RID: 139909
		[StaticVariableRuleIgnore]
		public static int CurrentSelectEntranceId;

		// Token: 0x04022286 RID: 139910
		private List<int> FinishPointList = new List<int>();

		// Token: 0x04022287 RID: 139911
		private List<IActivityRewardData> CurrentScoreRewardInfo = new List<IActivityRewardData>();

		// Token: 0x04022288 RID: 139912
		private List<FarmGoldLevelData> CurrentLevelData = new List<FarmGoldLevelData>();

		// Token: 0x04022289 RID: 139913
		private List<IActivityRewardData> CurrentLevelRewardInfo = new List<IActivityRewardData>();

		// Token: 0x0402228A RID: 139914
		[Nullable(2)]
		private ActivityData CurrentData;
	}
}
