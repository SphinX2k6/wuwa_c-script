using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02004268 RID: 17000
	[NullableContext(1)]
	public interface ISkillTriggerInfo
	{
		// Token: 0x17005656 RID: 22102
		// (get) Token: 0x0602B03C RID: 176188
		// (set) Token: 0x0602B03D RID: 176189
		EPhantomArenaBuffEffectType InteractType { get; set; }

		// Token: 0x17005657 RID: 22103
		// (get) Token: 0x0602B03E RID: 176190
		// (set) Token: 0x0602B03F RID: 176191
		List<int> SelectFightIdList { get; set; }

		// Token: 0x17005658 RID: 22104
		// (get) Token: 0x0602B040 RID: 176192
		// (set) Token: 0x0602B041 RID: 176193
		int SelectNum { get; set; }

		// Token: 0x17005659 RID: 22105
		// (get) Token: 0x0602B042 RID: 176194
		// (set) Token: 0x0602B043 RID: 176195
		int? SkillId { get; set; }

		// Token: 0x1700565A RID: 22106
		// (get) Token: 0x0602B044 RID: 176196
		// (set) Token: 0x0602B045 RID: 176197
		int? DataId { get; set; }

		// Token: 0x1700565B RID: 22107
		// (get) Token: 0x0602B046 RID: 176198
		// (set) Token: 0x0602B047 RID: 176199
		bool IsRole { get; set; }

		// Token: 0x1700565C RID: 22108
		// (get) Token: 0x0602B048 RID: 176200
		// (set) Token: 0x0602B049 RID: 176201
		bool IsPassive { get; set; }

		// Token: 0x1700565D RID: 22109
		// (get) Token: 0x0602B04A RID: 176202
		// (set) Token: 0x0602B04B RID: 176203
		bool IsFight { get; set; }

		// Token: 0x1700565E RID: 22110
		// (get) Token: 0x0602B04C RID: 176204
		// (set) Token: 0x0602B04D RID: 176205
		bool IsClickInteract { get; set; }
	}
}
