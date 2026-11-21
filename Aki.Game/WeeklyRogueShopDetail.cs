using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200229C RID: 8860
public class WeeklyRogueShopDetail : UiPanelBase
{
	// Token: 0x06015E31 RID: 89649 RVA: 0x00658990 File Offset: 0x00656B90
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(12, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(13, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnBtnConfirm))
		};
	}

	// Token: 0x06015E32 RID: 89650 RVA: 0x00658B04 File Offset: 0x00656D04
	protected override void OnStart()
	{
		this.TagLayout = new GenericLayout<WeeklyRogueTagItem, int>(base.GetHorizontalLayout(12), new Func<WeeklyRogueTagItem>(this.OnCreateTagItem), null, false, true);
	}

	// Token: 0x06015E33 RID: 89651 RVA: 0x00658B28 File Offset: 0x00656D28
	[NullableContext(1)]
	public void Refresh(RogueWeeklyEntry data)
	{
		RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(data.ConfigId);
		if (rogueWeeklyBuffPool == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), rogueWeeklyBuffPool.Value.BuffName, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), rogueWeeklyBuffPool.Value.BuffDesc, rogueWeeklyBuffPool.Value.BuffDescParam());
		LguiUtil instance = LguiUtil.Instance;
		UUIText text = base.GetText(2);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
		defaultInterpolatedStringHandler.AppendLiteral("WeeklyRoguelikeShopItemType");
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)data.Type);
		instance.SetLocalTextNew(text, defaultInterpolatedStringHandler.ToStringAndClear(), Array.Empty<object>());
		RogueWeeklyGoods rogueWeeklyGoods = data.RogueWeeklyGoods;
		bool flag = rogueWeeklyGoods.CurPrice != rogueWeeklyGoods.SourcePrice;
		int num = flag ? rogueWeeklyGoods.CurPrice : rogueWeeklyGoods.SourcePrice;
		RogueCurrency? rogueCurrencyConfig = RoguelikeConfig.Instance.GetRogueCurrencyConfig(80100000);
		int currency = WeeklyRogueModel.Instance.GetCurrency(80100000);
		if (flag)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "RogueShopOriginPriceDiscount", new <>z__ReadOnlySingleElementList<object>(rogueWeeklyGoods.SourcePrice.ToString()));
		}
		else
		{
			UUIText text2 = base.GetText(10);
			if (text2 != null)
			{
				text2.SetText("", true);
			}
		}
		UUIText text3 = base.GetText(9);
		if (text3 != null)
		{
			text3.SetText(num.ToString(), true);
			text3.useChangeColor = (currency < num);
		}
		base.SetTextureByPath(((rogueCurrencyConfig != null) ? rogueCurrencyConfig.GetValueOrDefault().IconSmall : null) ?? string.Empty, base.GetTexture(8), null, null);
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(!rogueWeeklyGoods.IsSell);
		}
		UUIButtonComponent button = base.GetButton(7);
		if (button != null)
		{
			button.SetSelfInteractive(true);
		}
		UUIButtonComponent button2 = base.GetButton(7);
		if (button2 != null)
		{
			button2.RootUIComp.Get().SetUIActive(!rogueWeeklyGoods.IsSell);
		}
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(11);
		if (horizontalLayout != null)
		{
			horizontalLayout.RootUIComp.Get().SetUIActive(false);
		}
		List<int> rogueWeeklyBuffTagIdList = WeeklyRogueModel.Instance.GetRogueWeeklyBuffTagIdList(data.ConfigId);
		this.TagLayout.SetActive(rogueWeeklyBuffTagIdList.Count > 0);
		if (rogueWeeklyBuffTagIdList.Count > 0)
		{
			this.TagLayout.RefreshByData(rogueWeeklyBuffTagIdList, null, false);
		}
	}

	// Token: 0x06015E34 RID: 89652 RVA: 0x00658D9B File Offset: 0x00656F9B
	private void OnBtnConfirm()
	{
		UUIButtonComponent button = base.GetButton(7);
		if (button != null)
		{
			button.SetSelfInteractive(false);
		}
		WeeklyRogueController.Instance.SelectOptionRequest(delegate(bool success)
		{
			UUIButtonComponent button2 = base.GetButton(7);
			if (button2 != null)
			{
				button2.SetSelfInteractive(true);
			}
			if (success)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("WeRogueStorePurchaseSuccessText", Array.Empty<object>());
			}
		});
	}

	// Token: 0x06015E35 RID: 89653 RVA: 0x00658DC6 File Offset: 0x00656FC6
	[NullableContext(1)]
	private WeeklyRogueTagItem OnCreateTagItem()
	{
		return new WeeklyRogueTagItem();
	}

	// Token: 0x0400B836 RID: 47158
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WeeklyRogueTagItem, int> TagLayout;

	// Token: 0x020084F7 RID: 34039
	private enum EWeeklyRogueShopDetailDefine
	{
		// Token: 0x0402ADC0 RID: 175552
		TxtName,
		// Token: 0x0402ADC1 RID: 175553
		TxtHave,
		// Token: 0x0402ADC2 RID: 175554
		TxtType,
		// Token: 0x0402ADC3 RID: 175555
		TxtDesc,
		// Token: 0x0402ADC4 RID: 175556
		PanelAttr,
		// Token: 0x0402ADC5 RID: 175557
		AttrItem,
		// Token: 0x0402ADC6 RID: 175558
		PanelCost,
		// Token: 0x0402ADC7 RID: 175559
		BtnConfirm,
		// Token: 0x0402ADC8 RID: 175560
		TextureCurrencyIcon,
		// Token: 0x0402ADC9 RID: 175561
		TxtCurrencyCurPrice,
		// Token: 0x0402ADCA RID: 175562
		TxtCurrencyOriginPrice,
		// Token: 0x0402ADCB RID: 175563
		ElementLayout,
		// Token: 0x0402ADCC RID: 175564
		TagLayout,
		// Token: 0x0402ADCD RID: 175565
		TagItem
	}
}
