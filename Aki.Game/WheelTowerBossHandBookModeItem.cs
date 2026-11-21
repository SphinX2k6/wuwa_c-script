using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000A45 RID: 2629
public class WheelTowerBossHandBookModeItem : GridProxyAbstract<bool>
{
	// Token: 0x17000D98 RID: 3480
	// (get) Token: 0x06007140 RID: 28992 RVA: 0x0022BC67 File Offset: 0x00229E67
	// (set) Token: 0x06007141 RID: 28993 RVA: 0x0022BC6F File Offset: 0x00229E6F
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

	// Token: 0x06007142 RID: 28994 RVA: 0x0022BC78 File Offset: 0x00229E78
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

	// Token: 0x06007143 RID: 28995 RVA: 0x0022BD40 File Offset: 0x00229F40
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

	// Token: 0x06007144 RID: 28996 RVA: 0x0022BD8D File Offset: 0x00229F8D
	public override void OnSelected(bool fireEvent)
	{
		this.InvokeToggleClick(fireEvent);
	}

	// Token: 0x06007145 RID: 28997 RVA: 0x0022BD96 File Offset: 0x00229F96
	private void OnToggleClick(EToggleState state)
	{
		this.InvokeToggleClick(state == EToggleState.ETT_Checked);
	}

	// Token: 0x06007146 RID: 28998 RVA: 0x0022BDA4 File Offset: 0x00229FA4
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

	// Token: 0x040045D9 RID: 17881
	private bool IsEndless;
}
