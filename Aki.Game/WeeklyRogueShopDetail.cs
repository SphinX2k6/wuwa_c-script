using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D42 RID: 11586
public class WeeklyRogueShopDetail : UiPanelBase
{
	// Token: 0x0601858F RID: 99727 RVA: 0x00632980 File Offset: 0x00630B80
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

	// Token: 0x06018590 RID: 99728 RVA: 0x00632AF4 File Offset: 0x00630CF4
	protected override void OnStart()
	{
		this.TagLayout = new GenericLayout<WeeklyRogueTagItem, int>(base.GetHorizontalLayout(12), new Func<WeeklyRogueTagItem>(this.OnCreateTagItem), null, false, true);
	}

	// Token: 0x06018591 RID: 99729 RVA: 0x00632B18 File Offset: 0x00630D18
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

	// Token: 0x06018592 RID: 99730 RVA: 0x00632D8B File Offset: 0x00630F8B
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

	// Token: 0x06018593 RID: 99731 RVA: 0x00632DB6 File Offset: 0x00630FB6
	[NullableContext(1)]
	private WeeklyRogueTagItem OnCreateTagItem()
	{
		return new WeeklyRogueTagItem();
	}

	// Token: 0x0400B4C1 RID: 46273
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<WeeklyRogueTagItem, int> TagLayout;

	// Token: 0x020092D0 RID: 37584
	private enum EWeeklyRogueShopDetailDefine
	{
		// Token: 0x0402F738 RID: 194360
		TxtName,
		// Token: 0x0402F739 RID: 194361
		TxtHave,
		// Token: 0x0402F73A RID: 194362
		TxtType,
		// Token: 0x0402F73B RID: 194363
		TxtDesc,
		// Token: 0x0402F73C RID: 194364
		PanelAttr,
		// Token: 0x0402F73D RID: 194365
		AttrItem,
		// Token: 0x0402F73E RID: 194366
		PanelCost,
		// Token: 0x0402F73F RID: 194367
		BtnConfirm,
		// Token: 0x0402F740 RID: 194368
		TextureCurrencyIcon,
		// Token: 0x0402F741 RID: 194369
		TxtCurrencyCurPrice,
		// Token: 0x0402F742 RID: 194370
		TxtCurrencyOriginPrice,
		// Token: 0x0402F743 RID: 194371
		ElementLayout,
		// Token: 0x0402F744 RID: 194372
		TagLayout,
		// Token: 0x0402F745 RID: 194373
		TagItem
	}
}
