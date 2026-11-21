using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042BF RID: 17087
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityPermanentRogueModel : ModelBase
	{
		// Token: 0x0602B440 RID: 177216 RVA: 0x00C28403 File Offset: 0x00C26603
		protected override bool OnInit()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RogueTaskView, new Func<EUiViewName, object, bool>(this.CanOpenTaskView), "ActivityPermanentRogueModel.CanOpenTaskView");
			return true;
		}

		// Token: 0x0602B441 RID: 177217 RVA: 0x00C28426 File Offset: 0x00C26626
		protected override bool OnClear()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RogueTaskView, new Func<EUiViewName, object, bool>(this.CanOpenTaskView));
			return true;
		}

		// Token: 0x0602B442 RID: 177218 RVA: 0x00C28444 File Offset: 0x00C26644
		public ActivityPermanentRogueData GetActivityData()
		{
			return ActivityModel.Instance.GetActivityById(ActivityPermanentRogueController.Instance.ActivityId) as ActivityPermanentRogueData;
		}

		// Token: 0x0602B443 RID: 177219 RVA: 0x00C2845F File Offset: 0x00C2665F
		public int GetNewSeasonId()
		{
			return this.GetActivityData().GetNewSeasonId();
		}

		// Token: 0x0602B444 RID: 177220 RVA: 0x00C2846C File Offset: 0x00C2666C
		public void InitCurrency(IDictionary<int, int> currencyDict)
		{
			this.CurrencyMap.Clear();
			foreach (int num in currencyDict.Keys)
			{
				int num2 = num;
				int num3 = currencyDict[num];
				this.CurrencyMap[num2] = currencyDict[num];
				EventSystem.Instance.Emit<int>(EEventName.OnPlayerCurrencyChange, num2);
			}
			this.SkillCurrencySet.Clear();
			foreach (RogueResTheme rogueResTheme in ConfigRogueResThemeAll.GetConfigList(true))
			{
				this.SkillCurrencySet[rogueResTheme.SkillItem] = rogueResTheme.Id;
			}
		}

		// Token: 0x0602B445 RID: 177221 RVA: 0x00C28548 File Offset: 0x00C26748
		public void UpdateCurrency(IDictionary<int, int> currencyDict, int? eventType = null)
		{
			foreach (int num in currencyDict.Keys)
			{
				int num2 = num;
				int num3 = currencyDict[num];
				int? num4 = null;
				int value;
				if (this.CurrencyMap.TryGetValue(num2, out value))
				{
					num4 = new int?(value);
				}
				if (this.SkillCurrencySet.ContainsKey(num2))
				{
					EventSystem.Instance.Emit<int>(EEventName.PermanentRogueSkillCurrencyRedDotUpdate, this.SkillCurrencySet[num2]);
					EventSystem.Instance.Emit<int>(EEventName.PermanentRogueSeasonRedDotUpdate, this.SkillCurrencySet[num2]);
				}
				if (num4 != null)
				{
					this.CurrencyMap[num2] = num4.Value + num3;
				}
				else
				{
					this.CurrencyMap[num2] = num3;
				}
				MapRogueGameInfo gameInfo = MapRogueModel.Instance.GameInfo;
				if (gameInfo != null)
				{
					if (gameInfo.InBattle)
					{
						if (num3 > 0)
						{
							ItemHintController.Instance.AddRoguelikeItemList(num2, num3);
						}
					}
					else if (eventType != null)
					{
						IEnumerable<int> enumerable = MapRogueConfig.Instance.GetGlobalParamConfig().Value.ShowCurrencyChangeEventTypeIter();
						bool flag = false;
						using (IEnumerator<int> enumerator2 = enumerable.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current == eventType.Value)
								{
									flag = true;
									break;
								}
							}
						}
						if (flag)
						{
							MapRogueGameInfo gameInfo2 = MapRogueModel.Instance.GameInfo;
							if (gameInfo2 != null)
							{
								gameInfo2.PushGetItemData(num2, num3);
							}
						}
					}
				}
				EventSystem.Instance.Emit<int>(EEventName.OnPlayerCurrencyChange, num2);
			}
		}

		// Token: 0x0602B446 RID: 177222 RVA: 0x00C28710 File Offset: 0x00C26910
		public int GetCurrency(int id)
		{
			int result;
			if (this.CurrencyMap.TryGetValue(id, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0602B447 RID: 177223 RVA: 0x00C28730 File Offset: 0x00C26930
		public int? GetSeasonHelpId(int seasonId)
		{
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(seasonId, true);
			if (config == null)
			{
				return null;
			}
			return new int?(config.Value.HelpId);
		}

		// Token: 0x0602B448 RID: 177224 RVA: 0x00C2876C File Offset: 0x00C2696C
		public bool GetMapNoteShowState()
		{
			ActivityRogueData currentActivityData = ActivityPermanentRogueController.Instance.GetCurrentActivityData();
			if (currentActivityData == null || !currentActivityData.IsUnLock())
			{
				return false;
			}
			if (!currentActivityData.GetPreGuideQuestFinishState())
			{
				return false;
			}
			int newSeasonId = this.GetNewSeasonId();
			int latestDungeon = this.GetLatestDungeon(newSeasonId);
			ExchangeRewardModel instance = ExchangeRewardModel.Instance;
			return instance == null || !instance.IsFinishInstance(latestDungeon);
		}

		// Token: 0x0602B449 RID: 177225 RVA: 0x00C287C0 File Offset: 0x00C269C0
		public int GetCurrentSelectedInst(int seasonId)
		{
			ServerStorageUtil.OverrideLocalMapToServerMap(ELocalStoragePlayerKey.RogueResDungeonSelected, EClientStorageSystemIdType.RogueResDungeonSelected, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResDungeonSelected) as ServerStorageMap).Get(seasonId).GetValueOrDefault();
		}

		// Token: 0x0602B44A RID: 177226 RVA: 0x00C287FC File Offset: 0x00C269FC
		public void SetCurrentSelectedInst(int inst)
		{
			RogueResDungeonConfig? config = ConfigRogueResDungeonConfigById.GetConfig(inst, true);
			if (config == null)
			{
				return;
			}
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResDungeonSelected) as ServerStorageMap).Set(config.Value.SeasonId, inst);
		}

		// Token: 0x0602B44B RID: 177227 RVA: 0x00C28844 File Offset: 0x00C26A44
		public int[] GetTokenCount(int season)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			int[] array = new int[2];
			Dictionary<int, SignState> allIllustratedState = activityData.GetAllIllustratedState();
			HashSet<int> tokenIndexSet = activityData.GetTokenIndexSet(season);
			array[1] = tokenIndexSet.Count;
			foreach (int key in tokenIndexSet)
			{
				array[0] += ((allIllustratedState.ContainsKey(key) && allIllustratedState[key] != SignState.Lock) ? 1 : 0);
			}
			return array;
		}

		// Token: 0x0602B44C RID: 177228 RVA: 0x00C288D8 File Offset: 0x00C26AD8
		public int[] GetEventCount(int season, bool isNormal)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			int[] array = new int[2];
			Dictionary<int, SignState> allIllustratedState = activityData.GetAllIllustratedState();
			HashSet<int> hashSet = isNormal ? activityData.GetNormalIndexSet(season) : activityData.GetMapIndexSet(season);
			array[1] = hashSet.Count;
			foreach (int key in hashSet)
			{
				array[0] += ((allIllustratedState.ContainsKey(key) && allIllustratedState[key] != SignState.Lock) ? 1 : 0);
			}
			return array;
		}

		// Token: 0x0602B44D RID: 177229 RVA: 0x00C28978 File Offset: 0x00C26B78
		public Dictionary<int, int[]> GetTypeIllustratedCountInfo()
		{
			Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();
			foreach (KeyValuePair<int, SignState> keyValuePair in this.GetActivityData().GetAllIllustratedState())
			{
				RogueResCollection? config = ConfigRogueResCollectionByIdKey.GetConfig(keyValuePair.Key, true);
				if (config == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Activity;
					ELogAuthor author = ELogAuthor.WHJ;
					string message = "未找到肉鸽图鉴配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("collectId", keyValuePair.Key);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					int type = config.Value.Type;
					if (!dictionary.ContainsKey(type))
					{
						dictionary[type] = new int[2];
					}
					dictionary[type][1]++;
					dictionary[type][0] += ((keyValuePair.Value > SignState.Lock) ? 1 : 0);
				}
			}
			return dictionary;
		}

		// Token: 0x0602B44E RID: 177230 RVA: 0x00C28A80 File Offset: 0x00C26C80
		public RogueResGainData GetTokenTipsData(int tokenId)
		{
			RogueResGainData result;
			if (this.DetailDataMap.TryGetValue(tokenId, out result))
			{
				return result;
			}
			RogueResGainData rogueResGainData = RogueResGainData.Create();
			rogueResGainData.RogueResToken = RogueResToken.Create();
			rogueResGainData.RogueResToken.IsNew = false;
			rogueResGainData.RogueResToken.ConfigId = tokenId;
			this.DetailDataMap[tokenId] = rogueResGainData;
			return rogueResGainData;
		}

		// Token: 0x0602B44F RID: 177231 RVA: 0x00C28AD6 File Offset: 0x00C26CD6
		public bool CheckIllustratedRedDot()
		{
			return this.GetActivityData().IsIllustratedReward();
		}

		// Token: 0x0602B450 RID: 177232 RVA: 0x00C28AE4 File Offset: 0x00C26CE4
		public HashSet<int> GetTokenIndexSet(RogueResTheme? config)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			if (config == null)
			{
				return activityData.GetTokenIndexSet(ActivityPermanentRogueModel.ALL_SEASON_ID);
			}
			return activityData.GetTokenIndexSet(config.Value.Id);
		}

		// Token: 0x0602B451 RID: 177233 RVA: 0x00C28B24 File Offset: 0x00C26D24
		public HashSet<int> GetNormalIndexSet(RogueResTheme? config)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			if (config == null)
			{
				return activityData.GetNormalIndexSet(ActivityPermanentRogueModel.ALL_SEASON_ID);
			}
			return activityData.GetNormalIndexSet(config.Value.Id);
		}

		// Token: 0x0602B452 RID: 177234 RVA: 0x00C28B64 File Offset: 0x00C26D64
		public HashSet<int> GetMapIndexSet(RogueResTheme? config)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			if (config == null)
			{
				return activityData.GetMapIndexSet(ActivityPermanentRogueModel.ALL_SEASON_ID);
			}
			return activityData.GetMapIndexSet(config.Value.Id);
		}

		// Token: 0x0602B453 RID: 177235 RVA: 0x00C28BA2 File Offset: 0x00C26DA2
		public SignState GetCollectItemState(int index)
		{
			return this.GetActivityData().GetCollectItemState(index);
		}

		// Token: 0x0602B454 RID: 177236 RVA: 0x00C28BB0 File Offset: 0x00C26DB0
		public bool GetHaveTokenAward(int seasonId)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			HashSet<int> tokenIndexSet = activityData.GetTokenIndexSet(seasonId);
			Dictionary<int, SignState> allIllustratedState = activityData.GetAllIllustratedState();
			foreach (int key in tokenIndexSet)
			{
				if (allIllustratedState.ContainsKey(key) && allIllustratedState[key] == SignState.Unlock)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602B455 RID: 177237 RVA: 0x00C28C28 File Offset: 0x00C26E28
		public bool GetHaveNormalAward(int seasonId)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			HashSet<int> normalIndexSet = activityData.GetNormalIndexSet(seasonId);
			Dictionary<int, SignState> allIllustratedState = activityData.GetAllIllustratedState();
			foreach (int key in normalIndexSet)
			{
				if (allIllustratedState.ContainsKey(key) && allIllustratedState[key] == SignState.Unlock)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602B456 RID: 177238 RVA: 0x00C28CA0 File Offset: 0x00C26EA0
		public bool GetHaveMapAward(int seasonId)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			HashSet<int> mapIndexSet = activityData.GetMapIndexSet(seasonId);
			Dictionary<int, SignState> allIllustratedState = activityData.GetAllIllustratedState();
			foreach (int key in mapIndexSet)
			{
				if (allIllustratedState.ContainsKey(key) && allIllustratedState[key] == SignState.Unlock)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602B457 RID: 177239 RVA: 0x00C28D18 File Offset: 0x00C26F18
		public bool GetTaskIsEnd()
		{
			return (double)this.GetTaskEndTime() < TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0602B458 RID: 177240 RVA: 0x00C28D2D File Offset: 0x00C26F2D
		public long GetTaskEndTime()
		{
			return this.GetActivityData().TaskEndTime;
		}

		// Token: 0x0602B459 RID: 177241 RVA: 0x00C28D3C File Offset: 0x00C26F3C
		public int[] GetTaskCount()
		{
			int[] array = new int[2];
			ActivityPermanentRogueData activityData = this.GetActivityData();
			if (activityData.GetTaskThemeId() == 0)
			{
				return array;
			}
			RogueResTaskTheme? config = ConfigRogueResTaskThemeById.GetConfig(activityData.GetTaskThemeId(), true);
			if (config == null)
			{
				return array;
			}
			foreach (DicIntString dicIntString in config.Value.TabNamesIter())
			{
				List<int> taskListByType = activityData.GetTaskListByType(dicIntString.Key);
				array[1] += taskListByType.Count;
				foreach (int configId in taskListByType)
				{
					array[0] += ((activityData.GetTaskById(configId).Status > ActivityTaskState.ActivityTaskRunning) ? 1 : 0);
				}
			}
			return array;
		}

		// Token: 0x0602B45A RID: 177242 RVA: 0x00C28E34 File Offset: 0x00C27034
		public int GetTaskProgressByType(int type)
		{
			int num = 0;
			List<int> taskListById = this.GetTaskListById(type);
			if (taskListById.Count == 0)
			{
				return 0;
			}
			ActivityPermanentRogueData activityData = this.GetActivityData();
			foreach (int configId in taskListById)
			{
				ActivityTaskState status = activityData.GetTaskById(configId).Status;
				num += ((status > ActivityTaskState.ActivityTaskRunning) ? 1 : 0);
			}
			return num / taskListById.Count * 100;
		}

		// Token: 0x0602B45B RID: 177243 RVA: 0x00C28EBC File Offset: 0x00C270BC
		public List<int> GetTaskListById(int id)
		{
			return this.GetActivityData().GetTaskListByType(id);
		}

		// Token: 0x0602B45C RID: 177244 RVA: 0x00C28ECA File Offset: 0x00C270CA
		public RogueTaskData GetTaskById(int id)
		{
			return this.GetActivityData().GetTaskById(id);
		}

		// Token: 0x0602B45D RID: 177245 RVA: 0x00C28ED8 File Offset: 0x00C270D8
		public List<RogueTaskData> GetTaskDataListById(int id)
		{
			List<int> taskListById = this.GetTaskListById(id);
			List<RogueTaskData> list = new List<RogueTaskData>();
			foreach (int id2 in taskListById)
			{
				RogueTaskData taskById = this.GetTaskById(id2);
				list.Add(taskById);
			}
			return list;
		}

		// Token: 0x0602B45E RID: 177246 RVA: 0x00C28F3C File Offset: 0x00C2713C
		public bool CheckAllTaskRedDot()
		{
			if (this.GetTaskIsEnd())
			{
				return false;
			}
			long cacheTaskOpen = this.GetCacheTaskOpen();
			return TimeUtil.Instance.GetServerTime() >= (double)cacheTaskOpen || this.GetActivityData().IsTaskReward();
		}

		// Token: 0x0602B45F RID: 177247 RVA: 0x00C28F78 File Offset: 0x00C27178
		public bool CheckTaskRedDot(int taskTabIndex)
		{
			if (this.CheckTaskExtraRedDot(taskTabIndex))
			{
				return true;
			}
			foreach (int id in this.GetTaskListById(taskTabIndex))
			{
				if (this.GetTaskById(id).Status == ActivityTaskState.ActivityTaskFinish)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602B460 RID: 177248 RVA: 0x00C28FE8 File Offset: 0x00C271E8
		private bool CheckTaskExtraRedDot(int taskTabIndex)
		{
			if (taskTabIndex == 4)
			{
				ActivityPermanentRogueData activityData = this.GetActivityData();
				return activityData != null && activityData.GetFirstCheckRedDotState(EPermanentRogueSaveFlag.NewTaskCheck);
			}
			return false;
		}

		// Token: 0x0602B461 RID: 177249 RVA: 0x00C29002 File Offset: 0x00C27202
		private int TaskStateSwitch(ActivityTaskState a)
		{
			if (a == ActivityTaskState.ActivityTaskFinish)
			{
				return 0;
			}
			if (a == ActivityTaskState.ActivityTaskTaken)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x0602B462 RID: 177250 RVA: 0x00C29011 File Offset: 0x00C27211
		public int SortTaskData(RogueTaskData a, RogueTaskData b)
		{
			if (a.Status == b.Status)
			{
				return a.Id - b.Id;
			}
			return this.TaskStateSwitch(a.Status) - this.TaskStateSwitch(b.Status);
		}

		// Token: 0x0602B463 RID: 177251 RVA: 0x00C29048 File Offset: 0x00C27248
		public List<int> GetTaskRoleList()
		{
			RogueResTaskTheme? config = ConfigRogueResTaskThemeById.GetConfig(this.GetActivityData().GetTaskThemeId(), true);
			if (config == null)
			{
				return new List<int>();
			}
			return new List<int>(config.Value.RoleImageIter());
		}

		// Token: 0x0602B464 RID: 177252 RVA: 0x00C2908C File Offset: 0x00C2728C
		public long GetCacheTaskOpen()
		{
			ServerStorageUtil.OverrideLocalNumberToServerLong(ELocalStoragePlayerKey.RogueResTaskOpen, EClientStorageSystemIdType.RogueResTaskOpen, true);
			long valueOrDefault = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResTaskOpen) as ServerStorageLong).Get().GetValueOrDefault();
			if (valueOrDefault == 0L)
			{
				return -1L;
			}
			return valueOrDefault;
		}

		// Token: 0x0602B465 RID: 177253 RVA: 0x00C290D0 File Offset: 0x00C272D0
		public void SetCacheTaskOpen()
		{
			long value = MathUtils.Instance.LongToNumber(this.GetTaskEndTime());
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResTaskOpen) as ServerStorageLong).Set(new long?(value));
		}

		// Token: 0x0602B466 RID: 177254 RVA: 0x00C2910A File Offset: 0x00C2730A
		private bool CanOpenTaskView(EUiViewName viewName, object param)
		{
			return !ActivityPermanentRogueModel.Instance.GetTaskIsEnd();
		}

		// Token: 0x0602B467 RID: 177255 RVA: 0x00C29119 File Offset: 0x00C27319
		public int? GetCacheDungeonNewest(int seasonId)
		{
			ServerStorageUtil.OverrideLocalMapToServerMap(ELocalStoragePlayerKey.RogueResDungeonNewest, EClientStorageSystemIdType.RogueResDungeonNewest, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResDungeonNewest) as ServerStorageMap).Get(seasonId);
		}

		// Token: 0x0602B468 RID: 177256 RVA: 0x00C29140 File Offset: 0x00C27340
		public void SetCacheDungeonNewest(int seasonId)
		{
			ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResDungeonNewest) as ServerStorageMap;
			int latestDungeon = this.GetLatestDungeon(seasonId);
			serverStorageMap.Set(seasonId, latestDungeon);
		}

		// Token: 0x0602B469 RID: 177257 RVA: 0x00C29170 File Offset: 0x00C27370
		public bool CheckDungeonRedDot(int seasonId)
		{
			int? cacheDungeonNewest = this.GetCacheDungeonNewest(seasonId);
			if (cacheDungeonNewest == null)
			{
				return true;
			}
			int latestDungeon = this.GetLatestDungeon(seasonId);
			int? num = cacheDungeonNewest;
			int num2 = latestDungeon;
			return !(num.GetValueOrDefault() == num2 & num != null);
		}

		// Token: 0x0602B46A RID: 177258 RVA: 0x00C291B0 File Offset: 0x00C273B0
		public int GetLatestDungeon(int seasonId)
		{
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(seasonId, true);
			int result = 0;
			foreach (int num in config.Value.GetInstsArray())
			{
				if (InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(num))
				{
					result = num;
					if (!ExchangeRewardModel.Instance.IsFinishInstance(num))
					{
						return num;
					}
				}
			}
			return result;
		}

		// Token: 0x0602B46B RID: 177259 RVA: 0x00C29210 File Offset: 0x00C27410
		public ERogueResInstState GetInstDungeonState(int instId)
		{
			int instDungeonEndingReachedCount = this.GetInstDungeonEndingReachedCount(instId);
			int num = 0;
			HashSet<int> hashSet;
			if (this.InstEndingMap.TryGetValue(instId, out hashSet))
			{
				num = hashSet.Count;
			}
			if (num == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RogueBattle;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "副本未配置结局数据！";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("instId", instId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return ERogueResInstState.Lock;
			}
			if (instDungeonEndingReachedCount == num)
			{
				return ERogueResInstState.Finished;
			}
			if (!InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(instId))
			{
				return ERogueResInstState.Lock;
			}
			return ERogueResInstState.Unlock;
		}

		// Token: 0x0602B46C RID: 177260 RVA: 0x00C29288 File Offset: 0x00C27488
		public int GetInstDungeonEndingTotalCount(int instId)
		{
			return this.InstEndingMap[instId].Count;
		}

		// Token: 0x0602B46D RID: 177261 RVA: 0x00C2929C File Offset: 0x00C2749C
		public int GetInstDungeonEndingReachedCount(int instId)
		{
			if (!this.InstEndingMap.ContainsKey(instId))
			{
				foreach (RogueResEnd rogueResEnd in ConfigRogueResEndAll.GetConfigList(true))
				{
					int instId2 = rogueResEnd.InstId;
					if (!this.InstEndingMap.ContainsKey(instId2))
					{
						this.InstEndingMap[instId2] = new HashSet<int>();
					}
					this.InstEndingMap[instId2].Add(rogueResEnd.Id);
				}
			}
			int num = 0;
			ActivityPermanentRogueData activityData = this.GetActivityData();
			int seasonId = ConfigRogueResDungeonConfigById.GetConfig(instId, true).Value.SeasonId;
			if (!this.InstEndingMap.ContainsKey(instId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RogueBattle;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "未找到副本相关结局";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InstId", instId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			foreach (int endingId in this.InstEndingMap[instId])
			{
				num += ((activityData.GetEndingReachedById(seasonId, endingId) > false) ? 1 : 0);
			}
			return num;
		}

		// Token: 0x0602B46E RID: 177262 RVA: 0x00C293F0 File Offset: 0x00C275F0
		public int GetLatestDungeonIndex(int seasonId)
		{
			List<int> list = new List<int>(ConfigRogueResThemeById.GetConfig(seasonId, true).Value.GetInstsArray());
			int latestDungeon = this.GetLatestDungeon(seasonId);
			return list.IndexOf(latestDungeon);
		}

		// Token: 0x0602B46F RID: 177263 RVA: 0x00C29428 File Offset: 0x00C27628
		public int GetSkillTreeLevel(int seasonId)
		{
			MapField<int, int> talentSkillDict = this.GetActivityData().GetSeasonDataById(seasonId).TalentSkillDict;
			int num = 0;
			foreach (int key in talentSkillDict.Keys)
			{
				num += ((talentSkillDict[key] > 0) ? talentSkillDict[key] : 0);
			}
			return num;
		}

		// Token: 0x0602B470 RID: 177264 RVA: 0x00C2949C File Offset: 0x00C2769C
		public IDictionary<int, int> GetSkillDict(int seasonId)
		{
			return new Dictionary<int, int>(this.GetActivityData().GetSeasonDataById(seasonId).TalentSkillDict);
		}

		// Token: 0x0602B471 RID: 177265 RVA: 0x00C294B4 File Offset: 0x00C276B4
		public int GetSkillLevelById(int talentId)
		{
			return this.GetActivityData().GetSeasonDataById(ConfigRogueResTalentTreeById.GetConfig(talentId, true).Value.SeasonId).TalentSkillDict[talentId];
		}

		// Token: 0x0602B472 RID: 177266 RVA: 0x00C294F0 File Offset: 0x00C276F0
		public int GetNextCanUnlockSkillId(int seasonId)
		{
			int num = 0;
			MapField<int, int> talentSkillDict = this.GetActivityData().GetSeasonDataById(seasonId).TalentSkillDict;
			int currency = this.GetCurrency(ConfigRogueResThemeById.GetConfig(seasonId, true).Value.SkillItem);
			foreach (int num2 in talentSkillDict.Keys)
			{
				if (talentSkillDict[num2] == 0)
				{
					num = num2;
					if (ConfigRogueResTalentTreeById.GetConfig(num, true).Value.Consule(0) <= currency)
					{
						return num;
					}
				}
				if (num == 0)
				{
					num = num2;
				}
			}
			return num;
		}

		// Token: 0x0602B473 RID: 177267 RVA: 0x00C295A8 File Offset: 0x00C277A8
		public bool GetCacheSkillTreeOpen(int seasonId)
		{
			ServerStorageUtil.OverrideLocalSetToServerSet(ELocalStoragePlayerKey.RogueResSkillTreeOpen, EClientStorageSystemIdType.RogueResSkillTreeOpen, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResSkillTreeOpen) as ServerStorageSet).Has(seasonId);
		}

		// Token: 0x0602B474 RID: 177268 RVA: 0x00C295CF File Offset: 0x00C277CF
		public void SetCacheSkillTreeOpen(int seasonId)
		{
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResSkillTreeOpen) as ServerStorageSet).Add(seasonId);
		}

		// Token: 0x0602B475 RID: 177269 RVA: 0x00C295E8 File Offset: 0x00C277E8
		public bool CheckSkillTreeRedDot(int seasonId)
		{
			if (seasonId == 0)
			{
				return false;
			}
			if (!this.GetCacheSkillTreeOpen(seasonId))
			{
				return true;
			}
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(seasonId, true);
			if (config == null)
			{
				return false;
			}
			int currency = this.GetCurrency(config.Value.SkillItem);
			MapField<int, int> talentSkillDict = this.GetActivityData().GetSeasonDataById(seasonId).TalentSkillDict;
			foreach (int num in talentSkillDict.Keys)
			{
				int num2 = talentSkillDict[num];
				if (num2 == 0 && ConfigRogueResTalentTreeById.GetConfig(num, true).Value.Consule(num2) <= currency)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602B476 RID: 177270 RVA: 0x00C296B8 File Offset: 0x00C278B8
		public void UpdateSkillTreeUnlockState(int skillId)
		{
			this.GetActivityData().UpgradeSkill(skillId, 0);
			EventSystem.Instance.Emit<int>(EEventName.RogueResTalentLevelUp, skillId);
		}

		// Token: 0x0602B477 RID: 177271 RVA: 0x00C296D8 File Offset: 0x00C278D8
		public int[] GetShopCount(int seasonId)
		{
			int[] array = new int[2];
			array[0] = this.GetTotalShopItem(seasonId);
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(seasonId, true);
			array[1] = ((config != null) ? config.GetValueOrDefault().PointItemMax : 0);
			return array;
		}

		// Token: 0x0602B478 RID: 177272 RVA: 0x00C2971C File Offset: 0x00C2791C
		public bool HasShopGoodsSoldOut(int seasonId)
		{
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(seasonId, true);
			if (config == null)
			{
				return true;
			}
			foreach (PayShopGoods payShopGoods in PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)config.Value.ShopId, 1, true))
			{
				PayShopGoodsData goodsData = payShopGoods.GetGoodsData();
				if (goodsData != null && goodsData.HasBuyLimit() && goodsData.GetRemainingCount() != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602B479 RID: 177273 RVA: 0x00C297B4 File Offset: 0x00C279B4
		public bool CheckShopRedDot(int seasonId)
		{
			if (seasonId == 0)
			{
				return false;
			}
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(seasonId, true);
			if (config == null)
			{
				return false;
			}
			List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)config.Value.ShopId, 1, true);
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			foreach (PayShopGoods payShopGoods in payShopTabData)
			{
				PayShopGoodsData goodsData = payShopGoods.GetGoodsData();
				if (goodsData.GetIfCanBuy())
				{
					list2.Add(goodsData.Id);
				}
				list.Add(goodsData.Id);
			}
			list.Sort((int a, int b) => a - b);
			if (!this.GetCacheShopNewGoods(seasonId, string.Join<int>(",", list)))
			{
				return true;
			}
			list2.Sort((int a, int b) => a - b);
			return !this.GetCacheShopOpen(seasonId, string.Join<int>(",", list2));
		}

		// Token: 0x0602B47A RID: 177274 RVA: 0x00C298D8 File Offset: 0x00C27AD8
		public void RefreshShopRedDot(int seasonId)
		{
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(seasonId, true);
			List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)config.Value.ShopId, 1, true);
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			foreach (PayShopGoods payShopGoods in payShopTabData)
			{
				PayShopGoodsData goodsData = payShopGoods.GetGoodsData();
				if (goodsData.GetIfCanBuy())
				{
					list2.Add(goodsData.Id);
				}
				list.Add(goodsData.Id);
			}
			list.Sort((int a, int b) => a - b);
			list2.Sort((int a, int b) => a - b);
			this.SetCacheShopOpen(seasonId, string.Join<int>(",", list2));
			this.SetCacheShopNewGoods(seasonId, string.Join<int>(",", list));
			EventSystem.Instance.Emit<int>(EEventName.PermanentRogueSeasonRedDotUpdate, seasonId);
		}

		// Token: 0x0602B47B RID: 177275 RVA: 0x00C299F8 File Offset: 0x00C27BF8
		public void UpdateTotalShopItem(int season, int count)
		{
			this.GetActivityData().UpdateTotalShopItem(season, count);
		}

		// Token: 0x0602B47C RID: 177276 RVA: 0x00C29A07 File Offset: 0x00C27C07
		public int GetTotalShopItem(int season)
		{
			return this.GetActivityData().GetTotalShopItem(season);
		}

		// Token: 0x0602B47D RID: 177277 RVA: 0x00C29A18 File Offset: 0x00C27C18
		public bool GetCacheShopOpen(int season, string shopData)
		{
			ServerStorageUtil.OverrideLocalStringMapToServerHashMap(ELocalStoragePlayerKey.RogueResShopRefresh, EClientStorageSystemIdType.RogueResShopRefresh, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResShopRefresh) as ServerStorageMap).Get(season).GetValueOrDefault() == UGASBPLibrary.FnvHash(shopData);
		}

		// Token: 0x0602B47E RID: 177278 RVA: 0x00C29A5A File Offset: 0x00C27C5A
		public void SetCacheShopOpen(int season, string shopData)
		{
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResShopRefresh) as ServerStorageMap).Set(season, UGASBPLibrary.FnvHash(shopData));
		}

		// Token: 0x0602B47F RID: 177279 RVA: 0x00C29A7C File Offset: 0x00C27C7C
		public bool GetCacheShopNewGoods(int season, string shopData)
		{
			ServerStorageUtil.OverrideLocalStringMapToServerHashMap(ELocalStoragePlayerKey.RogueResShopNewGoods, EClientStorageSystemIdType.RogueResShopNewGoods, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResShopNewGoods) as ServerStorageMap).Get(season).GetValueOrDefault() == UGASBPLibrary.FnvHash(shopData);
		}

		// Token: 0x0602B480 RID: 177280 RVA: 0x00C29ABE File Offset: 0x00C27CBE
		public void SetCacheShopNewGoods(int season, string shopData)
		{
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResShopNewGoods) as ServerStorageMap).Set(season, UGASBPLibrary.FnvHash(shopData));
		}

		// Token: 0x0602B481 RID: 177281 RVA: 0x00C29ADD File Offset: 0x00C27CDD
		public void SetEndingAwardData(int taskId)
		{
			this.GetActivityData().UpdateEndingAward(taskId);
		}

		// Token: 0x0602B482 RID: 177282 RVA: 0x00C29AEC File Offset: 0x00C27CEC
		public IActivityRewardViewData GetEndingAwardViewData(int seasonId)
		{
			List<IActivityRewardData> list = new List<IActivityRewardData>(this.GetEndingAwardList(seasonId));
			list.Sort(delegate(IActivityRewardData a, IActivityRewardData b)
			{
				if (a.RewardState == b.RewardState)
				{
					RogueResEndAward value = ConfigRogueResEndAwardById.GetConfig(a.Id.Value, true).Value;
					RogueResEndAward value2 = ConfigRogueResEndAwardById.GetConfig(b.Id.Value, true).Value;
					return value.Index - value2.Index;
				}
				return ActivityPermanentRogueModel.<GetEndingAwardViewData>g__stateSwitch|74_0(a.RewardState) - ActivityPermanentRogueModel.<GetEndingAwardViewData>g__stateSwitch|74_0(b.RewardState);
			});
			ActivityRewardDataPage item = new ActivityRewardDataPage
			{
				DataList = list,
				TabName = ConfigMultiTextLang.GetLocalTextNew("Rogue_End_S1_Task_Title", null),
				TabTips = " "
			};
			return new ActivityRewardViewData
			{
				DataPageList = new List<IActivityRewardDataPage>
				{
					item
				},
				Source = EActivityRewardSource.Collection
			};
		}

		// Token: 0x0602B483 RID: 177283 RVA: 0x00C29B76 File Offset: 0x00C27D76
		public List<IActivityRewardData> GetEndingAwardList(int seasonId)
		{
			return this.GetActivityData().GetEndingAwardList(seasonId);
		}

		// Token: 0x0602B484 RID: 177284 RVA: 0x00C29B84 File Offset: 0x00C27D84
		public int[] GetEndingAwardCount(int seasonId)
		{
			List<IActivityRewardData> endingAwardList = this.GetEndingAwardList(seasonId);
			int[] array = new int[]
			{
				0,
				(endingAwardList != null) ? endingAwardList.Count : 0
			};
			if (endingAwardList != null)
			{
				foreach (IActivityRewardData activityRewardData in endingAwardList)
				{
					array[0] += ((activityRewardData.RewardState > EActivityRewardState.Disabled) ? 1 : 0);
				}
			}
			return array;
		}

		// Token: 0x0602B485 RID: 177285 RVA: 0x00C29C04 File Offset: 0x00C27E04
		public bool CheckEndingAwardRedDot(int seasonId)
		{
			List<IActivityRewardData> endingAwardList = this.GetEndingAwardList(seasonId);
			if (endingAwardList != null)
			{
				using (List<IActivityRewardData>.Enumerator enumerator = endingAwardList.GetEnumerator())
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
			return false;
		}

		// Token: 0x0602B486 RID: 177286 RVA: 0x00C29C64 File Offset: 0x00C27E64
		public int[] GetEndingCount(int seasonId)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			int[] array = new int[2];
			List<int> endingListBySeasonId = this.GetEndingListBySeasonId(seasonId);
			array[1] = endingListBySeasonId.Count;
			foreach (int endingId in endingListBySeasonId)
			{
				array[0] += ((activityData.GetEndingReachedById(seasonId, endingId) > false) ? 1 : 0);
			}
			return array;
		}

		// Token: 0x0602B487 RID: 177287 RVA: 0x00C29CE4 File Offset: 0x00C27EE4
		public void SetEndingMainSelectedIndex(int id)
		{
			this.CurEndingSelectedIndex = id;
		}

		// Token: 0x0602B488 RID: 177288 RVA: 0x00C29CED File Offset: 0x00C27EED
		public int GetEndingMainSelectedIndex()
		{
			return this.CurEndingSelectedIndex;
		}

		// Token: 0x0602B489 RID: 177289 RVA: 0x00C29CF8 File Offset: 0x00C27EF8
		public List<int> GetEndingListBySeasonId(int id)
		{
			IEnumerable<RogueResEnd> configList = ConfigRogueResEndAll.GetConfigList(true);
			List<int> list = new List<int>();
			foreach (RogueResEnd rogueResEnd in configList)
			{
				if (rogueResEnd.SeasonId == id)
				{
					list.Add(rogueResEnd.Id);
				}
			}
			return list;
		}

		// Token: 0x0602B48A RID: 177290 RVA: 0x00C29D5C File Offset: 0x00C27F5C
		public bool GetEndingIsUnlock(int id)
		{
			int seasonId = ConfigRogueResEndById.GetConfig(id, true).Value.SeasonId;
			return this.GetActivityData().GetEndingReachedById(seasonId, id);
		}

		// Token: 0x0602B48B RID: 177291 RVA: 0x00C29D8E File Offset: 0x00C27F8E
		public bool GetCacheEndingOpen(int ending)
		{
			ServerStorageUtil.OverrideLocalSetToServerSet(ELocalStoragePlayerKey.RogueResEndingOpen, EClientStorageSystemIdType.RogueResEndingOpen, true);
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResEndingOpen) as ServerStorageSet).Has(ending);
		}

		// Token: 0x0602B48C RID: 177292 RVA: 0x00C29DB5 File Offset: 0x00C27FB5
		public void SetCacheEndingOpen(int ending)
		{
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResEndingOpen) as ServerStorageSet).Add(ending);
			EventSystem.Instance.Emit(EEventName.RogueResEndingRedDotUpdate);
		}

		// Token: 0x0602B48D RID: 177293 RVA: 0x00C29DE0 File Offset: 0x00C27FE0
		public List<int> GetTrailRole(int season, ERogueResTrialType type)
		{
			RogueResSeasonData seasonDataById = this.GetActivityData().GetSeasonDataById(season);
			if (type == ERogueResTrialType.Static)
			{
				if (((seasonDataById != null) ? seasonDataById.StaticTrialRoles : null) == null)
				{
					return new List<int>();
				}
				return new List<int>(seasonDataById.StaticTrialRoles);
			}
			else
			{
				if (((seasonDataById != null) ? seasonDataById.DynamicTrialRoles : null) == null)
				{
					return new List<int>();
				}
				return new List<int>(seasonDataById.DynamicTrialRoles);
			}
		}

		// Token: 0x0602B48E RID: 177294 RVA: 0x00C29E3C File Offset: 0x00C2803C
		public string GetTrailRemainTime(int season)
		{
			RogueResSeasonData seasonDataById = this.GetActivityData().GetSeasonDataById(season);
			long endTime = MathUtils.Instance.LongToNumber(seasonDataById.EndTime);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			return ActivityModel.Instance.GetRemainTimeText(endTime, localTextNew);
		}

		// Token: 0x0602B48F RID: 177295 RVA: 0x00C29E7F File Offset: 0x00C2807F
		public long GetTrailEndTime(int season)
		{
			return this.GetActivityData().GetSeasonDataById(season).EndTime;
		}

		// Token: 0x0602B490 RID: 177296 RVA: 0x00C29E94 File Offset: 0x00C28094
		public long GetCacheTrailOpen(int season)
		{
			this.TryOverrideTrialOpenToServerStorage();
			int? num = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResTrialOpen) as ServerStorageMap).Get(season);
			if (num == null)
			{
				return -1L;
			}
			return (long)num.Value * (long)TimeUtil.Instance.InverseMillisecond;
		}

		// Token: 0x0602B491 RID: 177297 RVA: 0x00C29EE0 File Offset: 0x00C280E0
		private void TryOverrideTrialOpenToServerStorage()
		{
			if (this.HasOverrideTrialOpenServerStorage)
			{
				return;
			}
			this.HasOverrideTrialOpenServerStorage = true;
			Dictionary<int, long> player = LocalStorage.GetPlayer<Dictionary<int, long>>(ELocalStoragePlayerKey.RogueResTrialOpen, null);
			if (player == null)
			{
				return;
			}
			ServerStorageMap serverStorageMap = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResTrialOpen) as ServerStorageMap;
			foreach (KeyValuePair<int, long> keyValuePair in player)
			{
				int num;
				long num2;
				keyValuePair.Deconstruct(out num, out num2);
				int key = num;
				long num3 = num2;
				if (!serverStorageMap.Has(key))
				{
					serverStorageMap.Set(key, (int)(num3 / (long)TimeUtil.Instance.InverseMillisecond));
				}
			}
		}

		// Token: 0x0602B492 RID: 177298 RVA: 0x00C29F8C File Offset: 0x00C2818C
		public void SetCacheTrailOpen(int season)
		{
			int value = (int)(this.GetActivityData().GetSeasonDataById(season).EndTime / (long)TimeUtil.Instance.InverseMillisecond);
			(ServerStorageModel.Instance.Get(EClientStorageSystemIdType.RogueResTrialOpen) as ServerStorageMap).Set(season, value);
		}

		// Token: 0x0602B493 RID: 177299 RVA: 0x00C29FD0 File Offset: 0x00C281D0
		public bool CheckTrialRedDot(int season)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			long cacheTrailOpen = this.GetCacheTrailOpen(season);
			return serverTime >= (double)cacheTrailOpen;
		}

		// Token: 0x170056CF RID: 22223
		// (get) Token: 0x0602B494 RID: 177300 RVA: 0x00C29FF6 File Offset: 0x00C281F6
		public static ActivityPermanentRogueModel Instance
		{
			get
			{
				return ActivityPermanentRogueModel._Instance;
			}
		}

		// Token: 0x0602B495 RID: 177301 RVA: 0x00C29FFD File Offset: 0x00C281FD
		public static ActivityPermanentRogueModel GetOrCreateInstance()
		{
			if (ActivityPermanentRogueModel._Instance == null)
			{
				ActivityPermanentRogueModel.CreateInstance();
			}
			return ActivityPermanentRogueModel._Instance;
		}

		// Token: 0x0602B496 RID: 177302 RVA: 0x00C2A011 File Offset: 0x00C28211
		public static bool CreateInstance()
		{
			if (ActivityPermanentRogueModel._Instance != null)
			{
				return true;
			}
			ActivityPermanentRogueModel._Instance = new ActivityPermanentRogueModel();
			return true;
		}

		// Token: 0x0602B497 RID: 177303 RVA: 0x00C2A027 File Offset: 0x00C28227
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B498 RID: 177304 RVA: 0x00C2A029 File Offset: 0x00C28229
		public static void ResetStaticDefaultValue()
		{
			ActivityPermanentRogueModel._Instance = null;
		}

		// Token: 0x0602B499 RID: 177305 RVA: 0x00C2A031 File Offset: 0x00C28231
		static ActivityPermanentRogueModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityPermanentRogueModel.CreateStaticDefaultValue), new Action(ActivityPermanentRogueModel.ResetStaticDefaultValue));
		}

		// Token: 0x0602B49B RID: 177307 RVA: 0x00C2A084 File Offset: 0x00C28284
		[CompilerGenerated]
		internal static int <GetEndingAwardViewData>g__stateSwitch|74_0(EActivityRewardState a)
		{
			if (a == EActivityRewardState.Enable)
			{
				return 0;
			}
			if (a == EActivityRewardState.Claimed)
			{
				return 2;
			}
			return 1;
		}

		// Token: 0x0401756D RID: 95597
		private static readonly int ALL_SEASON_ID;

		// Token: 0x0401756E RID: 95598
		public int SelectSkillId;

		// Token: 0x0401756F RID: 95599
		private readonly Dictionary<int, int> CurrencyMap = new Dictionary<int, int>();

		// Token: 0x04017570 RID: 95600
		private readonly Dictionary<int, int> SkillCurrencySet = new Dictionary<int, int>();

		// Token: 0x04017571 RID: 95601
		private readonly Dictionary<int, HashSet<int>> InstEndingMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x04017572 RID: 95602
		private readonly Dictionary<int, RogueResGainData> DetailDataMap = new Dictionary<int, RogueResGainData>();

		// Token: 0x04017573 RID: 95603
		private int CurEndingSelectedIndex;

		// Token: 0x04017574 RID: 95604
		private bool HasOverrideTrialOpenServerStorage;

		// Token: 0x04017575 RID: 95605
		[Nullable(2)]
		private static ActivityPermanentRogueModel _Instance;

		// Token: 0x02009FD0 RID: 40912
		[NullableContext(0)]
		private enum ESortPriority
		{
			// Token: 0x04031AA5 RID: 203429
			First,
			// Token: 0x04031AA6 RID: 203430
			Second,
			// Token: 0x04031AA7 RID: 203431
			Third
		}
	}
}
