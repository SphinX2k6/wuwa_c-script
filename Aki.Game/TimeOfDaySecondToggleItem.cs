using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002BBB RID: 11195
public class TimeOfDaySecondToggleItem : GridProxyAbstract<DaySelectPreset>
{
	// Token: 0x06017348 RID: 95048 RVA: 0x005E22AC File Offset: 0x005E04AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06017349 RID: 95049 RVA: 0x005E2352 File Offset: 0x005E0552
	private void OnClickToggle(EToggleState state)
	{
		EventSystem.Instance.Emit<int>(EEventName.OnSelectTimePreset, base.GridIndex);
	}

	// Token: 0x0601734A RID: 95050 RVA: 0x005E236A File Offset: 0x005E056A
	public override void Refresh(DaySelectPreset data, bool isSelected, int gridIndex)
	{
		base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Title, Array.Empty<object>());
	}

	// Token: 0x0601734B RID: 95051 RVA: 0x005E23A0 File Offset: 0x005E05A0
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		if (fireEvent)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnSelectTimePreset, base.GridIndex);
		}
	}

	// Token: 0x0601734C RID: 95052 RVA: 0x005E23CC File Offset: 0x005E05CC
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}
}
