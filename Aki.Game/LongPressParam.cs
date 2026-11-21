using System;

// Token: 0x02001969 RID: 6505
public class LongPressParam : ILongPressParam
{
	// Token: 0x170018CF RID: 6351
	// (get) Token: 0x060100CF RID: 65743 RVA: 0x004ADA63 File Offset: 0x004ABC63
	// (set) Token: 0x060100D0 RID: 65744 RVA: 0x004ADA6B File Offset: 0x004ABC6B
	public float BeforeLongPressThreshold { get; set; }

	// Token: 0x170018D0 RID: 6352
	// (get) Token: 0x060100D1 RID: 65745 RVA: 0x004ADA74 File Offset: 0x004ABC74
	// (set) Token: 0x060100D2 RID: 65746 RVA: 0x004ADA7C File Offset: 0x004ABC7C
	public float LongPressThreshold { get; set; }

	// Token: 0x170018D1 RID: 6353
	// (get) Token: 0x060100D3 RID: 65747 RVA: 0x004ADA85 File Offset: 0x004ABC85
	// (set) Token: 0x060100D4 RID: 65748 RVA: 0x004ADA8D File Offset: 0x004ABC8D
	public float InvalidMoveDistance { get; set; }

	// Token: 0x170018D2 RID: 6354
	// (get) Token: 0x060100D5 RID: 65749 RVA: 0x004ADA96 File Offset: 0x004ABC96
	// (set) Token: 0x060100D6 RID: 65750 RVA: 0x004ADA9E File Offset: 0x004ABC9E
	public float OffsetX { get; set; }

	// Token: 0x170018D3 RID: 6355
	// (get) Token: 0x060100D7 RID: 65751 RVA: 0x004ADAA7 File Offset: 0x004ABCA7
	// (set) Token: 0x060100D8 RID: 65752 RVA: 0x004ADAAF File Offset: 0x004ABCAF
	public float OffsetY { get; set; }
}
