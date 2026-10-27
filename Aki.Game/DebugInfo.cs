using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020034DF RID: 13535
[NullableContext(1)]
[Nullable(0)]
public class DebugInfo
{
	// Token: 0x0601DA55 RID: 121429 RVA: 0x0084BFE0 File Offset: 0x0084A1E0
	public DebugInfo(string 场景模式, bool 是否场景主, int 场景号, float 时间流速, int 玩家Id, IReadOnlyList<string> 玩家位置, bool 是否联机, IReadOnlyList<int> 编队玩家, IReadOnlyList<string> 队伍buff, string 队伍属性, IReadOnlyList<FormationRoleInfo> 编队角色, IReadOnlyList<SkillButtonDebugInfo> 技能按钮)
	{
		this.场景模式 = 场景模式;
		this.是否场景主 = 是否场景主;
		this.场景号 = 场景号;
		this.时间流速 = 时间流速;
		this.玩家Id = 玩家Id;
		this.玩家位置 = 玩家位置;
		this.是否联机 = 是否联机;
		this.编队玩家 = 编队玩家;
		this.队伍buff = 队伍buff;
		this.队伍属性 = 队伍属性;
		this.编队角色 = 编队角色;
		this.技能按钮 = 技能按钮;
	}

	// Token: 0x0400E895 RID: 59541
	public string 场景模式;

	// Token: 0x0400E896 RID: 59542
	public bool 是否场景主;

	// Token: 0x0400E897 RID: 59543
	public int 场景号;

	// Token: 0x0400E898 RID: 59544
	public float 时间流速;

	// Token: 0x0400E899 RID: 59545
	public int 玩家Id;

	// Token: 0x0400E89A RID: 59546
	public IReadOnlyList<string> 玩家位置;

	// Token: 0x0400E89B RID: 59547
	public bool 是否联机;

	// Token: 0x0400E89C RID: 59548
	public IReadOnlyList<int> 编队玩家;

	// Token: 0x0400E89D RID: 59549
	public IReadOnlyList<string> 队伍buff;

	// Token: 0x0400E89E RID: 59550
	public string 队伍属性;

	// Token: 0x0400E89F RID: 59551
	public IReadOnlyList<FormationRoleInfo> 编队角色;

	// Token: 0x0400E8A0 RID: 59552
	public IReadOnlyList<SkillButtonDebugInfo> 技能按钮;
}
