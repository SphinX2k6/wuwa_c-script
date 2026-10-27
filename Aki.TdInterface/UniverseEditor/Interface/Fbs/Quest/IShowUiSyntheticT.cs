using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200412E RID: 16686
	public class IShowUiSyntheticT
	{
		// Token: 0x17007638 RID: 30264
		// (get) Token: 0x0601877C RID: 100220 RVA: 0x003873B8 File Offset: 0x003855B8
		// (set) Token: 0x0601877D RID: 100221 RVA: 0x003873C0 File Offset: 0x003855C0
		public EShowUiType Type { get; set; }

		// Token: 0x17007639 RID: 30265
		// (get) Token: 0x0601877E RID: 100222 RVA: 0x003873C9 File Offset: 0x003855C9
		// (set) Token: 0x0601877F RID: 100223 RVA: 0x003873D1 File Offset: 0x003855D1
		public List<int> EntityIds { get; set; }

		// Token: 0x1700763A RID: 30266
		// (get) Token: 0x06018780 RID: 100224 RVA: 0x003873DA File Offset: 0x003855DA
		// (set) Token: 0x06018781 RID: 100225 RVA: 0x003873E2 File Offset: 0x003855E2
		public List<int> ProductIds { get; set; }

		// Token: 0x1700763B RID: 30267
		// (get) Token: 0x06018782 RID: 100226 RVA: 0x003873EB File Offset: 0x003855EB
		// (set) Token: 0x06018783 RID: 100227 RVA: 0x003873F3 File Offset: 0x003855F3
		public byte NullMask { get; set; }

		// Token: 0x06018784 RID: 100228 RVA: 0x003873FC File Offset: 0x003855FC
		public IShowUiSyntheticT()
		{
			this.Type = EShowUiType.All;
			this.EntityIds = null;
			this.ProductIds = null;
			this.NullMask = 0;
		}
	}
}
