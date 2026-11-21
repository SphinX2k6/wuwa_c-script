using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004059 RID: 16473
	public class ISplineEffectTipsActorT
	{
		// Token: 0x1700700F RID: 28687
		// (get) Token: 0x06016A61 RID: 92769 RVA: 0x0033D0EC File Offset: 0x0033B2EC
		// (set) Token: 0x06016A62 RID: 92770 RVA: 0x0033D0F4 File Offset: 0x0033B2F4
		public ETipsActorType Type { get; set; }

		// Token: 0x17007010 RID: 28688
		// (get) Token: 0x06016A63 RID: 92771 RVA: 0x0033D0FD File Offset: 0x0033B2FD
		// (set) Token: 0x06016A64 RID: 92772 RVA: 0x0033D105 File Offset: 0x0033B305
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17007011 RID: 28689
		// (get) Token: 0x06016A65 RID: 92773 RVA: 0x0033D10E File Offset: 0x0033B30E
		// (set) Token: 0x06016A66 RID: 92774 RVA: 0x0033D116 File Offset: 0x0033B316
		public int EntityId { get; set; }

		// Token: 0x17007012 RID: 28690
		// (get) Token: 0x06016A67 RID: 92775 RVA: 0x0033D11F File Offset: 0x0033B31F
		// (set) Token: 0x06016A68 RID: 92776 RVA: 0x0033D127 File Offset: 0x0033B327
		public byte NullMask { get; set; }

		// Token: 0x06016A69 RID: 92777 RVA: 0x0033D130 File Offset: 0x0033B330
		public ISplineEffectTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.EntityId = 0;
			this.NullMask = 0;
		}
	}
}
