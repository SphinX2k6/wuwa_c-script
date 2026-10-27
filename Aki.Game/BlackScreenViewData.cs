using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001712 RID: 5906
public class BlackScreenViewData
{
	// Token: 0x0600A97F RID: 43391 RVA: 0x002626D8 File Offset: 0x002608D8
	private void TriggerStateDelegate(BlackScreenViewData.EState state)
	{
		Action action;
		if (this.StateDelegateMap.TryGetValue(state, out action))
		{
			action();
		}
	}

	// Token: 0x0600A980 RID: 43392 RVA: 0x002626FB File Offset: 0x002608FB
	[NullableContext(1)]
	public void RegisterStateDelegate(BlackScreenViewData.EState state, Action @delegate)
	{
		this.StateDelegateMap[state] = @delegate;
	}

	// Token: 0x0600A981 RID: 43393 RVA: 0x0026270A File Offset: 0x0026090A
	public void TriggerCurrentStateDelegate()
	{
		this.TriggerStateDelegate(this.State);
	}

	// Token: 0x0600A982 RID: 43394 RVA: 0x00262718 File Offset: 0x00260918
	public bool SwitchState(BlackScreenViewData.EState state)
	{
		if (this.State == state)
		{
			return false;
		}
		this.State = state;
		this.TriggerStateDelegate(state);
		return true;
	}

	// Token: 0x04004D46 RID: 19782
	private BlackScreenViewData.EState State;

	// Token: 0x04004D47 RID: 19783
	[Nullable(1)]
	private readonly Dictionary<BlackScreenViewData.EState, Action> StateDelegateMap = new Dictionary<BlackScreenViewData.EState, Action>();

	// Token: 0x02007CC5 RID: 31941
	public enum EState
	{
		// Token: 0x04028ECF RID: 167631
		None,
		// Token: 0x04028ED0 RID: 167632
		ShowWithOutAnim,
		// Token: 0x04028ED1 RID: 167633
		Show,
		// Token: 0x04028ED2 RID: 167634
		HideWithOutAnim,
		// Token: 0x04028ED3 RID: 167635
		Hide
	}
}
