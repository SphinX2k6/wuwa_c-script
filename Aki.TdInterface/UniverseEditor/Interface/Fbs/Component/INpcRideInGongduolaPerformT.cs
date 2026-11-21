using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE3 RID: 23523
	public class INpcRideInGongduolaPerformT
	{
		// Token: 0x1700AC28 RID: 44072
		// (get) Token: 0x06026D94 RID: 159124 RVA: 0x00551C5B File Offset: 0x0054FE5B
		// (set) Token: 0x06026D95 RID: 159125 RVA: 0x00551C63 File Offset: 0x0054FE63
		public EVehicleType Type { get; set; }

		// Token: 0x1700AC29 RID: 44073
		// (get) Token: 0x06026D96 RID: 159126 RVA: 0x00551C6C File Offset: 0x0054FE6C
		// (set) Token: 0x06026D97 RID: 159127 RVA: 0x00551C74 File Offset: 0x0054FE74
		public string Montage { get; set; }

		// Token: 0x06026D98 RID: 159128 RVA: 0x00551C7D File Offset: 0x0054FE7D
		public INpcRideInGongduolaPerformT()
		{
			this.Type = EVehicleType.Gongduola;
			this.Montage = null;
		}
	}
}
