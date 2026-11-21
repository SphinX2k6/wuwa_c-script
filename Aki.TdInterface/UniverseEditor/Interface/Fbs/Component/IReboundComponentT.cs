using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E13 RID: 24083
	public class IReboundComponentT
	{
		// Token: 0x1700B188 RID: 45448
		// (get) Token: 0x0602837B RID: 164731 RVA: 0x005800B3 File Offset: 0x0057E2B3
		// (set) Token: 0x0602837C RID: 164732 RVA: 0x005800BB File Offset: 0x0057E2BB
		public bool Disabled { get; set; }

		// Token: 0x1700B189 RID: 45449
		// (get) Token: 0x0602837D RID: 164733 RVA: 0x005800C4 File Offset: 0x0057E2C4
		// (set) Token: 0x0602837E RID: 164734 RVA: 0x005800CC File Offset: 0x0057E2CC
		public long BulletId { get; set; }

		// Token: 0x1700B18A RID: 45450
		// (get) Token: 0x0602837F RID: 164735 RVA: 0x005800D5 File Offset: 0x0057E2D5
		// (set) Token: 0x06028380 RID: 164736 RVA: 0x005800DD File Offset: 0x0057E2DD
		public IForwardFrontReboundT Option { get; set; }

		// Token: 0x1700B18B RID: 45451
		// (get) Token: 0x06028381 RID: 164737 RVA: 0x005800E6 File Offset: 0x0057E2E6
		// (set) Token: 0x06028382 RID: 164738 RVA: 0x005800EE File Offset: 0x0057E2EE
		public byte NullMask { get; set; }

		// Token: 0x06028383 RID: 164739 RVA: 0x005800F7 File Offset: 0x0057E2F7
		public IReboundComponentT()
		{
			this.Disabled = false;
			this.BulletId = 0L;
			this.Option = null;
			this.NullMask = 0;
		}
	}
}
