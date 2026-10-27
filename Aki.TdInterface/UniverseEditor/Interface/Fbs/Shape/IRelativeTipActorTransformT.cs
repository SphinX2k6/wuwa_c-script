using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C32 RID: 15410
	public class IRelativeTipActorTransformT
	{
		// Token: 0x17006A18 RID: 27160
		// (get) Token: 0x0601545D RID: 87133 RVA: 0x003144F2 File Offset: 0x003126F2
		// (set) Token: 0x0601545E RID: 87134 RVA: 0x003144FA File Offset: 0x003126FA
		public ETipsActorTransformType Type { get; set; }

		// Token: 0x17006A19 RID: 27161
		// (get) Token: 0x0601545F RID: 87135 RVA: 0x00314503 File Offset: 0x00312703
		// (set) Token: 0x06015460 RID: 87136 RVA: 0x0031450B File Offset: 0x0031270B
		public IVectorInfoT Pos { get; set; }

		// Token: 0x17006A1A RID: 27162
		// (get) Token: 0x06015461 RID: 87137 RVA: 0x00314514 File Offset: 0x00312714
		// (set) Token: 0x06015462 RID: 87138 RVA: 0x0031451C File Offset: 0x0031271C
		public IVectorInfoT Rot { get; set; }

		// Token: 0x17006A1B RID: 27163
		// (get) Token: 0x06015463 RID: 87139 RVA: 0x00314525 File Offset: 0x00312725
		// (set) Token: 0x06015464 RID: 87140 RVA: 0x0031452D File Offset: 0x0031272D
		public int RelativeEntityId { get; set; }

		// Token: 0x06015465 RID: 87141 RVA: 0x00314536 File Offset: 0x00312736
		public IRelativeTipActorTransformT()
		{
			this.Type = ETipsActorTransformType.Absolute;
			this.Pos = null;
			this.Rot = null;
			this.RelativeEntityId = 0;
		}
	}
}
