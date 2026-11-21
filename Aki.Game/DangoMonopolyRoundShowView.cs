using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000701 RID: 1793
public class DangoMonopolyRoundShowView : DangoMonopolyViewBase
{
	// Token: 0x17000AEE RID: 2798
	// (get) Token: 0x060052C8 RID: 21192 RVA: 0x001B7DC2 File Offset: 0x001B5FC2
	[Nullable(2)]
	public new DangoMonopolyRoundShowViewParams OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as DangoMonopolyRoundShowViewParams;
		}
	}

	// Token: 0x060052C9 RID: 21193 RVA: 0x001B7DCF File Offset: 0x001B5FCF
	[NullableContext(1)]
	public DangoMonopolyRoundShowView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060052CA RID: 21194 RVA: 0x001B7DD8 File Offset: 0x001B5FD8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText))
		};
	}

	// Token: 0x060052CB RID: 21195 RVA: 0x001B7DFB File Offset: 0x001B5FFB
	private void InitDataParam()
	{
	}

	// Token: 0x060052CC RID: 21196 RVA: 0x001B7E00 File Offset: 0x001B6000
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyRoundShowView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyRoundShowView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060052CD RID: 21197 RVA: 0x001B7E44 File Offset: 0x001B6044
	protected override void OnStart()
	{
		UUIText text = base.GetText(0);
		DangoMonopolyRoundShowViewParams openParam = this.OpenParam;
		text.SetText(((openParam != null) ? openParam.TipsText : null) ?? "", true);
		TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.ShowTimeCallback), this.OpenParam.ShowTime, null, null, true, 1f);
	}

	// Token: 0x060052CE RID: 21198 RVA: 0x001B7EA3 File Offset: 0x001B60A3
	protected override void OnAfterPlayStartSequence()
	{
		this.AwaitOpenAfterClose().Forget();
	}

	// Token: 0x060052CF RID: 21199 RVA: 0x001B7EB0 File Offset: 0x001B60B0
	private UniTask AwaitOpenAfterClose()
	{
		DangoMonopolyRoundShowView.<AwaitOpenAfterClose>d__9 <AwaitOpenAfterClose>d__;
		<AwaitOpenAfterClose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AwaitOpenAfterClose>d__.<>4__this = this;
		<AwaitOpenAfterClose>d__.<>1__state = -1;
		<AwaitOpenAfterClose>d__.<>t__builder.Start<DangoMonopolyRoundShowView.<AwaitOpenAfterClose>d__9>(ref <AwaitOpenAfterClose>d__);
		return <AwaitOpenAfterClose>d__.<>t__builder.Task;
	}

	// Token: 0x060052D0 RID: 21200 RVA: 0x001B7EF3 File Offset: 0x001B60F3
	private void ShowTimeCallback(float _)
	{
		if (base.IsDestroyOrDestroying)
		{
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x060052D1 RID: 21201 RVA: 0x001B7F08 File Offset: 0x001B6108
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

	// Token: 0x020069EF RID: 27119
	private enum EChildType
	{
		// Token: 0x04022DED RID: 142829
		TxtDesc
	}
}
