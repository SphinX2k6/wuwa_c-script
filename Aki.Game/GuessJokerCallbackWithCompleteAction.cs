using System;
using System.Runtime.CompilerServices;

// Token: 0x020004D0 RID: 1232
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerCallbackWithCompleteAction : GuessJokerActionBase
{
	// Token: 0x06003D97 RID: 15767 RVA: 0x0015C905 File Offset: 0x0015AB05
	public GuessJokerCallbackWithCompleteAction(Action<Action> callback)
	{
		this.Callback = callback;
	}

	// Token: 0x06003D98 RID: 15768 RVA: 0x0015C914 File Offset: 0x0015AB14
	protected override void OnStart()
	{
		this.Callback(delegate
		{
			this.Done = true;
		});
	}

	// Token: 0x04003172 RID: 12658
	private readonly Action<Action> Callback;
}
