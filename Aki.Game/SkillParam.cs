using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003138 RID: 12600
[NullableContext(2)]
[Nullable(0)]
public class SkillParam : ISkillParam
{
	// Token: 0x1700257C RID: 9596
	// (get) Token: 0x0601B133 RID: 110899 RVA: 0x0075AE11 File Offset: 0x00759011
	// (set) Token: 0x0601B134 RID: 110900 RVA: 0x0075AE19 File Offset: 0x00759019
	public Entity Target { get; set; }

	// Token: 0x1700257D RID: 9597
	// (get) Token: 0x0601B135 RID: 110901 RVA: 0x0075AE22 File Offset: 0x00759022
	// (set) Token: 0x0601B136 RID: 110902 RVA: 0x0075AE2A File Offset: 0x0075902A
	public AActor TargetActor { get; set; }

	// Token: 0x1700257E RID: 9598
	// (get) Token: 0x0601B137 RID: 110903 RVA: 0x0075AE33 File Offset: 0x00759033
	// (set) Token: 0x0601B138 RID: 110904 RVA: 0x0075AE3B File Offset: 0x0075903B
	public string SocketName { get; set; }

	// Token: 0x1700257F RID: 9599
	// (get) Token: 0x0601B139 RID: 110905 RVA: 0x0075AE44 File Offset: 0x00759044
	// (set) Token: 0x0601B13A RID: 110906 RVA: 0x0075AE4C File Offset: 0x0075904C
	public long? ContextId { get; set; }

	// Token: 0x17002580 RID: 9600
	// (get) Token: 0x0601B13B RID: 110907 RVA: 0x0075AE55 File Offset: 0x00759055
	// (set) Token: 0x0601B13C RID: 110908 RVA: 0x0075AE5D File Offset: 0x0075905D
	public string Reason { get; set; }

	// Token: 0x17002581 RID: 9601
	// (get) Token: 0x0601B13D RID: 110909 RVA: 0x0075AE66 File Offset: 0x00759066
	// (set) Token: 0x0601B13E RID: 110910 RVA: 0x0075AE6E File Offset: 0x0075906E
	public int? MontageIndex { get; set; }

	// Token: 0x17002582 RID: 9602
	// (get) Token: 0x0601B13F RID: 110911 RVA: 0x0075AE77 File Offset: 0x00759077
	// (set) Token: 0x0601B140 RID: 110912 RVA: 0x0075AE7F File Offset: 0x0075907F
	public bool? CheckMultiSkill { get; set; }

	// Token: 0x17002583 RID: 9603
	// (get) Token: 0x0601B141 RID: 110913 RVA: 0x0075AE88 File Offset: 0x00759088
	// (set) Token: 0x0601B142 RID: 110914 RVA: 0x0075AE90 File Offset: 0x00759090
	public int? NextSkillId { get; set; }

	// Token: 0x17002584 RID: 9604
	// (get) Token: 0x0601B143 RID: 110915 RVA: 0x0075AE99 File Offset: 0x00759099
	// (set) Token: 0x0601B144 RID: 110916 RVA: 0x0075AEA1 File Offset: 0x007590A1
	public bool? IsAsync { get; set; }

	// Token: 0x17002585 RID: 9605
	// (get) Token: 0x0601B145 RID: 110917 RVA: 0x0075AEAA File Offset: 0x007590AA
	// (set) Token: 0x0601B146 RID: 110918 RVA: 0x0075AEB2 File Offset: 0x007590B2
	public FVectorDouble? ExtraTargetLocation { get; set; }
}
