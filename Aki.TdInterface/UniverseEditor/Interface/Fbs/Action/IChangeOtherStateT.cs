using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006983 RID: 27011
	public class IChangeOtherStateT
	{
		// Token: 0x1700C6DF RID: 50911
		// (get) Token: 0x0602E53E RID: 189758 RVA: 0x00653303 File Offset: 0x00651503
		// (set) Token: 0x0602E53F RID: 189759 RVA: 0x0065330B File Offset: 0x0065150B
		public int EntityId { get; set; }

		// Token: 0x1700C6E0 RID: 50912
		// (get) Token: 0x0602E540 RID: 189760 RVA: 0x00653314 File Offset: 0x00651514
		// (set) Token: 0x0602E541 RID: 189761 RVA: 0x0065331C File Offset: 0x0065151C
		public IPlayFlowT State { get; set; }

		// Token: 0x0602E542 RID: 189762 RVA: 0x00653325 File Offset: 0x00651525
		public IChangeOtherStateT()
		{
			this.EntityId = 0;
			this.State = null;
		}
	}
}
