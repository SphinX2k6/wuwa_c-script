using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015BE RID: 5566
public class WheelTowerChallengeBtn : UiPanelBase
{
	// Token: 0x06009DE0 RID: 40416 RVA: 0x00224F3C File Offset: 0x0022313C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009DE1 RID: 40417 RVA: 0x00225024 File Offset: 0x00223224
	public void SetRedDotVisible(bool visible)
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(visible);
	}

	// Token: 0x06009DE2 RID: 40418 RVA: 0x00225038 File Offset: 0x00223238
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(state);
	}

	// Token: 0x06009DE3 RID: 40419 RVA: 0x0022504C File Offset: 0x0022324C
	[NullableContext(1)]
	public void SetFunction(Action buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x06009DE4 RID: 40420 RVA: 0x00225055 File Offset: 0x00223255
	public void ExecuteButtonFunction()
	{
		Action buttonFunction = this.ButtonFunction;
		if (buttonFunction == null)
		{
			return;
		}
		buttonFunction();
	}

	// Token: 0x06009DE5 RID: 40421 RVA: 0x00225067 File Offset: 0x00223267
	private void ButtonClick()
	{
		this.ExecuteButtonFunction();
	}

	// Token: 0x040045E0 RID: 17888
	[Nullable(2)]
	private Action ButtonFunction;
}
