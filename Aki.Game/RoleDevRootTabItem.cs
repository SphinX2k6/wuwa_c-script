using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D75 RID: 7541
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevRootTabItem : GridProxyAbstract<IRoleDevRootTabData>
{
	// Token: 0x06012A19 RID: 76313 RVA: 0x0057CEE4 File Offset: 0x0057B0E4
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

	// Token: 0x06012A1A RID: 76314 RVA: 0x0057CFCC File Offset: 0x0057B1CC
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

	// Token: 0x17001C03 RID: 7171
	// (get) Token: 0x06012A1B RID: 76315 RVA: 0x0057D048 File Offset: 0x0057B248
	public int TabIndex
	{
		get
		{
			return this.TabIndexInternal;
		}
	}

	// Token: 0x06012A1C RID: 76316 RVA: 0x0057D050 File Offset: 0x0057B250
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
	}

	// Token: 0x06012A1D RID: 76317 RVA: 0x0057D068 File Offset: 0x0057B268
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06012A1E RID: 76318 RVA: 0x0057D080 File Offset: 0x0057B280
	public override object GetKey(IRoleDevRootTabData data, int gridIndex)
	{
		return gridIndex;
	}

	// Token: 0x06012A1F RID: 76319 RVA: 0x0057D088 File Offset: 0x0057B288
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
	}

	// Token: 0x06012A20 RID: 76320 RVA: 0x0057D0A7 File Offset: 0x0057B2A7
	public void SetToggleState(EToggleState state, bool fireEvent = false)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, fireEvent, false, false);
	}

	// Token: 0x06012A21 RID: 76321 RVA: 0x0057D0BF File Offset: 0x0057B2BF
	public EToggleState GetToggleState()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return EToggleState.ETT_UnChecked;
		}
		return extendToggle.GetToggleState();
	}

	// Token: 0x06012A22 RID: 76322 RVA: 0x0057D0D3 File Offset: 0x0057B2D3
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

	// Token: 0x06012A23 RID: 76323 RVA: 0x0057D0EF File Offset: 0x0057B2EF
	private bool OnCanExecuteChange()
	{
		Func<int, EToggleState, bool> canClickCallBack = this.CanClickCallBack;
		return canClickCallBack == null || canClickCallBack(this.TabIndex, this.GetToggleState());
	}

	// Token: 0x0400A1E2 RID: 41442
	private int TabIndexInternal;

	// Token: 0x0400A1E3 RID: 41443
	[Nullable(2)]
	public Action<int> OnClickToggleCallBack;

	// Token: 0x0400A1E4 RID: 41444
	[Nullable(2)]
	public Func<int, EToggleState, bool> CanClickCallBack;

	// Token: 0x02008090 RID: 32912
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029973 RID: 170355
		Toggle,
		// Token: 0x04029974 RID: 170356
		TabName,
		// Token: 0x04029975 RID: 170357
		ItemUp,
		// Token: 0x04029976 RID: 170358
		ItemFinish
	}
}
