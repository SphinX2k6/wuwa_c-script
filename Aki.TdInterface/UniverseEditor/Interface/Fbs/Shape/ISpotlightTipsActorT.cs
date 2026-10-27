using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C50 RID: 15440
	public class ISpotlightTipsActorT
	{
		// Token: 0x17006A71 RID: 27249
		// (get) Token: 0x0601558B RID: 87435 RVA: 0x003168FA File Offset: 0x00314AFA
		// (set) Token: 0x0601558C RID: 87436 RVA: 0x00316902 File Offset: 0x00314B02
		public ETipsActorType Type { get; set; }

		// Token: 0x17006A72 RID: 27250
		// (get) Token: 0x0601558D RID: 87437 RVA: 0x0031690B File Offset: 0x00314B0B
		// (set) Token: 0x0601558E RID: 87438 RVA: 0x00316913 File Offset: 0x00314B13
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006A73 RID: 27251
		// (get) Token: 0x0601558F RID: 87439 RVA: 0x0031691C File Offset: 0x00314B1C
		// (set) Token: 0x06015590 RID: 87440 RVA: 0x00316924 File Offset: 0x00314B24
		public float Radius { get; set; }

		// Token: 0x17006A74 RID: 27252
		// (get) Token: 0x06015591 RID: 87441 RVA: 0x0031692D File Offset: 0x00314B2D
		// (set) Token: 0x06015592 RID: 87442 RVA: 0x00316935 File Offset: 0x00314B35
		public float Height { get; set; }

		// Token: 0x17006A75 RID: 27253
		// (get) Token: 0x06015593 RID: 87443 RVA: 0x0031693E File Offset: 0x00314B3E
		// (set) Token: 0x06015594 RID: 87444 RVA: 0x00316946 File Offset: 0x00314B46
		public byte NullMask { get; set; }

		// Token: 0x06015595 RID: 87445 RVA: 0x0031694F File Offset: 0x00314B4F
		public ISpotlightTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.Height = 0f;
			this.NullMask = 0;
		}
	}
}
