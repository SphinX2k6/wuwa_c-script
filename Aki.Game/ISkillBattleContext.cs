using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020026BA RID: 9914
[NullableContext(1)]
public interface ISkillBattleContext
{
	// Token: 0x17002787 RID: 10119
	// (get) Token: 0x06018D8D RID: 101773
	// (set) Token: 0x06018D8E RID: 101774
	int VisionId { get; set; }

	// Token: 0x17002788 RID: 10120
	// (get) Token: 0x06018D8F RID: 101775
	// (set) Token: 0x06018D90 RID: 101776
	List<string> BattleFlags { get; set; }
}
