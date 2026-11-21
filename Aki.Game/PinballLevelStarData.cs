using System;
using System.Runtime.CompilerServices;

// Token: 0x020008A9 RID: 2217
[NullableContext(2)]
[Nullable(0)]
public class PinballLevelStarData : IPinballLevelStarData
{
	// Token: 0x17000C4B RID: 3147
	// (get) Token: 0x06006409 RID: 25609 RVA: 0x001FB5E8 File Offset: 0x001F97E8
	// (set) Token: 0x0600640A RID: 25610 RVA: 0x001FB5F0 File Offset: 0x001F97F0
	public int ConditionId { get; set; }

	// Token: 0x17000C4C RID: 3148
	// (get) Token: 0x0600640B RID: 25611 RVA: 0x001FB5F9 File Offset: 0x001F97F9
	// (set) Token: 0x0600640C RID: 25612 RVA: 0x001FB601 File Offset: 0x001F9801
	public bool Passed { get; set; }

	// Token: 0x17000C4D RID: 3149
	// (get) Token: 0x0600640D RID: 25613 RVA: 0x001FB60A File Offset: 0x001F980A
	// (set) Token: 0x0600640E RID: 25614 RVA: 0x001FB612 File Offset: 0x001F9812
	public string ConfigConditionDesc { get; set; }

	// Token: 0x17000C4E RID: 3150
	// (get) Token: 0x0600640F RID: 25615 RVA: 0x001FB61B File Offset: 0x001F981B
	// (set) Token: 0x06006410 RID: 25616 RVA: 0x001FB623 File Offset: 0x001F9823
	public int? ConfigTargetValue { get; set; }
}
