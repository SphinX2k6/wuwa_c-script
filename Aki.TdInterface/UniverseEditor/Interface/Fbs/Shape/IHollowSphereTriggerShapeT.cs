using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200402F RID: 16431
	public class IHollowSphereTriggerShapeT
	{
		// Token: 0x17006FA2 RID: 28578
		// (get) Token: 0x060168DB RID: 92379 RVA: 0x0033A297 File Offset: 0x00338497
		// (set) Token: 0x060168DC RID: 92380 RVA: 0x0033A29F File Offset: 0x0033849F
		public ETriggerShape Type { get; set; }

		// Token: 0x17006FA3 RID: 28579
		// (get) Token: 0x060168DD RID: 92381 RVA: 0x0033A2A8 File Offset: 0x003384A8
		// (set) Token: 0x060168DE RID: 92382 RVA: 0x0033A2B0 File Offset: 0x003384B0
		public IVectorInfoT Center { get; set; }

		// Token: 0x17006FA4 RID: 28580
		// (get) Token: 0x060168DF RID: 92383 RVA: 0x0033A2B9 File Offset: 0x003384B9
		// (set) Token: 0x060168E0 RID: 92384 RVA: 0x0033A2C1 File Offset: 0x003384C1
		public int Radius { get; set; }

		// Token: 0x17006FA5 RID: 28581
		// (get) Token: 0x060168E1 RID: 92385 RVA: 0x0033A2CA File Offset: 0x003384CA
		// (set) Token: 0x060168E2 RID: 92386 RVA: 0x0033A2D2 File Offset: 0x003384D2
		public int InnerRadius { get; set; }

		// Token: 0x060168E3 RID: 92387 RVA: 0x0033A2DB File Offset: 0x003384DB
		public IHollowSphereTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.Center = null;
			this.Radius = 0;
			this.InnerRadius = 0;
		}
	}
}
