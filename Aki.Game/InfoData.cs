using System;
using System.Runtime.CompilerServices;

// Token: 0x020025C9 RID: 9673
[NullableContext(1)]
[Nullable(0)]
public class InfoData : IInfoData
{
	// Token: 0x17001931 RID: 6449
	// (get) Token: 0x060139F7 RID: 80375 RVA: 0x004E8732 File Offset: 0x004E6932
	// (set) Token: 0x060139F8 RID: 80376 RVA: 0x004E873A File Offset: 0x004E693A
	public string Text { get; set; } = "";

	// Token: 0x17001932 RID: 6450
	// (get) Token: 0x060139F9 RID: 80377 RVA: 0x004E8743 File Offset: 0x004E6943
	// (set) Token: 0x060139FA RID: 80378 RVA: 0x004E874B File Offset: 0x004E694B
	public bool IsFinish { get; set; }

	// Token: 0x17001933 RID: 6451
	// (get) Token: 0x060139FB RID: 80379 RVA: 0x004E8754 File Offset: 0x004E6954
	// (set) Token: 0x060139FC RID: 80380 RVA: 0x004E875C File Offset: 0x004E695C
	public bool IsOptionFinished { get; set; }
}
