using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200149E RID: 5278
[NullableContext(1)]
public interface IRegressTransitionState
{
	// Token: 0x06009597 RID: 38295
	void Transition(UiViewBase view);

	// Token: 0x06009598 RID: 38296
	EActivityRecallTransitionStatus GetNextStatus();

	// Token: 0x06009599 RID: 38297
	void End();

	// Token: 0x17000CF4 RID: 3316
	// (get) Token: 0x0600959A RID: 38298
	Action<IRegressTransitionState> EndCallBack { get; }
}
