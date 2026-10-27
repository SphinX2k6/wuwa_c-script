using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001FBA RID: 8122
[Nullable(new byte[]
{
	0,
	1
})]
public class PhantomManageConfigTypeItem : GridProxyAbstract<InventoryDefine.IManageConfigTypeItemData>, IStaticVariableResetter
{
	// Token: 0x0600FDF2 RID: 65010 RVA: 0x003D9A8E File Offset: 0x003D7C8E
	static PhantomManageConfigTypeItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhantomManageConfigTypeItem.CreateStaticDefaultValue), new Action(PhantomManageConfigTypeItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600FDF3 RID: 65011 RVA: 0x003D9AAD File Offset: 0x003D7CAD
	public static void CreateStaticDefaultValue()
	{
		PhantomManageConfigTypeItem.ViewModel = null;
	}

	// Token: 0x0600FDF4 RID: 65012 RVA: 0x003D9AB5 File Offset: 0x003D7CB5
	public static void ResetStaticDefaultValue()
	{
		PhantomManageConfigTypeItem.ViewModel = null;
	}

	// Token: 0x0600FDF5 RID: 65013 RVA: 0x003D9AC0 File Offset: 0x003D7CC0
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

	// Token: 0x0600FDF6 RID: 65014 RVA: 0x003D9B87 File Offset: 0x003D7D87
	protected override void OnStart()
	{
		base.GetItem(2).SetUIActive(false);
		base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x0600FDF7 RID: 65015 RVA: 0x003D9BB4 File Offset: 0x003D7DB4
	[NullableContext(1)]
	public override void Refresh(InventoryDefine.IManageConfigTypeItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.Name, Array.Empty<object>());
		EToggleState state = this.GetSelectState() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600FDF8 RID: 65016 RVA: 0x003D9C02 File Offset: 0x003D7E02
	[NullableContext(1)]
	public override object GetKey(InventoryDefine.IManageConfigTypeItemData data, int displayIndex)
	{
		return data.Type;
	}

	// Token: 0x0600FDF9 RID: 65017 RVA: 0x003D9C10 File Offset: 0x003D7E10
	private bool OnCanExecuteChange()
	{
		EToggleState toggleState = base.GetExtendToggle(1).GetToggleState();
		return !this.GetSelectState() || toggleState != EToggleState.ETT_Checked;
	}

	// Token: 0x0600FDFA RID: 65018 RVA: 0x003D9C39 File Offset: 0x003D7E39
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

	// Token: 0x0600FDFB RID: 65019 RVA: 0x003D9C78 File Offset: 0x003D7E78
	private bool GetSelectState()
	{
		return this.Data != null && PhantomManageConfigTypeItem.ViewModel != null && PhantomManageConfigTypeItem.ViewModel.GetSelectType() == this.Data.Type;
	}

	// Token: 0x0400759B RID: 30107
	[Nullable(2)]
	private InventoryDefine.IManageConfigTypeItemData Data;

	// Token: 0x0400759C RID: 30108
	[Nullable(2)]
	public static PhantomManageConfigViewModel ViewModel;

	// Token: 0x020085C2 RID: 34242
	private enum EComponent
	{
		// Token: 0x0402B8B8 RID: 178360
		TextName,
		// Token: 0x0402B8B9 RID: 178361
		BtnSelect,
		// Token: 0x0402B8BA RID: 178362
		ItemReddot
	}
}
