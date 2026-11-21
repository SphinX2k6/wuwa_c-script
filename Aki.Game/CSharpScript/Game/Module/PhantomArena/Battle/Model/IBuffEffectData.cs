using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02004266 RID: 16998
	[NullableContext(1)]
	public interface IBuffEffectData
	{
		// Token: 0x1700564C RID: 22092
		// (get) Token: 0x0602B027 RID: 176167
		// (set) Token: 0x0602B028 RID: 176168
		int SourceFightId { get; set; }

		// Token: 0x1700564D RID: 22093
		// (get) Token: 0x0602B029 RID: 176169
		// (set) Token: 0x0602B02A RID: 176170
		int SkillId { get; set; }

		// Token: 0x1700564E RID: 22094
		// (get) Token: 0x0602B02B RID: 176171
		// (set) Token: 0x0602B02C RID: 176172
		List<int> SelectFightIdList { get; set; }

		// Token: 0x1700564F RID: 22095
		// (get) Token: 0x0602B02D RID: 176173
		// (set) Token: 0x0602B02E RID: 176174
		PhantomBattleEffectResultInfo Effect { get; set; }

		// Token: 0x17005650 RID: 22096
		// (get) Token: 0x0602B02F RID: 176175
		// (set) Token: 0x0602B030 RID: 176176
		ENotifyMessageId? NotifyId { get; set; }
	}
}
