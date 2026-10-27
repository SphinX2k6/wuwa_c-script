using System;
using System.Runtime.CompilerServices;

// Token: 0x0200101B RID: 4123
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerCallbackAction : GuessJokerActionBase
{
	// Token: 0x06006A00 RID: 27136 RVA: 0x00153FBA File Offset: 0x001521BA
	public GuessJokerCallbackAction(Action callback)
	{
		this.Callback = callback;
	}

	// Token: 0x06006A01 RID: 27137 RVA: 0x00153FC9 File Offset: 0x001521C9
	protected override void OnStart()
	{
		this.Callback();
		this.Done = true;
	}

	// Token: 0x040030D8 RID: 12504
	private readonly Action Callback;
}
