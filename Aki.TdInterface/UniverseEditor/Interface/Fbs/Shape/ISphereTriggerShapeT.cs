using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004053 RID: 16467
	public class ISphereTriggerShapeT
	{
		// Token: 0x17007000 RID: 28672
		// (get) Token: 0x06016A2B RID: 92715 RVA: 0x0033CAC9 File Offset: 0x0033ACC9
		// (set) Token: 0x06016A2C RID: 92716 RVA: 0x0033CAD1 File Offset: 0x0033ACD1
		public ETriggerShape Type { get; set; }

		// Token: 0x17007001 RID: 28673
		// (get) Token: 0x06016A2D RID: 92717 RVA: 0x0033CADA File Offset: 0x0033ACDA
		// (set) Token: 0x06016A2E RID: 92718 RVA: 0x0033CAE2 File Offset: 0x0033ACE2
		public IVectorInfoT Center { get; set; }

		// Token: 0x17007002 RID: 28674
		// (get) Token: 0x06016A2F RID: 92719 RVA: 0x0033CAEB File Offset: 0x0033ACEB
		// (set) Token: 0x06016A30 RID: 92720 RVA: 0x0033CAF3 File Offset: 0x0033ACF3
		public int Radius { get; set; }

		// Token: 0x06016A31 RID: 92721 RVA: 0x0033CAFC File Offset: 0x0033ACFC
		public ISphereTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
		}
	}
}
