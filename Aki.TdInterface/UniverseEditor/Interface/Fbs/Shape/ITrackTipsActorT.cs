using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C65 RID: 15461
	public class ITrackTipsActorT
	{
		// Token: 0x17006AAA RID: 27306
		// (get) Token: 0x06015651 RID: 87633 RVA: 0x00318066 File Offset: 0x00316266
		// (set) Token: 0x06015652 RID: 87634 RVA: 0x0031806E File Offset: 0x0031626E
		public ETipsActorType Type { get; set; }

		// Token: 0x17006AAB RID: 27307
		// (get) Token: 0x06015653 RID: 87635 RVA: 0x00318077 File Offset: 0x00316277
		// (set) Token: 0x06015654 RID: 87636 RVA: 0x0031807F File Offset: 0x0031627F
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17006AAC RID: 27308
		// (get) Token: 0x06015655 RID: 87637 RVA: 0x00318088 File Offset: 0x00316288
		// (set) Token: 0x06015656 RID: 87638 RVA: 0x00318090 File Offset: 0x00316290
		public int EntityId { get; set; }

		// Token: 0x17006AAD RID: 27309
		// (get) Token: 0x06015657 RID: 87639 RVA: 0x00318099 File Offset: 0x00316299
		// (set) Token: 0x06015658 RID: 87640 RVA: 0x003180A1 File Offset: 0x003162A1
		public float Width { get; set; }

		// Token: 0x17006AAE RID: 27310
		// (get) Token: 0x06015659 RID: 87641 RVA: 0x003180AA File Offset: 0x003162AA
		// (set) Token: 0x0601565A RID: 87642 RVA: 0x003180B2 File Offset: 0x003162B2
		public byte NullMask { get; set; }

		// Token: 0x0601565B RID: 87643 RVA: 0x003180BB File Offset: 0x003162BB
		public ITrackTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.EntityId = 0;
			this.Width = 0f;
			this.NullMask = 0;
		}
	}
}
