using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200149F RID: 5279
[NullableContext(1)]
[Nullable(0)]
public class RecallShowRewardState : IRegressTransitionState
{
	// Token: 0x17000CF5 RID: 3317
	// (get) Token: 0x0600959B RID: 38299 RVA: 0x002047B8 File Offset: 0x002029B8
	public Action<IRegressTransitionState> EndCallBack { get; }

	// Token: 0x0600959C RID: 38300 RVA: 0x002047C0 File Offset: 0x002029C0
	public RecallShowRewardState(Action<IRegressTransitionState> endCallBack)
	{
		this.EndCallBack = endCallBack;
	}

	// Token: 0x0600959D RID: 38301 RVA: 0x002047CF File Offset: 0x002029CF
	public void Transition(UiViewBase view)
	{
	}

	// Token: 0x0600959E RID: 38302 RVA: 0x002047D1 File Offset: 0x002029D1
	public EActivityRecallTransitionStatus GetNextStatus()
	{
		return EActivityRecallTransitionStatus.WaitToGetReward;
	}

	// Token: 0x0600959F RID: 38303 RVA: 0x002047D4 File Offset: 0x002029D4
	public void End()
	{
		this.EndCallBack(this);
	}
}
