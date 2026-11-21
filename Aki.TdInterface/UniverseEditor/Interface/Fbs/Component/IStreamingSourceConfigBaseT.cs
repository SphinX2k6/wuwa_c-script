using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FE5 RID: 24549
	public class IStreamingSourceConfigBaseT
	{
		// Token: 0x1700B608 RID: 46600
		// (get) Token: 0x060295CC RID: 169420 RVA: 0x005A585A File Offset: 0x005A3A5A
		// (set) Token: 0x060295CD RID: 169421 RVA: 0x005A5862 File Offset: 0x005A3A62
		public EStreamingSourceMode Type { get; set; }

		// Token: 0x060295CE RID: 169422 RVA: 0x005A586B File Offset: 0x005A3A6B
		public IStreamingSourceConfigBaseT()
		{
			this.Type = EStreamingSourceMode.Fixed;
		}
	}
}
