using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058BF RID: 22719
	public class IGroupAiModeDefaultT
	{
		// Token: 0x1700A4BA RID: 42170
		// (get) Token: 0x06024E22 RID: 151074 RVA: 0x005109D2 File Offset: 0x0050EBD2
		// (set) Token: 0x06024E23 RID: 151075 RVA: 0x005109DA File Offset: 0x0050EBDA
		public EGroupAiMode Type { get; set; }

		// Token: 0x06024E24 RID: 151076 RVA: 0x005109E3 File Offset: 0x0050EBE3
		public IGroupAiModeDefaultT()
		{
			this.Type = EGroupAiMode.Default;
		}
	}
}
