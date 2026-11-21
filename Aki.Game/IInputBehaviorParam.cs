using System;
using System.Runtime.CompilerServices;

// Token: 0x020026B3 RID: 9907
[NullableContext(1)]
[Nullable(0)]
public class IInputBehaviorParam
{
	// Token: 0x17002777 RID: 10103
	// (get) Token: 0x06018D51 RID: 101713 RVA: 0x0078A583 File Offset: 0x00788783
	// (set) Token: 0x06018D52 RID: 101714 RVA: 0x0078A58B File Offset: 0x0078878B
	public Entity Entity { get; set; }

	// Token: 0x17002778 RID: 10104
	// (get) Token: 0x06018D53 RID: 101715 RVA: 0x0078A594 File Offset: 0x00788794
	// (set) Token: 0x06018D54 RID: 101716 RVA: 0x0078A59C File Offset: 0x0078879C
	public BaseSkillComponent SkillComponent { get; set; }

	// Token: 0x17002779 RID: 10105
	// (get) Token: 0x06018D55 RID: 101717 RVA: 0x0078A5A5 File Offset: 0x007887A5
	// (set) Token: 0x06018D56 RID: 101718 RVA: 0x0078A5AD File Offset: 0x007887AD
	public Skill Skill { get; set; }
}
