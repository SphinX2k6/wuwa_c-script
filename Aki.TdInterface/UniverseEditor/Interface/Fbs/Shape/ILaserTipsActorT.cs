using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004035 RID: 16437
	public class ILaserTipsActorT
	{
		// Token: 0x17006FB1 RID: 28593
		// (get) Token: 0x06016911 RID: 92433 RVA: 0x0033A952 File Offset: 0x00338B52
		// (set) Token: 0x06016912 RID: 92434 RVA: 0x0033A95A File Offset: 0x00338B5A
		public ETipsActorType Type { get; set; }

		// Token: 0x17006FB2 RID: 28594
		// (get) Token: 0x06016913 RID: 92435 RVA: 0x0033A963 File Offset: 0x00338B63
		// (set) Token: 0x06016914 RID: 92436 RVA: 0x0033A96B File Offset: 0x00338B6B
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006FB3 RID: 28595
		// (get) Token: 0x06016915 RID: 92437 RVA: 0x0033A974 File Offset: 0x00338B74
		// (set) Token: 0x06016916 RID: 92438 RVA: 0x0033A97C File Offset: 0x00338B7C
		public float Radius { get; set; }

		// Token: 0x17006FB4 RID: 28596
		// (get) Token: 0x06016917 RID: 92439 RVA: 0x0033A985 File Offset: 0x00338B85
		// (set) Token: 0x06016918 RID: 92440 RVA: 0x0033A98D File Offset: 0x00338B8D
		public float Height { get; set; }

		// Token: 0x17006FB5 RID: 28597
		// (get) Token: 0x06016919 RID: 92441 RVA: 0x0033A996 File Offset: 0x00338B96
		// (set) Token: 0x0601691A RID: 92442 RVA: 0x0033A99E File Offset: 0x00338B9E
		public byte NullMask { get; set; }

		// Token: 0x0601691B RID: 92443 RVA: 0x0033A9A7 File Offset: 0x00338BA7
		public ILaserTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.Height = 0f;
			this.NullMask = 0;
		}
	}
}
