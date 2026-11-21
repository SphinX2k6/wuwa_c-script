using System;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x02004278 RID: 17016
	public class PhantomArenaGuideCardSkillData : IPhantomArenaGuideCardSkillData
	{
		// Token: 0x170056AB RID: 22187
		// (get) Token: 0x0602B156 RID: 176470 RVA: 0x00C1CEE5 File Offset: 0x00C1B0E5
		// (set) Token: 0x0602B157 RID: 176471 RVA: 0x00C1CEED File Offset: 0x00C1B0ED
		public int CardId { get; set; }

		// Token: 0x170056AC RID: 22188
		// (get) Token: 0x0602B158 RID: 176472 RVA: 0x00C1CEF6 File Offset: 0x00C1B0F6
		// (set) Token: 0x0602B159 RID: 176473 RVA: 0x00C1CEFE File Offset: 0x00C1B0FE
		public int? SkillId { get; set; }

		// Token: 0x170056AD RID: 22189
		// (get) Token: 0x0602B15A RID: 176474 RVA: 0x00C1CF07 File Offset: 0x00C1B107
		// (set) Token: 0x0602B15B RID: 176475 RVA: 0x00C1CF0F File Offset: 0x00C1B10F
		public EPhantomArenaBuffEffectType? BuffType { get; set; }
	}
}
