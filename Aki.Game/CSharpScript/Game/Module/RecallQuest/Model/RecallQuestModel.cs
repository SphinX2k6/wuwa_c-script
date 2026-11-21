using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.RecallQuest.Model
{
	// Token: 0x02003EEA RID: 16106
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RecallQuestModel : ModelBase
	{
		// Token: 0x06028D70 RID: 167280 RVA: 0x00B75E48 File Offset: 0x00B74048
		public void ClearCachedExploreSkill()
		{
			this.CacheRecallExploreSkillId = null;
		}

		// Token: 0x06028D71 RID: 167281 RVA: 0x00B75E58 File Offset: 0x00B74058
		protected override bool OnInit()
		{
			this.ClearCachedExploreSkill();
			this.RecallDataMap.Clear();
			this.InstanceIdsWithSaveDataMap.Clear();
			this.InventoryData.Clear();
			this.HasQueriedItemBag = false;
			this.CurrentRecallId = 0;
			this.CurrentRecallQuestIds.Clear();
			return true;
		}

		// Token: 0x06028D72 RID: 167282 RVA: 0x00B75EA8 File Offset: 0x00B740A8
		protected override bool OnClear()
		{
			this.ClearCachedExploreSkill();
			this.RecallDataMap.Clear();
			this.InstanceIdsWithSaveDataMap.Clear();
			this.InventoryData.Clear();
			this.HasQueriedItemBag = false;
			this.CurrentRecallId = 0;
			this.CurrentRecallQuestIds.Clear();
			return true;
		}

		// Token: 0x06028D73 RID: 167283 RVA: 0x00B75EF8 File Offset: 0x00B740F8
		protected override bool OnLeaveLevel()
		{
			this.ClearCachedExploreSkill();
			if (this.CurrentRecallId > 0 && this.CurrentRecallTrackQuestId == 0)
			{
				if (this.HasQueriedItemBag)
				{
					this.HasQueriedItemBag = false;
					this.InventoryData.Clear();
					InventoryModel.Instance.ResetInventoryDataProxy();
				}
				global::Quest curTrackedQuest = QuestNewModel.Instance.GetCurTrackedQuest();
				if (curTrackedQuest != null)
				{
					if (curTrackedQuest.Type == EQuest.Recall)
					{
						this.CurrentRecallTrackQuestId = ((curTrackedQuest.Id > 0) ? curTrackedQuest.Id : 0);
					}
					curTrackedQuest.SetTrack(false, ESetTrackReason.None);
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.QuestRecall;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "缓存当前回顾跟踪任务Id";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CurrentRecallTrackQuestId", this.CurrentRecallTrackQuestId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return true;
		}

		// Token: 0x06028D74 RID: 167284 RVA: 0x00B75FB0 File Offset: 0x00B741B0
		public void TryReTrackRecallQuest()
		{
			if (this.CurrentRecallTrackQuestId > 0)
			{
				global::Quest quest = QuestNewModel.Instance.GetQuest(this.CurrentRecallTrackQuestId);
				if (quest != null)
				{
					quest.SetTrack(true, ESetTrackReason.None);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.QuestRecall;
					ELogAuthor author = ELogAuthor.YZY;
					string message = "回顾副本：尝试重新追踪之前的任务";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questId", this.CurrentRecallTrackQuestId);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				this.CurrentRecallTrackQuestId = 0;
			}
		}

		// Token: 0x06028D75 RID: 167285 RVA: 0x00B7601C File Offset: 0x00B7421C
		public void SetPastRecallIds(IReadOnlyList<RecallInfo> data)
		{
			this.RecallDataMap.Clear();
			foreach (RecallInfo recallInfo in data)
			{
				int recallId = recallInfo.RecallId;
				ERecallStatus state = (ERecallStatus)recallInfo.State;
				this.RecallDataMap[recallId] = new RecallData(recallId, state);
			}
		}

		// Token: 0x06028D76 RID: 167286 RVA: 0x00B76088 File Offset: 0x00B74288
		public bool IsRecallCanContinue(int recallId)
		{
			RecallData recallData;
			return this.RecallDataMap.TryGetValue(recallId, out recallData) && recallData.Status == ERecallStatus.InProgress;
		}

		// Token: 0x06028D77 RID: 167287 RVA: 0x00B760B4 File Offset: 0x00B742B4
		public bool IsRecallHasData(int recallId)
		{
			RecallData recallData;
			return this.RecallDataMap.TryGetValue(recallId, out recallData) && (recallData.Status == ERecallStatus.Finished || recallData.Status == ERecallStatus.InProgress);
		}

		// Token: 0x06028D78 RID: 167288 RVA: 0x00B760E8 File Offset: 0x00B742E8
		public ERecallStatus GetRecallStatus(int recallId)
		{
			RecallData recallData;
			if (this.RecallDataMap.TryGetValue(recallId, out recallData))
			{
				return recallData.Status;
			}
			return ERecallStatus.InActive;
		}

		// Token: 0x06028D79 RID: 167289 RVA: 0x00B7610D File Offset: 0x00B7430D
		public RecallInventoryData GetInventoryData()
		{
			return this.InventoryData;
		}

		// Token: 0x06028D7A RID: 167290 RVA: 0x00B76115 File Offset: 0x00B74315
		public void ClearInventoryData()
		{
			this.InventoryData.Clear();
		}

		// Token: 0x06028D7B RID: 167291 RVA: 0x00B76124 File Offset: 0x00B74324
		public void SetCurrentRecallId(int recallId)
		{
			this.CurrentRecallId = recallId;
			RecallConfig? recallQuestConfig = RecallQuestConfig.Instance.GetRecallQuestConfig(recallId);
			for (int i = 0; i < recallQuestConfig.Value.RecallQuestsLength; i++)
			{
				DicIntInt? dicIntInt = recallQuestConfig.Value.RecallQuests(i);
				if (dicIntInt != null)
				{
					this.CurrentRecallQuestMap[dicIntInt.Value.Value] = dicIntInt.Value.Key;
				}
			}
		}

		// Token: 0x06028D7C RID: 167292 RVA: 0x00B761A3 File Offset: 0x00B743A3
		public int GetCurrentRecallId()
		{
			return this.CurrentRecallId;
		}

		// Token: 0x06028D7D RID: 167293 RVA: 0x00B761AB File Offset: 0x00B743AB
		public void SetInstanceIdsWithSaveData(int recallId, IEnumerable<int> instanceIds)
		{
			this.InstanceIdsWithSaveDataMap[recallId] = new HashSet<int>(instanceIds);
		}

		// Token: 0x06028D7E RID: 167294 RVA: 0x00B761C0 File Offset: 0x00B743C0
		public bool GetIfInstanceHasSaveData(int instanceId)
		{
			HashSet<int> hashSet;
			return this.InstanceIdsWithSaveDataMap.TryGetValue(this.CurrentRecallId, out hashSet) && hashSet.Contains(instanceId);
		}

		// Token: 0x06028D7F RID: 167295 RVA: 0x00B761EB File Offset: 0x00B743EB
		public void RecordCurrentRecallQuestId(int questId)
		{
			this.CurrentRecallQuestIds.Add(questId);
		}

		// Token: 0x06028D80 RID: 167296 RVA: 0x00B761FC File Offset: 0x00B743FC
		public void RecordCurrentRecallQuestIds(IReadOnlyList<int> questIds)
		{
			foreach (int item in questIds)
			{
				this.CurrentRecallQuestIds.Add(item);
			}
		}

		// Token: 0x06028D81 RID: 167297 RVA: 0x00B7624C File Offset: 0x00B7444C
		public List<int> TakeCurrentRecallQuestIds()
		{
			List<int> result = new List<int>(this.CurrentRecallQuestIds);
			this.CurrentRecallQuestIds.Clear();
			return result;
		}

		// Token: 0x06028D82 RID: 167298 RVA: 0x00B76264 File Offset: 0x00B74464
		public int TryGetRecallQuestIdByQuestId(int questId)
		{
			if (!this.IsInRecallInstance())
			{
				return questId;
			}
			int num;
			this.CurrentRecallQuestMap.TryGetValue(questId, out num);
			if (num == 0)
			{
				return questId;
			}
			return num;
		}

		// Token: 0x06028D83 RID: 167299 RVA: 0x00B76290 File Offset: 0x00B74490
		public int TryGetRecallLevelPlayIdByLevelPlayId(int levelPlayId)
		{
			if (!this.IsInRecallInstance())
			{
				return levelPlayId;
			}
			RecallConfig? currentRecallQuestConfig = this.GetCurrentRecallQuestConfig();
			if (currentRecallQuestConfig == null)
			{
				return levelPlayId;
			}
			for (int i = 0; i < currentRecallQuestConfig.Value.RecallLevelsLength; i++)
			{
				DicIntInt? dicIntInt = currentRecallQuestConfig.Value.RecallLevels(i);
				if (dicIntInt != null && dicIntInt.Value.Value == levelPlayId)
				{
					return dicIntInt.Value.Key;
				}
			}
			return levelPlayId;
		}

		// Token: 0x06028D84 RID: 167300 RVA: 0x00B76314 File Offset: 0x00B74514
		public bool IsInRecallInstance()
		{
			InstanceDungeon? instanceDungeon;
			return ((GameModeModel.Instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().InstType) : null).GetValueOrDefault() == 6;
		}

		// Token: 0x06028D85 RID: 167301 RVA: 0x00B76360 File Offset: 0x00B74560
		public int GetMapId(int? mapId = null)
		{
			if (mapId != null)
			{
				RecallConfig? recallQuestConfig = RecallQuestConfig.Instance.GetRecallQuestConfig(this.CurrentRecallId);
				if (recallQuestConfig != null)
				{
					for (int i = 0; i < recallQuestConfig.Value.DungeonIdMapLength; i++)
					{
						DicIntInt? dicIntInt = recallQuestConfig.Value.DungeonIdMap(i);
						if (dicIntInt != null && dicIntInt.Value.Key == mapId.Value)
						{
							return dicIntInt.Value.Value;
						}
					}
				}
				return mapId.Value;
			}
			int? instanceMapConfigId = InstanceDungeonConfig.Instance.GetInstanceMapConfigId(CreatureModel.Instance.GetInstanceId());
			int? num = instanceMapConfigId;
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				return instanceMapConfigId.Value;
			}
			return CreatureModel.Instance.GetInstanceId();
		}

		// Token: 0x06028D86 RID: 167302 RVA: 0x00B76440 File Offset: 0x00B74640
		public bool CanMissionShowFirstRow()
		{
			if (this.IsInRecallInstance())
			{
				InstanceDungeon? instanceDungeon;
				int? num = (GameModeModel.Instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().InstSubType) : null;
				return num.GetValueOrDefault() != 14 && num.GetValueOrDefault() != 2;
			}
			return false;
		}

		// Token: 0x06028D87 RID: 167303 RVA: 0x00B764A8 File Offset: 0x00B746A8
		public bool CheckIfRecallEntity(int? entityId)
		{
			if (entityId != null)
			{
				int? num = entityId;
				int num2 = 0;
				if (!(num.GetValueOrDefault() == num2 & num != null))
				{
					int instanceId = CreatureModel.Instance.GetInstanceId();
					return RecallQuestConfig.Instance.GetRecallEntityIds(this.GetCurrentRecallId(), instanceId).Contains(entityId.Value);
				}
			}
			return false;
		}

		// Token: 0x06028D88 RID: 167304 RVA: 0x00B76500 File Offset: 0x00B74700
		public HashSet<int> GetCurrentRecallDungeonIdSet()
		{
			HashSet<int> hashSet = new HashSet<int>();
			if (this.CurrentRecallId == 0)
			{
				return hashSet;
			}
			RecallConfig? recallQuestConfig = RecallQuestConfig.Instance.GetRecallQuestConfig(this.CurrentRecallId);
			if (recallQuestConfig == null)
			{
				return hashSet;
			}
			for (int i = 0; i < recallQuestConfig.Value.DungeonIdsLength; i++)
			{
				hashSet.Add(recallQuestConfig.Value.DungeonIds(i));
			}
			return hashSet;
		}

		// Token: 0x06028D89 RID: 167305 RVA: 0x00B7656B File Offset: 0x00B7476B
		public List<int> GetCurrentRecallFunctionIds()
		{
			if (this.CurrentRecallId == 0)
			{
				return new List<int>();
			}
			return this.GetRecallFunctionIds(this.CurrentRecallId);
		}

		// Token: 0x06028D8A RID: 167306 RVA: 0x00B76588 File Offset: 0x00B74788
		public List<int> GetRecallFunctionIds(int recallId)
		{
			RecallConfig? recallQuestConfig = RecallQuestConfig.Instance.GetRecallQuestConfig(recallId);
			List<int> list = new List<int>();
			if (recallQuestConfig == null)
			{
				return list;
			}
			for (int i = 0; i < recallQuestConfig.Value.FunctionIdsLength; i++)
			{
				int num = recallQuestConfig.Value.FunctionIds(i);
				RecallFunction? recallFunctionConfig = RecallQuestConfig.Instance.GetRecallFunctionConfig(num);
				if (recallFunctionConfig != null)
				{
					bool flag = true;
					for (int j = 0; j < recallFunctionConfig.Value.NeedFinishQuestIdsLength; j++)
					{
						int questId = recallFunctionConfig.Value.NeedFinishQuestIds(j);
						if (!QuestNewModel.Instance.CheckQuestFinished(questId))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						list.Add(num);
					}
				}
			}
			list.Sort(delegate(int a, int b)
			{
				RecallFunction? recallFunctionConfig2 = RecallQuestConfig.Instance.GetRecallFunctionConfig(a);
				RecallFunction? recallFunctionConfig3 = RecallQuestConfig.Instance.GetRecallFunctionConfig(b);
				return recallFunctionConfig2.Value.Sort - recallFunctionConfig3.Value.Sort;
			});
			return list;
		}

		// Token: 0x06028D8B RID: 167307 RVA: 0x00B76678 File Offset: 0x00B74878
		public bool CheckRecallRouletteFunction(int functionId)
		{
			IReadOnlyList<RecallRouletteFunc> configList = ConfigRecallRouletteFuncAll.GetConfigList(true);
			if (configList == null)
			{
				return true;
			}
			foreach (RecallRouletteFunc recallRouletteFunc in configList)
			{
				if (recallRouletteFunc.FunctionId == functionId)
				{
					for (int i = 0; i < recallRouletteFunc.NeedFinishQuestIdsLength; i++)
					{
						if (!QuestNewModel.Instance.CheckQuestFinished(recallRouletteFunc.NeedFinishQuestIds(i)))
						{
							return false;
						}
					}
					return true;
				}
			}
			return true;
		}

		// Token: 0x06028D8C RID: 167308 RVA: 0x00B76704 File Offset: 0x00B74904
		public int GetLoadingId()
		{
			if (this.CurrentRecallId == 0)
			{
				return 0;
			}
			return RecallQuestConfig.Instance.GetRecallQuestConfig(this.CurrentRecallId).Value.LoadingId;
		}

		// Token: 0x06028D8D RID: 167309 RVA: 0x00B7673C File Offset: 0x00B7493C
		public string GetBgTexturePath()
		{
			RecallConfig? currentRecallQuestConfig = this.GetCurrentRecallQuestConfig();
			if (currentRecallQuestConfig == null)
			{
				return "";
			}
			int j = 0;
			if (currentRecallQuestConfig.Value.FunctionViewTextureLength > 1 && WorldLevelModel.Instance.Sex == 0)
			{
				j = 1;
			}
			return currentRecallQuestConfig.Value.FunctionViewTexture(j);
		}

		// Token: 0x06028D8E RID: 167310 RVA: 0x00B76794 File Offset: 0x00B74994
		public RecallConfig? GetCurrentRecallQuestConfig()
		{
			if (this.CurrentRecallId == 0)
			{
				return null;
			}
			return RecallQuestConfig.Instance.GetRecallQuestConfig(this.CurrentRecallId);
		}

		// Token: 0x170052F0 RID: 21232
		// (get) Token: 0x06028D8F RID: 167311 RVA: 0x00B767C3 File Offset: 0x00B749C3
		public static RecallQuestModel Instance
		{
			get
			{
				return RecallQuestModel._Instance;
			}
		}

		// Token: 0x06028D90 RID: 167312 RVA: 0x00B767CA File Offset: 0x00B749CA
		public static RecallQuestModel GetOrCreateInstance()
		{
			if (RecallQuestModel._Instance == null)
			{
				RecallQuestModel.CreateInstance();
			}
			return RecallQuestModel._Instance;
		}

		// Token: 0x06028D91 RID: 167313 RVA: 0x00B767DE File Offset: 0x00B749DE
		public static bool CreateInstance()
		{
			if (RecallQuestModel._Instance != null)
			{
				return true;
			}
			RecallQuestModel._Instance = new RecallQuestModel();
			return true;
		}

		// Token: 0x06028D92 RID: 167314 RVA: 0x00B767F4 File Offset: 0x00B749F4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028D93 RID: 167315 RVA: 0x00B767F6 File Offset: 0x00B749F6
		public static void ResetStaticDefaultValue()
		{
			RecallQuestModel._Instance = null;
		}

		// Token: 0x06028D94 RID: 167316 RVA: 0x00B767FE File Offset: 0x00B749FE
		static RecallQuestModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RecallQuestModel.CreateStaticDefaultValue), new Action(RecallQuestModel.ResetStaticDefaultValue));
		}

		// Token: 0x04016360 RID: 90976
		private readonly Dictionary<int, RecallData> RecallDataMap = new Dictionary<int, RecallData>();

		// Token: 0x04016361 RID: 90977
		private readonly Dictionary<int, HashSet<int>> InstanceIdsWithSaveDataMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x04016362 RID: 90978
		private readonly RecallInventoryData InventoryData = new RecallInventoryData();

		// Token: 0x04016363 RID: 90979
		public bool HasQueriedItemBag;

		// Token: 0x04016364 RID: 90980
		private int CurrentRecallId;

		// Token: 0x04016365 RID: 90981
		private readonly Dictionary<int, int> CurrentRecallQuestMap = new Dictionary<int, int>();

		// Token: 0x04016366 RID: 90982
		private readonly HashSet<int> CurrentRecallQuestIds = new HashSet<int>();

		// Token: 0x04016367 RID: 90983
		public int CurrentRecallTrackQuestId;

		// Token: 0x04016368 RID: 90984
		[Nullable(2)]
		public RecallExploreSkillRouletteNotify CacheRecallExploreSkillRouletteData;

		// Token: 0x04016369 RID: 90985
		public int? CacheRecallExploreSkillId;

		// Token: 0x0401636A RID: 90986
		public int RecallExploreSkillRevision;

		// Token: 0x0401636B RID: 90987
		[Nullable(2)]
		private static RecallQuestModel _Instance;
	}
}
