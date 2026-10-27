using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DE6 RID: 7654
[NullableContext(1)]
[Nullable(0)]
public abstract class HandBookBaseView : UiViewBase
{
	// Token: 0x0600E8F3 RID: 59635 RVA: 0x00372720 File Offset: 0x00370920
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

	// Token: 0x0600E8F4 RID: 59636 RVA: 0x0037278C File Offset: 0x0037098C
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

	// Token: 0x0600E8F5 RID: 59637 RVA: 0x00372A2C File Offset: 0x00370C2C
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

	// Token: 0x0600E8F6 RID: 59638 RVA: 0x00372BC0 File Offset: 0x00370DC0
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

	// Token: 0x0600E8F7 RID: 59639
	public abstract List<CommonTabItemData> GetTabItemData(List<CommonTabData> tabData);

	// Token: 0x0600E8F8 RID: 59640 RVA: 0x00372C54 File Offset: 0x00370E54
	protected void InitCommonTabTitle(string iconPath, CommonTabTitleData titleData)
	{
		UUIItem item = base.GetItem(2);
		item.SetUIActive(true);
		this.CommonTabTitle = new CommonTabTitle(item);
		this.CommonTabTitle.UpdateIcon(iconPath);
		this.CommonTabTitle.UpdateTitle(titleData);
	}

	// Token: 0x0600E8F9 RID: 59641 RVA: 0x00372C94 File Offset: 0x00370E94
	protected void UpdateTitle(CommonTabTitleData titleData)
	{
		if (this.CommonTabTitle == null)
		{
			return;
		}
		this.CommonTabTitle.UpdateTitle(titleData);
	}

	// Token: 0x0600E8FA RID: 59642 RVA: 0x00372CAB File Offset: 0x00370EAB
	public void SetTabToggleCallBack(Action<int> toggleCallBack)
	{
		this.OnToggleCallBack = toggleCallBack;
	}

	// Token: 0x0600E8FB RID: 59643 RVA: 0x00372CB4 File Offset: 0x00370EB4
	protected virtual void OnPhantomToggleClick(HandBookCommonItemData handBookCommonItemData, int girdIndex)
	{
	}

	// Token: 0x0600E8FC RID: 59644 RVA: 0x00372CB6 File Offset: 0x00370EB6
	private void ToggleCallBack(int index)
	{
		if (this.OnToggleCallBack != null)
		{
			this.OnToggleCallBack(index);
		}
	}

