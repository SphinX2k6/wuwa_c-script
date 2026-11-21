using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200481F RID: 18463
	public class IQuestAllRefOccupationsT
	{
		// Token: 0x170080DB RID: 32987
		// (get) Token: 0x0601B54F RID: 111951 RVA: 0x003DF5DF File Offset: 0x003DD7DF
		// (set) Token: 0x0601B550 RID: 111952 RVA: 0x003DF5E7 File Offset: 0x003DD7E7
		public int QuestId { get; set; }

		// Token: 0x170080DC RID: 32988
		// (get) Token: 0x0601B551 RID: 111953 RVA: 0x003DF5F0 File Offset: 0x003DD7F0
		// (set) Token: 0x0601B552 RID: 111954 RVA: 0x003DF5F8 File Offset: 0x003DD7F8
		public List<INodeRefOccupationDataT> QuestActiveOccupations { get; set; }

		// Token: 0x170080DD RID: 32989
		// (get) Token: 0x0601B553 RID: 111955 RVA: 0x003DF601 File Offset: 0x003DD801
		// (set) Token: 0x0601B554 RID: 111956 RVA: 0x003DF609 File Offset: 0x003DD809
		public List<INodeRefOccupationDataT> QuestAcceptOccupations { get; set; }

		// Token: 0x170080DE RID: 32990
		// (get) Token: 0x0601B555 RID: 111957 RVA: 0x003DF612 File Offset: 0x003DD812
		// (set) Token: 0x0601B556 RID: 111958 RVA: 0x003DF61A File Offset: 0x003DD81A
		public List<INodeRefOccupationsT> NodeOccupations { get; set; }

		// Token: 0x0601B557 RID: 111959 RVA: 0x003DF623 File Offset: 0x003DD823
		public IQuestAllRefOccupationsT()
		{
			this.QuestId = 0;
			this.QuestActiveOccupations = null;
			this.QuestAcceptOccupations = null;
			this.NodeOccupations = null;
		}
	}
}
