using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x02002679 RID: 9849
[NullableContext(2)]
[Nullable(0)]
public class QuestReviewModel : ModelBase
{
	// Token: 0x060142D7 RID: 82647 RVA: 0x00517ED0 File Offset: 0x005160D0
	protected override bool OnInit()
	{
		IReadOnlyList<QuestReviewEntry> configList = ConfigQuestReviewEntryAll.GetConfigList(true);
		if (configList != null)
		{
			foreach (QuestReviewEntry questReviewEntry in configList)
			{
				foreach (int key in questReviewEntry.RelatedQuest())
				{
					this.QuestEntryMap[key] = questReviewEntry.Id;
				}
			}
		}
		return true;
	}

	// Token: 0x060142D8 RID: 82648 RVA: 0x00517F50 File Offset: 0x00516150
	protected override bool OnClear()
	{
		foreach (Dictionary<int, object> dictionary in this.DataMap.Values)
		{
			dictionary.Clear();
		}
		this.DataMap.Clear();
		return true;
	}

	// Token: 0x060142D9 RID: 82649 RVA: 0x00517FB4 File Offset: 0x005161B4
	[NullableContext(0)]
	[return: Nullable(2)]
	private TData GetOrCreateData<[Nullable(1)] TData, TConfig>(int id, [Nullable(new byte[]
	{
		1,
		0,
		1
	})] Func<TConfig, TData> ctor, TConfig? config) where TData : class where TConfig : struct
	{
		if (id == 0)
		{
			return default(TData);
		}
		string name = typeof(TData).Name;
		if (!this.DataMap.ContainsKey(name))
		{
			this.DataMap[name] = new Dictionary<int, object>();
		}
		if (config == null)
		{
			return default(TData);
		}
		Dictionary<int, object> dictionary = this.DataMap[name];
		if (!dictionary.ContainsKey(id))
		{
			dictionary[id] = ctor(config.Value);
		}
		return dictionary[id] as TData;
	}

	// Token: 0x060142DA RID: 82650 RVA: 0x00518050 File Offset: 0x00516250
	public QuestReviewNodeData GetQuestReviewNodeDataById(int id)
	{
		if (id == 0)
		{
			return null;
		}
		QuestReviewNode? config2 = ConfigQuestReviewNodeById.GetConfig(id, true);
		return this.GetOrCreateData<QuestReviewNodeData, QuestReviewNode>(id, (QuestReviewNode config) => new QuestReviewNodeData(config), config2);
	}

	// Token: 0x060142DB RID: 82651 RVA: 0x00518094 File Offset: 0x00516294
	public QuestReviewTabData GetQuestReviewTabDataById(int id)
	{
		if (id == 0)
		{
			return null;
		}
		QuestReviewTab? config2 = ConfigQuestReviewTabById.GetConfig(id, true);
		return this.GetOrCreateData<QuestReviewTabData, QuestReviewTab>(id, (QuestReviewTab config) => new QuestReviewTabData(config), config2);
	}

	// Token: 0x060142DC RID: 82652 RVA: 0x005180D8 File Offset: 0x005162D8
	public QuestReviewTreeData GetQuestReviewTreeDataById(int id)
	{
		if (id == 0)
		{
			return null;
		}
		QuestReviewTree? config2 = ConfigQuestReviewTreeById.GetConfig(id, true);
		return this.GetOrCreateData<QuestReviewTreeData, QuestReviewTree>(id, (QuestReviewTree config) => new QuestReviewTreeData(config), config2);
	}

	// Token: 0x060142DD RID: 82653 RVA: 0x0051811C File Offset: 0x0051631C
	public QuestReviewEntryData GetQuestReviewEntryDataById(int id)
	{
		if (id == 0)
		{
			return null;
		}
		QuestReviewEntry? config2 = ConfigQuestReviewEntryById.GetConfig(id, true);
		return this.GetOrCreateData<QuestReviewEntryData, QuestReviewEntry>(id, (QuestReviewEntry config) => new QuestReviewEntryData(config), config2);
	}

