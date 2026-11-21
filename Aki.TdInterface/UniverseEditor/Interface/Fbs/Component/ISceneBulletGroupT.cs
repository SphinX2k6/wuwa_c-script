using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EB4 RID: 24244
	public class ISceneBulletGroupT
	{
		// Token: 0x1700B31E RID: 45854
		// (get) Token: 0x06028A04 RID: 166404 RVA: 0x0058DFBB File Offset: 0x0058C1BB
		// (set) Token: 0x06028A05 RID: 166405 RVA: 0x0058DFC3 File Offset: 0x0058C1C3
		public string EntityState { get; set; }

		// Token: 0x1700B31F RID: 45855
		// (get) Token: 0x06028A06 RID: 166406 RVA: 0x0058DFCC File Offset: 0x0058C1CC
		// (set) Token: 0x06028A07 RID: 166407 RVA: 0x0058DFD4 File Offset: 0x0058C1D4
		public long BulletId { get; set; }

		// Token: 0x1700B320 RID: 45856
		// (get) Token: 0x06028A08 RID: 166408 RVA: 0x0058DFDD File Offset: 0x0058C1DD
		// (set) Token: 0x06028A09 RID: 166409 RVA: 0x0058DFE5 File Offset: 0x0058C1E5
		public IVectorInfoT Range { get; set; }

		// Token: 0x1700B321 RID: 45857
		// (get) Token: 0x06028A0A RID: 166410 RVA: 0x0058DFEE File Offset: 0x0058C1EE
		// (set) Token: 0x06028A0B RID: 166411 RVA: 0x0058DFF6 File Offset: 0x0058C1F6
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700B322 RID: 45858
		// (get) Token: 0x06028A0C RID: 166412 RVA: 0x0058DFFF File Offset: 0x0058C1FF
		// (set) Token: 0x06028A0D RID: 166413 RVA: 0x0058E007 File Offset: 0x0058C207
		public ITrafficBulletLogicT CustomBulletLogic { get; set; }

		// Token: 0x06028A0E RID: 166414 RVA: 0x0058E010 File Offset: 0x0058C210
		public ISceneBulletGroupT()
		{
			this.EntityState = null;
			this.BulletId = 0L;
			this.Range = null;
			this.Offset = null;
			this.CustomBulletLogic = null;
		}
	}
}
