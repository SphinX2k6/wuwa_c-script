using System;
using System.Runtime.CompilerServices;

// Token: 0x020008D4 RID: 2260
[NullableContext(2)]
[Nullable(0)]
internal class PinballBattleTipsParam : IPinballBattleTipsBaseParam
{
	// Token: 0x17000C9D RID: 3229
	// (get) Token: 0x060064D2 RID: 25810 RVA: 0x001FB7A4 File Offset: 0x001F99A4
	// (set) Token: 0x060064D3 RID: 25811 RVA: 0x001FB7AC File Offset: 0x001F99AC
	public Action CloseCallback { get; set; }

	// Token: 0x17000C9E RID: 3230
	// (get) Token: 0x060064D4 RID: 25812 RVA: 0x001FB7B5 File Offset: 0x001F99B5
	// (set) Token: 0x060064D5 RID: 25813 RVA: 0x001FB7BD File Offset: 0x001F99BD
	public bool? AddMask { get; set; }

	// Token: 0x17000C9F RID: 3231
	// (get) Token: 0x060064D6 RID: 25814 RVA: 0x001FB7C6 File Offset: 0x001F99C6
	// (set) Token: 0x060064D7 RID: 25815 RVA: 0x001FB7CE File Offset: 0x001F99CE
	public int? CloseTime { get; set; }

	// Token: 0x17000CA0 RID: 3232
	// (get) Token: 0x060064D8 RID: 25816 RVA: 0x001FB7D7 File Offset: 0x001F99D7
	// (set) Token: 0x060064D9 RID: 25817 RVA: 0x001FB7DF File Offset: 0x001F99DF
	public bool? MoveToBehind { get; set; }
}
