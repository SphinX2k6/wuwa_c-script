using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B9F RID: 19359
	public class IFavoriteFlowNodeInfoT
	{
		// Token: 0x17008905 RID: 35077
		// (get) Token: 0x0601D86C RID: 120940 RVA: 0x004253E2 File Offset: 0x004235E2
		// (set) Token: 0x0601D86D RID: 120941 RVA: 0x004253EA File Offset: 0x004235EA
		public string HighLightPath { get; set; }

		// Token: 0x17008906 RID: 35078
		// (get) Token: 0x0601D86E RID: 120942 RVA: 0x004253F3 File Offset: 0x004235F3
		// (set) Token: 0x0601D86F RID: 120943 RVA: 0x004253FB File Offset: 0x004235FB
		public IFlowStateIndexT FlowStateIndex { get; set; }

		// Token: 0x17008907 RID: 35079
		// (get) Token: 0x0601D870 RID: 120944 RVA: 0x00425404 File Offset: 0x00423604
		// (set) Token: 0x0601D871 RID: 120945 RVA: 0x0042540C File Offset: 0x0042360C
		public string Desc { get; set; }

		// Token: 0x0601D872 RID: 120946 RVA: 0x00425415 File Offset: 0x00423615
		public IFavoriteFlowNodeInfoT()
		{
			this.HighLightPath = null;
			this.FlowStateIndex = null;
			this.Desc = null;
		}
	}
}
