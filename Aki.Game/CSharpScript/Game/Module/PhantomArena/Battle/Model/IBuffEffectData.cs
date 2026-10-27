using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02005296 RID: 21142
	[NullableContext(1)]
	public interface IBuffEffectData
	{
		// Token: 0x1700828C RID: 33420
		// (get) Token: 0x0603612C RID: 221484
		// (set) Token: 0x0603612D RID: 221485
		int SourceFightId { get; set; }

		// Token: 0x1700828D RID: 33421
		// (get) Token: 0x0603612E RID: 221486
		// (set) Token: 0x0603612F RID: 221487
		int SkillId { get; set; }

		// Token: 0x1700828E RID: 33422
		// (get) Token: 0x06036130 RID: 221488
		// (set) Token: 0x06036131 RID: 221489
		List<int> SelectFightIdList { get; set; }

		// Token: 0x1700828F RID: 33423
		// (get) Token: 0x06036132 RID: 221490
		// (set) Token: 0x06036133 RID: 221491
		PhantomBattleEffectResultInfo Effect { get; set; }

		// Token: 0x17008290 RID: 33424
		// (get) Token: 0x06036134 RID: 221492
		// (set) Token: 0x06036135 RID: 221493
		ENotifyMessageId? NotifyId { get; set; }
	}
}
