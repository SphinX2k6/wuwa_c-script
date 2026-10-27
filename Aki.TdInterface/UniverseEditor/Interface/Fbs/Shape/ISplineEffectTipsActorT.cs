using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C4A RID: 15434
	public class ISplineEffectTipsActorT
	{
		// Token: 0x17006A5E RID: 27230
		// (get) Token: 0x0601554D RID: 87373 RVA: 0x0031624C File Offset: 0x0031444C
		// (set) Token: 0x0601554E RID: 87374 RVA: 0x00316254 File Offset: 0x00314454
		public ETipsActorType Type { get; set; }

		// Token: 0x17006A5F RID: 27231
		// (get) Token: 0x0601554F RID: 87375 RVA: 0x0031625D File Offset: 0x0031445D
		// (set) Token: 0x06015550 RID: 87376 RVA: 0x00316265 File Offset: 0x00314465
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006A60 RID: 27232
		// (get) Token: 0x06015551 RID: 87377 RVA: 0x0031626E File Offset: 0x0031446E
		// (set) Token: 0x06015552 RID: 87378 RVA: 0x00316276 File Offset: 0x00314476
		public int EntityId { get; set; }

		// Token: 0x17006A61 RID: 27233
		// (get) Token: 0x06015553 RID: 87379 RVA: 0x0031627F File Offset: 0x0031447F
		// (set) Token: 0x06015554 RID: 87380 RVA: 0x00316287 File Offset: 0x00314487
		public byte NullMask { get; set; }

		// Token: 0x06015555 RID: 87381 RVA: 0x00316290 File Offset: 0x00314490
		public ISplineEffectTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.EntityId = 0;
			this.NullMask = 0;
		}
	}
}
