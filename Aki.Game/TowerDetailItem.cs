using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002167 RID: 8551
public class TowerDetailItem : GridProxyAbstract<int>
{
	// Token: 0x06014FD8 RID: 85976 RVA: 0x0061D57C File Offset: 0x0061B77C
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

	// Token: 0x06014FD9 RID: 85977 RVA: 0x0061D624 File Offset: 0x0061B824
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

	// Token: 0x06014FDA RID: 85978 RVA: 0x0061D68F File Offset: 0x0061B88F
	[NullableContext(1)]
	public void BindOnClickToggle(Action<int> onClickToggle)
	{
		this.OnClickToggleHandle = onClickToggle;
	}

	// Token: 0x06014FDB RID: 85979 RVA: 0x0061D698 File Offset: 0x0061B898
	public void SetToggleState(EToggleState state)
	{
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		if (state == EToggleState.ETT_Checked)
		{
			this.OnClickToggle(state);
		}
	}

	// Token: 0x06014FDC RID: 85980 RVA: 0x0061D6B6 File Offset: 0x0061B8B6
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<int> onClickToggleHandle = this.OnClickToggleHandle;
		if (onClickToggleHandle == null)
		{
			return;
		}
		onClickToggleHandle(this.TowerId);
	}

	// Token: 0x06014FDD RID: 85981 RVA: 0x0061D6CE File Offset: 0x0061B8CE
	protected override void OnBeforeDestroy()
	{
		this.OnClickToggleHandle = null;
	}

	// Token: 0x0400B2CF RID: 45775
	[Nullable(2)]
	private Action<int> OnClickToggleHandle;

	// Token: 0x0400B2D0 RID: 45776
	private int TowerId = -1;

	// Token: 0x020083EC RID: 33772
	private enum EChildType
	{
		// Token: 0x0402A915 RID: 174357
		FloorToggle,
		// Token: 0x0402A916 RID: 174358
		FloorNumberText
	}
}
