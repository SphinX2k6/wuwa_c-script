using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005645 RID: 22085
	public class INpcRideInGongduolaPerformT
	{
		// Token: 0x1700A39E RID: 41886
		// (get) Token: 0x06024B75 RID: 150389 RVA: 0x00511337 File Offset: 0x0050F537
		// (set) Token: 0x06024B76 RID: 150390 RVA: 0x0051133F File Offset: 0x0050F53F
		public EVehicleType Type { get; set; }

		// Token: 0x1700A39F RID: 41887
		// (get) Token: 0x06024B77 RID: 150391 RVA: 0x00511348 File Offset: 0x0050F548
		// (set) Token: 0x06024B78 RID: 150392 RVA: 0x00511350 File Offset: 0x0050F550
		public string Montage { get; set; }

		// Token: 0x06024B79 RID: 150393 RVA: 0x00511359 File Offset: 0x0050F559
		public INpcRideInGongduolaPerformT()
		{
			this.Type = EVehicleType.Gongduola;
			this.Montage = null;
		}
	}
}
