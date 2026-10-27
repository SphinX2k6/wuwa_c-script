using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006294 RID: 25236
	public class ICameraOperationTypeT
	{
		// Token: 0x1700BC58 RID: 48216
		// (get) Token: 0x0602B991 RID: 178577 RVA: 0x0060085A File Offset: 0x005FEA5A
		// (set) Token: 0x0602B992 RID: 178578 RVA: 0x00600862 File Offset: 0x005FEA62
		public ECameraOperationType Type { get; set; }

		// Token: 0x0602B993 RID: 178579 RVA: 0x0060086B File Offset: 0x005FEA6B
		public ICameraOperationTypeT()
		{
			this.Type = ECameraOperationType.Enable;
		}
	}
}
