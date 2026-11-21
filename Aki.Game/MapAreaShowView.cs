using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F85 RID: 3973
[NullableContext(1)]
[Nullable(0)]
public class MapAreaShowView : UiViewBase
{
	// Token: 0x06009F41 RID: 40769 RVA: 0x002F02B3 File Offset: 0x002EE4B3
	public MapAreaShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009F42 RID: 40770 RVA: 0x002F02BC File Offset: 0x002EE4BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009F43 RID: 40771 RVA: 0x002F03AC File Offset: 0x002EE5AC
	protected override UniTask OnBeforeStartAsync()
	{
		MapAreaShowView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapAreaShowView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009F44 RID: 40772 RVA: 0x002F03EF File Offset: 0x002EE5EF
	protected override void OnStart()
	{
		this.TabComponent.SetHelpButtonShowState(false);
	}

	// Token: 0x06009F45 RID: 40773 RVA: 0x002F03FD File Offset: 0x002EE5FD
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MapAreaShowClickArea, new Action<int>(this.EventMapAreaShowClickArea));
	}

	// Token: 0x06009F46 RID: 40774 RVA: 0x002F041B File Offset: 0x002EE61B
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MapAreaShowClickArea, new Action<int>(this.EventMapAreaShowClickArea));
	}

	// Token: 0x06009F47 RID: 40775 RVA: 0x002F043C File Offset: 0x002EE63C
	protected override void OnBeforeShow()
	{
		this.DataParam = (this.OpenParam as MapAreaShowViewParams);
		MapAreaShowViewParams dataParam = this.DataParam;
		int key = ((dataParam != null) ? dataParam.AreaId : null) ?? MapUtil.GetWorldMapLevelOneAreaId();
		IWorldMapNavigate valueOrDefault = MapConfig.Instance.WorldMapNavigateAreaMap.GetValueOrDefault(key);
		MapAreaShowViewParams dataParam2 = this.DataParam;
		int num = ((dataParam2 != null) ? dataParam2.CountryId : null) ?? ((valueOrDefault != null) ? valueOrDefault.CountryId : 0);
		this.PendingDefaultStateId = ((valueOrDefault != null) ? valueOrDefault.StateId : null).GetValueOrDefault();
		MapAreaShowViewParams dataParam3 = this.DataParam;
		int index = 0;
		for (int i = 0; i < this.OneTabDataList.Count; i++)
		{
			if (this.OneTabDataList[i].CountryId == num)
			{
				index = i;
				break;
			}
		}
		this.TabComponent.SelectToggleByIndex(index, true);
	}

	// Token: 0x06009F48 RID: 40776 RVA: 0x002F054A File Offset: 0x002EE74A
	protected override void OnBeforeDestroy()
	{
		if (this.TwoTabGroup != null)
		{
			this.TwoTabGroup.Destroy(null);
			this.TwoTabGroup = null;
		}
	}

	// Token: 0x06009F49 RID: 40777 RVA: 0x002F0568 File Offset: 0x002EE768
	protected UniTask InitCommonOneTab()
	{
		MapAreaShowView.<InitCommonOneTab>d__20 <InitCommonOneTab>d__;
		<InitCommonOneTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCommonOneTab>d__.<>4__this = this;
		<InitCommonOneTab>d__.<>1__state = -1;
		<InitCommonOneTab>d__.<>t__builder.Start<MapAreaShowView.<InitCommonOneTab>d__20>(ref <InitCommonOneTab>d__);
		return <InitCommonOneTab>d__.<>t__builder.Task;
	}

	// Token: 0x06009F4A RID: 40778 RVA: 0x002F05AB File Offset: 0x002EE7AB
	private MapAreaShowCountryItem ProxyCreate([Nullable(2)] UUIItem item, int? index)
	{
		return new MapAreaShowCountryItem();
	}

	// Token: 0x06009F4B RID: 40779 RVA: 0x002F05B2 File Offset: 0x002EE7B2
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = new double?(Time.Instance.Now);
		this.CurSelectOneTabIndex = index;
		this.RefreshTwoTab();
	}

	// Token: 0x06009F4C RID: 40780 RVA: 0x002F05D8 File Offset: 0x002EE7D8
	private CommonTabData GetCommonTitleData(int index)
	{
		ExploreCountryData exploreCountryData = this.OneTabDataList[index];
		return new CommonTabData(exploreCountryData.Icon, new CommonTabTitleData(exploreCountryData.TitleId, new object[]
		{
			exploreCountryData
		}), null);
	}

	// Token: 0x06009F4D RID: 40781 RVA: 0x002F0613 File Offset: 0x002EE813
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009F4E RID: 40782 RVA: 0x002F061C File Offset: 0x002EE81C
	private bool CanToggleChange(int index, bool? forceSwitch)
	{
		return Info.Instance.IsInGamepad() || (this.LastClickTime == null || Time.Instance.Now - this.LastClickTime.Value >= (double)this.Interval);
	}

	// Token: 0x06009F4F RID: 40783 RVA: 0x002F065C File Offset: 0x002EE85C
	private void RefreshTwoTab()
	{
		if (this.TwoTabGroup == null)
		{
			this.TwoTabGroup = new TabComponent<MapAreaShowTabItem>(base.GetItem(3), new Func<UUIItem, int?, MapAreaShowTabItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleTwoTabCallBack), base.GetItem(5));
		}
		List<ExploreStateData> list = new List<ExploreStateData>(this.OneTabDataList[this.CurSelectOneTabIndex].GetStateDataList());
		list.Sort(delegate(ExploreStateData a, ExploreStateData b)
		{
			if (a.SortIndex != b.SortIndex)
			{
				return a.SortIndex - b.SortIndex;
			}
			return a.StateId - b.StateId;
		});
		this.TwoTabDataList = list;
		int count = this.TwoTabDataList.Count;
		this.TwoTabGroup.RefreshTabItemByLength(count, new Action(this.RefreshTwoTabFinish));
	}

	// Token: 0x06009F50 RID: 40784 RVA: 0x002F0710 File Offset: 0x002EE910
	private void RefreshTwoTabFinish()
	{
		int index = 0;
		if (this.PendingDefaultStateId != 0)
		{
			int num = -1;
			int num2 = 0;
			for (;;)
			{
				int num3 = num2;
				IReadOnlyList<ExploreStateData> twoTabDataList = this.TwoTabDataList;
				if (num3 >= ((twoTabDataList != null) ? twoTabDataList.Count : 0))
				{
					goto IL_46;
				}
				if (this.TwoTabDataList[num2].StateId == this.PendingDefaultStateId)
				{
					break;
				}
				num2++;
			}
			num = num2;
			IL_46:
			if (num >= 0)
			{
				index = num;
			}
			this.PendingDefaultStateId = 0;
		}
		Dictionary<int, MapAreaShowTabItem> tabItemMap = this.TwoTabGroup.GetTabItemMap();
		bool uiactive = false;
		foreach (KeyValuePair<int, MapAreaShowTabItem> keyValuePair in tabItemMap)
		{
			int key = keyValuePair.Key;
			MapAreaShowTabItem value = keyValuePair.Value;
			IReadOnlyList<ExploreStateData> twoTabDataList2 = this.TwoTabDataList;
			value.UpdateView((twoTabDataList2 != null) ? twoTabDataList2[key] : null);
			if (!this.TwoTabDataList[key].IsNoneState)
			{
				uiactive = true;
			}
		}
		this.TwoTabGroup.SelectToggleByIndex(index, true, true);
		base.GetItem(3).SetUIActive(uiactive);
	}

	// Token: 0x06009F51 RID: 40785 RVA: 0x002F0814 File Offset: 0x002EEA14
	private MapAreaShowTabItem TabItemProxyCreate([Nullable(2)] UUIItem item, int? index)
	{
		return new MapAreaShowTabItem();
	}

	// Token: 0x06009F52 RID: 40786 RVA: 0x002F081B File Offset: 0x002EEA1B
	private void ToggleTwoTabCallBack(int index)
	{
		this.CurSelectTwoTabIndex = index;
		this.RefreshArea();
	}

	// Token: 0x06009F53 RID: 40787 RVA: 0x002F082A File Offset: 0x002EEA2A
	private void RefreshArea()
	{
		this.RefreshLoopScrollView();
	}

	// Token: 0x06009F54 RID: 40788 RVA: 0x002F0834 File Offset: 0x002EEA34
	protected void RefreshLoopScrollView()
	{
		UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(1);
		if (this.AreaScroll == null)
		{
			this.AreaScroll = new LoopScrollView<MapAreaShowItem, ExploreAreaData>(loopScrollViewComponent, base.GetItem(2).GetOwner() as AUIBaseActor, new Func<MapAreaShowItem>(this.InitHandBookQuestItem), true);
		}
		IReadOnlyList<ExploreStateData> twoTabDataList = this.TwoTabDataList;
		List<ExploreAreaData> data = (twoTabDataList != null) ? twoTabDataList[this.CurSelectTwoTabIndex].ExploreAreaDataList : null;
		this.AreaScroll.RefreshByData(data, false, delegate
		{
		}, true);
	}

	// Token: 0x06009F55 RID: 40789 RVA: 0x002F08C6 File Offset: 0x002EEAC6
	private MapAreaShowItem InitHandBookQuestItem()
	{
		return new MapAreaShowItem();
	}

	// Token: 0x06009F56 RID: 40790 RVA: 0x002F08CD File Offset: 0x002EEACD
	private void EventMapAreaShowClickArea(int areaId)
	{
		MapAreaShowViewParams dataParam = this.DataParam;
		if (dataParam == null)
		{
			return;
		}
		Action<int> onClickArea = dataParam.OnClickArea;
		if (onClickArea == null)
		{
			return;
		}
		onClickArea(areaId);
	}

	// Token: 0x04005E54 RID: 24148
	private IReadOnlyList<ExploreCountryData> OneTabDataList;

	// Token: 0x04005E55 RID: 24149
	private TabComponentWithCaptionItem<MapAreaShowCountryItem> TabComponent;

	// Token: 0x04005E56 RID: 24150
	private int CurSelectOneTabIndex;

	// Token: 0x04005E57 RID: 24151
	private int Interval;

	// Token: 0x04005E58 RID: 24152
	private double? LastClickTime;

	// Token: 0x04005E59 RID: 24153
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<MapAreaShowItem, ExploreAreaData> AreaScroll;

	// Token: 0x04005E5A RID: 24154
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MapAreaShowTabItem> TwoTabGroup;

	// Token: 0x04005E5B RID: 24155
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IReadOnlyList<ExploreStateData> TwoTabDataList;

	// Token: 0x04005E5C RID: 24156
	private int CurSelectTwoTabIndex;

	// Token: 0x04005E5D RID: 24157
	[Nullable(2)]
	private MapAreaShowViewParams DataParam;

	// Token: 0x04005E5E RID: 24158
	private int PendingDefaultStateId;

	// Token: 0x020071AA RID: 29098
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04025063 RID: 151651
		TitleItem,
		// Token: 0x04025064 RID: 151652
		LoopScrollView,
		// Token: 0x04025065 RID: 151653
		ScrollViewItem,
		// Token: 0x04025066 RID: 151654
		TwoTabRoot,
		// Token: 0x04025067 RID: 151655
		TwoTabScrollView,
		// Token: 0x04025068 RID: 151656
		TwoTabItem
	}
}
