using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005642 RID: 22082
	public class INpcRideInAutoGongduolaPerformT
	{
		// Token: 0x1700A399 RID: 41881
		// (get) Token: 0x06024B5D RID: 150365 RVA: 0x00511103 File Offset: 0x0050F303
		// (set) Token: 0x06024B5E RID: 150366 RVA: 0x0051110B File Offset: 0x0050F30B
		public EVehicleType Type { get; set; }

		// Token: 0x1700A39A RID: 41882
		// (get) Token: 0x06024B5F RID: 150367 RVA: 0x00511114 File Offset: 0x0050F314
		// (set) Token: 0x06024B60 RID: 150368 RVA: 0x0051111C File Offset: 0x0050F31C
		public string Montage { get; set; }

		// Token: 0x06024B61 RID: 150369 RVA: 0x00511125 File Offset: 0x0050F325
		public INpcRideInAutoGongduolaPerformT()
		{
			this.Type = EVehicleType.Gongduola;
			this.Montage = null;
		}
	}
}
