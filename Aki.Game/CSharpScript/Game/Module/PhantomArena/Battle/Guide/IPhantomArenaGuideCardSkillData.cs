using System;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x02004277 RID: 17015
	public interface IPhantomArenaGuideCardSkillData
	{
		// Token: 0x170056A8 RID: 22184
		// (get) Token: 0x0602B150 RID: 176464
		// (set) Token: 0x0602B151 RID: 176465
		int CardId { get; set; }

		// Token: 0x170056A9 RID: 22185
		// (get) Token: 0x0602B152 RID: 176466
		// (set) Token: 0x0602B153 RID: 176467
		int? SkillId { get; set; }

		// Token: 0x170056AA RID: 22186
		// (get) Token: 0x0602B154 RID: 176468
		// (set) Token: 0x0602B155 RID: 176469
		EPhantomArenaBuffEffectType? BuffType { get; set; }
	}
}
