using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048F4 RID: 18676
	public class IDartSkillGroupT
	{
		// Token: 0x17008213 RID: 33299
		// (get) Token: 0x0601BA9B RID: 113307 RVA: 0x003E946D File Offset: 0x003E766D
		// (set) Token: 0x0601BA9C RID: 113308 RVA: 0x003E9475 File Offset: 0x003E7675
		public List<IDartSkillT> Skills { get; set; }

		// Token: 0x0601BA9D RID: 113309 RVA: 0x003E947E File Offset: 0x003E767E
		public IDartSkillGroupT()
		{
			this.Skills = null;
		}
	}
}
