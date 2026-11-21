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

// Token: 0x02001863 RID: 6243
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PayShopBigItem : GridProxyAbstract<IPayShopUnionData>
{
	// Token: 0x0600F71F RID: 63263 RVA: 0x00483364 File Offset: 0x00481564
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

	// Token: 0x0600F720 RID: 63264 RVA: 0x00483757 File Offset: 0x00481957
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

	// Token: 0x0600F721 RID: 63265 RVA: 0x00483788 File Offset: 0x00481988
	public void SetOnClickRechargeCallback(Action<PayItemData> callback)
	{
		this.OnClickRechargeCallback = callback;
	}

	// Token: 0x0600F722 RID: 63266 RVA: 0x00483791 File Offset: 0x00481991
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Add(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600F723 RID: 63267 RVA: 0x004837CC File Offset: 0x004819CC
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

	// Token: 0x0600F724 RID: 63268 RVA: 0x004839C4 File Offset: 0x00481BC4
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

	// Token: 0x0600F725 RID: 63269 RVA: 0x00483AA0 File Offset: 0x00481CA0
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

	// Token: 0x0600F726 RID: 63270 RVA: 0x00483B18 File Offset: 0x00481D18
	public void RefreshRechargeItem()
	{
		if (this.Data == null || this.Data is PayShopGoods)
		{
			return;
		}
		this.RefreshRechargeItemTag((PayItemData)this.Data);
		this.RefreshTotalScoreTagForItem((PayItemData)this.Data);
	}

	// Token: 0x0600F727 RID: 63271 RVA: 0x00483B54 File Offset: 0x00481D54
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

	// Token: 0x0600F728 RID: 63272 RVA: 0x00483BBB File Offset: 0x00481DBB
	private void RefreshTotalScoreTagForGoods(PayShopGoods data)
	{
		this.SetTagVisible(PayShopDefine.EPayShopTagType.TotalTopUp, data.GetIfShowTotalTopUpScore(), new Action(PayShopBigItem.<RefreshTotalScoreTagForGoods>g__callback|27_0), true);
	}

	// Token: 0x0600F729 RID: 63273 RVA: 0x00483BD8 File Offset: 0x00481DD8
	private void RefreshTotalScoreTagForItem(PayItemData data)
	{
		this.SetTagVisible(PayShopDefine.EPayShopTagType.TotalTopUp, data.GetIfShowTotalTopUpScore(), new Action(PayShopBigItem.<RefreshTotalScoreTagForItem>g__callback|28_0), true);
	}

	// Token: 0x0600F72A RID: 63274 RVA: 0x00483BF8 File Offset: 0x00481DF8
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

	// Token: 0x0600F72B RID: 63275 RVA: 0x00483C54 File Offset: 0x00481E54
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

	// Token: 0x0600F72C RID: 63276 RVA: 0x00483CD4 File Offset: 0x00481ED4
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

	// Token: 0x0600F72D RID: 63277 RVA: 0x00483D4C File Offset: 0x00481F4C
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

	// Token: 0x0600F72E RID: 63278 RVA: 0x00483DF8 File Offset: 0x00481FF8
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

	// Token: 0x0600F72F RID: 63279 RVA: 0x00483E68 File Offset: 0x00482068
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

	// Token: 0x0600F730 RID: 63280 RVA: 0x00483F3C File Offset: 0x0048213C
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

	// Token: 0x0600F731 RID: 63281 RVA: 0x00483FA8 File Offset: 0x004821A8
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

	// Token: 0x0600F732 RID: 63282 RVA: 0x00484003 File Offset: 0x00482203
	private string GetTagResourceId(PayShopDefine.EPayShopTagType tagType)
	{
		if (tagType == PayShopDefine.EPayShopTagType.TotalTopUp)
		{
			TotalTopUpController instance = TotalTopUpController.Instance;
			return ((instance != null) ? instance.GetCurrentTagResourcesId() : null) ?? "";
		}
		return PayShopDefine.payShopTagTypeToResourceId[tagType];
	}

	// Token: 0x0600F733 RID: 63283 RVA: 0x00484030 File Offset: 0x00482230
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

	// Token: 0x0600F734 RID: 63284 RVA: 0x004840A8 File Offset: 0x004822A8
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

	// Token: 0x0600F735 RID: 63285 RVA: 0x004841CC File Offset: 0x004823CC
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

	// Token: 0x0600F736 RID: 63286 RVA: 0x00484221 File Offset: 0x00482421
	public void RefreshRedDot()
	{
		if (this.DataSt.RedDotExistFunc != null)
		{
			base.GetItem(8).SetUIActive(this.DataSt.RedDotExistFunc());
			return;
		}
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x0600F737 RID: 63287 RVA: 0x0048425C File Offset: 0x0048245C
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

	// Token: 0x0600F738 RID: 63288 RVA: 0x00484378 File Offset: 0x00482578
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove(EEventName.DiscountShopTimerRefresh, new Action(this.OnDiscountShopTimerRefresh));
		EventSystem.Instance.Remove(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600F739 RID: 63289 RVA: 0x004843B4 File Offset: 0x004825B4
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

	// Token: 0x0600F73A RID: 63290 RVA: 0x00484428 File Offset: 0x00482628
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

	// Token: 0x0600F73B RID: 63291 RVA: 0x0048447C File Offset: 0x0048267C
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

	// Token: 0x0600F73C RID: 63292 RVA: 0x004844D8 File Offset: 0x004826D8
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

	// Token: 0x0600F73D RID: 63293 RVA: 0x0048452C File Offset: 0x0048272C
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

	// Token: 0x0600F73E RID: 63294 RVA: 0x00484602 File Offset: 0x00482802
	private void OnClickExplainBtn()
	{
		HelpController.Instance.OpenHelpById(9);
	}

	// Token: 0x0600F73F RID: 63295 RVA: 0x00484610 File Offset: 0x00482810
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

	// Token: 0x0600F741 RID: 63297 RVA: 0x00484751 File Offset: 0x00482951
	[CompilerGenerated]
	internal static void <RefreshTotalScoreTagForGoods>g__callback|27_0()
	{
	}

	// Token: 0x0600F742 RID: 63298 RVA: 0x00484753 File Offset: 0x00482953
	[CompilerGenerated]
	internal static void <RefreshTotalScoreTagForItem>g__callback|28_0()
	{
	}

	// Token: 0x04008A71 RID: 35441
	private const string NORMALCOLOR = "FFEF6FFF";

	// Token: 0x04008A72 RID: 35442
	private const string REDCOLOR = "F55E66FF";

	// Token: 0x04008A73 RID: 35443
	[Nullable(2)]
	private IPayShopUnionData Data;

	// Token: 0x04008A74 RID: 35444
	[Nullable(2)]
	private PayShopItemBaseSt DataSt;

	// Token: 0x04008A75 RID: 35445
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<PayShopDefine.EPayShopTagType, PayShopTagItem> TagItemMap = new Dictionary<PayShopDefine.EPayShopTagType, PayShopTagItem>();

	// Token: 0x04008A76 RID: 35446
	private UniTask? TagConstructPromise;

	// Token: 0x04008A77 RID: 35447
	[Nullable(2)]
	private IPriceData CachePriceData;

	// Token: 0x04008A78 RID: 35448
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PayItemData> OnClickRechargeCallback;

	// Token: 0x04008A79 RID: 35449
	private bool CurrentDiscountItemState;

	// Token: 0x04008A7A RID: 35450
	private int CurrentDiscountValue;

	// Token: 0x04008A7B RID: 35451
	private bool CurrentCountDownState = true;

	// Token: 0x04008A7C RID: 35452
	private EPayCountTimeType CountDownType;

	// Token: 0x04008A7D RID: 35453
	private string CurrentPriceColor = "";

	// Token: 0x04008A7E RID: 35454
	private int CurrentTagType;

	// Token: 0x04008A7F RID: 35455
	private List<int> PurpleEffectArray = new List<int>
	{
		21,
		22
	};

	// Token: 0x04008A80 RID: 35456
	private List<int> GoldEffectArray = new List<int>
	{
		23,
		24
	};

	// Token: 0x04008A81 RID: 35457
	private List<int> SpecialGoldEffectArray = new List<int>
	{
		25,
		26
	};

	// Token: 0x02007AA5 RID: 31397
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027C18 RID: 162840
		public const int BtnBuy = 0;

		// Token: 0x04027C19 RID: 162841
		public const int TextureQuality = 1;

		// Token: 0x04027C1A RID: 162842
		public const int TextureIcon = 2;

		// Token: 0x04027C1B RID: 162843
		public const int TextName = 3;

		// Token: 0x04027C1C RID: 162844
		public const int TextLeftTimes = 4;

		// Token: 0x04027C1D RID: 162845
		public const int TextPrice = 5;

		// Token: 0x04027C1E RID: 162846
		public const int TextOriginalPrice = 6;

		// Token: 0x04027C1F RID: 162847
		public const int BtnHelp = 7;

		// Token: 0x04027C20 RID: 162848
		public const int ItemRedDot = 8;

		// Token: 0x04027C21 RID: 162849
		public const int ItemCountDown = 9;

		// Token: 0x04027C22 RID: 162850
		public const int TextCountDown = 10;

		// Token: 0x04027C23 RID: 162851
		public const int ItemStatePanel = 11;

		// Token: 0x04027C24 RID: 162852
		public const int ItemTagPanel = 12;

		// Token: 0x04027C25 RID: 162853
		public const int TexturePriceIcon = 13;

		// Token: 0x04027C26 RID: 162854
		public const int TextureTimeBg = 14;

		// Token: 0x04027C27 RID: 162855
		public const int GachaDescItem = 15;

		// Token: 0x04027C28 RID: 162856
		public const int GachaRewardText = 16;

		// Token: 0x04027C29 RID: 162857
		public const int GachaRewardPriceText = 17;

		// Token: 0x04027C2A RID: 162858
		public const int TextureQualityLine = 18;

		// Token: 0x04027C2B RID: 162859
		public const int TextureQualityLineLight = 19;

		// Token: 0x04027C2C RID: 162860
		public const int PurpleNiagaraEffect = 21;

		// Token: 0x04027C2D RID: 162861
		public const int PurpleStarEffect = 22;

		// Token: 0x04027C2E RID: 162862
		public const int GoldNiagaraEffect = 23;

		// Token: 0x04027C2F RID: 162863
		public const int GoldStarEffect = 24;

		// Token: 0x04027C30 RID: 162864
		public const int SpecialGoldNiagaraEffect = 25;

		// Token: 0x04027C31 RID: 162865
		public const int SpecialGoldStarEffect = 26;
	}
}
