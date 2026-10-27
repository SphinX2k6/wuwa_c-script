using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020014A2 RID: 5282
[NullableContext(1)]
[Nullable(0)]
public class RegressTransitionStateMachine
{
	// Token: 0x060095AA RID: 38314 RVA: 0x00204847 File Offset: 0x00202A47
	public void Start()
	{
		this.SetState(EActivityRecallTransitionStatus.Init);
	}

	// Token: 0x060095AB RID: 38315 RVA: 0x00204850 File Offset: 0x00202A50
	public void ShutDown()
	{
		Dictionary<EActivityRecallTransitionStatus, IRegressTransitionState> stateMap = this.StateMap;
		if (stateMap != null)
		{
			stateMap.Clear();
		}
		this.StateMap = null;
		this.CurrentState = null;
	}

	// Token: 0x060095AC RID: 38316 RVA: 0x00204874 File Offset: 0x00202A74
	public unsafe void PlayNextState()
	{
		if (this.CurrentState == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityRegress;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "回归活动->RecallTransitionStateMachine.PlayNextState->";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("无法自动播放下一个状态, 当前状态为空 State", this.CurrentState);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前状态", this.Status);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.CurrentState.End();
	}

	// Token: 0x060095AD RID: 38317 RVA: 0x002048FC File Offset: 0x00202AFC
	public unsafe void SetState(EActivityRecallTransitionStatus status)
	{
		if (status == EActivityRecallTransitionStatus.Finish)
		{
			return;
		}
		IRegressTransitionState state = this.GetState(status);
		if (state != null)
		{
			this.CurrentState = state;
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.ActivityRegressStartupView);
			if (viewByName != null)
			{
				this.Status = new EActivityRecallTransitionStatus?(status);
				state.Transition(viewByName);
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityRegress;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "回归活动->RecallTransitionStateMachine.SetState->";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("播放状态异常, ActivityRecallStartView界面未加载, 目标状态", status);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前状态", this.Status);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x060095AE RID: 38318 RVA: 0x002049AF File Offset: 0x00202BAF
	private void OnEndCallBack(IRegressTransitionState state)
	{
		this.NextState(state);
	}

	// Token: 0x060095AF RID: 38319 RVA: 0x002049B8 File Offset: 0x00202BB8
	private unsafe void NextState(IRegressTransitionState state)
	{
		if (this.CurrentState != null && state != this.CurrentState)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.ActivityRegress;
			ELogAuthor author = ELogAuthor.LRX;
			string message = "回归活动->RecallTransitionStateMachine.OnTransitionComplete->";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("状态切换异常，结束状态与当前状态不对称, EndState", state);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentState", this.CurrentState);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.CurrentState = null;
		EActivityRecallTransitionStatus nextStatus = state.GetNextStatus();
		this.SetState(nextStatus);
	}

	// Token: 0x060095B0 RID: 38320 RVA: 0x00204A48 File Offset: 0x00202C48
	[NullableContext(2)]
	private unsafe IRegressTransitionState GetState(EActivityRecallTransitionStatus status)
	{
		if (this.StateMap == null)
		{
			this.StateMap = new Dictionary<EActivityRecallTransitionStatus, IRegressTransitionState>();
		}
		IRegressTransitionState regressTransitionState;
		if (!this.StateMap.TryGetValue(status, out regressTransitionState))
		{
			switch (status)
			{
			case EActivityRecallTransitionStatus.Init:
				regressTransitionState = new RecallShowRewardState(new Action<IRegressTransitionState>(this.OnEndCallBack));
				break;
			case EActivityRecallTransitionStatus.WaitToGetReward:
				regressTransitionState = new RecallRequestRewardState(new Action<IRegressTransitionState>(this.OnEndCallBack));
				break;
			case EActivityRecallTransitionStatus.ReqRewardAndJumpActivity:
				regressTransitionState = new RecallFinishState(new Action<IRegressTransitionState>(this.OnEndCallBack));
				break;
			default:
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityRegress;
				ELogAuthor author = ELogAuthor.LRX;
				string message = "回归活动->RecallTransitionStateMachine.GetState->";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("播放状态异常, 在未定义对应的状态, 目标状态", status);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("当前状态", this.Status);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				break;
			}
			}
		}
		if (regressTransitionState != null)
		{
			this.StateMap[status] = regressTransitionState;
		}
		return regressTransitionState;
	}

	// Token: 0x04004225 RID: 16933
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EActivityRecallTransitionStatus, IRegressTransitionState> StateMap;

	// Token: 0x04004226 RID: 16934
	private EActivityRecallTransitionStatus? Status;

	// Token: 0x04004227 RID: 16935
	[Nullable(2)]
	private IRegressTransitionState CurrentState;
}
