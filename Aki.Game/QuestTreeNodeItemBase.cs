using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001B98 RID: 7064
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public abstract class QuestTreeNodeItemBase<[Nullable(2)] TData> : GridProxyAbstract<TData>, IQuestTreeNodeItem
{
	// Token: 0x17001A86 RID: 6790
	// (get) Token: 0x0601195E RID: 72030
	public abstract EQuestTreeNodeType Type { get; }

	// Token: 0x17001A87 RID: 6791
	// (get) Token: 0x0601195F RID: 72031 RVA: 0x0052EB76 File Offset: 0x0052CD76
	// (set) Token: 0x06011960 RID: 72032 RVA: 0x0052EB7E File Offset: 0x0052CD7E
	public int HierarchyIndex { get; set; }

	// Token: 0x17001A88 RID: 6792
	// (get) Token: 0x06011961 RID: 72033 RVA: 0x0052EB87 File Offset: 0x0052CD87
	// (set) Token: 0x06011962 RID: 72034 RVA: 0x0052EB8F File Offset: 0x0052CD8F
	private protected IQuestTreeNodeItemLoader Loader { protected get; private set; }

	// Token: 0x06011963 RID: 72035 RVA: 0x0052EB98 File Offset: 0x0052CD98
	public void Init(IQuestTreeNodeItemLoader loader)
	{
		this.Loader = loader;
	}

	// Token: 0x06011964 RID: 72036
	public abstract UniTask CreateSelf(UUIItem parent);

	// Token: 0x06011965 RID: 72037
	public abstract void UpdateData(QuestTreeNodeData data);

	// Token: 0x06011966 RID: 72038 RVA: 0x0052EBA1 File Offset: 0x0052CDA1
	public virtual float GetAdditionalHeight()
	{
		return 0f;
	}

	// Token: 0x06011967 RID: 72039 RVA: 0x0052EBA8 File Offset: 0x0052CDA8
	public virtual void UpdateDataList(List<QuestTreeNodeData> data)
	{
	}

	// Token: 0x06011968 RID: 72040 RVA: 0x0052EBAA File Offset: 0x0052CDAA
	protected virtual void LocateSelf(bool tween = true)
	{
		QuestTreeNodeLocatingHelper locatingHelper = QuestTreeModel.Instance.ViewModelChapter.LocatingHelper;
		if (locatingHelper == null)
		{
			return;
		}
		locatingHelper.LocateToNode(base.GetRootItem(), tween, false);
	}

	// Token: 0x06011969 RID: 72041 RVA: 0x0052EBCD File Offset: 0x0052CDCD
	[NullableContext(2)]
	public virtual UUIItem GetGuideFocusUiItem()
	{
		return base.GetRootItem();
	}
}
