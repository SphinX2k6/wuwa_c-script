using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C41 RID: 15425
	public class ISphereTipsActorT
	{
		// Token: 0x17006A47 RID: 27207
		// (get) Token: 0x060154FB RID: 87291 RVA: 0x00315900 File Offset: 0x00313B00
		// (set) Token: 0x060154FC RID: 87292 RVA: 0x00315908 File Offset: 0x00313B08
		public ETipsActorType Type { get; set; }

		// Token: 0x17006A48 RID: 27208
		// (get) Token: 0x060154FD RID: 87293 RVA: 0x00315911 File Offset: 0x00313B11
		// (set) Token: 0x060154FE RID: 87294 RVA: 0x00315919 File Offset: 0x00313B19
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006A49 RID: 27209
		// (get) Token: 0x060154FF RID: 87295 RVA: 0x00315922 File Offset: 0x00313B22
		// (set) Token: 0x06015500 RID: 87296 RVA: 0x0031592A File Offset: 0x00313B2A
		public float Radius { get; set; }

		// Token: 0x17006A4A RID: 27210
		// (get) Token: 0x06015501 RID: 87297 RVA: 0x00315933 File Offset: 0x00313B33
		// (set) Token: 0x06015502 RID: 87298 RVA: 0x0031593B File Offset: 0x00313B3B
		public byte NullMask { get; set; }

		// Token: 0x06015503 RID: 87299 RVA: 0x00315944 File Offset: 0x00313B44
		public ISphereTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.NullMask = 0;
		}
	}
}
