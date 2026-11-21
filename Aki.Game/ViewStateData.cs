using System;
using System.Runtime.CompilerServices;

// Token: 0x020007B5 RID: 1973
[NullableContext(2)]
[Nullable(0)]
internal class ViewStateData
{
	// Token: 0x06005A69 RID: 23145 RVA: 0x001D54A5 File Offset: 0x001D36A5
	public ViewStateData(EBusinessSkipDefine viewState, Action exitFunc, Delegate enterFunc)
	{
		this.ViewState = viewState;
		this.ExitFunc = exitFunc;
		this.EnterFunc = enterFunc;
	}

	// Token: 0x04003CD8 RID: 15576
	public EBusinessSkipDefine ViewState;

	// Token: 0x04003CD9 RID: 15577
	public Action ExitFunc;

	// Token: 0x04003CDA RID: 15578
	public Delegate EnterFunc;

	// Token: 0x04003CDB RID: 15579
	[Nullable(1)]
	public object[] Params = Array.Empty<object>();
}
