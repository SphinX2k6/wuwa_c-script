using System;
using CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Guide
{
	// Token: 0x020052A8 RID: 21160
	public class PhantomArenaGuideCardSkillData : IPhantomArenaGuideCardSkillData
	{
		// Token: 0x170082EB RID: 33515
		// (get) Token: 0x0603625B RID: 221787 RVA: 0x00CCF7BD File Offset: 0x00CCD9BD
		// (set) Token: 0x0603625C RID: 221788 RVA: 0x00CCF7C5 File Offset: 0x00CCD9C5
		public int CardId { get; set; }

		// Token: 0x170082EC RID: 33516
		// (get) Token: 0x0603625D RID: 221789 RVA: 0x00CCF7CE File Offset: 0x00CCD9CE
		// (set) Token: 0x0603625E RID: 221790 RVA: 0x00CCF7D6 File Offset: 0x00CCD9D6
		public int? SkillId { get; set; }

		// Token: 0x170082ED RID: 33517
		// (get) Token: 0x0603625F RID: 221791 RVA: 0x00CCF7DF File Offset: 0x00CCD9DF
		// (set) Token: 0x06036260 RID: 221792 RVA: 0x00CCF7E7 File Offset: 0x00CCD9E7
		public EPhantomArenaBuffEffectType? BuffType { get; set; }
	}
}
