using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D08 RID: 32008
	public class IVehicleEnterPathMoveT
	{
		// Token: 0x1700EF96 RID: 61334
		// (get) Token: 0x06039C34 RID: 236596 RVA: 0x007CAB5D File Offset: 0x007C8D5D
		// (set) Token: 0x06039C35 RID: 236597 RVA: 0x007CAB65 File Offset: 0x007C8D65
		public EVehicleControlType Type { get; set; }

		// Token: 0x1700EF97 RID: 61335
		// (get) Token: 0x06039C36 RID: 236598 RVA: 0x007CAB6E File Offset: 0x007C8D6E
		// (set) Token: 0x06039C37 RID: 236599 RVA: 0x007CAB76 File Offset: 0x007C8D76
		public IVehicleCruisingParamsT ControlParams { get; set; }

		// Token: 0x1700EF98 RID: 61336
		// (get) Token: 0x06039C38 RID: 236600 RVA: 0x007CAB7F File Offset: 0x007C8D7F
		// (set) Token: 0x06039C39 RID: 236601 RVA: 0x007CAB87 File Offset: 0x007C8D87
		public TSplineMovePatternUnion Pattern { get; set; }

		// Token: 0x06039C3A RID: 236602 RVA: 0x007CAB90 File Offset: 0x007C8D90
		public IVehicleEnterPathMoveT()
		{
			this.Type = EVehicleControlType.EnterPathMoving;
			this.ControlParams = null;
			this.Pattern = null;
		}
	}
}
