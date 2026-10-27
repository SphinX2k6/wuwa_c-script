using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E84 RID: 20100
	public class IAimPartT
	{
		// Token: 0x17009006 RID: 36870
		// (get) Token: 0x0601F9AC RID: 129452 RVA: 0x00466FAD File Offset: 0x004651AD
		// (set) Token: 0x0601F9AD RID: 129453 RVA: 0x00466FB5 File Offset: 0x004651B5
		public string BoneName { get; set; }

		// Token: 0x17009007 RID: 36871
		// (get) Token: 0x0601F9AE RID: 129454 RVA: 0x00466FBE File Offset: 0x004651BE
		// (set) Token: 0x0601F9AF RID: 129455 RVA: 0x00466FC6 File Offset: 0x004651C6
		public IVectorInfoT Offset { get; set; }

		// Token: 0x17009008 RID: 36872
		// (get) Token: 0x0601F9B0 RID: 129456 RVA: 0x00466FCF File Offset: 0x004651CF
		// (set) Token: 0x0601F9B1 RID: 129457 RVA: 0x00466FD7 File Offset: 0x004651D7
		public int RadiusIn { get; set; }

		// Token: 0x17009009 RID: 36873
		// (get) Token: 0x0601F9B2 RID: 129458 RVA: 0x00466FE0 File Offset: 0x004651E0
		// (set) Token: 0x0601F9B3 RID: 129459 RVA: 0x00466FE8 File Offset: 0x004651E8
		public int RadiusOut { get; set; }

		// Token: 0x1700900A RID: 36874
		// (get) Token: 0x0601F9B4 RID: 129460 RVA: 0x00466FF1 File Offset: 0x004651F1
		// (set) Token: 0x0601F9B5 RID: 129461 RVA: 0x00466FF9 File Offset: 0x004651F9
		public int RadiusOutOnStart { get; set; }

		// Token: 0x1700900B RID: 36875
		// (get) Token: 0x0601F9B6 RID: 129462 RVA: 0x00467002 File Offset: 0x00465202
		// (set) Token: 0x0601F9B7 RID: 129463 RVA: 0x0046700A File Offset: 0x0046520A
		public float MobileCorrect { get; set; }

		// Token: 0x1700900C RID: 36876
		// (get) Token: 0x0601F9B8 RID: 129464 RVA: 0x00467013 File Offset: 0x00465213
		// (set) Token: 0x0601F9B9 RID: 129465 RVA: 0x0046701B File Offset: 0x0046521B
		public float GamePadCorrect { get; set; }

		// Token: 0x0601F9BA RID: 129466 RVA: 0x00467024 File Offset: 0x00465224
		public IAimPartT()
		{
			this.BoneName = null;
			this.Offset = null;
			this.RadiusIn = 0;
			this.RadiusOut = 0;
			this.RadiusOutOnStart = 0;
			this.MobileCorrect = 0f;
			this.GamePadCorrect = 0f;
		}
	}
}
