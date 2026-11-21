using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F74 RID: 3956
[NullableContext(2)]
[Nullable(0)]
public class ExploreAreaParentItem : UiPanelBase, IDynamicScrollItem<ExploreAreaViewData>
{
	// Token: 0x170010E1 RID: 4321
	// (get) Token: 0x06009E9D RID: 40605 RVA: 0x002ED818 File Offset: 0x002EBA18
	// (set) Token: 0x06009E9E RID: 40606 RVA: 0x002ED820 File Offset: 0x002EBA20
	public ExploreAreaViewData Data { get; private set; }

	// Token: 0x170010E2 RID: 4322
	// (get) Token: 0x06009E9F RID: 40607 RVA: 0x002ED829 File Offset: 0x002EBA29
	// (set) Token: 0x06009EA0 RID: 40608 RVA: 0x002ED831 File Offset: 0x002EBA31
	public ExploreAreaItem ExploreAreaItem { get; private set; }

	// Token: 0x06009EA1 RID: 40609 RVA: 0x002ED83C File Offset: 0x002EBA3C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009EA2 RID: 40610 RVA: 0x002ED8A5 File Offset: 0x002EBAA5
	[NullableContext(1)]
	public AUIBaseActor GetUsingItem(ExploreAreaViewData data)
	{
		if (data.IsCountry)
		{
			return base.GetItem(0).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(1).GetOwner() as AUIBaseActor;
	}

	// Token: 0x06009EA3 RID: 40611 RVA: 0x002ED8D4 File Offset: 0x002EBAD4
	[NullableContext(1)]
	public UniTask Init(UUIItem actor)
	{
		ExploreAreaParentItem.<Init>d__14 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.actor = actor;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ExploreAreaParentItem.<Init>d__14>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06009EA4 RID: 40612 RVA: 0x002ED91F File Offset: 0x002EBB1F
	protected override void OnStart()
	{
		this.ExploreCountryItem = new ExploreCountryItem();
		this.ExploreCountryItem.Initialize(base.GetItem(0));
		this.ExploreAreaItem = new ExploreAreaItem();
		this.ExploreAreaItem.Initialize(base.GetItem(1));
	}

	// Token: 0x06009EA5 RID: 40613 RVA: 0x002ED95B File Offset: 0x002EBB5B
	[NullableContext(1)]
	private void OnCountrySelected(ExploreCountryItem exploreCountryItem, ExploreAreaViewData data, EToggleState state)
	{
		Action<ExploreCountryItem, ExploreAreaViewData, EToggleState> onCountrySelectedCallback = this.OnCountrySelectedCallback;
		if (onCountrySelectedCallback == null)
		{
			return;
		}
		onCountrySelectedCallback(exploreCountryItem, data, state);
	}

	// Token: 0x06009EA6 RID: 40614 RVA: 0x002ED970 File Offset: 0x002EBB70
	[NullableContext(1)]
	private void OnAreaSelected(ExploreAreaItem exploreAreaItem, ExploreAreaViewData data, bool bSelected)
	{
		Action<ExploreAreaItem, ExploreAreaViewData, bool> onAreaSelectedCallback = this.OnAreaSelectedCallback;
		if (onAreaSelectedCallback == null)
		{
			return;
		}
		onAreaSelectedCallback(exploreAreaItem, data, bSelected);
	}

	// Token: 0x06009EA7 RID: 40615 RVA: 0x002ED988 File Offset: 0x002EBB88
	[NullableContext(1)]
	public void Update(ExploreAreaViewData data, int index)
	{
		this.Data = data;
		bool isCountry = data.IsCountry;
		if (isCountry)
		{
			this.ExploreCountryItem.BindOnSelected(new Action<ExploreCountryItem, ExploreAreaViewData, EToggleState>(this.OnCountrySelected));
			this.ExploreCountryItem.BindCanExecuteChange(new Func<bool>(this.OnCountryItemCanExecuteChange));
			this.ExploreCountryItem.Refresh(data);
		}
		else
		{
			this.ExploreAreaItem.BindOnSelected(new Action<ExploreAreaItem, ExploreAreaViewData, bool>(this.OnAreaSelected));
			this.ExploreAreaItem.BindCanExecuteChange(new Func<bool>(this.OnAreaItemCanExecuteChange));
			this.ExploreAreaItem.Refresh(data);
		}
		this.ExploreCountryItem.SetActive(isCountry);
		this.ExploreAreaItem.SetActive(!isCountry);
	}

	// Token: 0x06009EA8 RID: 40616 RVA: 0x002EDA37 File Offset: 0x002EBC37
	private bool OnCountryItemCanExecuteChange()
	{
		return true;
	}

	// Token: 0x06009EA9 RID: 40617 RVA: 0x002EDA3A File Offset: 0x002EBC3A
	private bool OnAreaItemCanExecuteChange()
	{
		return true;
	}

	// Token: 0x06009EAA RID: 40618 RVA: 0x002EDA3D File Offset: 0x002EBC3D
	[NullableContext(1)]
	public void BindOnCountrySelected(Action<ExploreCountryItem, ExploreAreaViewData, EToggleState> onSelectedCallback)
	{
		this.OnCountrySelectedCallback = onSelectedCallback;
	}

	// Token: 0x06009EAB RID: 40619 RVA: 0x002EDA46 File Offset: 0x002EBC46
	[NullableContext(1)]
	public void BindOnAreaSelected(Action<ExploreAreaItem, ExploreAreaViewData, bool> onSelectedCallback)
	{
		this.OnAreaSelectedCallback = onSelectedCallback;
	}

	// Token: 0x06009EAC RID: 40620 RVA: 0x002EDA4F File Offset: 0x002EBC4F
	public void ClearItem()
	{
		this.Data = null;
		ExploreCountryItem exploreCountryItem = this.ExploreCountryItem;
		if (exploreCountryItem != null)
		{
			exploreCountryItem.Destroy(null);
		}
		this.ExploreCountryItem = null;
		ExploreAreaItem exploreAreaItem = this.ExploreAreaItem;
		if (exploreAreaItem != null)
		{
			exploreAreaItem.Destroy(null);
		}
		this.ExploreAreaItem = null;
	}

	// Token: 0x04005E16 RID: 24086
	private ExploreCountryItem ExploreCountryItem;

	// Token: 0x04005E18 RID: 24088
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<ExploreCountryItem, ExploreAreaViewData, EToggleState> OnCountrySelectedCallback;

	// Token: 0x04005E19 RID: 24089
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<ExploreAreaItem, ExploreAreaViewData, bool> OnAreaSelectedCallback;

	// Token: 0x02007198 RID: 29080
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04025003 RID: 151555
		CountryItem,
		// Token: 0x04025004 RID: 151556
		AreaItem
	}
}
