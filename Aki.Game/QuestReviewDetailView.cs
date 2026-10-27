using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200267A RID: 9850
public class QuestReviewDetailView : UiViewBase
{
	// Token: 0x060142F5 RID: 82677 RVA: 0x005186D8 File Offset: 0x005168D8
	[NullableContext(1)]
	public QuestReviewDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060142F6 RID: 82678 RVA: 0x005186E4 File Offset: 0x005168E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnLeftClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnRightClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnCloseClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060142F7 RID: 82679 RVA: 0x005188DC File Offset: 0x00516ADC
	protected override UniTask OnBeforeStartAsync()
	{
		QuestReviewDetailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestReviewDetailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060142F8 RID: 82680 RVA: 0x00518920 File Offset: 0x00516B20
	[NullableContext(1)]
	private UniTask RefreshAsync(QuestReviewNodeData node)
	{
		QuestReviewDetailView.<RefreshAsync>d__6 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.node = node;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<QuestReviewDetailView.<RefreshAsync>d__6>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060142F9 RID: 82681 RVA: 0x0051896C File Offset: 0x00516B6C
	private void OnBtnLeftClick()
	{
		QuestReviewNodeData predecessorNodeByNodeId = QuestReviewModel.Instance.GetPredecessorNodeByNodeId(this.Node.Id);
		if (predecessorNodeByNodeId != null)
		{
			this.RefreshAsync(predecessorNodeByNodeId);
		}
	}

	// Token: 0x060142FA RID: 82682 RVA: 0x0051899C File Offset: 0x00516B9C
	private void OnBtnRightClick()
	{
		QuestReviewNodeData successorNodeByNodeId = QuestReviewModel.Instance.GetSuccessorNodeByNodeId(this.Node.Id);
		if (successorNodeByNodeId != null)
		{
			this.RefreshAsync(successorNodeByNodeId);
		}
	}

	// Token: 0x060142FB RID: 82683 RVA: 0x005189CA File Offset: 0x00516BCA
	private void OnBtnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x040097F8 RID: 38904
	[Nullable(2)]
	private QuestReviewNodeData Node;

	// Token: 0x040097F9 RID: 38905
	[Nullable(2)]
	private QuestReviewDetailImageItem ImageItem;

	// Token: 0x02008CBD RID: 36029
	private class EComponentDefine
	{
		// Token: 0x0402DACC RID: 187084
		public const int ItemImage = 0;

		// Token: 0x0402DACD RID: 187085
		public const int DraggableViewport = 1;

		// Token: 0x0402DACE RID: 187086
		public const int BtnLeft = 2;

		// Token: 0x0402DACF RID: 187087
		public const int BtnRight = 3;

		// Token: 0x0402DAD0 RID: 187088
		public const int BtnClose = 4;

		// Token: 0x0402DAD1 RID: 187089
		public const int ScrollDesc = 5;

		// Token: 0x0402DAD2 RID: 187090
		public const int TextDesc = 6;

		// Token: 0x0402DAD3 RID: 187091
		public const int TextBrief = 7;

		// Token: 0x0402DAD4 RID: 187092
		public const int TextName = 8;

		// Token: 0x0402DAD5 RID: 187093
		public const int ItemBrief = 9;
	}
}
