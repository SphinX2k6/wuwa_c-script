using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000CD5 RID: 3285
[NullableContext(1)]
[Nullable(0)]
public abstract class DropDownItemBase<[Nullable(2)] TData> : UiPanelBase
{
	// Token: 0x060088FA RID: 35066 RVA: 0x00298877 File Offset: 0x00296A77
	public DropDownItemBase(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x060088FB RID: 35067 RVA: 0x0029888C File Offset: 0x00296A8C
	protected override void OnStartImplement()
	{
		UUIExtendToggle dropDownToggle = this.GetDropDownToggle();
		dropDownToggle.OnStateChange.Clear();
		dropDownToggle.CanExecuteChange.Unbind();
		dropDownToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleFunction));
		dropDownToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x060088FC RID: 35068 RVA: 0x002988E2 File Offset: 0x00296AE2
	private void OnToggleFunction(EToggleState state)
	{
		Action<int> toggleFunction = this.ToggleFunction;
		if (toggleFunction == null)
		{
			return;
		}
		toggleFunction(this.Index);
	}

	// Token: 0x060088FD RID: 35069 RVA: 0x002988FA File Offset: 0x00296AFA
	private bool OnCanExecuteChange()
	{
		Func<int, bool> canExecuteFunction = this.CanExecuteFunction;
		return canExecuteFunction != null && canExecuteFunction(this.Index);
	}

	// Token: 0x060088FE RID: 35070 RVA: 0x00298913 File Offset: 0x00296B13
	protected override void OnBeforeDestroyImplement()
	{
		UUIExtendToggle dropDownToggle = this.GetDropDownToggle();
		dropDownToggle.OnStateChange.Clear();
		dropDownToggle.CanExecuteChange.Unbind();
	}

	// Token: 0x060088FF RID: 35071 RVA: 0x00298930 File Offset: 0x00296B30
	public void ShowDropDownItemBase(TData data, int index)
	{
		this.Index = index;
		this.OnShowDropDownItemBase(data);
	}

	// Token: 0x06008900 RID: 35072 RVA: 0x00298940 File Offset: 0x00296B40
	public void SetToggleFunction(Action<int> callback)
	{
		this.ToggleFunction = callback;
	}

	// Token: 0x06008901 RID: 35073 RVA: 0x00298949 File Offset: 0x00296B49
	public void SetCanExecuteFunction(Func<int, bool> callback)
	{
		this.CanExecuteFunction = callback;
	}

	// Token: 0x06008902 RID: 35074 RVA: 0x00298954 File Offset: 0x00296B54
	public void SetToggle(bool bSelected)
	{
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.GetDropDownToggle().SetToggleState(state, bSelected, false, false);
	}

	// Token: 0x06008903 RID: 35075 RVA: 0x0029897C File Offset: 0x00296B7C
	public void SetToggleForce(bool bSelected)
	{
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.GetDropDownToggle().SetToggleStateForce(state, bSelected, false, false);
	}

	// Token: 0x06008904 RID: 35076
	protected abstract void OnShowDropDownItemBase(TData data);

	// Token: 0x06008905 RID: 35077
	[NullableContext(2)]
	protected abstract UUIExtendToggle GetDropDownToggle();

	// Token: 0x0400526B RID: 21099
	private int Index;

	// Token: 0x0400526C RID: 21100
	[Nullable(2)]
	private Action<int> ToggleFunction;

	// Token: 0x0400526D RID: 21101
	[Nullable(2)]
	private Func<int, bool> CanExecuteFunction;
}
