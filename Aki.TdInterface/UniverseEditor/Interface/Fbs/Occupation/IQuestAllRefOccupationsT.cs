using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043BD RID: 17341
	public class IQuestAllRefOccupationsT
	{
		// Token: 0x17007AA4 RID: 31396
		// (get) Token: 0x06019DB4 RID: 105908 RVA: 0x003B3947 File Offset: 0x003B1B47
		// (set) Token: 0x06019DB5 RID: 105909 RVA: 0x003B394F File Offset: 0x003B1B4F
		public int QuestId { get; set; }

		// Token: 0x17007AA5 RID: 31397
		// (get) Token: 0x06019DB6 RID: 105910 RVA: 0x003B3958 File Offset: 0x003B1B58
		// (set) Token: 0x06019DB7 RID: 105911 RVA: 0x003B3960 File Offset: 0x003B1B60
		public List<INodeRefOccupationDataT> QuestActiveOccupations { get; set; }

		// Token: 0x17007AA6 RID: 31398
		// (get) Token: 0x06019DB8 RID: 105912 RVA: 0x003B3969 File Offset: 0x003B1B69
		// (set) Token: 0x06019DB9 RID: 105913 RVA: 0x003B3971 File Offset: 0x003B1B71
		public List<INodeRefOccupationDataT> QuestAcceptOccupations { get; set; }

		// Token: 0x17007AA7 RID: 31399
		// (get) Token: 0x06019DBA RID: 105914 RVA: 0x003B397A File Offset: 0x003B1B7A
		// (set) Token: 0x06019DBB RID: 105915 RVA: 0x003B3982 File Offset: 0x003B1B82
		public List<INodeRefOccupationsT> NodeOccupations { get; set; }

		// Token: 0x06019DBC RID: 105916 RVA: 0x003B398B File Offset: 0x003B1B8B
		public IQuestAllRefOccupationsT()
		{
			this.QuestId = 0;
			this.QuestActiveOccupations = null;
			this.QuestAcceptOccupations = null;
			this.NodeOccupations = null;
		}
	}
}
