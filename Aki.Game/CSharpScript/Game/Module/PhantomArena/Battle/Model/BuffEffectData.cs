using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02005297 RID: 21143
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffEffectData : IBuffEffectData
	{
		// Token: 0x17008291 RID: 33425
		// (get) Token: 0x06036136 RID: 221494 RVA: 0x00CCBFE5 File Offset: 0x00CCA1E5
		// (set) Token: 0x06036137 RID: 221495 RVA: 0x00CCBFED File Offset: 0x00CCA1ED
		public int SourceFightId { get; set; }

		// Token: 0x17008292 RID: 33426
		// (get) Token: 0x06036138 RID: 221496 RVA: 0x00CCBFF6 File Offset: 0x00CCA1F6
		// (set) Token: 0x06036139 RID: 221497 RVA: 0x00CCBFFE File Offset: 0x00CCA1FE
		public int SkillId { get; set; }

		// Token: 0x17008293 RID: 33427
		// (get) Token: 0x0603613A RID: 221498 RVA: 0x00CCC007 File Offset: 0x00CCA207
		// (set) Token: 0x0603613B RID: 221499 RVA: 0x00CCC00F File Offset: 0x00CCA20F
		public List<int> SelectFightIdList { get; set; }

		// Token: 0x17008294 RID: 33428
		// (get) Token: 0x0603613C RID: 221500 RVA: 0x00CCC018 File Offset: 0x00CCA218
		// (set) Token: 0x0603613D RID: 221501 RVA: 0x00CCC020 File Offset: 0x00CCA220
		public PhantomBattleEffectResultInfo Effect { get; set; }

		// Token: 0x17008295 RID: 33429
		// (get) Token: 0x0603613E RID: 221502 RVA: 0x00CCC029 File Offset: 0x00CCA229
		// (set) Token: 0x0603613F RID: 221503 RVA: 0x00CCC031 File Offset: 0x00CCA231
		public ENotifyMessageId? NotifyId { get; set; }
	}
}
