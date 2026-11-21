using System;
using System.Collections.Generic;
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

// Token: 0x02000D14 RID: 3348
public class FilterView : UiViewBase
{
	// Token: 0x06008AA6 RID: 35494 RVA: 0x0029F5ED File Offset: 0x0029D7ED
	[NullableContext(1)]
	public FilterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008AA7 RID: 35495 RVA: 0x0029F5F8 File Offset: 0x0029D7F8
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

	// Token: 0x06008AA8 RID: 35496 RVA: 0x0029F6E4 File Offset: 0x0029D8E4
	private void ResetView()
	{
		foreach (FilterGroup filterGroup in this.Scroll.GetScrollItemList())
		{
			filterGroup.ResetTempFilterDataMap();
			filterGroup.RefreshGroupItem();
			filterGroup.RefreshSelectAllToggleState();
		}
	}

	// Token: 0x06008AA9 RID: 35497 RVA: 0x0029F748 File Offset: 0x0029D948
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

	// Token: 0x06008AAA RID: 35498 RVA: 0x0029F7EC File Offset: 0x0029D9EC
	protected override void OnBeforeCreate()
	{
		this.ViewData = (this.OpenParam as FilterViewData);
	}

	// Token: 0x06008AAB RID: 35499 RVA: 0x0029F800 File Offset: 0x0029DA00
	protected override UniTask OnCreateAsync()
	{
		FilterView.<OnCreateAsync>d__9 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>4__this = this;
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<FilterView.<OnCreateAsync>d__9>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008AAC RID: 35500 RVA: 0x0029F843 File Offset: 0x0029DA43
	protected override void OnStart()
	{
		this.LayoutItem.SetUIParent(base.GetScrollViewWithScrollbar(0).ContentUIItem, false);
		this.InitFilter();
	}

	// Token: 0x06008AAD RID: 35501 RVA: 0x0029F868 File Offset: 0x0029DA68
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

	// Token: 0x06008AAE RID: 35502 RVA: 0x0029F8B2 File Offset: 0x0029DAB2
	protected override void OnBeforeDestroy()
	{
		this.Scroll.ClearChildren();
	}

	// Token: 0x06008AAF RID: 35503 RVA: 0x0029F8C0 File Offset: 0x0029DAC0
	private void InitFilter()
	{
		this.Scroll = new GenericScrollView<FilterGroup>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<FilterGroup>(this.InitFilterGroup), this.LayoutItem);
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(filterResultData.ConfigId);
		this.Scroll.RefreshByData<int>(filterConfig.Value.RuleList(), null);
	}

	// Token: 0x0400533A RID: 21306
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<FilterGroup> Scroll;

	// Token: 0x0400533B RID: 21307
	[Nullable(2)]
	private FilterViewData ViewData;

	// Token: 0x0400533C RID: 21308
	[Nullable(2)]
	private UUIItem LayoutItem;

	// Token: 0x02006FA3 RID: 28579
	private enum ECompDefine
	{
		// Token: 0x0402479A RID: 149402
		Scroll,
		// Token: 0x0402479B RID: 149403
		ClearButton,
		// Token: 0x0402479C RID: 149404
		ConfirmButton
	}
}
