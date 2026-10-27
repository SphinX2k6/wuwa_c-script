using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C4D RID: 15437
	public class ISplineTipsActorT
	{
		// Token: 0x17006A67 RID: 27239
		// (get) Token: 0x0601556B RID: 87403 RVA: 0x00316564 File Offset: 0x00314764
		// (set) Token: 0x0601556C RID: 87404 RVA: 0x0031656C File Offset: 0x0031476C
		public ETipsActorType Type { get; set; }

		// Token: 0x17006A68 RID: 27240
		// (get) Token: 0x0601556D RID: 87405 RVA: 0x00316575 File Offset: 0x00314775
		// (set) Token: 0x0601556E RID: 87406 RVA: 0x0031657D File Offset: 0x0031477D
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006A69 RID: 27241
		// (get) Token: 0x0601556F RID: 87407 RVA: 0x00316586 File Offset: 0x00314786
		// (set) Token: 0x06015570 RID: 87408 RVA: 0x0031658E File Offset: 0x0031478E
		public int EntityId { get; set; }

		// Token: 0x17006A6A RID: 27242
		// (get) Token: 0x06015571 RID: 87409 RVA: 0x00316597 File Offset: 0x00314797
		// (set) Token: 0x06015572 RID: 87410 RVA: 0x0031659F File Offset: 0x0031479F
		public byte NullMask { get; set; }

		// Token: 0x06015573 RID: 87411 RVA: 0x003165A8 File Offset: 0x003147A8
		public ISplineTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.EntityId = 0;
			this.NullMask = 0;
		}
	}
}
