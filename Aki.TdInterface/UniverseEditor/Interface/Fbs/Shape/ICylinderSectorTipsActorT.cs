using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004017 RID: 16407
	public class ICylinderSectorTipsActorT
	{
		// Token: 0x17006F4A RID: 28490
		// (get) Token: 0x060167CB RID: 92107 RVA: 0x00338270 File Offset: 0x00336470
		// (set) Token: 0x060167CC RID: 92108 RVA: 0x00338278 File Offset: 0x00336478
		public ETipsActorType Type { get; set; }

		// Token: 0x17006F4B RID: 28491
		// (get) Token: 0x060167CD RID: 92109 RVA: 0x00338281 File Offset: 0x00336481
		// (set) Token: 0x060167CE RID: 92110 RVA: 0x00338289 File Offset: 0x00336489
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006F4C RID: 28492
		// (get) Token: 0x060167CF RID: 92111 RVA: 0x00338292 File Offset: 0x00336492
		// (set) Token: 0x060167D0 RID: 92112 RVA: 0x0033829A File Offset: 0x0033649A
		public float Radius { get; set; }

		// Token: 0x17006F4D RID: 28493
		// (get) Token: 0x060167D1 RID: 92113 RVA: 0x003382A3 File Offset: 0x003364A3
		// (set) Token: 0x060167D2 RID: 92114 RVA: 0x003382AB File Offset: 0x003364AB
		public float Height { get; set; }

		// Token: 0x17006F4E RID: 28494
		// (get) Token: 0x060167D3 RID: 92115 RVA: 0x003382B4 File Offset: 0x003364B4
		// (set) Token: 0x060167D4 RID: 92116 RVA: 0x003382BC File Offset: 0x003364BC
		public float Angle { get; set; }

		// Token: 0x17006F4F RID: 28495
		// (get) Token: 0x060167D5 RID: 92117 RVA: 0x003382C5 File Offset: 0x003364C5
		// (set) Token: 0x060167D6 RID: 92118 RVA: 0x003382CD File Offset: 0x003364CD
		public byte NullMask { get; set; }

		// Token: 0x060167D7 RID: 92119 RVA: 0x003382D6 File Offset: 0x003364D6
		public ICylinderSectorTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.Height = 0f;
			this.Angle = 0f;
			this.NullMask = 0;
		}
	}
}
