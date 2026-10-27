using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200154C RID: 5452
[NullableContext(1)]
[Nullable(0)]
public class ActivityRewardList<TProxy, [Nullable(2)] TData> : UiPanelBase where TProxy : class, IGridProxy<TData>
{
	// Token: 0x06009BCF RID: 39887 RVA: 0x0021BAB4 File Offset: 0x00219CB4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009BD0 RID: 39888 RVA: 0x0021BB5F File Offset: 0x00219D5F
	public void InitGridLayout(Func<TProxy> gridProxyCreateFunction)
	{
		this.GridProxyCreateFunction = gridProxyCreateFunction;
		if (this.ItemLayout == null)
		{
			this.ItemLayout = new GenericLayout<TProxy, TData>(base.GetHorizontalLayout(2), this.GridProxyCreateFunction, null, false, true);
		}
	}

	// Token: 0x06009BD1 RID: 39889 RVA: 0x0021BB8B File Offset: 0x00219D8B
	public CommonItemSmallItemGrid InitCommonGridItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = this.ShowReceivedCallBack
		};
	}

	// Token: 0x06009BD2 RID: 39890 RVA: 0x0021BB9E File Offset: 0x00219D9E
	public void SetCommonTitle()
	{
		base.GetText(1).ShowTextNew("CollectActivity_reward");
	}

	// Token: 0x06009BD3 RID: 39891 RVA: 0x0021BBB1 File Offset: 0x00219DB1
	public void SetTitleByTextId(string textId)
	{
		base.GetText(1).ShowTextNew(textId);
	}

	// Token: 0x06009BD4 RID: 39892 RVA: 0x0021BBC0 File Offset: 0x00219DC0
	public void SetTitleByText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x06009BD5 RID: 39893 RVA: 0x0021BBD0 File Offset: 0x00219DD0
	public UUITexture GetBgTexture()
	{
		return base.GetTexture(0);
	}

	// Token: 0x06009BD6 RID: 39894 RVA: 0x0021BBD9 File Offset: 0x00219DD9
	public void RefreshItemLayout(IReadOnlyList<TData> dataList, [Nullable(2)] Action callBack = null)
	{
		this.ItemLayout.RefreshByData(dataList, callBack, false);
	}

	// Token: 0x06009BD7 RID: 39895 RVA: 0x0021BBE9 File Offset: 0x00219DE9
	public TProxy[] GetLayoutItemList()
	{
		return this.ItemLayout.GetLayoutItemList().ToArray();
	}

	// Token: 0x06009BD8 RID: 39896 RVA: 0x0021BBFB File Offset: 0x00219DFB
	public void SetItemLayoutVisible(bool bVisible)
	{
		this.ItemLayout.SetActive(bVisible);
	}

	// Token: 0x04004469 RID: 17513
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TProxy, TData> ItemLayout;

	// Token: 0x0400446A RID: 17514
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<TProxy> GridProxyCreateFunction;

	// Token: 0x0400446B RID: 17515
	[Nullable(2)]
	public Func<TItem, bool> ShowReceivedCallBack;

	// Token: 0x02007B81 RID: 31617
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040289A9 RID: 166313
		public const int BgTexture = 0;

		// Token: 0x040289AA RID: 166314
		public const int Title = 1;

		// Token: 0x040289AB RID: 166315
		public const int Layout = 2;

		// Token: 0x040289AC RID: 166316
		public const int GridItem = 3;
	}
}
