using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200751A RID: 29978
	public class IPreloadSubLevelsT
	{
		// Token: 0x1700DC9B RID: 56475
		// (get) Token: 0x06034935 RID: 215349 RVA: 0x0071378F File Offset: 0x0071198F
		// (set) Token: 0x06034936 RID: 215350 RVA: 0x00713797 File Offset: 0x00711997
		public ESwitchSubLevelsType Type { get; set; }

		// Token: 0x1700DC9C RID: 56476
		// (get) Token: 0x06034937 RID: 215351 RVA: 0x007137A0 File Offset: 0x007119A0
		// (set) Token: 0x06034938 RID: 215352 RVA: 0x007137A8 File Offset: 0x007119A8
		public List<string> PreloadLevels { get; set; }

		// Token: 0x06034939 RID: 215353 RVA: 0x007137B1 File Offset: 0x007119B1
		public IPreloadSubLevelsT()
		{
			this.Type = ESwitchSubLevelsType.Directly;
			this.PreloadLevels = null;
		}
	}
}
