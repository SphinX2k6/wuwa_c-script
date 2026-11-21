using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001B73 RID: 7027
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeChapterData
{
	// Token: 0x0601183F RID: 71743 RVA: 0x00529E16 File Offset: 0x00528016
	protected QuestTreeChapterData()
	{
	}

	// Token: 0x17001A32 RID: 6706
	// (get) Token: 0x06011840 RID: 71744 RVA: 0x00529E2C File Offset: 0x0052802C
	public bool IsUnlock
	{
		get
		{
			using (Dictionary<int, QuestTreeNodeData>.ValueCollection.Enumerator enumerator = this.NodeMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State > EQuestTreeNodeState.Locked)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x17001A33 RID: 6707
	// (get) Token: 0x06011841 RID: 71745 RVA: 0x00529E8C File Offset: 0x0052808C
	public bool IsTracking
	{
		get
		{
			using (Dictionary<int, QuestTreeNodeData>.ValueCollection.Enumerator enumerator = this.NodeMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsTracking)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x17001A34 RID: 6708
	// (get) Token: 0x06011842 RID: 71746 RVA: 0x00529EEC File Offset: 0x005280EC
	public bool HasAvailableQuest
	{
		get
		{
			using (Dictionary<int, QuestTreeNodeData>.ValueCollection.Enumerator enumerator = this.NodeMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.State == EQuestTreeNodeState.Available)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x17001A35 RID: 6709
	// (get) Token: 0x06011843 RID: 71747 RVA: 0x00529F4C File Offset: 0x0052814C
	[Nullable(0)]
	public ValueTuple<int, int> Progress
	{
		[NullableContext(0)]
		get
		{
			int num = 0;
			int num2 = this.NodeMap.Count;
			foreach (QuestTreeNodeData questTreeNodeData in this.NodeMap.Values)
			{
				if (questTreeNodeData.State == EQuestTreeNodeState.Finished && questTreeNodeData.Config.NodeType != 3)
				{
					num++;
				}
				if (questTreeNodeData.Config.NodeType == 3 || (questTreeNodeData.IsMoonChasingQuest() && questTreeNodeData.State == EQuestTreeNodeState.None))
				{
					num2--;
				}
			}
			return new ValueTuple<int, int>(num, num2);
		}
	}

	// Token: 0x17001A36 RID: 6710
	// (get) Token: 0x06011844 RID: 71748 RVA: 0x0052A000 File Offset: 0x00528200
	public string Image
	{
		get
		{
			if (this.IsUnlock)
			{
				return this.Config.Value.Image;
			}
			bool playerGender = PlayerInfoModel.Instance.GetPlayerGender() != EPlayerGender.Female;
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_QuestTree_Chapter_Nv_Small");
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("T_QuestTree_Chapter_Nan_Small");
			if (playerGender)
			{
				return resourcePath2;
			}
			return resourcePath;
		}
	}

	// Token: 0x06011845 RID: 71749 RVA: 0x0052A058 File Offset: 0x00528258
	public unsafe static QuestTreeChapterData Create(QuestTreeChapter config)
	{
		QuestTreeChapterData questTreeChapterData = new QuestTreeChapterData();
		questTreeChapterData.Config = new QuestTreeChapter?(config);
		questTreeChapterData.Id = config.Id;
		foreach (QuestTreeNode config2 in QuestTreeConfig.Instance.GetNodeListByChapterId(config.Id))
		{
			QuestTreeNodeData questTreeNodeData = QuestTreeNodeData.Create(config2);
			questTreeChapterData.NodeMap[questTreeNodeData.Id] = questTreeNodeData;
		}
		foreach (QuestTreeNodeData questTreeNodeData2 in questTreeChapterData.NodeMap.Values)
		{
			Span<int> includeNodesBytes = questTreeNodeData2.Config.GetIncludeNodesBytes();
			for (int i = 0; i < includeNodesBytes.Length; i++)
			{
				int key = *includeNodesBytes[i];
				QuestTreeNodeData valueOrDefault = questTreeChapterData.NodeMap.GetValueOrDefault(key);
				if (valueOrDefault != null)
				{
					valueOrDefault.SetBelongedNode(questTreeNodeData2);
				}
			}
		}
		return questTreeChapterData;
	}

	// Token: 0x06011846 RID: 71750 RVA: 0x0052A170 File Offset: 0x00528370
	public void Clear()
	{
		foreach (QuestTreeNodeData questTreeNodeData in this.NodeMap.Values)
		{
			questTreeNodeData.Clear();
		}
		this.NodeMap.Clear();
	}

	// Token: 0x06011847 RID: 71751 RVA: 0x0052A1D0 File Offset: 0x005283D0
	public List<QuestTreeNodeData> GetAvailableNodeList()
	{
		List<QuestTreeNodeData> list = new List<QuestTreeNodeData>();
		foreach (QuestTreeNodeData questTreeNodeData in this.NodeMap.Values)
		{
			if (questTreeNodeData.State == EQuestTreeNodeState.Available)
			{
				list.Add(questTreeNodeData);
			}
		}
		return list;
	}

	// Token: 0x06011848 RID: 71752 RVA: 0x0052A238 File Offset: 0x00528438
	public List<QuestTreeNodeData> GetMainNodeList()
	{
		List<QuestTreeNodeData> list = new List<QuestTreeNodeData>();
		QuestTreeNodeData questTreeNodeData = null;
		foreach (QuestTreeNodeData questTreeNodeData2 in this.NodeMap.Values)
		{
			if (questTreeNodeData2.Config.QuestType == 1 && questTreeNodeData2.State != EQuestTreeNodeState.None && questTreeNodeData2.PreQuestNodes.Count == 0)
			{
				questTreeNodeData = questTreeNodeData2;
				break;
			}
		}
		if (questTreeNodeData == null)
		{
			return list;
		}
		list.Add(questTreeNodeData);
		QuestTreeNodeData nextQuestNode = questTreeNodeData.NextQuestNode;
		while (nextQuestNode != null && nextQuestNode.State != EQuestTreeNodeState.None)
		{
			list.Add(nextQuestNode);
			nextQuestNode = nextQuestNode.NextQuestNode;
		}
		List<QuestTreeNodeData> list2 = list;
		QuestTreeNodeData questTreeNodeData3 = list2[list2.Count - 1];
		if (!questTreeNodeData3.Config.IsChapterEnding && questTreeNodeData3.State == EQuestTreeNodeState.Finished)
		{
			list.Add(QuestTreeModel.Instance.GetOrCreateDummyQuestTreeNodeData(questTreeNodeData3.Config));
		}
		return list;
	}

	// Token: 0x06011849 RID: 71753 RVA: 0x0052A330 File Offset: 0x00528530
	public List<List<QuestTreeNodeData>> GetNoParentNodeGroupList()
	{
		Dictionary<int, List<QuestTreeNodeData>> dictionary = new Dictionary<int, List<QuestTreeNodeData>>();
		foreach (QuestTreeNodeData questTreeNodeData in this.NodeMap.Values)
		{
			if (questTreeNodeData.Config.QuestType != 1 && questTreeNodeData.BelongedNode == null && questTreeNodeData.PreQuestNodes.Count <= 0 && questTreeNodeData.Config.SortOrder > 0)
			{
				int nextNode = questTreeNodeData.Config.NextNode;
				if (!dictionary.ContainsKey(nextNode))
				{
					dictionary.Add(nextNode, new List<QuestTreeNodeData>());
				}
				dictionary.GetValueOrDefault(nextNode).Add(questTreeNodeData);
			}
		}
		using (Dictionary<int, List<QuestTreeNodeData>>.ValueCollection.Enumerator enumerator2 = dictionary.Values.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				enumerator2.Current.Sort((QuestTreeNodeData a, QuestTreeNodeData b) => a.Config.SortOrder - b.Config.SortOrder);
			}
		}
		List<int> list = new List<int>(dictionary.Keys);
		list.Sort(delegate(int a, int b)
		{
			QuestTreeNodeData valueOrDefault = this.NodeMap.GetValueOrDefault(a);
			int num = (valueOrDefault != null) ? valueOrDefault.Config.SortOrder : 0;
			QuestTreeNodeData valueOrDefault2 = this.NodeMap.GetValueOrDefault(b);
			return num - ((valueOrDefault2 != null) ? valueOrDefault2.Config.SortOrder : 0);
		});
		List<List<QuestTreeNodeData>> list2 = new List<List<QuestTreeNodeData>>();
		foreach (int key in list)
		{
			list2.Add(dictionary[key]);
		}
		return list2;
	}

	// Token: 0x0601184A RID: 71754 RVA: 0x0052A4C4 File Offset: 0x005286C4
	[NullableContext(2)]
	public QuestTreeNodeData GetDefaultLocatingNode()
	{
		foreach (QuestTreeNodeData questTreeNodeData in this.NodeMap.Values)
		{
			if (questTreeNodeData.IsTracking)
			{
				return questTreeNodeData;
			}
		}
		List<QuestTreeNodeData> mainNodeList = this.GetMainNodeList();
		if (mainNodeList.Count <= 0)
		{
			return null;
		}
		List<QuestTreeNodeData> list = mainNodeList;
		return list[list.Count - 1];
	}

	// Token: 0x0601184B RID: 71755 RVA: 0x0052A544 File Offset: 0x00528744
	public List<QuestTreeNodeData> GetAcceptableNodeList()
	{
		List<QuestTreeNodeData> list = new List<QuestTreeNodeData>();
		foreach (QuestTreeNodeData questTreeNodeData in this.NodeMap.Values)
		{
			if (questTreeNodeData.State == EQuestTreeNodeState.Available)
			{
				list.Add(questTreeNodeData);
			}
		}
		return list;
	}

	// Token: 0x0601184C RID: 71756 RVA: 0x0052A5AC File Offset: 0x005287AC
	[NullableContext(2)]
	public QuestTreeNodeData GetCurTrackingNode()
	{
		foreach (QuestTreeNodeData questTreeNodeData in this.NodeMap.Values)
		{
			if (questTreeNodeData.IsTracking)
			{
				return questTreeNodeData;
			}
		}
		return null;
	}

	// Token: 0x04009972 RID: 39282
	public int Id;

	// Token: 0x04009973 RID: 39283
	public QuestTreeChapter? Config;

	// Token: 0x04009974 RID: 39284
	public Dictionary<int, QuestTreeNodeData> NodeMap = new Dictionary<int, QuestTreeNodeData>();
}
