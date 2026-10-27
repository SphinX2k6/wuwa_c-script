using System;
using System.Runtime.CompilerServices;

// Token: 0x02001301 RID: 4865
[NullableContext(2)]
[Nullable(0)]
internal class ViewStateData
{
	// Token: 0x060086CE RID: 34510 RVA: 0x001CC639 File Offset: 0x001CA839
	public ViewStateData(EBusinessSkipDefine viewState, Action exitFunc, Delegate enterFunc)
	{
		this.ViewState = viewState;
		this.ExitFunc = exitFunc;
		this.EnterFunc = enterFunc;
	}

	// Token: 0x04003C40 RID: 15424
	public EBusinessSkipDefine ViewState;

	// Token: 0x04003C41 RID: 15425
	public Action ExitFunc;

	// Token: 0x04003C42 RID: 15426
	public Delegate EnterFunc;

	// Token: 0x04003C43 RID: 15427
	[Nullable(1)]
	public object[] Params = Array.Empty<object>();
}
