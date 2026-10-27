using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020052EF RID: 21231
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityPermanentRogueModel : ModelBase
	{
		// Token: 0x06036545 RID: 222533 RVA: 0x00CDAAE7 File Offset: 0x00CD8CE7
		protected override bool OnInit()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RogueTaskView, new Func<EUiViewName, object, bool>(this.CanOpenTaskView), "ActivityPermanentRogueModel.CanOpenTaskView");
			return true;
		}

		// Token: 0x06036546 RID: 222534 RVA: 0x00CDAB0A File Offset: 0x00CD8D0A
		protected override bool OnClear()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RogueTaskView, new Func<EUiViewName, object, bool>(this.CanOpenTaskView));
			return true;
		}

		// Token: 0x06036547 RID: 222535 RVA: 0x00CDAB28 File Offset: 0x00CD8D28
		public ActivityPermanentRogueData GetActivityData()
		{
			return ActivityModel.Instance.GetActivityById(ActivityPermanentRogueController.Instance.ActivityId) as ActivityPermanentRogueData;
		}

		// Token: 0x06036548 RID: 222536 RVA: 0x00CDAB43 File Offset: 0x00CD8D43
		public int GetNewSeasonId()
		{
			return this.GetActivityData().GetNewSeasonId();
		}

		// Token: 0x06036549 RID: 222537 RVA: 0x00CDAB50 File Offset: 0x00CD8D50
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

		// Token: 0x0603654A RID: 222538 RVA: 0x00CDAC2C File Offset: 0x00CD8E2C
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
					else if (eventType != null && MapRogueConfig.Instance.GetGlobalParamConfig().Value.ShowCurrencyChangeEventTypeIter().Contains(eventType.Value))
					{
						MapRogueGameInfo gameInfo2 = MapRogueModel.Instance.GameInfo;
						if (gameInfo2 != null)
						{
							gameInfo2.PushGetItemData(num2, num3);
						}
					}
				}
				EventSystem.Instance.Emit<int>(EEventName.OnPlayerCurrencyChange, num2);
			}
		}

		// Token: 0x0603654B RID: 222539 RVA: 0x00CDADA8 File Offset: 0x00CD8FA8
		public int GetCurrency(int id)
		{
			int result;
			if (this.CurrencyMap.TryGetValue(id, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0603654C RID: 222540 RVA: 0x00CDADC8 File Offset: 0x00CD8FC8
		public int? GetSeasonHelpId(int seasonId)
		{
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(seasonId, true);
			if (config == null)
			{
				return null;
			}
			return new int?(config.Value.HelpId);
		}

		// Token: 0x0603654D RID: 222541 RVA: 0x00CDAE04 File Offset: 0x00CD9004
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

		// Token: 0x0603654E RID: 222542 RVA: 0x00CDAE58 File Offset: 0x00CD9058
		public int GetCurrentSelectedInst(int seasonId)
		{
			Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RogueResDungeonSelected, null) ?? null;
			int result;
			if (dictionary != null && dictionary.TryGetValue(seasonId, out result))
			{
				return result;
			}
			return 0;
		}

		// Token: 0x0603654F RID: 222543 RVA: 0x00CDAE88 File Offset: 0x00CD9088
		public void SetCurrentSelectedInst(int inst)
		{
			RogueResDungeonConfig? config = ConfigRogueResDungeonConfigById.GetConfig(inst, true);
			if (config == null)
			{
				return;
			}
			Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RogueResDungeonSelected, null) ?? new Dictionary<int, int>();
			dictionary[config.Value.SeasonId] = inst;
			LocalStorage.SetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RogueResDungeonSelected, dictionary);
		}

		// Token: 0x06036550 RID: 222544 RVA: 0x00CDAEE0 File Offset: 0x00CD90E0
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

		// Token: 0x06036551 RID: 222545 RVA: 0x00CDAF74 File Offset: 0x00CD9174
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

		// Token: 0x06036552 RID: 222546 RVA: 0x00CDB014 File Offset: 0x00CD9214
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

		// Token: 0x06036553 RID: 222547 RVA: 0x00CDB11C File Offset: 0x00CD931C
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

		// Token: 0x06036554 RID: 222548 RVA: 0x00CDB172 File Offset: 0x00CD9372
		public bool CheckIllustratedRedDot()
		{
			return this.GetActivityData().IsIllustratedReward();
		}

		// Token: 0x06036555 RID: 222549 RVA: 0x00CDB180 File Offset: 0x00CD9380
		public HashSet<int> GetTokenIndexSet(RogueResTheme? config)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			if (config == null)
			{
				return activityData.GetTokenIndexSet(ActivityPermanentRogueModel.ALL_SEASON_ID);
			}
			return activityData.GetTokenIndexSet(config.Value.Id);
		}

		// Token: 0x06036556 RID: 222550 RVA: 0x00CDB1C0 File Offset: 0x00CD93C0
		public HashSet<int> GetNormalIndexSet(RogueResTheme? config)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			if (config == null)
			{
				return activityData.GetNormalIndexSet(ActivityPermanentRogueModel.ALL_SEASON_ID);
			}
			return activityData.GetNormalIndexSet(config.Value.Id);
		}

		// Token: 0x06036557 RID: 222551 RVA: 0x00CDB200 File Offset: 0x00CD9400
		public HashSet<int> GetMapIndexSet(RogueResTheme? config)
		{
			ActivityPermanentRogueData activityData = this.GetActivityData();
			if (config == null)
			{
				return activityData.GetMapIndexSet(ActivityPermanentRogueModel.ALL_SEASON_ID);
			}
			return activityData.GetMapIndexSet(config.Value.Id);
		}

		// Token: 0x06036558 RID: 222552 RVA: 0x00CDB23E File Offset: 0x00CD943E
		public SignState GetCollectItemState(int index)
		{
			return this.GetActivityData().GetCollectItemState(index);
		}

		// Token: 0x06036559 RID: 222553 RVA: 0x00CDB24C File Offset: 0x00CD944C
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

		// Token: 0x0603655A RID: 222554 RVA: 0x00CDB2C4 File Offset: 0x00CD94C4
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

		// Token: 0x0603655B RID: 222555 RVA: 0x00CDB33C File Offset: 0x00CD953C
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

		// Token: 0x0603655C RID: 222556 RVA: 0x00CDB3B4 File Offset: 0x00CD95B4
		public bool GetTaskIsEnd()
		{
			return (double)this.GetTaskEndTime() < TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0603655D RID: 222557 RVA: 0x00CDB3C9 File Offset: 0x00CD95C9
		public long GetTaskEndTime()
		{
			return this.GetActivityData().TaskEndTime;
		}

		// Token: 0x0603655E RID: 222558 RVA: 0x00CDB3D8 File Offset: 0x00CD95D8
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

		// Token: 0x0603655F RID: 222559 RVA: 0x00CDB4D0 File Offset: 0x00CD96D0
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

		// Token: 0x06036560 RID: 222560 RVA: 0x00CDB558 File Offset: 0x00CD9758
		public List<int> GetTaskListById(int id)
		{
			return this.GetActivityData().GetTaskListByType(id);
		}

		// Token: 0x06036561 RID: 222561 RVA: 0x00CDB566 File Offset: 0x00CD9766
		public RogueTaskData GetTaskById(int id)
		{
			return this.GetActivityData().GetTaskById(id);
		}

		// Token: 0x06036562 RID: 222562 RVA: 0x00CDB574 File Offset: 0x00CD9774
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

		// Token: 0x06036563 RID: 222563 RVA: 0x00CDB5D8 File Offset: 0x00CD97D8
		public bool CheckAllTaskRedDot()
		{
			if (this.GetTaskIsEnd())
			{
				return false;
			}
			long cacheTaskOpen = this.GetCacheTaskOpen();
			return TimeUtil.Instance.GetServerTime() >= (double)cacheTaskOpen || this.GetActivityData().IsTaskReward();
		}

		// Token: 0x06036564 RID: 222564 RVA: 0x00CDB614 File Offset: 0x00CD9814
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

		// Token: 0x06036565 RID: 222565 RVA: 0x00CDB684 File Offset: 0x00CD9884
		private bool CheckTaskExtraRedDot(int taskTabIndex)
		{
			if (taskTabIndex == 4)
			{
				ActivityPermanentRogueData activityData = this.GetActivityData();
				return activityData != null && activityData.GetFirstCheckRedDotState(EPermanentRogueSaveFlag.NewTaskCheck);
			}
			return false;
		}

		// Token: 0x06036566 RID: 222566 RVA: 0x00CDB69E File Offset: 0x00CD989E
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

		// Token: 0x06036567 RID: 222567 RVA: 0x00CDB6AD File Offset: 0x00CD98AD
		public int SortTaskData(RogueTaskData a, RogueTaskData b)
		{
			if (a.Status == b.Status)
			{
				return a.Id - b.Id;
			}
			return this.TaskStateSwitch(a.Status) - this.TaskStateSwitch(b.Status);
		}

		// Token: 0x06036568 RID: 222568 RVA: 0x00CDB6E4 File Offset: 0x00CD98E4
		public List<int> GetTaskRoleList()
		{
			RogueResTaskTheme? config = ConfigRogueResTaskThemeById.GetConfig(this.GetActivityData().GetTaskThemeId(), true);
			if (config == null)
			{
				return new List<int>();
			}
			return config.Value.RoleImageIter().ToList<int>();
		}

		// Token: 0x06036569 RID: 222569 RVA: 0x00CDB728 File Offset: 0x00CD9928
		public long GetCacheTaskOpen()
		{
			long player = LocalStorage.GetPlayer<long>(ELocalStoragePlayerKey.RogueResTaskOpen, 0L);
			if (player == 0L)
			{
				return -1L;
			}
			return player;
		}

		// Token: 0x0603656A RID: 222570 RVA: 0x00CDB74C File Offset: 0x00CD994C
		public void SetCacheTaskOpen()
		{
			long value = MathUtils.Instance.LongToNumber(this.GetTaskEndTime());
			LocalStorage.SetPlayer<long>(ELocalStoragePlayerKey.RogueResTaskOpen, value);
		}

		// Token: 0x0603656B RID: 222571 RVA: 0x00CDB776 File Offset: 0x00CD9976
		private bool CanOpenTaskView(EUiViewName viewName, object param)
		{
			return !ActivityPermanentRogueModel.Instance.GetTaskIsEnd();
		}

		// Token: 0x0603656C RID: 222572 RVA: 0x00CDB788 File Offset: 0x00CD9988
		public int? GetCacheDungeonNewest(int seasonId)
		{
			Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RogueResDungeonNewest, null) ?? null;
			int value;
			if (dictionary != null && dictionary.TryGetValue(seasonId, out value))
			{
				return new int?(value);
			}
			return null;
		}

		// Token: 0x0603656D RID: 222573 RVA: 0x00CDB7C4 File Offset: 0x00CD99C4
		public void SetCacheDungeonNewest(int seasonId)
		{
			Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RogueResDungeonNewest, null) ?? new Dictionary<int, int>();
			int latestDungeon = this.GetLatestDungeon(seasonId);
			dictionary[seasonId] = latestDungeon;
			LocalStorage.SetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.RogueResDungeonNewest, dictionary);
		}

		// Token: 0x0603656E RID: 222574 RVA: 0x00CDB7FC File Offset: 0x00CD99FC
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

		// Token: 0x0603656F RID: 222575 RVA: 0x00CDB83C File Offset: 0x00CD9A3C
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

		// Token: 0x06036570 RID: 222576 RVA: 0x00CDB89C File Offset: 0x00CD9A9C
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

		// Token: 0x06036571 RID: 222577 RVA: 0x00CDB914 File Offset: 0x00CD9B14
		public int GetInstDungeonEndingTotalCount(int instId)
		{
			return this.InstEndingMap[instId].Count;
		}

		// Token: 0x06036572 RID: 222578 RVA: 0x00CDB928 File Offset: 0x00CD9B28
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

		// Token: 0x06036573 RID: 222579 RVA: 0x00CDBA7C File Offset: 0x00CD9C7C
		public int GetLatestDungeonIndex(int seasonId)
		{
			List<int> list = ConfigRogueResThemeById.GetConfig(seasonId, true).Value.GetInstsArray().ToList<int>();
			int latestDungeon = this.GetLatestDungeon(seasonId);
			return list.IndexOf(latestDungeon);
		}

		// Token: 0x06036574 RID: 222580 RVA: 0x00CDBAB4 File Offset: 0x00CD9CB4
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

		// Token: 0x06036575 RID: 222581 RVA: 0x00CDBB28 File Offset: 0x00CD9D28
		public IDictionary<int, int> GetSkillDict(int seasonId)
		{
			return this.GetActivityData().GetSeasonDataById(seasonId).TalentSkillDict.ToDictionary<int, int>();
		}

		// Token: 0x06036576 RID: 222582 RVA: 0x00CDBB40 File Offset: 0x00CD9D40
		public int GetSkillLevelById(int talentId)
		{
			return this.GetActivityData().GetSeasonDataById(ConfigRogueResTalentTreeById.GetConfig(talentId, true).Value.SeasonId).TalentSkillDict[talentId];
		}

		// Token: 0x06036577 RID: 222583 RVA: 0x00CDBB7C File Offset: 0x00CD9D7C
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

		// Token: 0x06036578 RID: 222584 RVA: 0x00CDBC34 File Offset: 0x00CD9E34
		public bool GetCacheSkillTreeOpen(int seasonId)
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RogueResSkillTreeOpen, null) ?? null;
			return hashSet != null && hashSet.Contains(seasonId);
		}

		// Token: 0x06036579 RID: 222585 RVA: 0x00CDBC60 File Offset: 0x00CD9E60
		public void SetCacheSkillTreeOpen(int seasonId)
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RogueResSkillTreeOpen, null) ?? new HashSet<int>();
			hashSet.Add(seasonId);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RogueResSkillTreeOpen, hashSet);
		}

		// Token: 0x0603657A RID: 222586 RVA: 0x00CDBC98 File Offset: 0x00CD9E98
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

		// Token: 0x0603657B RID: 222587 RVA: 0x00CDBD68 File Offset: 0x00CD9F68
		public void UpdateSkillTreeUnlockState(int skillId)
		{
			this.GetActivityData().UpgradeSkill(skillId, 0);
			EventSystem.Instance.Emit<int>(EEventName.RogueResTalentLevelUp, skillId);
		}

		// Token: 0x0603657C RID: 222588 RVA: 0x00CDBD88 File Offset: 0x00CD9F88
		public int[] GetShopCount(int seasonId)
		{
			int[] array = new int[2];
			array[0] = this.GetTotalShopItem(seasonId);
			RogueResTheme? config = ConfigRogueResThemeById.GetConfig(seasonId, true);
			array[1] = ((config != null) ? config.GetValueOrDefault().PointItemMax : 0);
			return array;
		}

		// Token: 0x0603657D RID: 222589 RVA: 0x00CDBDCC File Offset: 0x00CD9FCC
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

		// Token: 0x0603657E RID: 222590 RVA: 0x00CDBE64 File Offset: 0x00CDA064
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

		// Token: 0x0603657F RID: 222591 RVA: 0x00CDBF88 File Offset: 0x00CDA188
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

		// Token: 0x06036580 RID: 222592 RVA: 0x00CDC0A8 File Offset: 0x00CDA2A8
		public void UpdateTotalShopItem(int season, int count)
		{
			this.GetActivityData().UpdateTotalShopItem(season, count);
		}

		// Token: 0x06036581 RID: 222593 RVA: 0x00CDC0B7 File Offset: 0x00CDA2B7
		public int GetTotalShopItem(int season)
		{
			return this.GetActivityData().GetTotalShopItem(season);
		}

		// Token: 0x06036582 RID: 222594 RVA: 0x00CDC0C8 File Offset: 0x00CDA2C8
		public bool GetCacheShopOpen(int season, string shopData)
		{
			Dictionary<int, string> dictionary = LocalStorage.GetPlayer<Dictionary<int, string>>(ELocalStoragePlayerKey.RogueResShopRefresh, null) ?? null;
			string text;
			return dictionary != null && (dictionary.TryGetValue(season, out text) ? text : "") == shopData;
		}

		// Token: 0x06036583 RID: 222595 RVA: 0x00CDC104 File Offset: 0x00CDA304
		public void SetCacheShopOpen(int season, string shopData)
		{
			Dictionary<int, string> dictionary = LocalStorage.GetPlayer<Dictionary<int, string>>(ELocalStoragePlayerKey.RogueResShopRefresh, null) ?? new Dictionary<int, string>();
			dictionary[season] = shopData;
			LocalStorage.SetPlayer<Dictionary<int, string>>(ELocalStoragePlayerKey.RogueResShopRefresh, dictionary);
		}

		// Token: 0x06036584 RID: 222596 RVA: 0x00CDC13C File Offset: 0x00CDA33C
		public bool GetCacheShopNewGoods(int season, string shopData)
		{
			Dictionary<int, string> dictionary = LocalStorage.GetPlayer<Dictionary<int, string>>(ELocalStoragePlayerKey.RogueResShopNewGoods, null) ?? null;
			string text;
			return dictionary != null && (dictionary.TryGetValue(season, out text) ? text : "") == shopData;
		}

		// Token: 0x06036585 RID: 222597 RVA: 0x00CDC178 File Offset: 0x00CDA378
		public void SetCacheShopNewGoods(int season, string shopData)
		{
			Dictionary<int, string> dictionary = LocalStorage.GetPlayer<Dictionary<int, string>>(ELocalStoragePlayerKey.RogueResShopNewGoods, null) ?? new Dictionary<int, string>();
			dictionary[season] = shopData;
			LocalStorage.SetPlayer<Dictionary<int, string>>(ELocalStoragePlayerKey.RogueResShopNewGoods, dictionary);
		}

		// Token: 0x06036586 RID: 222598 RVA: 0x00CDC1AE File Offset: 0x00CDA3AE
		public void SetEndingAwardData(int taskId)
		{
			this.GetActivityData().UpdateEndingAward(taskId);
		}

		// Token: 0x06036587 RID: 222599 RVA: 0x00CDC1BC File Offset: 0x00CDA3BC
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

		// Token: 0x06036588 RID: 222600 RVA: 0x00CDC246 File Offset: 0x00CDA446
		public List<IActivityRewardData> GetEndingAwardList(int seasonId)
		{
			return this.GetActivityData().GetEndingAwardList(seasonId);
		}

		// Token: 0x06036589 RID: 222601 RVA: 0x00CDC254 File Offset: 0x00CDA454
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

		// Token: 0x0603658A RID: 222602 RVA: 0x00CDC2D4 File Offset: 0x00CDA4D4
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

		// Token: 0x0603658B RID: 222603 RVA: 0x00CDC334 File Offset: 0x00CDA534
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

		// Token: 0x0603658C RID: 222604 RVA: 0x00CDC3B4 File Offset: 0x00CDA5B4
		public void SetEndingMainSelectedIndex(int id)
		{
			this.CurEndingSelectedIndex = id;
		}

		// Token: 0x0603658D RID: 222605 RVA: 0x00CDC3BD File Offset: 0x00CDA5BD
		public int GetEndingMainSelectedIndex()
		{
			return this.CurEndingSelectedIndex;
		}

		// Token: 0x0603658E RID: 222606 RVA: 0x00CDC3C8 File Offset: 0x00CDA5C8
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

		// Token: 0x0603658F RID: 222607 RVA: 0x00CDC42C File Offset: 0x00CDA62C
		public bool GetEndingIsUnlock(int id)
		{
			int seasonId = ConfigRogueResEndById.GetConfig(id, true).Value.SeasonId;
			return this.GetActivityData().GetEndingReachedById(seasonId, id);
		}

		// Token: 0x06036590 RID: 222608 RVA: 0x00CDC460 File Offset: 0x00CDA660
		public bool GetCacheEndingOpen(int ending)
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RogueResEndingOpen, null) ?? null;
			return hashSet != null && hashSet.Contains(ending);
		}

		// Token: 0x06036591 RID: 222609 RVA: 0x00CDC48C File Offset: 0x00CDA68C
		public void SetCacheEndingOpen(int ending)
		{
			HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RogueResEndingOpen, null) ?? new HashSet<int>();
			hashSet.Add(ending);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.RogueResEndingOpen, hashSet);
			EventSystem.Instance.Emit(EEventName.RogueResEndingRedDotUpdate);
		}

		// Token: 0x06036592 RID: 222610 RVA: 0x00CDC4D4 File Offset: 0x00CDA6D4
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

		// Token: 0x06036593 RID: 222611 RVA: 0x00CDC530 File Offset: 0x00CDA730
		public string GetTrailRemainTime(int season)
		{
			RogueResSeasonData seasonDataById = this.GetActivityData().GetSeasonDataById(season);
			long endTime = MathUtils.Instance.LongToNumber(seasonDataById.EndTime);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			return ActivityModel.Instance.GetRemainTimeText(endTime, localTextNew);
		}

		// Token: 0x06036594 RID: 222612 RVA: 0x00CDC573 File Offset: 0x00CDA773
		public long GetTrailEndTime(int season)
		{
			return this.GetActivityData().GetSeasonDataById(season).EndTime;
		}

		// Token: 0x06036595 RID: 222613 RVA: 0x00CDC588 File Offset: 0x00CDA788
		public long GetCacheTrailOpen(int season)
		{
			Dictionary<int, long> dictionary = LocalStorage.GetPlayer<Dictionary<int, long>>(ELocalStoragePlayerKey.RogueResTrialOpen, null) ?? null;
			if (dictionary == null)
			{
				return -1L;
			}
			return dictionary.GetValueOrDefault(season, -1L);
		}

		// Token: 0x06036596 RID: 222614 RVA: 0x00CDC5B8 File Offset: 0x00CDA7B8
		public void SetCacheTrailOpen(int season)
		{
			Dictionary<int, long> dictionary = LocalStorage.GetPlayer<Dictionary<int, long>>(ELocalStoragePlayerKey.RogueResTrialOpen, null) ?? new Dictionary<int, long>();
			long endTime = this.GetActivityData().GetSeasonDataById(season).EndTime;
			dictionary[season] = endTime;
			LocalStorage.SetPlayer<Dictionary<int, long>>(ELocalStoragePlayerKey.RogueResTrialOpen, dictionary);
		}

		// Token: 0x06036597 RID: 222615 RVA: 0x00CDC600 File Offset: 0x00CDA800
		public bool CheckTrialRedDot(int season)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			long cacheTrailOpen = this.GetCacheTrailOpen(season);
			return serverTime >= (double)cacheTrailOpen;
		}

		// Token: 0x1700830F RID: 33551
		// (get) Token: 0x06036598 RID: 222616 RVA: 0x00CDC626 File Offset: 0x00CDA826
		public static ActivityPermanentRogueModel Instance
		{
			get
			{
				return ActivityPermanentRogueModel._Instance;
			}
		}

		// Token: 0x06036599 RID: 222617 RVA: 0x00CDC62D File Offset: 0x00CDA82D
		public static ActivityPermanentRogueModel GetOrCreateInstance()
		{
			if (ActivityPermanentRogueModel._Instance == null)
			{
				ActivityPermanentRogueModel.CreateInstance();
			}
			return ActivityPermanentRogueModel._Instance;
		}

		// Token: 0x0603659A RID: 222618 RVA: 0x00CDC641 File Offset: 0x00CDA841
		public static bool CreateInstance()
		{
			if (ActivityPermanentRogueModel._Instance != null)
			{
				return true;
			}
			ActivityPermanentRogueModel._Instance = new ActivityPermanentRogueModel();
			return true;
		}

		// Token: 0x0603659B RID: 222619 RVA: 0x00CDC657 File Offset: 0x00CDA857
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603659C RID: 222620 RVA: 0x00CDC659 File Offset: 0x00CDA859
		public static void ResetStaticDefaultValue()
		{
			ActivityPermanentRogueModel._Instance = null;
		}

		// Token: 0x0603659D RID: 222621 RVA: 0x00CDC661 File Offset: 0x00CDA861
		static ActivityPermanentRogueModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityPermanentRogueModel.CreateStaticDefaultValue), new Action(ActivityPermanentRogueModel.ResetStaticDefaultValue));
		}

		// Token: 0x0603659F RID: 222623 RVA: 0x00CDC6B4 File Offset: 0x00CDA8B4
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

		// Token: 0x0401CB38 RID: 117560
		private static readonly int ALL_SEASON_ID;

		// Token: 0x0401CB39 RID: 117561
		public int SelectSkillId;

		// Token: 0x0401CB3A RID: 117562
		private readonly Dictionary<int, int> CurrencyMap = new Dictionary<int, int>();

		// Token: 0x0401CB3B RID: 117563
		private readonly Dictionary<int, int> SkillCurrencySet = new Dictionary<int, int>();

		// Token: 0x0401CB3C RID: 117564
		private readonly Dictionary<int, HashSet<int>> InstEndingMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401CB3D RID: 117565
		private readonly Dictionary<int, RogueResGainData> DetailDataMap = new Dictionary<int, RogueResGainData>();

		// Token: 0x0401CB3E RID: 117566
		private int CurEndingSelectedIndex;

		// Token: 0x0401CB3F RID: 117567
		[Nullable(2)]
		private static ActivityPermanentRogueModel _Instance;

		// Token: 0x0200B598 RID: 46488
		[NullableContext(0)]
		private enum ESortPriority
		{
			// Token: 0x04037053 RID: 225363
			First,
			// Token: 0x04037054 RID: 225364
			Second,
			// Token: 0x04037055 RID: 225365
			Third
		}
	}
}
