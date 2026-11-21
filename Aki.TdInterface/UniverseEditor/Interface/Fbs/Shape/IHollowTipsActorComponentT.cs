using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004032 RID: 16434
	public class IHollowTipsActorComponentT
	{
		// Token: 0x17006FA9 RID: 28585
		// (get) Token: 0x060168F5 RID: 92405 RVA: 0x0033A5DA File Offset: 0x003387DA
		// (set) Token: 0x060168F6 RID: 92406 RVA: 0x0033A5E2 File Offset: 0x003387E2
		public IShapeTransformT InnerShapeCompTransform { get; set; }

		// Token: 0x17006FAA RID: 28586
		// (get) Token: 0x060168F7 RID: 92407 RVA: 0x0033A5EB File Offset: 0x003387EB
		// (set) Token: 0x060168F8 RID: 92408 RVA: 0x0033A5F3 File Offset: 0x003387F3
		public IShapeTransformT OuterShapeCompTransform { get; set; }

		// Token: 0x060168F9 RID: 92409 RVA: 0x0033A5FC File Offset: 0x003387FC
		public IHollowTipsActorComponentT()
		{
			this.InnerShapeCompTransform = null;
			this.OuterShapeCompTransform = null;
		}
	}
}
