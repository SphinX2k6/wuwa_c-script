using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.FilterSort.Sort.AttributeSort;
using CSharpScript.Game.Module.FilterSort.Sort.BaseSortGroup;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018AA RID: 6314
[NullableContext(2)]
[Nullable(0)]
public class SortView : UiViewBase
{
	// Token: 0x0600B8CD RID: 47309 RVA: 0x0029EC08 File Offset: 0x0029CE08
	[NullableContext(1)]
	public SortView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B8CE RID: 47310 RVA: 0x0029EC14 File Offset: 0x0029CE14
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

	// Token: 0x0600B8CF RID: 47311 RVA: 0x0029ECBF File Offset: 0x0029CEBF
	private void ResetView()
	{
		this.BaseSortGroup.Reset();
		this.AttributeSortGroup.Reset();
	}

	// Token: 0x0600B8D0 RID: 47312 RVA: 0x0029ECD8 File Offset: 0x0029CED8
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

	// Token: 0x0600B8D1 RID: 47313 RVA: 0x0029ED56 File Offset: 0x0029CF56
	protected override void OnStart()
	{
		this.BaseSortGroup = new BaseSortGroup(base.GetItem(2));
		this.AttributeSortGroup = new AttributeSortGroup(base.GetItem(3));
		this.ViewData = (this.OpenParam as SortViewData);
		this.InitSort();
	}

	// Token: 0x0600B8D2 RID: 47314 RVA: 0x0029ED93 File Offset: 0x0029CF93
	protected override void OnBeforeDestroy()
	{
		this.BaseSortGroup.Destroy(null);
		this.AttributeSortGroup.Destroy(null);
	}

	// Token: 0x0600B8D3 RID: 47315 RVA: 0x0029EDAD File Offset: 0x0029CFAD
	private void InitSort()
	{
		this.BaseSortGroup.Init(this.ViewData.UniqueId);
		this.AttributeSortGroup.Init(this.ViewData.UniqueId);
	}

	// Token: 0x040053BB RID: 21435
	private BaseSortGroup BaseSortGroup;

	// Token: 0x040053BC RID: 21436
	private AttributeSortGroup AttributeSortGroup;

	// Token: 0x040053BD RID: 21437
	private SortViewData ViewData;

	// Token: 0x02007E39 RID: 32313
	[NullableContext(0)]
	private static class ECompDefine
	{
		// Token: 0x040294F4 RID: 169204
		public const int ClearButton = 0;

		// Token: 0x040294F5 RID: 169205
		public const int ConfirmButton = 1;

		// Token: 0x040294F6 RID: 169206
		public const int BaseLayoutItem = 2;

		// Token: 0x040294F7 RID: 169207
		public const int AttributeLayoutItem = 3;
	}
}
