using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC3 RID: 27843
	public class IEnableCameraOperationT
	{
		// Token: 0x1700CC3C RID: 52284
		// (get) Token: 0x0602FFD4 RID: 196564 RVA: 0x00687E2E File Offset: 0x0068602E
		// (set) Token: 0x0602FFD5 RID: 196565 RVA: 0x00687E36 File Offset: 0x00686036
		public ECameraOperationType Type { get; set; }

		// Token: 0x0602FFD6 RID: 196566 RVA: 0x00687E3F File Offset: 0x0068603F
		public IEnableCameraOperationT()
		{
			this.Type = ECameraOperationType.Enable;
		}
	}
}
