using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200401D RID: 16413
	public class ICylinderTriggerShapeT
	{
		// Token: 0x17006F60 RID: 28512
		// (get) Token: 0x0601680F RID: 92175 RVA: 0x00338A1B File Offset: 0x00336C1B
		// (set) Token: 0x06016810 RID: 92176 RVA: 0x00338A23 File Offset: 0x00336C23
		public ETriggerShape Type { get; set; }

		// Token: 0x17006F61 RID: 28513
		// (get) Token: 0x06016811 RID: 92177 RVA: 0x00338A2C File Offset: 0x00336C2C
		// (set) Token: 0x06016812 RID: 92178 RVA: 0x00338A34 File Offset: 0x00336C34
		public IVectorInfoT Center { get; set; }

		// Token: 0x17006F62 RID: 28514
		// (get) Token: 0x06016813 RID: 92179 RVA: 0x00338A3D File Offset: 0x00336C3D
		// (set) Token: 0x06016814 RID: 92180 RVA: 0x00338A45 File Offset: 0x00336C45
		public int Radius { get; set; }

		// Token: 0x17006F63 RID: 28515
		// (get) Token: 0x06016815 RID: 92181 RVA: 0x00338A4E File Offset: 0x00336C4E
		// (set) Token: 0x06016816 RID: 92182 RVA: 0x00338A56 File Offset: 0x00336C56
		public int Height { get; set; }

		// Token: 0x06016817 RID: 92183 RVA: 0x00338A5F File Offset: 0x00336C5F
		public ICylinderTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
			this.Height = 0;
		}
	}
}
