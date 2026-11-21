using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004566 RID: 17766
	public class IShowUiCookT
	{
		// Token: 0x17007C23 RID: 31779
		// (get) Token: 0x06019D95 RID: 105877 RVA: 0x003B0370 File Offset: 0x003AE570
		// (set) Token: 0x06019D96 RID: 105878 RVA: 0x003B0378 File Offset: 0x003AE578
		public EShowUiType Type { get; set; }

		// Token: 0x17007C24 RID: 31780
		// (get) Token: 0x06019D97 RID: 105879 RVA: 0x003B0381 File Offset: 0x003AE581
		// (set) Token: 0x06019D98 RID: 105880 RVA: 0x003B0389 File Offset: 0x003AE589
		public List<int> EntityIds { get; set; }

		// Token: 0x17007C25 RID: 31781
		// (get) Token: 0x06019D99 RID: 105881 RVA: 0x003B0392 File Offset: 0x003AE592
		// (set) Token: 0x06019D9A RID: 105882 RVA: 0x003B039A File Offset: 0x003AE59A
		public List<int> ProductIds { get; set; }

		// Token: 0x17007C26 RID: 31782
		// (get) Token: 0x06019D9B RID: 105883 RVA: 0x003B03A3 File Offset: 0x003AE5A3
		// (set) Token: 0x06019D9C RID: 105884 RVA: 0x003B03AB File Offset: 0x003AE5AB
		public byte NullMask { get; set; }

		// Token: 0x06019D9D RID: 105885 RVA: 0x003B03B4 File Offset: 0x003AE5B4
		public IShowUiCookT()
		{
			this.Type = EShowUiType.All;
			this.EntityIds = null;
			this.ProductIds = null;
			this.NullMask = 0;
		}
	}
}
