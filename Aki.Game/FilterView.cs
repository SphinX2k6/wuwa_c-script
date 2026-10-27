using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FilterDefine;
using UnrealEngine;

// Token: 0x0200185B RID: 6235
public class FilterView : UiViewBase
{
	// Token: 0x0600B6BD RID: 46781 RVA: 0x00294EC1 File Offset: 0x002930C1
	[NullableContext(1)]
	public FilterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B6BE RID: 46782 RVA: 0x00294ECC File Offset: 0x002930CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.ResetView));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.SaveDataAndCloseView));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B6BF RID: 46783 RVA: 0x00294FB8 File Offset: 0x002931B8
	private void ResetView()
	{
		foreach (FilterGroup filterGroup in this.Scroll.GetScrollItemList())
		{
			filterGroup.ResetTempFilterDataMap();
			filterGroup.RefreshGroupItem();
			filterGroup.RefreshSelectAllToggleState();
		}
	}

	// Token: 0x0600B6C0 RID: 46784 RVA: 0x0029501C File Offset: 0x0029321C
	private void SaveDataAndCloseView()
	{
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		foreach (KeyValuePair<object, FilterGroup> keyValuePair in this.Scroll.GetScrollItemMap())
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

	// Token: 0x0600B6C1 RID: 46785 RVA: 0x002950C0 File Offset: 0x002932C0
	protected override void OnBeforeCreate()
	{
		this.ViewData = (this.OpenParam as FilterViewData);
	}

	// Token: 0x0600B6C2 RID: 46786 RVA: 0x002950D4 File Offset: 0x002932D4
	protected override UniTask OnCreateAsync()
	{
		FilterView.<OnCreateAsync>d__9 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<FilterView.<OnCreateAsync>d__9>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600B6C3 RID: 46787 RVA: 0x00295117 File Offset: 0x00293317
	protected override void OnStart()
	{
		this.LayoutItem.SetUIParent(base.GetScrollViewWithScrollbar(0).ContentUIItem, false);
		this.InitFilter();
	}

	// Token: 0x0600B6C4 RID: 46788 RVA: 0x0029513C File Offset: 0x0029333C
	[NullableContext(1)]
	private ILayoutItem<FilterGroup> InitFilterGroup(object ruleId, UUIItem uiItem, int index)
	{
		FilterGroup filterGroup = new FilterGroup(uiItem);
		filterGroup.ShowTemp((int)ruleId, this.ViewData.UniqueId);
		FilterDefine.EFilterType filterType = filterGroup.GetFilterType();
		return new LayoutItem<FilterGroup>
		{
			Key = filterType,
			Value = filterGroup
		};
	}

	// Token: 0x0600B6C5 RID: 46789 RVA: 0x00295186 File Offset: 0x00293386
	protected override void OnBeforeDestroy()
	{
		this.Scroll.ClearChildren();
	}

	// Token: 0x0600B6C6 RID: 46790 RVA: 0x00295194 File Offset: 0x00293394
	private void InitFilter()
	{
		this.Scroll = new GenericScrollView<FilterGroup>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<FilterGroup>(this.InitFilterGroup), this.LayoutItem);
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(filterResultData.ConfigId);
		this.Scroll.RefreshByData<int>(filterConfig.Value.RuleList().ToList<int>(), null);
	}

	// Token: 0x0400528F RID: 21135
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<FilterGroup> Scroll;

	// Token: 0x04005290 RID: 21136
	[Nullable(2)]
	private FilterViewData ViewData;

	// Token: 0x04005291 RID: 21137
	[Nullable(2)]
	private UUIItem LayoutItem;

	// Token: 0x02007E1C RID: 32284
	private enum ECompDefine
	{
		// Token: 0x0402946D RID: 169069
		Scroll,
		// Token: 0x0402946E RID: 169070
		ClearButton,
		// Token: 0x0402946F RID: 169071
		ConfirmButton
	}
}
