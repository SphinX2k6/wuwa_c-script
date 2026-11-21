using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200405F RID: 16479
	public class ISpotlightTipsActorT
	{
		// Token: 0x17007022 RID: 28706
		// (get) Token: 0x06016A9F RID: 92831 RVA: 0x0033D79A File Offset: 0x0033B99A
		// (set) Token: 0x06016AA0 RID: 92832 RVA: 0x0033D7A2 File Offset: 0x0033B9A2
		public ETipsActorType Type { get; set; }

		// Token: 0x17007023 RID: 28707
		// (get) Token: 0x06016AA1 RID: 92833 RVA: 0x0033D7AB File Offset: 0x0033B9AB
		// (set) Token: 0x06016AA2 RID: 92834 RVA: 0x0033D7B3 File Offset: 0x0033B9B3
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x17007024 RID: 28708
		// (get) Token: 0x06016AA3 RID: 92835 RVA: 0x0033D7BC File Offset: 0x0033B9BC
		// (set) Token: 0x06016AA4 RID: 92836 RVA: 0x0033D7C4 File Offset: 0x0033B9C4
		public float Radius { get; set; }

		// Token: 0x17007025 RID: 28709
		// (get) Token: 0x06016AA5 RID: 92837 RVA: 0x0033D7CD File Offset: 0x0033B9CD
		// (set) Token: 0x06016AA6 RID: 92838 RVA: 0x0033D7D5 File Offset: 0x0033B9D5
		public float Height { get; set; }

		// Token: 0x17007026 RID: 28710
		// (get) Token: 0x06016AA7 RID: 92839 RVA: 0x0033D7DE File Offset: 0x0033B9DE
		// (set) Token: 0x06016AA8 RID: 92840 RVA: 0x0033D7E6 File Offset: 0x0033B9E6
		public byte NullMask { get; set; }

		// Token: 0x06016AA9 RID: 92841 RVA: 0x0033D7EF File Offset: 0x0033B9EF
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
