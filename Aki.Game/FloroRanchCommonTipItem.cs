using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.FloroRanch;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B83 RID: 7043
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchCommonTipItem : UiPanelBase
{
	// Token: 0x0600D1AB RID: 53675 RVA: 0x00300CF8 File Offset: 0x002FEEF8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 27;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(22, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnDeleteButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D1AC RID: 53676 RVA: 0x003010EB File Offset: 0x002FF2EB
	protected override void OnStart()
	{
		this.BuffLayout = new GenericLayout<FloroRanchBuffItem, FloroRanchBuffData>(base.GetVerticalLayout(12), this.CreateBuffItem, null, false, true);
		UUIExtendToggle extendToggle = base.GetExtendToggle(24);
		if (extendToggle != null)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
		}
		this.RegisterTermExplanation();
	}

	// Token: 0x0600D1AD RID: 53677 RVA: 0x00301126 File Offset: 0x002FF326
	protected override void OnBeforeDestroy()
	{
		this.UnRegisterTermExplanation();
	}

	// Token: 0x0600D1AE RID: 53678 RVA: 0x00301130 File Offset: 0x002FF330
	public void RefreshInfoTipByParam(IFloroRanchCommonTipParam param)
	{
		this.ParamData = param;
		this.InitTipItem();
		switch (param.TipType)
		{
		case EFloroRanchCommonTipType.Entity:
			this.RefreshEntityTip();
			break;
		case EFloroRanchCommonTipType.Currency:
			this.RefreshCurrencyTip();
			break;
		case EFloroRanchCommonTipType.Toy:
			this.RefreshToyTip(param.ToyData);
			break;
		case EFloroRanchCommonTipType.Card:
			this.RefreshCardTip(param.CardData, null);
			break;
		}
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(23);
		if (scrollViewWithScrollbar != null)
		{
			scrollViewWithScrollbar.SetScrollProgress(0f);
		}
		UUIItem rootItem = base.GetRootItem();
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(true);
	}

	// Token: 0x0600D1AF RID: 53679 RVA: 0x003011C0 File Offset: 0x002FF3C0
	private void InitTipItem()
	{
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUIButtonComponent button = base.GetButton(14);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(false);
			}
		}
		base.GetItem(26).SetUIActive(false);
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(7);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(4);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUIItem item4 = base.GetItem(20);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		UUIItem item5 = base.GetItem(21);
		if (item5 != null)
		{
			item5.SetUIActive(false);
		}
		UUIText text2 = base.GetText(25);
		if (text2 == null)
		{
			return;
		}
		text2.SetUIActive(false);
	}

	// Token: 0x0600D1B0 RID: 53680 RVA: 0x0030128C File Offset: 0x002FF48C
	private void RefreshCurrencyTip()
	{
		IFloroRanchCommonTipParam paramData = this.ParamData;
		FloroRanchCurrencyData floroRanchCurrencyData = (paramData != null) ? paramData.CurrencyData : null;
		if (floroRanchCurrencyData == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "currencyData为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(floroRanchCurrencyData.ConfigData.GetName());
		}
		UUIText text2 = base.GetText(10);
		if (text2 != null)
		{
			text2.ShowTextNew(floroRanchCurrencyData.ConfigData.GetDesc());
		}
		base.SetTextureShowUntilLoaded(floroRanchCurrencyData.ConfigData.GetIcon(), base.GetTexture(3), null);
		FloroRanchRarityData qualityData = floroRanchCurrencyData.ConfigData.GetQualityData();
		base.SetTextureShowUntilLoaded(qualityData.GetRarityDetailCardBigBg(), base.GetTexture(18), null);
		base.SetTextureShowUntilLoaded(qualityData.GetRarityDetailCardSmallBg(), base.GetTexture(19), null);
		this.Price = 0;
	}

	// Token: 0x0600D1B1 RID: 53681 RVA: 0x00301360 File Offset: 0x002FF560
	private void RefreshEntityTip()
	{
		IFloroRanchCommonTipParam paramData = this.ParamData;
		FloroRanchEntityBase floroRanchEntityBase = (paramData != null) ? paramData.EntityData : null;
		if (floroRanchEntityBase == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "cardEntity为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		EFloroRanchEntityType entityType = floroRanchEntityBase.EntityType;
		FloroRanchEntityDataComponent floroRanchEntityDataComponent = floroRanchEntityBase.CheckGetComponent<FloroRanchEntityDataComponent>();
		if (entityType == EFloroRanchEntityType.Card)
		{
			FloroRanchCardDataComponent floroRanchCardDataComponent = floroRanchEntityBase.CheckGetComponent<FloroRanchCardDataComponent>();
			this.RefreshCardTip(floroRanchCardDataComponent.CardData, floroRanchEntityDataComponent.DailySaleData);
			UUIText text = base.GetText(17);
			if (text != null)
			{
				text.ShowTextNew("Farm_Edit3".ToString());
			}
			UUIButtonComponent button = base.GetButton(14);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(true);
				}
			}
		}
		else if (entityType == EFloroRanchEntityType.Toy)
		{
			FloroRanchToyDataComponent floroRanchToyDataComponent = floroRanchEntityBase.CheckGetComponent<FloroRanchToyDataComponent>();
			FloroRanchToyData toyData = floroRanchToyDataComponent.ToyData;
			int level = floroRanchToyDataComponent.Level;
			if (level > 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(25), "Farm_ToyLevelText", new <>z__ReadOnlySingleElementList<object>(level));
			}
			UUIText text2 = base.GetText(25);
			if (text2 != null)
			{
				text2.SetUIActive(level > 0);
			}
			this.RefreshToyTip(toyData);
			bool flag = toyData.CheckCanSell();
			if (flag)
			{
				UUIText text3 = base.GetText(17);
				if (text3 != null)
				{
					text3.ShowTextNew("Farm_Edit2".ToString());
				}
			}
			base.GetItem(26).SetUIActive(!flag);
			UUIButtonComponent button2 = base.GetButton(14);
			if (button2 != null)
			{
				UUIItem uuiitem2 = button2.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(flag);
				}
			}
		}
		this.RefreshTag(floroRanchEntityDataComponent.TagData);
		this.RefreshBuffTip(floroRanchEntityBase);
	}

	// Token: 0x0600D1B2 RID: 53682 RVA: 0x003014FC File Offset: 0x002FF6FC
	private void RefreshCardTip(FloroRanchCardData cardData, FloroRanchCurrencyData currencyData)
	{
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew("Farm_CardType1");
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetUIActive(true);
		}
		UUIText text3 = base.GetText(1);
		if (text3 != null)
		{
			text3.ShowTextNew(cardData.GetName());
		}
		this.RefreshTag(cardData.TagData);
		base.SetTextureShowUntilLoaded(cardData.GetIcon(), base.GetTexture(3), null);
		UUIText text4 = base.GetText(6);
		if (text4 != null)
		{
			text4.ShowTextNew(cardData.GetRaceName());
		}
		FloroRanchCurrencyData floroRanchCurrencyData = currencyData;
		if (floroRanchCurrencyData == null)
		{
			floroRanchCurrencyData = new FloroRanchCurrencyData(ECurrencyType.Salary);
			floroRanchCurrencyData.SetAmount((long)cardData.GetBasicSalary());
		}
		long amount = floroRanchCurrencyData.GetAmount();
		UUIText text5 = base.GetText(9);
		if (text5 != null)
		{
			text5.SetText(FloroRanchModel.Instance.GetCoinText(amount), true);
		}
		base.SetTextureShowUntilLoaded(floroRanchCurrencyData.ConfigData.GetSmallIcon(), base.GetTexture(8), null);
		base.GetItem(7).SetUIActive(true);
		FloroRanchRaceData floroRanchRaceData = FloroRanchModel.Instance.GetFloroRanchRaceData(cardData.GetRace());
		if (floroRanchRaceData != null)
		{
			base.SetTextureShowUntilLoaded(floroRanchRaceData.SmallIcon, base.GetTexture(5), null);
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(true);
			}
		}
		FloroRanchRarityData cardQualityData = cardData.GetCardQualityData();
		base.SetTextureShowUntilLoaded(cardQualityData.GetRarityDetailCardBigBg(), base.GetTexture(18), null);
		base.SetTextureShowUntilLoaded(cardQualityData.GetRarityDetailCardSmallBg(), base.GetTexture(19), null);
		FloroRanchCurrencyData diamondData = FloroRanchGamePlayModel.Instance.DiamondData;
		int deleteCost = cardData.GetDeleteCost();
		this.Price = deleteCost;
		UUIText text6 = base.GetText(16);
		UUIText uuitext = text6;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("-");
		defaultInterpolatedStringHandler.AppendFormatted<int>(deleteCost);
		uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		if (diamondData.GetAmount() < (long)deleteCost)
		{
			text6.useChangeColor = true;
		}
		else
		{
			text6.useChangeColor = false;
		}
		base.SetTextureShowUntilLoaded(diamondData.ConfigData.GetSmallIcon(), base.GetTexture(15), null);
		UUIItem item2 = base.GetItem(20);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(cardData.IsSpecialPhantom);
	}

	// Token: 0x0600D1B3 RID: 53683 RVA: 0x003016F8 File Offset: 0x002FF8F8
	private void RefreshToyTip(FloroRanchToyData toyData)
	{
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew("Farm_CardType2");
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetUIActive(true);
		}
		UUIText text3 = base.GetText(1);
		if (text3 != null)
		{
			text3.ShowTextNew(toyData.GetName());
		}
		this.RefreshTag(toyData.TagData);
		base.SetTextureShowUntilLoaded(toyData.GetIcon(), base.GetTexture(3), null);
		FloroRanchRarityData toyQualityData = toyData.GetToyQualityData();
		base.SetTextureShowUntilLoaded(toyQualityData.GetRarityDetailCardBigBg(), base.GetTexture(18), null);
		base.SetTextureShowUntilLoaded(toyQualityData.GetRarityDetailCardSmallBg(), base.GetTexture(19), null);
		int deleteEarn = toyData.GetDeleteEarn();
		UUIText text4 = base.GetText(16);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("+");
		defaultInterpolatedStringHandler.AppendFormatted<int>(deleteEarn);
		text4.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		text4.useChangeColor = false;
		FloroRanchCurrencyConfigData floroRanchCurrencyConfig = FloroRanchModel.Instance.GetFloroRanchCurrencyConfig(ECurrencyType.Diamond);
		base.SetTextureShowUntilLoaded(floroRanchCurrencyConfig.GetSmallIcon(), base.GetTexture(15), null);
		FloroRanchRaceData toyRaceData = toyData.GetToyRaceData();
		if (toyRaceData != null)
		{
			UUIItem item = base.GetItem(21);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			base.SetTextureShowUntilLoaded(toyRaceData.SmallIcon, base.GetTexture(22), null);
		}
		this.Price = 0;
	}

	// Token: 0x0600D1B4 RID: 53684 RVA: 0x00301834 File Offset: 0x002FFA34
	private void RefreshTag(FloroRanchTagData tagData)
	{
		if (tagData.TagId <= 0)
		{
			UUIText text = base.GetText(10);
			if (text == null)
			{
				return;
			}
			text.SetUIActive(false);
			return;
		}
		else
		{
			UUIText text2 = base.GetText(10);
			if (text2 != null)
			{
				text2.SetText(tagData.Desc, true);
			}
			UUIText text3 = base.GetText(10);
			if (text3 == null)
			{
				return;
			}
			text3.SetUIActive(true);
			return;
		}
	}

	// Token: 0x0600D1B5 RID: 53685 RVA: 0x0030188C File Offset: 0x002FFA8C
	private void RefreshBuffTip(FloroRanchEntityBase entityData)
	{
		FloroRanchEntityDataComponent floroRanchEntityDataComponent = entityData.CheckGetComponent<FloroRanchEntityDataComponent>();
		if (floroRanchEntityDataComponent == null)
		{
			return;
		}
		List<FloroRanchBuffData> tipShowBuffList = floroRanchEntityDataComponent.TipShowBuffList;
		if (tipShowBuffList != null && tipShowBuffList.Count <= 0)
		{
			return;
		}
		GenericLayout<FloroRanchBuffItem, FloroRanchBuffData> buffLayout = this.BuffLayout;
		if (buffLayout != null)
		{
			buffLayout.RefreshByData(tipShowBuffList, null, false);
		}
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(true);
	}

	// Token: 0x0600D1B6 RID: 53686 RVA: 0x003018E0 File Offset: 0x002FFAE0
	private void RegisterTermExplanation()
	{
		TermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(10),
			ViewType = ETermExplanationViewType.Center,
			Style = new ETermExplanationViewStyle?(ETermExplanationViewStyle.FloroRanch),
			ReportType = ETermExplanationReportType.FloroRanch,
			Group = new ETermExplanationGroup?(this.TermGroup)
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600D1B7 RID: 53687 RVA: 0x00301938 File Offset: 0x002FFB38
	private void UnRegisterTermExplanation()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(10));
	}

	// Token: 0x0600D1B8 RID: 53688 RVA: 0x0030194C File Offset: 0x002FFB4C
	private void OnDeleteButtonClick()
	{
		if (this.ParamData == null || this.ParamData.TipType != EFloroRanchCommonTipType.Entity)
		{
			return;
		}
		FloroRanchEntityBase entityData = this.ParamData.EntityData;
		if (entityData == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "删除按钮点击 entityData为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (entityData.EntityType == EFloroRanchEntityType.Toy)
		{
			FloroRanchToyDataComponent floroRanchToyDataComponent = entityData.CheckGetComponent<FloroRanchToyDataComponent>();
			if (floroRanchToyDataComponent != null)
			{
				FloroRanchToyData toyData = floroRanchToyDataComponent.ToyData;
				if (toyData != null && toyData.CheckCanSell())
				{
					goto IL_92;
				}
			}
			return;
		}
		IL_92:
		if (FloroRanchGamePlayModel.Instance.DiamondData.GetAmount() < (long)this.Price)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Farm_MoneyNotEnough".ToString(), Array.Empty<object>());
			return;
		}
		int subInstanceId = FloroRanchGamePlayModel.Instance.SubInstanceId;
		int entityId = entityData.EntityId;
		global::FloroRanchActivityData currentActivityData = FloroRanchGamePlayModel.Instance.GetCurrentActivityData();
		if (currentActivityData == null)
		{
			Log.Instance.Error(ELogModule.FloroRanchGamePlay, ELogAuthor.LRC, "删除按钮点击 当前不在弗洛洛玩法内，无法执行删除", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		FloroRanchController.Instance.SendFloroRanchPlayRemoveUnitRequest(currentActivityData.Id, subInstanceId, entityId, delegate(FloroRanchPlayRemoveUnitResponse _)
		{
			Action<FloroRanchEntityBase> removeCallback = this.ParamData.RemoveCallback;
			if (removeCallback == null)
			{
				return;
			}
			removeCallback(entityData);
		});
	}

	// Token: 0x04006031 RID: 24625
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<FloroRanchBuffItem, FloroRanchBuffData> BuffLayout;

	// Token: 0x04006032 RID: 24626
	private IFloroRanchCommonTipParam ParamData;

	// Token: 0x04006033 RID: 24627
	private int Price;

	// Token: 0x04006034 RID: 24628
	public ETermExplanationGroup TermGroup;

	// Token: 0x04006035 RID: 24629
	private readonly Func<FloroRanchBuffItem> CreateBuffItem = () => new FloroRanchBuffItem();

	// Token: 0x02008104 RID: 33028
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A1BE RID: 172478
		public const int TipItem = 0;

		// Token: 0x0402A1BF RID: 172479
		public const int Name = 1;

		// Token: 0x0402A1C0 RID: 172480
		public const int TypeName = 2;

		// Token: 0x0402A1C1 RID: 172481
		public const int IconTexture = 3;

		// Token: 0x0402A1C2 RID: 172482
		public const int CardRaceItem = 4;

		// Token: 0x0402A1C3 RID: 172483
		public const int CardRaceIcon = 5;

		// Token: 0x0402A1C4 RID: 172484
		public const int CardRace = 6;

		// Token: 0x0402A1C5 RID: 172485
		public const int SalaryItem = 7;

		// Token: 0x0402A1C6 RID: 172486
		public const int BasicSalaryIconTexture = 8;

		// Token: 0x0402A1C7 RID: 172487
		public const int Salary = 9;

		// Token: 0x0402A1C8 RID: 172488
		public const int TagDesc = 10;

		// Token: 0x0402A1C9 RID: 172489
		public const int BuffPanel = 11;

		// Token: 0x0402A1CA RID: 172490
		public const int BuffLayout = 12;

		// Token: 0x0402A1CB RID: 172491
		public const int BuffItem = 13;

		// Token: 0x0402A1CC RID: 172492
		public const int DeleteButton = 14;

		// Token: 0x0402A1CD RID: 172493
		public const int DeleteIconTexture = 15;

		// Token: 0x0402A1CE RID: 172494
		public const int DeleteNumber = 16;

		// Token: 0x0402A1CF RID: 172495
		public const int DeleteButtonText = 17;

		// Token: 0x0402A1D0 RID: 172496
		public const int QualityTexture = 18;

		// Token: 0x0402A1D1 RID: 172497
		public const int QualityBTexture = 19;

		// Token: 0x0402A1D2 RID: 172498
		public const int PhantomIconItem = 20;

		// Token: 0x0402A1D3 RID: 172499
		public const int ToyRaceItem = 21;

		// Token: 0x0402A1D4 RID: 172500
		public const int ToyRaceIcon = 22;

		// Token: 0x0402A1D5 RID: 172501
		public const int ScrollView = 23;

		// Token: 0x0402A1D6 RID: 172502
		public const int Toggle = 24;

		// Token: 0x0402A1D7 RID: 172503
		public const int ToyLevelText = 25;

		// Token: 0x0402A1D8 RID: 172504
		public const int NoSellItem = 26;
	}
}
