using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004023 RID: 16419
	public class IGraphPointTipsActorT
	{
		// Token: 0x17006F76 RID: 28534
		// (get) Token: 0x06016853 RID: 92243 RVA: 0x003392A4 File Offset: 0x003374A4
		// (set) Token: 0x06016854 RID: 92244 RVA: 0x003392AC File Offset: 0x003374AC
		public ETipsActorType Type { get; set; }

		// Token: 0x17006F77 RID: 28535
		// (get) Token: 0x06016855 RID: 92245 RVA: 0x003392B5 File Offset: 0x003374B5
		// (set) Token: 0x06016856 RID: 92246 RVA: 0x003392BD File Offset: 0x003374BD
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006F78 RID: 28536
		// (get) Token: 0x06016857 RID: 92247 RVA: 0x003392C6 File Offset: 0x003374C6
		// (set) Token: 0x06016858 RID: 92248 RVA: 0x003392CE File Offset: 0x003374CE
		public float Size { get; set; }

		// Token: 0x17006F79 RID: 28537
		// (get) Token: 0x06016859 RID: 92249 RVA: 0x003392D7 File Offset: 0x003374D7
		// (set) Token: 0x0601685A RID: 92250 RVA: 0x003392DF File Offset: 0x003374DF
		public byte NullMask { get; set; }

		// Token: 0x0601685B RID: 92251 RVA: 0x003392E8 File Offset: 0x003374E8
		public IGraphPointTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Size = 0f;
			this.NullMask = 0;
		}
	}
}
