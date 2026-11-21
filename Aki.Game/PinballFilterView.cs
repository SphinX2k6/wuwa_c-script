using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using FilterDefine;
using UnrealEngine;

// Token: 0x02000D25 RID: 3365
public class PinballFilterView : UiViewBase
{
	// Token: 0x06008B62 RID: 35682 RVA: 0x002A27D4 File Offset: 0x002A09D4
	[NullableContext(1)]
	public PinballFilterView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008B63 RID: 35683 RVA: 0x002A27E0 File Offset: 0x002A09E0
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

	// Token: 0x06008B64 RID: 35684 RVA: 0x002A290C File Offset: 0x002A0B0C
	private void ResetView()
	{
		foreach (PinballFilterGroup pinballFilterGroup in this.Scroll.GetScrollItemList())
		{
			pinballFilterGroup.ResetTempFilterDataMap();
			pinballFilterGroup.RefreshGroupItem();
		}
	}

	// Token: 0x06008B65 RID: 35685 RVA: 0x002A2968 File Offset: 0x002A0B68
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

	// Token: 0x06008B66 RID: 35686 RVA: 0x002A2A0C File Offset: 0x002A0C0C
	protected override void OnBeforeCreate()
	{
		this.ViewData = (this.OpenParam as FilterViewData);
	}

	// Token: 0x06008B67 RID: 35687 RVA: 0x002A2A1F File Offset: 0x002A0C1F
	protected override void OnStart()
	{
		this.InitFilter();
	}

	// Token: 0x06008B68 RID: 35688 RVA: 0x002A2A28 File Offset: 0x002A0C28
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

	// Token: 0x06008B69 RID: 35689 RVA: 0x002A2A72 File Offset: 0x002A0C72
	protected override void OnBeforeDestroy()
	{
		this.Scroll.ClearChildren();
	}

	// Token: 0x06008B6A RID: 35690 RVA: 0x002A2A80 File Offset: 0x002A0C80
	private void InitFilter()
	{
		this.Scroll = new GenericScrollView<PinballFilterGroup>(base.GetScrollViewWithScrollbar(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PinballFilterGroup>(this.InitFilterGroup), base.GetItem(3));
		FilterResultData filterResultData = FilterModel.Instance.GetFilterResultData(this.ViewData.UniqueId);
		Filter? filterConfig = FilterConfig.Instance.GetFilterConfig(filterResultData.ConfigId);
		this.Scroll.RefreshByData<int>(filterConfig.Value.RuleList(), null);
	}

	// Token: 0x04005371 RID: 21361
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<PinballFilterGroup> Scroll;

	// Token: 0x04005372 RID: 21362
	[Nullable(2)]
	private FilterViewData ViewData;

	// Token: 0x02006FB8 RID: 28600
	private enum EComponent
	{
		// Token: 0x040247FB RID: 149499
		ClearButton,
		// Token: 0x040247FC RID: 149500
		ConfirmButton,
		// Token: 0x040247FD RID: 149501
		Scroll,
		// Token: 0x040247FE RID: 149502
		ScrollItem,
		// Token: 0x040247FF RID: 149503
		Title
	}
}
