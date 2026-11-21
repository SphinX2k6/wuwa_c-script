using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F8B RID: 24459
	public class ISphereFactoryComponentT
	{
		// Token: 0x1700B51C RID: 46364
		// (get) Token: 0x060291F5 RID: 168437 RVA: 0x0059D71F File Offset: 0x0059B91F
		// (set) Token: 0x060291F6 RID: 168438 RVA: 0x0059D727 File Offset: 0x0059B927
		public bool Disabled { get; set; }

		// Token: 0x1700B51D RID: 46365
		// (get) Token: 0x060291F7 RID: 168439 RVA: 0x0059D730 File Offset: 0x0059B930
		// (set) Token: 0x060291F8 RID: 168440 RVA: 0x0059D738 File Offset: 0x0059B938
		public IVectorInfoT SphereLocation { get; set; }

		// Token: 0x1700B51E RID: 46366
		// (get) Token: 0x060291F9 RID: 168441 RVA: 0x0059D741 File Offset: 0x0059B941
		// (set) Token: 0x060291FA RID: 168442 RVA: 0x0059D749 File Offset: 0x0059B949
		public string SphereGuid { get; set; }

		// Token: 0x1700B51F RID: 46367
		// (get) Token: 0x060291FB RID: 168443 RVA: 0x0059D752 File Offset: 0x0059B952
		// (set) Token: 0x060291FC RID: 168444 RVA: 0x0059D75A File Offset: 0x0059B95A
		public byte NullMask { get; set; }

		// Token: 0x060291FD RID: 168445 RVA: 0x0059D763 File Offset: 0x0059B963
		public ISphereFactoryComponentT()
		{
			this.Disabled = false;
			this.SphereLocation = null;
			this.SphereGuid = null;
			this.NullMask = 0;
		}
	}
}
