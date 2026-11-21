using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000CD1 RID: 3281
[NullableContext(1)]
[Nullable(0)]
public class ItemGridConsumeComponent : UiPanelBase
{
	// Token: 0x060088B0 RID: 34992 RVA: 0x00297538 File Offset: 0x00295738
	public ItemGridConsumeComponent(UUIItem uiItem, CommonMultipleConsumeFunction consumeFunction, EUiViewName? belongView = null, bool needSettingComponent = false)
	{
		this.SourceItem = uiItem;
		this.ConsumeFunction = consumeFunction;
		this.BelongView = belongView;
		this.NeedSettingComponent = needSettingComponent;
	}

	// Token: 0x060088B1 RID: 34993 RVA: 0x0029758C File Offset: 0x0029578C
	public UniTask Init()
	{
		ItemGridConsumeComponent.<Init>d__19 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ItemGridConsumeComponent.<Init>d__19>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060088B2 RID: 34994 RVA: 0x002975D0 File Offset: 0x002957D0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(7, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.AutoClick))
		};
		if (this.NeedSettingComponent)
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(18, typeof(UUIButtonComponent)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(19, typeof(UUIItem)));
			this.BtnBindInfo.Add(new ValueTuple<int, Delegate>(18, new Action(this.OnSettingBtnClick)));
		}
	}

	// Token: 0x060088B3 RID: 34995 RVA: 0x002977B9 File Offset: 0x002959B9
	private OneTextDropDownItem CreateDropDownItem(UUIItem uiItem, QualityInfo data)
	{
		return new OneTextDropDownItem(uiItem);
	}

	// Token: 0x060088B4 RID: 34996 RVA: 0x002977C1 File Offset: 0x002959C1
	private OneTextTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new OneTextTitleItem(uiItem);
	}

	// Token: 0x060088B5 RID: 34997 RVA: 0x002977CC File Offset: 0x002959CC
	protected override UniTask OnBeforeStartAsync()
	{
		ItemGridConsumeComponent.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemGridConsumeComponent.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060088B6 RID: 34998 RVA: 0x00297810 File Offset: 0x00295A10
	public void InitFilter(EItemGridConsumeLocalDropDown dropDownKey, Action<int> onSelectCall)
	{
		this.DropDownCall = onSelectCall;
		this.CurrentDropDownKey = new EItemGridConsumeLocalDropDown?(dropDownKey);
		int currentDropDownSelectIndex;
		if ((LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.ItemGridDropDown, null) ?? new Dictionary<int, int>()).TryGetValue((int)dropDownKey, out currentDropDownSelectIndex))
		{
			this.CurrentDropDownSelectIndex = currentDropDownSelectIndex;
		}
		IReadOnlyList<QualityInfo> configList = ConfigQualityInfoAll.GetConfigList(true);
		this.CommonDropDown.SetOnSelectCall(new Action<int, QualityInfo>(this.OnDropDownSelectCall));
		this.CommonDropDown.SetShowType(ECommonDropDownShowType.Up);
		this.CommonDropDown.InitScroll(configList, new Func<QualityInfo, TableTextArgNew>(this.GetDropDownTextId), this.CurrentDropDownSelectIndex, true);
		this.DropDownCall(this.CurrentDropDownSelectIndex);
		base.GetItem(2).SetUIActive(true);
	}

	// Token: 0x060088B7 RID: 34999 RVA: 0x002978B9 File Offset: 0x00295AB9
	private TableTextArgNew GetDropDownTextId(QualityInfo data)
	{
		return new TableTextArgNew(data.ConsumeFilterText, Array.Empty<object>());
	}

	// Token: 0x060088B8 RID: 35000 RVA: 0x002978CC File Offset: 0x00295ACC
	public bool HasSelect()
	{
		return this.GetSelectedGridCount() > 0;
	}

	// Token: 0x060088B9 RID: 35001 RVA: 0x002978D8 File Offset: 0x00295AD8
	public int GetSelectedGridCount()
	{
		int num = 0;
		if (this.ConsumeList == null || this.ConsumeList.Count == 0)
		{
			return num;
		}
		foreach (TCommonMultipleConsumeData tcommonMultipleConsumeData in this.ConsumeList)
		{
			if (tcommonMultipleConsumeData.ItemData.ItemId == 0)
			{
				break;
			}
			num++;
		}
		return num;
	}

	// Token: 0x060088BA RID: 35002 RVA: 0x00297954 File Offset: 0x00295B54
	private void RefreshAutoSelectText()
	{
		if (this.HasSelect())
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "DeleteSelect", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), this.SelectTextId, Array.Empty<object>());
	}

	// Token: 0x060088BB RID: 35003 RVA: 0x002979A3 File Offset: 0x00295BA3
	public void UpdateAutoSelectTextByTextId(string textId)
	{
		this.SelectTextId = textId;
		this.RefreshAutoSelectText();
	}

	// Token: 0x060088BC RID: 35004 RVA: 0x002979B4 File Offset: 0x00295BB4
	private void AutoClick()
	{
		if (!this.HasSelect())
		{
			if (this.ConsumeFunction.AutoFunction != null)
			{
				this.ConsumeFunction.AutoFunction(this.CurrentDropDownSelectIndex);
				return;
			}
		}
		else
		{
			Action deleteSelectFunction = this.ConsumeFunction.DeleteSelectFunction;
			if (deleteSelectFunction == null)
			{
				return;
			}
			deleteSelectFunction();
		}
	}

	// Token: 0x060088BD RID: 35005 RVA: 0x00297A02 File Offset: 0x00295C02
	private void OnSettingBtnClick()
	{
		Action settingBtnClickCallBack = this.SettingBtnClickCallBack;
		if (settingBtnClickCallBack == null)
		{
			return;
		}
		settingBtnClickCallBack();
	}

	// Token: 0x060088BE RID: 35006 RVA: 0x00297A14 File Offset: 0x00295C14
	protected override void OnStart()
	{
		this.StrengthItem = new ButtonItem(base.GetItem(11));
		this.StrengthItem.SetFunction(delegate(int dataId)
		{
			TCommonMultipleConsumeFunction strengthFunction = this.ConsumeFunction.StrengthFunction;
			if (strengthFunction == null)
			{
				return;
			}
			strengthFunction(dataId);
		});
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
		this.ScrollView = new GenericScrollViewNew<ConsumeMediumItemGrid, TCommonMultipleConsumeData>(scrollViewWithScrollbar, new Func<ConsumeMediumItemGrid>(this.InitItem), null, false, null);
		base.GetItem(2).SetUIActive(false);
		this.MaxCount = WeaponConfig.Instance.GetMaterialItemMaxCount();
		this.SetSettingButtonVisible(false);
	}

	// Token: 0x060088BF RID: 35007 RVA: 0x00297A94 File Offset: 0x00295C94
	private void OnDropDownSelectCall(int index, QualityInfo data)
	{
		this.CurrentDropDownSelectIndex = index;
		Dictionary<int, int> dictionary = LocalStorage.GetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.ItemGridDropDown, null) ?? new Dictionary<int, int>();
		dictionary[(int)this.CurrentDropDownKey.Value] = index;
		LocalStorage.SetPlayer<Dictionary<int, int>>(ELocalStoragePlayerKey.ItemGridDropDown, dictionary);
		Action<int> dropDownCall = this.DropDownCall;
		if (dropDownCall == null)
		{
			return;
		}
		dropDownCall(index);
	}

	// Token: 0x060088C0 RID: 35008 RVA: 0x00297AE6 File Offset: 0x00295CE6
	public int GetCurrentDropDownSelectIndex()
	{
		return this.CurrentDropDownSelectIndex;
	}

	// Token: 0x060088C1 RID: 35009 RVA: 0x00297AF0 File Offset: 0x00295CF0
	private ConsumeMediumItemGrid InitItem()
	{
		ConsumeMediumItemGrid consumeMediumItemGrid = new ConsumeMediumItemGrid();
		this.BindItemEvents(consumeMediumItemGrid);
		return consumeMediumItemGrid;
	}

	// Token: 0x060088C2 RID: 35010 RVA: 0x00297B0C File Offset: 0x00295D0C
	private void BindItemEvents(ConsumeMediumItemGrid propItem)
	{
		propItem.BindReduceLongPress(delegate(bool isShortPress, MediumItemGrid mediumItemGrid, object data)
		{
			if (data == null)
			{
				return;
			}
			TCommonMultipleConsumeData tcommonMultipleConsumeData = (TCommonMultipleConsumeData)data;
			TCommonMultipleConsumeFunctionWithInt reduceItemFunction = this.ConsumeFunction.ReduceItemFunction;
			if (reduceItemFunction == null)
			{
				return;
			}
			reduceItemFunction(new int?(tcommonMultipleConsumeData.ItemData.IncId), new int?(tcommonMultipleConsumeData.ItemData.ItemId));
		});
		propItem.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback callbackParameter)
		{
			TCommonMultipleConsumeData tcommonMultipleConsumeData = (TCommonMultipleConsumeData)callbackParameter.Data;
			TCommonMultipleConsumeFunctionWithInt materialItemFunction = this.ConsumeFunction.MaterialItemFunction;
			if (materialItemFunction == null)
			{
				return;
			}
			materialItemFunction(new int?(tcommonMultipleConsumeData.ItemData.IncId), new int?(tcommonMultipleConsumeData.ItemData.ItemId));
		});
		propItem.BindEmptySlotButtonCallback(delegate(MediumItemGridButtonCallback callbackParameter)
		{
			Action itemClickFunction = this.ConsumeFunction.ItemClickFunction;
			if (itemClickFunction == null)
			{
				return;
			}
			itemClickFunction();
		});
		propItem.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
	}

	// Token: 0x060088C3 RID: 35011 RVA: 0x00297B74 File Offset: 0x00295D74
	protected override void OnBeforeDestroy()
	{
		if (this.StrengthItem != null)
		{
			this.StrengthItem.Destroy(null);
			this.StrengthItem = null;
		}
		CommonDropDown<TableTextArgNew, QualityInfo> commonDropDown = this.CommonDropDown;
		if (commonDropDown != null)
		{
			commonDropDown.Destroy(null);
		}
		if (this.SettingRedDotName != null)
		{
			RedDotController.Instance.UnBindGivenUi(this.SettingRedDotName.Value, base.GetItem(19), 0);
		}
	}

	// Token: 0x060088C4 RID: 35012 RVA: 0x00297BDC File Offset: 0x00295DDC
	public void UpdateComponent(int moneyId, int costCount, List<TCommonMultipleConsumeData> consumeList)
	{
		this.ConsumeList = consumeList;
		this.ScrollView.RefreshByData(this.ConsumeList, null, false);
		int selectedGridCount = this.GetSelectedGridCount();
		LguiUtil.Instance.SetLocalText(base.GetText(0), "WeaponMaterialLengthText", new <>z__ReadOnlyArray<object>(new object[]
		{
			selectedGridCount,
			this.MaxCount
		}));
		UUIText text = base.GetText(8);
		int playerMoney = PlayerInfoModel.Instance.GetPlayerMoney(moneyId);
		this.CurrentCostCount = costCount;
		text.SetText(costCount.ToString(), true);
		this.EnoughMoney = (playerMoney >= costCount);
		UUIItem uuiitem = text;
		bool bUseChangeColor = playerMoney < costCount;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		this.RefreshAutoSelectText();
	}

	// Token: 0x060088C5 RID: 35013 RVA: 0x00297C96 File Offset: 0x00295E96
	public void SetMaxState(bool inMax)
	{
		this.SetCostRootItemState(!inMax);
		this.SetStrengthItemEnable(!inMax);
		this.SetMaxItemEnable(inMax);
		this.SetMaterialRootItemEnable(!inMax);
	}

	// Token: 0x060088C6 RID: 35014 RVA: 0x00297CBD File Offset: 0x00295EBD
	public void SetCostRootItemState(bool state)
	{
		base.GetItem(6).SetUIActive(state);
	}

	// Token: 0x060088C7 RID: 35015 RVA: 0x00297CCC File Offset: 0x00295ECC
	public void SetStrengthItemText(string text)
	{
		this.StrengthItem.SetLocalTextNew(text, Array.Empty<object>());
	}

	// Token: 0x060088C8 RID: 35016 RVA: 0x00297CDF File Offset: 0x00295EDF
	public void SetStrengthItemEnable(bool state)
	{
		this.StrengthItem.SetEnableClick(state);
		this.StrengthItem.SetActive(state);
	}

	// Token: 0x060088C9 RID: 35017 RVA: 0x00297CF9 File Offset: 0x00295EF9
	public void SetMaxItemEnable(bool state)
	{
		base.GetItem(12).SetUIActive(state);
	}

	// Token: 0x060088CA RID: 35018 RVA: 0x00297D09 File Offset: 0x00295F09
	public void SetMaterialRootItemEnable(bool state)
	{
		base.GetItem(10).SetUIActive(state);
	}

	// Token: 0x060088CB RID: 35019 RVA: 0x00297D1C File Offset: 0x00295F1C
	public void SetConsumeListEnable(bool state)
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		scrollViewWithScrollbar.RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x060088CC RID: 35020 RVA: 0x00297D48 File Offset: 0x00295F48
	public bool GetEnoughMoney()
	{
		return this.EnoughMoney;
	}

	// Token: 0x060088CD RID: 35021 RVA: 0x00297D50 File Offset: 0x00295F50
	public void SetMaxCount(int count)
	{
		this.MaxCount = count;
	}

	// Token: 0x060088CE RID: 35022 RVA: 0x00297D59 File Offset: 0x00295F59
	public int GetMaxCount()
	{
		return this.MaxCount;
	}

	// Token: 0x060088CF RID: 35023 RVA: 0x00297D61 File Offset: 0x00295F61
	public void RefreshConditionText(string str)
	{
		base.GetText(9).ShowTextNew(str);
	}

	// Token: 0x060088D0 RID: 35024 RVA: 0x00297D74 File Offset: 0x00295F74
	public void SetConsumeTexture(int itemId)
	{
		base.SetItemIcon(base.GetTexture(7), itemId, null, null);
	}

	// Token: 0x060088D1 RID: 35025 RVA: 0x00297D9C File Offset: 0x00295F9C
	public void SetSettingButtonVisible(bool bVisible)
	{
		if (!this.NeedSettingComponent)
		{
			return;
		}
		UUIButtonComponent button = base.GetButton(18);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(bVisible);
	}

	// Token: 0x060088D2 RID: 35026 RVA: 0x00297DD2 File Offset: 0x00295FD2
	public void SetSettingButtonClickCallBack(Action callBack)
	{
		this.SettingBtnClickCallBack = callBack;
	}

	// Token: 0x060088D3 RID: 35027 RVA: 0x00297DDB File Offset: 0x00295FDB
	public void BindSettingButtonRedDot(ERedDotName name)
	{
		if (!this.NeedSettingComponent)
		{
			return;
		}
		this.SettingRedDotName = new ERedDotName?(name);
		RedDotController.Instance.BindRedDot(name, base.GetItem(19), null, 0);
	}

	// Token: 0x060088D4 RID: 35028 RVA: 0x00297E07 File Offset: 0x00296007
	public void SetMaxItemText(string text)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(20), text, Array.Empty<object>());
	}

	// Token: 0x060088D5 RID: 35029 RVA: 0x00297E21 File Offset: 0x00296021
	public int GetCurrentCostCount()
	{
		return this.CurrentCostCount;
	}

	// Token: 0x04005242 RID: 21058
	[Nullable(2)]
	protected ButtonItem StrengthItem;

	// Token: 0x04005243 RID: 21059
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<ConsumeMediumItemGrid, TCommonMultipleConsumeData> ScrollView;

	// Token: 0x04005244 RID: 21060
	protected List<TCommonMultipleConsumeData> ConsumeList = new List<TCommonMultipleConsumeData>();

	// Token: 0x04005245 RID: 21061
	private int CurrentDropDownSelectIndex = 3;

	// Token: 0x04005246 RID: 21062
	protected int MaxCount;

	// Token: 0x04005247 RID: 21063
	protected bool EnoughMoney = true;

	// Token: 0x04005248 RID: 21064
	protected int CurrentCostCount;

	// Token: 0x04005249 RID: 21065
	protected string SelectTextId = "AutoSelect";

	// Token: 0x0400524A RID: 21066
	protected ERedDotName? SettingRedDotName;

	// Token: 0x0400524B RID: 21067
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, QualityInfo> CommonDropDown;

	// Token: 0x0400524C RID: 21068
	[Nullable(2)]
	private Action<int> DropDownCall;

	// Token: 0x0400524D RID: 21069
	private EItemGridConsumeLocalDropDown? CurrentDropDownKey;

	// Token: 0x0400524E RID: 21070
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x0400524F RID: 21071
	[Nullable(2)]
	private Action SettingBtnClickCallBack;

	// Token: 0x04005250 RID: 21072
	protected CommonMultipleConsumeFunction ConsumeFunction;

	// Token: 0x04005251 RID: 21073
	public EUiViewName? BelongView;

	// Token: 0x04005252 RID: 21074
	public bool NeedSettingComponent;

	// Token: 0x02006F89 RID: 28553
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040246FA RID: 149242
		AddMaterialText,
		// Token: 0x040246FB RID: 149243
		PanelButton,
		// Token: 0x040246FC RID: 149244
		DropDownItem,
		// Token: 0x040246FD RID: 149245
		AutoButton,
		// Token: 0x040246FE RID: 149246
		LoopItem,
		// Token: 0x040246FF RID: 149247
		ScrollView,
		// Token: 0x04024700 RID: 149248
		CostRootItem,
		// Token: 0x04024701 RID: 149249
		ConsumeTexture,
		// Token: 0x04024702 RID: 149250
		ConsumeText,
		// Token: 0x04024703 RID: 149251
		ConditionText,
		// Token: 0x04024704 RID: 149252
		MaterialRootItem,
		// Token: 0x04024705 RID: 149253
		StrengthItem,
		// Token: 0x04024706 RID: 149254
		MaxItem,
		// Token: 0x04024707 RID: 149255
		LockItem,
		// Token: 0x04024708 RID: 149256
		TopButtons,
		// Token: 0x04024709 RID: 149257
		AutoButtonText,
		// Token: 0x0402470A RID: 149258
		LockText,
		// Token: 0x0402470B RID: 149259
		LockTipButton,
		// Token: 0x0402470C RID: 149260
		SettingButton,
		// Token: 0x0402470D RID: 149261
		SettingButtonRedDotItem,
		// Token: 0x0402470E RID: 149262
		MaxItemText
	}
}
