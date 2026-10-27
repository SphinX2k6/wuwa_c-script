using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044D7 RID: 17623
	public class IHitRemainScoreZoneResultT
	{
		// Token: 0x17007C61 RID: 31841
		// (get) Token: 0x0601A57A RID: 107898 RVA: 0x003C28E0 File Offset: 0x003C0AE0
		// (set) Token: 0x0601A57B RID: 107899 RVA: 0x003C28E8 File Offset: 0x003C0AE8
		public EDartSkillResultType Type { get; set; }

		// Token: 0x17007C62 RID: 31842
		// (get) Token: 0x0601A57C RID: 107900 RVA: 0x003C28F1 File Offset: 0x003C0AF1
		// (set) Token: 0x0601A57D RID: 107901 RVA: 0x003C28F9 File Offset: 0x003C0AF9
		public int Probability { get; set; }

		// Token: 0x0601A57E RID: 107902 RVA: 0x003C2902 File Offset: 0x003C0B02
		public IHitRemainScoreZoneResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.Probability = 0;
		}
	}
}
