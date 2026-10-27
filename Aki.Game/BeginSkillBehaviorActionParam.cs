using System;
using System.Runtime.CompilerServices;

// Token: 0x02003157 RID: 12631
[NullableContext(1)]
[Nullable(0)]
public class BeginSkillBehaviorActionParam : IBeginSkillBehaviorActionParam
{
	// Token: 0x170025AD RID: 9645
	// (get) Token: 0x0601B2FA RID: 111354 RVA: 0x00767FF3 File Offset: 0x007661F3
	// (set) Token: 0x0601B2FB RID: 111355 RVA: 0x00767FFB File Offset: 0x007661FB
	public Entity Entity { get; set; }

	// Token: 0x170025AE RID: 9646
	// (get) Token: 0x0601B2FC RID: 111356 RVA: 0x00768004 File Offset: 0x00766204
	// (set) Token: 0x0601B2FD RID: 111357 RVA: 0x0076800C File Offset: 0x0076620C
	public BaseSkillComponent SkillComponent { get; set; }

	// Token: 0x170025AF RID: 9647
	// (get) Token: 0x0601B2FE RID: 111358 RVA: 0x00768015 File Offset: 0x00766215
	// (set) Token: 0x0601B2FF RID: 111359 RVA: 0x0076801D File Offset: 0x0076621D
	public Skill Skill { get; set; }
}
