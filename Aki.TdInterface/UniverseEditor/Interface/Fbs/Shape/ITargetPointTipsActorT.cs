using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004065 RID: 16485
	public class ITargetPointTipsActorT
	{
		// Token: 0x1700703B RID: 28731
		// (get) Token: 0x06016AEB RID: 92907 RVA: 0x0033E077 File Offset: 0x0033C277
		// (set) Token: 0x06016AEC RID: 92908 RVA: 0x0033E07F File Offset: 0x0033C27F
		public ETipsActorType Type { get; set; }

		// Token: 0x1700703C RID: 28732
		// (get) Token: 0x06016AED RID: 92909 RVA: 0x0033E088 File Offset: 0x0033C288
		// (set) Token: 0x06016AEE RID: 92910 RVA: 0x0033E090 File Offset: 0x0033C290
		public ETipsActorColorType ColorType { get; set; }

		// Token: 0x1700703D RID: 28733
		// (get) Token: 0x06016AEF RID: 92911 RVA: 0x0033E099 File Offset: 0x0033C299
		// (set) Token: 0x06016AF0 RID: 92912 RVA: 0x0033E0A1 File Offset: 0x0033C2A1
		public string Label { get; set; }

		// Token: 0x1700703E RID: 28734
		// (get) Token: 0x06016AF1 RID: 92913 RVA: 0x0033E0AA File Offset: 0x0033C2AA
		// (set) Token: 0x06016AF2 RID: 92914 RVA: 0x0033E0B2 File Offset: 0x0033C2B2
		public byte NullMask { get; set; }

		// Token: 0x06016AF3 RID: 92915 RVA: 0x0033E0BB File Offset: 0x0033C2BB
		public ITargetPointTipsActorT()
		{
			this.Type = ETipsActorType.Sphere;
			this.ColorType = ETipsActorColorType.Inner;
			this.Label = null;
			this.NullMask = 0;
		}
	}
}
