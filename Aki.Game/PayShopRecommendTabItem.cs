using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x0200184B RID: 6219
[NullableContext(1)]
[Nullable(0)]
public class PayShopRecommendTabItem : CommonTabItemBase
{
	// Token: 0x0600F5C3 RID: 62915 RVA: 0x0047C5C3 File Offset: 0x0047A7C3
	public PayShopRecommendTabItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner());
	}

	// Token: 0x0600F5C4 RID: 62916 RVA: 0x0047C5D8 File Offset: 0x0047A7D8
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

	// Token: 0x0600F5C5 RID: 62917 RVA: 0x0047C67E File Offset: 0x0047A87E
	protected override void OnStart()
	{
		base.OnStart();
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600F5C6 RID: 62918 RVA: 0x0047C697 File Offset: 0x0047A897
	protected void ToggleEvent(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectedCallBack(base.GridIndex);
		}
	}

	// Token: 0x0600F5C7 RID: 62919 RVA: 0x0047C6B0 File Offset: 0x0047A8B0
	protected override void OnUpdateTabIcon(string iconPath)
	{
	}

	// Token: 0x0600F5C8 RID: 62920 RVA: 0x0047C6B2 File Offset: 0x0047A8B2
	protected override void OnSetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
	}

	// Token: 0x0600F5C9 RID: 62921 RVA: 0x0047C6C5 File Offset: 0x0047A8C5
	protected override UUIExtendToggle GetTabToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x02007A79 RID: 31353
	[NullableContext(0)]
	private enum EPayShopRecommondTabItemDefine
	{
		// Token: 0x04027B19 RID: 162585
		Toggle,
		// Token: 0x04027B1A RID: 162586
		Name
	}
}
