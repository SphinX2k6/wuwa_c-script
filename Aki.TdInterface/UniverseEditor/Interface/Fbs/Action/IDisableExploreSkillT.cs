using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C4B RID: 27723
	public class IDisableExploreSkillT
	{
		// Token: 0x1700CB36 RID: 52022
		// (get) Token: 0x0602FB8E RID: 195470 RVA: 0x0067FCA7 File Offset: 0x0067DEA7
		// (set) Token: 0x0602FB8F RID: 195471 RVA: 0x0067FCAF File Offset: 0x0067DEAF
		public bool PlaceTemporaryTeleport { get; set; }

		// Token: 0x1700CB37 RID: 52023
		// (get) Token: 0x0602FB90 RID: 195472 RVA: 0x0067FCB8 File Offset: 0x0067DEB8
		// (set) Token: 0x0602FB91 RID: 195473 RVA: 0x0067FCC0 File Offset: 0x0067DEC0
		public bool IsComplementary { get; set; }

		// Token: 0x1700CB38 RID: 52024
		// (get) Token: 0x0602FB92 RID: 195474 RVA: 0x0067FCC9 File Offset: 0x0067DEC9
		// (set) Token: 0x0602FB93 RID: 195475 RVA: 0x0067FCD1 File Offset: 0x0067DED1
		public List<EExploreSkillType> ExploreSkillList { get; set; }

		// Token: 0x1700CB39 RID: 52025
		// (get) Token: 0x0602FB94 RID: 195476 RVA: 0x0067FCDA File Offset: 0x0067DEDA
		// (set) Token: 0x0602FB95 RID: 195477 RVA: 0x0067FCE2 File Offset: 0x0067DEE2
		public byte NullMask { get; set; }

		// Token: 0x0602FB96 RID: 195478 RVA: 0x0067FCEB File Offset: 0x0067DEEB
		public IDisableExploreSkillT()
		{
			this.PlaceTemporaryTeleport = false;
			this.IsComplementary = false;
			this.ExploreSkillList = null;
			this.NullMask = 0;
		}
	}
}
