using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

// Token: 0x02001B4E RID: 6990
[NullableContext(1)]
[Nullable(0)]
public struct FloroRanchPhaseTargetViewParam
{
	// Token: 0x04005F68 RID: 24424
	public FloroRanchStageStart StageStartData;

	// Token: 0x04005F69 RID: 24425
	public Func<UniTask> CloseCallback;
}
