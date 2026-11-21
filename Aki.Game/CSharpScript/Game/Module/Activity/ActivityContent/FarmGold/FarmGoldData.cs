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
	// Token: 0x020055CB RID: 21963
	[NullableContext(1)]
	[Nullable(0)]
	public class FarmGoldData : ActivityBaseData
	{
		// Token: 0x060366F3 RID: 222963 RVA: 0x00F32AA1 File Offset: 0x00F30CA1
		protected override void PhraseEx(ActivityData data)
		{
			this.CurrentData = data;
			this.FinishPointList = new List<int>(data.FarmGoldInfo.PointsRewardGet);
			this.PhraseLevelData(data.FarmGoldInfo.LevelPlayTasks);
			this.PhraseRewardInfo();
		}

		// Token: 0x060366F4 RID: 222964 RVA: 0x00F32AD8 File Offset: 0x00F30CD8
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

		// Token: 0x060366F5 RID: 222965 RVA: 0x00F32B58 File Offset: 0x00F30D58
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

		// Token: 0x060366F6 RID: 222966 RVA: 0x00F32C2C File Offset: 0x00F30E2C
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

		// Token: 0x060366F7 RID: 222967 RVA: 0x00F32C9C File Offset: 0x00F30E9C
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

		// Token: 0x060366F8 RID: 222968 RVA: 0x00F32D28 File Offset: 0x00F30F28
		public int GetCurrentFullScore()
		{
			int num = 0;
			foreach (FarmGoldLevelData farmGoldLevelData in this.CurrentLevelData)
			{
				num += farmGoldLevelData.GetPoint();
			}
			return num;
		}

		// Token: 0x060366F9 RID: 222969 RVA: 0x00F32D80 File Offset: 0x00F30F80
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

		// Token: 0x060366FA RID: 222970 RVA: 0x00F32DF8 File Offset: 0x00F30FF8
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

		// Token: 0x060366FB RID: 222971 RVA: 0x00F32E2C File Offset: 0x00F3102C
		public void RestoreDifficultySettings()
		{
			for (int i = 0; i < this.CurrentLevelData.Count; i++)
			{
				FarmGoldLevelData levelData = this.CurrentLevelData[i];
				this.SetDifficultyFromPreviousLevel(levelData, i);
			}
		}

		// Token: 0x060366FC RID: 222972 RVA: 0x00F32E64 File Offset: 0x00F31064
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

		// Token: 0x060366FD RID: 222973 RVA: 0x00F32F90 File Offset: 0x00F31190
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

		// Token: 0x060366FE RID: 222974 RVA: 0x00F3302C File Offset: 0x00F3122C
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

		// Token: 0x060366FF RID: 222975 RVA: 0x00F330EC File Offset: 0x00F312EC
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

		// Token: 0x06036700 RID: 222976 RVA: 0x00F331F0 File Offset: 0x00F313F0
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

		// Token: 0x06036701 RID: 222977 RVA: 0x00F3321D File Offset: 0x00F3141D
		private List<TItem> GetRewardItems(int dropId)
		{
			return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId);
		}

		// Token: 0x06036702 RID: 222978 RVA: 0x00F3322A File Offset: 0x00F3142A
		public override bool GetExDataRedPointShowState()
		{
			return base.GetPreGuideQuestFinishState() && (this.GetIfCanTakeReward() || this.IfHaveNewLevel());
		}

		// Token: 0x06036703 RID: 222979 RVA: 0x00F33248 File Offset: 0x00F31448
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

		// Token: 0x06036704 RID: 222980 RVA: 0x00F332F4 File Offset: 0x00F314F4
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

		// Token: 0x06036705 RID: 222981 RVA: 0x00F33350 File Offset: 0x00F31550
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

		// Token: 0x06036706 RID: 222982 RVA: 0x00F333F0 File Offset: 0x00F315F0
		public bool EntranceRedDot()
		{
			return this.GetExDataRedPointShowState();
		}

		// Token: 0x06036707 RID: 222983 RVA: 0x00F333F8 File Offset: 0x00F315F8
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

		// Token: 0x06036708 RID: 222984 RVA: 0x00F3343A File Offset: 0x00F3163A
		public void RebuildData()
		{
			if (this.CurrentData != null)
			{
				this.PhraseEx(this.CurrentData);
			}
		}

		// Token: 0x06036709 RID: 222985 RVA: 0x00F33450 File Offset: 0x00F31650
		public IActivityRewardViewData GetRewardPopUpViewData()
		{
			this.RebuildData();
			return this.GetRewardViewData();
		}

		// Token: 0x0603670A RID: 222986 RVA: 0x00F33460 File Offset: 0x00F31660
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

		// Token: 0x0603670B RID: 222987 RVA: 0x00F33510 File Offset: 0x00F31710
		public string GetScoreDesc()
		{
			return this.GetCurrentFullScore().ToString();
		}

		// Token: 0x0603670C RID: 222988 RVA: 0x00F3352C File Offset: 0x00F3172C
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

		// Token: 0x0603670D RID: 222989 RVA: 0x00F33618 File Offset: 0x00F31818
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

		// Token: 0x0603670E RID: 222990 RVA: 0x00F33680 File Offset: 0x00F31880
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

		// Token: 0x0603670F RID: 222991 RVA: 0x00F336C4 File Offset: 0x00F318C4
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

		// Token: 0x06036710 RID: 222992 RVA: 0x00F336F4 File Offset: 0x00F318F4
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

		// Token: 0x06036711 RID: 222993 RVA: 0x00F33750 File Offset: 0x00F31950
		public bool HaveRewardCanTake()
		{
			return this.GetIfCanTakeReward();
		}

		// Token: 0x06036712 RID: 222994 RVA: 0x00F33758 File Offset: 0x00F31958
		public void SaveOpenState(int instId)
		{
			FarmGoldLevelData levelInfoByInstId = this.GetLevelInfoByInstId(instId);
			if (levelInfoByInstId != null)
			{
				levelInfoByInstId.SaveOpenState();
			}
		}

		// Token: 0x06036713 RID: 222995 RVA: 0x00F33776 File Offset: 0x00F31976
		public bool GetInsOpenState(int instanceId)
		{
			FarmGoldLevelData levelInfoByInstId = this.GetLevelInfoByInstId(instanceId);
			return levelInfoByInstId != null && levelInfoByInstId.GetNewOpenState();
		}

		// Token: 0x06036714 RID: 222996 RVA: 0x00F3378A File Offset: 0x00F3198A
		public string GetInsUnlockState(int instanceId)
		{
			FarmGoldLevelData levelInfoByInstId = this.GetLevelInfoByInstId(instanceId);
			return ((levelInfoByInstId != null) ? levelInfoByInstId.GetUnlockTimeText() : null) ?? "";
		}

		// Token: 0x06036715 RID: 222997 RVA: 0x00F337A8 File Offset: 0x00F319A8
		public string GetInsUnlockText(int instanceId)
		{
			FarmGoldLevelData levelInfoByInstId = this.GetLevelInfoByInstId(instanceId);
			return ((levelInfoByInstId != null) ? levelInfoByInstId.GetUnlockTimeText() : null) ?? "";
		}

		// Token: 0x06036716 RID: 222998 RVA: 0x00F337C6 File Offset: 0x00F319C6
		public List<FarmGoldLevelData> GetAllLevelData()
		{
			return this.CurrentLevelData;
		}

		// Token: 0x06036717 RID: 222999 RVA: 0x00F337CE File Offset: 0x00F319CE
		[NullableContext(2)]
		public FarmGoldLevelData GetLevelDataByIndex(int index)
		{
			if (index < 0 || index >= this.CurrentLevelData.Count)
			{
				return null;
			}
			return this.CurrentLevelData[index];
		}

		// Token: 0x06036718 RID: 223000 RVA: 0x00F337F0 File Offset: 0x00F319F0
		public string GetLevelNameTextByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetNameText() : null) ?? "";
		}

		// Token: 0x06036719 RID: 223001 RVA: 0x00F3380E File Offset: 0x00F31A0E
		public string GetLevelDescTextByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetDescText() : null) ?? "";
		}

		// Token: 0x0603671A RID: 223002 RVA: 0x00F3382C File Offset: 0x00F31A2C
		public List<int> GetLevelRecommendElementByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetRecommendElement() : null) ?? new List<int>();
		}

		// Token: 0x0603671B RID: 223003 RVA: 0x00F3384A File Offset: 0x00F31A4A
		public string GetLevelSubTitleTextByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetSubTitleText() : null) ?? "";
		}

		// Token: 0x0603671C RID: 223004 RVA: 0x00F33868 File Offset: 0x00F31A68
		public bool GetLevelLockStateByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return levelDataByIndex != null && !levelDataByIndex.GetIsOpen();
		}

		// Token: 0x0603671D RID: 223005 RVA: 0x00F3388B File Offset: 0x00F31A8B
		public int GetLevelInstanceDungeonIdByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			if (levelDataByIndex == null)
			{
				return 0;
			}
			return levelDataByIndex.GetInstId();
		}

		// Token: 0x0603671E RID: 223006 RVA: 0x00F3389F File Offset: 0x00F31A9F
		public string GetLevelUnlockTextByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetUnlockTimeText() : null) ?? "";
		}

		// Token: 0x0603671F RID: 223007 RVA: 0x00F338BD File Offset: 0x00F31ABD
		public bool GetLevelFinishStateByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return levelDataByIndex != null && levelDataByIndex.GetFinishState();
		}

		// Token: 0x06036720 RID: 223008 RVA: 0x00F338D1 File Offset: 0x00F31AD1
		public int GetLevelRecommendLevelByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			if (levelDataByIndex == null)
			{
				return 0;
			}
			return levelDataByIndex.GetRecommendLevel();
		}

		// Token: 0x06036721 RID: 223009 RVA: 0x00F338E5 File Offset: 0x00F31AE5
		public bool GetLevelRedDotStateByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return levelDataByIndex != null && levelDataByIndex.GetRedDotState();
		}

		// Token: 0x06036722 RID: 223010 RVA: 0x00F338FC File Offset: 0x00F31AFC
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

		// Token: 0x06036723 RID: 223011 RVA: 0x00F33934 File Offset: 0x00F31B34
		public string GetLevelBgByIndex(int index)
		{
			FarmGoldLevelData levelDataByIndex = this.GetLevelDataByIndex(index);
			return ((levelDataByIndex != null) ? levelDataByIndex.GetInstanceBg() : null) ?? "";
		}

		// Token: 0x06036724 RID: 223012 RVA: 0x00F33954 File Offset: 0x00F31B54
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

		// Token: 0x06036725 RID: 223013 RVA: 0x00F339C8 File Offset: 0x00F31BC8
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

		// Token: 0x06036726 RID: 223014 RVA: 0x00F33A30 File Offset: 0x00F31C30
		public int GetDifficultRecommendLevel(int difficultId)
		{
			return FarmGoldConfig.Instance.GetFarmGoldDifficultById(difficultId).RecommendedLevel;
		}

		// Token: 0x06036727 RID: 223015 RVA: 0x00F33A50 File Offset: 0x00F31C50
		public void SetInsDifficult(int instId, int difficult)
		{
			FarmGoldLevelData levelInfoByInstId = this.GetLevelInfoByInstId(instId);
			if (levelInfoByInstId != null)
			{
				levelInfoByInstId.SetDifficult(difficult);
			}
		}

		// Token: 0x06036728 RID: 223016 RVA: 0x00F33A70 File Offset: 0x00F31C70
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

		// Token: 0x06036729 RID: 223017 RVA: 0x00F33AD4 File Offset: 0x00F31CD4
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

		// Token: 0x0401CBB6 RID: 117686
		[StaticVariableRuleIgnore]
		public static int CurrentSelectEntranceId;

		// Token: 0x0401CBB7 RID: 117687
		private List<int> FinishPointList = new List<int>();

		// Token: 0x0401CBB8 RID: 117688
		private List<IActivityRewardData> CurrentScoreRewardInfo = new List<IActivityRewardData>();

		// Token: 0x0401CBB9 RID: 117689
		private List<FarmGoldLevelData> CurrentLevelData = new List<FarmGoldLevelData>();

		// Token: 0x0401CBBA RID: 117690
		private List<IActivityRewardData> CurrentLevelRewardInfo = new List<IActivityRewardData>();

		// Token: 0x0401CBBB RID: 117691
		[Nullable(2)]
		private ActivityData CurrentData;
	}
}
