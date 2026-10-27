using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200237E RID: 9086
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopBigItem : GridProxyAbstract<IPayShopUnionData>
{
	// Token: 0x0601226F RID: 74351 RVA: 0x004761E4 File Offset: 0x004743E4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 26;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickExplainBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06012270 RID: 74352 RVA: 0x004765D7 File Offset: 0x004747D7
	protected override void OnStart()
	{
		base.GetButton(0).SetCanClickWhenDisable(true);
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		base.GetTexture(14).SetUIActive(false);
	}

	// Token: 0x06012271 RID: 74353 RVA: 0x00476608 File Offset: 0x00474808
	public void SetOnClickRechargeCallback(Action<PayItemData> callback)
	{
		this.OnClickRechargeCallback = callback;
	}

	// Token: 0x06012272 RID: 74354 RVA: 0x00476611 File Offset: 0x00474811
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06012273 RID: 74355 RVA: 0x0047664C File Offset: 0x0047484C
	[NullableContext(2)]
	public override void Refresh(IPayShopUnionData data, bool isSelected, int gridIndex)
	{
		if (data == null)
		{
			return;
		}
		this.Data = data;
		PayShopGoods payShopGoods = data as PayShopGoods;
		if (payShopGoods != null)
		{
			this.DataSt = payShopGoods.ConvertToPayShopBaseSt();
			ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = payShopGoods.GetCountDownData();
			this.CurrentCountDownState = (countDownData.Item3 != 0.0);
			this.CountDownType = countDownData.Item1;
			this.CurrentDiscountItemState = payShopGoods.HasDiscount();
			this.CurrentDiscountValue = payShopGoods.GetDiscountNew();
		}
		else
		{
			PayItemData payItemData = data as PayItemData;
			if (payItemData != null)
			{
				this.DataSt = PayItemModel.Instance.ConvertPayItemDataToPayShopItemBaseSt(payItemData);
			}
		}
		base.GetText(3).SetText(this.DataSt.ItemName, true);
		UUITexture texture = base.GetTexture(2);
		if (this.DataSt.StageImage != "")
		{
			string stageImage = this.DataSt.StageImage;
			base.SetTextureByPath(stageImage, texture, null, null);
		}
		else
		{
			base.SetItemIcon(texture, this.DataSt.ItemId, null, null);
		}
		this.RefreshQualityTexture(this.DataSt.Quality, this.DataSt.QualityType);
		this.RefreshEffect(this.DataSt.Quality, this.DataSt.QualityType);
		int monthCardShopId = PayShopConfig.Instance.GetMonthCardShopId();
		base.GetButton(7).RootUIComp.Get().SetUIActive(this.DataSt.Id == monthCardShopId);
		UUITexture texture2 = base.GetTexture(13);
		IPriceData priceData = this.DataSt.PriceData;
		if (this.DataSt.IsDirect || priceData.NowPrice == 0)
		{
			texture2.SetUIActive(false);
		}
		else
		{
			texture2.SetUIActive(true);
			base.SetItemIcon(texture2, priceData.CurrencyId, null, null);
		}
		this.RefreshOriginalPriceText();
		this.RefreshPrice();
		this.RefreshGachaDescItem();
		this.RefreshLeftTimesText();
		this.RefreshRedDot();
		this.RefreshCommonItem();
		this.RefreshRechargeItem();
	}

	// Token: 0x06012274 RID: 74356 RVA: 0x00476844 File Offset: 0x00474A44
	private void RefreshQualityTexture(int quality, EItemQualityType qualityType)
	{
		QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(quality);
		string path;
		string path2;
		string hexStr;
		if (qualityType == EItemQualityType.Item)
		{
			path = qualityConfig.Value.PayShopQualityTexture;
			path2 = qualityConfig.Value.PayShopQualityLightTexture;
			hexStr = qualityConfig.Value.PayShopLineColor;
		}
		else
		{
			path = qualityConfig.Value.PayShopItemQualityTexture;
			path2 = qualityConfig.Value.PayShopItemQualityLightTexture;
			hexStr = qualityConfig.Value.PayShopItemLineColor;
		}
		base.SetTextureByPath(path, base.GetTexture(1), null, null);
		base.SetTextureByPath(path2, base.GetTexture(19), null, null);
		base.GetTexture(18).SetColor(FColor.FromHex(hexStr));
	}

	// Token: 0x06012275 RID: 74357 RVA: 0x00476920 File Offset: 0x00474B20
	public void RefreshCommonItem()
	{
		if (this.Data == null || this.Data is PayItemData)
		{
			return;
		}
		this.RefreshCommonItemTag((PayShopGoods)this.Data);
		this.RefreshShopItemState((PayShopGoods)this.Data);
		this.RefreshDiscount((PayShopGoods)this.Data);
		this.RefreshCountDown((PayShopGoods)this.Data);
		this.RefreshTotalScoreTagForGoods((PayShopGoods)this.Data);
	}

	// Token: 0x06012276 RID: 74358 RVA: 0x00476998 File Offset: 0x00474B98
	public void RefreshRechargeItem()
	{
		if (this.Data == null || this.Data is PayShopGoods)
		{
			return;
		}
		this.RefreshRechargeItemTag((PayItemData)this.Data);
		this.RefreshTotalScoreTagForItem((PayItemData)this.Data);
	}

	// Token: 0x06012277 RID: 74359 RVA: 0x004769D4 File Offset: 0x00474BD4
	private void RefreshDiscount(PayShopGoods data)
	{
		PayShopBigItem.<>c__DisplayClass26_0 CS$<>8__locals1 = new PayShopBigItem.<>c__DisplayClass26_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.data = data;
		if (this.CurrentTagType != 0)
		{
			PayShopTagItem payShopTagItem;
			if (this.TagItemMap.TryGetValue(PayShopDefine.EPayShopTagType.Discount, out payShopTagItem) && payShopTagItem != null)
			{
				payShopTagItem.SetUiActive(false);
			}
			return;
		}
		bool isVisible = CS$<>8__locals1.data.HasDiscount();
		this.SetTagVisible(PayShopDefine.EPayShopTagType.Discount, isVisible, new Action(CS$<>8__locals1.<RefreshDiscount>g__callback|0), true);
	}

	// Token: 0x06012278 RID: 74360 RVA: 0x00476A3B File Offset: 0x00474C3B
	private void RefreshTotalScoreTagForGoods(PayShopGoods data)
	{
		this.SetTagVisible(PayShopDefine.EPayShopTagType.TotalTopUp, data.GetIfShowTotalTopUpScore(), new Action(PayShopBigItem.<RefreshTotalScoreTagForGoods>g__callback|27_0), true);
	}

	// Token: 0x06012279 RID: 74361 RVA: 0x00476A58 File Offset: 0x00474C58
	private void RefreshTotalScoreTagForItem(PayItemData data)
	{
		this.SetTagVisible(PayShopDefine.EPayShopTagType.TotalTopUp, data.GetIfShowTotalTopUpScore(), new Action(PayShopBigItem.<RefreshTotalScoreTagForItem>g__callback|28_0), true);
	}

	// Token: 0x0601227A RID: 74362 RVA: 0x00476A78 File Offset: 0x00474C78
	private void RefreshCountDown(PayShopGoods data)
	{
		ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> countDownData = data.GetCountDownData();
		this.CountDownType = countDownData.Item1;
		CommonDefine.IPayShowCountDownRemainTime item = countDownData.Item2;
		if (countDownData.Item3 == 0.0)
		{
			base.GetItem(9).SetUIActive(false);
			base.GetTexture(14).SetUIActive(false);
			return;
		}
		this.SetCountDownText(item);
	}

	// Token: 0x0601227B RID: 74363 RVA: 0x00476AD4 File Offset: 0x00474CD4
	private void SetCountDownText(CommonDefine.IPayShowCountDownRemainTime countDownTime)
	{
		base.GetItem(9).SetUIActive(true);
		base.GetTexture(14).SetUIActive(true);
		UUIText text = base.GetText(10);
		CommonDefine.PayShowCountDownRemainTime<string> payShowCountDownRemainTime = countDownTime as CommonDefine.PayShowCountDownRemainTime<string>;
		if (payShowCountDownRemainTime != null)
		{
			text.SetText(payShowCountDownRemainTime.Value, true);
			return;
		}
		CommonDefine.PayShowCountDownRemainTime<CommonDefine.RemainTime> payShowCountDownRemainTime2 = countDownTime as CommonDefine.PayShowCountDownRemainTime<CommonDefine.RemainTime>;
		if (payShowCountDownRemainTime2 != null)
		{
			LguiUtil.Instance.SetLocalText(text, payShowCountDownRemainTime2.Value.TextId, new <>z__ReadOnlySingleElementList<object>(payShowCountDownRemainTime2.Value.TimeValue));
		}
	}

	// Token: 0x0601227C RID: 74364 RVA: 0x00476B54 File Offset: 0x00474D54
	private void RefreshShopItemState(PayShopGoods data)
	{
		PayShopBigItem.<>c__DisplayClass31_0 CS$<>8__locals1 = new PayShopBigItem.<>c__DisplayClass31_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.data = data;
		bool isVisible = CS$<>8__locals1.data.IsLimitGoods() && CS$<>8__locals1.data.IsSoldOut();
		this.SetTagVisible(PayShopDefine.EPayShopTagType.SoldOut, isVisible, new Action(CS$<>8__locals1.<RefreshShopItemState>g__callback|0), false);
		bool isVisible2 = !CS$<>8__locals1.data.IfCanBuy();
		this.SetTagVisible(PayShopDefine.EPayShopTagType.Lock, isVisible2, new Action(CS$<>8__locals1.<RefreshShopItemState>g__callback2|1), false);
	}

	// Token: 0x0601227D RID: 74365 RVA: 0x00476BCC File Offset: 0x00474DCC
	private void RefreshCommonItemTag(PayShopGoods data)
	{
		PayShopBigItem.<>c__DisplayClass32_0 CS$<>8__locals1 = new PayShopBigItem.<>c__DisplayClass32_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.data = data;
		CS$<>8__locals1.tagId = CS$<>8__locals1.data.GetDiscountLabel();
		if (this.CurrentTagType != CS$<>8__locals1.tagId)
		{
			this.SetTagVisible((PayShopDefine.EPayShopTagType)this.CurrentTagType, false, delegate
			{
			}, true);
			this.CurrentTagType = CS$<>8__locals1.tagId;
		}
		bool isVisible = CS$<>8__locals1.tagId > 0 && CS$<>8__locals1.data.InLabelShowTime();
		this.SetTagVisible((PayShopDefine.EPayShopTagType)this.CurrentTagType, isVisible, new Action(CS$<>8__locals1.<RefreshCommonItemTag>g__callback|1), true);
	}

	// Token: 0x0601227E RID: 74366 RVA: 0x00476C78 File Offset: 0x00474E78
	private void RefreshRechargeItemTag(PayItemData data)
	{
		PayShopBigItem.<>c__DisplayClass33_0 CS$<>8__locals1 = new PayShopBigItem.<>c__DisplayClass33_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.data = data;
		bool canSpecialBonus = CS$<>8__locals1.data.CanSpecialBonus;
		this.SetTagVisible(PayShopDefine.EPayShopTagType.RechargeGiven, canSpecialBonus, new Action(CS$<>8__locals1.<RefreshRechargeItemTag>g__callback|0), true);
		bool isVisible = CS$<>8__locals1.data.BonusItemCount > 0 && !canSpecialBonus;
		this.SetTagVisible(PayShopDefine.EPayShopTagType.RechargeDouble, isVisible, new Action(CS$<>8__locals1.<RefreshRechargeItemTag>g__callback2|1), true);
	}

	// Token: 0x0601227F RID: 74367 RVA: 0x00476CE8 File Offset: 0x00474EE8
	private void RefreshGachaDescItem()
	{
		if (!PayShopModel.Instance.BusinessCompliance)
		{
			base.GetItem(15).SetUIActive(false);
			return;
		}
		double num = (this.DataSt.GachaAverageCount != null) ? this.DataSt.GachaAverageCount() : 0.0;
		bool flag = num > 0.0;
		base.GetItem(15).SetUIActive(flag);
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "DisclaimerNumText", new <>z__ReadOnlySingleElementList<object>(num.ToString()));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(17), "DisclaimerText", new <>z__ReadOnlySingleElementList<object>((this.DataSt.GachaPrice != null) ? this.DataSt.GachaPrice() : ""));
		}
	}

	// Token: 0x06012280 RID: 74368 RVA: 0x00476DBC File Offset: 0x00474FBC
	private void SetTagVisible(PayShopDefine.EPayShopTagType tagType, bool isVisible, Action callback, bool inLeftTop = true)
	{
		PayShopTagItem payShopTagItem = null;
		this.TagItemMap.TryGetValue(tagType, out payShopTagItem);
		if (isVisible && payShopTagItem == null)
		{
			this.TagConstructPromise = new UniTask?(this.BuildTag(tagType, callback, inLeftTop).Preserve());
		}
		if (payShopTagItem != null)
		{
			payShopTagItem.SetUiActive(isVisible);
		}
		PayShopExtraTagItem payShopExtraTagItem = payShopTagItem as PayShopExtraTagItem;
		if (payShopExtraTagItem != null && isVisible)
		{
			payShopExtraTagItem.Refresh(this.Data);
		}
		callback();
	}

	// Token: 0x06012281 RID: 74369 RVA: 0x00476E28 File Offset: 0x00475028
	private UniTask BuildTag(PayShopDefine.EPayShopTagType tagType, Action callback, bool inLeftTop = true)
	{
		PayShopBigItem.<BuildTag>d__36 <BuildTag>d__;
		<BuildTag>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BuildTag>d__.<>4__this = this;
		<BuildTag>d__.tagType = tagType;
		<BuildTag>d__.callback = callback;
		<BuildTag>d__.inLeftTop = inLeftTop;
		<BuildTag>d__.<>1__state = -1;
		<BuildTag>d__.<>t__builder.Start<PayShopBigItem.<BuildTag>d__36>(ref <BuildTag>d__);
		return <BuildTag>d__.<>t__builder.Task;
	}

	// Token: 0x06012282 RID: 74370 RVA: 0x00476E83 File Offset: 0x00475083
	private string GetTagResourceId(PayShopDefine.EPayShopTagType tagType)
	{
		if (tagType == PayShopDefine.EPayShopTagType.TotalTopUp)
		{
			TotalTopUpController instance = TotalTopUpController.Instance;
			return ((instance != null) ? instance.GetCurrentTagResourcesId() : null) ?? "";
		}
		return PayShopDefine.payShopTagTypeToResourceId[tagType];
	}

	// Token: 0x06012283 RID: 74371 RVA: 0x00476EB0 File Offset: 0x004750B0
	private void RefreshOriginalPriceText()
	{
		UUIText text = base.GetText(6);
		IPriceData priceData = this.DataSt.PriceData;
		if (priceData == null || priceData.OriginalPrice == null || !priceData.InDiscountTime)
		{
			text.SetUIActive(false);
			return;
		}
		text.SetUIActive(true);
		text.SetText("<s>" + priceData.OriginalPrice.ToString() + "</s>", true);
	}

	// Token: 0x06012284 RID: 74372 RVA: 0x00476F28 File Offset: 0x00475128
	private void RefreshPrice()
	{
		string text = "FFEF6FFF";
		if (!this.DataSt.IsDirect && this.DataSt.PriceData.OwnNumber() < this.DataSt.PriceData.NowPrice)
		{
			text = "F55E66FF";
		}
		if (this.CachePriceData != null && this.CachePriceData == this.DataSt.PriceData && this.CurrentPriceColor == text)
		{
			return;
		}
		this.CurrentPriceColor = text;
		PayShopItemBaseSt dataSt = this.DataSt;
		this.CachePriceData = ((dataSt != null) ? dataSt.PriceData : null);
		UUIText text2 = base.GetText(5);
		if (this.DataSt.IsDirect)
		{
			Func<string> getDirectPriceTextFunc = this.DataSt.GetDirectPriceTextFunc;
			string text3 = (getDirectPriceTextFunc != null) ? getDirectPriceTextFunc() : null;
			if (text3 != null)
			{
				string newText = text3;
				text2.SetText(newText, true);
				text2.SetColor(FColor.FromHex(text));
			}
			return;
		}
		IPriceData priceData = this.DataSt.PriceData;
		if (priceData.NowPrice == 0)
		{
			text2.ShowTextNew("ShopDiscountLabel_4");
		}
		else
		{
			text2.SetText(priceData.NowPrice.ToString(), true);
		}
		text2.SetColor(FColor.FromHex(text));
	}

	// Token: 0x06012285 RID: 74373 RVA: 0x0047704C File Offset: 0x0047524C
	private void RefreshLeftTimesText()
	{
		UUIText text = base.GetText(4);
		Func<string> getShopTipsText = this.DataSt.GetShopTipsText;
		string text2 = (getShopTipsText != null) ? getShopTipsText() : null;
		if (this.CountDownType != EPayCountTimeType.Resell && !StringUtils.IsEmpty(text2))
		{
			text.SetUIActive(true);
			text.SetText(text2, true);
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x06012286 RID: 74374 RVA: 0x004770A1 File Offset: 0x004752A1
	public void RefreshRedDot()
	{
		if (this.DataSt.RedDotExistFunc != null)
		{
			base.GetItem(8).SetUIActive(this.DataSt.RedDotExistFunc());
			return;
		}
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x06012287 RID: 74375 RVA: 0x004770DC File Offset: 0x004752DC
	private void RefreshEffect(int quality, EItemQualityType qualityType)
	{
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		if (qualityType == EItemQualityType.PayShop)
		{
			list = this.SpecialGoldEffectArray;
			list2.AddRange(this.PurpleEffectArray);
			list2.AddRange(this.GoldEffectArray);
		}
		else if (quality == 4)
		{
			list = this.PurpleEffectArray;
			list2.AddRange(this.GoldEffectArray);
			list2.AddRange(this.SpecialGoldEffectArray);
		}
		else
		{
			list = this.GoldEffectArray;
			list2.AddRange(this.PurpleEffectArray);
			list2.AddRange(this.SpecialGoldEffectArray);
		}
		foreach (int name in list)
		{
			UUIItem item = base.GetItem(name);
			if (item != null)
			{
				item.SetUIActive(true);
			}
		}
		foreach (int name2 in list2)
		{
			UUIItem item2 = base.GetItem(name2);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
		}
	}

	// Token: 0x06012288 RID: 74376 RVA: 0x004771F8 File Offset: 0x004753F8
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x06012289 RID: 74377 RVA: 0x00477234 File Offset: 0x00475434
	private void OnDiscountShopTimerRefresh()
	{
		if (this.Data == null || !base.IsUiActiveInHierarchy())
		{
			return;
		}
		this.RefreshCommonItem();
		this.RefreshRechargeItem();
		this.RefreshOriginalPriceText();
		this.RefreshPrice();
		this.RefreshGachaDescItem();
		this.RefreshLeftTimesText();
		this.RefreshRedDot();
		PayShopGoods payShopGoods = this.Data as PayShopGoods;
		if (payShopGoods != null && (this.IsCountDownChange(payShopGoods) || this.IsDiscountChange(payShopGoods)))
		{
			this.TryEmitRefreshTips();
		}
	}

	// Token: 0x0601228A RID: 74378 RVA: 0x004772A8 File Offset: 0x004754A8
	private bool IsCountDownChange(PayShopGoods data)
	{
		double item = data.GetCountDownData().Item3;
		if (item == 0.0 && this.CurrentCountDownState)
		{
			this.CurrentCountDownState = false;
			return true;
		}
		if (item != 0.0 && !this.CurrentCountDownState)
		{
			this.CurrentCountDownState = true;
			return true;
		}
		return false;
	}

	// Token: 0x0601228B RID: 74379 RVA: 0x004772FC File Offset: 0x004754FC
	private bool IsDiscountChange(PayShopGoods data)
	{
		bool flag = data.HasDiscount();
		if (flag && !this.CurrentDiscountItemState)
		{
			this.CurrentDiscountItemState = true;
			return true;
		}
		if (!flag && this.CurrentDiscountItemState)
		{
			this.CurrentDiscountItemState = false;
			return true;
		}
		int discountNew = data.GetDiscountNew();
		if (discountNew != 0 && discountNew != this.CurrentDiscountValue)
		{
			this.CurrentDiscountValue = discountNew;
			return true;
		}
		return false;
	}

	// Token: 0x0601228C RID: 74380 RVA: 0x00477358 File Offset: 0x00475558
	protected void TryEmitRefreshTips()
	{
		PayShopController.Instance.ClosePayShopGoodDetailPopView();
		if (ConfirmBoxController.Instance.CheckIsConfirmBoxOpen())
		{
			return;
		}
		if (this.Data is PayItemData)
		{
			return;
		}
		EventSystem.Instance.Emit<int, bool>(EEventName.RefreshPayShop, (int)((PayShopGoods)this.Data).PayShopId, true);
	}

	// Token: 0x0601228D RID: 74381 RVA: 0x004773AC File Offset: 0x004755AC
	private unsafe void OnPayItemSuccess(PayItemSuccess notify)
	{
		if (this.Data is PayShopGoods || notify.PayItemId != ((PayItemData)this.Data).PayItemId)
		{
			return;
		}
		((PayItemData)this.Data).CanSpecialBonus = false;
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

	// Token: 0x0601228E RID: 74382 RVA: 0x00477482 File Offset: 0x00475682
	private void OnClickExplainBtn()
	{
		HelpController.Instance.OpenHelpById(9);
	}

	// Token: 0x0601228F RID: 74383 RVA: 0x00477490 File Offset: 0x00475690
	private void OnClickItem()
	{
		PayItemData payItemData = this.Data as PayItemData;
		if (payItemData == null)
		{
			PayShopGoods payShopGoods = this.Data as PayShopGoods;
			if (payShopGoods != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Shop;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "PayShop:ShopItem 点击商品";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", payShopGoods.GetGoodsData().Id);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				PayShopController.Instance.OpenBuyViewByGoodsId(payShopGoods, null);
			}
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Shop;
		ELogAuthor author2 = ELogAuthor.XXJ;
		string message2 = "PayShop:ShopItem 点击充值";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", payItemData.PayItemId);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		PayItemController.Instance.SdkPay(payItemData.PayItemId);
		Action<PayItemData> onClickRechargeCallback = this.OnClickRechargeCallback;
		if (onClickRechargeCallback == null)
		{
			return;
		}
		onClickRechargeCallback(payItemData);
	}

	// Token: 0x06012291 RID: 74385 RVA: 0x004775D1 File Offset: 0x004757D1
	[CompilerGenerated]
	internal static void <RefreshTotalScoreTagForGoods>g__callback|27_0()
	{
	}

	// Token: 0x06012292 RID: 74386 RVA: 0x004775D3 File Offset: 0x004757D3
	[CompilerGenerated]
	internal static void <RefreshTotalScoreTagForItem>g__callback|28_0()
	{
	}

	// Token: 0x0400892C RID: 35116
	private const string NORMALCOLOR = "FFEF6FFF";

	// Token: 0x0400892D RID: 35117
	private const string REDCOLOR = "F55E66FF";

	// Token: 0x0400892E RID: 35118
	[Nullable(2)]
	private IPayShopUnionData Data;

	// Token: 0x0400892F RID: 35119
	[Nullable(2)]
	private PayShopItemBaseSt DataSt;

	// Token: 0x04008930 RID: 35120
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<PayShopDefine.EPayShopTagType, PayShopTagItem> TagItemMap = new Dictionary<PayShopDefine.EPayShopTagType, PayShopTagItem>();

	// Token: 0x04008931 RID: 35121
	private UniTask? TagConstructPromise;

	// Token: 0x04008932 RID: 35122
	[Nullable(2)]
	private IPriceData CachePriceData;

	// Token: 0x04008933 RID: 35123
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PayItemData> OnClickRechargeCallback;

	// Token: 0x04008934 RID: 35124
	private bool CurrentDiscountItemState;

	// Token: 0x04008935 RID: 35125
	private int CurrentDiscountValue;

	// Token: 0x04008936 RID: 35126
	private bool CurrentCountDownState = true;

	// Token: 0x04008937 RID: 35127
	private EPayCountTimeType CountDownType;

	// Token: 0x04008938 RID: 35128
	private string CurrentPriceColor = "";

	// Token: 0x04008939 RID: 35129
	private int CurrentTagType;

	// Token: 0x0400893A RID: 35130
	private List<int> PurpleEffectArray = new List<int>
	{
		21,
		22
	};

	// Token: 0x0400893B RID: 35131
	private List<int> GoldEffectArray = new List<int>
	{
		23,
		24
	};

	// Token: 0x0400893C RID: 35132
	private List<int> SpecialGoldEffectArray = new List<int>
	{
		25,
		26
	};

	// Token: 0x0200891B RID: 35099
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402C900 RID: 182528
		public const int BtnBuy = 0;

		// Token: 0x0402C901 RID: 182529
		public const int TextureQuality = 1;

		// Token: 0x0402C902 RID: 182530
		public const int TextureIcon = 2;

		// Token: 0x0402C903 RID: 182531
		public const int TextName = 3;

		// Token: 0x0402C904 RID: 182532
		public const int TextLeftTimes = 4;

		// Token: 0x0402C905 RID: 182533
		public const int TextPrice = 5;

		// Token: 0x0402C906 RID: 182534
		public const int TextOriginalPrice = 6;

		// Token: 0x0402C907 RID: 182535
		public const int BtnHelp = 7;

		// Token: 0x0402C908 RID: 182536
		public const int ItemRedDot = 8;

		// Token: 0x0402C909 RID: 182537
		public const int ItemCountDown = 9;

		// Token: 0x0402C90A RID: 182538
		public const int TextCountDown = 10;

		// Token: 0x0402C90B RID: 182539
		public const int ItemStatePanel = 11;

		// Token: 0x0402C90C RID: 182540
		public const int ItemTagPanel = 12;

		// Token: 0x0402C90D RID: 182541
		public const int TexturePriceIcon = 13;

		// Token: 0x0402C90E RID: 182542
		public const int TextureTimeBg = 14;

		// Token: 0x0402C90F RID: 182543
		public const int GachaDescItem = 15;

		// Token: 0x0402C910 RID: 182544
		public const int GachaRewardText = 16;

		// Token: 0x0402C911 RID: 182545
		public const int GachaRewardPriceText = 17;

		// Token: 0x0402C912 RID: 182546
		public const int TextureQualityLine = 18;

		// Token: 0x0402C913 RID: 182547
		public const int TextureQualityLineLight = 19;

		// Token: 0x0402C914 RID: 182548
		public const int PurpleNiagaraEffect = 21;

		// Token: 0x0402C915 RID: 182549
		public const int PurpleStarEffect = 22;

		// Token: 0x0402C916 RID: 182550
		public const int GoldNiagaraEffect = 23;

		// Token: 0x0402C917 RID: 182551
		public const int GoldStarEffect = 24;

		// Token: 0x0402C918 RID: 182552
		public const int SpecialGoldNiagaraEffect = 25;

		// Token: 0x0402C919 RID: 182553
		public const int SpecialGoldStarEffect = 26;
	}
}
