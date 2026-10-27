using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020052EE RID: 21230
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityPermanentRogueData : ActivityBaseData
	{
		// Token: 0x0603651A RID: 222490 RVA: 0x00CD94F8 File Offset: 0x00CD76F8
		protected override bool GetExDataFinishShowState()
		{
			if (!base.GetPreGuideQuestFinishState())
			{
				return false;
			}
			ActivityPermanentRogueModel instance = ActivityPermanentRogueModel.Instance;
			foreach (int seasonId in this.RogueSeasonDataMap.Keys)
			{
				using (List<IActivityRewardData>.Enumerator enumerator2 = instance.GetEndingAwardList(seasonId).GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (enumerator2.Current.RewardState != EActivityRewardState.Claimed)
						{
							return false;
						}
					}
				}
				if (!instance.HasShopGoodsSoldOut(seasonId))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603651B RID: 222491 RVA: 0x00CD95B4 File Offset: 0x00CD77B4
		public override bool GetExDataRedPointShowState()
		{
			if (!base.GetPreGuideQuestFinishState())
			{
				return false;
			}
			if (this.CheckAllRightSideRedDot())
			{
				return true;
			}
			ActivityPermanentRogueModel instance = ActivityPermanentRogueModel.Instance;
			int newSeasonId = this.GetNewSeasonId();
			return instance.CheckAllTaskRedDot() || instance.CheckShopRedDot(newSeasonId);
		}

		// Token: 0x0603651C RID: 222492 RVA: 0x00CD95F6 File Offset: 0x00CD77F6
		public bool GetFirstCheckRedDotState(EPermanentRogueSaveFlag saveFlag)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, (int)saveFlag, 0, 0) == 0;
		}

		// Token: 0x0603651D RID: 222493 RVA: 0x00CD960F File Offset: 0x00CD780F
		public bool SaveFirstCheckRedDotState(EPermanentRogueSaveFlag saveFlag)
		{
			if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, (int)saveFlag, 0, 0) == 1)
			{
				return true;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, (int)saveFlag, 0, 0, 1);
			return false;
		}

		// Token: 0x0603651E RID: 222494 RVA: 0x00CD9644 File Offset: 0x00CD7844
		public bool CheckAllRightSideRedDot()
		{
			if (!base.GetPreGuideQuestFinishState())
			{
				return false;
			}
			int newSeasonId = this.GetNewSeasonId();
			ActivityPermanentRogueModel instance = ActivityPermanentRogueModel.Instance;
			return instance.CheckSkillTreeRedDot(newSeasonId) || instance.CheckIllustratedRedDot() || (instance.CheckEndingAwardRedDot(newSeasonId) || instance.CheckDungeonRedDot(newSeasonId));
		}

		// Token: 0x0603651F RID: 222495 RVA: 0x00CD9694 File Offset: 0x00CD7894
		public bool IsIllustratedReward()
		{
			foreach (KeyValuePair<int, SignState> keyValuePair in this.IllustratedState)
			{
				if (keyValuePair.Value == SignState.Unlock)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06036520 RID: 222496 RVA: 0x00CD96F4 File Offset: 0x00CD78F4
		public bool IsTaskReward()
		{
			if (this.GetFirstCheckRedDotState(EPermanentRogueSaveFlag.NewTaskCheck))
			{
				return true;
			}
			foreach (KeyValuePair<int, RogueTaskData> keyValuePair in this.TaskDataMap)
			{
				if (keyValuePair.Value.Status == ActivityTaskState.ActivityTaskFinish)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06036521 RID: 222497 RVA: 0x00CD9764 File Offset: 0x00CD7964
		protected override void PhraseEx(ActivityData data)
		{
			RogueResActivityData rogueResActivityData = data.RogueResActivityData;
			if (rogueResActivityData == null)
			{
				return;
			}
			foreach (RogueResSeasonData rogueResSeasonData in rogueResActivityData.RogueResSeasonData)
			{
				this.RogueSeasonDataMap[rogueResSeasonData.SeasonId] = rogueResSeasonData;
			}
			this.InitIllustratedData(rogueResActivityData);
			this.InitRogueQuest(rogueResActivityData);
			this.InitEnding(rogueResActivityData.RogueResSeasonData);
			this.InitShopItem(rogueResActivityData.RogueResSeasonData);
		}

		// Token: 0x06036522 RID: 222498 RVA: 0x00CD97F0 File Offset: 0x00CD79F0
		[NullableContext(2)]
		public RogueResSeasonData GetSeasonDataById(int seasonId)
		{
			RogueResSeasonData result;
			if (this.RogueSeasonDataMap.TryGetValue(seasonId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06036523 RID: 222499 RVA: 0x00CD9810 File Offset: 0x00CD7A10
		public int GetNewSeasonId()
		{
			int num = -1;
			foreach (KeyValuePair<int, RogueResSeasonData> keyValuePair in this.RogueSeasonDataMap)
			{
				if (keyValuePair.Key > num)
				{
					num = keyValuePair.Key;
				}
			}
			return num;
		}

		// Token: 0x06036524 RID: 222500 RVA: 0x00CD9874 File Offset: 0x00CD7A74
		public long GetCycleRemainTime()
		{
			int newSeasonId = this.GetNewSeasonId();
			return this.GetSeasonDataById(newSeasonId).EndTime;
		}

		// Token: 0x06036525 RID: 222501 RVA: 0x00CD9894 File Offset: 0x00CD7A94
		private void InitIllustratedData(RogueResActivityData rogueData)
		{
			if (this.IllustratedTokenMap.Count == 0)
			{
				this.InitIllustratedMap();
			}
			foreach (int num in rogueData.RogueResGlobalInfo.Dict.Keys)
			{
				int num2 = num;
				this.IllustratedState[num2] = rogueData.RogueResGlobalInfo.Dict[num];
				RogueResCollection value = ConfigRogueResCollectionByIdKey.GetConfig(num2, true).Value;
				if (value.Type == 0)
				{
					this.SetTokenMapInfo(num2);
				}
				else if (value.Type == 1)
				{
					this.SetNormalMapInfo(num2);
				}
				else
				{
					this.SetMapMapInfo(num2);
				}
			}
		}

		// Token: 0x06036526 RID: 222502 RVA: 0x00CD9954 File Offset: 0x00CD7B54
		private void InitIllustratedMap()
		{
			IReadOnlyList<RogueResTheme> configList = ConfigRogueResThemeAll.GetConfigList(true);
			this.IllustratedTokenMap[0] = new HashSet<int>();
			this.IllustratedNormalMap[0] = new HashSet<int>();
			this.IllustratedMapMap[0] = new HashSet<int>();
			if (configList == null)
			{
				return;
			}
			foreach (RogueResTheme rogueResTheme in configList)
			{
				this.IllustratedTokenMap[rogueResTheme.Id] = new HashSet<int>();
				this.IllustratedNormalMap[rogueResTheme.Id] = new HashSet<int>();
				this.IllustratedMapMap[rogueResTheme.Id] = new HashSet<int>();
			}
		}

		// Token: 0x06036527 RID: 222503 RVA: 0x00CD9A18 File Offset: 0x00CD7C18
		private void SetTokenMapInfo(int tokenIndex)
		{
			this.IllustratedTokenMap[0].Add(tokenIndex);
			RogueResCollectionRule? config = ConfigRogueResCollectionRuleById.GetConfig(ConfigRogueResCollectionByIdKey.GetConfig(tokenIndex, true).Value.RuleId, true);
			bool flag = config == null || config.Value.Type == 2;
			foreach (KeyValuePair<int, HashSet<int>> keyValuePair in this.IllustratedTokenMap)
			{
				int key = keyValuePair.Key;
				if (flag)
				{
					if (config == null || !config.Value.SeasonsIter().Contains(key))
					{
						this.IllustratedTokenMap[key].Add(tokenIndex);
					}
				}
				else if (config != null && config.Value.SeasonsIter().Contains(key))
				{
					this.IllustratedTokenMap[key].Add(tokenIndex);
				}
			}
		}

		// Token: 0x06036528 RID: 222504 RVA: 0x00CD9B38 File Offset: 0x00CD7D38
		private void SetNormalMapInfo(int index)
		{
			this.IllustratedNormalMap[0].Add(index);
			RogueResCollectionRule? config = ConfigRogueResCollectionRuleById.GetConfig(ConfigRogueResCollectionByIdKey.GetConfig(index, true).Value.RuleId, true);
			bool flag = config == null || config.Value.Type == 2;
			foreach (KeyValuePair<int, HashSet<int>> keyValuePair in this.IllustratedNormalMap)
			{
				int key = keyValuePair.Key;
				if (flag)
				{
					if (config == null || !config.Value.SeasonsIter().Contains(key))
					{
						this.IllustratedNormalMap[key].Add(index);
					}
				}
				else if (config != null && config.Value.SeasonsIter().Contains(key))
				{
					this.IllustratedNormalMap[key].Add(index);
				}
			}
		}

		// Token: 0x06036529 RID: 222505 RVA: 0x00CD9C58 File Offset: 0x00CD7E58
		private void SetMapMapInfo(int index)
		{
			this.IllustratedMapMap[0].Add(index);
			RogueResCollectionRule? config = ConfigRogueResCollectionRuleById.GetConfig(ConfigRogueResCollectionByIdKey.GetConfig(index, true).Value.RuleId, true);
			bool flag = config == null || config.Value.Type == 2;
			foreach (KeyValuePair<int, HashSet<int>> keyValuePair in this.IllustratedMapMap)
			{
				int key = keyValuePair.Key;
				if (flag)
				{
					if (config == null || !config.Value.SeasonsIter().Contains(key))
					{
						this.IllustratedMapMap[key].Add(index);
					}
				}
				else if (config != null && config.Value.SeasonsIter().Contains(key))
				{
					this.IllustratedMapMap[key].Add(index);
				}
			}
		}

		// Token: 0x0603652A RID: 222506 RVA: 0x00CD9D78 File Offset: 0x00CD7F78
		public void UpdateIllustrateState(RogueResIllustrationUpdateNotify updateData)
		{
			foreach (int num in updateData.Dict.Keys)
			{
				int num2 = num;
				this.IllustratedState[num2] = updateData.Dict[num];
				RogueResCollection? config = ConfigRogueResCollectionByIdKey.GetConfig(num2, true);
				if (config.Value.Type == 0)
				{
					this.SetTokenMapInfo(num2);
				}
				else if (config.Value.Type == 1)
				{
					this.SetNormalMapInfo(num2);
				}
				else
				{
					this.SetMapMapInfo(num2);
				}
			}
			EventSystem.Instance.Emit(EEventName.PermanentRogueRewardUpdate);
		}

		// Token: 0x0603652B RID: 222507 RVA: 0x00CD9E34 File Offset: 0x00CD8034
		public HashSet<int> GetTokenIndexSet(int seasonId)
		{
			HashSet<int> result;
			if (this.IllustratedTokenMap.TryGetValue(seasonId, out result))
			{
				return result;
			}
			return new HashSet<int>();
		}

		// Token: 0x0603652C RID: 222508 RVA: 0x00CD9E58 File Offset: 0x00CD8058
		public List<int> GetTokenInSeason(int token)
		{
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, HashSet<int>> keyValuePair in this.IllustratedTokenMap)
			{
				if (keyValuePair.Value.Contains(token))
				{
					list.Add(keyValuePair.Key);
				}
			}
			return list;
		}

		// Token: 0x0603652D RID: 222509 RVA: 0x00CD9EC8 File Offset: 0x00CD80C8
		public HashSet<int> GetNormalIndexSet(int seasonId)
		{
			HashSet<int> result;
			if (this.IllustratedNormalMap.TryGetValue(seasonId, out result))
			{
				return result;
			}
			return new HashSet<int>();
		}

		// Token: 0x0603652E RID: 222510 RVA: 0x00CD9EEC File Offset: 0x00CD80EC
		public List<int> GetEventNormalInSeason(int id)
		{
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, HashSet<int>> keyValuePair in this.IllustratedNormalMap)
			{
				if (keyValuePair.Value.Contains(id))
				{
					list.Add(keyValuePair.Key);
				}
			}
			return list;
		}

		// Token: 0x0603652F RID: 222511 RVA: 0x00CD9F5C File Offset: 0x00CD815C
		public HashSet<int> GetMapIndexSet(int seasonId)
		{
			HashSet<int> result;
			if (this.IllustratedMapMap.TryGetValue(seasonId, out result))
			{
				return result;
			}
			return new HashSet<int>();
		}

		// Token: 0x06036530 RID: 222512 RVA: 0x00CD9F80 File Offset: 0x00CD8180
		public List<int> GetEventMapInSeason(int id)
		{
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, HashSet<int>> keyValuePair in this.IllustratedMapMap)
			{
				if (keyValuePair.Value.Contains(id))
				{
					list.Add(keyValuePair.Key);
				}
			}
			return list;
		}

		// Token: 0x06036531 RID: 222513 RVA: 0x00CD9FF0 File Offset: 0x00CD81F0
		public SignState GetCollectItemState(int index)
		{
			if (!this.IllustratedState.ContainsKey(index))
			{
				return SignState.Lock;
			}
			return this.IllustratedState[index];
		}

		// Token: 0x06036532 RID: 222514 RVA: 0x00CDA00E File Offset: 0x00CD820E
		public Dictionary<int, SignState> GetAllIllustratedState()
		{
			return this.IllustratedState;
		}

		// Token: 0x06036533 RID: 222515 RVA: 0x00CDA018 File Offset: 0x00CD8218
		public void SetIllustratedRewardGot(int[] indexList)
		{
			foreach (int key in indexList)
			{
				this.IllustratedState[key] = SignState.IsReceive;
			}
		}

		// Token: 0x06036534 RID: 222516 RVA: 0x00CDA048 File Offset: 0x00CD8248
		private void InitRogueQuest(RogueResActivityData rogueData)
		{
			RogueResTaskUpdateNotify rogueResTaskUpdateNotify = rogueData.RogueResGlobalInfo.RogueResTaskUpdateNotify;
			if (rogueResTaskUpdateNotify.RogueResBranchTaskTheme != null)
			{
				if (rogueResTaskUpdateNotify.RogueResBranchTaskTheme.RogueResTaskThemeId == 0)
				{
					return;
				}
				this.RogueTaskConfigId = rogueResTaskUpdateNotify.RogueResBranchTaskTheme.RogueResTaskThemeId;
				RogueResTaskTheme? config = ConfigRogueResTaskThemeById.GetConfig(this.RogueTaskConfigId, true);
				if (config == null)
				{
					return;
				}
				this.TaskEndTime = rogueResTaskUpdateNotify.RogueResBranchTaskTheme.EndTime;
				this.TaskDataListMap.Clear();
				this.TaskDataMap.Clear();
				foreach (DicIntString dicIntString in config.Value.TabNamesIter())
				{
					this.TaskDataListMap[dicIntString.Key] = new List<int>();
				}
				foreach (ActivityTask activityTask in rogueResTaskUpdateNotify.RogueResBranchTaskTheme.BranchActivityTasks)
				{
					RogueTaskData rogueTaskData = new RogueTaskData(activityTask.Id);
					rogueTaskData.Current = activityTask.Current;
					rogueTaskData.Target = activityTask.Target;
					rogueTaskData.Status = activityTask.Status;
					this.TaskDataMap[activityTask.Id] = rogueTaskData;
					RogueResTask? config2 = ConfigRogueResTaskById.GetConfig(activityTask.Id, true);
					this.TaskDataListMap[config2.Value.Type].Add(activityTask.Id);
				}
			}
		}

		// Token: 0x06036535 RID: 222517 RVA: 0x00CDA1EC File Offset: 0x00CD83EC
		public List<int> GetTaskListByType(int type)
		{
			List<int> result;
			if (this.TaskDataListMap.TryGetValue(type, out result))
			{
				return result;
			}
			return new List<int>();
		}

		// Token: 0x06036536 RID: 222518 RVA: 0x00CDA210 File Offset: 0x00CD8410
		public RogueTaskData GetTaskById(int configId)
		{
			return this.TaskDataMap[configId];
		}

		// Token: 0x06036537 RID: 222519 RVA: 0x00CDA21E File Offset: 0x00CD841E
		public int GetTaskThemeId()
		{
			return this.RogueTaskConfigId;
		}

		// Token: 0x06036538 RID: 222520 RVA: 0x00CDA226 File Offset: 0x00CD8426
		public void SetTaskRewardGot(int configId)
		{
			if (!this.TaskDataMap.ContainsKey(configId))
			{
				return;
			}
			this.TaskDataMap[configId].Status = ActivityTaskState.ActivityTaskTaken;
		}

		// Token: 0x06036539 RID: 222521 RVA: 0x00CDA24C File Offset: 0x00CD844C
		public void UpdateTaskNotify(RogueResTaskUpdateNotify updateData)
		{
			if (updateData.RogueResBranchTaskTheme != null)
			{
				foreach (ActivityTask activityTask in updateData.RogueResBranchTaskTheme.BranchActivityTasks)
				{
					RogueTaskData rogueTaskData = new RogueTaskData(activityTask.Id);
					rogueTaskData.Current = activityTask.Current;
					rogueTaskData.Target = activityTask.Target;
					rogueTaskData.Status = activityTask.Status;
					this.TaskDataMap[activityTask.Id] = rogueTaskData;
					int type = ConfigRogueResTaskById.GetConfig(activityTask.Id, true).Value.Type;
					if (!this.TaskDataListMap[type].Contains(activityTask.Id))
					{
						this.TaskDataListMap[type].Add(activityTask.Id);
					}
				}
				if (updateData.RogueResBranchTaskTheme.RogueResTaskThemeId != 0)
				{
					this.RogueTaskConfigId = updateData.RogueResBranchTaskTheme.RogueResTaskThemeId;
				}
			}
			EventSystem.Instance.Emit(EEventName.PermanentRogueRewardUpdate);
		}

		// Token: 0x0603653A RID: 222522 RVA: 0x00CDA368 File Offset: 0x00CD8568
		private void InitEnding(IList<RogueResSeasonData> seasons)
		{
			foreach (RogueResSeasonData rogueResSeasonData in seasons)
			{
				if (!this.EndingSetMap.ContainsKey(rogueResSeasonData.SeasonId))
				{
					this.EndingSetMap[rogueResSeasonData.SeasonId] = new HashSet<int>();
				}
				foreach (int item in rogueResSeasonData.Endings)
				{
					this.EndingSetMap[rogueResSeasonData.SeasonId].Add(item);
				}
				if (!this.EndingMultiReward.ContainsKey(rogueResSeasonData.SeasonId))
				{
					this.EndingMultiReward[rogueResSeasonData.SeasonId] = new List<int>();
				}
				foreach (ActivityTask activityTask in rogueResSeasonData.EndingRewardIds)
				{
					if (!this.EndingMultiReward[rogueResSeasonData.SeasonId].Contains(activityTask.Id))
					{
						this.EndingMultiReward[rogueResSeasonData.SeasonId].Add(activityTask.Id);
						this.UpdateEndingReward(activityTask);
					}
				}
			}
		}

		// Token: 0x0603653B RID: 222523 RVA: 0x00CDA4F4 File Offset: 0x00CD86F4
		public bool GetEndingReachedById(int seasonId, int endingId)
		{
			HashSet<int> hashSet;
			return this.EndingSetMap.TryGetValue(seasonId, out hashSet) && hashSet.Contains(endingId);
		}

		// Token: 0x0603653C RID: 222524 RVA: 0x00CDA51C File Offset: 0x00CD871C
		public void UpdateEndingAward(int taskId)
		{
			IActivityRewardData activityRewardData = this.EndingMultiRewardState[taskId];
			activityRewardData.RewardState = EActivityRewardState.Claimed;
			this.EndingMultiRewardState[taskId] = activityRewardData;
		}

		// Token: 0x0603653D RID: 222525 RVA: 0x00CDA54C File Offset: 0x00CD874C
		public void UpdateEndingNotify(RogueResEndingUpdateNotify message)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int num in message.Endings)
			{
				RogueResEnd value = ConfigRogueResEndById.GetConfig(num, true).Value;
				if (!this.EndingSetMap.ContainsKey(value.SeasonId))
				{
					this.EndingSetMap[value.SeasonId] = new HashSet<int>();
				}
				this.EndingSetMap[value.SeasonId].Add(num);
			}
			foreach (ActivityTask activityTask in message.EndingRewardIds)
			{
				RogueResEndAward value2 = ConfigRogueResEndAwardById.GetConfig(activityTask.Id, true).Value;
				hashSet.Add(value2.SeasonId);
				if (!this.EndingMultiReward.ContainsKey(value2.SeasonId))
				{
					this.EndingMultiReward[value2.SeasonId] = new List<int>();
				}
				if (!this.EndingMultiReward[value2.SeasonId].Contains(activityTask.Id))
				{
					this.EndingMultiReward[value2.SeasonId].Add(activityTask.Id);
				}
				this.UpdateEndingReward(activityTask);
			}
			foreach (int p in hashSet)
			{
				EventSystem.Instance.Emit<int>(EEventName.PermanentRogueSeasonRedDotUpdate, p);
			}
		}

		// Token: 0x0603653E RID: 222526 RVA: 0x00CDA710 File Offset: 0x00CD8910
		private void UpdateEndingReward(ActivityTask data)
		{
			IActivityRewardData activityRewardData;
			this.EndingMultiRewardState.TryGetValue(data.Id, out activityRewardData);
			string rewardButtonTextId = (this.TaskStateToRewardState[data.Status] == EActivityRewardState.Enable) ? "Moonfiesta_AwardGet" : "Moonfiesta_Underway";
			if (activityRewardData != null)
			{
				IActivityRewardData activityRewardData2 = activityRewardData;
				string[] array = new string[1];
				int num = 0;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Current);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Target);
				array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
				activityRewardData2.NameTextArgs = array;
				activityRewardData.RewardState = this.TaskStateToRewardState[data.Status];
				activityRewardData.RewardButtonTextId = rewardButtonTextId;
			}
			else
			{
				RogueResEndAward config = ConfigRogueResEndAwardById.GetConfig(data.Id, true).Value;
				ActivityRewardData activityRewardData3 = new ActivityRewardData();
				activityRewardData3.Id = new int?(data.Id);
				activityRewardData3.NameText = "";
				activityRewardData3.NameTextId = config.Desc;
				ActivityRewardData activityRewardData4 = activityRewardData3;
				string[] array2 = new string[1];
				int num2 = 0;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Current);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.Target);
				array2[num2] = defaultInterpolatedStringHandler.ToStringAndClear();
				activityRewardData4.NameTextArgs = array2;
				activityRewardData3.RewardList = base.GetPreviewReward(new int?(config.Award)).ToArray();
				activityRewardData3.RewardState = this.TaskStateToRewardState[data.Status];
				activityRewardData3.ClickFunction = delegate()
				{
					ActivityPermanentRogueController.Instance.RequestRogueResEndingReward(config.SeasonId, data.Id, config.Index);
				};
				activityRewardData3.RewardButtonTextId = rewardButtonTextId;
				activityRewardData = activityRewardData3;
			}
			this.EndingMultiRewardState[data.Id] = activityRewardData;
		}

		// Token: 0x0603653F RID: 222527 RVA: 0x00CDA904 File Offset: 0x00CD8B04
		public List<IActivityRewardData> GetEndingAwardList(int seasonId)
		{
			List<int> list;
			if (!this.EndingMultiReward.TryGetValue(seasonId, out list))
			{
				return new List<IActivityRewardData>();
			}
			List<IActivityRewardData> list2 = new List<IActivityRewardData>();
			foreach (int key in list)
			{
				list2.Add(this.EndingMultiRewardState[key]);
			}
			return list2;
		}

		// Token: 0x06036540 RID: 222528 RVA: 0x00CDA97C File Offset: 0x00CD8B7C
		public void InitShopItem(IList<RogueResSeasonData> data)
		{
			foreach (RogueResSeasonData rogueResSeasonData in data)
			{
				this.UpdateTotalShopItem(rogueResSeasonData.SeasonId, rogueResSeasonData.TotalShopItem);
			}
		}

		// Token: 0x06036541 RID: 222529 RVA: 0x00CDA9D0 File Offset: 0x00CD8BD0
		public void UpdateTotalShopItem(int season, int count)
		{
			this.ShopItemCount[season] = count;
		}

		// Token: 0x06036542 RID: 222530 RVA: 0x00CDA9E0 File Offset: 0x00CD8BE0
		public int GetTotalShopItem(int season)
		{
			int result;
			if (this.ShopItemCount.TryGetValue(season, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x06036543 RID: 222531 RVA: 0x00CDAA00 File Offset: 0x00CD8C00
		public void UpgradeSkill(int skillId, int level)
		{
			this.GetSeasonDataById(ConfigRogueResTalentTreeById.GetConfig(skillId, true).Value.SeasonId).TalentSkillDict[skillId] = level;
		}

		// Token: 0x0401CB29 RID: 117545
		private const int ALL_SEASON_ID = 0;

		// Token: 0x0401CB2A RID: 117546
		private readonly Dictionary<ActivityTaskState, EActivityRewardState> TaskStateToRewardState = new Dictionary<ActivityTaskState, EActivityRewardState>
		{
			{
				ActivityTaskState.ActivityTaskRunning,
				EActivityRewardState.Disabled
			},
			{
				ActivityTaskState.ActivityTaskFinish,
				EActivityRewardState.Enable
			},
			{
				ActivityTaskState.ActivityTaskTaken,
				EActivityRewardState.Claimed
			}
		};

		// Token: 0x0401CB2B RID: 117547
		private readonly Dictionary<int, RogueResSeasonData> RogueSeasonDataMap = new Dictionary<int, RogueResSeasonData>();

		// Token: 0x0401CB2C RID: 117548
		private readonly Dictionary<int, SignState> IllustratedState = new Dictionary<int, SignState>();

		// Token: 0x0401CB2D RID: 117549
		private readonly Dictionary<int, HashSet<int>> IllustratedTokenMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401CB2E RID: 117550
		private readonly Dictionary<int, HashSet<int>> IllustratedNormalMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401CB2F RID: 117551
		private readonly Dictionary<int, HashSet<int>> IllustratedMapMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401CB30 RID: 117552
		private readonly Dictionary<int, RogueTaskData> TaskDataMap = new Dictionary<int, RogueTaskData>();

		// Token: 0x0401CB31 RID: 117553
		public long TaskEndTime;

		// Token: 0x0401CB32 RID: 117554
		private readonly Dictionary<int, List<int>> TaskDataListMap = new Dictionary<int, List<int>>();

		// Token: 0x0401CB33 RID: 117555
		private readonly Dictionary<int, HashSet<int>> EndingSetMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401CB34 RID: 117556
		private readonly Dictionary<int, List<int>> EndingMultiReward = new Dictionary<int, List<int>>();

		// Token: 0x0401CB35 RID: 117557
		private readonly Dictionary<int, IActivityRewardData> EndingMultiRewardState = new Dictionary<int, IActivityRewardData>();

		// Token: 0x0401CB36 RID: 117558
		private readonly Dictionary<int, int> ShopItemCount = new Dictionary<int, int>();

		// Token: 0x0401CB37 RID: 117559
		private int RogueTaskConfigId;
	}
}
