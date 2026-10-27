using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x020026C7 RID: 9927
[NullableContext(1)]
public interface IDangoDungeonCommand
{
	// Token: 0x17001A5A RID: 6746
	// (get) Token: 0x060145CD RID: 83405
	// (set) Token: 0x060145CE RID: 83406
	int CommandIndex { get; set; }

	// Token: 0x17001A5B RID: 6747
	// (get) Token: 0x060145CF RID: 83407
	ERacingBetsCommandType CommandType { get; }

	// Token: 0x17001A5C RID: 6748
	// (get) Token: 0x060145D0 RID: 83408
	// (set) Token: 0x060145D1 RID: 83409
	int ActionIndex { get; set; }

	// Token: 0x17001A5D RID: 6749
	// (get) Token: 0x060145D2 RID: 83410
	// (set) Token: 0x060145D3 RID: 83411
	bool IsAborted { get; set; }

	// Token: 0x060145D4 RID: 83412
	UniTask Execute();

	// Token: 0x060145D5 RID: 83413
	string LogInfo();
}
