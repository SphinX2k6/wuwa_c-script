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

// Token: 0x02001818 RID: 6168
[NullableContext(1)]
[Nullable(0)]
public class ItemGridConsumeComponent : UiPanelBase
{
	// Token: 0x0600B4C5 RID: 46277 RVA: 0x0028CE18 File Offset: 0x0028B018
	public ItemGridConsumeComponent(UUIItem uiItem, CommonMultipleConsumeFunction consumeFunction, EUiViewName? belongView = null, bool needSettingComponent = false)
	{
		this.SourceItem = uiItem;
		this.ConsumeFunction = consumeFunction;
		this.BelongView = belongView;
		this.NeedSettingComponent = needSettingComponent;
	}

	// Token: 0x0600B4C6 RID: 46278 RVA: 0x0028CE6C File Offset: 0x0028B06C
	public UniTask Init()
	{
		ItemGridConsumeComponent.<Init>d__19 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ItemGridConsumeComponent.<Init>d__19>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600B4C7 RID: 46279 RVA: 0x0028CEB0 File Offset: 0x0028B0B0
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

	// Token: 0x0600B4C8 RID: 46280 RVA: 0x0028D099 File Offset: 0x0028B299
	private OneTextDropDownItem CreateDropDownItem(UUIItem uiItem, QualityInfo data)
	{
		return new OneTextDropDownItem(uiItem);
	}

	// Token: 0x0600B4C9 RID: 46281 RVA: 0x0028D0A1 File Offset: 0x0028B2A1
	private OneTextTitleItem CreateTitleItem(UUIItem uiItem)
	{
		return new OneTextTitleItem(uiItem);
	}

	// Token: 0x0600B4CA RID: 46282 RVA: 0x0028D0AC File Offset: 0x0028B2AC
	protected override UniTask OnBeforeStartAsync()
	{
		ItemGridConsumeComponent.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ItemGridConsumeComponent.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B4CB RID: 46283 RVA: 0x0028D0F0 File Offset: 0x0028B2F0
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

	// Token: 0x0600B4CC RID: 46284 RVA: 0x0028D199 File Offset: 0x0028B399
	private TableTextArgNew GetDropDownTextId(QualityInfo data)
	{
		return new TableTextArgNew(data.ConsumeFilterText, Array.Empty<object>());
	}

	// Token: 0x0600B4CD RID: 46285 RVA: 0x0028D1AC File Offset: 0x0028B3AC
	public bool HasSelect()
	{
		return this.GetSelectedGridCount() > 0;
	}

	// Token: 0x0600B4CE RID: 46286 RVA: 0x0028D1B8 File Offset: 0x0028B3B8
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

	// Token: 0x0600B4CF RID: 46287 RVA: 0x0028D234 File Offset: 0x0028B434
	private void RefreshAutoSelectText()
	{
		if (this.HasSelect())
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "DeleteSelect", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), this.SelectTextId, Array.Empty<object>());
	}

	// Token: 0x0600B4D0 RID: 46288 RVA: 0x0028D283 File Offset: 0x0028B483
	public void UpdateAutoSelectTextByTextId(string textId)
	{
		this.SelectTextId = textId;
		this.RefreshAutoSelectText();
	}

	// Token: 0x0600B4D1 RID: 46289 RVA: 0x0028D294 File Offset: 0x0028B494
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

	// Token: 0x0600B4D2 RID: 46290 RVA: 0x0028D2E2 File Offset: 0x0028B4E2
	private void OnSettingBtnClick()
	{
		Action settingBtnClickCallBack = this.SettingBtnClickCallBack;
		if (settingBtnClickCallBack == null)
		{
			return;
		}
		settingBtnClickCallBack();
	}

	// Token: 0x0600B4D3 RID: 46291 RVA: 0x0028D2F4 File Offset: 0x0028B4F4
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

	// Token: 0x0600B4D4 RID: 46292 RVA: 0x0028D374 File Offset: 0x0028B574
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

	// Token: 0x0600B4D5 RID: 46293 RVA: 0x0028D3C6 File Offset: 0x0028B5C6
	public int GetCurrentDropDownSelectIndex()
	{
		return this.CurrentDropDownSelectIndex;
	}

