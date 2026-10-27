using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002389 RID: 9097
[NullableContext(1)]
[Nullable(0)]
public class PayShopItemBase : UiPanelBase
{
	// Token: 0x060122E7 RID: 74471 RVA: 0x00479788 File Offset: 0x00477988
	public PayShopItemBase(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
		this.Data = null;
		this.SetNameState = false;
		this.HandleId = -1;
		this.CachePriceData = null;
		this.CurrentPriceColor = "";
		this.LeftTimeTextShowOnceBuy = false;
		this.LeftTimeTextShowState = true;
		this.RefreshRedDotState = true;
	}

	// Token: 0x060122E8 RID: 74472 RVA: 0x004797DE File Offset: 0x004779DE
	public void Init()
	{
		base.SetRootActor(this.SourceItem.GetOwner(), true);
	}

	// Token: 0x060122E9 RID: 74473 RVA: 0x004797F4 File Offset: 0x004779F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.TipsClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060122EA RID: 74474 RVA: 0x00479A2C File Offset: 0x00477C2C
	private void TipsClick()
	{
		HelpController.Instance.OpenHelpById(9);
	}

	// Token: 0x060122EB RID: 74475 RVA: 0x00479A3A File Offset: 0x00477C3A
	public void SetDownPriceShowState(bool state)
	{
		base.GetSprite(1).SetUIActive(state);
		base.GetItem(6).SetUIActive(state);
		base.GetText(10).SetUIActive(state);
	}

	// Token: 0x060122EC RID: 74476 RVA: 0x00479A64 File Offset: 0x00477C64
	public void SetDownPriceOnlyShow(bool state)
	{
		base.GetSprite(1).SetUIActive(state);
		base.GetItem(6).SetUIActive(state);
		base.GetText(10).SetUIActive(!state);
	}

	// Token: 0x060122ED RID: 74477 RVA: 0x00479A91 File Offset: 0x00477C91
	public void OnTimerRefresh(PayShopItemBaseSt data, bool isSelected, int gridIndex)
	{
		if (this.Data == null || this.Data.Id != data.Id)
		{
			this.SetNameState = false;
		}
		this.Data = data;
		this.RefreshTimeConnectInfo();
	}

	// Token: 0x060122EE RID: 74478 RVA: 0x00479AC4 File Offset: 0x00477CC4
	public void Refresh(PayShopItemBaseSt data, bool isSelected, int gridIndex)
	{
		if (this.Data == null || this.Data.Id != data.Id)
		{
			this.SetNameState = false;
		}
		this.Data = data;
		this.LeftTimeTextShowState = true;
		this.RefreshQualityTexture();
		this.RefreshTexture();
		this.RefreshShopItemName();
		this.RefreshPriceIcon();
		this.RefreshTipsButton();
		this.RefreshNormalItemBg();
		this.RefreshTimeConnectInfo();
	}

	// Token: 0x060122EF RID: 74479 RVA: 0x00479B2B File Offset: 0x00477D2B
	private void RefreshTimeConnectInfo()
	{
		this.OriginalPriceText();
		this.RefreshPrice();
		this.RefreshLeftTimeText();
		this.RefreshDownTextTipsColor();
		this.RefreshRedDot();
	}

	// Token: 0x060122F0 RID: 74480 RVA: 0x00479B4B File Offset: 0x00477D4B
	protected override void OnBeforeDestroy()
	{
		this.CancelLoad();
	}

	// Token: 0x060122F1 RID: 74481 RVA: 0x00479B54 File Offset: 0x00477D54
	private void RefreshDownTextTipsColor()
	{
		if (this.Data.GetTextTipsColor == null)
		{
			return;
		}
		string hexStr = this.Data.GetTextTipsColor();
		base.GetText(10).SetColor(FColor.FromHex(hexStr));
	}

	// Token: 0x060122F2 RID: 74482 RVA: 0x00479B94 File Offset: 0x00477D94
	private void RefreshTipsButton()
	{
		int monthCardShopId = PayShopConfig.Instance.GetMonthCardShopId();
		base.GetButton(3).RootUIComp.Get().SetUIActive(this.Data.Id == monthCardShopId);
	}

	// Token: 0x060122F3 RID: 74483 RVA: 0x00479BD4 File Offset: 0x00477DD4
	private void RefreshQualityTexture()
	{
		string payShopItemQualitySpriteByItemIdAndQuality = PayShopModel.Instance.GetPayShopItemQualitySpriteByItemIdAndQuality(this.Data.ItemId, this.Data.Quality);
		this.SetSpriteByPath(payShopItemQualitySpriteByItemIdAndQuality, base.GetSprite(0), false, null, null);
	}

