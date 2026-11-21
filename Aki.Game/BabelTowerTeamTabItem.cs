using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000618 RID: 1560
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerTeamTabItem : GridProxyAbstract<string>
{
	// Token: 0x06004921 RID: 18721 RVA: 0x0018D2F8 File Offset: 0x0018B4F8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004922 RID: 18722 RVA: 0x0018D3BF File Offset: 0x0018B5BF
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06004923 RID: 18723 RVA: 0x0018D3D3 File Offset: 0x0018B5D3
	public override void Refresh(string data, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(data);
		}
		this.SetSelected(isSelected);
	}

	// Token: 0x06004924 RID: 18724 RVA: 0x0018D3EF File Offset: 0x0018B5EF
	public void SetToggleClickCallback(Action<EBabelTowerTeamTabType> callback)
	{
		this.ToggleClickCallback = callback;
	}

	// Token: 0x06004925 RID: 18725 RVA: 0x0018D3F8 File Offset: 0x0018B5F8
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		Action<EBabelTowerTeamTabType> toggleClickCallback = this.ToggleClickCallback;
		if (toggleClickCallback == null)
		{
			return;
		}
		toggleClickCallback((EBabelTowerTeamTabType)base.GridIndex);
	}

	// Token: 0x06004926 RID: 18726 RVA: 0x0018D417 File Offset: 0x0018B617
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true);
		if (fireEvent)
		{
			Action<EBabelTowerTeamTabType> toggleClickCallback = this.ToggleClickCallback;
			if (toggleClickCallback == null)
			{
				return;
			}
			toggleClickCallback((EBabelTowerTeamTabType)base.GridIndex);
		}
	}

	// Token: 0x06004927 RID: 18727 RVA: 0x0018D439 File Offset: 0x0018B639
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false);
	}

	// Token: 0x06004928 RID: 18728 RVA: 0x0018D442 File Offset: 0x0018B642
	private void SetSelected(bool selected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04003690 RID: 13968
	[Nullable(2)]
	private Action<EBabelTowerTeamTabType> ToggleClickCallback;

	// Token: 0x020068C4 RID: 26820
	[NullableContext(0)]
	private class ETabItem
	{
		// Token: 0x04022877 RID: 141431
		public const int Toggle = 0;

		// Token: 0x04022878 RID: 141432
		public const int Name = 1;

		// Token: 0x04022879 RID: 141433
		public const int RedDot = 2;
	}
}
