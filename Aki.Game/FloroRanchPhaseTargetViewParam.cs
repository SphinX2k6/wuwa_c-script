using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

// Token: 0x0200100D RID: 4109
[NullableContext(1)]
[Nullable(0)]
public struct FloroRanchPhaseTargetViewParam
{
	// Token: 0x04006037 RID: 24631
	public FloroRanchStageStart StageStartData;

	// Token: 0x04006038 RID: 24632
	public Func<UniTask> CloseCallback;
}
