using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020014A1 RID: 5281
[NullableContext(1)]
[Nullable(0)]
public class RecallFinishState : IRegressTransitionState
{
	// Token: 0x17000CF7 RID: 3319
	// (get) Token: 0x060095A5 RID: 38309 RVA: 0x0020480C File Offset: 0x00202A0C
	public Action<IRegressTransitionState> EndCallBack { get; }

	// Token: 0x060095A6 RID: 38310 RVA: 0x00204814 File Offset: 0x00202A14
	public RecallFinishState(Action<IRegressTransitionState> endCallBack)
	{
		this.EndCallBack = endCallBack;
	}

	// Token: 0x060095A7 RID: 38311 RVA: 0x00204823 File Offset: 0x00202A23
	public void Transition(UiViewBase view)
	{
		((ActivityRegressStartupView)view).GotoActivityViewAndCloseSelf();
		this.End();
	}

	// Token: 0x060095A8 RID: 38312 RVA: 0x00204836 File Offset: 0x00202A36
	public EActivityRecallTransitionStatus GetNextStatus()
	{
		return EActivityRecallTransitionStatus.Finish;
	}

	// Token: 0x060095A9 RID: 38313 RVA: 0x00204839 File Offset: 0x00202A39
	public void End()
	{
		this.EndCallBack(this);
	}
}
