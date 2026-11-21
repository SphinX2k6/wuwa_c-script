using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002136 RID: 8502
public class TimeOfDaySecondToggleItem : GridProxyAbstract<DaySelectPreset>
{
	// Token: 0x06014D79 RID: 85369 RVA: 0x0060EE80 File Offset: 0x0060D080
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

	// Token: 0x06014D7A RID: 85370 RVA: 0x0060EF26 File Offset: 0x0060D126
	private void OnClickToggle(EToggleState state)
	{
		EventSystem.Instance.Emit<int>(EEventName.OnSelectTimePreset, base.GridIndex);
	}

	// Token: 0x06014D7B RID: 85371 RVA: 0x0060EF3E File Offset: 0x0060D13E
	public override void Refresh(DaySelectPreset data, bool isSelected, int gridIndex)
	{
		base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Title, Array.Empty<object>());
	}

	// Token: 0x06014D7C RID: 85372 RVA: 0x0060EF74 File Offset: 0x0060D174
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		if (fireEvent)
		{
			EventSystem.Instance.Emit<int>(EEventName.OnSelectTimePreset, base.GridIndex);
		}
	}

	// Token: 0x06014D7D RID: 85373 RVA: 0x0060EFA0 File Offset: 0x0060D1A0
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}
}
