using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000F2A RID: 3882
public class AchievementProgressConfirmItem : UiPanelBase
{
	// Token: 0x06006269 RID: 25193 RVA: 0x00134158 File Offset: 0x00132358
	[NullableContext(1)]
	public AchievementProgressConfirmItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600626A RID: 25194 RVA: 0x00134170 File Offset: 0x00132370
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

	// Token: 0x0600626B RID: 25195 RVA: 0x00134216 File Offset: 0x00132416
	[NullableContext(1)]
	public void SetClickCallback(Action call)
	{
		this.OnClickCallback = call;
	}

	// Token: 0x0600626C RID: 25196 RVA: 0x0013421F File Offset: 0x0013241F
	private void OnClickButton()
	{
		Action onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback();
	}

	// Token: 0x0600626D RID: 25197 RVA: 0x00134231 File Offset: 0x00132431
	public void RefreshRedPoint(bool value)
	{
		base.GetItem(1).SetUIActive(value);
	}

	// Token: 0x04002CA9 RID: 11433
	[Nullable(2)]
	private Action OnClickCallback;

	// Token: 0x02007572 RID: 30066
	private enum EComponents
	{
		// Token: 0x04026D4C RID: 159052
		ConfirmBtn,
		// Token: 0x04026D4D RID: 159053
		RedDot
	}
}
