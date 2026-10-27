using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011FB RID: 4603
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingButton : UiPanelBase
{
	// Token: 0x06007B16 RID: 31510 RVA: 0x0019EFC4 File Offset: 0x0019D1C4
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

	// Token: 0x06007B17 RID: 31511 RVA: 0x0019F0AC File Offset: 0x0019D2AC
	protected override void OnBeforeShow()
	{
		base.GetText(0).SetText("", true);
		base.GetText(2).SetText("", true);
	}

	// Token: 0x06007B18 RID: 31512 RVA: 0x0019F0D4 File Offset: 0x0019D2D4
	public UniTask InitializeAsync(AActor rootActor, Action onClickCall)
	{
		ActivityCorniceMeetingButton.<InitializeAsync>d__4 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.rootActor = rootActor;
		<InitializeAsync>d__.onClickCall = onClickCall;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<ActivityCorniceMeetingButton.<InitializeAsync>d__4>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007B19 RID: 31513 RVA: 0x0019F127 File Offset: 0x0019D327
	private void OnClickedButton()
	{
		Action onClickEvent = this.OnClickEvent;
		if (onClickEvent == null)
		{
			return;
		}
		onClickEvent();
	}

	// Token: 0x06007B1A RID: 31514 RVA: 0x0019F139 File Offset: 0x0019D339
	public void SetFloatText(string textId, params string[] args)
	{
		base.GetText(2).SetUIActive(true);
		LguiUtil.Instance.SetLocalText(base.GetText(2), textId, args);
	}

	// Token: 0x06007B1B RID: 31515 RVA: 0x0019F15B File Offset: 0x0019D35B
	public void SetBtnText(string textId, params string[] args)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(0), textId, args);
	}

	// Token: 0x0400385C RID: 14428
	[Nullable(2)]
	private Action OnClickEvent;

	// Token: 0x020077E2 RID: 30690
	[NullableContext(0)]
	private class ESimpleButtonChildType
	{
		// Token: 0x04027851 RID: 161873
		public const int ButtonText = 0;

		// Token: 0x04027852 RID: 161874
		public const int DescriptionItem = 1;

		// Token: 0x04027853 RID: 161875
		public const int DescriptionText = 2;

		// Token: 0x04027854 RID: 161876
		public const int Button = 3;
	}
}
