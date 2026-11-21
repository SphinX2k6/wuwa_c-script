using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C42 RID: 27714
	public class IDisableCameraOperationT
	{
		// Token: 0x1700CB12 RID: 51986
		// (get) Token: 0x0602FB18 RID: 195352 RVA: 0x0067EE72 File Offset: 0x0067D072
		// (set) Token: 0x0602FB19 RID: 195353 RVA: 0x0067EE7A File Offset: 0x0067D07A
		public ECameraOperationType Type { get; set; }

		// Token: 0x0602FB1A RID: 195354 RVA: 0x0067EE83 File Offset: 0x0067D083
		public IDisableCameraOperationT()
		{
			this.Type = ECameraOperationType.Enable;
		}
	}
}
