using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C50 RID: 19536
	public class IListenEntityThroughPortalT
	{
		// Token: 0x17008DF3 RID: 36339
		// (get) Token: 0x0601EFA1 RID: 126881 RVA: 0x0045541D File Offset: 0x0045361D
		// (set) Token: 0x0601EFA2 RID: 126882 RVA: 0x00455425 File Offset: 0x00453625
		public ECondition Type { get; set; }

		// Token: 0x17008DF4 RID: 36340
		// (get) Token: 0x0601EFA3 RID: 126883 RVA: 0x0045542E File Offset: 0x0045362E
		// (set) Token: 0x0601EFA4 RID: 126884 RVA: 0x00455436 File Offset: 0x00453636
		public TTargetEntityUnion CheckTarget { get; set; }

		// Token: 0x17008DF5 RID: 36341
		// (get) Token: 0x0601EFA5 RID: 126885 RVA: 0x0045543F File Offset: 0x0045363F
		// (set) Token: 0x0601EFA6 RID: 126886 RVA: 0x00455447 File Offset: 0x00453647
		public int PortalEntityId { get; set; }

		// Token: 0x0601EFA7 RID: 126887 RVA: 0x00455450 File Offset: 0x00453650
		public IListenEntityThroughPortalT()
		{
			this.Type = ECondition.CompareVar;
			this.CheckTarget = null;
			this.PortalEntityId = 0;
		}
	}
}
