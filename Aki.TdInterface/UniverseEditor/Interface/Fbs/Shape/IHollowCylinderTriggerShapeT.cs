using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004029 RID: 16425
	public class IHollowCylinderTriggerShapeT
	{
		// Token: 0x17006F8D RID: 28557
		// (get) Token: 0x06016899 RID: 92313 RVA: 0x00339B05 File Offset: 0x00337D05
		// (set) Token: 0x0601689A RID: 92314 RVA: 0x00339B0D File Offset: 0x00337D0D
		public ETriggerShape Type { get; set; }

		// Token: 0x17006F8E RID: 28558
		// (get) Token: 0x0601689B RID: 92315 RVA: 0x00339B16 File Offset: 0x00337D16
		// (set) Token: 0x0601689C RID: 92316 RVA: 0x00339B1E File Offset: 0x00337D1E
		public IVectorInfoT Center { get; set; }

		// Token: 0x17006F8F RID: 28559
		// (get) Token: 0x0601689D RID: 92317 RVA: 0x00339B27 File Offset: 0x00337D27
		// (set) Token: 0x0601689E RID: 92318 RVA: 0x00339B2F File Offset: 0x00337D2F
		public int Radius { get; set; }

		// Token: 0x17006F90 RID: 28560
		// (get) Token: 0x0601689F RID: 92319 RVA: 0x00339B38 File Offset: 0x00337D38
		// (set) Token: 0x060168A0 RID: 92320 RVA: 0x00339B40 File Offset: 0x00337D40
		public int Height { get; set; }

		// Token: 0x17006F91 RID: 28561
		// (get) Token: 0x060168A1 RID: 92321 RVA: 0x00339B49 File Offset: 0x00337D49
		// (set) Token: 0x060168A2 RID: 92322 RVA: 0x00339B51 File Offset: 0x00337D51
		public int InnerRadius { get; set; }

		// Token: 0x060168A3 RID: 92323 RVA: 0x00339B5A File Offset: 0x00337D5A
		public IHollowCylinderTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
			this.Height = 0;
			this.InnerRadius = 0;
		}
	}
}
