using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B93 RID: 7059
public class QuestTreeAvailableListView : UiViewBase
{
	// Token: 0x06011943 RID: 72003 RVA: 0x0052E62D File Offset: 0x0052C82D
	[NullableContext(1)]
	public QuestTreeAvailableListView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06011944 RID: 72004 RVA: 0x0052E638 File Offset: 0x0052C838
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06011945 RID: 72005 RVA: 0x0052E6C4 File Offset: 0x0052C8C4
	protected override void OnStart()
	{
		List<QuestTreeNodeData> data = (this.OpenParam as List<QuestTreeNodeData>) ?? new List<QuestTreeNodeData>();
		this.LoopScrollView = new LoopScrollView<QuestTreeAvailableNodeItem, QuestTreeNodeData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, () => new QuestTreeAvailableNodeItem(), false);
		this.LoopScrollView.RefreshByData(data, false, null, false);
	}

	// Token: 0x040099E1 RID: 39393
	[Nullable(1)]
	private LoopScrollView<QuestTreeAvailableNodeItem, QuestTreeNodeData> LoopScrollView;

	// Token: 0x02007E71 RID: 32369
	private class EComponentDefine
	{
		// Token: 0x04028E8D RID: 167565
		public const int LoopScrollView = 0;

		// Token: 0x04028E8E RID: 167566
		public const int ItemQuest = 1;

		// Token: 0x04028E8F RID: 167567
		public const int TextNum = 2;
	}
}
