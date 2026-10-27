using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A40 RID: 19008
	public class ICheckGiantTotalProgressInteractActivatedNodeT
	{
		// Token: 0x1700899D RID: 35229
		// (get) Token: 0x0601DC3A RID: 121914 RVA: 0x0042F763 File Offset: 0x0042D963
		// (set) Token: 0x0601DC3B RID: 121915 RVA: 0x0042F76B File Offset: 0x0042D96B
		public ECondition Type { get; set; }

		// Token: 0x1700899E RID: 35230
		// (get) Token: 0x0601DC3C RID: 121916 RVA: 0x0042F774 File Offset: 0x0042D974
		// (set) Token: 0x0601DC3D RID: 121917 RVA: 0x0042F77C File Offset: 0x0042D97C
		public List<int> NodeIds { get; set; }

		// Token: 0x0601DC3E RID: 121918 RVA: 0x0042F785 File Offset: 0x0042D985
		public ICheckGiantTotalProgressInteractActivatedNodeT()
		{
			this.Type = ECondition.CompareVar;
			this.NodeIds = null;
		}
	}
}
