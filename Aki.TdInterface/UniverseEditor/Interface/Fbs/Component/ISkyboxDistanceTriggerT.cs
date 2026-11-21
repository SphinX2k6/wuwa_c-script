using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F2B RID: 24363
	public class ISkyboxDistanceTriggerT
	{
		// Token: 0x1700B456 RID: 46166
		// (get) Token: 0x06028EAE RID: 167598 RVA: 0x00597274 File Offset: 0x00595474
		// (set) Token: 0x06028EAF RID: 167599 RVA: 0x0059727C File Offset: 0x0059547C
		public ETriggerMode Type { get; set; }

		// Token: 0x1700B457 RID: 46167
		// (get) Token: 0x06028EB0 RID: 167600 RVA: 0x00597285 File Offset: 0x00595485
		// (set) Token: 0x06028EB1 RID: 167601 RVA: 0x0059728D File Offset: 0x0059548D
		public float Distance { get; set; }

		// Token: 0x06028EB2 RID: 167602 RVA: 0x00597296 File Offset: 0x00595496
		public ISkyboxDistanceTriggerT()
		{
			this.Type = ETriggerMode.Distance;
			this.Distance = 0f;
		}
	}
}
