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

// Token: 0x02001881 RID: 6273
[NullableContext(1)]
[Nullable(0)]
public class GiftPackageSupplyPackItem : UiPanelBase
{
	// Token: 0x0600F866 RID: 63590 RVA: 0x0048B030 File Offset: 0x00489230
	public GiftPackageSupplyPackItem(int packId, UUIItem uiItem, PayShopGoods goods)
	{
		this.PackId = packId;
		this.Goods = goods;
		base.CreateThenShowByResourceIdAsync("UiItem_GiftPackageSupplyPack", uiItem, false).Forget();
	}

	// Token: 0x0600F867 RID: 63591 RVA: 0x0048B064 File Offset: 0x00489264
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

	// Token: 0x0600F868 RID: 63592 RVA: 0x0048B193 File Offset: 0x00489393
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollView<GiftPackageItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<GiftPackageItem>(this.InitItem), null);
		this.Refresh();
	}

	// Token: 0x0600F869 RID: 63593 RVA: 0x0048B1BC File Offset: 0x004893BC
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

	// Token: 0x0600F86A RID: 63594 RVA: 0x0048B314 File Offset: 0x00489514
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

	// Token: 0x0600F86B RID: 63595 RVA: 0x0048B375 File Offset: 0x00489575
	private void RefreshTitle()
	{
	}

	// Token: 0x0600F86C RID: 63596 RVA: 0x0048B377 File Offset: 0x00489577
	private void RefreshTimeItemShowState()
	{
		base.GetItem(6).SetUIActive(this.LeftBuyShowState || this.LeftTimeShowState);
	}

	// Token: 0x0600F86D RID: 63597 RVA: 0x0048B398 File Offset: 0x00489598
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

	// Token: 0x0600F86E RID: 63598 RVA: 0x0048B424 File Offset: 0x00489624
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

	// Token: 0x0600F86F RID: 63599 RVA: 0x0048B573 File Offset: 0x00489773
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x04008B02 RID: 35586
	private const string COLOR = "FED12E";

	// Token: 0x04008B03 RID: 35587
	private bool LeftBuyShowState;

	// Token: 0x04008B04 RID: 35588
	private bool LeftTimeShowState;

	// Token: 0x04008B05 RID: 35589
	[Nullable(2)]
	private readonly PayShopGoods Goods;

	// Token: 0x04008B06 RID: 35590
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<GiftPackageItem> ScrollView;

	// Token: 0x04008B07 RID: 35591
	private List<int[]> RewardList = new List<int[]>();

	// Token: 0x04008B08 RID: 35592
	private int PackId;

	// Token: 0x02007ACB RID: 31435
	[NullableContext(0)]
	private class EGiftPackageSupplyPackItem
	{
		// Token: 0x04027D04 RID: 163076
		public const int ScrollView = 0;

		// Token: 0x04027D05 RID: 163077
		public const int GiftItem = 1;

		// Token: 0x04027D06 RID: 163078
		public const int LeftTimeText = 2;

		// Token: 0x04027D07 RID: 163079
		public const int EndTimeItem = 3;

		// Token: 0x04027D08 RID: 163080
		public const int DownItemText = 4;

		// Token: 0x04027D09 RID: 163081
		public const int EndTimeText = 5;

		// Token: 0x04027D0A RID: 163082
		public const int TitleItem = 6;

		// Token: 0x04027D0B RID: 163083
		public const int LeftLimitText = 7;
	}
}
