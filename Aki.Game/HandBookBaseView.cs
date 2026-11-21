using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012A8 RID: 4776
[NullableContext(1)]
[Nullable(0)]
public abstract class HandBookBaseView : UiViewBase
{
	// Token: 0x0600BD12 RID: 48402 RVA: 0x0037E428 File Offset: 0x0037C628
	public HandBookBaseView(UiViewInfo viewInfo) : base(viewInfo)
	{
		this.TabList = new List<CommonTabData>();
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		this.PhantomFetterDataList = new List<PhantomFetter>();
		this.HandBookCommonTypeItemDataList = new List<List<HandBookCommonItemData>>();
		this.InfoTextList = new List<string>();
		this.ContentTextList = new List<HandBookContentItemData>();
		this.AttributeList = new List<CSharpScript.Game.Module.Common.AttributeData>();
		this.PhantomDataList = new List<HandBookCommonItemData>();
	}

	// Token: 0x0600BD13 RID: 48403 RVA: 0x0037E494 File Offset: 0x0037C694
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(17, typeof(UUIText)),
			new ValueTuple<int, Type>(18, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(19, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(23, typeof(UUIText)),
			new ValueTuple<int, Type>(24, typeof(UUIText)),
			new ValueTuple<int, Type>(25, typeof(UUITexture)),
			new ValueTuple<int, Type>(26, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(22, new Action(this.CloseClick))
		};
	}

	// Token: 0x0600BD14 RID: 48404 RVA: 0x0037E734 File Offset: 0x0037C934
	protected void SetDefaultState()
	{
		base.GetItem(0).SetUIActive(false);
		base.GetItem(1).SetUIActive(false);
		base.GetItem(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
		base.GetLoopScrollViewComponent(4).RootUIComp.Get().SetUIActive(false);
		base.GetItem(5).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
		base.GetScrollViewWithScrollbar(7).RootUIComp.Get().SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		base.GetText(9).SetUIActive(false);
		base.GetText(10).SetUIActive(false);
		base.GetText(11).SetUIActive(false);
		base.GetVerticalLayout(12).RootUIComp.Get().SetUIActive(false);
		base.GetItem(13).SetUIActive(false);
		base.GetHorizontalLayout(14).RootUIComp.Get().SetUIActive(false);
		base.GetItem(15).SetUIActive(false);
		base.GetVerticalLayout(16).RootUIComp.Get().SetUIActive(false);
		base.GetText(17).SetUIActive(false);
		base.GetVerticalLayout(18).RootUIComp.Get().SetUIActive(false);
		base.GetVerticalLayout(19).RootUIComp.Get().SetUIActive(false);
		base.GetTexture(25).SetUIActive(false);
		base.GetItem(26).SetUIActive(false);
	}

	// Token: 0x0600BD15 RID: 48405 RVA: 0x0037E8C8 File Offset: 0x0037CAC8
	protected void InitTabComponent(List<CommonTabData> tabList)
	{
		base.GetItem(26).SetUIActive(true);
		UUIItem item = base.GetItem(0);
		base.GetItem(1).SetUIActive(true);
		item.SetUIActive(true);
		if (this.TabComponent == null)
		{
			this.TabComponent = new TabComponent<CommonTabItem>(item, new Func<UUIItem, int?, CommonTabItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), null);
		}
		this.TabList = tabList;
		List<CommonTabItemData> tabItemData = this.GetTabItemData(this.TabList);
		this.TabComponent.RefreshTabItem(tabItemData, null);
		this.TabComponent.SelectToggleByIndex(0, false, true);
	}

	// Token: 0x0600BD16 RID: 48406
	public abstract List<CommonTabItemData> GetTabItemData(List<CommonTabData> tabData);

	// Token: 0x0600BD17 RID: 48407 RVA: 0x0037E95C File Offset: 0x0037CB5C
	protected void InitCommonTabTitle(string iconPath, CommonTabTitleData titleData)
	{
		UUIItem item = base.GetItem(2);
		item.SetUIActive(true);
		this.CommonTabTitle = new CommonTabTitle(item);
		this.CommonTabTitle.UpdateIcon(iconPath);
		this.CommonTabTitle.UpdateTitle(titleData);
	}

	// Token: 0x0600BD18 RID: 48408 RVA: 0x0037E99C File Offset: 0x0037CB9C
	protected void UpdateTitle(CommonTabTitleData titleData)
	{
		if (this.CommonTabTitle == null)
		{
			return;
		}
		this.CommonTabTitle.UpdateTitle(titleData);
	}

	// Token: 0x0600BD19 RID: 48409 RVA: 0x0037E9B3 File Offset: 0x0037CBB3
	public void SetTabToggleCallBack(Action<int> toggleCallBack)
	{
		this.OnToggleCallBack = toggleCallBack;
	}

	// Token: 0x0600BD1A RID: 48410 RVA: 0x0037E9BC File Offset: 0x0037CBBC
	protected virtual void OnPhantomToggleClick(HandBookCommonItemData handBookCommonItemData, int girdIndex)
	{
	}

	// Token: 0x0600BD1B RID: 48411 RVA: 0x0037E9BE File Offset: 0x0037CBBE
	private void ToggleCallBack(int index)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(index);
		}
	}

	// Token: 0x0600BD1C RID: 48412 RVA: 0x0037E9D4 File Offset: 0x0037CBD4
	protected virtual CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600BD1D RID: 48413 RVA: 0x0037E9DC File Offset: 0x0037CBDC
	public void InitScrollViewByCommonItem(List<HandBookCommonItemData> handBookCommonItemDataList)
	{
		this.HandBookCommonItemDataList = handBookCommonItemDataList;
		UUIItem item = base.GetItem(6);
		AUIBaseActor gridActor = item.GetOwner() as AUIBaseActor;
		item.SetUIActive(true);
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(4);
		loopScrollViewComponent.RootUIComp.Get().SetUIActive(true);
		if (this.ScrollViewFetter != null)
		{
			this.ScrollViewFetter.ClearGridProxies();
			this.ScrollViewFetter = null;
		}
		if (this.ScrollViewCommon == null)
		{
			this.ScrollViewCommon = new LoopScrollView<HandBookCommonItem, HandBookCommonItemData>(loopScrollViewComponent, gridActor, new Func<HandBookCommonItem>(this.InitHandBookCommonItem), false);
		}
		item.SetUIActive(false);
		this.ScrollViewCommon.ClearGridProxies();
		this.ScrollViewCommon.DeselectCurrentGridProxy(false);
		this.ScrollViewCommon.ReloadProxyData(new Func<int, HandBookCommonItemData>(this.GetHandBookCommonItemData), this.HandBookCommonItemDataList.Count, false, false);
		this.ScrollViewCommon.RefreshAllGridProxies();
		if (this.ScrollViewCommon.StartGridIndex != -1)
		{
			this.ScrollViewCommon.ScrollToGridIndex(0, true);
			this.ScrollViewCommon.SelectGridProxy(0, true);
		}
	}

	// Token: 0x0600BD1E RID: 48414 RVA: 0x0037EAD8 File Offset: 0x0037CCD8
	public void InitScrollViewByFetterItem(List<PhantomFetter> phantomFetterDataList)
	{
		this.PhantomFetterDataList = phantomFetterDataList;
		UUIItem item = base.GetItem(5);
		AUIBaseActor gridActor = item.GetOwner() as AUIBaseActor;
		item.SetUIActive(true);
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(4);
		loopScrollViewComponent.RootUIComp.Get().SetUIActive(true);
		if (this.ScrollViewCommon != null)
		{
			this.ScrollViewCommon.ClearGridProxies();
			this.ScrollViewCommon = null;
		}
		if (this.ScrollViewFetter == null)
		{
			this.ScrollViewFetter = new LoopScrollView<HandBookFetterItem, PhantomFetter>(loopScrollViewComponent, gridActor, new Func<HandBookFetterItem>(this.InitHandBookFetterItem), false);
		}
		item.SetUIActive(false);
		this.ScrollViewFetter.ClearGridProxies();
		this.ScrollViewFetter.ReloadProxyData(new Func<int, PhantomFetter>(this.GetPhantomFetterData), this.PhantomFetterDataList.Count, false, false);
		this.ScrollViewFetter.RefreshAllGridProxies();
	}

	// Token: 0x0600BD1F RID: 48415 RVA: 0x0037EBA0 File Offset: 0x0037CDA0
	public void InitScrollViewByCommonTypeItem(List<List<HandBookCommonItemData>> handBookCommonTypeItemDataList)
	{
		this.HandBookCommonTypeItemDataList = handBookCommonTypeItemDataList;
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(7);
		scrollViewWithScrollbar.RootUIComp.Get().SetUIActive(true);
		if (this.ScrollViewCommonType == null)
		{
			this.ScrollViewCommonType = new GenericScrollView<HandBookCommonTypeItem>(scrollViewWithScrollbar, new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookCommonTypeItem>(this.InitHandBookCommonTypeItem), null);
		}
		this.ScrollViewCommonType.RefreshByData<List<HandBookCommonItemData>>(this.HandBookCommonTypeItemDataList, null);
	}

	// Token: 0x0600BD20 RID: 48416 RVA: 0x0037EC0B File Offset: 0x0037CE0B
	protected virtual HandBookCommonItem InitHandBookCommonItem()
	{
		return new HandBookCommonItem();
	}

	// Token: 0x0600BD21 RID: 48417 RVA: 0x0037EC12 File Offset: 0x0037CE12
	protected virtual HandBookFetterItem InitHandBookFetterItem()
	{
		return new HandBookFetterItem();
	}

	// Token: 0x0600BD22 RID: 48418 RVA: 0x0037EC1C File Offset: 0x0037CE1C
	protected ILayoutItem<HandBookCommonTypeItem> InitHandBookCommonTypeItem(object data, UUIItem uiItem, int index)
	{
		HandBookCommonTypeItem handBookCommonTypeItem = new HandBookCommonTypeItem();
		handBookCommonTypeItem.Initialize(null);
		return new LayoutItem<HandBookCommonTypeItem>
		{
			Key = index,
			Value = handBookCommonTypeItem
		};
	}

	// Token: 0x0600BD23 RID: 48419 RVA: 0x0037EC4E File Offset: 0x0037CE4E
	private PhantomFetter GetPhantomFetterData(int gridIndex)
	{
		return this.PhantomFetterDataList[gridIndex];
	}

	// Token: 0x0600BD24 RID: 48420 RVA: 0x0037EC5C File Offset: 0x0037CE5C
	private HandBookCommonItemData GetHandBookCommonItemData(int gridIndex)
	{
		return this.HandBookCommonItemDataList[gridIndex];
	}

	// Token: 0x0600BD25 RID: 48421 RVA: 0x0037EC6A File Offset: 0x0037CE6A
	protected void SetNameText(string name)
	{
		UUIText text = base.GetText(9);
		text.SetUIActive(true);
		text.SetText(name, true);
	}

	// Token: 0x0600BD26 RID: 48422 RVA: 0x0037EC82 File Offset: 0x0037CE82
	protected void SetTypeText(string type)
	{
		UUIText text = base.GetText(10);
		text.SetUIActive(true);
		text.SetText(type, true);
	}

	// Token: 0x0600BD27 RID: 48423 RVA: 0x0037EC9A File Offset: 0x0037CE9A
	protected void SetDescribeText(string describe)
	{
		UUIText text = base.GetText(11);
		text.SetUIActive(true);
		text.SetText(describe, true);
	}

	// Token: 0x0600BD28 RID: 48424 RVA: 0x0037ECB4 File Offset: 0x0037CEB4
	protected void InitInfoItemLayout(List<string> infoList)
	{
		this.InfoTextList = infoList;
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(12);
		verticalLayout.RootUIComp.Get().SetUIActive(true);
		if (this.InfoItemLayout == null)
		{
			UUILayoutBase layout = verticalLayout;
			CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookInfoTextItem> refreshFunction;
			if ((refreshFunction = HandBookBaseView.<>O.<0>__InitInfoItem) == null)
			{
				refreshFunction = (HandBookBaseView.<>O.<0>__InitInfoItem = new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookInfoTextItem>(HandBookBaseViewHelper.InitInfoItem));
			}
			this.InfoItemLayout = new GenericLayoutNew<HandBookInfoTextItem>(layout, refreshFunction, null);
		}
		this.InfoItemLayout.RebuildLayoutByDataNew<string>(this.InfoTextList, null);
	}

	// Token: 0x0600BD29 RID: 48425 RVA: 0x0037ED30 File Offset: 0x0037CF30
	protected void InitStarItemLayout(int starCount)
	{
		this.StarCount = starCount;
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(14);
		horizontalLayout.RootUIComp.Get().SetUIActive(true);
		if (this.StarItemLayout == null)
		{
			this.StarItemLayout = new GenericLayoutNew<UiPanelBase>(horizontalLayout, null, null);
		}
		this.StarItemLayout.RebuildLayoutByDataNew<int>(null, new int?(this.StarCount));
	}

	// Token: 0x0600BD2A RID: 48426 RVA: 0x0037ED90 File Offset: 0x0037CF90
	protected void InitContentItemLayout(List<HandBookContentItemData> contentTextList)
	{
		this.ContentTextList = contentTextList;
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(16);
		verticalLayout.RootUIComp.Get().SetUIActive(true);
		if (this.ContentItemLayout == null)
		{
			UUILayoutBase layout = verticalLayout;
			CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookContentItem> refreshFunction;
			if ((refreshFunction = HandBookBaseView.<>O.<1>__InitContentItem) == null)
			{
				refreshFunction = (HandBookBaseView.<>O.<1>__InitContentItem = new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookContentItem>(HandBookBaseViewHelper.InitContentItem));
			}
			this.ContentItemLayout = new GenericLayoutNew<HandBookContentItem>(layout, refreshFunction, null);
		}
		this.ContentItemLayout.RebuildLayoutByDataNew<HandBookContentItemData>(this.ContentTextList, null);
	}

	// Token: 0x0600BD2B RID: 48427 RVA: 0x0037EE0C File Offset: 0x0037D00C
	protected void InitAttributeLayout(List<CSharpScript.Game.Module.Common.AttributeData> attributeList)
	{
		base.GetVerticalLayout(19).RootUIComp.Get().SetUIActive(true);
		this.AttributeList = attributeList;
		this.AttributeLayout.RefreshByData(this.AttributeList, null, false);
	}

	// Token: 0x0600BD2C RID: 48428 RVA: 0x0037EE50 File Offset: 0x0037D050
	protected void InitHandBookPhantomLayout(List<HandBookCommonItemData> handBookCommonItemData)
	{
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(18);
		verticalLayout.RootUIComp.Get().SetUIActive(true);
		this.PhantomDataList = handBookCommonItemData;
		if (this.HandBookPhantomLayout == null)
		{
			this.HandBookPhantomLayout = new GenericLayoutNew<HandBookPhantomItem>(verticalLayout, new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookPhantomItem>(this.InitHandBookPhantom), null);
		}
		this.HandBookPhantomLayout.RebuildLayoutByDataNew<HandBookCommonItemData>(this.PhantomDataList, null);
	}

	// Token: 0x0600BD2D RID: 48429 RVA: 0x0037EEC0 File Offset: 0x0037D0C0
	protected virtual ILayoutItem<HandBookPhantomItem> InitHandBookPhantom(object data, UUIItem uiItem, int index)
	{
		HandBookPhantomItem handBookPhantomItem = new HandBookPhantomItem();
		handBookPhantomItem.Initialize((HandBookCommonItemData)data, uiItem);
		handBookPhantomItem.BindToggleCallback(new THandBookPhantomItemToggleFunction(this.OnPhantomToggleClick));
		return new LayoutItem<HandBookPhantomItem>
		{
			Key = index,
			Value = handBookPhantomItem
		};
	}

	// Token: 0x0600BD2E RID: 48430 RVA: 0x0037EF0C File Offset: 0x0037D10C
	protected void SetDateText(string time)
	{
		UUIText text = base.GetText(17);
		text.SetUIActive(true);
		LguiUtil.Instance.SetLocalText(text, "HandBookGet", new <>z__ReadOnlySingleElementList<object>(time));
	}

	// Token: 0x0600BD2F RID: 48431 RVA: 0x0037EF40 File Offset: 0x0037D140
	protected void SetCollectText(int curCount, int totalCount)
	{
		base.GetText(23).SetUIActive(true);
		LguiUtil.Instance.SetLocalText(base.GetText(23), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			curCount,
			totalCount
		}));
	}

	// Token: 0x0600BD30 RID: 48432 RVA: 0x0037EF8F File Offset: 0x0037D18F
	protected void SetOwnText(int count)
	{
		base.GetText(17).SetUIActive(true);
		LguiUtil.Instance.SetLocalText(base.GetText(17), "HandBookItemHaveNum", new <>z__ReadOnlySingleElementList<object>(count));
	}

	// Token: 0x0600BD31 RID: 48433 RVA: 0x0037EFC1 File Offset: 0x0037D1C1
	protected void SetKillText(int count)
	{
		base.GetText(17).SetUIActive(true);
		LguiUtil.Instance.SetLocalText(base.GetText(17), "KillCount", new <>z__ReadOnlySingleElementList<object>(count));
	}

	// Token: 0x0600BD32 RID: 48434 RVA: 0x0037EFF3 File Offset: 0x0037D1F3
	protected void SetLockState(bool isLock)
	{
		base.GetItem(21).SetUIActive(isLock);
		base.GetItem(20).SetUIActive(!isLock);
	}

	// Token: 0x0600BD33 RID: 48435 RVA: 0x0037F014 File Offset: 0x0037D214
	protected void SetLockText(string lockDesc)
	{
		base.GetText(24).SetText(lockDesc, true);
	}

	// Token: 0x0600BD34 RID: 48436 RVA: 0x0037F028 File Offset: 0x0037D228
	protected void SetItemTexture(string path)
	{
		UUITexture texture = base.GetTexture(25);
		texture.SetUIActive(true);
		base.SetTextureByPath(path, texture, null, null);
	}

	// Token: 0x0600BD35 RID: 48437 RVA: 0x0037F057 File Offset: 0x0037D257
	protected override void OnStart()
	{
	}

	// Token: 0x0600BD36 RID: 48438 RVA: 0x0037F059 File Offset: 0x0037D259
	protected override void OnAfterShow()
	{
	}

	// Token: 0x0600BD37 RID: 48439 RVA: 0x0037F05B File Offset: 0x0037D25B
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600BD38 RID: 48440 RVA: 0x0037F064 File Offset: 0x0037D264
	protected override void OnBeforeDestroy()
	{
		if (this.ScrollViewCommon != null)
		{
			this.ScrollViewCommon.ClearGridProxies();
			this.ScrollViewCommon = null;
		}
		if (this.ScrollViewFetter != null)
		{
			this.ScrollViewFetter.ClearGridProxies();
			this.ScrollViewFetter = null;
		}
		if (this.ScrollViewCommonType != null)
		{
			this.ScrollViewCommonType.ClearChildren();
			this.ScrollViewCommonType = null;
		}
		if (this.InfoItemLayout != null)
		{
			this.InfoItemLayout.ClearChildren();
			this.InfoItemLayout = null;
		}
		if (this.ContentItemLayout != null)
		{
			this.ContentItemLayout.ClearChildren();
			this.ContentItemLayout = null;
		}
		if (this.StarItemLayout != null)
		{
			this.StarItemLayout.ClearChildren();
			this.StarItemLayout = null;
		}
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
		if (this.HandBookPhantomLayout != null)
		{
			this.HandBookPhantomLayout.ClearChildren();
			this.HandBookPhantomLayout = null;
		}
		this.TabList = new List<CommonTabData>();
		this.OnToggleCallBack = null;
		this.OnPhantomToggleCallBack = null;
		this.CommonTabTitle = null;
		this.HandBookCommonItemDataList = new List<HandBookCommonItemData>();
		this.PhantomFetterDataList = new List<PhantomFetter>();
		this.HandBookCommonTypeItemDataList = new List<List<HandBookCommonItemData>>();
		this.InfoTextList = new List<string>();
		this.ContentTextList = new List<HandBookContentItemData>();
		this.AttributeList = new List<CSharpScript.Game.Module.Common.AttributeData>();
		this.PhantomDataList = new List<HandBookCommonItemData>();
		this.StarCount = 0;
	}

	// Token: 0x04006CD8 RID: 27864
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<CommonTabItem> TabComponent;

	// Token: 0x04006CD9 RID: 27865
	protected List<CommonTabData> TabList;

	// Token: 0x04006CDA RID: 27866
	[Nullable(2)]
	protected Action<int> OnToggleCallBack;

	// Token: 0x04006CDB RID: 27867
	[Nullable(2)]
	protected Action<PhantomItem> OnPhantomToggleCallBack;

	// Token: 0x04006CDC RID: 27868
	[Nullable(2)]
	protected CommonTabTitle CommonTabTitle;

	// Token: 0x04006CDD RID: 27869
	protected List<HandBookCommonItemData> HandBookCommonItemDataList;

	// Token: 0x04006CDE RID: 27870
	protected List<PhantomFetter> PhantomFetterDataList;

	// Token: 0x04006CDF RID: 27871
	protected List<List<HandBookCommonItemData>> HandBookCommonTypeItemDataList;

	// Token: 0x04006CE0 RID: 27872
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<HandBookCommonItem, HandBookCommonItemData> ScrollViewCommon;

	// Token: 0x04006CE1 RID: 27873
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected LoopScrollView<HandBookFetterItem, PhantomFetter> ScrollViewFetter;

	// Token: 0x04006CE2 RID: 27874
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<HandBookCommonTypeItem> ScrollViewCommonType;

	// Token: 0x04006CE3 RID: 27875
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<HandBookInfoTextItem> InfoItemLayout;

	// Token: 0x04006CE4 RID: 27876
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<HandBookContentItem> ContentItemLayout;

	// Token: 0x04006CE5 RID: 27877
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<UiPanelBase> StarItemLayout;

	// Token: 0x04006CE6 RID: 27878
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<HandBookPhantomItem> HandBookPhantomLayout;

	// Token: 0x04006CE7 RID: 27879
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x04006CE8 RID: 27880
	protected List<string> InfoTextList;

	// Token: 0x04006CE9 RID: 27881
	protected List<HandBookContentItemData> ContentTextList;

	// Token: 0x04006CEA RID: 27882
	protected List<CSharpScript.Game.Module.Common.AttributeData> AttributeList;

	// Token: 0x04006CEB RID: 27883
	protected List<HandBookCommonItemData> PhantomDataList;

	// Token: 0x04006CEC RID: 27884
	protected int StarCount;

	// Token: 0x02007540 RID: 30016
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04026182 RID: 156034
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookInfoTextItem> <0>__InitInfoItem;

		// Token: 0x04026183 RID: 156035
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookContentItem> <1>__InitContentItem;
	}
}
