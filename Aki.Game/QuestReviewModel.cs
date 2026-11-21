using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;

// Token: 0x02001B64 RID: 7012
[NullableContext(2)]
[Nullable(0)]
public class QuestReviewModel : ModelBase
{
	// Token: 0x060117B9 RID: 71609 RVA: 0x00526C28 File Offset: 0x00524E28
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

	// Token: 0x060117BA RID: 71610 RVA: 0x00526CA8 File Offset: 0x00524EA8
	protected override bool OnClear()
	{
		foreach (Dictionary<int, object> dictionary in this.DataMap.Values)
		{
			dictionary.Clear();
		}
		this.DataMap.Clear();
		return true;
	}

	// Token: 0x060117BB RID: 71611 RVA: 0x00526D0C File Offset: 0x00524F0C
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

	// Token: 0x060117BC RID: 71612 RVA: 0x00526DA8 File Offset: 0x00524FA8
	public QuestReviewNodeData GetQuestReviewNodeDataById(int id)
	{
		if (id == 0)
		{
			return null;
		}
		QuestReviewNode? config2 = ConfigQuestReviewNodeById.GetConfig(id, true);
		return this.GetOrCreateData<QuestReviewNodeData, QuestReviewNode>(id, (QuestReviewNode config) => new QuestReviewNodeData(config), config2);
	}

	// Token: 0x060117BD RID: 71613 RVA: 0x00526DEC File Offset: 0x00524FEC
	public QuestReviewTabData GetQuestReviewTabDataById(int id)
	{
		if (id == 0)
		{
			return null;
		}
		QuestReviewTab? config2 = ConfigQuestReviewTabById.GetConfig(id, true);
		return this.GetOrCreateData<QuestReviewTabData, QuestReviewTab>(id, (QuestReviewTab config) => new QuestReviewTabData(config), config2);
	}

	// Token: 0x060117BE RID: 71614 RVA: 0x00526E30 File Offset: 0x00525030
	public QuestReviewTreeData GetQuestReviewTreeDataById(int id)
	{
		if (id == 0)
		{
			return null;
		}
		QuestReviewTree? config2 = ConfigQuestReviewTreeById.GetConfig(id, true);
		return this.GetOrCreateData<QuestReviewTreeData, QuestReviewTree>(id, (QuestReviewTree config) => new QuestReviewTreeData(config), config2);
	}

	// Token: 0x060117BF RID: 71615 RVA: 0x00526E74 File Offset: 0x00525074
	public QuestReviewEntryData GetQuestReviewEntryDataById(int id)
	{
		if (id == 0)
		{
			return null;
		}
		QuestReviewEntry? config2 = ConfigQuestReviewEntryById.GetConfig(id, true);
		return this.GetOrCreateData<QuestReviewEntryData, QuestReviewEntry>(id, (QuestReviewEntry config) => new QuestReviewEntryData(config), config2);
	}

	// Token: 0x060117C0 RID: 71616 RVA: 0x00526EB8 File Offset: 0x005250B8
	public QuestReviewLineData GetQuestReviewLineDataById(int id)
	{
		if (id == 0)
		{
			return null;
		}
		QuestReviewLine? config2 = ConfigQuestReviewLineById.GetConfig(id, true);
		return this.GetOrCreateData<QuestReviewLineData, QuestReviewLine>(id, (QuestReviewLine config) => new QuestReviewLineData(config), config2);
	}

	// Token: 0x060117C1 RID: 71617 RVA: 0x00526EFC File Offset: 0x005250FC
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

	// Token: 0x060117C2 RID: 71618 RVA: 0x00526F8C File Offset: 0x0052518C
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

	// Token: 0x060117C3 RID: 71619 RVA: 0x00526FFC File Offset: 0x005251FC
	public QuestReviewNodeData GetSuccessorNodeByNodeId(int nodeId)
	{
		QuestReviewNodeData questReviewNodeDataById = this.GetQuestReviewNodeDataById(nodeId);
		if (questReviewNodeDataById == null)
		{
			return null;
		}
		return this.GetQuestReviewNodeDataById(questReviewNodeDataById.Successor);
	}

	// Token: 0x060117C4 RID: 71620 RVA: 0x00527024 File Offset: 0x00525224
	public QuestReviewNodeData GetPredecessorNodeByNodeId(int nodeId)
	{
		QuestReviewNodeData questReviewNodeDataById = this.GetQuestReviewNodeDataById(nodeId);
		if (questReviewNodeDataById == null)
		{
			return null;
		}
		return this.GetQuestReviewNodeDataById(questReviewNodeDataById.Predecessor);
	}

