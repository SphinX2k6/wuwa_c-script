using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020027FA RID: 10234
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevRootTabItem : GridProxyAbstract<IRoleDevRootTabData>
{
	// Token: 0x06015019 RID: 86041 RVA: 0x00552170 File Offset: 0x00550370
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
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601501A RID: 86042 RVA: 0x00552258 File Offset: 0x00550458
	public override void Refresh(IRoleDevRootTabData data, bool isSelected, int gridIndex)
	{
		this.TabIndexInternal = gridIndex;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TabName, Array.Empty<object>());
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(data.TabIsUpgrade);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(data.TabIsFinish);
	}

	// Token: 0x17001BAB RID: 7083
	// (get) Token: 0x0601501B RID: 86043 RVA: 0x005522D4 File Offset: 0x005504D4
	public int TabIndex
	{
		get
		{
			return this.TabIndexInternal;
		}
	}

	// Token: 0x0601501C RID: 86044 RVA: 0x005522DC File Offset: 0x005504DC
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
	}

	// Token: 0x0601501D RID: 86045 RVA: 0x005522F4 File Offset: 0x005504F4
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0601501E RID: 86046 RVA: 0x0055230C File Offset: 0x0055050C
	public override object GetKey(IRoleDevRootTabData data, int gridIndex)
	{
		return gridIndex;
	}

	// Token: 0x0601501F RID: 86047 RVA: 0x00552314 File Offset: 0x00550514
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x06015020 RID: 86048 RVA: 0x00552333 File Offset: 0x00550533
	public void SetToggleState(EToggleState state, bool fireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, fireEvent, false, false);
	}

	// Token: 0x06015021 RID: 86049 RVA: 0x0055234B File Offset: 0x0055054B
	public EToggleState GetToggleState()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return EToggleState.ETT_UnChecked;
		}
		return extendToggle.GetToggleState();
	}

	// Token: 0x06015022 RID: 86050 RVA: 0x0055235F File Offset: 0x0055055F
	protected void OnClickToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<int> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.TabIndex);
		}
	}

	// Token: 0x06015023 RID: 86051 RVA: 0x0055237B File Offset: 0x0055057B
	private bool OnCanExecuteChange()
	{
		Func<int, EToggleState, bool> canClickCallBack = this.CanClickCallBack;
		return canClickCallBack == null || canClickCallBack(this.TabIndex, this.GetToggleState());
	}

	// Token: 0x04009DF9 RID: 40441
	private int TabIndexInternal;

	// Token: 0x04009DFA RID: 40442
	[Nullable(2)]
	public Action<int> OnClickToggleCallBack;

	// Token: 0x04009DFB RID: 40443
	[Nullable(2)]
	public Func<int, EToggleState, bool> CanClickCallBack;

	// Token: 0x02008E47 RID: 36423
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E276 RID: 189046
		Toggle,
		// Token: 0x0402E277 RID: 189047
		TabName,
		// Token: 0x0402E278 RID: 189048
		ItemUp,
		// Token: 0x0402E279 RID: 189049
		ItemFinish
	}
}
