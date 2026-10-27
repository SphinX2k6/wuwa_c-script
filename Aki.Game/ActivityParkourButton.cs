using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020014D0 RID: 5328
[NullableContext(1)]
[Nullable(0)]
public class ActivityParkourButton : UiPanelBase
{
	// Token: 0x06009757 RID: 38743 RVA: 0x0020B430 File Offset: 0x00209630
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

	// Token: 0x06009758 RID: 38744 RVA: 0x0020B518 File Offset: 0x00209718
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

	// Token: 0x06009759 RID: 38745 RVA: 0x0020B54C File Offset: 0x0020974C
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

	// Token: 0x0600975A RID: 38746 RVA: 0x0020B59F File Offset: 0x0020979F
	private void OnClickedButton()
	{
		Action onClickEvent = this.OnClickEvent;
		if (onClickEvent == null)
		{
			return;
		}
		onClickEvent();
	}

	// Token: 0x0600975B RID: 38747 RVA: 0x0020B5B1 File Offset: 0x002097B1
	public void SetFloatText(string textId, params string[] args)
	{
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(true);
		}
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
	}

	// Token: 0x0600975C RID: 38748 RVA: 0x0020B5D9 File Offset: 0x002097D9
	public void SetBtnText(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), textId, args);
	}

	// Token: 0x040042AA RID: 17066
	[Nullable(2)]
	private Action OnClickEvent;

	// Token: 0x02007B09 RID: 31497
	[NullableContext(0)]
	private class ESimpleButtonChildType
	{
		// Token: 0x04028771 RID: 165745
		public const int ButtonText = 0;

		// Token: 0x04028772 RID: 165746
		public const int DescriptionItem = 1;

		// Token: 0x04028773 RID: 165747
		public const int DescriptionText = 2;

		// Token: 0x04028774 RID: 165748
		public const int Button = 3;
	}
}
