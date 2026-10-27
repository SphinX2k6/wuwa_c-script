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

// Token: 0x020029F8 RID: 10744
[NullableContext(2)]
[Nullable(0)]
public class ShopItemInfoDetailPanel : UiPanelBase
{
	// Token: 0x17001DC3 RID: 7619
	// (get) Token: 0x06016494 RID: 91284 RVA: 0x005A34B3 File Offset: 0x005A16B3
	// (set) Token: 0x06016495 RID: 91285 RVA: 0x005A34BC File Offset: 0x005A16BC
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

	// Token: 0x06016496 RID: 91286 RVA: 0x005A35E0 File Offset: 0x005A17E0
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

	// Token: 0x06016497 RID: 91287 RVA: 0x005A38E0 File Offset: 0x005A1AE0
	protected override UniTask OnBeforeStartAsync()
	{
		ShopItemInfoDetailPanel.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShopItemInfoDetailPanel.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016498 RID: 91288 RVA: 0x005A3924 File Offset: 0x005A1B24
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

	// Token: 0x06016499 RID: 91289 RVA: 0x005A3A1A File Offset: 0x005A1C1A
	private void ValueChangeFunction(int selectValue)
	{
		this.BuyCount = selectValue;
	}

	// Token: 0x0601649A RID: 91290 RVA: 0x005A3A23 File Offset: 0x005A1C23
	[NullableContext(1)]
	private AttributeItem InitDetail()
	{
		return new AttributeItem();
	}

	// Token: 0x0601649B RID: 91291 RVA: 0x005A3A2A File Offset: 0x005A1C2A
	private void UpdateAttribute()
	{
		this.AttributeVertical.RefreshByData(this.CommonTipsData.AttributeList, null, false);
	}

	// Token: 0x0601649C RID: 91292 RVA: 0x005A3A44 File Offset: 0x005A1C44
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

	// Token: 0x0601649D RID: 91293 RVA: 0x005A3A78 File Offset: 0x005A1C78
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

	// Token: 0x0601649E RID: 91294 RVA: 0x005A3AB8 File Offset: 0x005A1CB8
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

	// Token: 0x0601649F RID: 91295 RVA: 0x005A3E58 File Offset: 0x005A2058
	protected int GetMaxCanBuyCount()
	{
		int num = InventoryModel.Instance.GetItemCountByConfigId(this.ShopPanelData.CurrencyId, 0) / this.ShopPanelData.SingleBuyPrice;
		if (this.ShopPanelData.BuyLimit > 0)
		{
			return Math.Min(Math.Max(0, this.ShopPanelData.BuyLimit - this.ShopPanelData.BoughtCount), num);
		}
		return num;
	}

	// Token: 0x060164A0 RID: 91296 RVA: 0x005A3EBC File Offset: 0x005A20BC
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

	// Token: 0x060164A1 RID: 91297 RVA: 0x005A3F34 File Offset: 0x005A2134
	protected void CloseUiItem()
	{
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(20);
		if (verticalLayout != null)
		{
			verticalLayout.GetRootComponent().SetUIActive(false);
		}
		base.GetItem(17).SetUIActive(false);
	}

	// Token: 0x060164A2 RID: 91298 RVA: 0x005A3F68 File Offset: 0x005A2168
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

	// Token: 0x060164A3 RID: 91299 RVA: 0x005A4114 File Offset: 0x005A2314
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

	// Token: 0x060164A4 RID: 91300 RVA: 0x005A4190 File Offset: 0x005A2390
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

	// Token: 0x060164A5 RID: 91301 RVA: 0x005A4262 File Offset: 0x005A2462
	private void OnCurrencyNodeButtonClick()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ShopPanelData.CurrencyId, true, null);
	}

	// Token: 0x060164A6 RID: 91302 RVA: 0x005A427B File Offset: 0x005A247B
	public object GetParams()
	{
		ShopPanelData shopPanelData = this.ShopPanelData;
		if (shopPanelData == null)
		{
			return null;
		}
		return shopPanelData.ParamData;
	}

	// Token: 0x0400A5D0 RID: 42448
	private readonly FColor soldOutColor = FColor.FromHex("FFFFFFFF");

	// Token: 0x0400A5D1 RID: 42449
	private readonly FColor coinNotEnoughColor = FColor.FromHex("9D2437FF");

	// Token: 0x0400A5D2 RID: 42450
	private const int SECONDS_PER_DAY = 86400;

	// Token: 0x0400A5D3 RID: 42451
	private ShopPanelData ShopPanelData;

	// Token: 0x0400A5D4 RID: 42452
	protected CommonTipsData CommonTipsData;

	// Token: 0x0400A5D5 RID: 42453
	private int Count;

	// Token: 0x0400A5D6 RID: 42454
	private TipsWeaponItem TipsWeaponItem;

	// Token: 0x0400A5D7 RID: 42455
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeVertical;

	// Token: 0x0400A5D8 RID: 42456
	private UUIInteractionGroup BuyButtonInteractGroup;

	// Token: 0x0400A5D9 RID: 42457
	private FColor? PurchaseTextOriginColor;

	// Token: 0x0400A5DA RID: 42458
	private NumberSelectComponent NumberSelect;

	// Token: 0x0400A5DB RID: 42459
	private int BuyCountMax;

	// Token: 0x0200902F RID: 36911
	[NullableContext(0)]
	private enum EShopItemInfoDetailViewDefine
	{
		// Token: 0x0402EAEB RID: 191211
		Name,
		// Token: 0x0402EAEC RID: 191212
		Type,
		// Token: 0x0402EAED RID: 191213
		EffectDescribe,
		// Token: 0x0402EAEE RID: 191214
		Describe,
		// Token: 0x0402EAEF RID: 191215
		LimitCountText,
		// Token: 0x0402EAF0 RID: 191216
		CurrencyIcon,
		// Token: 0x0402EAF1 RID: 191217
		PurchaseText,
		// Token: 0x0402EAF2 RID: 191218
		BuyButton,
		// Token: 0x0402EAF3 RID: 191219
		BuyLimitItem,
		// Token: 0x0402EAF4 RID: 191220
		CalculatorItem,
		// Token: 0x0402EAF5 RID: 191221
		NumberSelectItem,
		// Token: 0x0402EAF6 RID: 191222
		LockItem,
		// Token: 0x0402EAF7 RID: 191223
		LockCondition,
		// Token: 0x0402EAF8 RID: 191224
		LockConditionText,
		// Token: 0x0402EAF9 RID: 191225
		LockLimitItem,
		// Token: 0x0402EAFA RID: 191226
		CurrencyNodeButton,
		// Token: 0x0402EAFB RID: 191227
		HaveText,
		// Token: 0x0402EAFC RID: 191228
		WeaponItem,
		// Token: 0x0402EAFD RID: 191229
		LevelText,
		// Token: 0x0402EAFE RID: 191230
		StarRootItem,
		// Token: 0x0402EAFF RID: 191231
		DetailVerticalLayout,
		// Token: 0x0402EB00 RID: 191232
		VerticalScroll,
		// Token: 0x0402EB01 RID: 191233
		DetailItem,
		// Token: 0x0402EB02 RID: 191234
		OriginPriceText,
		// Token: 0x0402EB03 RID: 191235
		LimitTimePanel,
		// Token: 0x0402EB04 RID: 191236
		LimitTimeText,
		// Token: 0x0402EB05 RID: 191237
		PanelCost,
		// Token: 0x0402EB06 RID: 191238
		TextCost,
		// Token: 0x0402EB07 RID: 191239
		PnlLimitedTime,
		// Token: 0x0402EB08 RID: 191240
		PnlAactived
	}
}
