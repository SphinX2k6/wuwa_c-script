using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000954 RID: 2388
[NullableContext(1)]
[Nullable(0)]
public class RecallRequestRewardState : IRegressTransitionState
{
	// Token: 0x17000D16 RID: 3350
	// (get) Token: 0x06006935 RID: 26933 RVA: 0x0020D74A File Offset: 0x0020B94A
	public Action<IRegressTransitionState> EndCallBack { get; }

	// Token: 0x06006936 RID: 26934 RVA: 0x0020D752 File Offset: 0x0020B952
	public RecallRequestRewardState(Action<IRegressTransitionState> endCallBack)
	{
		this.EndCallBack = endCallBack;
	}

	// Token: 0x06006937 RID: 26935 RVA: 0x0020D761 File Offset: 0x0020B961
	public void Transition(UiViewBase view)
	{
	}

	// Token: 0x06006938 RID: 26936 RVA: 0x0020D763 File Offset: 0x0020B963
	public EActivityRecallTransitionStatus GetNextStatus()
	{
		return EActivityRecallTransitionStatus.ReqRewardAndJumpActivity;
	}

	// Token: 0x06006939 RID: 26937 RVA: 0x0020D766 File Offset: 0x0020B966
	public void End()
	{
		this.EndCallBack(this);
	}
}
