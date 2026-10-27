using System;
using System.Collections.Generic;
using System.Linq;
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

// Token: 0x02001AC6 RID: 6854
[NullableContext(1)]
[Nullable(0)]
public class MapAreaShowView : UiViewBase
{
	// Token: 0x0600CB30 RID: 52016 RVA: 0x002E512F File Offset: 0x002E332F
	public MapAreaShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CB31 RID: 52017 RVA: 0x002E5138 File Offset: 0x002E3338
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

	// Token: 0x0600CB32 RID: 52018 RVA: 0x002E5228 File Offset: 0x002E3428
	protected override UniTask OnBeforeStartAsync()
	{
		MapAreaShowView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MapAreaShowView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CB33 RID: 52019 RVA: 0x002E526B File Offset: 0x002E346B
	protected override void OnStart()
	{
		this.TabComponent.SetHelpButtonShowState(false);
	}

	// Token: 0x0600CB34 RID: 52020 RVA: 0x002E5279 File Offset: 0x002E3479
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.MapAreaShowClickArea, new Action<int>(this.EventMapAreaShowClickArea));
	}

	// Token: 0x0600CB35 RID: 52021 RVA: 0x002E5297 File Offset: 0x002E3497
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.MapAreaShowClickArea, new Action<int>(this.EventMapAreaShowClickArea));
	}

	// Token: 0x0600CB36 RID: 52022 RVA: 0x002E52B8 File Offset: 0x002E34B8
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

	// Token: 0x0600CB37 RID: 52023 RVA: 0x002E53C6 File Offset: 0x002E35C6
	protected override void OnBeforeDestroy()
	{
		if (this.TwoTabGroup != null)
		{
			this.TwoTabGroup.Destroy(null);
			this.TwoTabGroup = null;
		}
	}

	// Token: 0x0600CB38 RID: 52024 RVA: 0x002E53E4 File Offset: 0x002E35E4
	protected UniTask InitCommonOneTab()
	{
		MapAreaShowView.<InitCommonOneTab>d__20 <InitCommonOneTab>d__;
		<InitCommonOneTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCommonOneTab>d__.<>4__this = this;
		<InitCommonOneTab>d__.<>1__state = -1;
		<InitCommonOneTab>d__.<>t__builder.Start<MapAreaShowView.<InitCommonOneTab>d__20>(ref <InitCommonOneTab>d__);
		return <InitCommonOneTab>d__.<>t__builder.Task;
	}

	// Token: 0x0600CB39 RID: 52025 RVA: 0x002E5427 File Offset: 0x002E3627
	private MapAreaShowCountryItem ProxyCreate([Nullable(2)] UUIItem item, int? index)
	{
		return new MapAreaShowCountryItem();
	}

	// Token: 0x0600CB3A RID: 52026 RVA: 0x002E542E File Offset: 0x002E362E
	private void ToggleCallBack(int index)
	{
		this.LastClickTime = new double?(Time.Instance.Now);
		this.CurSelectOneTabIndex = index;
		this.RefreshTwoTab();
	}

	// Token: 0x0600CB3B RID: 52027 RVA: 0x002E5454 File Offset: 0x002E3654
	private CommonTabData GetCommonTitleData(int index)
	{
		ExploreCountryData exploreCountryData = this.OneTabDataList[index];
		return new CommonTabData(exploreCountryData.Icon, new CommonTabTitleData(exploreCountryData.TitleId, new object[]
		{
			exploreCountryData
		}), null);
	}

	// Token: 0x0600CB3C RID: 52028 RVA: 0x002E548F File Offset: 0x002E368F
	private void OnClickCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CB3D RID: 52029 RVA: 0x002E5498 File Offset: 0x002E3698
	private bool CanToggleChange(int index, bool? forceSwitch)
	{
		return Info.Instance.IsInGamepad() || (this.LastClickTime == null || Time.Instance.Now - this.LastClickTime.Value >= (double)this.Interval);
	}

	// Token: 0x0600CB3E RID: 52030 RVA: 0x002E54D8 File Offset: 0x002E36D8
	private void RefreshTwoTab()
	{
		if (this.TwoTabGroup == null)
		{
			this.TwoTabGroup = new TabComponent<MapAreaShowTabItem>(base.GetItem(3), new Func<UUIItem, int?, MapAreaShowTabItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleTwoTabCallBack), base.GetItem(5));
		}
		ExploreCountryData exploreCountryData = this.OneTabDataList[this.CurSelectOneTabIndex];
		this.TwoTabDataList = (from s in exploreCountryData.GetStateDataList()
		orderby s.SortIndex, s.StateId
		select s).ToList<ExploreStateData>();
		int count = this.TwoTabDataList.Count;
		this.TwoTabGroup.RefreshTabItemByLength(count, new Action(this.RefreshTwoTabFinish));
	}

	// Token: 0x0600CB3F RID: 52031 RVA: 0x002E55B0 File Offset: 0x002E37B0
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

	// Token: 0x0600CB40 RID: 52032 RVA: 0x002E56B4 File Offset: 0x002E38B4
	private MapAreaShowTabItem TabItemProxyCreate([Nullable(2)] UUIItem item, int? index)
	{
		return new MapAreaShowTabItem();
	}

	// Token: 0x0600CB41 RID: 52033 RVA: 0x002E56BB File Offset: 0x002E38BB
	private void ToggleTwoTabCallBack(int index)
	{
		this.CurSelectTwoTabIndex = index;
		this.RefreshArea();
	}

	// Token: 0x0600CB42 RID: 52034 RVA: 0x002E56CA File Offset: 0x002E38CA
	private void RefreshArea()
	{
		this.RefreshLoopScrollView();
	}

	// Token: 0x0600CB43 RID: 52035 RVA: 0x002E56D4 File Offset: 0x002E38D4
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

	// Token: 0x0600CB44 RID: 52036 RVA: 0x002E5766 File Offset: 0x002E3966
	private MapAreaShowItem InitHandBookQuestItem()
	{
		return new MapAreaShowItem();
	}

	// Token: 0x0600CB45 RID: 52037 RVA: 0x002E576D File Offset: 0x002E396D
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

	// Token: 0x04005D85 RID: 23941
	private IReadOnlyList<ExploreCountryData> OneTabDataList;

	// Token: 0x04005D86 RID: 23942
	private TabComponentWithCaptionItem<MapAreaShowCountryItem> TabComponent;

	// Token: 0x04005D87 RID: 23943
	private int CurSelectOneTabIndex;

	// Token: 0x04005D88 RID: 23944
	private int Interval;

	// Token: 0x04005D89 RID: 23945
	private double? LastClickTime;

	// Token: 0x04005D8A RID: 23946
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<MapAreaShowItem, ExploreAreaData> AreaScroll;

	// Token: 0x04005D8B RID: 23947
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<MapAreaShowTabItem> TwoTabGroup;

	// Token: 0x04005D8C RID: 23948
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IReadOnlyList<ExploreStateData> TwoTabDataList;

	// Token: 0x04005D8D RID: 23949
	private int CurSelectTwoTabIndex;

	// Token: 0x04005D8E RID: 23950
	[Nullable(2)]
	private MapAreaShowViewParams DataParam;

	// Token: 0x04005D8F RID: 23951
	private int PendingDefaultStateId;

	// Token: 0x0200801B RID: 32795
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029D2A RID: 171306
		TitleItem,
		// Token: 0x04029D2B RID: 171307
		LoopScrollView,
		// Token: 0x04029D2C RID: 171308
		ScrollViewItem,
		// Token: 0x04029D2D RID: 171309
		TwoTabRoot,
		// Token: 0x04029D2E RID: 171310
		TwoTabScrollView,
		// Token: 0x04029D2F RID: 171311
		TwoTabItem
	}
}
