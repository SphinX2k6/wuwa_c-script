using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200401A RID: 16410
	public class ICylinderTipsActorT
	{
		// Token: 0x17006F56 RID: 28502
		// (get) Token: 0x060167EF RID: 92143 RVA: 0x00338662 File Offset: 0x00336862
		// (set) Token: 0x060167F0 RID: 92144 RVA: 0x0033866A File Offset: 0x0033686A
		public ETipsActorType Type { get; set; }

		// Token: 0x17006F57 RID: 28503
		// (get) Token: 0x060167F1 RID: 92145 RVA: 0x00338673 File Offset: 0x00336873
		// (set) Token: 0x060167F2 RID: 92146 RVA: 0x0033867B File Offset: 0x0033687B
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006F58 RID: 28504
		// (get) Token: 0x060167F3 RID: 92147 RVA: 0x00338684 File Offset: 0x00336884
		// (set) Token: 0x060167F4 RID: 92148 RVA: 0x0033868C File Offset: 0x0033688C
		public float Radius { get; set; }

		// Token: 0x17006F59 RID: 28505
		// (get) Token: 0x060167F5 RID: 92149 RVA: 0x00338695 File Offset: 0x00336895
		// (set) Token: 0x060167F6 RID: 92150 RVA: 0x0033869D File Offset: 0x0033689D
		public float Height { get; set; }

		// Token: 0x17006F5A RID: 28506
		// (get) Token: 0x060167F7 RID: 92151 RVA: 0x003386A6 File Offset: 0x003368A6
		// (set) Token: 0x060167F8 RID: 92152 RVA: 0x003386AE File Offset: 0x003368AE
		public byte NullMask { get; set; }

		// Token: 0x060167F9 RID: 92153 RVA: 0x003386B7 File Offset: 0x003368B7
		public ICylinderTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.Height = 0f;
			this.NullMask = 0;
		}
	}
}
