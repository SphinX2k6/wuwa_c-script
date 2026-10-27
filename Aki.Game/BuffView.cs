using System;

// Token: 0x0200141C RID: 5148
public class BuffView : IBuffView
{
	// Token: 0x17000C6E RID: 3182
	// (get) Token: 0x0600911B RID: 37147 RVA: 0x001F2B33 File Offset: 0x001F0D33
	// (set) Token: 0x0600911C RID: 37148 RVA: 0x001F2B3B File Offset: 0x001F0D3B
	public int BuffId { get; set; }

	// Token: 0x17000C6F RID: 3183
	// (get) Token: 0x0600911D RID: 37149 RVA: 0x001F2B44 File Offset: 0x001F0D44
	// (set) Token: 0x0600911E RID: 37150 RVA: 0x001F2B4C File Offset: 0x001F0D4C
	public EPinballBuffType BuffType { get; set; }

	// Token: 0x17000C70 RID: 3184
	// (get) Token: 0x0600911F RID: 37151 RVA: 0x001F2B55 File Offset: 0x001F0D55
	// (set) Token: 0x06009120 RID: 37152 RVA: 0x001F2B5D File Offset: 0x001F0D5D
	public int BuffCount { get; set; }

	// Token: 0x17000C71 RID: 3185
	// (get) Token: 0x06009121 RID: 37153 RVA: 0x001F2B66 File Offset: 0x001F0D66
	// (set) Token: 0x06009122 RID: 37154 RVA: 0x001F2B6E File Offset: 0x001F0D6E
	public int Sort { get; set; }
}
