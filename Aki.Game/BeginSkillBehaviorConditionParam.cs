using System;
using System.Runtime.CompilerServices;

// Token: 0x020026C3 RID: 9923
[NullableContext(2)]
[Nullable(0)]
public class BeginSkillBehaviorConditionParam : IBeginSkillBehaviorConditionParam
{
	// Token: 0x1700279B RID: 10139
	// (get) Token: 0x06018DF8 RID: 101880 RVA: 0x0078F984 File Offset: 0x0078DB84
	// (set) Token: 0x06018DF9 RID: 101881 RVA: 0x0078F98C File Offset: 0x0078DB8C
	[Nullable(1)]
	public Entity Entity { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700279C RID: 10140
	// (get) Token: 0x06018DFA RID: 101882 RVA: 0x0078F995 File Offset: 0x0078DB95
	// (set) Token: 0x06018DFB RID: 101883 RVA: 0x0078F99D File Offset: 0x0078DB9D
	public BaseSkillComponent SkillComponent { get; set; }

	// Token: 0x1700279D RID: 10141
	// (get) Token: 0x06018DFC RID: 101884 RVA: 0x0078F9A6 File Offset: 0x0078DBA6
	// (set) Token: 0x06018DFD RID: 101885 RVA: 0x0078F9AE File Offset: 0x0078DBAE
	public Skill Skill { get; set; }
}
