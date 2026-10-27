using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001EDD RID: 7901
public class MascotCollectBookToggleItem : UiPanelBase
{
	// Token: 0x0600F31B RID: 62235 RVA: 0x003A9924 File Offset: 0x003A7B24
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

	// Token: 0x0600F31C RID: 62236 RVA: 0x003A99CA File Offset: 0x003A7BCA
	protected override void OnStart()
	{
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x0600F31D RID: 62237 RVA: 0x003A99D9 File Offset: 0x003A7BD9
	public void SetSelectType(HonamiStoryMascotCollectBookView.EMascotCollectBookType type)
	{
		this.SelectType = type;
		this.RefreshToggleItem(this.SelectType);
	}

	// Token: 0x0600F31E RID: 62238 RVA: 0x003A99EE File Offset: 0x003A7BEE
	[NullableContext(1)]
	public void BindToggleCallBack(Action<HonamiStoryMascotCollectBookView.EMascotCollectBookType> callBack)
	{
		this.ToggleCallBack = callBack;
	}

	// Token: 0x0600F31F RID: 62239 RVA: 0x003A99F7 File Offset: 0x003A7BF7
	public void SetRedDotVisible(bool visible)
	{
		base.GetItem(1).SetUIActive(visible);
	}

	// Token: 0x0600F320 RID: 62240 RVA: 0x003A9A06 File Offset: 0x003A7C06
	public void RefreshToggleItem(HonamiStoryMascotCollectBookView.EMascotCollectBookType curSelectType)
	{
		if (curSelectType == this.SelectType)
		{
			this.OnSelected();
			return;
		}
		this.OnDeselected();
	}

	// Token: 0x0600F321 RID: 62241 RVA: 0x003A9A1E File Offset: 0x003A7C1E
	private void OnToggle(EToggleState toggleState)
	{
		Action<HonamiStoryMascotCollectBookView.EMascotCollectBookType> toggleCallBack = this.ToggleCallBack;
		if (toggleCallBack == null)
		{
			return;
		}
		toggleCallBack(this.SelectType);
	}

	// Token: 0x0600F322 RID: 62242 RVA: 0x003A9A36 File Offset: 0x003A7C36
	private void OnSelected()
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600F323 RID: 62243 RVA: 0x003A9A48 File Offset: 0x003A7C48
	private void OnDeselected()
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400709F RID: 28831
	private HonamiStoryMascotCollectBookView.EMascotCollectBookType SelectType;

	// Token: 0x040070A0 RID: 28832
	[Nullable(2)]
	private Action<HonamiStoryMascotCollectBookView.EMascotCollectBookType> ToggleCallBack;
}
