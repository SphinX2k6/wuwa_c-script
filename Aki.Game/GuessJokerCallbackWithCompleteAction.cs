using System;
using System.Runtime.CompilerServices;

// Token: 0x0200101C RID: 4124
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerCallbackWithCompleteAction : GuessJokerActionBase
{
	// Token: 0x06006A02 RID: 27138 RVA: 0x00153FDD File Offset: 0x001521DD
	public GuessJokerCallbackWithCompleteAction(Action<Action> callback)
	{
		this.Callback = callback;
	}

	// Token: 0x06006A03 RID: 27139 RVA: 0x00153FEC File Offset: 0x001521EC
	protected override void OnStart()
	{
		this.Callback(delegate
		{
			this.Done = true;
		});
	}

	// Token: 0x040030D9 RID: 12505
	private readonly Action<Action> Callback;
}
