using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002699 RID: 9881
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class QuestTreeModel : ModelBase
{
	// Token: 0x060143F8 RID: 82936 RVA: 0x0051E334 File Offset: 0x0051C534
	protected override bool OnInit()
	{
		foreach (QuestTreeChapter config in QuestTreeConfig.Instance.GetAllChapters())
		{
			QuestTreeChapterData questTreeChapterData = QuestTreeChapterData.Create(config);
			this.ChapterDataMap[questTreeChapterData.Id] = questTreeChapterData;
		}
		return true;
	}

	// Token: 0x060143F9 RID: 82937 RVA: 0x0051E398 File Offset: 0x0051C598
	protected override bool OnClear()
	{
		foreach (QuestTreeChapterData questTreeChapterData in this.ChapterDataMap.Values)
		{
			questTreeChapterData.Clear();
		}
		this.ChapterDataMap.Clear();
		this.ViewModelMain.Clear();
		this.ServerUnlockedChapterIds.Clear();
		this.ServerUnlockedNodeIds.Clear();
		return true;
	}

	// Token: 0x060143FA RID: 82938 RVA: 0x0051E41C File Offset: 0x0051C61C
	public void UpdateServerUnlockInfo(IReadOnlyList<int> chapterIds, IReadOnlyList<int> nodeIds)
	{
		this.ServerUnlockedChapterIds.Clear();
		foreach (int item in chapterIds)
		{
			this.ServerUnlockedChapterIds.Add(item);
		}
		this.ServerUnlockedNodeIds.Clear();
		foreach (int item2 in nodeIds)
		{
			this.ServerUnlockedNodeIds.Add(item2);
		}
	}

	// Token: 0x060143FB RID: 82939 RVA: 0x0051E4C0 File Offset: 0x0051C6C0
	public bool IsNodeUnlockedByServer(int nodeId)
	{
		return this.ServerUnlockedNodeIds.Contains(nodeId);
	}

	// Token: 0x060143FC RID: 82940 RVA: 0x0051E4CE File Offset: 0x0051C6CE
	public bool IsChapterUnlockedByServer(int chapterId)
	{
		return this.ServerUnlockedChapterIds.Contains(chapterId);
	}

	// Token: 0x060143FD RID: 82941 RVA: 0x0051E4DC File Offset: 0x0051C6DC
	[NullableContext(2)]
	public QuestTreeChapterData GetChapterDataById(int id)
	{
		return this.ChapterDataMap.GetValueOrDefault(id);
	}

	// Token: 0x060143FE RID: 82942 RVA: 0x0051E4EA File Offset: 0x0051C6EA
	public List<QuestTreeChapterData> GetAllChapterData()
	{
		return new List<QuestTreeChapterData>(this.ChapterDataMap.Values);
	}

	// Token: 0x060143FF RID: 82943 RVA: 0x0051E4FC File Offset: 0x0051C6FC
	public List<QuestTreeChapterData> GetVisibleChapterDataList()
	{
		List<QuestTreeChapterData> list = new List<QuestTreeChapterData>();
		List<QuestTreeChapterData> allChapterData = this.GetAllChapterData();
		int num = 0;
		for (int i = allChapterData.Count - 1; i >= 0; i--)
		{
			if (allChapterData[i].IsUnlock)
			{
				IL_47:
				while (num < allChapterData.Count && num <= i + 1)
				{
					QuestTreeChapterData item = allChapterData[num];
					list.Add(item);
					num++;
				}
				return list;
			}
		}
		goto IL_47;
	}

	// Token: 0x06014400 RID: 82944 RVA: 0x0051E560 File Offset: 0x0051C760
	public List<QuestTreeNodeData> GetAllAcceptableNodeList()
	{
		List<QuestTreeNodeData> list = new List<QuestTreeNodeData>();
		foreach (QuestTreeChapterData questTreeChapterData in this.ChapterDataMap.Values)
		{
			foreach (QuestTreeNodeData item in questTreeChapterData.GetAcceptableNodeList())
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06014401 RID: 82945 RVA: 0x0051E5F8 File Offset: 0x0051C7F8
	[NullableContext(2)]
	public QuestTreeChapterData GetCurTrackingChapterData()
	{
		foreach (QuestTreeChapterData questTreeChapterData in this.ChapterDataMap.Values)
		{
			if (questTreeChapterData.IsTracking)
			{
				return questTreeChapterData;
			}
		}
		return null;
	}

	// Token: 0x06014402 RID: 82946 RVA: 0x0051E658 File Offset: 0x0051C858
	public QuestTreeNodeData GetOrCreateDummyQuestTreeNodeData(QuestTreeNode dummyConfig)
	{
		if (this.DummyQuestTreeNodeData == null)
		{
			this.DummyQuestTreeNodeData = QuestTreeNodeData.CreateDummyNode(dummyConfig);
		}
		return this.DummyQuestTreeNodeData;
	}

	// Token: 0x06014403 RID: 82947 RVA: 0x0051E674 File Offset: 0x0051C874
	[NullableContext(2)]
	public QuestTreeNodeData GetNodeDataFromQuestId(int questId)
	{
		foreach (QuestTreeChapterData questTreeChapterData in this.ChapterDataMap.Values)
		{
			foreach (QuestTreeNodeData questTreeNodeData in questTreeChapterData.NodeMap.Values)
			{
				if (questTreeNodeData.Config.NodeType != 3 && questTreeNodeData.Config.GetQuestArrayBytes().Contains(questId))
				{
					return questTreeNodeData;
				}
			}
		}
		return null;
	}

	// Token: 0x06014404 RID: 82948 RVA: 0x0051E734 File Offset: 0x0051C934
	[NullableContext(2)]
	public QuestTreeNodeData GetNodeDataFromNodeId(int nodeId)
	{
		foreach (QuestTreeChapterData questTreeChapterData in this.ChapterDataMap.Values)
		{
			QuestTreeNodeData valueOrDefault = questTreeChapterData.NodeMap.GetValueOrDefault(nodeId);
			if (valueOrDefault != null)
			{
				return valueOrDefault;
			}
		}
		return null;
	}

	// Token: 0x17001A2B RID: 6699
	// (get) Token: 0x06014405 RID: 82949 RVA: 0x0051E79C File Offset: 0x0051C99C
	public static QuestTreeModel Instance
	{
		get
		{
			return QuestTreeModel._Instance;
		}
	}

	// Token: 0x06014406 RID: 82950 RVA: 0x0051E7A3 File Offset: 0x0051C9A3
	public static QuestTreeModel GetOrCreateInstance()
	{
		if (QuestTreeModel._Instance == null)
		{
			QuestTreeModel.CreateInstance();
		}
		return QuestTreeModel._Instance;
	}

	// Token: 0x06014407 RID: 82951 RVA: 0x0051E7B7 File Offset: 0x0051C9B7
	public static bool CreateInstance()
	{
		if (QuestTreeModel._Instance != null)
		{
			return true;
		}
		QuestTreeModel._Instance = new QuestTreeModel();
		return true;
	}

	// Token: 0x06014408 RID: 82952 RVA: 0x0051E7CD File Offset: 0x0051C9CD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014409 RID: 82953 RVA: 0x0051E7CF File Offset: 0x0051C9CF
	public static void ResetStaticDefaultValue()
	{
		QuestTreeModel._Instance = null;
	}

	// Token: 0x0601440A RID: 82954 RVA: 0x0051E7D7 File Offset: 0x0051C9D7
	static QuestTreeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestTreeModel.CreateStaticDefaultValue), new Action(QuestTreeModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400986A RID: 39018
	private readonly Dictionary<int, QuestTreeChapterData> ChapterDataMap = new Dictionary<int, QuestTreeChapterData>();

	// Token: 0x0400986B RID: 39019
	public QuestTreeMainViewModel ViewModelMain = QuestTreeMainViewModel.Create();

	// Token: 0x0400986C RID: 39020
	public QuestTreeChapterViewModel ViewModelChapter = QuestTreeChapterViewModel.Create();

	// Token: 0x0400986D RID: 39021
	[Nullable(2)]
	private QuestTreeNodeData DummyQuestTreeNodeData;

	// Token: 0x0400986E RID: 39022
	private readonly HashSet<int> ServerUnlockedChapterIds = new HashSet<int>();

	// Token: 0x0400986F RID: 39023
	private readonly HashSet<int> ServerUnlockedNodeIds = new HashSet<int>();

	// Token: 0x04009870 RID: 39024
	[Nullable(2)]
	private static QuestTreeModel _Instance;
}
