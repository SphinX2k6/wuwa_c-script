using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200510C RID: 20748
	public class IEffectAreaComponentT
	{
		// Token: 0x17009730 RID: 38704
		// (get) Token: 0x060216EE RID: 136942 RVA: 0x004A45ED File Offset: 0x004A27ED
		// (set) Token: 0x060216EF RID: 136943 RVA: 0x004A45F5 File Offset: 0x004A27F5
		public bool Disabled { get; set; }

		// Token: 0x17009731 RID: 38705
		// (get) Token: 0x060216F0 RID: 136944 RVA: 0x004A45FE File Offset: 0x004A27FE
		// (set) Token: 0x060216F1 RID: 136945 RVA: 0x004A4606 File Offset: 0x004A2806
		public IBuffAreaT Config { get; set; }

		// Token: 0x17009732 RID: 38706
		// (get) Token: 0x060216F2 RID: 136946 RVA: 0x004A460F File Offset: 0x004A280F
		// (set) Token: 0x060216F3 RID: 136947 RVA: 0x004A4617 File Offset: 0x004A2817
		public byte NullMask { get; set; }

		// Token: 0x060216F4 RID: 136948 RVA: 0x004A4620 File Offset: 0x004A2820
		public IEffectAreaComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.NullMask = 0;
		}
	}
}
