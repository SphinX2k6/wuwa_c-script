using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001868 RID: 6248
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopGiftItem : GridProxyAbstract<PayShopGoods>
{
	// Token: 0x0600F74E RID: 63310 RVA: 0x00484B30 File Offset: 0x00482D30
	public PayShopGiftItem(EQualityPathType qualityPathType, UUIItem uiItem = null)
	{
		this.QualityPathType = qualityPathType;
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0600F74F RID: 63311 RVA: 0x00484B60 File Offset: 0x00482D60
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.TipsClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F750 RID: 63312 RVA: 0x00484DBC File Offset: 0x00482FBC
	private void ToggleClick(EToggleState toggleState)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.ToggleFunction(this.Data.GetGoodsId());
	}

	// Token: 0x0600F751 RID: 63313 RVA: 0x00484DE5 File Offset: 0x00482FE5
	private void TipsClick()
	{
		HelpController.Instance.OpenHelpById(this.HelpId);
	}

	// Token: 0x0600F752 RID: 63314 RVA: 0x00484DF8 File Offset: 0x00482FF8
	protected override void OnStart()
	{
		base.GetButton(13).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600F753 RID: 63315 RVA: 0x00484E20 File Offset: 0x00483020
	protected void AddEventListener()
	{
		if (this.IsAddEvent)
		{
			return;
		}
		this.IsAddEvent = true;
		EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.RefreshPrice));
	}

	// Token: 0x0600F754 RID: 63316 RVA: 0x00484E4E File Offset: 0x0048304E
	protected void RemoveEventListener()
	{
		if (!this.IsAddEvent)
		{
			return;
		}
		this.IsAddEvent = false;
		EventSystem.Instance.Remove(EEventName.OnPlayerCurrencyChange, new Action<int>(this.RefreshPrice));
	}

	// Token: 0x0600F755 RID: 63317 RVA: 0x00484E7C File Offset: 0x0048307C
	private void RefreshPrice(int itemId)
	{
		PayShopGoodsData goodsData = this.Data.GetGoodsData();
		if (goodsData.IsDirect())
		{
			return;
		}
		if (goodsData.Price.Id != itemId)
		{
			return;
		}
		this.SetPrice();
	}

	// Token: 0x0600F756 RID: 63318 RVA: 0x00484EB3 File Offset: 0x004830B3
	public void SetBelongViewName(EUiViewName viewName)
	{
		this.BelongViewName = new EUiViewName?(viewName);
	}

	// Token: 0x0600F757 RID: 63319 RVA: 0x00484EC1 File Offset: 0x004830C1
	[NullableContext(1)]
	public void Refresh(PayShopGoods data)
	{
		this.AddEventListener();
		this.RefreshGiftItem(data);
	}

	// Token: 0x0600F758 RID: 63320 RVA: 0x00484ED0 File Offset: 0x004830D0
	[NullableContext(1)]
	public void RefreshGiftItem(PayShopGoods data)
	{
		this.Data = data;
		this.RefreshState();
	}

	// Token: 0x0600F759 RID: 63321 RVA: 0x00484EDF File Offset: 0x004830DF
	public override void Clear()
	{
		this.RemoveEventListener();
		this.RemoveSellTimer();
		this.RemoveDiscountTimer();
	}

	// Token: 0x0600F75A RID: 63322 RVA: 0x00484EF3 File Offset: 0x004830F3
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
		this.RemoveSellTimer();
		this.RemoveDiscountTimer();
		LguiResourceManager.Instance.CancelLoadPrefab(this.DebugTextLoadId);
	}

	// Token: 0x0600F75B RID: 63323 RVA: 0x00484F18 File Offset: 0x00483118
	protected void RefreshState()
	{
		CSharpScript.Game.Module.PayShop.IItemData itemData = this.Data.GetItemData();
		this.SetQuality(itemData.Quality);
		this.SetIcon();
		this.SetTips();
		this.SetPrice();
		this.SetDiscountTime();
		this.SetSellTime();
		this.SetName(itemData.Name);
		this.ShowDebugText();
	}

	// Token: 0x0600F75C RID: 63324 RVA: 0x00484F70 File Offset: 0x00483170
	protected void SetQuality(int quality)
	{
		QualityInfo value = ItemConfig.Instance.GetQualityConfig(quality).Value;
		string path = value.PayShopTexture;
		if (this.QualityPathType == EQualityPathType.PathType2)
		{
			path = value.NewPayShopTexture;
		}
		base.SetTextureByPath(path, base.GetTexture(2), null, null);
	}

	// Token: 0x0600F75D RID: 63325 RVA: 0x00484FC4 File Offset: 0x004831C4
	protected void SetIcon()
	{
		UUITexture texture = base.GetTexture(1);
		base.SetItemIcon(texture, this.Data.GetItemData().ItemId, this.BelongViewName, null);
	}

	// Token: 0x0600F75E RID: 63326 RVA: 0x00484FF8 File Offset: 0x004831F8
	protected void SetTips()
	{
		this.RootItem.SetAlpha(1f);
		UUIText text = base.GetText(4);
		if (this.Data.IsLocked())
		{
			string conditionTextId = this.Data.GetConditionTextId();
			LguiUtil.Instance.SetLocalTextNew(text, conditionTextId, Array.Empty<object>());
			text.SetUIActive(true);
			this.RootItem.SetAlpha(0.6f);
			return;
		}
		if (!this.Data.IsLimitGoods())
		{
			text.SetUIActive(false);
			return;
		}
		text.SetUIActive(true);
		if (this.Data.IsSoldOut())
		{
			LguiUtil.Instance.SetLocalText(text, "SoldoutText", Array.Empty<object>());
			this.RootItem.SetAlpha(0.6f);
			return;
		}
		IRemainingData remainingData = this.Data.GetRemainingData();
		LguiUtil.Instance.SetLocalText(text, remainingData.TextId, new <>z__ReadOnlySingleElementList<object>(remainingData.Count));
	}

	// Token: 0x0600F75F RID: 63327 RVA: 0x004850DC File Offset: 0x004832DC
	protected void SetPrice()
	{
		UUIText text = base.GetText(7);
		UUITexture texture = base.GetTexture(5);
		UUIText text2 = base.GetText(6);
		if (this.Data.IsDirect())
		{
			text.SetUIActive(false);
			texture.SetUIActive(false);
			string directPriceText = this.Data.GetDirectPriceText();
			text2.SetText(directPriceText, true);
			return;
		}
		texture.SetUIActive(true);
		IPriceData priceData = this.Data.GetPriceData();
		if (priceData.OriginalPrice == null)
		{
			text.SetUIActive(false);
		}
		else
		{
			text.SetUIActive(true);
			text.SetText("<s>" + priceData.OriginalPrice.ToString() + "</s>", true);
		}
		text2.SetText(priceData.NowPrice.ToString(), true);
		UUIItem uuiitem = text2;
		bool bUseChangeColor = priceData.OwnNumber() < priceData.NowPrice;
		FColor? fcolor = new FColor?(text2.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		base.SetItemIcon(texture, priceData.CurrencyId, null, null);
	}

	// Token: 0x0600F760 RID: 63328 RVA: 0x004851E8 File Offset: 0x004833E8
	protected void SetDiscountTime()
	{
		this.RemoveDiscountTimer();
		UUIItem item = base.GetItem(8);
		UUIText text = base.GetText(10);
		UUIItem item2 = base.GetItem(9);
		if (!this.Data.HasDiscount())
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		bool flag = this.Data.IsPermanentDiscount();
		item2.SetUIActive(!flag);
		text.SetText("-" + this.Data.GetDiscount().ToString() + "%", true);
		if (!flag)
		{
			CommonDefine.IRemainTime discountRemainTime = this.Data.GetDiscountRemainTime();
			this.DiscountTimerId = TimerSystem.RealTimeInstance.Delay(new TTimerAction(this.RefreshDiscountTime), (float)discountRemainTime.RemainingTime * 1000f, null, null, true, 1f);
		}
	}

	// Token: 0x0600F761 RID: 63329 RVA: 0x004852B3 File Offset: 0x004834B3
	private void RefreshDiscountTime(float _)
	{
		this.DiscountTimerId = null;
		this.SetDiscountTime();
		if (!this.Data.HasDiscount())
		{
			this.SetPrice();
			EventSystem.Instance.Emit<int>(EEventName.GoodsRefreshDiscountTime, this.Data.GetGoodsId());
		}
	}

	// Token: 0x0600F762 RID: 63330 RVA: 0x004852F0 File Offset: 0x004834F0
	protected void SetSellTime()
	{
		this.RemoveSellTimer();
		UUIItem item = base.GetItem(12);
		if (this.Data.IsPermanentSell())
		{
			item.SetUIActive(false);
			return;
		}
		if (!this.Data.InSellTime())
		{
			return;
		}
		CommonDefine.IPayShowCountDownRemainTime endTimeRemainData = this.Data.GetEndTimeRemainData();
		UUIText text = base.GetText(11);
		item.SetUIActive(true);
		CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = endTimeRemainData as CommonDefine.PayShowCountDownRemainTime<string>;
		if (payShowCountDownRemainTime != null)
		{
			text.SetText(payShowCountDownRemainTime.Value, true);
			return;
		}
		CommonDefine.IRemainTime remainTime = endTimeRemainData as CommonDefine.IRemainTime;
		if (remainTime != null)
		{
			LguiUtil.Instance.SetLocalText(text, remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue));
			this.SellTimerId = TimerSystem.RealTimeInstance.Delay(delegate(float _)
			{
				this.SellTimerId = null;
				this.SetSellTime();
			}, (float)remainTime.RemainingTime * 1000f, null, null, true, 1f);
		}
	}

	// Token: 0x0600F763 RID: 63331 RVA: 0x004853C4 File Offset: 0x004835C4
	[NullableContext(1)]
	protected void SetName(string name)
	{
		UUIText text = base.GetText(3);
		PayShopGoodsData goodsData = this.Data.GetGoodsData();
		if (goodsData.ItemCount > 1)
		{
			TableTextArgNew tableTextArgNew = new TableTextArgNew(name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(text, "GoodsName", new <>z__ReadOnlyArray<object>(new object[]
			{
				tableTextArgNew,
				goodsData.ItemCount
			}));
			return;
		}
		text.ShowTextNew(name);
	}

	// Token: 0x0600F764 RID: 63332 RVA: 0x00485430 File Offset: 0x00483630
	protected void ShowDebugText()
	{
		if (!GlobalData.IsPlayInEditor)
		{
			return;
		}
		if (this.DebugText == null)
		{
			LguiResourceManager.Instance.CancelLoadPrefab(this.DebugTextLoadId);
			this.DebugTextLoadId = LguiResourceManager.Instance.LoadPrefabByResourceId("UiItem_DebugText_Prefab", this.RootItem, delegate([Nullable(2)] AActor actor, string str, ELguiLoadResultType ELguiLoadResultType)
			{
				this.DebugTextLoadId = LguiResourceManager.Instance.InvalidId;
				this.DebugText = (actor.GetComponentByClass(UUIText.StaticClass()) as UUIText);
				UUIText debugText2 = this.DebugText;
				if (debugText2 == null)
				{
					return;
				}
				debugText2.SetText(this.Data.GetGoodsId().ToString(), true);
			}, "js_undefined");
			return;
		}
		UUIText debugText = this.DebugText;
		if (debugText == null)
		{
			return;
		}
		debugText.SetText(this.Data.GetGoodsId().ToString(), true);
	}

	// Token: 0x0600F765 RID: 63333 RVA: 0x004854AE File Offset: 0x004836AE
	protected void RemoveSellTimer()
	{
		if (this.SellTimerId != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.SellTimerId);
			this.SellTimerId = null;
		}
	}

	// Token: 0x0600F766 RID: 63334 RVA: 0x004854D0 File Offset: 0x004836D0
	protected void RemoveDiscountTimer()
	{
		if (this.DiscountTimerId != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.DiscountTimerId);
			this.DiscountTimerId = null;
		}
	}

	// Token: 0x0600F767 RID: 63335 RVA: 0x004854F2 File Offset: 0x004836F2
	[NullableContext(1)]
	public void SetToggleFunction(Action<int> callBack)
	{
		this.ToggleFunction = callBack;
	}

	// Token: 0x0600F768 RID: 63336 RVA: 0x004854FC File Offset: 0x004836FC
	public void SetTipsIdAndShowTipsButton(int helpId)
	{
		base.GetButton(13).RootUIComp.Get().SetUIActive(true);
		this.HelpId = helpId;
	}

	// Token: 0x04008A86 RID: 35462
	private const float SOLDOUT_ALPHA = 0.6f;

	// Token: 0x04008A87 RID: 35463
	protected PayShopGoods Data;

	// Token: 0x04008A88 RID: 35464
	protected TimerHandle SellTimerId;

	// Token: 0x04008A89 RID: 35465
	protected TimerHandle DiscountTimerId;

	// Token: 0x04008A8A RID: 35466
	protected Action<int> ToggleFunction;

	// Token: 0x04008A8B RID: 35467
	private UUIText DebugText;

	// Token: 0x04008A8C RID: 35468
	private bool IsAddEvent;

	// Token: 0x04008A8D RID: 35469
	private int HelpId;

	// Token: 0x04008A8E RID: 35470
	private readonly EQualityPathType QualityPathType;

	// Token: 0x04008A8F RID: 35471
	private EUiViewName? BelongViewName;

	// Token: 0x04008A90 RID: 35472
	private int DebugTextLoadId = LguiResourceManager.Instance.InvalidId;

	// Token: 0x02007AAE RID: 31406
	[NullableContext(0)]
	private class EPayShopGiftItemDefine
	{
		// Token: 0x04027C51 RID: 162897
		public const int Toggle = 0;

		// Token: 0x04027C52 RID: 162898
		public const int GiftIcon = 1;

		// Token: 0x04027C53 RID: 162899
		public const int GiftQuality = 2;

		// Token: 0x04027C54 RID: 162900
		public const int GiftName = 3;

		// Token: 0x04027C55 RID: 162901
		public const int TipsText = 4;

		// Token: 0x04027C56 RID: 162902
		public const int CurrencyIcon = 5;

		// Token: 0x04027C57 RID: 162903
		public const int CurrencyNowPrice = 6;

		// Token: 0x04027C58 RID: 162904
		public const int CurrencyOriginalPrice = 7;

		// Token: 0x04027C59 RID: 162905
		public const int DiscountTimeItem = 8;

		// Token: 0x04027C5A RID: 162906
		public const int DiscountTimeIconItem = 9;

		// Token: 0x04027C5B RID: 162907
		public const int DiscountTimeText = 10;

		// Token: 0x04027C5C RID: 162908
		public const int SellTimeText = 11;

		// Token: 0x04027C5D RID: 162909
		public const int SellTimeItem = 12;

		// Token: 0x04027C5E RID: 162910
		public const int TipsButton = 13;
	}
}
