using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002688 RID: 9864
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeChapterData
{
	// Token: 0x0601435D RID: 82781 RVA: 0x0051B0DE File Offset: 0x005192DE
	protected QuestTreeChapterData()
	{
	}

	// Token: 0x170019FA RID: 6650
	// (get) Token: 0x0601435E RID: 82782 RVA: 0x0051B0F4 File Offset: 0x005192F4
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

	// Token: 0x170019FB RID: 6651
	// (get) Token: 0x0601435F RID: 82783 RVA: 0x0051B154 File Offset: 0x00519354
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

	// Token: 0x170019FC RID: 6652
	// (get) Token: 0x06014360 RID: 82784 RVA: 0x0051B1B4 File Offset: 0x005193B4
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

	// Token: 0x170019FD RID: 6653
	// (get) Token: 0x06014361 RID: 82785 RVA: 0x0051B214 File Offset: 0x00519414
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

	// Token: 0x170019FE RID: 6654
	// (get) Token: 0x06014362 RID: 82786 RVA: 0x0051B2C8 File Offset: 0x005194C8
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

	// Token: 0x06014363 RID: 82787 RVA: 0x0051B320 File Offset: 0x00519520
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

	// Token: 0x06014364 RID: 82788 RVA: 0x0051B438 File Offset: 0x00519638
	public void Clear()
	{
		foreach (QuestTreeNodeData questTreeNodeData in this.NodeMap.Values)
		{
			questTreeNodeData.Clear();
		}
		this.NodeMap.Clear();
	}

	// Token: 0x06014365 RID: 82789 RVA: 0x0051B498 File Offset: 0x00519698
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

	// Token: 0x06014366 RID: 82790 RVA: 0x0051B500 File Offset: 0x00519700
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

	// Token: 0x06014367 RID: 82791 RVA: 0x0051B5F8 File Offset: 0x005197F8
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

	// Token: 0x06014368 RID: 82792 RVA: 0x0051B78C File Offset: 0x0051998C
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

	// Token: 0x06014369 RID: 82793 RVA: 0x0051B80C File Offset: 0x00519A0C
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

	// Token: 0x0601436A RID: 82794 RVA: 0x0051B874 File Offset: 0x00519A74
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

	// Token: 0x0400981A RID: 38938
	public int Id;

	// Token: 0x0400981B RID: 38939
	public QuestTreeChapter? Config;

	// Token: 0x0400981C RID: 38940
	public Dictionary<int, QuestTreeNodeData> NodeMap = new Dictionary<int, QuestTreeNodeData>();
}
