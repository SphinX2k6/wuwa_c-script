using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E51 RID: 24145
	public class IRenderFogBarrierT
	{
		// Token: 0x1700B208 RID: 45576
		// (get) Token: 0x060285BB RID: 165307 RVA: 0x00584AEC File Offset: 0x00582CEC
		// (set) Token: 0x060285BC RID: 165308 RVA: 0x00584AF4 File Offset: 0x00582CF4
		public ERenderSpecifiedRangeType Type { get; set; }

		// Token: 0x1700B209 RID: 45577
		// (get) Token: 0x060285BD RID: 165309 RVA: 0x00584AFD File Offset: 0x00582CFD
		// (set) Token: 0x060285BE RID: 165310 RVA: 0x00584B05 File Offset: 0x00582D05
		public TTargetEntityUnion CenterTarget { get; set; }

		// Token: 0x1700B20A RID: 45578
		// (get) Token: 0x060285BF RID: 165311 RVA: 0x00584B0E File Offset: 0x00582D0E
		// (set) Token: 0x060285C0 RID: 165312 RVA: 0x00584B16 File Offset: 0x00582D16
		public IVectorInfoT Center { get; set; }

		// Token: 0x1700B20B RID: 45579
		// (get) Token: 0x060285C1 RID: 165313 RVA: 0x00584B1F File Offset: 0x00582D1F
		// (set) Token: 0x060285C2 RID: 165314 RVA: 0x00584B27 File Offset: 0x00582D27
		public IVectorInfoT Size { get; set; }

		// Token: 0x1700B20C RID: 45580
		// (get) Token: 0x060285C3 RID: 165315 RVA: 0x00584B30 File Offset: 0x00582D30
		// (set) Token: 0x060285C4 RID: 165316 RVA: 0x00584B38 File Offset: 0x00582D38
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x060285C5 RID: 165317 RVA: 0x00584B41 File Offset: 0x00582D41
		public IRenderFogBarrierT()
		{
			this.Type = ERenderSpecifiedRangeType.FlowerBridge;
			this.CenterTarget = null;
			this.Center = null;
			this.Size = null;
			this.Rotator = null;
		}
	}
}
