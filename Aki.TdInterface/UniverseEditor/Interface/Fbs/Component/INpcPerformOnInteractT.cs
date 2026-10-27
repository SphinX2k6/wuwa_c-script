using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005636 RID: 22070
	public class INpcPerformOnInteractT
	{
		// Token: 0x1700A37C RID: 41852
		// (get) Token: 0x06024ADF RID: 150239 RVA: 0x00510185 File Offset: 0x0050E385
		// (set) Token: 0x06024AE0 RID: 150240 RVA: 0x0051018D File Offset: 0x0050E38D
		public string Montage { get; set; }

		// Token: 0x1700A37D RID: 41853
		// (get) Token: 0x06024AE1 RID: 150241 RVA: 0x00510196 File Offset: 0x0050E396
		// (set) Token: 0x06024AE2 RID: 150242 RVA: 0x0051019E File Offset: 0x0050E39E
		public bool NotInterruptMontageWhenFinishedInteract { get; set; }

		// Token: 0x1700A37E RID: 41854
		// (get) Token: 0x06024AE3 RID: 150243 RVA: 0x005101A7 File Offset: 0x0050E3A7
		// (set) Token: 0x06024AE4 RID: 150244 RVA: 0x005101AF File Offset: 0x0050E3AF
		public byte NullMask { get; set; }

		// Token: 0x06024AE5 RID: 150245 RVA: 0x005101B8 File Offset: 0x0050E3B8
		public INpcPerformOnInteractT()
		{
			this.Montage = null;
			this.NotInterruptMontageWhenFinishedInteract = false;
			this.NullMask = 0;
		}
	}
}
