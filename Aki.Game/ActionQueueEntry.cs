using System;
using System.Runtime.CompilerServices;

// Token: 0x02003039 RID: 12345
[NullableContext(2)]
[Nullable(0)]
internal class ActionQueueEntry
{
	// Token: 0x0400C71B RID: 50971
	public EPerformMode Mode;

	// Token: 0x0400C71C RID: 50972
	public EPerformAction ActionType;

	// Token: 0x0400C71D RID: 50973
	[Nullable(1)]
	public IActionParamMap Param;

	// Token: 0x0400C71E RID: 50974
	public Action<int> OnBeforeExecute;

	// Token: 0x0400C71F RID: 50975
	public Action<int> OnAfterExecute;

	// Token: 0x0400C720 RID: 50976
	public bool Persistent;

	// Token: 0x0400C721 RID: 50977
	public EPerformGroup Group;

	// Token: 0x0400C722 RID: 50978
	public int LoadId;

	// Token: 0x0400C723 RID: 50979
	public bool Loaded;
}
