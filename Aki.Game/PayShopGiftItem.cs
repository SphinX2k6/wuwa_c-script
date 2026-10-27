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

// Token: 0x02002383 RID: 9091
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopGiftItem : GridProxyAbstract<PayShopGoods>
{
	// Token: 0x0601229E RID: 74398 RVA: 0x004779B0 File Offset: 0x00475BB0
	public PayShopGiftItem(EQualityPathType qualityPathType, UUIItem uiItem = null)
	{
		this.QualityPathType = qualityPathType;
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0601229F RID: 74399 RVA: 0x004779E0 File Offset: 0x00475BE0
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

	// Token: 0x060122A0 RID: 74400 RVA: 0x00477C3C File Offset: 0x00475E3C
	private void ToggleClick(EToggleState toggleState)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		this.ToggleFunction(this.Data.GetGoodsId());
	}

	// Token: 0x060122A1 RID: 74401 RVA: 0x00477C65 File Offset: 0x00475E65
	private void TipsClick()
	{
		HelpController.Instance.OpenHelpById(this.HelpId);
	}

	// Token: 0x060122A2 RID: 74402 RVA: 0x00477C78 File Offset: 0x00475E78
	protected override void OnStart()
	{
		base.GetButton(13).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x060122A3 RID: 74403 RVA: 0x00477CA0 File Offset: 0x00475EA0
	protected void AddEventListener()
	{
		if (this.IsAddEvent)
		{
			return;
		}
		this.IsAddEvent = true;
		EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.RefreshPrice));
	}

	// Token: 0x060122A4 RID: 74404 RVA: 0x00477CCE File Offset: 0x00475ECE
	protected void RemoveEventListener()
	{
		if (!this.IsAddEvent)
		{
			return;
		}
		this.IsAddEvent = false;
		EventSystem.Instance.Remove(EEventName.OnPlayerCurrencyChange, new Action<int>(this.RefreshPrice));
	}

	// Token: 0x060122A5 RID: 74405 RVA: 0x00477CFC File Offset: 0x00475EFC
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

	// Token: 0x060122A6 RID: 74406 RVA: 0x00477D33 File Offset: 0x00475F33
	public void SetBelongViewName(EUiViewName viewName)
	{
		this.BelongViewName = new EUiViewName?(viewName);
	}

	// Token: 0x060122A7 RID: 74407 RVA: 0x00477D41 File Offset: 0x00475F41
	[NullableContext(1)]
	public void Refresh(PayShopGoods data)
	{
		this.AddEventListener();
		this.RefreshGiftItem(data);
	}

	// Token: 0x060122A8 RID: 74408 RVA: 0x00477D50 File Offset: 0x00475F50
	[NullableContext(1)]
	public void RefreshGiftItem(PayShopGoods data)
	{
		this.Data = data;
		this.RefreshState();
	}

	// Token: 0x060122A9 RID: 74409 RVA: 0x00477D5F File Offset: 0x00475F5F
	public override void Clear()
	{
		this.RemoveEventListener();
		this.RemoveSellTimer();
		this.RemoveDiscountTimer();
	}

	// Token: 0x060122AA RID: 74410 RVA: 0x00477D73 File Offset: 0x00475F73
	protected override void OnBeforeDestroy()
	{
		this.RemoveEventListener();
		this.RemoveSellTimer();
		this.RemoveDiscountTimer();
		LguiResourceManager.Instance.CancelLoadPrefab(this.DebugTextLoadId);
	}

	// Token: 0x060122AB RID: 74411 RVA: 0x00477D98 File Offset: 0x00475F98
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

	// Token: 0x060122AC RID: 74412 RVA: 0x00477DF0 File Offset: 0x00475FF0
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

	// Token: 0x060122AD RID: 74413 RVA: 0x00477E44 File Offset: 0x00476044
	protected void SetIcon()
	{
		UUITexture texture = base.GetTexture(1);
		base.SetItemIcon(texture, this.Data.GetItemData().ItemId, this.BelongViewName, null);
	}

	// Token: 0x060122AE RID: 74414 RVA: 0x00477E78 File Offset: 0x00476078
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

	// Token: 0x060122AF RID: 74415 RVA: 0x00477F5C File Offset: 0x0047615C
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

	// Token: 0x060122B0 RID: 74416 RVA: 0x00478068 File Offset: 0x00476268
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

	// Token: 0x060122B1 RID: 74417 RVA: 0x00478133 File Offset: 0x00476333
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

	// Token: 0x060122B2 RID: 74418 RVA: 0x00478170 File Offset: 0x00476370
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

	// Token: 0x060122B3 RID: 74419 RVA: 0x00478244 File Offset: 0x00476444
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

	// Token: 0x060122B4 RID: 74420 RVA: 0x004782B0 File Offset: 0x004764B0
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

	// Token: 0x060122B5 RID: 74421 RVA: 0x0047832E File Offset: 0x0047652E
	protected void RemoveSellTimer()
	{
		if (this.SellTimerId != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.SellTimerId);
			this.SellTimerId = null;
		}
	}

	// Token: 0x060122B6 RID: 74422 RVA: 0x00478350 File Offset: 0x00476550
	protected void RemoveDiscountTimer()
	{
		if (this.DiscountTimerId != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.DiscountTimerId);
			this.DiscountTimerId = null;
		}
	}

	// Token: 0x060122B7 RID: 74423 RVA: 0x00478372 File Offset: 0x00476572
	[NullableContext(1)]
	public void SetToggleFunction(Action<int> callBack)
	{
		this.ToggleFunction = callBack;
	}

	// Token: 0x060122B8 RID: 74424 RVA: 0x0047837C File Offset: 0x0047657C
	public void SetTipsIdAndShowTipsButton(int helpId)
	{
		base.GetButton(13).RootUIComp.Get().SetUIActive(true);
		this.HelpId = helpId;
	}

	// Token: 0x04008941 RID: 35137
	private const float SOLDOUT_ALPHA = 0.6f;

	// Token: 0x04008942 RID: 35138
	protected PayShopGoods Data;

	// Token: 0x04008943 RID: 35139
	protected TimerHandle SellTimerId;

	// Token: 0x04008944 RID: 35140
	protected TimerHandle DiscountTimerId;

	// Token: 0x04008945 RID: 35141
	protected Action<int> ToggleFunction;

	// Token: 0x04008946 RID: 35142
	private UUIText DebugText;

	// Token: 0x04008947 RID: 35143
	private bool IsAddEvent;

	// Token: 0x04008948 RID: 35144
	private int HelpId;

	// Token: 0x04008949 RID: 35145
	private readonly EQualityPathType QualityPathType;

	// Token: 0x0400894A RID: 35146
	private EUiViewName? BelongViewName;

	// Token: 0x0400894B RID: 35147
	private int DebugTextLoadId = LguiResourceManager.Instance.InvalidId;

	// Token: 0x02008924 RID: 35108
	[NullableContext(0)]
	private class EPayShopGiftItemDefine
	{
		// Token: 0x0402C939 RID: 182585
		public const int Toggle = 0;

		// Token: 0x0402C93A RID: 182586
		public const int GiftIcon = 1;

		// Token: 0x0402C93B RID: 182587
		public const int GiftQuality = 2;

		// Token: 0x0402C93C RID: 182588
		public const int GiftName = 3;

		// Token: 0x0402C93D RID: 182589
		public const int TipsText = 4;

		// Token: 0x0402C93E RID: 182590
		public const int CurrencyIcon = 5;

		// Token: 0x0402C93F RID: 182591
		public const int CurrencyNowPrice = 6;

		// Token: 0x0402C940 RID: 182592
		public const int CurrencyOriginalPrice = 7;

		// Token: 0x0402C941 RID: 182593
		public const int DiscountTimeItem = 8;

		// Token: 0x0402C942 RID: 182594
		public const int DiscountTimeIconItem = 9;

		// Token: 0x0402C943 RID: 182595
		public const int DiscountTimeText = 10;

		// Token: 0x0402C944 RID: 182596
		public const int SellTimeText = 11;

		// Token: 0x0402C945 RID: 182597
		public const int SellTimeItem = 12;

		// Token: 0x0402C946 RID: 182598
		public const int TipsButton = 13;
	}
}
