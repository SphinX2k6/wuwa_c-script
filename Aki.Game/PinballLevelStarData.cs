using System;
using System.Runtime.CompilerServices;

// Token: 0x020013F5 RID: 5109
[NullableContext(2)]
[Nullable(0)]
public class PinballLevelStarData : IPinballLevelStarData
{
	// Token: 0x17000C2B RID: 3115
	// (get) Token: 0x06009074 RID: 36980 RVA: 0x001F2AAC File Offset: 0x001F0CAC
	// (set) Token: 0x06009075 RID: 36981 RVA: 0x001F2AB4 File Offset: 0x001F0CB4
	public int ConditionId { get; set; }

	// Token: 0x17000C2C RID: 3116
	// (get) Token: 0x06009076 RID: 36982 RVA: 0x001F2ABD File Offset: 0x001F0CBD
	// (set) Token: 0x06009077 RID: 36983 RVA: 0x001F2AC5 File Offset: 0x001F0CC5
	public bool Passed { get; set; }

	// Token: 0x17000C2D RID: 3117
	// (get) Token: 0x06009078 RID: 36984 RVA: 0x001F2ACE File Offset: 0x001F0CCE
	// (set) Token: 0x06009079 RID: 36985 RVA: 0x001F2AD6 File Offset: 0x001F0CD6
	public string ConfigConditionDesc { get; set; }

	// Token: 0x17000C2E RID: 3118
	// (get) Token: 0x0600907A RID: 36986 RVA: 0x001F2ADF File Offset: 0x001F0CDF
	// (set) Token: 0x0600907B RID: 36987 RVA: 0x001F2AE7 File Offset: 0x001F0CE7
	public int? ConfigTargetValue { get; set; }
}
