using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200181C RID: 6172
[NullableContext(1)]
[Nullable(0)]
public abstract class DropDownItemBase<[Nullable(2)] TData> : UiPanelBase
{
	// Token: 0x0600B50F RID: 46351 RVA: 0x0028E157 File Offset: 0x0028C357
	public DropDownItemBase(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B510 RID: 46352 RVA: 0x0028E16C File Offset: 0x0028C36C
	protected override void OnStartImplement()
	{
		UUIExtendToggle dropDownToggle = this.GetDropDownToggle();
		dropDownToggle.OnStateChange.Clear();
		dropDownToggle.CanExecuteChange.Unbind();
		dropDownToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleFunction));
		dropDownToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x0600B511 RID: 46353 RVA: 0x0028E1C2 File Offset: 0x0028C3C2
	private void OnToggleFunction(EToggleState state)
	{
		Action<int> toggleFunction = this.ToggleFunction;
		if (toggleFunction == null)
		{
			return;
		}
		toggleFunction(this.Index);
	}

	// Token: 0x0600B512 RID: 46354 RVA: 0x0028E1DA File Offset: 0x0028C3DA
	private bool OnCanExecuteChange()
	{
		Func<int, bool> canExecuteFunction = this.CanExecuteFunction;
		return canExecuteFunction != null && canExecuteFunction(this.Index);
	}

	// Token: 0x0600B513 RID: 46355 RVA: 0x0028E1F3 File Offset: 0x0028C3F3
	protected override void OnBeforeDestroyImplement()
	{
		UUIExtendToggle dropDownToggle = this.GetDropDownToggle();
		dropDownToggle.OnStateChange.Clear();
		dropDownToggle.CanExecuteChange.Unbind();
	}

	// Token: 0x0600B514 RID: 46356 RVA: 0x0028E210 File Offset: 0x0028C410
	public void ShowDropDownItemBase(TData data, int index)
	{
		this.Index = index;
		this.OnShowDropDownItemBase(data);
	}

	// Token: 0x0600B515 RID: 46357 RVA: 0x0028E220 File Offset: 0x0028C420
	public void SetToggleFunction(Action<int> callback)
	{
		this.ToggleFunction = callback;
	}

	// Token: 0x0600B516 RID: 46358 RVA: 0x0028E229 File Offset: 0x0028C429
	public void SetCanExecuteFunction(Func<int, bool> callback)
	{
		this.CanExecuteFunction = callback;
	}

	// Token: 0x0600B517 RID: 46359 RVA: 0x0028E234 File Offset: 0x0028C434
	public void SetToggle(bool bSelected)
	{
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.GetDropDownToggle().SetToggleState(state, bSelected, false, false);
	}

	// Token: 0x0600B518 RID: 46360 RVA: 0x0028E25C File Offset: 0x0028C45C
	public void SetToggleForce(bool bSelected)
	{
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.GetDropDownToggle().SetToggleStateForce(state, bSelected, false, false);
	}

	// Token: 0x0600B519 RID: 46361
	protected abstract void OnShowDropDownItemBase(TData data);

	// Token: 0x0600B51A RID: 46362
	[NullableContext(2)]
	protected abstract UUIExtendToggle GetDropDownToggle();

	// Token: 0x040051C0 RID: 20928
	private int Index;

	// Token: 0x040051C1 RID: 20929
	[Nullable(2)]
	private Action<int> ToggleFunction;

	// Token: 0x040051C2 RID: 20930
	[Nullable(2)]
	private Func<int, bool> CanExecuteFunction;
}
