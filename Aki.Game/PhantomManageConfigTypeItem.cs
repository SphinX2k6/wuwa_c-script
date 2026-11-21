using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200147C RID: 5244
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManageConfigTypeItem : GridProxyAbstract<InventoryDefine.IManageConfigTypeItemData>, IStaticVariableResetter
{
	// Token: 0x0600D218 RID: 53784 RVA: 0x003E546A File Offset: 0x003E366A
	static PhantomManageConfigTypeItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomManageConfigTypeItem.CreateStaticDefaultValue), new Action(PhantomManageConfigTypeItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600D219 RID: 53785 RVA: 0x003E5489 File Offset: 0x003E3689
	public static void CreateStaticDefaultValue()
	{
		PhantomManageConfigTypeItem.ViewModel = null;
	}

	// Token: 0x0600D21A RID: 53786 RVA: 0x003E5491 File Offset: 0x003E3691
	public static void ResetStaticDefaultValue()
	{
		PhantomManageConfigTypeItem.ViewModel = null;
	}

	// Token: 0x0600D21B RID: 53787 RVA: 0x003E549C File Offset: 0x003E369C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickedSelect));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D21C RID: 53788 RVA: 0x003E5563 File Offset: 0x003E3763
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x0600D21D RID: 53789 RVA: 0x003E5590 File Offset: 0x003E3790
	[NullableContext(1)]
	public override void Refresh(InventoryDefine.IManageConfigTypeItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		EToggleState state = this.GetSelectState() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600D21E RID: 53790 RVA: 0x003E55DE File Offset: 0x003E37DE
	[NullableContext(1)]
	public override object GetKey(InventoryDefine.IManageConfigTypeItemData data, int displayIndex)
	{
		return data.Type;
	}

	// Token: 0x0600D21F RID: 53791 RVA: 0x003E55EC File Offset: 0x003E37EC
	private bool OnCanExecuteChange()
	{
		EToggleState toggleState = base.GetExtendToggle(1).GetToggleState();
		return !this.GetSelectState() || toggleState != EToggleState.ETT_Checked;
	}

	// Token: 0x0600D220 RID: 53792 RVA: 0x003E5615 File Offset: 0x003E3815
	private void OnClickedSelect(EToggleState toggleState)
	{
		if (this.Data != null && PhantomManageConfigTypeItem.ViewModel != null)
		{
			if (PhantomManageConfigTypeItem.ViewModel.GetSelectType() == this.Data.Type)
			{
				return;
			}
			PhantomManageConfigTypeItem.ViewModel.SetSelectType(this.Data.Type, false);
		}
	}

	// Token: 0x0600D221 RID: 53793 RVA: 0x003E5654 File Offset: 0x003E3854
	private bool GetSelectState()
	{
		return this.Data != null && PhantomManageConfigTypeItem.ViewModel != null && PhantomManageConfigTypeItem.ViewModel.GetSelectType() == this.Data.Type;
	}

	// Token: 0x0400767D RID: 30333
	[Nullable(2)]
	private InventoryDefine.IManageConfigTypeItemData Data;

	// Token: 0x0400767E RID: 30334
	[Nullable(2)]
	public static PhantomManageConfigViewModel ViewModel;

	// Token: 0x02007744 RID: 30532
	private enum EComponent
	{
		// Token: 0x04026BC0 RID: 158656
		TextName,
		// Token: 0x04026BC1 RID: 158657
		BtnSelect,
		// Token: 0x04026BC2 RID: 158658
		ItemReddot
	}
}
