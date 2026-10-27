using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.RecallQuest.Model
{
	// Token: 0x02004F21 RID: 20257
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RecallQuestModel : ModelBase
	{
		// Token: 0x06033F05 RID: 212741 RVA: 0x00C2C7D4 File Offset: 0x00C2A9D4
		protected override bool OnInit()
		{
			this.RecallDataMap.Clear();
			this.InstanceIdsWithSaveDataMap.Clear();
			this.InventoryData.Clear();
			this.HasQueriedItemBag = false;
			this.CurrentRecallId = 0;
			this.CurrentRecallQuestIds.Clear();
			return true;
		}

		// Token: 0x06033F06 RID: 212742 RVA: 0x00C2C811 File Offset: 0x00C2AA11
		protected override bool OnClear()
		{
			this.RecallDataMap.Clear();
			this.InstanceIdsWithSaveDataMap.Clear();
			this.InventoryData.Clear();
			this.HasQueriedItemBag = false;
			this.CurrentRecallId = 0;
			this.CurrentRecallQuestIds.Clear();
			return true;
		}

		// Token: 0x06033F07 RID: 212743 RVA: 0x00C2C850 File Offset: 0x00C2AA50
		protected override bool OnLeaveLevel()
		{
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

		// Token: 0x06033F08 RID: 212744 RVA: 0x00C2C904 File Offset: 0x00C2AB04
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

		// Token: 0x06033F09 RID: 212745 RVA: 0x00C2C970 File Offset: 0x00C2AB70
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

		// Token: 0x06033F0A RID: 212746 RVA: 0x00C2C9DC File Offset: 0x00C2ABDC
		public bool IsRecallCanContinue(int recallId)
		{
			RecallData recallData;
			return this.RecallDataMap.TryGetValue(recallId, out recallData) && recallData.Status == ERecallStatus.InProgress;
		}

		// Token: 0x06033F0B RID: 212747 RVA: 0x00C2CA08 File Offset: 0x00C2AC08
		public bool IsRecallHasData(int recallId)
		{
			RecallData recallData;
			return this.RecallDataMap.TryGetValue(recallId, out recallData) && (recallData.Status == ERecallStatus.Finished || recallData.Status == ERecallStatus.InProgress);
		}

		// Token: 0x06033F0C RID: 212748 RVA: 0x00C2CA3C File Offset: 0x00C2AC3C
		public ERecallStatus GetRecallStatus(int recallId)
		{
			RecallData recallData;
			if (this.RecallDataMap.TryGetValue(recallId, out recallData))
			{
				return recallData.Status;
			}
			return ERecallStatus.InActive;
		}

		// Token: 0x06033F0D RID: 212749 RVA: 0x00C2CA61 File Offset: 0x00C2AC61
		public RecallInventoryData GetInventoryData()
		{
			return this.InventoryData;
		}

		// Token: 0x06033F0E RID: 212750 RVA: 0x00C2CA69 File Offset: 0x00C2AC69
		public void ClearInventoryData()
		{
			this.InventoryData.Clear();
		}

		// Token: 0x06033F0F RID: 212751 RVA: 0x00C2CA78 File Offset: 0x00C2AC78
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

		// Token: 0x06033F10 RID: 212752 RVA: 0x00C2CAF7 File Offset: 0x00C2ACF7
		public int GetCurrentRecallId()
		{
			return this.CurrentRecallId;
		}

		// Token: 0x06033F11 RID: 212753 RVA: 0x00C2CAFF File Offset: 0x00C2ACFF
		public void SetInstanceIdsWithSaveData(int recallId, IEnumerable<int> instanceIds)
		{
			this.InstanceIdsWithSaveDataMap[recallId] = new HashSet<int>(instanceIds);
		}

		// Token: 0x06033F12 RID: 212754 RVA: 0x00C2CB14 File Offset: 0x00C2AD14
		public bool GetIfInstanceHasSaveData(int instanceId)
		{
			HashSet<int> hashSet;
			return this.InstanceIdsWithSaveDataMap.TryGetValue(this.CurrentRecallId, out hashSet) && hashSet.Contains(instanceId);
		}

		// Token: 0x06033F13 RID: 212755 RVA: 0x00C2CB3F File Offset: 0x00C2AD3F
		public void RecordCurrentRecallQuestId(int questId)
		{
			this.CurrentRecallQuestIds.Add(questId);
		}

		// Token: 0x06033F14 RID: 212756 RVA: 0x00C2CB50 File Offset: 0x00C2AD50
		public void RecordCurrentRecallQuestIds(IReadOnlyList<int> questIds)
		{
			foreach (int item in questIds)
			{
				this.CurrentRecallQuestIds.Add(item);
			}
		}

		// Token: 0x06033F15 RID: 212757 RVA: 0x00C2CBA0 File Offset: 0x00C2ADA0
		public List<int> TakeCurrentRecallQuestIds()
		{
			List<int> result = new List<int>(this.CurrentRecallQuestIds);
			this.CurrentRecallQuestIds.Clear();
			return result;
		}

		// Token: 0x06033F16 RID: 212758 RVA: 0x00C2CBB8 File Offset: 0x00C2ADB8
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

		// Token: 0x06033F17 RID: 212759 RVA: 0x00C2CBE4 File Offset: 0x00C2ADE4
		public bool IsInRecallInstance()
		{
			InstanceDungeon? instanceDungeon;
			return ((GameModeModel.Instance.InstanceDungeon != null) ? new int?(instanceDungeon.GetValueOrDefault().InstType) : null).GetValueOrDefault() == 6;
		}

		// Token: 0x06033F18 RID: 212760 RVA: 0x00C2CC30 File Offset: 0x00C2AE30
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

		// Token: 0x06033F19 RID: 212761 RVA: 0x00C2CD10 File Offset: 0x00C2AF10
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

		// Token: 0x06033F1A RID: 212762 RVA: 0x00C2CD78 File Offset: 0x00C2AF78
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

		// Token: 0x06033F1B RID: 212763 RVA: 0x00C2CDD0 File Offset: 0x00C2AFD0
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

		// Token: 0x06033F1C RID: 212764 RVA: 0x00C2CE3B File Offset: 0x00C2B03B
		public List<int> GetCurrentRecallFunctionIds()
		{
			if (this.CurrentRecallId == 0)
			{
				return new List<int>();
			}
			return this.GetRecallFunctionIds(this.CurrentRecallId);
		}

		// Token: 0x06033F1D RID: 212765 RVA: 0x00C2CE58 File Offset: 0x00C2B058
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

		// Token: 0x06033F1E RID: 212766 RVA: 0x00C2CF48 File Offset: 0x00C2B148
		public int GetLoadingId()
		{
			if (this.CurrentRecallId == 0)
			{
				return 0;
			}
			return RecallQuestConfig.Instance.GetRecallQuestConfig(this.CurrentRecallId).Value.LoadingId;
		}

		// Token: 0x06033F1F RID: 212767 RVA: 0x00C2CF80 File Offset: 0x00C2B180
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

		// Token: 0x06033F20 RID: 212768 RVA: 0x00C2CFD8 File Offset: 0x00C2B1D8
		public RecallConfig? GetCurrentRecallQuestConfig()
		{
			if (this.CurrentRecallId == 0)
			{
				return null;
			}
			return RecallQuestConfig.Instance.GetRecallQuestConfig(this.CurrentRecallId);
		}

		// Token: 0x17007F40 RID: 32576
		// (get) Token: 0x06033F21 RID: 212769 RVA: 0x00C2D007 File Offset: 0x00C2B207
		public static RecallQuestModel Instance
		{
			get
			{
				return RecallQuestModel._Instance;
			}
		}

		// Token: 0x06033F22 RID: 212770 RVA: 0x00C2D00E File Offset: 0x00C2B20E
		public static RecallQuestModel GetOrCreateInstance()
		{
			if (RecallQuestModel._Instance == null)
			{
				RecallQuestModel.CreateInstance();
			}
			return RecallQuestModel._Instance;
		}

		// Token: 0x06033F23 RID: 212771 RVA: 0x00C2D022 File Offset: 0x00C2B222
		public static bool CreateInstance()
		{
			if (RecallQuestModel._Instance != null)
			{
				return true;
			}
			RecallQuestModel._Instance = new RecallQuestModel();
			return true;
		}

		// Token: 0x06033F24 RID: 212772 RVA: 0x00C2D038 File Offset: 0x00C2B238
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033F25 RID: 212773 RVA: 0x00C2D03A File Offset: 0x00C2B23A
		public static void ResetStaticDefaultValue()
		{
			RecallQuestModel._Instance = null;
		}

		// Token: 0x06033F26 RID: 212774 RVA: 0x00C2D042 File Offset: 0x00C2B242
		static RecallQuestModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RecallQuestModel.CreateStaticDefaultValue), new Action(RecallQuestModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401B98D RID: 113037
		private readonly Dictionary<int, RecallData> RecallDataMap = new Dictionary<int, RecallData>();

		// Token: 0x0401B98E RID: 113038
		private readonly Dictionary<int, HashSet<int>> InstanceIdsWithSaveDataMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401B98F RID: 113039
		private readonly RecallInventoryData InventoryData = new RecallInventoryData();

		// Token: 0x0401B990 RID: 113040
		public bool HasQueriedItemBag;

		// Token: 0x0401B991 RID: 113041
		private int CurrentRecallId;

		// Token: 0x0401B992 RID: 113042
		private readonly Dictionary<int, int> CurrentRecallQuestMap = new Dictionary<int, int>();

		// Token: 0x0401B993 RID: 113043
		private readonly HashSet<int> CurrentRecallQuestIds = new HashSet<int>();

		// Token: 0x0401B994 RID: 113044
		public int CurrentRecallTrackQuestId;

		// Token: 0x0401B995 RID: 113045
		[Nullable(2)]
		public RecallExploreSkillRouletteNotify CacheRecallExploreSkillRouletteData;

		// Token: 0x0401B996 RID: 113046
		[Nullable(2)]
		private static RecallQuestModel _Instance;
	}
}
