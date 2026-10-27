using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B2A RID: 23338
	public class IVehicleTypedConfigT
	{
		// Token: 0x1700B02C RID: 45100
		// (get) Token: 0x06027E3A RID: 163386 RVA: 0x0057C472 File Offset: 0x0057A672
		// (set) Token: 0x06027E3B RID: 163387 RVA: 0x0057C47A File Offset: 0x0057A67A
		public EVehicleType Type { get; set; }

		// Token: 0x06027E3C RID: 163388 RVA: 0x0057C483 File Offset: 0x0057A683
		public IVehicleTypedConfigT()
		{
			this.Type = EVehicleType.Gongduola;
		}
	}
}
