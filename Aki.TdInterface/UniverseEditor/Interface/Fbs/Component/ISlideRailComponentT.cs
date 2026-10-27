using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005936 RID: 22838
	public class ISlideRailComponentT
	{
		// Token: 0x1700AB65 RID: 43877
		// (get) Token: 0x06026A42 RID: 158274 RVA: 0x0055281D File Offset: 0x00550A1D
		// (set) Token: 0x06026A43 RID: 158275 RVA: 0x00552825 File Offset: 0x00550A25
		public bool Disabled { get; set; }

		// Token: 0x1700AB66 RID: 43878
		// (get) Token: 0x06026A44 RID: 158276 RVA: 0x0055282E File Offset: 0x00550A2E
		// (set) Token: 0x06026A45 RID: 158277 RVA: 0x00552836 File Offset: 0x00550A36
		public int SlideSpeed { get; set; }

		// Token: 0x1700AB67 RID: 43879
		// (get) Token: 0x06026A46 RID: 158278 RVA: 0x0055283F File Offset: 0x00550A3F
		// (set) Token: 0x06026A47 RID: 158279 RVA: 0x00552847 File Offset: 0x00550A47
		public int UpSpeed { get; set; }

		// Token: 0x1700AB68 RID: 43880
		// (get) Token: 0x06026A48 RID: 158280 RVA: 0x00552850 File Offset: 0x00550A50
		// (set) Token: 0x06026A49 RID: 158281 RVA: 0x00552858 File Offset: 0x00550A58
		public int DownSpeed { get; set; }

		// Token: 0x1700AB69 RID: 43881
		// (get) Token: 0x06026A4A RID: 158282 RVA: 0x00552861 File Offset: 0x00550A61
		// (set) Token: 0x06026A4B RID: 158283 RVA: 0x00552869 File Offset: 0x00550A69
		public int RailSplineEntityId { get; set; }

		// Token: 0x1700AB6A RID: 43882
		// (get) Token: 0x06026A4C RID: 158284 RVA: 0x00552872 File Offset: 0x00550A72
		// (set) Token: 0x06026A4D RID: 158285 RVA: 0x0055287A File Offset: 0x00550A7A
		public List<IExchangeSlideRailConfigT> ExchangeRailConfigs { get; set; }

		// Token: 0x1700AB6B RID: 43883
		// (get) Token: 0x06026A4E RID: 158286 RVA: 0x00552883 File Offset: 0x00550A83
		// (set) Token: 0x06026A4F RID: 158287 RVA: 0x0055288B File Offset: 0x00550A8B
		public byte NullMask { get; set; }

		// Token: 0x06026A50 RID: 158288 RVA: 0x00552894 File Offset: 0x00550A94
		public ISlideRailComponentT()
		{
			this.Disabled = false;
			this.SlideSpeed = 0;
			this.UpSpeed = 0;
			this.DownSpeed = 0;
			this.RailSplineEntityId = 0;
			this.ExchangeRailConfigs = null;
			this.NullMask = 0;
		}
	}
}
