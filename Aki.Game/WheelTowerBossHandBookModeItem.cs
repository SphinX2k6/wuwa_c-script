using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200158D RID: 5517
public class WheelTowerBossHandBookModeItem : GridProxyAbstract<bool>
{
	// Token: 0x17000D77 RID: 3447
	// (get) Token: 0x06009D62 RID: 40290 RVA: 0x00221EB7 File Offset: 0x002200B7
	// (set) Token: 0x06009D63 RID: 40291 RVA: 0x00221EBF File Offset: 0x002200BF
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<bool, UUIExtendToggle, bool> OnClickToggleBack { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x06009D64 RID: 40292 RVA: 0x00221EC8 File Offset: 0x002200C8
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

	// Token: 0x06009D65 RID: 40293 RVA: 0x00221F90 File Offset: 0x00220190
	public override void Refresh(bool isEndless, bool isSelected, int gridIndex)
	{
		this.IsEndless = isEndless;
		string textStringId = isEndless ? "WheelTowerModeTitle_Endless" : "WheelTowerModeTitle_Normal";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06009D66 RID: 40294 RVA: 0x00221FDD File Offset: 0x002201DD
	public override void OnSelected(bool fireEvent)
	{
		this.InvokeToggleClick(fireEvent);
	}

	// Token: 0x06009D67 RID: 40295 RVA: 0x00221FE6 File Offset: 0x002201E6
	private void OnToggleClick(EToggleState state)
	{
		this.InvokeToggleClick(state == EToggleState.ETT_Checked);
	}

	// Token: 0x06009D68 RID: 40296 RVA: 0x00221FF4 File Offset: 0x002201F4
	private void InvokeToggleClick(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			Action<bool, UUIExtendToggle, bool> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.IsEndless, extendToggle, fireEvent);
		}
	}

	// Token: 0x04004533 RID: 17715
	private bool IsEndless;
}
