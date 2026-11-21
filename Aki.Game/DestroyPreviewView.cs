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

// Token: 0x02001499 RID: 5273
[NullableContext(1)]
[Nullable(0)]
public class DestroyPreviewView : UiViewBase
{
	// Token: 0x0600D2D0 RID: 53968 RVA: 0x003E86A8 File Offset: 0x003E68A8
	public DestroyPreviewView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D2D1 RID: 53969 RVA: 0x003E8770 File Offset: 0x003E6970
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

	// Token: 0x0600D2D2 RID: 53970 RVA: 0x003E8860 File Offset: 0x003E6A60
	protected override UniTask OnBeforeStartAsync()
	{
		DestroyPreviewView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DestroyPreviewView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D2D3 RID: 53971 RVA: 0x003E88A4 File Offset: 0x003E6AA4
	protected override void OnAfterShow()
	{
		if (this.HasResultItem)
		{
			this.UiViewSequence.PlaySequence("Notice", false, null);
		}
	}

	// Token: 0x0600D2D4 RID: 53972 RVA: 0x003E88D3 File Offset: 0x003E6AD3
	private DestroyPreviewGrid CreateItemGrid()
	{
		return new DestroyPreviewGrid();
	}

	// Token: 0x0600D2D5 RID: 53973 RVA: 0x003E88DC File Offset: 0x003E6ADC
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

	// Token: 0x0600D2D6 RID: 53974 RVA: 0x003E8950 File Offset: 0x003E6B50
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

	// Token: 0x04007699 RID: 30361
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<DestroyPreviewGrid, TItem> OriginScrollView;

	// Token: 0x0400769A RID: 30362
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<DestroyPreviewGrid, TItem> ResultScrollView;

	// Token: 0x0400769B RID: 30363
	private List<TItem> DestroyItemList = new List<TItem>();

	// Token: 0x0400769C RID: 30364
	[Nullable(2)]
	private ButtonItem ButtonLeft;

	// Token: 0x0400769D RID: 30365
	[Nullable(2)]
	private ButtonItem ButtonRight;

	// Token: 0x0400769E RID: 30366
	private bool HasResultItem;

	// Token: 0x0400769F RID: 30367
	private const int GRID_SIZE = 210;

	// Token: 0x040076A0 RID: 30368
	private const int GRID_NORMAL_WIDTH_SIZE = 630;

	// Token: 0x040076A1 RID: 30369
	private const int GRID_NORMAL_HEIGHT_SIZE = 525;

	// Token: 0x040076A2 RID: 30370
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

	// Token: 0x0200775E RID: 30558
	[NullableContext(0)]
	private enum EDestroyPreviewNode
	{
		// Token: 0x04026C1C RID: 158748
		LoopScrollViewLeft,
		// Token: 0x04026C1D RID: 158749
		LoopScrollViewRight,
		// Token: 0x04026C1E RID: 158750
		ItemGrid,
		// Token: 0x04026C1F RID: 158751
		TextNone,
		// Token: 0x04026C20 RID: 158752
		ButtonLeft,
		// Token: 0x04026C21 RID: 158753
		ButtonRight
	}
}
