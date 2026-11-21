using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000A61 RID: 2657
public class WheelTowerRecordTeamItem : GridProxyAbstract<int>
{
	// Token: 0x06007181 RID: 29057 RVA: 0x0022D860 File Offset: 0x0022BA60
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

	// Token: 0x06007182 RID: 29058 RVA: 0x0022D948 File Offset: 0x0022BB48
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06007183 RID: 29059 RVA: 0x0022D958 File Offset: 0x0022BB58
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

	// Token: 0x06007184 RID: 29060 RVA: 0x0022DA5C File Offset: 0x0022BC5C
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

	// Token: 0x06007185 RID: 29061 RVA: 0x0022DAB0 File Offset: 0x0022BCB0
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

	// Token: 0x06007186 RID: 29062 RVA: 0x0022DB61 File Offset: 0x0022BD61
	private void OnToggleClick(EToggleState state)
	{
		Action<int> onToggleClickCallback = this.OnToggleClickCallback;
		if (onToggleClickCallback == null)
		{
			return;
		}
		onToggleClickCallback(base.GridIndex);
	}

	// Token: 0x06007187 RID: 29063 RVA: 0x0022DB79 File Offset: 0x0022BD79
	public void SetToggleState(bool state)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04004638 RID: 17976
	private int NumberFirst;

	// Token: 0x04004639 RID: 17977
	private int NumberSecond;

	// Token: 0x0400463A RID: 17978
	[Nullable(2)]
	public Action<int> OnToggleClickCallback;
}
