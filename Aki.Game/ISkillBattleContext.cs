using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200314D RID: 12621
[NullableContext(1)]
public interface ISkillBattleContext
{
	// Token: 0x17002596 RID: 9622
	// (get) Token: 0x0601B288 RID: 111240
	// (set) Token: 0x0601B289 RID: 111241
	int VisionId { get; set; }

	// Token: 0x17002597 RID: 9623
	// (get) Token: 0x0601B28A RID: 111242
	// (set) Token: 0x0601B28B RID: 111243
	List<string> BattleFlags { get; set; }
}
