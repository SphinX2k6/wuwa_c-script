using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020014A0 RID: 5280
[NullableContext(1)]
[Nullable(0)]
public class RecallRequestRewardState : IRegressTransitionState
{
	// Token: 0x17000CF6 RID: 3318
	// (get) Token: 0x060095A0 RID: 38304 RVA: 0x002047E2 File Offset: 0x002029E2
	public Action<IRegressTransitionState> EndCallBack { get; }

	// Token: 0x060095A1 RID: 38305 RVA: 0x002047EA File Offset: 0x002029EA
	public RecallRequestRewardState(Action<IRegressTransitionState> endCallBack)
	{
		this.EndCallBack = endCallBack;
	}

	// Token: 0x060095A2 RID: 38306 RVA: 0x002047F9 File Offset: 0x002029F9
	public void Transition(UiViewBase view)
	{
	}

	// Token: 0x060095A3 RID: 38307 RVA: 0x002047FB File Offset: 0x002029FB
	public EActivityRecallTransitionStatus GetNextStatus()
	{
		return EActivityRecallTransitionStatus.ReqRewardAndJumpActivity;
	}

	// Token: 0x060095A4 RID: 38308 RVA: 0x002047FE File Offset: 0x002029FE
	public void End()
	{
		this.EndCallBack(this);
	}
}
