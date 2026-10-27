using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020015A9 RID: 5545
public class WheelTowerRecordTeamItem : GridProxyAbstract<int>
{
	// Token: 0x06009DA3 RID: 40355 RVA: 0x00223AB0 File Offset: 0x00221CB0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009DA4 RID: 40356 RVA: 0x00223B98 File Offset: 0x00221D98
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06009DA5 RID: 40357 RVA: 0x00223BA8 File Offset: 0x00221DA8
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		int num = gridIndex + 1;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "WheelTower_Team_Name", new <>z__ReadOnlySingleElementList<object>(num));
		this.NumberFirst = num / 10;
		this.NumberSecond = num % 10;
		if (this.NumberFirst == 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "WheelTower_Team_Number", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.NumberFirst,
				this.NumberSecond
			}));
		}
		else
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#ffffff>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberFirst);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberSecond);
				defaultInterpolatedStringHandler.AppendLiteral("</color>");
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "WheelTower_Team_Score", new <>z__ReadOnlySingleElementList<object>(data));
	}

	// Token: 0x06009DA6 RID: 40358 RVA: 0x00223CAC File Offset: 0x00221EAC
	public override void OnSelected(bool fireEvent)
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberFirst);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberSecond);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		this.SetToggleState(true);
	}

	// Token: 0x06009DA7 RID: 40359 RVA: 0x00223D00 File Offset: 0x00221F00
	public override void OnDeselected(bool fireEvent)
	{
		if (this.NumberFirst == 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "WheelTower_Team_Number", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.NumberFirst,
				this.NumberSecond
			}));
		}
		else
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#ffffff>");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberFirst);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.NumberSecond);
				defaultInterpolatedStringHandler.AppendLiteral("</color>");
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}
		this.SetToggleState(false);
	}

	// Token: 0x06009DA8 RID: 40360 RVA: 0x00223DB1 File Offset: 0x00221FB1
	private void OnToggleClick(EToggleState state)
	{
		Action<int> onToggleClickCallback = this.OnToggleClickCallback;
		if (onToggleClickCallback == null)
		{
			return;
		}
		onToggleClickCallback(base.GridIndex);
	}

	// Token: 0x06009DA9 RID: 40361 RVA: 0x00223DC9 File Offset: 0x00221FC9
	public void SetToggleState(bool state)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04004592 RID: 17810
	private int NumberFirst;

	// Token: 0x04004593 RID: 17811
	private int NumberSecond;

	// Token: 0x04004594 RID: 17812
	[Nullable(2)]
	public Action<int> OnToggleClickCallback;
}
