using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02002366 RID: 9062
[NullableContext(1)]
[Nullable(0)]
public class PayShopRecommendTabItem : CommonTabItemBase
{
	// Token: 0x06012113 RID: 74003 RVA: 0x0046F49B File Offset: 0x0046D69B
	public PayShopRecommendTabItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner());
	}

	// Token: 0x06012114 RID: 74004 RVA: 0x0046F4B0 File Offset: 0x0046D6B0
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleEvent));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06012115 RID: 74005 RVA: 0x0046F556 File Offset: 0x0046D756
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06012116 RID: 74006 RVA: 0x0046F56F File Offset: 0x0046D76F
	protected void ToggleEvent(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x06012117 RID: 74007 RVA: 0x0046F588 File Offset: 0x0046D788
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x06012118 RID: 74008 RVA: 0x0046F58A File Offset: 0x0046D78A
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x06012119 RID: 74009 RVA: 0x0046F59D File Offset: 0x0046D79D
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x020088EF RID: 35055
	[NullableContext(0)]
	private enum EPayShopRecommondTabItemDefine
	{
		// Token: 0x0402C801 RID: 182273
		Toggle,
		// Token: 0x0402C802 RID: 182274
		Name
	}
}
