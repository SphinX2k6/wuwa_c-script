using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C02 RID: 15362
	public class IConeTipsActorT
	{
		// Token: 0x17006984 RID: 27012
		// (get) Token: 0x06015275 RID: 86645 RVA: 0x00310B62 File Offset: 0x0030ED62
		// (set) Token: 0x06015276 RID: 86646 RVA: 0x00310B6A File Offset: 0x0030ED6A
		public ETipsActorType Type { get; set; }

		// Token: 0x17006985 RID: 27013
		// (get) Token: 0x06015277 RID: 86647 RVA: 0x00310B73 File Offset: 0x0030ED73
		// (set) Token: 0x06015278 RID: 86648 RVA: 0x00310B7B File Offset: 0x0030ED7B
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006986 RID: 27014
		// (get) Token: 0x06015279 RID: 86649 RVA: 0x00310B84 File Offset: 0x0030ED84
		// (set) Token: 0x0601527A RID: 86650 RVA: 0x00310B8C File Offset: 0x0030ED8C
		public float Radius { get; set; }

		// Token: 0x17006987 RID: 27015
		// (get) Token: 0x0601527B RID: 86651 RVA: 0x00310B95 File Offset: 0x0030ED95
		// (set) Token: 0x0601527C RID: 86652 RVA: 0x00310B9D File Offset: 0x0030ED9D
		public float Height { get; set; }

		// Token: 0x17006988 RID: 27016
		// (get) Token: 0x0601527D RID: 86653 RVA: 0x00310BA6 File Offset: 0x0030EDA6
		// (set) Token: 0x0601527E RID: 86654 RVA: 0x00310BAE File Offset: 0x0030EDAE
		public byte NullMask { get; set; }

		// Token: 0x0601527F RID: 86655 RVA: 0x00310BB7 File Offset: 0x0030EDB7
		public IConeTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Radius = 0f;
			this.Height = 0f;
			this.NullMask = 0;
		}
	}
}
