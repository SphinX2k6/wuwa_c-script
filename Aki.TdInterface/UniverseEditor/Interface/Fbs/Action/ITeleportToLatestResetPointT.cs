using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200738C RID: 29580
	public class ITeleportToLatestResetPointT
	{
		// Token: 0x1700E091 RID: 57489
		// (get) Token: 0x06035B1B RID: 219931 RVA: 0x0074F77D File Offset: 0x0074D97D
		// (set) Token: 0x06035B1C RID: 219932 RVA: 0x0074F785 File Offset: 0x0074D985
		public ITeleportToLatestResetPointDirectlyT Option { get; set; }

		// Token: 0x06035B1D RID: 219933 RVA: 0x0074F78E File Offset: 0x0074D98E
		public ITeleportToLatestResetPointT()
		{
			this.Option = null;
		}
	}
}
