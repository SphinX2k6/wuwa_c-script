using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005395 RID: 21397
	public class IAimPartT
	{
		// Token: 0x1700973F RID: 38719
		// (get) Token: 0x060215F7 RID: 136695 RVA: 0x0049AFC5 File Offset: 0x004991C5
		// (set) Token: 0x060215F8 RID: 136696 RVA: 0x0049AFCD File Offset: 0x004991CD
		public string BoneName { get; set; }

		// Token: 0x17009740 RID: 38720
		// (get) Token: 0x060215F9 RID: 136697 RVA: 0x0049AFD6 File Offset: 0x004991D6
		// (set) Token: 0x060215FA RID: 136698 RVA: 0x0049AFDE File Offset: 0x004991DE
		public IVectorInfoT Offset { get; set; }

		// Token: 0x17009741 RID: 38721
		// (get) Token: 0x060215FB RID: 136699 RVA: 0x0049AFE7 File Offset: 0x004991E7
		// (set) Token: 0x060215FC RID: 136700 RVA: 0x0049AFEF File Offset: 0x004991EF
		public int RadiusIn { get; set; }

		// Token: 0x17009742 RID: 38722
		// (get) Token: 0x060215FD RID: 136701 RVA: 0x0049AFF8 File Offset: 0x004991F8
		// (set) Token: 0x060215FE RID: 136702 RVA: 0x0049B000 File Offset: 0x00499200
		public int RadiusOut { get; set; }

		// Token: 0x17009743 RID: 38723
		// (get) Token: 0x060215FF RID: 136703 RVA: 0x0049B009 File Offset: 0x00499209
		// (set) Token: 0x06021600 RID: 136704 RVA: 0x0049B011 File Offset: 0x00499211
		public int RadiusOutOnStart { get; set; }

		// Token: 0x17009744 RID: 38724
		// (get) Token: 0x06021601 RID: 136705 RVA: 0x0049B01A File Offset: 0x0049921A
		// (set) Token: 0x06021602 RID: 136706 RVA: 0x0049B022 File Offset: 0x00499222
		public float MobileCorrect { get; set; }

		// Token: 0x17009745 RID: 38725
		// (get) Token: 0x06021603 RID: 136707 RVA: 0x0049B02B File Offset: 0x0049922B
		// (set) Token: 0x06021604 RID: 136708 RVA: 0x0049B033 File Offset: 0x00499233
		public float GamePadCorrect { get; set; }

		// Token: 0x06021605 RID: 136709 RVA: 0x0049B03C File Offset: 0x0049923C
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
