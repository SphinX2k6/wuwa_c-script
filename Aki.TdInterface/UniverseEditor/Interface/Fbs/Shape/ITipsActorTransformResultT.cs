using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C5F RID: 15455
	public class ITipsActorTransformResultT
	{
		// Token: 0x17006A9D RID: 27293
		// (get) Token: 0x06015621 RID: 87585 RVA: 0x00317B3E File Offset: 0x00315D3E
		// (set) Token: 0x06015622 RID: 87586 RVA: 0x00317B46 File Offset: 0x00315D46
		public bool IsSuccess { get; set; }

		// Token: 0x17006A9E RID: 27294
		// (get) Token: 0x06015623 RID: 87587 RVA: 0x00317B4F File Offset: 0x00315D4F
		// (set) Token: 0x06015624 RID: 87588 RVA: 0x00317B57 File Offset: 0x00315D57
		public string Reason { get; set; }

		// Token: 0x17006A9F RID: 27295
		// (get) Token: 0x06015625 RID: 87589 RVA: 0x00317B60 File Offset: 0x00315D60
		// (set) Token: 0x06015626 RID: 87590 RVA: 0x00317B68 File Offset: 0x00315D68
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x17006AA0 RID: 27296
		// (get) Token: 0x06015627 RID: 87591 RVA: 0x00317B71 File Offset: 0x00315D71
		// (set) Token: 0x06015628 RID: 87592 RVA: 0x00317B79 File Offset: 0x00315D79
		public IShapeTransformT TransformWorld { get; set; }

		// Token: 0x17006AA1 RID: 27297
		// (get) Token: 0x06015629 RID: 87593 RVA: 0x00317B82 File Offset: 0x00315D82
		// (set) Token: 0x0601562A RID: 87594 RVA: 0x00317B8A File Offset: 0x00315D8A
		public IHollowTipsActorComponentT HollowTipsActorComponent { get; set; }

		// Token: 0x0601562B RID: 87595 RVA: 0x00317B93 File Offset: 0x00315D93
		public ITipsActorTransformResultT()
		{
			this.IsSuccess = false;
			this.Reason = null;
			this.Type = ETipsActorTransformType.Absolute;
			this.TransformWorld = null;
			this.HollowTipsActorComponent = null;
		}
	}
}
