using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A03 RID: 23043
	public class IInteractStyleEntityPartT
	{
		// Token: 0x1700A76A RID: 42858
		// (get) Token: 0x06025A05 RID: 154117 RVA: 0x005289E7 File Offset: 0x00526BE7
		// (set) Token: 0x06025A06 RID: 154118 RVA: 0x005289EF File Offset: 0x00526BEF
		public EInteractStyleType Type { get; set; }

		// Token: 0x1700A76B RID: 42859
		// (get) Token: 0x06025A07 RID: 154119 RVA: 0x005289F8 File Offset: 0x00526BF8
		// (set) Token: 0x06025A08 RID: 154120 RVA: 0x00528A00 File Offset: 0x00526C00
		public TInteractEntityPartBindUnion Bind { get; set; }

		// Token: 0x1700A76C RID: 42860
		// (get) Token: 0x06025A09 RID: 154121 RVA: 0x00528A09 File Offset: 0x00526C09
		// (set) Token: 0x06025A0A RID: 154122 RVA: 0x00528A11 File Offset: 0x00526C11
		public float ShowAngle { get; set; }

		// Token: 0x1700A76D RID: 42861
		// (get) Token: 0x06025A0B RID: 154123 RVA: 0x00528A1A File Offset: 0x00526C1A
		// (set) Token: 0x06025A0C RID: 154124 RVA: 0x00528A22 File Offset: 0x00526C22
		public float TriggerAngle { get; set; }

		// Token: 0x06025A0D RID: 154125 RVA: 0x00528A2B File Offset: 0x00526C2B
		public IInteractStyleEntityPartT()
		{
			this.Type = EInteractStyleType.Panorama;
			this.Bind = null;
			this.ShowAngle = 0f;
			this.TriggerAngle = 0f;
		}
	}
}
