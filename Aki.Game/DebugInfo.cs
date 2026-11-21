using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A53 RID: 10835
[NullableContext(1)]
[Nullable(0)]
public class DebugInfo
{
	// Token: 0x0601B75F RID: 112479 RVA: 0x008741EC File Offset: 0x008723EC
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

	// Token: 0x0400ED4C RID: 60748
	public string 场景模式;

	// Token: 0x0400ED4D RID: 60749
	public bool 是否场景主;

	// Token: 0x0400ED4E RID: 60750
	public int 场景号;

	// Token: 0x0400ED4F RID: 60751
	public float 时间流速;

	// Token: 0x0400ED50 RID: 60752
	public int 玩家Id;

	// Token: 0x0400ED51 RID: 60753
	public IReadOnlyList<string> 玩家位置;

	// Token: 0x0400ED52 RID: 60754
	public bool 是否联机;

	// Token: 0x0400ED53 RID: 60755
	public IReadOnlyList<int> 编队玩家;

	// Token: 0x0400ED54 RID: 60756
	public IReadOnlyList<string> 队伍buff;

	// Token: 0x0400ED55 RID: 60757
	public string 队伍属性;

	// Token: 0x0400ED56 RID: 60758
	public IReadOnlyList<FormationRoleInfo> 编队角色;

	// Token: 0x0400ED57 RID: 60759
	public IReadOnlyList<SkillButtonDebugInfo> 技能按钮;
}
