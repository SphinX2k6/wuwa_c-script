using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A04 RID: 2564
[NullableContext(1)]
[Nullable(0)]
public class ActivityRewardList<TProxy, [Nullable(2)] TData> : UiPanelBase where TProxy : class, IGridProxy<TData>
{
	// Token: 0x06006FAD RID: 28589 RVA: 0x00225864 File Offset: 0x00223A64
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

	// Token: 0x06006FAE RID: 28590 RVA: 0x0022590F File Offset: 0x00223B0F
	public void InitGridLayout(Func<TProxy> gridProxyCreateFunction)
	{
		this.GridProxyCreateFunction = gridProxyCreateFunction;
		if (this.ItemLayout == null)
		{
			this.ItemLayout = new GenericLayout<TProxy, TData>(base.GetHorizontalLayout(2), this.GridProxyCreateFunction, null, false, true);
		}
	}

	// Token: 0x06006FAF RID: 28591 RVA: 0x0022593B File Offset: 0x00223B3B
	public CommonItemSmallItemGrid InitCommonGridItem()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = this.ShowReceivedCallBack
		};
	}

	// Token: 0x06006FB0 RID: 28592 RVA: 0x0022594E File Offset: 0x00223B4E
	public void SetCommonTitle()
	{
		base.GetText(1).ShowTextNew("CollectActivity_reward");
	}

	// Token: 0x06006FB1 RID: 28593 RVA: 0x00225961 File Offset: 0x00223B61
	public void SetTitleByTextId(string textId)
	{
		base.GetText(1).ShowTextNew(textId);
	}

	// Token: 0x06006FB2 RID: 28594 RVA: 0x00225970 File Offset: 0x00223B70
	public void SetTitleByText(string text)
	{
		base.GetText(1).SetText(text, true);
	}

	// Token: 0x06006FB3 RID: 28595 RVA: 0x00225980 File Offset: 0x00223B80
	public UUITexture GetBgTexture()
	{
		return base.GetTexture(0);
	}

	// Token: 0x06006FB4 RID: 28596 RVA: 0x00225989 File Offset: 0x00223B89
	public void RefreshItemLayout(IReadOnlyList<TData> dataList, [Nullable(2)] Action callBack = null)
	{
		this.ItemLayout.RefreshByData(dataList, callBack, false);
	}

	// Token: 0x06006FB5 RID: 28597 RVA: 0x00225999 File Offset: 0x00223B99
	public TProxy[] GetLayoutItemList()
	{
		return this.ItemLayout.GetLayoutItemList().ToArray();
	}

	// Token: 0x06006FB6 RID: 28598 RVA: 0x002259AB File Offset: 0x00223BAB
	public void SetItemLayoutVisible(bool bVisible)
	{
		this.ItemLayout.SetActive(bVisible);
	}

	// Token: 0x0400450F RID: 17679
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<TProxy, TData> ItemLayout;

	// Token: 0x04004510 RID: 17680
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Func<TProxy> GridProxyCreateFunction;

	// Token: 0x04004511 RID: 17681
	[Nullable(2)]
	public Func<TItem, bool> ShowReceivedCallBack;

	// Token: 0x02006D0C RID: 27916
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04023CE4 RID: 146660
		public const int BgTexture = 0;

		// Token: 0x04023CE5 RID: 146661
		public const int Title = 1;

		// Token: 0x04023CE6 RID: 146662
		public const int Layout = 2;

		// Token: 0x04023CE7 RID: 146663
		public const int GridItem = 3;
	}
}
