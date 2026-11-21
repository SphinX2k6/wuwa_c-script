using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054EE RID: 21742
	public class ICircuitConnectOutputPortLayoutT
	{
		// Token: 0x17009B4E RID: 39758
		// (get) Token: 0x06022549 RID: 140617 RVA: 0x004BB626 File Offset: 0x004B9826
		// (set) Token: 0x0602254A RID: 140618 RVA: 0x004BB62E File Offset: 0x004B982E
		public ECircuitConnectElementType Type { get; set; }

		// Token: 0x0602254B RID: 140619 RVA: 0x004BB637 File Offset: 0x004B9837
		public ICircuitConnectOutputPortLayoutT()
		{
			this.Type = ECircuitConnectElementType.Straight;
		}
	}
}
