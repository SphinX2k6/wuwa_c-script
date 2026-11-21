using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200167B RID: 5755
[NullableContext(1)]
[Nullable(0)]
public class LordChallengeResultButton : UiPanelBase
{
	// Token: 0x0600E009 RID: 57353 RVA: 0x0041C3B4 File Offset: 0x0041A5B4
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

	// Token: 0x0600E00A RID: 57354 RVA: 0x0041C447 File Offset: 0x0041A647
	protected override void OnBeforeShow()
	{
		base.GetText(0).SetText("", true);
		base.GetText(2).SetText("", true);
	}

	// Token: 0x0600E00B RID: 57355 RVA: 0x0041C470 File Offset: 0x0041A670
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

	// Token: 0x0600E00C RID: 57356 RVA: 0x0041C4C3 File Offset: 0x0041A6C3
	private void OnClickedButton()
	{
		Action onClickEvent = this.OnClickEvent;
		if (onClickEvent == null)
		{
			return;
		}
		onClickEvent();
	}

	// Token: 0x0600E00D RID: 57357 RVA: 0x0041C4D5 File Offset: 0x0041A6D5
	public void SetFloatText(string text)
	{
		base.GetText(2).SetUIActive(true);
		base.GetText(2).SetText(text, true);
	}

	// Token: 0x0600E00E RID: 57358 RVA: 0x0041C4F2 File Offset: 0x0041A6F2
	public void SetFloatText(string textId, params string[] args)
	{
		base.GetText(2).SetUIActive(true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textId, args);
	}

	// Token: 0x0600E00F RID: 57359 RVA: 0x0041C514 File Offset: 0x0041A714
	public void SetBtnText(string text)
	{
		base.GetText(0).SetText(text, true);
	}

	// Token: 0x04008099 RID: 32921
	[Nullable(2)]
	private Action OnClickEvent;

	// Token: 0x0200784D RID: 30797
	[NullableContext(0)]
	private class EButtonChildType
	{
		// Token: 0x040270A3 RID: 159907
		public const int ButtonText = 0;

		// Token: 0x040270A4 RID: 159908
		public const int DescriptionItem = 1;

		// Token: 0x040270A5 RID: 159909
		public const int DescriptionText = 2;

		// Token: 0x040270A6 RID: 159910
		public const int Button = 3;
	}
}
