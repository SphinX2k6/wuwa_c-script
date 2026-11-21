using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F31 RID: 24369
	public class ISkyboxTriggerT
	{
		// Token: 0x1700B45D RID: 46173
		// (get) Token: 0x06028ED4 RID: 167636 RVA: 0x0059758E File Offset: 0x0059578E
		// (set) Token: 0x06028ED5 RID: 167637 RVA: 0x00597596 File Offset: 0x00595796
		public ETriggerMode Type { get; set; }

		// Token: 0x06028ED6 RID: 167638 RVA: 0x0059759F File Offset: 0x0059579F
		public ISkyboxTriggerT()
		{
			this.Type = ETriggerMode.Distance;
		}
	}
}
