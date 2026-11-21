using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C0 RID: 26816
	public class IBvbPlayerOperationTypeT
	{
		// Token: 0x1700C51B RID: 50459
		// (get) Token: 0x0602DDD9 RID: 187865 RVA: 0x0064473A File Offset: 0x0064293A
		// (set) Token: 0x0602DDDA RID: 187866 RVA: 0x00644742 File Offset: 0x00642942
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x0602DDDB RID: 187867 RVA: 0x0064474B File Offset: 0x0064294B
		public IBvbPlayerOperationTypeT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
		}
	}
}
