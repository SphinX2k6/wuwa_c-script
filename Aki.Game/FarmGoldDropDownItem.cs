using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000718 RID: 1816
[NullableContext(2)]
[Nullable(0)]
public class FarmGoldDropDownItem : GridProxyAbstract<FarmGoldDifficulty>
{
	// Token: 0x060053AE RID: 21422 RVA: 0x001BA440 File Offset: 0x001B8640
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
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickItem));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060053AF RID: 21423 RVA: 0x001BA4E8 File Offset: 0x001B86E8
	private void OnClickItem(EToggleState toggleState)
	{
		if (this.Data != null)
		{
			Action<int, int> callback = this.Callback;
			if (callback == null)
			{
				return;
			}
			callback(this.Data.Value.Id, base.GridIndex);
		}
	}

	// Token: 0x060053B0 RID: 21424 RVA: 0x001BA52B File Offset: 0x001B872B
	public void SetClickCallback(Action<int, int> callback)
	{
		this.Callback = callback;
	}

	// Token: 0x060053B1 RID: 21425 RVA: 0x001BA534 File Offset: 0x001B8734
	[NullableContext(1)]
	public void SetActivityData(FarmGoldData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x060053B2 RID: 21426 RVA: 0x001BA53D File Offset: 0x001B873D
	public override void Refresh(FarmGoldDifficulty config, bool isSelected, int gridIndex)
	{
		this.Data = new FarmGoldDifficulty?(config);
		base.GridIndex = gridIndex;
		base.GetText(0).SetText(this.ActivityData.GetDifficultTogText(config.Id), true);
		this.SetToggleState(isSelected);
	}

	// Token: 0x060053B3 RID: 21427 RVA: 0x001BA578 File Offset: 0x001B8778
	private void SetToggleState(bool isSelected)
	{
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, false, false, false);
	}

	// Token: 0x060053B4 RID: 21428 RVA: 0x001BA59E File Offset: 0x001B879E
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x060053B5 RID: 21429 RVA: 0x001BA5A7 File Offset: 0x001B87A7
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04003AC6 RID: 15046
	private Action<int, int> Callback;

	// Token: 0x04003AC7 RID: 15047
	private FarmGoldDifficulty? Data;

	// Token: 0x04003AC8 RID: 15048
	private FarmGoldData ActivityData;

	// Token: 0x02006A02 RID: 27138
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04022E42 RID: 142914
		Text,
		// Token: 0x04022E43 RID: 142915
		Toggle
	}
}
