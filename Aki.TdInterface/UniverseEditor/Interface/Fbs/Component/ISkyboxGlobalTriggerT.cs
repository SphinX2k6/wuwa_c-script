using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F2E RID: 24366
	public class ISkyboxGlobalTriggerT
	{
		// Token: 0x1700B45A RID: 46170
		// (get) Token: 0x06028EC2 RID: 167618 RVA: 0x00597416 File Offset: 0x00595616
		// (set) Token: 0x06028EC3 RID: 167619 RVA: 0x0059741E File Offset: 0x0059561E
		public ETriggerMode Type { get; set; }

		// Token: 0x06028EC4 RID: 167620 RVA: 0x00597427 File Offset: 0x00595627
		public ISkyboxGlobalTriggerT()
		{
			this.Type = ETriggerMode.Distance;
		}
	}
}
