using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045A6 RID: 17830
	public class IRollBlockPathT
	{
		// Token: 0x17007EBB RID: 32443
		// (get) Token: 0x0601AF49 RID: 110409 RVA: 0x003D850B File Offset: 0x003D670B
		// (set) Token: 0x0601AF4A RID: 110410 RVA: 0x003D8513 File Offset: 0x003D6713
		public float Height { get; set; }

		// Token: 0x17007EBC RID: 32444
		// (get) Token: 0x0601AF4B RID: 110411 RVA: 0x003D851C File Offset: 0x003D671C
		// (set) Token: 0x0601AF4C RID: 110412 RVA: 0x003D8524 File Offset: 0x003D6724
		public List<IRollBlockPathNodeT> Nodes { get; set; }

		// Token: 0x0601AF4D RID: 110413 RVA: 0x003D852D File Offset: 0x003D672D
		public IRollBlockPathT()
		{
			this.Height = 0f;
			this.Nodes = null;
		}
	}
}
