using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000953 RID: 2387
[NullableContext(1)]
[Nullable(0)]
public class RecallShowRewardState : IRegressTransitionState
{
	// Token: 0x17000D15 RID: 3349
	// (get) Token: 0x06006930 RID: 26928 RVA: 0x0020D720 File Offset: 0x0020B920
	public Action<IRegressTransitionState> EndCallBack { get; }

	// Token: 0x06006931 RID: 26929 RVA: 0x0020D728 File Offset: 0x0020B928
	public RecallShowRewardState(Action<IRegressTransitionState> endCallBack)
	{
		this.EndCallBack = endCallBack;
	}

	// Token: 0x06006932 RID: 26930 RVA: 0x0020D737 File Offset: 0x0020B937
	public void Transition(UiViewBase view)
	{
	}

	// Token: 0x06006933 RID: 26931 RVA: 0x0020D739 File Offset: 0x0020B939
	public EActivityRecallTransitionStatus GetNextStatus()
	{
		return EActivityRecallTransitionStatus.WaitToGetReward;
	}

	// Token: 0x06006934 RID: 26932 RVA: 0x0020D73C File Offset: 0x0020B93C
	public void End()
	{
		this.EndCallBack(this);
	}
}
