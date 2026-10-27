using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005339 RID: 21305
	public class IGroupAiModeDefaultT
	{
		// Token: 0x17009C82 RID: 40066
		// (get) Token: 0x06022D6E RID: 142702 RVA: 0x004D3AFE File Offset: 0x004D1CFE
		// (set) Token: 0x06022D6F RID: 142703 RVA: 0x004D3B06 File Offset: 0x004D1D06
		public EGroupAiMode Type { get; set; }

		// Token: 0x06022D70 RID: 142704 RVA: 0x004D3B0F File Offset: 0x004D1D0F
		public IGroupAiModeDefaultT()
		{
			this.Type = EGroupAiMode.Default;
		}
	}
}
