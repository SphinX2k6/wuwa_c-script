using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050DA RID: 20698
	public class IConditionRequestDataT
	{
		// Token: 0x17009452 RID: 37970
		// (get) Token: 0x06020837 RID: 133175 RVA: 0x00482FB5 File Offset: 0x004811B5
		// (set) Token: 0x06020838 RID: 133176 RVA: 0x00482FBD File Offset: 0x004811BD
		public int RequestId { get; set; }

		// Token: 0x17009453 RID: 37971
		// (get) Token: 0x06020839 RID: 133177 RVA: 0x00482FC6 File Offset: 0x004811C6
		// (set) Token: 0x0602083A RID: 133178 RVA: 0x00482FCE File Offset: 0x004811CE
		public string Uid { get; set; }

		// Token: 0x17009454 RID: 37972
		// (get) Token: 0x0602083B RID: 133179 RVA: 0x00482FD7 File Offset: 0x004811D7
		// (set) Token: 0x0602083C RID: 133180 RVA: 0x00482FDF File Offset: 0x004811DF
		public TConditionDebugDataUnion ConditionGroup { get; set; }

		// Token: 0x0602083D RID: 133181 RVA: 0x00482FE8 File Offset: 0x004811E8
		public IConditionRequestDataT()
		{
			this.RequestId = 0;
			this.Uid = null;
			this.ConditionGroup = null;
		}
	}
}
