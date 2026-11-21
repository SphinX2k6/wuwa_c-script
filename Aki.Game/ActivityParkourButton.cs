using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000988 RID: 2440
[NullableContext(1)]
[Nullable(0)]
public class ActivityParkourButton : UiPanelBase
{
	// Token: 0x06006B31 RID: 27441 RVA: 0x00215170 File Offset: 0x00213370
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickedButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006B32 RID: 27442 RVA: 0x00215258 File Offset: 0x00213458
	protected override void OnBeforeShow()
	{
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText("", true);
		}
		UUIText text2 = base.GetText(2);
		if (text2 == null)
		{
			return;
		}
		text2.SetText("", true);
	}

	// Token: 0x06006B33 RID: 27443 RVA: 0x0021528C File Offset: 0x0021348C
	public UniTask InitializeAsync(AActor rootActor, Action onClickCall)
	{
		ActivityParkourButton.<InitializeAsync>d__4 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.rootActor = rootActor;
		<InitializeAsync>d__.onClickCall = onClickCall;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<ActivityParkourButton.<InitializeAsync>d__4>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006B34 RID: 27444 RVA: 0x002152DF File Offset: 0x002134DF
	private void OnClickedButton()
	{
		Action onClickEvent = this.OnClickEvent;
		if (onClickEvent == null)
		{
			return;
		}
		onClickEvent();
	}

	// Token: 0x06006B35 RID: 27445 RVA: 0x002152F1 File Offset: 0x002134F1
	public void SetFloatText(string textId, params string[] args)
	{
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
	}

	// Token: 0x06006B36 RID: 27446 RVA: 0x00215319 File Offset: 0x00213519
	public void SetBtnText(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), textId, args);
	}

	// Token: 0x0400434F RID: 17231
	[Nullable(2)]
	private Action OnClickEvent;

	// Token: 0x02006C95 RID: 27797
	[NullableContext(0)]
	private class ESimpleButtonChildType
	{
		// Token: 0x04023AAF RID: 146095
		public const int ButtonText = 0;

		// Token: 0x04023AB0 RID: 146096
		public const int DescriptionItem = 1;

		// Token: 0x04023AB1 RID: 146097
		public const int DescriptionText = 2;

		// Token: 0x04023AB2 RID: 146098
		public const int Button = 3;
	}
}
