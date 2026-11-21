using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001870 RID: 6256
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopRechargeItem : GridProxyAbstract<IPayShopUnionData>
{
	// Token: 0x0600F7B7 RID: 63415 RVA: 0x00487848 File Offset: 0x00485A48
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F7B8 RID: 63416 RVA: 0x00487972 File Offset: 0x00485B72
	public void SetRaycastState(bool state)
	{
		this.RootItem.SetRaycastTarget(state);
		this.PayShopItemBase.GetRootItem().SetRaycastTarget(state);
	}

	// Token: 0x0600F7B9 RID: 63417 RVA: 0x00487991 File Offset: 0x00485B91
	public void SetDownPriceShowState(bool state)
	{
		this.PayShopItemBase.SetDownPriceShowState(state);
	}

	// Token: 0x0600F7BA RID: 63418 RVA: 0x004879A0 File Offset: 0x00485BA0
	private void OnClickItem()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:ShopItem 点击充值";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", this.Data.PayItemId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		PayItemController.Instance.SdkPay(this.Data.PayItemId);
	}

	// Token: 0x0600F7BB RID: 63419 RVA: 0x004879F8 File Offset: 0x00485BF8
	protected override void OnStart()
	{
		this.PayShopItemBase = new PayShopItemBase(base.GetItem(0));
		this.PayShopItemBase.Init();
		this.CurrentGiveItemShowState = base.GetItem(1).bIsUIActive;
		this.CurrentDoubleItemShowState = base.GetItem(3).bIsUIActive;
		this.AddEventListener();
	}

	// Token: 0x0600F7BC RID: 63420 RVA: 0x00487A4C File Offset: 0x00485C4C
	private void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Add(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600F7BD RID: 63421 RVA: 0x00487A86 File Offset: 0x00485C86
	private void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600F7BE RID: 63422 RVA: 0x00487AC0 File Offset: 0x00485CC0
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0600F7BF RID: 63423 RVA: 0x00487AC8 File Offset: 0x00485CC8
	private unsafe void OnPayItemSuccess(PayItemSuccess notify)
	{
		if (notify.PayItemId != this.Data.PayItemId)
		{
			return;
		}
		this.Data.CanSpecialBonus = false;
		this.Refresh(this.Data, false, 0);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:ShopItem 充值成功,道具到账";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("订单号", notify.OrderId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("道具id", notify.ItemId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("道具数量", notify.ItemCount);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0600F7C0 RID: 63424 RVA: 0x00487B87 File Offset: 0x00485D87
	private void OnDiscountShopTimerRefresh()
	{
		if (this.Data == null)
		{
			return;
		}
		this.RefreshBonus();
		this.RefreshSpecialBonus();
	}

	// Token: 0x0600F7C1 RID: 63425 RVA: 0x00487BA0 File Offset: 0x00485DA0
	public override void Refresh(IPayShopUnionData data, bool isSelected, int gridIndex)
	{
		PayItemData payItemData = data as PayItemData;
		if (payItemData == null)
		{
			return;
		}
		this.Data = payItemData;
		this.PayShopItemBase.Refresh(PayItemModel.Instance.ConvertPayItemDataToPayShopItemBaseSt(this.Data), isSelected, gridIndex);
		this.RefreshBonus();
		this.RefreshSpecialBonus();
	}

	// Token: 0x0600F7C2 RID: 63426 RVA: 0x00487BE8 File Offset: 0x00485DE8
	private void RefreshBonus()
	{
		bool flag = false;
		int num = 0;
		if (this.Data.BonusItemCount > 0 && !this.Data.CanSpecialBonus)
		{
			flag = true;
			num = this.Data.BonusItemCount;
		}
		if (this.CurrentGiveItemShowState != flag)
		{
			this.CurrentGiveItemShowState = flag;
			base.GetItem(1).SetUIActive(flag);
		}
		if (this.CurrentShowGiveCount != num)
		{
			this.CurrentShowGiveCount = num;
			LguiUtil.Instance.SetLocalText(base.GetText(2), "DefaultBonus", new <>z__ReadOnlySingleElementList<object>(this.Data.BonusItemCount));
		}
	}

	// Token: 0x0600F7C3 RID: 63427 RVA: 0x00487C7C File Offset: 0x00485E7C
	private void RefreshSpecialBonus()
	{
		bool flag = false;
		int num = 0;
		if (this.Data.CanSpecialBonus)
		{
			flag = true;
			num = this.Data.SpecialBonusItemCount;
		}
		if (this.CurrentDoubleItemShowState != flag)
		{
			this.CurrentDoubleItemShowState = flag;
			base.GetItem(3).SetUIActive(flag);
		}
		if (this.CurrentSpecialBonusCount != num)
		{
			this.CurrentSpecialBonusCount = num;
			LguiUtil.Instance.SetLocalText(base.GetText(4), "FirstBonus2", new <>z__ReadOnlySingleElementList<object>(this.Data.SpecialBonusItemCount));
		}
	}

	// Token: 0x04008ACE RID: 35534
	[Nullable(2)]
	private PayItemData Data;

	// Token: 0x04008ACF RID: 35535
	[Nullable(2)]
	private PayShopItemBase PayShopItemBase;

	// Token: 0x04008AD0 RID: 35536
	private bool CurrentGiveItemShowState;

	// Token: 0x04008AD1 RID: 35537
	private int CurrentShowGiveCount;

	// Token: 0x04008AD2 RID: 35538
	private bool CurrentDoubleItemShowState;

	// Token: 0x04008AD3 RID: 35539
	private int CurrentSpecialBonusCount;

	// Token: 0x02007AB8 RID: 31416
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027C9A RID: 162970
		public const int BaseItem = 0;

		// Token: 0x04027C9B RID: 162971
		public const int GiveItem = 1;

		// Token: 0x04027C9C RID: 162972
		public const int GiveText = 2;

		// Token: 0x04027C9D RID: 162973
		public const int DoubleItem = 3;

		// Token: 0x04027C9E RID: 162974
		public const int DoubleText = 4;

		// Token: 0x04027C9F RID: 162975
		public const int BuyButton = 5;
	}
}
