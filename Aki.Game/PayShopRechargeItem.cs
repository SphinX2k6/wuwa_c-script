using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200238B RID: 9099
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopRechargeItem : GridProxyAbstract<IPayShopUnionData>
{
	// Token: 0x06012305 RID: 74501 RVA: 0x0047A4F8 File Offset: 0x004786F8
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

	// Token: 0x06012306 RID: 74502 RVA: 0x0047A622 File Offset: 0x00478822
	public void SetRaycastState(bool state)
	{
		this.RootItem.SetRaycastTarget(state);
		this.PayShopItemBase.GetRootItem().SetRaycastTarget(state);
	}

	// Token: 0x06012307 RID: 74503 RVA: 0x0047A641 File Offset: 0x00478841
	public void SetDownPriceShowState(bool state)
	{
		this.PayShopItemBase.SetDownPriceShowState(state);
	}

	// Token: 0x06012308 RID: 74504 RVA: 0x0047A650 File Offset: 0x00478850
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

	// Token: 0x06012309 RID: 74505 RVA: 0x0047A6A8 File Offset: 0x004788A8
	protected override void OnStart()
	{
		this.PayShopItemBase = new PayShopItemBase(base.GetItem(0));
		this.PayShopItemBase.Init();
		this.CurrentGiveItemShowState = base.GetItem(1).bIsUIActive;
		this.CurrentDoubleItemShowState = base.GetItem(3).bIsUIActive;
		this.AddEventListener();
	}

	// Token: 0x0601230A RID: 74506 RVA: 0x0047A6FC File Offset: 0x004788FC
	private void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Add(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0601230B RID: 74507 RVA: 0x0047A736 File Offset: 0x00478936
	private void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0601230C RID: 74508 RVA: 0x0047A770 File Offset: 0x00478970
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0601230D RID: 74509 RVA: 0x0047A778 File Offset: 0x00478978
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

	// Token: 0x0601230E RID: 74510 RVA: 0x0047A837 File Offset: 0x00478A37
	private void OnDiscountShopTimerRefresh()
	{
		if (this.Data == null)
		{
			return;
		}
		this.RefreshBonus();
		this.RefreshSpecialBonus();
	}

	// Token: 0x0601230F RID: 74511 RVA: 0x0047A850 File Offset: 0x00478A50
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

	// Token: 0x06012310 RID: 74512 RVA: 0x0047A898 File Offset: 0x00478A98
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

	// Token: 0x06012311 RID: 74513 RVA: 0x0047A92C File Offset: 0x00478B2C
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

	// Token: 0x04008987 RID: 35207
	[Nullable(2)]
	private PayItemData Data;

	// Token: 0x04008988 RID: 35208
	[Nullable(2)]
	private PayShopItemBase PayShopItemBase;

	// Token: 0x04008989 RID: 35209
	private bool CurrentGiveItemShowState;

	// Token: 0x0400898A RID: 35210
	private int CurrentShowGiveCount;

	// Token: 0x0400898B RID: 35211
	private bool CurrentDoubleItemShowState;

	// Token: 0x0400898C RID: 35212
	private int CurrentSpecialBonusCount;

	// Token: 0x0200892D RID: 35117
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402C97C RID: 182652
		public const int BaseItem = 0;

		// Token: 0x0402C97D RID: 182653
		public const int GiveItem = 1;

		// Token: 0x0402C97E RID: 182654
		public const int GiveText = 2;

		// Token: 0x0402C97F RID: 182655
		public const int DoubleItem = 3;

		// Token: 0x0402C980 RID: 182656
		public const int DoubleText = 4;

		// Token: 0x0402C981 RID: 182657
		public const int BuyButton = 5;
	}
}
