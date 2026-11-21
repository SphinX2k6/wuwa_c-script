using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200420F RID: 16911
	public class IDisableHLODT
	{
		// Token: 0x17007330 RID: 29488
		// (get) Token: 0x060177C6 RID: 96198 RVA: 0x0035A8E4 File Offset: 0x00358AE4
		// (set) Token: 0x060177C7 RID: 96199 RVA: 0x0035A8EC File Offset: 0x00358AEC
		public EOperation Type { get; set; }

		// Token: 0x17007331 RID: 29489
		// (get) Token: 0x060177C8 RID: 96200 RVA: 0x0035A8F5 File Offset: 0x00358AF5
		// (set) Token: 0x060177C9 RID: 96201 RVA: 0x0035A8FD File Offset: 0x00358AFD
		public bool IsDisable { get; set; }

		// Token: 0x060177CA RID: 96202 RVA: 0x0035A906 File Offset: 0x00358B06
		public IDisableHLODT()
		{
			this.Type = EOperation.DisableHLOD;
			this.IsDisable = false;
		}
	}
}
