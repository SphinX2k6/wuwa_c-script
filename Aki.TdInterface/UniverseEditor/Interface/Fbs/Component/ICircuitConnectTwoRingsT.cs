using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054FA RID: 21754
	public class ICircuitConnectTwoRingsT
	{
		// Token: 0x17009B5E RID: 39774
		// (get) Token: 0x06022599 RID: 140697 RVA: 0x004BBD16 File Offset: 0x004B9F16
		// (set) Token: 0x0602259A RID: 140698 RVA: 0x004BBD1E File Offset: 0x004B9F1E
		public ECircuitConnectMode Type { get; set; }

		// Token: 0x0602259B RID: 140699 RVA: 0x004BBD27 File Offset: 0x004B9F27
		public ICircuitConnectTwoRingsT()
		{
			this.Type = ECircuitConnectMode.TwoRings;
		}
	}
}
