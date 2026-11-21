using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000955 RID: 2389
[NullableContext(1)]
[Nullable(0)]
public class RecallFinishState : IRegressTransitionState
{
	// Token: 0x17000D17 RID: 3351
	// (get) Token: 0x0600693A RID: 26938 RVA: 0x0020D774 File Offset: 0x0020B974
	public Action<IRegressTransitionState> EndCallBack { get; }

	// Token: 0x0600693B RID: 26939 RVA: 0x0020D77C File Offset: 0x0020B97C
	public RecallFinishState(Action<IRegressTransitionState> endCallBack)
	{
		this.EndCallBack = endCallBack;
	}

	// Token: 0x0600693C RID: 26940 RVA: 0x0020D78B File Offset: 0x0020B98B
	public void Transition(UiViewBase view)
	{
		((ActivityRegressStartupView)view).GotoActivityViewAndCloseSelf();
		this.End();
	}

	// Token: 0x0600693D RID: 26941 RVA: 0x0020D79E File Offset: 0x0020B99E
	public EActivityRecallTransitionStatus GetNextStatus()
	{
		return EActivityRecallTransitionStatus.Finish;
	}

	// Token: 0x0600693E RID: 26942 RVA: 0x0020D7A1 File Offset: 0x0020B9A1
	public void End()
	{
		this.EndCallBack(this);
	}
}
