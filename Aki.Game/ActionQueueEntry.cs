using System;
using System.Runtime.CompilerServices;

// Token: 0x0200258F RID: 9615
[NullableContext(2)]
[Nullable(0)]
internal class ActionQueueEntry
{
	// Token: 0x0400CAF4 RID: 51956
	public EPerformMode Mode;

	// Token: 0x0400CAF5 RID: 51957
	public EPerformAction ActionType;

	// Token: 0x0400CAF6 RID: 51958
	[Nullable(1)]
	public IActionParamMap Param;

	// Token: 0x0400CAF7 RID: 51959
	public Action<int> OnBeforeExecute;

	// Token: 0x0400CAF8 RID: 51960
	public Action<int> OnAfterExecute;

	// Token: 0x0400CAF9 RID: 51961
	public bool Persistent;

	// Token: 0x0400CAFA RID: 51962
	public EPerformGroup Group;

	// Token: 0x0400CAFB RID: 51963
	public int LoadId;

	// Token: 0x0400CAFC RID: 51964
	public bool Loaded;
}
