using System;
using System.Runtime.CompilerServices;

// Token: 0x02000B6E RID: 2926
[NullableContext(1)]
[Nullable(0)]
public class PeriodicityChallengeTypeData : IPeriodicityChallengeTypeData
{
	// Token: 0x17000E05 RID: 3589
	// (get) Token: 0x060079B0 RID: 31152 RVA: 0x0025B320 File Offset: 0x00259520
	// (set) Token: 0x060079B1 RID: 31153 RVA: 0x0025B328 File Offset: 0x00259528
	public float LeftTime { get; set; }

	// Token: 0x17000E06 RID: 3590
	// (get) Token: 0x060079B2 RID: 31154 RVA: 0x0025B331 File Offset: 0x00259531
	// (set) Token: 0x060079B3 RID: 31155 RVA: 0x0025B339 File Offset: 0x00259539
	public int CurrentNum { get; set; }

	// Token: 0x17000E07 RID: 3591
	// (get) Token: 0x060079B4 RID: 31156 RVA: 0x0025B342 File Offset: 0x00259542
	// (set) Token: 0x060079B5 RID: 31157 RVA: 0x0025B34A File Offset: 0x0025954A
	public int TotalNum { get; set; }

	// Token: 0x17000E08 RID: 3592
	// (get) Token: 0x060079B6 RID: 31158 RVA: 0x0025B353 File Offset: 0x00259553
	// (set) Token: 0x060079B7 RID: 31159 RVA: 0x0025B35B File Offset: 0x0025955B
	public bool IsFinish { get; set; }

	// Token: 0x17000E09 RID: 3593
	// (get) Token: 0x060079B8 RID: 31160 RVA: 0x0025B364 File Offset: 0x00259564
	// (set) Token: 0x060079B9 RID: 31161 RVA: 0x0025B36C File Offset: 0x0025956C
	public bool RedPoint { get; set; }

	// Token: 0x17000E0A RID: 3594
	// (get) Token: 0x060079BA RID: 31162 RVA: 0x0025B375 File Offset: 0x00259575
	// (set) Token: 0x060079BB RID: 31163 RVA: 0x0025B37D File Offset: 0x0025957D
	public string SubText { get; set; }
}
