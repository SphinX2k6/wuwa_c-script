using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E8 RID: 21736
	public class ICircuitConnectModeBaseT
	{
		// Token: 0x17009B49 RID: 39753
		// (get) Token: 0x06022529 RID: 140585 RVA: 0x004BB366 File Offset: 0x004B9566
		// (set) Token: 0x0602252A RID: 140586 RVA: 0x004BB36E File Offset: 0x004B956E
		public ECircuitConnectMode Type { get; set; }

		// Token: 0x0602252B RID: 140587 RVA: 0x004BB377 File Offset: 0x004B9577
		public ICircuitConnectModeBaseT()
		{
			this.Type = ECircuitConnectMode.TwoRings;
		}
	}
}
