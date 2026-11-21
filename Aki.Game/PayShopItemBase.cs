using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200186E RID: 6254
[NullableContext(1)]
[Nullable(0)]
public class PayShopItemBase : UiPanelBase
{
	// Token: 0x0600F799 RID: 63385 RVA: 0x00486AD8 File Offset: 0x00484CD8
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

	// Token: 0x0600F79A RID: 63386 RVA: 0x00486B2E File Offset: 0x00484D2E
	public void Init()
	{
		base.SetRootActor(this.SourceItem.GetOwner(), true);
	}

	// Token: 0x0600F79B RID: 63387 RVA: 0x00486B44 File Offset: 0x00484D44
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

	// Token: 0x0600F79C RID: 63388 RVA: 0x00486D7C File Offset: 0x00484F7C
	private void TipsClick()
	{
		HelpController.Instance.OpenHelpById(9);
	}

	// Token: 0x0600F79D RID: 63389 RVA: 0x00486D8A File Offset: 0x00484F8A
	public void SetDownPriceShowState(bool state)
	{
		base.GetSprite(1).SetUIActive(state);
		base.GetItem(6).SetUIActive(state);
		base.GetText(10).SetUIActive(state);
	}

	// Token: 0x0600F79E RID: 63390 RVA: 0x00486DB4 File Offset: 0x00484FB4
	public void SetDownPriceOnlyShow(bool state)
	{
		base.GetSprite(1).SetUIActive(state);
		base.GetItem(6).SetUIActive(state);
		base.GetText(10).SetUIActive(!state);
	}

	// Token: 0x0600F79F RID: 63391 RVA: 0x00486DE1 File Offset: 0x00484FE1
	public void OnTimerRefresh(PayShopItemBaseSt data, bool isSelected, int gridIndex)
	{
		if (this.Data == null || this.Data.Id != data.Id)
		{
			this.SetNameState = false;
		}
		this.Data = data;
		this.RefreshTimeConnectInfo();
	}

	// Token: 0x0600F7A0 RID: 63392 RVA: 0x00486E14 File Offset: 0x00485014
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

	// Token: 0x0600F7A1 RID: 63393 RVA: 0x00486E7B File Offset: 0x0048507B
	private void RefreshTimeConnectInfo()
	{
		this.OriginalPriceText();
		this.RefreshPrice();
		this.RefreshLeftTimeText();
		this.RefreshDownTextTipsColor();
		this.RefreshRedDot();
	}

	// Token: 0x0600F7A2 RID: 63394 RVA: 0x00486E9B File Offset: 0x0048509B
	protected override void OnBeforeDestroy()
	{
		this.CancelLoad();
	}

	// Token: 0x0600F7A3 RID: 63395 RVA: 0x00486EA4 File Offset: 0x004850A4
	private void RefreshDownTextTipsColor()
	{
		if (this.Data.GetTextTipsColor == null)
		{
			return;
		}
		string hexStr = this.Data.GetTextTipsColor();
		base.GetText(10).SetColor(FColor.FromHex(hexStr));
	}

	// Token: 0x0600F7A4 RID: 63396 RVA: 0x00486EE4 File Offset: 0x004850E4
	private void RefreshTipsButton()
	{
		int monthCardShopId = PayShopConfig.Instance.GetMonthCardShopId();
		base.GetButton(3).RootUIComp.Get().SetUIActive(this.Data.Id == monthCardShopId);
	}

	// Token: 0x0600F7A5 RID: 63397 RVA: 0x00486F24 File Offset: 0x00485124
	private void RefreshQualityTexture()
	{
		string payShopItemQualitySpriteByItemIdAndQuality = PayShopModel.Instance.GetPayShopItemQualitySpriteByItemIdAndQuality(this.Data.ItemId, this.Data.Quality);
		this.SetSpriteByPath(payShopItemQualitySpriteByItemIdAndQuality, base.GetSprite(0), false, null, null);
	}

	// Token: 0x0600F7A6 RID: 63398 RVA: 0x00486F6C File Offset: 0x0048516C
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

	// Token: 0x0600F7A7 RID: 63399 RVA: 0x00487088 File Offset: 0x00485288
	private void CancelLoad()
	{
		if (this.HandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
			this.HandleId = -1;
		}
	}

