using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.FarmGold;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001264 RID: 4708
[NullableContext(2)]
[Nullable(0)]
public class FarmGoldDropDownItem : GridProxyAbstract<FarmGoldDifficulty>
{
	// Token: 0x06008017 RID: 32791 RVA: 0x001B1770 File Offset: 0x001AF970
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

	// Token: 0x06008018 RID: 32792 RVA: 0x001B1818 File Offset: 0x001AFA18
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

	// Token: 0x06008019 RID: 32793 RVA: 0x001B185B File Offset: 0x001AFA5B
	public void SetClickCallback(Action<int, int> callback)
	{
		this.Callback = callback;
	}

	// Token: 0x0600801A RID: 32794 RVA: 0x001B1864 File Offset: 0x001AFA64
	[NullableContext(1)]
	public void SetActivityData(FarmGoldData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x0600801B RID: 32795 RVA: 0x001B186D File Offset: 0x001AFA6D
	public override void Refresh(FarmGoldDifficulty config, bool isSelected, int gridIndex)
	{
		this.Data = new FarmGoldDifficulty?(config);
		base.GridIndex = gridIndex;
		base.GetText(0).SetText(this.ActivityData.GetDifficultTogText(config.Id), true);
		this.SetToggleState(isSelected);
	}

	// Token: 0x0600801C RID: 32796 RVA: 0x001B18A8 File Offset: 0x001AFAA8
	private void SetToggleState(bool isSelected)
	{
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600801D RID: 32797 RVA: 0x001B18CE File Offset: 0x001AFACE
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x0600801E RID: 32798 RVA: 0x001B18D7 File Offset: 0x001AFAD7
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x04003A2E RID: 14894
	private Action<int, int> Callback;

	// Token: 0x04003A2F RID: 14895
	private FarmGoldDifficulty? Data;

	// Token: 0x04003A30 RID: 14896
	private FarmGoldData ActivityData;

	// Token: 0x02007877 RID: 30839
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04027B11 RID: 162577
		Text,
		// Token: 0x04027B12 RID: 162578
		Toggle
	}
}
