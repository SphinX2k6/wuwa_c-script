using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001880 RID: 6272
public class GiftPackageMonthlyCardItem : UiPanelBase
{
	// Token: 0x0600F85F RID: 63583 RVA: 0x0048AE11 File Offset: 0x00489011
	[NullableContext(1)]
	public GiftPackageMonthlyCardItem(int mothCardId, UUIItem uiItem)
	{
		this.MothCardId = mothCardId;
		base.CreateThenShowByResourceIdAsync("UiItem_GiftPackageMonthlyCard", uiItem, false).Forget();
	}

	// Token: 0x0600F860 RID: 63584 RVA: 0x0048AE34 File Offset: 0x00489034
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600F861 RID: 63585 RVA: 0x0048AEE0 File Offset: 0x004890E0
	protected override void OnStart()
	{
		this.ImmediateRewardItem = new GiftPackageItem();
		this.ImmediateRewardItem.Initialize(base.GetItem(0));
		this.ImmediateRewardItem.SetBelongViewName(EUiViewName.GiftPackageDetailsView);
		this.DailyRewardItem = new GiftPackageItem();
		this.DailyRewardItem.Initialize(base.GetItem(1));
		this.ImmediateRewardItem.SetBelongViewName(EUiViewName.GiftPackageDetailsView);
		this.InitDailyRewardItem();
		this.Refresh();
		this.RefreshCloudGameInfo();
	}

	// Token: 0x0600F862 RID: 63586 RVA: 0x0048AF5C File Offset: 0x0048915C
	public void InitDailyRewardItem()
	{
		int? intConfig = ConfigCommonParamById.GetIntConfig("MonthCardDailyItemId");
		int? intConfig2 = ConfigCommonParamById.GetIntConfig("MonthCardDailyItemCount");
		this.DailyRewardItem.UpdateItem(intConfig.Value, intConfig2.Value);
	}

	// Token: 0x0600F863 RID: 63587 RVA: 0x0048AF98 File Offset: 0x00489198
	public void Update(int monthCardId)
	{
		this.MothCardId = monthCardId;
		this.Refresh();
	}

	// Token: 0x0600F864 RID: 63588 RVA: 0x0048AFA8 File Offset: 0x004891A8
	public void Refresh()
	{
		if (base.InAsyncLoading())
		{
			return;
		}
		MonthCardContent value = MonthCardConfig.Instance.GetConfig(this.MothCardId).Value;
		this.ImmediateRewardItem.UpdateItem(value.ItemId, value.Count);
	}

	// Token: 0x0600F865 RID: 63589 RVA: 0x0048AFF0 File Offset: 0x004891F0
	private void RefreshCloudGameInfo()
	{
		PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(42);
		bool flag = payShopGoodsById.HasCloudGameInfo();
		UUIText text = base.GetText(3);
		text.SetUIActive(flag);
		if (flag)
		{
			text.SetText(payShopGoodsById.GetCloudGameDesc(), true);
		}
	}

	// Token: 0x04008AFF RID: 35583
	[Nullable(2)]
	private GiftPackageItem ImmediateRewardItem;

	// Token: 0x04008B00 RID: 35584
	[Nullable(2)]
	private GiftPackageItem DailyRewardItem;

	// Token: 0x04008B01 RID: 35585
	private int MothCardId;

	// Token: 0x02007ACA RID: 31434
	private class EGiftPackageMonthlyCardItem
	{
		// Token: 0x04027D00 RID: 163072
		public const int ImmediateRewardItem = 0;

		// Token: 0x04027D01 RID: 163073
		public const int DailyRewardItem = 1;

		// Token: 0x04027D02 RID: 163074
		public const int TipText = 2;

		// Token: 0x04027D03 RID: 163075
		public const int CloudGameDesc = 3;
	}
}