	// Token: 0x060122F4 RID: 74484 RVA: 0x00479C1C File Offset: 0x00477E1C
	private void RefreshTexture()
	{
		UUITexture texture = base.GetTexture(2);
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.Data.ItemId));
		if (this.Data.IfRechargeItem)
		{
			texture.SetUIActive(false);
			texture = base.GetTexture(12);
			texture.SetUIActive(true);
			string stageImage = this.Data.StageImage;
			base.SetTextureByPath(stageImage, texture, null, null);
			return;
		}
		if (this.Data.ShowStageImage != "")
		{
			string showStageImage = this.Data.ShowStageImage;
			base.SetTextureByPath(showStageImage, texture, null, null);
			return;
		}
		if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem)
		{
			base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(this.Data.ItemId).Value.Card, texture, this.Data.ItemId, null, null);
		}
		else
		{
			base.SetItemIcon(texture, this.Data.ItemId, null, null);
		}
		this.CancelLoad();
		this.StartLoad();
	}

	// Token: 0x060122F5 RID: 74485 RVA: 0x00479D38 File Offset: 0x00477F38
	private void CancelLoad()
	{
		if (this.HandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
			this.HandleId = -1;
		}
	}

	// Token: 0x060122F6 RID: 74486 RVA: 0x00479D5C File Offset: 0x00477F5C
	private void StartLoad()
	{
		int itemDataTypeByConfigId = (int)InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.Data.ItemId));
		UUITexture giftIcon = base.GetTexture(2);
		if (itemDataTypeByConfigId == 3)
		{
			UiResourceConfig instance = UiResourceConfig.Instance;
			string path = (instance != null) ? instance.GetResourcePath("MI_HeadYuan") : null;
			this.HandleId = ResourceSystem.Instance.LoadAsync<UMaterialInterface>(path, delegate([Nullable(2)] UMaterialInterface materialInterface, string _)
			{
				giftIcon.SetCustomUIMaterial(materialInterface);
			}, 102, "js_undefined");
			return;
		}
		giftIcon.SetCustomUIMaterial(null);
	}

	// Token: 0x060122F7 RID: 74487 RVA: 0x00479DE1 File Offset: 0x00477FE1
	private void RefreshShopItemName()
	{
		if (!this.SetNameState)
		{
			base.GetText(5).SetText(this.Data.ItemName, true);
			this.SetNameState = true;
		}
	}

	// Token: 0x060122F8 RID: 74488 RVA: 0x00479E0C File Offset: 0x0047800C
	private void RefreshPriceIcon()
	{
		UUITexture texture = base.GetTexture(7);
		if (this.Data.IsDirect)
		{
			texture.SetUIActive(false);
			return;
		}
		IPriceData priceData = this.Data.PriceData;
		if (priceData.NowPrice == 0)
		{
			texture.SetUIActive(false);
			return;
		}
		texture.SetUIActive(true);
		base.SetItemIcon(texture, priceData.CurrencyId, null, null);
	}

	// Token: 0x060122F9 RID: 74489 RVA: 0x00479E70 File Offset: 0x00478070
	private void OriginalPriceText()
	{
		UUIText text = base.GetText(9);
		if (this.Data.IsDirect)
		{
			text.SetUIActive(false);
			return;
		}
		IPriceData priceData = this.Data.PriceData;
		if (priceData.OriginalPrice == null || !priceData.InDiscountTime)
		{
			text.SetUIActive(false);
			return;
		}
		text.SetUIActive(true);
		text.SetText("<s>" + priceData.OriginalPrice.ToString() + "</s>", true);
	}

	// Token: 0x060122FA RID: 74490 RVA: 0x00479EF8 File Offset: 0x004780F8
	private void RefreshPrice()
	{
		string text = "F9FFFFFF";
		if (!this.Data.IsDirect && this.Data.PriceData.OwnNumber() < this.Data.PriceData.NowPrice)
		{
			text = "F55E66FF";
		}
		if (this.CachePriceData != null && this.CachePriceData == this.Data.PriceData && this.CurrentPriceColor == text)
		{
			return;
		}
		this.CurrentPriceColor = text;
		PayShopItemBaseSt data = this.Data;
		this.CachePriceData = ((data != null) ? data.PriceData : null);
		UUIText text2 = base.GetText(8);
		if (this.Data.IsDirect)
		{
			Func<string> getDirectPriceTextFunc = this.Data.GetDirectPriceTextFunc;
			string text3 = (getDirectPriceTextFunc != null) ? getDirectPriceTextFunc() : null;
			if (text3 != null)
			{
				string newText = text3;
				text2.SetText(newText, true);
				text2.SetColor(FColor.FromHex(text));
			}
			return;
		}
		IPriceData priceData = this.Data.PriceData;
		if (priceData.NowPrice == 0)
		{
			text2.ShowTextNew("ShopDiscountLabel_4");
		}
		else
		{
			text2.SetText(priceData.NowPrice.ToString(), true);
		}
		string hexStr = text;
		text2.SetColor(FColor.FromHex(hexStr));
	}

	// Token: 0x060122FB RID: 74491 RVA: 0x0047A020 File Offset: 0x00478220
	private void RefreshLeftTimeText()
	{
		Func<string> getShopTipsText = this.Data.GetShopTipsText;
		string text = (getShopTipsText != null) ? getShopTipsText() : null;
		UUIText text2 = base.GetText(4);
		if (this.LeftTimeTextShowOnceBuy && this.Data.OnceBuyLimitCount > 0)
		{
			text2.SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(text2, "SingleBuyLimit", new <>z__ReadOnlySingleElementList<object>(this.Data.OnceBuyLimitCount));
			return;
		}
		if (this.LeftTimeTextShowState && !StringUtils.IsEmpty(text))
		{
			text2.SetUIActive(true);
			text2.SetText(text, true);
			return;
		}
		text2.SetUIActive(false);
	}

	// Token: 0x060122FC RID: 74492 RVA: 0x0047A0B8 File Offset: 0x004782B8
	public void SetLeftTimeTextShowOnceBuy(bool state)
	{
		this.LeftTimeTextShowOnceBuy = state;
		if (this.Data != null)
		{
			int onceBuyLimitCount = this.Data.OnceBuyLimitCount;
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetUIActive(this.LeftTimeTextShowOnceBuy && onceBuyLimitCount > 0);
			}
			LguiUtil.Instance.SetLocalTextNew(text, "SingleBuyLimit", new <>z__ReadOnlySingleElementList<object>(onceBuyLimitCount));
		}
	}

	// Token: 0x060122FD RID: 74493 RVA: 0x0047A11C File Offset: 0x0047831C
	public void SetLeftTimeTextShowState(bool state)
	{
		this.LeftTimeTextShowState = state;
		if (this.Data != null && !this.LeftTimeTextShowOnceBuy)
		{
			Func<string> getShopTipsText = this.Data.GetShopTipsText;
			string content = (getShopTipsText != null) ? getShopTipsText() : null;
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(this.LeftTimeTextShowState && !StringUtils.IsEmpty(content));
		}
	}

	// Token: 0x060122FE RID: 74494 RVA: 0x0047A17D File Offset: 0x0047837D
	public void SetNameTextShowState(bool state)
	{
		base.GetText(5).SetUIActive(state);
	}

	// Token: 0x060122FF RID: 74495 RVA: 0x0047A18C File Offset: 0x0047838C
	public void SetRedDotVisible(bool state)
	{
		base.GetItem(11).SetUIActive(state);
	}

	// Token: 0x06012300 RID: 74496 RVA: 0x0047A19C File Offset: 0x0047839C
	public void RefreshRedDot()
	{
		if (this.RefreshRedDotState && this.Data.RedDotExistFunc != null)
		{
			this.SetRedDotVisible(this.Data.RedDotExistFunc());
		}
	}

	// Token: 0x06012301 RID: 74497 RVA: 0x0047A1C9 File Offset: 0x004783C9
	private void RefreshNormalItemBg()
	{
		UUIItem item = base.GetItem(13);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!this.Data.IfRechargeItem);
	}

	// Token: 0x0400897E RID: 35198
	[Nullable(2)]
	private PayShopItemBaseSt Data;

	// Token: 0x0400897F RID: 35199
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x04008980 RID: 35200
	private bool SetNameState;

	// Token: 0x04008981 RID: 35201
	private int HandleId;

	// Token: 0x04008982 RID: 35202
	[Nullable(2)]
	private IPriceData CachePriceData;

	// Token: 0x04008983 RID: 35203
	private string CurrentPriceColor;

	// Token: 0x04008984 RID: 35204
	private bool LeftTimeTextShowState;

	// Token: 0x04008985 RID: 35205
	private bool LeftTimeTextShowOnceBuy;

	// Token: 0x04008986 RID: 35206
	public bool RefreshRedDotState;

	// Token: 0x0200892A RID: 35114
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402C963 RID: 182627
		public const int QualitySprite = 0;

		// Token: 0x0402C964 RID: 182628
		public const int DownBgSprite = 1;

		// Token: 0x0402C965 RID: 182629
		public const int Texture = 2;

		// Token: 0x0402C966 RID: 182630
		public const int TipsButton = 3;

		// Token: 0x0402C967 RID: 182631
		public const int LeftTimeText = 4;

		// Token: 0x0402C968 RID: 182632
		public const int NameText = 5;

		// Token: 0x0402C969 RID: 182633
		public const int PriceItem = 6;

		// Token: 0x0402C96A RID: 182634
		public const int PriceIcon = 7;

		// Token: 0x0402C96B RID: 182635
		public const int PriceText = 8;

		// Token: 0x0402C96C RID: 182636
		public const int SourcePriceText = 9;

		// Token: 0x0402C96D RID: 182637
		public const int PriceTipsText = 10;

		// Token: 0x0402C96E RID: 182638
		public const int RedDot = 11;

		// Token: 0x0402C96F RID: 182639
		public const int RechargeTexture = 12;

		// Token: 0x0402C970 RID: 182640
		public const int NormalItemBg = 13;
	}
}
