using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C14 RID: 15380
	public class IGraphLineTipsActorT
	{
		// Token: 0x170069C3 RID: 27075
		// (get) Token: 0x0601533B RID: 86843 RVA: 0x0031236E File Offset: 0x0031056E
		// (set) Token: 0x0601533C RID: 86844 RVA: 0x00312376 File Offset: 0x00310576
		public ETipsActorType Type { get; set; }

		// Token: 0x170069C4 RID: 27076
		// (get) Token: 0x0601533D RID: 86845 RVA: 0x0031237F File Offset: 0x0031057F
		// (set) Token: 0x0601533E RID: 86846 RVA: 0x00312387 File Offset: 0x00310587
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x170069C5 RID: 27077
		// (get) Token: 0x0601533F RID: 86847 RVA: 0x00312390 File Offset: 0x00310590
		// (set) Token: 0x06015340 RID: 86848 RVA: 0x00312398 File Offset: 0x00310598
		public IVectorInfoT Start { get; set; }

		// Token: 0x170069C6 RID: 27078
		// (get) Token: 0x06015341 RID: 86849 RVA: 0x003123A1 File Offset: 0x003105A1
		// (set) Token: 0x06015342 RID: 86850 RVA: 0x003123A9 File Offset: 0x003105A9
		public IVectorInfoT End { get; set; }

		// Token: 0x170069C7 RID: 27079
		// (get) Token: 0x06015343 RID: 86851 RVA: 0x003123B2 File Offset: 0x003105B2
		// (set) Token: 0x06015344 RID: 86852 RVA: 0x003123BA File Offset: 0x003105BA
		public float Thickness { get; set; }

		// Token: 0x170069C8 RID: 27080
		// (get) Token: 0x06015345 RID: 86853 RVA: 0x003123C3 File Offset: 0x003105C3
		// (set) Token: 0x06015346 RID: 86854 RVA: 0x003123CB File Offset: 0x003105CB
		public byte NullMask { get; set; }

		// Token: 0x06015347 RID: 86855 RVA: 0x003123D4 File Offset: 0x003105D4
		public IGraphLineTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Start = null;
			this.End = null;
			this.Thickness = 0f;
			this.NullMask = 0;
		}
	}
}
