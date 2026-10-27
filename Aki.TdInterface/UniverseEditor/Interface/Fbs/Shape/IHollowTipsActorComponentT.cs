using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C26 RID: 15398
	public class IHollowTipsActorComponentT
	{
		// Token: 0x17006A01 RID: 27137
		// (get) Token: 0x060153FF RID: 87039 RVA: 0x00313A52 File Offset: 0x00311C52
		// (set) Token: 0x06015400 RID: 87040 RVA: 0x00313A5A File Offset: 0x00311C5A
		public IShapeTransformT InnerShapeCompTransform { get; set; }

		// Token: 0x17006A02 RID: 27138
		// (get) Token: 0x06015401 RID: 87041 RVA: 0x00313A63 File Offset: 0x00311C63
		// (set) Token: 0x06015402 RID: 87042 RVA: 0x00313A6B File Offset: 0x00311C6B
		public IShapeTransformT OuterShapeCompTransform { get; set; }

		// Token: 0x06015403 RID: 87043 RVA: 0x00313A74 File Offset: 0x00311C74
		public IHollowTipsActorComponentT()
		{
			this.InnerShapeCompTransform = null;
			this.OuterShapeCompTransform = null;
		}
	}
}
