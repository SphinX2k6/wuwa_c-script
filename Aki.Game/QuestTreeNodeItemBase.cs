using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020026AD RID: 9901
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public abstract class QuestTreeNodeItemBase<[Nullable(2)] TData> : GridProxyAbstract<TData>, IQuestTreeNodeItem
{
	// Token: 0x17001A4E RID: 6734
	// (get) Token: 0x0601447C RID: 83068
	public abstract EQuestTreeNodeType Type { get; }

	// Token: 0x17001A4F RID: 6735
	// (get) Token: 0x0601447D RID: 83069 RVA: 0x0051FE3E File Offset: 0x0051E03E
	// (set) Token: 0x0601447E RID: 83070 RVA: 0x0051FE46 File Offset: 0x0051E046
	public int HierarchyIndex { get; set; }

	// Token: 0x17001A50 RID: 6736
	// (get) Token: 0x0601447F RID: 83071 RVA: 0x0051FE4F File Offset: 0x0051E04F
	// (set) Token: 0x06014480 RID: 83072 RVA: 0x0051FE57 File Offset: 0x0051E057
	private protected IQuestTreeNodeItemLoader Loader { protected get; private set; }

	// Token: 0x06014481 RID: 83073 RVA: 0x0051FE60 File Offset: 0x0051E060
	public void Init(IQuestTreeNodeItemLoader loader)
	{
		this.Loader = loader;
	}

	// Token: 0x06014482 RID: 83074
	public abstract UniTask CreateSelf(UUIItem parent);

	// Token: 0x06014483 RID: 83075
	public abstract void UpdateData(QuestTreeNodeData data);

	// Token: 0x06014484 RID: 83076 RVA: 0x0051FE69 File Offset: 0x0051E069
	public virtual float GetAdditionalHeight()
	{
		return 0f;
	}

	// Token: 0x06014485 RID: 83077 RVA: 0x0051FE70 File Offset: 0x0051E070
	public virtual void UpdateDataList(List<QuestTreeNodeData> data)
	{
	}

	// Token: 0x06014486 RID: 83078 RVA: 0x0051FE72 File Offset: 0x0051E072
	protected virtual void LocateSelf(bool tween = true)
	{
		QuestTreeNodeLocatingHelper locatingHelper = QuestTreeModel.Instance.ViewModelChapter.LocatingHelper;
		if (locatingHelper == null)
		{
			return;
		}
		locatingHelper.LocateToNode(base.GetRootItem(), tween, false);
	}

	// Token: 0x06014487 RID: 83079 RVA: 0x0051FE95 File Offset: 0x0051E095
	[NullableContext(2)]
	public virtual UUIItem GetGuideFocusUiItem()
	{
		return base.GetRootItem();
	}
}
