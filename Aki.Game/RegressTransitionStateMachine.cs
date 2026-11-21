using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000956 RID: 2390
[NullableContext(1)]
[Nullable(0)]
public class RegressTransitionStateMachine
{
	// Token: 0x0600693F RID: 26943 RVA: 0x0020D7AF File Offset: 0x0020B9AF
	public void Start()
	{
		this.SetState(EActivityRecallTransitionStatus.Init);
	}

	// Token: 0x06006940 RID: 26944 RVA: 0x0020D7B8 File Offset: 0x0020B9B8
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

	// Token: 0x06006941 RID: 26945 RVA: 0x0020D7DC File Offset: 0x0020B9DC
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

	// Token: 0x06006942 RID: 26946 RVA: 0x0020D864 File Offset: 0x0020BA64
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

	// Token: 0x06006943 RID: 26947 RVA: 0x0020D917 File Offset: 0x0020BB17
	private void OnEndCallBack(IRegressTransitionState state)
	{
		this.NextState(state);
	}

	// Token: 0x06006944 RID: 26948 RVA: 0x0020D920 File Offset: 0x0020BB20
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

	// Token: 0x06006945 RID: 26949 RVA: 0x0020D9B0 File Offset: 0x0020BBB0
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

	// Token: 0x040042BD RID: 17085
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EActivityRecallTransitionStatus, IRegressTransitionState> StateMap;

	// Token: 0x040042BE RID: 17086
	private EActivityRecallTransitionStatus? Status;

	// Token: 0x040042BF RID: 17087
	[Nullable(2)]
	private IRegressTransitionState CurrentState;
}
