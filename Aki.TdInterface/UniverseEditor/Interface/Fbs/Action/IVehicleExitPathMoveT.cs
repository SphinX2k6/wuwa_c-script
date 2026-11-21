using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D11 RID: 32017
	public class IVehicleExitPathMoveT
	{
		// Token: 0x1700EFA6 RID: 61350
		// (get) Token: 0x06039C8E RID: 236686 RVA: 0x007CB99B File Offset: 0x007C9B9B
		// (set) Token: 0x06039C8F RID: 236687 RVA: 0x007CB9A3 File Offset: 0x007C9BA3
		public EVehicleControlType Type { get; set; }

		// Token: 0x1700EFA7 RID: 61351
		// (get) Token: 0x06039C90 RID: 236688 RVA: 0x007CB9AC File Offset: 0x007C9BAC
		// (set) Token: 0x06039C91 RID: 236689 RVA: 0x007CB9B4 File Offset: 0x007C9BB4
		public TCloseSplineMovePatternUnion Pattern { get; set; }

		// Token: 0x06039C92 RID: 236690 RVA: 0x007CB9BD File Offset: 0x007C9BBD
		public IVehicleExitPathMoveT()
		{
			this.Type = EVehicleControlType.EnterPathMoving;
			this.Pattern = null;
		}
	}
}
