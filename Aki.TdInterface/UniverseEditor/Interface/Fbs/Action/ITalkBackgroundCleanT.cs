using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A6B RID: 31339
	public class ITalkBackgroundCleanT
	{
		// Token: 0x1700E58B RID: 58763
		// (get) Token: 0x060373B7 RID: 226231 RVA: 0x007606F2 File Offset: 0x0075E8F2
		// (set) Token: 0x060373B8 RID: 226232 RVA: 0x007606FA File Offset: 0x0075E8FA
		public ETalkBackgroundType Type { get; set; }

		// Token: 0x060373B9 RID: 226233 RVA: 0x00760703 File Offset: 0x0075E903
		public ITalkBackgroundCleanT()
		{
			this.Type = ETalkBackgroundType.Clean;
		}
	}
}
