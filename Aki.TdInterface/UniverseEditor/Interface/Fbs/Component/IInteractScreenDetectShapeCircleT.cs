using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005471 RID: 21617
	public class IInteractScreenDetectShapeCircleT
	{
		// Token: 0x17009F1F RID: 40735
		// (get) Token: 0x060238F9 RID: 145657 RVA: 0x004EB060 File Offset: 0x004E9260
		// (set) Token: 0x060238FA RID: 145658 RVA: 0x004EB068 File Offset: 0x004E9268
		public EInteractScreenDetectShape Type { get; set; }

		// Token: 0x17009F20 RID: 40736
		// (get) Token: 0x060238FB RID: 145659 RVA: 0x004EB071 File Offset: 0x004E9271
		// (set) Token: 0x060238FC RID: 145660 RVA: 0x004EB079 File Offset: 0x004E9279
		public float RadiusRatio { get; set; }

		// Token: 0x060238FD RID: 145661 RVA: 0x004EB082 File Offset: 0x004E9282
		public IInteractScreenDetectShapeCircleT()
		{
			this.Type = EInteractScreenDetectShape.Circle;
			this.RadiusRatio = 0f;
		}
	}
}
