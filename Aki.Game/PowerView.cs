using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020025FA RID: 9722
[NullableContext(1)]
[Nullable(0)]
public class PowerView : UiTickViewBase
{
	// Token: 0x06013C78 RID: 81016 RVA: 0x004F5731 File Offset: 0x004F3931
	public PowerView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013C79 RID: 81017 RVA: 0x004F5744 File Offset: 0x004F3944
	protected unsafe override void OnRegisterComponent()
	{
		int num = 16;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUISliderComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.CancelClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.ConfirmClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06013C7A RID: 81018 RVA: 0x004F59E4 File Offset: 0x004F3BE4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPowerChanged, new Action(this.OnPowerChange));
		EventSystem.Instance.Add(EEventName.BoughtItem, new Action<int, int>(this.OnBuySuccess));
		EventSystem.Instance.Add(EEventName.OnGoodUnlock, new Action(this.OnGoodUnlock));
		EventSystem.Instance.Add<int>(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
	}

	// Token: 0x06013C7B RID: 81019 RVA: 0x004F5A64 File Offset: 0x004F3C64
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPowerChanged, new Action(this.OnPowerChange));
		EventSystem.Instance.Remove(EEventName.BoughtItem, new Action<int, int>(this.OnBuySuccess));
		EventSystem.Instance.Remove(EEventName.OnGoodUnlock, new Action(this.OnGoodUnlock));
		EventSystem.Instance.Remove(EEventName.OnPlayerCurrencyChange, new Action<int>(this.OnPlayerCurrencyChange));
	}

	// Token: 0x06013C7C RID: 81020 RVA: 0x004F5AE1 File Offset: 0x004F3CE1
	protected override void OnBeforeShow()
	{
		this.RefreshCurrency();
	}

	// Token: 0x06013C7D RID: 81021 RVA: 0x004F5AEC File Offset: 0x004F3CEC
	private UniTask RefreshCurrency()
	{
		PowerView.<RefreshCurrency>d__17 <RefreshCurrency>d__;
		<RefreshCurrency>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshCurrency>d__.<>4__this = this;
		<RefreshCurrency>d__.<>1__state = -1;
		<RefreshCurrency>d__.<>t__builder.Start<PowerView.<RefreshCurrency>d__17>(ref <RefreshCurrency>d__);
		return <RefreshCurrency>d__.<>t__builder.Task;
	}

	// Token: 0x06013C7E RID: 81022 RVA: 0x004F5B30 File Offset: 0x004F3D30
	protected override void OnStart()
	{
		UUIItem item2 = base.GetItem(11);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIButtonComponent button = base.GetButton(13);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		PowerController.Instance.SendUpdatePowerRequest(new int[]
		{
			5,
			6
		});
		this.PowerNaturalLimit = PowerConfig.Instance.GetPowerNaturalLimit();
		this.PowerChargeLimit = PowerConfig.Instance.GetPowerChargeLimit();
		this.PowerConfirmBoxData = (this.OpenParam as PowerConfirmBoxData);
		this.RefreshViewByBoxData();
		this.PowerPropScrollView = new GenericScrollView<MediumItemGrid>(base.GetScrollViewWithScrollbar(7), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MediumItemGrid>(this.RefreshScrollView), null);
		this.PowerItemInfos = this.GetPowerRecoverItem();
		this.PowerPropScrollView.RefreshByData<PowerItemInfo>(this.PowerItemInfos, null);
		this.StartSelectedIndex = 0;
		if (PowerModel.Instance.GetPowerDataById(6).GetCurrentPower() == 0)
		{
			if (InventoryModel.Instance.GetItemCountByConfigId(10800, 0) == 0)
			{
				this.StartSelectedIndex = this.PowerItemInfos.FindIndex((PowerItemInfo item) => item.ItemId == 3);
			}
			else
			{
				this.StartSelectedIndex = this.PowerItemInfos.FindIndex((PowerItemInfo item) => item.ItemId == 10800);
			}
		}
		else
		{
			this.StartSelectedIndex = this.PowerItemInfos.FindIndex((PowerItemInfo item) => item.ItemId == 6);
		}
		this.SelectedItemInfo = this.PowerItemInfos[this.StartSelectedIndex];
		this.SelectedItemGrid = this.PowerPropScrollView.GetScrollItemList()[this.StartSelectedIndex];
		this.SelectedItemGrid.SetSelected(true, false);
		this.UpdateDisplayItem(this.SelectedItemInfo);
	}

	// Token: 0x06013C7F RID: 81023 RVA: 0x004F5D14 File Offset: 0x004F3F14
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PowerItemInfo> GetPowerRecoverItem()
	{
		List<PowerItemInfo> list = new List<PowerItemInfo>();
		foreach (PowerItemInfo powerItemInfo in PowerModel.Instance.PowerItemInfoList)
		{
			if (powerItemInfo.StackValue > 0 || !powerItemInfo.IsHideWhenZero)
			{
				list.Add(powerItemInfo);
			}
		}
		return list;
	}

	// Token: 0x06013C80 RID: 81024 RVA: 0x004F5D84 File Offset: 0x004F3F84
	protected override void OnBeforeDestroy()
	{
		if (this.PowerPropScrollView == null)
		{
			return;
		}
		this.PowerPropScrollView.ClearChildren();
		this.PowerPropScrollView = null;
	}

	// Token: 0x06013C81 RID: 81025 RVA: 0x004F5DA4 File Offset: 0x004F3FA4
	protected override void OnTick(float delta)
	{
		this.RefreshRecoveryText();
		PowerItemInfo selectedItemInfo = this.SelectedItemInfo;
		this.RefreshRecoveryItem((selectedItemInfo != null) ? new int?(selectedItemInfo.ItemId) : null);
	}

	// Token: 0x06013C82 RID: 81026 RVA: 0x004F5DDC File Offset: 0x004F3FDC
	private void UpdateCountDown(string fullRecoveryText, string nextRecoveryText)
	{
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(fullRecoveryText, true);
		}
		UUIText text2 = base.GetText(4);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(nextRecoveryText, true);
	}

	// Token: 0x06013C83 RID: 81027 RVA: 0x004F5E08 File Offset: 0x004F4008
	private void RefreshViewByBoxData()
	{
		if (this.PowerConfirmBoxData == null)
		{
			return;
		}
		switch (this.PowerConfirmBoxData.Type)
		{
		case EPowerMenuType.Enough:
		{
			LguiUtil.Instance.SetLocalText(base.GetText(6), "PowerGetReward", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(10), "PowerRewardCost", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(3), "PowerCostAndReward", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(1), "PowerCancel", Array.Empty<object>());
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(9);
			if (verticalLayout == null)
			{
				return;
			}
			UUIItem rootComponent = verticalLayout.GetRootComponent();
			if (rootComponent == null)
			{
				return;
			}
			rootComponent.SetUIActive(false);
			return;
		}
		case EPowerMenuType.DisEnough:
		{
			LguiUtil.Instance.SetLocalText(base.GetText(6), "PowerGetReward", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(10), "PowerRewardCostFail", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(3), "PowerCostAndReward", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(1), "PowerCancel", Array.Empty<object>());
			UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(9);
			if (verticalLayout2 == null)
			{
				return;
			}
			UUIItem rootComponent2 = verticalLayout2.GetRootComponent();
			if (rootComponent2 == null)
			{
				return;
			}
			rootComponent2.SetUIActive(false);
			return;
		}
		case EPowerMenuType.Supply:
			LguiUtil.Instance.SetLocalText(base.GetText(6), "PowerTitle", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(1), "PowerCancel", Array.Empty<object>());
			LguiUtil.Instance.SetLocalText(base.GetText(3), "PowerConfirm", Array.Empty<object>());
			return;
		default:
			return;
		}
	}

	// Token: 0x06013C84 RID: 81028 RVA: 0x004F5FA4 File Offset: 0x004F41A4
	private void CancelClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06013C85 RID: 81029 RVA: 0x004F5FB0 File Offset: 0x004F41B0
	private void ConfirmClick()
	{
		if (this.PowerConfirmBoxData == null || this.SelectedItemInfo == null)
		{
			return;
		}
		EPowerMenuType type = this.PowerConfirmBoxData.Type;
		if (type == EPowerMenuType.DisEnough)
		{
			base.CloseMe(null);
			PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, 0);
			return;
		}
		if (type != EPowerMenuType.Supply)
		{
			base.CloseMe(null);
			return;
		}
		if (PowerModel.Instance.PowerCount + this.SelectedItemInfo.RenewValue > this.PowerChargeLimit)
		{
			ScrollingTipsController.Instance.ShowTipsById("PowerBound", Array.Empty<object>());
			return;
		}
		if (this.SelectedItemInfo.RemainCount == 0 && this.SelectedItemInfo.ItemId != 6)
		{
			ScrollingTipsController.Instance.ShowTipsByText(ConfigMultiTextLang.GetLocalTextNew("Text_PowerDescribe_Astrite_Not", null));
			return;
		}
		if (this.SelectedItemInfo.CostValue > this.SelectedItemInfo.StackValue)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(this.SelectedItemInfo.ItemName, null);
			string text = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("PowerPropsCannotExchange", null), new string[]
			{
				localTextNew
			});
			ScrollingTipsController.Instance.ShowTipsByText(text);
			return;
		}
		int costCount = 1;
		PowerController.Instance.ExchangePower(this.SelectedItemInfo, costCount, null);
	}

	// Token: 0x06013C86 RID: 81030 RVA: 0x004F60CC File Offset: 0x004F42CC
	private void SetDisplayItemInfo(MediumItemGridExtendCallback callbackParameter)
	{
		PowerItemInfo powerItemInfo = callbackParameter.Data as PowerItemInfo;
		ItemGridBase mediumItemGrid = callbackParameter.MediumItemGrid;
		ItemGridBase selectedItemGrid = this.SelectedItemGrid;
		if (selectedItemGrid != null)
		{
			selectedItemGrid.SetSelected(false, false);
		}
		this.SelectedItemGrid = mediumItemGrid;
		this.SelectedItemInfo = powerItemInfo;
		this.UpdateDisplayItem(powerItemInfo);
	}

	// Token: 0x06013C87 RID: 81031 RVA: 0x004F6114 File Offset: 0x004F4314
	private void UpdateDisplayItem(PowerItemInfo itemInfo)
	{
		this.RefreshNameText(itemInfo);
		this.RefreshViewByItemId(itemInfo.ItemId);
	}

	// Token: 0x06013C88 RID: 81032 RVA: 0x004F612C File Offset: 0x004F432C
	private void RefreshNameText(PowerItemInfo itemInfo)
	{
		if (itemInfo.ItemId != 6)
		{
			string textStringId = (itemInfo.ItemId == 3) ? "Text_PowerDescribe_Astrite_Text" : "Text_PowerDescribe_Text";
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(itemInfo.ItemName, null);
			int num = (itemInfo.RemainCount < 0) ? 0 : itemInfo.RemainCount;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				itemInfo.CostValue,
				localTextNew,
				itemInfo.RenewValue,
				num
			}));
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "GetOverPower", Array.Empty<object>());
	}

	// Token: 0x06013C89 RID: 81033 RVA: 0x004F61DA File Offset: 0x004F43DA
	private void RefreshViewByItemId(int itemId)
	{
		this.RefreshRecoveryItem(new int?(itemId));
	}

	// Token: 0x06013C8A RID: 81034 RVA: 0x004F61E8 File Offset: 0x004F43E8
	private void RefreshRecoveryItem(int? itemId)
	{
		if (itemId == null)
		{
			return;
		}
		this.RefreshPowerFullItem();
		PowerData powerDataById = PowerModel.Instance.GetPowerDataById(5);
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(powerDataById.GetPowerRecoveryMode() == EPowerRecoveryMode.Update);
	}

	// Token: 0x06013C8B RID: 81035 RVA: 0x004F622C File Offset: 0x004F442C
	private void RefreshRecoveryText()
	{
		PowerItemInfo selectedItemInfo = this.SelectedItemInfo;
		int? num = (selectedItemInfo != null) ? new int?(selectedItemInfo.ItemId) : null;
		if (num.GetValueOrDefault() == 3 || num.GetValueOrDefault() == 5 || num.GetValueOrDefault() == 6 || num.GetValueOrDefault() == 10800)
		{
			PowerData powerDataById = PowerModel.Instance.GetPowerDataById(5);
			this.UpdateCountDown(powerDataById.GetFullRecoverText(), powerDataById.GetNextTimerRecoverText());
		}
	}

	// Token: 0x06013C8C RID: 81036 RVA: 0x004F62A4 File Offset: 0x004F44A4
	private void RefreshPowerFullItem()
	{
		PowerData powerDataById = PowerModel.Instance.GetPowerDataById(5);
		UUIItem item = base.GetItem(15);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(powerDataById.CheckPowerIfMax());
	}

	// Token: 0x06013C8D RID: 81037 RVA: 0x004F62D8 File Offset: 0x004F44D8
	private void OnPowerChange()
	{
		float inValue = (float)PowerModel.Instance.PowerCount / (float)this.PowerNaturalLimit;
		UUISliderComponent slider = base.GetSlider(14);
		if (slider != null)
		{
			slider.SetValue(inValue, true);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.PowerModule;
		ELogAuthor author = ELogAuthor.LK;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
		defaultInterpolatedStringHandler.AppendLiteral("补充时打印体力");
		defaultInterpolatedStringHandler.AppendFormatted<int>(PowerModel.Instance.PowerCount);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.PowerNaturalLimit);
		instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		this.PowerItemInfos = this.GetPowerRecoverItem();
		GenericScrollView<MediumItemGrid> powerPropScrollView = this.PowerPropScrollView;
		if (powerPropScrollView != null)
		{
			powerPropScrollView.RefreshByData<PowerItemInfo>(this.PowerItemInfos, null);
		}
		if (this.PowerConfirmBoxData == null)
		{
			return;
		}
		int autoClosePowerCount = this.PowerConfirmBoxData.AutoClosePowerCount;
		if (autoClosePowerCount > 0 && PowerModel.Instance.PowerCount >= autoClosePowerCount)
		{
			base.CloseMe(null);
			return;
		}
		if (this.PowerConfirmBoxData.UpdateCurrentNeedPower)
		{
			int num = PowerModel.Instance.PowerCount - this.PowerConfirmBoxData.PowerCount;
			PowerModel.Instance.CurrentNeedPower = Math.Max(PowerModel.Instance.CurrentNeedPower - num, 0);
		}
		this.PowerConfirmBoxData.PowerCount = PowerModel.Instance.PowerCount;
	}

	// Token: 0x06013C8E RID: 81038 RVA: 0x004F6420 File Offset: 0x004F4620
	private void OnPlayerCurrencyChange(int itemId)
	{
		if (itemId == 3)
		{
			this.PowerItemInfos = this.GetPowerRecoverItem();
			GenericScrollView<MediumItemGrid> powerPropScrollView = this.PowerPropScrollView;
			if (powerPropScrollView != null)
			{
				powerPropScrollView.RefreshByData<PowerItemInfo>(this.PowerItemInfos, null);
			}
		}
		if (this.SelectedItemInfo != null)
		{
			this.UpdateDisplayItem(this.SelectedItemInfo);
		}
		MediumItemGrid payItemGrid = this.PayItemGrid;
		if (payItemGrid == null)
		{
			return;
		}
		payItemGrid.SetBottomText(PlayerInfoModel.Instance.GetPlayerMoney(3).ToString());
	}

	// Token: 0x06013C8F RID: 81039 RVA: 0x004F6494 File Offset: 0x004F4694
	private void OnBuySuccess(int shopId, int goodsId)
	{
		if (shopId == 0 || goodsId == 0)
		{
			return;
		}
		if (this.PowerPropScrollView != null)
		{
			PowerItemInfo selectedItemInfo = this.SelectedItemInfo;
			if (selectedItemInfo == null || selectedItemInfo.ItemId != 6)
			{
				ScrollingTipsController.Instance.ShowTipsById("PowerBuySucceed", new object[]
				{
					this.SelectedItemInfo.RenewValue.ToString()
				});
			}
		}
		this.PowerItemInfos = this.GetPowerRecoverItem();
		GenericScrollView<MediumItemGrid> powerPropScrollView = this.PowerPropScrollView;
		if (powerPropScrollView != null)
		{
			powerPropScrollView.RefreshByData<PowerItemInfo>(this.PowerItemInfos, null);
		}
		if (this.SelectedItemInfo != null)
		{
			this.UpdateDisplayItem(this.SelectedItemInfo);
		}
	}

	// Token: 0x06013C90 RID: 81040 RVA: 0x004F6534 File Offset: 0x004F4734
	private void OnGoodUnlock()
	{
		this.PowerItemInfos = this.GetPowerRecoverItem();
		GenericScrollView<MediumItemGrid> powerPropScrollView = this.PowerPropScrollView;
		if (powerPropScrollView == null)
		{
			return;
		}
		powerPropScrollView.RefreshByData<PowerItemInfo>(this.PowerItemInfos, null);
	}

	// Token: 0x06013C91 RID: 81041 RVA: 0x004F656C File Offset: 0x004F476C
	private ILayoutItem<MediumItemGrid> RefreshScrollView(object rawItemInfo, UUIItem uiItem, int index)
	{
		PowerItemInfo powerItemInfo = (PowerItemInfo)rawItemInfo;
		MediumItemGrid mediumItemGrid = new MediumItemGrid();
		mediumItemGrid.Initialize(uiItem.GetOwner());
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = powerItemInfo,
			ItemConfigId = new int?(powerItemInfo.ItemId),
			BottomText = powerItemInfo.StackValue.ToString()
		};
		mediumItemGrid.Apply<PropMediumItemGrid>(parameters);
		mediumItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.SetDisplayItemInfo));
		if (powerItemInfo.CostValue > powerItemInfo.StackValue || powerItemInfo.RemainCount == 0)
		{
			mediumItemGrid.SetBottomTextColor("9D2437FF");
		}
		else
		{
			mediumItemGrid.SetBottomTextColor("FFFFFFFF");
		}
		if (powerItemInfo.ItemId == 3)
		{
			this.PayItemGrid = mediumItemGrid;
		}
		return new LayoutItem<MediumItemGrid>
		{
			Key = index,
			Value = mediumItemGrid
		};
	}

	// Token: 0x0400950D RID: 38157
	private const string COUN_NOT_ENOUGH_COLOR = "9D2437FF";

	// Token: 0x0400950E RID: 38158
	private const string WHITE_COLOR = "FFFFFFFF";

	// Token: 0x0400950F RID: 38159
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<MediumItemGrid> PowerPropScrollView;

	// Token: 0x04009510 RID: 38160
	[Nullable(2)]
	private MediumItemGrid PayItemGrid;

	// Token: 0x04009511 RID: 38161
	[Nullable(2)]
	private PowerConfirmBoxData PowerConfirmBoxData;

	// Token: 0x04009512 RID: 38162
	[Nullable(2)]
	private PowerItemInfo SelectedItemInfo;

	// Token: 0x04009513 RID: 38163
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PowerItemInfo> PowerItemInfos;

	// Token: 0x04009514 RID: 38164
	private int PowerNaturalLimit;

	// Token: 0x04009515 RID: 38165
	private int PowerChargeLimit;

	// Token: 0x04009516 RID: 38166
	[Nullable(2)]
	private ItemGridBase SelectedItemGrid;

	// Token: 0x04009517 RID: 38167
	private int StartSelectedIndex = -1;

	// Token: 0x02008C2B RID: 35883
	[NullableContext(0)]
	private enum EPowerWidget
	{
		// Token: 0x0402D806 RID: 186374
		CancelButton,
		// Token: 0x0402D807 RID: 186375
		CancelText,
		// Token: 0x0402D808 RID: 186376
		ConfirmButton,
		// Token: 0x0402D809 RID: 186377
		ConfirmText,
		// Token: 0x0402D80A RID: 186378
		Power1,
		// Token: 0x0402D80B RID: 186379
		Power2,
		// Token: 0x0402D80C RID: 186380
		Title,
		// Token: 0x0402D80D RID: 186381
		ScrollView,
		// Token: 0x0402D80E RID: 186382
		ContentText,
		// Token: 0x0402D80F RID: 186383
		ContainerProp,
		// Token: 0x0402D810 RID: 186384
		CommonDescribe,
		// Token: 0x0402D811 RID: 186385
		Recover,
		// Token: 0x0402D812 RID: 186386
		Group,
		// Token: 0x0402D813 RID: 186387
		ConfirmButton2,
		// Token: 0x0402D814 RID: 186388
		PowerSlider,
		// Token: 0x0402D815 RID: 186389
		PowerFullItem
	}
}
