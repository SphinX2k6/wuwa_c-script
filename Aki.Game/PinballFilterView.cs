using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using FilterDefine;
using UnrealEngine;

// Token: 0x0200186C RID: 6252
public class PinballFilterView : UiViewBase
{
	// Token: 0x0600B779 RID: 46969 RVA: 0x002980B0 File Offset: 0x002962B0
	[NullableContext(1)]
	public PinballFilterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B77A RID: 46970 RVA: 0x002980BC File Offset: 0x002962BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ResetView));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.SaveDataAndCloseView));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B77B RID: 46971 RVA: 0x002981E8 File Offset: 0x002963E8
	private void ResetView()
	{
		foreach (PinballFilterGroup pinballFilterGroup in this.Scroll.GetScrollItemList())
		{
			pinballFilterGroup.ResetTempFilterDataMap();
			pinballFilterGroup.RefreshGroupItem();
		}
	}

	// Token: 0x0600B77C RID: 46972 RVA: 0x00298244 File Offset: 0x00296444
	private void SaveDataAndCloseView()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		foreach (KeyValuePair<object, PinballFilterGroup> keyValuePair in this.Scroll.GetScrollItemMap())
		{
			Dictionary<int, string> tempFilterDataMap = keyValuePair.Value.GetTempFilterDataMap();
			filterResultData.SetSelectRuleData((FilterDefine.EFilterType)keyValuePair.Key, tempFilterDataMap);
		}
		Action confirmFunction = this.ViewData.ConfirmFunction;
		if (confirmFunction != null)
		{
			confirmFunction();
		}
		base.CloseMe(null);
	}

	// Token: 0x0600B77D RID: 46973 RVA: 0x002982E8 File Offset: 0x002964E8
	protected override void OnBeforeCreate()
	{
		this.ViewData = (this.OpenParam as FilterViewData);
	}

	// Token: 0x0600B77E RID: 46974 RVA: 0x002982FB File Offset: 0x002964FB
	protected override void OnStart()
	{
		this.InitFilter();
	}

	// Token: 0x0600B77F RID: 46975 RVA: 0x00298304 File Offset: 0x00296504
	[NullableContext(1)]
	private ILayoutItem<PinballFilterGroup> InitFilterGroup(object ruleId, UUIItem uiItem, int index)
	{
		PinballFilterGroup pinballFilterGroup = new PinballFilterGroup(uiItem);
		pinballFilterGroup.ShowTemp((int)ruleId, this.ViewData.UniqueId);
		FilterDefine.EFilterType filterType = pinballFilterGroup.GetFilterType();
		return new LayoutItem<PinballFilterGroup>
		{
			Key = filterType,
			Value = pinballFilterGroup
		};
	}

	// Token: 0x0600B780 RID: 46976 RVA: 0x0029834E File Offset: 0x0029654E
	protected override void OnBeforeDestroy()
	{
		this.Scroll.ClearChildren();
	}

	// Token: 0x0600B781 RID: 46977 RVA: 0x0029835C File Offset: 0x0029655C
	private void InitFilter()
	{
		this.Scroll = new GenericScrollView<PinballFilterGroup>(base.GetScrollViewWithScrollbar(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PinballFilterGroup>(this.InitFilterGroup), base.GetItem(3));
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(filterResultData.ConfigId);
		this.Scroll.RefreshByData<int>(filterConfig.Value.RuleList().ToList<int>(), null);
	}

	// Token: 0x040052C6 RID: 21190
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<PinballFilterGroup> Scroll;

	// Token: 0x040052C7 RID: 21191
	[Nullable(2)]
	private FilterViewData ViewData;

	// Token: 0x02007E31 RID: 32305
	private enum EComponent
	{
		// Token: 0x040294CE RID: 169166
		ClearButton,
		// Token: 0x040294CF RID: 169167
		ConfirmButton,
		// Token: 0x040294D0 RID: 169168
		Scroll,
		// Token: 0x040294D1 RID: 169169
		ScrollItem,
		// Token: 0x040294D2 RID: 169170
		Title
	}
}
