using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200139F RID: 5023
public class MascotCollectBookToggleItem : UiPanelBase
{
	// Token: 0x0600C73A RID: 51002 RVA: 0x003B5420 File Offset: 0x003B3620
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C73B RID: 51003 RVA: 0x003B54C6 File Offset: 0x003B36C6
	protected override void OnStart()
	{
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x0600C73C RID: 51004 RVA: 0x003B54D5 File Offset: 0x003B36D5
	public void SetSelectType(HonamiStoryMascotCollectBookView.EMascotCollectBookType type)
	{
		this.SelectType = type;
		this.RefreshToggleItem(this.SelectType);
	}

	// Token: 0x0600C73D RID: 51005 RVA: 0x003B54EA File Offset: 0x003B36EA
	[NullableContext(1)]
	public void BindToggleCallBack(Action<HonamiStoryMascotCollectBookView.EMascotCollectBookType> callBack)
	{
		this.ToggleCallBack = callBack;
	}

	// Token: 0x0600C73E RID: 51006 RVA: 0x003B54F3 File Offset: 0x003B36F3
	public void SetRedDotVisible(bool visible)
	{
		base.GetItem(1).SetUIActive(visible);
	}

	// Token: 0x0600C73F RID: 51007 RVA: 0x003B5502 File Offset: 0x003B3702
	public void RefreshToggleItem(HonamiStoryMascotCollectBookView.EMascotCollectBookType curSelectType)
	{
		if (curSelectType == this.SelectType)
		{
			this.OnSelected();
			return;
		}
		this.OnDeselected();
	}

	// Token: 0x0600C740 RID: 51008 RVA: 0x003B551A File Offset: 0x003B371A
	private void OnToggle(EToggleState toggleState)
	{
		Action<HonamiStoryMascotCollectBookView.EMascotCollectBookType> toggleCallBack = this.ToggleCallBack;
		if (toggleCallBack == null)
		{
			return;
		}
		toggleCallBack(this.SelectType);
	}

	// Token: 0x0600C741 RID: 51009 RVA: 0x003B5532 File Offset: 0x003B3732
	private void OnSelected()
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600C742 RID: 51010 RVA: 0x003B5544 File Offset: 0x003B3744
	private void OnDeselected()
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04007180 RID: 29056
	private HonamiStoryMascotCollectBookView.EMascotCollectBookType SelectType;

	// Token: 0x04007181 RID: 29057
	[Nullable(2)]
	private Action<HonamiStoryMascotCollectBookView.EMascotCollectBookType> ToggleCallBack;
}
