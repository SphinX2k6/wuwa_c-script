using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AC4 RID: 6852
[NullableContext(1)]
[Nullable(0)]
public class PhotoInfoData : IInfoData
{
	// Token: 0x17001976 RID: 6518
	// (get) Token: 0x06010FCD RID: 69581 RVA: 0x004FC99A File Offset: 0x004FAB9A
	// (set) Token: 0x06010FCE RID: 69582 RVA: 0x004FC9A2 File Offset: 0x004FABA2
	public string Text { get; set; } = "";

	// Token: 0x17001977 RID: 6519
	// (get) Token: 0x06010FCF RID: 69583 RVA: 0x004FC9AB File Offset: 0x004FABAB
	// (set) Token: 0x06010FD0 RID: 69584 RVA: 0x004FC9B3 File Offset: 0x004FABB3
	public bool IsFinish { get; set; }

	// Token: 0x17001978 RID: 6520
	// (get) Token: 0x06010FD1 RID: 69585 RVA: 0x004FC9BC File Offset: 0x004FABBC
	// (set) Token: 0x06010FD2 RID: 69586 RVA: 0x004FC9C4 File Offset: 0x004FABC4
	public bool IsOptionFinished { get; set; }
}
