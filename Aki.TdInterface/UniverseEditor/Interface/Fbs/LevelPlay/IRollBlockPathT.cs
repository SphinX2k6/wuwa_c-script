using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A0E RID: 18958
	public class IRollBlockPathT
	{
		// Token: 0x170084FC RID: 34044
		// (get) Token: 0x0601C71E RID: 116510 RVA: 0x004047A7 File Offset: 0x004029A7
		// (set) Token: 0x0601C71F RID: 116511 RVA: 0x004047AF File Offset: 0x004029AF
		public float Height { get; set; }

		// Token: 0x170084FD RID: 34045
		// (get) Token: 0x0601C720 RID: 116512 RVA: 0x004047B8 File Offset: 0x004029B8
		// (set) Token: 0x0601C721 RID: 116513 RVA: 0x004047C0 File Offset: 0x004029C0
		public List<IRollBlockPathNodeT> Nodes { get; set; }

		// Token: 0x0601C722 RID: 116514 RVA: 0x004047C9 File Offset: 0x004029C9
		public IRollBlockPathT()
		{
			this.Height = 0f;
			this.Nodes = null;
		}
	}
}