	// Token: 0x060117C5 RID: 71621 RVA: 0x0052704C File Offset: 0x0052524C
	public QuestReviewEntryData GetQuestEntryDataByQuestId(int questId)
	{
		int id;
		if (this.QuestEntryMap.TryGetValue(questId, out id))
		{
			return this.GetQuestReviewEntryDataById(id);
		}
		return null;
	}

	// Token: 0x060117C6 RID: 71622 RVA: 0x00527074 File Offset: 0x00525274
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

	// Token: 0x060117C7 RID: 71623 RVA: 0x00527174 File Offset: 0x00525374
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

	// Token: 0x060117C8 RID: 71624 RVA: 0x005271AC File Offset: 0x005253AC
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

	// Token: 0x060117C9 RID: 71625 RVA: 0x005271EF File Offset: 0x005253EF
	public bool HasQuestLineFused()
	{
		return LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.QuestReviewHasFused, false);
	}

	// Token: 0x060117CA RID: 71626 RVA: 0x005271FC File Offset: 0x005253FC
	public void SetQuestLineFused()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.QuestReviewHasFused, true);
	}

	// Token: 0x060117CB RID: 71627 RVA: 0x0052720C File Offset: 0x0052540C
	public bool IsFirstEntry()
	{
		return LocalStorage.GetPlayer<bool?>(ELocalStoragePlayerKey.QuestReviewMainViewEntryAnim, null).GetValueOrDefault(true);
	}

	// Token: 0x060117CC RID: 71628 RVA: 0x00527238 File Offset: 0x00525438
	[NullableContext(1)]
	public void UpdateAllQuestReviewEntryData(IEnumerable<QuestReviewEntryInfo> dataList)
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

	// Token: 0x060117CD RID: 71629 RVA: 0x00527290 File Offset: 0x00525490
	[NullableContext(1)]
	public void UpdateAllQuestReviewLineData(IEnumerable<QuestReviewLineInfo> dataList)
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

	// Token: 0x060117CE RID: 71630 RVA: 0x005272E8 File Offset: 0x005254E8
	[NullableContext(1)]
	public void UpdateAllQuestReviewNodeData(IEnumerable<QuestReviewNodeInfo> dataList)
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

	// Token: 0x060117CF RID: 71631 RVA: 0x00527340 File Offset: 0x00525540
	[NullableContext(1)]
	public void UpdateAllQuestReviewTabData(IEnumerable<QuestReviewTabInfo> dataList)
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

	// Token: 0x17001A2C RID: 6700
	// (get) Token: 0x060117D0 RID: 71632 RVA: 0x00527398 File Offset: 0x00525598
	[Nullable(1)]
	public static QuestReviewModel Instance
	{
		[NullableContext(1)]
		get
		{
			return QuestReviewModel._Instance;
		}
	}

	// Token: 0x060117D1 RID: 71633 RVA: 0x0052739F File Offset: 0x0052559F
	[NullableContext(1)]
	public static QuestReviewModel GetOrCreateInstance()
	{
		if (QuestReviewModel._Instance == null)
		{
			QuestReviewModel.CreateInstance();
		}
		return QuestReviewModel._Instance;
	}

	// Token: 0x060117D2 RID: 71634 RVA: 0x005273B3 File Offset: 0x005255B3
	public static bool CreateInstance()
	{
		if (QuestReviewModel._Instance != null)
		{
			return true;
		}
		QuestReviewModel._Instance = new QuestReviewModel();
		return true;
	}

	// Token: 0x060117D3 RID: 71635 RVA: 0x005273C9 File Offset: 0x005255C9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060117D4 RID: 71636 RVA: 0x005273CB File Offset: 0x005255CB
	public static void ResetStaticDefaultValue()
	{
		QuestReviewModel._Instance = null;
	}

	// Token: 0x060117D5 RID: 71637 RVA: 0x005273D3 File Offset: 0x005255D3
	static QuestReviewModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestReviewModel.CreateStaticDefaultValue), new Action(QuestReviewModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400994D RID: 39245
	[Nullable(1)]
	private readonly Dictionary<string, Dictionary<int, object>> DataMap = new Dictionary<string, Dictionary<int, object>>();

	// Token: 0x0400994E RID: 39246
	[Nullable(1)]
	private readonly Dictionary<int, int> QuestEntryMap = new Dictionary<int, int>();

	// Token: 0x0400994F RID: 39247
	private static QuestReviewModel _Instance;
}
