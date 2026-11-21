using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F7 RID: 23031
	public class IInteractScreenDetectShapeCircleT
	{
		// Token: 0x1700A759 RID: 42841
		// (get) Token: 0x060259B1 RID: 154033 RVA: 0x005280D4 File Offset: 0x005262D4
		// (set) Token: 0x060259B2 RID: 154034 RVA: 0x005280DC File Offset: 0x005262DC
		public EInteractScreenDetectShape Type { get; set; }

		// Token: 0x1700A75A RID: 42842
		// (get) Token: 0x060259B3 RID: 154035 RVA: 0x005280E5 File Offset: 0x005262E5
		// (set) Token: 0x060259B4 RID: 154036 RVA: 0x005280ED File Offset: 0x005262ED
		public float RadiusRatio { get; set; }

		// Token: 0x060259B5 RID: 154037 RVA: 0x005280F6 File Offset: 0x005262F6
		public IInteractScreenDetectShapeCircleT()
		{
			this.Type = EInteractScreenDetectShape.Circle;
			this.RadiusRatio = 0f;
		}
	}
}
