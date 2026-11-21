using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.FilterSort.Sort.AttributeSort;
using CSharpScript.Game.Module.FilterSort.Sort.BaseSortGroup;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D63 RID: 3427
[NullableContext(2)]
[Nullable(0)]
public class SortView : UiViewBase
{
	// Token: 0x06008CB6 RID: 36022 RVA: 0x002A9328 File Offset: 0x002A7528
	[NullableContext(1)]
	public SortView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06008CB7 RID: 36023 RVA: 0x002A9334 File Offset: 0x002A7534
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.ResetView)),
			new ValueTuple<int, Delegate>(1, new Action(this.SaveDataAndCloseView))
		};
	}

	// Token: 0x06008CB8 RID: 36024 RVA: 0x002A93DF File Offset: 0x002A75DF
	private void ResetView()
	{
		this.BaseSortGroup.Reset();
		this.AttributeSortGroup.Reset();
	}

	// Token: 0x06008CB9 RID: 36025 RVA: 0x002A93F8 File Offset: 0x002A75F8
	private void SaveDataAndCloseView()
	{
		SortResultData sortResultData = SortModel.Instance.GetSortResultData(this.ViewData.UniqueId);
		ValueTuple<int, string>? tempSelect = this.BaseSortGroup.GetTempSelect();
		sortResultData.SetSelectBaseSort(new SortViewBaseSort(tempSelect.Value.Item1, tempSelect.Value.Item2));
		sortResultData.SetSelectAttributeSort(this.AttributeSortGroup.GetTempSelectMap());
		Action confirmFunction = this.ViewData.ConfirmFunction;
		if (confirmFunction != null)
		{
			confirmFunction();
		}
		base.CloseMe(null);
	}

	// Token: 0x06008CBA RID: 36026 RVA: 0x002A9476 File Offset: 0x002A7676
	protected override void OnStart()
	{
		this.BaseSortGroup = new BaseSortGroup(base.GetItem(2));
		this.AttributeSortGroup = new AttributeSortGroup(base.GetItem(3));
		this.ViewData = (this.OpenParam as SortViewData);
		this.InitSort();
	}

	// Token: 0x06008CBB RID: 36027 RVA: 0x002A94B3 File Offset: 0x002A76B3
	protected override void OnBeforeDestroy()
	{
		this.BaseSortGroup.Destroy(null);
		this.AttributeSortGroup.Destroy(null);
	}

	// Token: 0x06008CBC RID: 36028 RVA: 0x002A94CD File Offset: 0x002A76CD
	private void InitSort()
	{
		this.BaseSortGroup.Init(this.ViewData.UniqueId);
		this.AttributeSortGroup.Init(this.ViewData.UniqueId);
	}

	// Token: 0x04005466 RID: 21606
	private BaseSortGroup BaseSortGroup;

	// Token: 0x04005467 RID: 21607
	private AttributeSortGroup AttributeSortGroup;

	// Token: 0x04005468 RID: 21608
	private SortViewData ViewData;

	// Token: 0x02006FC0 RID: 28608
	[NullableContext(0)]
	private static class ECompDefine
	{
		// Token: 0x04024821 RID: 149537
		public const int ClearButton = 0;

		// Token: 0x04024822 RID: 149538
		public const int ConfirmButton = 1;

		// Token: 0x04024823 RID: 149539
		public const int BaseLayoutItem = 2;

		// Token: 0x04024824 RID: 149540
		public const int AttributeLayoutItem = 3;
	}
}
