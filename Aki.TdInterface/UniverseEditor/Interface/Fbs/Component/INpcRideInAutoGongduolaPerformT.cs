using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE0 RID: 23520
	public class INpcRideInAutoGongduolaPerformT
	{
		// Token: 0x1700AC23 RID: 44067
		// (get) Token: 0x06026D7C RID: 159100 RVA: 0x00551A27 File Offset: 0x0054FC27
		// (set) Token: 0x06026D7D RID: 159101 RVA: 0x00551A2F File Offset: 0x0054FC2F
		public EVehicleType Type { get; set; }

		// Token: 0x1700AC24 RID: 44068
		// (get) Token: 0x06026D7E RID: 159102 RVA: 0x00551A38 File Offset: 0x0054FC38
		// (set) Token: 0x06026D7F RID: 159103 RVA: 0x00551A40 File Offset: 0x0054FC40
		public string Montage { get; set; }

		// Token: 0x06026D80 RID: 159104 RVA: 0x00551A49 File Offset: 0x0054FC49
		public INpcRideInAutoGongduolaPerformT()
		{
			this.Type = EVehicleType.Gongduola;
			this.Montage = null;
		}
	}
}
