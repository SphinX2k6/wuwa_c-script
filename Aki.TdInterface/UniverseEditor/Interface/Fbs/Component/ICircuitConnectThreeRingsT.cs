using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F7 RID: 21751
	public class ICircuitConnectThreeRingsT
	{
		// Token: 0x17009B5B RID: 39771
		// (get) Token: 0x06022587 RID: 140679 RVA: 0x004BBB9E File Offset: 0x004B9D9E
		// (set) Token: 0x06022588 RID: 140680 RVA: 0x004BBBA6 File Offset: 0x004B9DA6
		public ECircuitConnectMode Type { get; set; }

		// Token: 0x06022589 RID: 140681 RVA: 0x004BBBAF File Offset: 0x004B9DAF
		public ICircuitConnectThreeRingsT()
		{
			this.Type = ECircuitConnectMode.TwoRings;
		}
	}
}
