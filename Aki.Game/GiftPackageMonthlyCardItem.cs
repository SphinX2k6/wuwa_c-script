using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200239B RID: 9115
public class GiftPackageMonthlyCardItem : UiPanelBase
{
	// Token: 0x060123AD RID: 74669 RVA: 0x0047D9D1 File Offset: 0x0047BBD1
	[NullableContext(1)]
	public GiftPackageMonthlyCardItem(int mothCardId, UUIItem uiItem)
	{
		this.MothCardId = mothCardId;
		base.CreateThenShowByResourceIdAsync("UiItem_GiftPackageMonthlyCard", uiItem, false).Forget();
	}

	// Token: 0x060123AE RID: 74670 RVA: 0x0047D9F4 File Offset: 0x0047BBF4
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

	// Token: 0x060123AF RID: 74671 RVA: 0x0047DAA0 File Offset: 0x0047BCA0
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

	// Token: 0x060123B0 RID: 74672 RVA: 0x0047DB1C File Offset: 0x0047BD1C
	public void InitDailyRewardItem()
	{
		int? intConfig = ConfigCommonParamById.GetIntConfig("MonthCardDailyItemId");
		int? intConfig2 = ConfigCommonParamById.GetIntConfig("MonthCardDailyItemCount");
		this.DailyRewardItem.UpdateItem(intConfig.Value, intConfig2.Value);
	}

	// Token: 0x060123B1 RID: 74673 RVA: 0x0047DB58 File Offset: 0x0047BD58
	public void Update(int monthCardId)
	{
		this.MothCardId = monthCardId;
		this.Refresh();
	}

	// Token: 0x060123B2 RID: 74674 RVA: 0x0047DB68 File Offset: 0x0047BD68
	public void Refresh()
	{
		if (base.InAsyncLoading())
		{
			return;
		}
		MonthCardContent value = MonthCardConfig.Instance.GetConfig(this.MothCardId).Value;
		this.ImmediateRewardItem.UpdateItem(value.ItemId, value.Count);
	}

	// Token: 0x060123B3 RID: 74675 RVA: 0x0047DBB0 File Offset: 0x0047BDB0
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

	// Token: 0x040089B8 RID: 35256
	[Nullable(2)]
	private GiftPackageItem ImmediateRewardItem;

	// Token: 0x040089B9 RID: 35257
	[Nullable(2)]
	private GiftPackageItem DailyRewardItem;

	// Token: 0x040089BA RID: 35258
	private int MothCardId;

	// Token: 0x0200893F RID: 35135
	private class EGiftPackageMonthlyCardItem
	{
		// Token: 0x0402C9E3 RID: 182755
		public const int ImmediateRewardItem = 0;

		// Token: 0x0402C9E4 RID: 182756
		public const int DailyRewardItem = 1;

		// Token: 0x0402C9E5 RID: 182757
		public const int TipText = 2;

		// Token: 0x0402C9E6 RID: 182758
		public const int CloudGameDesc = 3;
	}
}
