using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200100B RID: 4107
[NullableContext(1)]
[Nullable(0)]
public struct FloroRanchPhaseSettleViewParam
{
	// Token: 0x04006034 RID: 24628
	public FloroRanchStageEnd StageEndData;

	// Token: 0x04006035 RID: 24629
	public Action<bool> CloseCallback;
}
