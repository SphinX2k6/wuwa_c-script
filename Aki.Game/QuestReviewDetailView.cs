using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B65 RID: 7013
public class QuestReviewDetailView : UiViewBase
{
	// Token: 0x060117D7 RID: 71639 RVA: 0x00527410 File Offset: 0x00525610
	[NullableContext(1)]
	public QuestReviewDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060117D8 RID: 71640 RVA: 0x0052741C File Offset: 0x0052561C
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

	// Token: 0x060117D9 RID: 71641 RVA: 0x00527614 File Offset: 0x00525814
	protected override UniTask OnBeforeStartAsync()
	{
		QuestReviewDetailView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestReviewDetailView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060117DA RID: 71642 RVA: 0x00527658 File Offset: 0x00525858
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

	// Token: 0x060117DB RID: 71643 RVA: 0x005276A4 File Offset: 0x005258A4
	private void OnBtnLeftClick()
	{
		QuestReviewNodeData predecessorNodeByNodeId = QuestReviewModel.Instance.GetPredecessorNodeByNodeId(this.Node.Id);
		if (predecessorNodeByNodeId != null)
		{
			this.RefreshAsync(predecessorNodeByNodeId);
		}
	}

	// Token: 0x060117DC RID: 71644 RVA: 0x005276D4 File Offset: 0x005258D4
	private void OnBtnRightClick()
	{
		QuestReviewNodeData successorNodeByNodeId = QuestReviewModel.Instance.GetSuccessorNodeByNodeId(this.Node.Id);
		if (successorNodeByNodeId != null)
		{
			this.RefreshAsync(successorNodeByNodeId);
		}
	}

	// Token: 0x060117DD RID: 71645 RVA: 0x00527702 File Offset: 0x00525902
	private void OnBtnCloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x04009950 RID: 39248
	[Nullable(2)]
	private QuestReviewNodeData Node;

	// Token: 0x04009951 RID: 39249
	[Nullable(2)]
	private QuestReviewDetailImageItem ImageItem;

	// Token: 0x02007E46 RID: 32326
	private class EComponentDefine
	{
		// Token: 0x04028DE3 RID: 167395
		public const int ItemImage = 0;

		// Token: 0x04028DE4 RID: 167396
		public const int DraggableViewport = 1;

		// Token: 0x04028DE5 RID: 167397
		public const int BtnLeft = 2;

		// Token: 0x04028DE6 RID: 167398
		public const int BtnRight = 3;

		// Token: 0x04028DE7 RID: 167399
		public const int BtnClose = 4;

		// Token: 0x04028DE8 RID: 167400
		public const int ScrollDesc = 5;

		// Token: 0x04028DE9 RID: 167401
		public const int TextDesc = 6;

		// Token: 0x04028DEA RID: 167402
		public const int TextBrief = 7;

		// Token: 0x04028DEB RID: 167403
		public const int TextName = 8;

		// Token: 0x04028DEC RID: 167404
		public const int ItemBrief = 9;
	}
}
