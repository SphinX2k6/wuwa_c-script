using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004128 RID: 16680
	public class IAreaQuestTrackingT
	{
		// Token: 0x170070F9 RID: 28921
		// (get) Token: 0x06016E53 RID: 93779 RVA: 0x00344B8D File Offset: 0x00342D8D
		// (set) Token: 0x06016E54 RID: 93780 RVA: 0x00344B95 File Offset: 0x00342D95
		public int QuestId { get; set; }

		// Token: 0x170070FA RID: 28922
		// (get) Token: 0x06016E55 RID: 93781 RVA: 0x00344B9E File Offset: 0x00342D9E
		// (set) Token: 0x06016E56 RID: 93782 RVA: 0x00344BA6 File Offset: 0x00342DA6
		public int NodeId { get; set; }

		// Token: 0x170070FB RID: 28923
		// (get) Token: 0x06016E57 RID: 93783 RVA: 0x00344BAF File Offset: 0x00342DAF
		// (set) Token: 0x06016E58 RID: 93784 RVA: 0x00344BB7 File Offset: 0x00342DB7
		public List<int> AreaIds { get; set; }

		// Token: 0x06016E59 RID: 93785 RVA: 0x00344BC0 File Offset: 0x00342DC0
		public IAreaQuestTrackingT()
		{
			this.QuestId = 0;
			this.NodeId = 0;
			this.AreaIds = null;
		}
	}
}
