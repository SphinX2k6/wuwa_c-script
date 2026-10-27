using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C3B RID: 15419
	public class ISectorTipsActorT
	{
		// Token: 0x17006A35 RID: 27189
		// (get) Token: 0x060154BF RID: 87231 RVA: 0x00315168 File Offset: 0x00313368
		// (set) Token: 0x060154C0 RID: 87232 RVA: 0x00315170 File Offset: 0x00313370
		public ETipsActorType Type { get; set; }

		// Token: 0x17006A36 RID: 27190
		// (get) Token: 0x060154C1 RID: 87233 RVA: 0x00315179 File Offset: 0x00313379
		// (set) Token: 0x060154C2 RID: 87234 RVA: 0x00315181 File Offset: 0x00313381
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006A37 RID: 27191
		// (get) Token: 0x060154C3 RID: 87235 RVA: 0x0031518A File Offset: 0x0031338A
		// (set) Token: 0x060154C4 RID: 87236 RVA: 0x00315192 File Offset: 0x00313392
		public float Radius { get; set; }

		// Token: 0x17006A38 RID: 27192
		// (get) Token: 0x060154C5 RID: 87237 RVA: 0x0031519B File Offset: 0x0031339B
		// (set) Token: 0x060154C6 RID: 87238 RVA: 0x003151A3 File Offset: 0x003133A3
		public float Angle { get; set; }

		// Token: 0x17006A39 RID: 27193
		// (get) Token: 0x060154C7 RID: 87239 RVA: 0x003151AC File Offset: 0x003133AC
		// (set) Token: 0x060154C8 RID: 87240 RVA: 0x003151B4 File Offset: 0x003133B4
		public float Offset { get; set; }

		// Token: 0x17006A3A RID: 27194
		// (get) Token: 0x060154C9 RID: 87241 RVA: 0x003151BD File Offset: 0x003133BD
		// (set) Token: 0x060154CA RID: 87242 RVA: 0x003151C5 File Offset: 0x003133C5
		public byte NullMask { get; set; }

		// Token: 0x060154CB RID: 87243 RVA: 0x003151CE File Offset: 0x003133CE
		public ISectorTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.Angle = 0f;
			this.Offset = 0f;
			this.NullMask = 0;
		}
	}
}
