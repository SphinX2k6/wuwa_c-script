using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D11 RID: 15633
	public class IAreaQuestTrackingT
	{
		// Token: 0x17006B3F RID: 27455
		// (get) Token: 0x0601591B RID: 88347 RVA: 0x0031D915 File Offset: 0x0031BB15
		// (set) Token: 0x0601591C RID: 88348 RVA: 0x0031D91D File Offset: 0x0031BB1D
		public int QuestId { get; set; }

		// Token: 0x17006B40 RID: 27456
		// (get) Token: 0x0601591D RID: 88349 RVA: 0x0031D926 File Offset: 0x0031BB26
		// (set) Token: 0x0601591E RID: 88350 RVA: 0x0031D92E File Offset: 0x0031BB2E
		public int NodeId { get; set; }

		// Token: 0x17006B41 RID: 27457
		// (get) Token: 0x0601591F RID: 88351 RVA: 0x0031D937 File Offset: 0x0031BB37
		// (set) Token: 0x06015920 RID: 88352 RVA: 0x0031D93F File Offset: 0x0031BB3F
		public List<int> AreaIds { get; set; }

		// Token: 0x06015921 RID: 88353 RVA: 0x0031D948 File Offset: 0x0031BB48
		public IAreaQuestTrackingT()
		{
			this.QuestId = 0;
			this.NodeId = 0;
			this.AreaIds = null;
		}
	}
}
