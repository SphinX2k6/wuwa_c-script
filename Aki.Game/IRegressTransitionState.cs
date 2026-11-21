using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000952 RID: 2386
[NullableContext(1)]
public interface IRegressTransitionState
{
	// Token: 0x0600692C RID: 26924
	void Transition(UiViewBase view);

	// Token: 0x0600692D RID: 26925
	EActivityRecallTransitionStatus GetNextStatus();

	// Token: 0x0600692E RID: 26926
	void End();

	// Token: 0x17000D14 RID: 3348
	// (get) Token: 0x0600692F RID: 26927
	Action<IRegressTransitionState> EndCallBack { get; }
}
