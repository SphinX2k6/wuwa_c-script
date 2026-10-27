using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FC6 RID: 8134
[NullableContext(1)]
[Nullable(0)]
public class DestroyPreviewView : UiViewBase
{
	// Token: 0x0600FE68 RID: 65128 RVA: 0x003DC0CC File Offset: 0x003DA2CC
	public DestroyPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FE69 RID: 65129 RVA: 0x003DC194 File Offset: 0x003DA394
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600FE6A RID: 65130 RVA: 0x003DC284 File Offset: 0x003DA484
	protected override UniTask OnBeforeStartAsync()
	{
		DestroyPreviewView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DestroyPreviewView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE6B RID: 65131 RVA: 0x003DC2C8 File Offset: 0x003DA4C8
	protected override void OnAfterShow()
	{
		if (this.HasResultItem)
		{
			this.UiViewSequence.PlaySequence("Notice", false, null);
		}
	}

	// Token: 0x0600FE6C RID: 65132 RVA: 0x003DC2F7 File Offset: 0x003DA4F7
	private DestroyPreviewGrid CreateItemGrid()
	{
		return new DestroyPreviewGrid();
	}

	// Token: 0x0600FE6D RID: 65133 RVA: 0x003DC300 File Offset: 0x003DA500
	private void ReSizeLoopScrollView(int itemCount, UUILoopScrollViewComponent loopScrollView)
	{
		int num = 630;
		int num2 = 525;
		if (itemCount < this.layoutSize.Length)
		{
			num = this.layoutSize[itemCount].Item1;
			num2 = this.layoutSize[itemCount].Item2;
		}
		loopScrollView.RootUIComp.Get().SetWidth((float)num);
		loopScrollView.RootUIComp.Get().SetHeight((float)num2);
	}

	// Token: 0x0600FE6E RID: 65134 RVA: 0x003DC374 File Offset: 0x003DA574
	private void RequestDecomposeItem()
	{
		List<DecomposeItemInfo> list = new List<DecomposeItemInfo>();
		foreach (TItem titem in this.DestroyItemList)
		{
			DecomposeItemInfo decomposeItemInfo = DecomposeItemInfo.Create();
			decomposeItemInfo.ItemId = titem.ItemData.ItemId;
			decomposeItemInfo.IncrId = titem.ItemData.IncId;
			decomposeItemInfo.Count = titem.Count;
			list.Add(decomposeItemInfo);
		}
		InventoryController.Instance.ItemDestructRequest(list.ToArray());
	}

	// Token: 0x040075B0 RID: 30128
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<DestroyPreviewGrid, TItem> OriginScrollView;

	// Token: 0x040075B1 RID: 30129
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<DestroyPreviewGrid, TItem> ResultScrollView;

	// Token: 0x040075B2 RID: 30130
	private List<TItem> DestroyItemList = new List<TItem>();

	// Token: 0x040075B3 RID: 30131
	[Nullable(2)]
	private ButtonItem ButtonLeft;

	// Token: 0x040075B4 RID: 30132
	[Nullable(2)]
	private ButtonItem ButtonRight;

	// Token: 0x040075B5 RID: 30133
	private bool HasResultItem;

	// Token: 0x040075B6 RID: 30134
	private const int GRID_SIZE = 210;

	// Token: 0x040075B7 RID: 30135
	private const int GRID_NORMAL_WIDTH_SIZE = 630;

	// Token: 0x040075B8 RID: 30136
	private const int GRID_NORMAL_HEIGHT_SIZE = 525;

	// Token: 0x040075B9 RID: 30137
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly ValueTuple<int, int>[] layoutSize = new ValueTuple<int, int>[]
	{
		new ValueTuple<int, int>(630, 525),
		new ValueTuple<int, int>(210, 210),
		new ValueTuple<int, int>(420, 210),
		new ValueTuple<int, int>(630, 210),
		new ValueTuple<int, int>(630, 420),
		new ValueTuple<int, int>(630, 420),
		new ValueTuple<int, int>(630, 420)
	};

	// Token: 0x020085D7 RID: 34263
	[NullableContext(0)]
	private enum EDestroyPreviewNode
	{
		// Token: 0x0402B90D RID: 178445
		LoopScrollViewLeft,
		// Token: 0x0402B90E RID: 178446
		LoopScrollViewRight,
		// Token: 0x0402B90F RID: 178447
		ItemGrid,
		// Token: 0x0402B910 RID: 178448
		TextNone,
		// Token: 0x0402B911 RID: 178449
		ButtonLeft,
		// Token: 0x0402B912 RID: 178450
		ButtonRight
	}
}
