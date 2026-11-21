using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020003DF RID: 991
public class AchievementProgressConfirmItem : UiPanelBase
{
	// Token: 0x06003601 RID: 13825 RVA: 0x0013CA80 File Offset: 0x0013AC80
	[NullableContext(1)]
	public AchievementProgressConfirmItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06003602 RID: 13826 RVA: 0x0013CA98 File Offset: 0x0013AC98
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06003603 RID: 13827 RVA: 0x0013CB3E File Offset: 0x0013AD3E
	[NullableContext(1)]
	public void SetClickCallback(Action call)
	{
		this.OnClickCallback = call;
	}

	// Token: 0x06003604 RID: 13828 RVA: 0x0013CB47 File Offset: 0x0013AD47
	private void OnClickButton()
	{
		Action onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback();
	}

	// Token: 0x06003605 RID: 13829 RVA: 0x0013CB59 File Offset: 0x0013AD59
	public void RefreshRedPoint(bool value)
	{
		base.GetItem(1).SetUIActive(value);
	}

	// Token: 0x04002D42 RID: 11586
	[Nullable(2)]
	private Action OnClickCallback;

	// Token: 0x02006706 RID: 26374
	private enum EComponents
	{
		// Token: 0x04022097 RID: 139415
		ConfirmBtn,
		// Token: 0x04022098 RID: 139416
		RedDot
	}
}