	// Token: 0x060142DE RID: 82654 RVA: 0x00518160 File Offset: 0x00516360
	public QuestReviewLineData GetQuestReviewLineDataById(int id)
	{
		if (id == 0)
		{
			return null;
		}
		QuestReviewLine? config2 = ConfigQuestReviewLineById.GetConfig(id, true);
		return this.GetOrCreateData<QuestReviewLineData, QuestReviewLine>(id, (QuestReviewLine config) => new QuestReviewLineData(config), config2);
	}

	// Token: 0x060142DF RID: 82655 RVA: 0x005181A4 File Offset: 0x005163A4
	public List<int> GetNodeIdListByQuestLineId(int questLineId)
	{
		QuestReviewLineData questReviewLineDataById = this.GetQuestReviewLineDataById(questLineId);
		if (questReviewLineDataById == null)
		{
			return null;
		}
		QuestReviewNodeData questReviewNodeDataById = this.GetQuestReviewNodeDataById(questReviewLineDataById.StartNode);
		if (questReviewNodeDataById == null)
		{
			return null;
		}
		List<int> list = new List<int>();
		for (int i = 0; i < 5; i++)
		{
			list.Add(0);
		}
		QuestReviewNodeData questReviewNodeDataById2;
		for (QuestReviewNodeData questReviewNodeData = questReviewNodeDataById; questReviewNodeData != null; questReviewNodeData = questReviewNodeDataById2)
		{
			list[questReviewNodeData.PosIndex] = questReviewNodeData.Id;
			questReviewNodeDataById2 = this.GetQuestReviewNodeDataById(questReviewNodeData.Successor);
			if (questReviewNodeDataById2 != null)
			{
				questReviewNodeDataById2.Predecessor = questReviewNodeData.Id;
			}
			if (questReviewNodeData.IsBranching)
			{
				break;
			}
		}
		return list;
	}

