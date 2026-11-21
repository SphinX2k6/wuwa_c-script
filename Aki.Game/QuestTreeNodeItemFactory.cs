using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B96 RID: 7062
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeNodeItemFactory : Singleton
{
	// Token: 0x0601194D RID: 72013 RVA: 0x0052EA36 File Offset: 0x0052CC36
	protected override bool OnInit()
	{
		this.InitializeLoader();
		return true;
	}

	// Token: 0x0601194E RID: 72014 RVA: 0x0052EA40 File Offset: 0x0052CC40
	public void InitializeLoader()
	{
		this.Loader = new QuestTreeNodeItemLoader();
		this.Loader.RegisterNodeType(EQuestTreeNodeType.Picture, typeof(QuestTreePictureNodeItem));
		this.Loader.RegisterNodeType(EQuestTreeNodeType.Text, typeof(QuestTreeTextNodeItem));
		this.Loader.RegisterNodeType(EQuestTreeNodeType.Series, typeof(QuestTreeSeriesNodeItem));
		this.Loader.RegisterNodeType(EQuestTreeNodeType.Container, typeof(QuestTreeNodeContainer));
	}

	// Token: 0x0601194F RID: 72015 RVA: 0x0052EAB0 File Offset: 0x0052CCB0
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public UniTask<IQuestTreeNodeItem> CreateAndLoadNode(QuestTreeNodeData nodeData, UUIItem parent)
	{
		QuestTreeNodeItemFactory.<CreateAndLoadNode>d__3 <CreateAndLoadNode>d__;
		<CreateAndLoadNode>d__.<>t__builder = AsyncUniTaskMethodBuilder<IQuestTreeNodeItem>.Create();
		<CreateAndLoadNode>d__.<>4__this = this;
		<CreateAndLoadNode>d__.nodeData = nodeData;
		<CreateAndLoadNode>d__.parent = parent;
		<CreateAndLoadNode>d__.<>1__state = -1;
		<CreateAndLoadNode>d__.<>t__builder.Start<QuestTreeNodeItemFactory.<CreateAndLoadNode>d__3>(ref <CreateAndLoadNode>d__);
		return <CreateAndLoadNode>d__.<>t__builder.Task;
	}

	// Token: 0x06011950 RID: 72016 RVA: 0x0052EB03 File Offset: 0x0052CD03
	[NullableContext(2)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public QuestTreeNodeItemBase<TData> CreateLogicalNodeItem<TData>(EQuestTreeNodeType type)
	{
		return this.Loader.CreateLogicalNodeItem<TData>(type);
	}

	// Token: 0x17001A83 RID: 6787
	// (get) Token: 0x06011951 RID: 72017 RVA: 0x0052EB11 File Offset: 0x0052CD11
	public static QuestTreeNodeItemFactory Instance
	{
		get
		{
			if (QuestTreeNodeItemFactory._instance == null)
			{
				QuestTreeNodeItemFactory._instance = new QuestTreeNodeItemFactory();
				QuestTreeNodeItemFactory._instance.OnInit();
			}
			return QuestTreeNodeItemFactory._instance;
		}
	}

	// Token: 0x06011952 RID: 72018 RVA: 0x0052EB34 File Offset: 0x0052CD34
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011953 RID: 72019 RVA: 0x0052EB36 File Offset: 0x0052CD36
	public static void ResetStaticDefaultValue()
	{
		QuestTreeNodeItemFactory instance = QuestTreeNodeItemFactory._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		QuestTreeNodeItemFactory._instance = null;
	}

	// Token: 0x06011954 RID: 72020 RVA: 0x0052EB4F File Offset: 0x0052CD4F
	static QuestTreeNodeItemFactory()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestTreeNodeItemFactory.CreateStaticDefaultValue), new Action(QuestTreeNodeItemFactory.ResetStaticDefaultValue));
	}

	// Token: 0x040099E3 RID: 39395
	private QuestTreeNodeItemLoader Loader;

	// Token: 0x040099E4 RID: 39396
	[Nullable(2)]
	private static QuestTreeNodeItemFactory _instance;
}
