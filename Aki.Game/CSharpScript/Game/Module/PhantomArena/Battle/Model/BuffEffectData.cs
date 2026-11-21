using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02004267 RID: 16999
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffEffectData : IBuffEffectData
	{
		// Token: 0x17005651 RID: 22097
		// (get) Token: 0x0602B031 RID: 176177 RVA: 0x00C1971D File Offset: 0x00C1791D
		// (set) Token: 0x0602B032 RID: 176178 RVA: 0x00C19725 File Offset: 0x00C17925
		public int SourceFightId { get; set; }

		// Token: 0x17005652 RID: 22098
		// (get) Token: 0x0602B033 RID: 176179 RVA: 0x00C1972E File Offset: 0x00C1792E
		// (set) Token: 0x0602B034 RID: 176180 RVA: 0x00C19736 File Offset: 0x00C17936
		public int SkillId { get; set; }

		// Token: 0x17005653 RID: 22099
		// (get) Token: 0x0602B035 RID: 176181 RVA: 0x00C1973F File Offset: 0x00C1793F
		// (set) Token: 0x0602B036 RID: 176182 RVA: 0x00C19747 File Offset: 0x00C17947
		public List<int> SelectFightIdList { get; set; }

		// Token: 0x17005654 RID: 22100
		// (get) Token: 0x0602B037 RID: 176183 RVA: 0x00C19750 File Offset: 0x00C17950
		// (set) Token: 0x0602B038 RID: 176184 RVA: 0x00C19758 File Offset: 0x00C17958
		public PhantomBattleEffectResultInfo Effect { get; set; }

		// Token: 0x17005655 RID: 22101
		// (get) Token: 0x0602B039 RID: 176185 RVA: 0x00C19761 File Offset: 0x00C17961
		// (set) Token: 0x0602B03A RID: 176186 RVA: 0x00C19769 File Offset: 0x00C17969
		public ENotifyMessageId? NotifyId { get; set; }
	}
}
