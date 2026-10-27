using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200592D RID: 22829
	public class ISlidePerformComponentT
	{
		// Token: 0x1700AB50 RID: 43856
		// (get) Token: 0x060269F2 RID: 158194 RVA: 0x00551EE5 File Offset: 0x005500E5
		// (set) Token: 0x060269F3 RID: 158195 RVA: 0x00551EED File Offset: 0x005500ED
		public bool Disabled { get; set; }

		// Token: 0x1700AB51 RID: 43857
		// (get) Token: 0x060269F4 RID: 158196 RVA: 0x00551EF6 File Offset: 0x005500F6
		// (set) Token: 0x060269F5 RID: 158197 RVA: 0x00551EFE File Offset: 0x005500FE
		public int SlideSpeed { get; set; }

		// Token: 0x1700AB52 RID: 43858
		// (get) Token: 0x060269F6 RID: 158198 RVA: 0x00551F07 File Offset: 0x00550107
		// (set) Token: 0x060269F7 RID: 158199 RVA: 0x00551F0F File Offset: 0x0055010F
		public int UpSpeed { get; set; }

		// Token: 0x1700AB53 RID: 43859
		// (get) Token: 0x060269F8 RID: 158200 RVA: 0x00551F18 File Offset: 0x00550118
		// (set) Token: 0x060269F9 RID: 158201 RVA: 0x00551F20 File Offset: 0x00550120
		public int DownSpeed { get; set; }

		// Token: 0x1700AB54 RID: 43860
		// (get) Token: 0x060269FA RID: 158202 RVA: 0x00551F29 File Offset: 0x00550129
		// (set) Token: 0x060269FB RID: 158203 RVA: 0x00551F31 File Offset: 0x00550131
		public int RailSplineEntityId { get; set; }

		// Token: 0x1700AB55 RID: 43861
		// (get) Token: 0x060269FC RID: 158204 RVA: 0x00551F3A File Offset: 0x0055013A
		// (set) Token: 0x060269FD RID: 158205 RVA: 0x00551F42 File Offset: 0x00550142
		public List<IExchangeSlideRailConfigT> ExchangeRailConfigs { get; set; }

		// Token: 0x1700AB56 RID: 43862
		// (get) Token: 0x060269FE RID: 158206 RVA: 0x00551F4B File Offset: 0x0055014B
		// (set) Token: 0x060269FF RID: 158207 RVA: 0x00551F53 File Offset: 0x00550153
		public ISlopeSlidePerformT SlidePerformConfig { get; set; }

		// Token: 0x1700AB57 RID: 43863
		// (get) Token: 0x06026A00 RID: 158208 RVA: 0x00551F5C File Offset: 0x0055015C
		// (set) Token: 0x06026A01 RID: 158209 RVA: 0x00551F64 File Offset: 0x00550164
		public byte NullMask { get; set; }

		// Token: 0x06026A02 RID: 158210 RVA: 0x00551F6D File Offset: 0x0055016D
		public ISlidePerformComponentT()
		{
			this.Disabled = false;
			this.SlideSpeed = 0;
			this.UpSpeed = 0;
			this.DownSpeed = 0;
			this.RailSplineEntityId = 0;
			this.ExchangeRailConfigs = null;
			this.SlidePerformConfig = null;
			this.NullMask = 0;
		}
	}
}
