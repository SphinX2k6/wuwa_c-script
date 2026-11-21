using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042BE RID: 17086
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityPermanentRogueData : ActivityBaseData
	{
		// Token: 0x0602B415 RID: 177173 RVA: 0x00C26CB8 File Offset: 0x00C24EB8
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

		// Token: 0x0602B416 RID: 177174 RVA: 0x00C26D74 File Offset: 0x00C24F74
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

		// Token: 0x0602B417 RID: 177175 RVA: 0x00C26DB6 File Offset: 0x00C24FB6
		public bool GetFirstCheckRedDotState(EPermanentRogueSaveFlag saveFlag)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, (int)saveFlag, 0, 0) == 0;
		}

		// Token: 0x0602B418 RID: 177176 RVA: 0x00C26DCF File Offset: 0x00C24FCF
		public bool SaveFirstCheckRedDotState(EPermanentRogueSaveFlag saveFlag)
		{
			if (ActivityModel.Instance.GetActivityCacheData(base.Id, 0, (int)saveFlag, 0, 0) == 1)
			{
				return true;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, (int)saveFlag, 0, 0, 1);
			return false;
		}

		// Token: 0x0602B419 RID: 177177 RVA: 0x00C26E04 File Offset: 0x00C25004
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

		// Token: 0x0602B41A RID: 177178 RVA: 0x00C26E54 File Offset: 0x00C25054
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

		// Token: 0x0602B41B RID: 177179 RVA: 0x00C26EB4 File Offset: 0x00C250B4
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

		// Token: 0x0602B41C RID: 177180 RVA: 0x00C26F24 File Offset: 0x00C25124
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

		// Token: 0x0602B41D RID: 177181 RVA: 0x00C26FB0 File Offset: 0x00C251B0
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

		// Token: 0x0602B41E RID: 177182 RVA: 0x00C26FD0 File Offset: 0x00C251D0
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

		// Token: 0x0602B41F RID: 177183 RVA: 0x00C27034 File Offset: 0x00C25234
		public long GetCycleRemainTime()
		{
			int newSeasonId = this.GetNewSeasonId();
			return this.GetSeasonDataById(newSeasonId).EndTime;
		}

		// Token: 0x0602B420 RID: 177184 RVA: 0x00C27054 File Offset: 0x00C25254
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

		// Token: 0x0602B421 RID: 177185 RVA: 0x00C27114 File Offset: 0x00C25314
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

		// Token: 0x0602B422 RID: 177186 RVA: 0x00C271D8 File Offset: 0x00C253D8
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
					bool flag2 = false;
					if (config != null)
					{
						using (IEnumerator<int> enumerator2 = config.Value.SeasonsIter().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current == key)
								{
									flag2 = true;
									break;
								}
							}
						}
					}
					if (!flag2)
					{
						this.IllustratedTokenMap[key].Add(tokenIndex);
					}
				}
				else
				{
					bool flag3 = false;
					if (config != null)
					{
						using (IEnumerator<int> enumerator2 = config.Value.SeasonsIter().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current == key)
								{
									flag3 = true;
									break;
								}
							}
						}
					}
					if (flag3)
					{
						this.IllustratedTokenMap[key].Add(tokenIndex);
					}
				}
			}
		}

		// Token: 0x0602B423 RID: 177187 RVA: 0x00C2736C File Offset: 0x00C2556C
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
					bool flag2 = false;
					if (config != null)
					{
						using (IEnumerator<int> enumerator2 = config.Value.SeasonsIter().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current == key)
								{
									flag2 = true;
									break;
								}
							}
						}
					}
					if (!flag2)
					{
						this.IllustratedNormalMap[key].Add(index);
					}
				}
				else
				{
					bool flag3 = false;
					if (config != null)
					{
						using (IEnumerator<int> enumerator2 = config.Value.SeasonsIter().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current == key)
								{
									flag3 = true;
									break;
								}
							}
						}
					}
					if (flag3)
					{
						this.IllustratedNormalMap[key].Add(index);
					}
				}
			}
		}

		// Token: 0x0602B424 RID: 177188 RVA: 0x00C27500 File Offset: 0x00C25700
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
					bool flag2 = false;
					if (config != null)
					{
						using (IEnumerator<int> enumerator2 = config.Value.SeasonsIter().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current == key)
								{
									flag2 = true;
									break;
								}
							}
						}
					}
					if (!flag2)
					{
						this.IllustratedMapMap[key].Add(index);
					}
				}
				else
				{
					bool flag3 = false;
					if (config != null)
					{
						using (IEnumerator<int> enumerator2 = config.Value.SeasonsIter().GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current == key)
								{
									flag3 = true;
									break;
								}
							}
						}
					}
					if (flag3)
					{
						this.IllustratedMapMap[key].Add(index);
					}
				}
			}
		}

		// Token: 0x0602B425 RID: 177189 RVA: 0x00C27694 File Offset: 0x00C25894
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

		// Token: 0x0602B426 RID: 177190 RVA: 0x00C27750 File Offset: 0x00C25950
		public HashSet<int> GetTokenIndexSet(int seasonId)
		{
			HashSet<int> result;
			if (this.IllustratedTokenMap.TryGetValue(seasonId, out result))
			{
				return result;
			}
			return new HashSet<int>();
		}

		// Token: 0x0602B427 RID: 177191 RVA: 0x00C27774 File Offset: 0x00C25974
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

		// Token: 0x0602B428 RID: 177192 RVA: 0x00C277E4 File Offset: 0x00C259E4
		public HashSet<int> GetNormalIndexSet(int seasonId)
		{
			HashSet<int> result;
			if (this.IllustratedNormalMap.TryGetValue(seasonId, out result))
			{
				return result;
			}
			return new HashSet<int>();
		}

		// Token: 0x0602B429 RID: 177193 RVA: 0x00C27808 File Offset: 0x00C25A08
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

		// Token: 0x0602B42A RID: 177194 RVA: 0x00C27878 File Offset: 0x00C25A78
		public HashSet<int> GetMapIndexSet(int seasonId)
		{
			HashSet<int> result;
			if (this.IllustratedMapMap.TryGetValue(seasonId, out result))
			{
				return result;
			}
			return new HashSet<int>();
		}

		// Token: 0x0602B42B RID: 177195 RVA: 0x00C2789C File Offset: 0x00C25A9C
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

		// Token: 0x0602B42C RID: 177196 RVA: 0x00C2790C File Offset: 0x00C25B0C
		public SignState GetCollectItemState(int index)
		{
			if (!this.IllustratedState.ContainsKey(index))
			{
				return SignState.Lock;
			}
			return this.IllustratedState[index];
		}

		// Token: 0x0602B42D RID: 177197 RVA: 0x00C2792A File Offset: 0x00C25B2A
		public Dictionary<int, SignState> GetAllIllustratedState()
		{
			return this.IllustratedState;
		}

		// Token: 0x0602B42E RID: 177198 RVA: 0x00C27934 File Offset: 0x00C25B34
		public void SetIllustratedRewardGot(int[] indexList)
		{
			foreach (int key in indexList)
			{
				this.IllustratedState[key] = SignState.IsReceive;
			}
		}

		// Token: 0x0602B42F RID: 177199 RVA: 0x00C27964 File Offset: 0x00C25B64
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

		// Token: 0x0602B430 RID: 177200 RVA: 0x00C27B08 File Offset: 0x00C25D08
		public List<int> GetTaskListByType(int type)
		{
			List<int> result;
			if (this.TaskDataListMap.TryGetValue(type, out result))
			{
				return result;
			}
			return new List<int>();
		}

		// Token: 0x0602B431 RID: 177201 RVA: 0x00C27B2C File Offset: 0x00C25D2C
		public RogueTaskData GetTaskById(int configId)
		{
			return this.TaskDataMap[configId];
		}

		// Token: 0x0602B432 RID: 177202 RVA: 0x00C27B3A File Offset: 0x00C25D3A
		public int GetTaskThemeId()
		{
			return this.RogueTaskConfigId;
		}

		// Token: 0x0602B433 RID: 177203 RVA: 0x00C27B42 File Offset: 0x00C25D42
		public void SetTaskRewardGot(int configId)
		{
			if (!this.TaskDataMap.ContainsKey(configId))
			{
				return;
			}
			this.TaskDataMap[configId].Status = ActivityTaskState.ActivityTaskTaken;
		}

		// Token: 0x0602B434 RID: 177204 RVA: 0x00C27B68 File Offset: 0x00C25D68
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

		// Token: 0x0602B435 RID: 177205 RVA: 0x00C27C84 File Offset: 0x00C25E84
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

		// Token: 0x0602B436 RID: 177206 RVA: 0x00C27E10 File Offset: 0x00C26010
		public bool GetEndingReachedById(int seasonId, int endingId)
		{
			HashSet<int> hashSet;
			return this.EndingSetMap.TryGetValue(seasonId, out hashSet) && hashSet.Contains(endingId);
		}

		// Token: 0x0602B437 RID: 177207 RVA: 0x00C27E38 File Offset: 0x00C26038
		public void UpdateEndingAward(int taskId)
		{
			IActivityRewardData activityRewardData = this.EndingMultiRewardState[taskId];
			activityRewardData.RewardState = EActivityRewardState.Claimed;
			this.EndingMultiRewardState[taskId] = activityRewardData;
		}

		// Token: 0x0602B438 RID: 177208 RVA: 0x00C27E68 File Offset: 0x00C26068
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

		// Token: 0x0602B439 RID: 177209 RVA: 0x00C2802C File Offset: 0x00C2622C
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

		// Token: 0x0602B43A RID: 177210 RVA: 0x00C28220 File Offset: 0x00C26420
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

		// Token: 0x0602B43B RID: 177211 RVA: 0x00C28298 File Offset: 0x00C26498
		public void InitShopItem(IList<RogueResSeasonData> data)
		{
			foreach (RogueResSeasonData rogueResSeasonData in data)
			{
				this.UpdateTotalShopItem(rogueResSeasonData.SeasonId, rogueResSeasonData.TotalShopItem);
			}
		}

		// Token: 0x0602B43C RID: 177212 RVA: 0x00C282EC File Offset: 0x00C264EC
		public void UpdateTotalShopItem(int season, int count)
		{
			this.ShopItemCount[season] = count;
		}

		// Token: 0x0602B43D RID: 177213 RVA: 0x00C282FC File Offset: 0x00C264FC
		public int GetTotalShopItem(int season)
		{
			int result;
			if (this.ShopItemCount.TryGetValue(season, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0602B43E RID: 177214 RVA: 0x00C2831C File Offset: 0x00C2651C
		public void UpgradeSkill(int skillId, int level)
		{
			this.GetSeasonDataById(ConfigRogueResTalentTreeById.GetConfig(skillId, true).Value.SeasonId).TalentSkillDict[skillId] = level;
		}

		// Token: 0x0401755E RID: 95582
		private const int ALL_SEASON_ID = 0;

		// Token: 0x0401755F RID: 95583
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

		// Token: 0x04017560 RID: 95584
		private readonly Dictionary<int, RogueResSeasonData> RogueSeasonDataMap = new Dictionary<int, RogueResSeasonData>();

		// Token: 0x04017561 RID: 95585
		private readonly Dictionary<int, SignState> IllustratedState = new Dictionary<int, SignState>();

		// Token: 0x04017562 RID: 95586
		private readonly Dictionary<int, HashSet<int>> IllustratedTokenMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x04017563 RID: 95587
		private readonly Dictionary<int, HashSet<int>> IllustratedNormalMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x04017564 RID: 95588
		private readonly Dictionary<int, HashSet<int>> IllustratedMapMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x04017565 RID: 95589
		private readonly Dictionary<int, RogueTaskData> TaskDataMap = new Dictionary<int, RogueTaskData>();

		// Token: 0x04017566 RID: 95590
		public long TaskEndTime;

		// Token: 0x04017567 RID: 95591
		private readonly Dictionary<int, List<int>> TaskDataListMap = new Dictionary<int, List<int>>();

		// Token: 0x04017568 RID: 95592
		private readonly Dictionary<int, HashSet<int>> EndingSetMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x04017569 RID: 95593
		private readonly Dictionary<int, List<int>> EndingMultiReward = new Dictionary<int, List<int>>();

		// Token: 0x0401756A RID: 95594
		private readonly Dictionary<int, IActivityRewardData> EndingMultiRewardState = new Dictionary<int, IActivityRewardData>();

		// Token: 0x0401756B RID: 95595
		private readonly Dictionary<int, int> ShopItemCount = new Dictionary<int, int>();

		// Token: 0x0401756C RID: 95596
		private int RogueTaskConfigId;
	}
}
