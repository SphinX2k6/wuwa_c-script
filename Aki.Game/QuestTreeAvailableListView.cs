using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020026A8 RID: 9896
public class QuestTreeAvailableListView : UiViewBase
{
	// Token: 0x06014461 RID: 83041 RVA: 0x0051F8F5 File Offset: 0x0051DAF5
	[NullableContext(1)]
	public QuestTreeAvailableListView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06014462 RID: 83042 RVA: 0x0051F900 File Offset: 0x0051DB00
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

	// Token: 0x06014463 RID: 83043 RVA: 0x0051F98C File Offset: 0x0051DB8C
	protected override void OnStart()
	{
		List<QuestTreeNodeData> data = (this.OpenParam as List<QuestTreeNodeData>) ?? new List<QuestTreeNodeData>();
		this.LoopScrollView = new LoopScrollView<QuestTreeAvailableNodeItem, QuestTreeNodeData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, () => new QuestTreeAvailableNodeItem(), false);
		this.LoopScrollView.RefreshByData(data, false, null, false);
	}

	// Token: 0x04009889 RID: 39049
	[Nullable(1)]
	private LoopScrollView<QuestTreeAvailableNodeItem, QuestTreeNodeData> LoopScrollView;

	// Token: 0x02008CE8 RID: 36072
	private class EComponentDefine
	{
		// Token: 0x0402DB76 RID: 187254
		public const int LoopScrollView = 0;

		// Token: 0x0402DB77 RID: 187255
		public const int ItemQuest = 1;

		// Token: 0x0402DB78 RID: 187256
		public const int TextNum = 2;
	}
}
