using System;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052A7 RID: 21159
	public interface IPhantomArenaGuideCardSkillData
	{
		// Token: 0x170082E8 RID: 33512
		// (get) Token: 0x06036255 RID: 221781
		// (set) Token: 0x06036256 RID: 221782
		int CardId { get; set; }

		// Token: 0x170082E9 RID: 33513
		// (get) Token: 0x06036257 RID: 221783
		// (set) Token: 0x06036258 RID: 221784
		int? SkillId { get; set; }

		// Token: 0x170082EA RID: 33514
		// (get) Token: 0x06036259 RID: 221785
		// (set) Token: 0x0603625A RID: 221786
		EPhantomArenaBuffEffectType? BuffType { get; set; }
	}
}
