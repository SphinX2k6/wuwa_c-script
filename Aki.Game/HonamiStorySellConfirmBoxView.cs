using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EEE RID: 7918
[NullableContext(1)]
[Nullable(0)]
public class HonamiStorySellConfirmBoxView : UiViewBase
{
	// Token: 0x0600F3B4 RID: 62388 RVA: 0x003ABFBC File Offset: 0x003AA1BC
	public HonamiStorySellConfirmBoxView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F3B5 RID: 62389 RVA: 0x003ABFF8 File Offset: 0x003AA1F8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F3B6 RID: 62390 RVA: 0x003AC0E8 File Offset: 0x003AA2E8
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStorySellConfirmBoxView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStorySellConfirmBoxView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F3B7 RID: 62391 RVA: 0x003AC12C File Offset: 0x003AA32C
	protected override void OnStart()
	{
		IHonamiStorySellConfirmBoxOpenParam honamiStorySellConfirmBoxOpenParam = (IHonamiStorySellConfirmBoxOpenParam)this.OpenParam;
		this.SellItemList = honamiStorySellConfirmBoxOpenParam.SellItemList;
		this.SellCallback = honamiStorySellConfirmBoxOpenParam.SellCallback;
	}

	// Token: 0x0600F3B8 RID: 62392 RVA: 0x003AC15D File Offset: 0x003AA35D
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600F3B9 RID: 62393 RVA: 0x003AC168 File Offset: 0x003AA368
	private void RefreshView()
	{
		List<IHonamiStoryItemSellItemInfo> list = new List<IHonamiStoryItemSellItemInfo>();
		int num = 0;
		Dictionary<HonamiStoryItemDataBase, int> dictionary = new Dictionary<HonamiStoryItemDataBase, int>();
		foreach (IHonamiStoryItemSellInfo honamiStoryItemSellInfo in this.SellItemList)
		{
			HonamiStoryItemDataBase itemData = honamiStoryItemSellInfo.ItemData;
			int num2;
			if (dictionary.TryGetValue(itemData, out num2))
			{
				dictionary[itemData] = num2 + 1;
			}
			else
			{
				dictionary[itemData] = 1;
			}
		}
		foreach (KeyValuePair<HonamiStoryItemDataBase, int> keyValuePair in dictionary)
		{
			HonamiStoryItemDataBase key = keyValuePair.Key;
			int value = keyValuePair.Value;
			list.Add(new HonamiStoryItemSellItemInfo
			{
				ItemData = key,
				Number = value
			});
			num += key.GetSellPrice() * value;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "HonamiStory_SumPriceConfirmText", new <>z__ReadOnlySingleElementList<object>(num.ToString()));
		this.LoopScrollView.RefreshByData(list, false, null, false);
	}

	// Token: 0x0600F3BA RID: 62394 RVA: 0x003AC290 File Offset: 0x003AA490
	private void OnClickConfirmButton(int _)
	{
		HonamiStoryController.Instance.RequestHonamiStorySellItem(this.SellItemList).ContinueWith(delegate(bool _)
		{
			this.SellCallback();
			base.CloseMe(null);
		});
	}

	// Token: 0x0600F3BB RID: 62395 RVA: 0x003AC2B4 File Offset: 0x003AA4B4
	private void OnClickCancelButton(int _)
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F3BC RID: 62396 RVA: 0x003AC2BD File Offset: 0x003AA4BD
	private HonamiStorySellConfirmBoxItem OnGridProxyCreate()
	{
		return new HonamiStorySellConfirmBoxItem();
	}

	// Token: 0x040070D3 RID: 28883
	private List<IHonamiStoryItemSellInfo> SellItemList = new List<IHonamiStoryItemSellInfo>();

	// Token: 0x040070D4 RID: 28884
	private Action SellCallback = delegate()
	{
	};

	// Token: 0x040070D5 RID: 28885
	[Nullable(2)]
	private ButtonItem ConfirmButton;

	// Token: 0x040070D6 RID: 28886
	[Nullable(2)]
	private ButtonItem CancelButton;

	// Token: 0x040070D7 RID: 28887
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<HonamiStorySellConfirmBoxItem, IHonamiStoryItemSellItemInfo> LoopScrollView;

	// Token: 0x020084E4 RID: 34020
	[NullableContext(0)]
	private enum EHonamiSellConfirmComponents
	{
		// Token: 0x0402B3F0 RID: 177136
		TextTitle,
		// Token: 0x0402B3F1 RID: 177137
		ConfirmButton,
		// Token: 0x0402B3F2 RID: 177138
		LoopScrollView,
		// Token: 0x0402B3F3 RID: 177139
		ScrollItem,
		// Token: 0x0402B3F4 RID: 177140
		ConfirmText,
		// Token: 0x0402B3F5 RID: 177141
		CancelButton
	}
}
