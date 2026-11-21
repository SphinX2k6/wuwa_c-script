using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004026 RID: 16422
	public class IHollowCylinderTipsActorT
	{
		// Token: 0x17006F81 RID: 28545
		// (get) Token: 0x06016875 RID: 92277 RVA: 0x003396BC File Offset: 0x003378BC
		// (set) Token: 0x06016876 RID: 92278 RVA: 0x003396C4 File Offset: 0x003378C4
		public ETipsActorType Type { get; set; }

		// Token: 0x17006F82 RID: 28546
		// (get) Token: 0x06016877 RID: 92279 RVA: 0x003396CD File Offset: 0x003378CD
		// (set) Token: 0x06016878 RID: 92280 RVA: 0x003396D5 File Offset: 0x003378D5
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006F83 RID: 28547
		// (get) Token: 0x06016879 RID: 92281 RVA: 0x003396DE File Offset: 0x003378DE
		// (set) Token: 0x0601687A RID: 92282 RVA: 0x003396E6 File Offset: 0x003378E6
		public float Radius { get; set; }

		// Token: 0x17006F84 RID: 28548
		// (get) Token: 0x0601687B RID: 92283 RVA: 0x003396EF File Offset: 0x003378EF
		// (set) Token: 0x0601687C RID: 92284 RVA: 0x003396F7 File Offset: 0x003378F7
		public float InnerRadius { get; set; }

		// Token: 0x17006F85 RID: 28549
		// (get) Token: 0x0601687D RID: 92285 RVA: 0x00339700 File Offset: 0x00337900
		// (set) Token: 0x0601687E RID: 92286 RVA: 0x00339708 File Offset: 0x00337908
		public float Height { get; set; }

		// Token: 0x17006F86 RID: 28550
		// (get) Token: 0x0601687F RID: 92287 RVA: 0x00339711 File Offset: 0x00337911
		// (set) Token: 0x06016880 RID: 92288 RVA: 0x00339719 File Offset: 0x00337919
		public byte NullMask { get; set; }

		// Token: 0x06016881 RID: 92289 RVA: 0x00339722 File Offset: 0x00337922
		public IHollowCylinderTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.InnerRadius = 0f;
			this.Height = 0f;
			this.NullMask = 0;
		}
	}
}
