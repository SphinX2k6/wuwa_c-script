using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002BEC RID: 11244
public class TowerDetailItem : GridProxyAbstract<int>
{
	// Token: 0x060175A7 RID: 95655 RVA: 0x005F0A1C File Offset: 0x005EEC1C
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

	// Token: 0x060175A8 RID: 95656 RVA: 0x005F0AC4 File Offset: 0x005EECC4
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.TowerId = data;
		TowerConfig? towerInfo = TowerClimbConfig.Instance.GetTowerInfo(data);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_TowerOnlyFloor_Text", new <>z__ReadOnlySingleElementList<object>(towerInfo.Value.Floor));
		if (data == TowerModel.Instance.CurrentSelectFloor)
		{
			this.SetToggleState(EToggleState.ETT_Checked);
			return;
		}
		this.SetToggleState(EToggleState.ETT_UnChecked);
	}

	// Token: 0x060175A9 RID: 95657 RVA: 0x005F0B2F File Offset: 0x005EED2F
	[NullableContext(1)]
	public void BindOnClickToggle(Action<int> onClickToggle)
	{
		this.OnClickToggleHandle = onClickToggle;
	}

	// Token: 0x060175AA RID: 95658 RVA: 0x005F0B38 File Offset: 0x005EED38
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		if (state == EToggleState.ETT_Checked)
		{
			this.OnClickToggle(state);
		}
	}

	// Token: 0x060175AB RID: 95659 RVA: 0x005F0B56 File Offset: 0x005EED56
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<int> onClickToggleHandle = this.OnClickToggleHandle;
		if (onClickToggleHandle == null)
		{
			return;
		}
		onClickToggleHandle(this.TowerId);
	}

	// Token: 0x060175AC RID: 95660 RVA: 0x005F0B6E File Offset: 0x005EED6E
	protected override void OnBeforeDestroy()
	{
		this.OnClickToggleHandle = null;
	}

	// Token: 0x0400AECA RID: 44746
	[Nullable(2)]
	private Action<int> OnClickToggleHandle;

	// Token: 0x0400AECB RID: 44747
	private int TowerId = -1;

	// Token: 0x020091A9 RID: 37289
	private enum EChildType
	{
		// Token: 0x0402F214 RID: 193044
		FloorToggle,
		// Token: 0x0402F215 RID: 193045
		FloorNumberText
	}
}
