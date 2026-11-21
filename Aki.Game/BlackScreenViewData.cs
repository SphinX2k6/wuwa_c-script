using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000BCA RID: 3018
public class BlackScreenViewData
{
	// Token: 0x06007D62 RID: 32098 RVA: 0x0026CC28 File Offset: 0x0026AE28
	private void TriggerStateDelegate(BlackScreenViewData.EState state)
	{
		Action action;
		if (this.StateDelegateMap.TryGetValue(state, out action))
		{
			action();
		}
	}

	// Token: 0x06007D63 RID: 32099 RVA: 0x0026CC4B File Offset: 0x0026AE4B
	[NullableContext(1)]
	public void RegisterStateDelegate(BlackScreenViewData.EState state, Action @delegate)
	{
		this.StateDelegateMap[state] = @delegate;
	}

	// Token: 0x06007D64 RID: 32100 RVA: 0x0026CC5A File Offset: 0x0026AE5A
	public void TriggerCurrentStateDelegate()
	{
		this.TriggerStateDelegate(this.State);
	}

	// Token: 0x06007D65 RID: 32101 RVA: 0x0026CC68 File Offset: 0x0026AE68
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

	// Token: 0x04004DEE RID: 19950
	private BlackScreenViewData.EState State;

	// Token: 0x04004DEF RID: 19951
	[Nullable(1)]
	private readonly Dictionary<BlackScreenViewData.EState, Action> StateDelegateMap = new Dictionary<BlackScreenViewData.EState, Action>();

	// Token: 0x02006E4A RID: 28234
	public enum EState
	{
		// Token: 0x040241F8 RID: 147960
		None,
		// Token: 0x040241F9 RID: 147961
		ShowWithOutAnim,
		// Token: 0x040241FA RID: 147962
		Show,
		// Token: 0x040241FB RID: 147963
		HideWithOutAnim,
		// Token: 0x040241FC RID: 147964
		Hide
	}
}
