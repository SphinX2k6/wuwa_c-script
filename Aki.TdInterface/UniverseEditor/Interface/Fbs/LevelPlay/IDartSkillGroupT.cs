using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200448C RID: 17548
	public class IDartSkillGroupT
	{
		// Token: 0x17007BD4 RID: 31700
		// (get) Token: 0x0601A2CA RID: 107210 RVA: 0x003BD261 File Offset: 0x003BB461
		// (set) Token: 0x0601A2CB RID: 107211 RVA: 0x003BD269 File Offset: 0x003BB469
		public List<IDartSkillT> Skills { get; set; }

		// Token: 0x0601A2CC RID: 107212 RVA: 0x003BD272 File Offset: 0x003BB472
		public IDartSkillGroupT()
		{
			this.Skills = null;
		}
	}
}