	// Token: 0x0600B4D6 RID: 46294 RVA: 0x0028D3D0 File Offset: 0x0028B5D0
	private ConsumeMediumItemGrid InitItem()
	{
		ConsumeMediumItemGrid consumeMediumItemGrid = new ConsumeMediumItemGrid();
		this.BindItemEvents(consumeMediumItemGrid);
		return consumeMediumItemGrid;
	}

	// Token: 0x0600B4D7 RID: 46295 RVA: 0x0028D3EC File Offset: 0x0028B5EC
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

	// Token: 0x0600B4D8 RID: 46296 RVA: 0x0028D454 File Offset: 0x0028B654
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

	// Token: 0x0600B4D9 RID: 46297 RVA: 0x0028D4BC File Offset: 0x0028B6BC
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

	// Token: 0x0600B4DA RID: 46298 RVA: 0x0028D576 File Offset: 0x0028B776
	public void SetMaxState(bool inMax)
	{
		this.SetCostRootItemState(!inMax);
		this.SetStrengthItemEnable(!inMax);
		this.SetMaxItemEnable(inMax);
		this.SetMaterialRootItemEnable(!inMax);
	}

	// Token: 0x0600B4DB RID: 46299 RVA: 0x0028D59D File Offset: 0x0028B79D
	public void SetCostRootItemState(bool state)
	{
		base.GetItem(6).SetUIActive(state);
	}

	// Token: 0x0600B4DC RID: 46300 RVA: 0x0028D5AC File Offset: 0x0028B7AC
	public void SetStrengthItemText(string text)
	{
		this.StrengthItem.SetLocalTextNew(text, Array.Empty<object>());
	}

	// Token: 0x0600B4DD RID: 46301 RVA: 0x0028D5BF File Offset: 0x0028B7BF
	public void SetStrengthItemEnable(bool state)
	{
		this.StrengthItem.SetEnableClick(state);
		this.StrengthItem.SetActive(state);
	}

	// Token: 0x0600B4DE RID: 46302 RVA: 0x0028D5D9 File Offset: 0x0028B7D9
	public void SetMaxItemEnable(bool state)
	{
		base.GetItem(12).SetUIActive(state);
	}

	// Token: 0x0600B4DF RID: 46303 RVA: 0x0028D5E9 File Offset: 0x0028B7E9
	public void SetMaterialRootItemEnable(bool state)
	{
		base.GetItem(10).SetUIActive(state);
	}

