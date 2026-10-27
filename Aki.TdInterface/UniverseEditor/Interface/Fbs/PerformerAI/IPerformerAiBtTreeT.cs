using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200435B RID: 17243
	public class IPerformerAiBtTreeT
	{
		// Token: 0x170079AF RID: 31151
		// (get) Token: 0x0601991C RID: 104732 RVA: 0x003A9106 File Offset: 0x003A7306
		// (set) Token: 0x0601991D RID: 104733 RVA: 0x003A910E File Offset: 0x003A730E
		public IPerformerAiStartT Root { get; set; }

		// Token: 0x170079B0 RID: 31152
		// (get) Token: 0x0601991E RID: 104734 RVA: 0x003A9117 File Offset: 0x003A7317
		// (set) Token: 0x0601991F RID: 104735 RVA: 0x003A911F File Offset: 0x003A731F
		public List<int> _StSelectedNodeIds { get; set; }

		// Token: 0x170079B1 RID: 31153
		// (get) Token: 0x06019920 RID: 104736 RVA: 0x003A9128 File Offset: 0x003A7328
		// (set) Token: 0x06019921 RID: 104737 RVA: 0x003A9130 File Offset: 0x003A7330
		public byte NullMask { get; set; }

		// Token: 0x06019922 RID: 104738 RVA: 0x003A9139 File Offset: 0x003A7339
		public IPerformerAiBtTreeT()
		{
			this.Root = null;
			this._StSelectedNodeIds = null;
			this.NullMask = 0;
		}
	}
}
