using System;
using System.Runtime.CompilerServices;

// Token: 0x020026C4 RID: 9924
[NullableContext(1)]
[Nullable(0)]
public class BeginSkillBehaviorActionParam : IBeginSkillBehaviorActionParam
{
	// Token: 0x1700279E RID: 10142
	// (get) Token: 0x06018DFF RID: 101887 RVA: 0x0078F9BF File Offset: 0x0078DBBF
	// (set) Token: 0x06018E00 RID: 101888 RVA: 0x0078F9C7 File Offset: 0x0078DBC7
	public Entity Entity { get; set; }

	// Token: 0x1700279F RID: 10143
	// (get) Token: 0x06018E01 RID: 101889 RVA: 0x0078F9D0 File Offset: 0x0078DBD0
	// (set) Token: 0x06018E02 RID: 101890 RVA: 0x0078F9D8 File Offset: 0x0078DBD8
	public BaseSkillComponent SkillComponent { get; set; }

	// Token: 0x170027A0 RID: 10144
	// (get) Token: 0x06018E03 RID: 101891 RVA: 0x0078F9E1 File Offset: 0x0078DBE1
	// (set) Token: 0x06018E04 RID: 101892 RVA: 0x0078F9E9 File Offset: 0x0078DBE9
	public Skill Skill { get; set; }
}
