using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F4E RID: 28494
	public class IGroupAiCommunicateRemoveTagT
	{
		// Token: 0x1700D0D2 RID: 53458
		// (get) Token: 0x06031516 RID: 202006 RVA: 0x006AE197 File Offset: 0x006AC397
		// (set) Token: 0x06031517 RID: 202007 RVA: 0x006AE19F File Offset: 0x006AC39F
		public EGroupAiCommunicateType Type { get; set; }

		// Token: 0x1700D0D3 RID: 53459
		// (get) Token: 0x06031518 RID: 202008 RVA: 0x006AE1A8 File Offset: 0x006AC3A8
		// (set) Token: 0x06031519 RID: 202009 RVA: 0x006AE1B0 File Offset: 0x006AC3B0
		public List<string> Tags { get; set; }

		// Token: 0x0603151A RID: 202010 RVA: 0x006AE1B9 File Offset: 0x006AC3B9
		public IGroupAiCommunicateRemoveTagT()
		{
			this.Type = EGroupAiCommunicateType.AddTag;
			this.Tags = null;
		}
	}
}
