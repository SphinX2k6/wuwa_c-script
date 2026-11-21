using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004044 RID: 16452
	public class IRelativeTipsActorTransformResultT
	{
		// Token: 0x17006FD4 RID: 28628
		// (get) Token: 0x06016995 RID: 92565 RVA: 0x0033B91D File Offset: 0x00339B1D
		// (set) Token: 0x06016996 RID: 92566 RVA: 0x0033B925 File Offset: 0x00339B25
		public bool IsSuccess { get; set; }

		// Token: 0x17006FD5 RID: 28629
		// (get) Token: 0x06016997 RID: 92567 RVA: 0x0033B92E File Offset: 0x00339B2E
		// (set) Token: 0x06016998 RID: 92568 RVA: 0x0033B936 File Offset: 0x00339B36
		public string Reason { get; set; }

		// Token: 0x17006FD6 RID: 28630
		// (get) Token: 0x06016999 RID: 92569 RVA: 0x0033B93F File Offset: 0x00339B3F
		// (set) Token: 0x0601699A RID: 92570 RVA: 0x0033B947 File Offset: 0x00339B47
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x17006FD7 RID: 28631
		// (get) Token: 0x0601699B RID: 92571 RVA: 0x0033B950 File Offset: 0x00339B50
		// (set) Token: 0x0601699C RID: 92572 RVA: 0x0033B958 File Offset: 0x00339B58
		public IShapeTransformT TransformWorld { get; set; }

		// Token: 0x17006FD8 RID: 28632
		// (get) Token: 0x0601699D RID: 92573 RVA: 0x0033B961 File Offset: 0x00339B61
		// (set) Token: 0x0601699E RID: 92574 RVA: 0x0033B969 File Offset: 0x00339B69
		public IHollowTipsActorComponentT HollowTipsActorComponent { get; set; }

		// Token: 0x17006FD9 RID: 28633
		// (get) Token: 0x0601699F RID: 92575 RVA: 0x0033B972 File Offset: 0x00339B72
		// (set) Token: 0x060169A0 RID: 92576 RVA: 0x0033B97A File Offset: 0x00339B7A
		public IShapeTransformT TransformEntity { get; set; }

		// Token: 0x060169A1 RID: 92577 RVA: 0x0033B983 File Offset: 0x00339B83
		public IRelativeTipsActorTransformResultT()
		{
			this.IsSuccess = false;
			this.Reason = null;
			this.Type = ETipsActorTransformType.Absolute;
			this.TransformWorld = null;
			this.HollowTipsActorComponent = null;
			this.TransformEntity = null;
		}
	}
}
