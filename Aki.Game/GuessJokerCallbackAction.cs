using System;
using System.Runtime.CompilerServices;

// Token: 0x020004CF RID: 1231
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerCallbackAction : GuessJokerActionBase
{
	// Token: 0x06003D95 RID: 15765 RVA: 0x0015C8E2 File Offset: 0x0015AAE2
	public GuessJokerCallbackAction(Action callback)
	{
		this.Callback = callback;
	}

	// Token: 0x06003D96 RID: 15766 RVA: 0x0015C8F1 File Offset: 0x0015AAF1
	protected override void OnStart()
	{
		this.Callback();
		this.Done = true;
	}

	// Token: 0x04003171 RID: 12657
	private readonly Action Callback;
}
