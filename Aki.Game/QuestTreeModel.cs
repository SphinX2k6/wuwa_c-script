using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001B84 RID: 7044
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class QuestTreeModel : ModelBase
{
	// Token: 0x060118DA RID: 71898 RVA: 0x0052D06C File Offset: 0x0052B26C
	protected override bool OnInit()
	{
		foreach (QuestTreeChapter config in QuestTreeConfig.Instance.GetAllChapters())
		{
			QuestTreeChapterData questTreeChapterData = QuestTreeChapterData.Create(config);
			this.ChapterDataMap[questTreeChapterData.Id] = questTreeChapterData;
		}
		return true;
	}

	// Token: 0x060118DB RID: 71899 RVA: 0x0052D0D0 File Offset: 0x0052B2D0
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

	// Token: 0x060118DC RID: 71900 RVA: 0x0052D154 File Offset: 0x0052B354
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

	// Token: 0x060118DD RID: 71901 RVA: 0x0052D1F8 File Offset: 0x0052B3F8
	public bool IsNodeUnlockedByServer(int nodeId)
	{
		return this.ServerUnlockedNodeIds.Contains(nodeId);
	}

	// Token: 0x060118DE RID: 71902 RVA: 0x0052D206 File Offset: 0x0052B406
	public bool IsChapterUnlockedByServer(int chapterId)
	{
		return this.ServerUnlockedChapterIds.Contains(chapterId);
	}

	// Token: 0x060118DF RID: 71903 RVA: 0x0052D214 File Offset: 0x0052B414
	[NullableContext(2)]
	public QuestTreeChapterData GetChapterDataById(int id)
	{
		return this.ChapterDataMap.GetValueOrDefault(id);
	}

	// Token: 0x060118E0 RID: 71904 RVA: 0x0052D222 File Offset: 0x0052B422
	public List<QuestTreeChapterData> GetAllChapterData()
	{
		return new List<QuestTreeChapterData>(this.ChapterDataMap.Values);
	}

	// Token: 0x060118E1 RID: 71905 RVA: 0x0052D234 File Offset: 0x0052B434
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

	// Token: 0x060118E2 RID: 71906 RVA: 0x0052D298 File Offset: 0x0052B498
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

	// Token: 0x060118E3 RID: 71907 RVA: 0x0052D330 File Offset: 0x0052B530
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

	// Token: 0x060118E4 RID: 71908 RVA: 0x0052D390 File Offset: 0x0052B590
	public QuestTreeNodeData GetOrCreateDummyQuestTreeNodeData(QuestTreeNode dummyConfig)
	{
		if (this.DummyQuestTreeNodeData == null)
		{
			this.DummyQuestTreeNodeData = QuestTreeNodeData.CreateDummyNode(dummyConfig);
		}
		return this.DummyQuestTreeNodeData;
	}

	// Token: 0x060118E5 RID: 71909 RVA: 0x0052D3AC File Offset: 0x0052B5AC
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

	// Token: 0x060118E6 RID: 71910 RVA: 0x0052D46C File Offset: 0x0052B66C
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

	// Token: 0x17001A63 RID: 6755
	// (get) Token: 0x060118E7 RID: 71911 RVA: 0x0052D4D4 File Offset: 0x0052B6D4
	public static QuestTreeModel Instance
	{
		get
		{
			return QuestTreeModel._Instance;
		}
	}

	// Token: 0x060118E8 RID: 71912 RVA: 0x0052D4DB File Offset: 0x0052B6DB
	public static QuestTreeModel GetOrCreateInstance()
	{
		if (QuestTreeModel._Instance == null)
		{
			QuestTreeModel.CreateInstance();
		}
		return QuestTreeModel._Instance;
	}

	// Token: 0x060118E9 RID: 71913 RVA: 0x0052D4EF File Offset: 0x0052B6EF
	public static bool CreateInstance()
	{
		if (QuestTreeModel._Instance != null)
		{
			return true;
		}
		QuestTreeModel._Instance = new QuestTreeModel();
		return true;
	}

	// Token: 0x060118EA RID: 71914 RVA: 0x0052D505 File Offset: 0x0052B705
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060118EB RID: 71915 RVA: 0x0052D507 File Offset: 0x0052B707
	public static void ResetStaticDefaultValue()
	{
		QuestTreeModel._Instance = null;
	}

	// Token: 0x060118EC RID: 71916 RVA: 0x0052D50F File Offset: 0x0052B70F
	static QuestTreeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestTreeModel.CreateStaticDefaultValue), new Action(QuestTreeModel.ResetStaticDefaultValue));
	}

	// Token: 0x040099C2 RID: 39362
	private readonly Dictionary<int, QuestTreeChapterData> ChapterDataMap = new Dictionary<int, QuestTreeChapterData>();

	// Token: 0x040099C3 RID: 39363
	public QuestTreeMainViewModel ViewModelMain = QuestTreeMainViewModel.Create();

	// Token: 0x040099C4 RID: 39364
	public QuestTreeChapterViewModel ViewModelChapter = QuestTreeChapterViewModel.Create();

	// Token: 0x040099C5 RID: 39365
	[Nullable(2)]
	private QuestTreeNodeData DummyQuestTreeNodeData;

	// Token: 0x040099C6 RID: 39366
	private readonly HashSet<int> ServerUnlockedChapterIds = new HashSet<int>();

	// Token: 0x040099C7 RID: 39367
	private readonly HashSet<int> ServerUnlockedNodeIds = new HashSet<int>();

	// Token: 0x040099C8 RID: 39368
	[Nullable(2)]
	private static QuestTreeModel _Instance;
}
