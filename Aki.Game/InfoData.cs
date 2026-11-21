using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AB4 RID: 6836
[NullableContext(1)]
[Nullable(0)]
public class InfoData : IInfoData
{
	// Token: 0x17001969 RID: 6505
	// (get) Token: 0x06010ED7 RID: 69335 RVA: 0x004F7332 File Offset: 0x004F5532
	// (set) Token: 0x06010ED8 RID: 69336 RVA: 0x004F733A File Offset: 0x004F553A
	public string Text { get; set; } = "";

	// Token: 0x1700196A RID: 6506
	// (get) Token: 0x06010ED9 RID: 69337 RVA: 0x004F7343 File Offset: 0x004F5543
	// (set) Token: 0x06010EDA RID: 69338 RVA: 0x004F734B File Offset: 0x004F554B
	public bool IsFinish { get; set; }

	// Token: 0x1700196B RID: 6507
	// (get) Token: 0x06010EDB RID: 69339 RVA: 0x004F7354 File Offset: 0x004F5554
	// (set) Token: 0x06010EDC RID: 69340 RVA: 0x004F735C File Offset: 0x004F555C
	public bool IsOptionFinished { get; set; }
}
