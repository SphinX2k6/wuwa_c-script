using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBC RID: 23484
	public class INpcDeathInteractT
	{
		// Token: 0x1700ABA6 RID: 43942
		// (get) Token: 0x06026B7F RID: 158591 RVA: 0x0054CBEF File Offset: 0x0054ADEF
		// (set) Token: 0x06026B80 RID: 158592 RVA: 0x0054CBF7 File Offset: 0x0054ADF7
		public IMontageIdT Montage { get; set; }

		// Token: 0x1700ABA7 RID: 43943
		// (get) Token: 0x06026B81 RID: 158593 RVA: 0x0054CC00 File Offset: 0x0054AE00
		// (set) Token: 0x06026B82 RID: 158594 RVA: 0x0054CC08 File Offset: 0x0054AE08
		public string MaterialDa { get; set; }

		// Token: 0x06026B83 RID: 158595 RVA: 0x0054CC11 File Offset: 0x0054AE11
		public INpcDeathInteractT()
		{
			this.Montage = null;
			this.MaterialDa = null;
		}
	}
}
