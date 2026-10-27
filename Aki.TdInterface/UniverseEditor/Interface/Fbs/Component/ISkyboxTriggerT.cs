using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005924 RID: 22820
	public class ISkyboxTriggerT
	{
		// Token: 0x1700AB29 RID: 43817
		// (get) Token: 0x0602696A RID: 158058 RVA: 0x00550922 File Offset: 0x0054EB22
		// (set) Token: 0x0602696B RID: 158059 RVA: 0x0055092A File Offset: 0x0054EB2A
		public ETriggerMode Type { get; set; }

		// Token: 0x0602696C RID: 158060 RVA: 0x00550933 File Offset: 0x0054EB33
		public ISkyboxTriggerT()
		{
			this.Type = ETriggerMode.Distance;
		}
	}
}
