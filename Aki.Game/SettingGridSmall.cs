using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using FilterDefine;
using UnrealEngine;

// Token: 0x02001FBD RID: 8125
public class SettingGridSmall : SettingGridBase
{
	// Token: 0x0600FE05 RID: 65029 RVA: 0x003D9E0C File Offset: 0x003D800C
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

	// Token: 0x0600FE06 RID: 65030 RVA: 0x003D9EB2 File Offset: 0x003D80B2
	protected override void OnStart()
	{
		base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.OnCheckCanChange));
	}

	// Token: 0x0600FE07 RID: 65031 RVA: 0x003D9ED4 File Offset: 0x003D80D4
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

	// Token: 0x0600FE08 RID: 65032 RVA: 0x003D9F4C File Offset: 0x003D814C
	private bool CheckShow()
	{
		InventoryDefine.IManageConfigSettingGridData data = this.Data;
		if (data.IsFirst)
		{
			return data.IsEmpty && !data.IsEditing;
		}
		return data.IsEditing || data.IsSelect;
	}

	// Token: 0x0600FE09 RID: 65033 RVA: 0x003D9F90 File Offset: 0x003D8190
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

	// Token: 0x0600FE0A RID: 65034 RVA: 0x003DA02E File Offset: 0x003D822E
	private bool OnCheckCanChange()
	{
		return this.Data != null && this.Data.IsEditing;
	}

	// Token: 0x0600FE0B RID: 65035 RVA: 0x003DA045 File Offset: 0x003D8245
	private void OnClickedSwitch(EToggleState state)
	{
		if (this.CallbackOnClicked != null)
		{
			this.CallbackOnClicked(this.Data, state == EToggleState.ETT_Checked);
		}
	}

	// Token: 0x040075A2 RID: 30114
	[Nullable(2)]
	private InventoryDefine.IManageConfigSettingGridData Data;

	// Token: 0x020085C6 RID: 34246
	private enum EComponentSmall
	{
		// Token: 0x0402B8C7 RID: 178375
		TextName,
		// Token: 0x0402B8C8 RID: 178376
		BtnSwitch
	}
}
