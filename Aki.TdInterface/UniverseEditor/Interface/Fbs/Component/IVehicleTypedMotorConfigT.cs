using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B30 RID: 23344
	public class IVehicleTypedMotorConfigT
	{
		// Token: 0x1700B033 RID: 45107
		// (get) Token: 0x06027E5C RID: 163420 RVA: 0x0057C7A6 File Offset: 0x0057A9A6
		// (set) Token: 0x06027E5D RID: 163421 RVA: 0x0057C7AE File Offset: 0x0057A9AE
		public EVehicleType Type { get; set; }

		// Token: 0x1700B034 RID: 45108
		// (get) Token: 0x06027E5E RID: 163422 RVA: 0x0057C7B7 File Offset: 0x0057A9B7
		// (set) Token: 0x06027E5F RID: 163423 RVA: 0x0057C7BF File Offset: 0x0057A9BF
		public int TrialAttributeId { get; set; }

		// Token: 0x1700B035 RID: 45109
		// (get) Token: 0x06027E60 RID: 163424 RVA: 0x0057C7C8 File Offset: 0x0057A9C8
		// (set) Token: 0x06027E61 RID: 163425 RVA: 0x0057C7D0 File Offset: 0x0057A9D0
		public byte NullMask { get; set; }

		// Token: 0x06027E62 RID: 163426 RVA: 0x0057C7D9 File Offset: 0x0057A9D9
		public IVehicleTypedMotorConfigT()
		{
			this.Type = EVehicleType.Gongduola;
			this.TrialAttributeId = 0;
			this.NullMask = 0;
		}
	}
}
