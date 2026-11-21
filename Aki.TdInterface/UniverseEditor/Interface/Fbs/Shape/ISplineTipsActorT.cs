using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200405C RID: 16476
	public class ISplineTipsActorT
	{
		// Token: 0x17007018 RID: 28696
		// (get) Token: 0x06016A7F RID: 92799 RVA: 0x0033D404 File Offset: 0x0033B604
		// (set) Token: 0x06016A80 RID: 92800 RVA: 0x0033D40C File Offset: 0x0033B60C
		public ETipsActorType Type { get; set; }

		// Token: 0x17007019 RID: 28697
		// (get) Token: 0x06016A81 RID: 92801 RVA: 0x0033D415 File Offset: 0x0033B615
		// (set) Token: 0x06016A82 RID: 92802 RVA: 0x0033D41D File Offset: 0x0033B61D
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x1700701A RID: 28698
		// (get) Token: 0x06016A83 RID: 92803 RVA: 0x0033D426 File Offset: 0x0033B626
		// (set) Token: 0x06016A84 RID: 92804 RVA: 0x0033D42E File Offset: 0x0033B62E
		public int EntityId { get; set; }

		// Token: 0x1700701B RID: 28699
		// (get) Token: 0x06016A85 RID: 92805 RVA: 0x0033D437 File Offset: 0x0033B637
		// (set) Token: 0x06016A86 RID: 92806 RVA: 0x0033D43F File Offset: 0x0033B63F
		public byte NullMask { get; set; }

		// Token: 0x06016A87 RID: 92807 RVA: 0x0033D448 File Offset: 0x0033B648
		public ISplineTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.EntityId = 0;
			this.NullMask = 0;
		}
	}
}
