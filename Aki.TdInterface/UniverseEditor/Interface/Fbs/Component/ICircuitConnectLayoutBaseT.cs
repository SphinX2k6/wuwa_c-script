using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054DC RID: 21724
	public class ICircuitConnectLayoutBaseT
	{
		// Token: 0x17009B34 RID: 39732
		// (get) Token: 0x060224B5 RID: 140469 RVA: 0x004BA3F6 File Offset: 0x004B85F6
		// (set) Token: 0x060224B6 RID: 140470 RVA: 0x004BA3FE File Offset: 0x004B85FE
		public ECircuitConnectElementType Type { get; set; }

		// Token: 0x060224B7 RID: 140471 RVA: 0x004BA407 File Offset: 0x004B8607
		public ICircuitConnectLayoutBaseT()
		{
			this.Type = ECircuitConnectElementType.Straight;
		}
	}
}
