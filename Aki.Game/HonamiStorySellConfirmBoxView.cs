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

// Token: 0x020013B0 RID: 5040
[NullableContext(1)]
[Nullable(0)]
public class HonamiStorySellConfirmBoxView : UiViewBase
{
	// Token: 0x0600C7D3 RID: 51155 RVA: 0x003B7AB8 File Offset: 0x003B5CB8
	public HonamiStorySellConfirmBoxView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C7D4 RID: 51156 RVA: 0x003B7AF4 File Offset: 0x003B5CF4
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

	// Token: 0x0600C7D5 RID: 51157 RVA: 0x003B7BE4 File Offset: 0x003B5DE4
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStorySellConfirmBoxView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStorySellConfirmBoxView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C7D6 RID: 51158 RVA: 0x003B7C28 File Offset: 0x003B5E28
	protected override void OnStart()
	{
		IHonamiStorySellConfirmBoxOpenParam honamiStorySellConfirmBoxOpenParam = (IHonamiStorySellConfirmBoxOpenParam)this.OpenParam;
		this.SellItemList = honamiStorySellConfirmBoxOpenParam.SellItemList;
		this.SellCallback = honamiStorySellConfirmBoxOpenParam.SellCallback;
	}

	// Token: 0x0600C7D7 RID: 51159 RVA: 0x003B7C59 File Offset: 0x003B5E59
	protected override void OnBeforeShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600C7D8 RID: 51160 RVA: 0x003B7C64 File Offset: 0x003B5E64
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

	// Token: 0x0600C7D9 RID: 51161 RVA: 0x003B7D8C File Offset: 0x003B5F8C
	private void OnClickConfirmButton(int _)
	{
		HonamiStoryController.Instance.RequestHonamiStorySellItem(this.SellItemList).ContinueWith(delegate(bool _)
		{
			this.SellCallback();
			base.CloseMe(null);
		});
	}

	// Token: 0x0600C7DA RID: 51162 RVA: 0x003B7DB0 File Offset: 0x003B5FB0
	private void OnClickCancelButton(int _)
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C7DB RID: 51163 RVA: 0x003B7DB9 File Offset: 0x003B5FB9
	private HonamiStorySellConfirmBoxItem OnGridProxyCreate()
	{
		return new HonamiStorySellConfirmBoxItem();
	}

	// Token: 0x040071B4 RID: 29108
	private List<IHonamiStoryItemSellInfo> SellItemList = new List<IHonamiStoryItemSellInfo>();

	// Token: 0x040071B5 RID: 29109
	private Action SellCallback = delegate()
	{
	};

	// Token: 0x040071B6 RID: 29110
	[Nullable(2)]
	private ButtonItem ConfirmButton;

	// Token: 0x040071B7 RID: 29111
	[Nullable(2)]
	private ButtonItem CancelButton;

	// Token: 0x040071B8 RID: 29112
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<HonamiStorySellConfirmBoxItem, IHonamiStoryItemSellItemInfo> LoopScrollView;

	// Token: 0x02007669 RID: 30313
	[NullableContext(0)]
	private enum EHonamiSellConfirmComponents
	{
		// Token: 0x04026714 RID: 157460
		TextTitle,
		// Token: 0x04026715 RID: 157461
		ConfirmButton,
		// Token: 0x04026716 RID: 157462
		LoopScrollView,
		// Token: 0x04026717 RID: 157463
		ScrollItem,
		// Token: 0x04026718 RID: 157464
		ConfirmText,
		// Token: 0x04026719 RID: 157465
		CancelButton
	}
}
