using System;
using System.Runtime.CompilerServices;

// Token: 0x020023FF RID: 9215
[NullableContext(1)]
[Nullable(0)]
public class MainSkillInfoData : IMainSkillInfoData
{
	// Token: 0x170017D7 RID: 6103
	// (get) Token: 0x060126F9 RID: 75513 RVA: 0x0048C919 File Offset: 0x0048AB19
	// (set) Token: 0x060126FA RID: 75514 RVA: 0x0048C921 File Offset: 0x0048AB21
	public string MainSkillText { get; set; }

	// Token: 0x170017D8 RID: 6104
	// (get) Token: 0x060126FB RID: 75515 RVA: 0x0048C92A File Offset: 0x0048AB2A
	// (set) Token: 0x060126FC RID: 75516 RVA: 0x0048C932 File Offset: 0x0048AB32
	public string[] MainSkillParameter { get; set; }

	// Token: 0x170017D9 RID: 6105
	// (get) Token: 0x060126FD RID: 75517 RVA: 0x0048C93B File Offset: 0x0048AB3B
	// (set) Token: 0x060126FE RID: 75518 RVA: 0x0048C943 File Offset: 0x0048AB43
	public string MainSkillIcon { get; set; }
}
