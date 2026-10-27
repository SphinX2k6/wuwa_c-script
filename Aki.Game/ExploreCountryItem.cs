using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001AB7 RID: 6839
[NullableContext(1)]
[Nullable(0)]
public class ExploreCountryItem : UiPanelBase
{
	// Token: 0x0600CAAD RID: 51885 RVA: 0x002E2A29 File Offset: 0x002E0C29
	public void Initialize(UUIItem uiItem)
	{
		base.CreateByActorAsync(uiItem.GetOwner(), null, false);
	}

	// Token: 0x0600CAAE RID: 51886 RVA: 0x002E2A3C File Offset: 0x002E0C3C
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

	// Token: 0x0600CAAF RID: 51887 RVA: 0x002E2B45 File Offset: 0x002E0D45
	protected override void OnStart()
	{
		base.GetExtendToggle(3).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x0600CAB0 RID: 51888 RVA: 0x002E2B64 File Offset: 0x002E0D64
	protected override void OnBeforeDestroy()
	{
		this.OnSelectedCallback = null;
		this.OnCanExecuteChangeCallback = null;
		base.GetExtendToggle(3).CanExecuteChange.Unbind();
	}

	// Token: 0x0600CAB1 RID: 51889 RVA: 0x002E2B85 File Offset: 0x002E0D85
	private void OnExtendToggleStateChanged(EToggleState state)
	{
		Action<ExploreCountryItem, ExploreAreaViewData, EToggleState> onSelectedCallback = this.OnSelectedCallback;
		if (onSelectedCallback == null)
		{
			return;
		}
		onSelectedCallback(this, this.Data, state);
	}

	// Token: 0x0600CAB2 RID: 51890 RVA: 0x002E2BA0 File Offset: 0x002E0DA0
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

	// Token: 0x0600CAB3 RID: 51891 RVA: 0x002E2C3C File Offset: 0x002E0E3C
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

	// Token: 0x0600CAB4 RID: 51892 RVA: 0x002E2C6B File Offset: 0x002E0E6B
	private bool OnCanExecuteChange()
	{
		Func<bool> onCanExecuteChangeCallback = this.OnCanExecuteChangeCallback;
		return onCanExecuteChangeCallback == null || onCanExecuteChangeCallback();
	}

	// Token: 0x0600CAB5 RID: 51893 RVA: 0x002E2C7E File Offset: 0x002E0E7E
	public void BindCanExecuteChange(Func<bool> onCanExecuteChange)
	{
		base.GetExtendToggle(3).CanExecuteChange.Bind(onCanExecuteChange);
	}

	// Token: 0x0600CAB6 RID: 51894 RVA: 0x002E2C92 File Offset: 0x002E0E92
	public void BindOnSelected(Action<ExploreCountryItem, ExploreAreaViewData, EToggleState> onSelectedCallback)
	{
		this.OnSelectedCallback = onSelectedCallback;
	}

	// Token: 0x04005D51 RID: 23889
	private ExploreAreaViewData Data;

	// Token: 0x04005D52 RID: 23890
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<ExploreCountryItem, ExploreAreaViewData, EToggleState> OnSelectedCallback;

	// Token: 0x04005D53 RID: 23891
	[Nullable(2)]
	private Func<bool> OnCanExecuteChangeCallback;

	// Token: 0x0200800B RID: 32779
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029CD1 RID: 171217
		TitleText,
		// Token: 0x04029CD2 RID: 171218
		LockSprite,
		// Token: 0x04029CD3 RID: 171219
		RedDotItem,
		// Token: 0x04029CD4 RID: 171220
		ExtendToggle,
		// Token: 0x04029CD5 RID: 171221
		LocationSprite
	}
}
