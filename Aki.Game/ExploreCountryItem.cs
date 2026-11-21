using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F76 RID: 3958
[NullableContext(1)]
[Nullable(0)]
public class ExploreCountryItem : UiPanelBase
{
	// Token: 0x06009EBE RID: 40638 RVA: 0x002EDB79 File Offset: 0x002EBD79
	public void Initialize(UUIItem uiItem)
	{
		base.CreateByActorAsync(uiItem.GetOwner(), null, false);
	}

	// Token: 0x06009EBF RID: 40639 RVA: 0x002EDB8C File Offset: 0x002EBD8C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnExtendToggleStateChanged));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009EC0 RID: 40640 RVA: 0x002EDC95 File Offset: 0x002EBE95
	protected override void OnStart()
	{
		base.GetExtendToggle(3).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x06009EC1 RID: 40641 RVA: 0x002EDCB4 File Offset: 0x002EBEB4
	protected override void OnBeforeDestroy()
	{
		this.OnSelectedCallback = null;
		this.OnCanExecuteChangeCallback = null;
		base.GetExtendToggle(3).CanExecuteChange.Unbind();
	}

	// Token: 0x06009EC2 RID: 40642 RVA: 0x002EDCD5 File Offset: 0x002EBED5
	private void OnExtendToggleStateChanged(EToggleState state)
	{
		Action<ExploreCountryItem, ExploreAreaViewData, EToggleState> onSelectedCallback = this.OnSelectedCallback;
		if (onSelectedCallback == null)
		{
			return;
		}
		onSelectedCallback(this, this.Data, state);
	}

	// Token: 0x06009EC3 RID: 40643 RVA: 0x002EDCF0 File Offset: 0x002EBEF0
	public void Refresh(ExploreAreaViewData data)
	{
		this.Data = data;
		int? areaCountryId = AreaModel.Instance.GetAreaCountryId();
		int countryId = data.CountryId;
		bool uiactive = areaCountryId.GetValueOrDefault() == countryId & areaCountryId != null;
		int selectedCountryId = ExploreProgressModel.Instance.SelectedCountryId;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.NameId, Array.Empty<object>());
		base.GetSprite(1).SetUIActive(data.IsLock);
		base.GetItem(2).SetUIActive(false);
		base.GetSprite(4).SetUIActive(uiactive);
		this.SetSelected(selectedCountryId == data.CountryId);
	}

	// Token: 0x06009EC4 RID: 40644 RVA: 0x002EDD8C File Offset: 0x002EBF8C
	public void SetSelected(bool bSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (bSelected)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06009EC5 RID: 40645 RVA: 0x002EDDBB File Offset: 0x002EBFBB
	private bool OnCanExecuteChange()
	{
		Func<bool> onCanExecuteChangeCallback = this.OnCanExecuteChangeCallback;
		return onCanExecuteChangeCallback == null || onCanExecuteChangeCallback();
	}

	// Token: 0x06009EC6 RID: 40646 RVA: 0x002EDDCE File Offset: 0x002EBFCE
	public void BindCanExecuteChange(Func<bool> onCanExecuteChange)
	{
		base.GetExtendToggle(3).CanExecuteChange.Bind(onCanExecuteChange);
	}

	// Token: 0x06009EC7 RID: 40647 RVA: 0x002EDDE2 File Offset: 0x002EBFE2
	public void BindOnSelected(Action<ExploreCountryItem, ExploreAreaViewData, EToggleState> onSelectedCallback)
	{
		this.OnSelectedCallback = onSelectedCallback;
	}

	// Token: 0x04005E20 RID: 24096
	private ExploreAreaViewData Data;

	// Token: 0x04005E21 RID: 24097
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<ExploreCountryItem, ExploreAreaViewData, EToggleState> OnSelectedCallback;

	// Token: 0x04005E22 RID: 24098
	[Nullable(2)]
	private Func<bool> OnCanExecuteChangeCallback;

	// Token: 0x0200719A RID: 29082
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402500B RID: 151563
		TitleText,
		// Token: 0x0402500C RID: 151564
		LockSprite,
		// Token: 0x0402500D RID: 151565
		RedDotItem,
		// Token: 0x0402500E RID: 151566
		ExtendToggle,
		// Token: 0x0402500F RID: 151567
		LocationSprite
	}
}