	// Token: 0x0600B4E0 RID: 46304 RVA: 0x0028D5FC File Offset: 0x0028B7FC
	public void SetConsumeListEnable(bool state)
	{
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(5);
		if (scrollViewWithScrollbar == null)
		{
			return;
		}
		scrollViewWithScrollbar.RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x0600B4E1 RID: 46305 RVA: 0x0028D628 File Offset: 0x0028B828
	public bool GetEnoughMoney()
	{
		return this.EnoughMoney;
	}

	// Token: 0x0600B4E2 RID: 46306 RVA: 0x0028D630 File Offset: 0x0028B830
	public void SetMaxCount(int count)
	{
		this.MaxCount = count;
	}

	// Token: 0x0600B4E3 RID: 46307 RVA: 0x0028D639 File Offset: 0x0028B839
	public int GetMaxCount()
	{
		return this.MaxCount;
	}

	// Token: 0x0600B4E4 RID: 46308 RVA: 0x0028D641 File Offset: 0x0028B841
	public void RefreshConditionText(string str)
	{
		base.GetText(9).ShowTextNew(str);
	}

	// Token: 0x0600B4E5 RID: 46309 RVA: 0x0028D654 File Offset: 0x0028B854
	public void SetConsumeTexture(int itemId)
	{
		base.SetItemIcon(base.GetTexture(7), itemId, null, null);
	}

	// Token: 0x0600B4E6 RID: 46310 RVA: 0x0028D67C File Offset: 0x0028B87C
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

	// Token: 0x0600B4E7 RID: 46311 RVA: 0x0028D6B2 File Offset: 0x0028B8B2
	public void SetSettingButtonClickCallBack(Action callBack)
	{
		this.SettingBtnClickCallBack = callBack;
	}

	// Token: 0x0600B4E8 RID: 46312 RVA: 0x0028D6BB File Offset: 0x0028B8BB
	public void BindSettingButtonRedDot(ERedDotName name)
	{
		if (!this.NeedSettingComponent)
		{
			return;
		}
		this.SettingRedDotName = new ERedDotName?(name);
		RedDotController.Instance.BindRedDot(name, base.GetItem(19), null, 0);
	}

	// Token: 0x0600B4E9 RID: 46313 RVA: 0x0028D6E7 File Offset: 0x0028B8E7
	public void SetMaxItemText(string text)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(20), text, Array.Empty<object>());
	}

	// Token: 0x0600B4EA RID: 46314 RVA: 0x0028D701 File Offset: 0x0028B901
	public int GetCurrentCostCount()
	{
		return this.CurrentCostCount;
	}

	// Token: 0x04005197 RID: 20887
	[Nullable(2)]
	protected ButtonItem StrengthItem;

	// Token: 0x04005198 RID: 20888
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollViewNew<ConsumeMediumItemGrid, TCommonMultipleConsumeData> ScrollView;

	// Token: 0x04005199 RID: 20889
	protected List<TCommonMultipleConsumeData> ConsumeList = new List<TCommonMultipleConsumeData>();

	// Token: 0x0400519A RID: 20890
	private int CurrentDropDownSelectIndex = 3;

	// Token: 0x0400519B RID: 20891
	protected int MaxCount;

	// Token: 0x0400519C RID: 20892
	protected bool EnoughMoney = true;

	// Token: 0x0400519D RID: 20893
	protected int CurrentCostCount;

	// Token: 0x0400519E RID: 20894
	protected string SelectTextId = "AutoSelect";

	// Token: 0x0400519F RID: 20895
	protected ERedDotName? SettingRedDotName;

	// Token: 0x040051A0 RID: 20896
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, QualityInfo> CommonDropDown;

	// Token: 0x040051A1 RID: 20897
	[Nullable(2)]
	private Action<int> DropDownCall;

	// Token: 0x040051A2 RID: 20898
	private EItemGridConsumeLocalDropDown? CurrentDropDownKey;

	// Token: 0x040051A3 RID: 20899
	[Nullable(2)]
	private readonly UUIItem SourceItem;

	// Token: 0x040051A4 RID: 20900
	[Nullable(2)]
	private Action SettingBtnClickCallBack;

	// Token: 0x040051A5 RID: 20901
	protected CommonMultipleConsumeFunction ConsumeFunction;

	// Token: 0x040051A6 RID: 20902
	public EUiViewName? BelongView;

	// Token: 0x040051A7 RID: 20903
	public bool NeedSettingComponent;

	// Token: 0x02007E03 RID: 32259
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040293CF RID: 168911
		AddMaterialText,
		// Token: 0x040293D0 RID: 168912
		PanelButton,
		// Token: 0x040293D1 RID: 168913
		DropDownItem,
		// Token: 0x040293D2 RID: 168914
		AutoButton,
		// Token: 0x040293D3 RID: 168915
		LoopItem,
		// Token: 0x040293D4 RID: 168916
		ScrollView,
		// Token: 0x040293D5 RID: 168917
		CostRootItem,
		// Token: 0x040293D6 RID: 168918
		ConsumeTexture,
		// Token: 0x040293D7 RID: 168919
		ConsumeText,
		// Token: 0x040293D8 RID: 168920
		ConditionText,
		// Token: 0x040293D9 RID: 168921
		MaterialRootItem,
		// Token: 0x040293DA RID: 168922
		StrengthItem,
		// Token: 0x040293DB RID: 168923
		MaxItem,
		// Token: 0x040293DC RID: 168924
		LockItem,
		// Token: 0x040293DD RID: 168925
		TopButtons,
		// Token: 0x040293DE RID: 168926
		AutoButtonText,
		// Token: 0x040293DF RID: 168927
		LockText,
		// Token: 0x040293E0 RID: 168928
		LockTipButton,
		// Token: 0x040293E1 RID: 168929
		SettingButton,
		// Token: 0x040293E2 RID: 168930
		SettingButtonRedDotItem,
		// Token: 0x040293E3 RID: 168931
		MaxItemText
	}
}
