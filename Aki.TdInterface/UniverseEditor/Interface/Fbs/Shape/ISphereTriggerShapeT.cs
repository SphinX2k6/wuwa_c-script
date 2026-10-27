using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C44 RID: 15428
	public class ISphereTriggerShapeT
	{
		// Token: 0x17006A4F RID: 27215
		// (get) Token: 0x06015517 RID: 87319 RVA: 0x00315C29 File Offset: 0x00313E29
		// (set) Token: 0x06015518 RID: 87320 RVA: 0x00315C31 File Offset: 0x00313E31
		public ETriggerShape Type { get; set; }

		// Token: 0x17006A50 RID: 27216
		// (get) Token: 0x06015519 RID: 87321 RVA: 0x00315C3A File Offset: 0x00313E3A
		// (set) Token: 0x0601551A RID: 87322 RVA: 0x00315C42 File Offset: 0x00313E42
		public IVectorInfoT Center { get; set; }

		// Token: 0x17006A51 RID: 27217
		// (get) Token: 0x0601551B RID: 87323 RVA: 0x00315C4B File Offset: 0x00313E4B
		// (set) Token: 0x0601551C RID: 87324 RVA: 0x00315C53 File Offset: 0x00313E53
		public int Radius { get; set; }

		// Token: 0x0601551D RID: 87325 RVA: 0x00315C5C File Offset: 0x00313E5C
		public ISphereTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
		}
	}
}
