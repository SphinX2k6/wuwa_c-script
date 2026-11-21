using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004569 RID: 17769
	public class IShowUiCraftingT
	{
		// Token: 0x17007C2C RID: 31788
		// (get) Token: 0x06019DC3 RID: 105923 RVA: 0x003B08E0 File Offset: 0x003AEAE0
		// (set) Token: 0x06019DC4 RID: 105924 RVA: 0x003B08E8 File Offset: 0x003AEAE8
		public EShowUiType Type { get; set; }

		// Token: 0x17007C2D RID: 31789
		// (get) Token: 0x06019DC5 RID: 105925 RVA: 0x003B08F1 File Offset: 0x003AEAF1
		// (set) Token: 0x06019DC6 RID: 105926 RVA: 0x003B08F9 File Offset: 0x003AEAF9
		public List<int> EntityIds { get; set; }

		// Token: 0x17007C2E RID: 31790
		// (get) Token: 0x06019DC7 RID: 105927 RVA: 0x003B0902 File Offset: 0x003AEB02
		// (set) Token: 0x06019DC8 RID: 105928 RVA: 0x003B090A File Offset: 0x003AEB0A
		public List<int> ProductIds { get; set; }

		// Token: 0x17007C2F RID: 31791
		// (get) Token: 0x06019DC9 RID: 105929 RVA: 0x003B0913 File Offset: 0x003AEB13
		// (set) Token: 0x06019DCA RID: 105930 RVA: 0x003B091B File Offset: 0x003AEB1B
		public byte NullMask { get; set; }

		// Token: 0x06019DCB RID: 105931 RVA: 0x003B0924 File Offset: 0x003AEB24
		public IShowUiCraftingT()
		{
			this.Type = EShowUiType.All;
			this.EntityIds = null;
			this.ProductIds = null;
			this.NullMask = 0;
		}
	}
}
