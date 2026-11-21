using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006125 RID: 24869
	public class IVehicleFeatureT
	{
		// Token: 0x1700B93C RID: 47420
		// (get) Token: 0x0602A308 RID: 172808 RVA: 0x005C222A File Offset: 0x005C042A
		// (set) Token: 0x0602A309 RID: 172809 RVA: 0x005C2232 File Offset: 0x005C0432
		public EVehicleFeatureFlag Type { get; set; }

		// Token: 0x0602A30A RID: 172810 RVA: 0x005C223B File Offset: 0x005C043B
		public IVehicleFeatureT()
		{
			this.Type = EVehicleFeatureFlag.None;
		}
	}
}
