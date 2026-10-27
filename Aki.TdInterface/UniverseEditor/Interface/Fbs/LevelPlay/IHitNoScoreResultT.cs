using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044D1 RID: 17617
	public class IHitNoScoreResultT
	{
		// Token: 0x17007C58 RID: 31832
		// (get) Token: 0x0601A550 RID: 107856 RVA: 0x003C2506 File Offset: 0x003C0706
		// (set) Token: 0x0601A551 RID: 107857 RVA: 0x003C250E File Offset: 0x003C070E
		public EDartSkillResultType Type { get; set; }

		// Token: 0x0601A552 RID: 107858 RVA: 0x003C2517 File Offset: 0x003C0717
		public IHitNoScoreResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
		}
	}
}
