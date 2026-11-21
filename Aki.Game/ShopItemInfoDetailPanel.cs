using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F73 RID: 8051
[NullableContext(2)]
[Nullable(0)]
public class ShopItemInfoDetailPanel : UiPanelBase
{
	// Token: 0x17001E1C RID: 7708
	// (get) Token: 0x06013E9B RID: 81563 RVA: 0x005CE48B File Offset: 0x005CC68B
	// (set) Token: 0x06013E9C RID: 81564 RVA: 0x005CE494 File Offset: 0x005CC694
	private int BuyCount
	{
		get
		{
			return this.Count;
		}
		set
		{
			this.Count = Math.Max(1, Math.Min(value, this.BuyCountMax));
			bool flag = InventoryModel.Instance.GetItemCountByConfigId(this.ShopPanelData.CurrencyId, 0) >= this.ShopPanelData.SingleBuyPrice * this.Count;
			UUIText text = base.GetText(6);
			text.SetColor(flag ? this.PurchaseTextOriginColor.Value : this.coinNotEnoughColor);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.ShopPanelData.SingleBuyPrice * this.Count);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			ShopItemFullInfo openItemInfo = ShopModel.Instance.OpenItemInfo;
			UUIText text2 = base.GetText(23);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("<s>");
			defaultInterpolatedStringHandler.AppendFormatted<int>(openItemInfo.GetOriginalPrice() * this.Count);
			defaultInterpolatedStringHandler.AppendLiteral("</s>");
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(27), "Text_ItemSelectShopQuantityTip_text", new <>z__ReadOnlySingleElementList<object>(this.Count));
		}
	}

	// Token: 0x06013E9D RID: 81565 RVA: 0x005CE5B8 File Offset: 0x005CC7B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIText)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(21, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIText)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIText)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUIText)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.BuyClick)),
			new ValueTuple<int, Delegate>(15, new Action(this.OnCurrencyNodeButtonClick))
		};
	}

	// Token: 0x06013E9E RID: 81566 RVA: 0x005CE8B8 File Offset: 0x005CCAB8
	protected override UniTask OnBeforeStartAsync()
	{
		ShopItemInfoDetailPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShopItemInfoDetailPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013E9F RID: 81567 RVA: 0x005CE8FC File Offset: 0x005CCAFC
	protected override void OnStart()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor != null)
		{
			rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.SequenceEvent));
		}
		this.PurchaseTextOriginColor = new FColor?(base.GetText(6).GetColor());
		this.AttributeVertical = new GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData>(base.GetVerticalLayout(20), new Func<AttributeItem>(this.InitDetail), null, false, true);
		UUIButtonComponent button = base.GetButton(15);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(true);
			}
		}
		UUIItem item = base.GetItem(10);
		this.NumberSelect = new NumberSelectComponent(item);
		this.NumberSelect.SetNumberSelectTipsVisible(false);
		UUIButtonComponent button2 = base.GetButton(7);
		if (button2 != null)
		{
			this.BuyButtonInteractGroup = (button2.GetOwner().GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup);
		}
		base.GetItem(28).SetUIActive(false);
		base.GetItem(29).SetUIActive(false);
	}

	// Token: 0x06013EA0 RID: 81568 RVA: 0x005CE9F2 File Offset: 0x005CCBF2
	private void ValueChangeFunction(int selectValue)
	{
		this.BuyCount = selectValue;
	}

	// Token: 0x06013EA1 RID: 81569 RVA: 0x005CE9FB File Offset: 0x005CCBFB
	[NullableContext(1)]
	private AttributeItem InitDetail()
	{
		return new AttributeItem();
	}

	// Token: 0x06013EA2 RID: 81570 RVA: 0x005CEA02 File Offset: 0x005CCC02
	private void UpdateAttribute()
	{
		this.AttributeVertical.RefreshByData(this.CommonTipsData.AttributeList, null, false);
	}

	// Token: 0x06013EA3 RID: 81571 RVA: 0x005CEA1C File Offset: 0x005CCC1C
	[NullableContext(1)]
	private void SequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "CloseEvent")
		{
			this.SetActive(false);
			return;
		}
		if (eventName == "SleEvent")
		{
			EventSystem.Instance.Emit(EEventName.CloseItemInfo);
		}
	}

	// Token: 0x06013EA4 RID: 81572 RVA: 0x005CEA50 File Offset: 0x005CCC50
	protected override void OnBeforeDestroy()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor != null)
		{
			rootActor.OnSequencePlayEvent.Unbind();
		}
		if (this.TipsWeaponItem != null)
		{
			this.TipsWeaponItem.Destroy(null);
			this.TipsWeaponItem = null;
		}
	}

	// Token: 0x06013EA5 RID: 81573 RVA: 0x005CEA90 File Offset: 0x005CCC90
	public void UpdatePanel(ShopPanelData panelData = null)
	{
		this.ShopPanelData = ((panelData != null) ? panelData : this.ShopPanelData);
		this.CommonTipsData = (CommonTipsComponentUtil.GetTipsDataByItemId(panelData.ItemId) as CommonTipsData);
		this.BuyCountMax = this.GetMaxCanBuyCount();
		this.BuyCount = 1;
		INumberSelectData data = new INumberSelectData
		{
			MaxNumber = this.BuyCountMax,
			ValueChangeFunction = new Action<int>(this.ValueChangeFunction)
		};
		this.NumberSelect.Init(data);
		this.NumberSelect.SetAddReduceButtonActive(true);
		this.NumberSelect.SetAddReduceButtonInteractive(this.BuyCountMax >= this.BuyCount);
		this.NumberSelect.SetReduceButtonInteractive(this.BuyCount > 1);
		ShopItemFullInfo openItemInfo = ShopModel.Instance.OpenItemInfo;
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(panelData.ItemId);
		LguiUtil.Instance.SetLocalText(base.GetText(0), "GoodsName", new <>z__ReadOnlyArray<object>(new object[]
		{
			new TableTextArgNew(itemConfigData.Name, Array.Empty<object>()),
			openItemInfo.StackSize
		}));
		Regex regex = new Regex("<.*?>");
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.AttributesDescription, null);
		string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.TypeDescription, null);
		string newText = regex.Replace(localTextNew, "");
		CommonTipsData commonTipsData = this.CommonTipsData;
		string newText2 = ((commonTipsData != null) ? commonTipsData.Type : null) ?? localTextNew2;
		base.GetText(1).SetText(newText2, true);
		base.GetText(2).SetText(newText, true);
		base.SetItemIcon(base.GetTexture(5), panelData.CurrencyId, null, null);
		bool flag = itemConfigData.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.CookMenu || itemConfigData.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.ForgingFormula || itemConfigData.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.ComposeFormula;
		base.GetText(16).SetUIActive(!flag);
		if (!flag)
		{
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(panelData.ItemId, 0);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(16), "Text_Have_Text", new <>z__ReadOnlySingleElementList<object>(itemCountByConfigId));
		}
		UUIText text = base.GetText(23);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
		defaultInterpolatedStringHandler.AppendLiteral("<s>");
		defaultInterpolatedStringHandler.AppendFormatted<int>(openItemInfo.GetOriginalPrice() * this.BuyCount);
		defaultInterpolatedStringHandler.AppendLiteral("</s>");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.GetText(23).SetUIActive(openItemInfo.GetOriginalPrice() != -1);
		base.GetItem(24).SetUIActive(openItemInfo.EndTime > 0U);
		if (openItemInfo.EndTime != 0U)
		{
			double num = openItemInfo.EndTime - TimeUtil.Instance.GetServerTime();
			int num2 = (int)(num / 86400.0);
			if (num2 > 0)
			{
				LguiUtil.Instance.SetLocalText(base.GetText(25), "ShopItemLimitTime1", new <>z__ReadOnlySingleElementList<object>(num2));
			}
			else if (num2 == 0)
			{
				int num3 = (int)(num / 3600.0);
				int num4 = (int)(num / 60.0) % 60;
				LguiUtil.Instance.SetLocalText(base.GetText(25), "ShopItemLimitTime2", new <>z__ReadOnlyArray<object>(new object[]
				{
					num3,
					num4
				}));
			}
			else
			{
				LguiUtil.Instance.SetLocalText(base.GetText(25), "ShopItemLimitTimeOut", Array.Empty<object>());
			}
		}
		this.UpdateLockState(panelData);
		this.BuyButtonInteractGroup.SetInteractable(true);
		InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(panelData.ItemId));
		this.UpdateItemTips(itemDataTypeByConfigId);
	}

	// Token: 0x06013EA6 RID: 81574 RVA: 0x005CEE30 File Offset: 0x005CD030
	protected int GetMaxCanBuyCount()
	{
		int num = InventoryModel.Instance.GetItemCountByConfigId(this.ShopPanelData.CurrencyId, 0) / this.ShopPanelData.SingleBuyPrice;
		if (this.ShopPanelData.BuyLimit > 0)
		{
			return Math.Min(Math.Max(0, this.ShopPanelData.BuyLimit - this.ShopPanelData.BoughtCount), num);
		}
		return num;
	}

	// Token: 0x06013EA7 RID: 81575 RVA: 0x005CEE94 File Offset: 0x005CD094
	protected void UpdateItemTips(InventoryDefine.EItemDataType itemType)
	{
		this.CloseUiItem();
		if (itemType == InventoryDefine.EItemDataType.WeaponItem)
		{
			this.SetWeaponTips();
			this.UpdateAttribute();
		}
		else
		{
			base.GetItem(22).SetUIActive(true);
		}
		UUIText text = base.GetText(18);
		CommonTipsData commonTipsData = this.CommonTipsData;
		if (((commonTipsData != null) ? commonTipsData.LevelText : null) != null)
		{
			text.SetUIActive(true);
			if (itemType != InventoryDefine.EItemDataType.WeaponItem)
			{
				text.SetText(this.CommonTipsData.LevelText, true);
				return;
			}
		}
		else
		{
			text.SetUIActive(false);
		}
	}

	// Token: 0x06013EA8 RID: 81576 RVA: 0x005CEF0C File Offset: 0x005CD10C
	protected void CloseUiItem()
	{
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(20);
		if (verticalLayout != null)
		{
			verticalLayout.GetRootComponent().SetUIActive(false);
		}
		base.GetItem(17).SetUIActive(false);
	}

	// Token: 0x06013EA9 RID: 81577 RVA: 0x005CEF40 File Offset: 0x005CD140
	[NullableContext(1)]
	protected void UpdateLockState(ShopPanelData panelData)
	{
		bool uiactive = panelData.IsInteractive();
		base.GetItem(9).SetUIActive(uiactive);
		base.GetItem(10).SetUIActive(uiactive);
		base.GetItem(11).SetUIActive(panelData.IsLock || panelData.IsSoldOut());
		base.GetItem(12).SetUIActive(panelData.IsLock);
		base.GetItem(8).SetUIActive(false);
		if (panelData.IsLock)
		{
			if (panelData.LockText is int)
			{
				int num = (int)panelData.LockText;
				if (num > 0)
				{
					LguiUtil.Instance.SetLocalText(base.GetText(13), "ShopFixed", new <>z__ReadOnlySingleElementList<object>(num));
					return;
				}
			}
			else if (panelData.LockText is string)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(13), (string)panelData.LockText, Array.Empty<object>());
			}
			return;
		}
		if (panelData.IsSoldOut())
		{
			base.GetItem(11).SetColor(this.soldOutColor);
			LguiUtil.Instance.SetLocalText(base.GetText(13), "ShopItemSoldOut", Array.Empty<object>());
			base.GetItem(14).SetUIActive(true);
			base.GetItem(26).SetUIActive(false);
			return;
		}
		base.GetItem(26).SetUIActive(true);
		if (panelData.BuyLimit > 0)
		{
			int num2 = Math.Max(0, panelData.BuyLimit - panelData.BoughtCount);
			base.GetItem(8).SetUIActive(true);
			LguiUtil.Instance.SetLocalText(base.GetText(4), "ShopItemLimitCount", new <>z__ReadOnlyArray<object>(new object[]
			{
				num2,
				panelData.BuyLimit
			}));
		}
	}

	// Token: 0x06013EAA RID: 81578 RVA: 0x005CF0EC File Offset: 0x005CD2EC
	protected void SetWeaponTips()
	{
		base.GetItem(17).SetUIActive(true);
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(20);
		if (verticalLayout != null)
		{
			verticalLayout.GetRootComponent().SetUIActive(true);
		}
		WeaponTipsData weaponTipsData = this.CommonTipsData as WeaponTipsData;
		int configId = weaponTipsData.ConfigId;
		WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(configId);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(weaponTipsData.BgDescription, null);
		this.TipsWeaponItem.UpdateItem(weaponConfigByItemId.Value, weaponTipsData.ResonanceLevel, localTextNew);
	}

	// Token: 0x06013EAB RID: 81579 RVA: 0x005CF168 File Offset: 0x005CD368
	private void BuyClick()
	{
		if (InventoryModel.Instance.GetItemCountByConfigId(this.ShopPanelData.CurrencyId, 0) >= this.ShopPanelData.SingleBuyPrice * this.Count)
		{
			this.ShopPanelData.BuySuccessFunction(this.ShopPanelData.ItemId, this.BuyCount, this.ShopPanelData.CurrencyId, this.ShopPanelData.ParamData);
			return;
		}
		string textById = TextConfig.Instance.GetTextById("ShopResourceNotEnough");
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ShopPanelData.CurrencyId);
		EventSystem.Instance.Emit(EEventName.OnSubmitItemFail);
		if (itemConfigData == null)
		{
			return;
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.Name, null);
		string text = StringUtils.Format(textById, new string[]
		{
			localTextNew
		});
		ScrollingTipsController.Instance.ShowTipsByText(text);
	}

	// Token: 0x06013EAC RID: 81580 RVA: 0x005CF23A File Offset: 0x005CD43A
	private void OnCurrencyNodeButtonClick()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ShopPanelData.CurrencyId, true, null, false);
	}

	// Token: 0x06013EAD RID: 81581 RVA: 0x005CF254 File Offset: 0x005CD454
	public object GetParams()
	{
		ShopPanelData shopPanelData = this.ShopPanelData;
		if (shopPanelData == null)
		{
			return null;
		}
		return shopPanelData.ParamData;
	}

	// Token: 0x0400A9BA RID: 43450
	private readonly FColor soldOutColor = FColor.FromHex("FFFFFFFF");

	// Token: 0x0400A9BB RID: 43451
	private readonly FColor coinNotEnoughColor = FColor.FromHex("9D2437FF");

	// Token: 0x0400A9BC RID: 43452
	private const int SECONDS_PER_DAY = 86400;

	// Token: 0x0400A9BD RID: 43453
	private ShopPanelData ShopPanelData;

	// Token: 0x0400A9BE RID: 43454
	protected CommonTipsData CommonTipsData;

	// Token: 0x0400A9BF RID: 43455
	private int Count;

	// Token: 0x0400A9C0 RID: 43456
	private TipsWeaponItem TipsWeaponItem;

	// Token: 0x0400A9C1 RID: 43457
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeVertical;

	// Token: 0x0400A9C2 RID: 43458
	private UUIInteractionGroup BuyButtonInteractGroup;

	// Token: 0x0400A9C3 RID: 43459
	private FColor? PurchaseTextOriginColor;

	// Token: 0x0400A9C4 RID: 43460
	private NumberSelectComponent NumberSelect;

	// Token: 0x0400A9C5 RID: 43461
	private int BuyCountMax;

	// Token: 0x02008276 RID: 33398
	[NullableContext(0)]
	private enum EShopItemInfoDetailViewDefine
	{
		// Token: 0x0402A1E3 RID: 172515
		Name,
		// Token: 0x0402A1E4 RID: 172516
		Type,
		// Token: 0x0402A1E5 RID: 172517
		EffectDescribe,
		// Token: 0x0402A1E6 RID: 172518
		Describe,
		// Token: 0x0402A1E7 RID: 172519
		LimitCountText,
		// Token: 0x0402A1E8 RID: 172520
		CurrencyIcon,
		// Token: 0x0402A1E9 RID: 172521
		PurchaseText,
		// Token: 0x0402A1EA RID: 172522
		BuyButton,
		// Token: 0x0402A1EB RID: 172523
		BuyLimitItem,
		// Token: 0x0402A1EC RID: 172524
		CalculatorItem,
		// Token: 0x0402A1ED RID: 172525
		NumberSelectItem,
		// Token: 0x0402A1EE RID: 172526
		LockItem,
		// Token: 0x0402A1EF RID: 172527
		LockCondition,
		// Token: 0x0402A1F0 RID: 172528
		LockConditionText,
		// Token: 0x0402A1F1 RID: 172529
		LockLimitItem,
		// Token: 0x0402A1F2 RID: 172530
		CurrencyNodeButton,
		// Token: 0x0402A1F3 RID: 172531
		HaveText,
		// Token: 0x0402A1F4 RID: 172532
		WeaponItem,
		// Token: 0x0402A1F5 RID: 172533
		LevelText,
		// Token: 0x0402A1F6 RID: 172534
		StarRootItem,
		// Token: 0x0402A1F7 RID: 172535
		DetailVerticalLayout,
		// Token: 0x0402A1F8 RID: 172536
		VerticalScroll,
		// Token: 0x0402A1F9 RID: 172537
		DetailItem,
		// Token: 0x0402A1FA RID: 172538
		OriginPriceText,
		// Token: 0x0402A1FB RID: 172539
		LimitTimePanel,
		// Token: 0x0402A1FC RID: 172540
		LimitTimeText,
		// Token: 0x0402A1FD RID: 172541
		PanelCost,
		// Token: 0x0402A1FE RID: 172542
		TextCost,
		// Token: 0x0402A1FF RID: 172543
		PnlLimitedTime,
		// Token: 0x0402A200 RID: 172544
		PnlAactived
	}
}
