using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02001BB2 RID: 7090
[NullableContext(1)]
public interface IDangoDungeonCommand
{
	// Token: 0x17001A92 RID: 6802
	// (get) Token: 0x06011AAF RID: 72367
	// (set) Token: 0x06011AB0 RID: 72368
	int CommandIndex { get; set; }

	// Token: 0x17001A93 RID: 6803
	// (get) Token: 0x06011AB1 RID: 72369
	ERacingBetsCommandType CommandType { get; }

	// Token: 0x17001A94 RID: 6804
	// (get) Token: 0x06011AB2 RID: 72370
	// (set) Token: 0x06011AB3 RID: 72371
	int ActionIndex { get; set; }

	// Token: 0x17001A95 RID: 6805
	// (get) Token: 0x06011AB4 RID: 72372
	// (set) Token: 0x06011AB5 RID: 72373
	bool IsAborted { get; set; }

	// Token: 0x06011AB6 RID: 72374
	UniTask Execute();

	// Token: 0x06011AB7 RID: 72375
	string LogInfo();
}