	// Token: 0x0600E8FD RID: 59645 RVA: 0x00372CCC File Offset: 0x00370ECC
	protected virtual CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new CommonTabItem();
	}

	// Token: 0x0600E8FE RID: 59646 RVA: 0x00372CD4 File Offset: 0x00370ED4
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

	// Token: 0x0600E8FF RID: 59647 RVA: 0x00372DD0 File Offset: 0x00370FD0
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

	// Token: 0x0600E900 RID: 59648 RVA: 0x00372E98 File Offset: 0x00371098
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

	// Token: 0x0600E901 RID: 59649 RVA: 0x00372F03 File Offset: 0x00371103
	protected virtual HandBookCommonItem InitHandBookCommonItem()
	{
		return new HandBookCommonItem();
	}

	// Token: 0x0600E902 RID: 59650 RVA: 0x00372F0A File Offset: 0x0037110A
	protected virtual HandBookFetterItem InitHandBookFetterItem()
	{
		return new HandBookFetterItem();
	}

	// Token: 0x0600E903 RID: 59651 RVA: 0x00372F14 File Offset: 0x00371114
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

	// Token: 0x0600E904 RID: 59652 RVA: 0x00372F46 File Offset: 0x00371146
	private PhantomFetter GetPhantomFetterData(int gridIndex)
	{
		return this.PhantomFetterDataList[gridIndex];
	}

	// Token: 0x0600E905 RID: 59653 RVA: 0x00372F54 File Offset: 0x00371154
	private HandBookCommonItemData GetHandBookCommonItemData(int gridIndex)
	{
		return this.HandBookCommonItemDataList[gridIndex];
	}

	// Token: 0x0600E906 RID: 59654 RVA: 0x00372F62 File Offset: 0x00371162
	protected void SetNameText(string name)
	{
		UUIText text = base.GetText(9);
		text.SetUIActive(true);
		text.SetText(name, true);
	}

	// Token: 0x0600E907 RID: 59655 RVA: 0x00372F7A File Offset: 0x0037117A
	protected void SetTypeText(string type)
	{
		UUIText text = base.GetText(10);
		text.SetUIActive(true);
		text.SetText(type, true);
	}

	// Token: 0x0600E908 RID: 59656 RVA: 0x00372F92 File Offset: 0x00371192
	protected void SetDescribeText(string describe)
	{
		UUIText text = base.GetText(11);
		text.SetUIActive(true);
		text.SetText(describe, true);
	}

	// Token: 0x0600E909 RID: 59657 RVA: 0x00372FAC File Offset: 0x003711AC
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

	// Token: 0x0600E90A RID: 59658 RVA: 0x00373028 File Offset: 0x00371228
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

	// Token: 0x0600E90B RID: 59659 RVA: 0x00373088 File Offset: 0x00371288
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

	// Token: 0x0600E90C RID: 59660 RVA: 0x00373104 File Offset: 0x00371304
	protected void InitAttributeLayout(List<CSharpScript.Game.Module.Common.AttributeData> attributeList)
	{
		base.GetVerticalLayout(19).RootUIComp.Get().SetUIActive(true);
		this.AttributeList = attributeList;
		this.AttributeLayout.RefreshByData(this.AttributeList, null, false);
	}

	// Token: 0x0600E90D RID: 59661 RVA: 0x00373148 File Offset: 0x00371348
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

	// Token: 0x0600E90E RID: 59662 RVA: 0x003731B8 File Offset: 0x003713B8
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

	// Token: 0x0600E90F RID: 59663 RVA: 0x00373204 File Offset: 0x00371404
	protected void SetDateText(string time)
	{
		UUIText text = base.GetText(17);
		text.SetUIActive(true);
		LguiUtil.Instance.SetLocalText(text, "HandBookGet", new <>z__ReadOnlySingleElementList<object>(time));
	}

	// Token: 0x0600E910 RID: 59664 RVA: 0x00373238 File Offset: 0x00371438
	protected void SetCollectText(int curCount, int totalCount)
	{
		base.GetText(23).SetUIActive(true);
		LguiUtil.Instance.SetLocalText(base.GetText(23), "RoleExp", new <>z__ReadOnlyArray<object>(new object[]
		{
			curCount,
			totalCount
		}));
	}

	// Token: 0x0600E911 RID: 59665 RVA: 0x00373287 File Offset: 0x00371487
	protected void SetOwnText(int count)
	{
		base.GetText(17).SetUIActive(true);
		LguiUtil.Instance.SetLocalText(base.GetText(17), "HandBookItemHaveNum", new <>z__ReadOnlySingleElementList<object>(count));
	}

	// Token: 0x0600E912 RID: 59666 RVA: 0x003732B9 File Offset: 0x003714B9
	protected void SetKillText(int count)
	{
		base.GetText(17).SetUIActive(true);
		LguiUtil.Instance.SetLocalText(base.GetText(17), "KillCount", new <>z__ReadOnlySingleElementList<object>(count));
	}

	// Token: 0x0600E913 RID: 59667 RVA: 0x003732EB File Offset: 0x003714EB
	protected void SetLockState(bool isLock)
	{
		base.GetItem(21).SetUIActive(isLock);
		base.GetItem(20).SetUIActive(!isLock);
	}

	// Token: 0x0600E914 RID: 59668 RVA: 0x0037330C File Offset: 0x0037150C
	protected void SetLockText(string lockDesc)
	{
		base.GetText(24).SetText(lockDesc, true);
	}

	// Token: 0x0600E915 RID: 59669 RVA: 0x00373320 File Offset: 0x00371520
	protected void SetItemTexture(string path)
	{
		UUITexture texture = base.GetTexture(25);
		texture.SetUIActive(true);
		base.SetTextureByPath(path, texture, null, null);
	}

	// Token: 0x0600E916 RID: 59670 RVA: 0x0037334F File Offset: 0x0037154F
	protected override void OnStart()
	{
	}

	// Token: 0x0600E917 RID: 59671 RVA: 0x00373351 File Offset: 0x00371551
	protected override void OnAfterShow()
	{
	}

	// Token: 0x0600E918 RID: 59672 RVA: 0x00373353 File Offset: 0x00371553
	protected void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600E919 RID: 59673 RVA: 0x0037335C File Offset: 0x0037155C
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

	// Token: 0x04006BF7 RID: 27639
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<CommonTabItem> TabComponent;

	// Token: 0x04006BF8 RID: 27640
	protected List<CommonTabData> TabList;

	// Token: 0x04006BF9 RID: 27641
	[Nullable(2)]
	protected Action<int> OnToggleCallBack;

	// Token: 0x04006BFA RID: 27642
	[Nullable(2)]
	protected Action<PhantomItem> OnPhantomToggleCallBack;

	// Token: 0x04006BFB RID: 27643
	[Nullable(2)]
	protected CommonTabTitle CommonTabTitle;

	// Token: 0x04006BFC RID: 27644
	protected List<HandBookCommonItemData> HandBookCommonItemDataList;

	// Token: 0x04006BFD RID: 27645
	protected List<PhantomFetter> PhantomFetterDataList;

	// Token: 0x04006BFE RID: 27646
	protected List<List<HandBookCommonItemData>> HandBookCommonTypeItemDataList;

	// Token: 0x04006BFF RID: 27647
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<HandBookCommonItem, HandBookCommonItemData> ScrollViewCommon;

	// Token: 0x04006C00 RID: 27648
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected LoopScrollView<HandBookFetterItem, PhantomFetter> ScrollViewFetter;

	// Token: 0x04006C01 RID: 27649
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<HandBookCommonTypeItem> ScrollViewCommonType;

	// Token: 0x04006C02 RID: 27650
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<HandBookInfoTextItem> InfoItemLayout;

	// Token: 0x04006C03 RID: 27651
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<HandBookContentItem> ContentItemLayout;

	// Token: 0x04006C04 RID: 27652
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<UiPanelBase> StarItemLayout;

	// Token: 0x04006C05 RID: 27653
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericLayoutNew<HandBookPhantomItem> HandBookPhantomLayout;

	// Token: 0x04006C06 RID: 27654
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<AttributeItem, CSharpScript.Game.Module.Common.AttributeData> AttributeLayout;

	// Token: 0x04006C07 RID: 27655
	protected List<string> InfoTextList;

	// Token: 0x04006C08 RID: 27656
	protected List<HandBookContentItemData> ContentTextList;

	// Token: 0x04006C09 RID: 27657
	protected List<CSharpScript.Game.Module.Common.AttributeData> AttributeList;

	// Token: 0x04006C0A RID: 27658
	protected List<HandBookCommonItemData> PhantomDataList;

	// Token: 0x04006C0B RID: 27659
	protected int StarCount;

	// Token: 0x020083BB RID: 33723
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402AE5F RID: 175711
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookInfoTextItem> <0>__InitInfoItem;

		// Token: 0x0402AE60 RID: 175712
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<HandBookContentItem> <1>__InitContentItem;
	}
}
