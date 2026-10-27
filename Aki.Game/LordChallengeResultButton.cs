using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002197 RID: 8599
[NullableContext(1)]
[Nullable(0)]
public class LordChallengeResultButton : UiPanelBase
{
	// Token: 0x06010B78 RID: 68472 RVA: 0x0040FACC File Offset: 0x0040DCCC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickedButton))
		};
	}

	// Token: 0x06010B79 RID: 68473 RVA: 0x0040FB5F File Offset: 0x0040DD5F
	protected override void OnBeforeShow()
	{
		base.GetText(0).SetText("", true);
		base.GetText(2).SetText("", true);
	}

	// Token: 0x06010B7A RID: 68474 RVA: 0x0040FB88 File Offset: 0x0040DD88
	public UniTask InitializeAsync(AActor rootActor, Action onClickCall)
	{
		LordChallengeResultButton.<InitializeAsync>d__4 <InitializeAsync>d__;
		<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeAsync>d__.<>4__this = this;
		<InitializeAsync>d__.rootActor = rootActor;
		<InitializeAsync>d__.onClickCall = onClickCall;
		<InitializeAsync>d__.<>1__state = -1;
		<InitializeAsync>d__.<>t__builder.Start<LordChallengeResultButton.<InitializeAsync>d__4>(ref <InitializeAsync>d__);
		return <InitializeAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010B7B RID: 68475 RVA: 0x0040FBDB File Offset: 0x0040DDDB
	private void OnClickedButton()
	{
		Action onClickEvent = this.OnClickEvent;
		if (onClickEvent == null)
		{
			return;
		}
		onClickEvent();
	}

	// Token: 0x06010B7C RID: 68476 RVA: 0x0040FBED File Offset: 0x0040DDED
	public void SetFloatText(string text)
	{
		base.GetText(2).SetUIActive(true);
		base.GetText(2).SetText(text, true);
	}

	// Token: 0x06010B7D RID: 68477 RVA: 0x0040FC0A File Offset: 0x0040DE0A
	public void SetFloatText(string textId, params string[] args)
	{
		base.GetText(2).SetUIActive(true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
	}

	// Token: 0x06010B7E RID: 68478 RVA: 0x0040FC2C File Offset: 0x0040DE2C
	public void SetBtnText(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x04007F52 RID: 32594
	[Nullable(2)]
	private Action OnClickEvent;

	// Token: 0x020086C2 RID: 34498
	[NullableContext(0)]
	private class EButtonChildType
	{
		// Token: 0x0402BD82 RID: 179586
		public const int ButtonText = 0;

		// Token: 0x0402BD83 RID: 179587
		public const int DescriptionItem = 1;

		// Token: 0x0402BD84 RID: 179588
		public const int DescriptionText = 2;

		// Token: 0x0402BD85 RID: 179589
		public const int Button = 3;
	}
}
