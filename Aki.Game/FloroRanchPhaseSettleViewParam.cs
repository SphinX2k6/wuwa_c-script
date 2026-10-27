using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001B4C RID: 6988
[NullableContext(1)]
[Nullable(0)]
public struct FloroRanchPhaseSettleViewParam
{
	// Token: 0x04005F65 RID: 24421
	public FloroRanchStageEnd StageEndData;

	// Token: 0x04005F66 RID: 24422
	public Action<bool> CloseCallback;
}
