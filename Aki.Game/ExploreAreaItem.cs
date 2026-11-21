using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F73 RID: 3955
[NullableContext(1)]
[Nullable(0)]
public class ExploreAreaItem : UiPanelBase
{
	// Token: 0x06009E92 RID: 40594 RVA: 0x002ED572 File Offset: 0x002EB772
	public void Initialize(UUIItem uiItem)
	{
		base.CreateByActorAsync(uiItem.GetOwner(), null, false);
	}

	// Token: 0x06009E93 RID: 40595 RVA: 0x002ED584 File Offset: 0x002EB784
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnExtendToggleStateChanged));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009E94 RID: 40596 RVA: 0x002ED68D File Offset: 0x002EB88D
	protected override void OnStart()
	{
		base.GetExtendToggle(4).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x06009E95 RID: 40597 RVA: 0x002ED6AC File Offset: 0x002EB8AC
	protected override void OnBeforeDestroy()
	{
		this.OnSelectedCallback = null;
		this.OnCanExecuteChangeCallback = null;
		base.GetExtendToggle(4).CanExecuteChange.Unbind();
	}

	// Token: 0x06009E96 RID: 40598 RVA: 0x002ED6D0 File Offset: 0x002EB8D0
	private void OnExtendToggleStateChanged(EToggleState toggleState)
	{
		if (this.OnSelectedCallback != null && this.Data != null)
		{
			bool arg = base.GetExtendToggle(4).GetToggleState() == EToggleState.ETT_Checked;
			this.OnSelectedCallback(this, this.Data, arg);
		}
	}

	// Token: 0x06009E97 RID: 40599 RVA: 0x002ED710 File Offset: 0x002EB910
	public void Refresh(ExploreAreaViewData data)
	{
		this.Data = data;
		int areaId = data.AreaId;
		bool uiactive = MapUtil.GetWorldMapLevelOneAreaId() == areaId;
		int selectedAreaId = ExploreProgressModel.Instance.SelectedAreaId;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.NameId, Array.Empty<object>());
		UUIText text = base.GetText(2);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<double>(Math.Floor((double)data.Progress));
		defaultInterpolatedStringHandler.AppendLiteral("%");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		base.GetItem(3).SetUIActive(false);
		base.GetSprite(0).SetUIActive(uiactive);
		this.SetSelected(selectedAreaId == areaId, true);
	}

	// Token: 0x06009E98 RID: 40600 RVA: 0x002ED7BC File Offset: 0x002EB9BC
	private bool OnCanExecuteChange()
	{
		Func<bool> onCanExecuteChangeCallback = this.OnCanExecuteChangeCallback;
		return onCanExecuteChangeCallback == null || onCanExecuteChangeCallback();
	}

	// Token: 0x06009E99 RID: 40601 RVA: 0x002ED7CF File Offset: 0x002EB9CF
	public void BindCanExecuteChange(Func<bool> onCanExecuteChange)
	{
		this.OnCanExecuteChangeCallback = onCanExecuteChange;
	}

	// Token: 0x06009E9A RID: 40602 RVA: 0x002ED7D8 File Offset: 0x002EB9D8
	public void SetSelected(bool bSelected, bool bFireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(4);
		if (bSelected)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, bFireEvent, false, false);
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, bFireEvent, false, false);
	}

	// Token: 0x06009E9B RID: 40603 RVA: 0x002ED807 File Offset: 0x002EBA07
	public void BindOnSelected(Action<ExploreAreaItem, ExploreAreaViewData, bool> onSelectedCallback)
	{
		this.OnSelectedCallback = onSelectedCallback;
	}

	// Token: 0x04005E12 RID: 24082
	[Nullable(2)]
	private ExploreAreaViewData Data;

	// Token: 0x04005E13 RID: 24083
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Action<ExploreAreaItem, ExploreAreaViewData, bool> OnSelectedCallback;

	// Token: 0x04005E14 RID: 24084
	[Nullable(2)]
	private Func<bool> OnCanExecuteChangeCallback;

	// Token: 0x02007197 RID: 29079
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04024FFD RID: 151549
		LocationSprite,
		// Token: 0x04024FFE RID: 151550
		TitleText,
		// Token: 0x04024FFF RID: 151551
		ProgressText,
		// Token: 0x04025000 RID: 151552
		RedDotItem,
		// Token: 0x04025001 RID: 151553
		ExtendToggle
	}
}
