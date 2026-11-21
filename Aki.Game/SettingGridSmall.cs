using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using FilterDefine;
using UnrealEngine;

// Token: 0x0200147F RID: 5247
public class SettingGridSmall : SettingGridBase
{
	// Token: 0x0600D22B RID: 53803 RVA: 0x003E57E8 File Offset: 0x003E39E8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickedSwitch));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D22C RID: 53804 RVA: 0x003E588E File Offset: 0x003E3A8E
	protected override void OnStart()
	{
		base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.OnCheckCanChange));
	}

	// Token: 0x0600D22D RID: 53805 RVA: 0x003E58B0 File Offset: 0x003E3AB0
	[NullableContext(1)]
	public override void Refresh(InventoryDefine.IManageConfigSettingGridData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		if (!this.CheckShow())
		{
			base.SetUiActive(false);
			return;
		}
		base.SetUiActive(true);
		base.GetExtendToggle(1).SetSelfInteractive(data.IsEditing);
		if (data.IsEmpty)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PhantomProject_EmptyChose", Array.Empty<object>());
			base.GetExtendToggle(1).SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
			return;
		}
		this.SetNormalState();
	}

	// Token: 0x0600D22E RID: 53806 RVA: 0x003E5928 File Offset: 0x003E3B28
	private bool CheckShow()
	{
		InventoryDefine.IManageConfigSettingGridData data = this.Data;
		if (data.IsFirst)
		{
			return data.IsEmpty && !data.IsEditing;
		}
		return data.IsEditing || data.IsSelect;
	}

	// Token: 0x0600D22F RID: 53807 RVA: 0x003E596C File Offset: 0x003E3B6C
	private void SetNormalState()
	{
		InventoryDefine.IManageConfigSettingGridData data = this.Data;
		int filterType = FilterConfig.Instance.GetFilterRuleConfig(data.RuleId).Value.FilterType;
		FilterItemData filterItemData = FilterModel.Instance.GetFilterDataFuncByFilterType((FilterDefine.EFilterType)filterType)(new int[]
		{
			data.Value
		})[0];
		EToggleState etoggleState = data.IsSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleStateForce((!data.IsEditing) ? EToggleState.ETT_UnDetermined : etoggleState, false, false, false);
		base.GetText(0).SetText(filterItemData.Content ?? "", true);
	}

	// Token: 0x0600D230 RID: 53808 RVA: 0x003E5A0A File Offset: 0x003E3C0A
	private bool OnCheckCanChange()
	{
		return this.Data != null && this.Data.IsEditing;
	}

	// Token: 0x0600D231 RID: 53809 RVA: 0x003E5A21 File Offset: 0x003E3C21
	private void OnClickedSwitch(EToggleState state)
	{
		if (this.CallbackOnClicked != null)
		{
			this.CallbackOnClicked(this.Data, state == EToggleState.ETT_Checked);
		}
	}

	// Token: 0x04007684 RID: 30340
	[Nullable(2)]
	private InventoryDefine.IManageConfigSettingGridData Data;

	// Token: 0x02007748 RID: 30536
	private enum EComponentSmall
	{
		// Token: 0x04026BCF RID: 158671
		TextName,
		// Token: 0x04026BD0 RID: 158672
		BtnSwitch
	}
}