	// Token: 0x060142E0 RID: 82656 RVA: 0x00518234 File Offset: 0x00516434
	public bool IsQuestLineHasAnyVisibleNode(int questLineId)
	{
		if (this.GetQuestReviewLineDataById(questLineId) == null)
		{
			return false;
		}
		List<int> nodeIdListByQuestLineId = this.GetNodeIdListByQuestLineId(questLineId);
		if (nodeIdListByQuestLineId == null)
		{
			return false;
		}
		foreach (int nodeId in nodeIdListByQuestLineId)
		{
			if (this.IsNodeVisible(nodeId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060142E1 RID: 82657 RVA: 0x005182A4 File Offset: 0x005164A4
	public QuestReviewNodeData GetSuccessorNodeByNodeId(int nodeId)
	{
		QuestReviewNodeData questReviewNodeDataById = this.GetQuestReviewNodeDataById(nodeId);
		if (questReviewNodeDataById == null)
		{
			return null;
		}
		return this.GetQuestReviewNodeDataById(questReviewNodeDataById.Successor);
	}

	// Token: 0x060142E2 RID: 82658 RVA: 0x005182CC File Offset: 0x005164CC
	public QuestReviewNodeData GetPredecessorNodeByNodeId(int nodeId)
	{
		QuestReviewNodeData questReviewNodeDataById = this.GetQuestReviewNodeDataById(nodeId);
		if (questReviewNodeDataById == null)
		{
			return null;
		}
		return this.GetQuestReviewNodeDataById(questReviewNodeDataById.Predecessor);
	}

	// Token: 0x060142E3 RID: 82659 RVA: 0x005182F4 File Offset: 0x005164F4
	public QuestReviewEntryData GetQuestEntryDataByQuestId(int questId)
	{
		int id;
		if (this.QuestEntryMap.TryGetValue(questId, out id))
		{
			return this.GetQuestReviewEntryDataById(id);
		}
		return null;
	}

	// Token: 0x060142E4 RID: 82660 RVA: 0x0051831C File Offset: 0x0051651C
	public bool TabHasRedDot(int tabId)
	{
		QuestReviewTabData questReviewTabDataById = this.GetQuestReviewTabDataById(tabId);
		if (questReviewTabDataById == null)
		{
			return false;
		}
		QuestReviewTreeData questReviewTreeDataById = this.GetQuestReviewTreeDataById(questReviewTabDataById.QuestTree);
		if (questReviewTreeDataById == null)
		{
			return false;
		}
		foreach (int num in questReviewTreeDataById.QuestLines)
		{
			QuestReviewLineData questReviewLineDataById = this.GetQuestReviewLineDataById(num);
			if (questReviewLineDataById != null && questReviewLineDataById.State == EQuestReviewLineState.Show)
			{
				List<int> nodeIdListByQuestLineId = this.GetNodeIdListByQuestLineId(num);
				if (nodeIdListByQuestLineId != null)
				{
					foreach (int num2 in nodeIdListByQuestLineId)
					{
						QuestReviewNodeData questReviewNodeDataById = this.GetQuestReviewNodeDataById(num2);
						bool flag = this.IsNodeVisible(num2);
						if (questReviewNodeDataById != null && questReviewNodeDataById.HasRedDot && flag)
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x060142E5 RID: 82661 RVA: 0x0051841C File Offset: 0x0051661C
	public QuestReviewLineData GetTempLineData()
	{
		QuestReviewLine? config = ConfigQuestReviewLineById.GetConfig(1100, true);
		if (config == null)
		{
			return null;
		}
		return new QuestReviewLineData(config.Value)
		{
			IsTempLine = true
		};
	}

	// Token: 0x060142E6 RID: 82662 RVA: 0x00518454 File Offset: 0x00516654
	public bool IsNodeVisible(int nodeId)
	{
		QuestReviewNodeData questReviewNodeDataById = this.GetQuestReviewNodeDataById(nodeId);
		if (questReviewNodeDataById == null || questReviewNodeDataById.State == EQuestReviewNodeState.Locked)
		{
			return false;
		}
		if (questReviewNodeDataById.ShowOnceUnlock)
		{
			return true;
		}
		QuestReviewNodeData predecessorNodeByNodeId = this.GetPredecessorNodeByNodeId(nodeId);
		return predecessorNodeByNodeId == null || predecessorNodeByNodeId.State == EQuestReviewNodeState.Finished;
	}

	// Token: 0x060142E7 RID: 82663 RVA: 0x00518497 File Offset: 0x00516697
	public bool HasQuestLineFused()
	{
		return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.QuestReviewHasFused, false);
	}

	// Token: 0x060142E8 RID: 82664 RVA: 0x005184A4 File Offset: 0x005166A4
	public void SetQuestLineFused()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.QuestReviewHasFused, true);
	}

	// Token: 0x060142E9 RID: 82665 RVA: 0x005184B4 File Offset: 0x005166B4
	public bool IsFirstEntry()
	{
		return LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.QuestReviewMainViewEntryAnim, null).GetValueOrDefault(true);
	}

	// Token: 0x060142EA RID: 82666 RVA: 0x005184E0 File Offset: 0x005166E0
	[NullableContext(1)]
	public void UpdateAllQuestReviewEntryData(List<QuestReviewEntryInfo> dataList)
	{
		foreach (QuestReviewEntryInfo questReviewEntryInfo in dataList)
		{
			QuestReviewEntryData questReviewEntryDataById = this.GetQuestReviewEntryDataById(questReviewEntryInfo.EntryId);
			if (questReviewEntryDataById != null)
			{
				questReviewEntryDataById.UpdateByServerData(questReviewEntryInfo);
			}
		}
	}

	// Token: 0x060142EB RID: 82667 RVA: 0x00518540 File Offset: 0x00516740
	[NullableContext(1)]
	public void UpdateAllQuestReviewLineData(List<QuestReviewLineInfo> dataList)
	{
		foreach (QuestReviewLineInfo questReviewLineInfo in dataList)
		{
			QuestReviewLineData questReviewLineDataById = this.GetQuestReviewLineDataById(questReviewLineInfo.LineId);
			if (questReviewLineDataById != null)
			{
				questReviewLineDataById.UpdateByServerData(questReviewLineInfo);
			}
		}
	}

	// Token: 0x060142EC RID: 82668 RVA: 0x005185A0 File Offset: 0x005167A0
	[NullableContext(1)]
	public void UpdateAllQuestReviewNodeData(List<QuestReviewNodeInfo> dataList)
	{
		foreach (QuestReviewNodeInfo questReviewNodeInfo in dataList)
		{
			QuestReviewNodeData questReviewNodeDataById = this.GetQuestReviewNodeDataById(questReviewNodeInfo.NodeId);
			if (questReviewNodeDataById != null)
			{
				questReviewNodeDataById.UpdateByServerData(questReviewNodeInfo);
			}
		}
	}

	// Token: 0x060142ED RID: 82669 RVA: 0x00518600 File Offset: 0x00516800
	[NullableContext(1)]
	public void UpdateAllQuestReviewTabData(List<QuestReviewTabInfo> dataList)
	{
		foreach (QuestReviewTabInfo questReviewTabInfo in dataList)
		{
			QuestReviewTabData questReviewTabDataById = this.GetQuestReviewTabDataById(questReviewTabInfo.TabId);
			if (questReviewTabDataById != null)
			{
				questReviewTabDataById.UpdateByServerData(questReviewTabInfo);
			}
		}
	}

	// Token: 0x170019F4 RID: 6644
	// (get) Token: 0x060142EE RID: 82670 RVA: 0x00518660 File Offset: 0x00516860
	[Nullable(1)]
	public static QuestReviewModel Instance
	{
		[NullableContext(1)]
		get
		{
			return QuestReviewModel._Instance;
		}
	}

	// Token: 0x060142EF RID: 82671 RVA: 0x00518667 File Offset: 0x00516867
	[NullableContext(1)]
	public static QuestReviewModel GetOrCreateInstance()
	{
		if (QuestReviewModel._Instance == null)
		{
			QuestReviewModel.CreateInstance();
		}
		return QuestReviewModel._Instance;
	}

	// Token: 0x060142F0 RID: 82672 RVA: 0x0051867B File Offset: 0x0051687B
	public static bool CreateInstance()
	{
		if (QuestReviewModel._Instance != null)
		{
			return true;
		}
		QuestReviewModel._Instance = new QuestReviewModel();
		return true;
	}

	// Token: 0x060142F1 RID: 82673 RVA: 0x00518691 File Offset: 0x00516891
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060142F2 RID: 82674 RVA: 0x00518693 File Offset: 0x00516893
	public static void ResetStaticDefaultValue()
	{
		QuestReviewModel._Instance = null;
	}

	// Token: 0x060142F3 RID: 82675 RVA: 0x0051869B File Offset: 0x0051689B
	static QuestReviewModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestReviewModel.CreateStaticDefaultValue), new Action(QuestReviewModel.ResetStaticDefaultValue));
	}

	// Token: 0x040097F5 RID: 38901
	[Nullable(1)]
	private readonly Dictionary<string, Dictionary<int, object>> DataMap = new Dictionary<string, Dictionary<int, object>>();

	// Token: 0x040097F6 RID: 38902
	[Nullable(1)]
	private readonly Dictionary<int, int> QuestEntryMap = new Dictionary<int, int>();

	// Token: 0x040097F7 RID: 38903
	private static QuestReviewModel _Instance;
}
