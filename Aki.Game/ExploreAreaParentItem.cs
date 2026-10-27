using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AB5 RID: 6837
[NullableContext(2)]
[Nullable(0)]
public class ExploreAreaParentItem : UiPanelBase, IDynamicScrollItem<ExploreAreaViewData>
{
	// Token: 0x170010BC RID: 4284
	// (get) Token: 0x0600CA8C RID: 51852 RVA: 0x002E26C8 File Offset: 0x002E08C8
	// (set) Token: 0x0600CA8D RID: 51853 RVA: 0x002E26D0 File Offset: 0x002E08D0
	public ExploreAreaViewData Data { get; private set; }

	// Token: 0x170010BD RID: 4285
	// (get) Token: 0x0600CA8E RID: 51854 RVA: 0x002E26D9 File Offset: 0x002E08D9
	// (set) Token: 0x0600CA8F RID: 51855 RVA: 0x002E26E1 File Offset: 0x002E08E1
	public ExploreAreaItem ExploreAreaItem { get; private set; }

	// Token: 0x0600CA90 RID: 51856 RVA: 0x002E26EC File Offset: 0x002E08EC
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

	// Token: 0x0600CA91 RID: 51857 RVA: 0x002E2755 File Offset: 0x002E0955
	[NullableContext(1)]
	public AUIBaseActor GetUsingItem(ExploreAreaViewData data)
	{
		if (data.IsCountry)
		{
			return base.GetItem(0).GetOwner() as AUIBaseActor;
		}
		return base.GetItem(1).GetOwner() as AUIBaseActor;
	}

	// Token: 0x0600CA92 RID: 51858 RVA: 0x002E2784 File Offset: 0x002E0984
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

	// Token: 0x0600CA93 RID: 51859 RVA: 0x002E27CF File Offset: 0x002E09CF
	protected override void OnStart()
	{
		this.ExploreCountryItem = new ExploreCountryItem();
		this.ExploreCountryItem.Initialize(base.GetItem(0));
		this.ExploreAreaItem = new ExploreAreaItem();
		this.ExploreAreaItem.Initialize(base.GetItem(1));
	}

	// Token: 0x0600CA94 RID: 51860 RVA: 0x002E280B File Offset: 0x002E0A0B
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

	// Token: 0x0600CA95 RID: 51861 RVA: 0x002E2820 File Offset: 0x002E0A20
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

	// Token: 0x0600CA96 RID: 51862 RVA: 0x002E2838 File Offset: 0x002E0A38
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

	// Token: 0x0600CA97 RID: 51863 RVA: 0x002E28E7 File Offset: 0x002E0AE7
	private bool OnCountryItemCanExecuteChange()
	{
		return true;
	}

	// Token: 0x0600CA98 RID: 51864 RVA: 0x002E28EA File Offset: 0x002E0AEA
	private bool OnAreaItemCanExecuteChange()
	{
		return true;
	}

	// Token: 0x0600CA99 RID: 51865 RVA: 0x002E28ED File Offset: 0x002E0AED
	[NullableContext(1)]
	public void BindOnCountrySelected(Action<ExploreCountryItem, ExploreAreaViewData, EToggleState> onSelectedCallback)
	{
		this.OnCountrySelectedCallback = onSelectedCallback;
	}

	// Token: 0x0600CA9A RID: 51866 RVA: 0x002E28F6 File Offset: 0x002E0AF6
	[NullableContext(1)]
	public void BindOnAreaSelected(Action<ExploreAreaItem, ExploreAreaViewData, bool> onSelectedCallback)
	{
		this.OnAreaSelectedCallback = onSelectedCallback;
	}

	// Token: 0x0600CA9B RID: 51867 RVA: 0x002E28FF File Offset: 0x002E0AFF
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

	// Token: 0x04005D47 RID: 23879
	private ExploreCountryItem ExploreCountryItem;

	// Token: 0x04005D49 RID: 23881
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<ExploreCountryItem, ExploreAreaViewData, EToggleState> OnCountrySelectedCallback;

	// Token: 0x04005D4A RID: 23882
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<ExploreAreaItem, ExploreAreaViewData, bool> OnAreaSelectedCallback;

	// Token: 0x02008009 RID: 32777
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029CC9 RID: 171209
		CountryItem,
		// Token: 0x04029CCA RID: 171210
		AreaItem
	}
}
