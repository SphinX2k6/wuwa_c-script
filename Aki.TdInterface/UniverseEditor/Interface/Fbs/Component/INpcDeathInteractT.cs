using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200561E RID: 22046
	public class INpcDeathInteractT
	{
		// Token: 0x1700A31E RID: 41758
		// (get) Token: 0x0602496F RID: 149871 RVA: 0x0050C5D7 File Offset: 0x0050A7D7
		// (set) Token: 0x06024970 RID: 149872 RVA: 0x0050C5DF File Offset: 0x0050A7DF
		public IMontageIdT Montage { get; set; }

		// Token: 0x1700A31F RID: 41759
		// (get) Token: 0x06024971 RID: 149873 RVA: 0x0050C5E8 File Offset: 0x0050A7E8
		// (set) Token: 0x06024972 RID: 149874 RVA: 0x0050C5F0 File Offset: 0x0050A7F0
		public string MaterialDa { get; set; }

		// Token: 0x06024973 RID: 149875 RVA: 0x0050C5F9 File Offset: 0x0050A7F9
		public INpcDeathInteractT()
		{
			this.Montage = null;
			this.MaterialDa = null;
		}
	}
}
