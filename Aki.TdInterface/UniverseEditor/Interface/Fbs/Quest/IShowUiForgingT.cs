using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200412B RID: 16683
	public class IShowUiForgingT
	{
		// Token: 0x1700762F RID: 30255
		// (get) Token: 0x0601874E RID: 100174 RVA: 0x00386E48 File Offset: 0x00385048
		// (set) Token: 0x0601874F RID: 100175 RVA: 0x00386E50 File Offset: 0x00385050
		public EShowUiType Type { get; set; }

		// Token: 0x17007630 RID: 30256
		// (get) Token: 0x06018750 RID: 100176 RVA: 0x00386E59 File Offset: 0x00385059
		// (set) Token: 0x06018751 RID: 100177 RVA: 0x00386E61 File Offset: 0x00385061
		public List<int> EntityIds { get; set; }

		// Token: 0x17007631 RID: 30257
		// (get) Token: 0x06018752 RID: 100178 RVA: 0x00386E6A File Offset: 0x0038506A
		// (set) Token: 0x06018753 RID: 100179 RVA: 0x00386E72 File Offset: 0x00385072
		public List<int> ProductIds { get; set; }

		// Token: 0x17007632 RID: 30258
		// (get) Token: 0x06018754 RID: 100180 RVA: 0x00386E7B File Offset: 0x0038507B
		// (set) Token: 0x06018755 RID: 100181 RVA: 0x00386E83 File Offset: 0x00385083
		public byte NullMask { get; set; }

		// Token: 0x06018756 RID: 100182 RVA: 0x00386E8C File Offset: 0x0038508C
		public IShowUiForgingT()
		{
			this.Type = EShowUiType.All;
			this.EntityIds = null;
			this.ProductIds = null;
			this.NullMask = 0;
		}
	}
}
