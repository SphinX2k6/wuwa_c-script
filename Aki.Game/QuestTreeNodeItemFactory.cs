using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026AB RID: 9899
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeNodeItemFactory : Singleton
{
	// Token: 0x0601446B RID: 83051 RVA: 0x0051FCFE File Offset: 0x0051DEFE
	protected override bool OnInit()
	{
		this.InitializeLoader();
		return true;
	}

	// Token: 0x0601446C RID: 83052 RVA: 0x0051FD08 File Offset: 0x0051DF08
	public void InitializeLoader()
	{
		this.Loader = new QuestTreeNodeItemLoader();
		this.Loader.RegisterNodeType(EQuestTreeNodeType.Picture, typeof(QuestTreePictureNodeItem));
		this.Loader.RegisterNodeType(EQuestTreeNodeType.Text, typeof(QuestTreeTextNodeItem));
		this.Loader.RegisterNodeType(EQuestTreeNodeType.Series, typeof(QuestTreeSeriesNodeItem));
		this.Loader.RegisterNodeType(EQuestTreeNodeType.Container, typeof(QuestTreeNodeContainer));
	}

	// Token: 0x0601446D RID: 83053 RVA: 0x0051FD78 File Offset: 0x0051DF78
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

	// Token: 0x0601446E RID: 83054 RVA: 0x0051FDCB File Offset: 0x0051DFCB
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

	// Token: 0x17001A4B RID: 6731
	// (get) Token: 0x0601446F RID: 83055 RVA: 0x0051FDD9 File Offset: 0x0051DFD9
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

	// Token: 0x06014470 RID: 83056 RVA: 0x0051FDFC File Offset: 0x0051DFFC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014471 RID: 83057 RVA: 0x0051FDFE File Offset: 0x0051DFFE
	public static void ResetStaticDefaultValue()
	{
		QuestTreeNodeItemFactory instance = QuestTreeNodeItemFactory._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		QuestTreeNodeItemFactory._instance = null;
	}

	// Token: 0x06014472 RID: 83058 RVA: 0x0051FE17 File Offset: 0x0051E017
	static QuestTreeNodeItemFactory()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(QuestTreeNodeItemFactory.CreateStaticDefaultValue), new Action(QuestTreeNodeItemFactory.ResetStaticDefaultValue));
	}

	// Token: 0x0400988B RID: 39051
	private QuestTreeNodeItemLoader Loader;

	// Token: 0x0400988C RID: 39052
	[Nullable(2)]
	private static QuestTreeNodeItemFactory _instance;
}
