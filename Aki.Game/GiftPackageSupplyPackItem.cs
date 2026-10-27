using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200239C RID: 9116
[NullableContext(1)]
[Nullable(0)]
public class GiftPackageSupplyPackItem : UiPanelBase
{
	// Token: 0x060123B4 RID: 74676 RVA: 0x0047DBF0 File Offset: 0x0047BDF0
	public GiftPackageSupplyPackItem(int packId, UUIItem uiItem, PayShopGoods goods)
	{
		this.PackId = packId;
		this.Goods = goods;
		base.CreateThenShowByResourceIdAsync("UiItem_GiftPackageSupplyPack", uiItem, false).Forget();
	}

	// Token: 0x060123B5 RID: 74677 RVA: 0x0047DC24 File Offset: 0x0047BE24
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060123B6 RID: 74678 RVA: 0x0047DD53 File Offset: 0x0047BF53
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollView<GiftPackageItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<GiftPackageItem>(this.InitItem), null);
		this.Refresh();
	}

	// Token: 0x060123B7 RID: 74679 RVA: 0x0047DD7C File Offset: 0x0047BF7C
	public void Refresh()
	{
		if (base.InAsyncLoading())
		{
			return;
		}
		GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(this.PackId);
		int num = 0;
		foreach (KeyValuePair<int, int> keyValuePair in giftPackageConfig.Value.Content())
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(key)) == InventoryDefine.EItemDataType.RoleSkinItem)
			{
				num = key;
				break;
			}
			this.RewardList.Add(new int[]
			{
				key,
				value
			});
		}
		if (num > 0)
		{
			this.RewardList = new List<int[]>();
			foreach (TItem titem in ShopSkinData.Create(this.Goods).GetAllReward())
			{
				this.RewardList.Add(new int[]
				{
					titem.ItemData.ItemId,
					titem.Count
				});
			}
		}
		this.ScrollView.RefreshByData<int[]>(this.RewardList, null);
		this.SetEndTime();
		this.RefreshTitle();
		this.RefreshLeftTimeText();
		this.RefreshTimeItemShowState();
	}

	// Token: 0x060123B8 RID: 74680 RVA: 0x0047DED4 File Offset: 0x0047C0D4
	private ILayoutItem<GiftPackageItem> InitItem(object data, UUIItem uiItem, int index)
	{
		GiftPackageItem giftPackageItem = new GiftPackageItem();
		giftPackageItem.Initialize(uiItem);
		giftPackageItem.SetBelongViewName(EUiViewName.GiftPackageDetailsView);
		if (data != null && ((int[])data).Length >= 2)
		{
			giftPackageItem.UpdateItem(((int[])data)[0], ((int[])data)[1]);
		}
		return new LayoutItem<GiftPackageItem>
		{
			Key = index,
			Value = giftPackageItem
		};
	}

	// Token: 0x060123B9 RID: 74681 RVA: 0x0047DF35 File Offset: 0x0047C135
	private void RefreshTitle()
	{
	}

	// Token: 0x060123BA RID: 74682 RVA: 0x0047DF37 File Offset: 0x0047C137
	private void RefreshTimeItemShowState()
	{
		base.GetItem(6).SetUIActive(this.LeftBuyShowState || this.LeftTimeShowState);
	}

	// Token: 0x060123BB RID: 74683 RVA: 0x0047DF58 File Offset: 0x0047C158
	private void RefreshLeftTimeText()
	{
		base.GetText(2).SetUIActive(false);
		base.GetText(7).SetUIActive(false);
		string exchangeViewShopTipsText = this.Goods.GetExchangeViewShopTipsText();
		UUIText text;
		if (this.LeftTimeShowState)
		{
			text = base.GetText(2);
		}
		else
		{
			text = base.GetText(7);
		}
		text.SetUIActive(exchangeViewShopTipsText != "");
		text.SetText(exchangeViewShopTipsText, true);
		text.SetColor(FColor.FromHex("FED12E"));
		this.LeftBuyShowState = (exchangeViewShopTipsText != "");
	}

	// Token: 0x060123BC RID: 74684 RVA: 0x0047DFE4 File Offset: 0x0047C1E4
	protected void SetEndTime()
	{
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = this.Goods.GetCountDownData();
		if (countDownData.Item3 == 0.0)
		{
			base.GetItem(3).SetUIActive(false);
			this.LeftTimeShowState = false;
			return;
		}
		CommonDefine.IPayShowCountDownRemainTime item = this.Goods.GetCountDownData().Item2;
		if (countDownData.Item1 == EPayCountTimeType.NeverResell)
		{
			base.GetText(4).ShowTextNew("DownShopItem");
			base.GetText(4).SetUIActive(true);
		}
		else if (countDownData.Item1 == EPayCountTimeType.Resell)
		{
			base.GetText(4).ShowTextNew("ReUpShopItem");
			base.GetText(4).SetUIActive(true);
		}
		else if (countDownData.Item1 == EPayCountTimeType.Discount)
		{
			base.GetText(4).ShowTextNew("DiscountItem");
			base.GetText(4).SetUIActive(true);
		}
		else
		{
			base.GetText(4).SetUIActive(false);
		}
		this.LeftTimeShowState = (item != null);
		if (item != null)
		{
			base.GetItem(3).SetUIActive(true);
			UUIText text = base.GetText(5);
			CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = item as CommonDefine.PayShowCountDownRemainTime<string>;
			if (payShowCountDownRemainTime != null)
			{
				text.SetText(payShowCountDownRemainTime.Value, true);
				return;
			}
			CommonDefine.IRemainTime remainTime = item as CommonDefine.IRemainTime;
			if (remainTime != null)
			{
				LguiUtil.Instance.SetLocalText(text, remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue));
				return;
			}
		}
		else
		{
			base.GetItem(3).SetUIActive(false);
		}
	}

	// Token: 0x060123BD RID: 74685 RVA: 0x0047E133 File Offset: 0x0047C333
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x040089BB RID: 35259
	private const string COLOR = "FED12E";

	// Token: 0x040089BC RID: 35260
	private bool LeftBuyShowState;

	// Token: 0x040089BD RID: 35261
	private bool LeftTimeShowState;

	// Token: 0x040089BE RID: 35262
	[Nullable(2)]
	private readonly PayShopGoods Goods;

	// Token: 0x040089BF RID: 35263
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<GiftPackageItem> ScrollView;

	// Token: 0x040089C0 RID: 35264
	private List<int[]> RewardList = new List<int[]>();

	// Token: 0x040089C1 RID: 35265
	private int PackId;

	// Token: 0x02008940 RID: 35136
	[NullableContext(0)]
	private class EGiftPackageSupplyPackItem
	{
		// Token: 0x0402C9E7 RID: 182759
		public const int ScrollView = 0;

		// Token: 0x0402C9E8 RID: 182760
		public const int GiftItem = 1;

		// Token: 0x0402C9E9 RID: 182761
		public const int LeftTimeText = 2;

		// Token: 0x0402C9EA RID: 182762
		public const int EndTimeItem = 3;

		// Token: 0x0402C9EB RID: 182763
		public const int DownItemText = 4;

		// Token: 0x0402C9EC RID: 182764
		public const int EndTimeText = 5;

		// Token: 0x0402C9ED RID: 182765
		public const int TitleItem = 6;

		// Token: 0x0402C9EE RID: 182766
		public const int LeftLimitText = 7;
	}
}
