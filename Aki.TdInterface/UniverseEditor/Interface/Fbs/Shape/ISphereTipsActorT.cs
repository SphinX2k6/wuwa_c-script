using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004050 RID: 16464
	public class ISphereTipsActorT
	{
		// Token: 0x17006FF8 RID: 28664
		// (get) Token: 0x06016A0F RID: 92687 RVA: 0x0033C7A0 File Offset: 0x0033A9A0
		// (set) Token: 0x06016A10 RID: 92688 RVA: 0x0033C7A8 File Offset: 0x0033A9A8
		public ETipsActorType Type { get; set; }

		// Token: 0x17006FF9 RID: 28665
		// (get) Token: 0x06016A11 RID: 92689 RVA: 0x0033C7B1 File Offset: 0x0033A9B1
		// (set) Token: 0x06016A12 RID: 92690 RVA: 0x0033C7B9 File Offset: 0x0033A9B9
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006FFA RID: 28666
		// (get) Token: 0x06016A13 RID: 92691 RVA: 0x0033C7C2 File Offset: 0x0033A9C2
		// (set) Token: 0x06016A14 RID: 92692 RVA: 0x0033C7CA File Offset: 0x0033A9CA
		public float Radius { get; set; }

		// Token: 0x17006FFB RID: 28667
		// (get) Token: 0x06016A15 RID: 92693 RVA: 0x0033C7D3 File Offset: 0x0033A9D3
		// (set) Token: 0x06016A16 RID: 92694 RVA: 0x0033C7DB File Offset: 0x0033A9DB
		public byte NullMask { get; set; }

		// Token: 0x06016A17 RID: 92695 RVA: 0x0033C7E4 File Offset: 0x0033A9E4
		public ISphereTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.NullMask = 0;
		}
	}
}