	// Token: 0x0600F7A8 RID: 63400 RVA: 0x004870AC File Offset: 0x004852AC
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

	// Token: 0x0600F7A9 RID: 63401 RVA: 0x00487131 File Offset: 0x00485331
	private void RefreshShopItemName()
	{
		if (!this.SetNameState)
		{
			base.GetText(5).SetText(this.Data.ItemName, true);
			this.SetNameState = true;
		}
	}

	// Token: 0x0600F7AA RID: 63402 RVA: 0x0048715C File Offset: 0x0048535C
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

	// Token: 0x0600F7AB RID: 63403 RVA: 0x004871C0 File Offset: 0x004853C0
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

	// Token: 0x0600F7AC RID: 63404 RVA: 0x00487248 File Offset: 0x00485448
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

	// Token: 0x0600F7AD RID: 63405 RVA: 0x00487370 File Offset: 0x00485570
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

	// Token: 0x0600F7AE RID: 63406 RVA: 0x00487408 File Offset: 0x00485608
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

	// Token: 0x0600F7AF RID: 63407 RVA: 0x0048746C File Offset: 0x0048566C
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

	// Token: 0x0600F7B0 RID: 63408 RVA: 0x004874CD File Offset: 0x004856CD
	public void SetNameTextShowState(bool state)
	{
		base.GetText(5).SetUIActive(state);
	}

	// Token: 0x0600F7B1 RID: 63409 RVA: 0x004874DC File Offset: 0x004856DC
	public void SetRedDotVisible(bool state)
	{
		base.GetItem(11).SetUIActive(state);
	}

	// Token: 0x0600F7B2 RID: 63410 RVA: 0x004874EC File Offset: 0x004856EC
	public void RefreshRedDot()
	{
		if (this.RefreshRedDotState && this.Data.RedDotExistFunc != null)
		{
			this.SetRedDotVisible(this.Data.RedDotExistFunc());
		}
	}

	// Token: 0x0600F7B3 RID: 63411 RVA: 0x00487519 File Offset: 0x00485719
	private void RefreshNormalItemBg()
	{
		UUIItem item = base.GetItem(13);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!this.Data.IfRechargeItem);
	}

	// Token: 0x04008AC5 RID: 35525
	[Nullable(2)]
	private PayShopItemBaseSt Data;

	// Token: 0x04008AC6 RID: 35526
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x04008AC7 RID: 35527
	private bool SetNameState;

	// Token: 0x04008AC8 RID: 35528
	private int HandleId;

	// Token: 0x04008AC9 RID: 35529
	[Nullable(2)]
	private IPriceData CachePriceData;

	// Token: 0x04008ACA RID: 35530
	private string CurrentPriceColor;

	// Token: 0x04008ACB RID: 35531
	private bool LeftTimeTextShowState;

	// Token: 0x04008ACC RID: 35532
	private bool LeftTimeTextShowOnceBuy;

	// Token: 0x04008ACD RID: 35533
	public bool RefreshRedDotState;

	// Token: 0x02007AB5 RID: 31413
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027C81 RID: 162945
		public const int QualitySprite = 0;

		// Token: 0x04027C82 RID: 162946
		public const int DownBgSprite = 1;

		// Token: 0x04027C83 RID: 162947
		public const int Texture = 2;

		// Token: 0x04027C84 RID: 162948
		public const int TipsButton = 3;

		// Token: 0x04027C85 RID: 162949
		public const int LeftTimeText = 4;

		// Token: 0x04027C86 RID: 162950
		public const int NameText = 5;

		// Token: 0x04027C87 RID: 162951
		public const int PriceItem = 6;

		// Token: 0x04027C88 RID: 162952
		public const int PriceIcon = 7;

		// Token: 0x04027C89 RID: 162953
		public const int PriceText = 8;

		// Token: 0x04027C8A RID: 162954
		public const int SourcePriceText = 9;

		// Token: 0x04027C8B RID: 162955
		public const int PriceTipsText = 10;

		// Token: 0x04027C8C RID: 162956
		public const int RedDot = 11;

		// Token: 0x04027C8D RID: 162957
		public const int RechargeTexture = 12;

		// Token: 0x04027C8E RID: 162958
		public const int NormalItemBg = 13;
	}
}
