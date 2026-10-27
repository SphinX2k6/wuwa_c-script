using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C35 RID: 15413
	public class IRelativeTipsActorTransformResultT
	{
		// Token: 0x17006A23 RID: 27171
		// (get) Token: 0x06015481 RID: 87169 RVA: 0x00314A7D File Offset: 0x00312C7D
		// (set) Token: 0x06015482 RID: 87170 RVA: 0x00314A85 File Offset: 0x00312C85
		public bool IsSuccess { get; set; }

		// Token: 0x17006A24 RID: 27172
		// (get) Token: 0x06015483 RID: 87171 RVA: 0x00314A8E File Offset: 0x00312C8E
		// (set) Token: 0x06015484 RID: 87172 RVA: 0x00314A96 File Offset: 0x00312C96
		public string Reason { get; set; }

		// Token: 0x17006A25 RID: 27173
		// (get) Token: 0x06015485 RID: 87173 RVA: 0x00314A9F File Offset: 0x00312C9F
		// (set) Token: 0x06015486 RID: 87174 RVA: 0x00314AA7 File Offset: 0x00312CA7
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x17006A26 RID: 27174
		// (get) Token: 0x06015487 RID: 87175 RVA: 0x00314AB0 File Offset: 0x00312CB0
		// (set) Token: 0x06015488 RID: 87176 RVA: 0x00314AB8 File Offset: 0x00312CB8
		public IShapeTransformT TransformWorld { get; set; }

		// Token: 0x17006A27 RID: 27175
		// (get) Token: 0x06015489 RID: 87177 RVA: 0x00314AC1 File Offset: 0x00312CC1
		// (set) Token: 0x0601548A RID: 87178 RVA: 0x00314AC9 File Offset: 0x00312CC9
		public IHollowTipsActorComponentT HollowTipsActorComponent { get; set; }

		// Token: 0x17006A28 RID: 27176
		// (get) Token: 0x0601548B RID: 87179 RVA: 0x00314AD2 File Offset: 0x00312CD2
		// (set) Token: 0x0601548C RID: 87180 RVA: 0x00314ADA File Offset: 0x00312CDA
		public IShapeTransformT TransformEntity { get; set; }

		// Token: 0x0601548D RID: 87181 RVA: 0x00314AE3 File Offset: 0x00312CE3
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
