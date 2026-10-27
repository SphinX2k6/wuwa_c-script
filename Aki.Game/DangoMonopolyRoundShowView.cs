using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200124D RID: 4685
public class DangoMonopolyRoundShowView : DangoMonopolyViewBase
{
	// Token: 0x17000ACE RID: 2766
	// (get) Token: 0x06007F31 RID: 32561 RVA: 0x001AF10A File Offset: 0x001AD30A
	[Nullable(2)]
	public new DangoMonopolyRoundShowViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as DangoMonopolyRoundShowViewParams;
		}
	}

	// Token: 0x06007F32 RID: 32562 RVA: 0x001AF117 File Offset: 0x001AD317
	[NullableContext(1)]
	public DangoMonopolyRoundShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007F33 RID: 32563 RVA: 0x001AF120 File Offset: 0x001AD320
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x06007F34 RID: 32564 RVA: 0x001AF143 File Offset: 0x001AD343
	private void InitDataParam()
	{
	}

	// Token: 0x06007F35 RID: 32565 RVA: 0x001AF148 File Offset: 0x001AD348
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyRoundShowView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyRoundShowView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007F36 RID: 32566 RVA: 0x001AF18C File Offset: 0x001AD38C
	protected override void OnStart()
	{
		UUIText text = base.GetText(0);
		DangoMonopolyRoundShowViewParams openParam = this.OpenParam;
		text.SetText(((openParam != null) ? openParam.TipsText : null) ?? "", true);
		TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.ShowTimeCallback), this.OpenParam.ShowTime, null, null, true, 1f);
	}

	// Token: 0x06007F37 RID: 32567 RVA: 0x001AF1EB File Offset: 0x001AD3EB
	protected override void OnAfterPlayStartSequence()
	{
		this.AwaitOpenAfterClose().Forget();
	}

	// Token: 0x06007F38 RID: 32568 RVA: 0x001AF1F8 File Offset: 0x001AD3F8
	private UniTask AwaitOpenAfterClose()
	{
		DangoMonopolyRoundShowView.<AwaitOpenAfterClose>d__9 <AwaitOpenAfterClose>d__;
		<AwaitOpenAfterClose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AwaitOpenAfterClose>d__.<>4__this = this;
		<AwaitOpenAfterClose>d__.<>1__state = -1;
		<AwaitOpenAfterClose>d__.<>t__builder.Start<DangoMonopolyRoundShowView.<AwaitOpenAfterClose>d__9>(ref <AwaitOpenAfterClose>d__);
		return <AwaitOpenAfterClose>d__.<>t__builder.Task;
	}

	// Token: 0x06007F39 RID: 32569 RVA: 0x001AF23B File Offset: 0x001AD43B
	private void ShowTimeCallback(float _)
	{
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x06007F3A RID: 32570 RVA: 0x001AF250 File Offset: 0x001AD450
	protected override void OnBeforeDestroy()
	{
		DangoMonopolyRoundShowViewParams openParam = this.OpenParam;
		int boardId = (openParam != null) ? openParam.BoardId : 0;
		DangoMonopolyRoundShowViewParams openParam2 = this.OpenParam;
		CustomPromise promise = (openParam2 != null) ? openParam2.Promise : null;
		UiManager.Instance.OpenView(EUiViewName.DangoMonopolyRoundBuffShowView, new DangoMonopolyRoundBuffShowViewParam
		{
			BoardId = boardId,
			Promise = promise
		}, null);
	}

	// Token: 0x02007864 RID: 30820
	private enum EChildType
	{
		// Token: 0x04027ABC RID: 162492
		TxtDesc
	}
}
