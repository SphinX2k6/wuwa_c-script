using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200404A RID: 16458
	public class ISectorTipsActorT
	{
		// Token: 0x17006FE6 RID: 28646
		// (get) Token: 0x060169D3 RID: 92627 RVA: 0x0033C008 File Offset: 0x0033A208
		// (set) Token: 0x060169D4 RID: 92628 RVA: 0x0033C010 File Offset: 0x0033A210
		public ETipsActorType Type { get; set; }

		// Token: 0x17006FE7 RID: 28647
		// (get) Token: 0x060169D5 RID: 92629 RVA: 0x0033C019 File Offset: 0x0033A219
		// (set) Token: 0x060169D6 RID: 92630 RVA: 0x0033C021 File Offset: 0x0033A221
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006FE8 RID: 28648
		// (get) Token: 0x060169D7 RID: 92631 RVA: 0x0033C02A File Offset: 0x0033A22A
		// (set) Token: 0x060169D8 RID: 92632 RVA: 0x0033C032 File Offset: 0x0033A232
		public float Radius { get; set; }

		// Token: 0x17006FE9 RID: 28649
		// (get) Token: 0x060169D9 RID: 92633 RVA: 0x0033C03B File Offset: 0x0033A23B
		// (set) Token: 0x060169DA RID: 92634 RVA: 0x0033C043 File Offset: 0x0033A243
		public float Angle { get; set; }

		// Token: 0x17006FEA RID: 28650
		// (get) Token: 0x060169DB RID: 92635 RVA: 0x0033C04C File Offset: 0x0033A24C
		// (set) Token: 0x060169DC RID: 92636 RVA: 0x0033C054 File Offset: 0x0033A254
		public float Offset { get; set; }

		// Token: 0x17006FEB RID: 28651
		// (get) Token: 0x060169DD RID: 92637 RVA: 0x0033C05D File Offset: 0x0033A25D
		// (set) Token: 0x060169DE RID: 92638 RVA: 0x0033C065 File Offset: 0x0033A265
		public byte NullMask { get; set; }

		// Token: 0x060169DF RID: 92639 RVA: 0x0033C06E File Offset: 0x0033A26E
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
